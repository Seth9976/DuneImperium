using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.UIElements.StyleSheets;

namespace UnityEngine.UIElements
{
	// Token: 0x020001BE RID: 446
	public class IStylePropertyAnimationSystem : Il2CppObjectBase
	{
		// Token: 0x060022EF RID: 8943 RVA: 0x0009D418 File Offset: 0x0009B618
		// Note: this type is marked as 'beforefieldinit'.
		static IStylePropertyAnimationSystem()
		{
			Il2CppClassPointerStore<IStylePropertyAnimationSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "IStylePropertyAnimationSystem");
			IStylePropertyAnimationSystem.NativeMethodInfoPtr_StartTransition_Public_Abstract_Virtual_New_Boolean_VisualElement_StylePropertyId_Single_Single_Int32_Int32_Func_2_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStylePropertyAnimationSystem>.NativeClassPtr, 100668479);
			IStylePropertyAnimationSystem.NativeMethodInfoPtr_StartTransition_Public_Abstract_Virtual_New_Boolean_VisualElement_StylePropertyId_Int32_Int32_Int32_Int32_Func_2_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStylePropertyAnimationSystem>.NativeClassPtr, 100668480);
			IStylePropertyAnimationSystem.NativeMethodInfoPtr_StartTransition_Public_Abstract_Virtual_New_Boolean_VisualElement_StylePropertyId_Length_Length_Int32_Int32_Func_2_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStylePropertyAnimationSystem>.NativeClassPtr, 100668481);
			IStylePropertyAnimationSystem.NativeMethodInfoPtr_StartTransition_Public_Abstract_Virtual_New_Boolean_VisualElement_StylePropertyId_Color_Color_Int32_Int32_Func_2_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStylePropertyAnimationSystem>.NativeClassPtr, 100668482);
			IStylePropertyAnimationSystem.NativeMethodInfoPtr_StartTransition_Public_Abstract_Virtual_New_Boolean_VisualElement_StylePropertyId_Background_Background_Int32_Int32_Func_2_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStylePropertyAnimationSystem>.NativeClassPtr, 100668483);
			IStylePropertyAnimationSystem.NativeMethodInfoPtr_StartTransition_Public_Abstract_Virtual_New_Boolean_VisualElement_StylePropertyId_FontDefinition_FontDefinition_Int32_Int32_Func_2_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStylePropertyAnimationSystem>.NativeClassPtr, 100668484);
			IStylePropertyAnimationSystem.NativeMethodInfoPtr_StartTransition_Public_Abstract_Virtual_New_Boolean_VisualElement_StylePropertyId_Font_Font_Int32_Int32_Func_2_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStylePropertyAnimationSystem>.NativeClassPtr, 100668485);
			IStylePropertyAnimationSystem.NativeMethodInfoPtr_StartTransition_Public_Abstract_Virtual_New_Boolean_VisualElement_StylePropertyId_TextShadow_TextShadow_Int32_Int32_Func_2_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStylePropertyAnimationSystem>.NativeClassPtr, 100668486);
			IStylePropertyAnimationSystem.NativeMethodInfoPtr_StartTransition_Public_Abstract_Virtual_New_Boolean_VisualElement_StylePropertyId_Scale_Scale_Int32_Int32_Func_2_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStylePropertyAnimationSystem>.NativeClassPtr, 100668487);
			IStylePropertyAnimationSystem.NativeMethodInfoPtr_StartTransition_Public_Abstract_Virtual_New_Boolean_VisualElement_StylePropertyId_TransformOrigin_TransformOrigin_Int32_Int32_Func_2_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStylePropertyAnimationSystem>.NativeClassPtr, 100668488);
			IStylePropertyAnimationSystem.NativeMethodInfoPtr_StartTransition_Public_Abstract_Virtual_New_Boolean_VisualElement_StylePropertyId_Translate_Translate_Int32_Int32_Func_2_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStylePropertyAnimationSystem>.NativeClassPtr, 100668489);
			IStylePropertyAnimationSystem.NativeMethodInfoPtr_StartTransition_Public_Abstract_Virtual_New_Boolean_VisualElement_StylePropertyId_Rotate_Rotate_Int32_Int32_Func_2_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStylePropertyAnimationSystem>.NativeClassPtr, 100668490);
			IStylePropertyAnimationSystem.NativeMethodInfoPtr_StartTransition_Public_Abstract_Virtual_New_Boolean_VisualElement_StylePropertyId_BackgroundPosition_BackgroundPosition_Int32_Int32_Func_2_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStylePropertyAnimationSystem>.NativeClassPtr, 100668491);
			IStylePropertyAnimationSystem.NativeMethodInfoPtr_StartTransition_Public_Abstract_Virtual_New_Boolean_VisualElement_StylePropertyId_BackgroundRepeat_BackgroundRepeat_Int32_Int32_Func_2_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStylePropertyAnimationSystem>.NativeClassPtr, 100668492);
			IStylePropertyAnimationSystem.NativeMethodInfoPtr_StartTransition_Public_Abstract_Virtual_New_Boolean_VisualElement_StylePropertyId_BackgroundSize_BackgroundSize_Int32_Int32_Func_2_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStylePropertyAnimationSystem>.NativeClassPtr, 100668493);
			IStylePropertyAnimationSystem.NativeMethodInfoPtr_CancelAllAnimations_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStylePropertyAnimationSystem>.NativeClassPtr, 100668494);
			IStylePropertyAnimationSystem.NativeMethodInfoPtr_CancelAllAnimations_Public_Abstract_Virtual_New_Void_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStylePropertyAnimationSystem>.NativeClassPtr, 100668495);
			IStylePropertyAnimationSystem.NativeMethodInfoPtr_CancelAnimation_Public_Abstract_Virtual_New_Void_VisualElement_StylePropertyId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStylePropertyAnimationSystem>.NativeClassPtr, 100668496);
			IStylePropertyAnimationSystem.NativeMethodInfoPtr_UpdateAnimation_Public_Abstract_Virtual_New_Void_VisualElement_StylePropertyId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStylePropertyAnimationSystem>.NativeClassPtr, 100668497);
			IStylePropertyAnimationSystem.NativeMethodInfoPtr_GetAllAnimations_Public_Abstract_Virtual_New_Void_VisualElement_List_1_StylePropertyId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStylePropertyAnimationSystem>.NativeClassPtr, 100668498);
			IStylePropertyAnimationSystem.NativeMethodInfoPtr_Update_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStylePropertyAnimationSystem>.NativeClassPtr, 100668499);
		}

		// Token: 0x060022F0 RID: 8944 RVA: 0x0009D5E4 File Offset: 0x0009B7E4
		[CallerCount(0)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IStylePropertyAnimationSystem.NativeMethodInfoPtr_StartTransition_Public_Abstract_Virtual_New_Boolean_VisualElement_StylePropertyId_Single_Single_Int32_Int32_Func_2_Single_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060022F1 RID: 8945 RVA: 0x0009D698 File Offset: 0x0009B898
		[CallerCount(0)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IStylePropertyAnimationSystem.NativeMethodInfoPtr_StartTransition_Public_Abstract_Virtual_New_Boolean_VisualElement_StylePropertyId_Int32_Int32_Int32_Int32_Func_2_Single_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060022F2 RID: 8946 RVA: 0x0009D74C File Offset: 0x0009B94C
		[CallerCount(0)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IStylePropertyAnimationSystem.NativeMethodInfoPtr_StartTransition_Public_Abstract_Virtual_New_Boolean_VisualElement_StylePropertyId_Length_Length_Int32_Int32_Func_2_Single_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060022F3 RID: 8947 RVA: 0x0009D800 File Offset: 0x0009BA00
		[CallerCount(0)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IStylePropertyAnimationSystem.NativeMethodInfoPtr_StartTransition_Public_Abstract_Virtual_New_Boolean_VisualElement_StylePropertyId_Color_Color_Int32_Int32_Func_2_Single_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060022F4 RID: 8948 RVA: 0x0009D8B4 File Offset: 0x0009BAB4
		[CallerCount(0)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IStylePropertyAnimationSystem.NativeMethodInfoPtr_StartTransition_Public_Abstract_Virtual_New_Boolean_VisualElement_StylePropertyId_Background_Background_Int32_Int32_Func_2_Single_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060022F5 RID: 8949 RVA: 0x0009D978 File Offset: 0x0009BB78
		[CallerCount(0)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IStylePropertyAnimationSystem.NativeMethodInfoPtr_StartTransition_Public_Abstract_Virtual_New_Boolean_VisualElement_StylePropertyId_FontDefinition_FontDefinition_Int32_Int32_Func_2_Single_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060022F6 RID: 8950 RVA: 0x0009DA3C File Offset: 0x0009BC3C
		[CallerCount(0)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IStylePropertyAnimationSystem.NativeMethodInfoPtr_StartTransition_Public_Abstract_Virtual_New_Boolean_VisualElement_StylePropertyId_Font_Font_Int32_Int32_Func_2_Single_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060022F7 RID: 8951 RVA: 0x0009DAF8 File Offset: 0x0009BCF8
		[CallerCount(0)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IStylePropertyAnimationSystem.NativeMethodInfoPtr_StartTransition_Public_Abstract_Virtual_New_Boolean_VisualElement_StylePropertyId_TextShadow_TextShadow_Int32_Int32_Func_2_Single_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060022F8 RID: 8952 RVA: 0x0009DBAC File Offset: 0x0009BDAC
		[CallerCount(0)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IStylePropertyAnimationSystem.NativeMethodInfoPtr_StartTransition_Public_Abstract_Virtual_New_Boolean_VisualElement_StylePropertyId_Scale_Scale_Int32_Int32_Func_2_Single_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060022F9 RID: 8953 RVA: 0x0009DC60 File Offset: 0x0009BE60
		[CallerCount(0)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IStylePropertyAnimationSystem.NativeMethodInfoPtr_StartTransition_Public_Abstract_Virtual_New_Boolean_VisualElement_StylePropertyId_TransformOrigin_TransformOrigin_Int32_Int32_Func_2_Single_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060022FA RID: 8954 RVA: 0x0009DD14 File Offset: 0x0009BF14
		[CallerCount(0)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IStylePropertyAnimationSystem.NativeMethodInfoPtr_StartTransition_Public_Abstract_Virtual_New_Boolean_VisualElement_StylePropertyId_Translate_Translate_Int32_Int32_Func_2_Single_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060022FB RID: 8955 RVA: 0x0009DDC8 File Offset: 0x0009BFC8
		[CallerCount(0)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IStylePropertyAnimationSystem.NativeMethodInfoPtr_StartTransition_Public_Abstract_Virtual_New_Boolean_VisualElement_StylePropertyId_Rotate_Rotate_Int32_Int32_Func_2_Single_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060022FC RID: 8956 RVA: 0x0009DE7C File Offset: 0x0009C07C
		[CallerCount(0)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IStylePropertyAnimationSystem.NativeMethodInfoPtr_StartTransition_Public_Abstract_Virtual_New_Boolean_VisualElement_StylePropertyId_BackgroundPosition_BackgroundPosition_Int32_Int32_Func_2_Single_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060022FD RID: 8957 RVA: 0x0009DF30 File Offset: 0x0009C130
		[CallerCount(0)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IStylePropertyAnimationSystem.NativeMethodInfoPtr_StartTransition_Public_Abstract_Virtual_New_Boolean_VisualElement_StylePropertyId_BackgroundRepeat_BackgroundRepeat_Int32_Int32_Func_2_Single_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060022FE RID: 8958 RVA: 0x0009DFE4 File Offset: 0x0009C1E4
		[CallerCount(0)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IStylePropertyAnimationSystem.NativeMethodInfoPtr_StartTransition_Public_Abstract_Virtual_New_Boolean_VisualElement_StylePropertyId_BackgroundSize_BackgroundSize_Int32_Int32_Func_2_Single_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060022FF RID: 8959 RVA: 0x0009E098 File Offset: 0x0009C298
		[CallerCount(0)]
		public unsafe virtual void CancelAllAnimations()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IStylePropertyAnimationSystem.NativeMethodInfoPtr_CancelAllAnimations_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002300 RID: 8960 RVA: 0x0009E0D4 File Offset: 0x0009C2D4
		[CallerCount(0)]
		public unsafe virtual void CancelAllAnimations(VisualElement owner)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(owner);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IStylePropertyAnimationSystem.NativeMethodInfoPtr_CancelAllAnimations_Public_Abstract_Virtual_New_Void_VisualElement_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002301 RID: 8961 RVA: 0x0009E124 File Offset: 0x0009C324
		[CallerCount(0)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IStylePropertyAnimationSystem.NativeMethodInfoPtr_CancelAnimation_Public_Abstract_Virtual_New_Void_VisualElement_StylePropertyId_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002302 RID: 8962 RVA: 0x0009E180 File Offset: 0x0009C380
		[CallerCount(0)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IStylePropertyAnimationSystem.NativeMethodInfoPtr_UpdateAnimation_Public_Abstract_Virtual_New_Void_VisualElement_StylePropertyId_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002303 RID: 8963 RVA: 0x0009E1DC File Offset: 0x0009C3DC
		[CallerCount(0)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IStylePropertyAnimationSystem.NativeMethodInfoPtr_GetAllAnimations_Public_Abstract_Virtual_New_Void_VisualElement_List_1_StylePropertyId_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002304 RID: 8964 RVA: 0x0009E23C File Offset: 0x0009C43C
		[CallerCount(0)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IStylePropertyAnimationSystem.NativeMethodInfoPtr_Update_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002305 RID: 8965 RVA: 0x0000E508 File Offset: 0x0000C708
		public IStylePropertyAnimationSystem(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001905 RID: 6405
		private static readonly IntPtr NativeMethodInfoPtr_StartTransition_Public_Abstract_Virtual_New_Boolean_VisualElement_StylePropertyId_Single_Single_Int32_Int32_Func_2_Single_Single_0;

		// Token: 0x04001906 RID: 6406
		private static readonly IntPtr NativeMethodInfoPtr_StartTransition_Public_Abstract_Virtual_New_Boolean_VisualElement_StylePropertyId_Int32_Int32_Int32_Int32_Func_2_Single_Single_0;

		// Token: 0x04001907 RID: 6407
		private static readonly IntPtr NativeMethodInfoPtr_StartTransition_Public_Abstract_Virtual_New_Boolean_VisualElement_StylePropertyId_Length_Length_Int32_Int32_Func_2_Single_Single_0;

		// Token: 0x04001908 RID: 6408
		private static readonly IntPtr NativeMethodInfoPtr_StartTransition_Public_Abstract_Virtual_New_Boolean_VisualElement_StylePropertyId_Color_Color_Int32_Int32_Func_2_Single_Single_0;

		// Token: 0x04001909 RID: 6409
		private static readonly IntPtr NativeMethodInfoPtr_StartTransition_Public_Abstract_Virtual_New_Boolean_VisualElement_StylePropertyId_Background_Background_Int32_Int32_Func_2_Single_Single_0;

		// Token: 0x0400190A RID: 6410
		private static readonly IntPtr NativeMethodInfoPtr_StartTransition_Public_Abstract_Virtual_New_Boolean_VisualElement_StylePropertyId_FontDefinition_FontDefinition_Int32_Int32_Func_2_Single_Single_0;

		// Token: 0x0400190B RID: 6411
		private static readonly IntPtr NativeMethodInfoPtr_StartTransition_Public_Abstract_Virtual_New_Boolean_VisualElement_StylePropertyId_Font_Font_Int32_Int32_Func_2_Single_Single_0;

		// Token: 0x0400190C RID: 6412
		private static readonly IntPtr NativeMethodInfoPtr_StartTransition_Public_Abstract_Virtual_New_Boolean_VisualElement_StylePropertyId_TextShadow_TextShadow_Int32_Int32_Func_2_Single_Single_0;

		// Token: 0x0400190D RID: 6413
		private static readonly IntPtr NativeMethodInfoPtr_StartTransition_Public_Abstract_Virtual_New_Boolean_VisualElement_StylePropertyId_Scale_Scale_Int32_Int32_Func_2_Single_Single_0;

		// Token: 0x0400190E RID: 6414
		private static readonly IntPtr NativeMethodInfoPtr_StartTransition_Public_Abstract_Virtual_New_Boolean_VisualElement_StylePropertyId_TransformOrigin_TransformOrigin_Int32_Int32_Func_2_Single_Single_0;

		// Token: 0x0400190F RID: 6415
		private static readonly IntPtr NativeMethodInfoPtr_StartTransition_Public_Abstract_Virtual_New_Boolean_VisualElement_StylePropertyId_Translate_Translate_Int32_Int32_Func_2_Single_Single_0;

		// Token: 0x04001910 RID: 6416
		private static readonly IntPtr NativeMethodInfoPtr_StartTransition_Public_Abstract_Virtual_New_Boolean_VisualElement_StylePropertyId_Rotate_Rotate_Int32_Int32_Func_2_Single_Single_0;

		// Token: 0x04001911 RID: 6417
		private static readonly IntPtr NativeMethodInfoPtr_StartTransition_Public_Abstract_Virtual_New_Boolean_VisualElement_StylePropertyId_BackgroundPosition_BackgroundPosition_Int32_Int32_Func_2_Single_Single_0;

		// Token: 0x04001912 RID: 6418
		private static readonly IntPtr NativeMethodInfoPtr_StartTransition_Public_Abstract_Virtual_New_Boolean_VisualElement_StylePropertyId_BackgroundRepeat_BackgroundRepeat_Int32_Int32_Func_2_Single_Single_0;

		// Token: 0x04001913 RID: 6419
		private static readonly IntPtr NativeMethodInfoPtr_StartTransition_Public_Abstract_Virtual_New_Boolean_VisualElement_StylePropertyId_BackgroundSize_BackgroundSize_Int32_Int32_Func_2_Single_Single_0;

		// Token: 0x04001914 RID: 6420
		private static readonly IntPtr NativeMethodInfoPtr_CancelAllAnimations_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x04001915 RID: 6421
		private static readonly IntPtr NativeMethodInfoPtr_CancelAllAnimations_Public_Abstract_Virtual_New_Void_VisualElement_0;

		// Token: 0x04001916 RID: 6422
		private static readonly IntPtr NativeMethodInfoPtr_CancelAnimation_Public_Abstract_Virtual_New_Void_VisualElement_StylePropertyId_0;

		// Token: 0x04001917 RID: 6423
		private static readonly IntPtr NativeMethodInfoPtr_UpdateAnimation_Public_Abstract_Virtual_New_Void_VisualElement_StylePropertyId_0;

		// Token: 0x04001918 RID: 6424
		private static readonly IntPtr NativeMethodInfoPtr_GetAllAnimations_Public_Abstract_Virtual_New_Void_VisualElement_List_1_StylePropertyId_0;

		// Token: 0x04001919 RID: 6425
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Abstract_Virtual_New_Void_0;
	}
}
