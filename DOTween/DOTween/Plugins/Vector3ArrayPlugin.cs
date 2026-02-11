using System;
using DG.Tweening.Core;
using DG.Tweening.Core.Enums;
using DG.Tweening.Plugins.Core;
using DG.Tweening.Plugins.Options;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace DG.Tweening.Plugins
{
	// Token: 0x02000020 RID: 32
	public class Vector3ArrayPlugin : ABSTweenPlugin<Vector3, Il2CppStructArray<Vector3>, Vector3ArrayOptions>
	{
		// Token: 0x06000298 RID: 664 RVA: 0x00012B2C File Offset: 0x00010D2C
		// Note: this type is marked as 'beforefieldinit'.
		static Vector3ArrayPlugin()
		{
			Il2CppClassPointerStore<Vector3ArrayPlugin>.NativeClassPtr = IL2CPP.GetIl2CppClass("DOTween.dll", "DG.Tweening.Plugins", "Vector3ArrayPlugin");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Vector3ArrayPlugin>.NativeClassPtr);
			Vector3ArrayPlugin.NativeMethodInfoPtr_Reset_Public_Virtual_Void_TweenerCore_3_Vector3_Il2CppStructArray_1_Vector3_Vector3ArrayOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3ArrayPlugin>.NativeClassPtr, 100663970);
			Vector3ArrayPlugin.NativeMethodInfoPtr_SetFrom_Public_Virtual_Void_TweenerCore_3_Vector3_Il2CppStructArray_1_Vector3_Vector3ArrayOptions_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3ArrayPlugin>.NativeClassPtr, 100663971);
			Vector3ArrayPlugin.NativeMethodInfoPtr_ConvertToStartValue_Public_Virtual_Il2CppStructArray_1_Vector3_TweenerCore_3_Vector3_Il2CppStructArray_1_Vector3_Vector3ArrayOptions_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3ArrayPlugin>.NativeClassPtr, 100663972);
			Vector3ArrayPlugin.NativeMethodInfoPtr_SetRelativeEndValue_Public_Virtual_Void_TweenerCore_3_Vector3_Il2CppStructArray_1_Vector3_Vector3ArrayOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3ArrayPlugin>.NativeClassPtr, 100663973);
			Vector3ArrayPlugin.NativeMethodInfoPtr_SetChangeValue_Public_Virtual_Void_TweenerCore_3_Vector3_Il2CppStructArray_1_Vector3_Vector3ArrayOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3ArrayPlugin>.NativeClassPtr, 100663974);
			Vector3ArrayPlugin.NativeMethodInfoPtr_GetSpeedBasedDuration_Public_Virtual_Single_Vector3ArrayOptions_Single_Il2CppStructArray_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3ArrayPlugin>.NativeClassPtr, 100663975);
			Vector3ArrayPlugin.NativeMethodInfoPtr_EvaluateAndApply_Public_Virtual_Void_Vector3ArrayOptions_Tween_Boolean_DOGetter_1_Vector3_DOSetter_1_Vector3_Single_Il2CppStructArray_1_Vector3_Il2CppStructArray_1_Vector3_Single_Boolean_UpdateNotice_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3ArrayPlugin>.NativeClassPtr, 100663976);
			Vector3ArrayPlugin.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3ArrayPlugin>.NativeClassPtr, 100663977);
		}

		// Token: 0x06000299 RID: 665 RVA: 0x00012BFC File Offset: 0x00010DFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1131776, XrefRangeEnd = 1131780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Reset(TweenerCore<Vector3, Il2CppStructArray<Vector3>, Vector3ArrayOptions> t)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Vector3ArrayPlugin.NativeMethodInfoPtr_Reset_Public_Virtual_Void_TweenerCore_3_Vector3_Il2CppStructArray_1_Vector3_Vector3ArrayOptions_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600029A RID: 666 RVA: 0x00012C4C File Offset: 0x00010E4C
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetFrom(TweenerCore<Vector3, Il2CppStructArray<Vector3>, Vector3ArrayOptions> t, bool isRelative)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Vector3ArrayPlugin.NativeMethodInfoPtr_SetFrom_Public_Virtual_Void_TweenerCore_3_Vector3_Il2CppStructArray_1_Vector3_Vector3ArrayOptions_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600029B RID: 667 RVA: 0x00012CA8 File Offset: 0x00010EA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1131780, XrefRangeEnd = 1131784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Il2CppStructArray<Vector3> ConvertToStartValue(TweenerCore<Vector3, Il2CppStructArray<Vector3>, Vector3ArrayOptions> t, Vector3 value)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Vector3ArrayPlugin.NativeMethodInfoPtr_ConvertToStartValue_Public_Virtual_Il2CppStructArray_1_Vector3_TweenerCore_3_Vector3_Il2CppStructArray_1_Vector3_Vector3ArrayOptions_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr3) : null;
		}

		// Token: 0x0600029C RID: 668 RVA: 0x00012D14 File Offset: 0x00010F14
		[CallerCount(0)]
		public unsafe override void SetRelativeEndValue(TweenerCore<Vector3, Il2CppStructArray<Vector3>, Vector3ArrayOptions> t)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Vector3ArrayPlugin.NativeMethodInfoPtr_SetRelativeEndValue_Public_Virtual_Void_TweenerCore_3_Vector3_Il2CppStructArray_1_Vector3_Vector3ArrayOptions_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600029D RID: 669 RVA: 0x00012D64 File Offset: 0x00010F64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1131784, XrefRangeEnd = 1131788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetChangeValue(TweenerCore<Vector3, Il2CppStructArray<Vector3>, Vector3ArrayOptions> t)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Vector3ArrayPlugin.NativeMethodInfoPtr_SetChangeValue_Public_Virtual_Void_TweenerCore_3_Vector3_Il2CppStructArray_1_Vector3_Vector3ArrayOptions_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600029E RID: 670 RVA: 0x00012DB4 File Offset: 0x00010FB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1131788, XrefRangeEnd = 1131793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override float GetSpeedBasedDuration(Vector3ArrayOptions options, float unitsXSecond, Il2CppStructArray<Vector3> changeValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(options));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unitsXSecond;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(changeValue);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Vector3ArrayPlugin.NativeMethodInfoPtr_GetSpeedBasedDuration_Public_Virtual_Single_Vector3ArrayOptions_Single_Il2CppStructArray_1_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600029F RID: 671 RVA: 0x00012E34 File Offset: 0x00011034
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1131793, XrefRangeEnd = 1131802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void EvaluateAndApply(Vector3ArrayOptions options, Tween t, bool isRelative, DOGetter<Vector3> getter, DOSetter<Vector3> setter, float elapsed, Il2CppStructArray<Vector3> startValue, Il2CppStructArray<Vector3> changeValue, float duration, bool usingInversePosition, UpdateNotice updateNotice)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(options));
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Vector3ArrayPlugin.NativeMethodInfoPtr_EvaluateAndApply_Public_Virtual_Void_Vector3ArrayOptions_Tween_Boolean_DOGetter_1_Vector3_DOSetter_1_Vector3_Single_Il2CppStructArray_1_Vector3_Il2CppStructArray_1_Vector3_Single_Boolean_UpdateNotice_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002A0 RID: 672 RVA: 0x00012F30 File Offset: 0x00011130
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1131805, RefRangeEnd = 1131806, XrefRangeStart = 1131802, XrefRangeEnd = 1131805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3ArrayPlugin()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Vector3ArrayPlugin>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3ArrayPlugin.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002A1 RID: 673 RVA: 0x00002BE0 File Offset: 0x00000DE0
		public Vector3ArrayPlugin(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400025A RID: 602
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Void_TweenerCore_3_Vector3_Il2CppStructArray_1_Vector3_Vector3ArrayOptions_0;

		// Token: 0x0400025B RID: 603
		private static readonly IntPtr NativeMethodInfoPtr_SetFrom_Public_Virtual_Void_TweenerCore_3_Vector3_Il2CppStructArray_1_Vector3_Vector3ArrayOptions_Boolean_0;

		// Token: 0x0400025C RID: 604
		private static readonly IntPtr NativeMethodInfoPtr_ConvertToStartValue_Public_Virtual_Il2CppStructArray_1_Vector3_TweenerCore_3_Vector3_Il2CppStructArray_1_Vector3_Vector3ArrayOptions_Vector3_0;

		// Token: 0x0400025D RID: 605
		private static readonly IntPtr NativeMethodInfoPtr_SetRelativeEndValue_Public_Virtual_Void_TweenerCore_3_Vector3_Il2CppStructArray_1_Vector3_Vector3ArrayOptions_0;

		// Token: 0x0400025E RID: 606
		private static readonly IntPtr NativeMethodInfoPtr_SetChangeValue_Public_Virtual_Void_TweenerCore_3_Vector3_Il2CppStructArray_1_Vector3_Vector3ArrayOptions_0;

		// Token: 0x0400025F RID: 607
		private static readonly IntPtr NativeMethodInfoPtr_GetSpeedBasedDuration_Public_Virtual_Single_Vector3ArrayOptions_Single_Il2CppStructArray_1_Vector3_0;

		// Token: 0x04000260 RID: 608
		private static readonly IntPtr NativeMethodInfoPtr_EvaluateAndApply_Public_Virtual_Void_Vector3ArrayOptions_Tween_Boolean_DOGetter_1_Vector3_DOSetter_1_Vector3_Single_Il2CppStructArray_1_Vector3_Il2CppStructArray_1_Vector3_Single_Boolean_UpdateNotice_0;

		// Token: 0x04000261 RID: 609
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
