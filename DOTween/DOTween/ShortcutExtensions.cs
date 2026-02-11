using System;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Core.PathCore;
using DG.Tweening.Plugins.Options;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace DG.Tweening
{
	// Token: 0x02000014 RID: 20
	public static class ShortcutExtensions : global::Il2CppSystem.Object
	{
		// Token: 0x060000F4 RID: 244 RVA: 0x00009AD4 File Offset: 0x00007CD4
		// Note: this type is marked as 'beforefieldinit'.
		static ShortcutExtensions()
		{
			Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("DOTween.dll", "DG.Tweening", "ShortcutExtensions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr);
			ShortcutExtensions.NativeMethodInfoPtr_DOFade_Public_Static_Tweener_AudioSource_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, 100663461);
			ShortcutExtensions.NativeMethodInfoPtr_DOPitch_Public_Static_Tweener_AudioSource_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, 100663462);
			ShortcutExtensions.NativeMethodInfoPtr_DOAspect_Public_Static_Tweener_Camera_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, 100663463);
			ShortcutExtensions.NativeMethodInfoPtr_DOColor_Public_Static_Tweener_Camera_Color_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, 100663464);
			ShortcutExtensions.NativeMethodInfoPtr_DOFarClipPlane_Public_Static_Tweener_Camera_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, 100663465);
			ShortcutExtensions.NativeMethodInfoPtr_DOFieldOfView_Public_Static_Tweener_Camera_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, 100663466);
			ShortcutExtensions.NativeMethodInfoPtr_DONearClipPlane_Public_Static_Tweener_Camera_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, 100663467);
			ShortcutExtensions.NativeMethodInfoPtr_DOOrthoSize_Public_Static_Tweener_Camera_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, 100663468);
			ShortcutExtensions.NativeMethodInfoPtr_DOPixelRect_Public_Static_Tweener_Camera_Rect_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, 100663469);
			ShortcutExtensions.NativeMethodInfoPtr_DORect_Public_Static_Tweener_Camera_Rect_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, 100663470);
			ShortcutExtensions.NativeMethodInfoPtr_DOShakePosition_Public_Static_Tweener_Camera_Single_Single_Int32_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, 100663471);
			ShortcutExtensions.NativeMethodInfoPtr_DOShakePosition_Public_Static_Tweener_Camera_Single_Vector3_Int32_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, 100663472);
			ShortcutExtensions.NativeMethodInfoPtr_DOShakeRotation_Public_Static_Tweener_Camera_Single_Single_Int32_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, 100663473);
			ShortcutExtensions.NativeMethodInfoPtr_DOShakeRotation_Public_Static_Tweener_Camera_Single_Vector3_Int32_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, 100663474);
			ShortcutExtensions.NativeMethodInfoPtr_DOColor_Public_Static_Tweener_Light_Color_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, 100663475);
			ShortcutExtensions.NativeMethodInfoPtr_DOIntensity_Public_Static_Tweener_Light_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, 100663476);
			ShortcutExtensions.NativeMethodInfoPtr_DOShadowStrength_Public_Static_Tweener_Light_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, 100663477);
			ShortcutExtensions.NativeMethodInfoPtr_DOColor_Public_Static_Tweener_LineRenderer_Color2_Color2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, 100663478);
			ShortcutExtensions.NativeMethodInfoPtr_DOColor_Public_Static_Tweener_Material_Color_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, 100663479);
			ShortcutExtensions.NativeMethodInfoPtr_DOColor_Public_Static_Tweener_Material_Color_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, 100663480);
			ShortcutExtensions.NativeMethodInfoPtr_DOFade_Public_Static_Tweener_Material_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, 100663481);
			ShortcutExtensions.NativeMethodInfoPtr_DOFade_Public_Static_Tweener_Material_Single_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, 100663482);
			ShortcutExtensions.NativeMethodInfoPtr_DOFloat_Public_Static_Tweener_Material_Single_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, 100663483);
			ShortcutExtensions.NativeMethodInfoPtr_DOOffset_Public_Static_Tweener_Material_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, 100663484);
			ShortcutExtensions.NativeMethodInfoPtr_DOOffset_Public_Static_Tweener_Material_Vector2_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, 100663485);
			ShortcutExtensions.NativeMethodInfoPtr_DOTiling_Public_Static_Tweener_Material_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, 100663486);
			ShortcutExtensions.NativeMethodInfoPtr_DOTiling_Public_Static_Tweener_Material_Vector2_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, 100663487);
			ShortcutExtensions.NativeMethodInfoPtr_DOVector_Public_Static_Tweener_Material_Vector4_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, 100663488);
			ShortcutExtensions.NativeMethodInfoPtr_DOMove_Public_Static_Tweener_Rigidbody_Vector3_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, 100663489);
			ShortcutExtensions.NativeMethodInfoPtr_DOMoveX_Public_Static_Tweener_Rigidbody_Single_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, 100663490);
			ShortcutExtensions.NativeMethodInfoPtr_DOMoveY_Public_Static_Tweener_Rigidbody_Single_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, 100663491);
			ShortcutExtensions.NativeMethodInfoPtr_DOMoveZ_Public_Static_Tweener_Rigidbody_Single_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, 100663492);
			ShortcutExtensions.NativeMethodInfoPtr_DORotate_Public_Static_Tweener_Rigidbody_Vector3_Single_RotateMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, 100663493);
			ShortcutExtensions.NativeMethodInfoPtr_DOLookAt_Public_Static_Tweener_Rigidbody_Vector3_Single_AxisConstraint_Nullable_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, 100663494);
			ShortcutExtensions.NativeMethodInfoPtr_DOJump_Public_Static_Sequence_Rigidbody_Vector3_Single_Int32_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, 100663495);
			ShortcutExtensions.NativeMethodInfoPtr_DOPath_Public_Static_TweenerCore_3_Vector3_Path_PathOptions_Rigidbody_Il2CppStructArray_1_Vector3_Single_PathType_PathMode_Int32_Nullable_1_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, 100663496);
			ShortcutExtensions.NativeMethodInfoPtr_DOLocalPath_Public_Static_TweenerCore_3_Vector3_Path_PathOptions_Rigidbody_Il2CppStructArray_1_Vector3_Single_PathType_PathMode_Int32_Nullable_1_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, 100663497);
			ShortcutExtensions.NativeMethodInfoPtr_DOPath_Internal_Static_TweenerCore_3_Vector3_Path_PathOptions_Rigidbody_Path_Single_PathMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, 100663498);
			ShortcutExtensions.NativeMethodInfoPtr_DOLocalPath_Internal_Static_TweenerCore_3_Vector3_Path_PathOptions_Rigidbody_Path_Single_PathMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, 100663499);
			ShortcutExtensions.NativeMethodInfoPtr_DOResize_Public_Static_Tweener_TrailRenderer_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, 100663500);
			ShortcutExtensions.NativeMethodInfoPtr_DOTime_Public_Static_Tweener_TrailRenderer_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, 100663501);
			ShortcutExtensions.NativeMethodInfoPtr_DOMove_Public_Static_Tweener_Transform_Vector3_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, 100663502);
			ShortcutExtensions.NativeMethodInfoPtr_DOMoveX_Public_Static_Tweener_Transform_Single_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, 100663503);
			ShortcutExtensions.NativeMethodInfoPtr_DOMoveY_Public_Static_Tweener_Transform_Single_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, 100663504);
			ShortcutExtensions.NativeMethodInfoPtr_DOMoveZ_Public_Static_Tweener_Transform_Single_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, 100663505);
			ShortcutExtensions.NativeMethodInfoPtr_DOLocalMove_Public_Static_Tweener_Transform_Vector3_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, 100663506);
			ShortcutExtensions.NativeMethodInfoPtr_DOLocalMoveX_Public_Static_Tweener_Transform_Single_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, 100663507);
			ShortcutExtensions.NativeMethodInfoPtr_DOLocalMoveY_Public_Static_Tweener_Transform_Single_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, 100663508);
			ShortcutExtensions.NativeMethodInfoPtr_DOLocalMoveZ_Public_Static_Tweener_Transform_Single_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, 100663509);
			ShortcutExtensions.NativeMethodInfoPtr_DORotate_Public_Static_Tweener_Transform_Vector3_Single_RotateMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, 100663510);
			ShortcutExtensions.NativeMethodInfoPtr_DORotateQuaternion_Public_Static_Tweener_Transform_Quaternion_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, 100663511);
			ShortcutExtensions.NativeMethodInfoPtr_DOLocalRotate_Public_Static_Tweener_Transform_Vector3_Single_RotateMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, 100663512);
			ShortcutExtensions.NativeMethodInfoPtr_DOLocalRotateQuaternion_Public_Static_Tweener_Transform_Quaternion_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, 100663513);
			ShortcutExtensions.NativeMethodInfoPtr_DOScale_Public_Static_Tweener_Transform_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, 100663514);
			ShortcutExtensions.NativeMethodInfoPtr_DOScale_Public_Static_Tweener_Transform_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, 100663515);
			ShortcutExtensions.NativeMethodInfoPtr_DOScaleX_Public_Static_Tweener_Transform_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, 100663516);
			ShortcutExtensions.NativeMethodInfoPtr_DOScaleY_Public_Static_Tweener_Transform_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, 100663517);
			ShortcutExtensions.NativeMethodInfoPtr_DOScaleZ_Public_Static_Tweener_Transform_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, 100663518);
			ShortcutExtensions.NativeMethodInfoPtr_DOLookAt_Public_Static_Tweener_Transform_Vector3_Single_AxisConstraint_Nullable_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, 100663519);
			ShortcutExtensions.NativeMethodInfoPtr_DOPunchPosition_Public_Static_Tweener_Transform_Vector3_Single_Int32_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, 100663520);
			ShortcutExtensions.NativeMethodInfoPtr_DOPunchScale_Public_Static_Tweener_Transform_Vector3_Single_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, 100663521);
			ShortcutExtensions.NativeMethodInfoPtr_DOPunchRotation_Public_Static_Tweener_Transform_Vector3_Single_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, 100663522);
			ShortcutExtensions.NativeMethodInfoPtr_DOShakePosition_Public_Static_Tweener_Transform_Single_Single_Int32_Single_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, 100663523);
			ShortcutExtensions.NativeMethodInfoPtr_DOShakePosition_Public_Static_Tweener_Transform_Single_Vector3_Int32_Single_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, 100663524);
			ShortcutExtensions.NativeMethodInfoPtr_DOShakeRotation_Public_Static_Tweener_Transform_Single_Single_Int32_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, 100663525);
			ShortcutExtensions.NativeMethodInfoPtr_DOShakeRotation_Public_Static_Tweener_Transform_Single_Vector3_Int32_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, 100663526);
			ShortcutExtensions.NativeMethodInfoPtr_DOShakeScale_Public_Static_Tweener_Transform_Single_Single_Int32_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, 100663527);
			ShortcutExtensions.NativeMethodInfoPtr_DOShakeScale_Public_Static_Tweener_Transform_Single_Vector3_Int32_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, 100663528);
			ShortcutExtensions.NativeMethodInfoPtr_DOJump_Public_Static_Sequence_Transform_Vector3_Single_Int32_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, 100663529);
			ShortcutExtensions.NativeMethodInfoPtr_DOLocalJump_Public_Static_Sequence_Transform_Vector3_Single_Int32_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, 100663530);
			ShortcutExtensions.NativeMethodInfoPtr_DOPath_Public_Static_TweenerCore_3_Vector3_Path_PathOptions_Transform_Il2CppStructArray_1_Vector3_Single_PathType_PathMode_Int32_Nullable_1_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, 100663531);
			ShortcutExtensions.NativeMethodInfoPtr_DOLocalPath_Public_Static_TweenerCore_3_Vector3_Path_PathOptions_Transform_Il2CppStructArray_1_Vector3_Single_PathType_PathMode_Int32_Nullable_1_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, 100663532);
			ShortcutExtensions.NativeMethodInfoPtr_DOPath_Internal_Static_TweenerCore_3_Vector3_Path_PathOptions_Transform_Path_Single_PathMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, 100663533);
			ShortcutExtensions.NativeMethodInfoPtr_DOLocalPath_Internal_Static_TweenerCore_3_Vector3_Path_PathOptions_Transform_Path_Single_PathMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, 100663534);
			ShortcutExtensions.NativeMethodInfoPtr_DOTimeScale_Public_Static_Tweener_Tween_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, 100663535);
			ShortcutExtensions.NativeMethodInfoPtr_DOBlendableColor_Public_Static_Tweener_Light_Color_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, 100663536);
			ShortcutExtensions.NativeMethodInfoPtr_DOBlendableColor_Public_Static_Tweener_Material_Color_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, 100663537);
			ShortcutExtensions.NativeMethodInfoPtr_DOBlendableColor_Public_Static_Tweener_Material_Color_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, 100663538);
			ShortcutExtensions.NativeMethodInfoPtr_DOBlendableMoveBy_Public_Static_Tweener_Transform_Vector3_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, 100663539);
			ShortcutExtensions.NativeMethodInfoPtr_DOBlendableLocalMoveBy_Public_Static_Tweener_Transform_Vector3_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, 100663540);
			ShortcutExtensions.NativeMethodInfoPtr_DOBlendableRotateBy_Public_Static_Tweener_Transform_Vector3_Single_RotateMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, 100663541);
			ShortcutExtensions.NativeMethodInfoPtr_DOBlendableLocalRotateBy_Public_Static_Tweener_Transform_Vector3_Single_RotateMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, 100663542);
			ShortcutExtensions.NativeMethodInfoPtr_DOBlendablePunchRotation_Public_Static_Tweener_Transform_Vector3_Single_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, 100663543);
			ShortcutExtensions.NativeMethodInfoPtr_DOBlendableScaleBy_Public_Static_Tweener_Transform_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, 100663544);
			ShortcutExtensions.NativeMethodInfoPtr_DOComplete_Public_Static_Int32_Component_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, 100663545);
			ShortcutExtensions.NativeMethodInfoPtr_DOComplete_Public_Static_Int32_Material_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, 100663546);
			ShortcutExtensions.NativeMethodInfoPtr_DOKill_Public_Static_Int32_Component_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, 100663547);
			ShortcutExtensions.NativeMethodInfoPtr_DOKill_Public_Static_Int32_Material_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, 100663548);
			ShortcutExtensions.NativeMethodInfoPtr_DOFlip_Public_Static_Int32_Component_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, 100663549);
			ShortcutExtensions.NativeMethodInfoPtr_DOFlip_Public_Static_Int32_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, 100663550);
			ShortcutExtensions.NativeMethodInfoPtr_DOGoto_Public_Static_Int32_Component_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, 100663551);
			ShortcutExtensions.NativeMethodInfoPtr_DOGoto_Public_Static_Int32_Material_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, 100663552);
			ShortcutExtensions.NativeMethodInfoPtr_DOPause_Public_Static_Int32_Component_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, 100663553);
			ShortcutExtensions.NativeMethodInfoPtr_DOPause_Public_Static_Int32_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, 100663554);
			ShortcutExtensions.NativeMethodInfoPtr_DOPlay_Public_Static_Int32_Component_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, 100663555);
			ShortcutExtensions.NativeMethodInfoPtr_DOPlay_Public_Static_Int32_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, 100663556);
			ShortcutExtensions.NativeMethodInfoPtr_DOPlayBackwards_Public_Static_Int32_Component_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, 100663557);
			ShortcutExtensions.NativeMethodInfoPtr_DOPlayBackwards_Public_Static_Int32_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, 100663558);
			ShortcutExtensions.NativeMethodInfoPtr_DOPlayForward_Public_Static_Int32_Component_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, 100663559);
			ShortcutExtensions.NativeMethodInfoPtr_DOPlayForward_Public_Static_Int32_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, 100663560);
			ShortcutExtensions.NativeMethodInfoPtr_DORestart_Public_Static_Int32_Component_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, 100663561);
			ShortcutExtensions.NativeMethodInfoPtr_DORestart_Public_Static_Int32_Material_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, 100663562);
			ShortcutExtensions.NativeMethodInfoPtr_DORewind_Public_Static_Int32_Component_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, 100663563);
			ShortcutExtensions.NativeMethodInfoPtr_DORewind_Public_Static_Int32_Material_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, 100663564);
			ShortcutExtensions.NativeMethodInfoPtr_DOSmoothRewind_Public_Static_Int32_Component_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, 100663565);
			ShortcutExtensions.NativeMethodInfoPtr_DOSmoothRewind_Public_Static_Int32_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, 100663566);
			ShortcutExtensions.NativeMethodInfoPtr_DOTogglePause_Public_Static_Int32_Component_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, 100663567);
			ShortcutExtensions.NativeMethodInfoPtr_DOTogglePause_Public_Static_Int32_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, 100663568);
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x0000A374 File Offset: 0x00008574
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1128391, XrefRangeEnd = 1128417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Tweener DOFade(this AudioSource target, float endValue, float duration)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.NativeMethodInfoPtr_DOFade_Public_Static_Tweener_AudioSource_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Tweener>(intPtr3) : null;
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x0000A3D4 File Offset: 0x000085D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1128417, XrefRangeEnd = 1128442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Tweener DOPitch(this AudioSource target, float endValue, float duration)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.NativeMethodInfoPtr_DOPitch_Public_Static_Tweener_AudioSource_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Tweener>(intPtr3) : null;
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x0000A434 File Offset: 0x00008634
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1128442, XrefRangeEnd = 1128467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Tweener DOAspect(this Camera target, float endValue, float duration)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.NativeMethodInfoPtr_DOAspect_Public_Static_Tweener_Camera_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Tweener>(intPtr3) : null;
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x0000A494 File Offset: 0x00008694
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1128467, XrefRangeEnd = 1128497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Tweener DOColor(this Camera target, Color endValue, float duration)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.NativeMethodInfoPtr_DOColor_Public_Static_Tweener_Camera_Color_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Tweener>(intPtr3) : null;
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x0000A4F4 File Offset: 0x000086F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1128497, XrefRangeEnd = 1128522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Tweener DOFarClipPlane(this Camera target, float endValue, float duration)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.NativeMethodInfoPtr_DOFarClipPlane_Public_Static_Tweener_Camera_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Tweener>(intPtr3) : null;
		}

		// Token: 0x060000FA RID: 250 RVA: 0x0000A554 File Offset: 0x00008754
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1128522, XrefRangeEnd = 1128547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Tweener DOFieldOfView(this Camera target, float endValue, float duration)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.NativeMethodInfoPtr_DOFieldOfView_Public_Static_Tweener_Camera_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Tweener>(intPtr3) : null;
		}

		// Token: 0x060000FB RID: 251 RVA: 0x0000A5B4 File Offset: 0x000087B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1128547, XrefRangeEnd = 1128572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Tweener DONearClipPlane(this Camera target, float endValue, float duration)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.NativeMethodInfoPtr_DONearClipPlane_Public_Static_Tweener_Camera_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Tweener>(intPtr3) : null;
		}

		// Token: 0x060000FC RID: 252 RVA: 0x0000A614 File Offset: 0x00008814
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1128572, XrefRangeEnd = 1128597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Tweener DOOrthoSize(this Camera target, float endValue, float duration)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.NativeMethodInfoPtr_DOOrthoSize_Public_Static_Tweener_Camera_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Tweener>(intPtr3) : null;
		}

		// Token: 0x060000FD RID: 253 RVA: 0x0000A674 File Offset: 0x00008874
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1128597, XrefRangeEnd = 1128627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Tweener DOPixelRect(this Camera target, Rect endValue, float duration)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.NativeMethodInfoPtr_DOPixelRect_Public_Static_Tweener_Camera_Rect_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Tweener>(intPtr3) : null;
		}

		// Token: 0x060000FE RID: 254 RVA: 0x0000A6D4 File Offset: 0x000088D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1128627, XrefRangeEnd = 1128657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Tweener DORect(this Camera target, Rect endValue, float duration)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.NativeMethodInfoPtr_DORect_Public_Static_Tweener_Camera_Rect_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Tweener>(intPtr3) : null;
		}

		// Token: 0x060000FF RID: 255 RVA: 0x0000A734 File Offset: 0x00008934
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1128657, XrefRangeEnd = 1128687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Tweener DOShakePosition(this Camera target, float duration, float strength = 3f, int vibrato = 10, float randomness = 90f, bool fadeOut = true)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref strength;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref vibrato;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref randomness;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fadeOut;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.NativeMethodInfoPtr_DOShakePosition_Public_Static_Tweener_Camera_Single_Single_Int32_Single_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Tweener>(intPtr3) : null;
		}

		// Token: 0x06000100 RID: 256 RVA: 0x0000A7C0 File Offset: 0x000089C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1128687, XrefRangeEnd = 1128720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Tweener DOShakePosition(this Camera target, float duration, Vector3 strength, int vibrato = 10, float randomness = 90f, bool fadeOut = true)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref strength;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref vibrato;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref randomness;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fadeOut;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.NativeMethodInfoPtr_DOShakePosition_Public_Static_Tweener_Camera_Single_Vector3_Int32_Single_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Tweener>(intPtr3) : null;
		}

		// Token: 0x06000101 RID: 257 RVA: 0x0000A84C File Offset: 0x00008A4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1128720, XrefRangeEnd = 1128750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Tweener DOShakeRotation(this Camera target, float duration, float strength = 90f, int vibrato = 10, float randomness = 90f, bool fadeOut = true)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref strength;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref vibrato;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref randomness;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fadeOut;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.NativeMethodInfoPtr_DOShakeRotation_Public_Static_Tweener_Camera_Single_Single_Int32_Single_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Tweener>(intPtr3) : null;
		}

		// Token: 0x06000102 RID: 258 RVA: 0x0000A8D8 File Offset: 0x00008AD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1128750, XrefRangeEnd = 1128783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Tweener DOShakeRotation(this Camera target, float duration, Vector3 strength, int vibrato = 10, float randomness = 90f, bool fadeOut = true)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref strength;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref vibrato;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref randomness;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fadeOut;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.NativeMethodInfoPtr_DOShakeRotation_Public_Static_Tweener_Camera_Single_Vector3_Int32_Single_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Tweener>(intPtr3) : null;
		}

		// Token: 0x06000103 RID: 259 RVA: 0x0000A964 File Offset: 0x00008B64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1128783, XrefRangeEnd = 1128813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Tweener DOColor(this Light target, Color endValue, float duration)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.NativeMethodInfoPtr_DOColor_Public_Static_Tweener_Light_Color_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Tweener>(intPtr3) : null;
		}

		// Token: 0x06000104 RID: 260 RVA: 0x0000A9C4 File Offset: 0x00008BC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1128813, XrefRangeEnd = 1128838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Tweener DOIntensity(this Light target, float endValue, float duration)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.NativeMethodInfoPtr_DOIntensity_Public_Static_Tweener_Light_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Tweener>(intPtr3) : null;
		}

		// Token: 0x06000105 RID: 261 RVA: 0x0000AA24 File Offset: 0x00008C24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1128838, XrefRangeEnd = 1128863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Tweener DOShadowStrength(this Light target, float endValue, float duration)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.NativeMethodInfoPtr_DOShadowStrength_Public_Static_Tweener_Light_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Tweener>(intPtr3) : null;
		}

		// Token: 0x06000106 RID: 262 RVA: 0x0000AA84 File Offset: 0x00008C84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1128863, XrefRangeEnd = 1128893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Tweener DOColor(this LineRenderer target, Color2 startValue, Color2 endValue, float duration)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endValue;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.NativeMethodInfoPtr_DOColor_Public_Static_Tweener_LineRenderer_Color2_Color2_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Tweener>(intPtr3) : null;
		}

		// Token: 0x06000107 RID: 263 RVA: 0x0000AAF4 File Offset: 0x00008CF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1128893, XrefRangeEnd = 1128923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Tweener DOColor(this Material target, Color endValue, float duration)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.NativeMethodInfoPtr_DOColor_Public_Static_Tweener_Material_Color_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Tweener>(intPtr3) : null;
		}

		// Token: 0x06000108 RID: 264 RVA: 0x0000AB54 File Offset: 0x00008D54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1128923, XrefRangeEnd = 1128955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Tweener DOColor(this Material target, Color endValue, string property, float duration)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(property);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.NativeMethodInfoPtr_DOColor_Public_Static_Tweener_Material_Color_String_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Tweener>(intPtr3) : null;
		}

		// Token: 0x06000109 RID: 265 RVA: 0x0000ABC8 File Offset: 0x00008DC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1128955, XrefRangeEnd = 1128980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Tweener DOFade(this Material target, float endValue, float duration)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.NativeMethodInfoPtr_DOFade_Public_Static_Tweener_Material_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Tweener>(intPtr3) : null;
		}

		// Token: 0x0600010A RID: 266 RVA: 0x0000AC28 File Offset: 0x00008E28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1128980, XrefRangeEnd = 1129007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Tweener DOFade(this Material target, float endValue, string property, float duration)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(property);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.NativeMethodInfoPtr_DOFade_Public_Static_Tweener_Material_Single_String_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Tweener>(intPtr3) : null;
		}

		// Token: 0x0600010B RID: 267 RVA: 0x0000AC9C File Offset: 0x00008E9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1129007, XrefRangeEnd = 1129034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Tweener DOFloat(this Material target, float endValue, string property, float duration)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(property);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.NativeMethodInfoPtr_DOFloat_Public_Static_Tweener_Material_Single_String_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Tweener>(intPtr3) : null;
		}

		// Token: 0x0600010C RID: 268 RVA: 0x0000AD10 File Offset: 0x00008F10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1129034, XrefRangeEnd = 1129059, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Tweener DOOffset(this Material target, Vector2 endValue, float duration)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.NativeMethodInfoPtr_DOOffset_Public_Static_Tweener_Material_Vector2_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Tweener>(intPtr3) : null;
		}

		// Token: 0x0600010D RID: 269 RVA: 0x0000AD70 File Offset: 0x00008F70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1129059, XrefRangeEnd = 1129086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Tweener DOOffset(this Material target, Vector2 endValue, string property, float duration)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(property);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.NativeMethodInfoPtr_DOOffset_Public_Static_Tweener_Material_Vector2_String_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Tweener>(intPtr3) : null;
		}

		// Token: 0x0600010E RID: 270 RVA: 0x0000ADE4 File Offset: 0x00008FE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1129086, XrefRangeEnd = 1129111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Tweener DOTiling(this Material target, Vector2 endValue, float duration)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.NativeMethodInfoPtr_DOTiling_Public_Static_Tweener_Material_Vector2_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Tweener>(intPtr3) : null;
		}

		// Token: 0x0600010F RID: 271 RVA: 0x0000AE44 File Offset: 0x00009044
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1129111, XrefRangeEnd = 1129138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Tweener DOTiling(this Material target, Vector2 endValue, string property, float duration)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(property);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.NativeMethodInfoPtr_DOTiling_Public_Static_Tweener_Material_Vector2_String_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Tweener>(intPtr3) : null;
		}

		// Token: 0x06000110 RID: 272 RVA: 0x0000AEB8 File Offset: 0x000090B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1129138, XrefRangeEnd = 1129170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Tweener DOVector(this Material target, Vector4 endValue, string property, float duration)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(property);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.NativeMethodInfoPtr_DOVector_Public_Static_Tweener_Material_Vector4_String_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Tweener>(intPtr3) : null;
		}

		// Token: 0x06000111 RID: 273 RVA: 0x0000AF2C File Offset: 0x0000912C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1129170, XrefRangeEnd = 1129200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Tweener DOMove(this Rigidbody target, Vector3 endValue, float duration, bool snapping = false)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref snapping;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.NativeMethodInfoPtr_DOMove_Public_Static_Tweener_Rigidbody_Vector3_Single_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Tweener>(intPtr3) : null;
		}

		// Token: 0x06000112 RID: 274 RVA: 0x0000AF9C File Offset: 0x0000919C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1129200, XrefRangeEnd = 1129230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Tweener DOMoveX(this Rigidbody target, float endValue, float duration, bool snapping = false)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref snapping;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.NativeMethodInfoPtr_DOMoveX_Public_Static_Tweener_Rigidbody_Single_Single_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Tweener>(intPtr3) : null;
		}

		// Token: 0x06000113 RID: 275 RVA: 0x0000B00C File Offset: 0x0000920C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1129230, XrefRangeEnd = 1129260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Tweener DOMoveY(this Rigidbody target, float endValue, float duration, bool snapping = false)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref snapping;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.NativeMethodInfoPtr_DOMoveY_Public_Static_Tweener_Rigidbody_Single_Single_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Tweener>(intPtr3) : null;
		}

		// Token: 0x06000114 RID: 276 RVA: 0x0000B07C File Offset: 0x0000927C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1129260, XrefRangeEnd = 1129290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Tweener DOMoveZ(this Rigidbody target, float endValue, float duration, bool snapping = false)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref snapping;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.NativeMethodInfoPtr_DOMoveZ_Public_Static_Tweener_Rigidbody_Single_Single_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Tweener>(intPtr3) : null;
		}

		// Token: 0x06000115 RID: 277 RVA: 0x0000B0EC File Offset: 0x000092EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1129290, XrefRangeEnd = 1129319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Tweener DORotate(this Rigidbody target, Vector3 endValue, float duration, RotateMode mode = RotateMode.Fast)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.NativeMethodInfoPtr_DORotate_Public_Static_Tweener_Rigidbody_Vector3_Single_RotateMode_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Tweener>(intPtr3) : null;
		}

		// Token: 0x06000116 RID: 278 RVA: 0x0000B15C File Offset: 0x0000935C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1129319, XrefRangeEnd = 1129358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Tweener DOLookAt(this Rigidbody target, Vector3 towards, float duration, AxisConstraint axisConstraint = AxisConstraint.None, Nullable<Vector3> up = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref towards;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref axisConstraint;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(up));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.NativeMethodInfoPtr_DOLookAt_Public_Static_Tweener_Rigidbody_Vector3_Single_AxisConstraint_Nullable_1_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Tweener>(intPtr3) : null;
		}

		// Token: 0x06000117 RID: 279 RVA: 0x0000B1E4 File Offset: 0x000093E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1129358, XrefRangeEnd = 1129451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Sequence DOJump(this Rigidbody target, Vector3 endValue, float jumpPower, int numJumps, float duration, bool snapping = false)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref jumpPower;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref numJumps;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref snapping;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.NativeMethodInfoPtr_DOJump_Public_Static_Sequence_Rigidbody_Vector3_Single_Int32_Single_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sequence>(intPtr3) : null;
		}

		// Token: 0x06000118 RID: 280 RVA: 0x0000B270 File Offset: 0x00009470
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1129451, XrefRangeEnd = 1129485, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TweenerCore<Vector3, Path, PathOptions> DOPath(this Rigidbody target, Il2CppStructArray<Vector3> path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, Nullable<Color> gizmoColor = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(path);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pathType;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pathMode;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref resolution;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(gizmoColor));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.NativeMethodInfoPtr_DOPath_Public_Static_TweenerCore_3_Vector3_Path_PathOptions_Rigidbody_Il2CppStructArray_1_Vector3_Single_PathType_PathMode_Int32_Nullable_1_Color_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TweenerCore<Vector3, Path, PathOptions>>(intPtr3) : null;
		}

		// Token: 0x06000119 RID: 281 RVA: 0x0000B318 File Offset: 0x00009518
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1129485, XrefRangeEnd = 1129521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TweenerCore<Vector3, Path, PathOptions> DOLocalPath(this Rigidbody target, Il2CppStructArray<Vector3> path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, Nullable<Color> gizmoColor = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(path);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pathType;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pathMode;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref resolution;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(gizmoColor));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.NativeMethodInfoPtr_DOLocalPath_Public_Static_TweenerCore_3_Vector3_Path_PathOptions_Rigidbody_Il2CppStructArray_1_Vector3_Single_PathType_PathMode_Int32_Nullable_1_Color_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TweenerCore<Vector3, Path, PathOptions>>(intPtr3) : null;
		}

		// Token: 0x0600011A RID: 282 RVA: 0x0000B3C0 File Offset: 0x000095C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1129521, XrefRangeEnd = 1129548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TweenerCore<Vector3, Path, PathOptions> DOPath(this Rigidbody target, Path path, float duration, PathMode pathMode = PathMode.Full3D)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(path);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pathMode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.NativeMethodInfoPtr_DOPath_Internal_Static_TweenerCore_3_Vector3_Path_PathOptions_Rigidbody_Path_Single_PathMode_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TweenerCore<Vector3, Path, PathOptions>>(intPtr3) : null;
		}

		// Token: 0x0600011B RID: 283 RVA: 0x0000B434 File Offset: 0x00009634
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1129548, XrefRangeEnd = 1129577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TweenerCore<Vector3, Path, PathOptions> DOLocalPath(this Rigidbody target, Path path, float duration, PathMode pathMode = PathMode.Full3D)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(path);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pathMode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.NativeMethodInfoPtr_DOLocalPath_Internal_Static_TweenerCore_3_Vector3_Path_PathOptions_Rigidbody_Path_Single_PathMode_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TweenerCore<Vector3, Path, PathOptions>>(intPtr3) : null;
		}

		// Token: 0x0600011C RID: 284 RVA: 0x0000B4A8 File Offset: 0x000096A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1129577, XrefRangeEnd = 1129602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Tweener DOResize(this TrailRenderer target, float toStartWidth, float toEndWidth, float duration)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref toStartWidth;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref toEndWidth;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.NativeMethodInfoPtr_DOResize_Public_Static_Tweener_TrailRenderer_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Tweener>(intPtr3) : null;
		}

		// Token: 0x0600011D RID: 285 RVA: 0x0000B518 File Offset: 0x00009718
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1129602, XrefRangeEnd = 1129627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Tweener DOTime(this TrailRenderer target, float endValue, float duration)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.NativeMethodInfoPtr_DOTime_Public_Static_Tweener_TrailRenderer_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Tweener>(intPtr3) : null;
		}

		// Token: 0x0600011E RID: 286 RVA: 0x0000B578 File Offset: 0x00009778
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1129657, RefRangeEnd = 1129659, XrefRangeStart = 1129627, XrefRangeEnd = 1129657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Tweener DOMove(this Transform target, Vector3 endValue, float duration, bool snapping = false)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref snapping;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.NativeMethodInfoPtr_DOMove_Public_Static_Tweener_Transform_Vector3_Single_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Tweener>(intPtr3) : null;
		}

		// Token: 0x0600011F RID: 287 RVA: 0x0000B5E8 File Offset: 0x000097E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1129659, XrefRangeEnd = 1129689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Tweener DOMoveX(this Transform target, float endValue, float duration, bool snapping = false)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref snapping;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.NativeMethodInfoPtr_DOMoveX_Public_Static_Tweener_Transform_Single_Single_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Tweener>(intPtr3) : null;
		}

		// Token: 0x06000120 RID: 288 RVA: 0x0000B658 File Offset: 0x00009858
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1129689, XrefRangeEnd = 1129719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Tweener DOMoveY(this Transform target, float endValue, float duration, bool snapping = false)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref snapping;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.NativeMethodInfoPtr_DOMoveY_Public_Static_Tweener_Transform_Single_Single_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Tweener>(intPtr3) : null;
		}

		// Token: 0x06000121 RID: 289 RVA: 0x0000B6C8 File Offset: 0x000098C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1129719, XrefRangeEnd = 1129749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Tweener DOMoveZ(this Transform target, float endValue, float duration, bool snapping = false)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref snapping;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.NativeMethodInfoPtr_DOMoveZ_Public_Static_Tweener_Transform_Single_Single_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Tweener>(intPtr3) : null;
		}

		// Token: 0x06000122 RID: 290 RVA: 0x0000B738 File Offset: 0x00009938
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1129749, XrefRangeEnd = 1129779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Tweener DOLocalMove(this Transform target, Vector3 endValue, float duration, bool snapping = false)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref snapping;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.NativeMethodInfoPtr_DOLocalMove_Public_Static_Tweener_Transform_Vector3_Single_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Tweener>(intPtr3) : null;
		}

		// Token: 0x06000123 RID: 291 RVA: 0x0000B7A8 File Offset: 0x000099A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1129779, XrefRangeEnd = 1129809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Tweener DOLocalMoveX(this Transform target, float endValue, float duration, bool snapping = false)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref snapping;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.NativeMethodInfoPtr_DOLocalMoveX_Public_Static_Tweener_Transform_Single_Single_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Tweener>(intPtr3) : null;
		}

		// Token: 0x06000124 RID: 292 RVA: 0x0000B818 File Offset: 0x00009A18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1129809, XrefRangeEnd = 1129839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Tweener DOLocalMoveY(this Transform target, float endValue, float duration, bool snapping = false)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref snapping;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.NativeMethodInfoPtr_DOLocalMoveY_Public_Static_Tweener_Transform_Single_Single_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Tweener>(intPtr3) : null;
		}

		// Token: 0x06000125 RID: 293 RVA: 0x0000B888 File Offset: 0x00009A88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1129839, XrefRangeEnd = 1129869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Tweener DOLocalMoveZ(this Transform target, float endValue, float duration, bool snapping = false)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref snapping;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.NativeMethodInfoPtr_DOLocalMoveZ_Public_Static_Tweener_Transform_Single_Single_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Tweener>(intPtr3) : null;
		}

		// Token: 0x06000126 RID: 294 RVA: 0x0000B8F8 File Offset: 0x00009AF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1129869, XrefRangeEnd = 1129898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Tweener DORotate(this Transform target, Vector3 endValue, float duration, RotateMode mode = RotateMode.Fast)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.NativeMethodInfoPtr_DORotate_Public_Static_Tweener_Transform_Vector3_Single_RotateMode_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Tweener>(intPtr3) : null;
		}

		// Token: 0x06000127 RID: 295 RVA: 0x0000B968 File Offset: 0x00009B68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1129898, XrefRangeEnd = 1129925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Tweener DORotateQuaternion(this Transform target, Quaternion endValue, float duration)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.NativeMethodInfoPtr_DORotateQuaternion_Public_Static_Tweener_Transform_Quaternion_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Tweener>(intPtr3) : null;
		}

		// Token: 0x06000128 RID: 296 RVA: 0x0000B9C8 File Offset: 0x00009BC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1129925, XrefRangeEnd = 1129954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Tweener DOLocalRotate(this Transform target, Vector3 endValue, float duration, RotateMode mode = RotateMode.Fast)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.NativeMethodInfoPtr_DOLocalRotate_Public_Static_Tweener_Transform_Vector3_Single_RotateMode_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Tweener>(intPtr3) : null;
		}

		// Token: 0x06000129 RID: 297 RVA: 0x0000BA38 File Offset: 0x00009C38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1129954, XrefRangeEnd = 1129981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Tweener DOLocalRotateQuaternion(this Transform target, Quaternion endValue, float duration)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.NativeMethodInfoPtr_DOLocalRotateQuaternion_Public_Static_Tweener_Transform_Quaternion_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Tweener>(intPtr3) : null;
		}

		// Token: 0x0600012A RID: 298 RVA: 0x0000BA98 File Offset: 0x00009C98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1129981, XrefRangeEnd = 1130011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Tweener DOScale(this Transform target, Vector3 endValue, float duration)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.NativeMethodInfoPtr_DOScale_Public_Static_Tweener_Transform_Vector3_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Tweener>(intPtr3) : null;
		}

		// Token: 0x0600012B RID: 299 RVA: 0x0000BAF8 File Offset: 0x00009CF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1130011, XrefRangeEnd = 1130041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Tweener DOScale(this Transform target, float endValue, float duration)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.NativeMethodInfoPtr_DOScale_Public_Static_Tweener_Transform_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Tweener>(intPtr3) : null;
		}

		// Token: 0x0600012C RID: 300 RVA: 0x0000BB58 File Offset: 0x00009D58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1130041, XrefRangeEnd = 1130071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Tweener DOScaleX(this Transform target, float endValue, float duration)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.NativeMethodInfoPtr_DOScaleX_Public_Static_Tweener_Transform_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Tweener>(intPtr3) : null;
		}

		// Token: 0x0600012D RID: 301 RVA: 0x0000BBB8 File Offset: 0x00009DB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1130071, XrefRangeEnd = 1130101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Tweener DOScaleY(this Transform target, float endValue, float duration)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.NativeMethodInfoPtr_DOScaleY_Public_Static_Tweener_Transform_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Tweener>(intPtr3) : null;
		}

		// Token: 0x0600012E RID: 302 RVA: 0x0000BC18 File Offset: 0x00009E18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1130101, XrefRangeEnd = 1130131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Tweener DOScaleZ(this Transform target, float endValue, float duration)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.NativeMethodInfoPtr_DOScaleZ_Public_Static_Tweener_Transform_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Tweener>(intPtr3) : null;
		}

		// Token: 0x0600012F RID: 303 RVA: 0x0000BC78 File Offset: 0x00009E78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1130131, XrefRangeEnd = 1130170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Tweener DOLookAt(this Transform target, Vector3 towards, float duration, AxisConstraint axisConstraint = AxisConstraint.None, Nullable<Vector3> up = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref towards;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref axisConstraint;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(up));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.NativeMethodInfoPtr_DOLookAt_Public_Static_Tweener_Transform_Vector3_Single_AxisConstraint_Nullable_1_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Tweener>(intPtr3) : null;
		}

		// Token: 0x06000130 RID: 304 RVA: 0x0000BD00 File Offset: 0x00009F00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1130170, XrefRangeEnd = 1130197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Tweener DOPunchPosition(this Transform target, Vector3 punch, float duration, int vibrato = 10, float elasticity = 1f, bool snapping = false)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref punch;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref vibrato;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref elasticity;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref snapping;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.NativeMethodInfoPtr_DOPunchPosition_Public_Static_Tweener_Transform_Vector3_Single_Int32_Single_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Tweener>(intPtr3) : null;
		}

		// Token: 0x06000131 RID: 305 RVA: 0x0000BD8C File Offset: 0x00009F8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1130197, XrefRangeEnd = 1130224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Tweener DOPunchScale(this Transform target, Vector3 punch, float duration, int vibrato = 10, float elasticity = 1f)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref punch;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref vibrato;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref elasticity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.NativeMethodInfoPtr_DOPunchScale_Public_Static_Tweener_Transform_Vector3_Single_Int32_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Tweener>(intPtr3) : null;
		}

		// Token: 0x06000132 RID: 306 RVA: 0x0000BE08 File Offset: 0x0000A008
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1130224, XrefRangeEnd = 1130251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Tweener DOPunchRotation(this Transform target, Vector3 punch, float duration, int vibrato = 10, float elasticity = 1f)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref punch;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref vibrato;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref elasticity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.NativeMethodInfoPtr_DOPunchRotation_Public_Static_Tweener_Transform_Vector3_Single_Int32_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Tweener>(intPtr3) : null;
		}

		// Token: 0x06000133 RID: 307 RVA: 0x0000BE84 File Offset: 0x0000A084
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1130251, XrefRangeEnd = 1130281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Tweener DOShakePosition(this Transform target, float duration, float strength = 1f, int vibrato = 10, float randomness = 90f, bool snapping = false, bool fadeOut = true)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref strength;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref vibrato;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref randomness;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref snapping;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fadeOut;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.NativeMethodInfoPtr_DOShakePosition_Public_Static_Tweener_Transform_Single_Single_Int32_Single_Boolean_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Tweener>(intPtr3) : null;
		}

		// Token: 0x06000134 RID: 308 RVA: 0x0000BF1C File Offset: 0x0000A11C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1130281, XrefRangeEnd = 1130314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Tweener DOShakePosition(this Transform target, float duration, Vector3 strength, int vibrato = 10, float randomness = 90f, bool snapping = false, bool fadeOut = true)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref strength;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref vibrato;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref randomness;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref snapping;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fadeOut;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.NativeMethodInfoPtr_DOShakePosition_Public_Static_Tweener_Transform_Single_Vector3_Int32_Single_Boolean_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Tweener>(intPtr3) : null;
		}

		// Token: 0x06000135 RID: 309 RVA: 0x0000BFB4 File Offset: 0x0000A1B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1130314, XrefRangeEnd = 1130344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Tweener DOShakeRotation(this Transform target, float duration, float strength = 90f, int vibrato = 10, float randomness = 90f, bool fadeOut = true)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref strength;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref vibrato;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref randomness;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fadeOut;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.NativeMethodInfoPtr_DOShakeRotation_Public_Static_Tweener_Transform_Single_Single_Int32_Single_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Tweener>(intPtr3) : null;
		}

		// Token: 0x06000136 RID: 310 RVA: 0x0000C040 File Offset: 0x0000A240
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1130344, XrefRangeEnd = 1130377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Tweener DOShakeRotation(this Transform target, float duration, Vector3 strength, int vibrato = 10, float randomness = 90f, bool fadeOut = true)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref strength;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref vibrato;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref randomness;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fadeOut;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.NativeMethodInfoPtr_DOShakeRotation_Public_Static_Tweener_Transform_Single_Vector3_Int32_Single_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Tweener>(intPtr3) : null;
		}

		// Token: 0x06000137 RID: 311 RVA: 0x0000C0CC File Offset: 0x0000A2CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1130377, XrefRangeEnd = 1130408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Tweener DOShakeScale(this Transform target, float duration, float strength = 1f, int vibrato = 10, float randomness = 90f, bool fadeOut = true)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref strength;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref vibrato;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref randomness;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fadeOut;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.NativeMethodInfoPtr_DOShakeScale_Public_Static_Tweener_Transform_Single_Single_Int32_Single_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Tweener>(intPtr3) : null;
		}

		// Token: 0x06000138 RID: 312 RVA: 0x0000C158 File Offset: 0x0000A358
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1130408, XrefRangeEnd = 1130441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Tweener DOShakeScale(this Transform target, float duration, Vector3 strength, int vibrato = 10, float randomness = 90f, bool fadeOut = true)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref strength;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref vibrato;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref randomness;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fadeOut;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.NativeMethodInfoPtr_DOShakeScale_Public_Static_Tweener_Transform_Single_Vector3_Int32_Single_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Tweener>(intPtr3) : null;
		}

		// Token: 0x06000139 RID: 313 RVA: 0x0000C1E4 File Offset: 0x0000A3E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1130441, XrefRangeEnd = 1130536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Sequence DOJump(this Transform target, Vector3 endValue, float jumpPower, int numJumps, float duration, bool snapping = false)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref jumpPower;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref numJumps;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref snapping;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.NativeMethodInfoPtr_DOJump_Public_Static_Sequence_Transform_Vector3_Single_Int32_Single_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sequence>(intPtr3) : null;
		}

		// Token: 0x0600013A RID: 314 RVA: 0x0000C270 File Offset: 0x0000A470
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1130536, XrefRangeEnd = 1130631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Sequence DOLocalJump(this Transform target, Vector3 endValue, float jumpPower, int numJumps, float duration, bool snapping = false)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref jumpPower;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref numJumps;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref snapping;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.NativeMethodInfoPtr_DOLocalJump_Public_Static_Sequence_Transform_Vector3_Single_Int32_Single_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sequence>(intPtr3) : null;
		}

		// Token: 0x0600013B RID: 315 RVA: 0x0000C2FC File Offset: 0x0000A4FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1130631, XrefRangeEnd = 1130662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TweenerCore<Vector3, Path, PathOptions> DOPath(this Transform target, Il2CppStructArray<Vector3> path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, Nullable<Color> gizmoColor = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(path);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pathType;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pathMode;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref resolution;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(gizmoColor));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.NativeMethodInfoPtr_DOPath_Public_Static_TweenerCore_3_Vector3_Path_PathOptions_Transform_Il2CppStructArray_1_Vector3_Single_PathType_PathMode_Int32_Nullable_1_Color_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TweenerCore<Vector3, Path, PathOptions>>(intPtr3) : null;
		}

		// Token: 0x0600013C RID: 316 RVA: 0x0000C3A4 File Offset: 0x0000A5A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1130662, XrefRangeEnd = 1130693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TweenerCore<Vector3, Path, PathOptions> DOLocalPath(this Transform target, Il2CppStructArray<Vector3> path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, Nullable<Color> gizmoColor = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(path);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pathType;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pathMode;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref resolution;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(gizmoColor));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.NativeMethodInfoPtr_DOLocalPath_Public_Static_TweenerCore_3_Vector3_Path_PathOptions_Transform_Il2CppStructArray_1_Vector3_Single_PathType_PathMode_Int32_Nullable_1_Color_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TweenerCore<Vector3, Path, PathOptions>>(intPtr3) : null;
		}

		// Token: 0x0600013D RID: 317 RVA: 0x0000C44C File Offset: 0x0000A64C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1130693, XrefRangeEnd = 1130720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TweenerCore<Vector3, Path, PathOptions> DOPath(this Transform target, Path path, float duration, PathMode pathMode = PathMode.Full3D)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(path);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pathMode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.NativeMethodInfoPtr_DOPath_Internal_Static_TweenerCore_3_Vector3_Path_PathOptions_Transform_Path_Single_PathMode_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TweenerCore<Vector3, Path, PathOptions>>(intPtr3) : null;
		}

		// Token: 0x0600013E RID: 318 RVA: 0x0000C4C0 File Offset: 0x0000A6C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1130720, XrefRangeEnd = 1130747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TweenerCore<Vector3, Path, PathOptions> DOLocalPath(this Transform target, Path path, float duration, PathMode pathMode = PathMode.Full3D)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(path);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pathMode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.NativeMethodInfoPtr_DOLocalPath_Internal_Static_TweenerCore_3_Vector3_Path_PathOptions_Transform_Path_Single_PathMode_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TweenerCore<Vector3, Path, PathOptions>>(intPtr3) : null;
		}

		// Token: 0x0600013F RID: 319 RVA: 0x0000C534 File Offset: 0x0000A734
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1130747, XrefRangeEnd = 1130772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Tweener DOTimeScale(this Tween target, float endValue, float duration)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.NativeMethodInfoPtr_DOTimeScale_Public_Static_Tweener_Tween_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Tweener>(intPtr3) : null;
		}

		// Token: 0x06000140 RID: 320 RVA: 0x0000C594 File Offset: 0x0000A794
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1130772, XrefRangeEnd = 1130806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Tweener DOBlendableColor(this Light target, Color endValue, float duration)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.NativeMethodInfoPtr_DOBlendableColor_Public_Static_Tweener_Light_Color_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Tweener>(intPtr3) : null;
		}

		// Token: 0x06000141 RID: 321 RVA: 0x0000C5F4 File Offset: 0x0000A7F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1130806, XrefRangeEnd = 1130840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Tweener DOBlendableColor(this Material target, Color endValue, float duration)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.NativeMethodInfoPtr_DOBlendableColor_Public_Static_Tweener_Material_Color_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Tweener>(intPtr3) : null;
		}

		// Token: 0x06000142 RID: 322 RVA: 0x0000C654 File Offset: 0x0000A854
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1130840, XrefRangeEnd = 1130876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Tweener DOBlendableColor(this Material target, Color endValue, string property, float duration)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(property);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.NativeMethodInfoPtr_DOBlendableColor_Public_Static_Tweener_Material_Color_String_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Tweener>(intPtr3) : null;
		}

		// Token: 0x06000143 RID: 323 RVA: 0x0000C6C8 File Offset: 0x0000A8C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1130876, XrefRangeEnd = 1130911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Tweener DOBlendableMoveBy(this Transform target, Vector3 byValue, float duration, bool snapping = false)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref byValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref snapping;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.NativeMethodInfoPtr_DOBlendableMoveBy_Public_Static_Tweener_Transform_Vector3_Single_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Tweener>(intPtr3) : null;
		}

		// Token: 0x06000144 RID: 324 RVA: 0x0000C738 File Offset: 0x0000A938
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1130911, XrefRangeEnd = 1130946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Tweener DOBlendableLocalMoveBy(this Transform target, Vector3 byValue, float duration, bool snapping = false)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref byValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref snapping;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.NativeMethodInfoPtr_DOBlendableLocalMoveBy_Public_Static_Tweener_Transform_Vector3_Single_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Tweener>(intPtr3) : null;
		}

		// Token: 0x06000145 RID: 325 RVA: 0x0000C7A8 File Offset: 0x0000A9A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1130946, XrefRangeEnd = 1130980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Tweener DOBlendableRotateBy(this Transform target, Vector3 byValue, float duration, RotateMode mode = RotateMode.Fast)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref byValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.NativeMethodInfoPtr_DOBlendableRotateBy_Public_Static_Tweener_Transform_Vector3_Single_RotateMode_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Tweener>(intPtr3) : null;
		}

		// Token: 0x06000146 RID: 326 RVA: 0x0000C818 File Offset: 0x0000AA18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1130980, XrefRangeEnd = 1131014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Tweener DOBlendableLocalRotateBy(this Transform target, Vector3 byValue, float duration, RotateMode mode = RotateMode.Fast)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref byValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.NativeMethodInfoPtr_DOBlendableLocalRotateBy_Public_Static_Tweener_Transform_Vector3_Single_RotateMode_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Tweener>(intPtr3) : null;
		}

		// Token: 0x06000147 RID: 327 RVA: 0x0000C888 File Offset: 0x0000AA88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1131014, XrefRangeEnd = 1131046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Tweener DOBlendablePunchRotation(this Transform target, Vector3 punch, float duration, int vibrato = 10, float elasticity = 1f)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref punch;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref vibrato;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref elasticity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.NativeMethodInfoPtr_DOBlendablePunchRotation_Public_Static_Tweener_Transform_Vector3_Single_Int32_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Tweener>(intPtr3) : null;
		}

		// Token: 0x06000148 RID: 328 RVA: 0x0000C904 File Offset: 0x0000AB04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1131046, XrefRangeEnd = 1131081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Tweener DOBlendableScaleBy(this Transform target, Vector3 byValue, float duration)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref byValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.NativeMethodInfoPtr_DOBlendableScaleBy_Public_Static_Tweener_Transform_Vector3_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Tweener>(intPtr3) : null;
		}

		// Token: 0x06000149 RID: 329 RVA: 0x0000C964 File Offset: 0x0000AB64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1131081, XrefRangeEnd = 1131088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int DOComplete(this Component target, bool withCallbacks = false)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref withCallbacks;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.NativeMethodInfoPtr_DOComplete_Public_Static_Int32_Component_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600014A RID: 330 RVA: 0x0000C9B4 File Offset: 0x0000ABB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1131088, XrefRangeEnd = 1131095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int DOComplete(this Material target, bool withCallbacks = false)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref withCallbacks;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.NativeMethodInfoPtr_DOComplete_Public_Static_Int32_Material_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600014B RID: 331 RVA: 0x0000CA04 File Offset: 0x0000AC04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1131095, XrefRangeEnd = 1131099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int DOKill(this Component target, bool complete = false)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref complete;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.NativeMethodInfoPtr_DOKill_Public_Static_Int32_Component_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600014C RID: 332 RVA: 0x0000CA54 File Offset: 0x0000AC54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1131099, XrefRangeEnd = 1131103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int DOKill(this Material target, bool complete = false)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref complete;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.NativeMethodInfoPtr_DOKill_Public_Static_Int32_Material_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600014D RID: 333 RVA: 0x0000CAA4 File Offset: 0x0000ACA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1131103, XrefRangeEnd = 1131110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int DOFlip(this Component target)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.NativeMethodInfoPtr_DOFlip_Public_Static_Int32_Component_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600014E RID: 334 RVA: 0x0000CAE8 File Offset: 0x0000ACE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1131110, XrefRangeEnd = 1131117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int DOFlip(this Material target)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.NativeMethodInfoPtr_DOFlip_Public_Static_Int32_Material_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600014F RID: 335 RVA: 0x0000CB2C File Offset: 0x0000AD2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1131117, XrefRangeEnd = 1131124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int DOGoto(this Component target, float to, bool andPlay = false)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref to;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref andPlay;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.NativeMethodInfoPtr_DOGoto_Public_Static_Int32_Component_Single_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000150 RID: 336 RVA: 0x0000CB8C File Offset: 0x0000AD8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1131124, XrefRangeEnd = 1131131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int DOGoto(this Material target, float to, bool andPlay = false)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref to;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref andPlay;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.NativeMethodInfoPtr_DOGoto_Public_Static_Int32_Material_Single_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000151 RID: 337 RVA: 0x0000CBEC File Offset: 0x0000ADEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1131131, XrefRangeEnd = 1131138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int DOPause(this Component target)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.NativeMethodInfoPtr_DOPause_Public_Static_Int32_Component_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000152 RID: 338 RVA: 0x0000CC30 File Offset: 0x0000AE30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1131138, XrefRangeEnd = 1131145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int DOPause(this Material target)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.NativeMethodInfoPtr_DOPause_Public_Static_Int32_Material_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000153 RID: 339 RVA: 0x0000CC74 File Offset: 0x0000AE74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1131145, XrefRangeEnd = 1131152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int DOPlay(this Component target)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.NativeMethodInfoPtr_DOPlay_Public_Static_Int32_Component_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000154 RID: 340 RVA: 0x0000CCB8 File Offset: 0x0000AEB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1131152, XrefRangeEnd = 1131159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int DOPlay(this Material target)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.NativeMethodInfoPtr_DOPlay_Public_Static_Int32_Material_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000155 RID: 341 RVA: 0x0000CCFC File Offset: 0x0000AEFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1131159, XrefRangeEnd = 1131166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int DOPlayBackwards(this Component target)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.NativeMethodInfoPtr_DOPlayBackwards_Public_Static_Int32_Component_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000156 RID: 342 RVA: 0x0000CD40 File Offset: 0x0000AF40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1131166, XrefRangeEnd = 1131173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int DOPlayBackwards(this Material target)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.NativeMethodInfoPtr_DOPlayBackwards_Public_Static_Int32_Material_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000157 RID: 343 RVA: 0x0000CD84 File Offset: 0x0000AF84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1131173, XrefRangeEnd = 1131180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int DOPlayForward(this Component target)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.NativeMethodInfoPtr_DOPlayForward_Public_Static_Int32_Component_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000158 RID: 344 RVA: 0x0000CDC8 File Offset: 0x0000AFC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1131180, XrefRangeEnd = 1131187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int DOPlayForward(this Material target)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.NativeMethodInfoPtr_DOPlayForward_Public_Static_Int32_Material_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000159 RID: 345 RVA: 0x0000CE0C File Offset: 0x0000B00C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1131187, XrefRangeEnd = 1131194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int DORestart(this Component target, bool includeDelay = true)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref includeDelay;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.NativeMethodInfoPtr_DORestart_Public_Static_Int32_Component_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600015A RID: 346 RVA: 0x0000CE5C File Offset: 0x0000B05C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1131194, XrefRangeEnd = 1131201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int DORestart(this Material target, bool includeDelay = true)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref includeDelay;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.NativeMethodInfoPtr_DORestart_Public_Static_Int32_Material_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600015B RID: 347 RVA: 0x0000CEAC File Offset: 0x0000B0AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1131201, XrefRangeEnd = 1131208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int DORewind(this Component target, bool includeDelay = true)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref includeDelay;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.NativeMethodInfoPtr_DORewind_Public_Static_Int32_Component_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600015C RID: 348 RVA: 0x0000CEFC File Offset: 0x0000B0FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1131208, XrefRangeEnd = 1131215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int DORewind(this Material target, bool includeDelay = true)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref includeDelay;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.NativeMethodInfoPtr_DORewind_Public_Static_Int32_Material_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600015D RID: 349 RVA: 0x0000CF4C File Offset: 0x0000B14C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1131215, XrefRangeEnd = 1131222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int DOSmoothRewind(this Component target)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.NativeMethodInfoPtr_DOSmoothRewind_Public_Static_Int32_Component_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600015E RID: 350 RVA: 0x0000CF90 File Offset: 0x0000B190
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1131222, XrefRangeEnd = 1131229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int DOSmoothRewind(this Material target)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.NativeMethodInfoPtr_DOSmoothRewind_Public_Static_Int32_Material_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600015F RID: 351 RVA: 0x0000CFD4 File Offset: 0x0000B1D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1131229, XrefRangeEnd = 1131236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int DOTogglePause(this Component target)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.NativeMethodInfoPtr_DOTogglePause_Public_Static_Int32_Component_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000160 RID: 352 RVA: 0x0000D018 File Offset: 0x0000B218
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1131236, XrefRangeEnd = 1131243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int DOTogglePause(this Material target)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.NativeMethodInfoPtr_DOTogglePause_Public_Static_Int32_Material_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000161 RID: 353 RVA: 0x00002343 File Offset: 0x00000543
		public ShortcutExtensions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000106 RID: 262
		private static readonly IntPtr NativeMethodInfoPtr_DOFade_Public_Static_Tweener_AudioSource_Single_Single_0;

		// Token: 0x04000107 RID: 263
		private static readonly IntPtr NativeMethodInfoPtr_DOPitch_Public_Static_Tweener_AudioSource_Single_Single_0;

		// Token: 0x04000108 RID: 264
		private static readonly IntPtr NativeMethodInfoPtr_DOAspect_Public_Static_Tweener_Camera_Single_Single_0;

		// Token: 0x04000109 RID: 265
		private static readonly IntPtr NativeMethodInfoPtr_DOColor_Public_Static_Tweener_Camera_Color_Single_0;

		// Token: 0x0400010A RID: 266
		private static readonly IntPtr NativeMethodInfoPtr_DOFarClipPlane_Public_Static_Tweener_Camera_Single_Single_0;

		// Token: 0x0400010B RID: 267
		private static readonly IntPtr NativeMethodInfoPtr_DOFieldOfView_Public_Static_Tweener_Camera_Single_Single_0;

		// Token: 0x0400010C RID: 268
		private static readonly IntPtr NativeMethodInfoPtr_DONearClipPlane_Public_Static_Tweener_Camera_Single_Single_0;

		// Token: 0x0400010D RID: 269
		private static readonly IntPtr NativeMethodInfoPtr_DOOrthoSize_Public_Static_Tweener_Camera_Single_Single_0;

		// Token: 0x0400010E RID: 270
		private static readonly IntPtr NativeMethodInfoPtr_DOPixelRect_Public_Static_Tweener_Camera_Rect_Single_0;

		// Token: 0x0400010F RID: 271
		private static readonly IntPtr NativeMethodInfoPtr_DORect_Public_Static_Tweener_Camera_Rect_Single_0;

		// Token: 0x04000110 RID: 272
		private static readonly IntPtr NativeMethodInfoPtr_DOShakePosition_Public_Static_Tweener_Camera_Single_Single_Int32_Single_Boolean_0;

		// Token: 0x04000111 RID: 273
		private static readonly IntPtr NativeMethodInfoPtr_DOShakePosition_Public_Static_Tweener_Camera_Single_Vector3_Int32_Single_Boolean_0;

		// Token: 0x04000112 RID: 274
		private static readonly IntPtr NativeMethodInfoPtr_DOShakeRotation_Public_Static_Tweener_Camera_Single_Single_Int32_Single_Boolean_0;

		// Token: 0x04000113 RID: 275
		private static readonly IntPtr NativeMethodInfoPtr_DOShakeRotation_Public_Static_Tweener_Camera_Single_Vector3_Int32_Single_Boolean_0;

		// Token: 0x04000114 RID: 276
		private static readonly IntPtr NativeMethodInfoPtr_DOColor_Public_Static_Tweener_Light_Color_Single_0;

		// Token: 0x04000115 RID: 277
		private static readonly IntPtr NativeMethodInfoPtr_DOIntensity_Public_Static_Tweener_Light_Single_Single_0;

		// Token: 0x04000116 RID: 278
		private static readonly IntPtr NativeMethodInfoPtr_DOShadowStrength_Public_Static_Tweener_Light_Single_Single_0;

		// Token: 0x04000117 RID: 279
		private static readonly IntPtr NativeMethodInfoPtr_DOColor_Public_Static_Tweener_LineRenderer_Color2_Color2_Single_0;

		// Token: 0x04000118 RID: 280
		private static readonly IntPtr NativeMethodInfoPtr_DOColor_Public_Static_Tweener_Material_Color_Single_0;

		// Token: 0x04000119 RID: 281
		private static readonly IntPtr NativeMethodInfoPtr_DOColor_Public_Static_Tweener_Material_Color_String_Single_0;

		// Token: 0x0400011A RID: 282
		private static readonly IntPtr NativeMethodInfoPtr_DOFade_Public_Static_Tweener_Material_Single_Single_0;

		// Token: 0x0400011B RID: 283
		private static readonly IntPtr NativeMethodInfoPtr_DOFade_Public_Static_Tweener_Material_Single_String_Single_0;

		// Token: 0x0400011C RID: 284
		private static readonly IntPtr NativeMethodInfoPtr_DOFloat_Public_Static_Tweener_Material_Single_String_Single_0;

		// Token: 0x0400011D RID: 285
		private static readonly IntPtr NativeMethodInfoPtr_DOOffset_Public_Static_Tweener_Material_Vector2_Single_0;

		// Token: 0x0400011E RID: 286
		private static readonly IntPtr NativeMethodInfoPtr_DOOffset_Public_Static_Tweener_Material_Vector2_String_Single_0;

		// Token: 0x0400011F RID: 287
		private static readonly IntPtr NativeMethodInfoPtr_DOTiling_Public_Static_Tweener_Material_Vector2_Single_0;

		// Token: 0x04000120 RID: 288
		private static readonly IntPtr NativeMethodInfoPtr_DOTiling_Public_Static_Tweener_Material_Vector2_String_Single_0;

		// Token: 0x04000121 RID: 289
		private static readonly IntPtr NativeMethodInfoPtr_DOVector_Public_Static_Tweener_Material_Vector4_String_Single_0;

		// Token: 0x04000122 RID: 290
		private static readonly IntPtr NativeMethodInfoPtr_DOMove_Public_Static_Tweener_Rigidbody_Vector3_Single_Boolean_0;

		// Token: 0x04000123 RID: 291
		private static readonly IntPtr NativeMethodInfoPtr_DOMoveX_Public_Static_Tweener_Rigidbody_Single_Single_Boolean_0;

		// Token: 0x04000124 RID: 292
		private static readonly IntPtr NativeMethodInfoPtr_DOMoveY_Public_Static_Tweener_Rigidbody_Single_Single_Boolean_0;

		// Token: 0x04000125 RID: 293
		private static readonly IntPtr NativeMethodInfoPtr_DOMoveZ_Public_Static_Tweener_Rigidbody_Single_Single_Boolean_0;

		// Token: 0x04000126 RID: 294
		private static readonly IntPtr NativeMethodInfoPtr_DORotate_Public_Static_Tweener_Rigidbody_Vector3_Single_RotateMode_0;

		// Token: 0x04000127 RID: 295
		private static readonly IntPtr NativeMethodInfoPtr_DOLookAt_Public_Static_Tweener_Rigidbody_Vector3_Single_AxisConstraint_Nullable_1_Vector3_0;

		// Token: 0x04000128 RID: 296
		private static readonly IntPtr NativeMethodInfoPtr_DOJump_Public_Static_Sequence_Rigidbody_Vector3_Single_Int32_Single_Boolean_0;

		// Token: 0x04000129 RID: 297
		private static readonly IntPtr NativeMethodInfoPtr_DOPath_Public_Static_TweenerCore_3_Vector3_Path_PathOptions_Rigidbody_Il2CppStructArray_1_Vector3_Single_PathType_PathMode_Int32_Nullable_1_Color_0;

		// Token: 0x0400012A RID: 298
		private static readonly IntPtr NativeMethodInfoPtr_DOLocalPath_Public_Static_TweenerCore_3_Vector3_Path_PathOptions_Rigidbody_Il2CppStructArray_1_Vector3_Single_PathType_PathMode_Int32_Nullable_1_Color_0;

		// Token: 0x0400012B RID: 299
		private static readonly IntPtr NativeMethodInfoPtr_DOPath_Internal_Static_TweenerCore_3_Vector3_Path_PathOptions_Rigidbody_Path_Single_PathMode_0;

		// Token: 0x0400012C RID: 300
		private static readonly IntPtr NativeMethodInfoPtr_DOLocalPath_Internal_Static_TweenerCore_3_Vector3_Path_PathOptions_Rigidbody_Path_Single_PathMode_0;

		// Token: 0x0400012D RID: 301
		private static readonly IntPtr NativeMethodInfoPtr_DOResize_Public_Static_Tweener_TrailRenderer_Single_Single_Single_0;

		// Token: 0x0400012E RID: 302
		private static readonly IntPtr NativeMethodInfoPtr_DOTime_Public_Static_Tweener_TrailRenderer_Single_Single_0;

		// Token: 0x0400012F RID: 303
		private static readonly IntPtr NativeMethodInfoPtr_DOMove_Public_Static_Tweener_Transform_Vector3_Single_Boolean_0;

		// Token: 0x04000130 RID: 304
		private static readonly IntPtr NativeMethodInfoPtr_DOMoveX_Public_Static_Tweener_Transform_Single_Single_Boolean_0;

		// Token: 0x04000131 RID: 305
		private static readonly IntPtr NativeMethodInfoPtr_DOMoveY_Public_Static_Tweener_Transform_Single_Single_Boolean_0;

		// Token: 0x04000132 RID: 306
		private static readonly IntPtr NativeMethodInfoPtr_DOMoveZ_Public_Static_Tweener_Transform_Single_Single_Boolean_0;

		// Token: 0x04000133 RID: 307
		private static readonly IntPtr NativeMethodInfoPtr_DOLocalMove_Public_Static_Tweener_Transform_Vector3_Single_Boolean_0;

		// Token: 0x04000134 RID: 308
		private static readonly IntPtr NativeMethodInfoPtr_DOLocalMoveX_Public_Static_Tweener_Transform_Single_Single_Boolean_0;

		// Token: 0x04000135 RID: 309
		private static readonly IntPtr NativeMethodInfoPtr_DOLocalMoveY_Public_Static_Tweener_Transform_Single_Single_Boolean_0;

		// Token: 0x04000136 RID: 310
		private static readonly IntPtr NativeMethodInfoPtr_DOLocalMoveZ_Public_Static_Tweener_Transform_Single_Single_Boolean_0;

		// Token: 0x04000137 RID: 311
		private static readonly IntPtr NativeMethodInfoPtr_DORotate_Public_Static_Tweener_Transform_Vector3_Single_RotateMode_0;

		// Token: 0x04000138 RID: 312
		private static readonly IntPtr NativeMethodInfoPtr_DORotateQuaternion_Public_Static_Tweener_Transform_Quaternion_Single_0;

		// Token: 0x04000139 RID: 313
		private static readonly IntPtr NativeMethodInfoPtr_DOLocalRotate_Public_Static_Tweener_Transform_Vector3_Single_RotateMode_0;

		// Token: 0x0400013A RID: 314
		private static readonly IntPtr NativeMethodInfoPtr_DOLocalRotateQuaternion_Public_Static_Tweener_Transform_Quaternion_Single_0;

		// Token: 0x0400013B RID: 315
		private static readonly IntPtr NativeMethodInfoPtr_DOScale_Public_Static_Tweener_Transform_Vector3_Single_0;

		// Token: 0x0400013C RID: 316
		private static readonly IntPtr NativeMethodInfoPtr_DOScale_Public_Static_Tweener_Transform_Single_Single_0;

		// Token: 0x0400013D RID: 317
		private static readonly IntPtr NativeMethodInfoPtr_DOScaleX_Public_Static_Tweener_Transform_Single_Single_0;

		// Token: 0x0400013E RID: 318
		private static readonly IntPtr NativeMethodInfoPtr_DOScaleY_Public_Static_Tweener_Transform_Single_Single_0;

		// Token: 0x0400013F RID: 319
		private static readonly IntPtr NativeMethodInfoPtr_DOScaleZ_Public_Static_Tweener_Transform_Single_Single_0;

		// Token: 0x04000140 RID: 320
		private static readonly IntPtr NativeMethodInfoPtr_DOLookAt_Public_Static_Tweener_Transform_Vector3_Single_AxisConstraint_Nullable_1_Vector3_0;

		// Token: 0x04000141 RID: 321
		private static readonly IntPtr NativeMethodInfoPtr_DOPunchPosition_Public_Static_Tweener_Transform_Vector3_Single_Int32_Single_Boolean_0;

		// Token: 0x04000142 RID: 322
		private static readonly IntPtr NativeMethodInfoPtr_DOPunchScale_Public_Static_Tweener_Transform_Vector3_Single_Int32_Single_0;

		// Token: 0x04000143 RID: 323
		private static readonly IntPtr NativeMethodInfoPtr_DOPunchRotation_Public_Static_Tweener_Transform_Vector3_Single_Int32_Single_0;

		// Token: 0x04000144 RID: 324
		private static readonly IntPtr NativeMethodInfoPtr_DOShakePosition_Public_Static_Tweener_Transform_Single_Single_Int32_Single_Boolean_Boolean_0;

		// Token: 0x04000145 RID: 325
		private static readonly IntPtr NativeMethodInfoPtr_DOShakePosition_Public_Static_Tweener_Transform_Single_Vector3_Int32_Single_Boolean_Boolean_0;

		// Token: 0x04000146 RID: 326
		private static readonly IntPtr NativeMethodInfoPtr_DOShakeRotation_Public_Static_Tweener_Transform_Single_Single_Int32_Single_Boolean_0;

		// Token: 0x04000147 RID: 327
		private static readonly IntPtr NativeMethodInfoPtr_DOShakeRotation_Public_Static_Tweener_Transform_Single_Vector3_Int32_Single_Boolean_0;

		// Token: 0x04000148 RID: 328
		private static readonly IntPtr NativeMethodInfoPtr_DOShakeScale_Public_Static_Tweener_Transform_Single_Single_Int32_Single_Boolean_0;

		// Token: 0x04000149 RID: 329
		private static readonly IntPtr NativeMethodInfoPtr_DOShakeScale_Public_Static_Tweener_Transform_Single_Vector3_Int32_Single_Boolean_0;

		// Token: 0x0400014A RID: 330
		private static readonly IntPtr NativeMethodInfoPtr_DOJump_Public_Static_Sequence_Transform_Vector3_Single_Int32_Single_Boolean_0;

		// Token: 0x0400014B RID: 331
		private static readonly IntPtr NativeMethodInfoPtr_DOLocalJump_Public_Static_Sequence_Transform_Vector3_Single_Int32_Single_Boolean_0;

		// Token: 0x0400014C RID: 332
		private static readonly IntPtr NativeMethodInfoPtr_DOPath_Public_Static_TweenerCore_3_Vector3_Path_PathOptions_Transform_Il2CppStructArray_1_Vector3_Single_PathType_PathMode_Int32_Nullable_1_Color_0;

		// Token: 0x0400014D RID: 333
		private static readonly IntPtr NativeMethodInfoPtr_DOLocalPath_Public_Static_TweenerCore_3_Vector3_Path_PathOptions_Transform_Il2CppStructArray_1_Vector3_Single_PathType_PathMode_Int32_Nullable_1_Color_0;

		// Token: 0x0400014E RID: 334
		private static readonly IntPtr NativeMethodInfoPtr_DOPath_Internal_Static_TweenerCore_3_Vector3_Path_PathOptions_Transform_Path_Single_PathMode_0;

		// Token: 0x0400014F RID: 335
		private static readonly IntPtr NativeMethodInfoPtr_DOLocalPath_Internal_Static_TweenerCore_3_Vector3_Path_PathOptions_Transform_Path_Single_PathMode_0;

		// Token: 0x04000150 RID: 336
		private static readonly IntPtr NativeMethodInfoPtr_DOTimeScale_Public_Static_Tweener_Tween_Single_Single_0;

		// Token: 0x04000151 RID: 337
		private static readonly IntPtr NativeMethodInfoPtr_DOBlendableColor_Public_Static_Tweener_Light_Color_Single_0;

		// Token: 0x04000152 RID: 338
		private static readonly IntPtr NativeMethodInfoPtr_DOBlendableColor_Public_Static_Tweener_Material_Color_Single_0;

		// Token: 0x04000153 RID: 339
		private static readonly IntPtr NativeMethodInfoPtr_DOBlendableColor_Public_Static_Tweener_Material_Color_String_Single_0;

		// Token: 0x04000154 RID: 340
		private static readonly IntPtr NativeMethodInfoPtr_DOBlendableMoveBy_Public_Static_Tweener_Transform_Vector3_Single_Boolean_0;

		// Token: 0x04000155 RID: 341
		private static readonly IntPtr NativeMethodInfoPtr_DOBlendableLocalMoveBy_Public_Static_Tweener_Transform_Vector3_Single_Boolean_0;

		// Token: 0x04000156 RID: 342
		private static readonly IntPtr NativeMethodInfoPtr_DOBlendableRotateBy_Public_Static_Tweener_Transform_Vector3_Single_RotateMode_0;

		// Token: 0x04000157 RID: 343
		private static readonly IntPtr NativeMethodInfoPtr_DOBlendableLocalRotateBy_Public_Static_Tweener_Transform_Vector3_Single_RotateMode_0;

		// Token: 0x04000158 RID: 344
		private static readonly IntPtr NativeMethodInfoPtr_DOBlendablePunchRotation_Public_Static_Tweener_Transform_Vector3_Single_Int32_Single_0;

		// Token: 0x04000159 RID: 345
		private static readonly IntPtr NativeMethodInfoPtr_DOBlendableScaleBy_Public_Static_Tweener_Transform_Vector3_Single_0;

		// Token: 0x0400015A RID: 346
		private static readonly IntPtr NativeMethodInfoPtr_DOComplete_Public_Static_Int32_Component_Boolean_0;

		// Token: 0x0400015B RID: 347
		private static readonly IntPtr NativeMethodInfoPtr_DOComplete_Public_Static_Int32_Material_Boolean_0;

		// Token: 0x0400015C RID: 348
		private static readonly IntPtr NativeMethodInfoPtr_DOKill_Public_Static_Int32_Component_Boolean_0;

		// Token: 0x0400015D RID: 349
		private static readonly IntPtr NativeMethodInfoPtr_DOKill_Public_Static_Int32_Material_Boolean_0;

		// Token: 0x0400015E RID: 350
		private static readonly IntPtr NativeMethodInfoPtr_DOFlip_Public_Static_Int32_Component_0;

		// Token: 0x0400015F RID: 351
		private static readonly IntPtr NativeMethodInfoPtr_DOFlip_Public_Static_Int32_Material_0;

		// Token: 0x04000160 RID: 352
		private static readonly IntPtr NativeMethodInfoPtr_DOGoto_Public_Static_Int32_Component_Single_Boolean_0;

		// Token: 0x04000161 RID: 353
		private static readonly IntPtr NativeMethodInfoPtr_DOGoto_Public_Static_Int32_Material_Single_Boolean_0;

		// Token: 0x04000162 RID: 354
		private static readonly IntPtr NativeMethodInfoPtr_DOPause_Public_Static_Int32_Component_0;

		// Token: 0x04000163 RID: 355
		private static readonly IntPtr NativeMethodInfoPtr_DOPause_Public_Static_Int32_Material_0;

		// Token: 0x04000164 RID: 356
		private static readonly IntPtr NativeMethodInfoPtr_DOPlay_Public_Static_Int32_Component_0;

		// Token: 0x04000165 RID: 357
		private static readonly IntPtr NativeMethodInfoPtr_DOPlay_Public_Static_Int32_Material_0;

		// Token: 0x04000166 RID: 358
		private static readonly IntPtr NativeMethodInfoPtr_DOPlayBackwards_Public_Static_Int32_Component_0;

		// Token: 0x04000167 RID: 359
		private static readonly IntPtr NativeMethodInfoPtr_DOPlayBackwards_Public_Static_Int32_Material_0;

		// Token: 0x04000168 RID: 360
		private static readonly IntPtr NativeMethodInfoPtr_DOPlayForward_Public_Static_Int32_Component_0;

		// Token: 0x04000169 RID: 361
		private static readonly IntPtr NativeMethodInfoPtr_DOPlayForward_Public_Static_Int32_Material_0;

		// Token: 0x0400016A RID: 362
		private static readonly IntPtr NativeMethodInfoPtr_DORestart_Public_Static_Int32_Component_Boolean_0;

		// Token: 0x0400016B RID: 363
		private static readonly IntPtr NativeMethodInfoPtr_DORestart_Public_Static_Int32_Material_Boolean_0;

		// Token: 0x0400016C RID: 364
		private static readonly IntPtr NativeMethodInfoPtr_DORewind_Public_Static_Int32_Component_Boolean_0;

		// Token: 0x0400016D RID: 365
		private static readonly IntPtr NativeMethodInfoPtr_DORewind_Public_Static_Int32_Material_Boolean_0;

		// Token: 0x0400016E RID: 366
		private static readonly IntPtr NativeMethodInfoPtr_DOSmoothRewind_Public_Static_Int32_Component_0;

		// Token: 0x0400016F RID: 367
		private static readonly IntPtr NativeMethodInfoPtr_DOSmoothRewind_Public_Static_Int32_Material_0;

		// Token: 0x04000170 RID: 368
		private static readonly IntPtr NativeMethodInfoPtr_DOTogglePause_Public_Static_Int32_Component_0;

		// Token: 0x04000171 RID: 369
		private static readonly IntPtr NativeMethodInfoPtr_DOTogglePause_Public_Static_Int32_Material_0;

		// Token: 0x02000063 RID: 99
		[ObfuscatedName("DG.Tweening.ShortcutExtensions+<>c__DisplayClass0_0")]
		public sealed class __c__DisplayClass0_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06000576 RID: 1398 RVA: 0x0001DD24 File Offset: 0x0001BF24
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass0_0()
			{
				Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass0_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, "<>c__DisplayClass0_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass0_0>.NativeClassPtr);
				ShortcutExtensions.__c__DisplayClass0_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass0_0>.NativeClassPtr, "target");
				ShortcutExtensions.__c__DisplayClass0_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass0_0>.NativeClassPtr, 100663569);
				ShortcutExtensions.__c__DisplayClass0_0.NativeMethodInfoPtr__DOFade_b__0_Internal_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass0_0>.NativeClassPtr, 100663570);
				ShortcutExtensions.__c__DisplayClass0_0.NativeMethodInfoPtr__DOFade_b__1_Internal_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass0_0>.NativeClassPtr, 100663571);
			}

			// Token: 0x06000577 RID: 1399 RVA: 0x0001DDA0 File Offset: 0x0001BFA0
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass0_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass0_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass0_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000578 RID: 1400 RVA: 0x0001DDDC File Offset: 0x0001BFDC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1128225, XrefRangeEnd = 1128227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _DOFade_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass0_0.NativeMethodInfoPtr__DOFade_b__0_Internal_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000579 RID: 1401 RVA: 0x0001DE18 File Offset: 0x0001C018
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1128227, XrefRangeEnd = 1128229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DOFade_b__1(float x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass0_0.NativeMethodInfoPtr__DOFade_b__1_Internal_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600057A RID: 1402 RVA: 0x00003CAB File Offset: 0x00001EAB
			public __c__DisplayClass0_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000107 RID: 263
			// (get) Token: 0x0600057B RID: 1403 RVA: 0x0001DE58 File Offset: 0x0001C058
			// (set) Token: 0x0600057C RID: 1404 RVA: 0x00003CB4 File Offset: 0x00001EB4
			public unsafe AudioSource target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass0_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSource>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass0_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000464 RID: 1124
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x04000465 RID: 1125
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000466 RID: 1126
			private static readonly IntPtr NativeMethodInfoPtr__DOFade_b__0_Internal_Single_0;

			// Token: 0x04000467 RID: 1127
			private static readonly IntPtr NativeMethodInfoPtr__DOFade_b__1_Internal_Void_Single_0;
		}

		// Token: 0x02000064 RID: 100
		[ObfuscatedName("DG.Tweening.ShortcutExtensions+<>c__DisplayClass1_0")]
		public sealed class __c__DisplayClass1_0 : global::Il2CppSystem.Object
		{
			// Token: 0x0600057D RID: 1405 RVA: 0x0001DE88 File Offset: 0x0001C088
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass1_0()
			{
				Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass1_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, "<>c__DisplayClass1_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass1_0>.NativeClassPtr);
				ShortcutExtensions.__c__DisplayClass1_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass1_0>.NativeClassPtr, "target");
				ShortcutExtensions.__c__DisplayClass1_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass1_0>.NativeClassPtr, 100663572);
				ShortcutExtensions.__c__DisplayClass1_0.NativeMethodInfoPtr__DOPitch_b__0_Internal_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass1_0>.NativeClassPtr, 100663573);
				ShortcutExtensions.__c__DisplayClass1_0.NativeMethodInfoPtr__DOPitch_b__1_Internal_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass1_0>.NativeClassPtr, 100663574);
			}

			// Token: 0x0600057E RID: 1406 RVA: 0x0001DF04 File Offset: 0x0001C104
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass1_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass1_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass1_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600057F RID: 1407 RVA: 0x0001DF40 File Offset: 0x0001C140
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1128229, XrefRangeEnd = 1128231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _DOPitch_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass1_0.NativeMethodInfoPtr__DOPitch_b__0_Internal_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000580 RID: 1408 RVA: 0x0001DF7C File Offset: 0x0001C17C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1128231, XrefRangeEnd = 1128233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DOPitch_b__1(float x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass1_0.NativeMethodInfoPtr__DOPitch_b__1_Internal_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000581 RID: 1409 RVA: 0x00003CD3 File Offset: 0x00001ED3
			public __c__DisplayClass1_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000108 RID: 264
			// (get) Token: 0x06000582 RID: 1410 RVA: 0x0001DFBC File Offset: 0x0001C1BC
			// (set) Token: 0x06000583 RID: 1411 RVA: 0x00003CDC File Offset: 0x00001EDC
			public unsafe AudioSource target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass1_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSource>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass1_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000468 RID: 1128
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x04000469 RID: 1129
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400046A RID: 1130
			private static readonly IntPtr NativeMethodInfoPtr__DOPitch_b__0_Internal_Single_0;

			// Token: 0x0400046B RID: 1131
			private static readonly IntPtr NativeMethodInfoPtr__DOPitch_b__1_Internal_Void_Single_0;
		}

		// Token: 0x02000065 RID: 101
		[ObfuscatedName("DG.Tweening.ShortcutExtensions+<>c__DisplayClass2_0")]
		public sealed class __c__DisplayClass2_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06000584 RID: 1412 RVA: 0x0001DFEC File Offset: 0x0001C1EC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass2_0()
			{
				Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass2_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, "<>c__DisplayClass2_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass2_0>.NativeClassPtr);
				ShortcutExtensions.__c__DisplayClass2_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass2_0>.NativeClassPtr, "target");
				ShortcutExtensions.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass2_0>.NativeClassPtr, 100663575);
				ShortcutExtensions.__c__DisplayClass2_0.NativeMethodInfoPtr__DOAspect_b__0_Internal_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass2_0>.NativeClassPtr, 100663576);
				ShortcutExtensions.__c__DisplayClass2_0.NativeMethodInfoPtr__DOAspect_b__1_Internal_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass2_0>.NativeClassPtr, 100663577);
			}

			// Token: 0x06000585 RID: 1413 RVA: 0x0001E068 File Offset: 0x0001C268
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass2_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass2_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000586 RID: 1414 RVA: 0x0001E0A4 File Offset: 0x0001C2A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1128233, XrefRangeEnd = 1128235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _DOAspect_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass2_0.NativeMethodInfoPtr__DOAspect_b__0_Internal_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000587 RID: 1415 RVA: 0x0001E0E0 File Offset: 0x0001C2E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1128235, XrefRangeEnd = 1128237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DOAspect_b__1(float x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass2_0.NativeMethodInfoPtr__DOAspect_b__1_Internal_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000588 RID: 1416 RVA: 0x00003CFB File Offset: 0x00001EFB
			public __c__DisplayClass2_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000109 RID: 265
			// (get) Token: 0x06000589 RID: 1417 RVA: 0x0001E120 File Offset: 0x0001C320
			// (set) Token: 0x0600058A RID: 1418 RVA: 0x00003D04 File Offset: 0x00001F04
			public unsafe Camera target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass2_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass2_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400046C RID: 1132
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x0400046D RID: 1133
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400046E RID: 1134
			private static readonly IntPtr NativeMethodInfoPtr__DOAspect_b__0_Internal_Single_0;

			// Token: 0x0400046F RID: 1135
			private static readonly IntPtr NativeMethodInfoPtr__DOAspect_b__1_Internal_Void_Single_0;
		}

		// Token: 0x02000066 RID: 102
		[ObfuscatedName("DG.Tweening.ShortcutExtensions+<>c__DisplayClass3_0")]
		public sealed class __c__DisplayClass3_0 : global::Il2CppSystem.Object
		{
			// Token: 0x0600058B RID: 1419 RVA: 0x0001E150 File Offset: 0x0001C350
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass3_0()
			{
				Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass3_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, "<>c__DisplayClass3_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass3_0>.NativeClassPtr);
				ShortcutExtensions.__c__DisplayClass3_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass3_0>.NativeClassPtr, "target");
				ShortcutExtensions.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass3_0>.NativeClassPtr, 100663578);
				ShortcutExtensions.__c__DisplayClass3_0.NativeMethodInfoPtr__DOColor_b__0_Internal_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass3_0>.NativeClassPtr, 100663579);
				ShortcutExtensions.__c__DisplayClass3_0.NativeMethodInfoPtr__DOColor_b__1_Internal_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass3_0>.NativeClassPtr, 100663580);
			}

			// Token: 0x0600058C RID: 1420 RVA: 0x0001E1CC File Offset: 0x0001C3CC
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass3_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass3_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600058D RID: 1421 RVA: 0x0001E208 File Offset: 0x0001C408
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1128237, XrefRangeEnd = 1128238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Color _DOColor_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass3_0.NativeMethodInfoPtr__DOColor_b__0_Internal_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600058E RID: 1422 RVA: 0x0001E244 File Offset: 0x0001C444
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1128238, XrefRangeEnd = 1128239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DOColor_b__1(Color x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass3_0.NativeMethodInfoPtr__DOColor_b__1_Internal_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600058F RID: 1423 RVA: 0x00003D23 File Offset: 0x00001F23
			public __c__DisplayClass3_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700010A RID: 266
			// (get) Token: 0x06000590 RID: 1424 RVA: 0x0001E284 File Offset: 0x0001C484
			// (set) Token: 0x06000591 RID: 1425 RVA: 0x00003D2C File Offset: 0x00001F2C
			public unsafe Camera target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass3_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass3_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000470 RID: 1136
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x04000471 RID: 1137
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000472 RID: 1138
			private static readonly IntPtr NativeMethodInfoPtr__DOColor_b__0_Internal_Color_0;

			// Token: 0x04000473 RID: 1139
			private static readonly IntPtr NativeMethodInfoPtr__DOColor_b__1_Internal_Void_Color_0;
		}

		// Token: 0x02000067 RID: 103
		[ObfuscatedName("DG.Tweening.ShortcutExtensions+<>c__DisplayClass4_0")]
		public sealed class __c__DisplayClass4_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06000592 RID: 1426 RVA: 0x0001E2B4 File Offset: 0x0001C4B4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass4_0()
			{
				Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass4_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, "<>c__DisplayClass4_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass4_0>.NativeClassPtr);
				ShortcutExtensions.__c__DisplayClass4_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass4_0>.NativeClassPtr, "target");
				ShortcutExtensions.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass4_0>.NativeClassPtr, 100663581);
				ShortcutExtensions.__c__DisplayClass4_0.NativeMethodInfoPtr__DOFarClipPlane_b__0_Internal_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass4_0>.NativeClassPtr, 100663582);
				ShortcutExtensions.__c__DisplayClass4_0.NativeMethodInfoPtr__DOFarClipPlane_b__1_Internal_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass4_0>.NativeClassPtr, 100663583);
			}

			// Token: 0x06000593 RID: 1427 RVA: 0x0001E330 File Offset: 0x0001C530
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass4_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass4_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000594 RID: 1428 RVA: 0x0001E36C File Offset: 0x0001C56C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1128239, XrefRangeEnd = 1128241, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _DOFarClipPlane_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass4_0.NativeMethodInfoPtr__DOFarClipPlane_b__0_Internal_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000595 RID: 1429 RVA: 0x0001E3A8 File Offset: 0x0001C5A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1128241, XrefRangeEnd = 1128243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DOFarClipPlane_b__1(float x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass4_0.NativeMethodInfoPtr__DOFarClipPlane_b__1_Internal_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000596 RID: 1430 RVA: 0x00003D4B File Offset: 0x00001F4B
			public __c__DisplayClass4_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700010B RID: 267
			// (get) Token: 0x06000597 RID: 1431 RVA: 0x0001E3E8 File Offset: 0x0001C5E8
			// (set) Token: 0x06000598 RID: 1432 RVA: 0x00003D54 File Offset: 0x00001F54
			public unsafe Camera target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass4_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass4_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000474 RID: 1140
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x04000475 RID: 1141
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000476 RID: 1142
			private static readonly IntPtr NativeMethodInfoPtr__DOFarClipPlane_b__0_Internal_Single_0;

			// Token: 0x04000477 RID: 1143
			private static readonly IntPtr NativeMethodInfoPtr__DOFarClipPlane_b__1_Internal_Void_Single_0;
		}

		// Token: 0x02000068 RID: 104
		[ObfuscatedName("DG.Tweening.ShortcutExtensions+<>c__DisplayClass5_0")]
		public sealed class __c__DisplayClass5_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06000599 RID: 1433 RVA: 0x0001E418 File Offset: 0x0001C618
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass5_0()
			{
				Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass5_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, "<>c__DisplayClass5_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass5_0>.NativeClassPtr);
				ShortcutExtensions.__c__DisplayClass5_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass5_0>.NativeClassPtr, "target");
				ShortcutExtensions.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass5_0>.NativeClassPtr, 100663584);
				ShortcutExtensions.__c__DisplayClass5_0.NativeMethodInfoPtr__DOFieldOfView_b__0_Internal_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass5_0>.NativeClassPtr, 100663585);
				ShortcutExtensions.__c__DisplayClass5_0.NativeMethodInfoPtr__DOFieldOfView_b__1_Internal_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass5_0>.NativeClassPtr, 100663586);
			}

			// Token: 0x0600059A RID: 1434 RVA: 0x0001E494 File Offset: 0x0001C694
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass5_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass5_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600059B RID: 1435 RVA: 0x0001E4D0 File Offset: 0x0001C6D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1128243, XrefRangeEnd = 1128245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _DOFieldOfView_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass5_0.NativeMethodInfoPtr__DOFieldOfView_b__0_Internal_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600059C RID: 1436 RVA: 0x0001E50C File Offset: 0x0001C70C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1128245, XrefRangeEnd = 1128247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DOFieldOfView_b__1(float x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass5_0.NativeMethodInfoPtr__DOFieldOfView_b__1_Internal_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600059D RID: 1437 RVA: 0x00003D73 File Offset: 0x00001F73
			public __c__DisplayClass5_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700010C RID: 268
			// (get) Token: 0x0600059E RID: 1438 RVA: 0x0001E54C File Offset: 0x0001C74C
			// (set) Token: 0x0600059F RID: 1439 RVA: 0x00003D7C File Offset: 0x00001F7C
			public unsafe Camera target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass5_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass5_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000478 RID: 1144
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x04000479 RID: 1145
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400047A RID: 1146
			private static readonly IntPtr NativeMethodInfoPtr__DOFieldOfView_b__0_Internal_Single_0;

			// Token: 0x0400047B RID: 1147
			private static readonly IntPtr NativeMethodInfoPtr__DOFieldOfView_b__1_Internal_Void_Single_0;
		}

		// Token: 0x02000069 RID: 105
		[ObfuscatedName("DG.Tweening.ShortcutExtensions+<>c__DisplayClass6_0")]
		public sealed class __c__DisplayClass6_0 : global::Il2CppSystem.Object
		{
			// Token: 0x060005A0 RID: 1440 RVA: 0x0001E57C File Offset: 0x0001C77C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass6_0()
			{
				Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass6_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, "<>c__DisplayClass6_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass6_0>.NativeClassPtr);
				ShortcutExtensions.__c__DisplayClass6_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass6_0>.NativeClassPtr, "target");
				ShortcutExtensions.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass6_0>.NativeClassPtr, 100663587);
				ShortcutExtensions.__c__DisplayClass6_0.NativeMethodInfoPtr__DONearClipPlane_b__0_Internal_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass6_0>.NativeClassPtr, 100663588);
				ShortcutExtensions.__c__DisplayClass6_0.NativeMethodInfoPtr__DONearClipPlane_b__1_Internal_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass6_0>.NativeClassPtr, 100663589);
			}

			// Token: 0x060005A1 RID: 1441 RVA: 0x0001E5F8 File Offset: 0x0001C7F8
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass6_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass6_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060005A2 RID: 1442 RVA: 0x0001E634 File Offset: 0x0001C834
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1128247, XrefRangeEnd = 1128249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _DONearClipPlane_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass6_0.NativeMethodInfoPtr__DONearClipPlane_b__0_Internal_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060005A3 RID: 1443 RVA: 0x0001E670 File Offset: 0x0001C870
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1128249, XrefRangeEnd = 1128251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DONearClipPlane_b__1(float x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass6_0.NativeMethodInfoPtr__DONearClipPlane_b__1_Internal_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060005A4 RID: 1444 RVA: 0x00003D9B File Offset: 0x00001F9B
			public __c__DisplayClass6_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700010D RID: 269
			// (get) Token: 0x060005A5 RID: 1445 RVA: 0x0001E6B0 File Offset: 0x0001C8B0
			// (set) Token: 0x060005A6 RID: 1446 RVA: 0x00003DA4 File Offset: 0x00001FA4
			public unsafe Camera target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass6_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass6_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400047C RID: 1148
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x0400047D RID: 1149
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400047E RID: 1150
			private static readonly IntPtr NativeMethodInfoPtr__DONearClipPlane_b__0_Internal_Single_0;

			// Token: 0x0400047F RID: 1151
			private static readonly IntPtr NativeMethodInfoPtr__DONearClipPlane_b__1_Internal_Void_Single_0;
		}

		// Token: 0x0200006A RID: 106
		[ObfuscatedName("DG.Tweening.ShortcutExtensions+<>c__DisplayClass7_0")]
		public sealed class __c__DisplayClass7_0 : global::Il2CppSystem.Object
		{
			// Token: 0x060005A7 RID: 1447 RVA: 0x0001E6E0 File Offset: 0x0001C8E0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass7_0()
			{
				Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass7_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, "<>c__DisplayClass7_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass7_0>.NativeClassPtr);
				ShortcutExtensions.__c__DisplayClass7_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass7_0>.NativeClassPtr, "target");
				ShortcutExtensions.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass7_0>.NativeClassPtr, 100663590);
				ShortcutExtensions.__c__DisplayClass7_0.NativeMethodInfoPtr__DOOrthoSize_b__0_Internal_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass7_0>.NativeClassPtr, 100663591);
				ShortcutExtensions.__c__DisplayClass7_0.NativeMethodInfoPtr__DOOrthoSize_b__1_Internal_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass7_0>.NativeClassPtr, 100663592);
			}

			// Token: 0x060005A8 RID: 1448 RVA: 0x0001E75C File Offset: 0x0001C95C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass7_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass7_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060005A9 RID: 1449 RVA: 0x0001E798 File Offset: 0x0001C998
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1128251, XrefRangeEnd = 1128253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _DOOrthoSize_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass7_0.NativeMethodInfoPtr__DOOrthoSize_b__0_Internal_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060005AA RID: 1450 RVA: 0x0001E7D4 File Offset: 0x0001C9D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1128253, XrefRangeEnd = 1128255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DOOrthoSize_b__1(float x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass7_0.NativeMethodInfoPtr__DOOrthoSize_b__1_Internal_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060005AB RID: 1451 RVA: 0x00003DC3 File Offset: 0x00001FC3
			public __c__DisplayClass7_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700010E RID: 270
			// (get) Token: 0x060005AC RID: 1452 RVA: 0x0001E814 File Offset: 0x0001CA14
			// (set) Token: 0x060005AD RID: 1453 RVA: 0x00003DCC File Offset: 0x00001FCC
			public unsafe Camera target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass7_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass7_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000480 RID: 1152
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x04000481 RID: 1153
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000482 RID: 1154
			private static readonly IntPtr NativeMethodInfoPtr__DOOrthoSize_b__0_Internal_Single_0;

			// Token: 0x04000483 RID: 1155
			private static readonly IntPtr NativeMethodInfoPtr__DOOrthoSize_b__1_Internal_Void_Single_0;
		}

		// Token: 0x0200006B RID: 107
		[ObfuscatedName("DG.Tweening.ShortcutExtensions+<>c__DisplayClass8_0")]
		public sealed class __c__DisplayClass8_0 : global::Il2CppSystem.Object
		{
			// Token: 0x060005AE RID: 1454 RVA: 0x0001E844 File Offset: 0x0001CA44
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass8_0()
			{
				Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass8_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, "<>c__DisplayClass8_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass8_0>.NativeClassPtr);
				ShortcutExtensions.__c__DisplayClass8_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass8_0>.NativeClassPtr, "target");
				ShortcutExtensions.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass8_0>.NativeClassPtr, 100663593);
				ShortcutExtensions.__c__DisplayClass8_0.NativeMethodInfoPtr__DOPixelRect_b__0_Internal_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass8_0>.NativeClassPtr, 100663594);
				ShortcutExtensions.__c__DisplayClass8_0.NativeMethodInfoPtr__DOPixelRect_b__1_Internal_Void_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass8_0>.NativeClassPtr, 100663595);
			}

			// Token: 0x060005AF RID: 1455 RVA: 0x0001E8C0 File Offset: 0x0001CAC0
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass8_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass8_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060005B0 RID: 1456 RVA: 0x0001E8FC File Offset: 0x0001CAFC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1128255, XrefRangeEnd = 1128256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Rect _DOPixelRect_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass8_0.NativeMethodInfoPtr__DOPixelRect_b__0_Internal_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060005B1 RID: 1457 RVA: 0x0001E938 File Offset: 0x0001CB38
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1128256, XrefRangeEnd = 1128257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DOPixelRect_b__1(Rect x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass8_0.NativeMethodInfoPtr__DOPixelRect_b__1_Internal_Void_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060005B2 RID: 1458 RVA: 0x00003DEB File Offset: 0x00001FEB
			public __c__DisplayClass8_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700010F RID: 271
			// (get) Token: 0x060005B3 RID: 1459 RVA: 0x0001E978 File Offset: 0x0001CB78
			// (set) Token: 0x060005B4 RID: 1460 RVA: 0x00003DF4 File Offset: 0x00001FF4
			public unsafe Camera target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass8_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass8_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000484 RID: 1156
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x04000485 RID: 1157
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000486 RID: 1158
			private static readonly IntPtr NativeMethodInfoPtr__DOPixelRect_b__0_Internal_Rect_0;

			// Token: 0x04000487 RID: 1159
			private static readonly IntPtr NativeMethodInfoPtr__DOPixelRect_b__1_Internal_Void_Rect_0;
		}

		// Token: 0x0200006C RID: 108
		[ObfuscatedName("DG.Tweening.ShortcutExtensions+<>c__DisplayClass9_0")]
		public sealed class __c__DisplayClass9_0 : global::Il2CppSystem.Object
		{
			// Token: 0x060005B5 RID: 1461 RVA: 0x0001E9A8 File Offset: 0x0001CBA8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass9_0()
			{
				Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass9_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, "<>c__DisplayClass9_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass9_0>.NativeClassPtr);
				ShortcutExtensions.__c__DisplayClass9_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass9_0>.NativeClassPtr, "target");
				ShortcutExtensions.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass9_0>.NativeClassPtr, 100663596);
				ShortcutExtensions.__c__DisplayClass9_0.NativeMethodInfoPtr__DORect_b__0_Internal_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass9_0>.NativeClassPtr, 100663597);
				ShortcutExtensions.__c__DisplayClass9_0.NativeMethodInfoPtr__DORect_b__1_Internal_Void_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass9_0>.NativeClassPtr, 100663598);
			}

			// Token: 0x060005B6 RID: 1462 RVA: 0x0001EA24 File Offset: 0x0001CC24
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass9_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass9_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060005B7 RID: 1463 RVA: 0x0001EA60 File Offset: 0x0001CC60
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1128257, XrefRangeEnd = 1128258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Rect _DORect_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass9_0.NativeMethodInfoPtr__DORect_b__0_Internal_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060005B8 RID: 1464 RVA: 0x0001EA9C File Offset: 0x0001CC9C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1128258, XrefRangeEnd = 1128259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DORect_b__1(Rect x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass9_0.NativeMethodInfoPtr__DORect_b__1_Internal_Void_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060005B9 RID: 1465 RVA: 0x00003E13 File Offset: 0x00002013
			public __c__DisplayClass9_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000110 RID: 272
			// (get) Token: 0x060005BA RID: 1466 RVA: 0x0001EADC File Offset: 0x0001CCDC
			// (set) Token: 0x060005BB RID: 1467 RVA: 0x00003E1C File Offset: 0x0000201C
			public unsafe Camera target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass9_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass9_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000488 RID: 1160
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x04000489 RID: 1161
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400048A RID: 1162
			private static readonly IntPtr NativeMethodInfoPtr__DORect_b__0_Internal_Rect_0;

			// Token: 0x0400048B RID: 1163
			private static readonly IntPtr NativeMethodInfoPtr__DORect_b__1_Internal_Void_Rect_0;
		}

		// Token: 0x0200006D RID: 109
		[ObfuscatedName("DG.Tweening.ShortcutExtensions+<>c__DisplayClass10_0")]
		public sealed class __c__DisplayClass10_0 : global::Il2CppSystem.Object
		{
			// Token: 0x060005BC RID: 1468 RVA: 0x0001EB0C File Offset: 0x0001CD0C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass10_0()
			{
				Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass10_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, "<>c__DisplayClass10_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass10_0>.NativeClassPtr);
				ShortcutExtensions.__c__DisplayClass10_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass10_0>.NativeClassPtr, "target");
				ShortcutExtensions.__c__DisplayClass10_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass10_0>.NativeClassPtr, 100663599);
				ShortcutExtensions.__c__DisplayClass10_0.NativeMethodInfoPtr__DOShakePosition_b__0_Internal_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass10_0>.NativeClassPtr, 100663600);
				ShortcutExtensions.__c__DisplayClass10_0.NativeMethodInfoPtr__DOShakePosition_b__1_Internal_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass10_0>.NativeClassPtr, 100663601);
			}

			// Token: 0x060005BD RID: 1469 RVA: 0x0001EB88 File Offset: 0x0001CD88
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass10_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass10_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass10_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060005BE RID: 1470 RVA: 0x0001EBC4 File Offset: 0x0001CDC4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1128259, XrefRangeEnd = 1128261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Vector3 _DOShakePosition_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass10_0.NativeMethodInfoPtr__DOShakePosition_b__0_Internal_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060005BF RID: 1471 RVA: 0x0001EC00 File Offset: 0x0001CE00
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1128261, XrefRangeEnd = 1128263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DOShakePosition_b__1(Vector3 x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass10_0.NativeMethodInfoPtr__DOShakePosition_b__1_Internal_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060005C0 RID: 1472 RVA: 0x00003E3B File Offset: 0x0000203B
			public __c__DisplayClass10_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000111 RID: 273
			// (get) Token: 0x060005C1 RID: 1473 RVA: 0x0001EC40 File Offset: 0x0001CE40
			// (set) Token: 0x060005C2 RID: 1474 RVA: 0x00003E44 File Offset: 0x00002044
			public unsafe Camera target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass10_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass10_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400048C RID: 1164
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x0400048D RID: 1165
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400048E RID: 1166
			private static readonly IntPtr NativeMethodInfoPtr__DOShakePosition_b__0_Internal_Vector3_0;

			// Token: 0x0400048F RID: 1167
			private static readonly IntPtr NativeMethodInfoPtr__DOShakePosition_b__1_Internal_Void_Vector3_0;
		}

		// Token: 0x0200006E RID: 110
		[ObfuscatedName("DG.Tweening.ShortcutExtensions+<>c__DisplayClass11_0")]
		public sealed class __c__DisplayClass11_0 : global::Il2CppSystem.Object
		{
			// Token: 0x060005C3 RID: 1475 RVA: 0x0001EC70 File Offset: 0x0001CE70
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass11_0()
			{
				Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass11_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, "<>c__DisplayClass11_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass11_0>.NativeClassPtr);
				ShortcutExtensions.__c__DisplayClass11_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass11_0>.NativeClassPtr, "target");
				ShortcutExtensions.__c__DisplayClass11_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass11_0>.NativeClassPtr, 100663602);
				ShortcutExtensions.__c__DisplayClass11_0.NativeMethodInfoPtr__DOShakePosition_b__0_Internal_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass11_0>.NativeClassPtr, 100663603);
				ShortcutExtensions.__c__DisplayClass11_0.NativeMethodInfoPtr__DOShakePosition_b__1_Internal_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass11_0>.NativeClassPtr, 100663604);
			}

			// Token: 0x060005C4 RID: 1476 RVA: 0x0001ECEC File Offset: 0x0001CEEC
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass11_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass11_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass11_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060005C5 RID: 1477 RVA: 0x0001ED28 File Offset: 0x0001CF28
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Vector3 _DOShakePosition_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass11_0.NativeMethodInfoPtr__DOShakePosition_b__0_Internal_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060005C6 RID: 1478 RVA: 0x0001ED64 File Offset: 0x0001CF64
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DOShakePosition_b__1(Vector3 x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass11_0.NativeMethodInfoPtr__DOShakePosition_b__1_Internal_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060005C7 RID: 1479 RVA: 0x00003E63 File Offset: 0x00002063
			public __c__DisplayClass11_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000112 RID: 274
			// (get) Token: 0x060005C8 RID: 1480 RVA: 0x0001EDA4 File Offset: 0x0001CFA4
			// (set) Token: 0x060005C9 RID: 1481 RVA: 0x00003E6C File Offset: 0x0000206C
			public unsafe Camera target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass11_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass11_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000490 RID: 1168
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x04000491 RID: 1169
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000492 RID: 1170
			private static readonly IntPtr NativeMethodInfoPtr__DOShakePosition_b__0_Internal_Vector3_0;

			// Token: 0x04000493 RID: 1171
			private static readonly IntPtr NativeMethodInfoPtr__DOShakePosition_b__1_Internal_Void_Vector3_0;
		}

		// Token: 0x0200006F RID: 111
		[ObfuscatedName("DG.Tweening.ShortcutExtensions+<>c__DisplayClass12_0")]
		public sealed class __c__DisplayClass12_0 : global::Il2CppSystem.Object
		{
			// Token: 0x060005CA RID: 1482 RVA: 0x0001EDD4 File Offset: 0x0001CFD4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass12_0()
			{
				Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass12_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, "<>c__DisplayClass12_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass12_0>.NativeClassPtr);
				ShortcutExtensions.__c__DisplayClass12_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass12_0>.NativeClassPtr, "target");
				ShortcutExtensions.__c__DisplayClass12_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass12_0>.NativeClassPtr, 100663605);
				ShortcutExtensions.__c__DisplayClass12_0.NativeMethodInfoPtr__DOShakeRotation_b__0_Internal_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass12_0>.NativeClassPtr, 100663606);
				ShortcutExtensions.__c__DisplayClass12_0.NativeMethodInfoPtr__DOShakeRotation_b__1_Internal_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass12_0>.NativeClassPtr, 100663607);
			}

			// Token: 0x060005CB RID: 1483 RVA: 0x0001EE50 File Offset: 0x0001D050
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass12_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass12_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass12_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060005CC RID: 1484 RVA: 0x0001EE8C File Offset: 0x0001D08C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1128263, XrefRangeEnd = 1128265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Vector3 _DOShakeRotation_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass12_0.NativeMethodInfoPtr__DOShakeRotation_b__0_Internal_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060005CD RID: 1485 RVA: 0x0001EEC8 File Offset: 0x0001D0C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1128265, XrefRangeEnd = 1128268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DOShakeRotation_b__1(Vector3 x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass12_0.NativeMethodInfoPtr__DOShakeRotation_b__1_Internal_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060005CE RID: 1486 RVA: 0x00003E8B File Offset: 0x0000208B
			public __c__DisplayClass12_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000113 RID: 275
			// (get) Token: 0x060005CF RID: 1487 RVA: 0x0001EF08 File Offset: 0x0001D108
			// (set) Token: 0x060005D0 RID: 1488 RVA: 0x00003E94 File Offset: 0x00002094
			public unsafe Camera target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass12_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass12_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000494 RID: 1172
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x04000495 RID: 1173
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000496 RID: 1174
			private static readonly IntPtr NativeMethodInfoPtr__DOShakeRotation_b__0_Internal_Vector3_0;

			// Token: 0x04000497 RID: 1175
			private static readonly IntPtr NativeMethodInfoPtr__DOShakeRotation_b__1_Internal_Void_Vector3_0;
		}

		// Token: 0x02000070 RID: 112
		[ObfuscatedName("DG.Tweening.ShortcutExtensions+<>c__DisplayClass13_0")]
		public sealed class __c__DisplayClass13_0 : global::Il2CppSystem.Object
		{
			// Token: 0x060005D1 RID: 1489 RVA: 0x0001EF38 File Offset: 0x0001D138
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass13_0()
			{
				Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass13_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, "<>c__DisplayClass13_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass13_0>.NativeClassPtr);
				ShortcutExtensions.__c__DisplayClass13_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass13_0>.NativeClassPtr, "target");
				ShortcutExtensions.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass13_0>.NativeClassPtr, 100663608);
				ShortcutExtensions.__c__DisplayClass13_0.NativeMethodInfoPtr__DOShakeRotation_b__0_Internal_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass13_0>.NativeClassPtr, 100663609);
				ShortcutExtensions.__c__DisplayClass13_0.NativeMethodInfoPtr__DOShakeRotation_b__1_Internal_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass13_0>.NativeClassPtr, 100663610);
			}

			// Token: 0x060005D2 RID: 1490 RVA: 0x0001EFB4 File Offset: 0x0001D1B4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass13_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass13_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060005D3 RID: 1491 RVA: 0x0001EFF0 File Offset: 0x0001D1F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Vector3 _DOShakeRotation_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass13_0.NativeMethodInfoPtr__DOShakeRotation_b__0_Internal_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060005D4 RID: 1492 RVA: 0x0001F02C File Offset: 0x0001D22C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DOShakeRotation_b__1(Vector3 x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass13_0.NativeMethodInfoPtr__DOShakeRotation_b__1_Internal_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060005D5 RID: 1493 RVA: 0x00003EB3 File Offset: 0x000020B3
			public __c__DisplayClass13_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000114 RID: 276
			// (get) Token: 0x060005D6 RID: 1494 RVA: 0x0001F06C File Offset: 0x0001D26C
			// (set) Token: 0x060005D7 RID: 1495 RVA: 0x00003EBC File Offset: 0x000020BC
			public unsafe Camera target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass13_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass13_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000498 RID: 1176
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x04000499 RID: 1177
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400049A RID: 1178
			private static readonly IntPtr NativeMethodInfoPtr__DOShakeRotation_b__0_Internal_Vector3_0;

			// Token: 0x0400049B RID: 1179
			private static readonly IntPtr NativeMethodInfoPtr__DOShakeRotation_b__1_Internal_Void_Vector3_0;
		}

		// Token: 0x02000071 RID: 113
		[ObfuscatedName("DG.Tweening.ShortcutExtensions+<>c__DisplayClass14_0")]
		public sealed class __c__DisplayClass14_0 : global::Il2CppSystem.Object
		{
			// Token: 0x060005D8 RID: 1496 RVA: 0x0001F09C File Offset: 0x0001D29C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass14_0()
			{
				Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass14_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, "<>c__DisplayClass14_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass14_0>.NativeClassPtr);
				ShortcutExtensions.__c__DisplayClass14_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass14_0>.NativeClassPtr, "target");
				ShortcutExtensions.__c__DisplayClass14_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass14_0>.NativeClassPtr, 100663611);
				ShortcutExtensions.__c__DisplayClass14_0.NativeMethodInfoPtr__DOColor_b__0_Internal_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass14_0>.NativeClassPtr, 100663612);
				ShortcutExtensions.__c__DisplayClass14_0.NativeMethodInfoPtr__DOColor_b__1_Internal_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass14_0>.NativeClassPtr, 100663613);
			}

			// Token: 0x060005D9 RID: 1497 RVA: 0x0001F118 File Offset: 0x0001D318
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass14_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass14_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass14_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060005DA RID: 1498 RVA: 0x0001F154 File Offset: 0x0001D354
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1128268, XrefRangeEnd = 1128269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Color _DOColor_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass14_0.NativeMethodInfoPtr__DOColor_b__0_Internal_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060005DB RID: 1499 RVA: 0x0001F190 File Offset: 0x0001D390
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1128269, XrefRangeEnd = 1128270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DOColor_b__1(Color x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass14_0.NativeMethodInfoPtr__DOColor_b__1_Internal_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060005DC RID: 1500 RVA: 0x00003EDB File Offset: 0x000020DB
			public __c__DisplayClass14_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000115 RID: 277
			// (get) Token: 0x060005DD RID: 1501 RVA: 0x0001F1D0 File Offset: 0x0001D3D0
			// (set) Token: 0x060005DE RID: 1502 RVA: 0x00003EE4 File Offset: 0x000020E4
			public unsafe Light target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass14_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Light>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass14_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400049C RID: 1180
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x0400049D RID: 1181
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400049E RID: 1182
			private static readonly IntPtr NativeMethodInfoPtr__DOColor_b__0_Internal_Color_0;

			// Token: 0x0400049F RID: 1183
			private static readonly IntPtr NativeMethodInfoPtr__DOColor_b__1_Internal_Void_Color_0;
		}

		// Token: 0x02000072 RID: 114
		[ObfuscatedName("DG.Tweening.ShortcutExtensions+<>c__DisplayClass15_0")]
		public sealed class __c__DisplayClass15_0 : global::Il2CppSystem.Object
		{
			// Token: 0x060005DF RID: 1503 RVA: 0x0001F200 File Offset: 0x0001D400
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass15_0()
			{
				Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass15_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, "<>c__DisplayClass15_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass15_0>.NativeClassPtr);
				ShortcutExtensions.__c__DisplayClass15_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass15_0>.NativeClassPtr, "target");
				ShortcutExtensions.__c__DisplayClass15_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass15_0>.NativeClassPtr, 100663614);
				ShortcutExtensions.__c__DisplayClass15_0.NativeMethodInfoPtr__DOIntensity_b__0_Internal_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass15_0>.NativeClassPtr, 100663615);
				ShortcutExtensions.__c__DisplayClass15_0.NativeMethodInfoPtr__DOIntensity_b__1_Internal_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass15_0>.NativeClassPtr, 100663616);
			}

			// Token: 0x060005E0 RID: 1504 RVA: 0x0001F27C File Offset: 0x0001D47C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass15_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass15_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass15_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060005E1 RID: 1505 RVA: 0x0001F2B8 File Offset: 0x0001D4B8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1128270, XrefRangeEnd = 1128272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _DOIntensity_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass15_0.NativeMethodInfoPtr__DOIntensity_b__0_Internal_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060005E2 RID: 1506 RVA: 0x0001F2F4 File Offset: 0x0001D4F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1128272, XrefRangeEnd = 1128274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DOIntensity_b__1(float x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass15_0.NativeMethodInfoPtr__DOIntensity_b__1_Internal_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060005E3 RID: 1507 RVA: 0x00003F03 File Offset: 0x00002103
			public __c__DisplayClass15_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000116 RID: 278
			// (get) Token: 0x060005E4 RID: 1508 RVA: 0x0001F334 File Offset: 0x0001D534
			// (set) Token: 0x060005E5 RID: 1509 RVA: 0x00003F0C File Offset: 0x0000210C
			public unsafe Light target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass15_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Light>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass15_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040004A0 RID: 1184
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x040004A1 RID: 1185
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040004A2 RID: 1186
			private static readonly IntPtr NativeMethodInfoPtr__DOIntensity_b__0_Internal_Single_0;

			// Token: 0x040004A3 RID: 1187
			private static readonly IntPtr NativeMethodInfoPtr__DOIntensity_b__1_Internal_Void_Single_0;
		}

		// Token: 0x02000073 RID: 115
		[ObfuscatedName("DG.Tweening.ShortcutExtensions+<>c__DisplayClass16_0")]
		public sealed class __c__DisplayClass16_0 : global::Il2CppSystem.Object
		{
			// Token: 0x060005E6 RID: 1510 RVA: 0x0001F364 File Offset: 0x0001D564
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass16_0()
			{
				Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass16_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, "<>c__DisplayClass16_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass16_0>.NativeClassPtr);
				ShortcutExtensions.__c__DisplayClass16_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass16_0>.NativeClassPtr, "target");
				ShortcutExtensions.__c__DisplayClass16_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass16_0>.NativeClassPtr, 100663617);
				ShortcutExtensions.__c__DisplayClass16_0.NativeMethodInfoPtr__DOShadowStrength_b__0_Internal_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass16_0>.NativeClassPtr, 100663618);
				ShortcutExtensions.__c__DisplayClass16_0.NativeMethodInfoPtr__DOShadowStrength_b__1_Internal_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass16_0>.NativeClassPtr, 100663619);
			}

			// Token: 0x060005E7 RID: 1511 RVA: 0x0001F3E0 File Offset: 0x0001D5E0
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass16_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass16_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass16_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060005E8 RID: 1512 RVA: 0x0001F41C File Offset: 0x0001D61C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1128274, XrefRangeEnd = 1128276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _DOShadowStrength_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass16_0.NativeMethodInfoPtr__DOShadowStrength_b__0_Internal_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060005E9 RID: 1513 RVA: 0x0001F458 File Offset: 0x0001D658
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1128276, XrefRangeEnd = 1128278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DOShadowStrength_b__1(float x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass16_0.NativeMethodInfoPtr__DOShadowStrength_b__1_Internal_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060005EA RID: 1514 RVA: 0x00003F2B File Offset: 0x0000212B
			public __c__DisplayClass16_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000117 RID: 279
			// (get) Token: 0x060005EB RID: 1515 RVA: 0x0001F498 File Offset: 0x0001D698
			// (set) Token: 0x060005EC RID: 1516 RVA: 0x00003F34 File Offset: 0x00002134
			public unsafe Light target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass16_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Light>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass16_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040004A4 RID: 1188
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x040004A5 RID: 1189
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040004A6 RID: 1190
			private static readonly IntPtr NativeMethodInfoPtr__DOShadowStrength_b__0_Internal_Single_0;

			// Token: 0x040004A7 RID: 1191
			private static readonly IntPtr NativeMethodInfoPtr__DOShadowStrength_b__1_Internal_Void_Single_0;
		}

		// Token: 0x02000074 RID: 116
		[ObfuscatedName("DG.Tweening.ShortcutExtensions+<>c__DisplayClass17_0")]
		public sealed class __c__DisplayClass17_0 : global::Il2CppSystem.Object
		{
			// Token: 0x060005ED RID: 1517 RVA: 0x0001F4C8 File Offset: 0x0001D6C8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass17_0()
			{
				Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass17_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, "<>c__DisplayClass17_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass17_0>.NativeClassPtr);
				ShortcutExtensions.__c__DisplayClass17_0.NativeFieldInfoPtr_startValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass17_0>.NativeClassPtr, "startValue");
				ShortcutExtensions.__c__DisplayClass17_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass17_0>.NativeClassPtr, "target");
				ShortcutExtensions.__c__DisplayClass17_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass17_0>.NativeClassPtr, 100663620);
				ShortcutExtensions.__c__DisplayClass17_0.NativeMethodInfoPtr__DOColor_b__0_Internal_Color2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass17_0>.NativeClassPtr, 100663621);
				ShortcutExtensions.__c__DisplayClass17_0.NativeMethodInfoPtr__DOColor_b__1_Internal_Void_Color2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass17_0>.NativeClassPtr, 100663622);
			}

			// Token: 0x060005EE RID: 1518 RVA: 0x0001F558 File Offset: 0x0001D758
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass17_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass17_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass17_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060005EF RID: 1519 RVA: 0x0001F594 File Offset: 0x0001D794
			[CallerCount(0)]
			public unsafe Color2 _DOColor_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass17_0.NativeMethodInfoPtr__DOColor_b__0_Internal_Color2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060005F0 RID: 1520 RVA: 0x0001F5D0 File Offset: 0x0001D7D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1128278, XrefRangeEnd = 1128279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DOColor_b__1(Color2 x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass17_0.NativeMethodInfoPtr__DOColor_b__1_Internal_Void_Color2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060005F1 RID: 1521 RVA: 0x00003F53 File Offset: 0x00002153
			public __c__DisplayClass17_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000118 RID: 280
			// (get) Token: 0x060005F2 RID: 1522 RVA: 0x0001F610 File Offset: 0x0001D810
			// (set) Token: 0x060005F3 RID: 1523 RVA: 0x00003F5C File Offset: 0x0000215C
			public unsafe Color2 startValue
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass17_0.NativeFieldInfoPtr_startValue);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass17_0.NativeFieldInfoPtr_startValue)) = value;
				}
			}

			// Token: 0x17000119 RID: 281
			// (get) Token: 0x060005F4 RID: 1524 RVA: 0x0001F638 File Offset: 0x0001D838
			// (set) Token: 0x060005F5 RID: 1525 RVA: 0x00003F77 File Offset: 0x00002177
			public unsafe LineRenderer target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass17_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LineRenderer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass17_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040004A8 RID: 1192
			private static readonly IntPtr NativeFieldInfoPtr_startValue;

			// Token: 0x040004A9 RID: 1193
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x040004AA RID: 1194
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040004AB RID: 1195
			private static readonly IntPtr NativeMethodInfoPtr__DOColor_b__0_Internal_Color2_0;

			// Token: 0x040004AC RID: 1196
			private static readonly IntPtr NativeMethodInfoPtr__DOColor_b__1_Internal_Void_Color2_0;
		}

		// Token: 0x02000075 RID: 117
		[ObfuscatedName("DG.Tweening.ShortcutExtensions+<>c__DisplayClass18_0")]
		public sealed class __c__DisplayClass18_0 : global::Il2CppSystem.Object
		{
			// Token: 0x060005F6 RID: 1526 RVA: 0x0001F668 File Offset: 0x0001D868
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass18_0()
			{
				Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass18_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, "<>c__DisplayClass18_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass18_0>.NativeClassPtr);
				ShortcutExtensions.__c__DisplayClass18_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass18_0>.NativeClassPtr, "target");
				ShortcutExtensions.__c__DisplayClass18_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass18_0>.NativeClassPtr, 100663623);
				ShortcutExtensions.__c__DisplayClass18_0.NativeMethodInfoPtr__DOColor_b__0_Internal_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass18_0>.NativeClassPtr, 100663624);
				ShortcutExtensions.__c__DisplayClass18_0.NativeMethodInfoPtr__DOColor_b__1_Internal_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass18_0>.NativeClassPtr, 100663625);
			}

			// Token: 0x060005F7 RID: 1527 RVA: 0x0001F6E4 File Offset: 0x0001D8E4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass18_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass18_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass18_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060005F8 RID: 1528 RVA: 0x0001F720 File Offset: 0x0001D920
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1128279, XrefRangeEnd = 1128280, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Color _DOColor_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass18_0.NativeMethodInfoPtr__DOColor_b__0_Internal_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060005F9 RID: 1529 RVA: 0x0001F75C File Offset: 0x0001D95C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1128280, XrefRangeEnd = 1128281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DOColor_b__1(Color x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass18_0.NativeMethodInfoPtr__DOColor_b__1_Internal_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060005FA RID: 1530 RVA: 0x00003F96 File Offset: 0x00002196
			public __c__DisplayClass18_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700011A RID: 282
			// (get) Token: 0x060005FB RID: 1531 RVA: 0x0001F79C File Offset: 0x0001D99C
			// (set) Token: 0x060005FC RID: 1532 RVA: 0x00003F9F File Offset: 0x0000219F
			public unsafe Material target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass18_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass18_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040004AD RID: 1197
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x040004AE RID: 1198
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040004AF RID: 1199
			private static readonly IntPtr NativeMethodInfoPtr__DOColor_b__0_Internal_Color_0;

			// Token: 0x040004B0 RID: 1200
			private static readonly IntPtr NativeMethodInfoPtr__DOColor_b__1_Internal_Void_Color_0;
		}

		// Token: 0x02000076 RID: 118
		[ObfuscatedName("DG.Tweening.ShortcutExtensions+<>c__DisplayClass19_0")]
		public sealed class __c__DisplayClass19_0 : global::Il2CppSystem.Object
		{
			// Token: 0x060005FD RID: 1533 RVA: 0x0001F7CC File Offset: 0x0001D9CC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass19_0()
			{
				Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass19_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, "<>c__DisplayClass19_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass19_0>.NativeClassPtr);
				ShortcutExtensions.__c__DisplayClass19_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass19_0>.NativeClassPtr, "target");
				ShortcutExtensions.__c__DisplayClass19_0.NativeFieldInfoPtr_property = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass19_0>.NativeClassPtr, "property");
				ShortcutExtensions.__c__DisplayClass19_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass19_0>.NativeClassPtr, 100663626);
				ShortcutExtensions.__c__DisplayClass19_0.NativeMethodInfoPtr__DOColor_b__0_Internal_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass19_0>.NativeClassPtr, 100663627);
				ShortcutExtensions.__c__DisplayClass19_0.NativeMethodInfoPtr__DOColor_b__1_Internal_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass19_0>.NativeClassPtr, 100663628);
			}

			// Token: 0x060005FE RID: 1534 RVA: 0x0001F85C File Offset: 0x0001DA5C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass19_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass19_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass19_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060005FF RID: 1535 RVA: 0x0001F898 File Offset: 0x0001DA98
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1128281, XrefRangeEnd = 1128282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Color _DOColor_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass19_0.NativeMethodInfoPtr__DOColor_b__0_Internal_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000600 RID: 1536 RVA: 0x0001F8D4 File Offset: 0x0001DAD4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1128282, XrefRangeEnd = 1128283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DOColor_b__1(Color x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass19_0.NativeMethodInfoPtr__DOColor_b__1_Internal_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000601 RID: 1537 RVA: 0x00003FBE File Offset: 0x000021BE
			public __c__DisplayClass19_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700011B RID: 283
			// (get) Token: 0x06000602 RID: 1538 RVA: 0x0001F914 File Offset: 0x0001DB14
			// (set) Token: 0x06000603 RID: 1539 RVA: 0x00003FC7 File Offset: 0x000021C7
			public unsafe Material target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass19_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass19_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700011C RID: 284
			// (get) Token: 0x06000604 RID: 1540 RVA: 0x0001F944 File Offset: 0x0001DB44
			// (set) Token: 0x06000605 RID: 1541 RVA: 0x00003FE6 File Offset: 0x000021E6
			public unsafe string property
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass19_0.NativeFieldInfoPtr_property);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass19_0.NativeFieldInfoPtr_property), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x040004B1 RID: 1201
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x040004B2 RID: 1202
			private static readonly IntPtr NativeFieldInfoPtr_property;

			// Token: 0x040004B3 RID: 1203
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040004B4 RID: 1204
			private static readonly IntPtr NativeMethodInfoPtr__DOColor_b__0_Internal_Color_0;

			// Token: 0x040004B5 RID: 1205
			private static readonly IntPtr NativeMethodInfoPtr__DOColor_b__1_Internal_Void_Color_0;
		}

		// Token: 0x02000077 RID: 119
		[ObfuscatedName("DG.Tweening.ShortcutExtensions+<>c__DisplayClass20_0")]
		public sealed class __c__DisplayClass20_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06000606 RID: 1542 RVA: 0x0001F96C File Offset: 0x0001DB6C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass20_0()
			{
				Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass20_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, "<>c__DisplayClass20_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass20_0>.NativeClassPtr);
				ShortcutExtensions.__c__DisplayClass20_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass20_0>.NativeClassPtr, "target");
				ShortcutExtensions.__c__DisplayClass20_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass20_0>.NativeClassPtr, 100663629);
				ShortcutExtensions.__c__DisplayClass20_0.NativeMethodInfoPtr__DOFade_b__0_Internal_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass20_0>.NativeClassPtr, 100663630);
				ShortcutExtensions.__c__DisplayClass20_0.NativeMethodInfoPtr__DOFade_b__1_Internal_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass20_0>.NativeClassPtr, 100663631);
			}

			// Token: 0x06000607 RID: 1543 RVA: 0x0001F9E8 File Offset: 0x0001DBE8
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass20_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass20_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass20_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000608 RID: 1544 RVA: 0x0001FA24 File Offset: 0x0001DC24
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Color _DOFade_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass20_0.NativeMethodInfoPtr__DOFade_b__0_Internal_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000609 RID: 1545 RVA: 0x0001FA60 File Offset: 0x0001DC60
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DOFade_b__1(Color x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass20_0.NativeMethodInfoPtr__DOFade_b__1_Internal_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600060A RID: 1546 RVA: 0x00004005 File Offset: 0x00002205
			public __c__DisplayClass20_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700011D RID: 285
			// (get) Token: 0x0600060B RID: 1547 RVA: 0x0001FAA0 File Offset: 0x0001DCA0
			// (set) Token: 0x0600060C RID: 1548 RVA: 0x0000400E File Offset: 0x0000220E
			public unsafe Material target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass20_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass20_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040004B6 RID: 1206
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x040004B7 RID: 1207
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040004B8 RID: 1208
			private static readonly IntPtr NativeMethodInfoPtr__DOFade_b__0_Internal_Color_0;

			// Token: 0x040004B9 RID: 1209
			private static readonly IntPtr NativeMethodInfoPtr__DOFade_b__1_Internal_Void_Color_0;
		}

		// Token: 0x02000078 RID: 120
		[ObfuscatedName("DG.Tweening.ShortcutExtensions+<>c__DisplayClass21_0")]
		public sealed class __c__DisplayClass21_0 : global::Il2CppSystem.Object
		{
			// Token: 0x0600060D RID: 1549 RVA: 0x0001FAD0 File Offset: 0x0001DCD0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass21_0()
			{
				Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass21_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, "<>c__DisplayClass21_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass21_0>.NativeClassPtr);
				ShortcutExtensions.__c__DisplayClass21_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass21_0>.NativeClassPtr, "target");
				ShortcutExtensions.__c__DisplayClass21_0.NativeFieldInfoPtr_property = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass21_0>.NativeClassPtr, "property");
				ShortcutExtensions.__c__DisplayClass21_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass21_0>.NativeClassPtr, 100663632);
				ShortcutExtensions.__c__DisplayClass21_0.NativeMethodInfoPtr__DOFade_b__0_Internal_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass21_0>.NativeClassPtr, 100663633);
				ShortcutExtensions.__c__DisplayClass21_0.NativeMethodInfoPtr__DOFade_b__1_Internal_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass21_0>.NativeClassPtr, 100663634);
			}

			// Token: 0x0600060E RID: 1550 RVA: 0x0001FB60 File Offset: 0x0001DD60
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass21_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass21_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass21_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600060F RID: 1551 RVA: 0x0001FB9C File Offset: 0x0001DD9C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Color _DOFade_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass21_0.NativeMethodInfoPtr__DOFade_b__0_Internal_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000610 RID: 1552 RVA: 0x0001FBD8 File Offset: 0x0001DDD8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DOFade_b__1(Color x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass21_0.NativeMethodInfoPtr__DOFade_b__1_Internal_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000611 RID: 1553 RVA: 0x0000402D File Offset: 0x0000222D
			public __c__DisplayClass21_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700011E RID: 286
			// (get) Token: 0x06000612 RID: 1554 RVA: 0x0001FC18 File Offset: 0x0001DE18
			// (set) Token: 0x06000613 RID: 1555 RVA: 0x00004036 File Offset: 0x00002236
			public unsafe Material target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass21_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass21_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700011F RID: 287
			// (get) Token: 0x06000614 RID: 1556 RVA: 0x0001FC48 File Offset: 0x0001DE48
			// (set) Token: 0x06000615 RID: 1557 RVA: 0x00004055 File Offset: 0x00002255
			public unsafe string property
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass21_0.NativeFieldInfoPtr_property);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass21_0.NativeFieldInfoPtr_property), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x040004BA RID: 1210
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x040004BB RID: 1211
			private static readonly IntPtr NativeFieldInfoPtr_property;

			// Token: 0x040004BC RID: 1212
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040004BD RID: 1213
			private static readonly IntPtr NativeMethodInfoPtr__DOFade_b__0_Internal_Color_0;

			// Token: 0x040004BE RID: 1214
			private static readonly IntPtr NativeMethodInfoPtr__DOFade_b__1_Internal_Void_Color_0;
		}

		// Token: 0x02000079 RID: 121
		[ObfuscatedName("DG.Tweening.ShortcutExtensions+<>c__DisplayClass22_0")]
		public sealed class __c__DisplayClass22_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06000616 RID: 1558 RVA: 0x0001FC70 File Offset: 0x0001DE70
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass22_0()
			{
				Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass22_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, "<>c__DisplayClass22_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass22_0>.NativeClassPtr);
				ShortcutExtensions.__c__DisplayClass22_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass22_0>.NativeClassPtr, "target");
				ShortcutExtensions.__c__DisplayClass22_0.NativeFieldInfoPtr_property = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass22_0>.NativeClassPtr, "property");
				ShortcutExtensions.__c__DisplayClass22_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass22_0>.NativeClassPtr, 100663635);
				ShortcutExtensions.__c__DisplayClass22_0.NativeMethodInfoPtr__DOFloat_b__0_Internal_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass22_0>.NativeClassPtr, 100663636);
				ShortcutExtensions.__c__DisplayClass22_0.NativeMethodInfoPtr__DOFloat_b__1_Internal_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass22_0>.NativeClassPtr, 100663637);
			}

			// Token: 0x06000617 RID: 1559 RVA: 0x0001FD00 File Offset: 0x0001DF00
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass22_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass22_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass22_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000618 RID: 1560 RVA: 0x0001FD3C File Offset: 0x0001DF3C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1128283, XrefRangeEnd = 1128285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _DOFloat_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass22_0.NativeMethodInfoPtr__DOFloat_b__0_Internal_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000619 RID: 1561 RVA: 0x0001FD78 File Offset: 0x0001DF78
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1128285, XrefRangeEnd = 1128287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DOFloat_b__1(float x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass22_0.NativeMethodInfoPtr__DOFloat_b__1_Internal_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600061A RID: 1562 RVA: 0x00004074 File Offset: 0x00002274
			public __c__DisplayClass22_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000120 RID: 288
			// (get) Token: 0x0600061B RID: 1563 RVA: 0x0001FDB8 File Offset: 0x0001DFB8
			// (set) Token: 0x0600061C RID: 1564 RVA: 0x0000407D File Offset: 0x0000227D
			public unsafe Material target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass22_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass22_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000121 RID: 289
			// (get) Token: 0x0600061D RID: 1565 RVA: 0x0001FDE8 File Offset: 0x0001DFE8
			// (set) Token: 0x0600061E RID: 1566 RVA: 0x0000409C File Offset: 0x0000229C
			public unsafe string property
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass22_0.NativeFieldInfoPtr_property);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass22_0.NativeFieldInfoPtr_property), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x040004BF RID: 1215
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x040004C0 RID: 1216
			private static readonly IntPtr NativeFieldInfoPtr_property;

			// Token: 0x040004C1 RID: 1217
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040004C2 RID: 1218
			private static readonly IntPtr NativeMethodInfoPtr__DOFloat_b__0_Internal_Single_0;

			// Token: 0x040004C3 RID: 1219
			private static readonly IntPtr NativeMethodInfoPtr__DOFloat_b__1_Internal_Void_Single_0;
		}

		// Token: 0x0200007A RID: 122
		[ObfuscatedName("DG.Tweening.ShortcutExtensions+<>c__DisplayClass23_0")]
		public sealed class __c__DisplayClass23_0 : global::Il2CppSystem.Object
		{
			// Token: 0x0600061F RID: 1567 RVA: 0x0001FE10 File Offset: 0x0001E010
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass23_0()
			{
				Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass23_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, "<>c__DisplayClass23_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass23_0>.NativeClassPtr);
				ShortcutExtensions.__c__DisplayClass23_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass23_0>.NativeClassPtr, "target");
				ShortcutExtensions.__c__DisplayClass23_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass23_0>.NativeClassPtr, 100663638);
				ShortcutExtensions.__c__DisplayClass23_0.NativeMethodInfoPtr__DOOffset_b__0_Internal_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass23_0>.NativeClassPtr, 100663639);
				ShortcutExtensions.__c__DisplayClass23_0.NativeMethodInfoPtr__DOOffset_b__1_Internal_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass23_0>.NativeClassPtr, 100663640);
			}

			// Token: 0x06000620 RID: 1568 RVA: 0x0001FE8C File Offset: 0x0001E08C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass23_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass23_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass23_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000621 RID: 1569 RVA: 0x0001FEC8 File Offset: 0x0001E0C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1128287, XrefRangeEnd = 1128289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Vector2 _DOOffset_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass23_0.NativeMethodInfoPtr__DOOffset_b__0_Internal_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000622 RID: 1570 RVA: 0x0001FF04 File Offset: 0x0001E104
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1128289, XrefRangeEnd = 1128291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DOOffset_b__1(Vector2 x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass23_0.NativeMethodInfoPtr__DOOffset_b__1_Internal_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000623 RID: 1571 RVA: 0x000040BB File Offset: 0x000022BB
			public __c__DisplayClass23_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000122 RID: 290
			// (get) Token: 0x06000624 RID: 1572 RVA: 0x0001FF44 File Offset: 0x0001E144
			// (set) Token: 0x06000625 RID: 1573 RVA: 0x000040C4 File Offset: 0x000022C4
			public unsafe Material target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass23_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass23_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040004C4 RID: 1220
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x040004C5 RID: 1221
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040004C6 RID: 1222
			private static readonly IntPtr NativeMethodInfoPtr__DOOffset_b__0_Internal_Vector2_0;

			// Token: 0x040004C7 RID: 1223
			private static readonly IntPtr NativeMethodInfoPtr__DOOffset_b__1_Internal_Void_Vector2_0;
		}

		// Token: 0x0200007B RID: 123
		[ObfuscatedName("DG.Tweening.ShortcutExtensions+<>c__DisplayClass24_0")]
		public sealed class __c__DisplayClass24_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06000626 RID: 1574 RVA: 0x0001FF74 File Offset: 0x0001E174
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass24_0()
			{
				Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass24_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, "<>c__DisplayClass24_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass24_0>.NativeClassPtr);
				ShortcutExtensions.__c__DisplayClass24_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass24_0>.NativeClassPtr, "target");
				ShortcutExtensions.__c__DisplayClass24_0.NativeFieldInfoPtr_property = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass24_0>.NativeClassPtr, "property");
				ShortcutExtensions.__c__DisplayClass24_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass24_0>.NativeClassPtr, 100663641);
				ShortcutExtensions.__c__DisplayClass24_0.NativeMethodInfoPtr__DOOffset_b__0_Internal_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass24_0>.NativeClassPtr, 100663642);
				ShortcutExtensions.__c__DisplayClass24_0.NativeMethodInfoPtr__DOOffset_b__1_Internal_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass24_0>.NativeClassPtr, 100663643);
			}

			// Token: 0x06000627 RID: 1575 RVA: 0x00020004 File Offset: 0x0001E204
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass24_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass24_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass24_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000628 RID: 1576 RVA: 0x00020040 File Offset: 0x0001E240
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1128291, XrefRangeEnd = 1128293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Vector2 _DOOffset_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass24_0.NativeMethodInfoPtr__DOOffset_b__0_Internal_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000629 RID: 1577 RVA: 0x0002007C File Offset: 0x0001E27C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1128293, XrefRangeEnd = 1128295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DOOffset_b__1(Vector2 x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass24_0.NativeMethodInfoPtr__DOOffset_b__1_Internal_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600062A RID: 1578 RVA: 0x000040E3 File Offset: 0x000022E3
			public __c__DisplayClass24_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000123 RID: 291
			// (get) Token: 0x0600062B RID: 1579 RVA: 0x000200BC File Offset: 0x0001E2BC
			// (set) Token: 0x0600062C RID: 1580 RVA: 0x000040EC File Offset: 0x000022EC
			public unsafe Material target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass24_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass24_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000124 RID: 292
			// (get) Token: 0x0600062D RID: 1581 RVA: 0x000200EC File Offset: 0x0001E2EC
			// (set) Token: 0x0600062E RID: 1582 RVA: 0x0000410B File Offset: 0x0000230B
			public unsafe string property
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass24_0.NativeFieldInfoPtr_property);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass24_0.NativeFieldInfoPtr_property), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x040004C8 RID: 1224
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x040004C9 RID: 1225
			private static readonly IntPtr NativeFieldInfoPtr_property;

			// Token: 0x040004CA RID: 1226
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040004CB RID: 1227
			private static readonly IntPtr NativeMethodInfoPtr__DOOffset_b__0_Internal_Vector2_0;

			// Token: 0x040004CC RID: 1228
			private static readonly IntPtr NativeMethodInfoPtr__DOOffset_b__1_Internal_Void_Vector2_0;
		}

		// Token: 0x0200007C RID: 124
		[ObfuscatedName("DG.Tweening.ShortcutExtensions+<>c__DisplayClass25_0")]
		public sealed class __c__DisplayClass25_0 : global::Il2CppSystem.Object
		{
			// Token: 0x0600062F RID: 1583 RVA: 0x00020114 File Offset: 0x0001E314
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass25_0()
			{
				Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass25_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, "<>c__DisplayClass25_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass25_0>.NativeClassPtr);
				ShortcutExtensions.__c__DisplayClass25_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass25_0>.NativeClassPtr, "target");
				ShortcutExtensions.__c__DisplayClass25_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass25_0>.NativeClassPtr, 100663644);
				ShortcutExtensions.__c__DisplayClass25_0.NativeMethodInfoPtr__DOTiling_b__0_Internal_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass25_0>.NativeClassPtr, 100663645);
				ShortcutExtensions.__c__DisplayClass25_0.NativeMethodInfoPtr__DOTiling_b__1_Internal_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass25_0>.NativeClassPtr, 100663646);
			}

			// Token: 0x06000630 RID: 1584 RVA: 0x00020190 File Offset: 0x0001E390
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass25_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass25_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass25_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000631 RID: 1585 RVA: 0x000201CC File Offset: 0x0001E3CC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1128295, XrefRangeEnd = 1128297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Vector2 _DOTiling_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass25_0.NativeMethodInfoPtr__DOTiling_b__0_Internal_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000632 RID: 1586 RVA: 0x00020208 File Offset: 0x0001E408
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1128297, XrefRangeEnd = 1128299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DOTiling_b__1(Vector2 x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass25_0.NativeMethodInfoPtr__DOTiling_b__1_Internal_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000633 RID: 1587 RVA: 0x0000412A File Offset: 0x0000232A
			public __c__DisplayClass25_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000125 RID: 293
			// (get) Token: 0x06000634 RID: 1588 RVA: 0x00020248 File Offset: 0x0001E448
			// (set) Token: 0x06000635 RID: 1589 RVA: 0x00004133 File Offset: 0x00002333
			public unsafe Material target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass25_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass25_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040004CD RID: 1229
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x040004CE RID: 1230
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040004CF RID: 1231
			private static readonly IntPtr NativeMethodInfoPtr__DOTiling_b__0_Internal_Vector2_0;

			// Token: 0x040004D0 RID: 1232
			private static readonly IntPtr NativeMethodInfoPtr__DOTiling_b__1_Internal_Void_Vector2_0;
		}

		// Token: 0x0200007D RID: 125
		[ObfuscatedName("DG.Tweening.ShortcutExtensions+<>c__DisplayClass26_0")]
		public sealed class __c__DisplayClass26_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06000636 RID: 1590 RVA: 0x00020278 File Offset: 0x0001E478
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass26_0()
			{
				Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass26_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, "<>c__DisplayClass26_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass26_0>.NativeClassPtr);
				ShortcutExtensions.__c__DisplayClass26_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass26_0>.NativeClassPtr, "target");
				ShortcutExtensions.__c__DisplayClass26_0.NativeFieldInfoPtr_property = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass26_0>.NativeClassPtr, "property");
				ShortcutExtensions.__c__DisplayClass26_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass26_0>.NativeClassPtr, 100663647);
				ShortcutExtensions.__c__DisplayClass26_0.NativeMethodInfoPtr__DOTiling_b__0_Internal_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass26_0>.NativeClassPtr, 100663648);
				ShortcutExtensions.__c__DisplayClass26_0.NativeMethodInfoPtr__DOTiling_b__1_Internal_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass26_0>.NativeClassPtr, 100663649);
			}

			// Token: 0x06000637 RID: 1591 RVA: 0x00020308 File Offset: 0x0001E508
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass26_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass26_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass26_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000638 RID: 1592 RVA: 0x00020344 File Offset: 0x0001E544
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1128299, XrefRangeEnd = 1128301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Vector2 _DOTiling_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass26_0.NativeMethodInfoPtr__DOTiling_b__0_Internal_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000639 RID: 1593 RVA: 0x00020380 File Offset: 0x0001E580
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1128301, XrefRangeEnd = 1128303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DOTiling_b__1(Vector2 x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass26_0.NativeMethodInfoPtr__DOTiling_b__1_Internal_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600063A RID: 1594 RVA: 0x00004152 File Offset: 0x00002352
			public __c__DisplayClass26_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000126 RID: 294
			// (get) Token: 0x0600063B RID: 1595 RVA: 0x000203C0 File Offset: 0x0001E5C0
			// (set) Token: 0x0600063C RID: 1596 RVA: 0x0000415B File Offset: 0x0000235B
			public unsafe Material target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass26_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass26_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000127 RID: 295
			// (get) Token: 0x0600063D RID: 1597 RVA: 0x000203F0 File Offset: 0x0001E5F0
			// (set) Token: 0x0600063E RID: 1598 RVA: 0x0000417A File Offset: 0x0000237A
			public unsafe string property
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass26_0.NativeFieldInfoPtr_property);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass26_0.NativeFieldInfoPtr_property), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x040004D1 RID: 1233
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x040004D2 RID: 1234
			private static readonly IntPtr NativeFieldInfoPtr_property;

			// Token: 0x040004D3 RID: 1235
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040004D4 RID: 1236
			private static readonly IntPtr NativeMethodInfoPtr__DOTiling_b__0_Internal_Vector2_0;

			// Token: 0x040004D5 RID: 1237
			private static readonly IntPtr NativeMethodInfoPtr__DOTiling_b__1_Internal_Void_Vector2_0;
		}

		// Token: 0x0200007E RID: 126
		[ObfuscatedName("DG.Tweening.ShortcutExtensions+<>c__DisplayClass27_0")]
		public sealed class __c__DisplayClass27_0 : global::Il2CppSystem.Object
		{
			// Token: 0x0600063F RID: 1599 RVA: 0x00020418 File Offset: 0x0001E618
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass27_0()
			{
				Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass27_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, "<>c__DisplayClass27_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass27_0>.NativeClassPtr);
				ShortcutExtensions.__c__DisplayClass27_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass27_0>.NativeClassPtr, "target");
				ShortcutExtensions.__c__DisplayClass27_0.NativeFieldInfoPtr_property = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass27_0>.NativeClassPtr, "property");
				ShortcutExtensions.__c__DisplayClass27_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass27_0>.NativeClassPtr, 100663650);
				ShortcutExtensions.__c__DisplayClass27_0.NativeMethodInfoPtr__DOVector_b__0_Internal_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass27_0>.NativeClassPtr, 100663651);
				ShortcutExtensions.__c__DisplayClass27_0.NativeMethodInfoPtr__DOVector_b__1_Internal_Void_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass27_0>.NativeClassPtr, 100663652);
			}

			// Token: 0x06000640 RID: 1600 RVA: 0x000204A8 File Offset: 0x0001E6A8
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass27_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass27_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass27_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000641 RID: 1601 RVA: 0x000204E4 File Offset: 0x0001E6E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1128303, XrefRangeEnd = 1128304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Vector4 _DOVector_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass27_0.NativeMethodInfoPtr__DOVector_b__0_Internal_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000642 RID: 1602 RVA: 0x00020520 File Offset: 0x0001E720
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1128304, XrefRangeEnd = 1128305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DOVector_b__1(Vector4 x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass27_0.NativeMethodInfoPtr__DOVector_b__1_Internal_Void_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000643 RID: 1603 RVA: 0x00004199 File Offset: 0x00002399
			public __c__DisplayClass27_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000128 RID: 296
			// (get) Token: 0x06000644 RID: 1604 RVA: 0x00020560 File Offset: 0x0001E760
			// (set) Token: 0x06000645 RID: 1605 RVA: 0x000041A2 File Offset: 0x000023A2
			public unsafe Material target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass27_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass27_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000129 RID: 297
			// (get) Token: 0x06000646 RID: 1606 RVA: 0x00020590 File Offset: 0x0001E790
			// (set) Token: 0x06000647 RID: 1607 RVA: 0x000041C1 File Offset: 0x000023C1
			public unsafe string property
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass27_0.NativeFieldInfoPtr_property);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass27_0.NativeFieldInfoPtr_property), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x040004D6 RID: 1238
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x040004D7 RID: 1239
			private static readonly IntPtr NativeFieldInfoPtr_property;

			// Token: 0x040004D8 RID: 1240
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040004D9 RID: 1241
			private static readonly IntPtr NativeMethodInfoPtr__DOVector_b__0_Internal_Vector4_0;

			// Token: 0x040004DA RID: 1242
			private static readonly IntPtr NativeMethodInfoPtr__DOVector_b__1_Internal_Void_Vector4_0;
		}

		// Token: 0x0200007F RID: 127
		[ObfuscatedName("DG.Tweening.ShortcutExtensions+<>c__DisplayClass28_0")]
		public sealed class __c__DisplayClass28_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06000648 RID: 1608 RVA: 0x000205B8 File Offset: 0x0001E7B8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass28_0()
			{
				Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass28_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, "<>c__DisplayClass28_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass28_0>.NativeClassPtr);
				ShortcutExtensions.__c__DisplayClass28_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass28_0>.NativeClassPtr, "target");
				ShortcutExtensions.__c__DisplayClass28_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass28_0>.NativeClassPtr, 100663653);
				ShortcutExtensions.__c__DisplayClass28_0.NativeMethodInfoPtr__DOMove_b__0_Internal_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass28_0>.NativeClassPtr, 100663654);
			}

			// Token: 0x06000649 RID: 1609 RVA: 0x00020620 File Offset: 0x0001E820
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass28_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass28_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass28_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600064A RID: 1610 RVA: 0x0002065C File Offset: 0x0001E85C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1128305, XrefRangeEnd = 1128306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Vector3 _DOMove_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass28_0.NativeMethodInfoPtr__DOMove_b__0_Internal_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600064B RID: 1611 RVA: 0x000041E0 File Offset: 0x000023E0
			public __c__DisplayClass28_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700012A RID: 298
			// (get) Token: 0x0600064C RID: 1612 RVA: 0x00020698 File Offset: 0x0001E898
			// (set) Token: 0x0600064D RID: 1613 RVA: 0x000041E9 File Offset: 0x000023E9
			public unsafe Rigidbody target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass28_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Rigidbody>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass28_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040004DB RID: 1243
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x040004DC RID: 1244
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040004DD RID: 1245
			private static readonly IntPtr NativeMethodInfoPtr__DOMove_b__0_Internal_Vector3_0;
		}

		// Token: 0x02000080 RID: 128
		[ObfuscatedName("DG.Tweening.ShortcutExtensions+<>c__DisplayClass29_0")]
		public sealed class __c__DisplayClass29_0 : global::Il2CppSystem.Object
		{
			// Token: 0x0600064E RID: 1614 RVA: 0x000206C8 File Offset: 0x0001E8C8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass29_0()
			{
				Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass29_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, "<>c__DisplayClass29_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass29_0>.NativeClassPtr);
				ShortcutExtensions.__c__DisplayClass29_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass29_0>.NativeClassPtr, "target");
				ShortcutExtensions.__c__DisplayClass29_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass29_0>.NativeClassPtr, 100663655);
				ShortcutExtensions.__c__DisplayClass29_0.NativeMethodInfoPtr__DOMoveX_b__0_Internal_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass29_0>.NativeClassPtr, 100663656);
			}

			// Token: 0x0600064F RID: 1615 RVA: 0x00020730 File Offset: 0x0001E930
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass29_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass29_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass29_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000650 RID: 1616 RVA: 0x0002076C File Offset: 0x0001E96C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Vector3 _DOMoveX_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass29_0.NativeMethodInfoPtr__DOMoveX_b__0_Internal_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000651 RID: 1617 RVA: 0x00004208 File Offset: 0x00002408
			public __c__DisplayClass29_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700012B RID: 299
			// (get) Token: 0x06000652 RID: 1618 RVA: 0x000207A8 File Offset: 0x0001E9A8
			// (set) Token: 0x06000653 RID: 1619 RVA: 0x00004211 File Offset: 0x00002411
			public unsafe Rigidbody target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass29_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Rigidbody>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass29_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040004DE RID: 1246
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x040004DF RID: 1247
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040004E0 RID: 1248
			private static readonly IntPtr NativeMethodInfoPtr__DOMoveX_b__0_Internal_Vector3_0;
		}

		// Token: 0x02000081 RID: 129
		[ObfuscatedName("DG.Tweening.ShortcutExtensions+<>c__DisplayClass30_0")]
		public sealed class __c__DisplayClass30_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06000654 RID: 1620 RVA: 0x000207D8 File Offset: 0x0001E9D8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass30_0()
			{
				Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass30_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, "<>c__DisplayClass30_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass30_0>.NativeClassPtr);
				ShortcutExtensions.__c__DisplayClass30_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass30_0>.NativeClassPtr, "target");
				ShortcutExtensions.__c__DisplayClass30_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass30_0>.NativeClassPtr, 100663657);
				ShortcutExtensions.__c__DisplayClass30_0.NativeMethodInfoPtr__DOMoveY_b__0_Internal_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass30_0>.NativeClassPtr, 100663658);
			}

			// Token: 0x06000655 RID: 1621 RVA: 0x00020840 File Offset: 0x0001EA40
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass30_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass30_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass30_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000656 RID: 1622 RVA: 0x0002087C File Offset: 0x0001EA7C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Vector3 _DOMoveY_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass30_0.NativeMethodInfoPtr__DOMoveY_b__0_Internal_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000657 RID: 1623 RVA: 0x00004230 File Offset: 0x00002430
			public __c__DisplayClass30_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700012C RID: 300
			// (get) Token: 0x06000658 RID: 1624 RVA: 0x000208B8 File Offset: 0x0001EAB8
			// (set) Token: 0x06000659 RID: 1625 RVA: 0x00004239 File Offset: 0x00002439
			public unsafe Rigidbody target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass30_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Rigidbody>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass30_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040004E1 RID: 1249
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x040004E2 RID: 1250
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040004E3 RID: 1251
			private static readonly IntPtr NativeMethodInfoPtr__DOMoveY_b__0_Internal_Vector3_0;
		}

		// Token: 0x02000082 RID: 130
		[ObfuscatedName("DG.Tweening.ShortcutExtensions+<>c__DisplayClass31_0")]
		public sealed class __c__DisplayClass31_0 : global::Il2CppSystem.Object
		{
			// Token: 0x0600065A RID: 1626 RVA: 0x000208E8 File Offset: 0x0001EAE8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass31_0()
			{
				Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass31_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, "<>c__DisplayClass31_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass31_0>.NativeClassPtr);
				ShortcutExtensions.__c__DisplayClass31_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass31_0>.NativeClassPtr, "target");
				ShortcutExtensions.__c__DisplayClass31_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass31_0>.NativeClassPtr, 100663659);
				ShortcutExtensions.__c__DisplayClass31_0.NativeMethodInfoPtr__DOMoveZ_b__0_Internal_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass31_0>.NativeClassPtr, 100663660);
			}

			// Token: 0x0600065B RID: 1627 RVA: 0x00020950 File Offset: 0x0001EB50
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass31_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass31_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass31_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600065C RID: 1628 RVA: 0x0002098C File Offset: 0x0001EB8C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Vector3 _DOMoveZ_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass31_0.NativeMethodInfoPtr__DOMoveZ_b__0_Internal_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600065D RID: 1629 RVA: 0x00004258 File Offset: 0x00002458
			public __c__DisplayClass31_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700012D RID: 301
			// (get) Token: 0x0600065E RID: 1630 RVA: 0x000209C8 File Offset: 0x0001EBC8
			// (set) Token: 0x0600065F RID: 1631 RVA: 0x00004261 File Offset: 0x00002461
			public unsafe Rigidbody target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass31_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Rigidbody>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass31_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040004E4 RID: 1252
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x040004E5 RID: 1253
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040004E6 RID: 1254
			private static readonly IntPtr NativeMethodInfoPtr__DOMoveZ_b__0_Internal_Vector3_0;
		}

		// Token: 0x02000083 RID: 131
		[ObfuscatedName("DG.Tweening.ShortcutExtensions+<>c__DisplayClass32_0")]
		public sealed class __c__DisplayClass32_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06000660 RID: 1632 RVA: 0x000209F8 File Offset: 0x0001EBF8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass32_0()
			{
				Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass32_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, "<>c__DisplayClass32_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass32_0>.NativeClassPtr);
				ShortcutExtensions.__c__DisplayClass32_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass32_0>.NativeClassPtr, "target");
				ShortcutExtensions.__c__DisplayClass32_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass32_0>.NativeClassPtr, 100663661);
				ShortcutExtensions.__c__DisplayClass32_0.NativeMethodInfoPtr__DORotate_b__0_Internal_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass32_0>.NativeClassPtr, 100663662);
			}

			// Token: 0x06000661 RID: 1633 RVA: 0x00020A60 File Offset: 0x0001EC60
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass32_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass32_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass32_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000662 RID: 1634 RVA: 0x00020A9C File Offset: 0x0001EC9C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1128306, XrefRangeEnd = 1128307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Quaternion _DORotate_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass32_0.NativeMethodInfoPtr__DORotate_b__0_Internal_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000663 RID: 1635 RVA: 0x00004280 File Offset: 0x00002480
			public __c__DisplayClass32_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700012E RID: 302
			// (get) Token: 0x06000664 RID: 1636 RVA: 0x00020AD8 File Offset: 0x0001ECD8
			// (set) Token: 0x06000665 RID: 1637 RVA: 0x00004289 File Offset: 0x00002489
			public unsafe Rigidbody target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass32_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Rigidbody>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass32_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040004E7 RID: 1255
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x040004E8 RID: 1256
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040004E9 RID: 1257
			private static readonly IntPtr NativeMethodInfoPtr__DORotate_b__0_Internal_Quaternion_0;
		}

		// Token: 0x02000084 RID: 132
		[ObfuscatedName("DG.Tweening.ShortcutExtensions+<>c__DisplayClass33_0")]
		public sealed class __c__DisplayClass33_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06000666 RID: 1638 RVA: 0x00020B08 File Offset: 0x0001ED08
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass33_0()
			{
				Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass33_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, "<>c__DisplayClass33_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass33_0>.NativeClassPtr);
				ShortcutExtensions.__c__DisplayClass33_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass33_0>.NativeClassPtr, "target");
				ShortcutExtensions.__c__DisplayClass33_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass33_0>.NativeClassPtr, 100663663);
				ShortcutExtensions.__c__DisplayClass33_0.NativeMethodInfoPtr__DOLookAt_b__0_Internal_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass33_0>.NativeClassPtr, 100663664);
			}

			// Token: 0x06000667 RID: 1639 RVA: 0x00020B70 File Offset: 0x0001ED70
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass33_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass33_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass33_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000668 RID: 1640 RVA: 0x00020BAC File Offset: 0x0001EDAC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Quaternion _DOLookAt_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass33_0.NativeMethodInfoPtr__DOLookAt_b__0_Internal_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000669 RID: 1641 RVA: 0x000042A8 File Offset: 0x000024A8
			public __c__DisplayClass33_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700012F RID: 303
			// (get) Token: 0x0600066A RID: 1642 RVA: 0x00020BE8 File Offset: 0x0001EDE8
			// (set) Token: 0x0600066B RID: 1643 RVA: 0x000042B1 File Offset: 0x000024B1
			public unsafe Rigidbody target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass33_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Rigidbody>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass33_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040004EA RID: 1258
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x040004EB RID: 1259
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040004EC RID: 1260
			private static readonly IntPtr NativeMethodInfoPtr__DOLookAt_b__0_Internal_Quaternion_0;
		}

		// Token: 0x02000085 RID: 133
		[ObfuscatedName("DG.Tweening.ShortcutExtensions+<>c__DisplayClass34_0")]
		public sealed class __c__DisplayClass34_0 : global::Il2CppSystem.Object
		{
			// Token: 0x0600066C RID: 1644 RVA: 0x00020C18 File Offset: 0x0001EE18
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass34_0()
			{
				Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass34_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, "<>c__DisplayClass34_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass34_0>.NativeClassPtr);
				ShortcutExtensions.__c__DisplayClass34_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass34_0>.NativeClassPtr, "target");
				ShortcutExtensions.__c__DisplayClass34_0.NativeFieldInfoPtr_offsetYSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass34_0>.NativeClassPtr, "offsetYSet");
				ShortcutExtensions.__c__DisplayClass34_0.NativeFieldInfoPtr_offsetY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass34_0>.NativeClassPtr, "offsetY");
				ShortcutExtensions.__c__DisplayClass34_0.NativeFieldInfoPtr_s = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass34_0>.NativeClassPtr, "s");
				ShortcutExtensions.__c__DisplayClass34_0.NativeFieldInfoPtr_endValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass34_0>.NativeClassPtr, "endValue");
				ShortcutExtensions.__c__DisplayClass34_0.NativeFieldInfoPtr_startPosY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass34_0>.NativeClassPtr, "startPosY");
				ShortcutExtensions.__c__DisplayClass34_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass34_0>.NativeClassPtr, 100663665);
				ShortcutExtensions.__c__DisplayClass34_0.NativeMethodInfoPtr__DOJump_b__0_Internal_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass34_0>.NativeClassPtr, 100663666);
				ShortcutExtensions.__c__DisplayClass34_0.NativeMethodInfoPtr__DOJump_b__1_Internal_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass34_0>.NativeClassPtr, 100663667);
				ShortcutExtensions.__c__DisplayClass34_0.NativeMethodInfoPtr__DOJump_b__2_Internal_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass34_0>.NativeClassPtr, 100663668);
				ShortcutExtensions.__c__DisplayClass34_0.NativeMethodInfoPtr__DOJump_b__3_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass34_0>.NativeClassPtr, 100663669);
			}

			// Token: 0x0600066D RID: 1645 RVA: 0x00020D20 File Offset: 0x0001EF20
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass34_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass34_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass34_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600066E RID: 1646 RVA: 0x00020D5C File Offset: 0x0001EF5C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Vector3 _DOJump_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass34_0.NativeMethodInfoPtr__DOJump_b__0_Internal_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600066F RID: 1647 RVA: 0x00020D98 File Offset: 0x0001EF98
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Vector3 _DOJump_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass34_0.NativeMethodInfoPtr__DOJump_b__1_Internal_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000670 RID: 1648 RVA: 0x00020DD4 File Offset: 0x0001EFD4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Vector3 _DOJump_b__2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass34_0.NativeMethodInfoPtr__DOJump_b__2_Internal_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000671 RID: 1649 RVA: 0x00020E10 File Offset: 0x0001F010
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1128307, XrefRangeEnd = 1128311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DOJump_b__3()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass34_0.NativeMethodInfoPtr__DOJump_b__3_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000672 RID: 1650 RVA: 0x000042D0 File Offset: 0x000024D0
			public __c__DisplayClass34_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000130 RID: 304
			// (get) Token: 0x06000673 RID: 1651 RVA: 0x00020E44 File Offset: 0x0001F044
			// (set) Token: 0x06000674 RID: 1652 RVA: 0x000042D9 File Offset: 0x000024D9
			public unsafe Rigidbody target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass34_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Rigidbody>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass34_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000131 RID: 305
			// (get) Token: 0x06000675 RID: 1653 RVA: 0x00020E74 File Offset: 0x0001F074
			// (set) Token: 0x06000676 RID: 1654 RVA: 0x000042F8 File Offset: 0x000024F8
			public unsafe bool offsetYSet
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass34_0.NativeFieldInfoPtr_offsetYSet);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass34_0.NativeFieldInfoPtr_offsetYSet)) = value;
				}
			}

			// Token: 0x17000132 RID: 306
			// (get) Token: 0x06000677 RID: 1655 RVA: 0x00020E9C File Offset: 0x0001F09C
			// (set) Token: 0x06000678 RID: 1656 RVA: 0x00004313 File Offset: 0x00002513
			public unsafe float offsetY
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass34_0.NativeFieldInfoPtr_offsetY);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass34_0.NativeFieldInfoPtr_offsetY)) = value;
				}
			}

			// Token: 0x17000133 RID: 307
			// (get) Token: 0x06000679 RID: 1657 RVA: 0x00020EC4 File Offset: 0x0001F0C4
			// (set) Token: 0x0600067A RID: 1658 RVA: 0x0000432E File Offset: 0x0000252E
			public unsafe Sequence s
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass34_0.NativeFieldInfoPtr_s);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sequence>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass34_0.NativeFieldInfoPtr_s), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000134 RID: 308
			// (get) Token: 0x0600067B RID: 1659 RVA: 0x00020EF4 File Offset: 0x0001F0F4
			// (set) Token: 0x0600067C RID: 1660 RVA: 0x0000434D File Offset: 0x0000254D
			public unsafe Vector3 endValue
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass34_0.NativeFieldInfoPtr_endValue);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass34_0.NativeFieldInfoPtr_endValue)) = value;
				}
			}

			// Token: 0x17000135 RID: 309
			// (get) Token: 0x0600067D RID: 1661 RVA: 0x00020F1C File Offset: 0x0001F11C
			// (set) Token: 0x0600067E RID: 1662 RVA: 0x00004368 File Offset: 0x00002568
			public unsafe float startPosY
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass34_0.NativeFieldInfoPtr_startPosY);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass34_0.NativeFieldInfoPtr_startPosY)) = value;
				}
			}

			// Token: 0x040004ED RID: 1261
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x040004EE RID: 1262
			private static readonly IntPtr NativeFieldInfoPtr_offsetYSet;

			// Token: 0x040004EF RID: 1263
			private static readonly IntPtr NativeFieldInfoPtr_offsetY;

			// Token: 0x040004F0 RID: 1264
			private static readonly IntPtr NativeFieldInfoPtr_s;

			// Token: 0x040004F1 RID: 1265
			private static readonly IntPtr NativeFieldInfoPtr_endValue;

			// Token: 0x040004F2 RID: 1266
			private static readonly IntPtr NativeFieldInfoPtr_startPosY;

			// Token: 0x040004F3 RID: 1267
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040004F4 RID: 1268
			private static readonly IntPtr NativeMethodInfoPtr__DOJump_b__0_Internal_Vector3_0;

			// Token: 0x040004F5 RID: 1269
			private static readonly IntPtr NativeMethodInfoPtr__DOJump_b__1_Internal_Vector3_0;

			// Token: 0x040004F6 RID: 1270
			private static readonly IntPtr NativeMethodInfoPtr__DOJump_b__2_Internal_Vector3_0;

			// Token: 0x040004F7 RID: 1271
			private static readonly IntPtr NativeMethodInfoPtr__DOJump_b__3_Internal_Void_0;
		}

		// Token: 0x02000086 RID: 134
		[ObfuscatedName("DG.Tweening.ShortcutExtensions+<>c__DisplayClass35_0")]
		public sealed class __c__DisplayClass35_0 : global::Il2CppSystem.Object
		{
			// Token: 0x0600067F RID: 1663 RVA: 0x00020F44 File Offset: 0x0001F144
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass35_0()
			{
				Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass35_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, "<>c__DisplayClass35_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass35_0>.NativeClassPtr);
				ShortcutExtensions.__c__DisplayClass35_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass35_0>.NativeClassPtr, "target");
				ShortcutExtensions.__c__DisplayClass35_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass35_0>.NativeClassPtr, 100663670);
				ShortcutExtensions.__c__DisplayClass35_0.NativeMethodInfoPtr__DOPath_b__0_Internal_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass35_0>.NativeClassPtr, 100663671);
			}

			// Token: 0x06000680 RID: 1664 RVA: 0x00020FAC File Offset: 0x0001F1AC
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass35_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass35_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass35_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000681 RID: 1665 RVA: 0x00020FE8 File Offset: 0x0001F1E8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Vector3 _DOPath_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass35_0.NativeMethodInfoPtr__DOPath_b__0_Internal_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000682 RID: 1666 RVA: 0x00004383 File Offset: 0x00002583
			public __c__DisplayClass35_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000136 RID: 310
			// (get) Token: 0x06000683 RID: 1667 RVA: 0x00021024 File Offset: 0x0001F224
			// (set) Token: 0x06000684 RID: 1668 RVA: 0x0000438C File Offset: 0x0000258C
			public unsafe Rigidbody target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass35_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Rigidbody>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass35_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040004F8 RID: 1272
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x040004F9 RID: 1273
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040004FA RID: 1274
			private static readonly IntPtr NativeMethodInfoPtr__DOPath_b__0_Internal_Vector3_0;
		}

		// Token: 0x02000087 RID: 135
		[ObfuscatedName("DG.Tweening.ShortcutExtensions+<>c__DisplayClass36_0")]
		public sealed class __c__DisplayClass36_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06000685 RID: 1669 RVA: 0x00021054 File Offset: 0x0001F254
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass36_0()
			{
				Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass36_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, "<>c__DisplayClass36_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass36_0>.NativeClassPtr);
				ShortcutExtensions.__c__DisplayClass36_0.NativeFieldInfoPtr_trans = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass36_0>.NativeClassPtr, "trans");
				ShortcutExtensions.__c__DisplayClass36_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass36_0>.NativeClassPtr, "target");
				ShortcutExtensions.__c__DisplayClass36_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass36_0>.NativeClassPtr, 100663672);
				ShortcutExtensions.__c__DisplayClass36_0.NativeMethodInfoPtr__DOLocalPath_b__0_Internal_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass36_0>.NativeClassPtr, 100663673);
				ShortcutExtensions.__c__DisplayClass36_0.NativeMethodInfoPtr__DOLocalPath_b__1_Internal_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass36_0>.NativeClassPtr, 100663674);
			}

			// Token: 0x06000686 RID: 1670 RVA: 0x000210E4 File Offset: 0x0001F2E4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass36_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass36_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass36_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000687 RID: 1671 RVA: 0x00021120 File Offset: 0x0001F320
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1128311, XrefRangeEnd = 1128312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Vector3 _DOLocalPath_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass36_0.NativeMethodInfoPtr__DOLocalPath_b__0_Internal_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000688 RID: 1672 RVA: 0x0002115C File Offset: 0x0001F35C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1128312, XrefRangeEnd = 1128321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DOLocalPath_b__1(Vector3 x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass36_0.NativeMethodInfoPtr__DOLocalPath_b__1_Internal_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000689 RID: 1673 RVA: 0x000043AB File Offset: 0x000025AB
			public __c__DisplayClass36_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000137 RID: 311
			// (get) Token: 0x0600068A RID: 1674 RVA: 0x0002119C File Offset: 0x0001F39C
			// (set) Token: 0x0600068B RID: 1675 RVA: 0x000043B4 File Offset: 0x000025B4
			public unsafe Transform trans
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass36_0.NativeFieldInfoPtr_trans);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass36_0.NativeFieldInfoPtr_trans), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000138 RID: 312
			// (get) Token: 0x0600068C RID: 1676 RVA: 0x000211CC File Offset: 0x0001F3CC
			// (set) Token: 0x0600068D RID: 1677 RVA: 0x000043D3 File Offset: 0x000025D3
			public unsafe Rigidbody target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass36_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Rigidbody>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass36_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040004FB RID: 1275
			private static readonly IntPtr NativeFieldInfoPtr_trans;

			// Token: 0x040004FC RID: 1276
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x040004FD RID: 1277
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040004FE RID: 1278
			private static readonly IntPtr NativeMethodInfoPtr__DOLocalPath_b__0_Internal_Vector3_0;

			// Token: 0x040004FF RID: 1279
			private static readonly IntPtr NativeMethodInfoPtr__DOLocalPath_b__1_Internal_Void_Vector3_0;
		}

		// Token: 0x02000088 RID: 136
		[ObfuscatedName("DG.Tweening.ShortcutExtensions+<>c__DisplayClass37_0")]
		public sealed class __c__DisplayClass37_0 : global::Il2CppSystem.Object
		{
			// Token: 0x0600068E RID: 1678 RVA: 0x000211FC File Offset: 0x0001F3FC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass37_0()
			{
				Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass37_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, "<>c__DisplayClass37_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass37_0>.NativeClassPtr);
				ShortcutExtensions.__c__DisplayClass37_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass37_0>.NativeClassPtr, "target");
				ShortcutExtensions.__c__DisplayClass37_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass37_0>.NativeClassPtr, 100663675);
				ShortcutExtensions.__c__DisplayClass37_0.NativeMethodInfoPtr__DOPath_b__0_Internal_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass37_0>.NativeClassPtr, 100663676);
			}

			// Token: 0x0600068F RID: 1679 RVA: 0x00021264 File Offset: 0x0001F464
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass37_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass37_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass37_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000690 RID: 1680 RVA: 0x000212A0 File Offset: 0x0001F4A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Vector3 _DOPath_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass37_0.NativeMethodInfoPtr__DOPath_b__0_Internal_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000691 RID: 1681 RVA: 0x000043F2 File Offset: 0x000025F2
			public __c__DisplayClass37_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000139 RID: 313
			// (get) Token: 0x06000692 RID: 1682 RVA: 0x000212DC File Offset: 0x0001F4DC
			// (set) Token: 0x06000693 RID: 1683 RVA: 0x000043FB File Offset: 0x000025FB
			public unsafe Rigidbody target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass37_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Rigidbody>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass37_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000500 RID: 1280
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x04000501 RID: 1281
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000502 RID: 1282
			private static readonly IntPtr NativeMethodInfoPtr__DOPath_b__0_Internal_Vector3_0;
		}

		// Token: 0x02000089 RID: 137
		[ObfuscatedName("DG.Tweening.ShortcutExtensions+<>c__DisplayClass38_0")]
		public sealed class __c__DisplayClass38_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06000694 RID: 1684 RVA: 0x0002130C File Offset: 0x0001F50C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass38_0()
			{
				Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass38_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, "<>c__DisplayClass38_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass38_0>.NativeClassPtr);
				ShortcutExtensions.__c__DisplayClass38_0.NativeFieldInfoPtr_trans = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass38_0>.NativeClassPtr, "trans");
				ShortcutExtensions.__c__DisplayClass38_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass38_0>.NativeClassPtr, "target");
				ShortcutExtensions.__c__DisplayClass38_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass38_0>.NativeClassPtr, 100663677);
				ShortcutExtensions.__c__DisplayClass38_0.NativeMethodInfoPtr__DOLocalPath_b__0_Internal_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass38_0>.NativeClassPtr, 100663678);
				ShortcutExtensions.__c__DisplayClass38_0.NativeMethodInfoPtr__DOLocalPath_b__1_Internal_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass38_0>.NativeClassPtr, 100663679);
			}

			// Token: 0x06000695 RID: 1685 RVA: 0x0002139C File Offset: 0x0001F59C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass38_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass38_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass38_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000696 RID: 1686 RVA: 0x000213D8 File Offset: 0x0001F5D8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Vector3 _DOLocalPath_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass38_0.NativeMethodInfoPtr__DOLocalPath_b__0_Internal_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000697 RID: 1687 RVA: 0x00021414 File Offset: 0x0001F614
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1128321, XrefRangeEnd = 1128330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DOLocalPath_b__1(Vector3 x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass38_0.NativeMethodInfoPtr__DOLocalPath_b__1_Internal_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000698 RID: 1688 RVA: 0x0000441A File Offset: 0x0000261A
			public __c__DisplayClass38_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700013A RID: 314
			// (get) Token: 0x06000699 RID: 1689 RVA: 0x00021454 File Offset: 0x0001F654
			// (set) Token: 0x0600069A RID: 1690 RVA: 0x00004423 File Offset: 0x00002623
			public unsafe Transform trans
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass38_0.NativeFieldInfoPtr_trans);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass38_0.NativeFieldInfoPtr_trans), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700013B RID: 315
			// (get) Token: 0x0600069B RID: 1691 RVA: 0x00021484 File Offset: 0x0001F684
			// (set) Token: 0x0600069C RID: 1692 RVA: 0x00004442 File Offset: 0x00002642
			public unsafe Rigidbody target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass38_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Rigidbody>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass38_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000503 RID: 1283
			private static readonly IntPtr NativeFieldInfoPtr_trans;

			// Token: 0x04000504 RID: 1284
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x04000505 RID: 1285
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000506 RID: 1286
			private static readonly IntPtr NativeMethodInfoPtr__DOLocalPath_b__0_Internal_Vector3_0;

			// Token: 0x04000507 RID: 1287
			private static readonly IntPtr NativeMethodInfoPtr__DOLocalPath_b__1_Internal_Void_Vector3_0;
		}

		// Token: 0x0200008A RID: 138
		[ObfuscatedName("DG.Tweening.ShortcutExtensions+<>c__DisplayClass39_0")]
		public sealed class __c__DisplayClass39_0 : global::Il2CppSystem.Object
		{
			// Token: 0x0600069D RID: 1693 RVA: 0x000214B4 File Offset: 0x0001F6B4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass39_0()
			{
				Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass39_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, "<>c__DisplayClass39_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass39_0>.NativeClassPtr);
				ShortcutExtensions.__c__DisplayClass39_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass39_0>.NativeClassPtr, "target");
				ShortcutExtensions.__c__DisplayClass39_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass39_0>.NativeClassPtr, 100663680);
				ShortcutExtensions.__c__DisplayClass39_0.NativeMethodInfoPtr__DOResize_b__0_Internal_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass39_0>.NativeClassPtr, 100663681);
				ShortcutExtensions.__c__DisplayClass39_0.NativeMethodInfoPtr__DOResize_b__1_Internal_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass39_0>.NativeClassPtr, 100663682);
			}

			// Token: 0x0600069E RID: 1694 RVA: 0x00021530 File Offset: 0x0001F730
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass39_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass39_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass39_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600069F RID: 1695 RVA: 0x0002156C File Offset: 0x0001F76C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1128330, XrefRangeEnd = 1128332, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Vector2 _DOResize_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass39_0.NativeMethodInfoPtr__DOResize_b__0_Internal_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060006A0 RID: 1696 RVA: 0x000215A8 File Offset: 0x0001F7A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1128332, XrefRangeEnd = 1128335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DOResize_b__1(Vector2 x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass39_0.NativeMethodInfoPtr__DOResize_b__1_Internal_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060006A1 RID: 1697 RVA: 0x00004461 File Offset: 0x00002661
			public __c__DisplayClass39_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700013C RID: 316
			// (get) Token: 0x060006A2 RID: 1698 RVA: 0x000215E8 File Offset: 0x0001F7E8
			// (set) Token: 0x060006A3 RID: 1699 RVA: 0x0000446A File Offset: 0x0000266A
			public unsafe TrailRenderer target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass39_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TrailRenderer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass39_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000508 RID: 1288
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x04000509 RID: 1289
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400050A RID: 1290
			private static readonly IntPtr NativeMethodInfoPtr__DOResize_b__0_Internal_Vector2_0;

			// Token: 0x0400050B RID: 1291
			private static readonly IntPtr NativeMethodInfoPtr__DOResize_b__1_Internal_Void_Vector2_0;
		}

		// Token: 0x0200008B RID: 139
		[ObfuscatedName("DG.Tweening.ShortcutExtensions+<>c__DisplayClass40_0")]
		public sealed class __c__DisplayClass40_0 : global::Il2CppSystem.Object
		{
			// Token: 0x060006A4 RID: 1700 RVA: 0x00021618 File Offset: 0x0001F818
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass40_0()
			{
				Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass40_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, "<>c__DisplayClass40_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass40_0>.NativeClassPtr);
				ShortcutExtensions.__c__DisplayClass40_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass40_0>.NativeClassPtr, "target");
				ShortcutExtensions.__c__DisplayClass40_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass40_0>.NativeClassPtr, 100663683);
				ShortcutExtensions.__c__DisplayClass40_0.NativeMethodInfoPtr__DOTime_b__0_Internal_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass40_0>.NativeClassPtr, 100663684);
				ShortcutExtensions.__c__DisplayClass40_0.NativeMethodInfoPtr__DOTime_b__1_Internal_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass40_0>.NativeClassPtr, 100663685);
			}

			// Token: 0x060006A5 RID: 1701 RVA: 0x00021694 File Offset: 0x0001F894
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass40_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass40_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass40_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060006A6 RID: 1702 RVA: 0x000216D0 File Offset: 0x0001F8D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1128335, XrefRangeEnd = 1128337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _DOTime_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass40_0.NativeMethodInfoPtr__DOTime_b__0_Internal_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060006A7 RID: 1703 RVA: 0x0002170C File Offset: 0x0001F90C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1128337, XrefRangeEnd = 1128339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DOTime_b__1(float x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass40_0.NativeMethodInfoPtr__DOTime_b__1_Internal_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060006A8 RID: 1704 RVA: 0x00004489 File Offset: 0x00002689
			public __c__DisplayClass40_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700013D RID: 317
			// (get) Token: 0x060006A9 RID: 1705 RVA: 0x0002174C File Offset: 0x0001F94C
			// (set) Token: 0x060006AA RID: 1706 RVA: 0x00004492 File Offset: 0x00002692
			public unsafe TrailRenderer target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass40_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TrailRenderer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass40_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400050C RID: 1292
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x0400050D RID: 1293
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400050E RID: 1294
			private static readonly IntPtr NativeMethodInfoPtr__DOTime_b__0_Internal_Single_0;

			// Token: 0x0400050F RID: 1295
			private static readonly IntPtr NativeMethodInfoPtr__DOTime_b__1_Internal_Void_Single_0;
		}

		// Token: 0x0200008C RID: 140
		[ObfuscatedName("DG.Tweening.ShortcutExtensions+<>c__DisplayClass41_0")]
		public sealed class __c__DisplayClass41_0 : global::Il2CppSystem.Object
		{
			// Token: 0x060006AB RID: 1707 RVA: 0x0002177C File Offset: 0x0001F97C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass41_0()
			{
				Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass41_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, "<>c__DisplayClass41_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass41_0>.NativeClassPtr);
				ShortcutExtensions.__c__DisplayClass41_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass41_0>.NativeClassPtr, "target");
				ShortcutExtensions.__c__DisplayClass41_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass41_0>.NativeClassPtr, 100663686);
				ShortcutExtensions.__c__DisplayClass41_0.NativeMethodInfoPtr__DOMove_b__0_Internal_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass41_0>.NativeClassPtr, 100663687);
				ShortcutExtensions.__c__DisplayClass41_0.NativeMethodInfoPtr__DOMove_b__1_Internal_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass41_0>.NativeClassPtr, 100663688);
			}

			// Token: 0x060006AC RID: 1708 RVA: 0x000217F8 File Offset: 0x0001F9F8
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass41_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass41_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass41_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060006AD RID: 1709 RVA: 0x00021834 File Offset: 0x0001FA34
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1128339, XrefRangeEnd = 1128340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Vector3 _DOMove_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass41_0.NativeMethodInfoPtr__DOMove_b__0_Internal_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060006AE RID: 1710 RVA: 0x00021870 File Offset: 0x0001FA70
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1128340, XrefRangeEnd = 1128341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DOMove_b__1(Vector3 x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass41_0.NativeMethodInfoPtr__DOMove_b__1_Internal_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060006AF RID: 1711 RVA: 0x000044B1 File Offset: 0x000026B1
			public __c__DisplayClass41_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700013E RID: 318
			// (get) Token: 0x060006B0 RID: 1712 RVA: 0x000218B0 File Offset: 0x0001FAB0
			// (set) Token: 0x060006B1 RID: 1713 RVA: 0x000044BA File Offset: 0x000026BA
			public unsafe Transform target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass41_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass41_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000510 RID: 1296
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x04000511 RID: 1297
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000512 RID: 1298
			private static readonly IntPtr NativeMethodInfoPtr__DOMove_b__0_Internal_Vector3_0;

			// Token: 0x04000513 RID: 1299
			private static readonly IntPtr NativeMethodInfoPtr__DOMove_b__1_Internal_Void_Vector3_0;
		}

		// Token: 0x0200008D RID: 141
		[ObfuscatedName("DG.Tweening.ShortcutExtensions+<>c__DisplayClass42_0")]
		public sealed class __c__DisplayClass42_0 : global::Il2CppSystem.Object
		{
			// Token: 0x060006B2 RID: 1714 RVA: 0x000218E0 File Offset: 0x0001FAE0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass42_0()
			{
				Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass42_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, "<>c__DisplayClass42_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass42_0>.NativeClassPtr);
				ShortcutExtensions.__c__DisplayClass42_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass42_0>.NativeClassPtr, "target");
				ShortcutExtensions.__c__DisplayClass42_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass42_0>.NativeClassPtr, 100663689);
				ShortcutExtensions.__c__DisplayClass42_0.NativeMethodInfoPtr__DOMoveX_b__0_Internal_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass42_0>.NativeClassPtr, 100663690);
				ShortcutExtensions.__c__DisplayClass42_0.NativeMethodInfoPtr__DOMoveX_b__1_Internal_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass42_0>.NativeClassPtr, 100663691);
			}

			// Token: 0x060006B3 RID: 1715 RVA: 0x0002195C File Offset: 0x0001FB5C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass42_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass42_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass42_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060006B4 RID: 1716 RVA: 0x00021998 File Offset: 0x0001FB98
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Vector3 _DOMoveX_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass42_0.NativeMethodInfoPtr__DOMoveX_b__0_Internal_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060006B5 RID: 1717 RVA: 0x000219D4 File Offset: 0x0001FBD4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DOMoveX_b__1(Vector3 x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass42_0.NativeMethodInfoPtr__DOMoveX_b__1_Internal_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060006B6 RID: 1718 RVA: 0x000044D9 File Offset: 0x000026D9
			public __c__DisplayClass42_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700013F RID: 319
			// (get) Token: 0x060006B7 RID: 1719 RVA: 0x00021A14 File Offset: 0x0001FC14
			// (set) Token: 0x060006B8 RID: 1720 RVA: 0x000044E2 File Offset: 0x000026E2
			public unsafe Transform target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass42_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass42_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000514 RID: 1300
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x04000515 RID: 1301
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000516 RID: 1302
			private static readonly IntPtr NativeMethodInfoPtr__DOMoveX_b__0_Internal_Vector3_0;

			// Token: 0x04000517 RID: 1303
			private static readonly IntPtr NativeMethodInfoPtr__DOMoveX_b__1_Internal_Void_Vector3_0;
		}

		// Token: 0x0200008E RID: 142
		[ObfuscatedName("DG.Tweening.ShortcutExtensions+<>c__DisplayClass43_0")]
		public sealed class __c__DisplayClass43_0 : global::Il2CppSystem.Object
		{
			// Token: 0x060006B9 RID: 1721 RVA: 0x00021A44 File Offset: 0x0001FC44
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass43_0()
			{
				Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass43_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, "<>c__DisplayClass43_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass43_0>.NativeClassPtr);
				ShortcutExtensions.__c__DisplayClass43_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass43_0>.NativeClassPtr, "target");
				ShortcutExtensions.__c__DisplayClass43_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass43_0>.NativeClassPtr, 100663692);
				ShortcutExtensions.__c__DisplayClass43_0.NativeMethodInfoPtr__DOMoveY_b__0_Internal_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass43_0>.NativeClassPtr, 100663693);
				ShortcutExtensions.__c__DisplayClass43_0.NativeMethodInfoPtr__DOMoveY_b__1_Internal_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass43_0>.NativeClassPtr, 100663694);
			}

			// Token: 0x060006BA RID: 1722 RVA: 0x00021AC0 File Offset: 0x0001FCC0
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass43_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass43_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass43_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060006BB RID: 1723 RVA: 0x00021AFC File Offset: 0x0001FCFC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Vector3 _DOMoveY_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass43_0.NativeMethodInfoPtr__DOMoveY_b__0_Internal_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060006BC RID: 1724 RVA: 0x00021B38 File Offset: 0x0001FD38
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DOMoveY_b__1(Vector3 x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass43_0.NativeMethodInfoPtr__DOMoveY_b__1_Internal_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060006BD RID: 1725 RVA: 0x00004501 File Offset: 0x00002701
			public __c__DisplayClass43_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000140 RID: 320
			// (get) Token: 0x060006BE RID: 1726 RVA: 0x00021B78 File Offset: 0x0001FD78
			// (set) Token: 0x060006BF RID: 1727 RVA: 0x0000450A File Offset: 0x0000270A
			public unsafe Transform target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass43_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass43_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000518 RID: 1304
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x04000519 RID: 1305
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400051A RID: 1306
			private static readonly IntPtr NativeMethodInfoPtr__DOMoveY_b__0_Internal_Vector3_0;

			// Token: 0x0400051B RID: 1307
			private static readonly IntPtr NativeMethodInfoPtr__DOMoveY_b__1_Internal_Void_Vector3_0;
		}

		// Token: 0x0200008F RID: 143
		[ObfuscatedName("DG.Tweening.ShortcutExtensions+<>c__DisplayClass44_0")]
		public sealed class __c__DisplayClass44_0 : global::Il2CppSystem.Object
		{
			// Token: 0x060006C0 RID: 1728 RVA: 0x00021BA8 File Offset: 0x0001FDA8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass44_0()
			{
				Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass44_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, "<>c__DisplayClass44_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass44_0>.NativeClassPtr);
				ShortcutExtensions.__c__DisplayClass44_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass44_0>.NativeClassPtr, "target");
				ShortcutExtensions.__c__DisplayClass44_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass44_0>.NativeClassPtr, 100663695);
				ShortcutExtensions.__c__DisplayClass44_0.NativeMethodInfoPtr__DOMoveZ_b__0_Internal_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass44_0>.NativeClassPtr, 100663696);
				ShortcutExtensions.__c__DisplayClass44_0.NativeMethodInfoPtr__DOMoveZ_b__1_Internal_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass44_0>.NativeClassPtr, 100663697);
			}

			// Token: 0x060006C1 RID: 1729 RVA: 0x00021C24 File Offset: 0x0001FE24
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass44_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass44_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass44_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060006C2 RID: 1730 RVA: 0x00021C60 File Offset: 0x0001FE60
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Vector3 _DOMoveZ_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass44_0.NativeMethodInfoPtr__DOMoveZ_b__0_Internal_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060006C3 RID: 1731 RVA: 0x00021C9C File Offset: 0x0001FE9C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DOMoveZ_b__1(Vector3 x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass44_0.NativeMethodInfoPtr__DOMoveZ_b__1_Internal_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060006C4 RID: 1732 RVA: 0x00004529 File Offset: 0x00002729
			public __c__DisplayClass44_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000141 RID: 321
			// (get) Token: 0x060006C5 RID: 1733 RVA: 0x00021CDC File Offset: 0x0001FEDC
			// (set) Token: 0x060006C6 RID: 1734 RVA: 0x00004532 File Offset: 0x00002732
			public unsafe Transform target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass44_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass44_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400051C RID: 1308
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x0400051D RID: 1309
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400051E RID: 1310
			private static readonly IntPtr NativeMethodInfoPtr__DOMoveZ_b__0_Internal_Vector3_0;

			// Token: 0x0400051F RID: 1311
			private static readonly IntPtr NativeMethodInfoPtr__DOMoveZ_b__1_Internal_Void_Vector3_0;
		}

		// Token: 0x02000090 RID: 144
		[ObfuscatedName("DG.Tweening.ShortcutExtensions+<>c__DisplayClass45_0")]
		public sealed class __c__DisplayClass45_0 : global::Il2CppSystem.Object
		{
			// Token: 0x060006C7 RID: 1735 RVA: 0x00021D0C File Offset: 0x0001FF0C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass45_0()
			{
				Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass45_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, "<>c__DisplayClass45_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass45_0>.NativeClassPtr);
				ShortcutExtensions.__c__DisplayClass45_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass45_0>.NativeClassPtr, "target");
				ShortcutExtensions.__c__DisplayClass45_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass45_0>.NativeClassPtr, 100663698);
				ShortcutExtensions.__c__DisplayClass45_0.NativeMethodInfoPtr__DOLocalMove_b__0_Internal_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass45_0>.NativeClassPtr, 100663699);
				ShortcutExtensions.__c__DisplayClass45_0.NativeMethodInfoPtr__DOLocalMove_b__1_Internal_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass45_0>.NativeClassPtr, 100663700);
			}

			// Token: 0x060006C8 RID: 1736 RVA: 0x00021D88 File Offset: 0x0001FF88
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass45_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass45_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass45_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060006C9 RID: 1737 RVA: 0x00021DC4 File Offset: 0x0001FFC4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Vector3 _DOLocalMove_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass45_0.NativeMethodInfoPtr__DOLocalMove_b__0_Internal_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060006CA RID: 1738 RVA: 0x00021E00 File Offset: 0x00020000
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1128341, XrefRangeEnd = 1128342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DOLocalMove_b__1(Vector3 x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass45_0.NativeMethodInfoPtr__DOLocalMove_b__1_Internal_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060006CB RID: 1739 RVA: 0x00004551 File Offset: 0x00002751
			public __c__DisplayClass45_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000142 RID: 322
			// (get) Token: 0x060006CC RID: 1740 RVA: 0x00021E40 File Offset: 0x00020040
			// (set) Token: 0x060006CD RID: 1741 RVA: 0x0000455A File Offset: 0x0000275A
			public unsafe Transform target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass45_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass45_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000520 RID: 1312
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x04000521 RID: 1313
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000522 RID: 1314
			private static readonly IntPtr NativeMethodInfoPtr__DOLocalMove_b__0_Internal_Vector3_0;

			// Token: 0x04000523 RID: 1315
			private static readonly IntPtr NativeMethodInfoPtr__DOLocalMove_b__1_Internal_Void_Vector3_0;
		}

		// Token: 0x02000091 RID: 145
		[ObfuscatedName("DG.Tweening.ShortcutExtensions+<>c__DisplayClass46_0")]
		public sealed class __c__DisplayClass46_0 : global::Il2CppSystem.Object
		{
			// Token: 0x060006CE RID: 1742 RVA: 0x00021E70 File Offset: 0x00020070
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass46_0()
			{
				Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass46_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, "<>c__DisplayClass46_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass46_0>.NativeClassPtr);
				ShortcutExtensions.__c__DisplayClass46_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass46_0>.NativeClassPtr, "target");
				ShortcutExtensions.__c__DisplayClass46_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass46_0>.NativeClassPtr, 100663701);
				ShortcutExtensions.__c__DisplayClass46_0.NativeMethodInfoPtr__DOLocalMoveX_b__0_Internal_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass46_0>.NativeClassPtr, 100663702);
				ShortcutExtensions.__c__DisplayClass46_0.NativeMethodInfoPtr__DOLocalMoveX_b__1_Internal_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass46_0>.NativeClassPtr, 100663703);
			}

			// Token: 0x060006CF RID: 1743 RVA: 0x00021EEC File Offset: 0x000200EC
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass46_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass46_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass46_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060006D0 RID: 1744 RVA: 0x00021F28 File Offset: 0x00020128
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Vector3 _DOLocalMoveX_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass46_0.NativeMethodInfoPtr__DOLocalMoveX_b__0_Internal_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060006D1 RID: 1745 RVA: 0x00021F64 File Offset: 0x00020164
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DOLocalMoveX_b__1(Vector3 x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass46_0.NativeMethodInfoPtr__DOLocalMoveX_b__1_Internal_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060006D2 RID: 1746 RVA: 0x00004579 File Offset: 0x00002779
			public __c__DisplayClass46_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000143 RID: 323
			// (get) Token: 0x060006D3 RID: 1747 RVA: 0x00021FA4 File Offset: 0x000201A4
			// (set) Token: 0x060006D4 RID: 1748 RVA: 0x00004582 File Offset: 0x00002782
			public unsafe Transform target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass46_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass46_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000524 RID: 1316
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x04000525 RID: 1317
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000526 RID: 1318
			private static readonly IntPtr NativeMethodInfoPtr__DOLocalMoveX_b__0_Internal_Vector3_0;

			// Token: 0x04000527 RID: 1319
			private static readonly IntPtr NativeMethodInfoPtr__DOLocalMoveX_b__1_Internal_Void_Vector3_0;
		}

		// Token: 0x02000092 RID: 146
		[ObfuscatedName("DG.Tweening.ShortcutExtensions+<>c__DisplayClass47_0")]
		public sealed class __c__DisplayClass47_0 : global::Il2CppSystem.Object
		{
			// Token: 0x060006D5 RID: 1749 RVA: 0x00021FD4 File Offset: 0x000201D4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass47_0()
			{
				Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass47_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, "<>c__DisplayClass47_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass47_0>.NativeClassPtr);
				ShortcutExtensions.__c__DisplayClass47_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass47_0>.NativeClassPtr, "target");
				ShortcutExtensions.__c__DisplayClass47_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass47_0>.NativeClassPtr, 100663704);
				ShortcutExtensions.__c__DisplayClass47_0.NativeMethodInfoPtr__DOLocalMoveY_b__0_Internal_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass47_0>.NativeClassPtr, 100663705);
				ShortcutExtensions.__c__DisplayClass47_0.NativeMethodInfoPtr__DOLocalMoveY_b__1_Internal_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass47_0>.NativeClassPtr, 100663706);
			}

			// Token: 0x060006D6 RID: 1750 RVA: 0x00022050 File Offset: 0x00020250
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass47_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass47_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass47_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060006D7 RID: 1751 RVA: 0x0002208C File Offset: 0x0002028C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Vector3 _DOLocalMoveY_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass47_0.NativeMethodInfoPtr__DOLocalMoveY_b__0_Internal_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060006D8 RID: 1752 RVA: 0x000220C8 File Offset: 0x000202C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DOLocalMoveY_b__1(Vector3 x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass47_0.NativeMethodInfoPtr__DOLocalMoveY_b__1_Internal_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060006D9 RID: 1753 RVA: 0x000045A1 File Offset: 0x000027A1
			public __c__DisplayClass47_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000144 RID: 324
			// (get) Token: 0x060006DA RID: 1754 RVA: 0x00022108 File Offset: 0x00020308
			// (set) Token: 0x060006DB RID: 1755 RVA: 0x000045AA File Offset: 0x000027AA
			public unsafe Transform target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass47_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass47_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000528 RID: 1320
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x04000529 RID: 1321
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400052A RID: 1322
			private static readonly IntPtr NativeMethodInfoPtr__DOLocalMoveY_b__0_Internal_Vector3_0;

			// Token: 0x0400052B RID: 1323
			private static readonly IntPtr NativeMethodInfoPtr__DOLocalMoveY_b__1_Internal_Void_Vector3_0;
		}

		// Token: 0x02000093 RID: 147
		[ObfuscatedName("DG.Tweening.ShortcutExtensions+<>c__DisplayClass48_0")]
		public sealed class __c__DisplayClass48_0 : global::Il2CppSystem.Object
		{
			// Token: 0x060006DC RID: 1756 RVA: 0x00022138 File Offset: 0x00020338
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass48_0()
			{
				Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass48_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, "<>c__DisplayClass48_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass48_0>.NativeClassPtr);
				ShortcutExtensions.__c__DisplayClass48_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass48_0>.NativeClassPtr, "target");
				ShortcutExtensions.__c__DisplayClass48_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass48_0>.NativeClassPtr, 100663707);
				ShortcutExtensions.__c__DisplayClass48_0.NativeMethodInfoPtr__DOLocalMoveZ_b__0_Internal_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass48_0>.NativeClassPtr, 100663708);
				ShortcutExtensions.__c__DisplayClass48_0.NativeMethodInfoPtr__DOLocalMoveZ_b__1_Internal_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass48_0>.NativeClassPtr, 100663709);
			}

			// Token: 0x060006DD RID: 1757 RVA: 0x000221B4 File Offset: 0x000203B4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass48_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass48_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass48_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060006DE RID: 1758 RVA: 0x000221F0 File Offset: 0x000203F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Vector3 _DOLocalMoveZ_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass48_0.NativeMethodInfoPtr__DOLocalMoveZ_b__0_Internal_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060006DF RID: 1759 RVA: 0x0002222C File Offset: 0x0002042C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DOLocalMoveZ_b__1(Vector3 x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass48_0.NativeMethodInfoPtr__DOLocalMoveZ_b__1_Internal_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060006E0 RID: 1760 RVA: 0x000045C9 File Offset: 0x000027C9
			public __c__DisplayClass48_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000145 RID: 325
			// (get) Token: 0x060006E1 RID: 1761 RVA: 0x0002226C File Offset: 0x0002046C
			// (set) Token: 0x060006E2 RID: 1762 RVA: 0x000045D2 File Offset: 0x000027D2
			public unsafe Transform target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass48_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass48_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400052C RID: 1324
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x0400052D RID: 1325
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400052E RID: 1326
			private static readonly IntPtr NativeMethodInfoPtr__DOLocalMoveZ_b__0_Internal_Vector3_0;

			// Token: 0x0400052F RID: 1327
			private static readonly IntPtr NativeMethodInfoPtr__DOLocalMoveZ_b__1_Internal_Void_Vector3_0;
		}

		// Token: 0x02000094 RID: 148
		[ObfuscatedName("DG.Tweening.ShortcutExtensions+<>c__DisplayClass49_0")]
		public sealed class __c__DisplayClass49_0 : global::Il2CppSystem.Object
		{
			// Token: 0x060006E3 RID: 1763 RVA: 0x0002229C File Offset: 0x0002049C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass49_0()
			{
				Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass49_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, "<>c__DisplayClass49_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass49_0>.NativeClassPtr);
				ShortcutExtensions.__c__DisplayClass49_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass49_0>.NativeClassPtr, "target");
				ShortcutExtensions.__c__DisplayClass49_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass49_0>.NativeClassPtr, 100663710);
				ShortcutExtensions.__c__DisplayClass49_0.NativeMethodInfoPtr__DORotate_b__0_Internal_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass49_0>.NativeClassPtr, 100663711);
				ShortcutExtensions.__c__DisplayClass49_0.NativeMethodInfoPtr__DORotate_b__1_Internal_Void_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass49_0>.NativeClassPtr, 100663712);
			}

			// Token: 0x060006E4 RID: 1764 RVA: 0x00022318 File Offset: 0x00020518
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass49_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass49_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass49_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060006E5 RID: 1765 RVA: 0x00022354 File Offset: 0x00020554
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1128342, XrefRangeEnd = 1128343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Quaternion _DORotate_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass49_0.NativeMethodInfoPtr__DORotate_b__0_Internal_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060006E6 RID: 1766 RVA: 0x00022390 File Offset: 0x00020590
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1128343, XrefRangeEnd = 1128344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DORotate_b__1(Quaternion x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass49_0.NativeMethodInfoPtr__DORotate_b__1_Internal_Void_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060006E7 RID: 1767 RVA: 0x000045F1 File Offset: 0x000027F1
			public __c__DisplayClass49_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000146 RID: 326
			// (get) Token: 0x060006E8 RID: 1768 RVA: 0x000223D0 File Offset: 0x000205D0
			// (set) Token: 0x060006E9 RID: 1769 RVA: 0x000045FA File Offset: 0x000027FA
			public unsafe Transform target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass49_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass49_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000530 RID: 1328
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x04000531 RID: 1329
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000532 RID: 1330
			private static readonly IntPtr NativeMethodInfoPtr__DORotate_b__0_Internal_Quaternion_0;

			// Token: 0x04000533 RID: 1331
			private static readonly IntPtr NativeMethodInfoPtr__DORotate_b__1_Internal_Void_Quaternion_0;
		}

		// Token: 0x02000095 RID: 149
		[ObfuscatedName("DG.Tweening.ShortcutExtensions+<>c__DisplayClass50_0")]
		public sealed class __c__DisplayClass50_0 : global::Il2CppSystem.Object
		{
			// Token: 0x060006EA RID: 1770 RVA: 0x00022400 File Offset: 0x00020600
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass50_0()
			{
				Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass50_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, "<>c__DisplayClass50_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass50_0>.NativeClassPtr);
				ShortcutExtensions.__c__DisplayClass50_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass50_0>.NativeClassPtr, "target");
				ShortcutExtensions.__c__DisplayClass50_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass50_0>.NativeClassPtr, 100663713);
				ShortcutExtensions.__c__DisplayClass50_0.NativeMethodInfoPtr__DORotateQuaternion_b__0_Internal_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass50_0>.NativeClassPtr, 100663714);
				ShortcutExtensions.__c__DisplayClass50_0.NativeMethodInfoPtr__DORotateQuaternion_b__1_Internal_Void_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass50_0>.NativeClassPtr, 100663715);
			}

			// Token: 0x060006EB RID: 1771 RVA: 0x0002247C File Offset: 0x0002067C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass50_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass50_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass50_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060006EC RID: 1772 RVA: 0x000224B8 File Offset: 0x000206B8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Quaternion _DORotateQuaternion_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass50_0.NativeMethodInfoPtr__DORotateQuaternion_b__0_Internal_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060006ED RID: 1773 RVA: 0x000224F4 File Offset: 0x000206F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DORotateQuaternion_b__1(Quaternion x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass50_0.NativeMethodInfoPtr__DORotateQuaternion_b__1_Internal_Void_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060006EE RID: 1774 RVA: 0x00004619 File Offset: 0x00002819
			public __c__DisplayClass50_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000147 RID: 327
			// (get) Token: 0x060006EF RID: 1775 RVA: 0x00022534 File Offset: 0x00020734
			// (set) Token: 0x060006F0 RID: 1776 RVA: 0x00004622 File Offset: 0x00002822
			public unsafe Transform target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass50_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass50_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000534 RID: 1332
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x04000535 RID: 1333
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000536 RID: 1334
			private static readonly IntPtr NativeMethodInfoPtr__DORotateQuaternion_b__0_Internal_Quaternion_0;

			// Token: 0x04000537 RID: 1335
			private static readonly IntPtr NativeMethodInfoPtr__DORotateQuaternion_b__1_Internal_Void_Quaternion_0;
		}

		// Token: 0x02000096 RID: 150
		[ObfuscatedName("DG.Tweening.ShortcutExtensions+<>c__DisplayClass51_0")]
		public sealed class __c__DisplayClass51_0 : global::Il2CppSystem.Object
		{
			// Token: 0x060006F1 RID: 1777 RVA: 0x00022564 File Offset: 0x00020764
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass51_0()
			{
				Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass51_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, "<>c__DisplayClass51_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass51_0>.NativeClassPtr);
				ShortcutExtensions.__c__DisplayClass51_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass51_0>.NativeClassPtr, "target");
				ShortcutExtensions.__c__DisplayClass51_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass51_0>.NativeClassPtr, 100663716);
				ShortcutExtensions.__c__DisplayClass51_0.NativeMethodInfoPtr__DOLocalRotate_b__0_Internal_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass51_0>.NativeClassPtr, 100663717);
				ShortcutExtensions.__c__DisplayClass51_0.NativeMethodInfoPtr__DOLocalRotate_b__1_Internal_Void_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass51_0>.NativeClassPtr, 100663718);
			}

			// Token: 0x060006F2 RID: 1778 RVA: 0x000225E0 File Offset: 0x000207E0
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass51_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass51_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass51_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060006F3 RID: 1779 RVA: 0x0002261C File Offset: 0x0002081C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1128344, XrefRangeEnd = 1128345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Quaternion _DOLocalRotate_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass51_0.NativeMethodInfoPtr__DOLocalRotate_b__0_Internal_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060006F4 RID: 1780 RVA: 0x00022658 File Offset: 0x00020858
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1128345, XrefRangeEnd = 1128346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DOLocalRotate_b__1(Quaternion x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass51_0.NativeMethodInfoPtr__DOLocalRotate_b__1_Internal_Void_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060006F5 RID: 1781 RVA: 0x00004641 File Offset: 0x00002841
			public __c__DisplayClass51_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000148 RID: 328
			// (get) Token: 0x060006F6 RID: 1782 RVA: 0x00022698 File Offset: 0x00020898
			// (set) Token: 0x060006F7 RID: 1783 RVA: 0x0000464A File Offset: 0x0000284A
			public unsafe Transform target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass51_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass51_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000538 RID: 1336
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x04000539 RID: 1337
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400053A RID: 1338
			private static readonly IntPtr NativeMethodInfoPtr__DOLocalRotate_b__0_Internal_Quaternion_0;

			// Token: 0x0400053B RID: 1339
			private static readonly IntPtr NativeMethodInfoPtr__DOLocalRotate_b__1_Internal_Void_Quaternion_0;
		}

		// Token: 0x02000097 RID: 151
		[ObfuscatedName("DG.Tweening.ShortcutExtensions+<>c__DisplayClass52_0")]
		public sealed class __c__DisplayClass52_0 : global::Il2CppSystem.Object
		{
			// Token: 0x060006F8 RID: 1784 RVA: 0x000226C8 File Offset: 0x000208C8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass52_0()
			{
				Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass52_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, "<>c__DisplayClass52_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass52_0>.NativeClassPtr);
				ShortcutExtensions.__c__DisplayClass52_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass52_0>.NativeClassPtr, "target");
				ShortcutExtensions.__c__DisplayClass52_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass52_0>.NativeClassPtr, 100663719);
				ShortcutExtensions.__c__DisplayClass52_0.NativeMethodInfoPtr__DOLocalRotateQuaternion_b__0_Internal_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass52_0>.NativeClassPtr, 100663720);
				ShortcutExtensions.__c__DisplayClass52_0.NativeMethodInfoPtr__DOLocalRotateQuaternion_b__1_Internal_Void_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass52_0>.NativeClassPtr, 100663721);
			}

			// Token: 0x060006F9 RID: 1785 RVA: 0x00022744 File Offset: 0x00020944
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass52_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass52_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass52_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060006FA RID: 1786 RVA: 0x00022780 File Offset: 0x00020980
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Quaternion _DOLocalRotateQuaternion_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass52_0.NativeMethodInfoPtr__DOLocalRotateQuaternion_b__0_Internal_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060006FB RID: 1787 RVA: 0x000227BC File Offset: 0x000209BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DOLocalRotateQuaternion_b__1(Quaternion x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass52_0.NativeMethodInfoPtr__DOLocalRotateQuaternion_b__1_Internal_Void_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060006FC RID: 1788 RVA: 0x00004669 File Offset: 0x00002869
			public __c__DisplayClass52_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000149 RID: 329
			// (get) Token: 0x060006FD RID: 1789 RVA: 0x000227FC File Offset: 0x000209FC
			// (set) Token: 0x060006FE RID: 1790 RVA: 0x00004672 File Offset: 0x00002872
			public unsafe Transform target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass52_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass52_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400053C RID: 1340
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x0400053D RID: 1341
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400053E RID: 1342
			private static readonly IntPtr NativeMethodInfoPtr__DOLocalRotateQuaternion_b__0_Internal_Quaternion_0;

			// Token: 0x0400053F RID: 1343
			private static readonly IntPtr NativeMethodInfoPtr__DOLocalRotateQuaternion_b__1_Internal_Void_Quaternion_0;
		}

		// Token: 0x02000098 RID: 152
		[ObfuscatedName("DG.Tweening.ShortcutExtensions+<>c__DisplayClass53_0")]
		public sealed class __c__DisplayClass53_0 : global::Il2CppSystem.Object
		{
			// Token: 0x060006FF RID: 1791 RVA: 0x0002282C File Offset: 0x00020A2C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass53_0()
			{
				Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass53_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, "<>c__DisplayClass53_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass53_0>.NativeClassPtr);
				ShortcutExtensions.__c__DisplayClass53_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass53_0>.NativeClassPtr, "target");
				ShortcutExtensions.__c__DisplayClass53_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass53_0>.NativeClassPtr, 100663722);
				ShortcutExtensions.__c__DisplayClass53_0.NativeMethodInfoPtr__DOScale_b__0_Internal_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass53_0>.NativeClassPtr, 100663723);
				ShortcutExtensions.__c__DisplayClass53_0.NativeMethodInfoPtr__DOScale_b__1_Internal_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass53_0>.NativeClassPtr, 100663724);
			}

			// Token: 0x06000700 RID: 1792 RVA: 0x000228A8 File Offset: 0x00020AA8
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass53_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass53_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass53_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000701 RID: 1793 RVA: 0x000228E4 File Offset: 0x00020AE4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1128346, XrefRangeEnd = 1128347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Vector3 _DOScale_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass53_0.NativeMethodInfoPtr__DOScale_b__0_Internal_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000702 RID: 1794 RVA: 0x00022920 File Offset: 0x00020B20
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1128347, XrefRangeEnd = 1128348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DOScale_b__1(Vector3 x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass53_0.NativeMethodInfoPtr__DOScale_b__1_Internal_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000703 RID: 1795 RVA: 0x00004691 File Offset: 0x00002891
			public __c__DisplayClass53_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700014A RID: 330
			// (get) Token: 0x06000704 RID: 1796 RVA: 0x00022960 File Offset: 0x00020B60
			// (set) Token: 0x06000705 RID: 1797 RVA: 0x0000469A File Offset: 0x0000289A
			public unsafe Transform target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass53_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass53_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000540 RID: 1344
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x04000541 RID: 1345
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000542 RID: 1346
			private static readonly IntPtr NativeMethodInfoPtr__DOScale_b__0_Internal_Vector3_0;

			// Token: 0x04000543 RID: 1347
			private static readonly IntPtr NativeMethodInfoPtr__DOScale_b__1_Internal_Void_Vector3_0;
		}

		// Token: 0x02000099 RID: 153
		[ObfuscatedName("DG.Tweening.ShortcutExtensions+<>c__DisplayClass54_0")]
		public sealed class __c__DisplayClass54_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06000706 RID: 1798 RVA: 0x00022990 File Offset: 0x00020B90
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass54_0()
			{
				Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass54_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, "<>c__DisplayClass54_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass54_0>.NativeClassPtr);
				ShortcutExtensions.__c__DisplayClass54_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass54_0>.NativeClassPtr, "target");
				ShortcutExtensions.__c__DisplayClass54_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass54_0>.NativeClassPtr, 100663725);
				ShortcutExtensions.__c__DisplayClass54_0.NativeMethodInfoPtr__DOScale_b__0_Internal_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass54_0>.NativeClassPtr, 100663726);
				ShortcutExtensions.__c__DisplayClass54_0.NativeMethodInfoPtr__DOScale_b__1_Internal_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass54_0>.NativeClassPtr, 100663727);
			}

			// Token: 0x06000707 RID: 1799 RVA: 0x00022A0C File Offset: 0x00020C0C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass54_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass54_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass54_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000708 RID: 1800 RVA: 0x00022A48 File Offset: 0x00020C48
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Vector3 _DOScale_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass54_0.NativeMethodInfoPtr__DOScale_b__0_Internal_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000709 RID: 1801 RVA: 0x00022A84 File Offset: 0x00020C84
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DOScale_b__1(Vector3 x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass54_0.NativeMethodInfoPtr__DOScale_b__1_Internal_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600070A RID: 1802 RVA: 0x000046B9 File Offset: 0x000028B9
			public __c__DisplayClass54_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700014B RID: 331
			// (get) Token: 0x0600070B RID: 1803 RVA: 0x00022AC4 File Offset: 0x00020CC4
			// (set) Token: 0x0600070C RID: 1804 RVA: 0x000046C2 File Offset: 0x000028C2
			public unsafe Transform target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass54_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass54_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000544 RID: 1348
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x04000545 RID: 1349
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000546 RID: 1350
			private static readonly IntPtr NativeMethodInfoPtr__DOScale_b__0_Internal_Vector3_0;

			// Token: 0x04000547 RID: 1351
			private static readonly IntPtr NativeMethodInfoPtr__DOScale_b__1_Internal_Void_Vector3_0;
		}

		// Token: 0x0200009A RID: 154
		[ObfuscatedName("DG.Tweening.ShortcutExtensions+<>c__DisplayClass55_0")]
		public sealed class __c__DisplayClass55_0 : global::Il2CppSystem.Object
		{
			// Token: 0x0600070D RID: 1805 RVA: 0x00022AF4 File Offset: 0x00020CF4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass55_0()
			{
				Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass55_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, "<>c__DisplayClass55_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass55_0>.NativeClassPtr);
				ShortcutExtensions.__c__DisplayClass55_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass55_0>.NativeClassPtr, "target");
				ShortcutExtensions.__c__DisplayClass55_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass55_0>.NativeClassPtr, 100663728);
				ShortcutExtensions.__c__DisplayClass55_0.NativeMethodInfoPtr__DOScaleX_b__0_Internal_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass55_0>.NativeClassPtr, 100663729);
				ShortcutExtensions.__c__DisplayClass55_0.NativeMethodInfoPtr__DOScaleX_b__1_Internal_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass55_0>.NativeClassPtr, 100663730);
			}

			// Token: 0x0600070E RID: 1806 RVA: 0x00022B70 File Offset: 0x00020D70
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass55_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass55_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass55_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600070F RID: 1807 RVA: 0x00022BAC File Offset: 0x00020DAC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Vector3 _DOScaleX_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass55_0.NativeMethodInfoPtr__DOScaleX_b__0_Internal_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000710 RID: 1808 RVA: 0x00022BE8 File Offset: 0x00020DE8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DOScaleX_b__1(Vector3 x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass55_0.NativeMethodInfoPtr__DOScaleX_b__1_Internal_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000711 RID: 1809 RVA: 0x000046E1 File Offset: 0x000028E1
			public __c__DisplayClass55_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700014C RID: 332
			// (get) Token: 0x06000712 RID: 1810 RVA: 0x00022C28 File Offset: 0x00020E28
			// (set) Token: 0x06000713 RID: 1811 RVA: 0x000046EA File Offset: 0x000028EA
			public unsafe Transform target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass55_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass55_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000548 RID: 1352
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x04000549 RID: 1353
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400054A RID: 1354
			private static readonly IntPtr NativeMethodInfoPtr__DOScaleX_b__0_Internal_Vector3_0;

			// Token: 0x0400054B RID: 1355
			private static readonly IntPtr NativeMethodInfoPtr__DOScaleX_b__1_Internal_Void_Vector3_0;
		}

		// Token: 0x0200009B RID: 155
		[ObfuscatedName("DG.Tweening.ShortcutExtensions+<>c__DisplayClass56_0")]
		public sealed class __c__DisplayClass56_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06000714 RID: 1812 RVA: 0x00022C58 File Offset: 0x00020E58
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass56_0()
			{
				Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass56_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, "<>c__DisplayClass56_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass56_0>.NativeClassPtr);
				ShortcutExtensions.__c__DisplayClass56_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass56_0>.NativeClassPtr, "target");
				ShortcutExtensions.__c__DisplayClass56_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass56_0>.NativeClassPtr, 100663731);
				ShortcutExtensions.__c__DisplayClass56_0.NativeMethodInfoPtr__DOScaleY_b__0_Internal_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass56_0>.NativeClassPtr, 100663732);
				ShortcutExtensions.__c__DisplayClass56_0.NativeMethodInfoPtr__DOScaleY_b__1_Internal_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass56_0>.NativeClassPtr, 100663733);
			}

			// Token: 0x06000715 RID: 1813 RVA: 0x00022CD4 File Offset: 0x00020ED4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass56_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass56_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass56_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000716 RID: 1814 RVA: 0x00022D10 File Offset: 0x00020F10
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Vector3 _DOScaleY_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass56_0.NativeMethodInfoPtr__DOScaleY_b__0_Internal_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000717 RID: 1815 RVA: 0x00022D4C File Offset: 0x00020F4C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DOScaleY_b__1(Vector3 x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass56_0.NativeMethodInfoPtr__DOScaleY_b__1_Internal_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000718 RID: 1816 RVA: 0x00004709 File Offset: 0x00002909
			public __c__DisplayClass56_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700014D RID: 333
			// (get) Token: 0x06000719 RID: 1817 RVA: 0x00022D8C File Offset: 0x00020F8C
			// (set) Token: 0x0600071A RID: 1818 RVA: 0x00004712 File Offset: 0x00002912
			public unsafe Transform target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass56_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass56_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400054C RID: 1356
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x0400054D RID: 1357
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400054E RID: 1358
			private static readonly IntPtr NativeMethodInfoPtr__DOScaleY_b__0_Internal_Vector3_0;

			// Token: 0x0400054F RID: 1359
			private static readonly IntPtr NativeMethodInfoPtr__DOScaleY_b__1_Internal_Void_Vector3_0;
		}

		// Token: 0x0200009C RID: 156
		[ObfuscatedName("DG.Tweening.ShortcutExtensions+<>c__DisplayClass57_0")]
		public sealed class __c__DisplayClass57_0 : global::Il2CppSystem.Object
		{
			// Token: 0x0600071B RID: 1819 RVA: 0x00022DBC File Offset: 0x00020FBC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass57_0()
			{
				Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass57_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, "<>c__DisplayClass57_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass57_0>.NativeClassPtr);
				ShortcutExtensions.__c__DisplayClass57_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass57_0>.NativeClassPtr, "target");
				ShortcutExtensions.__c__DisplayClass57_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass57_0>.NativeClassPtr, 100663734);
				ShortcutExtensions.__c__DisplayClass57_0.NativeMethodInfoPtr__DOScaleZ_b__0_Internal_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass57_0>.NativeClassPtr, 100663735);
				ShortcutExtensions.__c__DisplayClass57_0.NativeMethodInfoPtr__DOScaleZ_b__1_Internal_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass57_0>.NativeClassPtr, 100663736);
			}

			// Token: 0x0600071C RID: 1820 RVA: 0x00022E38 File Offset: 0x00021038
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass57_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass57_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass57_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600071D RID: 1821 RVA: 0x00022E74 File Offset: 0x00021074
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Vector3 _DOScaleZ_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass57_0.NativeMethodInfoPtr__DOScaleZ_b__0_Internal_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600071E RID: 1822 RVA: 0x00022EB0 File Offset: 0x000210B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DOScaleZ_b__1(Vector3 x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass57_0.NativeMethodInfoPtr__DOScaleZ_b__1_Internal_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600071F RID: 1823 RVA: 0x00004731 File Offset: 0x00002931
			public __c__DisplayClass57_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700014E RID: 334
			// (get) Token: 0x06000720 RID: 1824 RVA: 0x00022EF0 File Offset: 0x000210F0
			// (set) Token: 0x06000721 RID: 1825 RVA: 0x0000473A File Offset: 0x0000293A
			public unsafe Transform target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass57_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass57_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000550 RID: 1360
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x04000551 RID: 1361
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000552 RID: 1362
			private static readonly IntPtr NativeMethodInfoPtr__DOScaleZ_b__0_Internal_Vector3_0;

			// Token: 0x04000553 RID: 1363
			private static readonly IntPtr NativeMethodInfoPtr__DOScaleZ_b__1_Internal_Void_Vector3_0;
		}

		// Token: 0x0200009D RID: 157
		[ObfuscatedName("DG.Tweening.ShortcutExtensions+<>c__DisplayClass58_0")]
		public sealed class __c__DisplayClass58_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06000722 RID: 1826 RVA: 0x00022F20 File Offset: 0x00021120
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass58_0()
			{
				Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass58_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, "<>c__DisplayClass58_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass58_0>.NativeClassPtr);
				ShortcutExtensions.__c__DisplayClass58_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass58_0>.NativeClassPtr, "target");
				ShortcutExtensions.__c__DisplayClass58_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass58_0>.NativeClassPtr, 100663737);
				ShortcutExtensions.__c__DisplayClass58_0.NativeMethodInfoPtr__DOLookAt_b__0_Internal_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass58_0>.NativeClassPtr, 100663738);
				ShortcutExtensions.__c__DisplayClass58_0.NativeMethodInfoPtr__DOLookAt_b__1_Internal_Void_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass58_0>.NativeClassPtr, 100663739);
			}

			// Token: 0x06000723 RID: 1827 RVA: 0x00022F9C File Offset: 0x0002119C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass58_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass58_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass58_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000724 RID: 1828 RVA: 0x00022FD8 File Offset: 0x000211D8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Quaternion _DOLookAt_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass58_0.NativeMethodInfoPtr__DOLookAt_b__0_Internal_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000725 RID: 1829 RVA: 0x00023014 File Offset: 0x00021214
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DOLookAt_b__1(Quaternion x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass58_0.NativeMethodInfoPtr__DOLookAt_b__1_Internal_Void_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000726 RID: 1830 RVA: 0x00004759 File Offset: 0x00002959
			public __c__DisplayClass58_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700014F RID: 335
			// (get) Token: 0x06000727 RID: 1831 RVA: 0x00023054 File Offset: 0x00021254
			// (set) Token: 0x06000728 RID: 1832 RVA: 0x00004762 File Offset: 0x00002962
			public unsafe Transform target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass58_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass58_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000554 RID: 1364
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x04000555 RID: 1365
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000556 RID: 1366
			private static readonly IntPtr NativeMethodInfoPtr__DOLookAt_b__0_Internal_Quaternion_0;

			// Token: 0x04000557 RID: 1367
			private static readonly IntPtr NativeMethodInfoPtr__DOLookAt_b__1_Internal_Void_Quaternion_0;
		}

		// Token: 0x0200009E RID: 158
		[ObfuscatedName("DG.Tweening.ShortcutExtensions+<>c__DisplayClass59_0")]
		public sealed class __c__DisplayClass59_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06000729 RID: 1833 RVA: 0x00023084 File Offset: 0x00021284
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass59_0()
			{
				Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass59_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, "<>c__DisplayClass59_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass59_0>.NativeClassPtr);
				ShortcutExtensions.__c__DisplayClass59_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass59_0>.NativeClassPtr, "target");
				ShortcutExtensions.__c__DisplayClass59_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass59_0>.NativeClassPtr, 100663740);
				ShortcutExtensions.__c__DisplayClass59_0.NativeMethodInfoPtr__DOPunchPosition_b__0_Internal_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass59_0>.NativeClassPtr, 100663741);
				ShortcutExtensions.__c__DisplayClass59_0.NativeMethodInfoPtr__DOPunchPosition_b__1_Internal_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass59_0>.NativeClassPtr, 100663742);
			}

			// Token: 0x0600072A RID: 1834 RVA: 0x00023100 File Offset: 0x00021300
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass59_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass59_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass59_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600072B RID: 1835 RVA: 0x0002313C File Offset: 0x0002133C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Vector3 _DOPunchPosition_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass59_0.NativeMethodInfoPtr__DOPunchPosition_b__0_Internal_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600072C RID: 1836 RVA: 0x00023178 File Offset: 0x00021378
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DOPunchPosition_b__1(Vector3 x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass59_0.NativeMethodInfoPtr__DOPunchPosition_b__1_Internal_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600072D RID: 1837 RVA: 0x00004781 File Offset: 0x00002981
			public __c__DisplayClass59_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000150 RID: 336
			// (get) Token: 0x0600072E RID: 1838 RVA: 0x000231B8 File Offset: 0x000213B8
			// (set) Token: 0x0600072F RID: 1839 RVA: 0x0000478A File Offset: 0x0000298A
			public unsafe Transform target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass59_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass59_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000558 RID: 1368
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x04000559 RID: 1369
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400055A RID: 1370
			private static readonly IntPtr NativeMethodInfoPtr__DOPunchPosition_b__0_Internal_Vector3_0;

			// Token: 0x0400055B RID: 1371
			private static readonly IntPtr NativeMethodInfoPtr__DOPunchPosition_b__1_Internal_Void_Vector3_0;
		}

		// Token: 0x0200009F RID: 159
		[ObfuscatedName("DG.Tweening.ShortcutExtensions+<>c__DisplayClass60_0")]
		public sealed class __c__DisplayClass60_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06000730 RID: 1840 RVA: 0x000231E8 File Offset: 0x000213E8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass60_0()
			{
				Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass60_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, "<>c__DisplayClass60_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass60_0>.NativeClassPtr);
				ShortcutExtensions.__c__DisplayClass60_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass60_0>.NativeClassPtr, "target");
				ShortcutExtensions.__c__DisplayClass60_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass60_0>.NativeClassPtr, 100663743);
				ShortcutExtensions.__c__DisplayClass60_0.NativeMethodInfoPtr__DOPunchScale_b__0_Internal_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass60_0>.NativeClassPtr, 100663744);
				ShortcutExtensions.__c__DisplayClass60_0.NativeMethodInfoPtr__DOPunchScale_b__1_Internal_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass60_0>.NativeClassPtr, 100663745);
			}

			// Token: 0x06000731 RID: 1841 RVA: 0x00023264 File Offset: 0x00021464
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass60_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass60_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass60_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000732 RID: 1842 RVA: 0x000232A0 File Offset: 0x000214A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Vector3 _DOPunchScale_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass60_0.NativeMethodInfoPtr__DOPunchScale_b__0_Internal_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000733 RID: 1843 RVA: 0x000232DC File Offset: 0x000214DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DOPunchScale_b__1(Vector3 x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass60_0.NativeMethodInfoPtr__DOPunchScale_b__1_Internal_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000734 RID: 1844 RVA: 0x000047A9 File Offset: 0x000029A9
			public __c__DisplayClass60_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000151 RID: 337
			// (get) Token: 0x06000735 RID: 1845 RVA: 0x0002331C File Offset: 0x0002151C
			// (set) Token: 0x06000736 RID: 1846 RVA: 0x000047B2 File Offset: 0x000029B2
			public unsafe Transform target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass60_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass60_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400055C RID: 1372
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x0400055D RID: 1373
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400055E RID: 1374
			private static readonly IntPtr NativeMethodInfoPtr__DOPunchScale_b__0_Internal_Vector3_0;

			// Token: 0x0400055F RID: 1375
			private static readonly IntPtr NativeMethodInfoPtr__DOPunchScale_b__1_Internal_Void_Vector3_0;
		}

		// Token: 0x020000A0 RID: 160
		[ObfuscatedName("DG.Tweening.ShortcutExtensions+<>c__DisplayClass61_0")]
		public sealed class __c__DisplayClass61_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06000737 RID: 1847 RVA: 0x0002334C File Offset: 0x0002154C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass61_0()
			{
				Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass61_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, "<>c__DisplayClass61_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass61_0>.NativeClassPtr);
				ShortcutExtensions.__c__DisplayClass61_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass61_0>.NativeClassPtr, "target");
				ShortcutExtensions.__c__DisplayClass61_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass61_0>.NativeClassPtr, 100663746);
				ShortcutExtensions.__c__DisplayClass61_0.NativeMethodInfoPtr__DOPunchRotation_b__0_Internal_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass61_0>.NativeClassPtr, 100663747);
				ShortcutExtensions.__c__DisplayClass61_0.NativeMethodInfoPtr__DOPunchRotation_b__1_Internal_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass61_0>.NativeClassPtr, 100663748);
			}

			// Token: 0x06000738 RID: 1848 RVA: 0x000233C8 File Offset: 0x000215C8
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass61_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass61_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass61_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000739 RID: 1849 RVA: 0x00023404 File Offset: 0x00021604
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1128348, XrefRangeEnd = 1128349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Vector3 _DOPunchRotation_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass61_0.NativeMethodInfoPtr__DOPunchRotation_b__0_Internal_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600073A RID: 1850 RVA: 0x00023440 File Offset: 0x00021640
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1128349, XrefRangeEnd = 1128351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DOPunchRotation_b__1(Vector3 x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass61_0.NativeMethodInfoPtr__DOPunchRotation_b__1_Internal_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600073B RID: 1851 RVA: 0x000047D1 File Offset: 0x000029D1
			public __c__DisplayClass61_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000152 RID: 338
			// (get) Token: 0x0600073C RID: 1852 RVA: 0x00023480 File Offset: 0x00021680
			// (set) Token: 0x0600073D RID: 1853 RVA: 0x000047DA File Offset: 0x000029DA
			public unsafe Transform target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass61_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass61_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000560 RID: 1376
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x04000561 RID: 1377
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000562 RID: 1378
			private static readonly IntPtr NativeMethodInfoPtr__DOPunchRotation_b__0_Internal_Vector3_0;

			// Token: 0x04000563 RID: 1379
			private static readonly IntPtr NativeMethodInfoPtr__DOPunchRotation_b__1_Internal_Void_Vector3_0;
		}

		// Token: 0x020000A1 RID: 161
		[ObfuscatedName("DG.Tweening.ShortcutExtensions+<>c__DisplayClass62_0")]
		public sealed class __c__DisplayClass62_0 : global::Il2CppSystem.Object
		{
			// Token: 0x0600073E RID: 1854 RVA: 0x000234B0 File Offset: 0x000216B0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass62_0()
			{
				Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass62_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, "<>c__DisplayClass62_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass62_0>.NativeClassPtr);
				ShortcutExtensions.__c__DisplayClass62_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass62_0>.NativeClassPtr, "target");
				ShortcutExtensions.__c__DisplayClass62_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass62_0>.NativeClassPtr, 100663749);
				ShortcutExtensions.__c__DisplayClass62_0.NativeMethodInfoPtr__DOShakePosition_b__0_Internal_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass62_0>.NativeClassPtr, 100663750);
				ShortcutExtensions.__c__DisplayClass62_0.NativeMethodInfoPtr__DOShakePosition_b__1_Internal_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass62_0>.NativeClassPtr, 100663751);
			}

			// Token: 0x0600073F RID: 1855 RVA: 0x0002352C File Offset: 0x0002172C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass62_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass62_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass62_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000740 RID: 1856 RVA: 0x00023568 File Offset: 0x00021768
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Vector3 _DOShakePosition_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass62_0.NativeMethodInfoPtr__DOShakePosition_b__0_Internal_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000741 RID: 1857 RVA: 0x000235A4 File Offset: 0x000217A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DOShakePosition_b__1(Vector3 x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass62_0.NativeMethodInfoPtr__DOShakePosition_b__1_Internal_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000742 RID: 1858 RVA: 0x000047F9 File Offset: 0x000029F9
			public __c__DisplayClass62_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000153 RID: 339
			// (get) Token: 0x06000743 RID: 1859 RVA: 0x000235E4 File Offset: 0x000217E4
			// (set) Token: 0x06000744 RID: 1860 RVA: 0x00004802 File Offset: 0x00002A02
			public unsafe Transform target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass62_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass62_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000564 RID: 1380
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x04000565 RID: 1381
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000566 RID: 1382
			private static readonly IntPtr NativeMethodInfoPtr__DOShakePosition_b__0_Internal_Vector3_0;

			// Token: 0x04000567 RID: 1383
			private static readonly IntPtr NativeMethodInfoPtr__DOShakePosition_b__1_Internal_Void_Vector3_0;
		}

		// Token: 0x020000A2 RID: 162
		[ObfuscatedName("DG.Tweening.ShortcutExtensions+<>c__DisplayClass63_0")]
		public sealed class __c__DisplayClass63_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06000745 RID: 1861 RVA: 0x00023614 File Offset: 0x00021814
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass63_0()
			{
				Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass63_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, "<>c__DisplayClass63_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass63_0>.NativeClassPtr);
				ShortcutExtensions.__c__DisplayClass63_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass63_0>.NativeClassPtr, "target");
				ShortcutExtensions.__c__DisplayClass63_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass63_0>.NativeClassPtr, 100663752);
				ShortcutExtensions.__c__DisplayClass63_0.NativeMethodInfoPtr__DOShakePosition_b__0_Internal_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass63_0>.NativeClassPtr, 100663753);
				ShortcutExtensions.__c__DisplayClass63_0.NativeMethodInfoPtr__DOShakePosition_b__1_Internal_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass63_0>.NativeClassPtr, 100663754);
			}

			// Token: 0x06000746 RID: 1862 RVA: 0x00023690 File Offset: 0x00021890
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass63_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass63_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass63_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000747 RID: 1863 RVA: 0x000236CC File Offset: 0x000218CC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Vector3 _DOShakePosition_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass63_0.NativeMethodInfoPtr__DOShakePosition_b__0_Internal_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000748 RID: 1864 RVA: 0x00023708 File Offset: 0x00021908
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DOShakePosition_b__1(Vector3 x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass63_0.NativeMethodInfoPtr__DOShakePosition_b__1_Internal_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000749 RID: 1865 RVA: 0x00004821 File Offset: 0x00002A21
			public __c__DisplayClass63_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000154 RID: 340
			// (get) Token: 0x0600074A RID: 1866 RVA: 0x00023748 File Offset: 0x00021948
			// (set) Token: 0x0600074B RID: 1867 RVA: 0x0000482A File Offset: 0x00002A2A
			public unsafe Transform target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass63_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass63_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000568 RID: 1384
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x04000569 RID: 1385
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400056A RID: 1386
			private static readonly IntPtr NativeMethodInfoPtr__DOShakePosition_b__0_Internal_Vector3_0;

			// Token: 0x0400056B RID: 1387
			private static readonly IntPtr NativeMethodInfoPtr__DOShakePosition_b__1_Internal_Void_Vector3_0;
		}

		// Token: 0x020000A3 RID: 163
		[ObfuscatedName("DG.Tweening.ShortcutExtensions+<>c__DisplayClass64_0")]
		public sealed class __c__DisplayClass64_0 : global::Il2CppSystem.Object
		{
			// Token: 0x0600074C RID: 1868 RVA: 0x00023778 File Offset: 0x00021978
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass64_0()
			{
				Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass64_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, "<>c__DisplayClass64_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass64_0>.NativeClassPtr);
				ShortcutExtensions.__c__DisplayClass64_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass64_0>.NativeClassPtr, "target");
				ShortcutExtensions.__c__DisplayClass64_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass64_0>.NativeClassPtr, 100663755);
				ShortcutExtensions.__c__DisplayClass64_0.NativeMethodInfoPtr__DOShakeRotation_b__0_Internal_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass64_0>.NativeClassPtr, 100663756);
				ShortcutExtensions.__c__DisplayClass64_0.NativeMethodInfoPtr__DOShakeRotation_b__1_Internal_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass64_0>.NativeClassPtr, 100663757);
			}

			// Token: 0x0600074D RID: 1869 RVA: 0x000237F4 File Offset: 0x000219F4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass64_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass64_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass64_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600074E RID: 1870 RVA: 0x00023830 File Offset: 0x00021A30
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Vector3 _DOShakeRotation_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass64_0.NativeMethodInfoPtr__DOShakeRotation_b__0_Internal_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600074F RID: 1871 RVA: 0x0002386C File Offset: 0x00021A6C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DOShakeRotation_b__1(Vector3 x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass64_0.NativeMethodInfoPtr__DOShakeRotation_b__1_Internal_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000750 RID: 1872 RVA: 0x00004849 File Offset: 0x00002A49
			public __c__DisplayClass64_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000155 RID: 341
			// (get) Token: 0x06000751 RID: 1873 RVA: 0x000238AC File Offset: 0x00021AAC
			// (set) Token: 0x06000752 RID: 1874 RVA: 0x00004852 File Offset: 0x00002A52
			public unsafe Transform target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass64_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass64_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400056C RID: 1388
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x0400056D RID: 1389
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400056E RID: 1390
			private static readonly IntPtr NativeMethodInfoPtr__DOShakeRotation_b__0_Internal_Vector3_0;

			// Token: 0x0400056F RID: 1391
			private static readonly IntPtr NativeMethodInfoPtr__DOShakeRotation_b__1_Internal_Void_Vector3_0;
		}

		// Token: 0x020000A4 RID: 164
		[ObfuscatedName("DG.Tweening.ShortcutExtensions+<>c__DisplayClass65_0")]
		public sealed class __c__DisplayClass65_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06000753 RID: 1875 RVA: 0x000238DC File Offset: 0x00021ADC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass65_0()
			{
				Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass65_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, "<>c__DisplayClass65_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass65_0>.NativeClassPtr);
				ShortcutExtensions.__c__DisplayClass65_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass65_0>.NativeClassPtr, "target");
				ShortcutExtensions.__c__DisplayClass65_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass65_0>.NativeClassPtr, 100663758);
				ShortcutExtensions.__c__DisplayClass65_0.NativeMethodInfoPtr__DOShakeRotation_b__0_Internal_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass65_0>.NativeClassPtr, 100663759);
				ShortcutExtensions.__c__DisplayClass65_0.NativeMethodInfoPtr__DOShakeRotation_b__1_Internal_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass65_0>.NativeClassPtr, 100663760);
			}

			// Token: 0x06000754 RID: 1876 RVA: 0x00023958 File Offset: 0x00021B58
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass65_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass65_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass65_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000755 RID: 1877 RVA: 0x00023994 File Offset: 0x00021B94
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Vector3 _DOShakeRotation_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass65_0.NativeMethodInfoPtr__DOShakeRotation_b__0_Internal_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000756 RID: 1878 RVA: 0x000239D0 File Offset: 0x00021BD0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DOShakeRotation_b__1(Vector3 x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass65_0.NativeMethodInfoPtr__DOShakeRotation_b__1_Internal_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000757 RID: 1879 RVA: 0x00004871 File Offset: 0x00002A71
			public __c__DisplayClass65_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000156 RID: 342
			// (get) Token: 0x06000758 RID: 1880 RVA: 0x00023A10 File Offset: 0x00021C10
			// (set) Token: 0x06000759 RID: 1881 RVA: 0x0000487A File Offset: 0x00002A7A
			public unsafe Transform target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass65_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass65_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000570 RID: 1392
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x04000571 RID: 1393
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000572 RID: 1394
			private static readonly IntPtr NativeMethodInfoPtr__DOShakeRotation_b__0_Internal_Vector3_0;

			// Token: 0x04000573 RID: 1395
			private static readonly IntPtr NativeMethodInfoPtr__DOShakeRotation_b__1_Internal_Void_Vector3_0;
		}

		// Token: 0x020000A5 RID: 165
		[ObfuscatedName("DG.Tweening.ShortcutExtensions+<>c__DisplayClass66_0")]
		public sealed class __c__DisplayClass66_0 : global::Il2CppSystem.Object
		{
			// Token: 0x0600075A RID: 1882 RVA: 0x00023A40 File Offset: 0x00021C40
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass66_0()
			{
				Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass66_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, "<>c__DisplayClass66_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass66_0>.NativeClassPtr);
				ShortcutExtensions.__c__DisplayClass66_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass66_0>.NativeClassPtr, "target");
				ShortcutExtensions.__c__DisplayClass66_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass66_0>.NativeClassPtr, 100663761);
				ShortcutExtensions.__c__DisplayClass66_0.NativeMethodInfoPtr__DOShakeScale_b__0_Internal_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass66_0>.NativeClassPtr, 100663762);
				ShortcutExtensions.__c__DisplayClass66_0.NativeMethodInfoPtr__DOShakeScale_b__1_Internal_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass66_0>.NativeClassPtr, 100663763);
			}

			// Token: 0x0600075B RID: 1883 RVA: 0x00023ABC File Offset: 0x00021CBC
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass66_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass66_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass66_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600075C RID: 1884 RVA: 0x00023AF8 File Offset: 0x00021CF8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Vector3 _DOShakeScale_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass66_0.NativeMethodInfoPtr__DOShakeScale_b__0_Internal_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600075D RID: 1885 RVA: 0x00023B34 File Offset: 0x00021D34
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DOShakeScale_b__1(Vector3 x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass66_0.NativeMethodInfoPtr__DOShakeScale_b__1_Internal_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600075E RID: 1886 RVA: 0x00004899 File Offset: 0x00002A99
			public __c__DisplayClass66_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000157 RID: 343
			// (get) Token: 0x0600075F RID: 1887 RVA: 0x00023B74 File Offset: 0x00021D74
			// (set) Token: 0x06000760 RID: 1888 RVA: 0x000048A2 File Offset: 0x00002AA2
			public unsafe Transform target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass66_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass66_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000574 RID: 1396
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x04000575 RID: 1397
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000576 RID: 1398
			private static readonly IntPtr NativeMethodInfoPtr__DOShakeScale_b__0_Internal_Vector3_0;

			// Token: 0x04000577 RID: 1399
			private static readonly IntPtr NativeMethodInfoPtr__DOShakeScale_b__1_Internal_Void_Vector3_0;
		}

		// Token: 0x020000A6 RID: 166
		[ObfuscatedName("DG.Tweening.ShortcutExtensions+<>c__DisplayClass67_0")]
		public sealed class __c__DisplayClass67_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06000761 RID: 1889 RVA: 0x00023BA4 File Offset: 0x00021DA4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass67_0()
			{
				Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass67_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, "<>c__DisplayClass67_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass67_0>.NativeClassPtr);
				ShortcutExtensions.__c__DisplayClass67_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass67_0>.NativeClassPtr, "target");
				ShortcutExtensions.__c__DisplayClass67_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass67_0>.NativeClassPtr, 100663764);
				ShortcutExtensions.__c__DisplayClass67_0.NativeMethodInfoPtr__DOShakeScale_b__0_Internal_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass67_0>.NativeClassPtr, 100663765);
				ShortcutExtensions.__c__DisplayClass67_0.NativeMethodInfoPtr__DOShakeScale_b__1_Internal_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass67_0>.NativeClassPtr, 100663766);
			}

			// Token: 0x06000762 RID: 1890 RVA: 0x00023C20 File Offset: 0x00021E20
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass67_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass67_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass67_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000763 RID: 1891 RVA: 0x00023C5C File Offset: 0x00021E5C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Vector3 _DOShakeScale_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass67_0.NativeMethodInfoPtr__DOShakeScale_b__0_Internal_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000764 RID: 1892 RVA: 0x00023C98 File Offset: 0x00021E98
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DOShakeScale_b__1(Vector3 x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass67_0.NativeMethodInfoPtr__DOShakeScale_b__1_Internal_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000765 RID: 1893 RVA: 0x000048C1 File Offset: 0x00002AC1
			public __c__DisplayClass67_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000158 RID: 344
			// (get) Token: 0x06000766 RID: 1894 RVA: 0x00023CD8 File Offset: 0x00021ED8
			// (set) Token: 0x06000767 RID: 1895 RVA: 0x000048CA File Offset: 0x00002ACA
			public unsafe Transform target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass67_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass67_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000578 RID: 1400
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x04000579 RID: 1401
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400057A RID: 1402
			private static readonly IntPtr NativeMethodInfoPtr__DOShakeScale_b__0_Internal_Vector3_0;

			// Token: 0x0400057B RID: 1403
			private static readonly IntPtr NativeMethodInfoPtr__DOShakeScale_b__1_Internal_Void_Vector3_0;
		}

		// Token: 0x020000A7 RID: 167
		[ObfuscatedName("DG.Tweening.ShortcutExtensions+<>c__DisplayClass68_0")]
		public sealed class __c__DisplayClass68_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06000768 RID: 1896 RVA: 0x00023D08 File Offset: 0x00021F08
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass68_0()
			{
				Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass68_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, "<>c__DisplayClass68_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass68_0>.NativeClassPtr);
				ShortcutExtensions.__c__DisplayClass68_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass68_0>.NativeClassPtr, "target");
				ShortcutExtensions.__c__DisplayClass68_0.NativeFieldInfoPtr_offsetYSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass68_0>.NativeClassPtr, "offsetYSet");
				ShortcutExtensions.__c__DisplayClass68_0.NativeFieldInfoPtr_offsetY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass68_0>.NativeClassPtr, "offsetY");
				ShortcutExtensions.__c__DisplayClass68_0.NativeFieldInfoPtr_s = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass68_0>.NativeClassPtr, "s");
				ShortcutExtensions.__c__DisplayClass68_0.NativeFieldInfoPtr_endValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass68_0>.NativeClassPtr, "endValue");
				ShortcutExtensions.__c__DisplayClass68_0.NativeFieldInfoPtr_startPosY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass68_0>.NativeClassPtr, "startPosY");
				ShortcutExtensions.__c__DisplayClass68_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass68_0>.NativeClassPtr, 100663767);
				ShortcutExtensions.__c__DisplayClass68_0.NativeMethodInfoPtr__DOJump_b__0_Internal_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass68_0>.NativeClassPtr, 100663768);
				ShortcutExtensions.__c__DisplayClass68_0.NativeMethodInfoPtr__DOJump_b__1_Internal_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass68_0>.NativeClassPtr, 100663769);
				ShortcutExtensions.__c__DisplayClass68_0.NativeMethodInfoPtr__DOJump_b__2_Internal_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass68_0>.NativeClassPtr, 100663770);
				ShortcutExtensions.__c__DisplayClass68_0.NativeMethodInfoPtr__DOJump_b__3_Internal_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass68_0>.NativeClassPtr, 100663771);
				ShortcutExtensions.__c__DisplayClass68_0.NativeMethodInfoPtr__DOJump_b__4_Internal_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass68_0>.NativeClassPtr, 100663772);
				ShortcutExtensions.__c__DisplayClass68_0.NativeMethodInfoPtr__DOJump_b__5_Internal_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass68_0>.NativeClassPtr, 100663773);
				ShortcutExtensions.__c__DisplayClass68_0.NativeMethodInfoPtr__DOJump_b__6_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass68_0>.NativeClassPtr, 100663774);
			}

			// Token: 0x06000769 RID: 1897 RVA: 0x00023E4C File Offset: 0x0002204C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass68_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass68_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass68_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600076A RID: 1898 RVA: 0x00023E88 File Offset: 0x00022088
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Vector3 _DOJump_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass68_0.NativeMethodInfoPtr__DOJump_b__0_Internal_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600076B RID: 1899 RVA: 0x00023EC4 File Offset: 0x000220C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DOJump_b__1(Vector3 x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass68_0.NativeMethodInfoPtr__DOJump_b__1_Internal_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600076C RID: 1900 RVA: 0x00023F04 File Offset: 0x00022104
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Vector3 _DOJump_b__2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass68_0.NativeMethodInfoPtr__DOJump_b__2_Internal_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600076D RID: 1901 RVA: 0x00023F40 File Offset: 0x00022140
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DOJump_b__3(Vector3 x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass68_0.NativeMethodInfoPtr__DOJump_b__3_Internal_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600076E RID: 1902 RVA: 0x00023F80 File Offset: 0x00022180
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Vector3 _DOJump_b__4()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass68_0.NativeMethodInfoPtr__DOJump_b__4_Internal_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600076F RID: 1903 RVA: 0x00023FBC File Offset: 0x000221BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DOJump_b__5(Vector3 x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass68_0.NativeMethodInfoPtr__DOJump_b__5_Internal_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000770 RID: 1904 RVA: 0x00023FFC File Offset: 0x000221FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1128351, XrefRangeEnd = 1128355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DOJump_b__6()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass68_0.NativeMethodInfoPtr__DOJump_b__6_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000771 RID: 1905 RVA: 0x000048E9 File Offset: 0x00002AE9
			public __c__DisplayClass68_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000159 RID: 345
			// (get) Token: 0x06000772 RID: 1906 RVA: 0x00024030 File Offset: 0x00022230
			// (set) Token: 0x06000773 RID: 1907 RVA: 0x000048F2 File Offset: 0x00002AF2
			public unsafe Transform target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass68_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass68_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700015A RID: 346
			// (get) Token: 0x06000774 RID: 1908 RVA: 0x00024060 File Offset: 0x00022260
			// (set) Token: 0x06000775 RID: 1909 RVA: 0x00004911 File Offset: 0x00002B11
			public unsafe bool offsetYSet
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass68_0.NativeFieldInfoPtr_offsetYSet);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass68_0.NativeFieldInfoPtr_offsetYSet)) = value;
				}
			}

			// Token: 0x1700015B RID: 347
			// (get) Token: 0x06000776 RID: 1910 RVA: 0x00024088 File Offset: 0x00022288
			// (set) Token: 0x06000777 RID: 1911 RVA: 0x0000492C File Offset: 0x00002B2C
			public unsafe float offsetY
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass68_0.NativeFieldInfoPtr_offsetY);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass68_0.NativeFieldInfoPtr_offsetY)) = value;
				}
			}

			// Token: 0x1700015C RID: 348
			// (get) Token: 0x06000778 RID: 1912 RVA: 0x000240B0 File Offset: 0x000222B0
			// (set) Token: 0x06000779 RID: 1913 RVA: 0x00004947 File Offset: 0x00002B47
			public unsafe Sequence s
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass68_0.NativeFieldInfoPtr_s);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sequence>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass68_0.NativeFieldInfoPtr_s), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700015D RID: 349
			// (get) Token: 0x0600077A RID: 1914 RVA: 0x000240E0 File Offset: 0x000222E0
			// (set) Token: 0x0600077B RID: 1915 RVA: 0x00004966 File Offset: 0x00002B66
			public unsafe Vector3 endValue
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass68_0.NativeFieldInfoPtr_endValue);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass68_0.NativeFieldInfoPtr_endValue)) = value;
				}
			}

			// Token: 0x1700015E RID: 350
			// (get) Token: 0x0600077C RID: 1916 RVA: 0x00024108 File Offset: 0x00022308
			// (set) Token: 0x0600077D RID: 1917 RVA: 0x00004981 File Offset: 0x00002B81
			public unsafe float startPosY
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass68_0.NativeFieldInfoPtr_startPosY);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass68_0.NativeFieldInfoPtr_startPosY)) = value;
				}
			}

			// Token: 0x0400057C RID: 1404
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x0400057D RID: 1405
			private static readonly IntPtr NativeFieldInfoPtr_offsetYSet;

			// Token: 0x0400057E RID: 1406
			private static readonly IntPtr NativeFieldInfoPtr_offsetY;

			// Token: 0x0400057F RID: 1407
			private static readonly IntPtr NativeFieldInfoPtr_s;

			// Token: 0x04000580 RID: 1408
			private static readonly IntPtr NativeFieldInfoPtr_endValue;

			// Token: 0x04000581 RID: 1409
			private static readonly IntPtr NativeFieldInfoPtr_startPosY;

			// Token: 0x04000582 RID: 1410
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000583 RID: 1411
			private static readonly IntPtr NativeMethodInfoPtr__DOJump_b__0_Internal_Vector3_0;

			// Token: 0x04000584 RID: 1412
			private static readonly IntPtr NativeMethodInfoPtr__DOJump_b__1_Internal_Void_Vector3_0;

			// Token: 0x04000585 RID: 1413
			private static readonly IntPtr NativeMethodInfoPtr__DOJump_b__2_Internal_Vector3_0;

			// Token: 0x04000586 RID: 1414
			private static readonly IntPtr NativeMethodInfoPtr__DOJump_b__3_Internal_Void_Vector3_0;

			// Token: 0x04000587 RID: 1415
			private static readonly IntPtr NativeMethodInfoPtr__DOJump_b__4_Internal_Vector3_0;

			// Token: 0x04000588 RID: 1416
			private static readonly IntPtr NativeMethodInfoPtr__DOJump_b__5_Internal_Void_Vector3_0;

			// Token: 0x04000589 RID: 1417
			private static readonly IntPtr NativeMethodInfoPtr__DOJump_b__6_Internal_Void_0;
		}

		// Token: 0x020000A8 RID: 168
		[ObfuscatedName("DG.Tweening.ShortcutExtensions+<>c__DisplayClass69_0")]
		public sealed class __c__DisplayClass69_0 : global::Il2CppSystem.Object
		{
			// Token: 0x0600077E RID: 1918 RVA: 0x00024130 File Offset: 0x00022330
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass69_0()
			{
				Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass69_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, "<>c__DisplayClass69_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass69_0>.NativeClassPtr);
				ShortcutExtensions.__c__DisplayClass69_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass69_0>.NativeClassPtr, "target");
				ShortcutExtensions.__c__DisplayClass69_0.NativeFieldInfoPtr_offsetYSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass69_0>.NativeClassPtr, "offsetYSet");
				ShortcutExtensions.__c__DisplayClass69_0.NativeFieldInfoPtr_offsetY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass69_0>.NativeClassPtr, "offsetY");
				ShortcutExtensions.__c__DisplayClass69_0.NativeFieldInfoPtr_s = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass69_0>.NativeClassPtr, "s");
				ShortcutExtensions.__c__DisplayClass69_0.NativeFieldInfoPtr_endValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass69_0>.NativeClassPtr, "endValue");
				ShortcutExtensions.__c__DisplayClass69_0.NativeFieldInfoPtr_startPosY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass69_0>.NativeClassPtr, "startPosY");
				ShortcutExtensions.__c__DisplayClass69_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass69_0>.NativeClassPtr, 100663775);
				ShortcutExtensions.__c__DisplayClass69_0.NativeMethodInfoPtr__DOLocalJump_b__0_Internal_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass69_0>.NativeClassPtr, 100663776);
				ShortcutExtensions.__c__DisplayClass69_0.NativeMethodInfoPtr__DOLocalJump_b__1_Internal_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass69_0>.NativeClassPtr, 100663777);
				ShortcutExtensions.__c__DisplayClass69_0.NativeMethodInfoPtr__DOLocalJump_b__2_Internal_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass69_0>.NativeClassPtr, 100663778);
				ShortcutExtensions.__c__DisplayClass69_0.NativeMethodInfoPtr__DOLocalJump_b__3_Internal_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass69_0>.NativeClassPtr, 100663779);
				ShortcutExtensions.__c__DisplayClass69_0.NativeMethodInfoPtr__DOLocalJump_b__4_Internal_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass69_0>.NativeClassPtr, 100663780);
				ShortcutExtensions.__c__DisplayClass69_0.NativeMethodInfoPtr__DOLocalJump_b__5_Internal_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass69_0>.NativeClassPtr, 100663781);
				ShortcutExtensions.__c__DisplayClass69_0.NativeMethodInfoPtr__DOLocalJump_b__6_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass69_0>.NativeClassPtr, 100663782);
			}

			// Token: 0x0600077F RID: 1919 RVA: 0x00024274 File Offset: 0x00022474
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass69_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass69_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass69_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000780 RID: 1920 RVA: 0x000242B0 File Offset: 0x000224B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Vector3 _DOLocalJump_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass69_0.NativeMethodInfoPtr__DOLocalJump_b__0_Internal_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000781 RID: 1921 RVA: 0x000242EC File Offset: 0x000224EC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DOLocalJump_b__1(Vector3 x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass69_0.NativeMethodInfoPtr__DOLocalJump_b__1_Internal_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000782 RID: 1922 RVA: 0x0002432C File Offset: 0x0002252C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Vector3 _DOLocalJump_b__2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass69_0.NativeMethodInfoPtr__DOLocalJump_b__2_Internal_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000783 RID: 1923 RVA: 0x00024368 File Offset: 0x00022568
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DOLocalJump_b__3(Vector3 x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass69_0.NativeMethodInfoPtr__DOLocalJump_b__3_Internal_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000784 RID: 1924 RVA: 0x000243A8 File Offset: 0x000225A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Vector3 _DOLocalJump_b__4()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass69_0.NativeMethodInfoPtr__DOLocalJump_b__4_Internal_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000785 RID: 1925 RVA: 0x000243E4 File Offset: 0x000225E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DOLocalJump_b__5(Vector3 x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass69_0.NativeMethodInfoPtr__DOLocalJump_b__5_Internal_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000786 RID: 1926 RVA: 0x00024424 File Offset: 0x00022624
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1128355, XrefRangeEnd = 1128359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DOLocalJump_b__6()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass69_0.NativeMethodInfoPtr__DOLocalJump_b__6_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000787 RID: 1927 RVA: 0x0000499C File Offset: 0x00002B9C
			public __c__DisplayClass69_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700015F RID: 351
			// (get) Token: 0x06000788 RID: 1928 RVA: 0x00024458 File Offset: 0x00022658
			// (set) Token: 0x06000789 RID: 1929 RVA: 0x000049A5 File Offset: 0x00002BA5
			public unsafe Transform target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass69_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass69_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000160 RID: 352
			// (get) Token: 0x0600078A RID: 1930 RVA: 0x00024488 File Offset: 0x00022688
			// (set) Token: 0x0600078B RID: 1931 RVA: 0x000049C4 File Offset: 0x00002BC4
			public unsafe bool offsetYSet
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass69_0.NativeFieldInfoPtr_offsetYSet);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass69_0.NativeFieldInfoPtr_offsetYSet)) = value;
				}
			}

			// Token: 0x17000161 RID: 353
			// (get) Token: 0x0600078C RID: 1932 RVA: 0x000244B0 File Offset: 0x000226B0
			// (set) Token: 0x0600078D RID: 1933 RVA: 0x000049DF File Offset: 0x00002BDF
			public unsafe float offsetY
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass69_0.NativeFieldInfoPtr_offsetY);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass69_0.NativeFieldInfoPtr_offsetY)) = value;
				}
			}

			// Token: 0x17000162 RID: 354
			// (get) Token: 0x0600078E RID: 1934 RVA: 0x000244D8 File Offset: 0x000226D8
			// (set) Token: 0x0600078F RID: 1935 RVA: 0x000049FA File Offset: 0x00002BFA
			public unsafe Sequence s
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass69_0.NativeFieldInfoPtr_s);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sequence>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass69_0.NativeFieldInfoPtr_s), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000163 RID: 355
			// (get) Token: 0x06000790 RID: 1936 RVA: 0x00024508 File Offset: 0x00022708
			// (set) Token: 0x06000791 RID: 1937 RVA: 0x00004A19 File Offset: 0x00002C19
			public unsafe Vector3 endValue
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass69_0.NativeFieldInfoPtr_endValue);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass69_0.NativeFieldInfoPtr_endValue)) = value;
				}
			}

			// Token: 0x17000164 RID: 356
			// (get) Token: 0x06000792 RID: 1938 RVA: 0x00024530 File Offset: 0x00022730
			// (set) Token: 0x06000793 RID: 1939 RVA: 0x00004A34 File Offset: 0x00002C34
			public unsafe float startPosY
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass69_0.NativeFieldInfoPtr_startPosY);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass69_0.NativeFieldInfoPtr_startPosY)) = value;
				}
			}

			// Token: 0x0400058A RID: 1418
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x0400058B RID: 1419
			private static readonly IntPtr NativeFieldInfoPtr_offsetYSet;

			// Token: 0x0400058C RID: 1420
			private static readonly IntPtr NativeFieldInfoPtr_offsetY;

			// Token: 0x0400058D RID: 1421
			private static readonly IntPtr NativeFieldInfoPtr_s;

			// Token: 0x0400058E RID: 1422
			private static readonly IntPtr NativeFieldInfoPtr_endValue;

			// Token: 0x0400058F RID: 1423
			private static readonly IntPtr NativeFieldInfoPtr_startPosY;

			// Token: 0x04000590 RID: 1424
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000591 RID: 1425
			private static readonly IntPtr NativeMethodInfoPtr__DOLocalJump_b__0_Internal_Vector3_0;

			// Token: 0x04000592 RID: 1426
			private static readonly IntPtr NativeMethodInfoPtr__DOLocalJump_b__1_Internal_Void_Vector3_0;

			// Token: 0x04000593 RID: 1427
			private static readonly IntPtr NativeMethodInfoPtr__DOLocalJump_b__2_Internal_Vector3_0;

			// Token: 0x04000594 RID: 1428
			private static readonly IntPtr NativeMethodInfoPtr__DOLocalJump_b__3_Internal_Void_Vector3_0;

			// Token: 0x04000595 RID: 1429
			private static readonly IntPtr NativeMethodInfoPtr__DOLocalJump_b__4_Internal_Vector3_0;

			// Token: 0x04000596 RID: 1430
			private static readonly IntPtr NativeMethodInfoPtr__DOLocalJump_b__5_Internal_Void_Vector3_0;

			// Token: 0x04000597 RID: 1431
			private static readonly IntPtr NativeMethodInfoPtr__DOLocalJump_b__6_Internal_Void_0;
		}

		// Token: 0x020000A9 RID: 169
		[ObfuscatedName("DG.Tweening.ShortcutExtensions+<>c__DisplayClass70_0")]
		public sealed class __c__DisplayClass70_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06000794 RID: 1940 RVA: 0x00024558 File Offset: 0x00022758
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass70_0()
			{
				Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass70_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, "<>c__DisplayClass70_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass70_0>.NativeClassPtr);
				ShortcutExtensions.__c__DisplayClass70_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass70_0>.NativeClassPtr, "target");
				ShortcutExtensions.__c__DisplayClass70_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass70_0>.NativeClassPtr, 100663783);
				ShortcutExtensions.__c__DisplayClass70_0.NativeMethodInfoPtr__DOPath_b__0_Internal_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass70_0>.NativeClassPtr, 100663784);
				ShortcutExtensions.__c__DisplayClass70_0.NativeMethodInfoPtr__DOPath_b__1_Internal_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass70_0>.NativeClassPtr, 100663785);
			}

			// Token: 0x06000795 RID: 1941 RVA: 0x000245D4 File Offset: 0x000227D4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass70_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass70_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass70_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000796 RID: 1942 RVA: 0x00024610 File Offset: 0x00022810
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Vector3 _DOPath_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass70_0.NativeMethodInfoPtr__DOPath_b__0_Internal_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000797 RID: 1943 RVA: 0x0002464C File Offset: 0x0002284C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DOPath_b__1(Vector3 x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass70_0.NativeMethodInfoPtr__DOPath_b__1_Internal_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000798 RID: 1944 RVA: 0x00004A4F File Offset: 0x00002C4F
			public __c__DisplayClass70_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000165 RID: 357
			// (get) Token: 0x06000799 RID: 1945 RVA: 0x0002468C File Offset: 0x0002288C
			// (set) Token: 0x0600079A RID: 1946 RVA: 0x00004A58 File Offset: 0x00002C58
			public unsafe Transform target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass70_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass70_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000598 RID: 1432
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x04000599 RID: 1433
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400059A RID: 1434
			private static readonly IntPtr NativeMethodInfoPtr__DOPath_b__0_Internal_Vector3_0;

			// Token: 0x0400059B RID: 1435
			private static readonly IntPtr NativeMethodInfoPtr__DOPath_b__1_Internal_Void_Vector3_0;
		}

		// Token: 0x020000AA RID: 170
		[ObfuscatedName("DG.Tweening.ShortcutExtensions+<>c__DisplayClass71_0")]
		public sealed class __c__DisplayClass71_0 : global::Il2CppSystem.Object
		{
			// Token: 0x0600079B RID: 1947 RVA: 0x000246BC File Offset: 0x000228BC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass71_0()
			{
				Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass71_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, "<>c__DisplayClass71_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass71_0>.NativeClassPtr);
				ShortcutExtensions.__c__DisplayClass71_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass71_0>.NativeClassPtr, "target");
				ShortcutExtensions.__c__DisplayClass71_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass71_0>.NativeClassPtr, 100663786);
				ShortcutExtensions.__c__DisplayClass71_0.NativeMethodInfoPtr__DOLocalPath_b__0_Internal_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass71_0>.NativeClassPtr, 100663787);
				ShortcutExtensions.__c__DisplayClass71_0.NativeMethodInfoPtr__DOLocalPath_b__1_Internal_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass71_0>.NativeClassPtr, 100663788);
			}

			// Token: 0x0600079C RID: 1948 RVA: 0x00024738 File Offset: 0x00022938
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass71_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass71_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass71_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600079D RID: 1949 RVA: 0x00024774 File Offset: 0x00022974
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Vector3 _DOLocalPath_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass71_0.NativeMethodInfoPtr__DOLocalPath_b__0_Internal_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600079E RID: 1950 RVA: 0x000247B0 File Offset: 0x000229B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DOLocalPath_b__1(Vector3 x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass71_0.NativeMethodInfoPtr__DOLocalPath_b__1_Internal_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600079F RID: 1951 RVA: 0x00004A77 File Offset: 0x00002C77
			public __c__DisplayClass71_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000166 RID: 358
			// (get) Token: 0x060007A0 RID: 1952 RVA: 0x000247F0 File Offset: 0x000229F0
			// (set) Token: 0x060007A1 RID: 1953 RVA: 0x00004A80 File Offset: 0x00002C80
			public unsafe Transform target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass71_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass71_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400059C RID: 1436
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x0400059D RID: 1437
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400059E RID: 1438
			private static readonly IntPtr NativeMethodInfoPtr__DOLocalPath_b__0_Internal_Vector3_0;

			// Token: 0x0400059F RID: 1439
			private static readonly IntPtr NativeMethodInfoPtr__DOLocalPath_b__1_Internal_Void_Vector3_0;
		}

		// Token: 0x020000AB RID: 171
		[ObfuscatedName("DG.Tweening.ShortcutExtensions+<>c__DisplayClass72_0")]
		public sealed class __c__DisplayClass72_0 : global::Il2CppSystem.Object
		{
			// Token: 0x060007A2 RID: 1954 RVA: 0x00024820 File Offset: 0x00022A20
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass72_0()
			{
				Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass72_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, "<>c__DisplayClass72_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass72_0>.NativeClassPtr);
				ShortcutExtensions.__c__DisplayClass72_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass72_0>.NativeClassPtr, "target");
				ShortcutExtensions.__c__DisplayClass72_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass72_0>.NativeClassPtr, 100663789);
				ShortcutExtensions.__c__DisplayClass72_0.NativeMethodInfoPtr__DOPath_b__0_Internal_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass72_0>.NativeClassPtr, 100663790);
				ShortcutExtensions.__c__DisplayClass72_0.NativeMethodInfoPtr__DOPath_b__1_Internal_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass72_0>.NativeClassPtr, 100663791);
			}

			// Token: 0x060007A3 RID: 1955 RVA: 0x0002489C File Offset: 0x00022A9C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass72_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass72_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass72_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060007A4 RID: 1956 RVA: 0x000248D8 File Offset: 0x00022AD8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Vector3 _DOPath_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass72_0.NativeMethodInfoPtr__DOPath_b__0_Internal_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060007A5 RID: 1957 RVA: 0x00024914 File Offset: 0x00022B14
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DOPath_b__1(Vector3 x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass72_0.NativeMethodInfoPtr__DOPath_b__1_Internal_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060007A6 RID: 1958 RVA: 0x00004A9F File Offset: 0x00002C9F
			public __c__DisplayClass72_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000167 RID: 359
			// (get) Token: 0x060007A7 RID: 1959 RVA: 0x00024954 File Offset: 0x00022B54
			// (set) Token: 0x060007A8 RID: 1960 RVA: 0x00004AA8 File Offset: 0x00002CA8
			public unsafe Transform target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass72_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass72_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040005A0 RID: 1440
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x040005A1 RID: 1441
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040005A2 RID: 1442
			private static readonly IntPtr NativeMethodInfoPtr__DOPath_b__0_Internal_Vector3_0;

			// Token: 0x040005A3 RID: 1443
			private static readonly IntPtr NativeMethodInfoPtr__DOPath_b__1_Internal_Void_Vector3_0;
		}

		// Token: 0x020000AC RID: 172
		[ObfuscatedName("DG.Tweening.ShortcutExtensions+<>c__DisplayClass73_0")]
		public sealed class __c__DisplayClass73_0 : global::Il2CppSystem.Object
		{
			// Token: 0x060007A9 RID: 1961 RVA: 0x00024984 File Offset: 0x00022B84
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass73_0()
			{
				Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass73_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, "<>c__DisplayClass73_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass73_0>.NativeClassPtr);
				ShortcutExtensions.__c__DisplayClass73_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass73_0>.NativeClassPtr, "target");
				ShortcutExtensions.__c__DisplayClass73_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass73_0>.NativeClassPtr, 100663792);
				ShortcutExtensions.__c__DisplayClass73_0.NativeMethodInfoPtr__DOLocalPath_b__0_Internal_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass73_0>.NativeClassPtr, 100663793);
				ShortcutExtensions.__c__DisplayClass73_0.NativeMethodInfoPtr__DOLocalPath_b__1_Internal_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass73_0>.NativeClassPtr, 100663794);
			}

			// Token: 0x060007AA RID: 1962 RVA: 0x00024A00 File Offset: 0x00022C00
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass73_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass73_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass73_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060007AB RID: 1963 RVA: 0x00024A3C File Offset: 0x00022C3C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Vector3 _DOLocalPath_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass73_0.NativeMethodInfoPtr__DOLocalPath_b__0_Internal_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060007AC RID: 1964 RVA: 0x00024A78 File Offset: 0x00022C78
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DOLocalPath_b__1(Vector3 x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass73_0.NativeMethodInfoPtr__DOLocalPath_b__1_Internal_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060007AD RID: 1965 RVA: 0x00004AC7 File Offset: 0x00002CC7
			public __c__DisplayClass73_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000168 RID: 360
			// (get) Token: 0x060007AE RID: 1966 RVA: 0x00024AB8 File Offset: 0x00022CB8
			// (set) Token: 0x060007AF RID: 1967 RVA: 0x00004AD0 File Offset: 0x00002CD0
			public unsafe Transform target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass73_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass73_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040005A4 RID: 1444
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x040005A5 RID: 1445
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040005A6 RID: 1446
			private static readonly IntPtr NativeMethodInfoPtr__DOLocalPath_b__0_Internal_Vector3_0;

			// Token: 0x040005A7 RID: 1447
			private static readonly IntPtr NativeMethodInfoPtr__DOLocalPath_b__1_Internal_Void_Vector3_0;
		}

		// Token: 0x020000AD RID: 173
		[ObfuscatedName("DG.Tweening.ShortcutExtensions+<>c__DisplayClass74_0")]
		public sealed class __c__DisplayClass74_0 : global::Il2CppSystem.Object
		{
			// Token: 0x060007B0 RID: 1968 RVA: 0x00024AE8 File Offset: 0x00022CE8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass74_0()
			{
				Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass74_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, "<>c__DisplayClass74_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass74_0>.NativeClassPtr);
				ShortcutExtensions.__c__DisplayClass74_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass74_0>.NativeClassPtr, "target");
				ShortcutExtensions.__c__DisplayClass74_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass74_0>.NativeClassPtr, 100663795);
				ShortcutExtensions.__c__DisplayClass74_0.NativeMethodInfoPtr__DOTimeScale_b__0_Internal_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass74_0>.NativeClassPtr, 100663796);
				ShortcutExtensions.__c__DisplayClass74_0.NativeMethodInfoPtr__DOTimeScale_b__1_Internal_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass74_0>.NativeClassPtr, 100663797);
			}

			// Token: 0x060007B1 RID: 1969 RVA: 0x00024B64 File Offset: 0x00022D64
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass74_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass74_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass74_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060007B2 RID: 1970 RVA: 0x00024BA0 File Offset: 0x00022DA0
			[CallerCount(0)]
			public unsafe float _DOTimeScale_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass74_0.NativeMethodInfoPtr__DOTimeScale_b__0_Internal_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060007B3 RID: 1971 RVA: 0x00024BDC File Offset: 0x00022DDC
			[CallerCount(0)]
			public unsafe void _DOTimeScale_b__1(float x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass74_0.NativeMethodInfoPtr__DOTimeScale_b__1_Internal_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060007B4 RID: 1972 RVA: 0x00004AEF File Offset: 0x00002CEF
			public __c__DisplayClass74_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000169 RID: 361
			// (get) Token: 0x060007B5 RID: 1973 RVA: 0x00024C1C File Offset: 0x00022E1C
			// (set) Token: 0x060007B6 RID: 1974 RVA: 0x00004AF8 File Offset: 0x00002CF8
			public unsafe Tween target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass74_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Tween>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass74_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040005A8 RID: 1448
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x040005A9 RID: 1449
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040005AA RID: 1450
			private static readonly IntPtr NativeMethodInfoPtr__DOTimeScale_b__0_Internal_Single_0;

			// Token: 0x040005AB RID: 1451
			private static readonly IntPtr NativeMethodInfoPtr__DOTimeScale_b__1_Internal_Void_Single_0;
		}

		// Token: 0x020000AE RID: 174
		[ObfuscatedName("DG.Tweening.ShortcutExtensions+<>c__DisplayClass75_0")]
		public sealed class __c__DisplayClass75_0 : global::Il2CppSystem.Object
		{
			// Token: 0x060007B7 RID: 1975 RVA: 0x00024C4C File Offset: 0x00022E4C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass75_0()
			{
				Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass75_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, "<>c__DisplayClass75_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass75_0>.NativeClassPtr);
				ShortcutExtensions.__c__DisplayClass75_0.NativeFieldInfoPtr_to = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass75_0>.NativeClassPtr, "to");
				ShortcutExtensions.__c__DisplayClass75_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass75_0>.NativeClassPtr, "target");
				ShortcutExtensions.__c__DisplayClass75_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass75_0>.NativeClassPtr, 100663798);
				ShortcutExtensions.__c__DisplayClass75_0.NativeMethodInfoPtr__DOBlendableColor_b__0_Internal_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass75_0>.NativeClassPtr, 100663799);
				ShortcutExtensions.__c__DisplayClass75_0.NativeMethodInfoPtr__DOBlendableColor_b__1_Internal_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass75_0>.NativeClassPtr, 100663800);
			}

			// Token: 0x060007B8 RID: 1976 RVA: 0x00024CDC File Offset: 0x00022EDC
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass75_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass75_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass75_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060007B9 RID: 1977 RVA: 0x00024D18 File Offset: 0x00022F18
			[CallerCount(0)]
			public unsafe Color _DOBlendableColor_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass75_0.NativeMethodInfoPtr__DOBlendableColor_b__0_Internal_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060007BA RID: 1978 RVA: 0x00024D54 File Offset: 0x00022F54
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1128359, XrefRangeEnd = 1128361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DOBlendableColor_b__1(Color x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass75_0.NativeMethodInfoPtr__DOBlendableColor_b__1_Internal_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060007BB RID: 1979 RVA: 0x00004B17 File Offset: 0x00002D17
			public __c__DisplayClass75_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700016A RID: 362
			// (get) Token: 0x060007BC RID: 1980 RVA: 0x00024D94 File Offset: 0x00022F94
			// (set) Token: 0x060007BD RID: 1981 RVA: 0x00004B20 File Offset: 0x00002D20
			public unsafe Color to
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass75_0.NativeFieldInfoPtr_to);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass75_0.NativeFieldInfoPtr_to)) = value;
				}
			}

			// Token: 0x1700016B RID: 363
			// (get) Token: 0x060007BE RID: 1982 RVA: 0x00024DBC File Offset: 0x00022FBC
			// (set) Token: 0x060007BF RID: 1983 RVA: 0x00004B3B File Offset: 0x00002D3B
			public unsafe Light target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass75_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Light>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass75_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040005AC RID: 1452
			private static readonly IntPtr NativeFieldInfoPtr_to;

			// Token: 0x040005AD RID: 1453
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x040005AE RID: 1454
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040005AF RID: 1455
			private static readonly IntPtr NativeMethodInfoPtr__DOBlendableColor_b__0_Internal_Color_0;

			// Token: 0x040005B0 RID: 1456
			private static readonly IntPtr NativeMethodInfoPtr__DOBlendableColor_b__1_Internal_Void_Color_0;
		}

		// Token: 0x020000AF RID: 175
		[ObfuscatedName("DG.Tweening.ShortcutExtensions+<>c__DisplayClass76_0")]
		public sealed class __c__DisplayClass76_0 : global::Il2CppSystem.Object
		{
			// Token: 0x060007C0 RID: 1984 RVA: 0x00024DEC File Offset: 0x00022FEC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass76_0()
			{
				Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass76_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, "<>c__DisplayClass76_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass76_0>.NativeClassPtr);
				ShortcutExtensions.__c__DisplayClass76_0.NativeFieldInfoPtr_to = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass76_0>.NativeClassPtr, "to");
				ShortcutExtensions.__c__DisplayClass76_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass76_0>.NativeClassPtr, "target");
				ShortcutExtensions.__c__DisplayClass76_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass76_0>.NativeClassPtr, 100663801);
				ShortcutExtensions.__c__DisplayClass76_0.NativeMethodInfoPtr__DOBlendableColor_b__0_Internal_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass76_0>.NativeClassPtr, 100663802);
				ShortcutExtensions.__c__DisplayClass76_0.NativeMethodInfoPtr__DOBlendableColor_b__1_Internal_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass76_0>.NativeClassPtr, 100663803);
			}

			// Token: 0x060007C1 RID: 1985 RVA: 0x00024E7C File Offset: 0x0002307C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass76_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass76_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass76_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060007C2 RID: 1986 RVA: 0x00024EB8 File Offset: 0x000230B8
			[CallerCount(0)]
			public unsafe Color _DOBlendableColor_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass76_0.NativeMethodInfoPtr__DOBlendableColor_b__0_Internal_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060007C3 RID: 1987 RVA: 0x00024EF4 File Offset: 0x000230F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1128361, XrefRangeEnd = 1128363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DOBlendableColor_b__1(Color x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass76_0.NativeMethodInfoPtr__DOBlendableColor_b__1_Internal_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060007C4 RID: 1988 RVA: 0x00004B5A File Offset: 0x00002D5A
			public __c__DisplayClass76_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700016C RID: 364
			// (get) Token: 0x060007C5 RID: 1989 RVA: 0x00024F34 File Offset: 0x00023134
			// (set) Token: 0x060007C6 RID: 1990 RVA: 0x00004B63 File Offset: 0x00002D63
			public unsafe Color to
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass76_0.NativeFieldInfoPtr_to);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass76_0.NativeFieldInfoPtr_to)) = value;
				}
			}

			// Token: 0x1700016D RID: 365
			// (get) Token: 0x060007C7 RID: 1991 RVA: 0x00024F5C File Offset: 0x0002315C
			// (set) Token: 0x060007C8 RID: 1992 RVA: 0x00004B7E File Offset: 0x00002D7E
			public unsafe Material target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass76_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass76_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040005B1 RID: 1457
			private static readonly IntPtr NativeFieldInfoPtr_to;

			// Token: 0x040005B2 RID: 1458
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x040005B3 RID: 1459
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040005B4 RID: 1460
			private static readonly IntPtr NativeMethodInfoPtr__DOBlendableColor_b__0_Internal_Color_0;

			// Token: 0x040005B5 RID: 1461
			private static readonly IntPtr NativeMethodInfoPtr__DOBlendableColor_b__1_Internal_Void_Color_0;
		}

		// Token: 0x020000B0 RID: 176
		[ObfuscatedName("DG.Tweening.ShortcutExtensions+<>c__DisplayClass77_0")]
		public sealed class __c__DisplayClass77_0 : global::Il2CppSystem.Object
		{
			// Token: 0x060007C9 RID: 1993 RVA: 0x00024F8C File Offset: 0x0002318C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass77_0()
			{
				Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass77_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, "<>c__DisplayClass77_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass77_0>.NativeClassPtr);
				ShortcutExtensions.__c__DisplayClass77_0.NativeFieldInfoPtr_to = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass77_0>.NativeClassPtr, "to");
				ShortcutExtensions.__c__DisplayClass77_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass77_0>.NativeClassPtr, "target");
				ShortcutExtensions.__c__DisplayClass77_0.NativeFieldInfoPtr_property = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass77_0>.NativeClassPtr, "property");
				ShortcutExtensions.__c__DisplayClass77_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass77_0>.NativeClassPtr, 100663804);
				ShortcutExtensions.__c__DisplayClass77_0.NativeMethodInfoPtr__DOBlendableColor_b__0_Internal_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass77_0>.NativeClassPtr, 100663805);
				ShortcutExtensions.__c__DisplayClass77_0.NativeMethodInfoPtr__DOBlendableColor_b__1_Internal_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass77_0>.NativeClassPtr, 100663806);
			}

			// Token: 0x060007CA RID: 1994 RVA: 0x00025030 File Offset: 0x00023230
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass77_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass77_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass77_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060007CB RID: 1995 RVA: 0x0002506C File Offset: 0x0002326C
			[CallerCount(0)]
			public unsafe Color _DOBlendableColor_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass77_0.NativeMethodInfoPtr__DOBlendableColor_b__0_Internal_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060007CC RID: 1996 RVA: 0x000250A8 File Offset: 0x000232A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1128363, XrefRangeEnd = 1128365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DOBlendableColor_b__1(Color x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass77_0.NativeMethodInfoPtr__DOBlendableColor_b__1_Internal_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060007CD RID: 1997 RVA: 0x00004B9D File Offset: 0x00002D9D
			public __c__DisplayClass77_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700016E RID: 366
			// (get) Token: 0x060007CE RID: 1998 RVA: 0x000250E8 File Offset: 0x000232E8
			// (set) Token: 0x060007CF RID: 1999 RVA: 0x00004BA6 File Offset: 0x00002DA6
			public unsafe Color to
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass77_0.NativeFieldInfoPtr_to);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass77_0.NativeFieldInfoPtr_to)) = value;
				}
			}

			// Token: 0x1700016F RID: 367
			// (get) Token: 0x060007D0 RID: 2000 RVA: 0x00025110 File Offset: 0x00023310
			// (set) Token: 0x060007D1 RID: 2001 RVA: 0x00004BC1 File Offset: 0x00002DC1
			public unsafe Material target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass77_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass77_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000170 RID: 368
			// (get) Token: 0x060007D2 RID: 2002 RVA: 0x00025140 File Offset: 0x00023340
			// (set) Token: 0x060007D3 RID: 2003 RVA: 0x00004BE0 File Offset: 0x00002DE0
			public unsafe string property
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass77_0.NativeFieldInfoPtr_property);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass77_0.NativeFieldInfoPtr_property), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x040005B6 RID: 1462
			private static readonly IntPtr NativeFieldInfoPtr_to;

			// Token: 0x040005B7 RID: 1463
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x040005B8 RID: 1464
			private static readonly IntPtr NativeFieldInfoPtr_property;

			// Token: 0x040005B9 RID: 1465
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040005BA RID: 1466
			private static readonly IntPtr NativeMethodInfoPtr__DOBlendableColor_b__0_Internal_Color_0;

			// Token: 0x040005BB RID: 1467
			private static readonly IntPtr NativeMethodInfoPtr__DOBlendableColor_b__1_Internal_Void_Color_0;
		}

		// Token: 0x020000B1 RID: 177
		[ObfuscatedName("DG.Tweening.ShortcutExtensions+<>c__DisplayClass78_0")]
		public sealed class __c__DisplayClass78_0 : global::Il2CppSystem.Object
		{
			// Token: 0x060007D4 RID: 2004 RVA: 0x00025168 File Offset: 0x00023368
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass78_0()
			{
				Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass78_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, "<>c__DisplayClass78_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass78_0>.NativeClassPtr);
				ShortcutExtensions.__c__DisplayClass78_0.NativeFieldInfoPtr_to = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass78_0>.NativeClassPtr, "to");
				ShortcutExtensions.__c__DisplayClass78_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass78_0>.NativeClassPtr, "target");
				ShortcutExtensions.__c__DisplayClass78_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass78_0>.NativeClassPtr, 100663807);
				ShortcutExtensions.__c__DisplayClass78_0.NativeMethodInfoPtr__DOBlendableMoveBy_b__0_Internal_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass78_0>.NativeClassPtr, 100663808);
				ShortcutExtensions.__c__DisplayClass78_0.NativeMethodInfoPtr__DOBlendableMoveBy_b__1_Internal_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass78_0>.NativeClassPtr, 100663809);
			}

			// Token: 0x060007D5 RID: 2005 RVA: 0x000251F8 File Offset: 0x000233F8
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass78_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass78_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass78_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060007D6 RID: 2006 RVA: 0x00025234 File Offset: 0x00023434
			[CallerCount(0)]
			public unsafe Vector3 _DOBlendableMoveBy_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass78_0.NativeMethodInfoPtr__DOBlendableMoveBy_b__0_Internal_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060007D7 RID: 2007 RVA: 0x00025270 File Offset: 0x00023470
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1128365, XrefRangeEnd = 1128367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DOBlendableMoveBy_b__1(Vector3 x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass78_0.NativeMethodInfoPtr__DOBlendableMoveBy_b__1_Internal_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060007D8 RID: 2008 RVA: 0x00004BFF File Offset: 0x00002DFF
			public __c__DisplayClass78_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000171 RID: 369
			// (get) Token: 0x060007D9 RID: 2009 RVA: 0x000252B0 File Offset: 0x000234B0
			// (set) Token: 0x060007DA RID: 2010 RVA: 0x00004C08 File Offset: 0x00002E08
			public unsafe Vector3 to
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass78_0.NativeFieldInfoPtr_to);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass78_0.NativeFieldInfoPtr_to)) = value;
				}
			}

			// Token: 0x17000172 RID: 370
			// (get) Token: 0x060007DB RID: 2011 RVA: 0x000252D8 File Offset: 0x000234D8
			// (set) Token: 0x060007DC RID: 2012 RVA: 0x00004C23 File Offset: 0x00002E23
			public unsafe Transform target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass78_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass78_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040005BC RID: 1468
			private static readonly IntPtr NativeFieldInfoPtr_to;

			// Token: 0x040005BD RID: 1469
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x040005BE RID: 1470
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040005BF RID: 1471
			private static readonly IntPtr NativeMethodInfoPtr__DOBlendableMoveBy_b__0_Internal_Vector3_0;

			// Token: 0x040005C0 RID: 1472
			private static readonly IntPtr NativeMethodInfoPtr__DOBlendableMoveBy_b__1_Internal_Void_Vector3_0;
		}

		// Token: 0x020000B2 RID: 178
		[ObfuscatedName("DG.Tweening.ShortcutExtensions+<>c__DisplayClass79_0")]
		public sealed class __c__DisplayClass79_0 : global::Il2CppSystem.Object
		{
			// Token: 0x060007DD RID: 2013 RVA: 0x00025308 File Offset: 0x00023508
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass79_0()
			{
				Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass79_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, "<>c__DisplayClass79_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass79_0>.NativeClassPtr);
				ShortcutExtensions.__c__DisplayClass79_0.NativeFieldInfoPtr_to = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass79_0>.NativeClassPtr, "to");
				ShortcutExtensions.__c__DisplayClass79_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass79_0>.NativeClassPtr, "target");
				ShortcutExtensions.__c__DisplayClass79_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass79_0>.NativeClassPtr, 100663810);
				ShortcutExtensions.__c__DisplayClass79_0.NativeMethodInfoPtr__DOBlendableLocalMoveBy_b__0_Internal_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass79_0>.NativeClassPtr, 100663811);
				ShortcutExtensions.__c__DisplayClass79_0.NativeMethodInfoPtr__DOBlendableLocalMoveBy_b__1_Internal_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass79_0>.NativeClassPtr, 100663812);
			}

			// Token: 0x060007DE RID: 2014 RVA: 0x00025398 File Offset: 0x00023598
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass79_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass79_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass79_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060007DF RID: 2015 RVA: 0x000253D4 File Offset: 0x000235D4
			[CallerCount(0)]
			public unsafe Vector3 _DOBlendableLocalMoveBy_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass79_0.NativeMethodInfoPtr__DOBlendableLocalMoveBy_b__0_Internal_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060007E0 RID: 2016 RVA: 0x00025410 File Offset: 0x00023610
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1128367, XrefRangeEnd = 1128369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DOBlendableLocalMoveBy_b__1(Vector3 x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass79_0.NativeMethodInfoPtr__DOBlendableLocalMoveBy_b__1_Internal_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060007E1 RID: 2017 RVA: 0x00004C42 File Offset: 0x00002E42
			public __c__DisplayClass79_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000173 RID: 371
			// (get) Token: 0x060007E2 RID: 2018 RVA: 0x00025450 File Offset: 0x00023650
			// (set) Token: 0x060007E3 RID: 2019 RVA: 0x00004C4B File Offset: 0x00002E4B
			public unsafe Vector3 to
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass79_0.NativeFieldInfoPtr_to);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass79_0.NativeFieldInfoPtr_to)) = value;
				}
			}

			// Token: 0x17000174 RID: 372
			// (get) Token: 0x060007E4 RID: 2020 RVA: 0x00025478 File Offset: 0x00023678
			// (set) Token: 0x060007E5 RID: 2021 RVA: 0x00004C66 File Offset: 0x00002E66
			public unsafe Transform target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass79_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass79_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040005C1 RID: 1473
			private static readonly IntPtr NativeFieldInfoPtr_to;

			// Token: 0x040005C2 RID: 1474
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x040005C3 RID: 1475
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040005C4 RID: 1476
			private static readonly IntPtr NativeMethodInfoPtr__DOBlendableLocalMoveBy_b__0_Internal_Vector3_0;

			// Token: 0x040005C5 RID: 1477
			private static readonly IntPtr NativeMethodInfoPtr__DOBlendableLocalMoveBy_b__1_Internal_Void_Vector3_0;
		}

		// Token: 0x020000B3 RID: 179
		[ObfuscatedName("DG.Tweening.ShortcutExtensions+<>c__DisplayClass80_0")]
		public sealed class __c__DisplayClass80_0 : global::Il2CppSystem.Object
		{
			// Token: 0x060007E6 RID: 2022 RVA: 0x000254A8 File Offset: 0x000236A8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass80_0()
			{
				Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass80_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, "<>c__DisplayClass80_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass80_0>.NativeClassPtr);
				ShortcutExtensions.__c__DisplayClass80_0.NativeFieldInfoPtr_to = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass80_0>.NativeClassPtr, "to");
				ShortcutExtensions.__c__DisplayClass80_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass80_0>.NativeClassPtr, "target");
				ShortcutExtensions.__c__DisplayClass80_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass80_0>.NativeClassPtr, 100663813);
				ShortcutExtensions.__c__DisplayClass80_0.NativeMethodInfoPtr__DOBlendableRotateBy_b__0_Internal_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass80_0>.NativeClassPtr, 100663814);
				ShortcutExtensions.__c__DisplayClass80_0.NativeMethodInfoPtr__DOBlendableRotateBy_b__1_Internal_Void_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass80_0>.NativeClassPtr, 100663815);
			}

			// Token: 0x060007E7 RID: 2023 RVA: 0x00025538 File Offset: 0x00023738
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass80_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass80_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass80_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060007E8 RID: 2024 RVA: 0x00025574 File Offset: 0x00023774
			[CallerCount(0)]
			public unsafe Quaternion _DOBlendableRotateBy_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass80_0.NativeMethodInfoPtr__DOBlendableRotateBy_b__0_Internal_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060007E9 RID: 2025 RVA: 0x000255B0 File Offset: 0x000237B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1128369, XrefRangeEnd = 1128375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DOBlendableRotateBy_b__1(Quaternion x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass80_0.NativeMethodInfoPtr__DOBlendableRotateBy_b__1_Internal_Void_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060007EA RID: 2026 RVA: 0x00004C85 File Offset: 0x00002E85
			public __c__DisplayClass80_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000175 RID: 373
			// (get) Token: 0x060007EB RID: 2027 RVA: 0x000255F0 File Offset: 0x000237F0
			// (set) Token: 0x060007EC RID: 2028 RVA: 0x00004C8E File Offset: 0x00002E8E
			public unsafe Quaternion to
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass80_0.NativeFieldInfoPtr_to);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass80_0.NativeFieldInfoPtr_to)) = value;
				}
			}

			// Token: 0x17000176 RID: 374
			// (get) Token: 0x060007ED RID: 2029 RVA: 0x00025618 File Offset: 0x00023818
			// (set) Token: 0x060007EE RID: 2030 RVA: 0x00004CA9 File Offset: 0x00002EA9
			public unsafe Transform target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass80_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass80_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040005C6 RID: 1478
			private static readonly IntPtr NativeFieldInfoPtr_to;

			// Token: 0x040005C7 RID: 1479
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x040005C8 RID: 1480
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040005C9 RID: 1481
			private static readonly IntPtr NativeMethodInfoPtr__DOBlendableRotateBy_b__0_Internal_Quaternion_0;

			// Token: 0x040005CA RID: 1482
			private static readonly IntPtr NativeMethodInfoPtr__DOBlendableRotateBy_b__1_Internal_Void_Quaternion_0;
		}

		// Token: 0x020000B4 RID: 180
		[ObfuscatedName("DG.Tweening.ShortcutExtensions+<>c__DisplayClass81_0")]
		public sealed class __c__DisplayClass81_0 : global::Il2CppSystem.Object
		{
			// Token: 0x060007EF RID: 2031 RVA: 0x00025648 File Offset: 0x00023848
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass81_0()
			{
				Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass81_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, "<>c__DisplayClass81_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass81_0>.NativeClassPtr);
				ShortcutExtensions.__c__DisplayClass81_0.NativeFieldInfoPtr_to = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass81_0>.NativeClassPtr, "to");
				ShortcutExtensions.__c__DisplayClass81_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass81_0>.NativeClassPtr, "target");
				ShortcutExtensions.__c__DisplayClass81_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass81_0>.NativeClassPtr, 100663816);
				ShortcutExtensions.__c__DisplayClass81_0.NativeMethodInfoPtr__DOBlendableLocalRotateBy_b__0_Internal_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass81_0>.NativeClassPtr, 100663817);
				ShortcutExtensions.__c__DisplayClass81_0.NativeMethodInfoPtr__DOBlendableLocalRotateBy_b__1_Internal_Void_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass81_0>.NativeClassPtr, 100663818);
			}

			// Token: 0x060007F0 RID: 2032 RVA: 0x000256D8 File Offset: 0x000238D8
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass81_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass81_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass81_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060007F1 RID: 2033 RVA: 0x00025714 File Offset: 0x00023914
			[CallerCount(0)]
			public unsafe Quaternion _DOBlendableLocalRotateBy_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass81_0.NativeMethodInfoPtr__DOBlendableLocalRotateBy_b__0_Internal_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060007F2 RID: 2034 RVA: 0x00025750 File Offset: 0x00023950
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1128375, XrefRangeEnd = 1128381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DOBlendableLocalRotateBy_b__1(Quaternion x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass81_0.NativeMethodInfoPtr__DOBlendableLocalRotateBy_b__1_Internal_Void_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060007F3 RID: 2035 RVA: 0x00004CC8 File Offset: 0x00002EC8
			public __c__DisplayClass81_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000177 RID: 375
			// (get) Token: 0x060007F4 RID: 2036 RVA: 0x00025790 File Offset: 0x00023990
			// (set) Token: 0x060007F5 RID: 2037 RVA: 0x00004CD1 File Offset: 0x00002ED1
			public unsafe Quaternion to
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass81_0.NativeFieldInfoPtr_to);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass81_0.NativeFieldInfoPtr_to)) = value;
				}
			}

			// Token: 0x17000178 RID: 376
			// (get) Token: 0x060007F6 RID: 2038 RVA: 0x000257B8 File Offset: 0x000239B8
			// (set) Token: 0x060007F7 RID: 2039 RVA: 0x00004CEC File Offset: 0x00002EEC
			public unsafe Transform target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass81_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass81_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040005CB RID: 1483
			private static readonly IntPtr NativeFieldInfoPtr_to;

			// Token: 0x040005CC RID: 1484
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x040005CD RID: 1485
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040005CE RID: 1486
			private static readonly IntPtr NativeMethodInfoPtr__DOBlendableLocalRotateBy_b__0_Internal_Quaternion_0;

			// Token: 0x040005CF RID: 1487
			private static readonly IntPtr NativeMethodInfoPtr__DOBlendableLocalRotateBy_b__1_Internal_Void_Quaternion_0;
		}

		// Token: 0x020000B5 RID: 181
		[ObfuscatedName("DG.Tweening.ShortcutExtensions+<>c__DisplayClass82_0")]
		public sealed class __c__DisplayClass82_0 : global::Il2CppSystem.Object
		{
			// Token: 0x060007F8 RID: 2040 RVA: 0x000257E8 File Offset: 0x000239E8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass82_0()
			{
				Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass82_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, "<>c__DisplayClass82_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass82_0>.NativeClassPtr);
				ShortcutExtensions.__c__DisplayClass82_0.NativeFieldInfoPtr_to = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass82_0>.NativeClassPtr, "to");
				ShortcutExtensions.__c__DisplayClass82_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass82_0>.NativeClassPtr, "target");
				ShortcutExtensions.__c__DisplayClass82_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass82_0>.NativeClassPtr, 100663819);
				ShortcutExtensions.__c__DisplayClass82_0.NativeMethodInfoPtr__DOBlendablePunchRotation_b__0_Internal_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass82_0>.NativeClassPtr, 100663820);
				ShortcutExtensions.__c__DisplayClass82_0.NativeMethodInfoPtr__DOBlendablePunchRotation_b__1_Internal_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass82_0>.NativeClassPtr, 100663821);
			}

			// Token: 0x060007F9 RID: 2041 RVA: 0x00025878 File Offset: 0x00023A78
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass82_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass82_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass82_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060007FA RID: 2042 RVA: 0x000258B4 File Offset: 0x00023AB4
			[CallerCount(0)]
			public unsafe Vector3 _DOBlendablePunchRotation_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass82_0.NativeMethodInfoPtr__DOBlendablePunchRotation_b__0_Internal_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060007FB RID: 2043 RVA: 0x000258F0 File Offset: 0x00023AF0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1128381, XrefRangeEnd = 1128389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DOBlendablePunchRotation_b__1(Vector3 v)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref v;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass82_0.NativeMethodInfoPtr__DOBlendablePunchRotation_b__1_Internal_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060007FC RID: 2044 RVA: 0x00004D0B File Offset: 0x00002F0B
			public __c__DisplayClass82_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000179 RID: 377
			// (get) Token: 0x060007FD RID: 2045 RVA: 0x00025930 File Offset: 0x00023B30
			// (set) Token: 0x060007FE RID: 2046 RVA: 0x00004D14 File Offset: 0x00002F14
			public unsafe Vector3 to
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass82_0.NativeFieldInfoPtr_to);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass82_0.NativeFieldInfoPtr_to)) = value;
				}
			}

			// Token: 0x1700017A RID: 378
			// (get) Token: 0x060007FF RID: 2047 RVA: 0x00025958 File Offset: 0x00023B58
			// (set) Token: 0x06000800 RID: 2048 RVA: 0x00004D2F File Offset: 0x00002F2F
			public unsafe Transform target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass82_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass82_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040005D0 RID: 1488
			private static readonly IntPtr NativeFieldInfoPtr_to;

			// Token: 0x040005D1 RID: 1489
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x040005D2 RID: 1490
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040005D3 RID: 1491
			private static readonly IntPtr NativeMethodInfoPtr__DOBlendablePunchRotation_b__0_Internal_Vector3_0;

			// Token: 0x040005D4 RID: 1492
			private static readonly IntPtr NativeMethodInfoPtr__DOBlendablePunchRotation_b__1_Internal_Void_Vector3_0;
		}

		// Token: 0x020000B6 RID: 182
		[ObfuscatedName("DG.Tweening.ShortcutExtensions+<>c__DisplayClass83_0")]
		public sealed class __c__DisplayClass83_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06000801 RID: 2049 RVA: 0x00025988 File Offset: 0x00023B88
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass83_0()
			{
				Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass83_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, "<>c__DisplayClass83_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass83_0>.NativeClassPtr);
				ShortcutExtensions.__c__DisplayClass83_0.NativeFieldInfoPtr_to = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass83_0>.NativeClassPtr, "to");
				ShortcutExtensions.__c__DisplayClass83_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass83_0>.NativeClassPtr, "target");
				ShortcutExtensions.__c__DisplayClass83_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass83_0>.NativeClassPtr, 100663822);
				ShortcutExtensions.__c__DisplayClass83_0.NativeMethodInfoPtr__DOBlendableScaleBy_b__0_Internal_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass83_0>.NativeClassPtr, 100663823);
				ShortcutExtensions.__c__DisplayClass83_0.NativeMethodInfoPtr__DOBlendableScaleBy_b__1_Internal_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass83_0>.NativeClassPtr, 100663824);
			}

			// Token: 0x06000802 RID: 2050 RVA: 0x00025A18 File Offset: 0x00023C18
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass83_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass83_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass83_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000803 RID: 2051 RVA: 0x00025A54 File Offset: 0x00023C54
			[CallerCount(0)]
			public unsafe Vector3 _DOBlendableScaleBy_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass83_0.NativeMethodInfoPtr__DOBlendableScaleBy_b__0_Internal_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000804 RID: 2052 RVA: 0x00025A90 File Offset: 0x00023C90
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1128389, XrefRangeEnd = 1128391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DOBlendableScaleBy_b__1(Vector3 x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass83_0.NativeMethodInfoPtr__DOBlendableScaleBy_b__1_Internal_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000805 RID: 2053 RVA: 0x00004D4E File Offset: 0x00002F4E
			public __c__DisplayClass83_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700017B RID: 379
			// (get) Token: 0x06000806 RID: 2054 RVA: 0x00025AD0 File Offset: 0x00023CD0
			// (set) Token: 0x06000807 RID: 2055 RVA: 0x00004D57 File Offset: 0x00002F57
			public unsafe Vector3 to
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass83_0.NativeFieldInfoPtr_to);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass83_0.NativeFieldInfoPtr_to)) = value;
				}
			}

			// Token: 0x1700017C RID: 380
			// (get) Token: 0x06000808 RID: 2056 RVA: 0x00025AF8 File Offset: 0x00023CF8
			// (set) Token: 0x06000809 RID: 2057 RVA: 0x00004D72 File Offset: 0x00002F72
			public unsafe Transform target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass83_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass83_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040005D5 RID: 1493
			private static readonly IntPtr NativeFieldInfoPtr_to;

			// Token: 0x040005D6 RID: 1494
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x040005D7 RID: 1495
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040005D8 RID: 1496
			private static readonly IntPtr NativeMethodInfoPtr__DOBlendableScaleBy_b__0_Internal_Vector3_0;

			// Token: 0x040005D9 RID: 1497
			private static readonly IntPtr NativeMethodInfoPtr__DOBlendableScaleBy_b__1_Internal_Void_Vector3_0;
		}
	}
}
