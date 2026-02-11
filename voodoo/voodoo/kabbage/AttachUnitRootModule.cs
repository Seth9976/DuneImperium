using System;
using dwd.core.rendererManagement.configData;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using lotus;

namespace voodoo.kabbage
{
	// Token: 0x0200001F RID: 31
	public class AttachUnitRootModule : VoodooRootModule
	{
		// Token: 0x060000F6 RID: 246 RVA: 0x0000C134 File Offset: 0x0000A334
		// Note: this type is marked as 'beforefieldinit'.
		static AttachUnitRootModule()
		{
			Il2CppClassPointerStore<AttachUnitRootModule>.NativeClassPtr = IL2CPP.GetIl2CppClass("voodoo.dll", "voodoo.kabbage", "AttachUnitRootModule");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AttachUnitRootModule>.NativeClassPtr);
			AttachUnitRootModule.NativeFieldInfoPtr_executionOrder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttachUnitRootModule>.NativeClassPtr, "executionOrder");
			AttachUnitRootModule.NativeMethodInfoPtr_UpdateConfig_Public_Virtual_Void_VoodooRenderRoot_UnitView_VisibilityConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttachUnitRootModule>.NativeClassPtr, 100663405);
			AttachUnitRootModule.NativeMethodInfoPtr_get_ExecutionOrder_Protected_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttachUnitRootModule>.NativeClassPtr, 100663406);
			AttachUnitRootModule.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttachUnitRootModule>.NativeClassPtr, 100663407);
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x0000C1B4 File Offset: 0x0000A3B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1107079, XrefRangeEnd = 1107080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AttachUnitRootModule.NativeMethodInfoPtr_UpdateConfig_Public_Virtual_Void_VoodooRenderRoot_UnitView_VisibilityConfiguration_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060000F8 RID: 248 RVA: 0x0000C228 File Offset: 0x0000A428
		public unsafe override int ExecutionOrder
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AttachUnitRootModule.NativeMethodInfoPtr_get_ExecutionOrder_Protected_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x0000C270 File Offset: 0x0000A470
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1107080, XrefRangeEnd = 1107081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AttachUnitRootModule()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AttachUnitRootModule>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttachUnitRootModule.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000FA RID: 250 RVA: 0x000028E0 File Offset: 0x00000AE0
		public AttachUnitRootModule(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060000FB RID: 251 RVA: 0x0000C2AC File Offset: 0x0000A4AC
		// (set) Token: 0x060000FC RID: 252 RVA: 0x000028E9 File Offset: 0x00000AE9
		public unsafe int executionOrder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttachUnitRootModule.NativeFieldInfoPtr_executionOrder);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttachUnitRootModule.NativeFieldInfoPtr_executionOrder)) = value;
			}
		}

		// Token: 0x04000080 RID: 128
		private static readonly IntPtr NativeFieldInfoPtr_executionOrder;

		// Token: 0x04000081 RID: 129
		private static readonly IntPtr NativeMethodInfoPtr_UpdateConfig_Public_Virtual_Void_VoodooRenderRoot_UnitView_VisibilityConfiguration_0;

		// Token: 0x04000082 RID: 130
		private static readonly IntPtr NativeMethodInfoPtr_get_ExecutionOrder_Protected_Virtual_get_Int32_0;

		// Token: 0x04000083 RID: 131
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
