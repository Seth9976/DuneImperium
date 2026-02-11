using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Experimental.Rendering.RenderGraphModule;

namespace UnityEngine.Rendering.Universal.Internal
{
	// Token: 0x02000121 RID: 289
	public class DepthOnlyPass : ScriptableRenderPass
	{
		// Token: 0x06001923 RID: 6435 RVA: 0x00069D68 File Offset: 0x00067F68
		// Note: this type is marked as 'beforefieldinit'.
		static DepthOnlyPass()
		{
			Il2CppClassPointerStore<DepthOnlyPass>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal.Internal", "DepthOnlyPass");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DepthOnlyPass>.NativeClassPtr);
			DepthOnlyPass.NativeFieldInfoPtr_k_ShaderTagId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DepthOnlyPass>.NativeClassPtr, "k_ShaderTagId");
			DepthOnlyPass.NativeFieldInfoPtr__destination_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DepthOnlyPass>.NativeClassPtr, "<destination>k__BackingField");
			DepthOnlyPass.NativeFieldInfoPtr_depthStencilFormat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DepthOnlyPass>.NativeClassPtr, "depthStencilFormat");
			DepthOnlyPass.NativeFieldInfoPtr__shaderTagId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DepthOnlyPass>.NativeClassPtr, "<shaderTagId>k__BackingField");
			DepthOnlyPass.NativeFieldInfoPtr_m_PassData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DepthOnlyPass>.NativeClassPtr, "m_PassData");
			DepthOnlyPass.NativeFieldInfoPtr_m_FilteringSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DepthOnlyPass>.NativeClassPtr, "m_FilteringSettings");
			DepthOnlyPass.NativeMethodInfoPtr_get_destination_Private_get_RTHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DepthOnlyPass>.NativeClassPtr, 100666250);
			DepthOnlyPass.NativeMethodInfoPtr_set_destination_Private_set_Void_RTHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DepthOnlyPass>.NativeClassPtr, 100666251);
			DepthOnlyPass.NativeMethodInfoPtr_get_shaderTagId_Internal_get_ShaderTagId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DepthOnlyPass>.NativeClassPtr, 100666252);
			DepthOnlyPass.NativeMethodInfoPtr_set_shaderTagId_Internal_set_Void_ShaderTagId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DepthOnlyPass>.NativeClassPtr, 100666253);
			DepthOnlyPass.NativeMethodInfoPtr__ctor_Public_Void_RenderPassEvent_RenderQueueRange_LayerMask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DepthOnlyPass>.NativeClassPtr, 100666254);
			DepthOnlyPass.NativeMethodInfoPtr_Setup_Public_Void_RenderTextureDescriptor_RTHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DepthOnlyPass>.NativeClassPtr, 100666255);
			DepthOnlyPass.NativeMethodInfoPtr_OnCameraSetup_Public_Virtual_Void_CommandBuffer_byref_RenderingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DepthOnlyPass>.NativeClassPtr, 100666256);
			DepthOnlyPass.NativeMethodInfoPtr_ExecutePass_Private_Static_Void_ScriptableRenderContext_PassData_byref_RenderingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DepthOnlyPass>.NativeClassPtr, 100666257);
			DepthOnlyPass.NativeMethodInfoPtr_Execute_Public_Virtual_Void_ScriptableRenderContext_byref_RenderingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DepthOnlyPass>.NativeClassPtr, 100666258);
			DepthOnlyPass.NativeMethodInfoPtr_Render_Internal_Void_RenderGraph_byref_TextureHandle_byref_RenderingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DepthOnlyPass>.NativeClassPtr, 100666259);
		}

		// Token: 0x1700093C RID: 2364
		// (get) Token: 0x06001924 RID: 6436 RVA: 0x00069ED8 File Offset: 0x000680D8
		// (set) Token: 0x06001925 RID: 6437 RVA: 0x00069F18 File Offset: 0x00068118
		public unsafe RTHandle destination
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DepthOnlyPass.NativeMethodInfoPtr_get_destination_Private_get_RTHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RTHandle>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DepthOnlyPass.NativeMethodInfoPtr_set_destination_Private_set_Void_RTHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700093D RID: 2365
		// (get) Token: 0x06001926 RID: 6438 RVA: 0x00069F5C File Offset: 0x0006815C
		// (set) Token: 0x06001927 RID: 6439 RVA: 0x00069F98 File Offset: 0x00068198
		public unsafe ShaderTagId shaderTagId
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DepthOnlyPass.NativeMethodInfoPtr_get_shaderTagId_Internal_get_ShaderTagId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DepthOnlyPass.NativeMethodInfoPtr_set_shaderTagId_Internal_set_Void_ShaderTagId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001928 RID: 6440 RVA: 0x00069FD8 File Offset: 0x000681D8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 627568, RefRangeEnd = 627569, XrefRangeStart = 627542, XrefRangeEnd = 627568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DepthOnlyPass(RenderPassEvent evt, RenderQueueRange renderQueueRange, LayerMask layerMask)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DepthOnlyPass>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref evt;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref renderQueueRange;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layerMask;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DepthOnlyPass.NativeMethodInfoPtr__ctor_Public_Void_RenderPassEvent_RenderQueueRange_LayerMask_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001929 RID: 6441 RVA: 0x0006A03C File Offset: 0x0006823C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 627570, RefRangeEnd = 627571, XrefRangeStart = 627569, XrefRangeEnd = 627570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Setup(RenderTextureDescriptor baseDescriptor, RTHandle depthAttachmentHandle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref baseDescriptor;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(depthAttachmentHandle);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DepthOnlyPass.NativeMethodInfoPtr_Setup_Public_Void_RenderTextureDescriptor_RTHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600192A RID: 6442 RVA: 0x0006A08C File Offset: 0x0006828C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 627571, XrefRangeEnd = 627574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnCameraSetup(CommandBuffer cmd, ref RenderingData renderingData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(renderingData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DepthOnlyPass.NativeMethodInfoPtr_OnCameraSetup_Public_Virtual_Void_CommandBuffer_byref_RenderingData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600192B RID: 6443 RVA: 0x0006A0EC File Offset: 0x000682EC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 627596, RefRangeEnd = 627598, XrefRangeStart = 627574, XrefRangeEnd = 627596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ExecutePass(ScriptableRenderContext context, DepthOnlyPass.PassData passData, ref RenderingData renderingData)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref context;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(passData);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(renderingData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DepthOnlyPass.NativeMethodInfoPtr_ExecutePass_Private_Static_Void_ScriptableRenderContext_PassData_byref_RenderingData_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600192C RID: 6444 RVA: 0x0006A144 File Offset: 0x00068344
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 627598, XrefRangeEnd = 627603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref context;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(renderingData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DepthOnlyPass.NativeMethodInfoPtr_Execute_Public_Virtual_Void_ScriptableRenderContext_byref_RenderingData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600192D RID: 6445 RVA: 0x0006A1A0 File Offset: 0x000683A0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 627640, RefRangeEnd = 627641, XrefRangeStart = 627603, XrefRangeEnd = 627640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Render(RenderGraph renderGraph, out TextureHandle cameraDepthTexture, ref RenderingData renderingData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(renderGraph);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &cameraDepthTexture;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(renderingData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DepthOnlyPass.NativeMethodInfoPtr_Render_Internal_Void_RenderGraph_byref_TextureHandle_byref_RenderingData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600192E RID: 6446 RVA: 0x0000E46F File Offset: 0x0000C66F
		public DepthOnlyPass(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000936 RID: 2358
		// (get) Token: 0x0600192F RID: 6447 RVA: 0x0006A204 File Offset: 0x00068404
		// (set) Token: 0x06001930 RID: 6448 RVA: 0x0000E478 File Offset: 0x0000C678
		public unsafe static ShaderTagId k_ShaderTagId
		{
			get
			{
				ShaderTagId shaderTagId;
				IL2CPP.il2cpp_field_static_get_value(DepthOnlyPass.NativeFieldInfoPtr_k_ShaderTagId, (void*)(&shaderTagId));
				return shaderTagId;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DepthOnlyPass.NativeFieldInfoPtr_k_ShaderTagId, (void*)(&value));
			}
		}

		// Token: 0x17000937 RID: 2359
		// (get) Token: 0x06001931 RID: 6449 RVA: 0x0006A220 File Offset: 0x00068420
		// (set) Token: 0x06001932 RID: 6450 RVA: 0x0000E486 File Offset: 0x0000C686
		public unsafe RTHandle _destination_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DepthOnlyPass.NativeFieldInfoPtr__destination_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RTHandle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DepthOnlyPass.NativeFieldInfoPtr__destination_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000938 RID: 2360
		// (get) Token: 0x06001933 RID: 6451 RVA: 0x0006A250 File Offset: 0x00068450
		// (set) Token: 0x06001934 RID: 6452 RVA: 0x0000E4A5 File Offset: 0x0000C6A5
		public unsafe GraphicsFormat depthStencilFormat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DepthOnlyPass.NativeFieldInfoPtr_depthStencilFormat);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DepthOnlyPass.NativeFieldInfoPtr_depthStencilFormat)) = value;
			}
		}

		// Token: 0x17000939 RID: 2361
		// (get) Token: 0x06001935 RID: 6453 RVA: 0x0006A278 File Offset: 0x00068478
		// (set) Token: 0x06001936 RID: 6454 RVA: 0x0000E4C0 File Offset: 0x0000C6C0
		public unsafe ShaderTagId _shaderTagId_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DepthOnlyPass.NativeFieldInfoPtr__shaderTagId_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DepthOnlyPass.NativeFieldInfoPtr__shaderTagId_k__BackingField)) = value;
			}
		}

		// Token: 0x1700093A RID: 2362
		// (get) Token: 0x06001937 RID: 6455 RVA: 0x0006A2A0 File Offset: 0x000684A0
		// (set) Token: 0x06001938 RID: 6456 RVA: 0x0000E4DB File Offset: 0x0000C6DB
		public unsafe DepthOnlyPass.PassData m_PassData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DepthOnlyPass.NativeFieldInfoPtr_m_PassData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DepthOnlyPass.PassData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DepthOnlyPass.NativeFieldInfoPtr_m_PassData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700093B RID: 2363
		// (get) Token: 0x06001939 RID: 6457 RVA: 0x0006A2D0 File Offset: 0x000684D0
		// (set) Token: 0x0600193A RID: 6458 RVA: 0x0000E4FA File Offset: 0x0000C6FA
		public unsafe FilteringSettings m_FilteringSettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DepthOnlyPass.NativeFieldInfoPtr_m_FilteringSettings);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DepthOnlyPass.NativeFieldInfoPtr_m_FilteringSettings)) = value;
			}
		}

		// Token: 0x04001233 RID: 4659
		private static readonly IntPtr NativeFieldInfoPtr_k_ShaderTagId;

		// Token: 0x04001234 RID: 4660
		private static readonly IntPtr NativeFieldInfoPtr__destination_k__BackingField;

		// Token: 0x04001235 RID: 4661
		private static readonly IntPtr NativeFieldInfoPtr_depthStencilFormat;

		// Token: 0x04001236 RID: 4662
		private static readonly IntPtr NativeFieldInfoPtr__shaderTagId_k__BackingField;

		// Token: 0x04001237 RID: 4663
		private static readonly IntPtr NativeFieldInfoPtr_m_PassData;

		// Token: 0x04001238 RID: 4664
		private static readonly IntPtr NativeFieldInfoPtr_m_FilteringSettings;

		// Token: 0x04001239 RID: 4665
		private static readonly IntPtr NativeMethodInfoPtr_get_destination_Private_get_RTHandle_0;

		// Token: 0x0400123A RID: 4666
		private static readonly IntPtr NativeMethodInfoPtr_set_destination_Private_set_Void_RTHandle_0;

		// Token: 0x0400123B RID: 4667
		private static readonly IntPtr NativeMethodInfoPtr_get_shaderTagId_Internal_get_ShaderTagId_0;

		// Token: 0x0400123C RID: 4668
		private static readonly IntPtr NativeMethodInfoPtr_set_shaderTagId_Internal_set_Void_ShaderTagId_0;

		// Token: 0x0400123D RID: 4669
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_RenderPassEvent_RenderQueueRange_LayerMask_0;

		// Token: 0x0400123E RID: 4670
		private static readonly IntPtr NativeMethodInfoPtr_Setup_Public_Void_RenderTextureDescriptor_RTHandle_0;

		// Token: 0x0400123F RID: 4671
		private static readonly IntPtr NativeMethodInfoPtr_OnCameraSetup_Public_Virtual_Void_CommandBuffer_byref_RenderingData_0;

		// Token: 0x04001240 RID: 4672
		private static readonly IntPtr NativeMethodInfoPtr_ExecutePass_Private_Static_Void_ScriptableRenderContext_PassData_byref_RenderingData_0;

		// Token: 0x04001241 RID: 4673
		private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_ScriptableRenderContext_byref_RenderingData_0;

		// Token: 0x04001242 RID: 4674
		private static readonly IntPtr NativeMethodInfoPtr_Render_Internal_Void_RenderGraph_byref_TextureHandle_byref_RenderingData_0;

		// Token: 0x020001F7 RID: 503
		public class PassData : Object
		{
			// Token: 0x060022EA RID: 8938 RVA: 0x000847B0 File Offset: 0x000829B0
			// Note: this type is marked as 'beforefieldinit'.
			static PassData()
			{
				Il2CppClassPointerStore<DepthOnlyPass.PassData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DepthOnlyPass>.NativeClassPtr, "PassData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DepthOnlyPass.PassData>.NativeClassPtr);
				DepthOnlyPass.PassData.NativeFieldInfoPtr_cameraDepthTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DepthOnlyPass.PassData>.NativeClassPtr, "cameraDepthTexture");
				DepthOnlyPass.PassData.NativeFieldInfoPtr_renderingData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DepthOnlyPass.PassData>.NativeClassPtr, "renderingData");
				DepthOnlyPass.PassData.NativeFieldInfoPtr_shaderTagId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DepthOnlyPass.PassData>.NativeClassPtr, "shaderTagId");
				DepthOnlyPass.PassData.NativeFieldInfoPtr_filteringSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DepthOnlyPass.PassData>.NativeClassPtr, "filteringSettings");
				DepthOnlyPass.PassData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DepthOnlyPass.PassData>.NativeClassPtr, 100666261);
			}

			// Token: 0x060022EB RID: 8939 RVA: 0x00084840 File Offset: 0x00082A40
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe PassData()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DepthOnlyPass.PassData>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DepthOnlyPass.PassData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060022EC RID: 8940 RVA: 0x00013F68 File Offset: 0x00012168
			public PassData(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000C9E RID: 3230
			// (get) Token: 0x060022ED RID: 8941 RVA: 0x0008487C File Offset: 0x00082A7C
			// (set) Token: 0x060022EE RID: 8942 RVA: 0x00013F71 File Offset: 0x00012171
			public unsafe TextureHandle cameraDepthTexture
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DepthOnlyPass.PassData.NativeFieldInfoPtr_cameraDepthTexture);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DepthOnlyPass.PassData.NativeFieldInfoPtr_cameraDepthTexture)) = value;
				}
			}

			// Token: 0x17000C9F RID: 3231
			// (get) Token: 0x060022EF RID: 8943 RVA: 0x000848A4 File Offset: 0x00082AA4
			// (set) Token: 0x060022F0 RID: 8944 RVA: 0x00013F8C File Offset: 0x0001218C
			public RenderingData renderingData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DepthOnlyPass.PassData.NativeFieldInfoPtr_renderingData);
					return new RenderingData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RenderingData>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DepthOnlyPass.PassData.NativeFieldInfoPtr_renderingData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<RenderingData>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000CA0 RID: 3232
			// (get) Token: 0x060022F1 RID: 8945 RVA: 0x000848D4 File Offset: 0x00082AD4
			// (set) Token: 0x060022F2 RID: 8946 RVA: 0x00013FBA File Offset: 0x000121BA
			public unsafe ShaderTagId shaderTagId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DepthOnlyPass.PassData.NativeFieldInfoPtr_shaderTagId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DepthOnlyPass.PassData.NativeFieldInfoPtr_shaderTagId)) = value;
				}
			}

			// Token: 0x17000CA1 RID: 3233
			// (get) Token: 0x060022F3 RID: 8947 RVA: 0x000848FC File Offset: 0x00082AFC
			// (set) Token: 0x060022F4 RID: 8948 RVA: 0x00013FD5 File Offset: 0x000121D5
			public unsafe FilteringSettings filteringSettings
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DepthOnlyPass.PassData.NativeFieldInfoPtr_filteringSettings);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DepthOnlyPass.PassData.NativeFieldInfoPtr_filteringSettings)) = value;
				}
			}

			// Token: 0x0400187F RID: 6271
			private static readonly IntPtr NativeFieldInfoPtr_cameraDepthTexture;

			// Token: 0x04001880 RID: 6272
			private static readonly IntPtr NativeFieldInfoPtr_renderingData;

			// Token: 0x04001881 RID: 6273
			private static readonly IntPtr NativeFieldInfoPtr_shaderTagId;

			// Token: 0x04001882 RID: 6274
			private static readonly IntPtr NativeFieldInfoPtr_filteringSettings;

			// Token: 0x04001883 RID: 6275
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020001F8 RID: 504
		[ObfuscatedName("UnityEngine.Rendering.Universal.Internal.DepthOnlyPass+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x060022F5 RID: 8949 RVA: 0x00084924 File Offset: 0x00082B24
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<DepthOnlyPass.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DepthOnlyPass>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DepthOnlyPass.__c>.NativeClassPtr);
				DepthOnlyPass.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DepthOnlyPass.__c>.NativeClassPtr, "<>9");
				DepthOnlyPass.__c.NativeFieldInfoPtr___9__18_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DepthOnlyPass.__c>.NativeClassPtr, "<>9__18_0");
				DepthOnlyPass.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DepthOnlyPass.__c>.NativeClassPtr, 100666263);
				DepthOnlyPass.__c.NativeMethodInfoPtr__Render_b__18_0_Internal_Void_PassData_RenderGraphContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DepthOnlyPass.__c>.NativeClassPtr, 100666264);
			}

			// Token: 0x060022F6 RID: 8950 RVA: 0x000849A0 File Offset: 0x00082BA0
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DepthOnlyPass.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DepthOnlyPass.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060022F7 RID: 8951 RVA: 0x000849DC File Offset: 0x00082BDC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 627537, XrefRangeEnd = 627542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Render_b__18_0(DepthOnlyPass.PassData data, RenderGraphContext context)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DepthOnlyPass.__c.NativeMethodInfoPtr__Render_b__18_0_Internal_Void_PassData_RenderGraphContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060022F8 RID: 8952 RVA: 0x00013FF0 File Offset: 0x000121F0
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000CA2 RID: 3234
			// (get) Token: 0x060022F9 RID: 8953 RVA: 0x00084A30 File Offset: 0x00082C30
			// (set) Token: 0x060022FA RID: 8954 RVA: 0x00013FF9 File Offset: 0x000121F9
			public unsafe static DepthOnlyPass.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DepthOnlyPass.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DepthOnlyPass.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DepthOnlyPass.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000CA3 RID: 3235
			// (get) Token: 0x060022FB RID: 8955 RVA: 0x00084A58 File Offset: 0x00082C58
			// (set) Token: 0x060022FC RID: 8956 RVA: 0x0001400B File Offset: 0x0001220B
			public unsafe static RenderFunc<DepthOnlyPass.PassData> __9__18_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DepthOnlyPass.__c.NativeFieldInfoPtr___9__18_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderFunc<DepthOnlyPass.PassData>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DepthOnlyPass.__c.NativeFieldInfoPtr___9__18_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001884 RID: 6276
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04001885 RID: 6277
			private static readonly IntPtr NativeFieldInfoPtr___9__18_0;

			// Token: 0x04001886 RID: 6278
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001887 RID: 6279
			private static readonly IntPtr NativeMethodInfoPtr__Render_b__18_0_Internal_Void_PassData_RenderGraphContext_0;
		}
	}
}
