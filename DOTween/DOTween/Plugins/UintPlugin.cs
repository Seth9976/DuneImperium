using System;
using DG.Tweening.Core;
using DG.Tweening.Core.Enums;
using DG.Tweening.Plugins.Core;
using DG.Tweening.Plugins.Options;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace DG.Tweening.Plugins
{
	// Token: 0x02000027 RID: 39
	public class UintPlugin : ABSTweenPlugin<uint, uint, UintOptions>
	{
		// Token: 0x060002E4 RID: 740 RVA: 0x00014998 File Offset: 0x00012B98
		// Note: this type is marked as 'beforefieldinit'.
		static UintPlugin()
		{
			Il2CppClassPointerStore<UintPlugin>.NativeClassPtr = IL2CPP.GetIl2CppClass("DOTween.dll", "DG.Tweening.Plugins", "UintPlugin");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UintPlugin>.NativeClassPtr);
			UintPlugin.NativeMethodInfoPtr_Reset_Public_Virtual_Void_TweenerCore_3_UInt32_UInt32_UintOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UintPlugin>.NativeClassPtr, 100664029);
			UintPlugin.NativeMethodInfoPtr_SetFrom_Public_Virtual_Void_TweenerCore_3_UInt32_UInt32_UintOptions_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UintPlugin>.NativeClassPtr, 100664030);
			UintPlugin.NativeMethodInfoPtr_ConvertToStartValue_Public_Virtual_UInt32_TweenerCore_3_UInt32_UInt32_UintOptions_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UintPlugin>.NativeClassPtr, 100664031);
			UintPlugin.NativeMethodInfoPtr_SetRelativeEndValue_Public_Virtual_Void_TweenerCore_3_UInt32_UInt32_UintOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UintPlugin>.NativeClassPtr, 100664032);
			UintPlugin.NativeMethodInfoPtr_SetChangeValue_Public_Virtual_Void_TweenerCore_3_UInt32_UInt32_UintOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UintPlugin>.NativeClassPtr, 100664033);
			UintPlugin.NativeMethodInfoPtr_GetSpeedBasedDuration_Public_Virtual_Single_UintOptions_Single_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UintPlugin>.NativeClassPtr, 100664034);
			UintPlugin.NativeMethodInfoPtr_EvaluateAndApply_Public_Virtual_Void_UintOptions_Tween_Boolean_DOGetter_1_UInt32_DOSetter_1_UInt32_Single_UInt32_UInt32_Single_Boolean_UpdateNotice_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UintPlugin>.NativeClassPtr, 100664035);
			UintPlugin.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UintPlugin>.NativeClassPtr, 100664036);
		}

		// Token: 0x060002E5 RID: 741 RVA: 0x00014A68 File Offset: 0x00012C68
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Reset(TweenerCore<uint, uint, UintOptions> t)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UintPlugin.NativeMethodInfoPtr_Reset_Public_Virtual_Void_TweenerCore_3_UInt32_UInt32_UintOptions_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002E6 RID: 742 RVA: 0x00014AB8 File Offset: 0x00012CB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1132148, XrefRangeEnd = 1132149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetFrom(TweenerCore<uint, uint, UintOptions> t, bool isRelative)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UintPlugin.NativeMethodInfoPtr_SetFrom_Public_Virtual_Void_TweenerCore_3_UInt32_UInt32_UintOptions_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002E7 RID: 743 RVA: 0x00014B14 File Offset: 0x00012D14
		[CallerCount(0)]
		public unsafe override uint ConvertToStartValue(TweenerCore<uint, uint, UintOptions> t, uint value)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UintPlugin.NativeMethodInfoPtr_ConvertToStartValue_Public_Virtual_UInt32_TweenerCore_3_UInt32_UInt32_UintOptions_UInt32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002E8 RID: 744 RVA: 0x00014B7C File Offset: 0x00012D7C
		[CallerCount(0)]
		public unsafe override void SetRelativeEndValue(TweenerCore<uint, uint, UintOptions> t)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UintPlugin.NativeMethodInfoPtr_SetRelativeEndValue_Public_Virtual_Void_TweenerCore_3_UInt32_UInt32_UintOptions_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002E9 RID: 745 RVA: 0x00014BCC File Offset: 0x00012DCC
		[CallerCount(0)]
		public unsafe override void SetChangeValue(TweenerCore<uint, uint, UintOptions> t)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UintPlugin.NativeMethodInfoPtr_SetChangeValue_Public_Virtual_Void_TweenerCore_3_UInt32_UInt32_UintOptions_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002EA RID: 746 RVA: 0x00014C1C File Offset: 0x00012E1C
		[CallerCount(0)]
		public unsafe override float GetSpeedBasedDuration(UintOptions options, float unitsXSecond, uint changeValue)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UintPlugin.NativeMethodInfoPtr_GetSpeedBasedDuration_Public_Virtual_Single_UintOptions_Single_UInt32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002EB RID: 747 RVA: 0x00014C8C File Offset: 0x00012E8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1132149, XrefRangeEnd = 1132161, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void EvaluateAndApply(UintOptions options, Tween t, bool isRelative, DOGetter<uint> getter, DOSetter<uint> setter, float elapsed, uint startValue, uint changeValue, float duration, bool usingInversePosition, UpdateNotice updateNotice)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UintPlugin.NativeMethodInfoPtr_EvaluateAndApply_Public_Virtual_Void_UintOptions_Tween_Boolean_DOGetter_1_UInt32_DOSetter_1_UInt32_Single_UInt32_UInt32_Single_Boolean_UpdateNotice_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002EC RID: 748 RVA: 0x00014D74 File Offset: 0x00012F74
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1132164, RefRangeEnd = 1132165, XrefRangeStart = 1132161, XrefRangeEnd = 1132164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UintPlugin()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UintPlugin>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UintPlugin.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002ED RID: 749 RVA: 0x00002C3F File Offset: 0x00000E3F
		public UintPlugin(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000296 RID: 662
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Void_TweenerCore_3_UInt32_UInt32_UintOptions_0;

		// Token: 0x04000297 RID: 663
		private static readonly IntPtr NativeMethodInfoPtr_SetFrom_Public_Virtual_Void_TweenerCore_3_UInt32_UInt32_UintOptions_Boolean_0;

		// Token: 0x04000298 RID: 664
		private static readonly IntPtr NativeMethodInfoPtr_ConvertToStartValue_Public_Virtual_UInt32_TweenerCore_3_UInt32_UInt32_UintOptions_UInt32_0;

		// Token: 0x04000299 RID: 665
		private static readonly IntPtr NativeMethodInfoPtr_SetRelativeEndValue_Public_Virtual_Void_TweenerCore_3_UInt32_UInt32_UintOptions_0;

		// Token: 0x0400029A RID: 666
		private static readonly IntPtr NativeMethodInfoPtr_SetChangeValue_Public_Virtual_Void_TweenerCore_3_UInt32_UInt32_UintOptions_0;

		// Token: 0x0400029B RID: 667
		private static readonly IntPtr NativeMethodInfoPtr_GetSpeedBasedDuration_Public_Virtual_Single_UintOptions_Single_UInt32_0;

		// Token: 0x0400029C RID: 668
		private static readonly IntPtr NativeMethodInfoPtr_EvaluateAndApply_Public_Virtual_Void_UintOptions_Tween_Boolean_DOGetter_1_UInt32_DOSetter_1_UInt32_Single_UInt32_UInt32_Single_Boolean_UpdateNotice_0;

		// Token: 0x0400029D RID: 669
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
