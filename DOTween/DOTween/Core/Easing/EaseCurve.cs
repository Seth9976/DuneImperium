using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace DG.Tweening.Core.Easing
{
	// Token: 0x02000059 RID: 89
	public class EaseCurve : global::Il2CppSystem.Object
	{
		// Token: 0x06000540 RID: 1344 RVA: 0x0001D184 File Offset: 0x0001B384
		// Note: this type is marked as 'beforefieldinit'.
		static EaseCurve()
		{
			Il2CppClassPointerStore<EaseCurve>.NativeClassPtr = IL2CPP.GetIl2CppClass("DOTween.dll", "DG.Tweening.Core.Easing", "EaseCurve");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EaseCurve>.NativeClassPtr);
			EaseCurve.NativeFieldInfoPtr__animCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EaseCurve>.NativeClassPtr, "_animCurve");
			EaseCurve.NativeMethodInfoPtr__ctor_Public_Void_AnimationCurve_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EaseCurve>.NativeClassPtr, 100664329);
			EaseCurve.NativeMethodInfoPtr_Evaluate_Public_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EaseCurve>.NativeClassPtr, 100664330);
		}

		// Token: 0x06000541 RID: 1345 RVA: 0x0001D1F0 File Offset: 0x0001B3F0
		[CallerCount(148)]
		[CachedScanResults(RefRangeStart = 286435, RefRangeEnd = 286583, XrefRangeStart = 286435, XrefRangeEnd = 286583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EaseCurve(AnimationCurve animCurve)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EaseCurve>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(animCurve);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EaseCurve.NativeMethodInfoPtr__ctor_Public_Void_AnimationCurve_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000542 RID: 1346 RVA: 0x0001D23C File Offset: 0x0001B43C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1135445, XrefRangeEnd = 1135449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float Evaluate(float time, float duration, float unusedOvershoot, float unusedPeriod)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref time;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unusedOvershoot;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unusedPeriod;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EaseCurve.NativeMethodInfoPtr_Evaluate_Public_Single_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000543 RID: 1347 RVA: 0x00003B70 File Offset: 0x00001D70
		public EaseCurve(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000FC RID: 252
		// (get) Token: 0x06000544 RID: 1348 RVA: 0x0001D2B0 File Offset: 0x0001B4B0
		// (set) Token: 0x06000545 RID: 1349 RVA: 0x00003B79 File Offset: 0x00001D79
		public unsafe AnimationCurve _animCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EaseCurve.NativeFieldInfoPtr__animCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EaseCurve.NativeFieldInfoPtr__animCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000445 RID: 1093
		private static readonly IntPtr NativeFieldInfoPtr__animCurve;

		// Token: 0x04000446 RID: 1094
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_AnimationCurve_0;

		// Token: 0x04000447 RID: 1095
		private static readonly IntPtr NativeMethodInfoPtr_Evaluate_Public_Single_Single_Single_Single_Single_0;
	}
}
