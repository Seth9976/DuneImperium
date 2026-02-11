using System;
using System.Runtime.InteropServices;
using DG.Tweening.Core;
using DG.Tweening.Core.Enums;
using DG.Tweening.Plugins.Core;
using DG.Tweening.Plugins.Options;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using UnityEngine;

namespace DG.Tweening
{
	// Token: 0x02000008 RID: 8
	public class DOTween : global::Il2CppSystem.Object
	{
		// Token: 0x06000022 RID: 34 RVA: 0x00005B58 File Offset: 0x00003D58
		// Note: this type is marked as 'beforefieldinit'.
		static DOTween()
		{
			Il2CppClassPointerStore<DOTween>.NativeClassPtr = IL2CPP.GetIl2CppClass("DOTween.dll", "DG.Tweening", "DOTween");
			DOTween.NativeFieldInfoPtr_Version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTween>.NativeClassPtr, "Version");
			DOTween.NativeFieldInfoPtr_useSafeMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTween>.NativeClassPtr, "useSafeMode");
			DOTween.NativeFieldInfoPtr_showUnityEditorReport = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTween>.NativeClassPtr, "showUnityEditorReport");
			DOTween.NativeFieldInfoPtr_timeScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTween>.NativeClassPtr, "timeScale");
			DOTween.NativeFieldInfoPtr_useSmoothDeltaTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTween>.NativeClassPtr, "useSmoothDeltaTime");
			DOTween.NativeFieldInfoPtr_maxSmoothUnscaledTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTween>.NativeClassPtr, "maxSmoothUnscaledTime");
			DOTween.NativeFieldInfoPtr_rewindCallbackMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTween>.NativeClassPtr, "rewindCallbackMode");
			DOTween.NativeFieldInfoPtr__logBehaviour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTween>.NativeClassPtr, "_logBehaviour");
			DOTween.NativeFieldInfoPtr_drawGizmos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTween>.NativeClassPtr, "drawGizmos");
			DOTween.NativeFieldInfoPtr_defaultUpdateType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTween>.NativeClassPtr, "defaultUpdateType");
			DOTween.NativeFieldInfoPtr_defaultTimeScaleIndependent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTween>.NativeClassPtr, "defaultTimeScaleIndependent");
			DOTween.NativeFieldInfoPtr_defaultAutoPlay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTween>.NativeClassPtr, "defaultAutoPlay");
			DOTween.NativeFieldInfoPtr_defaultAutoKill = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTween>.NativeClassPtr, "defaultAutoKill");
			DOTween.NativeFieldInfoPtr_defaultLoopType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTween>.NativeClassPtr, "defaultLoopType");
			DOTween.NativeFieldInfoPtr_defaultRecyclable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTween>.NativeClassPtr, "defaultRecyclable");
			DOTween.NativeFieldInfoPtr_defaultEaseType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTween>.NativeClassPtr, "defaultEaseType");
			DOTween.NativeFieldInfoPtr_defaultEaseOvershootOrAmplitude = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTween>.NativeClassPtr, "defaultEaseOvershootOrAmplitude");
			DOTween.NativeFieldInfoPtr_defaultEasePeriod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTween>.NativeClassPtr, "defaultEasePeriod");
			DOTween.NativeFieldInfoPtr_instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTween>.NativeClassPtr, "instance");
			DOTween.NativeFieldInfoPtr_isUnityEditor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTween>.NativeClassPtr, "isUnityEditor");
			DOTween.NativeFieldInfoPtr_isDebugBuild = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTween>.NativeClassPtr, "isDebugBuild");
			DOTween.NativeFieldInfoPtr_maxActiveTweenersReached = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTween>.NativeClassPtr, "maxActiveTweenersReached");
			DOTween.NativeFieldInfoPtr_maxActiveSequencesReached = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTween>.NativeClassPtr, "maxActiveSequencesReached");
			DOTween.NativeFieldInfoPtr_GizmosDelegates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTween>.NativeClassPtr, "GizmosDelegates");
			DOTween.NativeFieldInfoPtr_initialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTween>.NativeClassPtr, "initialized");
			DOTween.NativeFieldInfoPtr_isQuitting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTween>.NativeClassPtr, "isQuitting");
			DOTween.NativeMethodInfoPtr_get_logBehaviour_Public_Static_get_LogBehaviour_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTween>.NativeClassPtr, 100663313);
			DOTween.NativeMethodInfoPtr_set_logBehaviour_Public_Static_set_Void_LogBehaviour_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTween>.NativeClassPtr, 100663314);
			DOTween.NativeMethodInfoPtr_Init_Public_Static_IDOTweenInit_Nullable_1_Boolean_Nullable_1_Boolean_Nullable_1_LogBehaviour_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTween>.NativeClassPtr, 100663316);
			DOTween.NativeMethodInfoPtr_AutoInit_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTween>.NativeClassPtr, 100663317);
			DOTween.NativeMethodInfoPtr_Init_Private_Static_IDOTweenInit_DOTweenSettings_Nullable_1_Boolean_Nullable_1_Boolean_Nullable_1_LogBehaviour_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTween>.NativeClassPtr, 100663318);
			DOTween.NativeMethodInfoPtr_SetTweensCapacity_Public_Static_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTween>.NativeClassPtr, 100663319);
			DOTween.NativeMethodInfoPtr_Clear_Public_Static_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTween>.NativeClassPtr, 100663320);
			DOTween.NativeMethodInfoPtr_ClearCachedTweens_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTween>.NativeClassPtr, 100663321);
			DOTween.NativeMethodInfoPtr_Validate_Public_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTween>.NativeClassPtr, 100663322);
			DOTween.NativeMethodInfoPtr_ManualUpdate_Public_Static_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTween>.NativeClassPtr, 100663323);
			DOTween.NativeMethodInfoPtr_To_Public_Static_TweenerCore_3_Single_Single_FloatOptions_DOGetter_1_Single_DOSetter_1_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTween>.NativeClassPtr, 100663324);
			DOTween.NativeMethodInfoPtr_To_Public_Static_TweenerCore_3_Double_Double_NoOptions_DOGetter_1_Double_DOSetter_1_Double_Double_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTween>.NativeClassPtr, 100663325);
			DOTween.NativeMethodInfoPtr_To_Public_Static_Tweener_DOGetter_1_Int32_DOSetter_1_Int32_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTween>.NativeClassPtr, 100663326);
			DOTween.NativeMethodInfoPtr_To_Public_Static_Tweener_DOGetter_1_UInt32_DOSetter_1_UInt32_UInt32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTween>.NativeClassPtr, 100663327);
			DOTween.NativeMethodInfoPtr_To_Public_Static_Tweener_DOGetter_1_Int64_DOSetter_1_Int64_Int64_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTween>.NativeClassPtr, 100663328);
			DOTween.NativeMethodInfoPtr_To_Public_Static_Tweener_DOGetter_1_UInt64_DOSetter_1_UInt64_UInt64_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTween>.NativeClassPtr, 100663329);
			DOTween.NativeMethodInfoPtr_To_Public_Static_TweenerCore_3_String_String_StringOptions_DOGetter_1_String_DOSetter_1_String_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTween>.NativeClassPtr, 100663330);
			DOTween.NativeMethodInfoPtr_To_Public_Static_TweenerCore_3_Vector2_Vector2_VectorOptions_DOGetter_1_Vector2_DOSetter_1_Vector2_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTween>.NativeClassPtr, 100663331);
			DOTween.NativeMethodInfoPtr_To_Public_Static_TweenerCore_3_Vector3_Vector3_VectorOptions_DOGetter_1_Vector3_DOSetter_1_Vector3_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTween>.NativeClassPtr, 100663332);
			DOTween.NativeMethodInfoPtr_To_Public_Static_TweenerCore_3_Vector4_Vector4_VectorOptions_DOGetter_1_Vector4_DOSetter_1_Vector4_Vector4_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTween>.NativeClassPtr, 100663333);
			DOTween.NativeMethodInfoPtr_To_Public_Static_TweenerCore_3_Quaternion_Vector3_QuaternionOptions_DOGetter_1_Quaternion_DOSetter_1_Quaternion_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTween>.NativeClassPtr, 100663334);
			DOTween.NativeMethodInfoPtr_To_Public_Static_TweenerCore_3_Color_Color_ColorOptions_DOGetter_1_Color_DOSetter_1_Color_Color_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTween>.NativeClassPtr, 100663335);
			DOTween.NativeMethodInfoPtr_To_Public_Static_TweenerCore_3_Rect_Rect_RectOptions_DOGetter_1_Rect_DOSetter_1_Rect_Rect_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTween>.NativeClassPtr, 100663336);
			DOTween.NativeMethodInfoPtr_To_Public_Static_Tweener_DOGetter_1_RectOffset_DOSetter_1_RectOffset_RectOffset_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTween>.NativeClassPtr, 100663337);
			DOTween.NativeMethodInfoPtr_To_Public_Static_TweenerCore_3_T1_T2_TPlugOptions_ABSTweenPlugin_3_T1_T2_TPlugOptions_DOGetter_1_T1_DOSetter_1_T1_T2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTween>.NativeClassPtr, 100663338);
			DOTween.NativeMethodInfoPtr_ToAxis_Public_Static_TweenerCore_3_Vector3_Vector3_VectorOptions_DOGetter_1_Vector3_DOSetter_1_Vector3_Single_Single_AxisConstraint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTween>.NativeClassPtr, 100663339);
			DOTween.NativeMethodInfoPtr_ToAlpha_Public_Static_Tweener_DOGetter_1_Color_DOSetter_1_Color_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTween>.NativeClassPtr, 100663340);
			DOTween.NativeMethodInfoPtr_To_Public_Static_Tweener_DOSetter_1_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTween>.NativeClassPtr, 100663341);
			DOTween.NativeMethodInfoPtr_Punch_Public_Static_TweenerCore_3_Vector3_Il2CppStructArray_1_Vector3_Vector3ArrayOptions_DOGetter_1_Vector3_DOSetter_1_Vector3_Vector3_Single_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTween>.NativeClassPtr, 100663342);
			DOTween.NativeMethodInfoPtr_Shake_Public_Static_TweenerCore_3_Vector3_Il2CppStructArray_1_Vector3_Vector3ArrayOptions_DOGetter_1_Vector3_DOSetter_1_Vector3_Single_Single_Int32_Single_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTween>.NativeClassPtr, 100663343);
			DOTween.NativeMethodInfoPtr_Shake_Public_Static_TweenerCore_3_Vector3_Il2CppStructArray_1_Vector3_Vector3ArrayOptions_DOGetter_1_Vector3_DOSetter_1_Vector3_Single_Vector3_Int32_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTween>.NativeClassPtr, 100663344);
			DOTween.NativeMethodInfoPtr_Shake_Private_Static_TweenerCore_3_Vector3_Il2CppStructArray_1_Vector3_Vector3ArrayOptions_DOGetter_1_Vector3_DOSetter_1_Vector3_Single_Vector3_Int32_Single_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTween>.NativeClassPtr, 100663345);
			DOTween.NativeMethodInfoPtr_ToArray_Public_Static_TweenerCore_3_Vector3_Il2CppStructArray_1_Vector3_Vector3ArrayOptions_DOGetter_1_Vector3_DOSetter_1_Vector3_Il2CppStructArray_1_Vector3_Il2CppStructArray_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTween>.NativeClassPtr, 100663346);
			DOTween.NativeMethodInfoPtr_To_Internal_Static_TweenerCore_3_Color2_Color2_ColorOptions_DOGetter_1_Color2_DOSetter_1_Color2_Color2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTween>.NativeClassPtr, 100663347);
			DOTween.NativeMethodInfoPtr_Sequence_Public_Static_Sequence_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTween>.NativeClassPtr, 100663348);
			DOTween.NativeMethodInfoPtr_CompleteAll_Public_Static_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTween>.NativeClassPtr, 100663349);
			DOTween.NativeMethodInfoPtr_Complete_Public_Static_Int32_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTween>.NativeClassPtr, 100663350);
			DOTween.NativeMethodInfoPtr_CompleteAndReturnKilledTot_Internal_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTween>.NativeClassPtr, 100663351);
			DOTween.NativeMethodInfoPtr_CompleteAndReturnKilledTot_Internal_Static_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTween>.NativeClassPtr, 100663352);
			DOTween.NativeMethodInfoPtr_CompleteAndReturnKilledTotExceptFor_Internal_Static_Int32_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTween>.NativeClassPtr, 100663353);
			DOTween.NativeMethodInfoPtr_FlipAll_Public_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTween>.NativeClassPtr, 100663354);
			DOTween.NativeMethodInfoPtr_Flip_Public_Static_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTween>.NativeClassPtr, 100663355);
			DOTween.NativeMethodInfoPtr_GotoAll_Public_Static_Int32_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTween>.NativeClassPtr, 100663356);
			DOTween.NativeMethodInfoPtr_Goto_Public_Static_Int32_Object_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTween>.NativeClassPtr, 100663357);
			DOTween.NativeMethodInfoPtr_KillAll_Public_Static_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTween>.NativeClassPtr, 100663358);
			DOTween.NativeMethodInfoPtr_KillAll_Public_Static_Int32_Boolean_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTween>.NativeClassPtr, 100663359);
			DOTween.NativeMethodInfoPtr_Kill_Public_Static_Int32_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTween>.NativeClassPtr, 100663360);
			DOTween.NativeMethodInfoPtr_PauseAll_Public_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTween>.NativeClassPtr, 100663361);
			DOTween.NativeMethodInfoPtr_Pause_Public_Static_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTween>.NativeClassPtr, 100663362);
			DOTween.NativeMethodInfoPtr_PlayAll_Public_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTween>.NativeClassPtr, 100663363);
			DOTween.NativeMethodInfoPtr_Play_Public_Static_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTween>.NativeClassPtr, 100663364);
			DOTween.NativeMethodInfoPtr_Play_Public_Static_Int32_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTween>.NativeClassPtr, 100663365);
			DOTween.NativeMethodInfoPtr_PlayBackwardsAll_Public_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTween>.NativeClassPtr, 100663366);
			DOTween.NativeMethodInfoPtr_PlayBackwards_Public_Static_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTween>.NativeClassPtr, 100663367);
			DOTween.NativeMethodInfoPtr_PlayBackwards_Public_Static_Int32_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTween>.NativeClassPtr, 100663368);
			DOTween.NativeMethodInfoPtr_PlayForwardAll_Public_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTween>.NativeClassPtr, 100663369);
			DOTween.NativeMethodInfoPtr_PlayForward_Public_Static_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTween>.NativeClassPtr, 100663370);
			DOTween.NativeMethodInfoPtr_PlayForward_Public_Static_Int32_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTween>.NativeClassPtr, 100663371);
			DOTween.NativeMethodInfoPtr_RestartAll_Public_Static_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTween>.NativeClassPtr, 100663372);
			DOTween.NativeMethodInfoPtr_Restart_Public_Static_Int32_Object_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTween>.NativeClassPtr, 100663373);
			DOTween.NativeMethodInfoPtr_Restart_Public_Static_Int32_Object_Object_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTween>.NativeClassPtr, 100663374);
			DOTween.NativeMethodInfoPtr_RewindAll_Public_Static_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTween>.NativeClassPtr, 100663375);
			DOTween.NativeMethodInfoPtr_Rewind_Public_Static_Int32_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTween>.NativeClassPtr, 100663376);
			DOTween.NativeMethodInfoPtr_SmoothRewindAll_Public_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTween>.NativeClassPtr, 100663377);
			DOTween.NativeMethodInfoPtr_SmoothRewind_Public_Static_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTween>.NativeClassPtr, 100663378);
			DOTween.NativeMethodInfoPtr_TogglePauseAll_Public_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTween>.NativeClassPtr, 100663379);
			DOTween.NativeMethodInfoPtr_TogglePause_Public_Static_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTween>.NativeClassPtr, 100663380);
			DOTween.NativeMethodInfoPtr_IsTweening_Public_Static_Boolean_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTween>.NativeClassPtr, 100663381);
			DOTween.NativeMethodInfoPtr_TotalPlayingTweens_Public_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTween>.NativeClassPtr, 100663382);
			DOTween.NativeMethodInfoPtr_PlayingTweens_Public_Static_List_1_Tween_List_1_Tween_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTween>.NativeClassPtr, 100663383);
			DOTween.NativeMethodInfoPtr_PausedTweens_Public_Static_List_1_Tween_List_1_Tween_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTween>.NativeClassPtr, 100663384);
			DOTween.NativeMethodInfoPtr_TweensById_Public_Static_List_1_Tween_Object_Boolean_List_1_Tween_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTween>.NativeClassPtr, 100663385);
			DOTween.NativeMethodInfoPtr_TweensByTarget_Public_Static_List_1_Tween_Object_Boolean_List_1_Tween_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTween>.NativeClassPtr, 100663386);
			DOTween.NativeMethodInfoPtr_InitCheck_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTween>.NativeClassPtr, 100663387);
			DOTween.NativeMethodInfoPtr_ApplyTo_Private_Static_TweenerCore_3_T1_T2_TPlugOptions_DOGetter_1_T1_DOSetter_1_T1_T2_Single_ABSTweenPlugin_3_T1_T2_TPlugOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTween>.NativeClassPtr, 100663388);
			DOTween.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTween>.NativeClassPtr, 100663389);
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000023 RID: 35 RVA: 0x00006378 File Offset: 0x00004578
		// (set) Token: 0x06000024 RID: 36 RVA: 0x000063A8 File Offset: 0x000045A8
		public unsafe static LogBehaviour logBehaviour
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1126904, XrefRangeEnd = 1126908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTween.NativeMethodInfoPtr_get_logBehaviour_Public_Static_get_LogBehaviour_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1126914, RefRangeEnd = 1126916, XrefRangeStart = 1126908, XrefRangeEnd = 1126914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTween.NativeMethodInfoPtr_set_logBehaviour_Public_Static_set_Void_LogBehaviour_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000025 RID: 37 RVA: 0x000063DC File Offset: 0x000045DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1126916, XrefRangeEnd = 1126937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IDOTweenInit Init(Nullable<bool> recycleAllByDefault = null, Nullable<bool> useSafeMode = null, Nullable<LogBehaviour> logBehaviour = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(recycleAllByDefault));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(useSafeMode));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(logBehaviour));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTween.NativeMethodInfoPtr_Init_Public_Static_IDOTweenInit_Nullable_1_Boolean_Nullable_1_Boolean_Nullable_1_LogBehaviour_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDOTweenInit>(intPtr3) : null;
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00006454 File Offset: 0x00004654
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1126937, XrefRangeEnd = 1126948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AutoInit()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTween.NativeMethodInfoPtr_AutoInit_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000027 RID: 39 RVA: 0x0000647C File Offset: 0x0000467C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1127064, RefRangeEnd = 1127067, XrefRangeStart = 1126948, XrefRangeEnd = 1127064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IDOTweenInit Init(DOTweenSettings settings, Nullable<bool> recycleAllByDefault, Nullable<bool> useSafeMode, Nullable<LogBehaviour> logBehaviour)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(recycleAllByDefault));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(useSafeMode));
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(logBehaviour));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTween.NativeMethodInfoPtr_Init_Private_Static_IDOTweenInit_DOTweenSettings_Nullable_1_Boolean_Nullable_1_Boolean_Nullable_1_LogBehaviour_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDOTweenInit>(intPtr3) : null;
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00006508 File Offset: 0x00004708
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1127067, XrefRangeEnd = 1127071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetTweensCapacity(int tweenersCapacity, int sequencesCapacity)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref tweenersCapacity;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sequencesCapacity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTween.NativeMethodInfoPtr_SetTweensCapacity_Public_Static_Void_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00006548 File Offset: 0x00004748
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1127071, XrefRangeEnd = 1127103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Clear(bool destroy = false)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref destroy;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTween.NativeMethodInfoPtr_Clear_Public_Static_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600002A RID: 42 RVA: 0x0000657C File Offset: 0x0000477C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1127103, XrefRangeEnd = 1127107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ClearCachedTweens()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTween.NativeMethodInfoPtr_ClearCachedTweens_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600002B RID: 43 RVA: 0x000065A4 File Offset: 0x000047A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1127107, XrefRangeEnd = 1127147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Validate()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTween.NativeMethodInfoPtr_Validate_Public_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600002C RID: 44 RVA: 0x000065D4 File Offset: 0x000047D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1127147, XrefRangeEnd = 1127154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ManualUpdate(float deltaTime, float unscaledDeltaTime)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref deltaTime;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unscaledDeltaTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTween.NativeMethodInfoPtr_ManualUpdate_Public_Static_Void_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00006614 File Offset: 0x00004814
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 1127160, RefRangeEnd = 1127175, XrefRangeStart = 1127154, XrefRangeEnd = 1127160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TweenerCore<float, float, FloatOptions> To(DOGetter<float> getter, DOSetter<float> setter, float endValue, float duration)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(getter);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(setter);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endValue;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTween.NativeMethodInfoPtr_To_Public_Static_TweenerCore_3_Single_Single_FloatOptions_DOGetter_1_Single_DOSetter_1_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TweenerCore<float, float, FloatOptions>>(intPtr3) : null;
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00006688 File Offset: 0x00004888
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1127175, XrefRangeEnd = 1127181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TweenerCore<double, double, NoOptions> To(DOGetter<double> getter, DOSetter<double> setter, double endValue, float duration)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(getter);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(setter);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endValue;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTween.NativeMethodInfoPtr_To_Public_Static_TweenerCore_3_Double_Double_NoOptions_DOGetter_1_Double_DOSetter_1_Double_Double_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TweenerCore<double, double, NoOptions>>(intPtr3) : null;
		}

		// Token: 0x0600002F RID: 47 RVA: 0x000066FC File Offset: 0x000048FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1127181, XrefRangeEnd = 1127187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Tweener To(DOGetter<int> getter, DOSetter<int> setter, int endValue, float duration)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(getter);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(setter);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endValue;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTween.NativeMethodInfoPtr_To_Public_Static_Tweener_DOGetter_1_Int32_DOSetter_1_Int32_Int32_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Tweener>(intPtr3) : null;
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00006770 File Offset: 0x00004970
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1127187, XrefRangeEnd = 1127193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Tweener To(DOGetter<uint> getter, DOSetter<uint> setter, uint endValue, float duration)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(getter);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(setter);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endValue;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTween.NativeMethodInfoPtr_To_Public_Static_Tweener_DOGetter_1_UInt32_DOSetter_1_UInt32_UInt32_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Tweener>(intPtr3) : null;
		}

		// Token: 0x06000031 RID: 49 RVA: 0x000067E4 File Offset: 0x000049E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1127193, XrefRangeEnd = 1127199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Tweener To(DOGetter<long> getter, DOSetter<long> setter, long endValue, float duration)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(getter);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(setter);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endValue;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTween.NativeMethodInfoPtr_To_Public_Static_Tweener_DOGetter_1_Int64_DOSetter_1_Int64_Int64_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Tweener>(intPtr3) : null;
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00006858 File Offset: 0x00004A58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1127199, XrefRangeEnd = 1127205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Tweener To(DOGetter<ulong> getter, DOSetter<ulong> setter, ulong endValue, float duration)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(getter);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(setter);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endValue;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTween.NativeMethodInfoPtr_To_Public_Static_Tweener_DOGetter_1_UInt64_DOSetter_1_UInt64_UInt64_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Tweener>(intPtr3) : null;
		}

		// Token: 0x06000033 RID: 51 RVA: 0x000068CC File Offset: 0x00004ACC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1127205, XrefRangeEnd = 1127211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TweenerCore<string, string, StringOptions> To(DOGetter<string> getter, DOSetter<string> setter, string endValue, float duration)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(getter);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(setter);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(endValue);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTween.NativeMethodInfoPtr_To_Public_Static_TweenerCore_3_String_String_StringOptions_DOGetter_1_String_DOSetter_1_String_String_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TweenerCore<string, string, StringOptions>>(intPtr3) : null;
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00006944 File Offset: 0x00004B44
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1127217, RefRangeEnd = 1127222, XrefRangeStart = 1127211, XrefRangeEnd = 1127217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TweenerCore<Vector2, Vector2, VectorOptions> To(DOGetter<Vector2> getter, DOSetter<Vector2> setter, Vector2 endValue, float duration)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(getter);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(setter);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endValue;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTween.NativeMethodInfoPtr_To_Public_Static_TweenerCore_3_Vector2_Vector2_VectorOptions_DOGetter_1_Vector2_DOSetter_1_Vector2_Vector2_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TweenerCore<Vector2, Vector2, VectorOptions>>(intPtr3) : null;
		}

		// Token: 0x06000035 RID: 53 RVA: 0x000069B8 File Offset: 0x00004BB8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1127228, RefRangeEnd = 1127229, XrefRangeStart = 1127222, XrefRangeEnd = 1127228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TweenerCore<Vector3, Vector3, VectorOptions> To(DOGetter<Vector3> getter, DOSetter<Vector3> setter, Vector3 endValue, float duration)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(getter);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(setter);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endValue;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTween.NativeMethodInfoPtr_To_Public_Static_TweenerCore_3_Vector3_Vector3_VectorOptions_DOGetter_1_Vector3_DOSetter_1_Vector3_Vector3_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TweenerCore<Vector3, Vector3, VectorOptions>>(intPtr3) : null;
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00006A2C File Offset: 0x00004C2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1127229, XrefRangeEnd = 1127235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TweenerCore<Vector4, Vector4, VectorOptions> To(DOGetter<Vector4> getter, DOSetter<Vector4> setter, Vector4 endValue, float duration)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(getter);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(setter);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endValue;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTween.NativeMethodInfoPtr_To_Public_Static_TweenerCore_3_Vector4_Vector4_VectorOptions_DOGetter_1_Vector4_DOSetter_1_Vector4_Vector4_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TweenerCore<Vector4, Vector4, VectorOptions>>(intPtr3) : null;
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00006AA0 File Offset: 0x00004CA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1127235, XrefRangeEnd = 1127241, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TweenerCore<Quaternion, Vector3, QuaternionOptions> To(DOGetter<Quaternion> getter, DOSetter<Quaternion> setter, Vector3 endValue, float duration)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(getter);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(setter);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endValue;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTween.NativeMethodInfoPtr_To_Public_Static_TweenerCore_3_Quaternion_Vector3_QuaternionOptions_DOGetter_1_Quaternion_DOSetter_1_Quaternion_Vector3_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TweenerCore<Quaternion, Vector3, QuaternionOptions>>(intPtr3) : null;
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00006B14 File Offset: 0x00004D14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1127241, XrefRangeEnd = 1127247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TweenerCore<Color, Color, ColorOptions> To(DOGetter<Color> getter, DOSetter<Color> setter, Color endValue, float duration)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(getter);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(setter);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endValue;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTween.NativeMethodInfoPtr_To_Public_Static_TweenerCore_3_Color_Color_ColorOptions_DOGetter_1_Color_DOSetter_1_Color_Color_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TweenerCore<Color, Color, ColorOptions>>(intPtr3) : null;
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00006B88 File Offset: 0x00004D88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1127247, XrefRangeEnd = 1127253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TweenerCore<Rect, Rect, RectOptions> To(DOGetter<Rect> getter, DOSetter<Rect> setter, Rect endValue, float duration)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(getter);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(setter);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endValue;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTween.NativeMethodInfoPtr_To_Public_Static_TweenerCore_3_Rect_Rect_RectOptions_DOGetter_1_Rect_DOSetter_1_Rect_Rect_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TweenerCore<Rect, Rect, RectOptions>>(intPtr3) : null;
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00006BFC File Offset: 0x00004DFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1127253, XrefRangeEnd = 1127259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Tweener To(DOGetter<RectOffset> getter, DOSetter<RectOffset> setter, RectOffset endValue, float duration)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(getter);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(setter);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(endValue);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTween.NativeMethodInfoPtr_To_Public_Static_Tweener_DOGetter_1_RectOffset_DOSetter_1_RectOffset_RectOffset_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Tweener>(intPtr3) : null;
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00006C74 File Offset: 0x00004E74
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1127277, RefRangeEnd = 1127279, XrefRangeStart = 1127259, XrefRangeEnd = 1127277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TweenerCore<T1, T2, TPlugOptions> To<T1, T2, TPlugOptions>(ABSTweenPlugin<T1, T2, TPlugOptions> plugin, DOGetter<T1> getter, DOSetter<T1> setter, T2 endValue, float duration) where TPlugOptions : new()
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(plugin);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(getter);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(setter);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			if (!typeof(T2).IsValueType)
			{
				T2 t = endValue;
				intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref endValue;
			}
			ptr2 = intPtr;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(DOTween.MethodInfoStoreGeneric_To_Public_Static_TweenerCore_3_T1_T2_TPlugOptions_ABSTweenPlugin_3_T1_T2_TPlugOptions_DOGetter_1_T1_DOSetter_1_T1_T2_Single_0<T1, T2, TPlugOptions>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr2;
			return (intPtr4 != 0) ? Il2CppObjectPool.Get<TweenerCore<T1, T2, TPlugOptions>>(intPtr4) : null;
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00006D34 File Offset: 0x00004F34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1127279, XrefRangeEnd = 1127285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TweenerCore<Vector3, Vector3, VectorOptions> ToAxis(DOGetter<Vector3> getter, DOSetter<Vector3> setter, float endValue, float duration, AxisConstraint axisConstraint = AxisConstraint.X)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(getter);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(setter);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endValue;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref axisConstraint;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTween.NativeMethodInfoPtr_ToAxis_Public_Static_TweenerCore_3_Vector3_Vector3_VectorOptions_DOGetter_1_Vector3_DOSetter_1_Vector3_Single_Single_AxisConstraint_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TweenerCore<Vector3, Vector3, VectorOptions>>(intPtr3) : null;
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00006DB4 File Offset: 0x00004FB4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1127291, RefRangeEnd = 1127293, XrefRangeStart = 1127285, XrefRangeEnd = 1127291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Tweener ToAlpha(DOGetter<Color> getter, DOSetter<Color> setter, float endValue, float duration)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(getter);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(setter);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endValue;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTween.NativeMethodInfoPtr_ToAlpha_Public_Static_Tweener_DOGetter_1_Color_DOSetter_1_Color_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Tweener>(intPtr3) : null;
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00006E28 File Offset: 0x00005028
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1127293, XrefRangeEnd = 1127318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Tweener To(DOSetter<float> setter, float startValue, float endValue, float duration)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(setter);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endValue;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTween.NativeMethodInfoPtr_To_Public_Static_Tweener_DOSetter_1_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Tweener>(intPtr3) : null;
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00006E98 File Offset: 0x00005098
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1127346, RefRangeEnd = 1127350, XrefRangeStart = 1127318, XrefRangeEnd = 1127346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TweenerCore<Vector3, Il2CppStructArray<Vector3>, Vector3ArrayOptions> Punch(DOGetter<Vector3> getter, DOSetter<Vector3> setter, Vector3 direction, float duration, int vibrato = 10, float elasticity = 1f)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(getter);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(setter);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref direction;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref vibrato;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref elasticity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTween.NativeMethodInfoPtr_Punch_Public_Static_TweenerCore_3_Vector3_Il2CppStructArray_1_Vector3_Vector3ArrayOptions_DOGetter_1_Vector3_DOSetter_1_Vector3_Vector3_Single_Int32_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TweenerCore<Vector3, Il2CppStructArray<Vector3>, Vector3ArrayOptions>>(intPtr3) : null;
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00006F28 File Offset: 0x00005128
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1127354, RefRangeEnd = 1127359, XrefRangeStart = 1127350, XrefRangeEnd = 1127354, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TweenerCore<Vector3, Il2CppStructArray<Vector3>, Vector3ArrayOptions> Shake(DOGetter<Vector3> getter, DOSetter<Vector3> setter, float duration, float strength = 3f, int vibrato = 10, float randomness = 90f, bool ignoreZAxis = true, bool fadeOut = true)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(getter);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(setter);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref strength;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref vibrato;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref randomness;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ignoreZAxis;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fadeOut;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTween.NativeMethodInfoPtr_Shake_Public_Static_TweenerCore_3_Vector3_Il2CppStructArray_1_Vector3_Vector3ArrayOptions_DOGetter_1_Vector3_DOSetter_1_Vector3_Single_Single_Int32_Single_Boolean_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TweenerCore<Vector3, Il2CppStructArray<Vector3>, Vector3ArrayOptions>>(intPtr3) : null;
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00006FD4 File Offset: 0x000051D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1127359, XrefRangeEnd = 1127363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TweenerCore<Vector3, Il2CppStructArray<Vector3>, Vector3ArrayOptions> Shake(DOGetter<Vector3> getter, DOSetter<Vector3> setter, float duration, Vector3 strength, int vibrato = 10, float randomness = 90f, bool fadeOut = true)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(getter);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(setter);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref strength;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref vibrato;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref randomness;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fadeOut;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTween.NativeMethodInfoPtr_Shake_Public_Static_TweenerCore_3_Vector3_Il2CppStructArray_1_Vector3_Vector3ArrayOptions_DOGetter_1_Vector3_DOSetter_1_Vector3_Single_Vector3_Int32_Single_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TweenerCore<Vector3, Il2CppStructArray<Vector3>, Vector3ArrayOptions>>(intPtr3) : null;
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00007070 File Offset: 0x00005270
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1127409, RefRangeEnd = 1127416, XrefRangeStart = 1127363, XrefRangeEnd = 1127409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TweenerCore<Vector3, Il2CppStructArray<Vector3>, Vector3ArrayOptions> Shake(DOGetter<Vector3> getter, DOSetter<Vector3> setter, float duration, Vector3 strength, int vibrato, float randomness, bool ignoreZAxis, bool vectorBased, bool fadeOut)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(getter);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(setter);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref strength;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref vibrato;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref randomness;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ignoreZAxis;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref vectorBased;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fadeOut;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTween.NativeMethodInfoPtr_Shake_Private_Static_TweenerCore_3_Vector3_Il2CppStructArray_1_Vector3_Vector3ArrayOptions_DOGetter_1_Vector3_DOSetter_1_Vector3_Single_Vector3_Int32_Single_Boolean_Boolean_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TweenerCore<Vector3, Il2CppStructArray<Vector3>, Vector3ArrayOptions>>(intPtr3) : null;
		}

		// Token: 0x06000043 RID: 67 RVA: 0x0000712C File Offset: 0x0000532C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1127434, RefRangeEnd = 1127436, XrefRangeStart = 1127416, XrefRangeEnd = 1127434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TweenerCore<Vector3, Il2CppStructArray<Vector3>, Vector3ArrayOptions> ToArray(DOGetter<Vector3> getter, DOSetter<Vector3> setter, Il2CppStructArray<Vector3> endValues, Il2CppStructArray<float> durations)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(getter);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(setter);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(endValues);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(durations);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTween.NativeMethodInfoPtr_ToArray_Public_Static_TweenerCore_3_Vector3_Il2CppStructArray_1_Vector3_Vector3ArrayOptions_DOGetter_1_Vector3_DOSetter_1_Vector3_Il2CppStructArray_1_Vector3_Il2CppStructArray_1_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TweenerCore<Vector3, Il2CppStructArray<Vector3>, Vector3ArrayOptions>>(intPtr3) : null;
		}

		// Token: 0x06000044 RID: 68 RVA: 0x000071A8 File Offset: 0x000053A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1127436, XrefRangeEnd = 1127442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TweenerCore<Color2, Color2, ColorOptions> To(DOGetter<Color2> getter, DOSetter<Color2> setter, Color2 endValue, float duration)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(getter);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(setter);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endValue;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTween.NativeMethodInfoPtr_To_Internal_Static_TweenerCore_3_Color2_Color2_ColorOptions_DOGetter_1_Color2_DOSetter_1_Color2_Color2_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TweenerCore<Color2, Color2, ColorOptions>>(intPtr3) : null;
		}

		// Token: 0x06000045 RID: 69 RVA: 0x0000721C File Offset: 0x0000541C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1127464, RefRangeEnd = 1127468, XrefRangeStart = 1127442, XrefRangeEnd = 1127464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Sequence Sequence()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTween.NativeMethodInfoPtr_Sequence_Public_Static_Sequence_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sequence>(intPtr3) : null;
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00007250 File Offset: 0x00005450
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1127468, XrefRangeEnd = 1127472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int CompleteAll(bool withCallbacks = false)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref withCallbacks;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTween.NativeMethodInfoPtr_CompleteAll_Public_Static_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00007290 File Offset: 0x00005490
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1127472, XrefRangeEnd = 1127476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Complete(global::Il2CppSystem.Object targetOrId, bool withCallbacks = false)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(targetOrId);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref withCallbacks;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTween.NativeMethodInfoPtr_Complete_Public_Static_Int32_Object_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000048 RID: 72 RVA: 0x000072E0 File Offset: 0x000054E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1127480, RefRangeEnd = 1127481, XrefRangeStart = 1127476, XrefRangeEnd = 1127480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int CompleteAndReturnKilledTot()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTween.NativeMethodInfoPtr_CompleteAndReturnKilledTot_Internal_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00007310 File Offset: 0x00005510
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1127481, XrefRangeEnd = 1127485, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int CompleteAndReturnKilledTot(global::Il2CppSystem.Object targetOrId)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(targetOrId);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTween.NativeMethodInfoPtr_CompleteAndReturnKilledTot_Internal_Static_Int32_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00007354 File Offset: 0x00005554
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1127485, XrefRangeEnd = 1127489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int CompleteAndReturnKilledTotExceptFor([Optional] Il2CppReferenceArray<global::Il2CppSystem.Object> excludeTargetsOrIds)
		{
			if (excludeTargetsOrIds == null)
			{
				excludeTargetsOrIds = new Il2CppReferenceArray<global::Il2CppSystem.Object>(0L);
			}
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(excludeTargetsOrIds);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTween.NativeMethodInfoPtr_CompleteAndReturnKilledTotExceptFor_Internal_Static_Int32_Il2CppReferenceArray_1_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600004B RID: 75 RVA: 0x000073A4 File Offset: 0x000055A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1127489, XrefRangeEnd = 1127493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int FlipAll()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTween.NativeMethodInfoPtr_FlipAll_Public_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600004C RID: 76 RVA: 0x000073D4 File Offset: 0x000055D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1127493, XrefRangeEnd = 1127497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Flip(global::Il2CppSystem.Object targetOrId)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(targetOrId);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTween.NativeMethodInfoPtr_Flip_Public_Static_Int32_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00007418 File Offset: 0x00005618
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1127497, XrefRangeEnd = 1127501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GotoAll(float to, bool andPlay = false)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref to;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref andPlay;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTween.NativeMethodInfoPtr_GotoAll_Public_Static_Int32_Single_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00007464 File Offset: 0x00005664
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1127501, XrefRangeEnd = 1127505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Goto(global::Il2CppSystem.Object targetOrId, float to, bool andPlay = false)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(targetOrId);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref to;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref andPlay;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTween.NativeMethodInfoPtr_Goto_Public_Static_Int32_Object_Single_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600004F RID: 79 RVA: 0x000074C4 File Offset: 0x000056C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1127505, XrefRangeEnd = 1127514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int KillAll(bool complete = false)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref complete;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTween.NativeMethodInfoPtr_KillAll_Public_Static_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00007504 File Offset: 0x00005704
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1127514, XrefRangeEnd = 1127526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int KillAll(bool complete, [Optional] Il2CppReferenceArray<global::Il2CppSystem.Object> idsOrTargetsToExclude)
		{
			if (idsOrTargetsToExclude == null)
			{
				idsOrTargetsToExclude = new Il2CppReferenceArray<global::Il2CppSystem.Object>(0L);
			}
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref complete;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(idsOrTargetsToExclude);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTween.NativeMethodInfoPtr_KillAll_Public_Static_Int32_Boolean_Il2CppReferenceArray_1_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00007560 File Offset: 0x00005760
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1127538, RefRangeEnd = 1127540, XrefRangeStart = 1127526, XrefRangeEnd = 1127538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Kill(global::Il2CppSystem.Object targetOrId, bool complete = false)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(targetOrId);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref complete;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTween.NativeMethodInfoPtr_Kill_Public_Static_Int32_Object_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000052 RID: 82 RVA: 0x000075B0 File Offset: 0x000057B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1127540, XrefRangeEnd = 1127544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int PauseAll()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTween.NativeMethodInfoPtr_PauseAll_Public_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000053 RID: 83 RVA: 0x000075E0 File Offset: 0x000057E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1127544, XrefRangeEnd = 1127548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Pause(global::Il2CppSystem.Object targetOrId)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(targetOrId);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTween.NativeMethodInfoPtr_Pause_Public_Static_Int32_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00007624 File Offset: 0x00005824
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1127548, XrefRangeEnd = 1127552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int PlayAll()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTween.NativeMethodInfoPtr_PlayAll_Public_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00007654 File Offset: 0x00005854
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1127552, XrefRangeEnd = 1127556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Play(global::Il2CppSystem.Object targetOrId)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(targetOrId);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTween.NativeMethodInfoPtr_Play_Public_Static_Int32_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00007698 File Offset: 0x00005898
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1127556, XrefRangeEnd = 1127560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Play(global::Il2CppSystem.Object target, global::Il2CppSystem.Object id)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(id);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTween.NativeMethodInfoPtr_Play_Public_Static_Int32_Object_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000057 RID: 87 RVA: 0x000076EC File Offset: 0x000058EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1127560, XrefRangeEnd = 1127564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int PlayBackwardsAll()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTween.NativeMethodInfoPtr_PlayBackwardsAll_Public_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000058 RID: 88 RVA: 0x0000771C File Offset: 0x0000591C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1127564, XrefRangeEnd = 1127568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int PlayBackwards(global::Il2CppSystem.Object targetOrId)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(targetOrId);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTween.NativeMethodInfoPtr_PlayBackwards_Public_Static_Int32_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00007760 File Offset: 0x00005960
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1127568, XrefRangeEnd = 1127572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int PlayBackwards(global::Il2CppSystem.Object target, global::Il2CppSystem.Object id)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(id);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTween.NativeMethodInfoPtr_PlayBackwards_Public_Static_Int32_Object_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600005A RID: 90 RVA: 0x000077B4 File Offset: 0x000059B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1127572, XrefRangeEnd = 1127576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int PlayForwardAll()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTween.NativeMethodInfoPtr_PlayForwardAll_Public_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600005B RID: 91 RVA: 0x000077E4 File Offset: 0x000059E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1127576, XrefRangeEnd = 1127580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int PlayForward(global::Il2CppSystem.Object targetOrId)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(targetOrId);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTween.NativeMethodInfoPtr_PlayForward_Public_Static_Int32_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00007828 File Offset: 0x00005A28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1127580, XrefRangeEnd = 1127584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int PlayForward(global::Il2CppSystem.Object target, global::Il2CppSystem.Object id)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(id);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTween.NativeMethodInfoPtr_PlayForward_Public_Static_Int32_Object_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600005D RID: 93 RVA: 0x0000787C File Offset: 0x00005A7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1127584, XrefRangeEnd = 1127588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int RestartAll(bool includeDelay = true)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref includeDelay;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTween.NativeMethodInfoPtr_RestartAll_Public_Static_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600005E RID: 94 RVA: 0x000078BC File Offset: 0x00005ABC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1127588, XrefRangeEnd = 1127592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Restart(global::Il2CppSystem.Object targetOrId, bool includeDelay = true, float changeDelayTo = -1f)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(targetOrId);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref includeDelay;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref changeDelayTo;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTween.NativeMethodInfoPtr_Restart_Public_Static_Int32_Object_Boolean_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600005F RID: 95 RVA: 0x0000791C File Offset: 0x00005B1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1127592, XrefRangeEnd = 1127597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Restart(global::Il2CppSystem.Object target, global::Il2CppSystem.Object id, bool includeDelay = true, float changeDelayTo = -1f)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(id);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref includeDelay;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref changeDelayTo;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTween.NativeMethodInfoPtr_Restart_Public_Static_Int32_Object_Object_Boolean_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000060 RID: 96 RVA: 0x0000798C File Offset: 0x00005B8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1127597, XrefRangeEnd = 1127601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int RewindAll(bool includeDelay = true)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref includeDelay;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTween.NativeMethodInfoPtr_RewindAll_Public_Static_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000061 RID: 97 RVA: 0x000079CC File Offset: 0x00005BCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1127601, XrefRangeEnd = 1127605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Rewind(global::Il2CppSystem.Object targetOrId, bool includeDelay = true)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(targetOrId);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref includeDelay;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTween.NativeMethodInfoPtr_Rewind_Public_Static_Int32_Object_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00007A1C File Offset: 0x00005C1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1127605, XrefRangeEnd = 1127609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int SmoothRewindAll()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTween.NativeMethodInfoPtr_SmoothRewindAll_Public_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00007A4C File Offset: 0x00005C4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1127609, XrefRangeEnd = 1127613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int SmoothRewind(global::Il2CppSystem.Object targetOrId)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(targetOrId);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTween.NativeMethodInfoPtr_SmoothRewind_Public_Static_Int32_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000064 RID: 100 RVA: 0x00007A90 File Offset: 0x00005C90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1127613, XrefRangeEnd = 1127617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int TogglePauseAll()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTween.NativeMethodInfoPtr_TogglePauseAll_Public_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000065 RID: 101 RVA: 0x00007AC0 File Offset: 0x00005CC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1127617, XrefRangeEnd = 1127621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int TogglePause(global::Il2CppSystem.Object targetOrId)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(targetOrId);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTween.NativeMethodInfoPtr_TogglePause_Public_Static_Int32_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000066 RID: 102 RVA: 0x00007B04 File Offset: 0x00005D04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1127621, XrefRangeEnd = 1127625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsTweening(global::Il2CppSystem.Object targetOrId, bool alsoCheckIfIsPlaying = false)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(targetOrId);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref alsoCheckIfIsPlaying;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTween.NativeMethodInfoPtr_IsTweening_Public_Static_Boolean_Object_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000067 RID: 103 RVA: 0x00007B54 File Offset: 0x00005D54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1127625, XrefRangeEnd = 1127629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int TotalPlayingTweens()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTween.NativeMethodInfoPtr_TotalPlayingTweens_Public_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000068 RID: 104 RVA: 0x00007B84 File Offset: 0x00005D84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1127629, XrefRangeEnd = 1127635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<Tween> PlayingTweens(List<Tween> fillableList = null)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(fillableList);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTween.NativeMethodInfoPtr_PlayingTweens_Public_Static_List_1_Tween_List_1_Tween_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Tween>>(intPtr3) : null;
			}
		}

		// Token: 0x06000069 RID: 105 RVA: 0x00007BC8 File Offset: 0x00005DC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1127635, XrefRangeEnd = 1127641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<Tween> PausedTweens(List<Tween> fillableList = null)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(fillableList);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTween.NativeMethodInfoPtr_PausedTweens_Public_Static_List_1_Tween_List_1_Tween_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Tween>>(intPtr3) : null;
			}
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00007C0C File Offset: 0x00005E0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1127641, XrefRangeEnd = 1127647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<Tween> TweensById(global::Il2CppSystem.Object id, bool playingOnly = false, List<Tween> fillableList = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(id);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref playingOnly;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(fillableList);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTween.NativeMethodInfoPtr_TweensById_Public_Static_List_1_Tween_Object_Boolean_List_1_Tween_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Tween>>(intPtr3) : null;
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00007C70 File Offset: 0x00005E70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1127647, XrefRangeEnd = 1127653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<Tween> TweensByTarget(global::Il2CppSystem.Object target, bool playingOnly = false, List<Tween> fillableList = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref playingOnly;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(fillableList);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTween.NativeMethodInfoPtr_TweensByTarget_Public_Static_List_1_Tween_Object_Boolean_List_1_Tween_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Tween>>(intPtr3) : null;
		}

		// Token: 0x0600006C RID: 108 RVA: 0x00007CD4 File Offset: 0x00005ED4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1127676, RefRangeEnd = 1127680, XrefRangeStart = 1127653, XrefRangeEnd = 1127676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InitCheck()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTween.NativeMethodInfoPtr_InitCheck_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600006D RID: 109 RVA: 0x00007CFC File Offset: 0x00005EFC
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 1127694, RefRangeEnd = 1127703, XrefRangeStart = 1127680, XrefRangeEnd = 1127694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TweenerCore<T1, T2, TPlugOptions> ApplyTo<T1, T2, TPlugOptions>(DOGetter<T1> getter, DOSetter<T1> setter, T2 endValue, float duration, ABSTweenPlugin<T1, T2, TPlugOptions> plugin = null) where TPlugOptions : new()
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(getter);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(setter);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			if (!typeof(T2).IsValueType)
			{
				T2 t = endValue;
				intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref endValue;
			}
			ptr2 = intPtr;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(plugin);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(DOTween.MethodInfoStoreGeneric_ApplyTo_Private_Static_TweenerCore_3_T1_T2_TPlugOptions_DOGetter_1_T1_DOSetter_1_T1_T2_Single_ABSTweenPlugin_3_T1_T2_TPlugOptions_0<T1, T2, TPlugOptions>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr2;
			return (intPtr4 != 0) ? Il2CppObjectPool.Get<TweenerCore<T1, T2, TPlugOptions>>(intPtr4) : null;
		}

		// Token: 0x0600006E RID: 110 RVA: 0x00007DBC File Offset: 0x00005FBC
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DOTween()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DOTween>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTween.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600006F RID: 111 RVA: 0x000020F2 File Offset: 0x000002F2
		public static int CompleteAndReturnKilledTotExceptFor(params global::Il2CppSystem.Object[] excludeTargetsOrIds)
		{
			return DOTween.CompleteAndReturnKilledTotExceptFor(new Il2CppReferenceArray<global::Il2CppSystem.Object>(excludeTargetsOrIds));
		}

		// Token: 0x06000070 RID: 112 RVA: 0x000020FF File Offset: 0x000002FF
		public static int KillAll(bool complete, params global::Il2CppSystem.Object[] idsOrTargetsToExclude)
		{
			return DOTween.KillAll(complete, new Il2CppReferenceArray<global::Il2CppSystem.Object>(idsOrTargetsToExclude));
		}

		// Token: 0x06000071 RID: 113 RVA: 0x0000210D File Offset: 0x0000030D
		public DOTween(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000072 RID: 114 RVA: 0x00007DF8 File Offset: 0x00005FF8
		// (set) Token: 0x06000073 RID: 115 RVA: 0x00002116 File Offset: 0x00000316
		public unsafe static string Version
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DOTween.NativeFieldInfoPtr_Version, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DOTween.NativeFieldInfoPtr_Version, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000074 RID: 116 RVA: 0x00007E18 File Offset: 0x00006018
		// (set) Token: 0x06000075 RID: 117 RVA: 0x00002128 File Offset: 0x00000328
		public unsafe static bool useSafeMode
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(DOTween.NativeFieldInfoPtr_useSafeMode, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DOTween.NativeFieldInfoPtr_useSafeMode, (void*)(&value));
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000076 RID: 118 RVA: 0x00007E34 File Offset: 0x00006034
		// (set) Token: 0x06000077 RID: 119 RVA: 0x00002136 File Offset: 0x00000336
		public unsafe static bool showUnityEditorReport
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(DOTween.NativeFieldInfoPtr_showUnityEditorReport, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DOTween.NativeFieldInfoPtr_showUnityEditorReport, (void*)(&value));
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000078 RID: 120 RVA: 0x00007E50 File Offset: 0x00006050
		// (set) Token: 0x06000079 RID: 121 RVA: 0x00002144 File Offset: 0x00000344
		public unsafe static float timeScale
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(DOTween.NativeFieldInfoPtr_timeScale, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DOTween.NativeFieldInfoPtr_timeScale, (void*)(&value));
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600007A RID: 122 RVA: 0x00007E6C File Offset: 0x0000606C
		// (set) Token: 0x0600007B RID: 123 RVA: 0x00002152 File Offset: 0x00000352
		public unsafe static bool useSmoothDeltaTime
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(DOTween.NativeFieldInfoPtr_useSmoothDeltaTime, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DOTween.NativeFieldInfoPtr_useSmoothDeltaTime, (void*)(&value));
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600007C RID: 124 RVA: 0x00007E88 File Offset: 0x00006088
		// (set) Token: 0x0600007D RID: 125 RVA: 0x00002160 File Offset: 0x00000360
		public unsafe static float maxSmoothUnscaledTime
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(DOTween.NativeFieldInfoPtr_maxSmoothUnscaledTime, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DOTween.NativeFieldInfoPtr_maxSmoothUnscaledTime, (void*)(&value));
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600007E RID: 126 RVA: 0x00007EA4 File Offset: 0x000060A4
		// (set) Token: 0x0600007F RID: 127 RVA: 0x0000216E File Offset: 0x0000036E
		public unsafe static RewindCallbackMode rewindCallbackMode
		{
			get
			{
				RewindCallbackMode rewindCallbackMode;
				IL2CPP.il2cpp_field_static_get_value(DOTween.NativeFieldInfoPtr_rewindCallbackMode, (void*)(&rewindCallbackMode));
				return rewindCallbackMode;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DOTween.NativeFieldInfoPtr_rewindCallbackMode, (void*)(&value));
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000080 RID: 128 RVA: 0x00007EC0 File Offset: 0x000060C0
		// (set) Token: 0x06000081 RID: 129 RVA: 0x0000217C File Offset: 0x0000037C
		public unsafe static LogBehaviour _logBehaviour
		{
			get
			{
				LogBehaviour logBehaviour;
				IL2CPP.il2cpp_field_static_get_value(DOTween.NativeFieldInfoPtr__logBehaviour, (void*)(&logBehaviour));
				return logBehaviour;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DOTween.NativeFieldInfoPtr__logBehaviour, (void*)(&value));
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000082 RID: 130 RVA: 0x00007EDC File Offset: 0x000060DC
		// (set) Token: 0x06000083 RID: 131 RVA: 0x0000218A File Offset: 0x0000038A
		public unsafe static bool drawGizmos
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(DOTween.NativeFieldInfoPtr_drawGizmos, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DOTween.NativeFieldInfoPtr_drawGizmos, (void*)(&value));
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000084 RID: 132 RVA: 0x00007EF8 File Offset: 0x000060F8
		// (set) Token: 0x06000085 RID: 133 RVA: 0x00002198 File Offset: 0x00000398
		public unsafe static UpdateType defaultUpdateType
		{
			get
			{
				UpdateType updateType;
				IL2CPP.il2cpp_field_static_get_value(DOTween.NativeFieldInfoPtr_defaultUpdateType, (void*)(&updateType));
				return updateType;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DOTween.NativeFieldInfoPtr_defaultUpdateType, (void*)(&value));
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000086 RID: 134 RVA: 0x00007F14 File Offset: 0x00006114
		// (set) Token: 0x06000087 RID: 135 RVA: 0x000021A6 File Offset: 0x000003A6
		public unsafe static bool defaultTimeScaleIndependent
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(DOTween.NativeFieldInfoPtr_defaultTimeScaleIndependent, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DOTween.NativeFieldInfoPtr_defaultTimeScaleIndependent, (void*)(&value));
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000088 RID: 136 RVA: 0x00007F30 File Offset: 0x00006130
		// (set) Token: 0x06000089 RID: 137 RVA: 0x000021B4 File Offset: 0x000003B4
		public unsafe static AutoPlay defaultAutoPlay
		{
			get
			{
				AutoPlay autoPlay;
				IL2CPP.il2cpp_field_static_get_value(DOTween.NativeFieldInfoPtr_defaultAutoPlay, (void*)(&autoPlay));
				return autoPlay;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DOTween.NativeFieldInfoPtr_defaultAutoPlay, (void*)(&value));
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x0600008A RID: 138 RVA: 0x00007F4C File Offset: 0x0000614C
		// (set) Token: 0x0600008B RID: 139 RVA: 0x000021C2 File Offset: 0x000003C2
		public unsafe static bool defaultAutoKill
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(DOTween.NativeFieldInfoPtr_defaultAutoKill, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DOTween.NativeFieldInfoPtr_defaultAutoKill, (void*)(&value));
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x0600008C RID: 140 RVA: 0x00007F68 File Offset: 0x00006168
		// (set) Token: 0x0600008D RID: 141 RVA: 0x000021D0 File Offset: 0x000003D0
		public unsafe static LoopType defaultLoopType
		{
			get
			{
				LoopType loopType;
				IL2CPP.il2cpp_field_static_get_value(DOTween.NativeFieldInfoPtr_defaultLoopType, (void*)(&loopType));
				return loopType;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DOTween.NativeFieldInfoPtr_defaultLoopType, (void*)(&value));
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600008E RID: 142 RVA: 0x00007F84 File Offset: 0x00006184
		// (set) Token: 0x0600008F RID: 143 RVA: 0x000021DE File Offset: 0x000003DE
		public unsafe static bool defaultRecyclable
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(DOTween.NativeFieldInfoPtr_defaultRecyclable, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DOTween.NativeFieldInfoPtr_defaultRecyclable, (void*)(&value));
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000090 RID: 144 RVA: 0x00007FA0 File Offset: 0x000061A0
		// (set) Token: 0x06000091 RID: 145 RVA: 0x000021EC File Offset: 0x000003EC
		public unsafe static Ease defaultEaseType
		{
			get
			{
				Ease ease;
				IL2CPP.il2cpp_field_static_get_value(DOTween.NativeFieldInfoPtr_defaultEaseType, (void*)(&ease));
				return ease;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DOTween.NativeFieldInfoPtr_defaultEaseType, (void*)(&value));
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000092 RID: 146 RVA: 0x00007FBC File Offset: 0x000061BC
		// (set) Token: 0x06000093 RID: 147 RVA: 0x000021FA File Offset: 0x000003FA
		public unsafe static float defaultEaseOvershootOrAmplitude
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(DOTween.NativeFieldInfoPtr_defaultEaseOvershootOrAmplitude, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DOTween.NativeFieldInfoPtr_defaultEaseOvershootOrAmplitude, (void*)(&value));
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000094 RID: 148 RVA: 0x00007FD8 File Offset: 0x000061D8
		// (set) Token: 0x06000095 RID: 149 RVA: 0x00002208 File Offset: 0x00000408
		public unsafe static float defaultEasePeriod
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(DOTween.NativeFieldInfoPtr_defaultEasePeriod, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DOTween.NativeFieldInfoPtr_defaultEasePeriod, (void*)(&value));
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000096 RID: 150 RVA: 0x00007FF4 File Offset: 0x000061F4
		// (set) Token: 0x06000097 RID: 151 RVA: 0x00002216 File Offset: 0x00000416
		public unsafe static DOTweenComponent instance
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DOTween.NativeFieldInfoPtr_instance, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DOTweenComponent>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DOTween.NativeFieldInfoPtr_instance, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000098 RID: 152 RVA: 0x0000801C File Offset: 0x0000621C
		// (set) Token: 0x06000099 RID: 153 RVA: 0x00002228 File Offset: 0x00000428
		public unsafe static bool isUnityEditor
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(DOTween.NativeFieldInfoPtr_isUnityEditor, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DOTween.NativeFieldInfoPtr_isUnityEditor, (void*)(&value));
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x0600009A RID: 154 RVA: 0x00008038 File Offset: 0x00006238
		// (set) Token: 0x0600009B RID: 155 RVA: 0x00002236 File Offset: 0x00000436
		public unsafe static bool isDebugBuild
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(DOTween.NativeFieldInfoPtr_isDebugBuild, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DOTween.NativeFieldInfoPtr_isDebugBuild, (void*)(&value));
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x0600009C RID: 156 RVA: 0x00008054 File Offset: 0x00006254
		// (set) Token: 0x0600009D RID: 157 RVA: 0x00002244 File Offset: 0x00000444
		public unsafe static int maxActiveTweenersReached
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DOTween.NativeFieldInfoPtr_maxActiveTweenersReached, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DOTween.NativeFieldInfoPtr_maxActiveTweenersReached, (void*)(&value));
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x0600009E RID: 158 RVA: 0x00008070 File Offset: 0x00006270
		// (set) Token: 0x0600009F RID: 159 RVA: 0x00002252 File Offset: 0x00000452
		public unsafe static int maxActiveSequencesReached
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DOTween.NativeFieldInfoPtr_maxActiveSequencesReached, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DOTween.NativeFieldInfoPtr_maxActiveSequencesReached, (void*)(&value));
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x060000A0 RID: 160 RVA: 0x0000808C File Offset: 0x0000628C
		// (set) Token: 0x060000A1 RID: 161 RVA: 0x00002260 File Offset: 0x00000460
		public unsafe static List<TweenCallback> GizmosDelegates
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DOTween.NativeFieldInfoPtr_GizmosDelegates, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<TweenCallback>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DOTween.NativeFieldInfoPtr_GizmosDelegates, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x060000A2 RID: 162 RVA: 0x000080B4 File Offset: 0x000062B4
		// (set) Token: 0x060000A3 RID: 163 RVA: 0x00002272 File Offset: 0x00000472
		public unsafe static bool initialized
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(DOTween.NativeFieldInfoPtr_initialized, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DOTween.NativeFieldInfoPtr_initialized, (void*)(&value));
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x060000A4 RID: 164 RVA: 0x000080D0 File Offset: 0x000062D0
		// (set) Token: 0x060000A5 RID: 165 RVA: 0x00002280 File Offset: 0x00000480
		public unsafe static bool isQuitting
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(DOTween.NativeFieldInfoPtr_isQuitting, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DOTween.NativeFieldInfoPtr_isQuitting, (void*)(&value));
			}
		}

		// Token: 0x04000020 RID: 32
		private static readonly IntPtr NativeFieldInfoPtr_Version;

		// Token: 0x04000021 RID: 33
		private static readonly IntPtr NativeFieldInfoPtr_useSafeMode;

		// Token: 0x04000022 RID: 34
		private static readonly IntPtr NativeFieldInfoPtr_showUnityEditorReport;

		// Token: 0x04000023 RID: 35
		private static readonly IntPtr NativeFieldInfoPtr_timeScale;

		// Token: 0x04000024 RID: 36
		private static readonly IntPtr NativeFieldInfoPtr_useSmoothDeltaTime;

		// Token: 0x04000025 RID: 37
		private static readonly IntPtr NativeFieldInfoPtr_maxSmoothUnscaledTime;

		// Token: 0x04000026 RID: 38
		private static readonly IntPtr NativeFieldInfoPtr_rewindCallbackMode;

		// Token: 0x04000027 RID: 39
		private static readonly IntPtr NativeFieldInfoPtr__logBehaviour;

		// Token: 0x04000028 RID: 40
		private static readonly IntPtr NativeFieldInfoPtr_drawGizmos;

		// Token: 0x04000029 RID: 41
		private static readonly IntPtr NativeFieldInfoPtr_defaultUpdateType;

		// Token: 0x0400002A RID: 42
		private static readonly IntPtr NativeFieldInfoPtr_defaultTimeScaleIndependent;

		// Token: 0x0400002B RID: 43
		private static readonly IntPtr NativeFieldInfoPtr_defaultAutoPlay;

		// Token: 0x0400002C RID: 44
		private static readonly IntPtr NativeFieldInfoPtr_defaultAutoKill;

		// Token: 0x0400002D RID: 45
		private static readonly IntPtr NativeFieldInfoPtr_defaultLoopType;

		// Token: 0x0400002E RID: 46
		private static readonly IntPtr NativeFieldInfoPtr_defaultRecyclable;

		// Token: 0x0400002F RID: 47
		private static readonly IntPtr NativeFieldInfoPtr_defaultEaseType;

		// Token: 0x04000030 RID: 48
		private static readonly IntPtr NativeFieldInfoPtr_defaultEaseOvershootOrAmplitude;

		// Token: 0x04000031 RID: 49
		private static readonly IntPtr NativeFieldInfoPtr_defaultEasePeriod;

		// Token: 0x04000032 RID: 50
		private static readonly IntPtr NativeFieldInfoPtr_instance;

		// Token: 0x04000033 RID: 51
		private static readonly IntPtr NativeFieldInfoPtr_isUnityEditor;

		// Token: 0x04000034 RID: 52
		private static readonly IntPtr NativeFieldInfoPtr_isDebugBuild;

		// Token: 0x04000035 RID: 53
		private static readonly IntPtr NativeFieldInfoPtr_maxActiveTweenersReached;

		// Token: 0x04000036 RID: 54
		private static readonly IntPtr NativeFieldInfoPtr_maxActiveSequencesReached;

		// Token: 0x04000037 RID: 55
		private static readonly IntPtr NativeFieldInfoPtr_GizmosDelegates;

		// Token: 0x04000038 RID: 56
		private static readonly IntPtr NativeFieldInfoPtr_initialized;

		// Token: 0x04000039 RID: 57
		private static readonly IntPtr NativeFieldInfoPtr_isQuitting;

		// Token: 0x0400003A RID: 58
		private static readonly IntPtr NativeMethodInfoPtr_get_logBehaviour_Public_Static_get_LogBehaviour_0;

		// Token: 0x0400003B RID: 59
		private static readonly IntPtr NativeMethodInfoPtr_set_logBehaviour_Public_Static_set_Void_LogBehaviour_0;

		// Token: 0x0400003C RID: 60
		private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Static_IDOTweenInit_Nullable_1_Boolean_Nullable_1_Boolean_Nullable_1_LogBehaviour_0;

		// Token: 0x0400003D RID: 61
		private static readonly IntPtr NativeMethodInfoPtr_AutoInit_Private_Static_Void_0;

		// Token: 0x0400003E RID: 62
		private static readonly IntPtr NativeMethodInfoPtr_Init_Private_Static_IDOTweenInit_DOTweenSettings_Nullable_1_Boolean_Nullable_1_Boolean_Nullable_1_LogBehaviour_0;

		// Token: 0x0400003F RID: 63
		private static readonly IntPtr NativeMethodInfoPtr_SetTweensCapacity_Public_Static_Void_Int32_Int32_0;

		// Token: 0x04000040 RID: 64
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Static_Void_Boolean_0;

		// Token: 0x04000041 RID: 65
		private static readonly IntPtr NativeMethodInfoPtr_ClearCachedTweens_Public_Static_Void_0;

		// Token: 0x04000042 RID: 66
		private static readonly IntPtr NativeMethodInfoPtr_Validate_Public_Static_Int32_0;

		// Token: 0x04000043 RID: 67
		private static readonly IntPtr NativeMethodInfoPtr_ManualUpdate_Public_Static_Void_Single_Single_0;

		// Token: 0x04000044 RID: 68
		private static readonly IntPtr NativeMethodInfoPtr_To_Public_Static_TweenerCore_3_Single_Single_FloatOptions_DOGetter_1_Single_DOSetter_1_Single_Single_Single_0;

		// Token: 0x04000045 RID: 69
		private static readonly IntPtr NativeMethodInfoPtr_To_Public_Static_TweenerCore_3_Double_Double_NoOptions_DOGetter_1_Double_DOSetter_1_Double_Double_Single_0;

		// Token: 0x04000046 RID: 70
		private static readonly IntPtr NativeMethodInfoPtr_To_Public_Static_Tweener_DOGetter_1_Int32_DOSetter_1_Int32_Int32_Single_0;

		// Token: 0x04000047 RID: 71
		private static readonly IntPtr NativeMethodInfoPtr_To_Public_Static_Tweener_DOGetter_1_UInt32_DOSetter_1_UInt32_UInt32_Single_0;

		// Token: 0x04000048 RID: 72
		private static readonly IntPtr NativeMethodInfoPtr_To_Public_Static_Tweener_DOGetter_1_Int64_DOSetter_1_Int64_Int64_Single_0;

		// Token: 0x04000049 RID: 73
		private static readonly IntPtr NativeMethodInfoPtr_To_Public_Static_Tweener_DOGetter_1_UInt64_DOSetter_1_UInt64_UInt64_Single_0;

		// Token: 0x0400004A RID: 74
		private static readonly IntPtr NativeMethodInfoPtr_To_Public_Static_TweenerCore_3_String_String_StringOptions_DOGetter_1_String_DOSetter_1_String_String_Single_0;

		// Token: 0x0400004B RID: 75
		private static readonly IntPtr NativeMethodInfoPtr_To_Public_Static_TweenerCore_3_Vector2_Vector2_VectorOptions_DOGetter_1_Vector2_DOSetter_1_Vector2_Vector2_Single_0;

		// Token: 0x0400004C RID: 76
		private static readonly IntPtr NativeMethodInfoPtr_To_Public_Static_TweenerCore_3_Vector3_Vector3_VectorOptions_DOGetter_1_Vector3_DOSetter_1_Vector3_Vector3_Single_0;

		// Token: 0x0400004D RID: 77
		private static readonly IntPtr NativeMethodInfoPtr_To_Public_Static_TweenerCore_3_Vector4_Vector4_VectorOptions_DOGetter_1_Vector4_DOSetter_1_Vector4_Vector4_Single_0;

		// Token: 0x0400004E RID: 78
		private static readonly IntPtr NativeMethodInfoPtr_To_Public_Static_TweenerCore_3_Quaternion_Vector3_QuaternionOptions_DOGetter_1_Quaternion_DOSetter_1_Quaternion_Vector3_Single_0;

		// Token: 0x0400004F RID: 79
		private static readonly IntPtr NativeMethodInfoPtr_To_Public_Static_TweenerCore_3_Color_Color_ColorOptions_DOGetter_1_Color_DOSetter_1_Color_Color_Single_0;

		// Token: 0x04000050 RID: 80
		private static readonly IntPtr NativeMethodInfoPtr_To_Public_Static_TweenerCore_3_Rect_Rect_RectOptions_DOGetter_1_Rect_DOSetter_1_Rect_Rect_Single_0;

		// Token: 0x04000051 RID: 81
		private static readonly IntPtr NativeMethodInfoPtr_To_Public_Static_Tweener_DOGetter_1_RectOffset_DOSetter_1_RectOffset_RectOffset_Single_0;

		// Token: 0x04000052 RID: 82
		private static readonly IntPtr NativeMethodInfoPtr_To_Public_Static_TweenerCore_3_T1_T2_TPlugOptions_ABSTweenPlugin_3_T1_T2_TPlugOptions_DOGetter_1_T1_DOSetter_1_T1_T2_Single_0;

		// Token: 0x04000053 RID: 83
		private static readonly IntPtr NativeMethodInfoPtr_ToAxis_Public_Static_TweenerCore_3_Vector3_Vector3_VectorOptions_DOGetter_1_Vector3_DOSetter_1_Vector3_Single_Single_AxisConstraint_0;

		// Token: 0x04000054 RID: 84
		private static readonly IntPtr NativeMethodInfoPtr_ToAlpha_Public_Static_Tweener_DOGetter_1_Color_DOSetter_1_Color_Single_Single_0;

		// Token: 0x04000055 RID: 85
		private static readonly IntPtr NativeMethodInfoPtr_To_Public_Static_Tweener_DOSetter_1_Single_Single_Single_Single_0;

		// Token: 0x04000056 RID: 86
		private static readonly IntPtr NativeMethodInfoPtr_Punch_Public_Static_TweenerCore_3_Vector3_Il2CppStructArray_1_Vector3_Vector3ArrayOptions_DOGetter_1_Vector3_DOSetter_1_Vector3_Vector3_Single_Int32_Single_0;

		// Token: 0x04000057 RID: 87
		private static readonly IntPtr NativeMethodInfoPtr_Shake_Public_Static_TweenerCore_3_Vector3_Il2CppStructArray_1_Vector3_Vector3ArrayOptions_DOGetter_1_Vector3_DOSetter_1_Vector3_Single_Single_Int32_Single_Boolean_Boolean_0;

		// Token: 0x04000058 RID: 88
		private static readonly IntPtr NativeMethodInfoPtr_Shake_Public_Static_TweenerCore_3_Vector3_Il2CppStructArray_1_Vector3_Vector3ArrayOptions_DOGetter_1_Vector3_DOSetter_1_Vector3_Single_Vector3_Int32_Single_Boolean_0;

		// Token: 0x04000059 RID: 89
		private static readonly IntPtr NativeMethodInfoPtr_Shake_Private_Static_TweenerCore_3_Vector3_Il2CppStructArray_1_Vector3_Vector3ArrayOptions_DOGetter_1_Vector3_DOSetter_1_Vector3_Single_Vector3_Int32_Single_Boolean_Boolean_Boolean_0;

		// Token: 0x0400005A RID: 90
		private static readonly IntPtr NativeMethodInfoPtr_ToArray_Public_Static_TweenerCore_3_Vector3_Il2CppStructArray_1_Vector3_Vector3ArrayOptions_DOGetter_1_Vector3_DOSetter_1_Vector3_Il2CppStructArray_1_Vector3_Il2CppStructArray_1_Single_0;

		// Token: 0x0400005B RID: 91
		private static readonly IntPtr NativeMethodInfoPtr_To_Internal_Static_TweenerCore_3_Color2_Color2_ColorOptions_DOGetter_1_Color2_DOSetter_1_Color2_Color2_Single_0;

		// Token: 0x0400005C RID: 92
		private static readonly IntPtr NativeMethodInfoPtr_Sequence_Public_Static_Sequence_0;

		// Token: 0x0400005D RID: 93
		private static readonly IntPtr NativeMethodInfoPtr_CompleteAll_Public_Static_Int32_Boolean_0;

		// Token: 0x0400005E RID: 94
		private static readonly IntPtr NativeMethodInfoPtr_Complete_Public_Static_Int32_Object_Boolean_0;

		// Token: 0x0400005F RID: 95
		private static readonly IntPtr NativeMethodInfoPtr_CompleteAndReturnKilledTot_Internal_Static_Int32_0;

		// Token: 0x04000060 RID: 96
		private static readonly IntPtr NativeMethodInfoPtr_CompleteAndReturnKilledTot_Internal_Static_Int32_Object_0;

		// Token: 0x04000061 RID: 97
		private static readonly IntPtr NativeMethodInfoPtr_CompleteAndReturnKilledTotExceptFor_Internal_Static_Int32_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04000062 RID: 98
		private static readonly IntPtr NativeMethodInfoPtr_FlipAll_Public_Static_Int32_0;

		// Token: 0x04000063 RID: 99
		private static readonly IntPtr NativeMethodInfoPtr_Flip_Public_Static_Int32_Object_0;

		// Token: 0x04000064 RID: 100
		private static readonly IntPtr NativeMethodInfoPtr_GotoAll_Public_Static_Int32_Single_Boolean_0;

		// Token: 0x04000065 RID: 101
		private static readonly IntPtr NativeMethodInfoPtr_Goto_Public_Static_Int32_Object_Single_Boolean_0;

		// Token: 0x04000066 RID: 102
		private static readonly IntPtr NativeMethodInfoPtr_KillAll_Public_Static_Int32_Boolean_0;

		// Token: 0x04000067 RID: 103
		private static readonly IntPtr NativeMethodInfoPtr_KillAll_Public_Static_Int32_Boolean_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04000068 RID: 104
		private static readonly IntPtr NativeMethodInfoPtr_Kill_Public_Static_Int32_Object_Boolean_0;

		// Token: 0x04000069 RID: 105
		private static readonly IntPtr NativeMethodInfoPtr_PauseAll_Public_Static_Int32_0;

		// Token: 0x0400006A RID: 106
		private static readonly IntPtr NativeMethodInfoPtr_Pause_Public_Static_Int32_Object_0;

		// Token: 0x0400006B RID: 107
		private static readonly IntPtr NativeMethodInfoPtr_PlayAll_Public_Static_Int32_0;

		// Token: 0x0400006C RID: 108
		private static readonly IntPtr NativeMethodInfoPtr_Play_Public_Static_Int32_Object_0;

		// Token: 0x0400006D RID: 109
		private static readonly IntPtr NativeMethodInfoPtr_Play_Public_Static_Int32_Object_Object_0;

		// Token: 0x0400006E RID: 110
		private static readonly IntPtr NativeMethodInfoPtr_PlayBackwardsAll_Public_Static_Int32_0;

		// Token: 0x0400006F RID: 111
		private static readonly IntPtr NativeMethodInfoPtr_PlayBackwards_Public_Static_Int32_Object_0;

		// Token: 0x04000070 RID: 112
		private static readonly IntPtr NativeMethodInfoPtr_PlayBackwards_Public_Static_Int32_Object_Object_0;

		// Token: 0x04000071 RID: 113
		private static readonly IntPtr NativeMethodInfoPtr_PlayForwardAll_Public_Static_Int32_0;

		// Token: 0x04000072 RID: 114
		private static readonly IntPtr NativeMethodInfoPtr_PlayForward_Public_Static_Int32_Object_0;

		// Token: 0x04000073 RID: 115
		private static readonly IntPtr NativeMethodInfoPtr_PlayForward_Public_Static_Int32_Object_Object_0;

		// Token: 0x04000074 RID: 116
		private static readonly IntPtr NativeMethodInfoPtr_RestartAll_Public_Static_Int32_Boolean_0;

		// Token: 0x04000075 RID: 117
		private static readonly IntPtr NativeMethodInfoPtr_Restart_Public_Static_Int32_Object_Boolean_Single_0;

		// Token: 0x04000076 RID: 118
		private static readonly IntPtr NativeMethodInfoPtr_Restart_Public_Static_Int32_Object_Object_Boolean_Single_0;

		// Token: 0x04000077 RID: 119
		private static readonly IntPtr NativeMethodInfoPtr_RewindAll_Public_Static_Int32_Boolean_0;

		// Token: 0x04000078 RID: 120
		private static readonly IntPtr NativeMethodInfoPtr_Rewind_Public_Static_Int32_Object_Boolean_0;

		// Token: 0x04000079 RID: 121
		private static readonly IntPtr NativeMethodInfoPtr_SmoothRewindAll_Public_Static_Int32_0;

		// Token: 0x0400007A RID: 122
		private static readonly IntPtr NativeMethodInfoPtr_SmoothRewind_Public_Static_Int32_Object_0;

		// Token: 0x0400007B RID: 123
		private static readonly IntPtr NativeMethodInfoPtr_TogglePauseAll_Public_Static_Int32_0;

		// Token: 0x0400007C RID: 124
		private static readonly IntPtr NativeMethodInfoPtr_TogglePause_Public_Static_Int32_Object_0;

		// Token: 0x0400007D RID: 125
		private static readonly IntPtr NativeMethodInfoPtr_IsTweening_Public_Static_Boolean_Object_Boolean_0;

		// Token: 0x0400007E RID: 126
		private static readonly IntPtr NativeMethodInfoPtr_TotalPlayingTweens_Public_Static_Int32_0;

		// Token: 0x0400007F RID: 127
		private static readonly IntPtr NativeMethodInfoPtr_PlayingTweens_Public_Static_List_1_Tween_List_1_Tween_0;

		// Token: 0x04000080 RID: 128
		private static readonly IntPtr NativeMethodInfoPtr_PausedTweens_Public_Static_List_1_Tween_List_1_Tween_0;

		// Token: 0x04000081 RID: 129
		private static readonly IntPtr NativeMethodInfoPtr_TweensById_Public_Static_List_1_Tween_Object_Boolean_List_1_Tween_0;

		// Token: 0x04000082 RID: 130
		private static readonly IntPtr NativeMethodInfoPtr_TweensByTarget_Public_Static_List_1_Tween_Object_Boolean_List_1_Tween_0;

		// Token: 0x04000083 RID: 131
		private static readonly IntPtr NativeMethodInfoPtr_InitCheck_Private_Static_Void_0;

		// Token: 0x04000084 RID: 132
		private static readonly IntPtr NativeMethodInfoPtr_ApplyTo_Private_Static_TweenerCore_3_T1_T2_TPlugOptions_DOGetter_1_T1_DOSetter_1_T1_T2_Single_ABSTweenPlugin_3_T1_T2_TPlugOptions_0;

		// Token: 0x04000085 RID: 133
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200005C RID: 92
		[ObfuscatedName("DG.Tweening.DOTween+<>c__DisplayClass55_0")]
		public sealed class __c__DisplayClass55_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06000557 RID: 1367 RVA: 0x0001D680 File Offset: 0x0001B880
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass55_0()
			{
				Il2CppClassPointerStore<DOTween.__c__DisplayClass55_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DOTween>.NativeClassPtr, "<>c__DisplayClass55_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DOTween.__c__DisplayClass55_0>.NativeClassPtr);
				DOTween.__c__DisplayClass55_0.NativeFieldInfoPtr_v = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTween.__c__DisplayClass55_0>.NativeClassPtr, "v");
				DOTween.__c__DisplayClass55_0.NativeFieldInfoPtr_setter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTween.__c__DisplayClass55_0>.NativeClassPtr, "setter");
				DOTween.__c__DisplayClass55_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTween.__c__DisplayClass55_0>.NativeClassPtr, 100663390);
				DOTween.__c__DisplayClass55_0.NativeMethodInfoPtr__To_b__0_Internal_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTween.__c__DisplayClass55_0>.NativeClassPtr, 100663391);
				DOTween.__c__DisplayClass55_0.NativeMethodInfoPtr__To_b__1_Internal_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTween.__c__DisplayClass55_0>.NativeClassPtr, 100663392);
			}

			// Token: 0x06000558 RID: 1368 RVA: 0x0001D710 File Offset: 0x0001B910
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass55_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DOTween.__c__DisplayClass55_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTween.__c__DisplayClass55_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000559 RID: 1369 RVA: 0x0001D74C File Offset: 0x0001B94C
			[CallerCount(0)]
			public unsafe float _To_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTween.__c__DisplayClass55_0.NativeMethodInfoPtr__To_b__0_Internal_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600055A RID: 1370 RVA: 0x0001D788 File Offset: 0x0001B988
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1126903, XrefRangeEnd = 1126904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _To_b__1(float x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTween.__c__DisplayClass55_0.NativeMethodInfoPtr__To_b__1_Internal_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600055B RID: 1371 RVA: 0x00003BE2 File Offset: 0x00001DE2
			public __c__DisplayClass55_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000101 RID: 257
			// (get) Token: 0x0600055C RID: 1372 RVA: 0x0001D7C8 File Offset: 0x0001B9C8
			// (set) Token: 0x0600055D RID: 1373 RVA: 0x00003BEB File Offset: 0x00001DEB
			public unsafe float v
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTween.__c__DisplayClass55_0.NativeFieldInfoPtr_v);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTween.__c__DisplayClass55_0.NativeFieldInfoPtr_v)) = value;
				}
			}

			// Token: 0x17000102 RID: 258
			// (get) Token: 0x0600055E RID: 1374 RVA: 0x0001D7F0 File Offset: 0x0001B9F0
			// (set) Token: 0x0600055F RID: 1375 RVA: 0x00003C06 File Offset: 0x00001E06
			public unsafe DOSetter<float> setter
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTween.__c__DisplayClass55_0.NativeFieldInfoPtr_setter);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DOSetter<float>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTween.__c__DisplayClass55_0.NativeFieldInfoPtr_setter), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000451 RID: 1105
			private static readonly IntPtr NativeFieldInfoPtr_v;

			// Token: 0x04000452 RID: 1106
			private static readonly IntPtr NativeFieldInfoPtr_setter;

			// Token: 0x04000453 RID: 1107
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000454 RID: 1108
			private static readonly IntPtr NativeMethodInfoPtr__To_b__0_Internal_Single_0;

			// Token: 0x04000455 RID: 1109
			private static readonly IntPtr NativeMethodInfoPtr__To_b__1_Internal_Void_Single_0;
		}

		// Token: 0x0200005D RID: 93
		private sealed class MethodInfoStoreGeneric_To_Public_Static_TweenerCore_3_T1_T2_TPlugOptions_ABSTweenPlugin_3_T1_T2_TPlugOptions_DOGetter_1_T1_DOSetter_1_T1_T2_Single_0<T1, T2, TPlugOptions>
		{
			// Token: 0x04000456 RID: 1110
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(DOTween.NativeMethodInfoPtr_To_Public_Static_TweenerCore_3_T1_T2_TPlugOptions_ABSTweenPlugin_3_T1_T2_TPlugOptions_DOGetter_1_T1_DOSetter_1_T1_T2_Single_0, Il2CppClassPointerStore<DOTween>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T2>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TPlugOptions>.NativeClassPtr))
			}))));
		}

		// Token: 0x0200005E RID: 94
		private sealed class MethodInfoStoreGeneric_ApplyTo_Private_Static_TweenerCore_3_T1_T2_TPlugOptions_DOGetter_1_T1_DOSetter_1_T1_T2_Single_ABSTweenPlugin_3_T1_T2_TPlugOptions_0<T1, T2, TPlugOptions>
		{
			// Token: 0x04000457 RID: 1111
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(DOTween.NativeMethodInfoPtr_ApplyTo_Private_Static_TweenerCore_3_T1_T2_TPlugOptions_DOGetter_1_T1_DOSetter_1_T1_T2_Single_ABSTweenPlugin_3_T1_T2_TPlugOptions_0, Il2CppClassPointerStore<DOTween>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T2>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TPlugOptions>.NativeClassPtr))
			}))));
		}
	}
}
