using System;
using DG.Tweening.Core;
using DG.Tweening.Core.Enums;
using DG.Tweening.Plugins.Core;
using DG.Tweening.Plugins.Options;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace DG.Tweening.Plugins
{
	// Token: 0x0200001D RID: 29
	public class DoublePlugin : ABSTweenPlugin<double, double, NoOptions>
	{
		// Token: 0x0600027A RID: 634 RVA: 0x00011EE4 File Offset: 0x000100E4
		// Note: this type is marked as 'beforefieldinit'.
		static DoublePlugin()
		{
			Il2CppClassPointerStore<DoublePlugin>.NativeClassPtr = IL2CPP.GetIl2CppClass("DOTween.dll", "DG.Tweening.Plugins", "DoublePlugin");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DoublePlugin>.NativeClassPtr);
			DoublePlugin.NativeMethodInfoPtr_Reset_Public_Virtual_Void_TweenerCore_3_Double_Double_NoOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoublePlugin>.NativeClassPtr, 100663946);
			DoublePlugin.NativeMethodInfoPtr_SetFrom_Public_Virtual_Void_TweenerCore_3_Double_Double_NoOptions_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoublePlugin>.NativeClassPtr, 100663947);
			DoublePlugin.NativeMethodInfoPtr_ConvertToStartValue_Public_Virtual_Double_TweenerCore_3_Double_Double_NoOptions_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoublePlugin>.NativeClassPtr, 100663948);
			DoublePlugin.NativeMethodInfoPtr_SetRelativeEndValue_Public_Virtual_Void_TweenerCore_3_Double_Double_NoOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoublePlugin>.NativeClassPtr, 100663949);
			DoublePlugin.NativeMethodInfoPtr_SetChangeValue_Public_Virtual_Void_TweenerCore_3_Double_Double_NoOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoublePlugin>.NativeClassPtr, 100663950);
			DoublePlugin.NativeMethodInfoPtr_GetSpeedBasedDuration_Public_Virtual_Single_NoOptions_Single_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoublePlugin>.NativeClassPtr, 100663951);
			DoublePlugin.NativeMethodInfoPtr_EvaluateAndApply_Public_Virtual_Void_NoOptions_Tween_Boolean_DOGetter_1_Double_DOSetter_1_Double_Single_Double_Double_Single_Boolean_UpdateNotice_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoublePlugin>.NativeClassPtr, 100663952);
			DoublePlugin.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoublePlugin>.NativeClassPtr, 100663953);
		}

		// Token: 0x0600027B RID: 635 RVA: 0x00011FB4 File Offset: 0x000101B4
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Reset(TweenerCore<double, double, NoOptions> t)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DoublePlugin.NativeMethodInfoPtr_Reset_Public_Virtual_Void_TweenerCore_3_Double_Double_NoOptions_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600027C RID: 636 RVA: 0x00012004 File Offset: 0x00010204
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1131734, XrefRangeEnd = 1131736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetFrom(TweenerCore<double, double, NoOptions> t, bool isRelative)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DoublePlugin.NativeMethodInfoPtr_SetFrom_Public_Virtual_Void_TweenerCore_3_Double_Double_NoOptions_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600027D RID: 637 RVA: 0x00012060 File Offset: 0x00010260
		[CallerCount(0)]
		public unsafe override double ConvertToStartValue(TweenerCore<double, double, NoOptions> t, double value)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DoublePlugin.NativeMethodInfoPtr_ConvertToStartValue_Public_Virtual_Double_TweenerCore_3_Double_Double_NoOptions_Double_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600027E RID: 638 RVA: 0x000120C8 File Offset: 0x000102C8
		[CallerCount(0)]
		public unsafe override void SetRelativeEndValue(TweenerCore<double, double, NoOptions> t)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DoublePlugin.NativeMethodInfoPtr_SetRelativeEndValue_Public_Virtual_Void_TweenerCore_3_Double_Double_NoOptions_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600027F RID: 639 RVA: 0x00012118 File Offset: 0x00010318
		[CallerCount(0)]
		public unsafe override void SetChangeValue(TweenerCore<double, double, NoOptions> t)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DoublePlugin.NativeMethodInfoPtr_SetChangeValue_Public_Virtual_Void_TweenerCore_3_Double_Double_NoOptions_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000280 RID: 640 RVA: 0x00012168 File Offset: 0x00010368
		[CallerCount(0)]
		public unsafe override float GetSpeedBasedDuration(NoOptions options, float unitsXSecond, double changeValue)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DoublePlugin.NativeMethodInfoPtr_GetSpeedBasedDuration_Public_Virtual_Single_NoOptions_Single_Double_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000281 RID: 641 RVA: 0x000121D8 File Offset: 0x000103D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1131736, XrefRangeEnd = 1131740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void EvaluateAndApply(NoOptions options, Tween t, bool isRelative, DOGetter<double> getter, DOSetter<double> setter, float elapsed, double startValue, double changeValue, float duration, bool usingInversePosition, UpdateNotice updateNotice)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DoublePlugin.NativeMethodInfoPtr_EvaluateAndApply_Public_Virtual_Void_NoOptions_Tween_Boolean_DOGetter_1_Double_DOSetter_1_Double_Single_Double_Double_Single_Boolean_UpdateNotice_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000282 RID: 642 RVA: 0x000122C0 File Offset: 0x000104C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1131743, RefRangeEnd = 1131744, XrefRangeStart = 1131740, XrefRangeEnd = 1131743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DoublePlugin()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DoublePlugin>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoublePlugin.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000283 RID: 643 RVA: 0x00002BC5 File Offset: 0x00000DC5
		public DoublePlugin(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000242 RID: 578
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Void_TweenerCore_3_Double_Double_NoOptions_0;

		// Token: 0x04000243 RID: 579
		private static readonly IntPtr NativeMethodInfoPtr_SetFrom_Public_Virtual_Void_TweenerCore_3_Double_Double_NoOptions_Boolean_0;

		// Token: 0x04000244 RID: 580
		private static readonly IntPtr NativeMethodInfoPtr_ConvertToStartValue_Public_Virtual_Double_TweenerCore_3_Double_Double_NoOptions_Double_0;

		// Token: 0x04000245 RID: 581
		private static readonly IntPtr NativeMethodInfoPtr_SetRelativeEndValue_Public_Virtual_Void_TweenerCore_3_Double_Double_NoOptions_0;

		// Token: 0x04000246 RID: 582
		private static readonly IntPtr NativeMethodInfoPtr_SetChangeValue_Public_Virtual_Void_TweenerCore_3_Double_Double_NoOptions_0;

		// Token: 0x04000247 RID: 583
		private static readonly IntPtr NativeMethodInfoPtr_GetSpeedBasedDuration_Public_Virtual_Single_NoOptions_Single_Double_0;

		// Token: 0x04000248 RID: 584
		private static readonly IntPtr NativeMethodInfoPtr_EvaluateAndApply_Public_Virtual_Void_NoOptions_Tween_Boolean_DOGetter_1_Double_DOSetter_1_Double_Single_Double_Double_Single_Boolean_UpdateNotice_0;

		// Token: 0x04000249 RID: 585
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
