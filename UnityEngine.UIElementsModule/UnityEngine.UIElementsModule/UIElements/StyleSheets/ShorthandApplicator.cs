using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.UIElements.StyleSheets
{
	// Token: 0x0200027F RID: 639
	public static class ShorthandApplicator : Object
	{
		// Token: 0x06003006 RID: 12294 RVA: 0x000CBFA8 File Offset: 0x000CA1A8
		// Note: this type is marked as 'beforefieldinit'.
		static ShorthandApplicator()
		{
			Il2CppClassPointerStore<ShorthandApplicator>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements.StyleSheets", "ShorthandApplicator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShorthandApplicator>.NativeClassPtr);
			ShorthandApplicator.NativeFieldInfoPtr_s_TransitionDelayList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShorthandApplicator>.NativeClassPtr, "s_TransitionDelayList");
			ShorthandApplicator.NativeFieldInfoPtr_s_TransitionDurationList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShorthandApplicator>.NativeClassPtr, "s_TransitionDurationList");
			ShorthandApplicator.NativeFieldInfoPtr_s_TransitionPropertyList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShorthandApplicator>.NativeClassPtr, "s_TransitionPropertyList");
			ShorthandApplicator.NativeFieldInfoPtr_s_TransitionTimingFunctionList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShorthandApplicator>.NativeClassPtr, "s_TransitionTimingFunctionList");
			ShorthandApplicator.NativeMethodInfoPtr_ApplyBackgroundPosition_Public_Static_Void_StylePropertyReader_byref_ComputedStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShorthandApplicator>.NativeClassPtr, 100670274);
			ShorthandApplicator.NativeMethodInfoPtr_ApplyBorderColor_Public_Static_Void_StylePropertyReader_byref_ComputedStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShorthandApplicator>.NativeClassPtr, 100670275);
			ShorthandApplicator.NativeMethodInfoPtr_ApplyBorderRadius_Public_Static_Void_StylePropertyReader_byref_ComputedStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShorthandApplicator>.NativeClassPtr, 100670276);
			ShorthandApplicator.NativeMethodInfoPtr_ApplyBorderWidth_Public_Static_Void_StylePropertyReader_byref_ComputedStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShorthandApplicator>.NativeClassPtr, 100670277);
			ShorthandApplicator.NativeMethodInfoPtr_ApplyFlex_Public_Static_Void_StylePropertyReader_byref_ComputedStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShorthandApplicator>.NativeClassPtr, 100670278);
			ShorthandApplicator.NativeMethodInfoPtr_ApplyMargin_Public_Static_Void_StylePropertyReader_byref_ComputedStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShorthandApplicator>.NativeClassPtr, 100670279);
			ShorthandApplicator.NativeMethodInfoPtr_ApplyPadding_Public_Static_Void_StylePropertyReader_byref_ComputedStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShorthandApplicator>.NativeClassPtr, 100670280);
			ShorthandApplicator.NativeMethodInfoPtr_ApplyTransition_Public_Static_Void_StylePropertyReader_byref_ComputedStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShorthandApplicator>.NativeClassPtr, 100670281);
			ShorthandApplicator.NativeMethodInfoPtr_ApplyUnityBackgroundScaleMode_Public_Static_Void_StylePropertyReader_byref_ComputedStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShorthandApplicator>.NativeClassPtr, 100670282);
			ShorthandApplicator.NativeMethodInfoPtr_ApplyUnityTextOutline_Public_Static_Void_StylePropertyReader_byref_ComputedStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShorthandApplicator>.NativeClassPtr, 100670283);
			ShorthandApplicator.NativeMethodInfoPtr_CompileFlexShorthand_Private_Static_Boolean_StylePropertyReader_byref_Single_byref_Single_byref_Length_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShorthandApplicator>.NativeClassPtr, 100670284);
			ShorthandApplicator.NativeMethodInfoPtr_CompileBorderRadius_Private_Static_Void_StylePropertyReader_byref_Length_byref_Length_byref_Length_byref_Length_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShorthandApplicator>.NativeClassPtr, 100670285);
			ShorthandApplicator.NativeMethodInfoPtr_CompileBackgroundPosition_Private_Static_Void_StylePropertyReader_byref_BackgroundPosition_byref_BackgroundPosition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShorthandApplicator>.NativeClassPtr, 100670286);
			ShorthandApplicator.NativeMethodInfoPtr_CompileUnityBackgroundScaleMode_Public_Static_Void_StylePropertyReader_byref_BackgroundPosition_byref_BackgroundPosition_byref_BackgroundRepeat_byref_BackgroundSize_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShorthandApplicator>.NativeClassPtr, 100670287);
			ShorthandApplicator.NativeMethodInfoPtr_CompileBoxArea_Private_Static_Void_StylePropertyReader_byref_Length_byref_Length_byref_Length_byref_Length_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShorthandApplicator>.NativeClassPtr, 100670288);
			ShorthandApplicator.NativeMethodInfoPtr_CompileBoxArea_Private_Static_Void_StylePropertyReader_byref_Single_byref_Single_byref_Single_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShorthandApplicator>.NativeClassPtr, 100670289);
			ShorthandApplicator.NativeMethodInfoPtr_CompileBoxArea_Private_Static_Void_StylePropertyReader_byref_Color_byref_Color_byref_Color_byref_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShorthandApplicator>.NativeClassPtr, 100670290);
			ShorthandApplicator.NativeMethodInfoPtr_CompileTextOutline_Private_Static_Void_StylePropertyReader_byref_Color_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShorthandApplicator>.NativeClassPtr, 100670291);
			ShorthandApplicator.NativeMethodInfoPtr_CompileTransition_Private_Static_Void_StylePropertyReader_byref_List_1_TimeValue_byref_List_1_TimeValue_byref_List_1_StylePropertyName_byref_List_1_EasingFunction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShorthandApplicator>.NativeClassPtr, 100670292);
			ShorthandApplicator.NativeMethodInfoPtr_Method_Internal_Static_Void_byref_BackgroundPositionKeyword_byref_BackgroundPositionKeyword_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShorthandApplicator>.NativeClassPtr, 100670294);
		}

		// Token: 0x06003007 RID: 12295 RVA: 0x000CC1B8 File Offset: 0x000CA3B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 355996, RefRangeEnd = 355997, XrefRangeStart = 355987, XrefRangeEnd = 355996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ApplyBackgroundPosition(StylePropertyReader reader, ref ComputedStyle computedStyle)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(computedStyle);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShorthandApplicator.NativeMethodInfoPtr_ApplyBackgroundPosition_Public_Static_Void_StylePropertyReader_byref_ComputedStyle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003008 RID: 12296 RVA: 0x000CC204 File Offset: 0x000CA404
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 356022, RefRangeEnd = 356023, XrefRangeStart = 355997, XrefRangeEnd = 356022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ApplyBorderColor(StylePropertyReader reader, ref ComputedStyle computedStyle)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(computedStyle);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShorthandApplicator.NativeMethodInfoPtr_ApplyBorderColor_Public_Static_Void_StylePropertyReader_byref_ComputedStyle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003009 RID: 12297 RVA: 0x000CC250 File Offset: 0x000CA450
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 356051, RefRangeEnd = 356052, XrefRangeStart = 356023, XrefRangeEnd = 356051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ApplyBorderRadius(StylePropertyReader reader, ref ComputedStyle computedStyle)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(computedStyle);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShorthandApplicator.NativeMethodInfoPtr_ApplyBorderRadius_Public_Static_Void_StylePropertyReader_byref_ComputedStyle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600300A RID: 12298 RVA: 0x000CC29C File Offset: 0x000CA49C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 356084, RefRangeEnd = 356085, XrefRangeStart = 356052, XrefRangeEnd = 356084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ApplyBorderWidth(StylePropertyReader reader, ref ComputedStyle computedStyle)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(computedStyle);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShorthandApplicator.NativeMethodInfoPtr_ApplyBorderWidth_Public_Static_Void_StylePropertyReader_byref_ComputedStyle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600300B RID: 12299 RVA: 0x000CC2E8 File Offset: 0x000CA4E8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 356096, RefRangeEnd = 356097, XrefRangeStart = 356085, XrefRangeEnd = 356096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ApplyFlex(StylePropertyReader reader, ref ComputedStyle computedStyle)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(computedStyle);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShorthandApplicator.NativeMethodInfoPtr_ApplyFlex_Public_Static_Void_StylePropertyReader_byref_ComputedStyle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600300C RID: 12300 RVA: 0x000CC334 File Offset: 0x000CA534
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 356126, RefRangeEnd = 356127, XrefRangeStart = 356097, XrefRangeEnd = 356126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ApplyMargin(StylePropertyReader reader, ref ComputedStyle computedStyle)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(computedStyle);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShorthandApplicator.NativeMethodInfoPtr_ApplyMargin_Public_Static_Void_StylePropertyReader_byref_ComputedStyle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600300D RID: 12301 RVA: 0x000CC380 File Offset: 0x000CA580
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 356156, RefRangeEnd = 356157, XrefRangeStart = 356127, XrefRangeEnd = 356156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ApplyPadding(StylePropertyReader reader, ref ComputedStyle computedStyle)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(computedStyle);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShorthandApplicator.NativeMethodInfoPtr_ApplyPadding_Public_Static_Void_StylePropertyReader_byref_ComputedStyle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600300E RID: 12302 RVA: 0x000CC3CC File Offset: 0x000CA5CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 356181, RefRangeEnd = 356182, XrefRangeStart = 356157, XrefRangeEnd = 356181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ApplyTransition(StylePropertyReader reader, ref ComputedStyle computedStyle)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(computedStyle);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShorthandApplicator.NativeMethodInfoPtr_ApplyTransition_Public_Static_Void_StylePropertyReader_byref_ComputedStyle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600300F RID: 12303 RVA: 0x000CC418 File Offset: 0x000CA618
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 356199, RefRangeEnd = 356200, XrefRangeStart = 356182, XrefRangeEnd = 356199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ApplyUnityBackgroundScaleMode(StylePropertyReader reader, ref ComputedStyle computedStyle)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(computedStyle);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShorthandApplicator.NativeMethodInfoPtr_ApplyUnityBackgroundScaleMode_Public_Static_Void_StylePropertyReader_byref_ComputedStyle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003010 RID: 12304 RVA: 0x000CC464 File Offset: 0x000CA664
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 356215, RefRangeEnd = 356216, XrefRangeStart = 356200, XrefRangeEnd = 356215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ApplyUnityTextOutline(StylePropertyReader reader, ref ComputedStyle computedStyle)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(computedStyle);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShorthandApplicator.NativeMethodInfoPtr_ApplyUnityTextOutline_Public_Static_Void_StylePropertyReader_byref_ComputedStyle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003011 RID: 12305 RVA: 0x000CC4B0 File Offset: 0x000CA6B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 356238, RefRangeEnd = 356239, XrefRangeStart = 356216, XrefRangeEnd = 356238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CompileFlexShorthand(StylePropertyReader reader, out float grow, out float shrink, out Length basis)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &grow;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &shrink;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &basis;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShorthandApplicator.NativeMethodInfoPtr_CompileFlexShorthand_Private_Static_Boolean_StylePropertyReader_byref_Single_byref_Single_byref_Length_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003012 RID: 12306 RVA: 0x000CC51C File Offset: 0x000CA71C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 356239, XrefRangeEnd = 356255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CompileBorderRadius(StylePropertyReader reader, out Length top, out Length right, out Length bottom, out Length left)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &top;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &right;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &bottom;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &left;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShorthandApplicator.NativeMethodInfoPtr_CompileBorderRadius_Private_Static_Void_StylePropertyReader_byref_Length_byref_Length_byref_Length_byref_Length_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003013 RID: 12307 RVA: 0x000CC58C File Offset: 0x000CA78C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 356332, RefRangeEnd = 356333, XrefRangeStart = 356255, XrefRangeEnd = 356332, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CompileBackgroundPosition(StylePropertyReader reader, out BackgroundPosition backgroundPositionX, out BackgroundPosition backgroundPositionY)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &backgroundPositionX;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &backgroundPositionY;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShorthandApplicator.NativeMethodInfoPtr_CompileBackgroundPosition_Private_Static_Void_StylePropertyReader_byref_BackgroundPosition_byref_BackgroundPosition_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003014 RID: 12308 RVA: 0x000CC5E0 File Offset: 0x000CA7E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 356333, XrefRangeEnd = 356338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CompileUnityBackgroundScaleMode(StylePropertyReader reader, out BackgroundPosition backgroundPositionX, out BackgroundPosition backgroundPositionY, out BackgroundRepeat backgroundRepeat, out BackgroundSize backgroundSize)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &backgroundPositionX;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &backgroundPositionY;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &backgroundRepeat;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &backgroundSize;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShorthandApplicator.NativeMethodInfoPtr_CompileUnityBackgroundScaleMode_Public_Static_Void_StylePropertyReader_byref_BackgroundPosition_byref_BackgroundPosition_byref_BackgroundRepeat_byref_BackgroundSize_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003015 RID: 12309 RVA: 0x000CC650 File Offset: 0x000CA850
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 356346, RefRangeEnd = 356348, XrefRangeStart = 356338, XrefRangeEnd = 356346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CompileBoxArea(StylePropertyReader reader, out Length top, out Length right, out Length bottom, out Length left)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &top;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &right;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &bottom;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &left;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShorthandApplicator.NativeMethodInfoPtr_CompileBoxArea_Private_Static_Void_StylePropertyReader_byref_Length_byref_Length_byref_Length_byref_Length_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003016 RID: 12310 RVA: 0x000CC6C0 File Offset: 0x000CA8C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 356348, XrefRangeEnd = 356368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CompileBoxArea(StylePropertyReader reader, out float top, out float right, out float bottom, out float left)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &top;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &right;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &bottom;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &left;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShorthandApplicator.NativeMethodInfoPtr_CompileBoxArea_Private_Static_Void_StylePropertyReader_byref_Single_byref_Single_byref_Single_byref_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003017 RID: 12311 RVA: 0x000CC730 File Offset: 0x000CA930
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 356368, XrefRangeEnd = 356372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CompileBoxArea(StylePropertyReader reader, out Color top, out Color right, out Color bottom, out Color left)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &top;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &right;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &bottom;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &left;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShorthandApplicator.NativeMethodInfoPtr_CompileBoxArea_Private_Static_Void_StylePropertyReader_byref_Color_byref_Color_byref_Color_byref_Color_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003018 RID: 12312 RVA: 0x000CC7A0 File Offset: 0x000CA9A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 356372, XrefRangeEnd = 356379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CompileTextOutline(StylePropertyReader reader, out Color outlineColor, out float outlineWidth)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &outlineColor;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &outlineWidth;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShorthandApplicator.NativeMethodInfoPtr_CompileTextOutline_Private_Static_Void_StylePropertyReader_byref_Color_byref_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003019 RID: 12313 RVA: 0x000CC7F4 File Offset: 0x000CA9F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 356488, RefRangeEnd = 356489, XrefRangeStart = 356379, XrefRangeEnd = 356488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CompileTransition(StylePropertyReader reader, out List<TimeValue> outDelay, out List<TimeValue> outDuration, out List<StylePropertyName> outProperty, out List<EasingFunction> outTimingFunction)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			ref IntPtr ptr4 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr3 = 0;
			ptr4 = &intPtr3;
			ref IntPtr ptr5 = ref ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr4 = 0;
			ptr5 = &intPtr4;
			IntPtr intPtr6;
			IntPtr intPtr5 = IL2CPP.il2cpp_runtime_invoke(ShorthandApplicator.NativeMethodInfoPtr_CompileTransition_Private_Static_Void_StylePropertyReader_byref_List_1_TimeValue_byref_List_1_TimeValue_byref_List_1_StylePropertyName_byref_List_1_EasingFunction_0, 0, (void**)ptr, ref intPtr6);
			Il2CppException.RaiseExceptionIfNecessary(intPtr6);
			IntPtr intPtr7 = intPtr;
			outDelay = ((intPtr7 == 0) ? null : new List<TimeValue>(intPtr7));
			IntPtr intPtr8 = intPtr2;
			outDuration = ((intPtr8 == 0) ? null : new List<TimeValue>(intPtr8));
			IntPtr intPtr9 = intPtr3;
			outProperty = ((intPtr9 == 0) ? null : new List<StylePropertyName>(intPtr9));
			IntPtr intPtr10 = intPtr4;
			outTimingFunction = ((intPtr10 == 0) ? null : new List<EasingFunction>(intPtr10));
		}

		// Token: 0x0600301A RID: 12314 RVA: 0x000CC8B8 File Offset: 0x000CAAB8
		[CallerCount(0)]
		public unsafe static void Method_Internal_Static_Void_byref_BackgroundPositionKeyword_byref_BackgroundPositionKeyword_0(ref BackgroundPositionKeyword a, ref BackgroundPositionKeyword b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShorthandApplicator.NativeMethodInfoPtr_Method_Internal_Static_Void_byref_BackgroundPositionKeyword_byref_BackgroundPositionKeyword_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600301B RID: 12315 RVA: 0x00013ABC File Offset: 0x00011CBC
		public ShorthandApplicator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000F36 RID: 3894
		// (get) Token: 0x0600301C RID: 12316 RVA: 0x000CC8F8 File Offset: 0x000CAAF8
		// (set) Token: 0x0600301D RID: 12317 RVA: 0x00013AC5 File Offset: 0x00011CC5
		public unsafe static List<TimeValue> s_TransitionDelayList
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ShorthandApplicator.NativeFieldInfoPtr_s_TransitionDelayList, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<TimeValue>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShorthandApplicator.NativeFieldInfoPtr_s_TransitionDelayList, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F37 RID: 3895
		// (get) Token: 0x0600301E RID: 12318 RVA: 0x000CC920 File Offset: 0x000CAB20
		// (set) Token: 0x0600301F RID: 12319 RVA: 0x00013AD7 File Offset: 0x00011CD7
		public unsafe static List<TimeValue> s_TransitionDurationList
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ShorthandApplicator.NativeFieldInfoPtr_s_TransitionDurationList, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<TimeValue>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShorthandApplicator.NativeFieldInfoPtr_s_TransitionDurationList, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F38 RID: 3896
		// (get) Token: 0x06003020 RID: 12320 RVA: 0x000CC948 File Offset: 0x000CAB48
		// (set) Token: 0x06003021 RID: 12321 RVA: 0x00013AE9 File Offset: 0x00011CE9
		public unsafe static List<StylePropertyName> s_TransitionPropertyList
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ShorthandApplicator.NativeFieldInfoPtr_s_TransitionPropertyList, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<StylePropertyName>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShorthandApplicator.NativeFieldInfoPtr_s_TransitionPropertyList, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F39 RID: 3897
		// (get) Token: 0x06003022 RID: 12322 RVA: 0x000CC970 File Offset: 0x000CAB70
		// (set) Token: 0x06003023 RID: 12323 RVA: 0x00013AFB File Offset: 0x00011CFB
		public unsafe static List<EasingFunction> s_TransitionTimingFunctionList
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ShorthandApplicator.NativeFieldInfoPtr_s_TransitionTimingFunctionList, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<EasingFunction>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShorthandApplicator.NativeFieldInfoPtr_s_TransitionTimingFunctionList, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400229B RID: 8859
		private static readonly IntPtr NativeFieldInfoPtr_s_TransitionDelayList;

		// Token: 0x0400229C RID: 8860
		private static readonly IntPtr NativeFieldInfoPtr_s_TransitionDurationList;

		// Token: 0x0400229D RID: 8861
		private static readonly IntPtr NativeFieldInfoPtr_s_TransitionPropertyList;

		// Token: 0x0400229E RID: 8862
		private static readonly IntPtr NativeFieldInfoPtr_s_TransitionTimingFunctionList;

		// Token: 0x0400229F RID: 8863
		private static readonly IntPtr NativeMethodInfoPtr_ApplyBackgroundPosition_Public_Static_Void_StylePropertyReader_byref_ComputedStyle_0;

		// Token: 0x040022A0 RID: 8864
		private static readonly IntPtr NativeMethodInfoPtr_ApplyBorderColor_Public_Static_Void_StylePropertyReader_byref_ComputedStyle_0;

		// Token: 0x040022A1 RID: 8865
		private static readonly IntPtr NativeMethodInfoPtr_ApplyBorderRadius_Public_Static_Void_StylePropertyReader_byref_ComputedStyle_0;

		// Token: 0x040022A2 RID: 8866
		private static readonly IntPtr NativeMethodInfoPtr_ApplyBorderWidth_Public_Static_Void_StylePropertyReader_byref_ComputedStyle_0;

		// Token: 0x040022A3 RID: 8867
		private static readonly IntPtr NativeMethodInfoPtr_ApplyFlex_Public_Static_Void_StylePropertyReader_byref_ComputedStyle_0;

		// Token: 0x040022A4 RID: 8868
		private static readonly IntPtr NativeMethodInfoPtr_ApplyMargin_Public_Static_Void_StylePropertyReader_byref_ComputedStyle_0;

		// Token: 0x040022A5 RID: 8869
		private static readonly IntPtr NativeMethodInfoPtr_ApplyPadding_Public_Static_Void_StylePropertyReader_byref_ComputedStyle_0;

		// Token: 0x040022A6 RID: 8870
		private static readonly IntPtr NativeMethodInfoPtr_ApplyTransition_Public_Static_Void_StylePropertyReader_byref_ComputedStyle_0;

		// Token: 0x040022A7 RID: 8871
		private static readonly IntPtr NativeMethodInfoPtr_ApplyUnityBackgroundScaleMode_Public_Static_Void_StylePropertyReader_byref_ComputedStyle_0;

		// Token: 0x040022A8 RID: 8872
		private static readonly IntPtr NativeMethodInfoPtr_ApplyUnityTextOutline_Public_Static_Void_StylePropertyReader_byref_ComputedStyle_0;

		// Token: 0x040022A9 RID: 8873
		private static readonly IntPtr NativeMethodInfoPtr_CompileFlexShorthand_Private_Static_Boolean_StylePropertyReader_byref_Single_byref_Single_byref_Length_0;

		// Token: 0x040022AA RID: 8874
		private static readonly IntPtr NativeMethodInfoPtr_CompileBorderRadius_Private_Static_Void_StylePropertyReader_byref_Length_byref_Length_byref_Length_byref_Length_0;

		// Token: 0x040022AB RID: 8875
		private static readonly IntPtr NativeMethodInfoPtr_CompileBackgroundPosition_Private_Static_Void_StylePropertyReader_byref_BackgroundPosition_byref_BackgroundPosition_0;

		// Token: 0x040022AC RID: 8876
		private static readonly IntPtr NativeMethodInfoPtr_CompileUnityBackgroundScaleMode_Public_Static_Void_StylePropertyReader_byref_BackgroundPosition_byref_BackgroundPosition_byref_BackgroundRepeat_byref_BackgroundSize_0;

		// Token: 0x040022AD RID: 8877
		private static readonly IntPtr NativeMethodInfoPtr_CompileBoxArea_Private_Static_Void_StylePropertyReader_byref_Length_byref_Length_byref_Length_byref_Length_0;

		// Token: 0x040022AE RID: 8878
		private static readonly IntPtr NativeMethodInfoPtr_CompileBoxArea_Private_Static_Void_StylePropertyReader_byref_Single_byref_Single_byref_Single_byref_Single_0;

		// Token: 0x040022AF RID: 8879
		private static readonly IntPtr NativeMethodInfoPtr_CompileBoxArea_Private_Static_Void_StylePropertyReader_byref_Color_byref_Color_byref_Color_byref_Color_0;

		// Token: 0x040022B0 RID: 8880
		private static readonly IntPtr NativeMethodInfoPtr_CompileTextOutline_Private_Static_Void_StylePropertyReader_byref_Color_byref_Single_0;

		// Token: 0x040022B1 RID: 8881
		private static readonly IntPtr NativeMethodInfoPtr_CompileTransition_Private_Static_Void_StylePropertyReader_byref_List_1_TimeValue_byref_List_1_TimeValue_byref_List_1_StylePropertyName_byref_List_1_EasingFunction_0;

		// Token: 0x040022B2 RID: 8882
		private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Static_Void_byref_BackgroundPositionKeyword_byref_BackgroundPositionKeyword_0;
	}
}
