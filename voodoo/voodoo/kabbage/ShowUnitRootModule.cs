using System;
using dwd.core.rendererManagement.configData;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using lotus;

namespace voodoo.kabbage
{
	// Token: 0x02000023 RID: 35
	public class ShowUnitRootModule : VoodooRootModule
	{
		// Token: 0x06000119 RID: 281 RVA: 0x0000C8D0 File Offset: 0x0000AAD0
		// Note: this type is marked as 'beforefieldinit'.
		static ShowUnitRootModule()
		{
			Il2CppClassPointerStore<ShowUnitRootModule>.NativeClassPtr = IL2CPP.GetIl2CppClass("voodoo.dll", "voodoo.kabbage", "ShowUnitRootModule");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShowUnitRootModule>.NativeClassPtr);
			ShowUnitRootModule.NativeFieldInfoPtr_visible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowUnitRootModule>.NativeClassPtr, "visible");
			ShowUnitRootModule.NativeFieldInfoPtr_executionOrder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowUnitRootModule>.NativeClassPtr, "executionOrder");
			ShowUnitRootModule.NativeMethodInfoPtr_UpdateConfig_Public_Virtual_Void_VoodooRenderRoot_UnitView_VisibilityConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowUnitRootModule>.NativeClassPtr, 100663418);
			ShowUnitRootModule.NativeMethodInfoPtr_get_ExecutionOrder_Protected_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowUnitRootModule>.NativeClassPtr, 100663419);
			ShowUnitRootModule.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowUnitRootModule>.NativeClassPtr, 100663420);
		}

		// Token: 0x0600011A RID: 282 RVA: 0x0000C964 File Offset: 0x0000AB64
		[CallerCount(0)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ShowUnitRootModule.NativeMethodInfoPtr_UpdateConfig_Public_Virtual_Void_VoodooRenderRoot_UnitView_VisibilityConfiguration_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x0600011B RID: 283 RVA: 0x0000C9D8 File Offset: 0x0000ABD8
		public unsafe override int ExecutionOrder
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ShowUnitRootModule.NativeMethodInfoPtr_get_ExecutionOrder_Protected_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600011C RID: 284 RVA: 0x0000CA20 File Offset: 0x0000AC20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1107109, XrefRangeEnd = 1107110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ShowUnitRootModule()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShowUnitRootModule>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShowUnitRootModule.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600011D RID: 285 RVA: 0x000029CD File Offset: 0x00000BCD
		public ShowUnitRootModule(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x0600011E RID: 286 RVA: 0x0000CA5C File Offset: 0x0000AC5C
		// (set) Token: 0x0600011F RID: 287 RVA: 0x000029D6 File Offset: 0x00000BD6
		public unsafe bool visible
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShowUnitRootModule.NativeFieldInfoPtr_visible);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShowUnitRootModule.NativeFieldInfoPtr_visible)) = value;
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x06000120 RID: 288 RVA: 0x0000CA84 File Offset: 0x0000AC84
		// (set) Token: 0x06000121 RID: 289 RVA: 0x000029F1 File Offset: 0x00000BF1
		public unsafe int executionOrder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShowUnitRootModule.NativeFieldInfoPtr_executionOrder);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShowUnitRootModule.NativeFieldInfoPtr_executionOrder)) = value;
			}
		}

		// Token: 0x04000094 RID: 148
		private static readonly IntPtr NativeFieldInfoPtr_visible;

		// Token: 0x04000095 RID: 149
		private static readonly IntPtr NativeFieldInfoPtr_executionOrder;

		// Token: 0x04000096 RID: 150
		private static readonly IntPtr NativeMethodInfoPtr_UpdateConfig_Public_Virtual_Void_VoodooRenderRoot_UnitView_VisibilityConfiguration_0;

		// Token: 0x04000097 RID: 151
		private static readonly IntPtr NativeMethodInfoPtr_get_ExecutionOrder_Protected_Virtual_get_Int32_0;

		// Token: 0x04000098 RID: 152
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
