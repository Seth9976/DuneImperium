using System;
using DG.Tweening.Core;
using DG.Tweening.Core.Enums;
using DG.Tweening.Plugins.Core;
using DG.Tweening.Plugins.Options;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace DG.Tweening.Plugins
{
	// Token: 0x02000026 RID: 38
	public class RectPlugin : ABSTweenPlugin<Rect, Rect, RectOptions>
	{
		// Token: 0x060002DA RID: 730 RVA: 0x00014580 File Offset: 0x00012780
		// Note: this type is marked as 'beforefieldinit'.
		static RectPlugin()
		{
			Il2CppClassPointerStore<RectPlugin>.NativeClassPtr = IL2CPP.GetIl2CppClass("DOTween.dll", "DG.Tweening.Plugins", "RectPlugin");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RectPlugin>.NativeClassPtr);
			RectPlugin.NativeMethodInfoPtr_Reset_Public_Virtual_Void_TweenerCore_3_Rect_Rect_RectOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectPlugin>.NativeClassPtr, 100664021);
			RectPlugin.NativeMethodInfoPtr_SetFrom_Public_Virtual_Void_TweenerCore_3_Rect_Rect_RectOptions_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectPlugin>.NativeClassPtr, 100664022);
			RectPlugin.NativeMethodInfoPtr_ConvertToStartValue_Public_Virtual_Rect_TweenerCore_3_Rect_Rect_RectOptions_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectPlugin>.NativeClassPtr, 100664023);
			RectPlugin.NativeMethodInfoPtr_SetRelativeEndValue_Public_Virtual_Void_TweenerCore_3_Rect_Rect_RectOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectPlugin>.NativeClassPtr, 100664024);
			RectPlugin.NativeMethodInfoPtr_SetChangeValue_Public_Virtual_Void_TweenerCore_3_Rect_Rect_RectOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectPlugin>.NativeClassPtr, 100664025);
			RectPlugin.NativeMethodInfoPtr_GetSpeedBasedDuration_Public_Virtual_Single_RectOptions_Single_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectPlugin>.NativeClassPtr, 100664026);
			RectPlugin.NativeMethodInfoPtr_EvaluateAndApply_Public_Virtual_Void_RectOptions_Tween_Boolean_DOGetter_1_Rect_DOSetter_1_Rect_Single_Rect_Rect_Single_Boolean_UpdateNotice_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectPlugin>.NativeClassPtr, 100664027);
			RectPlugin.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectPlugin>.NativeClassPtr, 100664028);
		}

		// Token: 0x060002DB RID: 731 RVA: 0x00014650 File Offset: 0x00012850
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Reset(TweenerCore<Rect, Rect, RectOptions> t)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RectPlugin.NativeMethodInfoPtr_Reset_Public_Virtual_Void_TweenerCore_3_Rect_Rect_RectOptions_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002DC RID: 732 RVA: 0x000146A0 File Offset: 0x000128A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1132122, XrefRangeEnd = 1132130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetFrom(TweenerCore<Rect, Rect, RectOptions> t, bool isRelative)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isRelative;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RectPlugin.NativeMethodInfoPtr_SetFrom_Public_Virtual_Void_TweenerCore_3_Rect_Rect_RectOptions_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002DD RID: 733 RVA: 0x000146FC File Offset: 0x000128FC
		[CallerCount(0)]
		public unsafe override Rect ConvertToStartValue(TweenerCore<Rect, Rect, RectOptions> t, Rect value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RectPlugin.NativeMethodInfoPtr_ConvertToStartValue_Public_Virtual_Rect_TweenerCore_3_Rect_Rect_RectOptions_Rect_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002DE RID: 734 RVA: 0x00014764 File Offset: 0x00012964
		[CallerCount(0)]
		public unsafe override void SetRelativeEndValue(TweenerCore<Rect, Rect, RectOptions> t)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RectPlugin.NativeMethodInfoPtr_SetRelativeEndValue_Public_Virtual_Void_TweenerCore_3_Rect_Rect_RectOptions_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002DF RID: 735 RVA: 0x000147B4 File Offset: 0x000129B4
		[CallerCount(0)]
		public unsafe override void SetChangeValue(TweenerCore<Rect, Rect, RectOptions> t)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RectPlugin.NativeMethodInfoPtr_SetChangeValue_Public_Virtual_Void_TweenerCore_3_Rect_Rect_RectOptions_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002E0 RID: 736 RVA: 0x00014804 File Offset: 0x00012A04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1132130, XrefRangeEnd = 1132135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override float GetSpeedBasedDuration(RectOptions options, float unitsXSecond, Rect changeValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref options;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unitsXSecond;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref changeValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RectPlugin.NativeMethodInfoPtr_GetSpeedBasedDuration_Public_Virtual_Single_RectOptions_Single_Rect_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002E1 RID: 737 RVA: 0x00014874 File Offset: 0x00012A74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1132135, XrefRangeEnd = 1132144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void EvaluateAndApply(RectOptions options, Tween t, bool isRelative, DOGetter<Rect> getter, DOSetter<Rect> setter, float elapsed, Rect startValue, Rect changeValue, float duration, bool usingInversePosition, UpdateNotice updateNotice)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref options;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(t);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isRelative;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(getter);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(setter);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref elapsed;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startValue;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref changeValue;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref usingInversePosition;
			ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref updateNotice;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RectPlugin.NativeMethodInfoPtr_EvaluateAndApply_Public_Virtual_Void_RectOptions_Tween_Boolean_DOGetter_1_Rect_DOSetter_1_Rect_Single_Rect_Rect_Single_Boolean_UpdateNotice_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002E2 RID: 738 RVA: 0x0001495C File Offset: 0x00012B5C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1132147, RefRangeEnd = 1132148, XrefRangeStart = 1132144, XrefRangeEnd = 1132147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RectPlugin()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RectPlugin>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectPlugin.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002E3 RID: 739 RVA: 0x00002C36 File Offset: 0x00000E36
		public RectPlugin(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400028E RID: 654
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Void_TweenerCore_3_Rect_Rect_RectOptions_0;

		// Token: 0x0400028F RID: 655
		private static readonly IntPtr NativeMethodInfoPtr_SetFrom_Public_Virtual_Void_TweenerCore_3_Rect_Rect_RectOptions_Boolean_0;

		// Token: 0x04000290 RID: 656
		private static readonly IntPtr NativeMethodInfoPtr_ConvertToStartValue_Public_Virtual_Rect_TweenerCore_3_Rect_Rect_RectOptions_Rect_0;

		// Token: 0x04000291 RID: 657
		private static readonly IntPtr NativeMethodInfoPtr_SetRelativeEndValue_Public_Virtual_Void_TweenerCore_3_Rect_Rect_RectOptions_0;

		// Token: 0x04000292 RID: 658
		private static readonly IntPtr NativeMethodInfoPtr_SetChangeValue_Public_Virtual_Void_TweenerCore_3_Rect_Rect_RectOptions_0;

		// Token: 0x04000293 RID: 659
		private static readonly IntPtr NativeMethodInfoPtr_GetSpeedBasedDuration_Public_Virtual_Single_RectOptions_Single_Rect_0;

		// Token: 0x04000294 RID: 660
		private static readonly IntPtr NativeMethodInfoPtr_EvaluateAndApply_Public_Virtual_Void_RectOptions_Tween_Boolean_DOGetter_1_Rect_DOSetter_1_Rect_Single_Rect_Rect_Single_Boolean_UpdateNotice_0;

		// Token: 0x04000295 RID: 661
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
