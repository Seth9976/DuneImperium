using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Globalization;
using Il2CppSystem.Reflection;

namespace Il2CppSystem
{
	// Token: 0x02000130 RID: 304
	[Serializable]
	public class DefaultBinder : Binder
	{
		// Token: 0x0600141F RID: 5151 RVA: 0x00087198 File Offset: 0x00085398
		// Note: this type is marked as 'beforefieldinit'.
		static DefaultBinder()
		{
			Il2CppClassPointerStore<DefaultBinder>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "DefaultBinder");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DefaultBinder>.NativeClassPtr);
			DefaultBinder.NativeFieldInfoPtr__primitiveConversions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultBinder>.NativeClassPtr, "_primitiveConversions");
			DefaultBinder.NativeMethodInfoPtr_BindToMethod_Public_Virtual_MethodBase_BindingFlags_Il2CppReferenceArray_1_MethodBase_byref_Il2CppReferenceArray_1_Object_Il2CppReferenceArray_1_ParameterModifier_CultureInfo_Il2CppStringArray_byref_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultBinder>.NativeClassPtr, 100666861);
			DefaultBinder.NativeMethodInfoPtr_BindToField_Public_Virtual_FieldInfo_BindingFlags_Il2CppReferenceArray_1_FieldInfo_Object_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultBinder>.NativeClassPtr, 100666862);
			DefaultBinder.NativeMethodInfoPtr_SelectProperty_Public_Virtual_PropertyInfo_BindingFlags_Il2CppReferenceArray_1_PropertyInfo_Type_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_ParameterModifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultBinder>.NativeClassPtr, 100666863);
			DefaultBinder.NativeMethodInfoPtr_ChangeType_Public_Virtual_Object_Object_Type_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultBinder>.NativeClassPtr, 100666864);
			DefaultBinder.NativeMethodInfoPtr_ReorderArgumentArray_Public_Virtual_Void_byref_Il2CppReferenceArray_1_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultBinder>.NativeClassPtr, 100666865);
			DefaultBinder.NativeMethodInfoPtr_ExactBinding_Public_Static_MethodBase_Il2CppReferenceArray_1_MethodBase_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_ParameterModifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultBinder>.NativeClassPtr, 100666866);
			DefaultBinder.NativeMethodInfoPtr_ExactPropertyBinding_Public_Static_PropertyInfo_Il2CppReferenceArray_1_PropertyInfo_Type_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_ParameterModifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultBinder>.NativeClassPtr, 100666867);
			DefaultBinder.NativeMethodInfoPtr_FindMostSpecific_Private_Static_Int32_Il2CppReferenceArray_1_ParameterInfo_Il2CppStructArray_1_Int32_Type_Il2CppReferenceArray_1_ParameterInfo_Il2CppStructArray_1_Int32_Type_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultBinder>.NativeClassPtr, 100666868);
			DefaultBinder.NativeMethodInfoPtr_FindMostSpecificType_Private_Static_Int32_Type_Type_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultBinder>.NativeClassPtr, 100666869);
			DefaultBinder.NativeMethodInfoPtr_FindMostSpecificMethod_Private_Static_Int32_MethodBase_Il2CppStructArray_1_Int32_Type_MethodBase_Il2CppStructArray_1_Int32_Type_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultBinder>.NativeClassPtr, 100666870);
			DefaultBinder.NativeMethodInfoPtr_FindMostSpecificField_Private_Static_Int32_FieldInfo_FieldInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultBinder>.NativeClassPtr, 100666871);
			DefaultBinder.NativeMethodInfoPtr_FindMostSpecificProperty_Private_Static_Int32_PropertyInfo_PropertyInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultBinder>.NativeClassPtr, 100666872);
			DefaultBinder.NativeMethodInfoPtr_CompareMethodSigAndName_Internal_Static_Boolean_MethodBase_MethodBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultBinder>.NativeClassPtr, 100666873);
			DefaultBinder.NativeMethodInfoPtr_GetHierarchyDepth_Internal_Static_Int32_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultBinder>.NativeClassPtr, 100666874);
			DefaultBinder.NativeMethodInfoPtr_FindMostDerivedNewSlotMeth_Internal_Static_MethodBase_Il2CppReferenceArray_1_MethodBase_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultBinder>.NativeClassPtr, 100666875);
			DefaultBinder.NativeMethodInfoPtr_ReorderParams_Private_Static_Void_Il2CppStructArray_1_Int32_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultBinder>.NativeClassPtr, 100666876);
			DefaultBinder.NativeMethodInfoPtr_CreateParamOrder_Private_Static_Boolean_Il2CppStructArray_1_Int32_Il2CppReferenceArray_1_ParameterInfo_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultBinder>.NativeClassPtr, 100666877);
			DefaultBinder.NativeMethodInfoPtr_CanConvertPrimitive_Private_Static_Boolean_RuntimeType_RuntimeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultBinder>.NativeClassPtr, 100666878);
			DefaultBinder.NativeMethodInfoPtr_CanConvertPrimitiveObjectToType_Private_Static_Boolean_Object_RuntimeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultBinder>.NativeClassPtr, 100666879);
			DefaultBinder.NativeMethodInfoPtr_CompareMethodSig_Internal_Static_Boolean_MethodBase_MethodBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultBinder>.NativeClassPtr, 100666880);
			DefaultBinder.NativeMethodInfoPtr_SelectMethod_Public_Virtual_Final_MethodBase_BindingFlags_Il2CppReferenceArray_1_MethodBase_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_ParameterModifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultBinder>.NativeClassPtr, 100666881);
			DefaultBinder.NativeMethodInfoPtr_CanChangePrimitive_Private_Static_Boolean_Type_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultBinder>.NativeClassPtr, 100666882);
			DefaultBinder.NativeMethodInfoPtr_CanPrimitiveWiden_Private_Static_Boolean_Type_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultBinder>.NativeClassPtr, 100666883);
			DefaultBinder.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultBinder>.NativeClassPtr, 100666884);
		}

		// Token: 0x06001420 RID: 5152 RVA: 0x000873BC File Offset: 0x000855BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1339065, XrefRangeEnd = 1339216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override MethodBase BindToMethod(BindingFlags bindingAttr, Il2CppReferenceArray<MethodBase> match, ref Il2CppReferenceArray<Object> args, Il2CppReferenceArray<ParameterModifier> modifiers, CultureInfo cultureInfo, Il2CppStringArray names, out Object state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bindingAttr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(match);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(args);
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(modifiers);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cultureInfo);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(names);
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DefaultBinder.NativeMethodInfoPtr_BindToMethod_Public_Virtual_MethodBase_BindingFlags_Il2CppReferenceArray_1_MethodBase_byref_Il2CppReferenceArray_1_Object_Il2CppReferenceArray_1_ParameterModifier_CultureInfo_Il2CppStringArray_byref_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			args = ((intPtr5 == 0) ? null : new Il2CppReferenceArray<Object>(intPtr5));
			IntPtr intPtr6 = intPtr2;
			state = ((intPtr6 == 0) ? null : new Object(intPtr6));
			IntPtr intPtr7 = intPtr3;
			return (intPtr7 != 0) ? Il2CppObjectPool.Get<MethodBase>(intPtr7) : null;
		}

		// Token: 0x06001421 RID: 5153 RVA: 0x000874AC File Offset: 0x000856AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1339216, XrefRangeEnd = 1339255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override FieldInfo BindToField(BindingFlags bindingAttr, Il2CppReferenceArray<FieldInfo> match, Object value, CultureInfo cultureInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bindingAttr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(match);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cultureInfo);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DefaultBinder.NativeMethodInfoPtr_BindToField_Public_Virtual_FieldInfo_BindingFlags_Il2CppReferenceArray_1_FieldInfo_Object_CultureInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<FieldInfo>(intPtr3) : null;
		}

		// Token: 0x06001422 RID: 5154 RVA: 0x0008753C File Offset: 0x0008573C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1339255, XrefRangeEnd = 1339324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override PropertyInfo SelectProperty(BindingFlags bindingAttr, Il2CppReferenceArray<PropertyInfo> match, Type returnType, Il2CppReferenceArray<Type> indexes, Il2CppReferenceArray<ParameterModifier> modifiers)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bindingAttr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(match);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(returnType);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(indexes);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(modifiers);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DefaultBinder.NativeMethodInfoPtr_SelectProperty_Public_Virtual_PropertyInfo_BindingFlags_Il2CppReferenceArray_1_PropertyInfo_Type_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_ParameterModifier_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PropertyInfo>(intPtr3) : null;
		}

		// Token: 0x06001423 RID: 5155 RVA: 0x000875E0 File Offset: 0x000857E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1339324, XrefRangeEnd = 1339331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Object ChangeType(Object value, Type type, CultureInfo cultureInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cultureInfo);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DefaultBinder.NativeMethodInfoPtr_ChangeType_Public_Virtual_Object_Object_Type_CultureInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06001424 RID: 5156 RVA: 0x00087660 File Offset: 0x00085860
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1339331, XrefRangeEnd = 1339342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ReorderArgumentArray(ref Il2CppReferenceArray<Object> args, Object state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(args);
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DefaultBinder.NativeMethodInfoPtr_ReorderArgumentArray_Public_Virtual_Void_byref_Il2CppReferenceArray_1_Object_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			args = ((intPtr4 == 0) ? null : new Il2CppReferenceArray<Object>(intPtr4));
		}

		// Token: 0x06001425 RID: 5157 RVA: 0x000876D4 File Offset: 0x000858D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1339353, RefRangeEnd = 1339354, XrefRangeStart = 1339342, XrefRangeEnd = 1339353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MethodBase ExactBinding(Il2CppReferenceArray<MethodBase> match, Il2CppReferenceArray<Type> types, Il2CppReferenceArray<ParameterModifier> modifiers)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(types);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(modifiers);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultBinder.NativeMethodInfoPtr_ExactBinding_Public_Static_MethodBase_Il2CppReferenceArray_1_MethodBase_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_ParameterModifier_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodBase>(intPtr3) : null;
		}

		// Token: 0x06001426 RID: 5158 RVA: 0x0008773C File Offset: 0x0008593C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1339354, XrefRangeEnd = 1339369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static PropertyInfo ExactPropertyBinding(Il2CppReferenceArray<PropertyInfo> match, Type returnType, Il2CppReferenceArray<Type> types, Il2CppReferenceArray<ParameterModifier> modifiers)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(returnType);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(types);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(modifiers);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultBinder.NativeMethodInfoPtr_ExactPropertyBinding_Public_Static_PropertyInfo_Il2CppReferenceArray_1_PropertyInfo_Type_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_ParameterModifier_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PropertyInfo>(intPtr3) : null;
		}

		// Token: 0x06001427 RID: 5159 RVA: 0x000877B8 File Offset: 0x000859B8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1339377, RefRangeEnd = 1339379, XrefRangeStart = 1339369, XrefRangeEnd = 1339377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int FindMostSpecific(Il2CppReferenceArray<ParameterInfo> p1, Il2CppStructArray<int> paramOrder1, Type paramArrayType1, Il2CppReferenceArray<ParameterInfo> p2, Il2CppStructArray<int> paramOrder2, Type paramArrayType2, Il2CppReferenceArray<Type> types, Il2CppReferenceArray<Object> args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(p1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(paramOrder1);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(paramArrayType1);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(p2);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(paramOrder2);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(paramArrayType2);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(types);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultBinder.NativeMethodInfoPtr_FindMostSpecific_Private_Static_Int32_Il2CppReferenceArray_1_ParameterInfo_Il2CppStructArray_1_Int32_Type_Il2CppReferenceArray_1_ParameterInfo_Il2CppStructArray_1_Int32_Type_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001428 RID: 5160 RVA: 0x0008787C File Offset: 0x00085A7C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1339415, RefRangeEnd = 1339416, XrefRangeStart = 1339379, XrefRangeEnd = 1339415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int FindMostSpecificType(Type c1, Type c2, Type t)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(c1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(c2);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(t);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultBinder.NativeMethodInfoPtr_FindMostSpecificType_Private_Static_Int32_Type_Type_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001429 RID: 5161 RVA: 0x000878E4 File Offset: 0x00085AE4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1339430, RefRangeEnd = 1339432, XrefRangeStart = 1339416, XrefRangeEnd = 1339430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int FindMostSpecificMethod(MethodBase m1, Il2CppStructArray<int> paramOrder1, Type paramArrayType1, MethodBase m2, Il2CppStructArray<int> paramOrder2, Type paramArrayType2, Il2CppReferenceArray<Type> types, Il2CppReferenceArray<Object> args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(paramOrder1);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(paramArrayType1);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m2);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(paramOrder2);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(paramArrayType2);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(types);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultBinder.NativeMethodInfoPtr_FindMostSpecificMethod_Private_Static_Int32_MethodBase_Il2CppStructArray_1_Int32_Type_MethodBase_Il2CppStructArray_1_Int32_Type_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600142A RID: 5162 RVA: 0x000879A8 File Offset: 0x00085BA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1339432, XrefRangeEnd = 1339438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int FindMostSpecificField(FieldInfo cur1, FieldInfo cur2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cur1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cur2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultBinder.NativeMethodInfoPtr_FindMostSpecificField_Private_Static_Int32_FieldInfo_FieldInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600142B RID: 5163 RVA: 0x000879FC File Offset: 0x00085BFC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1339444, RefRangeEnd = 1339445, XrefRangeStart = 1339438, XrefRangeEnd = 1339444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int FindMostSpecificProperty(PropertyInfo cur1, PropertyInfo cur2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cur1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cur2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultBinder.NativeMethodInfoPtr_FindMostSpecificProperty_Private_Static_Int32_PropertyInfo_PropertyInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600142C RID: 5164 RVA: 0x00087A50 File Offset: 0x00085C50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1339445, XrefRangeEnd = 1339449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CompareMethodSigAndName(MethodBase m1, MethodBase m2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultBinder.NativeMethodInfoPtr_CompareMethodSigAndName_Internal_Static_Boolean_MethodBase_MethodBase_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600142D RID: 5165 RVA: 0x00087AA4 File Offset: 0x00085CA4
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1339453, RefRangeEnd = 1339460, XrefRangeStart = 1339449, XrefRangeEnd = 1339453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetHierarchyDepth(Type t)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultBinder.NativeMethodInfoPtr_GetHierarchyDepth_Internal_Static_Int32_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600142E RID: 5166 RVA: 0x00087AE8 File Offset: 0x00085CE8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1339464, RefRangeEnd = 1339465, XrefRangeStart = 1339460, XrefRangeEnd = 1339464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MethodBase FindMostDerivedNewSlotMeth(Il2CppReferenceArray<MethodBase> match, int cMatches)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cMatches;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultBinder.NativeMethodInfoPtr_FindMostDerivedNewSlotMeth_Internal_Static_MethodBase_Il2CppReferenceArray_1_MethodBase_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodBase>(intPtr3) : null;
		}

		// Token: 0x0600142F RID: 5167 RVA: 0x00087B3C File Offset: 0x00085D3C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1339474, RefRangeEnd = 1339476, XrefRangeStart = 1339465, XrefRangeEnd = 1339474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ReorderParams(Il2CppStructArray<int> paramOrder, Il2CppReferenceArray<Object> vars)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(paramOrder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(vars);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultBinder.NativeMethodInfoPtr_ReorderParams_Private_Static_Void_Il2CppStructArray_1_Int32_Il2CppReferenceArray_1_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001430 RID: 5168 RVA: 0x00087B84 File Offset: 0x00085D84
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1339483, RefRangeEnd = 1339484, XrefRangeStart = 1339476, XrefRangeEnd = 1339483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CreateParamOrder(Il2CppStructArray<int> paramOrder, Il2CppReferenceArray<ParameterInfo> pars, Il2CppStringArray names)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(paramOrder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pars);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(names);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultBinder.NativeMethodInfoPtr_CreateParamOrder_Private_Static_Boolean_Il2CppStructArray_1_Int32_Il2CppReferenceArray_1_ParameterInfo_Il2CppStringArray_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001431 RID: 5169 RVA: 0x00087BEC File Offset: 0x00085DEC
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1339494, RefRangeEnd = 1339500, XrefRangeStart = 1339484, XrefRangeEnd = 1339494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CanConvertPrimitive(RuntimeType source, RuntimeType target)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(target);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultBinder.NativeMethodInfoPtr_CanConvertPrimitive_Private_Static_Boolean_RuntimeType_RuntimeType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001432 RID: 5170 RVA: 0x00087C40 File Offset: 0x00085E40
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1339512, RefRangeEnd = 1339515, XrefRangeStart = 1339500, XrefRangeEnd = 1339512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CanConvertPrimitiveObjectToType(Object source, RuntimeType type)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultBinder.NativeMethodInfoPtr_CanConvertPrimitiveObjectToType_Private_Static_Boolean_Object_RuntimeType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001433 RID: 5171 RVA: 0x00087C94 File Offset: 0x00085E94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1339515, XrefRangeEnd = 1339519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CompareMethodSig(MethodBase m1, MethodBase m2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultBinder.NativeMethodInfoPtr_CompareMethodSig_Internal_Static_Boolean_MethodBase_MethodBase_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001434 RID: 5172 RVA: 0x00087CE8 File Offset: 0x00085EE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1339519, XrefRangeEnd = 1339567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override MethodBase SelectMethod(BindingFlags bindingAttr, Il2CppReferenceArray<MethodBase> match, Il2CppReferenceArray<Type> types, Il2CppReferenceArray<ParameterModifier> modifiers)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bindingAttr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(match);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(types);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(modifiers);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultBinder.NativeMethodInfoPtr_SelectMethod_Public_Virtual_Final_MethodBase_BindingFlags_Il2CppReferenceArray_1_MethodBase_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_ParameterModifier_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodBase>(intPtr3) : null;
		}

		// Token: 0x06001435 RID: 5173 RVA: 0x00087D6C File Offset: 0x00085F6C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1339579, RefRangeEnd = 1339580, XrefRangeStart = 1339567, XrefRangeEnd = 1339579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CanChangePrimitive(Type source, Type target)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(target);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultBinder.NativeMethodInfoPtr_CanChangePrimitive_Private_Static_Boolean_Type_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001436 RID: 5174 RVA: 0x00087DC0 File Offset: 0x00085FC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1339580, XrefRangeEnd = 1339589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CanPrimitiveWiden(Type source, Type target)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(target);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultBinder.NativeMethodInfoPtr_CanPrimitiveWiden_Private_Static_Boolean_Type_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001437 RID: 5175 RVA: 0x00087E14 File Offset: 0x00086014
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DefaultBinder()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DefaultBinder>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultBinder.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001438 RID: 5176 RVA: 0x00006682 File Offset: 0x00004882
		public DefaultBinder(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000350 RID: 848
		// (get) Token: 0x06001439 RID: 5177 RVA: 0x00087E50 File Offset: 0x00086050
		// (set) Token: 0x0600143A RID: 5178 RVA: 0x0000668B File Offset: 0x0000488B
		public unsafe static Il2CppStructArray<DefaultBinder.Primitives> _primitiveConversions
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DefaultBinder.NativeFieldInfoPtr__primitiveConversions, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<DefaultBinder.Primitives>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DefaultBinder.NativeFieldInfoPtr__primitiveConversions, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001113 RID: 4371
		private static readonly IntPtr NativeFieldInfoPtr__primitiveConversions;

		// Token: 0x04001114 RID: 4372
		private static readonly IntPtr NativeMethodInfoPtr_BindToMethod_Public_Virtual_MethodBase_BindingFlags_Il2CppReferenceArray_1_MethodBase_byref_Il2CppReferenceArray_1_Object_Il2CppReferenceArray_1_ParameterModifier_CultureInfo_Il2CppStringArray_byref_Object_0;

		// Token: 0x04001115 RID: 4373
		private static readonly IntPtr NativeMethodInfoPtr_BindToField_Public_Virtual_FieldInfo_BindingFlags_Il2CppReferenceArray_1_FieldInfo_Object_CultureInfo_0;

		// Token: 0x04001116 RID: 4374
		private static readonly IntPtr NativeMethodInfoPtr_SelectProperty_Public_Virtual_PropertyInfo_BindingFlags_Il2CppReferenceArray_1_PropertyInfo_Type_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_ParameterModifier_0;

		// Token: 0x04001117 RID: 4375
		private static readonly IntPtr NativeMethodInfoPtr_ChangeType_Public_Virtual_Object_Object_Type_CultureInfo_0;

		// Token: 0x04001118 RID: 4376
		private static readonly IntPtr NativeMethodInfoPtr_ReorderArgumentArray_Public_Virtual_Void_byref_Il2CppReferenceArray_1_Object_Object_0;

		// Token: 0x04001119 RID: 4377
		private static readonly IntPtr NativeMethodInfoPtr_ExactBinding_Public_Static_MethodBase_Il2CppReferenceArray_1_MethodBase_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_ParameterModifier_0;

		// Token: 0x0400111A RID: 4378
		private static readonly IntPtr NativeMethodInfoPtr_ExactPropertyBinding_Public_Static_PropertyInfo_Il2CppReferenceArray_1_PropertyInfo_Type_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_ParameterModifier_0;

		// Token: 0x0400111B RID: 4379
		private static readonly IntPtr NativeMethodInfoPtr_FindMostSpecific_Private_Static_Int32_Il2CppReferenceArray_1_ParameterInfo_Il2CppStructArray_1_Int32_Type_Il2CppReferenceArray_1_ParameterInfo_Il2CppStructArray_1_Int32_Type_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_Object_0;

		// Token: 0x0400111C RID: 4380
		private static readonly IntPtr NativeMethodInfoPtr_FindMostSpecificType_Private_Static_Int32_Type_Type_Type_0;

		// Token: 0x0400111D RID: 4381
		private static readonly IntPtr NativeMethodInfoPtr_FindMostSpecificMethod_Private_Static_Int32_MethodBase_Il2CppStructArray_1_Int32_Type_MethodBase_Il2CppStructArray_1_Int32_Type_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_Object_0;

		// Token: 0x0400111E RID: 4382
		private static readonly IntPtr NativeMethodInfoPtr_FindMostSpecificField_Private_Static_Int32_FieldInfo_FieldInfo_0;

		// Token: 0x0400111F RID: 4383
		private static readonly IntPtr NativeMethodInfoPtr_FindMostSpecificProperty_Private_Static_Int32_PropertyInfo_PropertyInfo_0;

		// Token: 0x04001120 RID: 4384
		private static readonly IntPtr NativeMethodInfoPtr_CompareMethodSigAndName_Internal_Static_Boolean_MethodBase_MethodBase_0;

		// Token: 0x04001121 RID: 4385
		private static readonly IntPtr NativeMethodInfoPtr_GetHierarchyDepth_Internal_Static_Int32_Type_0;

		// Token: 0x04001122 RID: 4386
		private static readonly IntPtr NativeMethodInfoPtr_FindMostDerivedNewSlotMeth_Internal_Static_MethodBase_Il2CppReferenceArray_1_MethodBase_Int32_0;

		// Token: 0x04001123 RID: 4387
		private static readonly IntPtr NativeMethodInfoPtr_ReorderParams_Private_Static_Void_Il2CppStructArray_1_Int32_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04001124 RID: 4388
		private static readonly IntPtr NativeMethodInfoPtr_CreateParamOrder_Private_Static_Boolean_Il2CppStructArray_1_Int32_Il2CppReferenceArray_1_ParameterInfo_Il2CppStringArray_0;

		// Token: 0x04001125 RID: 4389
		private static readonly IntPtr NativeMethodInfoPtr_CanConvertPrimitive_Private_Static_Boolean_RuntimeType_RuntimeType_0;

		// Token: 0x04001126 RID: 4390
		private static readonly IntPtr NativeMethodInfoPtr_CanConvertPrimitiveObjectToType_Private_Static_Boolean_Object_RuntimeType_0;

		// Token: 0x04001127 RID: 4391
		private static readonly IntPtr NativeMethodInfoPtr_CompareMethodSig_Internal_Static_Boolean_MethodBase_MethodBase_0;

		// Token: 0x04001128 RID: 4392
		private static readonly IntPtr NativeMethodInfoPtr_SelectMethod_Public_Virtual_Final_MethodBase_BindingFlags_Il2CppReferenceArray_1_MethodBase_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_ParameterModifier_0;

		// Token: 0x04001129 RID: 4393
		private static readonly IntPtr NativeMethodInfoPtr_CanChangePrimitive_Private_Static_Boolean_Type_Type_0;

		// Token: 0x0400112A RID: 4394
		private static readonly IntPtr NativeMethodInfoPtr_CanPrimitiveWiden_Private_Static_Boolean_Type_Type_0;

		// Token: 0x0400112B RID: 4395
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020005E6 RID: 1510
		public class BinderState : Object
		{
			// Token: 0x06005753 RID: 22355 RVA: 0x00192D00 File Offset: 0x00190F00
			// Note: this type is marked as 'beforefieldinit'.
			static BinderState()
			{
				Il2CppClassPointerStore<DefaultBinder.BinderState>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DefaultBinder>.NativeClassPtr, "BinderState");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DefaultBinder.BinderState>.NativeClassPtr);
				DefaultBinder.BinderState.NativeFieldInfoPtr_m_argsMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultBinder.BinderState>.NativeClassPtr, "m_argsMap");
				DefaultBinder.BinderState.NativeFieldInfoPtr_m_originalSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultBinder.BinderState>.NativeClassPtr, "m_originalSize");
				DefaultBinder.BinderState.NativeFieldInfoPtr_m_isParamArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultBinder.BinderState>.NativeClassPtr, "m_isParamArray");
				DefaultBinder.BinderState.NativeMethodInfoPtr__ctor_Internal_Void_Il2CppStructArray_1_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultBinder.BinderState>.NativeClassPtr, 100666886);
			}

			// Token: 0x06005754 RID: 22356 RVA: 0x00192D7C File Offset: 0x00190F7C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1339048, XrefRangeEnd = 1339050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe BinderState(Il2CppStructArray<int> argsMap, int originalSize, bool isParamArray)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DefaultBinder.BinderState>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(argsMap);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref originalSize;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isParamArray;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultBinder.BinderState.NativeMethodInfoPtr__ctor_Internal_Void_Il2CppStructArray_1_Int32_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005755 RID: 22357 RVA: 0x0001EFE6 File Offset: 0x0001D1E6
			public BinderState(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700163F RID: 5695
			// (get) Token: 0x06005756 RID: 22358 RVA: 0x00192DE4 File Offset: 0x00190FE4
			// (set) Token: 0x06005757 RID: 22359 RVA: 0x0001EFEF File Offset: 0x0001D1EF
			public unsafe Il2CppStructArray<int> m_argsMap
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultBinder.BinderState.NativeFieldInfoPtr_m_argsMap);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultBinder.BinderState.NativeFieldInfoPtr_m_argsMap), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001640 RID: 5696
			// (get) Token: 0x06005758 RID: 22360 RVA: 0x00192E14 File Offset: 0x00191014
			// (set) Token: 0x06005759 RID: 22361 RVA: 0x0001F00E File Offset: 0x0001D20E
			public unsafe int m_originalSize
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultBinder.BinderState.NativeFieldInfoPtr_m_originalSize);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultBinder.BinderState.NativeFieldInfoPtr_m_originalSize)) = value;
				}
			}

			// Token: 0x17001641 RID: 5697
			// (get) Token: 0x0600575A RID: 22362 RVA: 0x00192E3C File Offset: 0x0019103C
			// (set) Token: 0x0600575B RID: 22363 RVA: 0x0001F029 File Offset: 0x0001D229
			public unsafe bool m_isParamArray
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultBinder.BinderState.NativeFieldInfoPtr_m_isParamArray);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultBinder.BinderState.NativeFieldInfoPtr_m_isParamArray)) = value;
				}
			}

			// Token: 0x040047A4 RID: 18340
			private static readonly IntPtr NativeFieldInfoPtr_m_argsMap;

			// Token: 0x040047A5 RID: 18341
			private static readonly IntPtr NativeFieldInfoPtr_m_originalSize;

			// Token: 0x040047A6 RID: 18342
			private static readonly IntPtr NativeFieldInfoPtr_m_isParamArray;

			// Token: 0x040047A7 RID: 18343
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Il2CppStructArray_1_Int32_Int32_Boolean_0;
		}

		// Token: 0x020005E7 RID: 1511
		[Flags]
		public enum Primitives
		{
			// Token: 0x040047A9 RID: 18345
			Boolean = 8,
			// Token: 0x040047AA RID: 18346
			Char = 16,
			// Token: 0x040047AB RID: 18347
			SByte = 32,
			// Token: 0x040047AC RID: 18348
			Byte = 64,
			// Token: 0x040047AD RID: 18349
			Int16 = 128,
			// Token: 0x040047AE RID: 18350
			UInt16 = 256,
			// Token: 0x040047AF RID: 18351
			Int32 = 512,
			// Token: 0x040047B0 RID: 18352
			UInt32 = 1024,
			// Token: 0x040047B1 RID: 18353
			Int64 = 2048,
			// Token: 0x040047B2 RID: 18354
			UInt64 = 4096,
			// Token: 0x040047B3 RID: 18355
			Single = 8192,
			// Token: 0x040047B4 RID: 18356
			Double = 16384,
			// Token: 0x040047B5 RID: 18357
			Decimal = 32768,
			// Token: 0x040047B6 RID: 18358
			DateTime = 65536,
			// Token: 0x040047B7 RID: 18359
			String = 262144
		}

		// Token: 0x020005E8 RID: 1512
		[ObfuscatedName("System.DefaultBinder+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x0600575C RID: 22364 RVA: 0x00192E64 File Offset: 0x00191064
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<DefaultBinder.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DefaultBinder>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DefaultBinder.__c>.NativeClassPtr);
				DefaultBinder.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultBinder.__c>.NativeClassPtr, "<>9");
				DefaultBinder.__c.NativeFieldInfoPtr___9__2_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultBinder.__c>.NativeClassPtr, "<>9__2_0");
				DefaultBinder.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultBinder.__c>.NativeClassPtr, 100666888);
				DefaultBinder.__c.NativeMethodInfoPtr__SelectProperty_b__2_0_Internal_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultBinder.__c>.NativeClassPtr, 100666889);
			}

			// Token: 0x0600575D RID: 22365 RVA: 0x00192EE0 File Offset: 0x001910E0
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DefaultBinder.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultBinder.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600575E RID: 22366 RVA: 0x00192F1C File Offset: 0x0019111C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1339050, XrefRangeEnd = 1339065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _SelectProperty_b__2_0(Type t)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultBinder.__c.NativeMethodInfoPtr__SelectProperty_b__2_0_Internal_Boolean_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600575F RID: 22367 RVA: 0x0001F044 File Offset: 0x0001D244
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001642 RID: 5698
			// (get) Token: 0x06005760 RID: 22368 RVA: 0x00192F6C File Offset: 0x0019116C
			// (set) Token: 0x06005761 RID: 22369 RVA: 0x0001F04D File Offset: 0x0001D24D
			public unsafe static DefaultBinder.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DefaultBinder.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DefaultBinder.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DefaultBinder.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001643 RID: 5699
			// (get) Token: 0x06005762 RID: 22370 RVA: 0x00192F94 File Offset: 0x00191194
			// (set) Token: 0x06005763 RID: 22371 RVA: 0x0001F05F File Offset: 0x0001D25F
			public unsafe static Predicate<Type> __9__2_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DefaultBinder.__c.NativeFieldInfoPtr___9__2_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Predicate<Type>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DefaultBinder.__c.NativeFieldInfoPtr___9__2_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040047B8 RID: 18360
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040047B9 RID: 18361
			private static readonly IntPtr NativeFieldInfoPtr___9__2_0;

			// Token: 0x040047BA RID: 18362
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040047BB RID: 18363
			private static readonly IntPtr NativeMethodInfoPtr__SelectProperty_b__2_0_Internal_Boolean_Type_0;
		}
	}
}
