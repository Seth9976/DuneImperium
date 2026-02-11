using System;
using dwd.core.rendererManagement.configData;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using lotus;
using UnityEngine;

namespace voodoo.kabbage
{
	// Token: 0x0200002E RID: 46
	public class WaypointRootModule : VoodooRootModule
	{
		// Token: 0x060001D4 RID: 468 RVA: 0x0000EC1C File Offset: 0x0000CE1C
		// Note: this type is marked as 'beforefieldinit'.
		static WaypointRootModule()
		{
			Il2CppClassPointerStore<WaypointRootModule>.NativeClassPtr = IL2CPP.GetIl2CppClass("voodoo.dll", "voodoo.kabbage", "WaypointRootModule");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WaypointRootModule>.NativeClassPtr);
			WaypointRootModule.NativeFieldInfoPtr_pathPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaypointRootModule>.NativeClassPtr, "pathPosition");
			WaypointRootModule.NativeFieldInfoPtr_waypoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaypointRootModule>.NativeClassPtr, "waypoints");
			WaypointRootModule.NativeFieldInfoPtr_executionOrder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaypointRootModule>.NativeClassPtr, "executionOrder");
			WaypointRootModule.NativeMethodInfoPtr_Configure_Public_Virtual_Final_New_Void_MoveContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaypointRootModule>.NativeClassPtr, 100663499);
			WaypointRootModule.NativeMethodInfoPtr_UpdateConfig_Public_Virtual_Void_VoodooRenderRoot_UnitView_VisibilityConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaypointRootModule>.NativeClassPtr, 100663500);
			WaypointRootModule.NativeMethodInfoPtr_get_ExecutionOrder_Protected_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaypointRootModule>.NativeClassPtr, 100663501);
			WaypointRootModule.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaypointRootModule>.NativeClassPtr, 100663502);
		}

		// Token: 0x060001D5 RID: 469 RVA: 0x0000ECD8 File Offset: 0x0000CED8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1107683, XrefRangeEnd = 1107720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Configure(MoveContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaypointRootModule.NativeMethodInfoPtr_Configure_Public_Virtual_Final_New_Void_MoveContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001D6 RID: 470 RVA: 0x0000ED1C File Offset: 0x0000CF1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1107720, XrefRangeEnd = 1107737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WaypointRootModule.NativeMethodInfoPtr_UpdateConfig_Public_Virtual_Void_VoodooRenderRoot_UnitView_VisibilityConfiguration_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x060001D7 RID: 471 RVA: 0x0000ED90 File Offset: 0x0000CF90
		public unsafe override int ExecutionOrder
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 137950, RefRangeEnd = 137951, XrefRangeStart = 137950, XrefRangeEnd = 137951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WaypointRootModule.NativeMethodInfoPtr_get_ExecutionOrder_Protected_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060001D8 RID: 472 RVA: 0x0000EDD8 File Offset: 0x0000CFD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1107737, XrefRangeEnd = 1107745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WaypointRootModule()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WaypointRootModule>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaypointRootModule.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001D9 RID: 473 RVA: 0x0000302A File Offset: 0x0000122A
		public WaypointRootModule(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x060001DA RID: 474 RVA: 0x0000EE14 File Offset: 0x0000D014
		// (set) Token: 0x060001DB RID: 475 RVA: 0x00003033 File Offset: 0x00001233
		public unsafe float pathPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaypointRootModule.NativeFieldInfoPtr_pathPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaypointRootModule.NativeFieldInfoPtr_pathPosition)) = value;
			}
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x060001DC RID: 476 RVA: 0x0000EE3C File Offset: 0x0000D03C
		// (set) Token: 0x060001DD RID: 477 RVA: 0x0000304E File Offset: 0x0000124E
		public unsafe List<ValueTuple<float, Transform>> waypoints
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaypointRootModule.NativeFieldInfoPtr_waypoints);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ValueTuple<float, Transform>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaypointRootModule.NativeFieldInfoPtr_waypoints), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x060001DE RID: 478 RVA: 0x0000EE6C File Offset: 0x0000D06C
		// (set) Token: 0x060001DF RID: 479 RVA: 0x0000306D File Offset: 0x0000126D
		public unsafe int executionOrder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaypointRootModule.NativeFieldInfoPtr_executionOrder);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaypointRootModule.NativeFieldInfoPtr_executionOrder)) = value;
			}
		}

		// Token: 0x04000103 RID: 259
		private static readonly IntPtr NativeFieldInfoPtr_pathPosition;

		// Token: 0x04000104 RID: 260
		private static readonly IntPtr NativeFieldInfoPtr_waypoints;

		// Token: 0x04000105 RID: 261
		private static readonly IntPtr NativeFieldInfoPtr_executionOrder;

		// Token: 0x04000106 RID: 262
		private static readonly IntPtr NativeMethodInfoPtr_Configure_Public_Virtual_Final_New_Void_MoveContext_0;

		// Token: 0x04000107 RID: 263
		private static readonly IntPtr NativeMethodInfoPtr_UpdateConfig_Public_Virtual_Void_VoodooRenderRoot_UnitView_VisibilityConfiguration_0;

		// Token: 0x04000108 RID: 264
		private static readonly IntPtr NativeMethodInfoPtr_get_ExecutionOrder_Protected_Virtual_get_Int32_0;

		// Token: 0x04000109 RID: 265
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
