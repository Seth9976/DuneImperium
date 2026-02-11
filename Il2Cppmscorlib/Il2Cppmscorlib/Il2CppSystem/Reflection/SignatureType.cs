using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Globalization;

namespace Il2CppSystem.Reflection
{
	// Token: 0x0200042C RID: 1068
	public class SignatureType : Type
	{
		// Token: 0x06003D42 RID: 15682 RVA: 0x00125718 File Offset: 0x00123918
		// Note: this type is marked as 'beforefieldinit'.
		static SignatureType()
		{
			Il2CppClassPointerStore<SignatureType>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Reflection", "SignatureType");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SignatureType>.NativeClassPtr);
			SignatureType.NativeMethodInfoPtr_get_IsSignatureType_Public_Virtual_Final_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignatureType>.NativeClassPtr, 100672465);
			SignatureType.NativeMethodInfoPtr_HasElementTypeImpl_Protected_Abstract_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignatureType>.NativeClassPtr, 100672466);
			SignatureType.NativeMethodInfoPtr_IsArrayImpl_Protected_Abstract_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignatureType>.NativeClassPtr, 100672467);
			SignatureType.NativeMethodInfoPtr_get_IsSZArray_Public_Abstract_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignatureType>.NativeClassPtr, 100672468);
			SignatureType.NativeMethodInfoPtr_get_IsVariableBoundArray_Public_Abstract_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignatureType>.NativeClassPtr, 100672469);
			SignatureType.NativeMethodInfoPtr_IsByRefImpl_Protected_Abstract_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignatureType>.NativeClassPtr, 100672470);
			SignatureType.NativeMethodInfoPtr_IsPointerImpl_Protected_Abstract_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignatureType>.NativeClassPtr, 100672471);
			SignatureType.NativeMethodInfoPtr_get_IsGenericType_Public_Virtual_Final_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignatureType>.NativeClassPtr, 100672472);
			SignatureType.NativeMethodInfoPtr_get_IsGenericTypeDefinition_Public_Abstract_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignatureType>.NativeClassPtr, 100672473);
			SignatureType.NativeMethodInfoPtr_get_IsConstructedGenericType_Public_Abstract_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignatureType>.NativeClassPtr, 100672474);
			SignatureType.NativeMethodInfoPtr_get_IsGenericParameter_Public_Abstract_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignatureType>.NativeClassPtr, 100672475);
			SignatureType.NativeMethodInfoPtr_get_IsGenericMethodParameter_Public_Abstract_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignatureType>.NativeClassPtr, 100672476);
			SignatureType.NativeMethodInfoPtr_get_ContainsGenericParameters_Public_Abstract_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignatureType>.NativeClassPtr, 100672477);
			SignatureType.NativeMethodInfoPtr_get_MemberType_Public_Virtual_Final_get_MemberTypes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignatureType>.NativeClassPtr, 100672478);
			SignatureType.NativeMethodInfoPtr_MakeArrayType_Public_Virtual_Final_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignatureType>.NativeClassPtr, 100672479);
			SignatureType.NativeMethodInfoPtr_MakeArrayType_Public_Virtual_Final_Type_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignatureType>.NativeClassPtr, 100672480);
			SignatureType.NativeMethodInfoPtr_MakeByRefType_Public_Virtual_Final_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignatureType>.NativeClassPtr, 100672481);
			SignatureType.NativeMethodInfoPtr_MakePointerType_Public_Virtual_Final_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignatureType>.NativeClassPtr, 100672482);
			SignatureType.NativeMethodInfoPtr_MakeGenericType_Public_Virtual_Final_Type_Il2CppReferenceArray_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignatureType>.NativeClassPtr, 100672483);
			SignatureType.NativeMethodInfoPtr_GetElementType_Public_Virtual_Final_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignatureType>.NativeClassPtr, 100672484);
			SignatureType.NativeMethodInfoPtr_GetArrayRank_Public_Abstract_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignatureType>.NativeClassPtr, 100672485);
			SignatureType.NativeMethodInfoPtr_GetGenericTypeDefinition_Public_Abstract_Virtual_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignatureType>.NativeClassPtr, 100672486);
			SignatureType.NativeMethodInfoPtr_get_GenericTypeArguments_Public_Abstract_Virtual_get_Il2CppReferenceArray_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignatureType>.NativeClassPtr, 100672487);
			SignatureType.NativeMethodInfoPtr_GetGenericArguments_Public_Abstract_Virtual_Il2CppReferenceArray_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignatureType>.NativeClassPtr, 100672488);
			SignatureType.NativeMethodInfoPtr_get_GenericParameterPosition_Public_Abstract_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignatureType>.NativeClassPtr, 100672489);
			SignatureType.NativeMethodInfoPtr_get_ElementType_Internal_Abstract_Virtual_New_get_SignatureType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignatureType>.NativeClassPtr, 100672490);
			SignatureType.NativeMethodInfoPtr_get_UnderlyingSystemType_Public_Virtual_Final_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignatureType>.NativeClassPtr, 100672491);
			SignatureType.NativeMethodInfoPtr_get_Name_Public_Abstract_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignatureType>.NativeClassPtr, 100672492);
			SignatureType.NativeMethodInfoPtr_get_Namespace_Public_Abstract_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignatureType>.NativeClassPtr, 100672493);
			SignatureType.NativeMethodInfoPtr_get_FullName_Public_Virtual_Final_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignatureType>.NativeClassPtr, 100672494);
			SignatureType.NativeMethodInfoPtr_get_AssemblyQualifiedName_Public_Virtual_Final_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignatureType>.NativeClassPtr, 100672495);
			SignatureType.NativeMethodInfoPtr_ToString_Public_Abstract_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignatureType>.NativeClassPtr, 100672496);
			SignatureType.NativeMethodInfoPtr_get_Assembly_Public_Virtual_Final_get_Assembly_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignatureType>.NativeClassPtr, 100672497);
			SignatureType.NativeMethodInfoPtr_get_Module_Public_Virtual_Final_get_Module_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignatureType>.NativeClassPtr, 100672498);
			SignatureType.NativeMethodInfoPtr_get_ReflectedType_Public_Virtual_Final_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignatureType>.NativeClassPtr, 100672499);
			SignatureType.NativeMethodInfoPtr_get_BaseType_Public_Virtual_Final_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignatureType>.NativeClassPtr, 100672500);
			SignatureType.NativeMethodInfoPtr_GetInterfaces_Public_Virtual_Final_Il2CppReferenceArray_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignatureType>.NativeClassPtr, 100672501);
			SignatureType.NativeMethodInfoPtr_IsAssignableFrom_Public_Virtual_Final_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignatureType>.NativeClassPtr, 100672502);
			SignatureType.NativeMethodInfoPtr_get_MetadataToken_Public_Virtual_Final_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignatureType>.NativeClassPtr, 100672503);
			SignatureType.NativeMethodInfoPtr_get_DeclaringType_Public_Virtual_Final_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignatureType>.NativeClassPtr, 100672504);
			SignatureType.NativeMethodInfoPtr_get_DeclaringMethod_Public_Virtual_Final_get_MethodBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignatureType>.NativeClassPtr, 100672505);
			SignatureType.NativeMethodInfoPtr_GetGenericParameterConstraints_Public_Virtual_Final_Il2CppReferenceArray_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignatureType>.NativeClassPtr, 100672506);
			SignatureType.NativeMethodInfoPtr_get_GenericParameterAttributes_Public_Virtual_Final_get_GenericParameterAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignatureType>.NativeClassPtr, 100672507);
			SignatureType.NativeMethodInfoPtr_IsEnumDefined_Public_Virtual_Final_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignatureType>.NativeClassPtr, 100672508);
			SignatureType.NativeMethodInfoPtr_GetEnumName_Public_Virtual_Final_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignatureType>.NativeClassPtr, 100672509);
			SignatureType.NativeMethodInfoPtr_GetEnumNames_Public_Virtual_Final_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignatureType>.NativeClassPtr, 100672510);
			SignatureType.NativeMethodInfoPtr_GetEnumUnderlyingType_Public_Virtual_Final_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignatureType>.NativeClassPtr, 100672511);
			SignatureType.NativeMethodInfoPtr_GetEnumValues_Public_Virtual_Final_Array_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignatureType>.NativeClassPtr, 100672512);
			SignatureType.NativeMethodInfoPtr_get_GUID_Public_Virtual_Final_get_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignatureType>.NativeClassPtr, 100672513);
			SignatureType.NativeMethodInfoPtr_GetTypeCodeImpl_Protected_Virtual_Final_TypeCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignatureType>.NativeClassPtr, 100672514);
			SignatureType.NativeMethodInfoPtr_GetAttributeFlagsImpl_Protected_Virtual_Final_TypeAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignatureType>.NativeClassPtr, 100672515);
			SignatureType.NativeMethodInfoPtr_GetConstructors_Public_Virtual_Final_Il2CppReferenceArray_1_ConstructorInfo_BindingFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignatureType>.NativeClassPtr, 100672516);
			SignatureType.NativeMethodInfoPtr_GetEvent_Public_Virtual_Final_EventInfo_String_BindingFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignatureType>.NativeClassPtr, 100672517);
			SignatureType.NativeMethodInfoPtr_GetEvents_Public_Virtual_Final_Il2CppReferenceArray_1_EventInfo_BindingFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignatureType>.NativeClassPtr, 100672518);
			SignatureType.NativeMethodInfoPtr_GetField_Public_Virtual_Final_FieldInfo_String_BindingFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignatureType>.NativeClassPtr, 100672519);
			SignatureType.NativeMethodInfoPtr_GetFields_Public_Virtual_Final_Il2CppReferenceArray_1_FieldInfo_BindingFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignatureType>.NativeClassPtr, 100672520);
			SignatureType.NativeMethodInfoPtr_GetMembers_Public_Virtual_Final_Il2CppReferenceArray_1_MemberInfo_BindingFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignatureType>.NativeClassPtr, 100672521);
			SignatureType.NativeMethodInfoPtr_GetMethods_Public_Virtual_Final_Il2CppReferenceArray_1_MethodInfo_BindingFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignatureType>.NativeClassPtr, 100672522);
			SignatureType.NativeMethodInfoPtr_GetNestedType_Public_Virtual_Final_Type_String_BindingFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignatureType>.NativeClassPtr, 100672523);
			SignatureType.NativeMethodInfoPtr_GetProperties_Public_Virtual_Final_Il2CppReferenceArray_1_PropertyInfo_BindingFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignatureType>.NativeClassPtr, 100672524);
			SignatureType.NativeMethodInfoPtr_InvokeMember_Public_Virtual_Final_Object_String_BindingFlags_Binder_Object_Il2CppReferenceArray_1_Object_Il2CppReferenceArray_1_ParameterModifier_CultureInfo_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignatureType>.NativeClassPtr, 100672525);
			SignatureType.NativeMethodInfoPtr_GetMethodImpl_Protected_Virtual_Final_MethodInfo_String_BindingFlags_Binder_CallingConventions_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_ParameterModifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignatureType>.NativeClassPtr, 100672526);
			SignatureType.NativeMethodInfoPtr_GetPropertyImpl_Protected_Virtual_Final_PropertyInfo_String_BindingFlags_Binder_Type_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_ParameterModifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignatureType>.NativeClassPtr, 100672527);
			SignatureType.NativeMethodInfoPtr_GetMember_Public_Virtual_Final_Il2CppReferenceArray_1_MemberInfo_String_BindingFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignatureType>.NativeClassPtr, 100672528);
			SignatureType.NativeMethodInfoPtr_GetMember_Public_Virtual_Final_Il2CppReferenceArray_1_MemberInfo_String_MemberTypes_BindingFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignatureType>.NativeClassPtr, 100672529);
			SignatureType.NativeMethodInfoPtr_GetCustomAttributes_Public_Virtual_Final_Il2CppReferenceArray_1_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignatureType>.NativeClassPtr, 100672530);
			SignatureType.NativeMethodInfoPtr_GetCustomAttributes_Public_Virtual_Final_Il2CppReferenceArray_1_Object_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignatureType>.NativeClassPtr, 100672531);
			SignatureType.NativeMethodInfoPtr_IsDefined_Public_Virtual_Final_Boolean_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignatureType>.NativeClassPtr, 100672532);
			SignatureType.NativeMethodInfoPtr_GetCustomAttributesData_Public_Virtual_Final_IList_1_CustomAttributeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignatureType>.NativeClassPtr, 100672533);
			SignatureType.NativeMethodInfoPtr_GetInterface_Public_Virtual_Final_Type_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignatureType>.NativeClassPtr, 100672534);
			SignatureType.NativeMethodInfoPtr_GetConstructorImpl_Protected_Virtual_Final_ConstructorInfo_BindingFlags_Binder_CallingConventions_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_ParameterModifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignatureType>.NativeClassPtr, 100672535);
			SignatureType.NativeMethodInfoPtr_IsCOMObjectImpl_Protected_Virtual_Final_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignatureType>.NativeClassPtr, 100672536);
			SignatureType.NativeMethodInfoPtr_IsPrimitiveImpl_Protected_Virtual_Final_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignatureType>.NativeClassPtr, 100672537);
			SignatureType.NativeMethodInfoPtr_IsContextfulImpl_Protected_Virtual_Final_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignatureType>.NativeClassPtr, 100672538);
			SignatureType.NativeMethodInfoPtr_get_IsEnum_Public_Virtual_Final_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignatureType>.NativeClassPtr, 100672539);
			SignatureType.NativeMethodInfoPtr_IsEquivalentTo_Public_Virtual_Final_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignatureType>.NativeClassPtr, 100672540);
			SignatureType.NativeMethodInfoPtr_IsInstanceOfType_Public_Virtual_Final_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignatureType>.NativeClassPtr, 100672541);
			SignatureType.NativeMethodInfoPtr_IsMarshalByRefImpl_Protected_Virtual_Final_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignatureType>.NativeClassPtr, 100672542);
			SignatureType.NativeMethodInfoPtr_get_IsSerializable_Public_Virtual_Final_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignatureType>.NativeClassPtr, 100672543);
			SignatureType.NativeMethodInfoPtr_IsSubclassOf_Public_Virtual_Final_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignatureType>.NativeClassPtr, 100672544);
			SignatureType.NativeMethodInfoPtr_IsValueTypeImpl_Protected_Virtual_Final_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignatureType>.NativeClassPtr, 100672545);
			SignatureType.NativeMethodInfoPtr_get_TypeHandle_Public_Virtual_Final_get_RuntimeTypeHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignatureType>.NativeClassPtr, 100672546);
			SignatureType.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignatureType>.NativeClassPtr, 100672547);
		}

		// Token: 0x17000E6A RID: 3690
		// (get) Token: 0x06003D43 RID: 15683 RVA: 0x00125DC4 File Offset: 0x00123FC4
		public unsafe override bool IsSignatureType
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignatureType.NativeMethodInfoPtr_get_IsSignatureType_Public_Virtual_Final_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003D44 RID: 15684 RVA: 0x00125E00 File Offset: 0x00124000
		[CallerCount(0)]
		public unsafe override bool HasElementTypeImpl()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SignatureType.NativeMethodInfoPtr_HasElementTypeImpl_Protected_Abstract_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003D45 RID: 15685 RVA: 0x00125E48 File Offset: 0x00124048
		[CallerCount(0)]
		public unsafe override bool IsArrayImpl()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SignatureType.NativeMethodInfoPtr_IsArrayImpl_Protected_Abstract_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000E6B RID: 3691
		// (get) Token: 0x06003D46 RID: 15686 RVA: 0x00125E90 File Offset: 0x00124090
		public unsafe override bool IsSZArray
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SignatureType.NativeMethodInfoPtr_get_IsSZArray_Public_Abstract_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000E6C RID: 3692
		// (get) Token: 0x06003D47 RID: 15687 RVA: 0x00125ED8 File Offset: 0x001240D8
		public unsafe override bool IsVariableBoundArray
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SignatureType.NativeMethodInfoPtr_get_IsVariableBoundArray_Public_Abstract_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003D48 RID: 15688 RVA: 0x00125F20 File Offset: 0x00124120
		[CallerCount(0)]
		public unsafe override bool IsByRefImpl()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SignatureType.NativeMethodInfoPtr_IsByRefImpl_Protected_Abstract_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003D49 RID: 15689 RVA: 0x00125F68 File Offset: 0x00124168
		[CallerCount(0)]
		public unsafe override bool IsPointerImpl()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SignatureType.NativeMethodInfoPtr_IsPointerImpl_Protected_Abstract_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000E6D RID: 3693
		// (get) Token: 0x06003D4A RID: 15690 RVA: 0x00125FB0 File Offset: 0x001241B0
		public unsafe override bool IsGenericType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignatureType.NativeMethodInfoPtr_get_IsGenericType_Public_Virtual_Final_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000E6E RID: 3694
		// (get) Token: 0x06003D4B RID: 15691 RVA: 0x00125FEC File Offset: 0x001241EC
		public unsafe override bool IsGenericTypeDefinition
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SignatureType.NativeMethodInfoPtr_get_IsGenericTypeDefinition_Public_Abstract_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000E6F RID: 3695
		// (get) Token: 0x06003D4C RID: 15692 RVA: 0x00126034 File Offset: 0x00124234
		public unsafe override bool IsConstructedGenericType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SignatureType.NativeMethodInfoPtr_get_IsConstructedGenericType_Public_Abstract_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000E70 RID: 3696
		// (get) Token: 0x06003D4D RID: 15693 RVA: 0x0012607C File Offset: 0x0012427C
		public unsafe override bool IsGenericParameter
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SignatureType.NativeMethodInfoPtr_get_IsGenericParameter_Public_Abstract_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000E71 RID: 3697
		// (get) Token: 0x06003D4E RID: 15694 RVA: 0x001260C4 File Offset: 0x001242C4
		public unsafe override bool IsGenericMethodParameter
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SignatureType.NativeMethodInfoPtr_get_IsGenericMethodParameter_Public_Abstract_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000E72 RID: 3698
		// (get) Token: 0x06003D4F RID: 15695 RVA: 0x0012610C File Offset: 0x0012430C
		public unsafe override bool ContainsGenericParameters
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SignatureType.NativeMethodInfoPtr_get_ContainsGenericParameters_Public_Abstract_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000E73 RID: 3699
		// (get) Token: 0x06003D50 RID: 15696 RVA: 0x00126154 File Offset: 0x00124354
		public unsafe override MemberTypes MemberType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignatureType.NativeMethodInfoPtr_get_MemberType_Public_Virtual_Final_get_MemberTypes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003D51 RID: 15697 RVA: 0x00126190 File Offset: 0x00124390
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1399235, XrefRangeEnd = 1399239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Type MakeArrayType()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignatureType.NativeMethodInfoPtr_MakeArrayType_Public_Virtual_Final_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
		}

		// Token: 0x06003D52 RID: 15698 RVA: 0x001261D0 File Offset: 0x001243D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1399239, XrefRangeEnd = 1399243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Type MakeArrayType(int rank)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref rank;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignatureType.NativeMethodInfoPtr_MakeArrayType_Public_Virtual_Final_Type_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x06003D53 RID: 15699 RVA: 0x0012621C File Offset: 0x0012441C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1399243, XrefRangeEnd = 1399251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Type MakeByRefType()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignatureType.NativeMethodInfoPtr_MakeByRefType_Public_Virtual_Final_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
		}

		// Token: 0x06003D54 RID: 15700 RVA: 0x0012625C File Offset: 0x0012445C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1399251, XrefRangeEnd = 1399259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Type MakePointerType()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignatureType.NativeMethodInfoPtr_MakePointerType_Public_Virtual_Final_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
		}

		// Token: 0x06003D55 RID: 15701 RVA: 0x0012629C File Offset: 0x0012449C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1399259, XrefRangeEnd = 1399265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Type MakeGenericType([Optional] Il2CppReferenceArray<Type> typeArguments)
		{
			if (typeArguments == null)
			{
				typeArguments = new Il2CppReferenceArray<Type>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(typeArguments);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignatureType.NativeMethodInfoPtr_MakeGenericType_Public_Virtual_Final_Type_Il2CppReferenceArray_1_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x06003D56 RID: 15702 RVA: 0x001262FC File Offset: 0x001244FC
		[CallerCount(0)]
		public unsafe override Type GetElementType()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignatureType.NativeMethodInfoPtr_GetElementType_Public_Virtual_Final_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
		}

		// Token: 0x06003D57 RID: 15703 RVA: 0x0012633C File Offset: 0x0012453C
		[CallerCount(0)]
		public unsafe override int GetArrayRank()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SignatureType.NativeMethodInfoPtr_GetArrayRank_Public_Abstract_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003D58 RID: 15704 RVA: 0x00126384 File Offset: 0x00124584
		[CallerCount(0)]
		public unsafe override Type GetGenericTypeDefinition()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SignatureType.NativeMethodInfoPtr_GetGenericTypeDefinition_Public_Abstract_Virtual_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
		}

		// Token: 0x17000E74 RID: 3700
		// (get) Token: 0x06003D59 RID: 15705 RVA: 0x001263D0 File Offset: 0x001245D0
		public unsafe override Il2CppReferenceArray<Type> GenericTypeArguments
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SignatureType.NativeMethodInfoPtr_get_GenericTypeArguments_Public_Abstract_Virtual_get_Il2CppReferenceArray_1_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Type>>(intPtr3) : null;
			}
		}

		// Token: 0x06003D5A RID: 15706 RVA: 0x0012641C File Offset: 0x0012461C
		[CallerCount(0)]
		public unsafe override Il2CppReferenceArray<Type> GetGenericArguments()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SignatureType.NativeMethodInfoPtr_GetGenericArguments_Public_Abstract_Virtual_Il2CppReferenceArray_1_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Type>>(intPtr3) : null;
		}

		// Token: 0x17000E75 RID: 3701
		// (get) Token: 0x06003D5B RID: 15707 RVA: 0x00126468 File Offset: 0x00124668
		public unsafe override int GenericParameterPosition
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SignatureType.NativeMethodInfoPtr_get_GenericParameterPosition_Public_Abstract_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000E76 RID: 3702
		// (get) Token: 0x06003D5C RID: 15708 RVA: 0x001264B0 File Offset: 0x001246B0
		public unsafe virtual SignatureType ElementType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SignatureType.NativeMethodInfoPtr_get_ElementType_Internal_Abstract_Virtual_New_get_SignatureType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SignatureType>(intPtr3) : null;
			}
		}

		// Token: 0x17000E77 RID: 3703
		// (get) Token: 0x06003D5D RID: 15709 RVA: 0x001264FC File Offset: 0x001246FC
		public unsafe override Type UnderlyingSystemType
		{
			[CallerCount(1295)]
			[CachedScanResults(RefRangeStart = 308780, RefRangeEnd = 310075, XrefRangeStart = 308780, XrefRangeEnd = 310075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignatureType.NativeMethodInfoPtr_get_UnderlyingSystemType_Public_Virtual_Final_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x17000E78 RID: 3704
		// (get) Token: 0x06003D5E RID: 15710 RVA: 0x0012653C File Offset: 0x0012473C
		public unsafe override string Name
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SignatureType.NativeMethodInfoPtr_get_Name_Public_Abstract_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000E79 RID: 3705
		// (get) Token: 0x06003D5F RID: 15711 RVA: 0x00126580 File Offset: 0x00124780
		public unsafe override string Namespace
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SignatureType.NativeMethodInfoPtr_get_Namespace_Public_Abstract_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000E7A RID: 3706
		// (get) Token: 0x06003D60 RID: 15712 RVA: 0x001265C4 File Offset: 0x001247C4
		public unsafe override string FullName
		{
			[CallerCount(74)]
			[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignatureType.NativeMethodInfoPtr_get_FullName_Public_Virtual_Final_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000E7B RID: 3707
		// (get) Token: 0x06003D61 RID: 15713 RVA: 0x001265FC File Offset: 0x001247FC
		public unsafe override string AssemblyQualifiedName
		{
			[CallerCount(74)]
			[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignatureType.NativeMethodInfoPtr_get_AssemblyQualifiedName_Public_Virtual_Final_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06003D62 RID: 15714 RVA: 0x00126634 File Offset: 0x00124834
		[CallerCount(0)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SignatureType.NativeMethodInfoPtr_ToString_Public_Abstract_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x17000E7C RID: 3708
		// (get) Token: 0x06003D63 RID: 15715 RVA: 0x00126678 File Offset: 0x00124878
		public unsafe override Assembly Assembly
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1399265, XrefRangeEnd = 1399271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignatureType.NativeMethodInfoPtr_get_Assembly_Public_Virtual_Final_get_Assembly_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Assembly>(intPtr3) : null;
			}
		}

		// Token: 0x17000E7D RID: 3709
		// (get) Token: 0x06003D64 RID: 15716 RVA: 0x001266B8 File Offset: 0x001248B8
		public unsafe override Module Module
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1399271, XrefRangeEnd = 1399277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignatureType.NativeMethodInfoPtr_get_Module_Public_Virtual_Final_get_Module_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Module>(intPtr3) : null;
			}
		}

		// Token: 0x17000E7E RID: 3710
		// (get) Token: 0x06003D65 RID: 15717 RVA: 0x001266F8 File Offset: 0x001248F8
		public unsafe override Type ReflectedType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1399277, XrefRangeEnd = 1399283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignatureType.NativeMethodInfoPtr_get_ReflectedType_Public_Virtual_Final_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x17000E7F RID: 3711
		// (get) Token: 0x06003D66 RID: 15718 RVA: 0x00126738 File Offset: 0x00124938
		public unsafe override Type BaseType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1399283, XrefRangeEnd = 1399289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignatureType.NativeMethodInfoPtr_get_BaseType_Public_Virtual_Final_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x06003D67 RID: 15719 RVA: 0x00126778 File Offset: 0x00124978
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1399289, XrefRangeEnd = 1399295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Il2CppReferenceArray<Type> GetInterfaces()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignatureType.NativeMethodInfoPtr_GetInterfaces_Public_Virtual_Final_Il2CppReferenceArray_1_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Type>>(intPtr3) : null;
		}

		// Token: 0x06003D68 RID: 15720 RVA: 0x001267B8 File Offset: 0x001249B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1399295, XrefRangeEnd = 1399301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsAssignableFrom(Type c)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignatureType.NativeMethodInfoPtr_IsAssignableFrom_Public_Virtual_Final_Boolean_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000E80 RID: 3712
		// (get) Token: 0x06003D69 RID: 15721 RVA: 0x00126808 File Offset: 0x00124A08
		public unsafe override int MetadataToken
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1399301, XrefRangeEnd = 1399307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignatureType.NativeMethodInfoPtr_get_MetadataToken_Public_Virtual_Final_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000E81 RID: 3713
		// (get) Token: 0x06003D6A RID: 15722 RVA: 0x00126844 File Offset: 0x00124A44
		public unsafe override Type DeclaringType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1399307, XrefRangeEnd = 1399313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignatureType.NativeMethodInfoPtr_get_DeclaringType_Public_Virtual_Final_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x17000E82 RID: 3714
		// (get) Token: 0x06003D6B RID: 15723 RVA: 0x00126884 File Offset: 0x00124A84
		public unsafe override MethodBase DeclaringMethod
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1399313, XrefRangeEnd = 1399319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignatureType.NativeMethodInfoPtr_get_DeclaringMethod_Public_Virtual_Final_get_MethodBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodBase>(intPtr3) : null;
			}
		}

		// Token: 0x06003D6C RID: 15724 RVA: 0x001268C4 File Offset: 0x00124AC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1399319, XrefRangeEnd = 1399325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Il2CppReferenceArray<Type> GetGenericParameterConstraints()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignatureType.NativeMethodInfoPtr_GetGenericParameterConstraints_Public_Virtual_Final_Il2CppReferenceArray_1_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Type>>(intPtr3) : null;
		}

		// Token: 0x17000E83 RID: 3715
		// (get) Token: 0x06003D6D RID: 15725 RVA: 0x00126904 File Offset: 0x00124B04
		public unsafe override GenericParameterAttributes GenericParameterAttributes
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1399325, XrefRangeEnd = 1399331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignatureType.NativeMethodInfoPtr_get_GenericParameterAttributes_Public_Virtual_Final_get_GenericParameterAttributes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003D6E RID: 15726 RVA: 0x00126940 File Offset: 0x00124B40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1399331, XrefRangeEnd = 1399337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsEnumDefined(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignatureType.NativeMethodInfoPtr_IsEnumDefined_Public_Virtual_Final_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003D6F RID: 15727 RVA: 0x00126990 File Offset: 0x00124B90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1399337, XrefRangeEnd = 1399343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetEnumName(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignatureType.NativeMethodInfoPtr_GetEnumName_Public_Virtual_Final_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06003D70 RID: 15728 RVA: 0x001269D8 File Offset: 0x00124BD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1399343, XrefRangeEnd = 1399349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Il2CppStringArray GetEnumNames()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignatureType.NativeMethodInfoPtr_GetEnumNames_Public_Virtual_Final_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
		}

		// Token: 0x06003D71 RID: 15729 RVA: 0x00126A18 File Offset: 0x00124C18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1399349, XrefRangeEnd = 1399355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Type GetEnumUnderlyingType()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignatureType.NativeMethodInfoPtr_GetEnumUnderlyingType_Public_Virtual_Final_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
		}

		// Token: 0x06003D72 RID: 15730 RVA: 0x00126A58 File Offset: 0x00124C58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1399355, XrefRangeEnd = 1399361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Array GetEnumValues()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignatureType.NativeMethodInfoPtr_GetEnumValues_Public_Virtual_Final_Array_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Array>(intPtr3) : null;
		}

		// Token: 0x17000E84 RID: 3716
		// (get) Token: 0x06003D73 RID: 15731 RVA: 0x00126A98 File Offset: 0x00124C98
		public unsafe override Guid GUID
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1399361, XrefRangeEnd = 1399367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignatureType.NativeMethodInfoPtr_get_GUID_Public_Virtual_Final_get_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003D74 RID: 15732 RVA: 0x00126AD4 File Offset: 0x00124CD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1399367, XrefRangeEnd = 1399373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override TypeCode GetTypeCodeImpl()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignatureType.NativeMethodInfoPtr_GetTypeCodeImpl_Protected_Virtual_Final_TypeCode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003D75 RID: 15733 RVA: 0x00126B10 File Offset: 0x00124D10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1399373, XrefRangeEnd = 1399379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override TypeAttributes GetAttributeFlagsImpl()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignatureType.NativeMethodInfoPtr_GetAttributeFlagsImpl_Protected_Virtual_Final_TypeAttributes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003D76 RID: 15734 RVA: 0x00126B4C File Offset: 0x00124D4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1399379, XrefRangeEnd = 1399385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Il2CppReferenceArray<ConstructorInfo> GetConstructors(BindingFlags bindingAttr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bindingAttr;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignatureType.NativeMethodInfoPtr_GetConstructors_Public_Virtual_Final_Il2CppReferenceArray_1_ConstructorInfo_BindingFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ConstructorInfo>>(intPtr3) : null;
			}
		}

		// Token: 0x06003D77 RID: 15735 RVA: 0x00126B98 File Offset: 0x00124D98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1399385, XrefRangeEnd = 1399391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignatureType.NativeMethodInfoPtr_GetEvent_Public_Virtual_Final_EventInfo_String_BindingFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<EventInfo>(intPtr3) : null;
		}

		// Token: 0x06003D78 RID: 15736 RVA: 0x00126BF8 File Offset: 0x00124DF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1399391, XrefRangeEnd = 1399397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Il2CppReferenceArray<EventInfo> GetEvents(BindingFlags bindingAttr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bindingAttr;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignatureType.NativeMethodInfoPtr_GetEvents_Public_Virtual_Final_Il2CppReferenceArray_1_EventInfo_BindingFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<EventInfo>>(intPtr3) : null;
			}
		}

		// Token: 0x06003D79 RID: 15737 RVA: 0x00126C44 File Offset: 0x00124E44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1399397, XrefRangeEnd = 1399403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignatureType.NativeMethodInfoPtr_GetField_Public_Virtual_Final_FieldInfo_String_BindingFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<FieldInfo>(intPtr3) : null;
		}

		// Token: 0x06003D7A RID: 15738 RVA: 0x00126CA4 File Offset: 0x00124EA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1399403, XrefRangeEnd = 1399409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Il2CppReferenceArray<FieldInfo> GetFields(BindingFlags bindingAttr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bindingAttr;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignatureType.NativeMethodInfoPtr_GetFields_Public_Virtual_Final_Il2CppReferenceArray_1_FieldInfo_BindingFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<FieldInfo>>(intPtr3) : null;
			}
		}

		// Token: 0x06003D7B RID: 15739 RVA: 0x00126CF0 File Offset: 0x00124EF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1399409, XrefRangeEnd = 1399415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Il2CppReferenceArray<MemberInfo> GetMembers(BindingFlags bindingAttr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bindingAttr;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignatureType.NativeMethodInfoPtr_GetMembers_Public_Virtual_Final_Il2CppReferenceArray_1_MemberInfo_BindingFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MemberInfo>>(intPtr3) : null;
			}
		}

		// Token: 0x06003D7C RID: 15740 RVA: 0x00126D3C File Offset: 0x00124F3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1399415, XrefRangeEnd = 1399421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Il2CppReferenceArray<MethodInfo> GetMethods(BindingFlags bindingAttr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bindingAttr;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignatureType.NativeMethodInfoPtr_GetMethods_Public_Virtual_Final_Il2CppReferenceArray_1_MethodInfo_BindingFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MethodInfo>>(intPtr3) : null;
			}
		}

		// Token: 0x06003D7D RID: 15741 RVA: 0x00126D88 File Offset: 0x00124F88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1399421, XrefRangeEnd = 1399427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Type GetNestedType(string name, BindingFlags bindingAttr)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignatureType.NativeMethodInfoPtr_GetNestedType_Public_Virtual_Final_Type_String_BindingFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
		}

		// Token: 0x06003D7E RID: 15742 RVA: 0x00126DE8 File Offset: 0x00124FE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1399427, XrefRangeEnd = 1399433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Il2CppReferenceArray<PropertyInfo> GetProperties(BindingFlags bindingAttr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bindingAttr;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignatureType.NativeMethodInfoPtr_GetProperties_Public_Virtual_Final_Il2CppReferenceArray_1_PropertyInfo_BindingFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<PropertyInfo>>(intPtr3) : null;
			}
		}

		// Token: 0x06003D7F RID: 15743 RVA: 0x00126E34 File Offset: 0x00125034
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1399433, XrefRangeEnd = 1399439, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Object InvokeMember(string name, BindingFlags invokeAttr, Binder binder, Object target, Il2CppReferenceArray<Object> args, Il2CppReferenceArray<ParameterModifier> modifiers, CultureInfo culture, Il2CppStringArray namedParameters)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref invokeAttr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(binder);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(target);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(modifiers);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(culture);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(namedParameters);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignatureType.NativeMethodInfoPtr_InvokeMember_Public_Virtual_Final_Object_String_BindingFlags_Binder_Object_Il2CppReferenceArray_1_Object_Il2CppReferenceArray_1_ParameterModifier_CultureInfo_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06003D80 RID: 15744 RVA: 0x00126F04 File Offset: 0x00125104
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1399439, XrefRangeEnd = 1399445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override MethodInfo GetMethodImpl(string name, BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Il2CppReferenceArray<Type> types, Il2CppReferenceArray<ParameterModifier> modifiers)
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
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref callConvention;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(types);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(modifiers);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignatureType.NativeMethodInfoPtr_GetMethodImpl_Protected_Virtual_Final_MethodInfo_String_BindingFlags_Binder_CallingConventions_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_ParameterModifier_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr3) : null;
		}

		// Token: 0x06003D81 RID: 15745 RVA: 0x00126FA8 File Offset: 0x001251A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1399445, XrefRangeEnd = 1399451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignatureType.NativeMethodInfoPtr_GetPropertyImpl_Protected_Virtual_Final_PropertyInfo_String_BindingFlags_Binder_Type_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_ParameterModifier_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PropertyInfo>(intPtr3) : null;
		}

		// Token: 0x06003D82 RID: 15746 RVA: 0x00127054 File Offset: 0x00125254
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1399451, XrefRangeEnd = 1399457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Il2CppReferenceArray<MemberInfo> GetMember(string name, BindingFlags bindingAttr)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignatureType.NativeMethodInfoPtr_GetMember_Public_Virtual_Final_Il2CppReferenceArray_1_MemberInfo_String_BindingFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MemberInfo>>(intPtr3) : null;
		}

		// Token: 0x06003D83 RID: 15747 RVA: 0x001270B4 File Offset: 0x001252B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1399457, XrefRangeEnd = 1399463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignatureType.NativeMethodInfoPtr_GetMember_Public_Virtual_Final_Il2CppReferenceArray_1_MemberInfo_String_MemberTypes_BindingFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MemberInfo>>(intPtr3) : null;
		}

		// Token: 0x06003D84 RID: 15748 RVA: 0x00127120 File Offset: 0x00125320
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1399463, XrefRangeEnd = 1399469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Il2CppReferenceArray<Object> GetCustomAttributes(bool inherit)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref inherit;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignatureType.NativeMethodInfoPtr_GetCustomAttributes_Public_Virtual_Final_Il2CppReferenceArray_1_Object_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr3) : null;
			}
		}

		// Token: 0x06003D85 RID: 15749 RVA: 0x0012716C File Offset: 0x0012536C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1399469, XrefRangeEnd = 1399475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignatureType.NativeMethodInfoPtr_GetCustomAttributes_Public_Virtual_Final_Il2CppReferenceArray_1_Object_Type_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr3) : null;
		}

		// Token: 0x06003D86 RID: 15750 RVA: 0x001271CC File Offset: 0x001253CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1399475, XrefRangeEnd = 1399481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignatureType.NativeMethodInfoPtr_IsDefined_Public_Virtual_Final_Boolean_Type_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003D87 RID: 15751 RVA: 0x00127228 File Offset: 0x00125428
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1399481, XrefRangeEnd = 1399487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IList<CustomAttributeData> GetCustomAttributesData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignatureType.NativeMethodInfoPtr_GetCustomAttributesData_Public_Virtual_Final_IList_1_CustomAttributeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<CustomAttributeData>>(intPtr3) : null;
		}

		// Token: 0x06003D88 RID: 15752 RVA: 0x00127268 File Offset: 0x00125468
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1399487, XrefRangeEnd = 1399493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Type GetInterface(string name, bool ignoreCase)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ignoreCase;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignatureType.NativeMethodInfoPtr_GetInterface_Public_Virtual_Final_Type_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
		}

		// Token: 0x06003D89 RID: 15753 RVA: 0x001272C8 File Offset: 0x001254C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1399493, XrefRangeEnd = 1399499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignatureType.NativeMethodInfoPtr_GetConstructorImpl_Protected_Virtual_Final_ConstructorInfo_BindingFlags_Binder_CallingConventions_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_ParameterModifier_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ConstructorInfo>(intPtr3) : null;
		}

		// Token: 0x06003D8A RID: 15754 RVA: 0x0012735C File Offset: 0x0012555C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1399499, XrefRangeEnd = 1399505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsCOMObjectImpl()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignatureType.NativeMethodInfoPtr_IsCOMObjectImpl_Protected_Virtual_Final_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003D8B RID: 15755 RVA: 0x00127398 File Offset: 0x00125598
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1399505, XrefRangeEnd = 1399511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsPrimitiveImpl()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignatureType.NativeMethodInfoPtr_IsPrimitiveImpl_Protected_Virtual_Final_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003D8C RID: 15756 RVA: 0x001273D4 File Offset: 0x001255D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1399511, XrefRangeEnd = 1399517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsContextfulImpl()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignatureType.NativeMethodInfoPtr_IsContextfulImpl_Protected_Virtual_Final_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000E85 RID: 3717
		// (get) Token: 0x06003D8D RID: 15757 RVA: 0x00127410 File Offset: 0x00125610
		public unsafe override bool IsEnum
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1399517, XrefRangeEnd = 1399523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignatureType.NativeMethodInfoPtr_get_IsEnum_Public_Virtual_Final_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003D8E RID: 15758 RVA: 0x0012744C File Offset: 0x0012564C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1399523, XrefRangeEnd = 1399529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsEquivalentTo(Type other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignatureType.NativeMethodInfoPtr_IsEquivalentTo_Public_Virtual_Final_Boolean_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003D8F RID: 15759 RVA: 0x0012749C File Offset: 0x0012569C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1399529, XrefRangeEnd = 1399535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsInstanceOfType(Object o)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignatureType.NativeMethodInfoPtr_IsInstanceOfType_Public_Virtual_Final_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003D90 RID: 15760 RVA: 0x001274EC File Offset: 0x001256EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1399535, XrefRangeEnd = 1399541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsMarshalByRefImpl()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignatureType.NativeMethodInfoPtr_IsMarshalByRefImpl_Protected_Virtual_Final_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000E86 RID: 3718
		// (get) Token: 0x06003D91 RID: 15761 RVA: 0x00127528 File Offset: 0x00125728
		public unsafe override bool IsSerializable
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1399541, XrefRangeEnd = 1399547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignatureType.NativeMethodInfoPtr_get_IsSerializable_Public_Virtual_Final_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003D92 RID: 15762 RVA: 0x00127564 File Offset: 0x00125764
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1399547, XrefRangeEnd = 1399553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsSubclassOf(Type c)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignatureType.NativeMethodInfoPtr_IsSubclassOf_Public_Virtual_Final_Boolean_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003D93 RID: 15763 RVA: 0x001275B4 File Offset: 0x001257B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1399553, XrefRangeEnd = 1399559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsValueTypeImpl()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignatureType.NativeMethodInfoPtr_IsValueTypeImpl_Protected_Virtual_Final_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000E87 RID: 3719
		// (get) Token: 0x06003D94 RID: 15764 RVA: 0x001275F0 File Offset: 0x001257F0
		public unsafe override RuntimeTypeHandle TypeHandle
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1399559, XrefRangeEnd = 1399565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignatureType.NativeMethodInfoPtr_get_TypeHandle_Public_Virtual_Final_get_RuntimeTypeHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003D95 RID: 15765 RVA: 0x0012762C File Offset: 0x0012582C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1399565, XrefRangeEnd = 1399569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SignatureType()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SignatureType>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignatureType.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003D96 RID: 15766 RVA: 0x00016958 File Offset: 0x00014B58
		public override Type MakeGenericType(params Type[] typeArguments)
		{
			return this.MakeGenericType(new Il2CppReferenceArray<Type>(typeArguments));
		}

		// Token: 0x06003D97 RID: 15767 RVA: 0x00016966 File Offset: 0x00014B66
		public SignatureType(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04003200 RID: 12800
		private static readonly IntPtr NativeMethodInfoPtr_get_IsSignatureType_Public_Virtual_Final_get_Boolean_0;

		// Token: 0x04003201 RID: 12801
		private static readonly IntPtr NativeMethodInfoPtr_HasElementTypeImpl_Protected_Abstract_Virtual_Boolean_0;

		// Token: 0x04003202 RID: 12802
		private static readonly IntPtr NativeMethodInfoPtr_IsArrayImpl_Protected_Abstract_Virtual_Boolean_0;

		// Token: 0x04003203 RID: 12803
		private static readonly IntPtr NativeMethodInfoPtr_get_IsSZArray_Public_Abstract_Virtual_get_Boolean_0;

		// Token: 0x04003204 RID: 12804
		private static readonly IntPtr NativeMethodInfoPtr_get_IsVariableBoundArray_Public_Abstract_Virtual_get_Boolean_0;

		// Token: 0x04003205 RID: 12805
		private static readonly IntPtr NativeMethodInfoPtr_IsByRefImpl_Protected_Abstract_Virtual_Boolean_0;

		// Token: 0x04003206 RID: 12806
		private static readonly IntPtr NativeMethodInfoPtr_IsPointerImpl_Protected_Abstract_Virtual_Boolean_0;

		// Token: 0x04003207 RID: 12807
		private static readonly IntPtr NativeMethodInfoPtr_get_IsGenericType_Public_Virtual_Final_get_Boolean_0;

		// Token: 0x04003208 RID: 12808
		private static readonly IntPtr NativeMethodInfoPtr_get_IsGenericTypeDefinition_Public_Abstract_Virtual_get_Boolean_0;

		// Token: 0x04003209 RID: 12809
		private static readonly IntPtr NativeMethodInfoPtr_get_IsConstructedGenericType_Public_Abstract_Virtual_get_Boolean_0;

		// Token: 0x0400320A RID: 12810
		private static readonly IntPtr NativeMethodInfoPtr_get_IsGenericParameter_Public_Abstract_Virtual_get_Boolean_0;

		// Token: 0x0400320B RID: 12811
		private static readonly IntPtr NativeMethodInfoPtr_get_IsGenericMethodParameter_Public_Abstract_Virtual_get_Boolean_0;

		// Token: 0x0400320C RID: 12812
		private static readonly IntPtr NativeMethodInfoPtr_get_ContainsGenericParameters_Public_Abstract_Virtual_get_Boolean_0;

		// Token: 0x0400320D RID: 12813
		private static readonly IntPtr NativeMethodInfoPtr_get_MemberType_Public_Virtual_Final_get_MemberTypes_0;

		// Token: 0x0400320E RID: 12814
		private static readonly IntPtr NativeMethodInfoPtr_MakeArrayType_Public_Virtual_Final_Type_0;

		// Token: 0x0400320F RID: 12815
		private static readonly IntPtr NativeMethodInfoPtr_MakeArrayType_Public_Virtual_Final_Type_Int32_0;

		// Token: 0x04003210 RID: 12816
		private static readonly IntPtr NativeMethodInfoPtr_MakeByRefType_Public_Virtual_Final_Type_0;

		// Token: 0x04003211 RID: 12817
		private static readonly IntPtr NativeMethodInfoPtr_MakePointerType_Public_Virtual_Final_Type_0;

		// Token: 0x04003212 RID: 12818
		private static readonly IntPtr NativeMethodInfoPtr_MakeGenericType_Public_Virtual_Final_Type_Il2CppReferenceArray_1_Type_0;

		// Token: 0x04003213 RID: 12819
		private static readonly IntPtr NativeMethodInfoPtr_GetElementType_Public_Virtual_Final_Type_0;

		// Token: 0x04003214 RID: 12820
		private static readonly IntPtr NativeMethodInfoPtr_GetArrayRank_Public_Abstract_Virtual_Int32_0;

		// Token: 0x04003215 RID: 12821
		private static readonly IntPtr NativeMethodInfoPtr_GetGenericTypeDefinition_Public_Abstract_Virtual_Type_0;

		// Token: 0x04003216 RID: 12822
		private static readonly IntPtr NativeMethodInfoPtr_get_GenericTypeArguments_Public_Abstract_Virtual_get_Il2CppReferenceArray_1_Type_0;

		// Token: 0x04003217 RID: 12823
		private static readonly IntPtr NativeMethodInfoPtr_GetGenericArguments_Public_Abstract_Virtual_Il2CppReferenceArray_1_Type_0;

		// Token: 0x04003218 RID: 12824
		private static readonly IntPtr NativeMethodInfoPtr_get_GenericParameterPosition_Public_Abstract_Virtual_get_Int32_0;

		// Token: 0x04003219 RID: 12825
		private static readonly IntPtr NativeMethodInfoPtr_get_ElementType_Internal_Abstract_Virtual_New_get_SignatureType_0;

		// Token: 0x0400321A RID: 12826
		private static readonly IntPtr NativeMethodInfoPtr_get_UnderlyingSystemType_Public_Virtual_Final_get_Type_0;

		// Token: 0x0400321B RID: 12827
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Abstract_Virtual_get_String_0;

		// Token: 0x0400321C RID: 12828
		private static readonly IntPtr NativeMethodInfoPtr_get_Namespace_Public_Abstract_Virtual_get_String_0;

		// Token: 0x0400321D RID: 12829
		private static readonly IntPtr NativeMethodInfoPtr_get_FullName_Public_Virtual_Final_get_String_0;

		// Token: 0x0400321E RID: 12830
		private static readonly IntPtr NativeMethodInfoPtr_get_AssemblyQualifiedName_Public_Virtual_Final_get_String_0;

		// Token: 0x0400321F RID: 12831
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Abstract_Virtual_String_0;

		// Token: 0x04003220 RID: 12832
		private static readonly IntPtr NativeMethodInfoPtr_get_Assembly_Public_Virtual_Final_get_Assembly_0;

		// Token: 0x04003221 RID: 12833
		private static readonly IntPtr NativeMethodInfoPtr_get_Module_Public_Virtual_Final_get_Module_0;

		// Token: 0x04003222 RID: 12834
		private static readonly IntPtr NativeMethodInfoPtr_get_ReflectedType_Public_Virtual_Final_get_Type_0;

		// Token: 0x04003223 RID: 12835
		private static readonly IntPtr NativeMethodInfoPtr_get_BaseType_Public_Virtual_Final_get_Type_0;

		// Token: 0x04003224 RID: 12836
		private static readonly IntPtr NativeMethodInfoPtr_GetInterfaces_Public_Virtual_Final_Il2CppReferenceArray_1_Type_0;

		// Token: 0x04003225 RID: 12837
		private static readonly IntPtr NativeMethodInfoPtr_IsAssignableFrom_Public_Virtual_Final_Boolean_Type_0;

		// Token: 0x04003226 RID: 12838
		private static readonly IntPtr NativeMethodInfoPtr_get_MetadataToken_Public_Virtual_Final_get_Int32_0;

		// Token: 0x04003227 RID: 12839
		private static readonly IntPtr NativeMethodInfoPtr_get_DeclaringType_Public_Virtual_Final_get_Type_0;

		// Token: 0x04003228 RID: 12840
		private static readonly IntPtr NativeMethodInfoPtr_get_DeclaringMethod_Public_Virtual_Final_get_MethodBase_0;

		// Token: 0x04003229 RID: 12841
		private static readonly IntPtr NativeMethodInfoPtr_GetGenericParameterConstraints_Public_Virtual_Final_Il2CppReferenceArray_1_Type_0;

		// Token: 0x0400322A RID: 12842
		private static readonly IntPtr NativeMethodInfoPtr_get_GenericParameterAttributes_Public_Virtual_Final_get_GenericParameterAttributes_0;

		// Token: 0x0400322B RID: 12843
		private static readonly IntPtr NativeMethodInfoPtr_IsEnumDefined_Public_Virtual_Final_Boolean_Object_0;

		// Token: 0x0400322C RID: 12844
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumName_Public_Virtual_Final_String_Object_0;

		// Token: 0x0400322D RID: 12845
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumNames_Public_Virtual_Final_Il2CppStringArray_0;

		// Token: 0x0400322E RID: 12846
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumUnderlyingType_Public_Virtual_Final_Type_0;

		// Token: 0x0400322F RID: 12847
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumValues_Public_Virtual_Final_Array_0;

		// Token: 0x04003230 RID: 12848
		private static readonly IntPtr NativeMethodInfoPtr_get_GUID_Public_Virtual_Final_get_Guid_0;

		// Token: 0x04003231 RID: 12849
		private static readonly IntPtr NativeMethodInfoPtr_GetTypeCodeImpl_Protected_Virtual_Final_TypeCode_0;

		// Token: 0x04003232 RID: 12850
		private static readonly IntPtr NativeMethodInfoPtr_GetAttributeFlagsImpl_Protected_Virtual_Final_TypeAttributes_0;

		// Token: 0x04003233 RID: 12851
		private static readonly IntPtr NativeMethodInfoPtr_GetConstructors_Public_Virtual_Final_Il2CppReferenceArray_1_ConstructorInfo_BindingFlags_0;

		// Token: 0x04003234 RID: 12852
		private static readonly IntPtr NativeMethodInfoPtr_GetEvent_Public_Virtual_Final_EventInfo_String_BindingFlags_0;

		// Token: 0x04003235 RID: 12853
		private static readonly IntPtr NativeMethodInfoPtr_GetEvents_Public_Virtual_Final_Il2CppReferenceArray_1_EventInfo_BindingFlags_0;

		// Token: 0x04003236 RID: 12854
		private static readonly IntPtr NativeMethodInfoPtr_GetField_Public_Virtual_Final_FieldInfo_String_BindingFlags_0;

		// Token: 0x04003237 RID: 12855
		private static readonly IntPtr NativeMethodInfoPtr_GetFields_Public_Virtual_Final_Il2CppReferenceArray_1_FieldInfo_BindingFlags_0;

		// Token: 0x04003238 RID: 12856
		private static readonly IntPtr NativeMethodInfoPtr_GetMembers_Public_Virtual_Final_Il2CppReferenceArray_1_MemberInfo_BindingFlags_0;

		// Token: 0x04003239 RID: 12857
		private static readonly IntPtr NativeMethodInfoPtr_GetMethods_Public_Virtual_Final_Il2CppReferenceArray_1_MethodInfo_BindingFlags_0;

		// Token: 0x0400323A RID: 12858
		private static readonly IntPtr NativeMethodInfoPtr_GetNestedType_Public_Virtual_Final_Type_String_BindingFlags_0;

		// Token: 0x0400323B RID: 12859
		private static readonly IntPtr NativeMethodInfoPtr_GetProperties_Public_Virtual_Final_Il2CppReferenceArray_1_PropertyInfo_BindingFlags_0;

		// Token: 0x0400323C RID: 12860
		private static readonly IntPtr NativeMethodInfoPtr_InvokeMember_Public_Virtual_Final_Object_String_BindingFlags_Binder_Object_Il2CppReferenceArray_1_Object_Il2CppReferenceArray_1_ParameterModifier_CultureInfo_Il2CppStringArray_0;

		// Token: 0x0400323D RID: 12861
		private static readonly IntPtr NativeMethodInfoPtr_GetMethodImpl_Protected_Virtual_Final_MethodInfo_String_BindingFlags_Binder_CallingConventions_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_ParameterModifier_0;

		// Token: 0x0400323E RID: 12862
		private static readonly IntPtr NativeMethodInfoPtr_GetPropertyImpl_Protected_Virtual_Final_PropertyInfo_String_BindingFlags_Binder_Type_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_ParameterModifier_0;

		// Token: 0x0400323F RID: 12863
		private static readonly IntPtr NativeMethodInfoPtr_GetMember_Public_Virtual_Final_Il2CppReferenceArray_1_MemberInfo_String_BindingFlags_0;

		// Token: 0x04003240 RID: 12864
		private static readonly IntPtr NativeMethodInfoPtr_GetMember_Public_Virtual_Final_Il2CppReferenceArray_1_MemberInfo_String_MemberTypes_BindingFlags_0;

		// Token: 0x04003241 RID: 12865
		private static readonly IntPtr NativeMethodInfoPtr_GetCustomAttributes_Public_Virtual_Final_Il2CppReferenceArray_1_Object_Boolean_0;

		// Token: 0x04003242 RID: 12866
		private static readonly IntPtr NativeMethodInfoPtr_GetCustomAttributes_Public_Virtual_Final_Il2CppReferenceArray_1_Object_Type_Boolean_0;

		// Token: 0x04003243 RID: 12867
		private static readonly IntPtr NativeMethodInfoPtr_IsDefined_Public_Virtual_Final_Boolean_Type_Boolean_0;

		// Token: 0x04003244 RID: 12868
		private static readonly IntPtr NativeMethodInfoPtr_GetCustomAttributesData_Public_Virtual_Final_IList_1_CustomAttributeData_0;

		// Token: 0x04003245 RID: 12869
		private static readonly IntPtr NativeMethodInfoPtr_GetInterface_Public_Virtual_Final_Type_String_Boolean_0;

		// Token: 0x04003246 RID: 12870
		private static readonly IntPtr NativeMethodInfoPtr_GetConstructorImpl_Protected_Virtual_Final_ConstructorInfo_BindingFlags_Binder_CallingConventions_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_ParameterModifier_0;

		// Token: 0x04003247 RID: 12871
		private static readonly IntPtr NativeMethodInfoPtr_IsCOMObjectImpl_Protected_Virtual_Final_Boolean_0;

		// Token: 0x04003248 RID: 12872
		private static readonly IntPtr NativeMethodInfoPtr_IsPrimitiveImpl_Protected_Virtual_Final_Boolean_0;

		// Token: 0x04003249 RID: 12873
		private static readonly IntPtr NativeMethodInfoPtr_IsContextfulImpl_Protected_Virtual_Final_Boolean_0;

		// Token: 0x0400324A RID: 12874
		private static readonly IntPtr NativeMethodInfoPtr_get_IsEnum_Public_Virtual_Final_get_Boolean_0;

		// Token: 0x0400324B RID: 12875
		private static readonly IntPtr NativeMethodInfoPtr_IsEquivalentTo_Public_Virtual_Final_Boolean_Type_0;

		// Token: 0x0400324C RID: 12876
		private static readonly IntPtr NativeMethodInfoPtr_IsInstanceOfType_Public_Virtual_Final_Boolean_Object_0;

		// Token: 0x0400324D RID: 12877
		private static readonly IntPtr NativeMethodInfoPtr_IsMarshalByRefImpl_Protected_Virtual_Final_Boolean_0;

		// Token: 0x0400324E RID: 12878
		private static readonly IntPtr NativeMethodInfoPtr_get_IsSerializable_Public_Virtual_Final_get_Boolean_0;

		// Token: 0x0400324F RID: 12879
		private static readonly IntPtr NativeMethodInfoPtr_IsSubclassOf_Public_Virtual_Final_Boolean_Type_0;

		// Token: 0x04003250 RID: 12880
		private static readonly IntPtr NativeMethodInfoPtr_IsValueTypeImpl_Protected_Virtual_Final_Boolean_0;

		// Token: 0x04003251 RID: 12881
		private static readonly IntPtr NativeMethodInfoPtr_get_TypeHandle_Public_Virtual_Final_get_RuntimeTypeHandle_0;

		// Token: 0x04003252 RID: 12882
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
