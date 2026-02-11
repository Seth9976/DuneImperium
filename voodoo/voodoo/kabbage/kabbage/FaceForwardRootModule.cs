using System;
using dwd.core.rendererManagement.configData;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using lotus;
using UnityEngine;

namespace voodoo.kabbage.kabbage
{
	// Token: 0x0200002F RID: 47
	public class FaceForwardRootModule : VoodooRootModule
	{
		// Token: 0x060001E0 RID: 480 RVA: 0x0000EE94 File Offset: 0x0000D094
		// Note: this type is marked as 'beforefieldinit'.
		static FaceForwardRootModule()
		{
			Il2CppClassPointerStore<FaceForwardRootModule>.NativeClassPtr = IL2CPP.GetIl2CppClass("voodoo.dll", "voodoo.kabbage.kabbage", "FaceForwardRootModule");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FaceForwardRootModule>.NativeClassPtr);
			FaceForwardRootModule.NativeFieldInfoPtr_backward = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FaceForwardRootModule>.NativeClassPtr, "backward");
			FaceForwardRootModule.NativeFieldInfoPtr_lastPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FaceForwardRootModule>.NativeClassPtr, "lastPosition");
			FaceForwardRootModule.NativeFieldInfoPtr_executionOrder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FaceForwardRootModule>.NativeClassPtr, "executionOrder");
			FaceForwardRootModule.NativeMethodInfoPtr_UpdateConfig_Public_Virtual_Void_VoodooRenderRoot_UnitView_VisibilityConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FaceForwardRootModule>.NativeClassPtr, 100663503);
			FaceForwardRootModule.NativeMethodInfoPtr_get_ExecutionOrder_Protected_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FaceForwardRootModule>.NativeClassPtr, 100663504);
			FaceForwardRootModule.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FaceForwardRootModule>.NativeClassPtr, 100663505);
		}

		// Token: 0x060001E1 RID: 481 RVA: 0x0000EF3C File Offset: 0x0000D13C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1107745, XrefRangeEnd = 1107750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FaceForwardRootModule.NativeMethodInfoPtr_UpdateConfig_Public_Virtual_Void_VoodooRenderRoot_UnitView_VisibilityConfiguration_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x060001E2 RID: 482 RVA: 0x0000EFB0 File Offset: 0x0000D1B0
		public unsafe override int ExecutionOrder
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 137950, RefRangeEnd = 137951, XrefRangeStart = 137950, XrefRangeEnd = 137951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FaceForwardRootModule.NativeMethodInfoPtr_get_ExecutionOrder_Protected_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060001E3 RID: 483 RVA: 0x0000EFF8 File Offset: 0x0000D1F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1107750, XrefRangeEnd = 1107751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FaceForwardRootModule()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FaceForwardRootModule>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FaceForwardRootModule.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001E4 RID: 484 RVA: 0x00003088 File Offset: 0x00001288
		public FaceForwardRootModule(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x060001E5 RID: 485 RVA: 0x0000F034 File Offset: 0x0000D234
		// (set) Token: 0x060001E6 RID: 486 RVA: 0x00003091 File Offset: 0x00001291
		public unsafe bool backward
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FaceForwardRootModule.NativeFieldInfoPtr_backward);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FaceForwardRootModule.NativeFieldInfoPtr_backward)) = value;
			}
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x060001E7 RID: 487 RVA: 0x0000F05C File Offset: 0x0000D25C
		// (set) Token: 0x060001E8 RID: 488 RVA: 0x000030AC File Offset: 0x000012AC
		public unsafe Vector3 lastPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FaceForwardRootModule.NativeFieldInfoPtr_lastPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FaceForwardRootModule.NativeFieldInfoPtr_lastPosition)) = value;
			}
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x060001E9 RID: 489 RVA: 0x0000F084 File Offset: 0x0000D284
		// (set) Token: 0x060001EA RID: 490 RVA: 0x000030C7 File Offset: 0x000012C7
		public unsafe int executionOrder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FaceForwardRootModule.NativeFieldInfoPtr_executionOrder);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FaceForwardRootModule.NativeFieldInfoPtr_executionOrder)) = value;
			}
		}

		// Token: 0x0400010A RID: 266
		private static readonly IntPtr NativeFieldInfoPtr_backward;

		// Token: 0x0400010B RID: 267
		private static readonly IntPtr NativeFieldInfoPtr_lastPosition;

		// Token: 0x0400010C RID: 268
		private static readonly IntPtr NativeFieldInfoPtr_executionOrder;

		// Token: 0x0400010D RID: 269
		private static readonly IntPtr NativeMethodInfoPtr_UpdateConfig_Public_Virtual_Void_VoodooRenderRoot_UnitView_VisibilityConfiguration_0;

		// Token: 0x0400010E RID: 270
		private static readonly IntPtr NativeMethodInfoPtr_get_ExecutionOrder_Protected_Virtual_get_Int32_0;

		// Token: 0x0400010F RID: 271
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
