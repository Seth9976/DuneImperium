using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace lotus
{
	// Token: 0x020000D6 RID: 214
	public class TargetedCameraPosition : EnvironmentCameraPosition
	{
		// Token: 0x06000ABB RID: 2747 RVA: 0x00033430 File Offset: 0x00031630
		// Note: this type is marked as 'beforefieldinit'.
		static TargetedCameraPosition()
		{
			Il2CppClassPointerStore<TargetedCameraPosition>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "lotus", "TargetedCameraPosition");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TargetedCameraPosition>.NativeClassPtr);
			TargetedCameraPosition.NativeFieldInfoPtr_viewTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetedCameraPosition>.NativeClassPtr, "viewTarget");
			TargetedCameraPosition.NativeFieldInfoPtr_viewAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetedCameraPosition>.NativeClassPtr, "viewAngle");
			TargetedCameraPosition.NativeFieldInfoPtr_ceilingPlane = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetedCameraPosition>.NativeClassPtr, "ceilingPlane");
			TargetedCameraPosition.NativeFieldInfoPtr_cachedTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetedCameraPosition>.NativeClassPtr, "cachedTransform");
			TargetedCameraPosition.NativeMethodInfoPtr_set_ViewTarget_Public_set_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetedCameraPosition>.NativeClassPtr, 100665030);
			TargetedCameraPosition.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetedCameraPosition>.NativeClassPtr, 100665031);
			TargetedCameraPosition.NativeMethodInfoPtr_OnDrawGizmosSelected_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetedCameraPosition>.NativeClassPtr, 100665032);
			TargetedCameraPosition.NativeMethodInfoPtr_updatePlane_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetedCameraPosition>.NativeClassPtr, 100665033);
			TargetedCameraPosition.NativeMethodInfoPtr_updateForTarget_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetedCameraPosition>.NativeClassPtr, 100665034);
			TargetedCameraPosition.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetedCameraPosition>.NativeClassPtr, 100665035);
		}

		// Token: 0x170002E4 RID: 740
		// (set) Token: 0x06000ABC RID: 2748 RVA: 0x00033528 File Offset: 0x00031728
		public unsafe Transform ViewTarget
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 994192, XrefRangeEnd = 994205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TargetedCameraPosition.NativeMethodInfoPtr_set_ViewTarget_Public_set_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000ABD RID: 2749 RVA: 0x0003356C File Offset: 0x0003176C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 994205, XrefRangeEnd = 994208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TargetedCameraPosition.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000ABE RID: 2750 RVA: 0x000335A0 File Offset: 0x000317A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 994208, XrefRangeEnd = 994227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDrawGizmosSelected()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TargetedCameraPosition.NativeMethodInfoPtr_OnDrawGizmosSelected_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000ABF RID: 2751 RVA: 0x000335D4 File Offset: 0x000317D4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 994231, RefRangeEnd = 994235, XrefRangeStart = 994227, XrefRangeEnd = 994231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void updatePlane()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TargetedCameraPosition.NativeMethodInfoPtr_updatePlane_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AC0 RID: 2752 RVA: 0x00033608 File Offset: 0x00031808
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 994235, XrefRangeEnd = 994247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void updateForTarget()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TargetedCameraPosition.NativeMethodInfoPtr_updateForTarget_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AC1 RID: 2753 RVA: 0x0003363C File Offset: 0x0003183C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 994247, XrefRangeEnd = 994251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TargetedCameraPosition()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TargetedCameraPosition>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TargetedCameraPosition.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AC2 RID: 2754 RVA: 0x00006ED8 File Offset: 0x000050D8
		public TargetedCameraPosition(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002E0 RID: 736
		// (get) Token: 0x06000AC3 RID: 2755 RVA: 0x00033678 File Offset: 0x00031878
		// (set) Token: 0x06000AC4 RID: 2756 RVA: 0x00006EE1 File Offset: 0x000050E1
		public unsafe Transform viewTarget
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TargetedCameraPosition.NativeFieldInfoPtr_viewTarget);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TargetedCameraPosition.NativeFieldInfoPtr_viewTarget), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002E1 RID: 737
		// (get) Token: 0x06000AC5 RID: 2757 RVA: 0x000336A8 File Offset: 0x000318A8
		// (set) Token: 0x06000AC6 RID: 2758 RVA: 0x00006F00 File Offset: 0x00005100
		public unsafe float viewAngle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TargetedCameraPosition.NativeFieldInfoPtr_viewAngle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TargetedCameraPosition.NativeFieldInfoPtr_viewAngle)) = value;
			}
		}

		// Token: 0x170002E2 RID: 738
		// (get) Token: 0x06000AC7 RID: 2759 RVA: 0x000336D0 File Offset: 0x000318D0
		// (set) Token: 0x06000AC8 RID: 2760 RVA: 0x00006F1B File Offset: 0x0000511B
		public unsafe Plane ceilingPlane
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TargetedCameraPosition.NativeFieldInfoPtr_ceilingPlane);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TargetedCameraPosition.NativeFieldInfoPtr_ceilingPlane)) = value;
			}
		}

		// Token: 0x170002E3 RID: 739
		// (get) Token: 0x06000AC9 RID: 2761 RVA: 0x000336F8 File Offset: 0x000318F8
		// (set) Token: 0x06000ACA RID: 2762 RVA: 0x00006F36 File Offset: 0x00005136
		public unsafe Transform cachedTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TargetedCameraPosition.NativeFieldInfoPtr_cachedTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TargetedCameraPosition.NativeFieldInfoPtr_cachedTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400069C RID: 1692
		private static readonly IntPtr NativeFieldInfoPtr_viewTarget;

		// Token: 0x0400069D RID: 1693
		private static readonly IntPtr NativeFieldInfoPtr_viewAngle;

		// Token: 0x0400069E RID: 1694
		private static readonly IntPtr NativeFieldInfoPtr_ceilingPlane;

		// Token: 0x0400069F RID: 1695
		private static readonly IntPtr NativeFieldInfoPtr_cachedTransform;

		// Token: 0x040006A0 RID: 1696
		private static readonly IntPtr NativeMethodInfoPtr_set_ViewTarget_Public_set_Void_Transform_0;

		// Token: 0x040006A1 RID: 1697
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040006A2 RID: 1698
		private static readonly IntPtr NativeMethodInfoPtr_OnDrawGizmosSelected_Private_Void_0;

		// Token: 0x040006A3 RID: 1699
		private static readonly IntPtr NativeMethodInfoPtr_updatePlane_Private_Void_0;

		// Token: 0x040006A4 RID: 1700
		private static readonly IntPtr NativeMethodInfoPtr_updateForTarget_Private_Void_0;

		// Token: 0x040006A5 RID: 1701
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
