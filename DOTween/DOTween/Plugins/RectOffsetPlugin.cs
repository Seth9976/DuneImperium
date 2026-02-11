using System;
using DG.Tweening.Core;
using DG.Tweening.Core.Enums;
using DG.Tweening.Plugins.Core;
using DG.Tweening.Plugins.Options;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace DG.Tweening.Plugins
{
	// Token: 0x02000025 RID: 37
	public class RectOffsetPlugin : ABSTweenPlugin<RectOffset, RectOffset, NoOptions>
	{
		// Token: 0x060002CE RID: 718 RVA: 0x00014118 File Offset: 0x00012318
		// Note: this type is marked as 'beforefieldinit'.
		static RectOffsetPlugin()
		{
			Il2CppClassPointerStore<RectOffsetPlugin>.NativeClassPtr = IL2CPP.GetIl2CppClass("DOTween.dll", "DG.Tweening.Plugins", "RectOffsetPlugin");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RectOffsetPlugin>.NativeClassPtr);
			RectOffsetPlugin.NativeFieldInfoPtr__r = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RectOffsetPlugin>.NativeClassPtr, "_r");
			RectOffsetPlugin.NativeMethodInfoPtr_Reset_Public_Virtual_Void_TweenerCore_3_RectOffset_RectOffset_NoOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectOffsetPlugin>.NativeClassPtr, 100664012);
			RectOffsetPlugin.NativeMethodInfoPtr_SetFrom_Public_Virtual_Void_TweenerCore_3_RectOffset_RectOffset_NoOptions_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectOffsetPlugin>.NativeClassPtr, 100664013);
			RectOffsetPlugin.NativeMethodInfoPtr_ConvertToStartValue_Public_Virtual_RectOffset_TweenerCore_3_RectOffset_RectOffset_NoOptions_RectOffset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectOffsetPlugin>.NativeClassPtr, 100664014);
			RectOffsetPlugin.NativeMethodInfoPtr_SetRelativeEndValue_Public_Virtual_Void_TweenerCore_3_RectOffset_RectOffset_NoOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectOffsetPlugin>.NativeClassPtr, 100664015);
			RectOffsetPlugin.NativeMethodInfoPtr_SetChangeValue_Public_Virtual_Void_TweenerCore_3_RectOffset_RectOffset_NoOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectOffsetPlugin>.NativeClassPtr, 100664016);
			RectOffsetPlugin.NativeMethodInfoPtr_GetSpeedBasedDuration_Public_Virtual_Single_NoOptions_Single_RectOffset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectOffsetPlugin>.NativeClassPtr, 100664017);
			RectOffsetPlugin.NativeMethodInfoPtr_EvaluateAndApply_Public_Virtual_Void_NoOptions_Tween_Boolean_DOGetter_1_RectOffset_DOSetter_1_RectOffset_Single_RectOffset_RectOffset_Single_Boolean_UpdateNotice_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectOffsetPlugin>.NativeClassPtr, 100664018);
			RectOffsetPlugin.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectOffsetPlugin>.NativeClassPtr, 100664019);
		}

		// Token: 0x060002CF RID: 719 RVA: 0x000141FC File Offset: 0x000123FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Reset(TweenerCore<RectOffset, RectOffset, NoOptions> t)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RectOffsetPlugin.NativeMethodInfoPtr_Reset_Public_Virtual_Void_TweenerCore_3_RectOffset_RectOffset_NoOptions_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002D0 RID: 720 RVA: 0x0001424C File Offset: 0x0001244C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1131974, XrefRangeEnd = 1131989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetFrom(TweenerCore<RectOffset, RectOffset, NoOptions> t, bool isRelative)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RectOffsetPlugin.NativeMethodInfoPtr_SetFrom_Public_Virtual_Void_TweenerCore_3_RectOffset_RectOffset_NoOptions_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002D1 RID: 721 RVA: 0x000142A8 File Offset: 0x000124A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1131989, XrefRangeEnd = 1131997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override RectOffset ConvertToStartValue(TweenerCore<RectOffset, RectOffset, NoOptions> t, RectOffset value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RectOffsetPlugin.NativeMethodInfoPtr_ConvertToStartValue_Public_Virtual_RectOffset_TweenerCore_3_RectOffset_RectOffset_NoOptions_RectOffset_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RectOffset>(intPtr3) : null;
		}

		// Token: 0x060002D2 RID: 722 RVA: 0x00014318 File Offset: 0x00012518
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1131997, XrefRangeEnd = 1132018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetRelativeEndValue(TweenerCore<RectOffset, RectOffset, NoOptions> t)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RectOffsetPlugin.NativeMethodInfoPtr_SetRelativeEndValue_Public_Virtual_Void_TweenerCore_3_RectOffset_RectOffset_NoOptions_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002D3 RID: 723 RVA: 0x00014368 File Offset: 0x00012568
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1132018, XrefRangeEnd = 1132032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetChangeValue(TweenerCore<RectOffset, RectOffset, NoOptions> t)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RectOffsetPlugin.NativeMethodInfoPtr_SetChangeValue_Public_Virtual_Void_TweenerCore_3_RectOffset_RectOffset_NoOptions_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002D4 RID: 724 RVA: 0x000143B8 File Offset: 0x000125B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1132032, XrefRangeEnd = 1132039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override float GetSpeedBasedDuration(NoOptions options, float unitsXSecond, RectOffset changeValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref options;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unitsXSecond;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(changeValue);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RectOffsetPlugin.NativeMethodInfoPtr_GetSpeedBasedDuration_Public_Virtual_Single_NoOptions_Single_RectOffset_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002D5 RID: 725 RVA: 0x0001442C File Offset: 0x0001262C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1132039, XrefRangeEnd = 1132118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void EvaluateAndApply(NoOptions options, Tween t, bool isRelative, DOGetter<RectOffset> getter, DOSetter<RectOffset> setter, float elapsed, RectOffset startValue, RectOffset changeValue, float duration, bool usingInversePosition, UpdateNotice updateNotice)
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
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(startValue);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(changeValue);
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref usingInversePosition;
			ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref updateNotice;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RectOffsetPlugin.NativeMethodInfoPtr_EvaluateAndApply_Public_Virtual_Void_NoOptions_Tween_Boolean_DOGetter_1_RectOffset_DOSetter_1_RectOffset_Single_RectOffset_RectOffset_Single_Boolean_UpdateNotice_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002D6 RID: 726 RVA: 0x0001451C File Offset: 0x0001271C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1132121, RefRangeEnd = 1132122, XrefRangeStart = 1132118, XrefRangeEnd = 1132121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RectOffsetPlugin()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RectOffsetPlugin>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectOffsetPlugin.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002D7 RID: 727 RVA: 0x00002C1B File Offset: 0x00000E1B
		public RectOffsetPlugin(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x060002D8 RID: 728 RVA: 0x00014558 File Offset: 0x00012758
		// (set) Token: 0x060002D9 RID: 729 RVA: 0x00002C24 File Offset: 0x00000E24
		public unsafe static RectOffset _r
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RectOffsetPlugin.NativeFieldInfoPtr__r, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectOffset>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RectOffsetPlugin.NativeFieldInfoPtr__r, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000285 RID: 645
		private static readonly IntPtr NativeFieldInfoPtr__r;

		// Token: 0x04000286 RID: 646
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Void_TweenerCore_3_RectOffset_RectOffset_NoOptions_0;

		// Token: 0x04000287 RID: 647
		private static readonly IntPtr NativeMethodInfoPtr_SetFrom_Public_Virtual_Void_TweenerCore_3_RectOffset_RectOffset_NoOptions_Boolean_0;

		// Token: 0x04000288 RID: 648
		private static readonly IntPtr NativeMethodInfoPtr_ConvertToStartValue_Public_Virtual_RectOffset_TweenerCore_3_RectOffset_RectOffset_NoOptions_RectOffset_0;

		// Token: 0x04000289 RID: 649
		private static readonly IntPtr NativeMethodInfoPtr_SetRelativeEndValue_Public_Virtual_Void_TweenerCore_3_RectOffset_RectOffset_NoOptions_0;

		// Token: 0x0400028A RID: 650
		private static readonly IntPtr NativeMethodInfoPtr_SetChangeValue_Public_Virtual_Void_TweenerCore_3_RectOffset_RectOffset_NoOptions_0;

		// Token: 0x0400028B RID: 651
		private static readonly IntPtr NativeMethodInfoPtr_GetSpeedBasedDuration_Public_Virtual_Single_NoOptions_Single_RectOffset_0;

		// Token: 0x0400028C RID: 652
		private static readonly IntPtr NativeMethodInfoPtr_EvaluateAndApply_Public_Virtual_Void_NoOptions_Tween_Boolean_DOGetter_1_RectOffset_DOSetter_1_RectOffset_Single_RectOffset_RectOffset_Single_Boolean_UpdateNotice_0;

		// Token: 0x0400028D RID: 653
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
