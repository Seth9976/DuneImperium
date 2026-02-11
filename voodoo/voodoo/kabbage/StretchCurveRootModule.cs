using System;
using dwd.core.rendererManagement.configData;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using lotus;
using UnityEngine;

namespace voodoo.kabbage
{
	// Token: 0x02000024 RID: 36
	public class StretchCurveRootModule : VoodooRootModule
	{
		// Token: 0x06000122 RID: 290 RVA: 0x0000CAAC File Offset: 0x0000ACAC
		// Note: this type is marked as 'beforefieldinit'.
		static StretchCurveRootModule()
		{
			Il2CppClassPointerStore<StretchCurveRootModule>.NativeClassPtr = IL2CPP.GetIl2CppClass("voodoo.dll", "voodoo.kabbage", "StretchCurveRootModule");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StretchCurveRootModule>.NativeClassPtr);
			StretchCurveRootModule.NativeFieldInfoPtr_animationStartPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StretchCurveRootModule>.NativeClassPtr, "animationStartPoint");
			StretchCurveRootModule.NativeFieldInfoPtr_animatorRoot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StretchCurveRootModule>.NativeClassPtr, "animatorRoot");
			StretchCurveRootModule.NativeFieldInfoPtr_executionOrder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StretchCurveRootModule>.NativeClassPtr, "executionOrder");
			StretchCurveRootModule.NativeFieldInfoPtr_stretchHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StretchCurveRootModule>.NativeClassPtr, "stretchHeight");
			StretchCurveRootModule.NativeFieldInfoPtr_stretchWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StretchCurveRootModule>.NativeClassPtr, "stretchWidth");
			StretchCurveRootModule.NativeFieldInfoPtr_lateStarted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StretchCurveRootModule>.NativeClassPtr, "lateStarted");
			StretchCurveRootModule.NativeMethodInfoPtr_get_ExecutionOrder_Protected_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StretchCurveRootModule>.NativeClassPtr, 100663421);
			StretchCurveRootModule.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StretchCurveRootModule>.NativeClassPtr, 100663422);
			StretchCurveRootModule.NativeMethodInfoPtr_UpdateConfig_Public_Virtual_Void_VoodooRenderRoot_UnitView_VisibilityConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StretchCurveRootModule>.NativeClassPtr, 100663423);
			StretchCurveRootModule.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StretchCurveRootModule>.NativeClassPtr, 100663424);
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x06000123 RID: 291 RVA: 0x0000CBA4 File Offset: 0x0000ADA4
		public unsafe override int ExecutionOrder
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StretchCurveRootModule.NativeMethodInfoPtr_get_ExecutionOrder_Protected_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000124 RID: 292 RVA: 0x0000CBEC File Offset: 0x0000ADEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1107110, XrefRangeEnd = 1107120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StretchCurveRootModule.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000125 RID: 293 RVA: 0x0000CC20 File Offset: 0x0000AE20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1107120, XrefRangeEnd = 1107124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void UpdateConfig(VoodooRenderRoot root, UnitView unit, VisibilityConfiguration config)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(root);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(unit);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(config);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StretchCurveRootModule.NativeMethodInfoPtr_UpdateConfig_Public_Virtual_Void_VoodooRenderRoot_UnitView_VisibilityConfiguration_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000126 RID: 294 RVA: 0x0000CC94 File Offset: 0x0000AE94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1107124, XrefRangeEnd = 1107127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StretchCurveRootModule()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StretchCurveRootModule>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StretchCurveRootModule.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000127 RID: 295 RVA: 0x00002A0C File Offset: 0x00000C0C
		public StretchCurveRootModule(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x06000128 RID: 296 RVA: 0x0000CCD0 File Offset: 0x0000AED0
		// (set) Token: 0x06000129 RID: 297 RVA: 0x00002A15 File Offset: 0x00000C15
		public unsafe Vector3 animationStartPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StretchCurveRootModule.NativeFieldInfoPtr_animationStartPoint);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StretchCurveRootModule.NativeFieldInfoPtr_animationStartPoint)) = value;
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x0600012A RID: 298 RVA: 0x0000CCF8 File Offset: 0x0000AEF8
		// (set) Token: 0x0600012B RID: 299 RVA: 0x00002A30 File Offset: 0x00000C30
		public unsafe Transform animatorRoot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StretchCurveRootModule.NativeFieldInfoPtr_animatorRoot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StretchCurveRootModule.NativeFieldInfoPtr_animatorRoot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x0600012C RID: 300 RVA: 0x0000CD28 File Offset: 0x0000AF28
		// (set) Token: 0x0600012D RID: 301 RVA: 0x00002A4F File Offset: 0x00000C4F
		public unsafe int executionOrder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StretchCurveRootModule.NativeFieldInfoPtr_executionOrder);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StretchCurveRootModule.NativeFieldInfoPtr_executionOrder)) = value;
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x0600012E RID: 302 RVA: 0x0000CD50 File Offset: 0x0000AF50
		// (set) Token: 0x0600012F RID: 303 RVA: 0x00002A6A File Offset: 0x00000C6A
		public unsafe float stretchHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StretchCurveRootModule.NativeFieldInfoPtr_stretchHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StretchCurveRootModule.NativeFieldInfoPtr_stretchHeight)) = value;
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x06000130 RID: 304 RVA: 0x0000CD78 File Offset: 0x0000AF78
		// (set) Token: 0x06000131 RID: 305 RVA: 0x00002A85 File Offset: 0x00000C85
		public unsafe float stretchWidth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StretchCurveRootModule.NativeFieldInfoPtr_stretchWidth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StretchCurveRootModule.NativeFieldInfoPtr_stretchWidth)) = value;
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x06000132 RID: 306 RVA: 0x0000CDA0 File Offset: 0x0000AFA0
		// (set) Token: 0x06000133 RID: 307 RVA: 0x00002AA0 File Offset: 0x00000CA0
		public unsafe bool lateStarted
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StretchCurveRootModule.NativeFieldInfoPtr_lateStarted);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StretchCurveRootModule.NativeFieldInfoPtr_lateStarted)) = value;
			}
		}

		// Token: 0x04000099 RID: 153
		private static readonly IntPtr NativeFieldInfoPtr_animationStartPoint;

		// Token: 0x0400009A RID: 154
		private static readonly IntPtr NativeFieldInfoPtr_animatorRoot;

		// Token: 0x0400009B RID: 155
		private static readonly IntPtr NativeFieldInfoPtr_executionOrder;

		// Token: 0x0400009C RID: 156
		private static readonly IntPtr NativeFieldInfoPtr_stretchHeight;

		// Token: 0x0400009D RID: 157
		private static readonly IntPtr NativeFieldInfoPtr_stretchWidth;

		// Token: 0x0400009E RID: 158
		private static readonly IntPtr NativeFieldInfoPtr_lateStarted;

		// Token: 0x0400009F RID: 159
		private static readonly IntPtr NativeMethodInfoPtr_get_ExecutionOrder_Protected_Virtual_get_Int32_0;

		// Token: 0x040000A0 RID: 160
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x040000A1 RID: 161
		private static readonly IntPtr NativeMethodInfoPtr_UpdateConfig_Public_Virtual_Void_VoodooRenderRoot_UnitView_VisibilityConfiguration_0;

		// Token: 0x040000A2 RID: 162
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
