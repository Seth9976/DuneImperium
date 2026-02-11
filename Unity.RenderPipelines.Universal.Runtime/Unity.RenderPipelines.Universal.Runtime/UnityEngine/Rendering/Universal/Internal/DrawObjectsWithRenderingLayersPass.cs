using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.Rendering.Universal.Internal
{
	// Token: 0x02000122 RID: 290
	public class DrawObjectsWithRenderingLayersPass : DrawObjectsPass
	{
		// Token: 0x0600193B RID: 6459 RVA: 0x0006A2F8 File Offset: 0x000684F8
		// Note: this type is marked as 'beforefieldinit'.
		static DrawObjectsWithRenderingLayersPass()
		{
			Il2CppClassPointerStore<DrawObjectsWithRenderingLayersPass>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal.Internal", "DrawObjectsWithRenderingLayersPass");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DrawObjectsWithRenderingLayersPass>.NativeClassPtr);
			DrawObjectsWithRenderingLayersPass.NativeFieldInfoPtr_m_ColorTargetIndentifiers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawObjectsWithRenderingLayersPass>.NativeClassPtr, "m_ColorTargetIndentifiers");
			DrawObjectsWithRenderingLayersPass.NativeFieldInfoPtr_m_DepthTargetIndentifiers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawObjectsWithRenderingLayersPass>.NativeClassPtr, "m_DepthTargetIndentifiers");
			DrawObjectsWithRenderingLayersPass.NativeMethodInfoPtr__ctor_Public_Void_URPProfileId_Boolean_RenderPassEvent_RenderQueueRange_LayerMask_StencilState_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawObjectsWithRenderingLayersPass>.NativeClassPtr, 100666265);
			DrawObjectsWithRenderingLayersPass.NativeMethodInfoPtr_Setup_Public_Void_RTHandle_RTHandle_RTHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawObjectsWithRenderingLayersPass>.NativeClassPtr, 100666266);
			DrawObjectsWithRenderingLayersPass.NativeMethodInfoPtr_Configure_Public_Virtual_Void_CommandBuffer_RenderTextureDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawObjectsWithRenderingLayersPass>.NativeClassPtr, 100666267);
			DrawObjectsWithRenderingLayersPass.NativeMethodInfoPtr_OnExecute_Protected_Virtual_Void_CommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawObjectsWithRenderingLayersPass>.NativeClassPtr, 100666268);
		}

		// Token: 0x0600193C RID: 6460 RVA: 0x0006A3A0 File Offset: 0x000685A0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 627672, RefRangeEnd = 627673, XrefRangeStart = 627641, XrefRangeEnd = 627672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DrawObjectsWithRenderingLayersPass(URPProfileId profilerTag, bool opaque, RenderPassEvent evt, RenderQueueRange renderQueueRange, LayerMask layerMask, StencilState stencilState, int stencilReference)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DrawObjectsWithRenderingLayersPass>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref profilerTag;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref opaque;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref evt;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref renderQueueRange;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layerMask;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref stencilState;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref stencilReference;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DrawObjectsWithRenderingLayersPass.NativeMethodInfoPtr__ctor_Public_Void_URPProfileId_Boolean_RenderPassEvent_RenderQueueRange_LayerMask_StencilState_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600193D RID: 6461 RVA: 0x0006A43C File Offset: 0x0006863C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 627705, RefRangeEnd = 627706, XrefRangeStart = 627673, XrefRangeEnd = 627705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Setup(RTHandle colorAttachment, RTHandle renderingLayersTexture, RTHandle depthAttachment)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(colorAttachment);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(renderingLayersTexture);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(depthAttachment);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DrawObjectsWithRenderingLayersPass.NativeMethodInfoPtr_Setup_Public_Void_RTHandle_RTHandle_RTHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600193E RID: 6462 RVA: 0x0006A4A4 File Offset: 0x000686A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 627706, XrefRangeEnd = 627707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Configure(CommandBuffer cmd, RenderTextureDescriptor cameraTextureDescriptor)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cameraTextureDescriptor;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DrawObjectsWithRenderingLayersPass.NativeMethodInfoPtr_Configure_Public_Virtual_Void_CommandBuffer_RenderTextureDescriptor_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600193F RID: 6463 RVA: 0x0006A500 File Offset: 0x00068700
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 627707, XrefRangeEnd = 627713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnExecute(CommandBuffer cmd)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DrawObjectsWithRenderingLayersPass.NativeMethodInfoPtr_OnExecute_Protected_Virtual_Void_CommandBuffer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001940 RID: 6464 RVA: 0x0000E515 File Offset: 0x0000C715
		public DrawObjectsWithRenderingLayersPass(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700093E RID: 2366
		// (get) Token: 0x06001941 RID: 6465 RVA: 0x0006A550 File Offset: 0x00068750
		// (set) Token: 0x06001942 RID: 6466 RVA: 0x0000E51E File Offset: 0x0000C71E
		public unsafe Il2CppReferenceArray<RTHandle> m_ColorTargetIndentifiers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrawObjectsWithRenderingLayersPass.NativeFieldInfoPtr_m_ColorTargetIndentifiers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RTHandle>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrawObjectsWithRenderingLayersPass.NativeFieldInfoPtr_m_ColorTargetIndentifiers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700093F RID: 2367
		// (get) Token: 0x06001943 RID: 6467 RVA: 0x0006A580 File Offset: 0x00068780
		// (set) Token: 0x06001944 RID: 6468 RVA: 0x0000E53D File Offset: 0x0000C73D
		public unsafe RTHandle m_DepthTargetIndentifiers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrawObjectsWithRenderingLayersPass.NativeFieldInfoPtr_m_DepthTargetIndentifiers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RTHandle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrawObjectsWithRenderingLayersPass.NativeFieldInfoPtr_m_DepthTargetIndentifiers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001243 RID: 4675
		private static readonly IntPtr NativeFieldInfoPtr_m_ColorTargetIndentifiers;

		// Token: 0x04001244 RID: 4676
		private static readonly IntPtr NativeFieldInfoPtr_m_DepthTargetIndentifiers;

		// Token: 0x04001245 RID: 4677
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_URPProfileId_Boolean_RenderPassEvent_RenderQueueRange_LayerMask_StencilState_Int32_0;

		// Token: 0x04001246 RID: 4678
		private static readonly IntPtr NativeMethodInfoPtr_Setup_Public_Void_RTHandle_RTHandle_RTHandle_0;

		// Token: 0x04001247 RID: 4679
		private static readonly IntPtr NativeMethodInfoPtr_Configure_Public_Virtual_Void_CommandBuffer_RenderTextureDescriptor_0;

		// Token: 0x04001248 RID: 4680
		private static readonly IntPtr NativeMethodInfoPtr_OnExecute_Protected_Virtual_Void_CommandBuffer_0;
	}
}
