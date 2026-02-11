using System;
using DG.Tweening.Core;
using DG.Tweening.Core.Enums;
using DG.Tweening.Plugins.Core;
using DG.Tweening.Plugins.Options;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace DG.Tweening.CustomPlugins
{
	// Token: 0x02000045 RID: 69
	public class PureQuaternionPlugin : ABSTweenPlugin<Quaternion, Quaternion, NoOptions>
	{
		// Token: 0x0600041A RID: 1050 RVA: 0x000191B0 File Offset: 0x000173B0
		// Note: this type is marked as 'beforefieldinit'.
		static PureQuaternionPlugin()
		{
			Il2CppClassPointerStore<PureQuaternionPlugin>.NativeClassPtr = IL2CPP.GetIl2CppClass("DOTween.dll", "DG.Tweening.CustomPlugins", "PureQuaternionPlugin");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PureQuaternionPlugin>.NativeClassPtr);
			PureQuaternionPlugin.NativeFieldInfoPtr__plug = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PureQuaternionPlugin>.NativeClassPtr, "_plug");
			PureQuaternionPlugin.NativeMethodInfoPtr_Plug_Public_Static_PureQuaternionPlugin_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PureQuaternionPlugin>.NativeClassPtr, 100664142);
			PureQuaternionPlugin.NativeMethodInfoPtr_Reset_Public_Virtual_Void_TweenerCore_3_Quaternion_Quaternion_NoOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PureQuaternionPlugin>.NativeClassPtr, 100664143);
			PureQuaternionPlugin.NativeMethodInfoPtr_SetFrom_Public_Virtual_Void_TweenerCore_3_Quaternion_Quaternion_NoOptions_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PureQuaternionPlugin>.NativeClassPtr, 100664144);
			PureQuaternionPlugin.NativeMethodInfoPtr_ConvertToStartValue_Public_Virtual_Quaternion_TweenerCore_3_Quaternion_Quaternion_NoOptions_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PureQuaternionPlugin>.NativeClassPtr, 100664145);
			PureQuaternionPlugin.NativeMethodInfoPtr_SetRelativeEndValue_Public_Virtual_Void_TweenerCore_3_Quaternion_Quaternion_NoOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PureQuaternionPlugin>.NativeClassPtr, 100664146);
			PureQuaternionPlugin.NativeMethodInfoPtr_SetChangeValue_Public_Virtual_Void_TweenerCore_3_Quaternion_Quaternion_NoOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PureQuaternionPlugin>.NativeClassPtr, 100664147);
			PureQuaternionPlugin.NativeMethodInfoPtr_GetSpeedBasedDuration_Public_Virtual_Single_NoOptions_Single_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PureQuaternionPlugin>.NativeClassPtr, 100664148);
			PureQuaternionPlugin.NativeMethodInfoPtr_EvaluateAndApply_Public_Virtual_Void_NoOptions_Tween_Boolean_DOGetter_1_Quaternion_DOSetter_1_Quaternion_Single_Quaternion_Quaternion_Single_Boolean_UpdateNotice_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PureQuaternionPlugin>.NativeClassPtr, 100664149);
			PureQuaternionPlugin.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PureQuaternionPlugin>.NativeClassPtr, 100664150);
		}

		// Token: 0x0600041B RID: 1051 RVA: 0x000192A8 File Offset: 0x000174A8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1133096, RefRangeEnd = 1133098, XrefRangeStart = 1133086, XrefRangeEnd = 1133096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static PureQuaternionPlugin Plug()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PureQuaternionPlugin.NativeMethodInfoPtr_Plug_Public_Static_PureQuaternionPlugin_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PureQuaternionPlugin>(intPtr3) : null;
		}

		// Token: 0x0600041C RID: 1052 RVA: 0x000192DC File Offset: 0x000174DC
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Reset(TweenerCore<Quaternion, Quaternion, NoOptions> t)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PureQuaternionPlugin.NativeMethodInfoPtr_Reset_Public_Virtual_Void_TweenerCore_3_Quaternion_Quaternion_NoOptions_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600041D RID: 1053 RVA: 0x0001932C File Offset: 0x0001752C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1133098, XrefRangeEnd = 1133099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetFrom(TweenerCore<Quaternion, Quaternion, NoOptions> t, bool isRelative)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PureQuaternionPlugin.NativeMethodInfoPtr_SetFrom_Public_Virtual_Void_TweenerCore_3_Quaternion_Quaternion_NoOptions_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600041E RID: 1054 RVA: 0x00019388 File Offset: 0x00017588
		[CallerCount(0)]
		public unsafe override Quaternion ConvertToStartValue(TweenerCore<Quaternion, Quaternion, NoOptions> t, Quaternion value)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PureQuaternionPlugin.NativeMethodInfoPtr_ConvertToStartValue_Public_Virtual_Quaternion_TweenerCore_3_Quaternion_Quaternion_NoOptions_Quaternion_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600041F RID: 1055 RVA: 0x000193F0 File Offset: 0x000175F0
		[CallerCount(0)]
		public unsafe override void SetRelativeEndValue(TweenerCore<Quaternion, Quaternion, NoOptions> t)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PureQuaternionPlugin.NativeMethodInfoPtr_SetRelativeEndValue_Public_Virtual_Void_TweenerCore_3_Quaternion_Quaternion_NoOptions_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000420 RID: 1056 RVA: 0x00019440 File Offset: 0x00017640
		[CallerCount(0)]
		public unsafe override void SetChangeValue(TweenerCore<Quaternion, Quaternion, NoOptions> t)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PureQuaternionPlugin.NativeMethodInfoPtr_SetChangeValue_Public_Virtual_Void_TweenerCore_3_Quaternion_Quaternion_NoOptions_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000421 RID: 1057 RVA: 0x00019490 File Offset: 0x00017690
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1133099, XrefRangeEnd = 1133102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override float GetSpeedBasedDuration(NoOptions options, float unitsXSecond, Quaternion changeValue)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PureQuaternionPlugin.NativeMethodInfoPtr_GetSpeedBasedDuration_Public_Virtual_Single_NoOptions_Single_Quaternion_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000422 RID: 1058 RVA: 0x00019500 File Offset: 0x00017700
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1133102, XrefRangeEnd = 1133103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void EvaluateAndApply(NoOptions options, Tween t, bool isRelative, DOGetter<Quaternion> getter, DOSetter<Quaternion> setter, float elapsed, Quaternion startValue, Quaternion changeValue, float duration, bool usingInversePosition, UpdateNotice updateNotice)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PureQuaternionPlugin.NativeMethodInfoPtr_EvaluateAndApply_Public_Virtual_Void_NoOptions_Tween_Boolean_DOGetter_1_Quaternion_DOSetter_1_Quaternion_Single_Quaternion_Quaternion_Single_Boolean_UpdateNotice_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000423 RID: 1059 RVA: 0x000195E8 File Offset: 0x000177E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1133103, XrefRangeEnd = 1133106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PureQuaternionPlugin()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PureQuaternionPlugin>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PureQuaternionPlugin.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000424 RID: 1060 RVA: 0x000034D4 File Offset: 0x000016D4
		public PureQuaternionPlugin(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x06000425 RID: 1061 RVA: 0x00019624 File Offset: 0x00017824
		// (set) Token: 0x06000426 RID: 1062 RVA: 0x000034DD File Offset: 0x000016DD
		public unsafe static PureQuaternionPlugin _plug
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PureQuaternionPlugin.NativeFieldInfoPtr__plug, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PureQuaternionPlugin>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PureQuaternionPlugin.NativeFieldInfoPtr__plug, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000365 RID: 869
		private static readonly IntPtr NativeFieldInfoPtr__plug;

		// Token: 0x04000366 RID: 870
		private static readonly IntPtr NativeMethodInfoPtr_Plug_Public_Static_PureQuaternionPlugin_0;

		// Token: 0x04000367 RID: 871
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Void_TweenerCore_3_Quaternion_Quaternion_NoOptions_0;

		// Token: 0x04000368 RID: 872
		private static readonly IntPtr NativeMethodInfoPtr_SetFrom_Public_Virtual_Void_TweenerCore_3_Quaternion_Quaternion_NoOptions_Boolean_0;

		// Token: 0x04000369 RID: 873
		private static readonly IntPtr NativeMethodInfoPtr_ConvertToStartValue_Public_Virtual_Quaternion_TweenerCore_3_Quaternion_Quaternion_NoOptions_Quaternion_0;

		// Token: 0x0400036A RID: 874
		private static readonly IntPtr NativeMethodInfoPtr_SetRelativeEndValue_Public_Virtual_Void_TweenerCore_3_Quaternion_Quaternion_NoOptions_0;

		// Token: 0x0400036B RID: 875
		private static readonly IntPtr NativeMethodInfoPtr_SetChangeValue_Public_Virtual_Void_TweenerCore_3_Quaternion_Quaternion_NoOptions_0;

		// Token: 0x0400036C RID: 876
		private static readonly IntPtr NativeMethodInfoPtr_GetSpeedBasedDuration_Public_Virtual_Single_NoOptions_Single_Quaternion_0;

		// Token: 0x0400036D RID: 877
		private static readonly IntPtr NativeMethodInfoPtr_EvaluateAndApply_Public_Virtual_Void_NoOptions_Tween_Boolean_DOGetter_1_Quaternion_DOSetter_1_Quaternion_Single_Quaternion_Quaternion_Single_Boolean_UpdateNotice_0;

		// Token: 0x0400036E RID: 878
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
