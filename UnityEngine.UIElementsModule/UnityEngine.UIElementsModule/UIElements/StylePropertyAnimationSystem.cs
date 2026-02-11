using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using UnityEngine.Pool;
using UnityEngine.UIElements.StyleSheets;

namespace UnityEngine.UIElements
{
	// Token: 0x020001BF RID: 447
	public class StylePropertyAnimationSystem : Object
	{
		// Token: 0x06002306 RID: 8966 RVA: 0x0009E278 File Offset: 0x0009C478
		// Note: this type is marked as 'beforefieldinit'.
		static StylePropertyAnimationSystem()
		{
			Il2CppClassPointerStore<StylePropertyAnimationSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "StylePropertyAnimationSystem");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StylePropertyAnimationSystem>.NativeClassPtr);
			StylePropertyAnimationSystem.NativeFieldInfoPtr_m_CurrentTimeMs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StylePropertyAnimationSystem>.NativeClassPtr, "m_CurrentTimeMs");
			StylePropertyAnimationSystem.NativeFieldInfoPtr_m_Floats = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StylePropertyAnimationSystem>.NativeClassPtr, "m_Floats");
			StylePropertyAnimationSystem.NativeFieldInfoPtr_m_Ints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StylePropertyAnimationSystem>.NativeClassPtr, "m_Ints");
			StylePropertyAnimationSystem.NativeFieldInfoPtr_m_Lengths = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StylePropertyAnimationSystem>.NativeClassPtr, "m_Lengths");
			StylePropertyAnimationSystem.NativeFieldInfoPtr_m_Colors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StylePropertyAnimationSystem>.NativeClassPtr, "m_Colors");
			StylePropertyAnimationSystem.NativeFieldInfoPtr_m_Backgrounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StylePropertyAnimationSystem>.NativeClassPtr, "m_Backgrounds");
			StylePropertyAnimationSystem.NativeFieldInfoPtr_m_FontDefinitions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StylePropertyAnimationSystem>.NativeClassPtr, "m_FontDefinitions");
			StylePropertyAnimationSystem.NativeFieldInfoPtr_m_Fonts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StylePropertyAnimationSystem>.NativeClassPtr, "m_Fonts");
			StylePropertyAnimationSystem.NativeFieldInfoPtr_m_TextShadows = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StylePropertyAnimationSystem>.NativeClassPtr, "m_TextShadows");
			StylePropertyAnimationSystem.NativeFieldInfoPtr_m_Scale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StylePropertyAnimationSystem>.NativeClassPtr, "m_Scale");
			StylePropertyAnimationSystem.NativeFieldInfoPtr_m_Rotate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StylePropertyAnimationSystem>.NativeClassPtr, "m_Rotate");
			StylePropertyAnimationSystem.NativeFieldInfoPtr_m_Translate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StylePropertyAnimationSystem>.NativeClassPtr, "m_Translate");
			StylePropertyAnimationSystem.NativeFieldInfoPtr_m_TransformOrigin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StylePropertyAnimationSystem>.NativeClassPtr, "m_TransformOrigin");
			StylePropertyAnimationSystem.NativeFieldInfoPtr_m_BackgroundPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StylePropertyAnimationSystem>.NativeClassPtr, "m_BackgroundPosition");
			StylePropertyAnimationSystem.NativeFieldInfoPtr_m_BackgroundRepeat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StylePropertyAnimationSystem>.NativeClassPtr, "m_BackgroundRepeat");
			StylePropertyAnimationSystem.NativeFieldInfoPtr_m_BackgroundSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StylePropertyAnimationSystem>.NativeClassPtr, "m_BackgroundSize");
			StylePropertyAnimationSystem.NativeFieldInfoPtr_m_AllValues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StylePropertyAnimationSystem>.NativeClassPtr, "m_AllValues");
			StylePropertyAnimationSystem.NativeFieldInfoPtr_m_PropertyToValues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StylePropertyAnimationSystem>.NativeClassPtr, "m_PropertyToValues");
			StylePropertyAnimationSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyAnimationSystem>.NativeClassPtr, 100668500);
			StylePropertyAnimationSystem.NativeMethodInfoPtr_GetOrCreate_Private_T_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyAnimationSystem>.NativeClassPtr, 100668501);
			StylePropertyAnimationSystem.NativeMethodInfoPtr_StartTransition_Private_Boolean_VisualElement_StylePropertyId_T_T_Int32_Int32_Func_2_Single_Single_Values_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyAnimationSystem>.NativeClassPtr, 100668502);
			StylePropertyAnimationSystem.NativeMethodInfoPtr_StartTransition_Public_Virtual_Final_New_Boolean_VisualElement_StylePropertyId_Single_Single_Int32_Int32_Func_2_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyAnimationSystem>.NativeClassPtr, 100668503);
			StylePropertyAnimationSystem.NativeMethodInfoPtr_StartTransition_Public_Virtual_Final_New_Boolean_VisualElement_StylePropertyId_Int32_Int32_Int32_Int32_Func_2_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyAnimationSystem>.NativeClassPtr, 100668504);
			StylePropertyAnimationSystem.NativeMethodInfoPtr_StartTransition_Public_Virtual_Final_New_Boolean_VisualElement_StylePropertyId_Length_Length_Int32_Int32_Func_2_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyAnimationSystem>.NativeClassPtr, 100668505);
			StylePropertyAnimationSystem.NativeMethodInfoPtr_StartTransition_Public_Virtual_Final_New_Boolean_VisualElement_StylePropertyId_Color_Color_Int32_Int32_Func_2_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyAnimationSystem>.NativeClassPtr, 100668506);
			StylePropertyAnimationSystem.NativeMethodInfoPtr_StartTransition_Public_Virtual_Final_New_Boolean_VisualElement_StylePropertyId_Background_Background_Int32_Int32_Func_2_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyAnimationSystem>.NativeClassPtr, 100668507);
			StylePropertyAnimationSystem.NativeMethodInfoPtr_StartTransition_Public_Virtual_Final_New_Boolean_VisualElement_StylePropertyId_FontDefinition_FontDefinition_Int32_Int32_Func_2_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyAnimationSystem>.NativeClassPtr, 100668508);
			StylePropertyAnimationSystem.NativeMethodInfoPtr_StartTransition_Public_Virtual_Final_New_Boolean_VisualElement_StylePropertyId_Font_Font_Int32_Int32_Func_2_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyAnimationSystem>.NativeClassPtr, 100668509);
			StylePropertyAnimationSystem.NativeMethodInfoPtr_StartTransition_Public_Virtual_Final_New_Boolean_VisualElement_StylePropertyId_TextShadow_TextShadow_Int32_Int32_Func_2_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyAnimationSystem>.NativeClassPtr, 100668510);
			StylePropertyAnimationSystem.NativeMethodInfoPtr_StartTransition_Public_Virtual_Final_New_Boolean_VisualElement_StylePropertyId_Scale_Scale_Int32_Int32_Func_2_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyAnimationSystem>.NativeClassPtr, 100668511);
			StylePropertyAnimationSystem.NativeMethodInfoPtr_StartTransition_Public_Virtual_Final_New_Boolean_VisualElement_StylePropertyId_Rotate_Rotate_Int32_Int32_Func_2_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyAnimationSystem>.NativeClassPtr, 100668512);
			StylePropertyAnimationSystem.NativeMethodInfoPtr_StartTransition_Public_Virtual_Final_New_Boolean_VisualElement_StylePropertyId_Translate_Translate_Int32_Int32_Func_2_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyAnimationSystem>.NativeClassPtr, 100668513);
			StylePropertyAnimationSystem.NativeMethodInfoPtr_StartTransition_Public_Virtual_Final_New_Boolean_VisualElement_StylePropertyId_TransformOrigin_TransformOrigin_Int32_Int32_Func_2_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyAnimationSystem>.NativeClassPtr, 100668514);
			StylePropertyAnimationSystem.NativeMethodInfoPtr_StartTransition_Public_Virtual_Final_New_Boolean_VisualElement_StylePropertyId_BackgroundPosition_BackgroundPosition_Int32_Int32_Func_2_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyAnimationSystem>.NativeClassPtr, 100668515);
			StylePropertyAnimationSystem.NativeMethodInfoPtr_StartTransition_Public_Virtual_Final_New_Boolean_VisualElement_StylePropertyId_BackgroundRepeat_BackgroundRepeat_Int32_Int32_Func_2_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyAnimationSystem>.NativeClassPtr, 100668516);
			StylePropertyAnimationSystem.NativeMethodInfoPtr_StartTransition_Public_Virtual_Final_New_Boolean_VisualElement_StylePropertyId_BackgroundSize_BackgroundSize_Int32_Int32_Func_2_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyAnimationSystem>.NativeClassPtr, 100668517);
			StylePropertyAnimationSystem.NativeMethodInfoPtr_CancelAllAnimations_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyAnimationSystem>.NativeClassPtr, 100668518);
			StylePropertyAnimationSystem.NativeMethodInfoPtr_CancelAllAnimations_Public_Virtual_Final_New_Void_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyAnimationSystem>.NativeClassPtr, 100668519);
			StylePropertyAnimationSystem.NativeMethodInfoPtr_CancelAnimation_Public_Virtual_Final_New_Void_VisualElement_StylePropertyId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyAnimationSystem>.NativeClassPtr, 100668520);
			StylePropertyAnimationSystem.NativeMethodInfoPtr_UpdateAnimation_Public_Virtual_Final_New_Void_VisualElement_StylePropertyId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyAnimationSystem>.NativeClassPtr, 100668521);
			StylePropertyAnimationSystem.NativeMethodInfoPtr_GetAllAnimations_Public_Virtual_Final_New_Void_VisualElement_List_1_StylePropertyId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyAnimationSystem>.NativeClassPtr, 100668522);
			StylePropertyAnimationSystem.NativeMethodInfoPtr_UpdateTracking_Private_Void_Values_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyAnimationSystem>.NativeClassPtr, 100668523);
			StylePropertyAnimationSystem.NativeMethodInfoPtr_CurrentTimeMs_Private_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyAnimationSystem>.NativeClassPtr, 100668524);
			StylePropertyAnimationSystem.NativeMethodInfoPtr_Update_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyAnimationSystem>.NativeClassPtr, 100668525);
		}

		// Token: 0x06002307 RID: 8967 RVA: 0x0009E618 File Offset: 0x0009C818
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 337164, RefRangeEnd = 337165, XrefRangeStart = 337145, XrefRangeEnd = 337164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StylePropertyAnimationSystem()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StylePropertyAnimationSystem>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyAnimationSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002308 RID: 8968 RVA: 0x0009E654 File Offset: 0x0009C854
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 337168, RefRangeEnd = 337183, XrefRangeStart = 337165, XrefRangeEnd = 337168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T GetOrCreate<T>(ref T values) where T : new()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(values);
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(StylePropertyAnimationSystem.MethodInfoStoreGeneric_GetOrCreate_Private_T_byref_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				values = ((intPtr4 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr4, false, false));
				return IL2CPP.PointerToValueGeneric<T>(intPtr2, false, true);
			}
		}

		// Token: 0x06002309 RID: 8969 RVA: 0x0009E6B8 File Offset: 0x0009C8B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 337197, RefRangeEnd = 337198, XrefRangeStart = 337183, XrefRangeEnd = 337197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool StartTransition<T>(VisualElement owner, UnityEngine.UIElements.StyleSheets.StylePropertyId prop, T startValue, T endValue, int durationMs, int delayMs, Func<float, float> easingCurve, StylePropertyAnimationSystem.Values<T> values)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(owner);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref prop;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			if (!typeof(T).IsValueType)
			{
				T t = startValue;
				intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref startValue;
			}
			ptr2 = intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2;
			if (!typeof(T).IsValueType)
			{
				T t2 = endValue;
				intPtr2 = ((t2 is string) ? IL2CPP.ManagedStringToIl2Cpp(t2 as string) : IL2CPP.Il2CppObjectBaseToPtr(t2 as Il2CppObjectBase));
			}
			else
			{
				intPtr2 = ref endValue;
			}
			ptr3 = intPtr2;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref durationMs;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref delayMs;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(easingCurve);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(values);
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(StylePropertyAnimationSystem.MethodInfoStoreGeneric_StartTransition_Private_Boolean_VisualElement_StylePropertyId_T_T_Int32_Int32_Func_2_Single_Single_Values_1_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			return *IL2CPP.il2cpp_object_unbox(intPtr3);
		}

		// Token: 0x0600230A RID: 8970 RVA: 0x0009E7E8 File Offset: 0x0009C9E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337198, XrefRangeEnd = 337204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool StartTransition(VisualElement owner, UnityEngine.UIElements.StyleSheets.StylePropertyId prop, float startValue, float endValue, int durationMs, int delayMs, Func<float, float> easingCurve)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(owner);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref prop;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startValue;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endValue;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref durationMs;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref delayMs;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(easingCurve);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyAnimationSystem.NativeMethodInfoPtr_StartTransition_Public_Virtual_Final_New_Boolean_VisualElement_StylePropertyId_Single_Single_Int32_Int32_Func_2_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600230B RID: 8971 RVA: 0x0009E890 File Offset: 0x0009CA90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337204, XrefRangeEnd = 337210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool StartTransition(VisualElement owner, UnityEngine.UIElements.StyleSheets.StylePropertyId prop, int startValue, int endValue, int durationMs, int delayMs, Func<float, float> easingCurve)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(owner);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref prop;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startValue;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endValue;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref durationMs;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref delayMs;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(easingCurve);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyAnimationSystem.NativeMethodInfoPtr_StartTransition_Public_Virtual_Final_New_Boolean_VisualElement_StylePropertyId_Int32_Int32_Int32_Int32_Func_2_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600230C RID: 8972 RVA: 0x0009E938 File Offset: 0x0009CB38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337210, XrefRangeEnd = 337216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool StartTransition(VisualElement owner, UnityEngine.UIElements.StyleSheets.StylePropertyId prop, Length startValue, Length endValue, int durationMs, int delayMs, Func<float, float> easingCurve)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(owner);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref prop;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startValue;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endValue;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref durationMs;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref delayMs;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(easingCurve);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyAnimationSystem.NativeMethodInfoPtr_StartTransition_Public_Virtual_Final_New_Boolean_VisualElement_StylePropertyId_Length_Length_Int32_Int32_Func_2_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600230D RID: 8973 RVA: 0x0009E9E0 File Offset: 0x0009CBE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337216, XrefRangeEnd = 337222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool StartTransition(VisualElement owner, UnityEngine.UIElements.StyleSheets.StylePropertyId prop, Color startValue, Color endValue, int durationMs, int delayMs, Func<float, float> easingCurve)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(owner);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref prop;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startValue;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endValue;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref durationMs;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref delayMs;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(easingCurve);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyAnimationSystem.NativeMethodInfoPtr_StartTransition_Public_Virtual_Final_New_Boolean_VisualElement_StylePropertyId_Color_Color_Int32_Int32_Func_2_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600230E RID: 8974 RVA: 0x0009EA88 File Offset: 0x0009CC88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337222, XrefRangeEnd = 337228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool StartTransition(VisualElement owner, UnityEngine.UIElements.StyleSheets.StylePropertyId prop, Background startValue, Background endValue, int durationMs, int delayMs, Func<float, float> easingCurve)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(owner);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref prop;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(startValue));
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(endValue));
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref durationMs;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref delayMs;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(easingCurve);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyAnimationSystem.NativeMethodInfoPtr_StartTransition_Public_Virtual_Final_New_Boolean_VisualElement_StylePropertyId_Background_Background_Int32_Int32_Func_2_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600230F RID: 8975 RVA: 0x0009EB44 File Offset: 0x0009CD44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337228, XrefRangeEnd = 337234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool StartTransition(VisualElement owner, UnityEngine.UIElements.StyleSheets.StylePropertyId prop, FontDefinition startValue, FontDefinition endValue, int durationMs, int delayMs, Func<float, float> easingCurve)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(owner);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref prop;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(startValue));
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(endValue));
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref durationMs;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref delayMs;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(easingCurve);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyAnimationSystem.NativeMethodInfoPtr_StartTransition_Public_Virtual_Final_New_Boolean_VisualElement_StylePropertyId_FontDefinition_FontDefinition_Int32_Int32_Func_2_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002310 RID: 8976 RVA: 0x0009EC00 File Offset: 0x0009CE00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337234, XrefRangeEnd = 337240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool StartTransition(VisualElement owner, UnityEngine.UIElements.StyleSheets.StylePropertyId prop, Font startValue, Font endValue, int durationMs, int delayMs, Func<float, float> easingCurve)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(owner);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref prop;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(startValue);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(endValue);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref durationMs;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref delayMs;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(easingCurve);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyAnimationSystem.NativeMethodInfoPtr_StartTransition_Public_Virtual_Final_New_Boolean_VisualElement_StylePropertyId_Font_Font_Int32_Int32_Func_2_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002311 RID: 8977 RVA: 0x0009ECB0 File Offset: 0x0009CEB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337240, XrefRangeEnd = 337246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool StartTransition(VisualElement owner, UnityEngine.UIElements.StyleSheets.StylePropertyId prop, TextShadow startValue, TextShadow endValue, int durationMs, int delayMs, Func<float, float> easingCurve)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(owner);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref prop;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startValue;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endValue;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref durationMs;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref delayMs;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(easingCurve);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyAnimationSystem.NativeMethodInfoPtr_StartTransition_Public_Virtual_Final_New_Boolean_VisualElement_StylePropertyId_TextShadow_TextShadow_Int32_Int32_Func_2_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002312 RID: 8978 RVA: 0x0009ED58 File Offset: 0x0009CF58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337246, XrefRangeEnd = 337252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool StartTransition(VisualElement owner, UnityEngine.UIElements.StyleSheets.StylePropertyId prop, Scale startValue, Scale endValue, int durationMs, int delayMs, Func<float, float> easingCurve)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(owner);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref prop;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startValue;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endValue;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref durationMs;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref delayMs;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(easingCurve);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyAnimationSystem.NativeMethodInfoPtr_StartTransition_Public_Virtual_Final_New_Boolean_VisualElement_StylePropertyId_Scale_Scale_Int32_Int32_Func_2_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002313 RID: 8979 RVA: 0x0009EE00 File Offset: 0x0009D000
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337252, XrefRangeEnd = 337258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool StartTransition(VisualElement owner, UnityEngine.UIElements.StyleSheets.StylePropertyId prop, Rotate startValue, Rotate endValue, int durationMs, int delayMs, Func<float, float> easingCurve)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(owner);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref prop;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startValue;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endValue;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref durationMs;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref delayMs;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(easingCurve);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyAnimationSystem.NativeMethodInfoPtr_StartTransition_Public_Virtual_Final_New_Boolean_VisualElement_StylePropertyId_Rotate_Rotate_Int32_Int32_Func_2_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002314 RID: 8980 RVA: 0x0009EEA8 File Offset: 0x0009D0A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337258, XrefRangeEnd = 337264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool StartTransition(VisualElement owner, UnityEngine.UIElements.StyleSheets.StylePropertyId prop, Translate startValue, Translate endValue, int durationMs, int delayMs, Func<float, float> easingCurve)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(owner);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref prop;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startValue;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endValue;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref durationMs;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref delayMs;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(easingCurve);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyAnimationSystem.NativeMethodInfoPtr_StartTransition_Public_Virtual_Final_New_Boolean_VisualElement_StylePropertyId_Translate_Translate_Int32_Int32_Func_2_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002315 RID: 8981 RVA: 0x0009EF50 File Offset: 0x0009D150
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337264, XrefRangeEnd = 337270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool StartTransition(VisualElement owner, UnityEngine.UIElements.StyleSheets.StylePropertyId prop, TransformOrigin startValue, TransformOrigin endValue, int durationMs, int delayMs, Func<float, float> easingCurve)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(owner);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref prop;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startValue;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endValue;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref durationMs;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref delayMs;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(easingCurve);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyAnimationSystem.NativeMethodInfoPtr_StartTransition_Public_Virtual_Final_New_Boolean_VisualElement_StylePropertyId_TransformOrigin_TransformOrigin_Int32_Int32_Func_2_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002316 RID: 8982 RVA: 0x0009EFF8 File Offset: 0x0009D1F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337270, XrefRangeEnd = 337276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool StartTransition(VisualElement owner, UnityEngine.UIElements.StyleSheets.StylePropertyId prop, BackgroundPosition startValue, BackgroundPosition endValue, int durationMs, int delayMs, Func<float, float> easingCurve)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(owner);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref prop;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startValue;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endValue;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref durationMs;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref delayMs;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(easingCurve);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyAnimationSystem.NativeMethodInfoPtr_StartTransition_Public_Virtual_Final_New_Boolean_VisualElement_StylePropertyId_BackgroundPosition_BackgroundPosition_Int32_Int32_Func_2_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002317 RID: 8983 RVA: 0x0009F0A0 File Offset: 0x0009D2A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337276, XrefRangeEnd = 337282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool StartTransition(VisualElement owner, UnityEngine.UIElements.StyleSheets.StylePropertyId prop, BackgroundRepeat startValue, BackgroundRepeat endValue, int durationMs, int delayMs, Func<float, float> easingCurve)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(owner);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref prop;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startValue;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endValue;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref durationMs;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref delayMs;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(easingCurve);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyAnimationSystem.NativeMethodInfoPtr_StartTransition_Public_Virtual_Final_New_Boolean_VisualElement_StylePropertyId_BackgroundRepeat_BackgroundRepeat_Int32_Int32_Func_2_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002318 RID: 8984 RVA: 0x0009F148 File Offset: 0x0009D348
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337282, XrefRangeEnd = 337288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool StartTransition(VisualElement owner, UnityEngine.UIElements.StyleSheets.StylePropertyId prop, BackgroundSize startValue, BackgroundSize endValue, int durationMs, int delayMs, Func<float, float> easingCurve)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(owner);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref prop;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startValue;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endValue;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref durationMs;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref delayMs;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(easingCurve);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyAnimationSystem.NativeMethodInfoPtr_StartTransition_Public_Virtual_Final_New_Boolean_VisualElement_StylePropertyId_BackgroundSize_BackgroundSize_Int32_Int32_Func_2_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002319 RID: 8985 RVA: 0x0009F1F0 File Offset: 0x0009D3F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337288, XrefRangeEnd = 337302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CancelAllAnimations()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyAnimationSystem.NativeMethodInfoPtr_CancelAllAnimations_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600231A RID: 8986 RVA: 0x0009F224 File Offset: 0x0009D424
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337302, XrefRangeEnd = 337328, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CancelAllAnimations(VisualElement owner)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(owner);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyAnimationSystem.NativeMethodInfoPtr_CancelAllAnimations_Public_Virtual_Final_New_Void_VisualElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600231B RID: 8987 RVA: 0x0009F268 File Offset: 0x0009D468
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337328, XrefRangeEnd = 337331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CancelAnimation(VisualElement owner, UnityEngine.UIElements.StyleSheets.StylePropertyId id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(owner);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref id;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyAnimationSystem.NativeMethodInfoPtr_CancelAnimation_Public_Virtual_Final_New_Void_VisualElement_StylePropertyId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600231C RID: 8988 RVA: 0x0009F2B8 File Offset: 0x0009D4B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337331, XrefRangeEnd = 337334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UpdateAnimation(VisualElement owner, UnityEngine.UIElements.StyleSheets.StylePropertyId id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(owner);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref id;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyAnimationSystem.NativeMethodInfoPtr_UpdateAnimation_Public_Virtual_Final_New_Void_VisualElement_StylePropertyId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600231D RID: 8989 RVA: 0x0009F308 File Offset: 0x0009D508
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337334, XrefRangeEnd = 337348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void GetAllAnimations(VisualElement owner, List<UnityEngine.UIElements.StyleSheets.StylePropertyId> propertyIds)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(owner);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(propertyIds);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyAnimationSystem.NativeMethodInfoPtr_GetAllAnimations_Public_Virtual_Final_New_Void_VisualElement_List_1_StylePropertyId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600231E RID: 8990 RVA: 0x0009F35C File Offset: 0x0009D55C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337348, XrefRangeEnd = 337356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateTracking<T>(StylePropertyAnimationSystem.Values<T> values)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(values);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyAnimationSystem.MethodInfoStoreGeneric_UpdateTracking_Private_Void_Values_1_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600231F RID: 8991 RVA: 0x0009F3A0 File Offset: 0x0009D5A0
		[CallerCount(169)]
		[CachedScanResults(RefRangeStart = 282426, RefRangeEnd = 282595, XrefRangeStart = 282426, XrefRangeEnd = 282595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe long CurrentTimeMs()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyAnimationSystem.NativeMethodInfoPtr_CurrentTimeMs_Private_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002320 RID: 8992 RVA: 0x0009F3DC File Offset: 0x0009D5DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337356, XrefRangeEnd = 337364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyAnimationSystem.NativeMethodInfoPtr_Update_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002321 RID: 8993 RVA: 0x0000E511 File Offset: 0x0000C711
		public StylePropertyAnimationSystem(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000B04 RID: 2820
		// (get) Token: 0x06002322 RID: 8994 RVA: 0x0009F410 File Offset: 0x0009D610
		// (set) Token: 0x06002323 RID: 8995 RVA: 0x0000E51A File Offset: 0x0000C71A
		public unsafe long m_CurrentTimeMs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StylePropertyAnimationSystem.NativeFieldInfoPtr_m_CurrentTimeMs);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StylePropertyAnimationSystem.NativeFieldInfoPtr_m_CurrentTimeMs)) = value;
			}
		}

		// Token: 0x17000B05 RID: 2821
		// (get) Token: 0x06002324 RID: 8996 RVA: 0x0009F438 File Offset: 0x0009D638
		// (set) Token: 0x06002325 RID: 8997 RVA: 0x0000E535 File Offset: 0x0000C735
		public unsafe StylePropertyAnimationSystem.ValuesFloat m_Floats
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StylePropertyAnimationSystem.NativeFieldInfoPtr_m_Floats);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StylePropertyAnimationSystem.ValuesFloat>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StylePropertyAnimationSystem.NativeFieldInfoPtr_m_Floats), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B06 RID: 2822
		// (get) Token: 0x06002326 RID: 8998 RVA: 0x0009F468 File Offset: 0x0009D668
		// (set) Token: 0x06002327 RID: 8999 RVA: 0x0000E554 File Offset: 0x0000C754
		public unsafe StylePropertyAnimationSystem.ValuesInt m_Ints
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StylePropertyAnimationSystem.NativeFieldInfoPtr_m_Ints);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StylePropertyAnimationSystem.ValuesInt>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StylePropertyAnimationSystem.NativeFieldInfoPtr_m_Ints), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B07 RID: 2823
		// (get) Token: 0x06002328 RID: 9000 RVA: 0x0009F498 File Offset: 0x0009D698
		// (set) Token: 0x06002329 RID: 9001 RVA: 0x0000E573 File Offset: 0x0000C773
		public unsafe StylePropertyAnimationSystem.ValuesLength m_Lengths
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StylePropertyAnimationSystem.NativeFieldInfoPtr_m_Lengths);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StylePropertyAnimationSystem.ValuesLength>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StylePropertyAnimationSystem.NativeFieldInfoPtr_m_Lengths), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B08 RID: 2824
		// (get) Token: 0x0600232A RID: 9002 RVA: 0x0009F4C8 File Offset: 0x0009D6C8
		// (set) Token: 0x0600232B RID: 9003 RVA: 0x0000E592 File Offset: 0x0000C792
		public unsafe StylePropertyAnimationSystem.ValuesColor m_Colors
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StylePropertyAnimationSystem.NativeFieldInfoPtr_m_Colors);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StylePropertyAnimationSystem.ValuesColor>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StylePropertyAnimationSystem.NativeFieldInfoPtr_m_Colors), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B09 RID: 2825
		// (get) Token: 0x0600232C RID: 9004 RVA: 0x0009F4F8 File Offset: 0x0009D6F8
		// (set) Token: 0x0600232D RID: 9005 RVA: 0x0000E5B1 File Offset: 0x0000C7B1
		public unsafe StylePropertyAnimationSystem.ValuesBackground m_Backgrounds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StylePropertyAnimationSystem.NativeFieldInfoPtr_m_Backgrounds);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StylePropertyAnimationSystem.ValuesBackground>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StylePropertyAnimationSystem.NativeFieldInfoPtr_m_Backgrounds), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B0A RID: 2826
		// (get) Token: 0x0600232E RID: 9006 RVA: 0x0009F528 File Offset: 0x0009D728
		// (set) Token: 0x0600232F RID: 9007 RVA: 0x0000E5D0 File Offset: 0x0000C7D0
		public unsafe StylePropertyAnimationSystem.ValuesFontDefinition m_FontDefinitions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StylePropertyAnimationSystem.NativeFieldInfoPtr_m_FontDefinitions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StylePropertyAnimationSystem.ValuesFontDefinition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StylePropertyAnimationSystem.NativeFieldInfoPtr_m_FontDefinitions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B0B RID: 2827
		// (get) Token: 0x06002330 RID: 9008 RVA: 0x0009F558 File Offset: 0x0009D758
		// (set) Token: 0x06002331 RID: 9009 RVA: 0x0000E5EF File Offset: 0x0000C7EF
		public unsafe StylePropertyAnimationSystem.ValuesFont m_Fonts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StylePropertyAnimationSystem.NativeFieldInfoPtr_m_Fonts);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StylePropertyAnimationSystem.ValuesFont>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StylePropertyAnimationSystem.NativeFieldInfoPtr_m_Fonts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B0C RID: 2828
		// (get) Token: 0x06002332 RID: 9010 RVA: 0x0009F588 File Offset: 0x0009D788
		// (set) Token: 0x06002333 RID: 9011 RVA: 0x0000E60E File Offset: 0x0000C80E
		public unsafe StylePropertyAnimationSystem.ValuesTextShadow m_TextShadows
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StylePropertyAnimationSystem.NativeFieldInfoPtr_m_TextShadows);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StylePropertyAnimationSystem.ValuesTextShadow>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StylePropertyAnimationSystem.NativeFieldInfoPtr_m_TextShadows), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B0D RID: 2829
		// (get) Token: 0x06002334 RID: 9012 RVA: 0x0009F5B8 File Offset: 0x0009D7B8
		// (set) Token: 0x06002335 RID: 9013 RVA: 0x0000E62D File Offset: 0x0000C82D
		public unsafe StylePropertyAnimationSystem.ValuesScale m_Scale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StylePropertyAnimationSystem.NativeFieldInfoPtr_m_Scale);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StylePropertyAnimationSystem.ValuesScale>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StylePropertyAnimationSystem.NativeFieldInfoPtr_m_Scale), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B0E RID: 2830
		// (get) Token: 0x06002336 RID: 9014 RVA: 0x0009F5E8 File Offset: 0x0009D7E8
		// (set) Token: 0x06002337 RID: 9015 RVA: 0x0000E64C File Offset: 0x0000C84C
		public unsafe StylePropertyAnimationSystem.ValuesRotate m_Rotate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StylePropertyAnimationSystem.NativeFieldInfoPtr_m_Rotate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StylePropertyAnimationSystem.ValuesRotate>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StylePropertyAnimationSystem.NativeFieldInfoPtr_m_Rotate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B0F RID: 2831
		// (get) Token: 0x06002338 RID: 9016 RVA: 0x0009F618 File Offset: 0x0009D818
		// (set) Token: 0x06002339 RID: 9017 RVA: 0x0000E66B File Offset: 0x0000C86B
		public unsafe StylePropertyAnimationSystem.ValuesTranslate m_Translate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StylePropertyAnimationSystem.NativeFieldInfoPtr_m_Translate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StylePropertyAnimationSystem.ValuesTranslate>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StylePropertyAnimationSystem.NativeFieldInfoPtr_m_Translate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B10 RID: 2832
		// (get) Token: 0x0600233A RID: 9018 RVA: 0x0009F648 File Offset: 0x0009D848
		// (set) Token: 0x0600233B RID: 9019 RVA: 0x0000E68A File Offset: 0x0000C88A
		public unsafe StylePropertyAnimationSystem.ValuesTransformOrigin m_TransformOrigin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StylePropertyAnimationSystem.NativeFieldInfoPtr_m_TransformOrigin);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StylePropertyAnimationSystem.ValuesTransformOrigin>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StylePropertyAnimationSystem.NativeFieldInfoPtr_m_TransformOrigin), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B11 RID: 2833
		// (get) Token: 0x0600233C RID: 9020 RVA: 0x0009F678 File Offset: 0x0009D878
		// (set) Token: 0x0600233D RID: 9021 RVA: 0x0000E6A9 File Offset: 0x0000C8A9
		public unsafe StylePropertyAnimationSystem.ValuesBackgroundPosition m_BackgroundPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StylePropertyAnimationSystem.NativeFieldInfoPtr_m_BackgroundPosition);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StylePropertyAnimationSystem.ValuesBackgroundPosition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StylePropertyAnimationSystem.NativeFieldInfoPtr_m_BackgroundPosition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B12 RID: 2834
		// (get) Token: 0x0600233E RID: 9022 RVA: 0x0009F6A8 File Offset: 0x0009D8A8
		// (set) Token: 0x0600233F RID: 9023 RVA: 0x0000E6C8 File Offset: 0x0000C8C8
		public unsafe StylePropertyAnimationSystem.ValuesBackgroundRepeat m_BackgroundRepeat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StylePropertyAnimationSystem.NativeFieldInfoPtr_m_BackgroundRepeat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StylePropertyAnimationSystem.ValuesBackgroundRepeat>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StylePropertyAnimationSystem.NativeFieldInfoPtr_m_BackgroundRepeat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B13 RID: 2835
		// (get) Token: 0x06002340 RID: 9024 RVA: 0x0009F6D8 File Offset: 0x0009D8D8
		// (set) Token: 0x06002341 RID: 9025 RVA: 0x0000E6E7 File Offset: 0x0000C8E7
		public unsafe StylePropertyAnimationSystem.ValuesBackgroundSize m_BackgroundSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StylePropertyAnimationSystem.NativeFieldInfoPtr_m_BackgroundSize);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StylePropertyAnimationSystem.ValuesBackgroundSize>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StylePropertyAnimationSystem.NativeFieldInfoPtr_m_BackgroundSize), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B14 RID: 2836
		// (get) Token: 0x06002342 RID: 9026 RVA: 0x0009F708 File Offset: 0x0009D908
		// (set) Token: 0x06002343 RID: 9027 RVA: 0x0000E706 File Offset: 0x0000C906
		public unsafe List<StylePropertyAnimationSystem.Values> m_AllValues
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StylePropertyAnimationSystem.NativeFieldInfoPtr_m_AllValues);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<StylePropertyAnimationSystem.Values>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StylePropertyAnimationSystem.NativeFieldInfoPtr_m_AllValues), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B15 RID: 2837
		// (get) Token: 0x06002344 RID: 9028 RVA: 0x0009F738 File Offset: 0x0009D938
		// (set) Token: 0x06002345 RID: 9029 RVA: 0x0000E725 File Offset: 0x0000C925
		public unsafe Dictionary<UnityEngine.UIElements.StyleSheets.StylePropertyId, StylePropertyAnimationSystem.Values> m_PropertyToValues
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StylePropertyAnimationSystem.NativeFieldInfoPtr_m_PropertyToValues);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<UnityEngine.UIElements.StyleSheets.StylePropertyId, StylePropertyAnimationSystem.Values>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StylePropertyAnimationSystem.NativeFieldInfoPtr_m_PropertyToValues), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x06002346 RID: 9030 RVA: 0x0000E744 File Offset: 0x0000C944
		public bool StartAnimationEnum(VisualElement owner, UnityEngine.UIElements.StyleSheets.StylePropertyId prop, int startValue, int endValue, int durationMs, int delayMs, Func<float, float> easingCurve)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06002347 RID: 9031 RVA: 0x0009F768 File Offset: 0x0009D968
		public bool HasRunningAnimation(VisualElement owner, UnityEngine.UIElements.StyleSheets.StylePropertyId id)
		{
			StylePropertyAnimationSystem.Values values;
			return this.m_PropertyToValues.TryGetValue(id, out values) && values.HasRunningAnimation(owner, id);
		}

		// Token: 0x0400191A RID: 6426
		private static readonly IntPtr NativeFieldInfoPtr_m_CurrentTimeMs;

		// Token: 0x0400191B RID: 6427
		private static readonly IntPtr NativeFieldInfoPtr_m_Floats;

		// Token: 0x0400191C RID: 6428
		private static readonly IntPtr NativeFieldInfoPtr_m_Ints;

		// Token: 0x0400191D RID: 6429
		private static readonly IntPtr NativeFieldInfoPtr_m_Lengths;

		// Token: 0x0400191E RID: 6430
		private static readonly IntPtr NativeFieldInfoPtr_m_Colors;

		// Token: 0x0400191F RID: 6431
		private static readonly IntPtr NativeFieldInfoPtr_m_Backgrounds;

		// Token: 0x04001920 RID: 6432
		private static readonly IntPtr NativeFieldInfoPtr_m_FontDefinitions;

		// Token: 0x04001921 RID: 6433
		private static readonly IntPtr NativeFieldInfoPtr_m_Fonts;

		// Token: 0x04001922 RID: 6434
		private static readonly IntPtr NativeFieldInfoPtr_m_TextShadows;

		// Token: 0x04001923 RID: 6435
		private static readonly IntPtr NativeFieldInfoPtr_m_Scale;

		// Token: 0x04001924 RID: 6436
		private static readonly IntPtr NativeFieldInfoPtr_m_Rotate;

		// Token: 0x04001925 RID: 6437
		private static readonly IntPtr NativeFieldInfoPtr_m_Translate;

		// Token: 0x04001926 RID: 6438
		private static readonly IntPtr NativeFieldInfoPtr_m_TransformOrigin;

		// Token: 0x04001927 RID: 6439
		private static readonly IntPtr NativeFieldInfoPtr_m_BackgroundPosition;

		// Token: 0x04001928 RID: 6440
		private static readonly IntPtr NativeFieldInfoPtr_m_BackgroundRepeat;

		// Token: 0x04001929 RID: 6441
		private static readonly IntPtr NativeFieldInfoPtr_m_BackgroundSize;

		// Token: 0x0400192A RID: 6442
		private static readonly IntPtr NativeFieldInfoPtr_m_AllValues;

		// Token: 0x0400192B RID: 6443
		private static readonly IntPtr NativeFieldInfoPtr_m_PropertyToValues;

		// Token: 0x0400192C RID: 6444
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400192D RID: 6445
		private static readonly IntPtr NativeMethodInfoPtr_GetOrCreate_Private_T_byref_T_0;

		// Token: 0x0400192E RID: 6446
		private static readonly IntPtr NativeMethodInfoPtr_StartTransition_Private_Boolean_VisualElement_StylePropertyId_T_T_Int32_Int32_Func_2_Single_Single_Values_1_T_0;

		// Token: 0x0400192F RID: 6447
		private static readonly IntPtr NativeMethodInfoPtr_StartTransition_Public_Virtual_Final_New_Boolean_VisualElement_StylePropertyId_Single_Single_Int32_Int32_Func_2_Single_Single_0;

		// Token: 0x04001930 RID: 6448
		private static readonly IntPtr NativeMethodInfoPtr_StartTransition_Public_Virtual_Final_New_Boolean_VisualElement_StylePropertyId_Int32_Int32_Int32_Int32_Func_2_Single_Single_0;

		// Token: 0x04001931 RID: 6449
		private static readonly IntPtr NativeMethodInfoPtr_StartTransition_Public_Virtual_Final_New_Boolean_VisualElement_StylePropertyId_Length_Length_Int32_Int32_Func_2_Single_Single_0;

		// Token: 0x04001932 RID: 6450
		private static readonly IntPtr NativeMethodInfoPtr_StartTransition_Public_Virtual_Final_New_Boolean_VisualElement_StylePropertyId_Color_Color_Int32_Int32_Func_2_Single_Single_0;

		// Token: 0x04001933 RID: 6451
		private static readonly IntPtr NativeMethodInfoPtr_StartTransition_Public_Virtual_Final_New_Boolean_VisualElement_StylePropertyId_Background_Background_Int32_Int32_Func_2_Single_Single_0;

		// Token: 0x04001934 RID: 6452
		private static readonly IntPtr NativeMethodInfoPtr_StartTransition_Public_Virtual_Final_New_Boolean_VisualElement_StylePropertyId_FontDefinition_FontDefinition_Int32_Int32_Func_2_Single_Single_0;

		// Token: 0x04001935 RID: 6453
		private static readonly IntPtr NativeMethodInfoPtr_StartTransition_Public_Virtual_Final_New_Boolean_VisualElement_StylePropertyId_Font_Font_Int32_Int32_Func_2_Single_Single_0;

		// Token: 0x04001936 RID: 6454
		private static readonly IntPtr NativeMethodInfoPtr_StartTransition_Public_Virtual_Final_New_Boolean_VisualElement_StylePropertyId_TextShadow_TextShadow_Int32_Int32_Func_2_Single_Single_0;

		// Token: 0x04001937 RID: 6455
		private static readonly IntPtr NativeMethodInfoPtr_StartTransition_Public_Virtual_Final_New_Boolean_VisualElement_StylePropertyId_Scale_Scale_Int32_Int32_Func_2_Single_Single_0;

		// Token: 0x04001938 RID: 6456
		private static readonly IntPtr NativeMethodInfoPtr_StartTransition_Public_Virtual_Final_New_Boolean_VisualElement_StylePropertyId_Rotate_Rotate_Int32_Int32_Func_2_Single_Single_0;

		// Token: 0x04001939 RID: 6457
		private static readonly IntPtr NativeMethodInfoPtr_StartTransition_Public_Virtual_Final_New_Boolean_VisualElement_StylePropertyId_Translate_Translate_Int32_Int32_Func_2_Single_Single_0;

		// Token: 0x0400193A RID: 6458
		private static readonly IntPtr NativeMethodInfoPtr_StartTransition_Public_Virtual_Final_New_Boolean_VisualElement_StylePropertyId_TransformOrigin_TransformOrigin_Int32_Int32_Func_2_Single_Single_0;

		// Token: 0x0400193B RID: 6459
		private static readonly IntPtr NativeMethodInfoPtr_StartTransition_Public_Virtual_Final_New_Boolean_VisualElement_StylePropertyId_BackgroundPosition_BackgroundPosition_Int32_Int32_Func_2_Single_Single_0;

		// Token: 0x0400193C RID: 6460
		private static readonly IntPtr NativeMethodInfoPtr_StartTransition_Public_Virtual_Final_New_Boolean_VisualElement_StylePropertyId_BackgroundRepeat_BackgroundRepeat_Int32_Int32_Func_2_Single_Single_0;

		// Token: 0x0400193D RID: 6461
		private static readonly IntPtr NativeMethodInfoPtr_StartTransition_Public_Virtual_Final_New_Boolean_VisualElement_StylePropertyId_BackgroundSize_BackgroundSize_Int32_Int32_Func_2_Single_Single_0;

		// Token: 0x0400193E RID: 6462
		private static readonly IntPtr NativeMethodInfoPtr_CancelAllAnimations_Public_Virtual_Final_New_Void_0;

		// Token: 0x0400193F RID: 6463
		private static readonly IntPtr NativeMethodInfoPtr_CancelAllAnimations_Public_Virtual_Final_New_Void_VisualElement_0;

		// Token: 0x04001940 RID: 6464
		private static readonly IntPtr NativeMethodInfoPtr_CancelAnimation_Public_Virtual_Final_New_Void_VisualElement_StylePropertyId_0;

		// Token: 0x04001941 RID: 6465
		private static readonly IntPtr NativeMethodInfoPtr_UpdateAnimation_Public_Virtual_Final_New_Void_VisualElement_StylePropertyId_0;

		// Token: 0x04001942 RID: 6466
		private static readonly IntPtr NativeMethodInfoPtr_GetAllAnimations_Public_Virtual_Final_New_Void_VisualElement_List_1_StylePropertyId_0;

		// Token: 0x04001943 RID: 6467
		private static readonly IntPtr NativeMethodInfoPtr_UpdateTracking_Private_Void_Values_1_T_0;

		// Token: 0x04001944 RID: 6468
		private static readonly IntPtr NativeMethodInfoPtr_CurrentTimeMs_Private_Int64_0;

		// Token: 0x04001945 RID: 6469
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Virtual_Final_New_Void_0;

		// Token: 0x020004C1 RID: 1217
		[Flags]
		public enum TransitionState
		{
			// Token: 0x04002BDC RID: 11228
			None = 0,
			// Token: 0x04002BDD RID: 11229
			Running = 1,
			// Token: 0x04002BDE RID: 11230
			Started = 2,
			// Token: 0x04002BDF RID: 11231
			Ended = 4,
			// Token: 0x04002BE0 RID: 11232
			Canceled = 8
		}

		// Token: 0x020004C2 RID: 1218
		public sealed class AnimationDataSet<TTimingData, TStyleData> : ValueType
		{
			// Token: 0x06003E0F RID: 15887 RVA: 0x000F7580 File Offset: 0x000F5780
			// Note: this type is marked as 'beforefieldinit'.
			static AnimationDataSet()
			{
				Il2CppClassPointerStore<StylePropertyAnimationSystem.AnimationDataSet<TTimingData, TStyleData>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StylePropertyAnimationSystem>.NativeClassPtr, "AnimationDataSet`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TTimingData>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TStyleData>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StylePropertyAnimationSystem.AnimationDataSet<TTimingData, TStyleData>>.NativeClassPtr);
				StylePropertyAnimationSystem.AnimationDataSet<TTimingData, TStyleData>.NativeFieldInfoPtr_elements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StylePropertyAnimationSystem.AnimationDataSet<TTimingData, TStyleData>>.NativeClassPtr, "elements");
				StylePropertyAnimationSystem.AnimationDataSet<TTimingData, TStyleData>.NativeFieldInfoPtr_properties = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StylePropertyAnimationSystem.AnimationDataSet<TTimingData, TStyleData>>.NativeClassPtr, "properties");
				StylePropertyAnimationSystem.AnimationDataSet<TTimingData, TStyleData>.NativeFieldInfoPtr_timing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StylePropertyAnimationSystem.AnimationDataSet<TTimingData, TStyleData>>.NativeClassPtr, "timing");
				StylePropertyAnimationSystem.AnimationDataSet<TTimingData, TStyleData>.NativeFieldInfoPtr_style = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StylePropertyAnimationSystem.AnimationDataSet<TTimingData, TStyleData>>.NativeClassPtr, "style");
				StylePropertyAnimationSystem.AnimationDataSet<TTimingData, TStyleData>.NativeFieldInfoPtr_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StylePropertyAnimationSystem.AnimationDataSet<TTimingData, TStyleData>>.NativeClassPtr, "count");
				StylePropertyAnimationSystem.AnimationDataSet<TTimingData, TStyleData>.NativeFieldInfoPtr_indices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StylePropertyAnimationSystem.AnimationDataSet<TTimingData, TStyleData>>.NativeClassPtr, "indices");
				StylePropertyAnimationSystem.AnimationDataSet<TTimingData, TStyleData>.NativeMethodInfoPtr_get_capacity_Private_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyAnimationSystem.AnimationDataSet<TTimingData, TStyleData>>.NativeClassPtr, 100668526);
				StylePropertyAnimationSystem.AnimationDataSet<TTimingData, TStyleData>.NativeMethodInfoPtr_set_capacity_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyAnimationSystem.AnimationDataSet<TTimingData, TStyleData>>.NativeClassPtr, 100668527);
				StylePropertyAnimationSystem.AnimationDataSet<TTimingData, TStyleData>.NativeMethodInfoPtr_LocalInit_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyAnimationSystem.AnimationDataSet<TTimingData, TStyleData>>.NativeClassPtr, 100668528);
				StylePropertyAnimationSystem.AnimationDataSet<TTimingData, TStyleData>.NativeMethodInfoPtr_Create_Public_Static_AnimationDataSet_2_TTimingData_TStyleData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyAnimationSystem.AnimationDataSet<TTimingData, TStyleData>>.NativeClassPtr, 100668529);
				StylePropertyAnimationSystem.AnimationDataSet<TTimingData, TStyleData>.NativeMethodInfoPtr_IndexOf_Public_Boolean_VisualElement_StylePropertyId_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyAnimationSystem.AnimationDataSet<TTimingData, TStyleData>>.NativeClassPtr, 100668530);
				StylePropertyAnimationSystem.AnimationDataSet<TTimingData, TStyleData>.NativeMethodInfoPtr_Add_Public_Void_VisualElement_StylePropertyId_TTimingData_TStyleData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyAnimationSystem.AnimationDataSet<TTimingData, TStyleData>>.NativeClassPtr, 100668531);
				StylePropertyAnimationSystem.AnimationDataSet<TTimingData, TStyleData>.NativeMethodInfoPtr_Remove_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyAnimationSystem.AnimationDataSet<TTimingData, TStyleData>>.NativeClassPtr, 100668532);
				StylePropertyAnimationSystem.AnimationDataSet<TTimingData, TStyleData>.NativeMethodInfoPtr_Replace_Public_Void_Int32_TTimingData_TStyleData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyAnimationSystem.AnimationDataSet<TTimingData, TStyleData>>.NativeClassPtr, 100668533);
				StylePropertyAnimationSystem.AnimationDataSet<TTimingData, TStyleData>.NativeMethodInfoPtr_RemoveAll_Public_Void_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyAnimationSystem.AnimationDataSet<TTimingData, TStyleData>>.NativeClassPtr, 100668534);
				StylePropertyAnimationSystem.AnimationDataSet<TTimingData, TStyleData>.NativeMethodInfoPtr_RemoveAll_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyAnimationSystem.AnimationDataSet<TTimingData, TStyleData>>.NativeClassPtr, 100668535);
				StylePropertyAnimationSystem.AnimationDataSet<TTimingData, TStyleData>.NativeMethodInfoPtr_GetActivePropertiesForElement_Public_Void_VisualElement_List_1_StylePropertyId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyAnimationSystem.AnimationDataSet<TTimingData, TStyleData>>.NativeClassPtr, 100668536);
			}

			// Token: 0x170012CE RID: 4814
			// (get) Token: 0x06003E10 RID: 15888 RVA: 0x000F774C File Offset: 0x000F594C
			// (set) Token: 0x06003E11 RID: 15889 RVA: 0x000F7790 File Offset: 0x000F5990
			public unsafe int capacity
			{
				[CallerCount(22)]
				[CachedScanResults(RefRangeStart = 336051, RefRangeEnd = 336073, XrefRangeStart = 336051, XrefRangeEnd = 336051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyAnimationSystem.AnimationDataSet<TTimingData, TStyleData>.NativeMethodInfoPtr_get_capacity_Private_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 336073, XrefRangeEnd = 336083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyAnimationSystem.AnimationDataSet<TTimingData, TStyleData>.NativeMethodInfoPtr_set_capacity_Private_set_Void_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x06003E12 RID: 15890 RVA: 0x000F77D4 File Offset: 0x000F59D4
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 336110, RefRangeEnd = 336111, XrefRangeStart = 336083, XrefRangeEnd = 336110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void LocalInit()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyAnimationSystem.AnimationDataSet<TTimingData, TStyleData>.NativeMethodInfoPtr_LocalInit_Private_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003E13 RID: 15891 RVA: 0x000F780C File Offset: 0x000F5A0C
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 336113, RefRangeEnd = 336115, XrefRangeStart = 336111, XrefRangeEnd = 336113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static StylePropertyAnimationSystem.AnimationDataSet<TTimingData, TStyleData> Create()
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyAnimationSystem.AnimationDataSet<TTimingData, TStyleData>.NativeMethodInfoPtr_Create_Public_Static_AnimationDataSet_2_TTimingData_TStyleData_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new StylePropertyAnimationSystem.AnimationDataSet<TTimingData, TStyleData>(intPtr);
			}

			// Token: 0x06003E14 RID: 15892 RVA: 0x000F7838 File Offset: 0x000F5A38
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 336119, RefRangeEnd = 336121, XrefRangeStart = 336115, XrefRangeEnd = 336119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool IndexOf(VisualElement ve, UnityEngine.UIElements.StyleSheets.StylePropertyId prop, out int index)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ve);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref prop;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyAnimationSystem.AnimationDataSet<TTimingData, TStyleData>.NativeMethodInfoPtr_IndexOf_Public_Boolean_VisualElement_StylePropertyId_byref_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06003E15 RID: 15893 RVA: 0x000F78A8 File Offset: 0x000F5AA8
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 336132, RefRangeEnd = 336133, XrefRangeStart = 336121, XrefRangeEnd = 336132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Add(VisualElement owner, UnityEngine.UIElements.StyleSheets.StylePropertyId prop, TTimingData timingData, TStyleData styleData)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(owner);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref prop;
				ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
				IntPtr intPtr;
				if (!typeof(TTimingData).IsValueType)
				{
					TTimingData ttimingData = timingData;
					intPtr = ((ttimingData is string) ? IL2CPP.ManagedStringToIl2Cpp(ttimingData as string) : IL2CPP.Il2CppObjectBaseToPtr(ttimingData as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref timingData;
				}
				ptr2 = intPtr;
				ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
				IntPtr intPtr2;
				if (!typeof(TStyleData).IsValueType)
				{
					TStyleData tstyleData = styleData;
					intPtr2 = ((tstyleData is string) ? IL2CPP.ManagedStringToIl2Cpp(tstyleData as string) : IL2CPP.Il2CppObjectBaseToPtr(tstyleData as Il2CppObjectBase));
				}
				else
				{
					intPtr2 = ref styleData;
				}
				ptr3 = intPtr2;
				IntPtr intPtr4;
				IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(StylePropertyAnimationSystem.AnimationDataSet<TTimingData, TStyleData>.NativeMethodInfoPtr_Add_Public_Void_VisualElement_StylePropertyId_TTimingData_TStyleData_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr4);
				Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			}

			// Token: 0x06003E16 RID: 15894 RVA: 0x000F7990 File Offset: 0x000F5B90
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 336165, RefRangeEnd = 336168, XrefRangeStart = 336133, XrefRangeEnd = 336165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Remove(int cancelledIndex)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref cancelledIndex;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyAnimationSystem.AnimationDataSet<TTimingData, TStyleData>.NativeMethodInfoPtr_Remove_Public_Void_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003E17 RID: 15895 RVA: 0x000F79D4 File Offset: 0x000F5BD4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 336168, XrefRangeEnd = 336221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Replace(int index, TTimingData timingData, TStyleData styleData)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
				}
				ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
				IntPtr intPtr;
				if (!typeof(TTimingData).IsValueType)
				{
					TTimingData ttimingData = timingData;
					intPtr = ((ttimingData is string) ? IL2CPP.ManagedStringToIl2Cpp(ttimingData as string) : IL2CPP.Il2CppObjectBaseToPtr(ttimingData as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref timingData;
				}
				ptr2 = intPtr;
				ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
				IntPtr intPtr2;
				if (!typeof(TStyleData).IsValueType)
				{
					TStyleData tstyleData = styleData;
					intPtr2 = ((tstyleData is string) ? IL2CPP.ManagedStringToIl2Cpp(tstyleData as string) : IL2CPP.Il2CppObjectBaseToPtr(tstyleData as Il2CppObjectBase));
				}
				else
				{
					intPtr2 = ref styleData;
				}
				ptr3 = intPtr2;
				IntPtr intPtr4;
				IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(StylePropertyAnimationSystem.AnimationDataSet<TTimingData, TStyleData>.NativeMethodInfoPtr_Replace_Public_Void_Int32_TTimingData_TStyleData_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr4);
				Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			}

			// Token: 0x06003E18 RID: 15896 RVA: 0x000F7AA8 File Offset: 0x000F5CA8
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 336223, RefRangeEnd = 336224, XrefRangeStart = 336221, XrefRangeEnd = 336223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void RemoveAll(VisualElement ve)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ve);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyAnimationSystem.AnimationDataSet<TTimingData, TStyleData>.NativeMethodInfoPtr_RemoveAll_Public_Void_VisualElement_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003E19 RID: 15897 RVA: 0x000F7AF0 File Offset: 0x000F5CF0
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 336237, RefRangeEnd = 336238, XrefRangeStart = 336224, XrefRangeEnd = 336237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void RemoveAll()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyAnimationSystem.AnimationDataSet<TTimingData, TStyleData>.NativeMethodInfoPtr_RemoveAll_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003E1A RID: 15898 RVA: 0x000F7B28 File Offset: 0x000F5D28
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 336241, RefRangeEnd = 336242, XrefRangeStart = 336238, XrefRangeEnd = 336241, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void GetActivePropertiesForElement(VisualElement ve, List<UnityEngine.UIElements.StyleSheets.StylePropertyId> outProperties)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ve);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(outProperties);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyAnimationSystem.AnimationDataSet<TTimingData, TStyleData>.NativeMethodInfoPtr_GetActivePropertiesForElement_Public_Void_VisualElement_List_1_StylePropertyId_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003E1B RID: 15899 RVA: 0x0001A218 File Offset: 0x00018418
			public AnimationDataSet(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06003E1C RID: 15900 RVA: 0x0001A221 File Offset: 0x00018421
			public AnimationDataSet()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StylePropertyAnimationSystem.AnimationDataSet<TTimingData, TStyleData>>.NativeClassPtr))
			{
			}

			// Token: 0x170012C8 RID: 4808
			// (get) Token: 0x06003E1D RID: 15901 RVA: 0x000F7B84 File Offset: 0x000F5D84
			// (set) Token: 0x06003E1E RID: 15902 RVA: 0x0001A233 File Offset: 0x00018433
			public unsafe Il2CppReferenceArray<VisualElement> elements
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StylePropertyAnimationSystem.AnimationDataSet<TTimingData, TStyleData>.NativeFieldInfoPtr_elements);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<VisualElement>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StylePropertyAnimationSystem.AnimationDataSet<TTimingData, TStyleData>.NativeFieldInfoPtr_elements), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170012C9 RID: 4809
			// (get) Token: 0x06003E1F RID: 15903 RVA: 0x000F7BB4 File Offset: 0x000F5DB4
			// (set) Token: 0x06003E20 RID: 15904 RVA: 0x0001A252 File Offset: 0x00018452
			public unsafe Il2CppStructArray<UnityEngine.UIElements.StyleSheets.StylePropertyId> properties
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StylePropertyAnimationSystem.AnimationDataSet<TTimingData, TStyleData>.NativeFieldInfoPtr_properties);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<UnityEngine.UIElements.StyleSheets.StylePropertyId>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StylePropertyAnimationSystem.AnimationDataSet<TTimingData, TStyleData>.NativeFieldInfoPtr_properties), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170012CA RID: 4810
			// (get) Token: 0x06003E21 RID: 15905 RVA: 0x000F7BE4 File Offset: 0x000F5DE4
			// (set) Token: 0x06003E22 RID: 15906 RVA: 0x0001A271 File Offset: 0x00018471
			public unsafe Il2CppArrayBase<TTimingData> timing
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StylePropertyAnimationSystem.AnimationDataSet<TTimingData, TStyleData>.NativeFieldInfoPtr_timing);
					return Il2CppArrayBase<TTimingData>.WrapNativeGenericArrayPointer(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StylePropertyAnimationSystem.AnimationDataSet<TTimingData, TStyleData>.NativeFieldInfoPtr_timing), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170012CB RID: 4811
			// (get) Token: 0x06003E23 RID: 15907 RVA: 0x000F7C0C File Offset: 0x000F5E0C
			// (set) Token: 0x06003E24 RID: 15908 RVA: 0x0001A290 File Offset: 0x00018490
			public unsafe Il2CppArrayBase<TStyleData> style
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StylePropertyAnimationSystem.AnimationDataSet<TTimingData, TStyleData>.NativeFieldInfoPtr_style);
					return Il2CppArrayBase<TStyleData>.WrapNativeGenericArrayPointer(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StylePropertyAnimationSystem.AnimationDataSet<TTimingData, TStyleData>.NativeFieldInfoPtr_style), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170012CC RID: 4812
			// (get) Token: 0x06003E25 RID: 15909 RVA: 0x000F7C34 File Offset: 0x000F5E34
			// (set) Token: 0x06003E26 RID: 15910 RVA: 0x0001A2AF File Offset: 0x000184AF
			public unsafe int count
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StylePropertyAnimationSystem.AnimationDataSet<TTimingData, TStyleData>.NativeFieldInfoPtr_count);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StylePropertyAnimationSystem.AnimationDataSet<TTimingData, TStyleData>.NativeFieldInfoPtr_count)) = value;
				}
			}

			// Token: 0x170012CD RID: 4813
			// (get) Token: 0x06003E27 RID: 15911 RVA: 0x000F7C5C File Offset: 0x000F5E5C
			// (set) Token: 0x06003E28 RID: 15912 RVA: 0x0001A2CA File Offset: 0x000184CA
			public unsafe Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, int> indices
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StylePropertyAnimationSystem.AnimationDataSet<TTimingData, TStyleData>.NativeFieldInfoPtr_indices);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StylePropertyAnimationSystem.AnimationDataSet<TTimingData, TStyleData>.NativeFieldInfoPtr_indices), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002BE1 RID: 11233
			private static readonly IntPtr NativeFieldInfoPtr_elements;

			// Token: 0x04002BE2 RID: 11234
			private static readonly IntPtr NativeFieldInfoPtr_properties;

			// Token: 0x04002BE3 RID: 11235
			private static readonly IntPtr NativeFieldInfoPtr_timing;

			// Token: 0x04002BE4 RID: 11236
			private static readonly IntPtr NativeFieldInfoPtr_style;

			// Token: 0x04002BE5 RID: 11237
			private static readonly IntPtr NativeFieldInfoPtr_count;

			// Token: 0x04002BE6 RID: 11238
			private static readonly IntPtr NativeFieldInfoPtr_indices;

			// Token: 0x04002BE7 RID: 11239
			private static readonly IntPtr NativeMethodInfoPtr_get_capacity_Private_get_Int32_0;

			// Token: 0x04002BE8 RID: 11240
			private static readonly IntPtr NativeMethodInfoPtr_set_capacity_Private_set_Void_Int32_0;

			// Token: 0x04002BE9 RID: 11241
			private static readonly IntPtr NativeMethodInfoPtr_LocalInit_Private_Void_0;

			// Token: 0x04002BEA RID: 11242
			private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_AnimationDataSet_2_TTimingData_TStyleData_0;

			// Token: 0x04002BEB RID: 11243
			private static readonly IntPtr NativeMethodInfoPtr_IndexOf_Public_Boolean_VisualElement_StylePropertyId_byref_Int32_0;

			// Token: 0x04002BEC RID: 11244
			private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Void_VisualElement_StylePropertyId_TTimingData_TStyleData_0;

			// Token: 0x04002BED RID: 11245
			private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Void_Int32_0;

			// Token: 0x04002BEE RID: 11246
			private static readonly IntPtr NativeMethodInfoPtr_Replace_Public_Void_Int32_TTimingData_TStyleData_0;

			// Token: 0x04002BEF RID: 11247
			private static readonly IntPtr NativeMethodInfoPtr_RemoveAll_Public_Void_VisualElement_0;

			// Token: 0x04002BF0 RID: 11248
			private static readonly IntPtr NativeMethodInfoPtr_RemoveAll_Public_Void_0;

			// Token: 0x04002BF1 RID: 11249
			private static readonly IntPtr NativeMethodInfoPtr_GetActivePropertiesForElement_Public_Void_VisualElement_List_1_StylePropertyId_0;
		}

		// Token: 0x020004C3 RID: 1219
		public sealed class ElementPropertyPair : ValueType
		{
			// Token: 0x06003E29 RID: 15913 RVA: 0x000F7C8C File Offset: 0x000F5E8C
			// Note: this type is marked as 'beforefieldinit'.
			static ElementPropertyPair()
			{
				Il2CppClassPointerStore<StylePropertyAnimationSystem.ElementPropertyPair>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StylePropertyAnimationSystem>.NativeClassPtr, "ElementPropertyPair");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StylePropertyAnimationSystem.ElementPropertyPair>.NativeClassPtr);
				StylePropertyAnimationSystem.ElementPropertyPair.NativeFieldInfoPtr_Comparer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StylePropertyAnimationSystem.ElementPropertyPair>.NativeClassPtr, "Comparer");
				StylePropertyAnimationSystem.ElementPropertyPair.NativeFieldInfoPtr_element = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StylePropertyAnimationSystem.ElementPropertyPair>.NativeClassPtr, "element");
				StylePropertyAnimationSystem.ElementPropertyPair.NativeFieldInfoPtr_property = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StylePropertyAnimationSystem.ElementPropertyPair>.NativeClassPtr, "property");
				StylePropertyAnimationSystem.ElementPropertyPair.NativeMethodInfoPtr__ctor_Public_Void_VisualElement_StylePropertyId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyAnimationSystem.ElementPropertyPair>.NativeClassPtr, 100668537);
			}

			// Token: 0x06003E2A RID: 15914 RVA: 0x000F7D08 File Offset: 0x000F5F08
			[CallerCount(40)]
			[CachedScanResults(RefRangeStart = 336243, RefRangeEnd = 336283, XrefRangeStart = 336242, XrefRangeEnd = 336243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ElementPropertyPair(VisualElement element, UnityEngine.UIElements.StyleSheets.StylePropertyId property)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StylePropertyAnimationSystem.ElementPropertyPair>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref property;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyAnimationSystem.ElementPropertyPair.NativeMethodInfoPtr__ctor_Public_Void_VisualElement_StylePropertyId_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003E2B RID: 15915 RVA: 0x0001A2E9 File Offset: 0x000184E9
			public ElementPropertyPair(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06003E2C RID: 15916 RVA: 0x0001A2F2 File Offset: 0x000184F2
			public ElementPropertyPair()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StylePropertyAnimationSystem.ElementPropertyPair>.NativeClassPtr))
			{
			}

			// Token: 0x170012CF RID: 4815
			// (get) Token: 0x06003E2D RID: 15917 RVA: 0x000F7D68 File Offset: 0x000F5F68
			// (set) Token: 0x06003E2E RID: 15918 RVA: 0x0001A304 File Offset: 0x00018504
			public unsafe static IEqualityComparer<StylePropertyAnimationSystem.ElementPropertyPair> Comparer
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(StylePropertyAnimationSystem.ElementPropertyPair.NativeFieldInfoPtr_Comparer, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEqualityComparer<StylePropertyAnimationSystem.ElementPropertyPair>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(StylePropertyAnimationSystem.ElementPropertyPair.NativeFieldInfoPtr_Comparer, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170012D0 RID: 4816
			// (get) Token: 0x06003E2F RID: 15919 RVA: 0x000F7D90 File Offset: 0x000F5F90
			// (set) Token: 0x06003E30 RID: 15920 RVA: 0x0001A316 File Offset: 0x00018516
			public unsafe VisualElement element
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StylePropertyAnimationSystem.ElementPropertyPair.NativeFieldInfoPtr_element);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StylePropertyAnimationSystem.ElementPropertyPair.NativeFieldInfoPtr_element), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170012D1 RID: 4817
			// (get) Token: 0x06003E31 RID: 15921 RVA: 0x000F7DC0 File Offset: 0x000F5FC0
			// (set) Token: 0x06003E32 RID: 15922 RVA: 0x0001A335 File Offset: 0x00018535
			public unsafe UnityEngine.UIElements.StyleSheets.StylePropertyId property
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StylePropertyAnimationSystem.ElementPropertyPair.NativeFieldInfoPtr_property);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StylePropertyAnimationSystem.ElementPropertyPair.NativeFieldInfoPtr_property)) = value;
				}
			}

			// Token: 0x04002BF2 RID: 11250
			private static readonly IntPtr NativeFieldInfoPtr_Comparer;

			// Token: 0x04002BF3 RID: 11251
			private static readonly IntPtr NativeFieldInfoPtr_element;

			// Token: 0x04002BF4 RID: 11252
			private static readonly IntPtr NativeFieldInfoPtr_property;

			// Token: 0x04002BF5 RID: 11253
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_VisualElement_StylePropertyId_0;

			// Token: 0x02000596 RID: 1430
			public class EqualityComparer : Object
			{
				// Token: 0x060042C3 RID: 17091 RVA: 0x00105A4C File Offset: 0x00103C4C
				// Note: this type is marked as 'beforefieldinit'.
				static EqualityComparer()
				{
					Il2CppClassPointerStore<StylePropertyAnimationSystem.ElementPropertyPair.EqualityComparer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StylePropertyAnimationSystem.ElementPropertyPair>.NativeClassPtr, "EqualityComparer");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StylePropertyAnimationSystem.ElementPropertyPair.EqualityComparer>.NativeClassPtr);
					StylePropertyAnimationSystem.ElementPropertyPair.EqualityComparer.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ElementPropertyPair_ElementPropertyPair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyAnimationSystem.ElementPropertyPair.EqualityComparer>.NativeClassPtr, 100668539);
					StylePropertyAnimationSystem.ElementPropertyPair.EqualityComparer.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Final_New_Int32_ElementPropertyPair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyAnimationSystem.ElementPropertyPair.EqualityComparer>.NativeClassPtr, 100668540);
					StylePropertyAnimationSystem.ElementPropertyPair.EqualityComparer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyAnimationSystem.ElementPropertyPair.EqualityComparer>.NativeClassPtr, 100668541);
				}

				// Token: 0x060042C4 RID: 17092 RVA: 0x00105AB4 File Offset: 0x00103CB4
				[CallerCount(0)]
				public unsafe virtual bool Equals(StylePropertyAnimationSystem.ElementPropertyPair x, StylePropertyAnimationSystem.ElementPropertyPair y)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(y));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyAnimationSystem.ElementPropertyPair.EqualityComparer.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ElementPropertyPair_ElementPropertyPair_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x060042C5 RID: 17093 RVA: 0x00105B20 File Offset: 0x00103D20
				[CallerCount(0)]
				public unsafe virtual int GetHashCode(StylePropertyAnimationSystem.ElementPropertyPair obj)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(obj));
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyAnimationSystem.ElementPropertyPair.EqualityComparer.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Final_New_Int32_ElementPropertyPair_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return *IL2CPP.il2cpp_object_unbox(intPtr);
					}
				}

				// Token: 0x060042C6 RID: 17094 RVA: 0x00105B74 File Offset: 0x00103D74
				[CallerCount(2676)]
				[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe EqualityComparer()
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StylePropertyAnimationSystem.ElementPropertyPair.EqualityComparer>.NativeClassPtr))
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyAnimationSystem.ElementPropertyPair.EqualityComparer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060042C7 RID: 17095 RVA: 0x0001C80E File Offset: 0x0001AA0E
				public EqualityComparer(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x04002EBE RID: 11966
				private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ElementPropertyPair_ElementPropertyPair_0;

				// Token: 0x04002EBF RID: 11967
				private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Final_New_Int32_ElementPropertyPair_0;

				// Token: 0x04002EC0 RID: 11968
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
			}
		}

		// Token: 0x020004C4 RID: 1220
		public class Values : Object
		{
			// Token: 0x06003E33 RID: 15923 RVA: 0x000F7DE8 File Offset: 0x000F5FE8
			// Note: this type is marked as 'beforefieldinit'.
			static Values()
			{
				Il2CppClassPointerStore<StylePropertyAnimationSystem.Values>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StylePropertyAnimationSystem>.NativeClassPtr, "Values");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StylePropertyAnimationSystem.Values>.NativeClassPtr);
				StylePropertyAnimationSystem.Values.NativeMethodInfoPtr_CancelAllAnimations_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyAnimationSystem.Values>.NativeClassPtr, 100668542);
				StylePropertyAnimationSystem.Values.NativeMethodInfoPtr_CancelAllAnimations_Public_Abstract_Virtual_New_Void_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyAnimationSystem.Values>.NativeClassPtr, 100668543);
				StylePropertyAnimationSystem.Values.NativeMethodInfoPtr_CancelAnimation_Public_Abstract_Virtual_New_Void_VisualElement_StylePropertyId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyAnimationSystem.Values>.NativeClassPtr, 100668544);
				StylePropertyAnimationSystem.Values.NativeMethodInfoPtr_UpdateAnimation_Public_Abstract_Virtual_New_Void_VisualElement_StylePropertyId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyAnimationSystem.Values>.NativeClassPtr, 100668545);
				StylePropertyAnimationSystem.Values.NativeMethodInfoPtr_GetAllAnimations_Public_Abstract_Virtual_New_Void_VisualElement_List_1_StylePropertyId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyAnimationSystem.Values>.NativeClassPtr, 100668546);
				StylePropertyAnimationSystem.Values.NativeMethodInfoPtr_Update_Public_Abstract_Virtual_New_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyAnimationSystem.Values>.NativeClassPtr, 100668547);
				StylePropertyAnimationSystem.Values.NativeMethodInfoPtr_UpdateValues_Protected_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyAnimationSystem.Values>.NativeClassPtr, 100668548);
				StylePropertyAnimationSystem.Values.NativeMethodInfoPtr_UpdateComputedStyle_Protected_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyAnimationSystem.Values>.NativeClassPtr, 100668549);
				StylePropertyAnimationSystem.Values.NativeMethodInfoPtr_UpdateComputedStyle_Protected_Abstract_Virtual_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyAnimationSystem.Values>.NativeClassPtr, 100668550);
				StylePropertyAnimationSystem.Values.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyAnimationSystem.Values>.NativeClassPtr, 100668551);
			}

			// Token: 0x06003E34 RID: 15924 RVA: 0x000F7EDC File Offset: 0x000F60DC
			[CallerCount(0)]
			public unsafe virtual void CancelAllAnimations()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StylePropertyAnimationSystem.Values.NativeMethodInfoPtr_CancelAllAnimations_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003E35 RID: 15925 RVA: 0x000F7F18 File Offset: 0x000F6118
			[CallerCount(0)]
			public unsafe virtual void CancelAllAnimations(VisualElement ve)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ve);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StylePropertyAnimationSystem.Values.NativeMethodInfoPtr_CancelAllAnimations_Public_Abstract_Virtual_New_Void_VisualElement_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003E36 RID: 15926 RVA: 0x000F7F68 File Offset: 0x000F6168
			[CallerCount(0)]
			public unsafe virtual void CancelAnimation(VisualElement ve, UnityEngine.UIElements.StyleSheets.StylePropertyId id)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ve);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StylePropertyAnimationSystem.Values.NativeMethodInfoPtr_CancelAnimation_Public_Abstract_Virtual_New_Void_VisualElement_StylePropertyId_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003E37 RID: 15927 RVA: 0x000F7FC4 File Offset: 0x000F61C4
			[CallerCount(0)]
			public unsafe virtual void UpdateAnimation(VisualElement ve, UnityEngine.UIElements.StyleSheets.StylePropertyId id)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ve);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StylePropertyAnimationSystem.Values.NativeMethodInfoPtr_UpdateAnimation_Public_Abstract_Virtual_New_Void_VisualElement_StylePropertyId_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003E38 RID: 15928 RVA: 0x000F8020 File Offset: 0x000F6220
			[CallerCount(0)]
			public unsafe virtual void GetAllAnimations(VisualElement ve, List<UnityEngine.UIElements.StyleSheets.StylePropertyId> outPropertyIds)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ve);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(outPropertyIds);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StylePropertyAnimationSystem.Values.NativeMethodInfoPtr_GetAllAnimations_Public_Abstract_Virtual_New_Void_VisualElement_List_1_StylePropertyId_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003E39 RID: 15929 RVA: 0x000F8080 File Offset: 0x000F6280
			[CallerCount(0)]
			public unsafe virtual void Update(long currentTimeMs)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref currentTimeMs;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StylePropertyAnimationSystem.Values.NativeMethodInfoPtr_Update_Public_Abstract_Virtual_New_Void_Int64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003E3A RID: 15930 RVA: 0x000F80CC File Offset: 0x000F62CC
			[CallerCount(0)]
			public unsafe virtual void UpdateValues()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StylePropertyAnimationSystem.Values.NativeMethodInfoPtr_UpdateValues_Protected_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003E3B RID: 15931 RVA: 0x000F8108 File Offset: 0x000F6308
			[CallerCount(0)]
			public unsafe virtual void UpdateComputedStyle()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StylePropertyAnimationSystem.Values.NativeMethodInfoPtr_UpdateComputedStyle_Protected_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003E3C RID: 15932 RVA: 0x000F8144 File Offset: 0x000F6344
			[CallerCount(0)]
			public unsafe virtual void UpdateComputedStyle(int i)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref i;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StylePropertyAnimationSystem.Values.NativeMethodInfoPtr_UpdateComputedStyle_Protected_Abstract_Virtual_New_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003E3D RID: 15933 RVA: 0x000F8190 File Offset: 0x000F6390
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Values()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StylePropertyAnimationSystem.Values>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyAnimationSystem.Values.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003E3E RID: 15934 RVA: 0x0001A350 File Offset: 0x00018550
			public Values(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04002BF6 RID: 11254
			private static readonly IntPtr NativeMethodInfoPtr_CancelAllAnimations_Public_Abstract_Virtual_New_Void_0;

			// Token: 0x04002BF7 RID: 11255
			private static readonly IntPtr NativeMethodInfoPtr_CancelAllAnimations_Public_Abstract_Virtual_New_Void_VisualElement_0;

			// Token: 0x04002BF8 RID: 11256
			private static readonly IntPtr NativeMethodInfoPtr_CancelAnimation_Public_Abstract_Virtual_New_Void_VisualElement_StylePropertyId_0;

			// Token: 0x04002BF9 RID: 11257
			private static readonly IntPtr NativeMethodInfoPtr_UpdateAnimation_Public_Abstract_Virtual_New_Void_VisualElement_StylePropertyId_0;

			// Token: 0x04002BFA RID: 11258
			private static readonly IntPtr NativeMethodInfoPtr_GetAllAnimations_Public_Abstract_Virtual_New_Void_VisualElement_List_1_StylePropertyId_0;

			// Token: 0x04002BFB RID: 11259
			private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Abstract_Virtual_New_Void_Int64_0;

			// Token: 0x04002BFC RID: 11260
			private static readonly IntPtr NativeMethodInfoPtr_UpdateValues_Protected_Abstract_Virtual_New_Void_0;

			// Token: 0x04002BFD RID: 11261
			private static readonly IntPtr NativeMethodInfoPtr_UpdateComputedStyle_Protected_Abstract_Virtual_New_Void_0;

			// Token: 0x04002BFE RID: 11262
			private static readonly IntPtr NativeMethodInfoPtr_UpdateComputedStyle_Protected_Abstract_Virtual_New_Void_Int32_0;

			// Token: 0x04002BFF RID: 11263
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
		}

		// Token: 0x020004C5 RID: 1221
		public class Values<T> : StylePropertyAnimationSystem.Values
		{
			// Token: 0x06003E3F RID: 15935 RVA: 0x000F81CC File Offset: 0x000F63CC
			// Note: this type is marked as 'beforefieldinit'.
			static Values()
			{
				Il2CppClassPointerStore<StylePropertyAnimationSystem.Values<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StylePropertyAnimationSystem>.NativeClassPtr, "Values`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StylePropertyAnimationSystem.Values<T>>.NativeClassPtr);
				StylePropertyAnimationSystem.Values<T>.NativeFieldInfoPtr_m_CurrentTimeMs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StylePropertyAnimationSystem.Values<T>>.NativeClassPtr, "m_CurrentTimeMs");
				StylePropertyAnimationSystem.Values<T>.NativeFieldInfoPtr_m_CurrentFrameEventsState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StylePropertyAnimationSystem.Values<T>>.NativeClassPtr, "m_CurrentFrameEventsState");
				StylePropertyAnimationSystem.Values<T>.NativeFieldInfoPtr_m_NextFrameEventsState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StylePropertyAnimationSystem.Values<T>>.NativeClassPtr, "m_NextFrameEventsState");
				StylePropertyAnimationSystem.Values<T>.NativeFieldInfoPtr_running = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StylePropertyAnimationSystem.Values<T>>.NativeClassPtr, "running");
				StylePropertyAnimationSystem.Values<T>.NativeFieldInfoPtr_completed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StylePropertyAnimationSystem.Values<T>>.NativeClassPtr, "completed");
				StylePropertyAnimationSystem.Values<T>.NativeMethodInfoPtr_get_isEmpty_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyAnimationSystem.Values<T>>.NativeClassPtr, 100668552);
				StylePropertyAnimationSystem.Values<T>.NativeMethodInfoPtr_get_SameFunc_Public_Abstract_Virtual_New_get_Func_3_T_T_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyAnimationSystem.Values<T>>.NativeClassPtr, 100668553);
				StylePropertyAnimationSystem.Values<T>.NativeMethodInfoPtr_ConvertUnits_Protected_Virtual_New_Boolean_VisualElement_StylePropertyId_byref_T_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyAnimationSystem.Values<T>>.NativeClassPtr, 100668554);
				StylePropertyAnimationSystem.Values<T>.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyAnimationSystem.Values<T>>.NativeClassPtr, 100668555);
				StylePropertyAnimationSystem.Values<T>.NativeMethodInfoPtr_SwapFrameStates_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyAnimationSystem.Values<T>>.NativeClassPtr, 100668556);
				StylePropertyAnimationSystem.Values<T>.NativeMethodInfoPtr_QueueEvent_Private_Void_EventBase_ElementPropertyPair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyAnimationSystem.Values<T>>.NativeClassPtr, 100668557);
				StylePropertyAnimationSystem.Values<T>.NativeMethodInfoPtr_ClearEventQueue_Private_Void_ElementPropertyPair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyAnimationSystem.Values<T>>.NativeClassPtr, 100668558);
				StylePropertyAnimationSystem.Values<T>.NativeMethodInfoPtr_QueueTransitionRunEvent_Private_Void_VisualElement_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyAnimationSystem.Values<T>>.NativeClassPtr, 100668559);
				StylePropertyAnimationSystem.Values<T>.NativeMethodInfoPtr_QueueTransitionStartEvent_Private_Void_VisualElement_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyAnimationSystem.Values<T>>.NativeClassPtr, 100668560);
				StylePropertyAnimationSystem.Values<T>.NativeMethodInfoPtr_QueueTransitionEndEvent_Private_Void_VisualElement_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyAnimationSystem.Values<T>>.NativeClassPtr, 100668561);
				StylePropertyAnimationSystem.Values<T>.NativeMethodInfoPtr_QueueTransitionCancelEvent_Private_Void_VisualElement_Int32_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyAnimationSystem.Values<T>>.NativeClassPtr, 100668562);
				StylePropertyAnimationSystem.Values<T>.NativeMethodInfoPtr_SendTransitionCancelEvent_Private_Void_VisualElement_Int32_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyAnimationSystem.Values<T>>.NativeClassPtr, 100668563);
				StylePropertyAnimationSystem.Values<T>.NativeMethodInfoPtr_CancelAllAnimations_Public_Virtual_Final_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyAnimationSystem.Values<T>>.NativeClassPtr, 100668564);
				StylePropertyAnimationSystem.Values<T>.NativeMethodInfoPtr_CancelAllAnimations_Public_Virtual_Final_Void_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyAnimationSystem.Values<T>>.NativeClassPtr, 100668565);
				StylePropertyAnimationSystem.Values<T>.NativeMethodInfoPtr_CancelAnimation_Public_Virtual_Final_Void_VisualElement_StylePropertyId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyAnimationSystem.Values<T>>.NativeClassPtr, 100668566);
				StylePropertyAnimationSystem.Values<T>.NativeMethodInfoPtr_UpdateAnimation_Public_Virtual_Final_Void_VisualElement_StylePropertyId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyAnimationSystem.Values<T>>.NativeClassPtr, 100668567);
				StylePropertyAnimationSystem.Values<T>.NativeMethodInfoPtr_GetAllAnimations_Public_Virtual_Final_Void_VisualElement_List_1_StylePropertyId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyAnimationSystem.Values<T>>.NativeClassPtr, 100668568);
				StylePropertyAnimationSystem.Values<T>.NativeMethodInfoPtr_ComputeReversingShorteningFactor_Private_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyAnimationSystem.Values<T>>.NativeClassPtr, 100668569);
				StylePropertyAnimationSystem.Values<T>.NativeMethodInfoPtr_ComputeReversingDuration_Private_Int32_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyAnimationSystem.Values<T>>.NativeClassPtr, 100668570);
				StylePropertyAnimationSystem.Values<T>.NativeMethodInfoPtr_ComputeReversingDelay_Private_Int32_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyAnimationSystem.Values<T>>.NativeClassPtr, 100668571);
				StylePropertyAnimationSystem.Values<T>.NativeMethodInfoPtr_StartTransition_Public_Boolean_VisualElement_StylePropertyId_T_T_Int32_Int32_Func_2_Single_Single_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyAnimationSystem.Values<T>>.NativeClassPtr, 100668572);
				StylePropertyAnimationSystem.Values<T>.NativeMethodInfoPtr_ForceComputedStyleEndValue_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyAnimationSystem.Values<T>>.NativeClassPtr, 100668573);
				StylePropertyAnimationSystem.Values<T>.NativeMethodInfoPtr_Update_Public_Virtual_Final_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyAnimationSystem.Values<T>>.NativeClassPtr, 100668574);
				StylePropertyAnimationSystem.Values<T>.NativeMethodInfoPtr_ProcessEventQueue_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyAnimationSystem.Values<T>>.NativeClassPtr, 100668575);
				StylePropertyAnimationSystem.Values<T>.NativeMethodInfoPtr_UpdateProgress_Private_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyAnimationSystem.Values<T>>.NativeClassPtr, 100668576);
			}

			// Token: 0x170012D7 RID: 4823
			// (get) Token: 0x06003E40 RID: 15936 RVA: 0x000F848C File Offset: 0x000F668C
			public unsafe bool isEmpty
			{
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 336492, RefRangeEnd = 336494, XrefRangeStart = 336492, XrefRangeEnd = 336492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyAnimationSystem.Values<T>.NativeMethodInfoPtr_get_isEmpty_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x170012D8 RID: 4824
			// (get) Token: 0x06003E41 RID: 15937 RVA: 0x000F84C8 File Offset: 0x000F66C8
			public unsafe virtual Func<T, T, bool> SameFunc
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StylePropertyAnimationSystem.Values<T>.NativeMethodInfoPtr_get_SameFunc_Public_Abstract_Virtual_New_get_Func_3_T_T_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Func<T, T, bool>>(intPtr3) : null;
				}
			}

			// Token: 0x06003E42 RID: 15938 RVA: 0x000F8514 File Offset: 0x000F6714
			[CallerCount(0)]
			public unsafe virtual bool ConvertUnits(VisualElement owner, UnityEngine.UIElements.StyleSheets.StylePropertyId prop, ref T a, ref T b)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(owner);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref prop;
				ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(a);
				ptr2 = &intPtr;
				ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
				IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr(b);
				ptr3 = &intPtr2;
				IntPtr intPtr4;
				IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StylePropertyAnimationSystem.Values<T>.NativeMethodInfoPtr_ConvertUnits_Protected_Virtual_New_Boolean_VisualElement_StylePropertyId_byref_T_byref_T_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
				Il2CppException.RaiseExceptionIfNecessary(intPtr4);
				IntPtr intPtr5 = intPtr;
				a = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr5, false, false));
				IntPtr intPtr6 = intPtr2;
				b = ((intPtr6 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr6, false, false));
				return *IL2CPP.il2cpp_object_unbox(intPtr3);
			}

			// Token: 0x06003E43 RID: 15939 RVA: 0x000F85D4 File Offset: 0x000F67D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 336494, XrefRangeEnd = 336511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Values()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StylePropertyAnimationSystem.Values<T>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyAnimationSystem.Values<T>.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003E44 RID: 15940 RVA: 0x000F8610 File Offset: 0x000F6810
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 336511, XrefRangeEnd = 336514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SwapFrameStates()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyAnimationSystem.Values<T>.NativeMethodInfoPtr_SwapFrameStates_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003E45 RID: 15941 RVA: 0x000F8644 File Offset: 0x000F6844
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 336514, XrefRangeEnd = 336530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void QueueEvent(EventBase evt, StylePropertyAnimationSystem.ElementPropertyPair epp)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(epp));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyAnimationSystem.Values<T>.NativeMethodInfoPtr_QueueEvent_Private_Void_EventBase_ElementPropertyPair_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003E46 RID: 15942 RVA: 0x000F86A0 File Offset: 0x000F68A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 336530, XrefRangeEnd = 336539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void ClearEventQueue(StylePropertyAnimationSystem.ElementPropertyPair epp)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(epp));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyAnimationSystem.Values<T>.NativeMethodInfoPtr_ClearEventQueue_Private_Void_ElementPropertyPair_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003E47 RID: 15943 RVA: 0x000F86E8 File Offset: 0x000F68E8
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 336559, RefRangeEnd = 336561, XrefRangeStart = 336539, XrefRangeEnd = 336559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void QueueTransitionRunEvent(VisualElement ve, int runningIndex)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ve);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref runningIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyAnimationSystem.Values<T>.NativeMethodInfoPtr_QueueTransitionRunEvent_Private_Void_VisualElement_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003E48 RID: 15944 RVA: 0x000F8738 File Offset: 0x000F6938
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 336581, RefRangeEnd = 336582, XrefRangeStart = 336561, XrefRangeEnd = 336581, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void QueueTransitionStartEvent(VisualElement ve, int runningIndex)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ve);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref runningIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyAnimationSystem.Values<T>.NativeMethodInfoPtr_QueueTransitionStartEvent_Private_Void_VisualElement_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003E49 RID: 15945 RVA: 0x000F8788 File Offset: 0x000F6988
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 336602, RefRangeEnd = 336603, XrefRangeStart = 336582, XrefRangeEnd = 336602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void QueueTransitionEndEvent(VisualElement ve, int runningIndex)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ve);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref runningIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyAnimationSystem.Values<T>.NativeMethodInfoPtr_QueueTransitionEndEvent_Private_Void_VisualElement_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003E4A RID: 15946 RVA: 0x000F87D8 File Offset: 0x000F69D8
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 336620, RefRangeEnd = 336623, XrefRangeStart = 336603, XrefRangeEnd = 336620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void QueueTransitionCancelEvent(VisualElement ve, int runningIndex, long panelElapsedMs)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ve);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref runningIndex;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref panelElapsedMs;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyAnimationSystem.Values<T>.NativeMethodInfoPtr_QueueTransitionCancelEvent_Private_Void_VisualElement_Int32_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003E4B RID: 15947 RVA: 0x000F8838 File Offset: 0x000F6A38
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 336640, RefRangeEnd = 336642, XrefRangeStart = 336623, XrefRangeEnd = 336640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SendTransitionCancelEvent(VisualElement ve, int runningIndex, long panelElapsedMs)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ve);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref runningIndex;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref panelElapsedMs;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyAnimationSystem.Values<T>.NativeMethodInfoPtr_SendTransitionCancelEvent_Private_Void_VisualElement_Int32_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003E4C RID: 15948 RVA: 0x000F8898 File Offset: 0x000F6A98
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 336642, XrefRangeEnd = 336668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void CancelAllAnimations()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyAnimationSystem.Values<T>.NativeMethodInfoPtr_CancelAllAnimations_Public_Virtual_Final_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003E4D RID: 15949 RVA: 0x000F88CC File Offset: 0x000F6ACC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 336668, XrefRangeEnd = 336692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void CancelAllAnimations(VisualElement ve)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ve);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyAnimationSystem.Values<T>.NativeMethodInfoPtr_CancelAllAnimations_Public_Virtual_Final_Void_VisualElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003E4E RID: 15950 RVA: 0x000F8910 File Offset: 0x000F6B10
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 336692, XrefRangeEnd = 336709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void CancelAnimation(VisualElement ve, UnityEngine.UIElements.StyleSheets.StylePropertyId id)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ve);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyAnimationSystem.Values<T>.NativeMethodInfoPtr_CancelAnimation_Public_Virtual_Final_Void_VisualElement_StylePropertyId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003E4F RID: 15951 RVA: 0x000F8960 File Offset: 0x000F6B60
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 336709, XrefRangeEnd = 336710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void UpdateAnimation(VisualElement ve, UnityEngine.UIElements.StyleSheets.StylePropertyId id)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ve);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyAnimationSystem.Values<T>.NativeMethodInfoPtr_UpdateAnimation_Public_Virtual_Final_Void_VisualElement_StylePropertyId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003E50 RID: 15952 RVA: 0x000F89B0 File Offset: 0x000F6BB0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 336710, XrefRangeEnd = 336747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void GetAllAnimations(VisualElement ve, List<UnityEngine.UIElements.StyleSheets.StylePropertyId> outPropertyIds)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ve);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(outPropertyIds);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyAnimationSystem.Values<T>.NativeMethodInfoPtr_GetAllAnimations_Public_Virtual_Final_Void_VisualElement_List_1_StylePropertyId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003E51 RID: 15953 RVA: 0x000F8A04 File Offset: 0x000F6C04
			[CallerCount(0)]
			public unsafe float ComputeReversingShorteningFactor(int oldIndex)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref oldIndex;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyAnimationSystem.Values<T>.NativeMethodInfoPtr_ComputeReversingShorteningFactor_Private_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06003E52 RID: 15954 RVA: 0x000F8A50 File Offset: 0x000F6C50
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 336747, XrefRangeEnd = 336748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int ComputeReversingDuration(int newTransitionDurationMs, float newReversingShorteningFactor)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref newTransitionDurationMs;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newReversingShorteningFactor;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyAnimationSystem.Values<T>.NativeMethodInfoPtr_ComputeReversingDuration_Private_Int32_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06003E53 RID: 15955 RVA: 0x000F8AA8 File Offset: 0x000F6CA8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 336748, XrefRangeEnd = 336749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int ComputeReversingDelay(int delayMs, float newReversingShorteningFactor)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref delayMs;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newReversingShorteningFactor;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyAnimationSystem.Values<T>.NativeMethodInfoPtr_ComputeReversingDelay_Private_Int32_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06003E54 RID: 15956 RVA: 0x000F8B00 File Offset: 0x000F6D00
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 336789, RefRangeEnd = 336790, XrefRangeStart = 336749, XrefRangeEnd = 336789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool StartTransition(VisualElement owner, UnityEngine.UIElements.StyleSheets.StylePropertyId prop, T startValue, T endValue, int durationMs, int delayMs, Func<float, float> easingCurve, long currentTimeMs)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(owner);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref prop;
				ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = startValue;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref startValue;
				}
				ptr2 = intPtr;
				ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
				IntPtr intPtr2;
				if (!typeof(T).IsValueType)
				{
					T t2 = endValue;
					intPtr2 = ((t2 is string) ? IL2CPP.ManagedStringToIl2Cpp(t2 as string) : IL2CPP.Il2CppObjectBaseToPtr(t2 as Il2CppObjectBase));
				}
				else
				{
					intPtr2 = ref endValue;
				}
				ptr3 = intPtr2;
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref durationMs;
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref delayMs;
				ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(easingCurve);
				ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref currentTimeMs;
				IntPtr intPtr4;
				IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(StylePropertyAnimationSystem.Values<T>.NativeMethodInfoPtr_StartTransition_Public_Boolean_VisualElement_StylePropertyId_T_T_Int32_Int32_Func_2_Single_Single_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
				Il2CppException.RaiseExceptionIfNecessary(intPtr4);
				return *IL2CPP.il2cpp_object_unbox(intPtr3);
			}

			// Token: 0x06003E55 RID: 15957 RVA: 0x000F8C2C File Offset: 0x000F6E2C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 336790, XrefRangeEnd = 336795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void ForceComputedStyleEndValue(int runningIndex)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref runningIndex;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyAnimationSystem.Values<T>.NativeMethodInfoPtr_ForceComputedStyleEndValue_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003E56 RID: 15958 RVA: 0x000F8C6C File Offset: 0x000F6E6C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 336795, XrefRangeEnd = 336798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Update(long currentTimeMs)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref currentTimeMs;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyAnimationSystem.Values<T>.NativeMethodInfoPtr_Update_Public_Virtual_Final_Void_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003E57 RID: 15959 RVA: 0x000F8CAC File Offset: 0x000F6EAC
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 336829, RefRangeEnd = 336830, XrefRangeStart = 336798, XrefRangeEnd = 336829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void ProcessEventQueue()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyAnimationSystem.Values<T>.NativeMethodInfoPtr_ProcessEventQueue_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003E58 RID: 15960 RVA: 0x000F8CE0 File Offset: 0x000F6EE0
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 336851, RefRangeEnd = 336852, XrefRangeStart = 336830, XrefRangeEnd = 336851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void UpdateProgress(long currentTimeMs)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref currentTimeMs;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyAnimationSystem.Values<T>.NativeMethodInfoPtr_UpdateProgress_Private_Void_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003E59 RID: 15961 RVA: 0x0001A359 File Offset: 0x00018559
			public Values(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170012D2 RID: 4818
			// (get) Token: 0x06003E5A RID: 15962 RVA: 0x000F8D20 File Offset: 0x000F6F20
			// (set) Token: 0x06003E5B RID: 15963 RVA: 0x0001A362 File Offset: 0x00018562
			public unsafe long m_CurrentTimeMs
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StylePropertyAnimationSystem.Values<T>.NativeFieldInfoPtr_m_CurrentTimeMs);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StylePropertyAnimationSystem.Values<T>.NativeFieldInfoPtr_m_CurrentTimeMs)) = value;
				}
			}

			// Token: 0x170012D3 RID: 4819
			// (get) Token: 0x06003E5C RID: 15964 RVA: 0x000F8D48 File Offset: 0x000F6F48
			// (set) Token: 0x06003E5D RID: 15965 RVA: 0x0001A37D File Offset: 0x0001857D
			public unsafe StylePropertyAnimationSystem.Values<T>.TransitionEventsFrameState m_CurrentFrameEventsState
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StylePropertyAnimationSystem.Values<T>.NativeFieldInfoPtr_m_CurrentFrameEventsState);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<StylePropertyAnimationSystem.Values<T>.TransitionEventsFrameState>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StylePropertyAnimationSystem.Values<T>.NativeFieldInfoPtr_m_CurrentFrameEventsState), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170012D4 RID: 4820
			// (get) Token: 0x06003E5E RID: 15966 RVA: 0x000F8D78 File Offset: 0x000F6F78
			// (set) Token: 0x06003E5F RID: 15967 RVA: 0x0001A39C File Offset: 0x0001859C
			public unsafe StylePropertyAnimationSystem.Values<T>.TransitionEventsFrameState m_NextFrameEventsState
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StylePropertyAnimationSystem.Values<T>.NativeFieldInfoPtr_m_NextFrameEventsState);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<StylePropertyAnimationSystem.Values<T>.TransitionEventsFrameState>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StylePropertyAnimationSystem.Values<T>.NativeFieldInfoPtr_m_NextFrameEventsState), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170012D5 RID: 4821
			// (get) Token: 0x06003E60 RID: 15968 RVA: 0x000F8DA8 File Offset: 0x000F6FA8
			// (set) Token: 0x06003E61 RID: 15969 RVA: 0x0001A3BB File Offset: 0x000185BB
			public StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values<T>.TimingData, StylePropertyAnimationSystem.Values<T>.StyleData> running
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StylePropertyAnimationSystem.Values<T>.NativeFieldInfoPtr_running);
					return new StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values<T>.TimingData, StylePropertyAnimationSystem.Values<T>.StyleData>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values<T>.TimingData, StylePropertyAnimationSystem.Values<T>.StyleData>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StylePropertyAnimationSystem.Values<T>.NativeFieldInfoPtr_running), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values<T>.TimingData, StylePropertyAnimationSystem.Values<T>.StyleData>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170012D6 RID: 4822
			// (get) Token: 0x06003E62 RID: 15970 RVA: 0x000F8DD8 File Offset: 0x000F6FD8
			// (set) Token: 0x06003E63 RID: 15971 RVA: 0x0001A3E9 File Offset: 0x000185E9
			public StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values<T>.EmptyData, T> completed
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StylePropertyAnimationSystem.Values<T>.NativeFieldInfoPtr_completed);
					return new StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values<T>.EmptyData, T>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values<T>.EmptyData, T>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StylePropertyAnimationSystem.Values<T>.NativeFieldInfoPtr_completed), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values<T>.EmptyData, T>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04002C00 RID: 11264
			private static readonly IntPtr NativeFieldInfoPtr_m_CurrentTimeMs;

			// Token: 0x04002C01 RID: 11265
			private static readonly IntPtr NativeFieldInfoPtr_m_CurrentFrameEventsState;

			// Token: 0x04002C02 RID: 11266
			private static readonly IntPtr NativeFieldInfoPtr_m_NextFrameEventsState;

			// Token: 0x04002C03 RID: 11267
			private static readonly IntPtr NativeFieldInfoPtr_running;

			// Token: 0x04002C04 RID: 11268
			private static readonly IntPtr NativeFieldInfoPtr_completed;

			// Token: 0x04002C05 RID: 11269
			private static readonly IntPtr NativeMethodInfoPtr_get_isEmpty_Public_get_Boolean_0;

			// Token: 0x04002C06 RID: 11270
			private static readonly IntPtr NativeMethodInfoPtr_get_SameFunc_Public_Abstract_Virtual_New_get_Func_3_T_T_Boolean_0;

			// Token: 0x04002C07 RID: 11271
			private static readonly IntPtr NativeMethodInfoPtr_ConvertUnits_Protected_Virtual_New_Boolean_VisualElement_StylePropertyId_byref_T_byref_T_0;

			// Token: 0x04002C08 RID: 11272
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

			// Token: 0x04002C09 RID: 11273
			private static readonly IntPtr NativeMethodInfoPtr_SwapFrameStates_Private_Void_0;

			// Token: 0x04002C0A RID: 11274
			private static readonly IntPtr NativeMethodInfoPtr_QueueEvent_Private_Void_EventBase_ElementPropertyPair_0;

			// Token: 0x04002C0B RID: 11275
			private static readonly IntPtr NativeMethodInfoPtr_ClearEventQueue_Private_Void_ElementPropertyPair_0;

			// Token: 0x04002C0C RID: 11276
			private static readonly IntPtr NativeMethodInfoPtr_QueueTransitionRunEvent_Private_Void_VisualElement_Int32_0;

			// Token: 0x04002C0D RID: 11277
			private static readonly IntPtr NativeMethodInfoPtr_QueueTransitionStartEvent_Private_Void_VisualElement_Int32_0;

			// Token: 0x04002C0E RID: 11278
			private static readonly IntPtr NativeMethodInfoPtr_QueueTransitionEndEvent_Private_Void_VisualElement_Int32_0;

			// Token: 0x04002C0F RID: 11279
			private static readonly IntPtr NativeMethodInfoPtr_QueueTransitionCancelEvent_Private_Void_VisualElement_Int32_Int64_0;

			// Token: 0x04002C10 RID: 11280
			private static readonly IntPtr NativeMethodInfoPtr_SendTransitionCancelEvent_Private_Void_VisualElement_Int32_Int64_0;

			// Token: 0x04002C11 RID: 11281
			private static readonly IntPtr NativeMethodInfoPtr_CancelAllAnimations_Public_Virtual_Final_Void_0;

			// Token: 0x04002C12 RID: 11282
			private static readonly IntPtr NativeMethodInfoPtr_CancelAllAnimations_Public_Virtual_Final_Void_VisualElement_0;

			// Token: 0x04002C13 RID: 11283
			private static readonly IntPtr NativeMethodInfoPtr_CancelAnimation_Public_Virtual_Final_Void_VisualElement_StylePropertyId_0;

			// Token: 0x04002C14 RID: 11284
			private static readonly IntPtr NativeMethodInfoPtr_UpdateAnimation_Public_Virtual_Final_Void_VisualElement_StylePropertyId_0;

			// Token: 0x04002C15 RID: 11285
			private static readonly IntPtr NativeMethodInfoPtr_GetAllAnimations_Public_Virtual_Final_Void_VisualElement_List_1_StylePropertyId_0;

			// Token: 0x04002C16 RID: 11286
			private static readonly IntPtr NativeMethodInfoPtr_ComputeReversingShorteningFactor_Private_Single_Int32_0;

			// Token: 0x04002C17 RID: 11287
			private static readonly IntPtr NativeMethodInfoPtr_ComputeReversingDuration_Private_Int32_Int32_Single_0;

			// Token: 0x04002C18 RID: 11288
			private static readonly IntPtr NativeMethodInfoPtr_ComputeReversingDelay_Private_Int32_Int32_Single_0;

			// Token: 0x04002C19 RID: 11289
			private static readonly IntPtr NativeMethodInfoPtr_StartTransition_Public_Boolean_VisualElement_StylePropertyId_T_T_Int32_Int32_Func_2_Single_Single_Int64_0;

			// Token: 0x04002C1A RID: 11290
			private static readonly IntPtr NativeMethodInfoPtr_ForceComputedStyleEndValue_Private_Void_Int32_0;

			// Token: 0x04002C1B RID: 11291
			private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Virtual_Final_Void_Int64_0;

			// Token: 0x04002C1C RID: 11292
			private static readonly IntPtr NativeMethodInfoPtr_ProcessEventQueue_Private_Void_0;

			// Token: 0x04002C1D RID: 11293
			private static readonly IntPtr NativeMethodInfoPtr_UpdateProgress_Private_Void_Int64_0;

			// Token: 0x02000597 RID: 1431
			public class TransitionEventsFrameState : Object
			{
				// Token: 0x060042C8 RID: 17096 RVA: 0x00105BB0 File Offset: 0x00103DB0
				// Note: this type is marked as 'beforefieldinit'.
				static TransitionEventsFrameState()
				{
					Il2CppClassPointerStore<StylePropertyAnimationSystem.Values<T>.TransitionEventsFrameState>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StylePropertyAnimationSystem.Values<T>>.NativeClassPtr, "TransitionEventsFrameState"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StylePropertyAnimationSystem.Values<T>.TransitionEventsFrameState>.NativeClassPtr);
					StylePropertyAnimationSystem.Values<T>.TransitionEventsFrameState.NativeFieldInfoPtr_k_EventQueuePool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StylePropertyAnimationSystem.Values<T>.TransitionEventsFrameState>.NativeClassPtr, "k_EventQueuePool");
					StylePropertyAnimationSystem.Values<T>.TransitionEventsFrameState.NativeFieldInfoPtr_elementPropertyStateDelta = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StylePropertyAnimationSystem.Values<T>.TransitionEventsFrameState>.NativeClassPtr, "elementPropertyStateDelta");
					StylePropertyAnimationSystem.Values<T>.TransitionEventsFrameState.NativeFieldInfoPtr_elementPropertyQueuedEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StylePropertyAnimationSystem.Values<T>.TransitionEventsFrameState>.NativeClassPtr, "elementPropertyQueuedEvents");
					StylePropertyAnimationSystem.Values<T>.TransitionEventsFrameState.NativeFieldInfoPtr_panel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StylePropertyAnimationSystem.Values<T>.TransitionEventsFrameState>.NativeClassPtr, "panel");
					StylePropertyAnimationSystem.Values<T>.TransitionEventsFrameState.NativeFieldInfoPtr_m_ChangesCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StylePropertyAnimationSystem.Values<T>.TransitionEventsFrameState>.NativeClassPtr, "m_ChangesCount");
					StylePropertyAnimationSystem.Values<T>.TransitionEventsFrameState.NativeMethodInfoPtr_GetPooledQueue_Public_Static_Queue_1_EventBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyAnimationSystem.Values<T>.TransitionEventsFrameState>.NativeClassPtr, 100668577);
					StylePropertyAnimationSystem.Values<T>.TransitionEventsFrameState.NativeMethodInfoPtr_RegisterChange_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyAnimationSystem.Values<T>.TransitionEventsFrameState>.NativeClassPtr, 100668578);
					StylePropertyAnimationSystem.Values<T>.TransitionEventsFrameState.NativeMethodInfoPtr_UnregisterChange_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyAnimationSystem.Values<T>.TransitionEventsFrameState>.NativeClassPtr, 100668579);
					StylePropertyAnimationSystem.Values<T>.TransitionEventsFrameState.NativeMethodInfoPtr_StateChanged_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyAnimationSystem.Values<T>.TransitionEventsFrameState>.NativeClassPtr, 100668580);
					StylePropertyAnimationSystem.Values<T>.TransitionEventsFrameState.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyAnimationSystem.Values<T>.TransitionEventsFrameState>.NativeClassPtr, 100668581);
					StylePropertyAnimationSystem.Values<T>.TransitionEventsFrameState.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyAnimationSystem.Values<T>.TransitionEventsFrameState>.NativeClassPtr, 100668582);
				}

				// Token: 0x060042C9 RID: 17097 RVA: 0x00105CF4 File Offset: 0x00103EF4
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 336298, RefRangeEnd = 336299, XrefRangeStart = 336289, XrefRangeEnd = 336298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe static Queue<EventBase> GetPooledQueue()
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyAnimationSystem.Values<T>.TransitionEventsFrameState.NativeMethodInfoPtr_GetPooledQueue_Public_Static_Queue_1_EventBase_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Queue<EventBase>>(intPtr3) : null;
				}

				// Token: 0x060042CA RID: 17098 RVA: 0x00105D28 File Offset: 0x00103F28
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 336299, RefRangeEnd = 336300, XrefRangeStart = 336299, XrefRangeEnd = 336299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void RegisterChange()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyAnimationSystem.Values<T>.TransitionEventsFrameState.NativeMethodInfoPtr_RegisterChange_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060042CB RID: 17099 RVA: 0x00105D5C File Offset: 0x00103F5C
				[CallerCount(4)]
				[CachedScanResults(RefRangeStart = 336300, RefRangeEnd = 336304, XrefRangeStart = 336300, XrefRangeEnd = 336300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void UnregisterChange()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyAnimationSystem.Values<T>.TransitionEventsFrameState.NativeMethodInfoPtr_UnregisterChange_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060042CC RID: 17100 RVA: 0x00105D90 File Offset: 0x00103F90
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 336304, RefRangeEnd = 336305, XrefRangeStart = 336304, XrefRangeEnd = 336304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool StateChanged()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyAnimationSystem.Values<T>.TransitionEventsFrameState.NativeMethodInfoPtr_StateChanged_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x060042CD RID: 17101 RVA: 0x00105DCC File Offset: 0x00103FCC
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 336336, RefRangeEnd = 336337, XrefRangeStart = 336305, XrefRangeEnd = 336336, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void Clear()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyAnimationSystem.Values<T>.TransitionEventsFrameState.NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060042CE RID: 17102 RVA: 0x00105E00 File Offset: 0x00104000
				[CallerCount(4)]
				[CachedScanResults(RefRangeStart = 336488, RefRangeEnd = 336492, XrefRangeStart = 336337, XrefRangeEnd = 336488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe TransitionEventsFrameState()
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StylePropertyAnimationSystem.Values<T>.TransitionEventsFrameState>.NativeClassPtr))
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyAnimationSystem.Values<T>.TransitionEventsFrameState.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060042CF RID: 17103 RVA: 0x0001C817 File Offset: 0x0001AA17
				public TransitionEventsFrameState(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x170013F7 RID: 5111
				// (get) Token: 0x060042D0 RID: 17104 RVA: 0x00105E3C File Offset: 0x0010403C
				// (set) Token: 0x060042D1 RID: 17105 RVA: 0x0001C820 File Offset: 0x0001AA20
				public unsafe static ObjectPool<Queue<EventBase>> k_EventQueuePool
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(StylePropertyAnimationSystem.Values<T>.TransitionEventsFrameState.NativeFieldInfoPtr_k_EventQueuePool, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectPool<Queue<EventBase>>>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(StylePropertyAnimationSystem.Values<T>.TransitionEventsFrameState.NativeFieldInfoPtr_k_EventQueuePool, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170013F8 RID: 5112
				// (get) Token: 0x060042D2 RID: 17106 RVA: 0x00105E64 File Offset: 0x00104064
				// (set) Token: 0x060042D3 RID: 17107 RVA: 0x0001C832 File Offset: 0x0001AA32
				public unsafe Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, StylePropertyAnimationSystem.TransitionState> elementPropertyStateDelta
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StylePropertyAnimationSystem.Values<T>.TransitionEventsFrameState.NativeFieldInfoPtr_elementPropertyStateDelta);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, StylePropertyAnimationSystem.TransitionState>>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StylePropertyAnimationSystem.Values<T>.TransitionEventsFrameState.NativeFieldInfoPtr_elementPropertyStateDelta), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170013F9 RID: 5113
				// (get) Token: 0x060042D4 RID: 17108 RVA: 0x00105E94 File Offset: 0x00104094
				// (set) Token: 0x060042D5 RID: 17109 RVA: 0x0001C851 File Offset: 0x0001AA51
				public unsafe Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, Queue<EventBase>> elementPropertyQueuedEvents
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StylePropertyAnimationSystem.Values<T>.TransitionEventsFrameState.NativeFieldInfoPtr_elementPropertyQueuedEvents);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, Queue<EventBase>>>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StylePropertyAnimationSystem.Values<T>.TransitionEventsFrameState.NativeFieldInfoPtr_elementPropertyQueuedEvents), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170013FA RID: 5114
				// (get) Token: 0x060042D6 RID: 17110 RVA: 0x00105EC4 File Offset: 0x001040C4
				// (set) Token: 0x060042D7 RID: 17111 RVA: 0x0001C870 File Offset: 0x0001AA70
				public unsafe IPanel panel
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StylePropertyAnimationSystem.Values<T>.TransitionEventsFrameState.NativeFieldInfoPtr_panel);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<IPanel>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StylePropertyAnimationSystem.Values<T>.TransitionEventsFrameState.NativeFieldInfoPtr_panel), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170013FB RID: 5115
				// (get) Token: 0x060042D8 RID: 17112 RVA: 0x00105EF4 File Offset: 0x001040F4
				// (set) Token: 0x060042D9 RID: 17113 RVA: 0x0001C88F File Offset: 0x0001AA8F
				public unsafe int m_ChangesCount
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StylePropertyAnimationSystem.Values<T>.TransitionEventsFrameState.NativeFieldInfoPtr_m_ChangesCount);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StylePropertyAnimationSystem.Values<T>.TransitionEventsFrameState.NativeFieldInfoPtr_m_ChangesCount)) = value;
					}
				}

				// Token: 0x04002EC1 RID: 11969
				private static readonly IntPtr NativeFieldInfoPtr_k_EventQueuePool;

				// Token: 0x04002EC2 RID: 11970
				private static readonly IntPtr NativeFieldInfoPtr_elementPropertyStateDelta;

				// Token: 0x04002EC3 RID: 11971
				private static readonly IntPtr NativeFieldInfoPtr_elementPropertyQueuedEvents;

				// Token: 0x04002EC4 RID: 11972
				private static readonly IntPtr NativeFieldInfoPtr_panel;

				// Token: 0x04002EC5 RID: 11973
				private static readonly IntPtr NativeFieldInfoPtr_m_ChangesCount;

				// Token: 0x04002EC6 RID: 11974
				private static readonly IntPtr NativeMethodInfoPtr_GetPooledQueue_Public_Static_Queue_1_EventBase_0;

				// Token: 0x04002EC7 RID: 11975
				private static readonly IntPtr NativeMethodInfoPtr_RegisterChange_Public_Void_0;

				// Token: 0x04002EC8 RID: 11976
				private static readonly IntPtr NativeMethodInfoPtr_UnregisterChange_Public_Void_0;

				// Token: 0x04002EC9 RID: 11977
				private static readonly IntPtr NativeMethodInfoPtr_StateChanged_Public_Boolean_0;

				// Token: 0x04002ECA RID: 11978
				private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

				// Token: 0x04002ECB RID: 11979
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

				// Token: 0x020005A1 RID: 1441
				[ObfuscatedName("UnityEngine.UIElements.StylePropertyAnimationSystem+Values`1+TransitionEventsFrameState+<>c")]
				[Serializable]
				public sealed class __c : Object
				{
					// Token: 0x06004314 RID: 17172 RVA: 0x0010695C File Offset: 0x00104B5C
					// Note: this type is marked as 'beforefieldinit'.
					static __c()
					{
						Il2CppClassPointerStore<StylePropertyAnimationSystem.Values<T>.TransitionEventsFrameState.__c>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StylePropertyAnimationSystem.Values<T>.TransitionEventsFrameState>.NativeClassPtr, "<>c"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
						IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StylePropertyAnimationSystem.Values<T>.TransitionEventsFrameState.__c>.NativeClassPtr);
						StylePropertyAnimationSystem.Values<T>.TransitionEventsFrameState.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StylePropertyAnimationSystem.Values<T>.TransitionEventsFrameState.__c>.NativeClassPtr, "<>9");
						StylePropertyAnimationSystem.Values<T>.TransitionEventsFrameState.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyAnimationSystem.Values<T>.TransitionEventsFrameState.__c>.NativeClassPtr, 100668585);
						StylePropertyAnimationSystem.Values<T>.TransitionEventsFrameState.__c.NativeMethodInfoPtr___cctor_b__11_0_Internal_Queue_1_EventBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyAnimationSystem.Values<T>.TransitionEventsFrameState.__c>.NativeClassPtr, 100668586);
					}

					// Token: 0x06004315 RID: 17173 RVA: 0x00106A00 File Offset: 0x00104C00
					[CallerCount(2676)]
					[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					public unsafe __c()
						: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StylePropertyAnimationSystem.Values<T>.TransitionEventsFrameState.__c>.NativeClassPtr))
					{
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyAnimationSystem.Values<T>.TransitionEventsFrameState.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}

					// Token: 0x06004316 RID: 17174 RVA: 0x00106A3C File Offset: 0x00104C3C
					[CallerCount(0)]
					[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 336283, XrefRangeEnd = 336289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					public unsafe Queue<EventBase> __cctor_b__11_0()
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyAnimationSystem.Values<T>.TransitionEventsFrameState.__c.NativeMethodInfoPtr___cctor_b__11_0_Internal_Queue_1_EventBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Queue<EventBase>>(intPtr3) : null;
					}

					// Token: 0x06004317 RID: 17175 RVA: 0x0001CAED File Offset: 0x0001ACED
					public __c(IntPtr pointer)
						: base(pointer)
					{
					}

					// Token: 0x1700140F RID: 5135
					// (get) Token: 0x06004318 RID: 17176 RVA: 0x00106A7C File Offset: 0x00104C7C
					// (set) Token: 0x06004319 RID: 17177 RVA: 0x0001CAF6 File Offset: 0x0001ACF6
					public unsafe static StylePropertyAnimationSystem.Values<T>.TransitionEventsFrameState.__c __9
					{
						get
						{
							IntPtr intPtr;
							IL2CPP.il2cpp_field_static_get_value(StylePropertyAnimationSystem.Values<T>.TransitionEventsFrameState.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
							IntPtr intPtr2 = intPtr;
							return (intPtr2 != 0) ? Il2CppObjectPool.Get<StylePropertyAnimationSystem.Values<T>.TransitionEventsFrameState.__c>(intPtr2) : null;
						}
						set
						{
							IL2CPP.il2cpp_field_static_set_value(StylePropertyAnimationSystem.Values<T>.TransitionEventsFrameState.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
						}
					}

					// Token: 0x04002EE3 RID: 12003
					private static readonly IntPtr NativeFieldInfoPtr___9;

					// Token: 0x04002EE4 RID: 12004
					private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

					// Token: 0x04002EE5 RID: 12005
					private static readonly IntPtr NativeMethodInfoPtr___cctor_b__11_0_Internal_Queue_1_EventBase_0;
				}
			}

			// Token: 0x02000598 RID: 1432
			public sealed class TimingData : ValueType
			{
				// Token: 0x060042DA RID: 17114 RVA: 0x00105F1C File Offset: 0x0010411C
				// Note: this type is marked as 'beforefieldinit'.
				static TimingData()
				{
					Il2CppClassPointerStore<StylePropertyAnimationSystem.Values<T>.TimingData>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StylePropertyAnimationSystem.Values<T>>.NativeClassPtr, "TimingData"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StylePropertyAnimationSystem.Values<T>.TimingData>.NativeClassPtr);
					StylePropertyAnimationSystem.Values<T>.TimingData.NativeFieldInfoPtr_startTimeMs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StylePropertyAnimationSystem.Values<T>.TimingData>.NativeClassPtr, "startTimeMs");
					StylePropertyAnimationSystem.Values<T>.TimingData.NativeFieldInfoPtr_durationMs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StylePropertyAnimationSystem.Values<T>.TimingData>.NativeClassPtr, "durationMs");
					StylePropertyAnimationSystem.Values<T>.TimingData.NativeFieldInfoPtr_easingCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StylePropertyAnimationSystem.Values<T>.TimingData>.NativeClassPtr, "easingCurve");
					StylePropertyAnimationSystem.Values<T>.TimingData.NativeFieldInfoPtr_easedProgress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StylePropertyAnimationSystem.Values<T>.TimingData>.NativeClassPtr, "easedProgress");
					StylePropertyAnimationSystem.Values<T>.TimingData.NativeFieldInfoPtr_reversingShorteningFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StylePropertyAnimationSystem.Values<T>.TimingData>.NativeClassPtr, "reversingShorteningFactor");
					StylePropertyAnimationSystem.Values<T>.TimingData.NativeFieldInfoPtr_isStarted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StylePropertyAnimationSystem.Values<T>.TimingData>.NativeClassPtr, "isStarted");
					StylePropertyAnimationSystem.Values<T>.TimingData.NativeFieldInfoPtr_delayMs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StylePropertyAnimationSystem.Values<T>.TimingData>.NativeClassPtr, "delayMs");
				}

				// Token: 0x060042DB RID: 17115 RVA: 0x0001C8AA File Offset: 0x0001AAAA
				public TimingData(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x060042DC RID: 17116 RVA: 0x0001C8B3 File Offset: 0x0001AAB3
				public TimingData()
					: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StylePropertyAnimationSystem.Values<T>.TimingData>.NativeClassPtr))
				{
				}

				// Token: 0x170013FC RID: 5116
				// (get) Token: 0x060042DD RID: 17117 RVA: 0x00106010 File Offset: 0x00104210
				// (set) Token: 0x060042DE RID: 17118 RVA: 0x0001C8C5 File Offset: 0x0001AAC5
				public unsafe long startTimeMs
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StylePropertyAnimationSystem.Values<T>.TimingData.NativeFieldInfoPtr_startTimeMs);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StylePropertyAnimationSystem.Values<T>.TimingData.NativeFieldInfoPtr_startTimeMs)) = value;
					}
				}

				// Token: 0x170013FD RID: 5117
				// (get) Token: 0x060042DF RID: 17119 RVA: 0x00106038 File Offset: 0x00104238
				// (set) Token: 0x060042E0 RID: 17120 RVA: 0x0001C8E0 File Offset: 0x0001AAE0
				public unsafe int durationMs
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StylePropertyAnimationSystem.Values<T>.TimingData.NativeFieldInfoPtr_durationMs);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StylePropertyAnimationSystem.Values<T>.TimingData.NativeFieldInfoPtr_durationMs)) = value;
					}
				}

				// Token: 0x170013FE RID: 5118
				// (get) Token: 0x060042E1 RID: 17121 RVA: 0x00106060 File Offset: 0x00104260
				// (set) Token: 0x060042E2 RID: 17122 RVA: 0x0001C8FB File Offset: 0x0001AAFB
				public unsafe Func<float, float> easingCurve
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StylePropertyAnimationSystem.Values<T>.TimingData.NativeFieldInfoPtr_easingCurve);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<float, float>>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StylePropertyAnimationSystem.Values<T>.TimingData.NativeFieldInfoPtr_easingCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170013FF RID: 5119
				// (get) Token: 0x060042E3 RID: 17123 RVA: 0x00106090 File Offset: 0x00104290
				// (set) Token: 0x060042E4 RID: 17124 RVA: 0x0001C91A File Offset: 0x0001AB1A
				public unsafe float easedProgress
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StylePropertyAnimationSystem.Values<T>.TimingData.NativeFieldInfoPtr_easedProgress);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StylePropertyAnimationSystem.Values<T>.TimingData.NativeFieldInfoPtr_easedProgress)) = value;
					}
				}

				// Token: 0x17001400 RID: 5120
				// (get) Token: 0x060042E5 RID: 17125 RVA: 0x001060B8 File Offset: 0x001042B8
				// (set) Token: 0x060042E6 RID: 17126 RVA: 0x0001C935 File Offset: 0x0001AB35
				public unsafe float reversingShorteningFactor
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StylePropertyAnimationSystem.Values<T>.TimingData.NativeFieldInfoPtr_reversingShorteningFactor);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StylePropertyAnimationSystem.Values<T>.TimingData.NativeFieldInfoPtr_reversingShorteningFactor)) = value;
					}
				}

				// Token: 0x17001401 RID: 5121
				// (get) Token: 0x060042E7 RID: 17127 RVA: 0x001060E0 File Offset: 0x001042E0
				// (set) Token: 0x060042E8 RID: 17128 RVA: 0x0001C950 File Offset: 0x0001AB50
				public unsafe bool isStarted
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StylePropertyAnimationSystem.Values<T>.TimingData.NativeFieldInfoPtr_isStarted);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StylePropertyAnimationSystem.Values<T>.TimingData.NativeFieldInfoPtr_isStarted)) = value;
					}
				}

				// Token: 0x17001402 RID: 5122
				// (get) Token: 0x060042E9 RID: 17129 RVA: 0x00106108 File Offset: 0x00104308
				// (set) Token: 0x060042EA RID: 17130 RVA: 0x0001C96B File Offset: 0x0001AB6B
				public unsafe int delayMs
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StylePropertyAnimationSystem.Values<T>.TimingData.NativeFieldInfoPtr_delayMs);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StylePropertyAnimationSystem.Values<T>.TimingData.NativeFieldInfoPtr_delayMs)) = value;
					}
				}

				// Token: 0x04002ECC RID: 11980
				private static readonly IntPtr NativeFieldInfoPtr_startTimeMs;

				// Token: 0x04002ECD RID: 11981
				private static readonly IntPtr NativeFieldInfoPtr_durationMs;

				// Token: 0x04002ECE RID: 11982
				private static readonly IntPtr NativeFieldInfoPtr_easingCurve;

				// Token: 0x04002ECF RID: 11983
				private static readonly IntPtr NativeFieldInfoPtr_easedProgress;

				// Token: 0x04002ED0 RID: 11984
				private static readonly IntPtr NativeFieldInfoPtr_reversingShorteningFactor;

				// Token: 0x04002ED1 RID: 11985
				private static readonly IntPtr NativeFieldInfoPtr_isStarted;

				// Token: 0x04002ED2 RID: 11986
				private static readonly IntPtr NativeFieldInfoPtr_delayMs;
			}

			// Token: 0x02000599 RID: 1433
			public sealed class StyleData : ValueType
			{
				// Token: 0x060042EB RID: 17131 RVA: 0x00106130 File Offset: 0x00104330
				// Note: this type is marked as 'beforefieldinit'.
				static StyleData()
				{
					Il2CppClassPointerStore<StylePropertyAnimationSystem.Values<T>.StyleData>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StylePropertyAnimationSystem.Values<T>>.NativeClassPtr, "StyleData"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StylePropertyAnimationSystem.Values<T>.StyleData>.NativeClassPtr);
					StylePropertyAnimationSystem.Values<T>.StyleData.NativeFieldInfoPtr_startValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StylePropertyAnimationSystem.Values<T>.StyleData>.NativeClassPtr, "startValue");
					StylePropertyAnimationSystem.Values<T>.StyleData.NativeFieldInfoPtr_endValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StylePropertyAnimationSystem.Values<T>.StyleData>.NativeClassPtr, "endValue");
					StylePropertyAnimationSystem.Values<T>.StyleData.NativeFieldInfoPtr_reversingAdjustedStartValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StylePropertyAnimationSystem.Values<T>.StyleData>.NativeClassPtr, "reversingAdjustedStartValue");
					StylePropertyAnimationSystem.Values<T>.StyleData.NativeFieldInfoPtr_currentValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StylePropertyAnimationSystem.Values<T>.StyleData>.NativeClassPtr, "currentValue");
				}

				// Token: 0x060042EC RID: 17132 RVA: 0x0001C986 File Offset: 0x0001AB86
				public StyleData(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x060042ED RID: 17133 RVA: 0x0001C98F File Offset: 0x0001AB8F
				public StyleData()
					: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StylePropertyAnimationSystem.Values<T>.StyleData>.NativeClassPtr))
				{
				}

				// Token: 0x17001403 RID: 5123
				// (get) Token: 0x060042EE RID: 17134 RVA: 0x001061E8 File Offset: 0x001043E8
				// (set) Token: 0x060042EF RID: 17135 RVA: 0x00106210 File Offset: 0x00104410
				public unsafe T startValue
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StylePropertyAnimationSystem.Values<T>.StyleData.NativeFieldInfoPtr_startValue);
						return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StylePropertyAnimationSystem.Values<T>.StyleData.NativeFieldInfoPtr_startValue);
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

				// Token: 0x17001404 RID: 5124
				// (get) Token: 0x060042F0 RID: 17136 RVA: 0x001062B8 File Offset: 0x001044B8
				// (set) Token: 0x060042F1 RID: 17137 RVA: 0x001062E0 File Offset: 0x001044E0
				public unsafe T endValue
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StylePropertyAnimationSystem.Values<T>.StyleData.NativeFieldInfoPtr_endValue);
						return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StylePropertyAnimationSystem.Values<T>.StyleData.NativeFieldInfoPtr_endValue);
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

				// Token: 0x17001405 RID: 5125
				// (get) Token: 0x060042F2 RID: 17138 RVA: 0x00106388 File Offset: 0x00104588
				// (set) Token: 0x060042F3 RID: 17139 RVA: 0x001063B0 File Offset: 0x001045B0
				public unsafe T reversingAdjustedStartValue
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StylePropertyAnimationSystem.Values<T>.StyleData.NativeFieldInfoPtr_reversingAdjustedStartValue);
						return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StylePropertyAnimationSystem.Values<T>.StyleData.NativeFieldInfoPtr_reversingAdjustedStartValue);
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

				// Token: 0x17001406 RID: 5126
				// (get) Token: 0x060042F4 RID: 17140 RVA: 0x00106458 File Offset: 0x00104658
				// (set) Token: 0x060042F5 RID: 17141 RVA: 0x00106480 File Offset: 0x00104680
				public unsafe T currentValue
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StylePropertyAnimationSystem.Values<T>.StyleData.NativeFieldInfoPtr_currentValue);
						return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StylePropertyAnimationSystem.Values<T>.StyleData.NativeFieldInfoPtr_currentValue);
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

				// Token: 0x04002ED3 RID: 11987
				private static readonly IntPtr NativeFieldInfoPtr_startValue;

				// Token: 0x04002ED4 RID: 11988
				private static readonly IntPtr NativeFieldInfoPtr_endValue;

				// Token: 0x04002ED5 RID: 11989
				private static readonly IntPtr NativeFieldInfoPtr_reversingAdjustedStartValue;

				// Token: 0x04002ED6 RID: 11990
				private static readonly IntPtr NativeFieldInfoPtr_currentValue;
			}

			// Token: 0x0200059A RID: 1434
			public sealed class EmptyData : ValueType
			{
				// Token: 0x060042F6 RID: 17142 RVA: 0x00106528 File Offset: 0x00104728
				// Note: this type is marked as 'beforefieldinit'.
				static EmptyData()
				{
					Il2CppClassPointerStore<StylePropertyAnimationSystem.Values<T>.EmptyData>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StylePropertyAnimationSystem.Values<T>>.NativeClassPtr, "EmptyData"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StylePropertyAnimationSystem.Values<T>.EmptyData>.NativeClassPtr);
					StylePropertyAnimationSystem.Values<T>.EmptyData.NativeFieldInfoPtr_Default = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StylePropertyAnimationSystem.Values<T>.EmptyData>.NativeClassPtr, "Default");
				}

				// Token: 0x060042F7 RID: 17143 RVA: 0x0001C9A1 File Offset: 0x0001ABA1
				public EmptyData(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x060042F8 RID: 17144 RVA: 0x0001C9AA File Offset: 0x0001ABAA
				public EmptyData()
					: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StylePropertyAnimationSystem.Values<T>.EmptyData>.NativeClassPtr))
				{
				}

				// Token: 0x17001407 RID: 5127
				// (get) Token: 0x060042F9 RID: 17145 RVA: 0x001065A4 File Offset: 0x001047A4
				// (set) Token: 0x060042FA RID: 17146 RVA: 0x0001C9BC File Offset: 0x0001ABBC
				public unsafe static StylePropertyAnimationSystem.Values<T>.EmptyData Default
				{
					get
					{
						IntPtr intPtr = stackalloc byte[(UIntPtr)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<StylePropertyAnimationSystem.Values<T>.EmptyData>.NativeClassPtr, (UIntPtr)0)];
						IL2CPP.il2cpp_field_static_get_value(StylePropertyAnimationSystem.Values<T>.EmptyData.NativeFieldInfoPtr_Default, intPtr);
						return new StylePropertyAnimationSystem.Values<T>.EmptyData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StylePropertyAnimationSystem.Values<T>.EmptyData>.NativeClassPtr, intPtr));
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(StylePropertyAnimationSystem.Values<T>.EmptyData.NativeFieldInfoPtr_Default, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value)));
					}
				}

				// Token: 0x04002ED7 RID: 11991
				private static readonly IntPtr NativeFieldInfoPtr_Default;
			}
		}

		// Token: 0x020004C6 RID: 1222
		public class ValuesFloat : StylePropertyAnimationSystem.Values<float>
		{
			// Token: 0x06003E64 RID: 15972 RVA: 0x000F8E08 File Offset: 0x000F7008
			// Note: this type is marked as 'beforefieldinit'.
			static ValuesFloat()
			{
				Il2CppClassPointerStore<StylePropertyAnimationSystem.ValuesFloat>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StylePropertyAnimationSystem>.NativeClassPtr, "ValuesFloat");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StylePropertyAnimationSystem.ValuesFloat>.NativeClassPtr);
				StylePropertyAnimationSystem.ValuesFloat.NativeFieldInfoPtr__SameFunc_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StylePropertyAnimationSystem.ValuesFloat>.NativeClassPtr, "<SameFunc>k__BackingField");
				StylePropertyAnimationSystem.ValuesFloat.NativeMethodInfoPtr_get_SameFunc_Public_Virtual_get_Func_3_Single_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyAnimationSystem.ValuesFloat>.NativeClassPtr, 100668588);
				StylePropertyAnimationSystem.ValuesFloat.NativeMethodInfoPtr_IsSame_Private_Static_Boolean_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyAnimationSystem.ValuesFloat>.NativeClassPtr, 100668589);
				StylePropertyAnimationSystem.ValuesFloat.NativeMethodInfoPtr_Lerp_Private_Static_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyAnimationSystem.ValuesFloat>.NativeClassPtr, 100668590);
				StylePropertyAnimationSystem.ValuesFloat.NativeMethodInfoPtr_UpdateValues_Protected_Virtual_Final_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyAnimationSystem.ValuesFloat>.NativeClassPtr, 100668591);
				StylePropertyAnimationSystem.ValuesFloat.NativeMethodInfoPtr_UpdateComputedStyle_Protected_Virtual_Final_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyAnimationSystem.ValuesFloat>.NativeClassPtr, 100668592);
				StylePropertyAnimationSystem.ValuesFloat.NativeMethodInfoPtr_UpdateComputedStyle_Protected_Virtual_Final_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyAnimationSystem.ValuesFloat>.NativeClassPtr, 100668593);
				StylePropertyAnimationSystem.ValuesFloat.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyAnimationSystem.ValuesFloat>.NativeClassPtr, 100668594);
			}

			// Token: 0x170012DA RID: 4826
			// (get) Token: 0x06003E65 RID: 15973 RVA: 0x000F8ED4 File Offset: 0x000F70D4
			public unsafe override Func<float, float, bool> SameFunc
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StylePropertyAnimationSystem.ValuesFloat.NativeMethodInfoPtr_get_SameFunc_Public_Virtual_get_Func_3_Single_Single_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Func<float, float, bool>>(intPtr3) : null;
				}
			}

			// Token: 0x06003E66 RID: 15974 RVA: 0x000F8F20 File Offset: 0x000F7120
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 336852, XrefRangeEnd = 336853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static bool IsSame(float a, float b)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref a;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyAnimationSystem.ValuesFloat.NativeMethodInfoPtr_IsSame_Private_Static_Boolean_Single_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06003E67 RID: 15975 RVA: 0x000F8F6C File Offset: 0x000F716C
			[CallerCount(0)]
			public unsafe static float Lerp(float a, float b, float t)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref a;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref t;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyAnimationSystem.ValuesFloat.NativeMethodInfoPtr_Lerp_Private_Static_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06003E68 RID: 15976 RVA: 0x000F8FC8 File Offset: 0x000F71C8
			[CallerCount(0)]
			public unsafe override void UpdateValues()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyAnimationSystem.ValuesFloat.NativeMethodInfoPtr_UpdateValues_Protected_Virtual_Final_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003E69 RID: 15977 RVA: 0x000F8FFC File Offset: 0x000F71FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 336853, XrefRangeEnd = 336855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void UpdateComputedStyle()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyAnimationSystem.ValuesFloat.NativeMethodInfoPtr_UpdateComputedStyle_Protected_Virtual_Final_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003E6A RID: 15978 RVA: 0x000F9030 File Offset: 0x000F7230
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 336855, XrefRangeEnd = 336857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void UpdateComputedStyle(int i)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref i;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyAnimationSystem.ValuesFloat.NativeMethodInfoPtr_UpdateComputedStyle_Protected_Virtual_Final_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003E6B RID: 15979 RVA: 0x000F9070 File Offset: 0x000F7270
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 336857, XrefRangeEnd = 336867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ValuesFloat()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StylePropertyAnimationSystem.ValuesFloat>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyAnimationSystem.ValuesFloat.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003E6C RID: 15980 RVA: 0x0001A417 File Offset: 0x00018617
			public ValuesFloat(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170012D9 RID: 4825
			// (get) Token: 0x06003E6D RID: 15981 RVA: 0x000F90AC File Offset: 0x000F72AC
			// (set) Token: 0x06003E6E RID: 15982 RVA: 0x0001A420 File Offset: 0x00018620
			public unsafe Func<float, float, bool> _SameFunc_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StylePropertyAnimationSystem.ValuesFloat.NativeFieldInfoPtr__SameFunc_k__BackingField);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<float, float, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StylePropertyAnimationSystem.ValuesFloat.NativeFieldInfoPtr__SameFunc_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002C1E RID: 11294
			private static readonly IntPtr NativeFieldInfoPtr__SameFunc_k__BackingField;

			// Token: 0x04002C1F RID: 11295
			private static readonly IntPtr NativeMethodInfoPtr_get_SameFunc_Public_Virtual_get_Func_3_Single_Single_Boolean_0;

			// Token: 0x04002C20 RID: 11296
			private static readonly IntPtr NativeMethodInfoPtr_IsSame_Private_Static_Boolean_Single_Single_0;

			// Token: 0x04002C21 RID: 11297
			private static readonly IntPtr NativeMethodInfoPtr_Lerp_Private_Static_Single_Single_Single_Single_0;

			// Token: 0x04002C22 RID: 11298
			private static readonly IntPtr NativeMethodInfoPtr_UpdateValues_Protected_Virtual_Final_Void_0;

			// Token: 0x04002C23 RID: 11299
			private static readonly IntPtr NativeMethodInfoPtr_UpdateComputedStyle_Protected_Virtual_Final_Void_0;

			// Token: 0x04002C24 RID: 11300
			private static readonly IntPtr NativeMethodInfoPtr_UpdateComputedStyle_Protected_Virtual_Final_Void_Int32_0;

			// Token: 0x04002C25 RID: 11301
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020004C7 RID: 1223
		public class ValuesInt : StylePropertyAnimationSystem.Values<int>
		{
			// Token: 0x06003E6F RID: 15983 RVA: 0x000F90DC File Offset: 0x000F72DC
			// Note: this type is marked as 'beforefieldinit'.
			static ValuesInt()
			{
				Il2CppClassPointerStore<StylePropertyAnimationSystem.ValuesInt>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StylePropertyAnimationSystem>.NativeClassPtr, "ValuesInt");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StylePropertyAnimationSystem.ValuesInt>.NativeClassPtr);
				StylePropertyAnimationSystem.ValuesInt.NativeFieldInfoPtr__SameFunc_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StylePropertyAnimationSystem.ValuesInt>.NativeClassPtr, "<SameFunc>k__BackingField");
				StylePropertyAnimationSystem.ValuesInt.NativeMethodInfoPtr_get_SameFunc_Public_Virtual_get_Func_3_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyAnimationSystem.ValuesInt>.NativeClassPtr, 100668595);
				StylePropertyAnimationSystem.ValuesInt.NativeMethodInfoPtr_IsSame_Private_Static_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyAnimationSystem.ValuesInt>.NativeClassPtr, 100668596);
				StylePropertyAnimationSystem.ValuesInt.NativeMethodInfoPtr_Lerp_Private_Static_Int32_Int32_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyAnimationSystem.ValuesInt>.NativeClassPtr, 100668597);
				StylePropertyAnimationSystem.ValuesInt.NativeMethodInfoPtr_UpdateValues_Protected_Virtual_Final_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyAnimationSystem.ValuesInt>.NativeClassPtr, 100668598);
				StylePropertyAnimationSystem.ValuesInt.NativeMethodInfoPtr_UpdateComputedStyle_Protected_Virtual_Final_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyAnimationSystem.ValuesInt>.NativeClassPtr, 100668599);
				StylePropertyAnimationSystem.ValuesInt.NativeMethodInfoPtr_UpdateComputedStyle_Protected_Virtual_Final_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyAnimationSystem.ValuesInt>.NativeClassPtr, 100668600);
				StylePropertyAnimationSystem.ValuesInt.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyAnimationSystem.ValuesInt>.NativeClassPtr, 100668601);
			}

			// Token: 0x170012DC RID: 4828
			// (get) Token: 0x06003E70 RID: 15984 RVA: 0x000F91A8 File Offset: 0x000F73A8
			public unsafe override Func<int, int, bool> SameFunc
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StylePropertyAnimationSystem.ValuesInt.NativeMethodInfoPtr_get_SameFunc_Public_Virtual_get_Func_3_Int32_Int32_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Func<int, int, bool>>(intPtr3) : null;
				}
			}

			// Token: 0x06003E71 RID: 15985 RVA: 0x000F91F4 File Offset: 0x000F73F4
			[CallerCount(0)]
			public unsafe static bool IsSame(int a, int b)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref a;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyAnimationSystem.ValuesInt.NativeMethodInfoPtr_IsSame_Private_Static_Boolean_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06003E72 RID: 15986 RVA: 0x000F9240 File Offset: 0x000F7440
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 336867, XrefRangeEnd = 336871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static int Lerp(int a, int b, float t)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref a;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref t;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyAnimationSystem.ValuesInt.NativeMethodInfoPtr_Lerp_Private_Static_Int32_Int32_Int32_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06003E73 RID: 15987 RVA: 0x000F929C File Offset: 0x000F749C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 336871, XrefRangeEnd = 336880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void UpdateValues()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyAnimationSystem.ValuesInt.NativeMethodInfoPtr_UpdateValues_Protected_Virtual_Final_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003E74 RID: 15988 RVA: 0x000F92D0 File Offset: 0x000F74D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 336880, XrefRangeEnd = 336882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void UpdateComputedStyle()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyAnimationSystem.ValuesInt.NativeMethodInfoPtr_UpdateComputedStyle_Protected_Virtual_Final_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003E75 RID: 15989 RVA: 0x000F9304 File Offset: 0x000F7504
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 336882, XrefRangeEnd = 336884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void UpdateComputedStyle(int i)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref i;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyAnimationSystem.ValuesInt.NativeMethodInfoPtr_UpdateComputedStyle_Protected_Virtual_Final_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003E76 RID: 15990 RVA: 0x000F9344 File Offset: 0x000F7544
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 336884, XrefRangeEnd = 336894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ValuesInt()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StylePropertyAnimationSystem.ValuesInt>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyAnimationSystem.ValuesInt.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003E77 RID: 15991 RVA: 0x0001A43F File Offset: 0x0001863F
			public ValuesInt(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170012DB RID: 4827
			// (get) Token: 0x06003E78 RID: 15992 RVA: 0x000F9380 File Offset: 0x000F7580
			// (set) Token: 0x06003E79 RID: 15993 RVA: 0x0001A448 File Offset: 0x00018648
			public unsafe Func<int, int, bool> _SameFunc_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StylePropertyAnimationSystem.ValuesInt.NativeFieldInfoPtr__SameFunc_k__BackingField);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, int, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StylePropertyAnimationSystem.ValuesInt.NativeFieldInfoPtr__SameFunc_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002C26 RID: 11302
			private static readonly IntPtr NativeFieldInfoPtr__SameFunc_k__BackingField;

			// Token: 0x04002C27 RID: 11303
			private static readonly IntPtr NativeMethodInfoPtr_get_SameFunc_Public_Virtual_get_Func_3_Int32_Int32_Boolean_0;

			// Token: 0x04002C28 RID: 11304
			private static readonly IntPtr NativeMethodInfoPtr_IsSame_Private_Static_Boolean_Int32_Int32_0;

			// Token: 0x04002C29 RID: 11305
			private static readonly IntPtr NativeMethodInfoPtr_Lerp_Private_Static_Int32_Int32_Int32_Single_0;

			// Token: 0x04002C2A RID: 11306
			private static readonly IntPtr NativeMethodInfoPtr_UpdateValues_Protected_Virtual_Final_Void_0;

			// Token: 0x04002C2B RID: 11307
			private static readonly IntPtr NativeMethodInfoPtr_UpdateComputedStyle_Protected_Virtual_Final_Void_0;

			// Token: 0x04002C2C RID: 11308
			private static readonly IntPtr NativeMethodInfoPtr_UpdateComputedStyle_Protected_Virtual_Final_Void_Int32_0;

			// Token: 0x04002C2D RID: 11309
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020004C8 RID: 1224
		public class ValuesLength : StylePropertyAnimationSystem.Values<Length>
		{
			// Token: 0x06003E7A RID: 15994 RVA: 0x000F93B0 File Offset: 0x000F75B0
			// Note: this type is marked as 'beforefieldinit'.
			static ValuesLength()
			{
				Il2CppClassPointerStore<StylePropertyAnimationSystem.ValuesLength>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StylePropertyAnimationSystem>.NativeClassPtr, "ValuesLength");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StylePropertyAnimationSystem.ValuesLength>.NativeClassPtr);
				StylePropertyAnimationSystem.ValuesLength.NativeFieldInfoPtr__SameFunc_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StylePropertyAnimationSystem.ValuesLength>.NativeClassPtr, "<SameFunc>k__BackingField");
				StylePropertyAnimationSystem.ValuesLength.NativeMethodInfoPtr_get_SameFunc_Public_Virtual_get_Func_3_Length_Length_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyAnimationSystem.ValuesLength>.NativeClassPtr, 100668602);
				StylePropertyAnimationSystem.ValuesLength.NativeMethodInfoPtr_IsSame_Private_Static_Boolean_Length_Length_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyAnimationSystem.ValuesLength>.NativeClassPtr, 100668603);
				StylePropertyAnimationSystem.ValuesLength.NativeMethodInfoPtr_ConvertUnits_Protected_Virtual_Final_Boolean_VisualElement_StylePropertyId_byref_Length_byref_Length_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyAnimationSystem.ValuesLength>.NativeClassPtr, 100668604);
				StylePropertyAnimationSystem.ValuesLength.NativeMethodInfoPtr_Lerp_Internal_Static_Length_Length_Length_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyAnimationSystem.ValuesLength>.NativeClassPtr, 100668605);
				StylePropertyAnimationSystem.ValuesLength.NativeMethodInfoPtr_UpdateValues_Protected_Virtual_Final_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyAnimationSystem.ValuesLength>.NativeClassPtr, 100668606);
				StylePropertyAnimationSystem.ValuesLength.NativeMethodInfoPtr_UpdateComputedStyle_Protected_Virtual_Final_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyAnimationSystem.ValuesLength>.NativeClassPtr, 100668607);
				StylePropertyAnimationSystem.ValuesLength.NativeMethodInfoPtr_UpdateComputedStyle_Protected_Virtual_Final_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyAnimationSystem.ValuesLength>.NativeClassPtr, 100668608);
				StylePropertyAnimationSystem.ValuesLength.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyAnimationSystem.ValuesLength>.NativeClassPtr, 100668609);
			}

			// Token: 0x170012DE RID: 4830
			// (get) Token: 0x06003E7B RID: 15995 RVA: 0x000F9490 File Offset: 0x000F7690
			public unsafe override Func<Length, Length, bool> SameFunc
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StylePropertyAnimationSystem.ValuesLength.NativeMethodInfoPtr_get_SameFunc_Public_Virtual_get_Func_3_Length_Length_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Func<Length, Length, bool>>(intPtr3) : null;
				}
			}

			// Token: 0x06003E7C RID: 15996 RVA: 0x000F94DC File Offset: 0x000F76DC
			[CallerCount(0)]
			public unsafe static bool IsSame(Length a, Length b)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref a;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyAnimationSystem.ValuesLength.NativeMethodInfoPtr_IsSame_Private_Static_Boolean_Length_Length_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06003E7D RID: 15997 RVA: 0x000F9528 File Offset: 0x000F7728
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 336894, XrefRangeEnd = 336896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override bool ConvertUnits(VisualElement owner, UnityEngine.UIElements.StyleSheets.StylePropertyId prop, ref Length a, ref Length b)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(owner);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref prop;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &a;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &b;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyAnimationSystem.ValuesLength.NativeMethodInfoPtr_ConvertUnits_Protected_Virtual_Final_Boolean_VisualElement_StylePropertyId_byref_Length_byref_Length_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06003E7E RID: 15998 RVA: 0x000F95A0 File Offset: 0x000F77A0
			[CallerCount(0)]
			public unsafe static Length Lerp(Length a, Length b, float t)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref a;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref t;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyAnimationSystem.ValuesLength.NativeMethodInfoPtr_Lerp_Internal_Static_Length_Length_Length_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06003E7F RID: 15999 RVA: 0x000F95FC File Offset: 0x000F77FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 336896, XrefRangeEnd = 336897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void UpdateValues()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyAnimationSystem.ValuesLength.NativeMethodInfoPtr_UpdateValues_Protected_Virtual_Final_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003E80 RID: 16000 RVA: 0x000F9630 File Offset: 0x000F7830
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 336897, XrefRangeEnd = 336899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void UpdateComputedStyle()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyAnimationSystem.ValuesLength.NativeMethodInfoPtr_UpdateComputedStyle_Protected_Virtual_Final_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003E81 RID: 16001 RVA: 0x000F9664 File Offset: 0x000F7864
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 336899, XrefRangeEnd = 336901, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void UpdateComputedStyle(int i)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref i;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyAnimationSystem.ValuesLength.NativeMethodInfoPtr_UpdateComputedStyle_Protected_Virtual_Final_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003E82 RID: 16002 RVA: 0x000F96A4 File Offset: 0x000F78A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 336901, XrefRangeEnd = 336911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ValuesLength()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StylePropertyAnimationSystem.ValuesLength>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyAnimationSystem.ValuesLength.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003E83 RID: 16003 RVA: 0x0001A467 File Offset: 0x00018667
			public ValuesLength(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170012DD RID: 4829
			// (get) Token: 0x06003E84 RID: 16004 RVA: 0x000F96E0 File Offset: 0x000F78E0
			// (set) Token: 0x06003E85 RID: 16005 RVA: 0x0001A470 File Offset: 0x00018670
			public unsafe Func<Length, Length, bool> _SameFunc_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StylePropertyAnimationSystem.ValuesLength.NativeFieldInfoPtr__SameFunc_k__BackingField);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Length, Length, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StylePropertyAnimationSystem.ValuesLength.NativeFieldInfoPtr__SameFunc_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002C2E RID: 11310
			private static readonly IntPtr NativeFieldInfoPtr__SameFunc_k__BackingField;

			// Token: 0x04002C2F RID: 11311
			private static readonly IntPtr NativeMethodInfoPtr_get_SameFunc_Public_Virtual_get_Func_3_Length_Length_Boolean_0;

			// Token: 0x04002C30 RID: 11312
			private static readonly IntPtr NativeMethodInfoPtr_IsSame_Private_Static_Boolean_Length_Length_0;

			// Token: 0x04002C31 RID: 11313
			private static readonly IntPtr NativeMethodInfoPtr_ConvertUnits_Protected_Virtual_Final_Boolean_VisualElement_StylePropertyId_byref_Length_byref_Length_0;

			// Token: 0x04002C32 RID: 11314
			private static readonly IntPtr NativeMethodInfoPtr_Lerp_Internal_Static_Length_Length_Length_Single_0;

			// Token: 0x04002C33 RID: 11315
			private static readonly IntPtr NativeMethodInfoPtr_UpdateValues_Protected_Virtual_Final_Void_0;

			// Token: 0x04002C34 RID: 11316
			private static readonly IntPtr NativeMethodInfoPtr_UpdateComputedStyle_Protected_Virtual_Final_Void_0;

			// Token: 0x04002C35 RID: 11317
			private static readonly IntPtr NativeMethodInfoPtr_UpdateComputedStyle_Protected_Virtual_Final_Void_Int32_0;

			// Token: 0x04002C36 RID: 11318
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020004C9 RID: 1225
		public class ValuesColor : StylePropertyAnimationSystem.Values<Color>
		{
			// Token: 0x06003E86 RID: 16006 RVA: 0x000F9710 File Offset: 0x000F7910
			// Note: this type is marked as 'beforefieldinit'.
			static ValuesColor()
			{
				Il2CppClassPointerStore<StylePropertyAnimationSystem.ValuesColor>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StylePropertyAnimationSystem>.NativeClassPtr, "ValuesColor");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StylePropertyAnimationSystem.ValuesColor>.NativeClassPtr);
				StylePropertyAnimationSystem.ValuesColor.NativeFieldInfoPtr__SameFunc_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StylePropertyAnimationSystem.ValuesColor>.NativeClassPtr, "<SameFunc>k__BackingField");
				StylePropertyAnimationSystem.ValuesColor.NativeMethodInfoPtr_get_SameFunc_Public_Virtual_get_Func_3_Color_Color_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyAnimationSystem.ValuesColor>.NativeClassPtr, 100668610);
				StylePropertyAnimationSystem.ValuesColor.NativeMethodInfoPtr_IsSame_Private_Static_Boolean_Color_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyAnimationSystem.ValuesColor>.NativeClassPtr, 100668611);
				StylePropertyAnimationSystem.ValuesColor.NativeMethodInfoPtr_Lerp_Private_Static_Color_Color_Color_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyAnimationSystem.ValuesColor>.NativeClassPtr, 100668612);
				StylePropertyAnimationSystem.ValuesColor.NativeMethodInfoPtr_UpdateValues_Protected_Virtual_Final_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyAnimationSystem.ValuesColor>.NativeClassPtr, 100668613);
				StylePropertyAnimationSystem.ValuesColor.NativeMethodInfoPtr_UpdateComputedStyle_Protected_Virtual_Final_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyAnimationSystem.ValuesColor>.NativeClassPtr, 100668614);
				StylePropertyAnimationSystem.ValuesColor.NativeMethodInfoPtr_UpdateComputedStyle_Protected_Virtual_Final_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyAnimationSystem.ValuesColor>.NativeClassPtr, 100668615);
				StylePropertyAnimationSystem.ValuesColor.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyAnimationSystem.ValuesColor>.NativeClassPtr, 100668616);
			}

			// Token: 0x170012E0 RID: 4832
			// (get) Token: 0x06003E87 RID: 16007 RVA: 0x000F97DC File Offset: 0x000F79DC
			public unsafe override Func<Color, Color, bool> SameFunc
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StylePropertyAnimationSystem.ValuesColor.NativeMethodInfoPtr_get_SameFunc_Public_Virtual_get_Func_3_Color_Color_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Func<Color, Color, bool>>(intPtr3) : null;
				}
			}

			// Token: 0x06003E88 RID: 16008 RVA: 0x000F9828 File Offset: 0x000F7A28
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 336911, XrefRangeEnd = 336915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static bool IsSame(Color c, Color d)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref c;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref d;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyAnimationSystem.ValuesColor.NativeMethodInfoPtr_IsSame_Private_Static_Boolean_Color_Color_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06003E89 RID: 16009 RVA: 0x000F9874 File Offset: 0x000F7A74
			[CallerCount(0)]
			public unsafe static Color Lerp(Color a, Color b, float t)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref a;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref t;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyAnimationSystem.ValuesColor.NativeMethodInfoPtr_Lerp_Private_Static_Color_Color_Color_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06003E8A RID: 16010 RVA: 0x000F98D0 File Offset: 0x000F7AD0
			[CallerCount(0)]
			public unsafe override void UpdateValues()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyAnimationSystem.ValuesColor.NativeMethodInfoPtr_UpdateValues_Protected_Virtual_Final_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003E8B RID: 16011 RVA: 0x000F9904 File Offset: 0x000F7B04
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 336915, XrefRangeEnd = 336917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void UpdateComputedStyle()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyAnimationSystem.ValuesColor.NativeMethodInfoPtr_UpdateComputedStyle_Protected_Virtual_Final_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003E8C RID: 16012 RVA: 0x000F9938 File Offset: 0x000F7B38
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 336917, XrefRangeEnd = 336919, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void UpdateComputedStyle(int i)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref i;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyAnimationSystem.ValuesColor.NativeMethodInfoPtr_UpdateComputedStyle_Protected_Virtual_Final_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003E8D RID: 16013 RVA: 0x000F9978 File Offset: 0x000F7B78
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 336919, XrefRangeEnd = 336929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ValuesColor()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StylePropertyAnimationSystem.ValuesColor>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyAnimationSystem.ValuesColor.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003E8E RID: 16014 RVA: 0x0001A48F File Offset: 0x0001868F
			public ValuesColor(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170012DF RID: 4831
			// (get) Token: 0x06003E8F RID: 16015 RVA: 0x000F99B4 File Offset: 0x000F7BB4
			// (set) Token: 0x06003E90 RID: 16016 RVA: 0x0001A498 File Offset: 0x00018698
			public unsafe Func<Color, Color, bool> _SameFunc_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StylePropertyAnimationSystem.ValuesColor.NativeFieldInfoPtr__SameFunc_k__BackingField);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Color, Color, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StylePropertyAnimationSystem.ValuesColor.NativeFieldInfoPtr__SameFunc_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002C37 RID: 11319
			private static readonly IntPtr NativeFieldInfoPtr__SameFunc_k__BackingField;

			// Token: 0x04002C38 RID: 11320
			private static readonly IntPtr NativeMethodInfoPtr_get_SameFunc_Public_Virtual_get_Func_3_Color_Color_Boolean_0;

			// Token: 0x04002C39 RID: 11321
			private static readonly IntPtr NativeMethodInfoPtr_IsSame_Private_Static_Boolean_Color_Color_0;

			// Token: 0x04002C3A RID: 11322
			private static readonly IntPtr NativeMethodInfoPtr_Lerp_Private_Static_Color_Color_Color_Single_0;

			// Token: 0x04002C3B RID: 11323
			private static readonly IntPtr NativeMethodInfoPtr_UpdateValues_Protected_Virtual_Final_Void_0;

			// Token: 0x04002C3C RID: 11324
			private static readonly IntPtr NativeMethodInfoPtr_UpdateComputedStyle_Protected_Virtual_Final_Void_0;

			// Token: 0x04002C3D RID: 11325
			private static readonly IntPtr NativeMethodInfoPtr_UpdateComputedStyle_Protected_Virtual_Final_Void_Int32_0;

			// Token: 0x04002C3E RID: 11326
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020004CA RID: 1226
		public class ValuesDiscrete<T> : StylePropertyAnimationSystem.Values<T>
		{
			// Token: 0x06003E91 RID: 16017 RVA: 0x000F99E4 File Offset: 0x000F7BE4
			// Note: this type is marked as 'beforefieldinit'.
			static ValuesDiscrete()
			{
				Il2CppClassPointerStore<StylePropertyAnimationSystem.ValuesDiscrete<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StylePropertyAnimationSystem>.NativeClassPtr, "ValuesDiscrete`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StylePropertyAnimationSystem.ValuesDiscrete<T>>.NativeClassPtr);
				StylePropertyAnimationSystem.ValuesDiscrete<T>.NativeFieldInfoPtr__SameFunc_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StylePropertyAnimationSystem.ValuesDiscrete<T>>.NativeClassPtr, "<SameFunc>k__BackingField");
				StylePropertyAnimationSystem.ValuesDiscrete<T>.NativeMethodInfoPtr_get_SameFunc_Public_Virtual_get_Func_3_T_T_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyAnimationSystem.ValuesDiscrete<T>>.NativeClassPtr, 100668617);
				StylePropertyAnimationSystem.ValuesDiscrete<T>.NativeMethodInfoPtr_IsSame_Private_Static_Boolean_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyAnimationSystem.ValuesDiscrete<T>>.NativeClassPtr, 100668618);
				StylePropertyAnimationSystem.ValuesDiscrete<T>.NativeMethodInfoPtr_Lerp_Private_Static_T_T_T_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyAnimationSystem.ValuesDiscrete<T>>.NativeClassPtr, 100668619);
				StylePropertyAnimationSystem.ValuesDiscrete<T>.NativeMethodInfoPtr_UpdateValues_Protected_Virtual_Final_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyAnimationSystem.ValuesDiscrete<T>>.NativeClassPtr, 100668620);
				StylePropertyAnimationSystem.ValuesDiscrete<T>.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyAnimationSystem.ValuesDiscrete<T>>.NativeClassPtr, 100668621);
			}

			// Token: 0x170012E2 RID: 4834
			// (get) Token: 0x06003E92 RID: 16018 RVA: 0x000F9AC4 File Offset: 0x000F7CC4
			public unsafe override Func<T, T, bool> SameFunc
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StylePropertyAnimationSystem.ValuesDiscrete<T>.NativeMethodInfoPtr_get_SameFunc_Public_Virtual_get_Func_3_T_T_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Func<T, T, bool>>(intPtr3) : null;
				}
			}

			// Token: 0x06003E93 RID: 16019 RVA: 0x000F9B10 File Offset: 0x000F7D10
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 336929, XrefRangeEnd = 336941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static bool IsSame(T a, T b)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr;
					if (!typeof(T).IsValueType)
					{
						T t = a;
						intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
					}
					else
					{
						intPtr = ref a;
					}
					ptr2 = intPtr;
				}
				ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
				IntPtr intPtr2;
				if (!typeof(T).IsValueType)
				{
					T t2 = b;
					intPtr2 = ((t2 is string) ? IL2CPP.ManagedStringToIl2Cpp(t2 as string) : IL2CPP.Il2CppObjectBaseToPtr(t2 as Il2CppObjectBase));
				}
				else
				{
					intPtr2 = ref b;
				}
				ptr3 = intPtr2;
				IntPtr intPtr4;
				IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(StylePropertyAnimationSystem.ValuesDiscrete<T>.NativeMethodInfoPtr_IsSame_Private_Static_Boolean_T_T_0, 0, (void**)ptr, ref intPtr4);
				Il2CppException.RaiseExceptionIfNecessary(intPtr4);
				return *IL2CPP.il2cpp_object_unbox(intPtr3);
			}

			// Token: 0x06003E94 RID: 16020 RVA: 0x000F9BD0 File Offset: 0x000F7DD0
			[CallerCount(0)]
			public unsafe static T Lerp(T a, T b, float t)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr;
					if (!typeof(T).IsValueType)
					{
						T t2 = a;
						intPtr = ((t2 is string) ? IL2CPP.ManagedStringToIl2Cpp(t2 as string) : IL2CPP.Il2CppObjectBaseToPtr(t2 as Il2CppObjectBase));
					}
					else
					{
						intPtr = ref a;
					}
					ptr2 = intPtr;
				}
				ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
				IntPtr intPtr2;
				if (!typeof(T).IsValueType)
				{
					T t3 = b;
					intPtr2 = ((t3 is string) ? IL2CPP.ManagedStringToIl2Cpp(t3 as string) : IL2CPP.Il2CppObjectBaseToPtr(t3 as Il2CppObjectBase));
				}
				else
				{
					intPtr2 = ref b;
				}
				ptr3 = intPtr2;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref t;
				IntPtr intPtr4;
				IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(StylePropertyAnimationSystem.ValuesDiscrete<T>.NativeMethodInfoPtr_Lerp_Private_Static_T_T_T_Single_0, 0, (void**)ptr, ref intPtr4);
				Il2CppException.RaiseExceptionIfNecessary(intPtr4);
				return IL2CPP.PointerToValueGeneric<T>(intPtr3, false, true);
			}

			// Token: 0x06003E95 RID: 16021 RVA: 0x000F9C9C File Offset: 0x000F7E9C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 336941, XrefRangeEnd = 336943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void UpdateValues()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyAnimationSystem.ValuesDiscrete<T>.NativeMethodInfoPtr_UpdateValues_Protected_Virtual_Final_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003E96 RID: 16022 RVA: 0x000F9CD0 File Offset: 0x000F7ED0
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 336964, RefRangeEnd = 336965, XrefRangeStart = 336943, XrefRangeEnd = 336964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ValuesDiscrete()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StylePropertyAnimationSystem.ValuesDiscrete<T>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyAnimationSystem.ValuesDiscrete<T>.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003E97 RID: 16023 RVA: 0x0001A4B7 File Offset: 0x000186B7
			public ValuesDiscrete(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170012E1 RID: 4833
			// (get) Token: 0x06003E98 RID: 16024 RVA: 0x000F9D0C File Offset: 0x000F7F0C
			// (set) Token: 0x06003E99 RID: 16025 RVA: 0x0001A4C0 File Offset: 0x000186C0
			public unsafe Func<T, T, bool> _SameFunc_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StylePropertyAnimationSystem.ValuesDiscrete<T>.NativeFieldInfoPtr__SameFunc_k__BackingField);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<T, T, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StylePropertyAnimationSystem.ValuesDiscrete<T>.NativeFieldInfoPtr__SameFunc_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002C3F RID: 11327
			private static readonly IntPtr NativeFieldInfoPtr__SameFunc_k__BackingField;

			// Token: 0x04002C40 RID: 11328
			private static readonly IntPtr NativeMethodInfoPtr_get_SameFunc_Public_Virtual_get_Func_3_T_T_Boolean_0;

			// Token: 0x04002C41 RID: 11329
			private static readonly IntPtr NativeMethodInfoPtr_IsSame_Private_Static_Boolean_T_T_0;

			// Token: 0x04002C42 RID: 11330
			private static readonly IntPtr NativeMethodInfoPtr_Lerp_Private_Static_T_T_T_Single_0;

			// Token: 0x04002C43 RID: 11331
			private static readonly IntPtr NativeMethodInfoPtr_UpdateValues_Protected_Virtual_Final_Void_0;

			// Token: 0x04002C44 RID: 11332
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
		}

		// Token: 0x020004CB RID: 1227
		public class ValuesBackground : StylePropertyAnimationSystem.ValuesDiscrete<Background>
		{
			// Token: 0x06003E9A RID: 16026 RVA: 0x000F9D3C File Offset: 0x000F7F3C
			// Note: this type is marked as 'beforefieldinit'.
			static ValuesBackground()
			{
				Il2CppClassPointerStore<StylePropertyAnimationSystem.ValuesBackground>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StylePropertyAnimationSystem>.NativeClassPtr, "ValuesBackground");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StylePropertyAnimationSystem.ValuesBackground>.NativeClassPtr);
				StylePropertyAnimationSystem.ValuesBackground.NativeMethodInfoPtr_UpdateComputedStyle_Protected_Virtual_Final_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyAnimationSystem.ValuesBackground>.NativeClassPtr, 100668622);
				StylePropertyAnimationSystem.ValuesBackground.NativeMethodInfoPtr_UpdateComputedStyle_Protected_Virtual_Final_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyAnimationSystem.ValuesBackground>.NativeClassPtr, 100668623);
				StylePropertyAnimationSystem.ValuesBackground.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyAnimationSystem.ValuesBackground>.NativeClassPtr, 100668624);
			}

			// Token: 0x06003E9B RID: 16027 RVA: 0x000F9DA4 File Offset: 0x000F7FA4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 336965, XrefRangeEnd = 336967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void UpdateComputedStyle()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyAnimationSystem.ValuesBackground.NativeMethodInfoPtr_UpdateComputedStyle_Protected_Virtual_Final_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003E9C RID: 16028 RVA: 0x000F9DD8 File Offset: 0x000F7FD8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 336967, XrefRangeEnd = 336969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void UpdateComputedStyle(int i)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref i;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyAnimationSystem.ValuesBackground.NativeMethodInfoPtr_UpdateComputedStyle_Protected_Virtual_Final_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003E9D RID: 16029 RVA: 0x000F9E18 File Offset: 0x000F8018
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 336969, XrefRangeEnd = 336972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ValuesBackground()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StylePropertyAnimationSystem.ValuesBackground>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyAnimationSystem.ValuesBackground.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003E9E RID: 16030 RVA: 0x0001A4DF File Offset: 0x000186DF
			public ValuesBackground(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04002C45 RID: 11333
			private static readonly IntPtr NativeMethodInfoPtr_UpdateComputedStyle_Protected_Virtual_Final_Void_0;

			// Token: 0x04002C46 RID: 11334
			private static readonly IntPtr NativeMethodInfoPtr_UpdateComputedStyle_Protected_Virtual_Final_Void_Int32_0;

			// Token: 0x04002C47 RID: 11335
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020004CC RID: 1228
		public class ValuesFontDefinition : StylePropertyAnimationSystem.ValuesDiscrete<FontDefinition>
		{
			// Token: 0x06003E9F RID: 16031 RVA: 0x000F9E54 File Offset: 0x000F8054
			// Note: this type is marked as 'beforefieldinit'.
			static ValuesFontDefinition()
			{
				Il2CppClassPointerStore<StylePropertyAnimationSystem.ValuesFontDefinition>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StylePropertyAnimationSystem>.NativeClassPtr, "ValuesFontDefinition");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StylePropertyAnimationSystem.ValuesFontDefinition>.NativeClassPtr);
				StylePropertyAnimationSystem.ValuesFontDefinition.NativeMethodInfoPtr_UpdateComputedStyle_Protected_Virtual_Final_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyAnimationSystem.ValuesFontDefinition>.NativeClassPtr, 100668625);
				StylePropertyAnimationSystem.ValuesFontDefinition.NativeMethodInfoPtr_UpdateComputedStyle_Protected_Virtual_Final_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyAnimationSystem.ValuesFontDefinition>.NativeClassPtr, 100668626);
				StylePropertyAnimationSystem.ValuesFontDefinition.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyAnimationSystem.ValuesFontDefinition>.NativeClassPtr, 100668627);
			}

			// Token: 0x06003EA0 RID: 16032 RVA: 0x000F9EBC File Offset: 0x000F80BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 336972, XrefRangeEnd = 336974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void UpdateComputedStyle()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyAnimationSystem.ValuesFontDefinition.NativeMethodInfoPtr_UpdateComputedStyle_Protected_Virtual_Final_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003EA1 RID: 16033 RVA: 0x000F9EF0 File Offset: 0x000F80F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 336974, XrefRangeEnd = 336976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void UpdateComputedStyle(int i)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref i;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyAnimationSystem.ValuesFontDefinition.NativeMethodInfoPtr_UpdateComputedStyle_Protected_Virtual_Final_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003EA2 RID: 16034 RVA: 0x000F9F30 File Offset: 0x000F8130
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 336976, XrefRangeEnd = 336979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ValuesFontDefinition()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StylePropertyAnimationSystem.ValuesFontDefinition>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyAnimationSystem.ValuesFontDefinition.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003EA3 RID: 16035 RVA: 0x0001A4E8 File Offset: 0x000186E8
			public ValuesFontDefinition(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04002C48 RID: 11336
			private static readonly IntPtr NativeMethodInfoPtr_UpdateComputedStyle_Protected_Virtual_Final_Void_0;

			// Token: 0x04002C49 RID: 11337
			private static readonly IntPtr NativeMethodInfoPtr_UpdateComputedStyle_Protected_Virtual_Final_Void_Int32_0;

			// Token: 0x04002C4A RID: 11338
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020004CD RID: 1229
		public class ValuesFont : StylePropertyAnimationSystem.ValuesDiscrete<Font>
		{
			// Token: 0x06003EA4 RID: 16036 RVA: 0x000F9F6C File Offset: 0x000F816C
			// Note: this type is marked as 'beforefieldinit'.
			static ValuesFont()
			{
				Il2CppClassPointerStore<StylePropertyAnimationSystem.ValuesFont>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StylePropertyAnimationSystem>.NativeClassPtr, "ValuesFont");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StylePropertyAnimationSystem.ValuesFont>.NativeClassPtr);
				StylePropertyAnimationSystem.ValuesFont.NativeMethodInfoPtr_UpdateComputedStyle_Protected_Virtual_Final_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyAnimationSystem.ValuesFont>.NativeClassPtr, 100668628);
				StylePropertyAnimationSystem.ValuesFont.NativeMethodInfoPtr_UpdateComputedStyle_Protected_Virtual_Final_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyAnimationSystem.ValuesFont>.NativeClassPtr, 100668629);
				StylePropertyAnimationSystem.ValuesFont.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyAnimationSystem.ValuesFont>.NativeClassPtr, 100668630);
			}

			// Token: 0x06003EA5 RID: 16037 RVA: 0x000F9FD4 File Offset: 0x000F81D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 336979, XrefRangeEnd = 336981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void UpdateComputedStyle()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyAnimationSystem.ValuesFont.NativeMethodInfoPtr_UpdateComputedStyle_Protected_Virtual_Final_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003EA6 RID: 16038 RVA: 0x000FA008 File Offset: 0x000F8208
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 336981, XrefRangeEnd = 336983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void UpdateComputedStyle(int i)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref i;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyAnimationSystem.ValuesFont.NativeMethodInfoPtr_UpdateComputedStyle_Protected_Virtual_Final_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003EA7 RID: 16039 RVA: 0x000FA048 File Offset: 0x000F8248
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 336983, XrefRangeEnd = 336986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ValuesFont()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StylePropertyAnimationSystem.ValuesFont>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyAnimationSystem.ValuesFont.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003EA8 RID: 16040 RVA: 0x0001A4F1 File Offset: 0x000186F1
			public ValuesFont(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04002C4B RID: 11339
			private static readonly IntPtr NativeMethodInfoPtr_UpdateComputedStyle_Protected_Virtual_Final_Void_0;

			// Token: 0x04002C4C RID: 11340
			private static readonly IntPtr NativeMethodInfoPtr_UpdateComputedStyle_Protected_Virtual_Final_Void_Int32_0;

			// Token: 0x04002C4D RID: 11341
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020004CE RID: 1230
		public class ValuesTextShadow : StylePropertyAnimationSystem.Values<TextShadow>
		{
			// Token: 0x06003EA9 RID: 16041 RVA: 0x000FA084 File Offset: 0x000F8284
			// Note: this type is marked as 'beforefieldinit'.
			static ValuesTextShadow()
			{
				Il2CppClassPointerStore<StylePropertyAnimationSystem.ValuesTextShadow>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StylePropertyAnimationSystem>.NativeClassPtr, "ValuesTextShadow");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StylePropertyAnimationSystem.ValuesTextShadow>.NativeClassPtr);
				StylePropertyAnimationSystem.ValuesTextShadow.NativeFieldInfoPtr__SameFunc_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StylePropertyAnimationSystem.ValuesTextShadow>.NativeClassPtr, "<SameFunc>k__BackingField");
				StylePropertyAnimationSystem.ValuesTextShadow.NativeMethodInfoPtr_get_SameFunc_Public_Virtual_get_Func_3_TextShadow_TextShadow_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyAnimationSystem.ValuesTextShadow>.NativeClassPtr, 100668631);
				StylePropertyAnimationSystem.ValuesTextShadow.NativeMethodInfoPtr_IsSame_Private_Static_Boolean_TextShadow_TextShadow_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyAnimationSystem.ValuesTextShadow>.NativeClassPtr, 100668632);
				StylePropertyAnimationSystem.ValuesTextShadow.NativeMethodInfoPtr_Lerp_Private_Static_TextShadow_TextShadow_TextShadow_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyAnimationSystem.ValuesTextShadow>.NativeClassPtr, 100668633);
				StylePropertyAnimationSystem.ValuesTextShadow.NativeMethodInfoPtr_UpdateValues_Protected_Virtual_Final_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyAnimationSystem.ValuesTextShadow>.NativeClassPtr, 100668634);
				StylePropertyAnimationSystem.ValuesTextShadow.NativeMethodInfoPtr_UpdateComputedStyle_Protected_Virtual_Final_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyAnimationSystem.ValuesTextShadow>.NativeClassPtr, 100668635);
				StylePropertyAnimationSystem.ValuesTextShadow.NativeMethodInfoPtr_UpdateComputedStyle_Protected_Virtual_Final_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyAnimationSystem.ValuesTextShadow>.NativeClassPtr, 100668636);
				StylePropertyAnimationSystem.ValuesTextShadow.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyAnimationSystem.ValuesTextShadow>.NativeClassPtr, 100668637);
			}

			// Token: 0x170012E4 RID: 4836
			// (get) Token: 0x06003EAA RID: 16042 RVA: 0x000FA150 File Offset: 0x000F8350
			public unsafe override Func<TextShadow, TextShadow, bool> SameFunc
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StylePropertyAnimationSystem.ValuesTextShadow.NativeMethodInfoPtr_get_SameFunc_Public_Virtual_get_Func_3_TextShadow_TextShadow_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Func<TextShadow, TextShadow, bool>>(intPtr3) : null;
				}
			}

			// Token: 0x06003EAB RID: 16043 RVA: 0x000FA19C File Offset: 0x000F839C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 336986, XrefRangeEnd = 336987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static bool IsSame(TextShadow a, TextShadow b)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref a;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyAnimationSystem.ValuesTextShadow.NativeMethodInfoPtr_IsSame_Private_Static_Boolean_TextShadow_TextShadow_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06003EAC RID: 16044 RVA: 0x000FA1E8 File Offset: 0x000F83E8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 336987, XrefRangeEnd = 336988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static TextShadow Lerp(TextShadow a, TextShadow b, float t)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref a;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref t;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyAnimationSystem.ValuesTextShadow.NativeMethodInfoPtr_Lerp_Private_Static_TextShadow_TextShadow_TextShadow_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06003EAD RID: 16045 RVA: 0x000FA244 File Offset: 0x000F8444
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 336988, XrefRangeEnd = 336989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void UpdateValues()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyAnimationSystem.ValuesTextShadow.NativeMethodInfoPtr_UpdateValues_Protected_Virtual_Final_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003EAE RID: 16046 RVA: 0x000FA278 File Offset: 0x000F8478
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 336989, XrefRangeEnd = 336991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void UpdateComputedStyle()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyAnimationSystem.ValuesTextShadow.NativeMethodInfoPtr_UpdateComputedStyle_Protected_Virtual_Final_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003EAF RID: 16047 RVA: 0x000FA2AC File Offset: 0x000F84AC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 336991, XrefRangeEnd = 336993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void UpdateComputedStyle(int i)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref i;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyAnimationSystem.ValuesTextShadow.NativeMethodInfoPtr_UpdateComputedStyle_Protected_Virtual_Final_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003EB0 RID: 16048 RVA: 0x000FA2EC File Offset: 0x000F84EC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 336993, XrefRangeEnd = 337003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ValuesTextShadow()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StylePropertyAnimationSystem.ValuesTextShadow>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyAnimationSystem.ValuesTextShadow.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003EB1 RID: 16049 RVA: 0x0001A4FA File Offset: 0x000186FA
			public ValuesTextShadow(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170012E3 RID: 4835
			// (get) Token: 0x06003EB2 RID: 16050 RVA: 0x000FA328 File Offset: 0x000F8528
			// (set) Token: 0x06003EB3 RID: 16051 RVA: 0x0001A503 File Offset: 0x00018703
			public unsafe Func<TextShadow, TextShadow, bool> _SameFunc_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StylePropertyAnimationSystem.ValuesTextShadow.NativeFieldInfoPtr__SameFunc_k__BackingField);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<TextShadow, TextShadow, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StylePropertyAnimationSystem.ValuesTextShadow.NativeFieldInfoPtr__SameFunc_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002C4E RID: 11342
			private static readonly IntPtr NativeFieldInfoPtr__SameFunc_k__BackingField;

			// Token: 0x04002C4F RID: 11343
			private static readonly IntPtr NativeMethodInfoPtr_get_SameFunc_Public_Virtual_get_Func_3_TextShadow_TextShadow_Boolean_0;

			// Token: 0x04002C50 RID: 11344
			private static readonly IntPtr NativeMethodInfoPtr_IsSame_Private_Static_Boolean_TextShadow_TextShadow_0;

			// Token: 0x04002C51 RID: 11345
			private static readonly IntPtr NativeMethodInfoPtr_Lerp_Private_Static_TextShadow_TextShadow_TextShadow_Single_0;

			// Token: 0x04002C52 RID: 11346
			private static readonly IntPtr NativeMethodInfoPtr_UpdateValues_Protected_Virtual_Final_Void_0;

			// Token: 0x04002C53 RID: 11347
			private static readonly IntPtr NativeMethodInfoPtr_UpdateComputedStyle_Protected_Virtual_Final_Void_0;

			// Token: 0x04002C54 RID: 11348
			private static readonly IntPtr NativeMethodInfoPtr_UpdateComputedStyle_Protected_Virtual_Final_Void_Int32_0;

			// Token: 0x04002C55 RID: 11349
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020004CF RID: 1231
		public class ValuesScale : StylePropertyAnimationSystem.Values<Scale>
		{
			// Token: 0x06003EB4 RID: 16052 RVA: 0x000FA358 File Offset: 0x000F8558
			// Note: this type is marked as 'beforefieldinit'.
			static ValuesScale()
			{
				Il2CppClassPointerStore<StylePropertyAnimationSystem.ValuesScale>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StylePropertyAnimationSystem>.NativeClassPtr, "ValuesScale");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StylePropertyAnimationSystem.ValuesScale>.NativeClassPtr);
				StylePropertyAnimationSystem.ValuesScale.NativeFieldInfoPtr__SameFunc_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StylePropertyAnimationSystem.ValuesScale>.NativeClassPtr, "<SameFunc>k__BackingField");
				StylePropertyAnimationSystem.ValuesScale.NativeMethodInfoPtr_get_SameFunc_Public_Virtual_get_Func_3_Scale_Scale_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyAnimationSystem.ValuesScale>.NativeClassPtr, 100668638);
				StylePropertyAnimationSystem.ValuesScale.NativeMethodInfoPtr_IsSame_Private_Static_Boolean_Scale_Scale_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyAnimationSystem.ValuesScale>.NativeClassPtr, 100668639);
				StylePropertyAnimationSystem.ValuesScale.NativeMethodInfoPtr_UpdateComputedStyle_Protected_Virtual_Final_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyAnimationSystem.ValuesScale>.NativeClassPtr, 100668640);
				StylePropertyAnimationSystem.ValuesScale.NativeMethodInfoPtr_UpdateComputedStyle_Protected_Virtual_Final_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyAnimationSystem.ValuesScale>.NativeClassPtr, 100668641);
				StylePropertyAnimationSystem.ValuesScale.NativeMethodInfoPtr_Lerp_Private_Static_Scale_Scale_Scale_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyAnimationSystem.ValuesScale>.NativeClassPtr, 100668642);
				StylePropertyAnimationSystem.ValuesScale.NativeMethodInfoPtr_UpdateValues_Protected_Virtual_Final_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyAnimationSystem.ValuesScale>.NativeClassPtr, 100668643);
				StylePropertyAnimationSystem.ValuesScale.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyAnimationSystem.ValuesScale>.NativeClassPtr, 100668644);
			}

			// Token: 0x170012E6 RID: 4838
			// (get) Token: 0x06003EB5 RID: 16053 RVA: 0x000FA424 File Offset: 0x000F8624
			public unsafe override Func<Scale, Scale, bool> SameFunc
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StylePropertyAnimationSystem.ValuesScale.NativeMethodInfoPtr_get_SameFunc_Public_Virtual_get_Func_3_Scale_Scale_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Func<Scale, Scale, bool>>(intPtr3) : null;
				}
			}

			// Token: 0x06003EB6 RID: 16054 RVA: 0x000FA470 File Offset: 0x000F8670
			[CallerCount(0)]
			public unsafe static bool IsSame(Scale a, Scale b)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref a;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyAnimationSystem.ValuesScale.NativeMethodInfoPtr_IsSame_Private_Static_Boolean_Scale_Scale_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06003EB7 RID: 16055 RVA: 0x000FA4BC File Offset: 0x000F86BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337003, XrefRangeEnd = 337005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void UpdateComputedStyle()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyAnimationSystem.ValuesScale.NativeMethodInfoPtr_UpdateComputedStyle_Protected_Virtual_Final_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003EB8 RID: 16056 RVA: 0x000FA4F0 File Offset: 0x000F86F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337005, XrefRangeEnd = 337007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void UpdateComputedStyle(int i)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref i;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyAnimationSystem.ValuesScale.NativeMethodInfoPtr_UpdateComputedStyle_Protected_Virtual_Final_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003EB9 RID: 16057 RVA: 0x000FA530 File Offset: 0x000F8730
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337007, XrefRangeEnd = 337014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static Scale Lerp(Scale a, Scale b, float t)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref a;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref t;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyAnimationSystem.ValuesScale.NativeMethodInfoPtr_Lerp_Private_Static_Scale_Scale_Scale_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06003EBA RID: 16058 RVA: 0x000FA58C File Offset: 0x000F878C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337014, XrefRangeEnd = 337021, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void UpdateValues()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyAnimationSystem.ValuesScale.NativeMethodInfoPtr_UpdateValues_Protected_Virtual_Final_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003EBB RID: 16059 RVA: 0x000FA5C0 File Offset: 0x000F87C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337021, XrefRangeEnd = 337031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ValuesScale()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StylePropertyAnimationSystem.ValuesScale>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyAnimationSystem.ValuesScale.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003EBC RID: 16060 RVA: 0x0001A522 File Offset: 0x00018722
			public ValuesScale(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170012E5 RID: 4837
			// (get) Token: 0x06003EBD RID: 16061 RVA: 0x000FA5FC File Offset: 0x000F87FC
			// (set) Token: 0x06003EBE RID: 16062 RVA: 0x0001A52B File Offset: 0x0001872B
			public unsafe Func<Scale, Scale, bool> _SameFunc_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StylePropertyAnimationSystem.ValuesScale.NativeFieldInfoPtr__SameFunc_k__BackingField);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Scale, Scale, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StylePropertyAnimationSystem.ValuesScale.NativeFieldInfoPtr__SameFunc_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002C56 RID: 11350
			private static readonly IntPtr NativeFieldInfoPtr__SameFunc_k__BackingField;

			// Token: 0x04002C57 RID: 11351
			private static readonly IntPtr NativeMethodInfoPtr_get_SameFunc_Public_Virtual_get_Func_3_Scale_Scale_Boolean_0;

			// Token: 0x04002C58 RID: 11352
			private static readonly IntPtr NativeMethodInfoPtr_IsSame_Private_Static_Boolean_Scale_Scale_0;

			// Token: 0x04002C59 RID: 11353
			private static readonly IntPtr NativeMethodInfoPtr_UpdateComputedStyle_Protected_Virtual_Final_Void_0;

			// Token: 0x04002C5A RID: 11354
			private static readonly IntPtr NativeMethodInfoPtr_UpdateComputedStyle_Protected_Virtual_Final_Void_Int32_0;

			// Token: 0x04002C5B RID: 11355
			private static readonly IntPtr NativeMethodInfoPtr_Lerp_Private_Static_Scale_Scale_Scale_Single_0;

			// Token: 0x04002C5C RID: 11356
			private static readonly IntPtr NativeMethodInfoPtr_UpdateValues_Protected_Virtual_Final_Void_0;

			// Token: 0x04002C5D RID: 11357
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020004D0 RID: 1232
		public class ValuesRotate : StylePropertyAnimationSystem.Values<Rotate>
		{
			// Token: 0x06003EBF RID: 16063 RVA: 0x000FA62C File Offset: 0x000F882C
			// Note: this type is marked as 'beforefieldinit'.
			static ValuesRotate()
			{
				Il2CppClassPointerStore<StylePropertyAnimationSystem.ValuesRotate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StylePropertyAnimationSystem>.NativeClassPtr, "ValuesRotate");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StylePropertyAnimationSystem.ValuesRotate>.NativeClassPtr);
				StylePropertyAnimationSystem.ValuesRotate.NativeFieldInfoPtr__SameFunc_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StylePropertyAnimationSystem.ValuesRotate>.NativeClassPtr, "<SameFunc>k__BackingField");
				StylePropertyAnimationSystem.ValuesRotate.NativeMethodInfoPtr_get_SameFunc_Public_Virtual_get_Func_3_Rotate_Rotate_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyAnimationSystem.ValuesRotate>.NativeClassPtr, 100668645);
				StylePropertyAnimationSystem.ValuesRotate.NativeMethodInfoPtr_IsSame_Private_Static_Boolean_Rotate_Rotate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyAnimationSystem.ValuesRotate>.NativeClassPtr, 100668646);
				StylePropertyAnimationSystem.ValuesRotate.NativeMethodInfoPtr_UpdateComputedStyle_Protected_Virtual_Final_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyAnimationSystem.ValuesRotate>.NativeClassPtr, 100668647);
				StylePropertyAnimationSystem.ValuesRotate.NativeMethodInfoPtr_UpdateComputedStyle_Protected_Virtual_Final_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyAnimationSystem.ValuesRotate>.NativeClassPtr, 100668648);
				StylePropertyAnimationSystem.ValuesRotate.NativeMethodInfoPtr_Lerp_Private_Static_Rotate_Rotate_Rotate_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyAnimationSystem.ValuesRotate>.NativeClassPtr, 100668649);
				StylePropertyAnimationSystem.ValuesRotate.NativeMethodInfoPtr_UpdateValues_Protected_Virtual_Final_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyAnimationSystem.ValuesRotate>.NativeClassPtr, 100668650);
				StylePropertyAnimationSystem.ValuesRotate.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyAnimationSystem.ValuesRotate>.NativeClassPtr, 100668651);
			}

			// Token: 0x170012E8 RID: 4840
			// (get) Token: 0x06003EC0 RID: 16064 RVA: 0x000FA6F8 File Offset: 0x000F88F8
			public unsafe override Func<Rotate, Rotate, bool> SameFunc
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StylePropertyAnimationSystem.ValuesRotate.NativeMethodInfoPtr_get_SameFunc_Public_Virtual_get_Func_3_Rotate_Rotate_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Func<Rotate, Rotate, bool>>(intPtr3) : null;
				}
			}

			// Token: 0x06003EC1 RID: 16065 RVA: 0x000FA744 File Offset: 0x000F8944
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 334505, RefRangeEnd = 334506, XrefRangeStart = 334505, XrefRangeEnd = 334506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static bool IsSame(Rotate a, Rotate b)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref a;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyAnimationSystem.ValuesRotate.NativeMethodInfoPtr_IsSame_Private_Static_Boolean_Rotate_Rotate_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06003EC2 RID: 16066 RVA: 0x000FA790 File Offset: 0x000F8990
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337031, XrefRangeEnd = 337033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void UpdateComputedStyle()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyAnimationSystem.ValuesRotate.NativeMethodInfoPtr_UpdateComputedStyle_Protected_Virtual_Final_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003EC3 RID: 16067 RVA: 0x000FA7C4 File Offset: 0x000F89C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337033, XrefRangeEnd = 337035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void UpdateComputedStyle(int i)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref i;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyAnimationSystem.ValuesRotate.NativeMethodInfoPtr_UpdateComputedStyle_Protected_Virtual_Final_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003EC4 RID: 16068 RVA: 0x000FA804 File Offset: 0x000F8A04
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337035, XrefRangeEnd = 337040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static Rotate Lerp(Rotate a, Rotate b, float t)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref a;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref t;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyAnimationSystem.ValuesRotate.NativeMethodInfoPtr_Lerp_Private_Static_Rotate_Rotate_Rotate_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06003EC5 RID: 16069 RVA: 0x000FA860 File Offset: 0x000F8A60
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337040, XrefRangeEnd = 337045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void UpdateValues()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyAnimationSystem.ValuesRotate.NativeMethodInfoPtr_UpdateValues_Protected_Virtual_Final_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003EC6 RID: 16070 RVA: 0x000FA894 File Offset: 0x000F8A94
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337045, XrefRangeEnd = 337055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ValuesRotate()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StylePropertyAnimationSystem.ValuesRotate>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyAnimationSystem.ValuesRotate.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003EC7 RID: 16071 RVA: 0x0001A54A File Offset: 0x0001874A
			public ValuesRotate(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170012E7 RID: 4839
			// (get) Token: 0x06003EC8 RID: 16072 RVA: 0x000FA8D0 File Offset: 0x000F8AD0
			// (set) Token: 0x06003EC9 RID: 16073 RVA: 0x0001A553 File Offset: 0x00018753
			public unsafe Func<Rotate, Rotate, bool> _SameFunc_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StylePropertyAnimationSystem.ValuesRotate.NativeFieldInfoPtr__SameFunc_k__BackingField);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Rotate, Rotate, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StylePropertyAnimationSystem.ValuesRotate.NativeFieldInfoPtr__SameFunc_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002C5E RID: 11358
			private static readonly IntPtr NativeFieldInfoPtr__SameFunc_k__BackingField;

			// Token: 0x04002C5F RID: 11359
			private static readonly IntPtr NativeMethodInfoPtr_get_SameFunc_Public_Virtual_get_Func_3_Rotate_Rotate_Boolean_0;

			// Token: 0x04002C60 RID: 11360
			private static readonly IntPtr NativeMethodInfoPtr_IsSame_Private_Static_Boolean_Rotate_Rotate_0;

			// Token: 0x04002C61 RID: 11361
			private static readonly IntPtr NativeMethodInfoPtr_UpdateComputedStyle_Protected_Virtual_Final_Void_0;

			// Token: 0x04002C62 RID: 11362
			private static readonly IntPtr NativeMethodInfoPtr_UpdateComputedStyle_Protected_Virtual_Final_Void_Int32_0;

			// Token: 0x04002C63 RID: 11363
			private static readonly IntPtr NativeMethodInfoPtr_Lerp_Private_Static_Rotate_Rotate_Rotate_Single_0;

			// Token: 0x04002C64 RID: 11364
			private static readonly IntPtr NativeMethodInfoPtr_UpdateValues_Protected_Virtual_Final_Void_0;

			// Token: 0x04002C65 RID: 11365
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020004D1 RID: 1233
		public class ValuesTranslate : StylePropertyAnimationSystem.Values<Translate>
		{
			// Token: 0x06003ECA RID: 16074 RVA: 0x000FA900 File Offset: 0x000F8B00
			// Note: this type is marked as 'beforefieldinit'.
			static ValuesTranslate()
			{
				Il2CppClassPointerStore<StylePropertyAnimationSystem.ValuesTranslate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StylePropertyAnimationSystem>.NativeClassPtr, "ValuesTranslate");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StylePropertyAnimationSystem.ValuesTranslate>.NativeClassPtr);
				StylePropertyAnimationSystem.ValuesTranslate.NativeFieldInfoPtr__SameFunc_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StylePropertyAnimationSystem.ValuesTranslate>.NativeClassPtr, "<SameFunc>k__BackingField");
				StylePropertyAnimationSystem.ValuesTranslate.NativeMethodInfoPtr_get_SameFunc_Public_Virtual_get_Func_3_Translate_Translate_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyAnimationSystem.ValuesTranslate>.NativeClassPtr, 100668652);
				StylePropertyAnimationSystem.ValuesTranslate.NativeMethodInfoPtr_IsSame_Private_Static_Boolean_Translate_Translate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyAnimationSystem.ValuesTranslate>.NativeClassPtr, 100668653);
				StylePropertyAnimationSystem.ValuesTranslate.NativeMethodInfoPtr_ConvertUnits_Protected_Virtual_Final_Boolean_VisualElement_StylePropertyId_byref_Translate_byref_Translate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyAnimationSystem.ValuesTranslate>.NativeClassPtr, 100668654);
				StylePropertyAnimationSystem.ValuesTranslate.NativeMethodInfoPtr_UpdateComputedStyle_Protected_Virtual_Final_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyAnimationSystem.ValuesTranslate>.NativeClassPtr, 100668655);
				StylePropertyAnimationSystem.ValuesTranslate.NativeMethodInfoPtr_UpdateComputedStyle_Protected_Virtual_Final_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyAnimationSystem.ValuesTranslate>.NativeClassPtr, 100668656);
				StylePropertyAnimationSystem.ValuesTranslate.NativeMethodInfoPtr_Lerp_Private_Static_Translate_Translate_Translate_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyAnimationSystem.ValuesTranslate>.NativeClassPtr, 100668657);
				StylePropertyAnimationSystem.ValuesTranslate.NativeMethodInfoPtr_UpdateValues_Protected_Virtual_Final_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyAnimationSystem.ValuesTranslate>.NativeClassPtr, 100668658);
				StylePropertyAnimationSystem.ValuesTranslate.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyAnimationSystem.ValuesTranslate>.NativeClassPtr, 100668659);
			}

			// Token: 0x170012EA RID: 4842
			// (get) Token: 0x06003ECB RID: 16075 RVA: 0x000FA9E0 File Offset: 0x000F8BE0
			public unsafe override Func<Translate, Translate, bool> SameFunc
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StylePropertyAnimationSystem.ValuesTranslate.NativeMethodInfoPtr_get_SameFunc_Public_Virtual_get_Func_3_Translate_Translate_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Func<Translate, Translate, bool>>(intPtr3) : null;
				}
			}

			// Token: 0x06003ECC RID: 16076 RVA: 0x000FAA2C File Offset: 0x000F8C2C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337055, XrefRangeEnd = 337056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static bool IsSame(Translate a, Translate b)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref a;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyAnimationSystem.ValuesTranslate.NativeMethodInfoPtr_IsSame_Private_Static_Boolean_Translate_Translate_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06003ECD RID: 16077 RVA: 0x000FAA78 File Offset: 0x000F8C78
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337056, XrefRangeEnd = 337058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override bool ConvertUnits(VisualElement owner, UnityEngine.UIElements.StyleSheets.StylePropertyId prop, ref Translate a, ref Translate b)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(owner);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref prop;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &a;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &b;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyAnimationSystem.ValuesTranslate.NativeMethodInfoPtr_ConvertUnits_Protected_Virtual_Final_Boolean_VisualElement_StylePropertyId_byref_Translate_byref_Translate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06003ECE RID: 16078 RVA: 0x000FAAF0 File Offset: 0x000F8CF0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337058, XrefRangeEnd = 337060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void UpdateComputedStyle()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyAnimationSystem.ValuesTranslate.NativeMethodInfoPtr_UpdateComputedStyle_Protected_Virtual_Final_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003ECF RID: 16079 RVA: 0x000FAB24 File Offset: 0x000F8D24
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337060, XrefRangeEnd = 337062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void UpdateComputedStyle(int i)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref i;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyAnimationSystem.ValuesTranslate.NativeMethodInfoPtr_UpdateComputedStyle_Protected_Virtual_Final_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003ED0 RID: 16080 RVA: 0x000FAB64 File Offset: 0x000F8D64
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337062, XrefRangeEnd = 337065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static Translate Lerp(Translate a, Translate b, float t)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref a;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref t;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyAnimationSystem.ValuesTranslate.NativeMethodInfoPtr_Lerp_Private_Static_Translate_Translate_Translate_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06003ED1 RID: 16081 RVA: 0x000FABC0 File Offset: 0x000F8DC0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337065, XrefRangeEnd = 337068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void UpdateValues()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyAnimationSystem.ValuesTranslate.NativeMethodInfoPtr_UpdateValues_Protected_Virtual_Final_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003ED2 RID: 16082 RVA: 0x000FABF4 File Offset: 0x000F8DF4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337068, XrefRangeEnd = 337078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ValuesTranslate()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StylePropertyAnimationSystem.ValuesTranslate>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyAnimationSystem.ValuesTranslate.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003ED3 RID: 16083 RVA: 0x0001A572 File Offset: 0x00018772
			public ValuesTranslate(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170012E9 RID: 4841
			// (get) Token: 0x06003ED4 RID: 16084 RVA: 0x000FAC30 File Offset: 0x000F8E30
			// (set) Token: 0x06003ED5 RID: 16085 RVA: 0x0001A57B File Offset: 0x0001877B
			public unsafe Func<Translate, Translate, bool> _SameFunc_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StylePropertyAnimationSystem.ValuesTranslate.NativeFieldInfoPtr__SameFunc_k__BackingField);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Translate, Translate, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StylePropertyAnimationSystem.ValuesTranslate.NativeFieldInfoPtr__SameFunc_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002C66 RID: 11366
			private static readonly IntPtr NativeFieldInfoPtr__SameFunc_k__BackingField;

			// Token: 0x04002C67 RID: 11367
			private static readonly IntPtr NativeMethodInfoPtr_get_SameFunc_Public_Virtual_get_Func_3_Translate_Translate_Boolean_0;

			// Token: 0x04002C68 RID: 11368
			private static readonly IntPtr NativeMethodInfoPtr_IsSame_Private_Static_Boolean_Translate_Translate_0;

			// Token: 0x04002C69 RID: 11369
			private static readonly IntPtr NativeMethodInfoPtr_ConvertUnits_Protected_Virtual_Final_Boolean_VisualElement_StylePropertyId_byref_Translate_byref_Translate_0;

			// Token: 0x04002C6A RID: 11370
			private static readonly IntPtr NativeMethodInfoPtr_UpdateComputedStyle_Protected_Virtual_Final_Void_0;

			// Token: 0x04002C6B RID: 11371
			private static readonly IntPtr NativeMethodInfoPtr_UpdateComputedStyle_Protected_Virtual_Final_Void_Int32_0;

			// Token: 0x04002C6C RID: 11372
			private static readonly IntPtr NativeMethodInfoPtr_Lerp_Private_Static_Translate_Translate_Translate_Single_0;

			// Token: 0x04002C6D RID: 11373
			private static readonly IntPtr NativeMethodInfoPtr_UpdateValues_Protected_Virtual_Final_Void_0;

			// Token: 0x04002C6E RID: 11374
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020004D2 RID: 1234
		public class ValuesTransformOrigin : StylePropertyAnimationSystem.Values<TransformOrigin>
		{
			// Token: 0x06003ED6 RID: 16086 RVA: 0x000FAC60 File Offset: 0x000F8E60
			// Note: this type is marked as 'beforefieldinit'.
			static ValuesTransformOrigin()
			{
				Il2CppClassPointerStore<StylePropertyAnimationSystem.ValuesTransformOrigin>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StylePropertyAnimationSystem>.NativeClassPtr, "ValuesTransformOrigin");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StylePropertyAnimationSystem.ValuesTransformOrigin>.NativeClassPtr);
				StylePropertyAnimationSystem.ValuesTransformOrigin.NativeFieldInfoPtr__SameFunc_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StylePropertyAnimationSystem.ValuesTransformOrigin>.NativeClassPtr, "<SameFunc>k__BackingField");
				StylePropertyAnimationSystem.ValuesTransformOrigin.NativeMethodInfoPtr_get_SameFunc_Public_Virtual_get_Func_3_TransformOrigin_TransformOrigin_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyAnimationSystem.ValuesTransformOrigin>.NativeClassPtr, 100668660);
				StylePropertyAnimationSystem.ValuesTransformOrigin.NativeMethodInfoPtr_IsSame_Private_Static_Boolean_TransformOrigin_TransformOrigin_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyAnimationSystem.ValuesTransformOrigin>.NativeClassPtr, 100668661);
				StylePropertyAnimationSystem.ValuesTransformOrigin.NativeMethodInfoPtr_ConvertUnits_Protected_Virtual_Final_Boolean_VisualElement_StylePropertyId_byref_TransformOrigin_byref_TransformOrigin_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyAnimationSystem.ValuesTransformOrigin>.NativeClassPtr, 100668662);
				StylePropertyAnimationSystem.ValuesTransformOrigin.NativeMethodInfoPtr_UpdateComputedStyle_Protected_Virtual_Final_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyAnimationSystem.ValuesTransformOrigin>.NativeClassPtr, 100668663);
				StylePropertyAnimationSystem.ValuesTransformOrigin.NativeMethodInfoPtr_UpdateComputedStyle_Protected_Virtual_Final_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyAnimationSystem.ValuesTransformOrigin>.NativeClassPtr, 100668664);
				StylePropertyAnimationSystem.ValuesTransformOrigin.NativeMethodInfoPtr_Lerp_Private_Static_TransformOrigin_TransformOrigin_TransformOrigin_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyAnimationSystem.ValuesTransformOrigin>.NativeClassPtr, 100668665);
				StylePropertyAnimationSystem.ValuesTransformOrigin.NativeMethodInfoPtr_UpdateValues_Protected_Virtual_Final_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyAnimationSystem.ValuesTransformOrigin>.NativeClassPtr, 100668666);
				StylePropertyAnimationSystem.ValuesTransformOrigin.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyAnimationSystem.ValuesTransformOrigin>.NativeClassPtr, 100668667);
			}

			// Token: 0x170012EC RID: 4844
			// (get) Token: 0x06003ED7 RID: 16087 RVA: 0x000FAD40 File Offset: 0x000F8F40
			public unsafe override Func<TransformOrigin, TransformOrigin, bool> SameFunc
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StylePropertyAnimationSystem.ValuesTransformOrigin.NativeMethodInfoPtr_get_SameFunc_Public_Virtual_get_Func_3_TransformOrigin_TransformOrigin_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Func<TransformOrigin, TransformOrigin, bool>>(intPtr3) : null;
				}
			}

			// Token: 0x06003ED8 RID: 16088 RVA: 0x000FAD8C File Offset: 0x000F8F8C
			[CallerCount(0)]
			public unsafe static bool IsSame(TransformOrigin a, TransformOrigin b)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref a;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyAnimationSystem.ValuesTransformOrigin.NativeMethodInfoPtr_IsSame_Private_Static_Boolean_TransformOrigin_TransformOrigin_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06003ED9 RID: 16089 RVA: 0x000FADD8 File Offset: 0x000F8FD8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337078, XrefRangeEnd = 337080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override bool ConvertUnits(VisualElement owner, UnityEngine.UIElements.StyleSheets.StylePropertyId prop, ref TransformOrigin a, ref TransformOrigin b)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(owner);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref prop;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &a;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &b;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyAnimationSystem.ValuesTransformOrigin.NativeMethodInfoPtr_ConvertUnits_Protected_Virtual_Final_Boolean_VisualElement_StylePropertyId_byref_TransformOrigin_byref_TransformOrigin_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06003EDA RID: 16090 RVA: 0x000FAE50 File Offset: 0x000F9050
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337080, XrefRangeEnd = 337082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void UpdateComputedStyle()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyAnimationSystem.ValuesTransformOrigin.NativeMethodInfoPtr_UpdateComputedStyle_Protected_Virtual_Final_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003EDB RID: 16091 RVA: 0x000FAE84 File Offset: 0x000F9084
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337082, XrefRangeEnd = 337084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void UpdateComputedStyle(int i)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref i;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyAnimationSystem.ValuesTransformOrigin.NativeMethodInfoPtr_UpdateComputedStyle_Protected_Virtual_Final_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003EDC RID: 16092 RVA: 0x000FAEC4 File Offset: 0x000F90C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337084, XrefRangeEnd = 337087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static TransformOrigin Lerp(TransformOrigin a, TransformOrigin b, float t)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref a;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref t;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyAnimationSystem.ValuesTransformOrigin.NativeMethodInfoPtr_Lerp_Private_Static_TransformOrigin_TransformOrigin_TransformOrigin_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06003EDD RID: 16093 RVA: 0x000FAF20 File Offset: 0x000F9120
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337087, XrefRangeEnd = 337090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void UpdateValues()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyAnimationSystem.ValuesTransformOrigin.NativeMethodInfoPtr_UpdateValues_Protected_Virtual_Final_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003EDE RID: 16094 RVA: 0x000FAF54 File Offset: 0x000F9154
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337090, XrefRangeEnd = 337100, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ValuesTransformOrigin()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StylePropertyAnimationSystem.ValuesTransformOrigin>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyAnimationSystem.ValuesTransformOrigin.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003EDF RID: 16095 RVA: 0x0001A59A File Offset: 0x0001879A
			public ValuesTransformOrigin(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170012EB RID: 4843
			// (get) Token: 0x06003EE0 RID: 16096 RVA: 0x000FAF90 File Offset: 0x000F9190
			// (set) Token: 0x06003EE1 RID: 16097 RVA: 0x0001A5A3 File Offset: 0x000187A3
			public unsafe Func<TransformOrigin, TransformOrigin, bool> _SameFunc_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StylePropertyAnimationSystem.ValuesTransformOrigin.NativeFieldInfoPtr__SameFunc_k__BackingField);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<TransformOrigin, TransformOrigin, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StylePropertyAnimationSystem.ValuesTransformOrigin.NativeFieldInfoPtr__SameFunc_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002C6F RID: 11375
			private static readonly IntPtr NativeFieldInfoPtr__SameFunc_k__BackingField;

			// Token: 0x04002C70 RID: 11376
			private static readonly IntPtr NativeMethodInfoPtr_get_SameFunc_Public_Virtual_get_Func_3_TransformOrigin_TransformOrigin_Boolean_0;

			// Token: 0x04002C71 RID: 11377
			private static readonly IntPtr NativeMethodInfoPtr_IsSame_Private_Static_Boolean_TransformOrigin_TransformOrigin_0;

			// Token: 0x04002C72 RID: 11378
			private static readonly IntPtr NativeMethodInfoPtr_ConvertUnits_Protected_Virtual_Final_Boolean_VisualElement_StylePropertyId_byref_TransformOrigin_byref_TransformOrigin_0;

			// Token: 0x04002C73 RID: 11379
			private static readonly IntPtr NativeMethodInfoPtr_UpdateComputedStyle_Protected_Virtual_Final_Void_0;

			// Token: 0x04002C74 RID: 11380
			private static readonly IntPtr NativeMethodInfoPtr_UpdateComputedStyle_Protected_Virtual_Final_Void_Int32_0;

			// Token: 0x04002C75 RID: 11381
			private static readonly IntPtr NativeMethodInfoPtr_Lerp_Private_Static_TransformOrigin_TransformOrigin_TransformOrigin_Single_0;

			// Token: 0x04002C76 RID: 11382
			private static readonly IntPtr NativeMethodInfoPtr_UpdateValues_Protected_Virtual_Final_Void_0;

			// Token: 0x04002C77 RID: 11383
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020004D3 RID: 1235
		public class ValuesBackgroundPosition : StylePropertyAnimationSystem.ValuesDiscrete<BackgroundPosition>
		{
			// Token: 0x06003EE2 RID: 16098 RVA: 0x000FAFC0 File Offset: 0x000F91C0
			// Note: this type is marked as 'beforefieldinit'.
			static ValuesBackgroundPosition()
			{
				Il2CppClassPointerStore<StylePropertyAnimationSystem.ValuesBackgroundPosition>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StylePropertyAnimationSystem>.NativeClassPtr, "ValuesBackgroundPosition");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StylePropertyAnimationSystem.ValuesBackgroundPosition>.NativeClassPtr);
				StylePropertyAnimationSystem.ValuesBackgroundPosition.NativeMethodInfoPtr_UpdateComputedStyle_Protected_Virtual_Final_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyAnimationSystem.ValuesBackgroundPosition>.NativeClassPtr, 100668668);
				StylePropertyAnimationSystem.ValuesBackgroundPosition.NativeMethodInfoPtr_UpdateComputedStyle_Protected_Virtual_Final_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyAnimationSystem.ValuesBackgroundPosition>.NativeClassPtr, 100668669);
				StylePropertyAnimationSystem.ValuesBackgroundPosition.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyAnimationSystem.ValuesBackgroundPosition>.NativeClassPtr, 100668670);
			}

			// Token: 0x06003EE3 RID: 16099 RVA: 0x000FB028 File Offset: 0x000F9228
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337100, XrefRangeEnd = 337102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void UpdateComputedStyle()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyAnimationSystem.ValuesBackgroundPosition.NativeMethodInfoPtr_UpdateComputedStyle_Protected_Virtual_Final_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003EE4 RID: 16100 RVA: 0x000FB05C File Offset: 0x000F925C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337102, XrefRangeEnd = 337104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void UpdateComputedStyle(int i)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref i;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyAnimationSystem.ValuesBackgroundPosition.NativeMethodInfoPtr_UpdateComputedStyle_Protected_Virtual_Final_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003EE5 RID: 16101 RVA: 0x000FB09C File Offset: 0x000F929C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337104, XrefRangeEnd = 337107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ValuesBackgroundPosition()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StylePropertyAnimationSystem.ValuesBackgroundPosition>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyAnimationSystem.ValuesBackgroundPosition.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003EE6 RID: 16102 RVA: 0x0001A5C2 File Offset: 0x000187C2
			public ValuesBackgroundPosition(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04002C78 RID: 11384
			private static readonly IntPtr NativeMethodInfoPtr_UpdateComputedStyle_Protected_Virtual_Final_Void_0;

			// Token: 0x04002C79 RID: 11385
			private static readonly IntPtr NativeMethodInfoPtr_UpdateComputedStyle_Protected_Virtual_Final_Void_Int32_0;

			// Token: 0x04002C7A RID: 11386
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020004D4 RID: 1236
		public class ValuesBackgroundRepeat : StylePropertyAnimationSystem.ValuesDiscrete<BackgroundRepeat>
		{
			// Token: 0x06003EE7 RID: 16103 RVA: 0x000FB0D8 File Offset: 0x000F92D8
			// Note: this type is marked as 'beforefieldinit'.
			static ValuesBackgroundRepeat()
			{
				Il2CppClassPointerStore<StylePropertyAnimationSystem.ValuesBackgroundRepeat>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StylePropertyAnimationSystem>.NativeClassPtr, "ValuesBackgroundRepeat");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StylePropertyAnimationSystem.ValuesBackgroundRepeat>.NativeClassPtr);
				StylePropertyAnimationSystem.ValuesBackgroundRepeat.NativeMethodInfoPtr_UpdateComputedStyle_Protected_Virtual_Final_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyAnimationSystem.ValuesBackgroundRepeat>.NativeClassPtr, 100668671);
				StylePropertyAnimationSystem.ValuesBackgroundRepeat.NativeMethodInfoPtr_UpdateComputedStyle_Protected_Virtual_Final_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyAnimationSystem.ValuesBackgroundRepeat>.NativeClassPtr, 100668672);
				StylePropertyAnimationSystem.ValuesBackgroundRepeat.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyAnimationSystem.ValuesBackgroundRepeat>.NativeClassPtr, 100668673);
			}

			// Token: 0x06003EE8 RID: 16104 RVA: 0x000FB140 File Offset: 0x000F9340
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337107, XrefRangeEnd = 337109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void UpdateComputedStyle()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyAnimationSystem.ValuesBackgroundRepeat.NativeMethodInfoPtr_UpdateComputedStyle_Protected_Virtual_Final_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003EE9 RID: 16105 RVA: 0x000FB174 File Offset: 0x000F9374
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337109, XrefRangeEnd = 337111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void UpdateComputedStyle(int i)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref i;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyAnimationSystem.ValuesBackgroundRepeat.NativeMethodInfoPtr_UpdateComputedStyle_Protected_Virtual_Final_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003EEA RID: 16106 RVA: 0x000FB1B4 File Offset: 0x000F93B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337111, XrefRangeEnd = 337114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ValuesBackgroundRepeat()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StylePropertyAnimationSystem.ValuesBackgroundRepeat>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyAnimationSystem.ValuesBackgroundRepeat.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003EEB RID: 16107 RVA: 0x0001A5CB File Offset: 0x000187CB
			public ValuesBackgroundRepeat(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04002C7B RID: 11387
			private static readonly IntPtr NativeMethodInfoPtr_UpdateComputedStyle_Protected_Virtual_Final_Void_0;

			// Token: 0x04002C7C RID: 11388
			private static readonly IntPtr NativeMethodInfoPtr_UpdateComputedStyle_Protected_Virtual_Final_Void_Int32_0;

			// Token: 0x04002C7D RID: 11389
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020004D5 RID: 1237
		public class ValuesBackgroundSize : StylePropertyAnimationSystem.Values<BackgroundSize>
		{
			// Token: 0x06003EEC RID: 16108 RVA: 0x000FB1F0 File Offset: 0x000F93F0
			// Note: this type is marked as 'beforefieldinit'.
			static ValuesBackgroundSize()
			{
				Il2CppClassPointerStore<StylePropertyAnimationSystem.ValuesBackgroundSize>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StylePropertyAnimationSystem>.NativeClassPtr, "ValuesBackgroundSize");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StylePropertyAnimationSystem.ValuesBackgroundSize>.NativeClassPtr);
				StylePropertyAnimationSystem.ValuesBackgroundSize.NativeFieldInfoPtr__SameFunc_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StylePropertyAnimationSystem.ValuesBackgroundSize>.NativeClassPtr, "<SameFunc>k__BackingField");
				StylePropertyAnimationSystem.ValuesBackgroundSize.NativeMethodInfoPtr_get_SameFunc_Public_Virtual_get_Func_3_BackgroundSize_BackgroundSize_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyAnimationSystem.ValuesBackgroundSize>.NativeClassPtr, 100668674);
				StylePropertyAnimationSystem.ValuesBackgroundSize.NativeMethodInfoPtr_IsSame_Private_Static_Boolean_BackgroundSize_BackgroundSize_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyAnimationSystem.ValuesBackgroundSize>.NativeClassPtr, 100668675);
				StylePropertyAnimationSystem.ValuesBackgroundSize.NativeMethodInfoPtr_ConvertUnits_Protected_Virtual_Final_Boolean_VisualElement_StylePropertyId_byref_BackgroundSize_byref_BackgroundSize_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyAnimationSystem.ValuesBackgroundSize>.NativeClassPtr, 100668676);
				StylePropertyAnimationSystem.ValuesBackgroundSize.NativeMethodInfoPtr_UpdateComputedStyle_Protected_Virtual_Final_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyAnimationSystem.ValuesBackgroundSize>.NativeClassPtr, 100668677);
				StylePropertyAnimationSystem.ValuesBackgroundSize.NativeMethodInfoPtr_UpdateComputedStyle_Protected_Virtual_Final_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyAnimationSystem.ValuesBackgroundSize>.NativeClassPtr, 100668678);
				StylePropertyAnimationSystem.ValuesBackgroundSize.NativeMethodInfoPtr_Lerp_Private_Static_BackgroundSize_BackgroundSize_BackgroundSize_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyAnimationSystem.ValuesBackgroundSize>.NativeClassPtr, 100668679);
				StylePropertyAnimationSystem.ValuesBackgroundSize.NativeMethodInfoPtr_UpdateValues_Protected_Virtual_Final_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyAnimationSystem.ValuesBackgroundSize>.NativeClassPtr, 100668680);
				StylePropertyAnimationSystem.ValuesBackgroundSize.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyAnimationSystem.ValuesBackgroundSize>.NativeClassPtr, 100668681);
			}

			// Token: 0x170012EE RID: 4846
			// (get) Token: 0x06003EED RID: 16109 RVA: 0x000FB2D0 File Offset: 0x000F94D0
			public unsafe override Func<BackgroundSize, BackgroundSize, bool> SameFunc
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StylePropertyAnimationSystem.ValuesBackgroundSize.NativeMethodInfoPtr_get_SameFunc_Public_Virtual_get_Func_3_BackgroundSize_BackgroundSize_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Func<BackgroundSize, BackgroundSize, bool>>(intPtr3) : null;
				}
			}

			// Token: 0x06003EEE RID: 16110 RVA: 0x000FB31C File Offset: 0x000F951C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337114, XrefRangeEnd = 337115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static bool IsSame(BackgroundSize a, BackgroundSize b)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref a;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyAnimationSystem.ValuesBackgroundSize.NativeMethodInfoPtr_IsSame_Private_Static_Boolean_BackgroundSize_BackgroundSize_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06003EEF RID: 16111 RVA: 0x000FB368 File Offset: 0x000F9568
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337115, XrefRangeEnd = 337117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override bool ConvertUnits(VisualElement owner, UnityEngine.UIElements.StyleSheets.StylePropertyId prop, ref BackgroundSize a, ref BackgroundSize b)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(owner);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref prop;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &a;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &b;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyAnimationSystem.ValuesBackgroundSize.NativeMethodInfoPtr_ConvertUnits_Protected_Virtual_Final_Boolean_VisualElement_StylePropertyId_byref_BackgroundSize_byref_BackgroundSize_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06003EF0 RID: 16112 RVA: 0x000FB3E0 File Offset: 0x000F95E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337117, XrefRangeEnd = 337119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void UpdateComputedStyle()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyAnimationSystem.ValuesBackgroundSize.NativeMethodInfoPtr_UpdateComputedStyle_Protected_Virtual_Final_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003EF1 RID: 16113 RVA: 0x000FB414 File Offset: 0x000F9614
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337119, XrefRangeEnd = 337121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void UpdateComputedStyle(int i)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref i;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyAnimationSystem.ValuesBackgroundSize.NativeMethodInfoPtr_UpdateComputedStyle_Protected_Virtual_Final_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003EF2 RID: 16114 RVA: 0x000FB454 File Offset: 0x000F9654
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337121, XrefRangeEnd = 337128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static BackgroundSize Lerp(BackgroundSize a, BackgroundSize b, float t)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref a;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref t;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyAnimationSystem.ValuesBackgroundSize.NativeMethodInfoPtr_Lerp_Private_Static_BackgroundSize_BackgroundSize_BackgroundSize_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06003EF3 RID: 16115 RVA: 0x000FB4B0 File Offset: 0x000F96B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337128, XrefRangeEnd = 337135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void UpdateValues()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyAnimationSystem.ValuesBackgroundSize.NativeMethodInfoPtr_UpdateValues_Protected_Virtual_Final_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003EF4 RID: 16116 RVA: 0x000FB4E4 File Offset: 0x000F96E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337135, XrefRangeEnd = 337145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ValuesBackgroundSize()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StylePropertyAnimationSystem.ValuesBackgroundSize>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyAnimationSystem.ValuesBackgroundSize.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003EF5 RID: 16117 RVA: 0x0001A5D4 File Offset: 0x000187D4
			public ValuesBackgroundSize(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170012ED RID: 4845
			// (get) Token: 0x06003EF6 RID: 16118 RVA: 0x000FB520 File Offset: 0x000F9720
			// (set) Token: 0x06003EF7 RID: 16119 RVA: 0x0001A5DD File Offset: 0x000187DD
			public unsafe Func<BackgroundSize, BackgroundSize, bool> _SameFunc_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StylePropertyAnimationSystem.ValuesBackgroundSize.NativeFieldInfoPtr__SameFunc_k__BackingField);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<BackgroundSize, BackgroundSize, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StylePropertyAnimationSystem.ValuesBackgroundSize.NativeFieldInfoPtr__SameFunc_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002C7E RID: 11390
			private static readonly IntPtr NativeFieldInfoPtr__SameFunc_k__BackingField;

			// Token: 0x04002C7F RID: 11391
			private static readonly IntPtr NativeMethodInfoPtr_get_SameFunc_Public_Virtual_get_Func_3_BackgroundSize_BackgroundSize_Boolean_0;

			// Token: 0x04002C80 RID: 11392
			private static readonly IntPtr NativeMethodInfoPtr_IsSame_Private_Static_Boolean_BackgroundSize_BackgroundSize_0;

			// Token: 0x04002C81 RID: 11393
			private static readonly IntPtr NativeMethodInfoPtr_ConvertUnits_Protected_Virtual_Final_Boolean_VisualElement_StylePropertyId_byref_BackgroundSize_byref_BackgroundSize_0;

			// Token: 0x04002C82 RID: 11394
			private static readonly IntPtr NativeMethodInfoPtr_UpdateComputedStyle_Protected_Virtual_Final_Void_0;

			// Token: 0x04002C83 RID: 11395
			private static readonly IntPtr NativeMethodInfoPtr_UpdateComputedStyle_Protected_Virtual_Final_Void_Int32_0;

			// Token: 0x04002C84 RID: 11396
			private static readonly IntPtr NativeMethodInfoPtr_Lerp_Private_Static_BackgroundSize_BackgroundSize_BackgroundSize_Single_0;

			// Token: 0x04002C85 RID: 11397
			private static readonly IntPtr NativeMethodInfoPtr_UpdateValues_Protected_Virtual_Final_Void_0;

			// Token: 0x04002C86 RID: 11398
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020004D6 RID: 1238
		private sealed class MethodInfoStoreGeneric_GetOrCreate_Private_T_byref_T_0<T>
		{
			// Token: 0x04002C87 RID: 11399
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(StylePropertyAnimationSystem.NativeMethodInfoPtr_GetOrCreate_Private_T_byref_T_0, Il2CppClassPointerStore<StylePropertyAnimationSystem>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020004D7 RID: 1239
		private sealed class MethodInfoStoreGeneric_StartTransition_Private_Boolean_VisualElement_StylePropertyId_T_T_Int32_Int32_Func_2_Single_Single_Values_1_T_0<T>
		{
			// Token: 0x04002C88 RID: 11400
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(StylePropertyAnimationSystem.NativeMethodInfoPtr_StartTransition_Private_Boolean_VisualElement_StylePropertyId_T_T_Int32_Int32_Func_2_Single_Single_Values_1_T_0, Il2CppClassPointerStore<StylePropertyAnimationSystem>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020004D8 RID: 1240
		private sealed class MethodInfoStoreGeneric_UpdateTracking_Private_Void_Values_1_T_0<T>
		{
			// Token: 0x04002C89 RID: 11401
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(StylePropertyAnimationSystem.NativeMethodInfoPtr_UpdateTracking_Private_Void_Values_1_T_0, Il2CppClassPointerStore<StylePropertyAnimationSystem>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020004D9 RID: 1241
		public class ValuesEnum : StylePropertyAnimationSystem.ValuesDiscrete<int>
		{
		}
	}
}
