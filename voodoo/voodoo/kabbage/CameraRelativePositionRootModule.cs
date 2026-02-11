using System;
using dwd.core.rendererManagement.configData;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using lotus;
using UnityEngine;

namespace voodoo.kabbage
{
	// Token: 0x02000020 RID: 32
	public class CameraRelativePositionRootModule : VoodooRootModule
	{
		// Token: 0x060000FD RID: 253 RVA: 0x0000C2D4 File Offset: 0x0000A4D4
		// Note: this type is marked as 'beforefieldinit'.
		static CameraRelativePositionRootModule()
		{
			Il2CppClassPointerStore<CameraRelativePositionRootModule>.NativeClassPtr = IL2CPP.GetIl2CppClass("voodoo.dll", "voodoo.kabbage", "CameraRelativePositionRootModule");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CameraRelativePositionRootModule>.NativeClassPtr);
			CameraRelativePositionRootModule.NativeFieldInfoPtr_relativePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraRelativePositionRootModule>.NativeClassPtr, "relativePosition");
			CameraRelativePositionRootModule.NativeFieldInfoPtr_cameraTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraRelativePositionRootModule>.NativeClassPtr, "cameraTransform");
			CameraRelativePositionRootModule.NativeFieldInfoPtr_executionOrder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraRelativePositionRootModule>.NativeClassPtr, "executionOrder");
			CameraRelativePositionRootModule.NativeMethodInfoPtr_setCamera_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraRelativePositionRootModule>.NativeClassPtr, 100663408);
			CameraRelativePositionRootModule.NativeMethodInfoPtr_UpdateConfig_Public_Virtual_Void_VoodooRenderRoot_UnitView_VisibilityConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraRelativePositionRootModule>.NativeClassPtr, 100663409);
			CameraRelativePositionRootModule.NativeMethodInfoPtr_get_ExecutionOrder_Protected_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraRelativePositionRootModule>.NativeClassPtr, 100663410);
			CameraRelativePositionRootModule.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraRelativePositionRootModule>.NativeClassPtr, 100663411);
		}

		// Token: 0x060000FE RID: 254 RVA: 0x0000C390 File Offset: 0x0000A590
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1107081, XrefRangeEnd = 1107085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void setCamera()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CameraRelativePositionRootModule.NativeMethodInfoPtr_setCamera_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000FF RID: 255 RVA: 0x0000C3CC File Offset: 0x0000A5CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1107085, XrefRangeEnd = 1107097, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CameraRelativePositionRootModule.NativeMethodInfoPtr_UpdateConfig_Public_Virtual_Void_VoodooRenderRoot_UnitView_VisibilityConfiguration_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x06000100 RID: 256 RVA: 0x0000C440 File Offset: 0x0000A640
		public unsafe override int ExecutionOrder
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 137950, RefRangeEnd = 137951, XrefRangeStart = 137950, XrefRangeEnd = 137951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CameraRelativePositionRootModule.NativeMethodInfoPtr_get_ExecutionOrder_Protected_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000101 RID: 257 RVA: 0x0000C488 File Offset: 0x0000A688
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CameraRelativePositionRootModule()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CameraRelativePositionRootModule>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraRelativePositionRootModule.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000102 RID: 258 RVA: 0x00002904 File Offset: 0x00000B04
		public CameraRelativePositionRootModule(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x06000103 RID: 259 RVA: 0x0000C4C4 File Offset: 0x0000A6C4
		// (set) Token: 0x06000104 RID: 260 RVA: 0x0000290D File Offset: 0x00000B0D
		public unsafe Transform relativePosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraRelativePositionRootModule.NativeFieldInfoPtr_relativePosition);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraRelativePositionRootModule.NativeFieldInfoPtr_relativePosition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x06000105 RID: 261 RVA: 0x0000C4F4 File Offset: 0x0000A6F4
		// (set) Token: 0x06000106 RID: 262 RVA: 0x0000292C File Offset: 0x00000B2C
		public unsafe Transform cameraTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraRelativePositionRootModule.NativeFieldInfoPtr_cameraTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraRelativePositionRootModule.NativeFieldInfoPtr_cameraTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x06000107 RID: 263 RVA: 0x0000C524 File Offset: 0x0000A724
		// (set) Token: 0x06000108 RID: 264 RVA: 0x0000294B File Offset: 0x00000B4B
		public unsafe int executionOrder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraRelativePositionRootModule.NativeFieldInfoPtr_executionOrder);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraRelativePositionRootModule.NativeFieldInfoPtr_executionOrder)) = value;
			}
		}

		// Token: 0x04000084 RID: 132
		private static readonly IntPtr NativeFieldInfoPtr_relativePosition;

		// Token: 0x04000085 RID: 133
		private static readonly IntPtr NativeFieldInfoPtr_cameraTransform;

		// Token: 0x04000086 RID: 134
		private static readonly IntPtr NativeFieldInfoPtr_executionOrder;

		// Token: 0x04000087 RID: 135
		private static readonly IntPtr NativeMethodInfoPtr_setCamera_Protected_Virtual_New_Void_0;

		// Token: 0x04000088 RID: 136
		private static readonly IntPtr NativeMethodInfoPtr_UpdateConfig_Public_Virtual_Void_VoodooRenderRoot_UnitView_VisibilityConfiguration_0;

		// Token: 0x04000089 RID: 137
		private static readonly IntPtr NativeMethodInfoPtr_get_ExecutionOrder_Protected_Virtual_get_Int32_0;

		// Token: 0x0400008A RID: 138
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
