using System;
using dwd.core.rendererManagement.configData;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using lotus;
using UnityEngine;

namespace voodoo.kabbage
{
	// Token: 0x02000021 RID: 33
	public class LocalTransformOffsetRootModule : VoodooRootModule
	{
		// Token: 0x06000109 RID: 265 RVA: 0x0000C54C File Offset: 0x0000A74C
		// Note: this type is marked as 'beforefieldinit'.
		static LocalTransformOffsetRootModule()
		{
			Il2CppClassPointerStore<LocalTransformOffsetRootModule>.NativeClassPtr = IL2CPP.GetIl2CppClass("voodoo.dll", "voodoo.kabbage", "LocalTransformOffsetRootModule");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LocalTransformOffsetRootModule>.NativeClassPtr);
			LocalTransformOffsetRootModule.NativeFieldInfoPtr_offsetTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalTransformOffsetRootModule>.NativeClassPtr, "offsetTransform");
			LocalTransformOffsetRootModule.NativeFieldInfoPtr_executionOrder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalTransformOffsetRootModule>.NativeClassPtr, "executionOrder");
			LocalTransformOffsetRootModule.NativeMethodInfoPtr_UpdateConfig_Public_Virtual_Void_VoodooRenderRoot_UnitView_VisibilityConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalTransformOffsetRootModule>.NativeClassPtr, 100663412);
			LocalTransformOffsetRootModule.NativeMethodInfoPtr_get_ExecutionOrder_Protected_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalTransformOffsetRootModule>.NativeClassPtr, 100663413);
			LocalTransformOffsetRootModule.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalTransformOffsetRootModule>.NativeClassPtr, 100663414);
		}

		// Token: 0x0600010A RID: 266 RVA: 0x0000C5E0 File Offset: 0x0000A7E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1107097, XrefRangeEnd = 1107100, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LocalTransformOffsetRootModule.NativeMethodInfoPtr_UpdateConfig_Public_Virtual_Void_VoodooRenderRoot_UnitView_VisibilityConfiguration_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x0600010B RID: 267 RVA: 0x0000C654 File Offset: 0x0000A854
		public unsafe override int ExecutionOrder
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LocalTransformOffsetRootModule.NativeMethodInfoPtr_get_ExecutionOrder_Protected_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600010C RID: 268 RVA: 0x0000C69C File Offset: 0x0000A89C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1107100, XrefRangeEnd = 1107101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LocalTransformOffsetRootModule()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocalTransformOffsetRootModule>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalTransformOffsetRootModule.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600010D RID: 269 RVA: 0x00002966 File Offset: 0x00000B66
		public LocalTransformOffsetRootModule(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x0600010E RID: 270 RVA: 0x0000C6D8 File Offset: 0x0000A8D8
		// (set) Token: 0x0600010F RID: 271 RVA: 0x0000296F File Offset: 0x00000B6F
		public unsafe Transform offsetTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalTransformOffsetRootModule.NativeFieldInfoPtr_offsetTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalTransformOffsetRootModule.NativeFieldInfoPtr_offsetTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x06000110 RID: 272 RVA: 0x0000C708 File Offset: 0x0000A908
		// (set) Token: 0x06000111 RID: 273 RVA: 0x0000298E File Offset: 0x00000B8E
		public unsafe int executionOrder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalTransformOffsetRootModule.NativeFieldInfoPtr_executionOrder);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalTransformOffsetRootModule.NativeFieldInfoPtr_executionOrder)) = value;
			}
		}

		// Token: 0x0400008B RID: 139
		private static readonly IntPtr NativeFieldInfoPtr_offsetTransform;

		// Token: 0x0400008C RID: 140
		private static readonly IntPtr NativeFieldInfoPtr_executionOrder;

		// Token: 0x0400008D RID: 141
		private static readonly IntPtr NativeMethodInfoPtr_UpdateConfig_Public_Virtual_Void_VoodooRenderRoot_UnitView_VisibilityConfiguration_0;

		// Token: 0x0400008E RID: 142
		private static readonly IntPtr NativeMethodInfoPtr_get_ExecutionOrder_Protected_Virtual_get_Int32_0;

		// Token: 0x0400008F RID: 143
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
