using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Experimental.Rendering.RenderGraphModule;

namespace UnityEngine.Rendering.Universal.Internal
{
	// Token: 0x0200011D RID: 285
	public class CopyColorPass : ScriptableRenderPass
	{
		// Token: 0x060018AF RID: 6319 RVA: 0x00067FD0 File Offset: 0x000661D0
		// Note: this type is marked as 'beforefieldinit'.
		static CopyColorPass()
		{
			Il2CppClassPointerStore<CopyColorPass>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal.Internal", "CopyColorPass");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CopyColorPass>.NativeClassPtr);
			CopyColorPass.NativeFieldInfoPtr_m_SampleOffsetShaderHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CopyColorPass>.NativeClassPtr, "m_SampleOffsetShaderHandle");
			CopyColorPass.NativeFieldInfoPtr_m_SamplingMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CopyColorPass>.NativeClassPtr, "m_SamplingMaterial");
			CopyColorPass.NativeFieldInfoPtr_m_DownsamplingMethod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CopyColorPass>.NativeClassPtr, "m_DownsamplingMethod");
			CopyColorPass.NativeFieldInfoPtr_m_CopyColorMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CopyColorPass>.NativeClassPtr, "m_CopyColorMaterial");
			CopyColorPass.NativeFieldInfoPtr__source_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CopyColorPass>.NativeClassPtr, "<source>k__BackingField");
			CopyColorPass.NativeFieldInfoPtr__destination_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CopyColorPass>.NativeClassPtr, "<destination>k__BackingField");
			CopyColorPass.NativeFieldInfoPtr__destinationID_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CopyColorPass>.NativeClassPtr, "<destinationID>k__BackingField");
			CopyColorPass.NativeFieldInfoPtr_m_PassData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CopyColorPass>.NativeClassPtr, "m_PassData");
			CopyColorPass.NativeMethodInfoPtr_get_source_Private_get_RTHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopyColorPass>.NativeClassPtr, 100666176);
			CopyColorPass.NativeMethodInfoPtr_set_source_Private_set_Void_RTHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopyColorPass>.NativeClassPtr, 100666177);
			CopyColorPass.NativeMethodInfoPtr_get_destination_Private_get_RTHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopyColorPass>.NativeClassPtr, 100666178);
			CopyColorPass.NativeMethodInfoPtr_set_destination_Private_set_Void_RTHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopyColorPass>.NativeClassPtr, 100666179);
			CopyColorPass.NativeMethodInfoPtr_get_destinationID_Private_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopyColorPass>.NativeClassPtr, 100666180);
			CopyColorPass.NativeMethodInfoPtr_set_destinationID_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopyColorPass>.NativeClassPtr, 100666181);
			CopyColorPass.NativeMethodInfoPtr__ctor_Public_Void_RenderPassEvent_Material_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopyColorPass>.NativeClassPtr, 100666182);
			CopyColorPass.NativeMethodInfoPtr_ConfigureDescriptor_Public_Static_Void_Downsampling_byref_RenderTextureDescriptor_byref_FilterMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopyColorPass>.NativeClassPtr, 100666183);
			CopyColorPass.NativeMethodInfoPtr_Setup_Public_Void_RenderTargetIdentifier_RenderTargetHandle_Downsampling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopyColorPass>.NativeClassPtr, 100666184);
			CopyColorPass.NativeMethodInfoPtr_Setup_Public_Void_RTHandle_RTHandle_Downsampling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopyColorPass>.NativeClassPtr, 100666185);
			CopyColorPass.NativeMethodInfoPtr_OnCameraSetup_Public_Virtual_Void_CommandBuffer_byref_RenderingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopyColorPass>.NativeClassPtr, 100666186);
			CopyColorPass.NativeMethodInfoPtr_Execute_Public_Virtual_Void_ScriptableRenderContext_byref_RenderingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopyColorPass>.NativeClassPtr, 100666187);
			CopyColorPass.NativeMethodInfoPtr_ExecutePass_Private_Static_Void_PassData_RTHandle_RTHandle_byref_CommandBuffer_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopyColorPass>.NativeClassPtr, 100666188);
			CopyColorPass.NativeMethodInfoPtr_Render_Internal_TextureHandle_RenderGraph_byref_TextureHandle_byref_TextureHandle_Downsampling_byref_RenderingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopyColorPass>.NativeClassPtr, 100666189);
			CopyColorPass.NativeMethodInfoPtr_OnCameraCleanup_Public_Virtual_Void_CommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopyColorPass>.NativeClassPtr, 100666190);
		}

		// Token: 0x17000917 RID: 2327
		// (get) Token: 0x060018B0 RID: 6320 RVA: 0x000681CC File Offset: 0x000663CC
		// (set) Token: 0x060018B1 RID: 6321 RVA: 0x0006820C File Offset: 0x0006640C
		public unsafe RTHandle source
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CopyColorPass.NativeMethodInfoPtr_get_source_Private_get_RTHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CopyColorPass.NativeMethodInfoPtr_set_source_Private_set_Void_RTHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000918 RID: 2328
		// (get) Token: 0x060018B2 RID: 6322 RVA: 0x00068250 File Offset: 0x00066450
		// (set) Token: 0x060018B3 RID: 6323 RVA: 0x00068290 File Offset: 0x00066490
		public unsafe RTHandle destination
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CopyColorPass.NativeMethodInfoPtr_get_destination_Private_get_RTHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CopyColorPass.NativeMethodInfoPtr_set_destination_Private_set_Void_RTHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000919 RID: 2329
		// (get) Token: 0x060018B4 RID: 6324 RVA: 0x000682D4 File Offset: 0x000664D4
		// (set) Token: 0x060018B5 RID: 6325 RVA: 0x00068310 File Offset: 0x00066510
		public unsafe int destinationID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CopyColorPass.NativeMethodInfoPtr_get_destinationID_Private_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CopyColorPass.NativeMethodInfoPtr_set_destinationID_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060018B6 RID: 6326 RVA: 0x00068350 File Offset: 0x00066550
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 626800, RefRangeEnd = 626801, XrefRangeStart = 626779, XrefRangeEnd = 626800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CopyColorPass(RenderPassEvent evt, Material samplingMaterial, Material copyColorMaterial = null)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CopyColorPass>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref evt;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(samplingMaterial);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(copyColorMaterial);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CopyColorPass.NativeMethodInfoPtr__ctor_Public_Void_RenderPassEvent_Material_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018B7 RID: 6327 RVA: 0x000683BC File Offset: 0x000665BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 626803, RefRangeEnd = 626804, XrefRangeStart = 626801, XrefRangeEnd = 626803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ConfigureDescriptor(Downsampling downsamplingMethod, ref RenderTextureDescriptor descriptor, out FilterMode filterMode)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref downsamplingMethod;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &descriptor;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &filterMode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CopyColorPass.NativeMethodInfoPtr_ConfigureDescriptor_Public_Static_Void_Downsampling_byref_RenderTextureDescriptor_byref_FilterMode_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018B8 RID: 6328 RVA: 0x0006840C File Offset: 0x0006660C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 626804, XrefRangeEnd = 626815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Setup(RenderTargetIdentifier source, RenderTargetHandle destination, Downsampling downsampling)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref source;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref destination;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref downsampling;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CopyColorPass.NativeMethodInfoPtr_Setup_Public_Void_RenderTargetIdentifier_RenderTargetHandle_Downsampling_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018B9 RID: 6329 RVA: 0x00068468 File Offset: 0x00066668
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 626817, RefRangeEnd = 626818, XrefRangeStart = 626815, XrefRangeEnd = 626817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Setup(RTHandle source, RTHandle destination, Downsampling downsampling)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(destination);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref downsampling;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CopyColorPass.NativeMethodInfoPtr_Setup_Public_Void_RTHandle_RTHandle_Downsampling_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018BA RID: 6330 RVA: 0x000684CC File Offset: 0x000666CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 626818, XrefRangeEnd = 626823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CopyColorPass.NativeMethodInfoPtr_OnCameraSetup_Public_Virtual_Void_CommandBuffer_byref_RenderingData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018BB RID: 6331 RVA: 0x0006852C File Offset: 0x0006672C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 626823, XrefRangeEnd = 626839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CopyColorPass.NativeMethodInfoPtr_Execute_Public_Virtual_Void_ScriptableRenderContext_byref_RenderingData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018BC RID: 6332 RVA: 0x00068588 File Offset: 0x00066788
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 626893, RefRangeEnd = 626895, XrefRangeStart = 626839, XrefRangeEnd = 626893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ExecutePass(CopyColorPass.PassData passData, RTHandle source, RTHandle destination, ref CommandBuffer cmd, bool useDrawProceduralBlit, bool disableFoveatedRenderingForPass)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(passData);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(source);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(destination);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useDrawProceduralBlit;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref disableFoveatedRenderingForPass;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(CopyColorPass.NativeMethodInfoPtr_ExecutePass_Private_Static_Void_PassData_RTHandle_RTHandle_byref_CommandBuffer_Boolean_Boolean_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			cmd = ((intPtr4 == 0) ? null : new CommandBuffer(intPtr4));
		}

		// Token: 0x060018BD RID: 6333 RVA: 0x00068628 File Offset: 0x00066828
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 626965, RefRangeEnd = 626966, XrefRangeStart = 626895, XrefRangeEnd = 626965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TextureHandle Render(RenderGraph renderGraph, out TextureHandle destination, [In] ref TextureHandle source, Downsampling downsampling, ref RenderingData renderingData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(renderGraph);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &destination;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &source;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref downsampling;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(renderingData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CopyColorPass.NativeMethodInfoPtr_Render_Internal_TextureHandle_RenderGraph_byref_TextureHandle_byref_TextureHandle_Downsampling_byref_RenderingData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060018BE RID: 6334 RVA: 0x000686B4 File Offset: 0x000668B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 626966, XrefRangeEnd = 626973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnCameraCleanup(CommandBuffer cmd)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CopyColorPass.NativeMethodInfoPtr_OnCameraCleanup_Public_Virtual_Void_CommandBuffer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060018BF RID: 6335 RVA: 0x0000E151 File Offset: 0x0000C351
		public CopyColorPass(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700090F RID: 2319
		// (get) Token: 0x060018C0 RID: 6336 RVA: 0x00068704 File Offset: 0x00066904
		// (set) Token: 0x060018C1 RID: 6337 RVA: 0x0000E15A File Offset: 0x0000C35A
		public unsafe int m_SampleOffsetShaderHandle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CopyColorPass.NativeFieldInfoPtr_m_SampleOffsetShaderHandle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CopyColorPass.NativeFieldInfoPtr_m_SampleOffsetShaderHandle)) = value;
			}
		}

		// Token: 0x17000910 RID: 2320
		// (get) Token: 0x060018C2 RID: 6338 RVA: 0x0006872C File Offset: 0x0006692C
		// (set) Token: 0x060018C3 RID: 6339 RVA: 0x0000E175 File Offset: 0x0000C375
		public unsafe Material m_SamplingMaterial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CopyColorPass.NativeFieldInfoPtr_m_SamplingMaterial);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CopyColorPass.NativeFieldInfoPtr_m_SamplingMaterial), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000911 RID: 2321
		// (get) Token: 0x060018C4 RID: 6340 RVA: 0x0006875C File Offset: 0x0006695C
		// (set) Token: 0x060018C5 RID: 6341 RVA: 0x0000E194 File Offset: 0x0000C394
		public unsafe Downsampling m_DownsamplingMethod
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CopyColorPass.NativeFieldInfoPtr_m_DownsamplingMethod);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CopyColorPass.NativeFieldInfoPtr_m_DownsamplingMethod)) = value;
			}
		}

		// Token: 0x17000912 RID: 2322
		// (get) Token: 0x060018C6 RID: 6342 RVA: 0x00068784 File Offset: 0x00066984
		// (set) Token: 0x060018C7 RID: 6343 RVA: 0x0000E1AF File Offset: 0x0000C3AF
		public unsafe Material m_CopyColorMaterial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CopyColorPass.NativeFieldInfoPtr_m_CopyColorMaterial);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CopyColorPass.NativeFieldInfoPtr_m_CopyColorMaterial), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000913 RID: 2323
		// (get) Token: 0x060018C8 RID: 6344 RVA: 0x000687B4 File Offset: 0x000669B4
		// (set) Token: 0x060018C9 RID: 6345 RVA: 0x0000E1CE File Offset: 0x0000C3CE
		public unsafe RTHandle _source_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CopyColorPass.NativeFieldInfoPtr__source_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RTHandle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CopyColorPass.NativeFieldInfoPtr__source_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000914 RID: 2324
		// (get) Token: 0x060018CA RID: 6346 RVA: 0x000687E4 File Offset: 0x000669E4
		// (set) Token: 0x060018CB RID: 6347 RVA: 0x0000E1ED File Offset: 0x0000C3ED
		public unsafe RTHandle _destination_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CopyColorPass.NativeFieldInfoPtr__destination_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RTHandle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CopyColorPass.NativeFieldInfoPtr__destination_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000915 RID: 2325
		// (get) Token: 0x060018CC RID: 6348 RVA: 0x00068814 File Offset: 0x00066A14
		// (set) Token: 0x060018CD RID: 6349 RVA: 0x0000E20C File Offset: 0x0000C40C
		public unsafe int _destinationID_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CopyColorPass.NativeFieldInfoPtr__destinationID_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CopyColorPass.NativeFieldInfoPtr__destinationID_k__BackingField)) = value;
			}
		}

		// Token: 0x17000916 RID: 2326
		// (get) Token: 0x060018CE RID: 6350 RVA: 0x0006883C File Offset: 0x00066A3C
		// (set) Token: 0x060018CF RID: 6351 RVA: 0x0000E227 File Offset: 0x0000C427
		public unsafe CopyColorPass.PassData m_PassData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CopyColorPass.NativeFieldInfoPtr_m_PassData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CopyColorPass.PassData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CopyColorPass.NativeFieldInfoPtr_m_PassData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040011E2 RID: 4578
		private static readonly IntPtr NativeFieldInfoPtr_m_SampleOffsetShaderHandle;

		// Token: 0x040011E3 RID: 4579
		private static readonly IntPtr NativeFieldInfoPtr_m_SamplingMaterial;

		// Token: 0x040011E4 RID: 4580
		private static readonly IntPtr NativeFieldInfoPtr_m_DownsamplingMethod;

		// Token: 0x040011E5 RID: 4581
		private static readonly IntPtr NativeFieldInfoPtr_m_CopyColorMaterial;

		// Token: 0x040011E6 RID: 4582
		private static readonly IntPtr NativeFieldInfoPtr__source_k__BackingField;

		// Token: 0x040011E7 RID: 4583
		private static readonly IntPtr NativeFieldInfoPtr__destination_k__BackingField;

		// Token: 0x040011E8 RID: 4584
		private static readonly IntPtr NativeFieldInfoPtr__destinationID_k__BackingField;

		// Token: 0x040011E9 RID: 4585
		private static readonly IntPtr NativeFieldInfoPtr_m_PassData;

		// Token: 0x040011EA RID: 4586
		private static readonly IntPtr NativeMethodInfoPtr_get_source_Private_get_RTHandle_0;

		// Token: 0x040011EB RID: 4587
		private static readonly IntPtr NativeMethodInfoPtr_set_source_Private_set_Void_RTHandle_0;

		// Token: 0x040011EC RID: 4588
		private static readonly IntPtr NativeMethodInfoPtr_get_destination_Private_get_RTHandle_0;

		// Token: 0x040011ED RID: 4589
		private static readonly IntPtr NativeMethodInfoPtr_set_destination_Private_set_Void_RTHandle_0;

		// Token: 0x040011EE RID: 4590
		private static readonly IntPtr NativeMethodInfoPtr_get_destinationID_Private_get_Int32_0;

		// Token: 0x040011EF RID: 4591
		private static readonly IntPtr NativeMethodInfoPtr_set_destinationID_Private_set_Void_Int32_0;

		// Token: 0x040011F0 RID: 4592
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_RenderPassEvent_Material_Material_0;

		// Token: 0x040011F1 RID: 4593
		private static readonly IntPtr NativeMethodInfoPtr_ConfigureDescriptor_Public_Static_Void_Downsampling_byref_RenderTextureDescriptor_byref_FilterMode_0;

		// Token: 0x040011F2 RID: 4594
		private static readonly IntPtr NativeMethodInfoPtr_Setup_Public_Void_RenderTargetIdentifier_RenderTargetHandle_Downsampling_0;

		// Token: 0x040011F3 RID: 4595
		private static readonly IntPtr NativeMethodInfoPtr_Setup_Public_Void_RTHandle_RTHandle_Downsampling_0;

		// Token: 0x040011F4 RID: 4596
		private static readonly IntPtr NativeMethodInfoPtr_OnCameraSetup_Public_Virtual_Void_CommandBuffer_byref_RenderingData_0;

		// Token: 0x040011F5 RID: 4597
		private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_ScriptableRenderContext_byref_RenderingData_0;

		// Token: 0x040011F6 RID: 4598
		private static readonly IntPtr NativeMethodInfoPtr_ExecutePass_Private_Static_Void_PassData_RTHandle_RTHandle_byref_CommandBuffer_Boolean_Boolean_0;

		// Token: 0x040011F7 RID: 4599
		private static readonly IntPtr NativeMethodInfoPtr_Render_Internal_TextureHandle_RenderGraph_byref_TextureHandle_byref_TextureHandle_Downsampling_byref_RenderingData_0;

		// Token: 0x040011F8 RID: 4600
		private static readonly IntPtr NativeMethodInfoPtr_OnCameraCleanup_Public_Virtual_Void_CommandBuffer_0;

		// Token: 0x020001EF RID: 495
		public class PassData : Object
		{
			// Token: 0x0600227B RID: 8827 RVA: 0x00083748 File Offset: 0x00081948
			// Note: this type is marked as 'beforefieldinit'.
			static PassData()
			{
				Il2CppClassPointerStore<CopyColorPass.PassData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CopyColorPass>.NativeClassPtr, "PassData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CopyColorPass.PassData>.NativeClassPtr);
				CopyColorPass.PassData.NativeFieldInfoPtr_source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CopyColorPass.PassData>.NativeClassPtr, "source");
				CopyColorPass.PassData.NativeFieldInfoPtr_destination = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CopyColorPass.PassData>.NativeClassPtr, "destination");
				CopyColorPass.PassData.NativeFieldInfoPtr_useProceduralBlit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CopyColorPass.PassData>.NativeClassPtr, "useProceduralBlit");
				CopyColorPass.PassData.NativeFieldInfoPtr_disableFoveatedRenderingForPass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CopyColorPass.PassData>.NativeClassPtr, "disableFoveatedRenderingForPass");
				CopyColorPass.PassData.NativeFieldInfoPtr_cmd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CopyColorPass.PassData>.NativeClassPtr, "cmd");
				CopyColorPass.PassData.NativeFieldInfoPtr_samplingMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CopyColorPass.PassData>.NativeClassPtr, "samplingMaterial");
				CopyColorPass.PassData.NativeFieldInfoPtr_copyColorMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CopyColorPass.PassData>.NativeClassPtr, "copyColorMaterial");
				CopyColorPass.PassData.NativeFieldInfoPtr_downsamplingMethod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CopyColorPass.PassData>.NativeClassPtr, "downsamplingMethod");
				CopyColorPass.PassData.NativeFieldInfoPtr_clearFlag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CopyColorPass.PassData>.NativeClassPtr, "clearFlag");
				CopyColorPass.PassData.NativeFieldInfoPtr_clearColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CopyColorPass.PassData>.NativeClassPtr, "clearColor");
				CopyColorPass.PassData.NativeFieldInfoPtr_sampleOffsetShaderHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CopyColorPass.PassData>.NativeClassPtr, "sampleOffsetShaderHandle");
				CopyColorPass.PassData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopyColorPass.PassData>.NativeClassPtr, 100666191);
			}

			// Token: 0x0600227C RID: 8828 RVA: 0x00083864 File Offset: 0x00081A64
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe PassData()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CopyColorPass.PassData>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CopyColorPass.PassData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600227D RID: 8829 RVA: 0x00013AF6 File Offset: 0x00011CF6
			public PassData(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000C76 RID: 3190
			// (get) Token: 0x0600227E RID: 8830 RVA: 0x000838A0 File Offset: 0x00081AA0
			// (set) Token: 0x0600227F RID: 8831 RVA: 0x00013AFF File Offset: 0x00011CFF
			public unsafe TextureHandle source
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CopyColorPass.PassData.NativeFieldInfoPtr_source);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CopyColorPass.PassData.NativeFieldInfoPtr_source)) = value;
				}
			}

			// Token: 0x17000C77 RID: 3191
			// (get) Token: 0x06002280 RID: 8832 RVA: 0x000838C8 File Offset: 0x00081AC8
			// (set) Token: 0x06002281 RID: 8833 RVA: 0x00013B1A File Offset: 0x00011D1A
			public unsafe TextureHandle destination
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CopyColorPass.PassData.NativeFieldInfoPtr_destination);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CopyColorPass.PassData.NativeFieldInfoPtr_destination)) = value;
				}
			}

			// Token: 0x17000C78 RID: 3192
			// (get) Token: 0x06002282 RID: 8834 RVA: 0x000838F0 File Offset: 0x00081AF0
			// (set) Token: 0x06002283 RID: 8835 RVA: 0x00013B35 File Offset: 0x00011D35
			public unsafe bool useProceduralBlit
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CopyColorPass.PassData.NativeFieldInfoPtr_useProceduralBlit);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CopyColorPass.PassData.NativeFieldInfoPtr_useProceduralBlit)) = value;
				}
			}

			// Token: 0x17000C79 RID: 3193
			// (get) Token: 0x06002284 RID: 8836 RVA: 0x00083918 File Offset: 0x00081B18
			// (set) Token: 0x06002285 RID: 8837 RVA: 0x00013B50 File Offset: 0x00011D50
			public unsafe bool disableFoveatedRenderingForPass
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CopyColorPass.PassData.NativeFieldInfoPtr_disableFoveatedRenderingForPass);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CopyColorPass.PassData.NativeFieldInfoPtr_disableFoveatedRenderingForPass)) = value;
				}
			}

			// Token: 0x17000C7A RID: 3194
			// (get) Token: 0x06002286 RID: 8838 RVA: 0x00083940 File Offset: 0x00081B40
			// (set) Token: 0x06002287 RID: 8839 RVA: 0x00013B6B File Offset: 0x00011D6B
			public unsafe CommandBuffer cmd
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CopyColorPass.PassData.NativeFieldInfoPtr_cmd);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CommandBuffer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CopyColorPass.PassData.NativeFieldInfoPtr_cmd), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000C7B RID: 3195
			// (get) Token: 0x06002288 RID: 8840 RVA: 0x00083970 File Offset: 0x00081B70
			// (set) Token: 0x06002289 RID: 8841 RVA: 0x00013B8A File Offset: 0x00011D8A
			public unsafe Material samplingMaterial
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CopyColorPass.PassData.NativeFieldInfoPtr_samplingMaterial);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CopyColorPass.PassData.NativeFieldInfoPtr_samplingMaterial), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000C7C RID: 3196
			// (get) Token: 0x0600228A RID: 8842 RVA: 0x000839A0 File Offset: 0x00081BA0
			// (set) Token: 0x0600228B RID: 8843 RVA: 0x00013BA9 File Offset: 0x00011DA9
			public unsafe Material copyColorMaterial
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CopyColorPass.PassData.NativeFieldInfoPtr_copyColorMaterial);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CopyColorPass.PassData.NativeFieldInfoPtr_copyColorMaterial), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000C7D RID: 3197
			// (get) Token: 0x0600228C RID: 8844 RVA: 0x000839D0 File Offset: 0x00081BD0
			// (set) Token: 0x0600228D RID: 8845 RVA: 0x00013BC8 File Offset: 0x00011DC8
			public unsafe Downsampling downsamplingMethod
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CopyColorPass.PassData.NativeFieldInfoPtr_downsamplingMethod);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CopyColorPass.PassData.NativeFieldInfoPtr_downsamplingMethod)) = value;
				}
			}

			// Token: 0x17000C7E RID: 3198
			// (get) Token: 0x0600228E RID: 8846 RVA: 0x000839F8 File Offset: 0x00081BF8
			// (set) Token: 0x0600228F RID: 8847 RVA: 0x00013BE3 File Offset: 0x00011DE3
			public unsafe ClearFlag clearFlag
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CopyColorPass.PassData.NativeFieldInfoPtr_clearFlag);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CopyColorPass.PassData.NativeFieldInfoPtr_clearFlag)) = value;
				}
			}

			// Token: 0x17000C7F RID: 3199
			// (get) Token: 0x06002290 RID: 8848 RVA: 0x00083A20 File Offset: 0x00081C20
			// (set) Token: 0x06002291 RID: 8849 RVA: 0x00013BFE File Offset: 0x00011DFE
			public unsafe Color clearColor
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CopyColorPass.PassData.NativeFieldInfoPtr_clearColor);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CopyColorPass.PassData.NativeFieldInfoPtr_clearColor)) = value;
				}
			}

			// Token: 0x17000C80 RID: 3200
			// (get) Token: 0x06002292 RID: 8850 RVA: 0x00083A48 File Offset: 0x00081C48
			// (set) Token: 0x06002293 RID: 8851 RVA: 0x00013C19 File Offset: 0x00011E19
			public unsafe int sampleOffsetShaderHandle
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CopyColorPass.PassData.NativeFieldInfoPtr_sampleOffsetShaderHandle);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CopyColorPass.PassData.NativeFieldInfoPtr_sampleOffsetShaderHandle)) = value;
				}
			}

			// Token: 0x04001848 RID: 6216
			private static readonly IntPtr NativeFieldInfoPtr_source;

			// Token: 0x04001849 RID: 6217
			private static readonly IntPtr NativeFieldInfoPtr_destination;

			// Token: 0x0400184A RID: 6218
			private static readonly IntPtr NativeFieldInfoPtr_useProceduralBlit;

			// Token: 0x0400184B RID: 6219
			private static readonly IntPtr NativeFieldInfoPtr_disableFoveatedRenderingForPass;

			// Token: 0x0400184C RID: 6220
			private static readonly IntPtr NativeFieldInfoPtr_cmd;

			// Token: 0x0400184D RID: 6221
			private static readonly IntPtr NativeFieldInfoPtr_samplingMaterial;

			// Token: 0x0400184E RID: 6222
			private static readonly IntPtr NativeFieldInfoPtr_copyColorMaterial;

			// Token: 0x0400184F RID: 6223
			private static readonly IntPtr NativeFieldInfoPtr_downsamplingMethod;

			// Token: 0x04001850 RID: 6224
			private static readonly IntPtr NativeFieldInfoPtr_clearFlag;

			// Token: 0x04001851 RID: 6225
			private static readonly IntPtr NativeFieldInfoPtr_clearColor;

			// Token: 0x04001852 RID: 6226
			private static readonly IntPtr NativeFieldInfoPtr_sampleOffsetShaderHandle;

			// Token: 0x04001853 RID: 6227
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020001F0 RID: 496
		[ObfuscatedName("UnityEngine.Rendering.Universal.Internal.CopyColorPass+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06002294 RID: 8852 RVA: 0x00083A70 File Offset: 0x00081C70
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<CopyColorPass.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CopyColorPass>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CopyColorPass.__c>.NativeClassPtr);
				CopyColorPass.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CopyColorPass.__c>.NativeClassPtr, "<>9");
				CopyColorPass.__c.NativeFieldInfoPtr___9__25_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CopyColorPass.__c>.NativeClassPtr, "<>9__25_0");
				CopyColorPass.__c.NativeFieldInfoPtr___9__25_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CopyColorPass.__c>.NativeClassPtr, "<>9__25_1");
				CopyColorPass.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopyColorPass.__c>.NativeClassPtr, 100666193);
				CopyColorPass.__c.NativeMethodInfoPtr__Render_b__25_0_Internal_Void_PassData_RenderGraphContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopyColorPass.__c>.NativeClassPtr, 100666194);
				CopyColorPass.__c.NativeMethodInfoPtr__Render_b__25_1_Internal_Void_PassData_RenderGraphContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopyColorPass.__c>.NativeClassPtr, 100666195);
			}

			// Token: 0x06002295 RID: 8853 RVA: 0x00083B14 File Offset: 0x00081D14
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CopyColorPass.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CopyColorPass.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002296 RID: 8854 RVA: 0x00083B50 File Offset: 0x00081D50
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 626766, XrefRangeEnd = 626772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Render_b__25_0(CopyColorPass.PassData data, RenderGraphContext context)
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CopyColorPass.__c.NativeMethodInfoPtr__Render_b__25_0_Internal_Void_PassData_RenderGraphContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002297 RID: 8855 RVA: 0x00083BA4 File Offset: 0x00081DA4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 626772, XrefRangeEnd = 626779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Render_b__25_1(CopyColorPass.PassData data, RenderGraphContext context)
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CopyColorPass.__c.NativeMethodInfoPtr__Render_b__25_1_Internal_Void_PassData_RenderGraphContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002298 RID: 8856 RVA: 0x00013C34 File Offset: 0x00011E34
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000C81 RID: 3201
			// (get) Token: 0x06002299 RID: 8857 RVA: 0x00083BF8 File Offset: 0x00081DF8
			// (set) Token: 0x0600229A RID: 8858 RVA: 0x00013C3D File Offset: 0x00011E3D
			public unsafe static CopyColorPass.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CopyColorPass.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CopyColorPass.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CopyColorPass.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000C82 RID: 3202
			// (get) Token: 0x0600229B RID: 8859 RVA: 0x00083C20 File Offset: 0x00081E20
			// (set) Token: 0x0600229C RID: 8860 RVA: 0x00013C4F File Offset: 0x00011E4F
			public unsafe static RenderFunc<CopyColorPass.PassData> __9__25_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CopyColorPass.__c.NativeFieldInfoPtr___9__25_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderFunc<CopyColorPass.PassData>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CopyColorPass.__c.NativeFieldInfoPtr___9__25_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000C83 RID: 3203
			// (get) Token: 0x0600229D RID: 8861 RVA: 0x00083C48 File Offset: 0x00081E48
			// (set) Token: 0x0600229E RID: 8862 RVA: 0x00013C61 File Offset: 0x00011E61
			public unsafe static RenderFunc<CopyColorPass.PassData> __9__25_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CopyColorPass.__c.NativeFieldInfoPtr___9__25_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderFunc<CopyColorPass.PassData>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CopyColorPass.__c.NativeFieldInfoPtr___9__25_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001854 RID: 6228
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04001855 RID: 6229
			private static readonly IntPtr NativeFieldInfoPtr___9__25_0;

			// Token: 0x04001856 RID: 6230
			private static readonly IntPtr NativeFieldInfoPtr___9__25_1;

			// Token: 0x04001857 RID: 6231
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001858 RID: 6232
			private static readonly IntPtr NativeMethodInfoPtr__Render_b__25_0_Internal_Void_PassData_RenderGraphContext_0;

			// Token: 0x04001859 RID: 6233
			private static readonly IntPtr NativeMethodInfoPtr__Render_b__25_1_Internal_Void_PassData_RenderGraphContext_0;
		}
	}
}
