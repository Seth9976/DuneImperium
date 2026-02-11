using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering.Universal
{
	// Token: 0x020000F9 RID: 249
	public sealed class RenderingData : ValueType
	{
		// Token: 0x060013A3 RID: 5027 RVA: 0x0005973C File Offset: 0x0005793C
		// Note: this type is marked as 'beforefieldinit'.
		static RenderingData()
		{
			Il2CppClassPointerStore<RenderingData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "RenderingData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RenderingData>.NativeClassPtr);
			RenderingData.NativeFieldInfoPtr_commandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderingData>.NativeClassPtr, "commandBuffer");
			RenderingData.NativeFieldInfoPtr_cullResults = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderingData>.NativeClassPtr, "cullResults");
			RenderingData.NativeFieldInfoPtr_cameraData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderingData>.NativeClassPtr, "cameraData");
			RenderingData.NativeFieldInfoPtr_lightData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderingData>.NativeClassPtr, "lightData");
			RenderingData.NativeFieldInfoPtr_shadowData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderingData>.NativeClassPtr, "shadowData");
			RenderingData.NativeFieldInfoPtr_postProcessingData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderingData>.NativeClassPtr, "postProcessingData");
			RenderingData.NativeFieldInfoPtr_supportsDynamicBatching = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderingData>.NativeClassPtr, "supportsDynamicBatching");
			RenderingData.NativeFieldInfoPtr_perObjectData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderingData>.NativeClassPtr, "perObjectData");
			RenderingData.NativeFieldInfoPtr_postProcessingEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderingData>.NativeClassPtr, "postProcessingEnabled");
		}

		// Token: 0x060013A4 RID: 5028 RVA: 0x0000B706 File Offset: 0x00009906
		public RenderingData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060013A5 RID: 5029 RVA: 0x0000B70F File Offset: 0x0000990F
		public RenderingData()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RenderingData>.NativeClassPtr))
		{
		}

		// Token: 0x17000709 RID: 1801
		// (get) Token: 0x060013A6 RID: 5030 RVA: 0x00059820 File Offset: 0x00057A20
		// (set) Token: 0x060013A7 RID: 5031 RVA: 0x0000B721 File Offset: 0x00009921
		public unsafe CommandBuffer commandBuffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderingData.NativeFieldInfoPtr_commandBuffer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CommandBuffer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderingData.NativeFieldInfoPtr_commandBuffer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700070A RID: 1802
		// (get) Token: 0x060013A8 RID: 5032 RVA: 0x00059850 File Offset: 0x00057A50
		// (set) Token: 0x060013A9 RID: 5033 RVA: 0x0000B740 File Offset: 0x00009940
		public unsafe CullingResults cullResults
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderingData.NativeFieldInfoPtr_cullResults);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderingData.NativeFieldInfoPtr_cullResults)) = value;
			}
		}

		// Token: 0x1700070B RID: 1803
		// (get) Token: 0x060013AA RID: 5034 RVA: 0x00059878 File Offset: 0x00057A78
		// (set) Token: 0x060013AB RID: 5035 RVA: 0x0000B75B File Offset: 0x0000995B
		public CameraData cameraData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderingData.NativeFieldInfoPtr_cameraData);
				return new CameraData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CameraData>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderingData.NativeFieldInfoPtr_cameraData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CameraData>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700070C RID: 1804
		// (get) Token: 0x060013AC RID: 5036 RVA: 0x000598A8 File Offset: 0x00057AA8
		// (set) Token: 0x060013AD RID: 5037 RVA: 0x0000B789 File Offset: 0x00009989
		public LightData lightData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderingData.NativeFieldInfoPtr_lightData);
				return new LightData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LightData>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderingData.NativeFieldInfoPtr_lightData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<LightData>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700070D RID: 1805
		// (get) Token: 0x060013AE RID: 5038 RVA: 0x000598D8 File Offset: 0x00057AD8
		// (set) Token: 0x060013AF RID: 5039 RVA: 0x0000B7B7 File Offset: 0x000099B7
		public ShadowData shadowData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderingData.NativeFieldInfoPtr_shadowData);
				return new ShadowData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ShadowData>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderingData.NativeFieldInfoPtr_shadowData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ShadowData>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700070E RID: 1806
		// (get) Token: 0x060013B0 RID: 5040 RVA: 0x00059908 File Offset: 0x00057B08
		// (set) Token: 0x060013B1 RID: 5041 RVA: 0x0000B7E5 File Offset: 0x000099E5
		public unsafe PostProcessingData postProcessingData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderingData.NativeFieldInfoPtr_postProcessingData);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderingData.NativeFieldInfoPtr_postProcessingData)) = value;
			}
		}

		// Token: 0x1700070F RID: 1807
		// (get) Token: 0x060013B2 RID: 5042 RVA: 0x00059930 File Offset: 0x00057B30
		// (set) Token: 0x060013B3 RID: 5043 RVA: 0x0000B800 File Offset: 0x00009A00
		public unsafe bool supportsDynamicBatching
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderingData.NativeFieldInfoPtr_supportsDynamicBatching);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderingData.NativeFieldInfoPtr_supportsDynamicBatching)) = value;
			}
		}

		// Token: 0x17000710 RID: 1808
		// (get) Token: 0x060013B4 RID: 5044 RVA: 0x00059958 File Offset: 0x00057B58
		// (set) Token: 0x060013B5 RID: 5045 RVA: 0x0000B81B File Offset: 0x00009A1B
		public unsafe PerObjectData perObjectData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderingData.NativeFieldInfoPtr_perObjectData);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderingData.NativeFieldInfoPtr_perObjectData)) = value;
			}
		}

		// Token: 0x17000711 RID: 1809
		// (get) Token: 0x060013B6 RID: 5046 RVA: 0x00059980 File Offset: 0x00057B80
		// (set) Token: 0x060013B7 RID: 5047 RVA: 0x0000B836 File Offset: 0x00009A36
		public unsafe bool postProcessingEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderingData.NativeFieldInfoPtr_postProcessingEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderingData.NativeFieldInfoPtr_postProcessingEnabled)) = value;
			}
		}

		// Token: 0x04000E75 RID: 3701
		private static readonly IntPtr NativeFieldInfoPtr_commandBuffer;

		// Token: 0x04000E76 RID: 3702
		private static readonly IntPtr NativeFieldInfoPtr_cullResults;

		// Token: 0x04000E77 RID: 3703
		private static readonly IntPtr NativeFieldInfoPtr_cameraData;

		// Token: 0x04000E78 RID: 3704
		private static readonly IntPtr NativeFieldInfoPtr_lightData;

		// Token: 0x04000E79 RID: 3705
		private static readonly IntPtr NativeFieldInfoPtr_shadowData;

		// Token: 0x04000E7A RID: 3706
		private static readonly IntPtr NativeFieldInfoPtr_postProcessingData;

		// Token: 0x04000E7B RID: 3707
		private static readonly IntPtr NativeFieldInfoPtr_supportsDynamicBatching;

		// Token: 0x04000E7C RID: 3708
		private static readonly IntPtr NativeFieldInfoPtr_perObjectData;

		// Token: 0x04000E7D RID: 3709
		private static readonly IntPtr NativeFieldInfoPtr_postProcessingEnabled;
	}
}
