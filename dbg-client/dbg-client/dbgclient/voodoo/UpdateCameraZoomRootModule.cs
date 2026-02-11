using System;
using boardgames.camera;
using dwd.core.rendererManagement.configData;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using lotus;
using voodoo.kabbage;

namespace dbgclient.voodoo
{
	// Token: 0x02000087 RID: 135
	public class UpdateCameraZoomRootModule : VoodooRootModule
	{
		// Token: 0x06000536 RID: 1334 RVA: 0x0002DFD4 File Offset: 0x0002C1D4
		// Note: this type is marked as 'beforefieldinit'.
		static UpdateCameraZoomRootModule()
		{
			Il2CppClassPointerStore<UpdateCameraZoomRootModule>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "dbgclient.voodoo", "UpdateCameraZoomRootModule");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UpdateCameraZoomRootModule>.NativeClassPtr);
			UpdateCameraZoomRootModule.NativeFieldInfoPtr_cameraControl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateCameraZoomRootModule>.NativeClassPtr, "cameraControl");
			UpdateCameraZoomRootModule.NativeFieldInfoPtr_executionOrder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateCameraZoomRootModule>.NativeClassPtr, "executionOrder");
			UpdateCameraZoomRootModule.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateCameraZoomRootModule>.NativeClassPtr, 100664098);
			UpdateCameraZoomRootModule.NativeMethodInfoPtr_UpdateConfig_Public_Virtual_Void_VoodooRenderRoot_UnitView_VisibilityConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateCameraZoomRootModule>.NativeClassPtr, 100664099);
			UpdateCameraZoomRootModule.NativeMethodInfoPtr_get_ExecutionOrder_Protected_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateCameraZoomRootModule>.NativeClassPtr, 100664100);
			UpdateCameraZoomRootModule.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateCameraZoomRootModule>.NativeClassPtr, 100664101);
		}

		// Token: 0x06000537 RID: 1335 RVA: 0x0002E07C File Offset: 0x0002C27C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 501620, XrefRangeEnd = 501623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UpdateCameraZoomRootModule.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000538 RID: 1336 RVA: 0x0002E0B0 File Offset: 0x0002C2B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 501623, XrefRangeEnd = 501624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UpdateCameraZoomRootModule.NativeMethodInfoPtr_UpdateConfig_Public_Virtual_Void_VoodooRenderRoot_UnitView_VisibilityConfiguration_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000147 RID: 327
		// (get) Token: 0x06000539 RID: 1337 RVA: 0x0002E124 File Offset: 0x0002C324
		public unsafe override int ExecutionOrder
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UpdateCameraZoomRootModule.NativeMethodInfoPtr_get_ExecutionOrder_Protected_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600053A RID: 1338 RVA: 0x0002E16C File Offset: 0x0002C36C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 501624, XrefRangeEnd = 501625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UpdateCameraZoomRootModule()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UpdateCameraZoomRootModule>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UpdateCameraZoomRootModule.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600053B RID: 1339 RVA: 0x000045D8 File Offset: 0x000027D8
		public UpdateCameraZoomRootModule(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000145 RID: 325
		// (get) Token: 0x0600053C RID: 1340 RVA: 0x0002E1A8 File Offset: 0x0002C3A8
		// (set) Token: 0x0600053D RID: 1341 RVA: 0x000045E1 File Offset: 0x000027E1
		public unsafe CameraControlProvider cameraControl
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateCameraZoomRootModule.NativeFieldInfoPtr_cameraControl);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CameraControlProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateCameraZoomRootModule.NativeFieldInfoPtr_cameraControl), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000146 RID: 326
		// (get) Token: 0x0600053E RID: 1342 RVA: 0x0002E1D8 File Offset: 0x0002C3D8
		// (set) Token: 0x0600053F RID: 1343 RVA: 0x00004600 File Offset: 0x00002800
		public unsafe int executionOrder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateCameraZoomRootModule.NativeFieldInfoPtr_executionOrder);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateCameraZoomRootModule.NativeFieldInfoPtr_executionOrder)) = value;
			}
		}

		// Token: 0x04000335 RID: 821
		private static readonly IntPtr NativeFieldInfoPtr_cameraControl;

		// Token: 0x04000336 RID: 822
		private static readonly IntPtr NativeFieldInfoPtr_executionOrder;

		// Token: 0x04000337 RID: 823
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04000338 RID: 824
		private static readonly IntPtr NativeMethodInfoPtr_UpdateConfig_Public_Virtual_Void_VoodooRenderRoot_UnitView_VisibilityConfiguration_0;

		// Token: 0x04000339 RID: 825
		private static readonly IntPtr NativeMethodInfoPtr_get_ExecutionOrder_Protected_Virtual_get_Int32_0;

		// Token: 0x0400033A RID: 826
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
