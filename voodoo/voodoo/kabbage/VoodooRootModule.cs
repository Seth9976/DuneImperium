using System;
using dwd.core.rendererManagement.configData;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using lotus;
using UnityEngine;

namespace voodoo.kabbage
{
	// Token: 0x0200002A RID: 42
	public class VoodooRootModule : MonoBehaviour
	{
		// Token: 0x060001AD RID: 429 RVA: 0x0000E414 File Offset: 0x0000C614
		// Note: this type is marked as 'beforefieldinit'.
		static VoodooRootModule()
		{
			Il2CppClassPointerStore<VoodooRootModule>.NativeClassPtr = IL2CPP.GetIl2CppClass("voodoo.dll", "voodoo.kabbage", "VoodooRootModule");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VoodooRootModule>.NativeClassPtr);
			VoodooRootModule.NativeMethodInfoPtr_UpdateConfig_Public_Abstract_Virtual_New_Void_VoodooRenderRoot_UnitView_VisibilityConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooRootModule>.NativeClassPtr, 100663484);
			VoodooRootModule.NativeMethodInfoPtr_get_ExecutionOrder_Protected_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooRootModule>.NativeClassPtr, 100663485);
			VoodooRootModule.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_VoodooRootModule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooRootModule>.NativeClassPtr, 100663486);
			VoodooRootModule.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooRootModule>.NativeClassPtr, 100663487);
		}

		// Token: 0x060001AE RID: 430 RVA: 0x0000E494 File Offset: 0x0000C694
		[CallerCount(0)]
		public unsafe virtual void UpdateConfig(VoodooRenderRoot root, UnitView unit, VisibilityConfiguration config)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VoodooRootModule.NativeMethodInfoPtr_UpdateConfig_Public_Abstract_Virtual_New_Void_VoodooRenderRoot_UnitView_VisibilityConfiguration_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x060001AF RID: 431 RVA: 0x0000E508 File Offset: 0x0000C708
		public unsafe virtual int ExecutionOrder
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VoodooRootModule.NativeMethodInfoPtr_get_ExecutionOrder_Protected_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x0000E550 File Offset: 0x0000C750
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1107610, XrefRangeEnd = 1107611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int CompareTo(VoodooRootModule other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooRootModule.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_VoodooRootModule_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060001B1 RID: 433 RVA: 0x0000E5A0 File Offset: 0x0000C7A0
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VoodooRootModule()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VoodooRootModule>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooRootModule.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001B2 RID: 434 RVA: 0x00002F16 File Offset: 0x00001116
		public VoodooRootModule(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040000EC RID: 236
		private static readonly IntPtr NativeMethodInfoPtr_UpdateConfig_Public_Abstract_Virtual_New_Void_VoodooRenderRoot_UnitView_VisibilityConfiguration_0;

		// Token: 0x040000ED RID: 237
		private static readonly IntPtr NativeMethodInfoPtr_get_ExecutionOrder_Protected_Abstract_Virtual_New_get_Int32_0;

		// Token: 0x040000EE RID: 238
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_VoodooRootModule_0;

		// Token: 0x040000EF RID: 239
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x020000BF RID: 191
		public static class CoreExecutionLayers : global::Il2CppSystem.Object
		{
			// Token: 0x06000A87 RID: 2695 RVA: 0x0002C06C File Offset: 0x0002A26C
			// Note: this type is marked as 'beforefieldinit'.
			static CoreExecutionLayers()
			{
				Il2CppClassPointerStore<VoodooRootModule.CoreExecutionLayers>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VoodooRootModule>.NativeClassPtr, "CoreExecutionLayers");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VoodooRootModule.CoreExecutionLayers>.NativeClassPtr);
				VoodooRootModule.CoreExecutionLayers.NativeFieldInfoPtr_RawTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooRootModule.CoreExecutionLayers>.NativeClassPtr, "RawTransform");
				VoodooRootModule.CoreExecutionLayers.NativeFieldInfoPtr_Stretch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooRootModule.CoreExecutionLayers>.NativeClassPtr, "Stretch");
				VoodooRootModule.CoreExecutionLayers.NativeFieldInfoPtr_Blend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooRootModule.CoreExecutionLayers>.NativeClassPtr, "Blend");
				VoodooRootModule.CoreExecutionLayers.NativeFieldInfoPtr_ConfigureRenderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooRootModule.CoreExecutionLayers>.NativeClassPtr, "ConfigureRenderer");
			}

			// Token: 0x06000A88 RID: 2696 RVA: 0x000072B1 File Offset: 0x000054B1
			public CoreExecutionLayers(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000309 RID: 777
			// (get) Token: 0x06000A89 RID: 2697 RVA: 0x0002C0E8 File Offset: 0x0002A2E8
			// (set) Token: 0x06000A8A RID: 2698 RVA: 0x000072BA File Offset: 0x000054BA
			public unsafe static int RawTransform
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(VoodooRootModule.CoreExecutionLayers.NativeFieldInfoPtr_RawTransform, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(VoodooRootModule.CoreExecutionLayers.NativeFieldInfoPtr_RawTransform, (void*)(&value));
				}
			}

			// Token: 0x1700030A RID: 778
			// (get) Token: 0x06000A8B RID: 2699 RVA: 0x0002C104 File Offset: 0x0002A304
			// (set) Token: 0x06000A8C RID: 2700 RVA: 0x000072C8 File Offset: 0x000054C8
			public unsafe static int Stretch
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(VoodooRootModule.CoreExecutionLayers.NativeFieldInfoPtr_Stretch, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(VoodooRootModule.CoreExecutionLayers.NativeFieldInfoPtr_Stretch, (void*)(&value));
				}
			}

			// Token: 0x1700030B RID: 779
			// (get) Token: 0x06000A8D RID: 2701 RVA: 0x0002C120 File Offset: 0x0002A320
			// (set) Token: 0x06000A8E RID: 2702 RVA: 0x000072D6 File Offset: 0x000054D6
			public unsafe static int Blend
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(VoodooRootModule.CoreExecutionLayers.NativeFieldInfoPtr_Blend, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(VoodooRootModule.CoreExecutionLayers.NativeFieldInfoPtr_Blend, (void*)(&value));
				}
			}

			// Token: 0x1700030C RID: 780
			// (get) Token: 0x06000A8F RID: 2703 RVA: 0x0002C13C File Offset: 0x0002A33C
			// (set) Token: 0x06000A90 RID: 2704 RVA: 0x000072E4 File Offset: 0x000054E4
			public unsafe static int ConfigureRenderer
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(VoodooRootModule.CoreExecutionLayers.NativeFieldInfoPtr_ConfigureRenderer, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(VoodooRootModule.CoreExecutionLayers.NativeFieldInfoPtr_ConfigureRenderer, (void*)(&value));
				}
			}

			// Token: 0x04000681 RID: 1665
			private static readonly IntPtr NativeFieldInfoPtr_RawTransform;

			// Token: 0x04000682 RID: 1666
			private static readonly IntPtr NativeFieldInfoPtr_Stretch;

			// Token: 0x04000683 RID: 1667
			private static readonly IntPtr NativeFieldInfoPtr_Blend;

			// Token: 0x04000684 RID: 1668
			private static readonly IntPtr NativeFieldInfoPtr_ConfigureRenderer;
		}
	}
}
