using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;

namespace UnityEngine
{
	// Token: 0x02000177 RID: 375
	public class Transform : Component
	{
		// Token: 0x06001C09 RID: 7177 RVA: 0x0008014C File Offset: 0x0007E34C
		// Note: this type is marked as 'beforefieldinit'.
		static Transform()
		{
			Il2CppClassPointerStore<Transform>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "Transform");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Transform>.NativeClassPtr);
			Transform.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100667132);
			Transform.NativeMethodInfoPtr_get_position_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100667133);
			Transform.NativeMethodInfoPtr_set_position_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100667134);
			Transform.NativeMethodInfoPtr_get_localPosition_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100667135);
			Transform.NativeMethodInfoPtr_set_localPosition_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100667136);
			Transform.NativeMethodInfoPtr_GetLocalEulerAngles_Internal_Vector3_RotationOrder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100667137);
			Transform.NativeMethodInfoPtr_SetLocalEulerAngles_Internal_Void_Vector3_RotationOrder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100667138);
			Transform.NativeMethodInfoPtr_SetLocalEulerHint_Internal_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100667139);
			Transform.NativeMethodInfoPtr_get_eulerAngles_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100667140);
			Transform.NativeMethodInfoPtr_set_eulerAngles_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100667141);
			Transform.NativeMethodInfoPtr_get_localEulerAngles_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100667142);
			Transform.NativeMethodInfoPtr_set_localEulerAngles_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100667143);
			Transform.NativeMethodInfoPtr_get_right_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100667144);
			Transform.NativeMethodInfoPtr_set_right_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100667145);
			Transform.NativeMethodInfoPtr_get_up_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100667146);
			Transform.NativeMethodInfoPtr_set_up_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100667147);
			Transform.NativeMethodInfoPtr_get_forward_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100667148);
			Transform.NativeMethodInfoPtr_set_forward_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100667149);
			Transform.NativeMethodInfoPtr_get_rotation_Public_get_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100667150);
			Transform.NativeMethodInfoPtr_set_rotation_Public_set_Void_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100667151);
			Transform.NativeMethodInfoPtr_get_localRotation_Public_get_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100667152);
			Transform.NativeMethodInfoPtr_set_localRotation_Public_set_Void_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100667153);
			Transform.NativeMethodInfoPtr_get_rotationOrder_Internal_get_RotationOrder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100667154);
			Transform.NativeMethodInfoPtr_set_rotationOrder_Internal_set_Void_RotationOrder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100667155);
			Transform.NativeMethodInfoPtr_GetRotationOrderInternal_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100667156);
			Transform.NativeMethodInfoPtr_SetRotationOrderInternal_Internal_Void_RotationOrder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100667157);
			Transform.NativeMethodInfoPtr_get_localScale_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100667158);
			Transform.NativeMethodInfoPtr_set_localScale_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100667159);
			Transform.NativeMethodInfoPtr_get_parent_Public_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100667160);
			Transform.NativeMethodInfoPtr_set_parent_Public_set_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100667161);
			Transform.NativeMethodInfoPtr_get_parentInternal_Internal_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100667162);
			Transform.NativeMethodInfoPtr_set_parentInternal_Internal_set_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100667163);
			Transform.NativeMethodInfoPtr_GetParent_Private_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100667164);
			Transform.NativeMethodInfoPtr_SetParent_Public_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100667165);
			Transform.NativeMethodInfoPtr_SetParent_Public_Void_Transform_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100667166);
			Transform.NativeMethodInfoPtr_get_worldToLocalMatrix_Public_get_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100667167);
			Transform.NativeMethodInfoPtr_get_localToWorldMatrix_Public_get_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100667168);
			Transform.NativeMethodInfoPtr_SetPositionAndRotation_Public_Void_Vector3_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100667169);
			Transform.NativeMethodInfoPtr_SetLocalPositionAndRotation_Public_Void_Vector3_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100667170);
			Transform.NativeMethodInfoPtr_GetPositionAndRotation_Public_Void_byref_Vector3_byref_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100667171);
			Transform.NativeMethodInfoPtr_GetLocalPositionAndRotation_Public_Void_byref_Vector3_byref_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100667172);
			Transform.NativeMethodInfoPtr_Translate_Public_Void_Vector3_Space_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100667173);
			Transform.NativeMethodInfoPtr_Translate_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100667174);
			Transform.NativeMethodInfoPtr_Translate_Public_Void_Single_Single_Single_Space_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100667175);
			Transform.NativeMethodInfoPtr_Translate_Public_Void_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100667176);
			Transform.NativeMethodInfoPtr_Translate_Public_Void_Vector3_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100667177);
			Transform.NativeMethodInfoPtr_Translate_Public_Void_Single_Single_Single_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100667178);
			Transform.NativeMethodInfoPtr_Rotate_Public_Void_Vector3_Space_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100667179);
			Transform.NativeMethodInfoPtr_Rotate_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100667180);
			Transform.NativeMethodInfoPtr_Rotate_Public_Void_Single_Single_Single_Space_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100667181);
			Transform.NativeMethodInfoPtr_Rotate_Public_Void_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100667182);
			Transform.NativeMethodInfoPtr_RotateAroundInternal_Internal_Void_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100667183);
			Transform.NativeMethodInfoPtr_Rotate_Public_Void_Vector3_Single_Space_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100667184);
			Transform.NativeMethodInfoPtr_Rotate_Public_Void_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100667185);
			Transform.NativeMethodInfoPtr_RotateAround_Public_Void_Vector3_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100667186);
			Transform.NativeMethodInfoPtr_LookAt_Public_Void_Transform_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100667187);
			Transform.NativeMethodInfoPtr_LookAt_Public_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100667188);
			Transform.NativeMethodInfoPtr_LookAt_Public_Void_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100667189);
			Transform.NativeMethodInfoPtr_LookAt_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100667190);
			Transform.NativeMethodInfoPtr_Internal_LookAt_Private_Void_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100667191);
			Transform.NativeMethodInfoPtr_TransformDirection_Public_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100667192);
			Transform.NativeMethodInfoPtr_TransformDirection_Public_Vector3_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100667193);
			Transform.NativeMethodInfoPtr_TransformDirections_Internal_Void_ptr_Vector3_Int32_ptr_Vector3_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100667194);
			Transform.NativeMethodInfoPtr_TransformDirections_Public_Void_ReadOnlySpan_1_Vector3_Span_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100667195);
			Transform.NativeMethodInfoPtr_TransformDirections_Public_Void_Span_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100667196);
			Transform.NativeMethodInfoPtr_InverseTransformDirection_Public_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100667197);
			Transform.NativeMethodInfoPtr_InverseTransformDirection_Public_Vector3_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100667198);
			Transform.NativeMethodInfoPtr_InverseTransformDirections_Internal_Void_ptr_Vector3_Int32_ptr_Vector3_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100667199);
			Transform.NativeMethodInfoPtr_InverseTransformDirections_Public_Void_ReadOnlySpan_1_Vector3_Span_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100667200);
			Transform.NativeMethodInfoPtr_InverseTransformDirections_Public_Void_Span_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100667201);
			Transform.NativeMethodInfoPtr_TransformVector_Public_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100667202);
			Transform.NativeMethodInfoPtr_TransformVector_Public_Vector3_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100667203);
			Transform.NativeMethodInfoPtr_TransformVectors_Internal_Void_ptr_Vector3_Int32_ptr_Vector3_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100667204);
			Transform.NativeMethodInfoPtr_TransformVectors_Public_Void_ReadOnlySpan_1_Vector3_Span_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100667205);
			Transform.NativeMethodInfoPtr_TransformVectors_Public_Void_Span_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100667206);
			Transform.NativeMethodInfoPtr_InverseTransformVector_Public_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100667207);
			Transform.NativeMethodInfoPtr_InverseTransformVector_Public_Vector3_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100667208);
			Transform.NativeMethodInfoPtr_InverseTransformVectors_Internal_Void_ptr_Vector3_Int32_ptr_Vector3_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100667209);
			Transform.NativeMethodInfoPtr_InverseTransformVectors_Public_Void_ReadOnlySpan_1_Vector3_Span_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100667210);
			Transform.NativeMethodInfoPtr_InverseTransformVectors_Public_Void_Span_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100667211);
			Transform.NativeMethodInfoPtr_TransformPoint_Public_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100667212);
			Transform.NativeMethodInfoPtr_TransformPoint_Public_Vector3_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100667213);
			Transform.NativeMethodInfoPtr_TransformPoints_Internal_Void_ptr_Vector3_Int32_ptr_Vector3_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100667214);
			Transform.NativeMethodInfoPtr_TransformPoints_Public_Void_ReadOnlySpan_1_Vector3_Span_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100667215);
			Transform.NativeMethodInfoPtr_TransformPoints_Public_Void_Span_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100667216);
			Transform.NativeMethodInfoPtr_InverseTransformPoint_Public_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100667217);
			Transform.NativeMethodInfoPtr_InverseTransformPoint_Public_Vector3_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100667218);
			Transform.NativeMethodInfoPtr_InverseTransformPoints_Internal_Void_ptr_Vector3_Int32_ptr_Vector3_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100667219);
			Transform.NativeMethodInfoPtr_InverseTransformPoints_Public_Void_ReadOnlySpan_1_Vector3_Span_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100667220);
			Transform.NativeMethodInfoPtr_InverseTransformPoints_Public_Void_Span_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100667221);
			Transform.NativeMethodInfoPtr_get_root_Public_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100667222);
			Transform.NativeMethodInfoPtr_GetRoot_Private_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100667223);
			Transform.NativeMethodInfoPtr_get_childCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100667224);
			Transform.NativeMethodInfoPtr_DetachChildren_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100667225);
			Transform.NativeMethodInfoPtr_SetAsFirstSibling_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100667226);
			Transform.NativeMethodInfoPtr_SetAsLastSibling_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100667227);
			Transform.NativeMethodInfoPtr_SetSiblingIndex_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100667228);
			Transform.NativeMethodInfoPtr_MoveAfterSibling_Internal_Void_Transform_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100667229);
			Transform.NativeMethodInfoPtr_GetSiblingIndex_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100667230);
			Transform.NativeMethodInfoPtr_FindRelativeTransformWithPath_Private_Static_Transform_Transform_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100667231);
			Transform.NativeMethodInfoPtr_Find_Public_Transform_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100667232);
			Transform.NativeMethodInfoPtr_SendTransformChangedScale_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100667233);
			Transform.NativeMethodInfoPtr_get_lossyScale_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100667234);
			Transform.NativeMethodInfoPtr_IsChildOf_Public_Boolean_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100667235);
			Transform.NativeMethodInfoPtr_get_hasChanged_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100667236);
			Transform.NativeMethodInfoPtr_set_hasChanged_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100667237);
			Transform.NativeMethodInfoPtr_FindChild_Public_Transform_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100667238);
			Transform.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100667239);
			Transform.NativeMethodInfoPtr_RotateAround_Public_Void_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100667240);
			Transform.NativeMethodInfoPtr_RotateAroundLocal_Public_Void_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100667241);
			Transform.NativeMethodInfoPtr_GetChild_Public_Transform_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100667242);
			Transform.NativeMethodInfoPtr_GetChildCount_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100667243);
			Transform.NativeMethodInfoPtr_get_hierarchyCapacity_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100667244);
			Transform.NativeMethodInfoPtr_set_hierarchyCapacity_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100667245);
			Transform.NativeMethodInfoPtr_internal_getHierarchyCapacity_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100667246);
			Transform.NativeMethodInfoPtr_internal_setHierarchyCapacity_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100667247);
			Transform.NativeMethodInfoPtr_get_hierarchyCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100667248);
			Transform.NativeMethodInfoPtr_internal_getHierarchyCount_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100667249);
			Transform.NativeMethodInfoPtr_IsNonUniformScaleTransform_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100667250);
			Transform.NativeMethodInfoPtr_get_constrainProportionsScale_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100667251);
			Transform.NativeMethodInfoPtr_set_constrainProportionsScale_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100667252);
			Transform.NativeMethodInfoPtr_SetConstrainProportionsScale_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100667253);
			Transform.NativeMethodInfoPtr_IsConstrainProportionsScale_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100667254);
			Transform.NativeMethodInfoPtr_get_position_Injected_Private_Void_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100667255);
			Transform.NativeMethodInfoPtr_set_position_Injected_Private_Void_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100667256);
			Transform.NativeMethodInfoPtr_get_localPosition_Injected_Private_Void_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100667257);
			Transform.NativeMethodInfoPtr_set_localPosition_Injected_Private_Void_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100667258);
			Transform.NativeMethodInfoPtr_GetLocalEulerAngles_Injected_Private_Void_RotationOrder_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100667259);
			Transform.NativeMethodInfoPtr_SetLocalEulerAngles_Injected_Private_Void_byref_Vector3_RotationOrder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100667260);
			Transform.NativeMethodInfoPtr_SetLocalEulerHint_Injected_Private_Void_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100667261);
			Transform.NativeMethodInfoPtr_get_rotation_Injected_Private_Void_byref_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100667262);
			Transform.NativeMethodInfoPtr_set_rotation_Injected_Private_Void_byref_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100667263);
			Transform.NativeMethodInfoPtr_get_localRotation_Injected_Private_Void_byref_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100667264);
			Transform.NativeMethodInfoPtr_set_localRotation_Injected_Private_Void_byref_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100667265);
			Transform.NativeMethodInfoPtr_get_localScale_Injected_Private_Void_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100667266);
			Transform.NativeMethodInfoPtr_set_localScale_Injected_Private_Void_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100667267);
			Transform.NativeMethodInfoPtr_get_worldToLocalMatrix_Injected_Private_Void_byref_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100667268);
			Transform.NativeMethodInfoPtr_get_localToWorldMatrix_Injected_Private_Void_byref_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100667269);
			Transform.NativeMethodInfoPtr_SetPositionAndRotation_Injected_Private_Void_byref_Vector3_byref_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100667270);
			Transform.NativeMethodInfoPtr_SetLocalPositionAndRotation_Injected_Private_Void_byref_Vector3_byref_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100667271);
			Transform.NativeMethodInfoPtr_RotateAroundInternal_Injected_Private_Void_byref_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100667272);
			Transform.NativeMethodInfoPtr_Internal_LookAt_Injected_Private_Void_byref_Vector3_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100667273);
			Transform.NativeMethodInfoPtr_TransformDirection_Injected_Private_Void_byref_Vector3_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100667274);
			Transform.NativeMethodInfoPtr_InverseTransformDirection_Injected_Private_Void_byref_Vector3_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100667275);
			Transform.NativeMethodInfoPtr_TransformVector_Injected_Private_Void_byref_Vector3_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100667276);
			Transform.NativeMethodInfoPtr_InverseTransformVector_Injected_Private_Void_byref_Vector3_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100667277);
			Transform.NativeMethodInfoPtr_TransformPoint_Injected_Private_Void_byref_Vector3_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100667278);
			Transform.NativeMethodInfoPtr_InverseTransformPoint_Injected_Private_Void_byref_Vector3_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100667279);
			Transform.NativeMethodInfoPtr_get_lossyScale_Injected_Private_Void_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100667280);
			Transform.NativeMethodInfoPtr_RotateAround_Injected_Private_Void_byref_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100667281);
			Transform.NativeMethodInfoPtr_RotateAroundLocal_Injected_Private_Void_byref_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100667282);
		}

		// Token: 0x06001C0A RID: 7178 RVA: 0x00080D48 File Offset: 0x0007EF48
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Transform()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Transform>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170005E1 RID: 1505
		// (get) Token: 0x06001C0B RID: 7179 RVA: 0x00080D84 File Offset: 0x0007EF84
		// (set) Token: 0x06001C0C RID: 7180 RVA: 0x00080DC0 File Offset: 0x0007EFC0
		public unsafe Vector3 position
		{
			[CallerCount(239)]
			[CachedScanResults(RefRangeStart = 675233, RefRangeEnd = 675472, XrefRangeStart = 675231, XrefRangeEnd = 675233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_get_position_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(66)]
			[CachedScanResults(RefRangeStart = 675474, RefRangeEnd = 675540, XrefRangeStart = 675472, XrefRangeEnd = 675474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_set_position_Public_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170005E2 RID: 1506
		// (get) Token: 0x06001C0D RID: 7181 RVA: 0x00080E00 File Offset: 0x0007F000
		// (set) Token: 0x06001C0E RID: 7182 RVA: 0x00080E3C File Offset: 0x0007F03C
		public unsafe Vector3 localPosition
		{
			[CallerCount(50)]
			[CachedScanResults(RefRangeStart = 675542, RefRangeEnd = 675592, XrefRangeStart = 675540, XrefRangeEnd = 675542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_get_localPosition_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(42)]
			[CachedScanResults(RefRangeStart = 675594, RefRangeEnd = 675636, XrefRangeStart = 675592, XrefRangeEnd = 675594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_set_localPosition_Public_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001C0F RID: 7183 RVA: 0x00080E7C File Offset: 0x0007F07C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 675636, XrefRangeEnd = 675638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 GetLocalEulerAngles(RotationOrder order)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref order;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_GetLocalEulerAngles_Internal_Vector3_RotationOrder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001C10 RID: 7184 RVA: 0x00080EC8 File Offset: 0x0007F0C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 675638, XrefRangeEnd = 675640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetLocalEulerAngles(Vector3 euler, RotationOrder order)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref euler;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref order;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_SetLocalEulerAngles_Internal_Void_Vector3_RotationOrder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C11 RID: 7185 RVA: 0x00080F14 File Offset: 0x0007F114
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 675640, XrefRangeEnd = 675642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetLocalEulerHint(Vector3 euler)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref euler;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_SetLocalEulerHint_Internal_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170005E3 RID: 1507
		// (get) Token: 0x06001C12 RID: 7186 RVA: 0x00080F54 File Offset: 0x0007F154
		// (set) Token: 0x06001C13 RID: 7187 RVA: 0x00080F90 File Offset: 0x0007F190
		public unsafe Vector3 eulerAngles
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 675646, RefRangeEnd = 675647, XrefRangeStart = 675642, XrefRangeEnd = 675646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_get_eulerAngles_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 675650, RefRangeEnd = 675652, XrefRangeStart = 675647, XrefRangeEnd = 675650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_set_eulerAngles_Public_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170005E4 RID: 1508
		// (get) Token: 0x06001C14 RID: 7188 RVA: 0x00080FD0 File Offset: 0x0007F1D0
		// (set) Token: 0x06001C15 RID: 7189 RVA: 0x0008100C File Offset: 0x0007F20C
		public unsafe Vector3 localEulerAngles
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 675656, RefRangeEnd = 675664, XrefRangeStart = 675652, XrefRangeEnd = 675656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_get_localEulerAngles_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 675664, XrefRangeEnd = 675667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_set_localEulerAngles_Public_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170005E5 RID: 1509
		// (get) Token: 0x06001C16 RID: 7190 RVA: 0x0008104C File Offset: 0x0007F24C
		// (set) Token: 0x06001C17 RID: 7191 RVA: 0x00081088 File Offset: 0x0007F288
		public unsafe Vector3 right
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 675672, RefRangeEnd = 675677, XrefRangeStart = 675667, XrefRangeEnd = 675672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_get_right_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 675677, XrefRangeEnd = 675682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_set_right_Public_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170005E6 RID: 1510
		// (get) Token: 0x06001C18 RID: 7192 RVA: 0x000810C8 File Offset: 0x0007F2C8
		// (set) Token: 0x06001C19 RID: 7193 RVA: 0x00081104 File Offset: 0x0007F304
		public unsafe Vector3 up
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 675687, RefRangeEnd = 675699, XrefRangeStart = 675682, XrefRangeEnd = 675687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_get_up_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 675699, XrefRangeEnd = 675704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_set_up_Public_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170005E7 RID: 1511
		// (get) Token: 0x06001C1A RID: 7194 RVA: 0x00081144 File Offset: 0x0007F344
		// (set) Token: 0x06001C1B RID: 7195 RVA: 0x00081180 File Offset: 0x0007F380
		public unsafe Vector3 forward
		{
			[CallerCount(25)]
			[CachedScanResults(RefRangeStart = 675709, RefRangeEnd = 675734, XrefRangeStart = 675704, XrefRangeEnd = 675709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_get_forward_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 675734, XrefRangeEnd = 675737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_set_forward_Public_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170005E8 RID: 1512
		// (get) Token: 0x06001C1C RID: 7196 RVA: 0x000811C0 File Offset: 0x0007F3C0
		// (set) Token: 0x06001C1D RID: 7197 RVA: 0x000811FC File Offset: 0x0007F3FC
		public unsafe Quaternion rotation
		{
			[CallerCount(54)]
			[CachedScanResults(RefRangeStart = 675739, RefRangeEnd = 675793, XrefRangeStart = 675737, XrefRangeEnd = 675739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_get_rotation_Public_get_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(28)]
			[CachedScanResults(RefRangeStart = 675795, RefRangeEnd = 675823, XrefRangeStart = 675793, XrefRangeEnd = 675795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_set_rotation_Public_set_Void_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170005E9 RID: 1513
		// (get) Token: 0x06001C1E RID: 7198 RVA: 0x0008123C File Offset: 0x0007F43C
		// (set) Token: 0x06001C1F RID: 7199 RVA: 0x00081278 File Offset: 0x0007F478
		public unsafe Quaternion localRotation
		{
			[CallerCount(16)]
			[CachedScanResults(RefRangeStart = 675825, RefRangeEnd = 675841, XrefRangeStart = 675823, XrefRangeEnd = 675825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_get_localRotation_Public_get_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(18)]
			[CachedScanResults(RefRangeStart = 675843, RefRangeEnd = 675861, XrefRangeStart = 675841, XrefRangeEnd = 675843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_set_localRotation_Public_set_Void_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170005EA RID: 1514
		// (get) Token: 0x06001C20 RID: 7200 RVA: 0x000812B8 File Offset: 0x0007F4B8
		// (set) Token: 0x06001C21 RID: 7201 RVA: 0x000812F4 File Offset: 0x0007F4F4
		public unsafe RotationOrder rotationOrder
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 675861, XrefRangeEnd = 675863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_get_rotationOrder_Internal_get_RotationOrder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 675863, XrefRangeEnd = 675865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_set_rotationOrder_Internal_set_Void_RotationOrder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001C22 RID: 7202 RVA: 0x00081334 File Offset: 0x0007F534
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetRotationOrderInternal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_GetRotationOrderInternal_Internal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C23 RID: 7203 RVA: 0x00081370 File Offset: 0x0007F570
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetRotationOrderInternal(RotationOrder rotationOrder)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref rotationOrder;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_SetRotationOrderInternal_Internal_Void_RotationOrder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170005EB RID: 1515
		// (get) Token: 0x06001C24 RID: 7204 RVA: 0x000813B0 File Offset: 0x0007F5B0
		// (set) Token: 0x06001C25 RID: 7205 RVA: 0x000813EC File Offset: 0x0007F5EC
		public unsafe Vector3 localScale
		{
			[CallerCount(34)]
			[CachedScanResults(RefRangeStart = 675867, RefRangeEnd = 675901, XrefRangeStart = 675865, XrefRangeEnd = 675867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_get_localScale_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(38)]
			[CachedScanResults(RefRangeStart = 675903, RefRangeEnd = 675941, XrefRangeStart = 675901, XrefRangeEnd = 675903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_set_localScale_Public_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170005EC RID: 1516
		// (get) Token: 0x06001C26 RID: 7206 RVA: 0x0008142C File Offset: 0x0007F62C
		// (set) Token: 0x06001C27 RID: 7207 RVA: 0x0008146C File Offset: 0x0007F66C
		public unsafe Transform parent
		{
			[CallerCount(160)]
			[CachedScanResults(RefRangeStart = 675943, RefRangeEnd = 676103, XrefRangeStart = 675941, XrefRangeEnd = 675943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_get_parent_Public_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
			}
			[CallerCount(18)]
			[CachedScanResults(RefRangeStart = 676113, RefRangeEnd = 676131, XrefRangeStart = 676103, XrefRangeEnd = 676113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_set_parent_Public_set_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170005ED RID: 1517
		// (get) Token: 0x06001C28 RID: 7208 RVA: 0x000814B0 File Offset: 0x0007F6B0
		// (set) Token: 0x06001C29 RID: 7209 RVA: 0x000814F0 File Offset: 0x0007F6F0
		public unsafe Transform parentInternal
		{
			[CallerCount(160)]
			[CachedScanResults(RefRangeStart = 675943, RefRangeEnd = 676103, XrefRangeStart = 675943, XrefRangeEnd = 676103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_get_parentInternal_Internal_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
			}
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 676133, RefRangeEnd = 676148, XrefRangeStart = 676131, XrefRangeEnd = 676133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_set_parentInternal_Internal_set_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001C2A RID: 7210 RVA: 0x00081534 File Offset: 0x0007F734
		[CallerCount(160)]
		[CachedScanResults(RefRangeStart = 675943, RefRangeEnd = 676103, XrefRangeStart = 675943, XrefRangeEnd = 676103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Transform GetParent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_GetParent_Private_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
		}

		// Token: 0x06001C2B RID: 7211 RVA: 0x00081574 File Offset: 0x0007F774
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 676133, RefRangeEnd = 676148, XrefRangeStart = 676133, XrefRangeEnd = 676148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetParent(Transform p)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_SetParent_Public_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001C2C RID: 7212 RVA: 0x000815B8 File Offset: 0x0007F7B8
		[CallerCount(27)]
		[CachedScanResults(RefRangeStart = 676150, RefRangeEnd = 676177, XrefRangeStart = 676148, XrefRangeEnd = 676150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetParent(Transform parent, bool worldPositionStays)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(parent);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref worldPositionStays;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_SetParent_Public_Void_Transform_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170005EE RID: 1518
		// (get) Token: 0x06001C2D RID: 7213 RVA: 0x00081608 File Offset: 0x0007F808
		public unsafe Matrix4x4 worldToLocalMatrix
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 676179, RefRangeEnd = 676182, XrefRangeStart = 676177, XrefRangeEnd = 676179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_get_worldToLocalMatrix_Public_get_Matrix4x4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005EF RID: 1519
		// (get) Token: 0x06001C2E RID: 7214 RVA: 0x00081644 File Offset: 0x0007F844
		public unsafe Matrix4x4 localToWorldMatrix
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 676184, RefRangeEnd = 676198, XrefRangeStart = 676182, XrefRangeEnd = 676184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_get_localToWorldMatrix_Public_get_Matrix4x4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001C2F RID: 7215 RVA: 0x00081680 File Offset: 0x0007F880
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 676198, XrefRangeEnd = 676200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPositionAndRotation(Vector3 position, Quaternion rotation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref position;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_SetPositionAndRotation_Public_Void_Vector3_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C30 RID: 7216 RVA: 0x000816CC File Offset: 0x0007F8CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 676200, XrefRangeEnd = 676202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetLocalPositionAndRotation(Vector3 localPosition, Quaternion localRotation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref localPosition;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref localRotation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_SetLocalPositionAndRotation_Public_Void_Vector3_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C31 RID: 7217 RVA: 0x00081718 File Offset: 0x0007F918
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 676202, XrefRangeEnd = 676204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetPositionAndRotation(out Vector3 position, out Quaternion rotation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &position;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &rotation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_GetPositionAndRotation_Public_Void_byref_Vector3_byref_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C32 RID: 7218 RVA: 0x00081764 File Offset: 0x0007F964
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 676204, XrefRangeEnd = 676206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetLocalPositionAndRotation(out Vector3 localPosition, out Quaternion localRotation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &localPosition;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &localRotation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_GetLocalPositionAndRotation_Public_Void_byref_Vector3_byref_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C33 RID: 7219 RVA: 0x000817B0 File Offset: 0x0007F9B0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 676217, RefRangeEnd = 676219, XrefRangeStart = 676206, XrefRangeEnd = 676217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Translate(Vector3 translation, Space relativeTo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref translation;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref relativeTo;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_Translate_Public_Void_Vector3_Space_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C34 RID: 7220 RVA: 0x000817FC File Offset: 0x0007F9FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 676219, XrefRangeEnd = 676225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Translate(Vector3 translation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref translation;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_Translate_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001C35 RID: 7221 RVA: 0x0008183C File Offset: 0x0007FA3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 676225, XrefRangeEnd = 676226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Translate(float x, float y, float z, Space relativeTo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref z;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref relativeTo;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_Translate_Public_Void_Single_Single_Single_Space_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C36 RID: 7222 RVA: 0x000818A4 File Offset: 0x0007FAA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 676226, XrefRangeEnd = 676232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Translate(float x, float y, float z)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref z;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_Translate_Public_Void_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C37 RID: 7223 RVA: 0x00081900 File Offset: 0x0007FB00
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 676240, RefRangeEnd = 676241, XrefRangeStart = 676232, XrefRangeEnd = 676240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Translate(Vector3 translation, Transform relativeTo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref translation;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(relativeTo);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_Translate_Public_Void_Vector3_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C38 RID: 7224 RVA: 0x00081950 File Offset: 0x0007FB50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 676241, XrefRangeEnd = 676242, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Translate(float x, float y, float z, Transform relativeTo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref z;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(relativeTo);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_Translate_Public_Void_Single_Single_Single_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C39 RID: 7225 RVA: 0x000819C0 File Offset: 0x0007FBC0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 676257, RefRangeEnd = 676260, XrefRangeStart = 676242, XrefRangeEnd = 676257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Rotate(Vector3 eulers, Space relativeTo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref eulers;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref relativeTo;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_Rotate_Public_Void_Vector3_Space_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C3A RID: 7226 RVA: 0x00081A0C File Offset: 0x0007FC0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 676260, XrefRangeEnd = 676261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Rotate(Vector3 eulers)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref eulers;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_Rotate_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001C3B RID: 7227 RVA: 0x00081A4C File Offset: 0x0007FC4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 676261, XrefRangeEnd = 676262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Rotate(float xAngle, float yAngle, float zAngle, Space relativeTo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref xAngle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref yAngle;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref zAngle;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref relativeTo;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_Rotate_Public_Void_Single_Single_Single_Space_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C3C RID: 7228 RVA: 0x00081AB4 File Offset: 0x0007FCB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 676262, XrefRangeEnd = 676263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Rotate(float xAngle, float yAngle, float zAngle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref xAngle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref yAngle;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref zAngle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_Rotate_Public_Void_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C3D RID: 7229 RVA: 0x00081B10 File Offset: 0x0007FD10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 676263, XrefRangeEnd = 676265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RotateAroundInternal(Vector3 axis, float angle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref axis;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref angle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_RotateAroundInternal_Internal_Void_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C3E RID: 7230 RVA: 0x00081B5C File Offset: 0x0007FD5C
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 676267, RefRangeEnd = 676281, XrefRangeStart = 676265, XrefRangeEnd = 676267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Rotate(Vector3 axis, float angle, Space relativeTo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref axis;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref angle;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref relativeTo;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_Rotate_Public_Void_Vector3_Single_Space_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C3F RID: 7231 RVA: 0x00081BB8 File Offset: 0x0007FDB8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 676286, RefRangeEnd = 676287, XrefRangeStart = 676281, XrefRangeEnd = 676286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Rotate(Vector3 axis, float angle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref axis;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref angle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_Rotate_Public_Void_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C40 RID: 7232 RVA: 0x00081C04 File Offset: 0x0007FE04
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 676295, RefRangeEnd = 676296, XrefRangeStart = 676287, XrefRangeEnd = 676295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RotateAround(Vector3 point, Vector3 axis, float angle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref point;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref axis;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref angle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_RotateAround_Public_Void_Vector3_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C41 RID: 7233 RVA: 0x00081C60 File Offset: 0x0007FE60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 676296, XrefRangeEnd = 676304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LookAt(Transform target, Vector3 worldUp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref worldUp;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_LookAt_Public_Void_Transform_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C42 RID: 7234 RVA: 0x00081CB0 File Offset: 0x0007FEB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 676304, XrefRangeEnd = 676314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LookAt(Transform target)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_LookAt_Public_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001C43 RID: 7235 RVA: 0x00081CF4 File Offset: 0x0007FEF4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 676316, RefRangeEnd = 676317, XrefRangeStart = 676314, XrefRangeEnd = 676316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LookAt(Vector3 worldPosition, Vector3 worldUp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref worldPosition;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref worldUp;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_LookAt_Public_Void_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C44 RID: 7236 RVA: 0x00081D40 File Offset: 0x0007FF40
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 676321, RefRangeEnd = 676323, XrefRangeStart = 676317, XrefRangeEnd = 676321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LookAt(Vector3 worldPosition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref worldPosition;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_LookAt_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001C45 RID: 7237 RVA: 0x00081D80 File Offset: 0x0007FF80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 676323, XrefRangeEnd = 676325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Internal_LookAt(Vector3 worldPosition, Vector3 worldUp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref worldPosition;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref worldUp;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_Internal_LookAt_Private_Void_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C46 RID: 7238 RVA: 0x00081DCC File Offset: 0x0007FFCC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 676327, RefRangeEnd = 676329, XrefRangeStart = 676325, XrefRangeEnd = 676327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 TransformDirection(Vector3 direction)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref direction;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_TransformDirection_Public_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001C47 RID: 7239 RVA: 0x00081E18 File Offset: 0x00080018
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 676329, XrefRangeEnd = 676331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 TransformDirection(float x, float y, float z)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref z;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_TransformDirection_Public_Vector3_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C48 RID: 7240 RVA: 0x00081E80 File Offset: 0x00080080
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 676331, XrefRangeEnd = 676333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TransformDirections(Vector3* directions, int count, Vector3* transformedDirections, int transformedCount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = directions;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = transformedDirections;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref transformedCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_TransformDirections_Internal_Void_ptr_Vector3_Int32_ptr_Vector3_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C49 RID: 7241 RVA: 0x00081EE8 File Offset: 0x000800E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 676333, XrefRangeEnd = 676343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TransformDirections(ReadOnlySpan<Vector3> directions, Span<Vector3> transformedDirections)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(directions));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(transformedDirections));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_TransformDirections_Public_Void_ReadOnlySpan_1_Vector3_Span_1_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C4A RID: 7242 RVA: 0x00081F48 File Offset: 0x00080148
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 676343, XrefRangeEnd = 676356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TransformDirections(Span<Vector3> directions)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(directions));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_TransformDirections_Public_Void_Span_1_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001C4B RID: 7243 RVA: 0x00081F90 File Offset: 0x00080190
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 676356, XrefRangeEnd = 676358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 InverseTransformDirection(Vector3 direction)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref direction;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_InverseTransformDirection_Public_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001C4C RID: 7244 RVA: 0x00081FDC File Offset: 0x000801DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 676358, XrefRangeEnd = 676360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 InverseTransformDirection(float x, float y, float z)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref z;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_InverseTransformDirection_Public_Vector3_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C4D RID: 7245 RVA: 0x00082044 File Offset: 0x00080244
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 676360, XrefRangeEnd = 676362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InverseTransformDirections(Vector3* directions, int count, Vector3* transformedDirections, int transformedCount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = directions;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = transformedDirections;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref transformedCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_InverseTransformDirections_Internal_Void_ptr_Vector3_Int32_ptr_Vector3_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C4E RID: 7246 RVA: 0x000820AC File Offset: 0x000802AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 676362, XrefRangeEnd = 676372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InverseTransformDirections(ReadOnlySpan<Vector3> directions, Span<Vector3> transformedDirections)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(directions));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(transformedDirections));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_InverseTransformDirections_Public_Void_ReadOnlySpan_1_Vector3_Span_1_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C4F RID: 7247 RVA: 0x0008210C File Offset: 0x0008030C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 676372, XrefRangeEnd = 676385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InverseTransformDirections(Span<Vector3> directions)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(directions));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_InverseTransformDirections_Public_Void_Span_1_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001C50 RID: 7248 RVA: 0x00082154 File Offset: 0x00080354
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 676387, RefRangeEnd = 676389, XrefRangeStart = 676385, XrefRangeEnd = 676387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 TransformVector(Vector3 vector)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref vector;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_TransformVector_Public_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001C51 RID: 7249 RVA: 0x000821A0 File Offset: 0x000803A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 676389, XrefRangeEnd = 676391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 TransformVector(float x, float y, float z)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref z;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_TransformVector_Public_Vector3_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C52 RID: 7250 RVA: 0x00082208 File Offset: 0x00080408
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 676391, XrefRangeEnd = 676393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TransformVectors(Vector3* vectors, int count, Vector3* transformedVectors, int transformedCount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = vectors;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = transformedVectors;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref transformedCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_TransformVectors_Internal_Void_ptr_Vector3_Int32_ptr_Vector3_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C53 RID: 7251 RVA: 0x00082270 File Offset: 0x00080470
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 676393, XrefRangeEnd = 676403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TransformVectors(ReadOnlySpan<Vector3> vectors, Span<Vector3> transformedVectors)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(vectors));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(transformedVectors));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_TransformVectors_Public_Void_ReadOnlySpan_1_Vector3_Span_1_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C54 RID: 7252 RVA: 0x000822D0 File Offset: 0x000804D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 676403, XrefRangeEnd = 676416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TransformVectors(Span<Vector3> vectors)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(vectors));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_TransformVectors_Public_Void_Span_1_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001C55 RID: 7253 RVA: 0x00082318 File Offset: 0x00080518
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 676416, XrefRangeEnd = 676418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 InverseTransformVector(Vector3 vector)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref vector;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_InverseTransformVector_Public_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001C56 RID: 7254 RVA: 0x00082364 File Offset: 0x00080564
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 676418, XrefRangeEnd = 676420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 InverseTransformVector(float x, float y, float z)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref z;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_InverseTransformVector_Public_Vector3_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C57 RID: 7255 RVA: 0x000823CC File Offset: 0x000805CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 676420, XrefRangeEnd = 676422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InverseTransformVectors(Vector3* vectors, int count, Vector3* transformedVectors, int transformedCount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = vectors;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = transformedVectors;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref transformedCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_InverseTransformVectors_Internal_Void_ptr_Vector3_Int32_ptr_Vector3_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C58 RID: 7256 RVA: 0x00082434 File Offset: 0x00080634
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 676422, XrefRangeEnd = 676432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InverseTransformVectors(ReadOnlySpan<Vector3> vectors, Span<Vector3> transformedVectors)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(vectors));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(transformedVectors));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_InverseTransformVectors_Public_Void_ReadOnlySpan_1_Vector3_Span_1_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C59 RID: 7257 RVA: 0x00082494 File Offset: 0x00080694
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 676432, XrefRangeEnd = 676445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InverseTransformVectors(Span<Vector3> vectors)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(vectors));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_InverseTransformVectors_Public_Void_Span_1_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001C5A RID: 7258 RVA: 0x000824DC File Offset: 0x000806DC
		[CallerCount(89)]
		[CachedScanResults(RefRangeStart = 676447, RefRangeEnd = 676536, XrefRangeStart = 676445, XrefRangeEnd = 676447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 TransformPoint(Vector3 position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref position;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_TransformPoint_Public_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001C5B RID: 7259 RVA: 0x00082528 File Offset: 0x00080728
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 676538, RefRangeEnd = 676546, XrefRangeStart = 676536, XrefRangeEnd = 676538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 TransformPoint(float x, float y, float z)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref z;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_TransformPoint_Public_Vector3_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C5C RID: 7260 RVA: 0x00082590 File Offset: 0x00080790
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 676546, XrefRangeEnd = 676548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TransformPoints(Vector3* positions, int count, Vector3* transformedPositions, int transformedCount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = positions;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = transformedPositions;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref transformedCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_TransformPoints_Internal_Void_ptr_Vector3_Int32_ptr_Vector3_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C5D RID: 7261 RVA: 0x000825F8 File Offset: 0x000807F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 676548, XrefRangeEnd = 676558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TransformPoints(ReadOnlySpan<Vector3> positions, Span<Vector3> transformedPositions)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(positions));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(transformedPositions));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_TransformPoints_Public_Void_ReadOnlySpan_1_Vector3_Span_1_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C5E RID: 7262 RVA: 0x00082658 File Offset: 0x00080858
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 676558, XrefRangeEnd = 676571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TransformPoints(Span<Vector3> positions)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(positions));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_TransformPoints_Public_Void_Span_1_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001C5F RID: 7263 RVA: 0x000826A0 File Offset: 0x000808A0
		[CallerCount(33)]
		[CachedScanResults(RefRangeStart = 676573, RefRangeEnd = 676606, XrefRangeStart = 676571, XrefRangeEnd = 676573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 InverseTransformPoint(Vector3 position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref position;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_InverseTransformPoint_Public_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001C60 RID: 7264 RVA: 0x000826EC File Offset: 0x000808EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 676606, XrefRangeEnd = 676608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 InverseTransformPoint(float x, float y, float z)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref z;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_InverseTransformPoint_Public_Vector3_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C61 RID: 7265 RVA: 0x00082754 File Offset: 0x00080954
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 676608, XrefRangeEnd = 676610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InverseTransformPoints(Vector3* positions, int count, Vector3* transformedPositions, int transformedCount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = positions;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = transformedPositions;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref transformedCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_InverseTransformPoints_Internal_Void_ptr_Vector3_Int32_ptr_Vector3_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C62 RID: 7266 RVA: 0x000827BC File Offset: 0x000809BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 676610, XrefRangeEnd = 676620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InverseTransformPoints(ReadOnlySpan<Vector3> positions, Span<Vector3> transformedPositions)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(positions));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(transformedPositions));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_InverseTransformPoints_Public_Void_ReadOnlySpan_1_Vector3_Span_1_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C63 RID: 7267 RVA: 0x0008281C File Offset: 0x00080A1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 676620, XrefRangeEnd = 676633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InverseTransformPoints(Span<Vector3> positions)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(positions));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_InverseTransformPoints_Public_Void_Span_1_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170005F0 RID: 1520
		// (get) Token: 0x06001C64 RID: 7268 RVA: 0x00082864 File Offset: 0x00080A64
		public unsafe Transform root
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 676633, XrefRangeEnd = 676635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_get_root_Public_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
			}
		}

		// Token: 0x06001C65 RID: 7269 RVA: 0x000828A4 File Offset: 0x00080AA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Transform GetRoot()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_GetRoot_Private_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
		}

		// Token: 0x170005F1 RID: 1521
		// (get) Token: 0x06001C66 RID: 7270 RVA: 0x000828E4 File Offset: 0x00080AE4
		public unsafe int childCount
		{
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 676637, RefRangeEnd = 676710, XrefRangeStart = 676635, XrefRangeEnd = 676637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_get_childCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001C67 RID: 7271 RVA: 0x00082920 File Offset: 0x00080B20
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 676712, RefRangeEnd = 676713, XrefRangeStart = 676710, XrefRangeEnd = 676712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DetachChildren()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_DetachChildren_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C68 RID: 7272 RVA: 0x00082954 File Offset: 0x00080B54
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 676715, RefRangeEnd = 676720, XrefRangeStart = 676713, XrefRangeEnd = 676715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetAsFirstSibling()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_SetAsFirstSibling_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C69 RID: 7273 RVA: 0x00082988 File Offset: 0x00080B88
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 676722, RefRangeEnd = 676726, XrefRangeStart = 676720, XrefRangeEnd = 676722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetAsLastSibling()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_SetAsLastSibling_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C6A RID: 7274 RVA: 0x000829BC File Offset: 0x00080BBC
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 676728, RefRangeEnd = 676749, XrefRangeStart = 676726, XrefRangeEnd = 676728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSiblingIndex(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_SetSiblingIndex_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001C6B RID: 7275 RVA: 0x000829FC File Offset: 0x00080BFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 676749, XrefRangeEnd = 676751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MoveAfterSibling(Transform transform, bool notifyEditorAndMarkDirty)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(transform);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref notifyEditorAndMarkDirty;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_MoveAfterSibling_Internal_Void_Transform_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C6C RID: 7276 RVA: 0x00082A4C File Offset: 0x00080C4C
		[CallerCount(24)]
		[CachedScanResults(RefRangeStart = 676753, RefRangeEnd = 676777, XrefRangeStart = 676751, XrefRangeEnd = 676753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetSiblingIndex()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_GetSiblingIndex_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C6D RID: 7277 RVA: 0x00082A88 File Offset: 0x00080C88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 676777, XrefRangeEnd = 676779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Transform FindRelativeTransformWithPath(Transform transform, string path, bool isActiveOnly)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(transform);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(path);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isActiveOnly;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_FindRelativeTransformWithPath_Private_Static_Transform_Transform_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
		}

		// Token: 0x06001C6E RID: 7278 RVA: 0x00082AEC File Offset: 0x00080CEC
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 676787, RefRangeEnd = 676801, XrefRangeStart = 676779, XrefRangeEnd = 676787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Transform Find(string n)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(n);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_Find_Public_Transform_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
			}
		}

		// Token: 0x06001C6F RID: 7279 RVA: 0x00082B3C File Offset: 0x00080D3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 676801, XrefRangeEnd = 676803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendTransformChangedScale()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_SendTransformChangedScale_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170005F2 RID: 1522
		// (get) Token: 0x06001C70 RID: 7280 RVA: 0x00082B70 File Offset: 0x00080D70
		public unsafe Vector3 lossyScale
		{
			[CallerCount(22)]
			[CachedScanResults(RefRangeStart = 676805, RefRangeEnd = 676827, XrefRangeStart = 676803, XrefRangeEnd = 676805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_get_lossyScale_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001C71 RID: 7281 RVA: 0x00082BAC File Offset: 0x00080DAC
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 676829, RefRangeEnd = 676838, XrefRangeStart = 676827, XrefRangeEnd = 676829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsChildOf(Transform parent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(parent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_IsChildOf_Public_Boolean_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005F3 RID: 1523
		// (get) Token: 0x06001C72 RID: 7282 RVA: 0x00082BFC File Offset: 0x00080DFC
		// (set) Token: 0x06001C73 RID: 7283 RVA: 0x00082C38 File Offset: 0x00080E38
		public unsafe bool hasChanged
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 676840, RefRangeEnd = 676843, XrefRangeStart = 676838, XrefRangeEnd = 676840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_get_hasChanged_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 676845, RefRangeEnd = 676847, XrefRangeStart = 676843, XrefRangeEnd = 676845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_set_hasChanged_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001C74 RID: 7284 RVA: 0x00082C78 File Offset: 0x00080E78
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 676787, RefRangeEnd = 676801, XrefRangeStart = 676787, XrefRangeEnd = 676801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Transform FindChild(string n)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(n);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_FindChild_Public_Transform_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
			}
		}

		// Token: 0x06001C75 RID: 7285 RVA: 0x00082CC8 File Offset: 0x00080EC8
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 676852, RefRangeEnd = 676860, XrefRangeStart = 676847, XrefRangeEnd = 676852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001C76 RID: 7286 RVA: 0x00082D08 File Offset: 0x00080F08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 676860, XrefRangeEnd = 676862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RotateAround(Vector3 axis, float angle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref axis;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref angle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_RotateAround_Public_Void_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C77 RID: 7287 RVA: 0x00082D54 File Offset: 0x00080F54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 676862, XrefRangeEnd = 676864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RotateAroundLocal(Vector3 axis, float angle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref axis;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref angle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_RotateAroundLocal_Public_Void_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C78 RID: 7288 RVA: 0x00082DA0 File Offset: 0x00080FA0
		[CallerCount(49)]
		[CachedScanResults(RefRangeStart = 676866, RefRangeEnd = 676915, XrefRangeStart = 676864, XrefRangeEnd = 676866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Transform GetChild(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_GetChild_Public_Transform_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
			}
		}

		// Token: 0x06001C79 RID: 7289 RVA: 0x00082DEC File Offset: 0x00080FEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 676915, XrefRangeEnd = 676917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetChildCount()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_GetChildCount_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170005F4 RID: 1524
		// (get) Token: 0x06001C7A RID: 7290 RVA: 0x00082E28 File Offset: 0x00081028
		// (set) Token: 0x06001C7B RID: 7291 RVA: 0x00082E64 File Offset: 0x00081064
		public unsafe int hierarchyCapacity
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 676917, XrefRangeEnd = 676919, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_get_hierarchyCapacity_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 676919, XrefRangeEnd = 676921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_set_hierarchyCapacity_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001C7C RID: 7292 RVA: 0x00082EA4 File Offset: 0x000810A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int internal_getHierarchyCapacity()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_internal_getHierarchyCapacity_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C7D RID: 7293 RVA: 0x00082EE0 File Offset: 0x000810E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void internal_setHierarchyCapacity(int value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_internal_setHierarchyCapacity_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170005F5 RID: 1525
		// (get) Token: 0x06001C7E RID: 7294 RVA: 0x00082F20 File Offset: 0x00081120
		public unsafe int hierarchyCount
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 676921, XrefRangeEnd = 676923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_get_hierarchyCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001C7F RID: 7295 RVA: 0x00082F5C File Offset: 0x0008115C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int internal_getHierarchyCount()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_internal_getHierarchyCount_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C80 RID: 7296 RVA: 0x00082F98 File Offset: 0x00081198
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 676923, XrefRangeEnd = 676925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsNonUniformScaleTransform()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_IsNonUniformScaleTransform_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170005F6 RID: 1526
		// (get) Token: 0x06001C81 RID: 7297 RVA: 0x00082FD4 File Offset: 0x000811D4
		// (set) Token: 0x06001C82 RID: 7298 RVA: 0x00083010 File Offset: 0x00081210
		public unsafe bool constrainProportionsScale
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 676925, XrefRangeEnd = 676927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_get_constrainProportionsScale_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 676927, XrefRangeEnd = 676929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_set_constrainProportionsScale_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001C83 RID: 7299 RVA: 0x00083050 File Offset: 0x00081250
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetConstrainProportionsScale(bool isLinked)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref isLinked;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_SetConstrainProportionsScale_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001C84 RID: 7300 RVA: 0x00083090 File Offset: 0x00081290
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsConstrainProportionsScale()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_IsConstrainProportionsScale_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C85 RID: 7301 RVA: 0x000830CC File Offset: 0x000812CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 676929, XrefRangeEnd = 676931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void get_position_Injected(out Vector3 ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &ret;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_get_position_Injected_Private_Void_byref_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001C86 RID: 7302 RVA: 0x0008310C File Offset: 0x0008130C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 676931, XrefRangeEnd = 676933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void set_position_Injected(ref Vector3 value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_set_position_Injected_Private_Void_byref_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001C87 RID: 7303 RVA: 0x0008314C File Offset: 0x0008134C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 676933, XrefRangeEnd = 676935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void get_localPosition_Injected(out Vector3 ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &ret;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_get_localPosition_Injected_Private_Void_byref_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001C88 RID: 7304 RVA: 0x0008318C File Offset: 0x0008138C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 676935, XrefRangeEnd = 676937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void set_localPosition_Injected(ref Vector3 value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_set_localPosition_Injected_Private_Void_byref_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001C89 RID: 7305 RVA: 0x000831CC File Offset: 0x000813CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 676937, XrefRangeEnd = 676939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetLocalEulerAngles_Injected(RotationOrder order, out Vector3 ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref order;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_GetLocalEulerAngles_Injected_Private_Void_RotationOrder_byref_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C8A RID: 7306 RVA: 0x00083218 File Offset: 0x00081418
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 676939, XrefRangeEnd = 676941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetLocalEulerAngles_Injected(ref Vector3 euler, RotationOrder order)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &euler;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref order;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_SetLocalEulerAngles_Injected_Private_Void_byref_Vector3_RotationOrder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C8B RID: 7307 RVA: 0x00083264 File Offset: 0x00081464
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 676941, XrefRangeEnd = 676943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetLocalEulerHint_Injected(ref Vector3 euler)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &euler;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_SetLocalEulerHint_Injected_Private_Void_byref_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001C8C RID: 7308 RVA: 0x000832A4 File Offset: 0x000814A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 676943, XrefRangeEnd = 676945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void get_rotation_Injected(out Quaternion ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &ret;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_get_rotation_Injected_Private_Void_byref_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001C8D RID: 7309 RVA: 0x000832E4 File Offset: 0x000814E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 676945, XrefRangeEnd = 676947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void set_rotation_Injected(ref Quaternion value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_set_rotation_Injected_Private_Void_byref_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001C8E RID: 7310 RVA: 0x00083324 File Offset: 0x00081524
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 676947, XrefRangeEnd = 676949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void get_localRotation_Injected(out Quaternion ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &ret;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_get_localRotation_Injected_Private_Void_byref_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001C8F RID: 7311 RVA: 0x00083364 File Offset: 0x00081564
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 676949, XrefRangeEnd = 676951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void set_localRotation_Injected(ref Quaternion value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_set_localRotation_Injected_Private_Void_byref_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001C90 RID: 7312 RVA: 0x000833A4 File Offset: 0x000815A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 676951, XrefRangeEnd = 676953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void get_localScale_Injected(out Vector3 ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &ret;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_get_localScale_Injected_Private_Void_byref_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001C91 RID: 7313 RVA: 0x000833E4 File Offset: 0x000815E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 676953, XrefRangeEnd = 676955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void set_localScale_Injected(ref Vector3 value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_set_localScale_Injected_Private_Void_byref_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001C92 RID: 7314 RVA: 0x00083424 File Offset: 0x00081624
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 676955, XrefRangeEnd = 676957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void get_worldToLocalMatrix_Injected(out Matrix4x4 ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &ret;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_get_worldToLocalMatrix_Injected_Private_Void_byref_Matrix4x4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001C93 RID: 7315 RVA: 0x00083464 File Offset: 0x00081664
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 676957, XrefRangeEnd = 676959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void get_localToWorldMatrix_Injected(out Matrix4x4 ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &ret;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_get_localToWorldMatrix_Injected_Private_Void_byref_Matrix4x4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001C94 RID: 7316 RVA: 0x000834A4 File Offset: 0x000816A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 676959, XrefRangeEnd = 676961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPositionAndRotation_Injected(ref Vector3 position, ref Quaternion rotation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &position;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &rotation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_SetPositionAndRotation_Injected_Private_Void_byref_Vector3_byref_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C95 RID: 7317 RVA: 0x000834F0 File Offset: 0x000816F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 676961, XrefRangeEnd = 676963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetLocalPositionAndRotation_Injected(ref Vector3 localPosition, ref Quaternion localRotation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &localPosition;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &localRotation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_SetLocalPositionAndRotation_Injected_Private_Void_byref_Vector3_byref_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C96 RID: 7318 RVA: 0x0008353C File Offset: 0x0008173C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 676963, XrefRangeEnd = 676965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RotateAroundInternal_Injected(ref Vector3 axis, float angle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &axis;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref angle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_RotateAroundInternal_Injected_Private_Void_byref_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C97 RID: 7319 RVA: 0x00083588 File Offset: 0x00081788
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 676965, XrefRangeEnd = 676967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Internal_LookAt_Injected(ref Vector3 worldPosition, ref Vector3 worldUp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &worldPosition;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &worldUp;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_Internal_LookAt_Injected_Private_Void_byref_Vector3_byref_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C98 RID: 7320 RVA: 0x000835D4 File Offset: 0x000817D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 676967, XrefRangeEnd = 676969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TransformDirection_Injected(ref Vector3 direction, out Vector3 ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &direction;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_TransformDirection_Injected_Private_Void_byref_Vector3_byref_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C99 RID: 7321 RVA: 0x00083620 File Offset: 0x00081820
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 676969, XrefRangeEnd = 676971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InverseTransformDirection_Injected(ref Vector3 direction, out Vector3 ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &direction;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_InverseTransformDirection_Injected_Private_Void_byref_Vector3_byref_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C9A RID: 7322 RVA: 0x0008366C File Offset: 0x0008186C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 676971, XrefRangeEnd = 676973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TransformVector_Injected(ref Vector3 vector, out Vector3 ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &vector;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_TransformVector_Injected_Private_Void_byref_Vector3_byref_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C9B RID: 7323 RVA: 0x000836B8 File Offset: 0x000818B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 676973, XrefRangeEnd = 676975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InverseTransformVector_Injected(ref Vector3 vector, out Vector3 ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &vector;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_InverseTransformVector_Injected_Private_Void_byref_Vector3_byref_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C9C RID: 7324 RVA: 0x00083704 File Offset: 0x00081904
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 676975, XrefRangeEnd = 676977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TransformPoint_Injected(ref Vector3 position, out Vector3 ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &position;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_TransformPoint_Injected_Private_Void_byref_Vector3_byref_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C9D RID: 7325 RVA: 0x00083750 File Offset: 0x00081950
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 676977, XrefRangeEnd = 676979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InverseTransformPoint_Injected(ref Vector3 position, out Vector3 ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &position;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_InverseTransformPoint_Injected_Private_Void_byref_Vector3_byref_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C9E RID: 7326 RVA: 0x0008379C File Offset: 0x0008199C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 676979, XrefRangeEnd = 676981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void get_lossyScale_Injected(out Vector3 ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &ret;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_get_lossyScale_Injected_Private_Void_byref_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001C9F RID: 7327 RVA: 0x000837DC File Offset: 0x000819DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 676981, XrefRangeEnd = 676983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RotateAround_Injected(ref Vector3 axis, float angle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &axis;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref angle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_RotateAround_Injected_Private_Void_byref_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CA0 RID: 7328 RVA: 0x00083828 File Offset: 0x00081A28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 676983, XrefRangeEnd = 676985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RotateAroundLocal_Injected(ref Vector3 axis, float angle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &axis;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref angle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_RotateAroundLocal_Injected_Private_Void_byref_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CA1 RID: 7329 RVA: 0x0000AC76 File Offset: 0x00008E76
		public Transform(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040018C9 RID: 6345
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x040018CA RID: 6346
		private static readonly IntPtr NativeMethodInfoPtr_get_position_Public_get_Vector3_0;

		// Token: 0x040018CB RID: 6347
		private static readonly IntPtr NativeMethodInfoPtr_set_position_Public_set_Void_Vector3_0;

		// Token: 0x040018CC RID: 6348
		private static readonly IntPtr NativeMethodInfoPtr_get_localPosition_Public_get_Vector3_0;

		// Token: 0x040018CD RID: 6349
		private static readonly IntPtr NativeMethodInfoPtr_set_localPosition_Public_set_Void_Vector3_0;

		// Token: 0x040018CE RID: 6350
		private static readonly IntPtr NativeMethodInfoPtr_GetLocalEulerAngles_Internal_Vector3_RotationOrder_0;

		// Token: 0x040018CF RID: 6351
		private static readonly IntPtr NativeMethodInfoPtr_SetLocalEulerAngles_Internal_Void_Vector3_RotationOrder_0;

		// Token: 0x040018D0 RID: 6352
		private static readonly IntPtr NativeMethodInfoPtr_SetLocalEulerHint_Internal_Void_Vector3_0;

		// Token: 0x040018D1 RID: 6353
		private static readonly IntPtr NativeMethodInfoPtr_get_eulerAngles_Public_get_Vector3_0;

		// Token: 0x040018D2 RID: 6354
		private static readonly IntPtr NativeMethodInfoPtr_set_eulerAngles_Public_set_Void_Vector3_0;

		// Token: 0x040018D3 RID: 6355
		private static readonly IntPtr NativeMethodInfoPtr_get_localEulerAngles_Public_get_Vector3_0;

		// Token: 0x040018D4 RID: 6356
		private static readonly IntPtr NativeMethodInfoPtr_set_localEulerAngles_Public_set_Void_Vector3_0;

		// Token: 0x040018D5 RID: 6357
		private static readonly IntPtr NativeMethodInfoPtr_get_right_Public_get_Vector3_0;

		// Token: 0x040018D6 RID: 6358
		private static readonly IntPtr NativeMethodInfoPtr_set_right_Public_set_Void_Vector3_0;

		// Token: 0x040018D7 RID: 6359
		private static readonly IntPtr NativeMethodInfoPtr_get_up_Public_get_Vector3_0;

		// Token: 0x040018D8 RID: 6360
		private static readonly IntPtr NativeMethodInfoPtr_set_up_Public_set_Void_Vector3_0;

		// Token: 0x040018D9 RID: 6361
		private static readonly IntPtr NativeMethodInfoPtr_get_forward_Public_get_Vector3_0;

		// Token: 0x040018DA RID: 6362
		private static readonly IntPtr NativeMethodInfoPtr_set_forward_Public_set_Void_Vector3_0;

		// Token: 0x040018DB RID: 6363
		private static readonly IntPtr NativeMethodInfoPtr_get_rotation_Public_get_Quaternion_0;

		// Token: 0x040018DC RID: 6364
		private static readonly IntPtr NativeMethodInfoPtr_set_rotation_Public_set_Void_Quaternion_0;

		// Token: 0x040018DD RID: 6365
		private static readonly IntPtr NativeMethodInfoPtr_get_localRotation_Public_get_Quaternion_0;

		// Token: 0x040018DE RID: 6366
		private static readonly IntPtr NativeMethodInfoPtr_set_localRotation_Public_set_Void_Quaternion_0;

		// Token: 0x040018DF RID: 6367
		private static readonly IntPtr NativeMethodInfoPtr_get_rotationOrder_Internal_get_RotationOrder_0;

		// Token: 0x040018E0 RID: 6368
		private static readonly IntPtr NativeMethodInfoPtr_set_rotationOrder_Internal_set_Void_RotationOrder_0;

		// Token: 0x040018E1 RID: 6369
		private static readonly IntPtr NativeMethodInfoPtr_GetRotationOrderInternal_Internal_Int32_0;

		// Token: 0x040018E2 RID: 6370
		private static readonly IntPtr NativeMethodInfoPtr_SetRotationOrderInternal_Internal_Void_RotationOrder_0;

		// Token: 0x040018E3 RID: 6371
		private static readonly IntPtr NativeMethodInfoPtr_get_localScale_Public_get_Vector3_0;

		// Token: 0x040018E4 RID: 6372
		private static readonly IntPtr NativeMethodInfoPtr_set_localScale_Public_set_Void_Vector3_0;

		// Token: 0x040018E5 RID: 6373
		private static readonly IntPtr NativeMethodInfoPtr_get_parent_Public_get_Transform_0;

		// Token: 0x040018E6 RID: 6374
		private static readonly IntPtr NativeMethodInfoPtr_set_parent_Public_set_Void_Transform_0;

		// Token: 0x040018E7 RID: 6375
		private static readonly IntPtr NativeMethodInfoPtr_get_parentInternal_Internal_get_Transform_0;

		// Token: 0x040018E8 RID: 6376
		private static readonly IntPtr NativeMethodInfoPtr_set_parentInternal_Internal_set_Void_Transform_0;

		// Token: 0x040018E9 RID: 6377
		private static readonly IntPtr NativeMethodInfoPtr_GetParent_Private_Transform_0;

		// Token: 0x040018EA RID: 6378
		private static readonly IntPtr NativeMethodInfoPtr_SetParent_Public_Void_Transform_0;

		// Token: 0x040018EB RID: 6379
		private static readonly IntPtr NativeMethodInfoPtr_SetParent_Public_Void_Transform_Boolean_0;

		// Token: 0x040018EC RID: 6380
		private static readonly IntPtr NativeMethodInfoPtr_get_worldToLocalMatrix_Public_get_Matrix4x4_0;

		// Token: 0x040018ED RID: 6381
		private static readonly IntPtr NativeMethodInfoPtr_get_localToWorldMatrix_Public_get_Matrix4x4_0;

		// Token: 0x040018EE RID: 6382
		private static readonly IntPtr NativeMethodInfoPtr_SetPositionAndRotation_Public_Void_Vector3_Quaternion_0;

		// Token: 0x040018EF RID: 6383
		private static readonly IntPtr NativeMethodInfoPtr_SetLocalPositionAndRotation_Public_Void_Vector3_Quaternion_0;

		// Token: 0x040018F0 RID: 6384
		private static readonly IntPtr NativeMethodInfoPtr_GetPositionAndRotation_Public_Void_byref_Vector3_byref_Quaternion_0;

		// Token: 0x040018F1 RID: 6385
		private static readonly IntPtr NativeMethodInfoPtr_GetLocalPositionAndRotation_Public_Void_byref_Vector3_byref_Quaternion_0;

		// Token: 0x040018F2 RID: 6386
		private static readonly IntPtr NativeMethodInfoPtr_Translate_Public_Void_Vector3_Space_0;

		// Token: 0x040018F3 RID: 6387
		private static readonly IntPtr NativeMethodInfoPtr_Translate_Public_Void_Vector3_0;

		// Token: 0x040018F4 RID: 6388
		private static readonly IntPtr NativeMethodInfoPtr_Translate_Public_Void_Single_Single_Single_Space_0;

		// Token: 0x040018F5 RID: 6389
		private static readonly IntPtr NativeMethodInfoPtr_Translate_Public_Void_Single_Single_Single_0;

		// Token: 0x040018F6 RID: 6390
		private static readonly IntPtr NativeMethodInfoPtr_Translate_Public_Void_Vector3_Transform_0;

		// Token: 0x040018F7 RID: 6391
		private static readonly IntPtr NativeMethodInfoPtr_Translate_Public_Void_Single_Single_Single_Transform_0;

		// Token: 0x040018F8 RID: 6392
		private static readonly IntPtr NativeMethodInfoPtr_Rotate_Public_Void_Vector3_Space_0;

		// Token: 0x040018F9 RID: 6393
		private static readonly IntPtr NativeMethodInfoPtr_Rotate_Public_Void_Vector3_0;

		// Token: 0x040018FA RID: 6394
		private static readonly IntPtr NativeMethodInfoPtr_Rotate_Public_Void_Single_Single_Single_Space_0;

		// Token: 0x040018FB RID: 6395
		private static readonly IntPtr NativeMethodInfoPtr_Rotate_Public_Void_Single_Single_Single_0;

		// Token: 0x040018FC RID: 6396
		private static readonly IntPtr NativeMethodInfoPtr_RotateAroundInternal_Internal_Void_Vector3_Single_0;

		// Token: 0x040018FD RID: 6397
		private static readonly IntPtr NativeMethodInfoPtr_Rotate_Public_Void_Vector3_Single_Space_0;

		// Token: 0x040018FE RID: 6398
		private static readonly IntPtr NativeMethodInfoPtr_Rotate_Public_Void_Vector3_Single_0;

		// Token: 0x040018FF RID: 6399
		private static readonly IntPtr NativeMethodInfoPtr_RotateAround_Public_Void_Vector3_Vector3_Single_0;

		// Token: 0x04001900 RID: 6400
		private static readonly IntPtr NativeMethodInfoPtr_LookAt_Public_Void_Transform_Vector3_0;

		// Token: 0x04001901 RID: 6401
		private static readonly IntPtr NativeMethodInfoPtr_LookAt_Public_Void_Transform_0;

		// Token: 0x04001902 RID: 6402
		private static readonly IntPtr NativeMethodInfoPtr_LookAt_Public_Void_Vector3_Vector3_0;

		// Token: 0x04001903 RID: 6403
		private static readonly IntPtr NativeMethodInfoPtr_LookAt_Public_Void_Vector3_0;

		// Token: 0x04001904 RID: 6404
		private static readonly IntPtr NativeMethodInfoPtr_Internal_LookAt_Private_Void_Vector3_Vector3_0;

		// Token: 0x04001905 RID: 6405
		private static readonly IntPtr NativeMethodInfoPtr_TransformDirection_Public_Vector3_Vector3_0;

		// Token: 0x04001906 RID: 6406
		private static readonly IntPtr NativeMethodInfoPtr_TransformDirection_Public_Vector3_Single_Single_Single_0;

		// Token: 0x04001907 RID: 6407
		private static readonly IntPtr NativeMethodInfoPtr_TransformDirections_Internal_Void_ptr_Vector3_Int32_ptr_Vector3_Int32_0;

		// Token: 0x04001908 RID: 6408
		private static readonly IntPtr NativeMethodInfoPtr_TransformDirections_Public_Void_ReadOnlySpan_1_Vector3_Span_1_Vector3_0;

		// Token: 0x04001909 RID: 6409
		private static readonly IntPtr NativeMethodInfoPtr_TransformDirections_Public_Void_Span_1_Vector3_0;

		// Token: 0x0400190A RID: 6410
		private static readonly IntPtr NativeMethodInfoPtr_InverseTransformDirection_Public_Vector3_Vector3_0;

		// Token: 0x0400190B RID: 6411
		private static readonly IntPtr NativeMethodInfoPtr_InverseTransformDirection_Public_Vector3_Single_Single_Single_0;

		// Token: 0x0400190C RID: 6412
		private static readonly IntPtr NativeMethodInfoPtr_InverseTransformDirections_Internal_Void_ptr_Vector3_Int32_ptr_Vector3_Int32_0;

		// Token: 0x0400190D RID: 6413
		private static readonly IntPtr NativeMethodInfoPtr_InverseTransformDirections_Public_Void_ReadOnlySpan_1_Vector3_Span_1_Vector3_0;

		// Token: 0x0400190E RID: 6414
		private static readonly IntPtr NativeMethodInfoPtr_InverseTransformDirections_Public_Void_Span_1_Vector3_0;

		// Token: 0x0400190F RID: 6415
		private static readonly IntPtr NativeMethodInfoPtr_TransformVector_Public_Vector3_Vector3_0;

		// Token: 0x04001910 RID: 6416
		private static readonly IntPtr NativeMethodInfoPtr_TransformVector_Public_Vector3_Single_Single_Single_0;

		// Token: 0x04001911 RID: 6417
		private static readonly IntPtr NativeMethodInfoPtr_TransformVectors_Internal_Void_ptr_Vector3_Int32_ptr_Vector3_Int32_0;

		// Token: 0x04001912 RID: 6418
		private static readonly IntPtr NativeMethodInfoPtr_TransformVectors_Public_Void_ReadOnlySpan_1_Vector3_Span_1_Vector3_0;

		// Token: 0x04001913 RID: 6419
		private static readonly IntPtr NativeMethodInfoPtr_TransformVectors_Public_Void_Span_1_Vector3_0;

		// Token: 0x04001914 RID: 6420
		private static readonly IntPtr NativeMethodInfoPtr_InverseTransformVector_Public_Vector3_Vector3_0;

		// Token: 0x04001915 RID: 6421
		private static readonly IntPtr NativeMethodInfoPtr_InverseTransformVector_Public_Vector3_Single_Single_Single_0;

		// Token: 0x04001916 RID: 6422
		private static readonly IntPtr NativeMethodInfoPtr_InverseTransformVectors_Internal_Void_ptr_Vector3_Int32_ptr_Vector3_Int32_0;

		// Token: 0x04001917 RID: 6423
		private static readonly IntPtr NativeMethodInfoPtr_InverseTransformVectors_Public_Void_ReadOnlySpan_1_Vector3_Span_1_Vector3_0;

		// Token: 0x04001918 RID: 6424
		private static readonly IntPtr NativeMethodInfoPtr_InverseTransformVectors_Public_Void_Span_1_Vector3_0;

		// Token: 0x04001919 RID: 6425
		private static readonly IntPtr NativeMethodInfoPtr_TransformPoint_Public_Vector3_Vector3_0;

		// Token: 0x0400191A RID: 6426
		private static readonly IntPtr NativeMethodInfoPtr_TransformPoint_Public_Vector3_Single_Single_Single_0;

		// Token: 0x0400191B RID: 6427
		private static readonly IntPtr NativeMethodInfoPtr_TransformPoints_Internal_Void_ptr_Vector3_Int32_ptr_Vector3_Int32_0;

		// Token: 0x0400191C RID: 6428
		private static readonly IntPtr NativeMethodInfoPtr_TransformPoints_Public_Void_ReadOnlySpan_1_Vector3_Span_1_Vector3_0;

		// Token: 0x0400191D RID: 6429
		private static readonly IntPtr NativeMethodInfoPtr_TransformPoints_Public_Void_Span_1_Vector3_0;

		// Token: 0x0400191E RID: 6430
		private static readonly IntPtr NativeMethodInfoPtr_InverseTransformPoint_Public_Vector3_Vector3_0;

		// Token: 0x0400191F RID: 6431
		private static readonly IntPtr NativeMethodInfoPtr_InverseTransformPoint_Public_Vector3_Single_Single_Single_0;

		// Token: 0x04001920 RID: 6432
		private static readonly IntPtr NativeMethodInfoPtr_InverseTransformPoints_Internal_Void_ptr_Vector3_Int32_ptr_Vector3_Int32_0;

		// Token: 0x04001921 RID: 6433
		private static readonly IntPtr NativeMethodInfoPtr_InverseTransformPoints_Public_Void_ReadOnlySpan_1_Vector3_Span_1_Vector3_0;

		// Token: 0x04001922 RID: 6434
		private static readonly IntPtr NativeMethodInfoPtr_InverseTransformPoints_Public_Void_Span_1_Vector3_0;

		// Token: 0x04001923 RID: 6435
		private static readonly IntPtr NativeMethodInfoPtr_get_root_Public_get_Transform_0;

		// Token: 0x04001924 RID: 6436
		private static readonly IntPtr NativeMethodInfoPtr_GetRoot_Private_Transform_0;

		// Token: 0x04001925 RID: 6437
		private static readonly IntPtr NativeMethodInfoPtr_get_childCount_Public_get_Int32_0;

		// Token: 0x04001926 RID: 6438
		private static readonly IntPtr NativeMethodInfoPtr_DetachChildren_Public_Void_0;

		// Token: 0x04001927 RID: 6439
		private static readonly IntPtr NativeMethodInfoPtr_SetAsFirstSibling_Public_Void_0;

		// Token: 0x04001928 RID: 6440
		private static readonly IntPtr NativeMethodInfoPtr_SetAsLastSibling_Public_Void_0;

		// Token: 0x04001929 RID: 6441
		private static readonly IntPtr NativeMethodInfoPtr_SetSiblingIndex_Public_Void_Int32_0;

		// Token: 0x0400192A RID: 6442
		private static readonly IntPtr NativeMethodInfoPtr_MoveAfterSibling_Internal_Void_Transform_Boolean_0;

		// Token: 0x0400192B RID: 6443
		private static readonly IntPtr NativeMethodInfoPtr_GetSiblingIndex_Public_Int32_0;

		// Token: 0x0400192C RID: 6444
		private static readonly IntPtr NativeMethodInfoPtr_FindRelativeTransformWithPath_Private_Static_Transform_Transform_String_Boolean_0;

		// Token: 0x0400192D RID: 6445
		private static readonly IntPtr NativeMethodInfoPtr_Find_Public_Transform_String_0;

		// Token: 0x0400192E RID: 6446
		private static readonly IntPtr NativeMethodInfoPtr_SendTransformChangedScale_Internal_Void_0;

		// Token: 0x0400192F RID: 6447
		private static readonly IntPtr NativeMethodInfoPtr_get_lossyScale_Public_get_Vector3_0;

		// Token: 0x04001930 RID: 6448
		private static readonly IntPtr NativeMethodInfoPtr_IsChildOf_Public_Boolean_Transform_0;

		// Token: 0x04001931 RID: 6449
		private static readonly IntPtr NativeMethodInfoPtr_get_hasChanged_Public_get_Boolean_0;

		// Token: 0x04001932 RID: 6450
		private static readonly IntPtr NativeMethodInfoPtr_set_hasChanged_Public_set_Void_Boolean_0;

		// Token: 0x04001933 RID: 6451
		private static readonly IntPtr NativeMethodInfoPtr_FindChild_Public_Transform_String_0;

		// Token: 0x04001934 RID: 6452
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_0;

		// Token: 0x04001935 RID: 6453
		private static readonly IntPtr NativeMethodInfoPtr_RotateAround_Public_Void_Vector3_Single_0;

		// Token: 0x04001936 RID: 6454
		private static readonly IntPtr NativeMethodInfoPtr_RotateAroundLocal_Public_Void_Vector3_Single_0;

		// Token: 0x04001937 RID: 6455
		private static readonly IntPtr NativeMethodInfoPtr_GetChild_Public_Transform_Int32_0;

		// Token: 0x04001938 RID: 6456
		private static readonly IntPtr NativeMethodInfoPtr_GetChildCount_Public_Int32_0;

		// Token: 0x04001939 RID: 6457
		private static readonly IntPtr NativeMethodInfoPtr_get_hierarchyCapacity_Public_get_Int32_0;

		// Token: 0x0400193A RID: 6458
		private static readonly IntPtr NativeMethodInfoPtr_set_hierarchyCapacity_Public_set_Void_Int32_0;

		// Token: 0x0400193B RID: 6459
		private static readonly IntPtr NativeMethodInfoPtr_internal_getHierarchyCapacity_Private_Int32_0;

		// Token: 0x0400193C RID: 6460
		private static readonly IntPtr NativeMethodInfoPtr_internal_setHierarchyCapacity_Private_Void_Int32_0;

		// Token: 0x0400193D RID: 6461
		private static readonly IntPtr NativeMethodInfoPtr_get_hierarchyCount_Public_get_Int32_0;

		// Token: 0x0400193E RID: 6462
		private static readonly IntPtr NativeMethodInfoPtr_internal_getHierarchyCount_Private_Int32_0;

		// Token: 0x0400193F RID: 6463
		private static readonly IntPtr NativeMethodInfoPtr_IsNonUniformScaleTransform_Internal_Boolean_0;

		// Token: 0x04001940 RID: 6464
		private static readonly IntPtr NativeMethodInfoPtr_get_constrainProportionsScale_Internal_get_Boolean_0;

		// Token: 0x04001941 RID: 6465
		private static readonly IntPtr NativeMethodInfoPtr_set_constrainProportionsScale_Internal_set_Void_Boolean_0;

		// Token: 0x04001942 RID: 6466
		private static readonly IntPtr NativeMethodInfoPtr_SetConstrainProportionsScale_Private_Void_Boolean_0;

		// Token: 0x04001943 RID: 6467
		private static readonly IntPtr NativeMethodInfoPtr_IsConstrainProportionsScale_Private_Boolean_0;

		// Token: 0x04001944 RID: 6468
		private static readonly IntPtr NativeMethodInfoPtr_get_position_Injected_Private_Void_byref_Vector3_0;

		// Token: 0x04001945 RID: 6469
		private static readonly IntPtr NativeMethodInfoPtr_set_position_Injected_Private_Void_byref_Vector3_0;

		// Token: 0x04001946 RID: 6470
		private static readonly IntPtr NativeMethodInfoPtr_get_localPosition_Injected_Private_Void_byref_Vector3_0;

		// Token: 0x04001947 RID: 6471
		private static readonly IntPtr NativeMethodInfoPtr_set_localPosition_Injected_Private_Void_byref_Vector3_0;

		// Token: 0x04001948 RID: 6472
		private static readonly IntPtr NativeMethodInfoPtr_GetLocalEulerAngles_Injected_Private_Void_RotationOrder_byref_Vector3_0;

		// Token: 0x04001949 RID: 6473
		private static readonly IntPtr NativeMethodInfoPtr_SetLocalEulerAngles_Injected_Private_Void_byref_Vector3_RotationOrder_0;

		// Token: 0x0400194A RID: 6474
		private static readonly IntPtr NativeMethodInfoPtr_SetLocalEulerHint_Injected_Private_Void_byref_Vector3_0;

		// Token: 0x0400194B RID: 6475
		private static readonly IntPtr NativeMethodInfoPtr_get_rotation_Injected_Private_Void_byref_Quaternion_0;

		// Token: 0x0400194C RID: 6476
		private static readonly IntPtr NativeMethodInfoPtr_set_rotation_Injected_Private_Void_byref_Quaternion_0;

		// Token: 0x0400194D RID: 6477
		private static readonly IntPtr NativeMethodInfoPtr_get_localRotation_Injected_Private_Void_byref_Quaternion_0;

		// Token: 0x0400194E RID: 6478
		private static readonly IntPtr NativeMethodInfoPtr_set_localRotation_Injected_Private_Void_byref_Quaternion_0;

		// Token: 0x0400194F RID: 6479
		private static readonly IntPtr NativeMethodInfoPtr_get_localScale_Injected_Private_Void_byref_Vector3_0;

		// Token: 0x04001950 RID: 6480
		private static readonly IntPtr NativeMethodInfoPtr_set_localScale_Injected_Private_Void_byref_Vector3_0;

		// Token: 0x04001951 RID: 6481
		private static readonly IntPtr NativeMethodInfoPtr_get_worldToLocalMatrix_Injected_Private_Void_byref_Matrix4x4_0;

		// Token: 0x04001952 RID: 6482
		private static readonly IntPtr NativeMethodInfoPtr_get_localToWorldMatrix_Injected_Private_Void_byref_Matrix4x4_0;

		// Token: 0x04001953 RID: 6483
		private static readonly IntPtr NativeMethodInfoPtr_SetPositionAndRotation_Injected_Private_Void_byref_Vector3_byref_Quaternion_0;

		// Token: 0x04001954 RID: 6484
		private static readonly IntPtr NativeMethodInfoPtr_SetLocalPositionAndRotation_Injected_Private_Void_byref_Vector3_byref_Quaternion_0;

		// Token: 0x04001955 RID: 6485
		private static readonly IntPtr NativeMethodInfoPtr_RotateAroundInternal_Injected_Private_Void_byref_Vector3_Single_0;

		// Token: 0x04001956 RID: 6486
		private static readonly IntPtr NativeMethodInfoPtr_Internal_LookAt_Injected_Private_Void_byref_Vector3_byref_Vector3_0;

		// Token: 0x04001957 RID: 6487
		private static readonly IntPtr NativeMethodInfoPtr_TransformDirection_Injected_Private_Void_byref_Vector3_byref_Vector3_0;

		// Token: 0x04001958 RID: 6488
		private static readonly IntPtr NativeMethodInfoPtr_InverseTransformDirection_Injected_Private_Void_byref_Vector3_byref_Vector3_0;

		// Token: 0x04001959 RID: 6489
		private static readonly IntPtr NativeMethodInfoPtr_TransformVector_Injected_Private_Void_byref_Vector3_byref_Vector3_0;

		// Token: 0x0400195A RID: 6490
		private static readonly IntPtr NativeMethodInfoPtr_InverseTransformVector_Injected_Private_Void_byref_Vector3_byref_Vector3_0;

		// Token: 0x0400195B RID: 6491
		private static readonly IntPtr NativeMethodInfoPtr_TransformPoint_Injected_Private_Void_byref_Vector3_byref_Vector3_0;

		// Token: 0x0400195C RID: 6492
		private static readonly IntPtr NativeMethodInfoPtr_InverseTransformPoint_Injected_Private_Void_byref_Vector3_byref_Vector3_0;

		// Token: 0x0400195D RID: 6493
		private static readonly IntPtr NativeMethodInfoPtr_get_lossyScale_Injected_Private_Void_byref_Vector3_0;

		// Token: 0x0400195E RID: 6494
		private static readonly IntPtr NativeMethodInfoPtr_RotateAround_Injected_Private_Void_byref_Vector3_Single_0;

		// Token: 0x0400195F RID: 6495
		private static readonly IntPtr NativeMethodInfoPtr_RotateAroundLocal_Injected_Private_Void_byref_Vector3_Single_0;

		// Token: 0x020007FF RID: 2047
		public class Enumerator : Object
		{
			// Token: 0x060038A7 RID: 14503 RVA: 0x000BCCF8 File Offset: 0x000BAEF8
			// Note: this type is marked as 'beforefieldinit'.
			static Enumerator()
			{
				Il2CppClassPointerStore<Transform.Enumerator>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Transform>.NativeClassPtr, "Enumerator");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Transform.Enumerator>.NativeClassPtr);
				Transform.Enumerator.NativeFieldInfoPtr_outer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Transform.Enumerator>.NativeClassPtr, "outer");
				Transform.Enumerator.NativeFieldInfoPtr_currentIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Transform.Enumerator>.NativeClassPtr, "currentIndex");
				Transform.Enumerator.NativeMethodInfoPtr__ctor_Internal_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform.Enumerator>.NativeClassPtr, 100667283);
				Transform.Enumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform.Enumerator>.NativeClassPtr, 100667284);
				Transform.Enumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform.Enumerator>.NativeClassPtr, 100667285);
				Transform.Enumerator.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform.Enumerator>.NativeClassPtr, 100667286);
			}

			// Token: 0x060038A8 RID: 14504 RVA: 0x000BCD9C File Offset: 0x000BAF9C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Enumerator(Transform outer)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Transform.Enumerator>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(outer);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.Enumerator.NativeMethodInfoPtr__ctor_Internal_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x17000A2E RID: 2606
			// (get) Token: 0x060038A9 RID: 14505 RVA: 0x000BCDE8 File Offset: 0x000BAFE8
			public unsafe virtual Object Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 675226, XrefRangeEnd = 675229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.Enumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060038AA RID: 14506 RVA: 0x000BCE28 File Offset: 0x000BB028
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 675229, XrefRangeEnd = 675231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.Enumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060038AB RID: 14507 RVA: 0x000BCE64 File Offset: 0x000BB064
			[CallerCount(0)]
			public unsafe virtual void Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.Enumerator.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060038AC RID: 14508 RVA: 0x000140FB File Offset: 0x000122FB
			public Enumerator(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000A2C RID: 2604
			// (get) Token: 0x060038AD RID: 14509 RVA: 0x000BCE98 File Offset: 0x000BB098
			// (set) Token: 0x060038AE RID: 14510 RVA: 0x00014104 File Offset: 0x00012304
			public unsafe Transform outer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Transform.Enumerator.NativeFieldInfoPtr_outer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Transform.Enumerator.NativeFieldInfoPtr_outer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A2D RID: 2605
			// (get) Token: 0x060038AF RID: 14511 RVA: 0x000BCEC8 File Offset: 0x000BB0C8
			// (set) Token: 0x060038B0 RID: 14512 RVA: 0x00014123 File Offset: 0x00012323
			public unsafe int currentIndex
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Transform.Enumerator.NativeFieldInfoPtr_currentIndex);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Transform.Enumerator.NativeFieldInfoPtr_currentIndex)) = value;
				}
			}

			// Token: 0x04002CB1 RID: 11441
			private static readonly IntPtr NativeFieldInfoPtr_outer;

			// Token: 0x04002CB2 RID: 11442
			private static readonly IntPtr NativeFieldInfoPtr_currentIndex;

			// Token: 0x04002CB3 RID: 11443
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Transform_0;

			// Token: 0x04002CB4 RID: 11444
			private static readonly IntPtr NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_Object_0;

			// Token: 0x04002CB5 RID: 11445
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0;

			// Token: 0x04002CB6 RID: 11446
			private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0;
		}
	}
}
