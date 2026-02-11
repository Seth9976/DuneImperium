using System;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Core.PathCore;
using DG.Tweening.Plugins.Options;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;
using UnityEngine;

namespace DG.Tweening
{
	// Token: 0x02000016 RID: 22
	public static class TweenSettingsExtensions : global::Il2CppSystem.Object
	{
		// Token: 0x060001AB RID: 427 RVA: 0x0000DF90 File Offset: 0x0000C190
		// Note: this type is marked as 'beforefieldinit'.
		static TweenSettingsExtensions()
		{
			Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("DOTween.dll", "DG.Tweening", "TweenSettingsExtensions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr);
			TweenSettingsExtensions.NativeMethodInfoPtr_SetAutoKill_Public_Static_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr, 100663849);
			TweenSettingsExtensions.NativeMethodInfoPtr_SetAutoKill_Public_Static_T_T_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr, 100663850);
			TweenSettingsExtensions.NativeMethodInfoPtr_SetId_Public_Static_T_T_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr, 100663851);
			TweenSettingsExtensions.NativeMethodInfoPtr_SetId_Public_Static_T_T_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr, 100663852);
			TweenSettingsExtensions.NativeMethodInfoPtr_SetId_Public_Static_T_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr, 100663853);
			TweenSettingsExtensions.NativeMethodInfoPtr_SetTarget_Public_Static_T_T_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr, 100663854);
			TweenSettingsExtensions.NativeMethodInfoPtr_SetLoops_Public_Static_T_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr, 100663855);
			TweenSettingsExtensions.NativeMethodInfoPtr_SetLoops_Public_Static_T_T_Int32_LoopType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr, 100663856);
			TweenSettingsExtensions.NativeMethodInfoPtr_SetEase_Public_Static_T_T_Ease_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr, 100663857);
			TweenSettingsExtensions.NativeMethodInfoPtr_SetEase_Public_Static_T_T_Ease_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr, 100663858);
			TweenSettingsExtensions.NativeMethodInfoPtr_SetEase_Public_Static_T_T_Ease_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr, 100663859);
			TweenSettingsExtensions.NativeMethodInfoPtr_SetEase_Public_Static_T_T_AnimationCurve_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr, 100663860);
			TweenSettingsExtensions.NativeMethodInfoPtr_SetEase_Public_Static_T_T_EaseFunction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr, 100663861);
			TweenSettingsExtensions.NativeMethodInfoPtr_SetRecyclable_Public_Static_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr, 100663862);
			TweenSettingsExtensions.NativeMethodInfoPtr_SetRecyclable_Public_Static_T_T_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr, 100663863);
			TweenSettingsExtensions.NativeMethodInfoPtr_SetUpdate_Public_Static_T_T_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr, 100663864);
			TweenSettingsExtensions.NativeMethodInfoPtr_SetUpdate_Public_Static_T_T_UpdateType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr, 100663865);
			TweenSettingsExtensions.NativeMethodInfoPtr_SetUpdate_Public_Static_T_T_UpdateType_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr, 100663866);
			TweenSettingsExtensions.NativeMethodInfoPtr_OnStart_Public_Static_T_T_TweenCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr, 100663867);
			TweenSettingsExtensions.NativeMethodInfoPtr_OnPlay_Public_Static_T_T_TweenCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr, 100663868);
			TweenSettingsExtensions.NativeMethodInfoPtr_OnPause_Public_Static_T_T_TweenCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr, 100663869);
			TweenSettingsExtensions.NativeMethodInfoPtr_OnRewind_Public_Static_T_T_TweenCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr, 100663870);
			TweenSettingsExtensions.NativeMethodInfoPtr_OnUpdate_Public_Static_T_T_TweenCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr, 100663871);
			TweenSettingsExtensions.NativeMethodInfoPtr_OnStepComplete_Public_Static_T_T_TweenCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr, 100663872);
			TweenSettingsExtensions.NativeMethodInfoPtr_OnComplete_Public_Static_T_T_TweenCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr, 100663873);
			TweenSettingsExtensions.NativeMethodInfoPtr_OnKill_Public_Static_T_T_TweenCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr, 100663874);
			TweenSettingsExtensions.NativeMethodInfoPtr_OnWaypointChange_Public_Static_T_T_TweenCallback_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr, 100663875);
			TweenSettingsExtensions.NativeMethodInfoPtr_SetAs_Public_Static_T_T_Tween_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr, 100663876);
			TweenSettingsExtensions.NativeMethodInfoPtr_SetAs_Public_Static_T_T_TweenParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr, 100663877);
			TweenSettingsExtensions.NativeMethodInfoPtr_Append_Public_Static_Sequence_Sequence_Tween_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr, 100663878);
			TweenSettingsExtensions.NativeMethodInfoPtr_Prepend_Public_Static_Sequence_Sequence_Tween_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr, 100663879);
			TweenSettingsExtensions.NativeMethodInfoPtr_Join_Public_Static_Sequence_Sequence_Tween_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr, 100663880);
			TweenSettingsExtensions.NativeMethodInfoPtr_Insert_Public_Static_Sequence_Sequence_Single_Tween_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr, 100663881);
			TweenSettingsExtensions.NativeMethodInfoPtr_AppendInterval_Public_Static_Sequence_Sequence_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr, 100663882);
			TweenSettingsExtensions.NativeMethodInfoPtr_PrependInterval_Public_Static_Sequence_Sequence_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr, 100663883);
			TweenSettingsExtensions.NativeMethodInfoPtr_AppendCallback_Public_Static_Sequence_Sequence_TweenCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr, 100663884);
			TweenSettingsExtensions.NativeMethodInfoPtr_PrependCallback_Public_Static_Sequence_Sequence_TweenCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr, 100663885);
			TweenSettingsExtensions.NativeMethodInfoPtr_InsertCallback_Public_Static_Sequence_Sequence_Single_TweenCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr, 100663886);
			TweenSettingsExtensions.NativeMethodInfoPtr_From_Public_Static_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr, 100663887);
			TweenSettingsExtensions.NativeMethodInfoPtr_From_Public_Static_T_T_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr, 100663888);
			TweenSettingsExtensions.NativeMethodInfoPtr_SetDelay_Public_Static_T_T_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr, 100663889);
			TweenSettingsExtensions.NativeMethodInfoPtr_SetRelative_Public_Static_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr, 100663890);
			TweenSettingsExtensions.NativeMethodInfoPtr_SetRelative_Public_Static_T_T_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr, 100663891);
			TweenSettingsExtensions.NativeMethodInfoPtr_SetSpeedBased_Public_Static_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr, 100663892);
			TweenSettingsExtensions.NativeMethodInfoPtr_SetSpeedBased_Public_Static_T_T_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr, 100663893);
			TweenSettingsExtensions.NativeMethodInfoPtr_SetOptions_Public_Static_Tweener_TweenerCore_3_Single_Single_FloatOptions_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr, 100663894);
			TweenSettingsExtensions.NativeMethodInfoPtr_SetOptions_Public_Static_Tweener_TweenerCore_3_Vector2_Vector2_VectorOptions_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr, 100663895);
			TweenSettingsExtensions.NativeMethodInfoPtr_SetOptions_Public_Static_Tweener_TweenerCore_3_Vector2_Vector2_VectorOptions_AxisConstraint_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr, 100663896);
			TweenSettingsExtensions.NativeMethodInfoPtr_SetOptions_Public_Static_Tweener_TweenerCore_3_Vector3_Vector3_VectorOptions_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr, 100663897);
			TweenSettingsExtensions.NativeMethodInfoPtr_SetOptions_Public_Static_Tweener_TweenerCore_3_Vector3_Vector3_VectorOptions_AxisConstraint_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr, 100663898);
			TweenSettingsExtensions.NativeMethodInfoPtr_SetOptions_Public_Static_Tweener_TweenerCore_3_Vector4_Vector4_VectorOptions_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr, 100663899);
			TweenSettingsExtensions.NativeMethodInfoPtr_SetOptions_Public_Static_Tweener_TweenerCore_3_Vector4_Vector4_VectorOptions_AxisConstraint_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr, 100663900);
			TweenSettingsExtensions.NativeMethodInfoPtr_SetOptions_Public_Static_Tweener_TweenerCore_3_Quaternion_Vector3_QuaternionOptions_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr, 100663901);
			TweenSettingsExtensions.NativeMethodInfoPtr_SetOptions_Public_Static_Tweener_TweenerCore_3_Color_Color_ColorOptions_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr, 100663902);
			TweenSettingsExtensions.NativeMethodInfoPtr_SetOptions_Public_Static_Tweener_TweenerCore_3_Rect_Rect_RectOptions_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr, 100663903);
			TweenSettingsExtensions.NativeMethodInfoPtr_SetOptions_Public_Static_Tweener_TweenerCore_3_String_String_StringOptions_Boolean_ScrambleMode_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr, 100663904);
			TweenSettingsExtensions.NativeMethodInfoPtr_SetOptions_Public_Static_Tweener_TweenerCore_3_Vector3_Il2CppStructArray_1_Vector3_Vector3ArrayOptions_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr, 100663905);
			TweenSettingsExtensions.NativeMethodInfoPtr_SetOptions_Public_Static_Tweener_TweenerCore_3_Vector3_Il2CppStructArray_1_Vector3_Vector3ArrayOptions_AxisConstraint_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr, 100663906);
			TweenSettingsExtensions.NativeMethodInfoPtr_SetOptions_Public_Static_TweenerCore_3_Vector3_Path_PathOptions_TweenerCore_3_Vector3_Path_PathOptions_AxisConstraint_AxisConstraint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr, 100663907);
			TweenSettingsExtensions.NativeMethodInfoPtr_SetOptions_Public_Static_TweenerCore_3_Vector3_Path_PathOptions_TweenerCore_3_Vector3_Path_PathOptions_Boolean_AxisConstraint_AxisConstraint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr, 100663908);
			TweenSettingsExtensions.NativeMethodInfoPtr_SetLookAt_Public_Static_TweenerCore_3_Vector3_Path_PathOptions_TweenerCore_3_Vector3_Path_PathOptions_Vector3_Nullable_1_Vector3_Nullable_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr, 100663909);
			TweenSettingsExtensions.NativeMethodInfoPtr_SetLookAt_Public_Static_TweenerCore_3_Vector3_Path_PathOptions_TweenerCore_3_Vector3_Path_PathOptions_Transform_Nullable_1_Vector3_Nullable_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr, 100663910);
			TweenSettingsExtensions.NativeMethodInfoPtr_SetLookAt_Public_Static_TweenerCore_3_Vector3_Path_PathOptions_TweenerCore_3_Vector3_Path_PathOptions_Single_Nullable_1_Vector3_Nullable_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr, 100663911);
			TweenSettingsExtensions.NativeMethodInfoPtr_SetPathForwardDirection_Private_Static_Void_TweenerCore_3_Vector3_Path_PathOptions_Nullable_1_Vector3_Nullable_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr, 100663912);
		}

		// Token: 0x060001AC RID: 428 RVA: 0x0000E4C0 File Offset: 0x0000C6C0
		[CallerCount(0)]
		public unsafe static T SetAutoKill<T>(this T t) where T : Tween
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t2 = t;
					intPtr = ((t2 is string) ? IL2CPP.ManagedStringToIl2Cpp(t2 as string) : IL2CPP.Il2CppObjectBaseToPtr(t2 as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref t;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(TweenSettingsExtensions.MethodInfoStoreGeneric_SetAutoKill_Public_Static_T_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return IL2CPP.PointerToValueGeneric<T>(intPtr2, false, true);
			}
		}

		// Token: 0x060001AD RID: 429 RVA: 0x0000E534 File Offset: 0x0000C734
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1131329, RefRangeEnd = 1131330, XrefRangeStart = 1131329, XrefRangeEnd = 1131329, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T SetAutoKill<T>(this T t, bool autoKillOnCompletion) where T : Tween
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t2 = t;
					intPtr = ((t2 is string) ? IL2CPP.ManagedStringToIl2Cpp(t2 as string) : IL2CPP.Il2CppObjectBaseToPtr(t2 as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref t;
				}
				ptr2 = intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref autoKillOnCompletion;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(TweenSettingsExtensions.MethodInfoStoreGeneric_SetAutoKill_Public_Static_T_T_Boolean_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return IL2CPP.PointerToValueGeneric<T>(intPtr2, false, true);
		}

		// Token: 0x060001AE RID: 430 RVA: 0x0000E5B8 File Offset: 0x0000C7B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1131330, XrefRangeEnd = 1131331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T SetId<T>(this T t, global::Il2CppSystem.Object objectId) where T : Tween
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t2 = t;
					intPtr = ((t2 is string) ? IL2CPP.ManagedStringToIl2Cpp(t2 as string) : IL2CPP.Il2CppObjectBaseToPtr(t2 as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref t;
				}
				ptr2 = intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(objectId);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(TweenSettingsExtensions.MethodInfoStoreGeneric_SetId_Public_Static_T_T_Object_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return IL2CPP.PointerToValueGeneric<T>(intPtr2, false, true);
		}

		// Token: 0x060001AF RID: 431 RVA: 0x0000E640 File Offset: 0x0000C840
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1131331, XrefRangeEnd = 1131332, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T SetId<T>(this T t, string stringId) where T : Tween
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t2 = t;
					intPtr = ((t2 is string) ? IL2CPP.ManagedStringToIl2Cpp(t2 as string) : IL2CPP.Il2CppObjectBaseToPtr(t2 as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref t;
				}
				ptr2 = intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(stringId);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(TweenSettingsExtensions.MethodInfoStoreGeneric_SetId_Public_Static_T_T_String_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return IL2CPP.PointerToValueGeneric<T>(intPtr2, false, true);
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x0000E6C8 File Offset: 0x0000C8C8
		[CallerCount(0)]
		public unsafe static T SetId<T>(this T t, int intId) where T : Tween
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t2 = t;
					intPtr = ((t2 is string) ? IL2CPP.ManagedStringToIl2Cpp(t2 as string) : IL2CPP.Il2CppObjectBaseToPtr(t2 as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref t;
				}
				ptr2 = intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref intId;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(TweenSettingsExtensions.MethodInfoStoreGeneric_SetId_Public_Static_T_T_Int32_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return IL2CPP.PointerToValueGeneric<T>(intPtr2, false, true);
		}

		// Token: 0x060001B1 RID: 433 RVA: 0x0000E74C File Offset: 0x0000C94C
		[CallerCount(84)]
		[CachedScanResults(RefRangeStart = 1131333, RefRangeEnd = 1131417, XrefRangeStart = 1131332, XrefRangeEnd = 1131333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T SetTarget<T>(this T t, global::Il2CppSystem.Object target) where T : Tween
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t2 = t;
					intPtr = ((t2 is string) ? IL2CPP.ManagedStringToIl2Cpp(t2 as string) : IL2CPP.Il2CppObjectBaseToPtr(t2 as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref t;
				}
				ptr2 = intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(target);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(TweenSettingsExtensions.MethodInfoStoreGeneric_SetTarget_Public_Static_T_T_Object_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return IL2CPP.PointerToValueGeneric<T>(intPtr2, false, true);
		}

		// Token: 0x060001B2 RID: 434 RVA: 0x0000E7D4 File Offset: 0x0000C9D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1131417, XrefRangeEnd = 1131418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T SetLoops<T>(this T t, int loops) where T : Tween
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t2 = t;
					intPtr = ((t2 is string) ? IL2CPP.ManagedStringToIl2Cpp(t2 as string) : IL2CPP.Il2CppObjectBaseToPtr(t2 as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref t;
				}
				ptr2 = intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref loops;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(TweenSettingsExtensions.MethodInfoStoreGeneric_SetLoops_Public_Static_T_T_Int32_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return IL2CPP.PointerToValueGeneric<T>(intPtr2, false, true);
		}

		// Token: 0x060001B3 RID: 435 RVA: 0x0000E858 File Offset: 0x0000CA58
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1131419, RefRangeEnd = 1131422, XrefRangeStart = 1131418, XrefRangeEnd = 1131419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T SetLoops<T>(this T t, int loops, LoopType loopType) where T : Tween
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t2 = t;
					intPtr = ((t2 is string) ? IL2CPP.ManagedStringToIl2Cpp(t2 as string) : IL2CPP.Il2CppObjectBaseToPtr(t2 as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref t;
				}
				ptr2 = intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref loops;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref loopType;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(TweenSettingsExtensions.MethodInfoStoreGeneric_SetLoops_Public_Static_T_T_Int32_LoopType_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return IL2CPP.PointerToValueGeneric<T>(intPtr2, false, true);
		}

		// Token: 0x060001B4 RID: 436 RVA: 0x0000E8E8 File Offset: 0x0000CAE8
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 1131424, RefRangeEnd = 1131439, XrefRangeStart = 1131422, XrefRangeEnd = 1131424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T SetEase<T>(this T t, Ease ease) where T : Tween
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t2 = t;
					intPtr = ((t2 is string) ? IL2CPP.ManagedStringToIl2Cpp(t2 as string) : IL2CPP.Il2CppObjectBaseToPtr(t2 as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref t;
				}
				ptr2 = intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ease;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(TweenSettingsExtensions.MethodInfoStoreGeneric_SetEase_Public_Static_T_T_Ease_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return IL2CPP.PointerToValueGeneric<T>(intPtr2, false, true);
		}

		// Token: 0x060001B5 RID: 437 RVA: 0x0000E96C File Offset: 0x0000CB6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1131439, XrefRangeEnd = 1131441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T SetEase<T>(this T t, Ease ease, float overshoot) where T : Tween
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t2 = t;
					intPtr = ((t2 is string) ? IL2CPP.ManagedStringToIl2Cpp(t2 as string) : IL2CPP.Il2CppObjectBaseToPtr(t2 as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref t;
				}
				ptr2 = intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ease;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref overshoot;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(TweenSettingsExtensions.MethodInfoStoreGeneric_SetEase_Public_Static_T_T_Ease_Single_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return IL2CPP.PointerToValueGeneric<T>(intPtr2, false, true);
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x0000E9FC File Offset: 0x0000CBFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1131441, XrefRangeEnd = 1131443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T SetEase<T>(this T t, Ease ease, float amplitude, float period) where T : Tween
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t2 = t;
					intPtr = ((t2 is string) ? IL2CPP.ManagedStringToIl2Cpp(t2 as string) : IL2CPP.Il2CppObjectBaseToPtr(t2 as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref t;
				}
				ptr2 = intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ease;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref amplitude;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref period;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(TweenSettingsExtensions.MethodInfoStoreGeneric_SetEase_Public_Static_T_T_Ease_Single_Single_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return IL2CPP.PointerToValueGeneric<T>(intPtr2, false, true);
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x0000EA9C File Offset: 0x0000CC9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1131443, XrefRangeEnd = 1131454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T SetEase<T>(this T t, AnimationCurve animCurve) where T : Tween
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t2 = t;
					intPtr = ((t2 is string) ? IL2CPP.ManagedStringToIl2Cpp(t2 as string) : IL2CPP.Il2CppObjectBaseToPtr(t2 as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref t;
				}
				ptr2 = intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(animCurve);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(TweenSettingsExtensions.MethodInfoStoreGeneric_SetEase_Public_Static_T_T_AnimationCurve_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return IL2CPP.PointerToValueGeneric<T>(intPtr2, false, true);
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x0000EB24 File Offset: 0x0000CD24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1131454, XrefRangeEnd = 1131455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T SetEase<T>(this T t, EaseFunction customEase) where T : Tween
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t2 = t;
					intPtr = ((t2 is string) ? IL2CPP.ManagedStringToIl2Cpp(t2 as string) : IL2CPP.Il2CppObjectBaseToPtr(t2 as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref t;
				}
				ptr2 = intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(customEase);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(TweenSettingsExtensions.MethodInfoStoreGeneric_SetEase_Public_Static_T_T_EaseFunction_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return IL2CPP.PointerToValueGeneric<T>(intPtr2, false, true);
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x0000EBAC File Offset: 0x0000CDAC
		[CallerCount(0)]
		public unsafe static T SetRecyclable<T>(this T t) where T : Tween
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t2 = t;
					intPtr = ((t2 is string) ? IL2CPP.ManagedStringToIl2Cpp(t2 as string) : IL2CPP.Il2CppObjectBaseToPtr(t2 as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref t;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(TweenSettingsExtensions.MethodInfoStoreGeneric_SetRecyclable_Public_Static_T_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return IL2CPP.PointerToValueGeneric<T>(intPtr2, false, true);
			}
		}

		// Token: 0x060001BA RID: 442 RVA: 0x0000EC20 File Offset: 0x0000CE20
		[CallerCount(0)]
		public unsafe static T SetRecyclable<T>(this T t, bool recyclable) where T : Tween
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t2 = t;
					intPtr = ((t2 is string) ? IL2CPP.ManagedStringToIl2Cpp(t2 as string) : IL2CPP.Il2CppObjectBaseToPtr(t2 as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref t;
				}
				ptr2 = intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref recyclable;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(TweenSettingsExtensions.MethodInfoStoreGeneric_SetRecyclable_Public_Static_T_T_Boolean_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return IL2CPP.PointerToValueGeneric<T>(intPtr2, false, true);
		}

		// Token: 0x060001BB RID: 443 RVA: 0x0000ECA4 File Offset: 0x0000CEA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1131455, XrefRangeEnd = 1131463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T SetUpdate<T>(this T t, bool isIndependentUpdate) where T : Tween
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t2 = t;
					intPtr = ((t2 is string) ? IL2CPP.ManagedStringToIl2Cpp(t2 as string) : IL2CPP.Il2CppObjectBaseToPtr(t2 as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref t;
				}
				ptr2 = intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isIndependentUpdate;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(TweenSettingsExtensions.MethodInfoStoreGeneric_SetUpdate_Public_Static_T_T_Boolean_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return IL2CPP.PointerToValueGeneric<T>(intPtr2, false, true);
		}

		// Token: 0x060001BC RID: 444 RVA: 0x0000ED28 File Offset: 0x0000CF28
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1131471, RefRangeEnd = 1131476, XrefRangeStart = 1131463, XrefRangeEnd = 1131471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T SetUpdate<T>(this T t, UpdateType updateType) where T : Tween
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t2 = t;
					intPtr = ((t2 is string) ? IL2CPP.ManagedStringToIl2Cpp(t2 as string) : IL2CPP.Il2CppObjectBaseToPtr(t2 as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref t;
				}
				ptr2 = intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref updateType;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(TweenSettingsExtensions.MethodInfoStoreGeneric_SetUpdate_Public_Static_T_T_UpdateType_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return IL2CPP.PointerToValueGeneric<T>(intPtr2, false, true);
		}

		// Token: 0x060001BD RID: 445 RVA: 0x0000EDAC File Offset: 0x0000CFAC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1131480, RefRangeEnd = 1131481, XrefRangeStart = 1131476, XrefRangeEnd = 1131480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T SetUpdate<T>(this T t, UpdateType updateType, bool isIndependentUpdate) where T : Tween
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t2 = t;
					intPtr = ((t2 is string) ? IL2CPP.ManagedStringToIl2Cpp(t2 as string) : IL2CPP.Il2CppObjectBaseToPtr(t2 as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref t;
				}
				ptr2 = intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref updateType;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isIndependentUpdate;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(TweenSettingsExtensions.MethodInfoStoreGeneric_SetUpdate_Public_Static_T_T_UpdateType_Boolean_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return IL2CPP.PointerToValueGeneric<T>(intPtr2, false, true);
		}

		// Token: 0x060001BE RID: 446 RVA: 0x0000EE3C File Offset: 0x0000D03C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1131481, XrefRangeEnd = 1131482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T OnStart<T>(this T t, TweenCallback action) where T : Tween
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t2 = t;
					intPtr = ((t2 is string) ? IL2CPP.ManagedStringToIl2Cpp(t2 as string) : IL2CPP.Il2CppObjectBaseToPtr(t2 as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref t;
				}
				ptr2 = intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(TweenSettingsExtensions.MethodInfoStoreGeneric_OnStart_Public_Static_T_T_TweenCallback_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return IL2CPP.PointerToValueGeneric<T>(intPtr2, false, true);
		}

		// Token: 0x060001BF RID: 447 RVA: 0x0000EEC4 File Offset: 0x0000D0C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1131482, XrefRangeEnd = 1131483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T OnPlay<T>(this T t, TweenCallback action) where T : Tween
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t2 = t;
					intPtr = ((t2 is string) ? IL2CPP.ManagedStringToIl2Cpp(t2 as string) : IL2CPP.Il2CppObjectBaseToPtr(t2 as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref t;
				}
				ptr2 = intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(TweenSettingsExtensions.MethodInfoStoreGeneric_OnPlay_Public_Static_T_T_TweenCallback_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return IL2CPP.PointerToValueGeneric<T>(intPtr2, false, true);
		}

		// Token: 0x060001C0 RID: 448 RVA: 0x0000EF4C File Offset: 0x0000D14C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1131483, XrefRangeEnd = 1131484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T OnPause<T>(this T t, TweenCallback action) where T : Tween
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t2 = t;
					intPtr = ((t2 is string) ? IL2CPP.ManagedStringToIl2Cpp(t2 as string) : IL2CPP.Il2CppObjectBaseToPtr(t2 as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref t;
				}
				ptr2 = intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(TweenSettingsExtensions.MethodInfoStoreGeneric_OnPause_Public_Static_T_T_TweenCallback_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return IL2CPP.PointerToValueGeneric<T>(intPtr2, false, true);
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x0000EFD4 File Offset: 0x0000D1D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1131484, XrefRangeEnd = 1131485, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T OnRewind<T>(this T t, TweenCallback action) where T : Tween
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t2 = t;
					intPtr = ((t2 is string) ? IL2CPP.ManagedStringToIl2Cpp(t2 as string) : IL2CPP.Il2CppObjectBaseToPtr(t2 as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref t;
				}
				ptr2 = intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(TweenSettingsExtensions.MethodInfoStoreGeneric_OnRewind_Public_Static_T_T_TweenCallback_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return IL2CPP.PointerToValueGeneric<T>(intPtr2, false, true);
		}

		// Token: 0x060001C2 RID: 450 RVA: 0x0000F05C File Offset: 0x0000D25C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1131486, RefRangeEnd = 1131491, XrefRangeStart = 1131485, XrefRangeEnd = 1131486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T OnUpdate<T>(this T t, TweenCallback action) where T : Tween
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t2 = t;
					intPtr = ((t2 is string) ? IL2CPP.ManagedStringToIl2Cpp(t2 as string) : IL2CPP.Il2CppObjectBaseToPtr(t2 as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref t;
				}
				ptr2 = intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(TweenSettingsExtensions.MethodInfoStoreGeneric_OnUpdate_Public_Static_T_T_TweenCallback_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return IL2CPP.PointerToValueGeneric<T>(intPtr2, false, true);
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x0000F0E4 File Offset: 0x0000D2E4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1131492, RefRangeEnd = 1131493, XrefRangeStart = 1131491, XrefRangeEnd = 1131492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T OnStepComplete<T>(this T t, TweenCallback action) where T : Tween
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t2 = t;
					intPtr = ((t2 is string) ? IL2CPP.ManagedStringToIl2Cpp(t2 as string) : IL2CPP.Il2CppObjectBaseToPtr(t2 as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref t;
				}
				ptr2 = intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(TweenSettingsExtensions.MethodInfoStoreGeneric_OnStepComplete_Public_Static_T_T_TweenCallback_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return IL2CPP.PointerToValueGeneric<T>(intPtr2, false, true);
		}

		// Token: 0x060001C4 RID: 452 RVA: 0x0000F16C File Offset: 0x0000D36C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1131494, RefRangeEnd = 1131495, XrefRangeStart = 1131493, XrefRangeEnd = 1131494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T OnComplete<T>(this T t, TweenCallback action) where T : Tween
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t2 = t;
					intPtr = ((t2 is string) ? IL2CPP.ManagedStringToIl2Cpp(t2 as string) : IL2CPP.Il2CppObjectBaseToPtr(t2 as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref t;
				}
				ptr2 = intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(TweenSettingsExtensions.MethodInfoStoreGeneric_OnComplete_Public_Static_T_T_TweenCallback_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return IL2CPP.PointerToValueGeneric<T>(intPtr2, false, true);
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x0000F1F4 File Offset: 0x0000D3F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1131495, XrefRangeEnd = 1131496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T OnKill<T>(this T t, TweenCallback action) where T : Tween
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t2 = t;
					intPtr = ((t2 is string) ? IL2CPP.ManagedStringToIl2Cpp(t2 as string) : IL2CPP.Il2CppObjectBaseToPtr(t2 as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref t;
				}
				ptr2 = intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(TweenSettingsExtensions.MethodInfoStoreGeneric_OnKill_Public_Static_T_T_TweenCallback_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return IL2CPP.PointerToValueGeneric<T>(intPtr2, false, true);
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x0000F27C File Offset: 0x0000D47C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1131496, XrefRangeEnd = 1131497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T OnWaypointChange<T>(this T t, TweenCallback<int> action) where T : Tween
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t2 = t;
					intPtr = ((t2 is string) ? IL2CPP.ManagedStringToIl2Cpp(t2 as string) : IL2CPP.Il2CppObjectBaseToPtr(t2 as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref t;
				}
				ptr2 = intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(TweenSettingsExtensions.MethodInfoStoreGeneric_OnWaypointChange_Public_Static_T_T_TweenCallback_1_Int32_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return IL2CPP.PointerToValueGeneric<T>(intPtr2, false, true);
		}

		// Token: 0x060001C7 RID: 455 RVA: 0x0000F304 File Offset: 0x0000D504
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1131497, XrefRangeEnd = 1131512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T SetAs<T>(this T t, Tween asTween) where T : Tween
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t2 = t;
					intPtr = ((t2 is string) ? IL2CPP.ManagedStringToIl2Cpp(t2 as string) : IL2CPP.Il2CppObjectBaseToPtr(t2 as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref t;
				}
				ptr2 = intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(asTween);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(TweenSettingsExtensions.MethodInfoStoreGeneric_SetAs_Public_Static_T_T_Tween_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return IL2CPP.PointerToValueGeneric<T>(intPtr2, false, true);
		}

		// Token: 0x060001C8 RID: 456 RVA: 0x0000F38C File Offset: 0x0000D58C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1131512, XrefRangeEnd = 1131533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T SetAs<T>(this T t, TweenParams tweenParams) where T : Tween
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t2 = t;
					intPtr = ((t2 is string) ? IL2CPP.ManagedStringToIl2Cpp(t2 as string) : IL2CPP.Il2CppObjectBaseToPtr(t2 as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref t;
				}
				ptr2 = intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(tweenParams);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(TweenSettingsExtensions.MethodInfoStoreGeneric_SetAs_Public_Static_T_T_TweenParams_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return IL2CPP.PointerToValueGeneric<T>(intPtr2, false, true);
		}

		// Token: 0x060001C9 RID: 457 RVA: 0x0000F414 File Offset: 0x0000D614
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1131533, XrefRangeEnd = 1131534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Sequence Append(this Sequence s, Tween t)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(t);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenSettingsExtensions.NativeMethodInfoPtr_Append_Public_Static_Sequence_Sequence_Tween_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sequence>(intPtr3) : null;
		}

		// Token: 0x060001CA RID: 458 RVA: 0x0000F46C File Offset: 0x0000D66C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1131534, XrefRangeEnd = 1131539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Sequence Prepend(this Sequence s, Tween t)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(t);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenSettingsExtensions.NativeMethodInfoPtr_Prepend_Public_Static_Sequence_Sequence_Tween_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sequence>(intPtr3) : null;
		}

		// Token: 0x060001CB RID: 459 RVA: 0x0000F4C4 File Offset: 0x0000D6C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1131539, XrefRangeEnd = 1131540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Sequence Join(this Sequence s, Tween t)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(t);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenSettingsExtensions.NativeMethodInfoPtr_Join_Public_Static_Sequence_Sequence_Tween_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sequence>(intPtr3) : null;
		}

		// Token: 0x060001CC RID: 460 RVA: 0x0000F51C File Offset: 0x0000D71C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1131540, XrefRangeEnd = 1131541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Sequence Insert(this Sequence s, float atPosition, Tween t)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref atPosition;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(t);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenSettingsExtensions.NativeMethodInfoPtr_Insert_Public_Static_Sequence_Sequence_Single_Tween_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sequence>(intPtr3) : null;
		}

		// Token: 0x060001CD RID: 461 RVA: 0x0000F580 File Offset: 0x0000D780
		[CallerCount(0)]
		public unsafe static Sequence AppendInterval(this Sequence s, float interval)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref interval;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenSettingsExtensions.NativeMethodInfoPtr_AppendInterval_Public_Static_Sequence_Sequence_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sequence>(intPtr3) : null;
		}

		// Token: 0x060001CE RID: 462 RVA: 0x0000F5D4 File Offset: 0x0000D7D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1131541, XrefRangeEnd = 1131545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Sequence PrependInterval(this Sequence s, float interval)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref interval;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenSettingsExtensions.NativeMethodInfoPtr_PrependInterval_Public_Static_Sequence_Sequence_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sequence>(intPtr3) : null;
		}

		// Token: 0x060001CF RID: 463 RVA: 0x0000F628 File Offset: 0x0000D828
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1131545, XrefRangeEnd = 1131546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Sequence AppendCallback(this Sequence s, TweenCallback callback)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenSettingsExtensions.NativeMethodInfoPtr_AppendCallback_Public_Static_Sequence_Sequence_TweenCallback_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sequence>(intPtr3) : null;
		}

		// Token: 0x060001D0 RID: 464 RVA: 0x0000F680 File Offset: 0x0000D880
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1131546, XrefRangeEnd = 1131547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Sequence PrependCallback(this Sequence s, TweenCallback callback)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenSettingsExtensions.NativeMethodInfoPtr_PrependCallback_Public_Static_Sequence_Sequence_TweenCallback_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sequence>(intPtr3) : null;
		}

		// Token: 0x060001D1 RID: 465 RVA: 0x0000F6D8 File Offset: 0x0000D8D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1131547, XrefRangeEnd = 1131548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Sequence InsertCallback(this Sequence s, float atPosition, TweenCallback callback)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref atPosition;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenSettingsExtensions.NativeMethodInfoPtr_InsertCallback_Public_Static_Sequence_Sequence_Single_TweenCallback_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sequence>(intPtr3) : null;
		}

		// Token: 0x060001D2 RID: 466 RVA: 0x0000F73C File Offset: 0x0000D93C
		[CallerCount(0)]
		public unsafe static T From<T>(this T t) where T : Tweener
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t2 = t;
					intPtr = ((t2 is string) ? IL2CPP.ManagedStringToIl2Cpp(t2 as string) : IL2CPP.Il2CppObjectBaseToPtr(t2 as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref t;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(TweenSettingsExtensions.MethodInfoStoreGeneric_From_Public_Static_T_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return IL2CPP.PointerToValueGeneric<T>(intPtr2, false, true);
			}
		}

		// Token: 0x060001D3 RID: 467 RVA: 0x0000F7B0 File Offset: 0x0000D9B0
		[CallerCount(0)]
		public unsafe static T From<T>(this T t, bool isRelative) where T : Tweener
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t2 = t;
					intPtr = ((t2 is string) ? IL2CPP.ManagedStringToIl2Cpp(t2 as string) : IL2CPP.Il2CppObjectBaseToPtr(t2 as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref t;
				}
				ptr2 = intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isRelative;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(TweenSettingsExtensions.MethodInfoStoreGeneric_From_Public_Static_T_T_Boolean_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return IL2CPP.PointerToValueGeneric<T>(intPtr2, false, true);
		}

		// Token: 0x060001D4 RID: 468 RVA: 0x0000F834 File Offset: 0x0000DA34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1131548, XrefRangeEnd = 1131549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T SetDelay<T>(this T t, float delay) where T : Tween
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t2 = t;
					intPtr = ((t2 is string) ? IL2CPP.ManagedStringToIl2Cpp(t2 as string) : IL2CPP.Il2CppObjectBaseToPtr(t2 as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref t;
				}
				ptr2 = intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref delay;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(TweenSettingsExtensions.MethodInfoStoreGeneric_SetDelay_Public_Static_T_T_Single_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return IL2CPP.PointerToValueGeneric<T>(intPtr2, false, true);
		}

		// Token: 0x060001D5 RID: 469 RVA: 0x0000F8B8 File Offset: 0x0000DAB8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1131549, RefRangeEnd = 1131552, XrefRangeStart = 1131549, XrefRangeEnd = 1131549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T SetRelative<T>(this T t) where T : Tween
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t2 = t;
					intPtr = ((t2 is string) ? IL2CPP.ManagedStringToIl2Cpp(t2 as string) : IL2CPP.Il2CppObjectBaseToPtr(t2 as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref t;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(TweenSettingsExtensions.MethodInfoStoreGeneric_SetRelative_Public_Static_T_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return IL2CPP.PointerToValueGeneric<T>(intPtr2, false, true);
			}
		}

		// Token: 0x060001D6 RID: 470 RVA: 0x0000F92C File Offset: 0x0000DB2C
		[CallerCount(0)]
		public unsafe static T SetRelative<T>(this T t, bool isRelative) where T : Tween
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t2 = t;
					intPtr = ((t2 is string) ? IL2CPP.ManagedStringToIl2Cpp(t2 as string) : IL2CPP.Il2CppObjectBaseToPtr(t2 as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref t;
				}
				ptr2 = intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isRelative;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(TweenSettingsExtensions.MethodInfoStoreGeneric_SetRelative_Public_Static_T_T_Boolean_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return IL2CPP.PointerToValueGeneric<T>(intPtr2, false, true);
		}

		// Token: 0x060001D7 RID: 471 RVA: 0x0000F9B0 File Offset: 0x0000DBB0
		[CallerCount(0)]
		public unsafe static T SetSpeedBased<T>(this T t) where T : Tween
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t2 = t;
					intPtr = ((t2 is string) ? IL2CPP.ManagedStringToIl2Cpp(t2 as string) : IL2CPP.Il2CppObjectBaseToPtr(t2 as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref t;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(TweenSettingsExtensions.MethodInfoStoreGeneric_SetSpeedBased_Public_Static_T_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return IL2CPP.PointerToValueGeneric<T>(intPtr2, false, true);
			}
		}

		// Token: 0x060001D8 RID: 472 RVA: 0x0000FA24 File Offset: 0x0000DC24
		[CallerCount(0)]
		public unsafe static T SetSpeedBased<T>(this T t, bool isSpeedBased) where T : Tween
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t2 = t;
					intPtr = ((t2 is string) ? IL2CPP.ManagedStringToIl2Cpp(t2 as string) : IL2CPP.Il2CppObjectBaseToPtr(t2 as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref t;
				}
				ptr2 = intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isSpeedBased;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(TweenSettingsExtensions.MethodInfoStoreGeneric_SetSpeedBased_Public_Static_T_T_Boolean_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return IL2CPP.PointerToValueGeneric<T>(intPtr2, false, true);
		}

		// Token: 0x060001D9 RID: 473 RVA: 0x0000FAA8 File Offset: 0x0000DCA8
		[CallerCount(0)]
		public unsafe static Tweener SetOptions(this TweenerCore<float, float, FloatOptions> t, bool snapping)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref snapping;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenSettingsExtensions.NativeMethodInfoPtr_SetOptions_Public_Static_Tweener_TweenerCore_3_Single_Single_FloatOptions_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Tweener>(intPtr3) : null;
		}

		// Token: 0x060001DA RID: 474 RVA: 0x0000FAFC File Offset: 0x0000DCFC
		[CallerCount(0)]
		public unsafe static Tweener SetOptions(this TweenerCore<Vector2, Vector2, VectorOptions> t, bool snapping)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref snapping;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenSettingsExtensions.NativeMethodInfoPtr_SetOptions_Public_Static_Tweener_TweenerCore_3_Vector2_Vector2_VectorOptions_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Tweener>(intPtr3) : null;
		}

		// Token: 0x060001DB RID: 475 RVA: 0x0000FB50 File Offset: 0x0000DD50
		[CallerCount(0)]
		public unsafe static Tweener SetOptions(this TweenerCore<Vector2, Vector2, VectorOptions> t, AxisConstraint axisConstraint, bool snapping = false)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref axisConstraint;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref snapping;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenSettingsExtensions.NativeMethodInfoPtr_SetOptions_Public_Static_Tweener_TweenerCore_3_Vector2_Vector2_VectorOptions_AxisConstraint_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Tweener>(intPtr3) : null;
		}

		// Token: 0x060001DC RID: 476 RVA: 0x0000FBB0 File Offset: 0x0000DDB0
		[CallerCount(0)]
		public unsafe static Tweener SetOptions(this TweenerCore<Vector3, Vector3, VectorOptions> t, bool snapping)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref snapping;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenSettingsExtensions.NativeMethodInfoPtr_SetOptions_Public_Static_Tweener_TweenerCore_3_Vector3_Vector3_VectorOptions_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Tweener>(intPtr3) : null;
		}

		// Token: 0x060001DD RID: 477 RVA: 0x0000FC04 File Offset: 0x0000DE04
		[CallerCount(0)]
		public unsafe static Tweener SetOptions(this TweenerCore<Vector3, Vector3, VectorOptions> t, AxisConstraint axisConstraint, bool snapping = false)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref axisConstraint;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref snapping;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenSettingsExtensions.NativeMethodInfoPtr_SetOptions_Public_Static_Tweener_TweenerCore_3_Vector3_Vector3_VectorOptions_AxisConstraint_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Tweener>(intPtr3) : null;
		}

		// Token: 0x060001DE RID: 478 RVA: 0x0000FC64 File Offset: 0x0000DE64
		[CallerCount(0)]
		public unsafe static Tweener SetOptions(this TweenerCore<Vector4, Vector4, VectorOptions> t, bool snapping)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref snapping;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenSettingsExtensions.NativeMethodInfoPtr_SetOptions_Public_Static_Tweener_TweenerCore_3_Vector4_Vector4_VectorOptions_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Tweener>(intPtr3) : null;
		}

		// Token: 0x060001DF RID: 479 RVA: 0x0000FCB8 File Offset: 0x0000DEB8
		[CallerCount(0)]
		public unsafe static Tweener SetOptions(this TweenerCore<Vector4, Vector4, VectorOptions> t, AxisConstraint axisConstraint, bool snapping = false)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref axisConstraint;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref snapping;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenSettingsExtensions.NativeMethodInfoPtr_SetOptions_Public_Static_Tweener_TweenerCore_3_Vector4_Vector4_VectorOptions_AxisConstraint_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Tweener>(intPtr3) : null;
		}

		// Token: 0x060001E0 RID: 480 RVA: 0x0000FD18 File Offset: 0x0000DF18
		[CallerCount(0)]
		public unsafe static Tweener SetOptions(this TweenerCore<Quaternion, Vector3, QuaternionOptions> t, bool useShortest360Route = true)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useShortest360Route;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenSettingsExtensions.NativeMethodInfoPtr_SetOptions_Public_Static_Tweener_TweenerCore_3_Quaternion_Vector3_QuaternionOptions_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Tweener>(intPtr3) : null;
		}

		// Token: 0x060001E1 RID: 481 RVA: 0x0000FD6C File Offset: 0x0000DF6C
		[CallerCount(0)]
		public unsafe static Tweener SetOptions(this TweenerCore<Color, Color, ColorOptions> t, bool alphaOnly)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref alphaOnly;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenSettingsExtensions.NativeMethodInfoPtr_SetOptions_Public_Static_Tweener_TweenerCore_3_Color_Color_ColorOptions_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Tweener>(intPtr3) : null;
		}

		// Token: 0x060001E2 RID: 482 RVA: 0x0000FDC0 File Offset: 0x0000DFC0
		[CallerCount(0)]
		public unsafe static Tweener SetOptions(this TweenerCore<Rect, Rect, RectOptions> t, bool snapping)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref snapping;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenSettingsExtensions.NativeMethodInfoPtr_SetOptions_Public_Static_Tweener_TweenerCore_3_Rect_Rect_RectOptions_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Tweener>(intPtr3) : null;
		}

		// Token: 0x060001E3 RID: 483 RVA: 0x0000FE14 File Offset: 0x0000E014
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1131552, XrefRangeEnd = 1131560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Tweener SetOptions(this TweenerCore<string, string, StringOptions> t, bool richTextEnabled, ScrambleMode scrambleMode = ScrambleMode.None, string scrambleChars = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref richTextEnabled;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref scrambleMode;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(scrambleChars);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenSettingsExtensions.NativeMethodInfoPtr_SetOptions_Public_Static_Tweener_TweenerCore_3_String_String_StringOptions_Boolean_ScrambleMode_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Tweener>(intPtr3) : null;
		}

		// Token: 0x060001E4 RID: 484 RVA: 0x0000FE88 File Offset: 0x0000E088
		[CallerCount(0)]
		public unsafe static Tweener SetOptions(this TweenerCore<Vector3, Il2CppStructArray<Vector3>, Vector3ArrayOptions> t, bool snapping)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref snapping;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenSettingsExtensions.NativeMethodInfoPtr_SetOptions_Public_Static_Tweener_TweenerCore_3_Vector3_Il2CppStructArray_1_Vector3_Vector3ArrayOptions_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Tweener>(intPtr3) : null;
		}

		// Token: 0x060001E5 RID: 485 RVA: 0x0000FEDC File Offset: 0x0000E0DC
		[CallerCount(0)]
		public unsafe static Tweener SetOptions(this TweenerCore<Vector3, Il2CppStructArray<Vector3>, Vector3ArrayOptions> t, AxisConstraint axisConstraint, bool snapping = false)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref axisConstraint;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref snapping;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenSettingsExtensions.NativeMethodInfoPtr_SetOptions_Public_Static_Tweener_TweenerCore_3_Vector3_Il2CppStructArray_1_Vector3_Vector3ArrayOptions_AxisConstraint_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Tweener>(intPtr3) : null;
		}

		// Token: 0x060001E6 RID: 486 RVA: 0x0000FF3C File Offset: 0x0000E13C
		[CallerCount(0)]
		public unsafe static TweenerCore<Vector3, Path, PathOptions> SetOptions(this TweenerCore<Vector3, Path, PathOptions> t, AxisConstraint lockPosition, AxisConstraint lockRotation = AxisConstraint.None)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lockPosition;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lockRotation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenSettingsExtensions.NativeMethodInfoPtr_SetOptions_Public_Static_TweenerCore_3_Vector3_Path_PathOptions_TweenerCore_3_Vector3_Path_PathOptions_AxisConstraint_AxisConstraint_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TweenerCore<Vector3, Path, PathOptions>>(intPtr3) : null;
		}

		// Token: 0x060001E7 RID: 487 RVA: 0x0000FF9C File Offset: 0x0000E19C
		[CallerCount(0)]
		public unsafe static TweenerCore<Vector3, Path, PathOptions> SetOptions(this TweenerCore<Vector3, Path, PathOptions> t, bool closePath, AxisConstraint lockPosition = AxisConstraint.None, AxisConstraint lockRotation = AxisConstraint.None)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref closePath;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lockPosition;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lockRotation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenSettingsExtensions.NativeMethodInfoPtr_SetOptions_Public_Static_TweenerCore_3_Vector3_Path_PathOptions_TweenerCore_3_Vector3_Path_PathOptions_Boolean_AxisConstraint_AxisConstraint_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TweenerCore<Vector3, Path, PathOptions>>(intPtr3) : null;
		}

		// Token: 0x060001E8 RID: 488 RVA: 0x0001000C File Offset: 0x0000E20C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1131560, XrefRangeEnd = 1131561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TweenerCore<Vector3, Path, PathOptions> SetLookAt(this TweenerCore<Vector3, Path, PathOptions> t, Vector3 lookAtPosition, Nullable<Vector3> forwardDirection = null, Nullable<Vector3> up = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lookAtPosition;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(forwardDirection));
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(up));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenSettingsExtensions.NativeMethodInfoPtr_SetLookAt_Public_Static_TweenerCore_3_Vector3_Path_PathOptions_TweenerCore_3_Vector3_Path_PathOptions_Vector3_Nullable_1_Vector3_Nullable_1_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TweenerCore<Vector3, Path, PathOptions>>(intPtr3) : null;
		}

		// Token: 0x060001E9 RID: 489 RVA: 0x0001008C File Offset: 0x0000E28C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1131561, XrefRangeEnd = 1131563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TweenerCore<Vector3, Path, PathOptions> SetLookAt(this TweenerCore<Vector3, Path, PathOptions> t, Transform lookAtTransform, Nullable<Vector3> forwardDirection = null, Nullable<Vector3> up = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(lookAtTransform);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(forwardDirection));
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(up));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenSettingsExtensions.NativeMethodInfoPtr_SetLookAt_Public_Static_TweenerCore_3_Vector3_Path_PathOptions_TweenerCore_3_Vector3_Path_PathOptions_Transform_Nullable_1_Vector3_Nullable_1_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TweenerCore<Vector3, Path, PathOptions>>(intPtr3) : null;
		}

		// Token: 0x060001EA RID: 490 RVA: 0x00010110 File Offset: 0x0000E310
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1131563, XrefRangeEnd = 1131564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TweenerCore<Vector3, Path, PathOptions> SetLookAt(this TweenerCore<Vector3, Path, PathOptions> t, float lookAhead, Nullable<Vector3> forwardDirection = null, Nullable<Vector3> up = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lookAhead;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(forwardDirection));
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(up));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenSettingsExtensions.NativeMethodInfoPtr_SetLookAt_Public_Static_TweenerCore_3_Vector3_Path_PathOptions_TweenerCore_3_Vector3_Path_PathOptions_Single_Nullable_1_Vector3_Nullable_1_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TweenerCore<Vector3, Path, PathOptions>>(intPtr3) : null;
		}

		// Token: 0x060001EB RID: 491 RVA: 0x00010190 File Offset: 0x0000E390
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1131591, RefRangeEnd = 1131594, XrefRangeStart = 1131564, XrefRangeEnd = 1131591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetPathForwardDirection(this TweenerCore<Vector3, Path, PathOptions> t, Nullable<Vector3> forwardDirection = null, Nullable<Vector3> up = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(forwardDirection));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(up));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenSettingsExtensions.NativeMethodInfoPtr_SetPathForwardDirection_Private_Static_Void_TweenerCore_3_Vector3_Path_PathOptions_Nullable_1_Vector3_Nullable_1_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001EC RID: 492 RVA: 0x00002600 File Offset: 0x00000800
		public TweenSettingsExtensions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040001A1 RID: 417
		private static readonly IntPtr NativeMethodInfoPtr_SetAutoKill_Public_Static_T_T_0;

		// Token: 0x040001A2 RID: 418
		private static readonly IntPtr NativeMethodInfoPtr_SetAutoKill_Public_Static_T_T_Boolean_0;

		// Token: 0x040001A3 RID: 419
		private static readonly IntPtr NativeMethodInfoPtr_SetId_Public_Static_T_T_Object_0;

		// Token: 0x040001A4 RID: 420
		private static readonly IntPtr NativeMethodInfoPtr_SetId_Public_Static_T_T_String_0;

		// Token: 0x040001A5 RID: 421
		private static readonly IntPtr NativeMethodInfoPtr_SetId_Public_Static_T_T_Int32_0;

		// Token: 0x040001A6 RID: 422
		private static readonly IntPtr NativeMethodInfoPtr_SetTarget_Public_Static_T_T_Object_0;

		// Token: 0x040001A7 RID: 423
		private static readonly IntPtr NativeMethodInfoPtr_SetLoops_Public_Static_T_T_Int32_0;

		// Token: 0x040001A8 RID: 424
		private static readonly IntPtr NativeMethodInfoPtr_SetLoops_Public_Static_T_T_Int32_LoopType_0;

		// Token: 0x040001A9 RID: 425
		private static readonly IntPtr NativeMethodInfoPtr_SetEase_Public_Static_T_T_Ease_0;

		// Token: 0x040001AA RID: 426
		private static readonly IntPtr NativeMethodInfoPtr_SetEase_Public_Static_T_T_Ease_Single_0;

		// Token: 0x040001AB RID: 427
		private static readonly IntPtr NativeMethodInfoPtr_SetEase_Public_Static_T_T_Ease_Single_Single_0;

		// Token: 0x040001AC RID: 428
		private static readonly IntPtr NativeMethodInfoPtr_SetEase_Public_Static_T_T_AnimationCurve_0;

		// Token: 0x040001AD RID: 429
		private static readonly IntPtr NativeMethodInfoPtr_SetEase_Public_Static_T_T_EaseFunction_0;

		// Token: 0x040001AE RID: 430
		private static readonly IntPtr NativeMethodInfoPtr_SetRecyclable_Public_Static_T_T_0;

		// Token: 0x040001AF RID: 431
		private static readonly IntPtr NativeMethodInfoPtr_SetRecyclable_Public_Static_T_T_Boolean_0;

		// Token: 0x040001B0 RID: 432
		private static readonly IntPtr NativeMethodInfoPtr_SetUpdate_Public_Static_T_T_Boolean_0;

		// Token: 0x040001B1 RID: 433
		private static readonly IntPtr NativeMethodInfoPtr_SetUpdate_Public_Static_T_T_UpdateType_0;

		// Token: 0x040001B2 RID: 434
		private static readonly IntPtr NativeMethodInfoPtr_SetUpdate_Public_Static_T_T_UpdateType_Boolean_0;

		// Token: 0x040001B3 RID: 435
		private static readonly IntPtr NativeMethodInfoPtr_OnStart_Public_Static_T_T_TweenCallback_0;

		// Token: 0x040001B4 RID: 436
		private static readonly IntPtr NativeMethodInfoPtr_OnPlay_Public_Static_T_T_TweenCallback_0;

		// Token: 0x040001B5 RID: 437
		private static readonly IntPtr NativeMethodInfoPtr_OnPause_Public_Static_T_T_TweenCallback_0;

		// Token: 0x040001B6 RID: 438
		private static readonly IntPtr NativeMethodInfoPtr_OnRewind_Public_Static_T_T_TweenCallback_0;

		// Token: 0x040001B7 RID: 439
		private static readonly IntPtr NativeMethodInfoPtr_OnUpdate_Public_Static_T_T_TweenCallback_0;

		// Token: 0x040001B8 RID: 440
		private static readonly IntPtr NativeMethodInfoPtr_OnStepComplete_Public_Static_T_T_TweenCallback_0;

		// Token: 0x040001B9 RID: 441
		private static readonly IntPtr NativeMethodInfoPtr_OnComplete_Public_Static_T_T_TweenCallback_0;

		// Token: 0x040001BA RID: 442
		private static readonly IntPtr NativeMethodInfoPtr_OnKill_Public_Static_T_T_TweenCallback_0;

		// Token: 0x040001BB RID: 443
		private static readonly IntPtr NativeMethodInfoPtr_OnWaypointChange_Public_Static_T_T_TweenCallback_1_Int32_0;

		// Token: 0x040001BC RID: 444
		private static readonly IntPtr NativeMethodInfoPtr_SetAs_Public_Static_T_T_Tween_0;

		// Token: 0x040001BD RID: 445
		private static readonly IntPtr NativeMethodInfoPtr_SetAs_Public_Static_T_T_TweenParams_0;

		// Token: 0x040001BE RID: 446
		private static readonly IntPtr NativeMethodInfoPtr_Append_Public_Static_Sequence_Sequence_Tween_0;

		// Token: 0x040001BF RID: 447
		private static readonly IntPtr NativeMethodInfoPtr_Prepend_Public_Static_Sequence_Sequence_Tween_0;

		// Token: 0x040001C0 RID: 448
		private static readonly IntPtr NativeMethodInfoPtr_Join_Public_Static_Sequence_Sequence_Tween_0;

		// Token: 0x040001C1 RID: 449
		private static readonly IntPtr NativeMethodInfoPtr_Insert_Public_Static_Sequence_Sequence_Single_Tween_0;

		// Token: 0x040001C2 RID: 450
		private static readonly IntPtr NativeMethodInfoPtr_AppendInterval_Public_Static_Sequence_Sequence_Single_0;

		// Token: 0x040001C3 RID: 451
		private static readonly IntPtr NativeMethodInfoPtr_PrependInterval_Public_Static_Sequence_Sequence_Single_0;

		// Token: 0x040001C4 RID: 452
		private static readonly IntPtr NativeMethodInfoPtr_AppendCallback_Public_Static_Sequence_Sequence_TweenCallback_0;

		// Token: 0x040001C5 RID: 453
		private static readonly IntPtr NativeMethodInfoPtr_PrependCallback_Public_Static_Sequence_Sequence_TweenCallback_0;

		// Token: 0x040001C6 RID: 454
		private static readonly IntPtr NativeMethodInfoPtr_InsertCallback_Public_Static_Sequence_Sequence_Single_TweenCallback_0;

		// Token: 0x040001C7 RID: 455
		private static readonly IntPtr NativeMethodInfoPtr_From_Public_Static_T_T_0;

		// Token: 0x040001C8 RID: 456
		private static readonly IntPtr NativeMethodInfoPtr_From_Public_Static_T_T_Boolean_0;

		// Token: 0x040001C9 RID: 457
		private static readonly IntPtr NativeMethodInfoPtr_SetDelay_Public_Static_T_T_Single_0;

		// Token: 0x040001CA RID: 458
		private static readonly IntPtr NativeMethodInfoPtr_SetRelative_Public_Static_T_T_0;

		// Token: 0x040001CB RID: 459
		private static readonly IntPtr NativeMethodInfoPtr_SetRelative_Public_Static_T_T_Boolean_0;

		// Token: 0x040001CC RID: 460
		private static readonly IntPtr NativeMethodInfoPtr_SetSpeedBased_Public_Static_T_T_0;

		// Token: 0x040001CD RID: 461
		private static readonly IntPtr NativeMethodInfoPtr_SetSpeedBased_Public_Static_T_T_Boolean_0;

		// Token: 0x040001CE RID: 462
		private static readonly IntPtr NativeMethodInfoPtr_SetOptions_Public_Static_Tweener_TweenerCore_3_Single_Single_FloatOptions_Boolean_0;

		// Token: 0x040001CF RID: 463
		private static readonly IntPtr NativeMethodInfoPtr_SetOptions_Public_Static_Tweener_TweenerCore_3_Vector2_Vector2_VectorOptions_Boolean_0;

		// Token: 0x040001D0 RID: 464
		private static readonly IntPtr NativeMethodInfoPtr_SetOptions_Public_Static_Tweener_TweenerCore_3_Vector2_Vector2_VectorOptions_AxisConstraint_Boolean_0;

		// Token: 0x040001D1 RID: 465
		private static readonly IntPtr NativeMethodInfoPtr_SetOptions_Public_Static_Tweener_TweenerCore_3_Vector3_Vector3_VectorOptions_Boolean_0;

		// Token: 0x040001D2 RID: 466
		private static readonly IntPtr NativeMethodInfoPtr_SetOptions_Public_Static_Tweener_TweenerCore_3_Vector3_Vector3_VectorOptions_AxisConstraint_Boolean_0;

		// Token: 0x040001D3 RID: 467
		private static readonly IntPtr NativeMethodInfoPtr_SetOptions_Public_Static_Tweener_TweenerCore_3_Vector4_Vector4_VectorOptions_Boolean_0;

		// Token: 0x040001D4 RID: 468
		private static readonly IntPtr NativeMethodInfoPtr_SetOptions_Public_Static_Tweener_TweenerCore_3_Vector4_Vector4_VectorOptions_AxisConstraint_Boolean_0;

		// Token: 0x040001D5 RID: 469
		private static readonly IntPtr NativeMethodInfoPtr_SetOptions_Public_Static_Tweener_TweenerCore_3_Quaternion_Vector3_QuaternionOptions_Boolean_0;

		// Token: 0x040001D6 RID: 470
		private static readonly IntPtr NativeMethodInfoPtr_SetOptions_Public_Static_Tweener_TweenerCore_3_Color_Color_ColorOptions_Boolean_0;

		// Token: 0x040001D7 RID: 471
		private static readonly IntPtr NativeMethodInfoPtr_SetOptions_Public_Static_Tweener_TweenerCore_3_Rect_Rect_RectOptions_Boolean_0;

		// Token: 0x040001D8 RID: 472
		private static readonly IntPtr NativeMethodInfoPtr_SetOptions_Public_Static_Tweener_TweenerCore_3_String_String_StringOptions_Boolean_ScrambleMode_String_0;

		// Token: 0x040001D9 RID: 473
		private static readonly IntPtr NativeMethodInfoPtr_SetOptions_Public_Static_Tweener_TweenerCore_3_Vector3_Il2CppStructArray_1_Vector3_Vector3ArrayOptions_Boolean_0;

		// Token: 0x040001DA RID: 474
		private static readonly IntPtr NativeMethodInfoPtr_SetOptions_Public_Static_Tweener_TweenerCore_3_Vector3_Il2CppStructArray_1_Vector3_Vector3ArrayOptions_AxisConstraint_Boolean_0;

		// Token: 0x040001DB RID: 475
		private static readonly IntPtr NativeMethodInfoPtr_SetOptions_Public_Static_TweenerCore_3_Vector3_Path_PathOptions_TweenerCore_3_Vector3_Path_PathOptions_AxisConstraint_AxisConstraint_0;

		// Token: 0x040001DC RID: 476
		private static readonly IntPtr NativeMethodInfoPtr_SetOptions_Public_Static_TweenerCore_3_Vector3_Path_PathOptions_TweenerCore_3_Vector3_Path_PathOptions_Boolean_AxisConstraint_AxisConstraint_0;

		// Token: 0x040001DD RID: 477
		private static readonly IntPtr NativeMethodInfoPtr_SetLookAt_Public_Static_TweenerCore_3_Vector3_Path_PathOptions_TweenerCore_3_Vector3_Path_PathOptions_Vector3_Nullable_1_Vector3_Nullable_1_Vector3_0;

		// Token: 0x040001DE RID: 478
		private static readonly IntPtr NativeMethodInfoPtr_SetLookAt_Public_Static_TweenerCore_3_Vector3_Path_PathOptions_TweenerCore_3_Vector3_Path_PathOptions_Transform_Nullable_1_Vector3_Nullable_1_Vector3_0;

		// Token: 0x040001DF RID: 479
		private static readonly IntPtr NativeMethodInfoPtr_SetLookAt_Public_Static_TweenerCore_3_Vector3_Path_PathOptions_TweenerCore_3_Vector3_Path_PathOptions_Single_Nullable_1_Vector3_Nullable_1_Vector3_0;

		// Token: 0x040001E0 RID: 480
		private static readonly IntPtr NativeMethodInfoPtr_SetPathForwardDirection_Private_Static_Void_TweenerCore_3_Vector3_Path_PathOptions_Nullable_1_Vector3_Nullable_1_Vector3_0;

		// Token: 0x020000B7 RID: 183
		private sealed class MethodInfoStoreGeneric_SetAutoKill_Public_Static_T_T_0<T>
		{
			// Token: 0x040005DA RID: 1498
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(TweenSettingsExtensions.NativeMethodInfoPtr_SetAutoKill_Public_Static_T_T_0, Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020000B8 RID: 184
		private sealed class MethodInfoStoreGeneric_SetAutoKill_Public_Static_T_T_Boolean_0<T>
		{
			// Token: 0x040005DB RID: 1499
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(TweenSettingsExtensions.NativeMethodInfoPtr_SetAutoKill_Public_Static_T_T_Boolean_0, Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020000B9 RID: 185
		private sealed class MethodInfoStoreGeneric_SetId_Public_Static_T_T_Object_0<T>
		{
			// Token: 0x040005DC RID: 1500
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(TweenSettingsExtensions.NativeMethodInfoPtr_SetId_Public_Static_T_T_Object_0, Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020000BA RID: 186
		private sealed class MethodInfoStoreGeneric_SetId_Public_Static_T_T_String_0<T>
		{
			// Token: 0x040005DD RID: 1501
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(TweenSettingsExtensions.NativeMethodInfoPtr_SetId_Public_Static_T_T_String_0, Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020000BB RID: 187
		private sealed class MethodInfoStoreGeneric_SetId_Public_Static_T_T_Int32_0<T>
		{
			// Token: 0x040005DE RID: 1502
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(TweenSettingsExtensions.NativeMethodInfoPtr_SetId_Public_Static_T_T_Int32_0, Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020000BC RID: 188
		private sealed class MethodInfoStoreGeneric_SetTarget_Public_Static_T_T_Object_0<T>
		{
			// Token: 0x040005DF RID: 1503
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(TweenSettingsExtensions.NativeMethodInfoPtr_SetTarget_Public_Static_T_T_Object_0, Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020000BD RID: 189
		private sealed class MethodInfoStoreGeneric_SetLoops_Public_Static_T_T_Int32_0<T>
		{
			// Token: 0x040005E0 RID: 1504
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(TweenSettingsExtensions.NativeMethodInfoPtr_SetLoops_Public_Static_T_T_Int32_0, Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020000BE RID: 190
		private sealed class MethodInfoStoreGeneric_SetLoops_Public_Static_T_T_Int32_LoopType_0<T>
		{
			// Token: 0x040005E1 RID: 1505
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(TweenSettingsExtensions.NativeMethodInfoPtr_SetLoops_Public_Static_T_T_Int32_LoopType_0, Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020000BF RID: 191
		private sealed class MethodInfoStoreGeneric_SetEase_Public_Static_T_T_Ease_0<T>
		{
			// Token: 0x040005E2 RID: 1506
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(TweenSettingsExtensions.NativeMethodInfoPtr_SetEase_Public_Static_T_T_Ease_0, Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020000C0 RID: 192
		private sealed class MethodInfoStoreGeneric_SetEase_Public_Static_T_T_Ease_Single_0<T>
		{
			// Token: 0x040005E3 RID: 1507
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(TweenSettingsExtensions.NativeMethodInfoPtr_SetEase_Public_Static_T_T_Ease_Single_0, Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020000C1 RID: 193
		private sealed class MethodInfoStoreGeneric_SetEase_Public_Static_T_T_Ease_Single_Single_0<T>
		{
			// Token: 0x040005E4 RID: 1508
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(TweenSettingsExtensions.NativeMethodInfoPtr_SetEase_Public_Static_T_T_Ease_Single_Single_0, Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020000C2 RID: 194
		private sealed class MethodInfoStoreGeneric_SetEase_Public_Static_T_T_AnimationCurve_0<T>
		{
			// Token: 0x040005E5 RID: 1509
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(TweenSettingsExtensions.NativeMethodInfoPtr_SetEase_Public_Static_T_T_AnimationCurve_0, Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020000C3 RID: 195
		private sealed class MethodInfoStoreGeneric_SetEase_Public_Static_T_T_EaseFunction_0<T>
		{
			// Token: 0x040005E6 RID: 1510
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(TweenSettingsExtensions.NativeMethodInfoPtr_SetEase_Public_Static_T_T_EaseFunction_0, Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020000C4 RID: 196
		private sealed class MethodInfoStoreGeneric_SetRecyclable_Public_Static_T_T_0<T>
		{
			// Token: 0x040005E7 RID: 1511
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(TweenSettingsExtensions.NativeMethodInfoPtr_SetRecyclable_Public_Static_T_T_0, Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020000C5 RID: 197
		private sealed class MethodInfoStoreGeneric_SetRecyclable_Public_Static_T_T_Boolean_0<T>
		{
			// Token: 0x040005E8 RID: 1512
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(TweenSettingsExtensions.NativeMethodInfoPtr_SetRecyclable_Public_Static_T_T_Boolean_0, Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020000C6 RID: 198
		private sealed class MethodInfoStoreGeneric_SetUpdate_Public_Static_T_T_Boolean_0<T>
		{
			// Token: 0x040005E9 RID: 1513
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(TweenSettingsExtensions.NativeMethodInfoPtr_SetUpdate_Public_Static_T_T_Boolean_0, Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020000C7 RID: 199
		private sealed class MethodInfoStoreGeneric_SetUpdate_Public_Static_T_T_UpdateType_0<T>
		{
			// Token: 0x040005EA RID: 1514
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(TweenSettingsExtensions.NativeMethodInfoPtr_SetUpdate_Public_Static_T_T_UpdateType_0, Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020000C8 RID: 200
		private sealed class MethodInfoStoreGeneric_SetUpdate_Public_Static_T_T_UpdateType_Boolean_0<T>
		{
			// Token: 0x040005EB RID: 1515
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(TweenSettingsExtensions.NativeMethodInfoPtr_SetUpdate_Public_Static_T_T_UpdateType_Boolean_0, Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020000C9 RID: 201
		private sealed class MethodInfoStoreGeneric_OnStart_Public_Static_T_T_TweenCallback_0<T>
		{
			// Token: 0x040005EC RID: 1516
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(TweenSettingsExtensions.NativeMethodInfoPtr_OnStart_Public_Static_T_T_TweenCallback_0, Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020000CA RID: 202
		private sealed class MethodInfoStoreGeneric_OnPlay_Public_Static_T_T_TweenCallback_0<T>
		{
			// Token: 0x040005ED RID: 1517
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(TweenSettingsExtensions.NativeMethodInfoPtr_OnPlay_Public_Static_T_T_TweenCallback_0, Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020000CB RID: 203
		private sealed class MethodInfoStoreGeneric_OnPause_Public_Static_T_T_TweenCallback_0<T>
		{
			// Token: 0x040005EE RID: 1518
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(TweenSettingsExtensions.NativeMethodInfoPtr_OnPause_Public_Static_T_T_TweenCallback_0, Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020000CC RID: 204
		private sealed class MethodInfoStoreGeneric_OnRewind_Public_Static_T_T_TweenCallback_0<T>
		{
			// Token: 0x040005EF RID: 1519
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(TweenSettingsExtensions.NativeMethodInfoPtr_OnRewind_Public_Static_T_T_TweenCallback_0, Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020000CD RID: 205
		private sealed class MethodInfoStoreGeneric_OnUpdate_Public_Static_T_T_TweenCallback_0<T>
		{
			// Token: 0x040005F0 RID: 1520
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(TweenSettingsExtensions.NativeMethodInfoPtr_OnUpdate_Public_Static_T_T_TweenCallback_0, Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020000CE RID: 206
		private sealed class MethodInfoStoreGeneric_OnStepComplete_Public_Static_T_T_TweenCallback_0<T>
		{
			// Token: 0x040005F1 RID: 1521
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(TweenSettingsExtensions.NativeMethodInfoPtr_OnStepComplete_Public_Static_T_T_TweenCallback_0, Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020000CF RID: 207
		private sealed class MethodInfoStoreGeneric_OnComplete_Public_Static_T_T_TweenCallback_0<T>
		{
			// Token: 0x040005F2 RID: 1522
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(TweenSettingsExtensions.NativeMethodInfoPtr_OnComplete_Public_Static_T_T_TweenCallback_0, Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020000D0 RID: 208
		private sealed class MethodInfoStoreGeneric_OnKill_Public_Static_T_T_TweenCallback_0<T>
		{
			// Token: 0x040005F3 RID: 1523
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(TweenSettingsExtensions.NativeMethodInfoPtr_OnKill_Public_Static_T_T_TweenCallback_0, Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020000D1 RID: 209
		private sealed class MethodInfoStoreGeneric_OnWaypointChange_Public_Static_T_T_TweenCallback_1_Int32_0<T>
		{
			// Token: 0x040005F4 RID: 1524
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(TweenSettingsExtensions.NativeMethodInfoPtr_OnWaypointChange_Public_Static_T_T_TweenCallback_1_Int32_0, Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020000D2 RID: 210
		private sealed class MethodInfoStoreGeneric_SetAs_Public_Static_T_T_Tween_0<T>
		{
			// Token: 0x040005F5 RID: 1525
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(TweenSettingsExtensions.NativeMethodInfoPtr_SetAs_Public_Static_T_T_Tween_0, Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020000D3 RID: 211
		private sealed class MethodInfoStoreGeneric_SetAs_Public_Static_T_T_TweenParams_0<T>
		{
			// Token: 0x040005F6 RID: 1526
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(TweenSettingsExtensions.NativeMethodInfoPtr_SetAs_Public_Static_T_T_TweenParams_0, Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020000D4 RID: 212
		private sealed class MethodInfoStoreGeneric_From_Public_Static_T_T_0<T>
		{
			// Token: 0x040005F7 RID: 1527
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(TweenSettingsExtensions.NativeMethodInfoPtr_From_Public_Static_T_T_0, Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020000D5 RID: 213
		private sealed class MethodInfoStoreGeneric_From_Public_Static_T_T_Boolean_0<T>
		{
			// Token: 0x040005F8 RID: 1528
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(TweenSettingsExtensions.NativeMethodInfoPtr_From_Public_Static_T_T_Boolean_0, Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020000D6 RID: 214
		private sealed class MethodInfoStoreGeneric_SetDelay_Public_Static_T_T_Single_0<T>
		{
			// Token: 0x040005F9 RID: 1529
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(TweenSettingsExtensions.NativeMethodInfoPtr_SetDelay_Public_Static_T_T_Single_0, Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020000D7 RID: 215
		private sealed class MethodInfoStoreGeneric_SetRelative_Public_Static_T_T_0<T>
		{
			// Token: 0x040005FA RID: 1530
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(TweenSettingsExtensions.NativeMethodInfoPtr_SetRelative_Public_Static_T_T_0, Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020000D8 RID: 216
		private sealed class MethodInfoStoreGeneric_SetRelative_Public_Static_T_T_Boolean_0<T>
		{
			// Token: 0x040005FB RID: 1531
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(TweenSettingsExtensions.NativeMethodInfoPtr_SetRelative_Public_Static_T_T_Boolean_0, Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020000D9 RID: 217
		private sealed class MethodInfoStoreGeneric_SetSpeedBased_Public_Static_T_T_0<T>
		{
			// Token: 0x040005FC RID: 1532
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(TweenSettingsExtensions.NativeMethodInfoPtr_SetSpeedBased_Public_Static_T_T_0, Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020000DA RID: 218
		private sealed class MethodInfoStoreGeneric_SetSpeedBased_Public_Static_T_T_Boolean_0<T>
		{
			// Token: 0x040005FD RID: 1533
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(TweenSettingsExtensions.NativeMethodInfoPtr_SetSpeedBased_Public_Static_T_T_Boolean_0, Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
