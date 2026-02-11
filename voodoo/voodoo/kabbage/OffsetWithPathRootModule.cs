using System;
using dwd.core.rendererManagement.configData;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using lotus;

namespace voodoo.kabbage
{
	// Token: 0x02000022 RID: 34
	public class OffsetWithPathRootModule : VoodooRootModule
	{
		// Token: 0x06000112 RID: 274 RVA: 0x0000C730 File Offset: 0x0000A930
		// Note: this type is marked as 'beforefieldinit'.
		static OffsetWithPathRootModule()
		{
			Il2CppClassPointerStore<OffsetWithPathRootModule>.NativeClassPtr = IL2CPP.GetIl2CppClass("voodoo.dll", "voodoo.kabbage", "OffsetWithPathRootModule");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OffsetWithPathRootModule>.NativeClassPtr);
			OffsetWithPathRootModule.NativeFieldInfoPtr_executionOrder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OffsetWithPathRootModule>.NativeClassPtr, "executionOrder");
			OffsetWithPathRootModule.NativeMethodInfoPtr_UpdateConfig_Public_Virtual_Void_VoodooRenderRoot_UnitView_VisibilityConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OffsetWithPathRootModule>.NativeClassPtr, 100663415);
			OffsetWithPathRootModule.NativeMethodInfoPtr_get_ExecutionOrder_Protected_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OffsetWithPathRootModule>.NativeClassPtr, 100663416);
			OffsetWithPathRootModule.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OffsetWithPathRootModule>.NativeClassPtr, 100663417);
		}

		// Token: 0x06000113 RID: 275 RVA: 0x0000C7B0 File Offset: 0x0000A9B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1107101, XrefRangeEnd = 1107108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OffsetWithPathRootModule.NativeMethodInfoPtr_UpdateConfig_Public_Virtual_Void_VoodooRenderRoot_UnitView_VisibilityConfiguration_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x06000114 RID: 276 RVA: 0x0000C824 File Offset: 0x0000AA24
		public unsafe override int ExecutionOrder
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OffsetWithPathRootModule.NativeMethodInfoPtr_get_ExecutionOrder_Protected_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000115 RID: 277 RVA: 0x0000C86C File Offset: 0x0000AA6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1107108, XrefRangeEnd = 1107109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OffsetWithPathRootModule()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OffsetWithPathRootModule>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OffsetWithPathRootModule.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000116 RID: 278 RVA: 0x000029A9 File Offset: 0x00000BA9
		public OffsetWithPathRootModule(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x06000117 RID: 279 RVA: 0x0000C8A8 File Offset: 0x0000AAA8
		// (set) Token: 0x06000118 RID: 280 RVA: 0x000029B2 File Offset: 0x00000BB2
		public unsafe int executionOrder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OffsetWithPathRootModule.NativeFieldInfoPtr_executionOrder);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OffsetWithPathRootModule.NativeFieldInfoPtr_executionOrder)) = value;
			}
		}

		// Token: 0x04000090 RID: 144
		private static readonly IntPtr NativeFieldInfoPtr_executionOrder;

		// Token: 0x04000091 RID: 145
		private static readonly IntPtr NativeMethodInfoPtr_UpdateConfig_Public_Virtual_Void_VoodooRenderRoot_UnitView_VisibilityConfiguration_0;

		// Token: 0x04000092 RID: 146
		private static readonly IntPtr NativeMethodInfoPtr_get_ExecutionOrder_Protected_Virtual_get_Int32_0;

		// Token: 0x04000093 RID: 147
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
