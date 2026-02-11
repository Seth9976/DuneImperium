using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Experimental.Rendering.RenderGraphModule;

namespace UnityEngine.Rendering.Universal.Internal
{
	// Token: 0x0200011E RID: 286
	public class CopyDepthPass : ScriptableRenderPass
	{
		// Token: 0x060018D0 RID: 6352 RVA: 0x0006886C File Offset: 0x00066A6C
		// Note: this type is marked as 'beforefieldinit'.
		static CopyDepthPass()
		{
			Il2CppClassPointerStore<CopyDepthPass>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal.Internal", "CopyDepthPass");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CopyDepthPass>.NativeClassPtr);
			CopyDepthPass.NativeFieldInfoPtr__source_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CopyDepthPass>.NativeClassPtr, "<source>k__BackingField");
			CopyDepthPass.NativeFieldInfoPtr__destination_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CopyDepthPass>.NativeClassPtr, "<destination>k__BackingField");
			CopyDepthPass.NativeFieldInfoPtr__MssaSamples_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CopyDepthPass>.NativeClassPtr, "<MssaSamples>k__BackingField");
			CopyDepthPass.NativeFieldInfoPtr__CopyToDepth_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CopyDepthPass>.NativeClassPtr, "<CopyToDepth>k__BackingField");
			CopyDepthPass.NativeFieldInfoPtr_m_CopyDepthMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CopyDepthPass>.NativeClassPtr, "m_CopyDepthMaterial");
			CopyDepthPass.NativeFieldInfoPtr_m_CopyResolvedDepth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CopyDepthPass>.NativeClassPtr, "m_CopyResolvedDepth");
			CopyDepthPass.NativeFieldInfoPtr_m_ShouldClear = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CopyDepthPass>.NativeClassPtr, "m_ShouldClear");
			CopyDepthPass.NativeFieldInfoPtr_m_PassData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CopyDepthPass>.NativeClassPtr, "m_PassData");
			CopyDepthPass.NativeMethodInfoPtr_get_source_Private_get_RTHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopyDepthPass>.NativeClassPtr, 100666196);
			CopyDepthPass.NativeMethodInfoPtr_set_source_Private_set_Void_RTHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopyDepthPass>.NativeClassPtr, 100666197);
			CopyDepthPass.NativeMethodInfoPtr_get_destination_Private_get_RTHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopyDepthPass>.NativeClassPtr, 100666198);
			CopyDepthPass.NativeMethodInfoPtr_set_destination_Private_set_Void_RTHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopyDepthPass>.NativeClassPtr, 100666199);
			CopyDepthPass.NativeMethodInfoPtr_get_MssaSamples_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopyDepthPass>.NativeClassPtr, 100666200);
			CopyDepthPass.NativeMethodInfoPtr_set_MssaSamples_Internal_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopyDepthPass>.NativeClassPtr, 100666201);
			CopyDepthPass.NativeMethodInfoPtr_get_CopyToDepth_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopyDepthPass>.NativeClassPtr, 100666202);
			CopyDepthPass.NativeMethodInfoPtr_set_CopyToDepth_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopyDepthPass>.NativeClassPtr, 100666203);
			CopyDepthPass.NativeMethodInfoPtr__ctor_Public_Void_RenderPassEvent_Material_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopyDepthPass>.NativeClassPtr, 100666204);
			CopyDepthPass.NativeMethodInfoPtr_Setup_Public_Void_RTHandle_RTHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopyDepthPass>.NativeClassPtr, 100666205);
			CopyDepthPass.NativeMethodInfoPtr_OnCameraSetup_Public_Virtual_Void_CommandBuffer_byref_RenderingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopyDepthPass>.NativeClassPtr, 100666206);
			CopyDepthPass.NativeMethodInfoPtr_Execute_Public_Virtual_Void_ScriptableRenderContext_byref_RenderingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopyDepthPass>.NativeClassPtr, 100666207);
			CopyDepthPass.NativeMethodInfoPtr_ExecutePass_Private_Static_Void_ScriptableRenderContext_PassData_byref_CommandBuffer_byref_CameraData_RTHandle_RTHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopyDepthPass>.NativeClassPtr, 100666208);
			CopyDepthPass.NativeMethodInfoPtr_OnCameraCleanup_Public_Virtual_Void_CommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopyDepthPass>.NativeClassPtr, 100666209);
			CopyDepthPass.NativeMethodInfoPtr_Render_Internal_Void_RenderGraph_byref_TextureHandle_byref_TextureHandle_byref_RenderingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopyDepthPass>.NativeClassPtr, 100666210);
		}

		// Token: 0x17000922 RID: 2338
		// (get) Token: 0x060018D1 RID: 6353 RVA: 0x00068A68 File Offset: 0x00066C68
		// (set) Token: 0x060018D2 RID: 6354 RVA: 0x00068AA8 File Offset: 0x00066CA8
		public unsafe RTHandle source
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CopyDepthPass.NativeMethodInfoPtr_get_source_Private_get_RTHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CopyDepthPass.NativeMethodInfoPtr_set_source_Private_set_Void_RTHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000923 RID: 2339
		// (get) Token: 0x060018D3 RID: 6355 RVA: 0x00068AEC File Offset: 0x00066CEC
		// (set) Token: 0x060018D4 RID: 6356 RVA: 0x00068B2C File Offset: 0x00066D2C
		public unsafe RTHandle destination
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CopyDepthPass.NativeMethodInfoPtr_get_destination_Private_get_RTHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CopyDepthPass.NativeMethodInfoPtr_set_destination_Private_set_Void_RTHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000924 RID: 2340
		// (get) Token: 0x060018D5 RID: 6357 RVA: 0x00068B70 File Offset: 0x00066D70
		// (set) Token: 0x060018D6 RID: 6358 RVA: 0x00068BAC File Offset: 0x00066DAC
		public unsafe int MssaSamples
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CopyDepthPass.NativeMethodInfoPtr_get_MssaSamples_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CopyDepthPass.NativeMethodInfoPtr_set_MssaSamples_Internal_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000925 RID: 2341
		// (get) Token: 0x060018D7 RID: 6359 RVA: 0x00068BEC File Offset: 0x00066DEC
		// (set) Token: 0x060018D8 RID: 6360 RVA: 0x00068C28 File Offset: 0x00066E28
		public unsafe bool CopyToDepth
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CopyDepthPass.NativeMethodInfoPtr_get_CopyToDepth_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CopyDepthPass.NativeMethodInfoPtr_set_CopyToDepth_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060018D9 RID: 6361 RVA: 0x00068C68 File Offset: 0x00066E68
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 627010, RefRangeEnd = 627015, XrefRangeStart = 626993, XrefRangeEnd = 627010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CopyDepthPass(RenderPassEvent evt, Material copyDepthMaterial, bool shouldClear = false, bool copyToDepth = false, bool copyResolvedDepth = false)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CopyDepthPass>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref evt;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(copyDepthMaterial);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref shouldClear;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref copyToDepth;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref copyResolvedDepth;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CopyDepthPass.NativeMethodInfoPtr__ctor_Public_Void_RenderPassEvent_Material_Boolean_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018DA RID: 6362 RVA: 0x00068CEC File Offset: 0x00066EEC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 627017, RefRangeEnd = 627021, XrefRangeStart = 627015, XrefRangeEnd = 627017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Setup(RTHandle source, RTHandle destination)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(destination);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CopyDepthPass.NativeMethodInfoPtr_Setup_Public_Void_RTHandle_RTHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018DB RID: 6363 RVA: 0x00068D40 File Offset: 0x00066F40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 627021, XrefRangeEnd = 627030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CopyDepthPass.NativeMethodInfoPtr_OnCameraSetup_Public_Virtual_Void_CommandBuffer_byref_RenderingData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018DC RID: 6364 RVA: 0x00068DA0 File Offset: 0x00066FA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 627030, XrefRangeEnd = 627040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CopyDepthPass.NativeMethodInfoPtr_Execute_Public_Virtual_Void_ScriptableRenderContext_byref_RenderingData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018DD RID: 6365 RVA: 0x00068DFC File Offset: 0x00066FFC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 627123, RefRangeEnd = 627125, XrefRangeStart = 627040, XrefRangeEnd = 627123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ExecutePass(ScriptableRenderContext context, CopyDepthPass.PassData passData, ref CommandBuffer cmd, ref CameraData cameraData, RTHandle source, RTHandle destination)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref context;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(passData);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(cameraData);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(source);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(destination);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(CopyDepthPass.NativeMethodInfoPtr_ExecutePass_Private_Static_Void_ScriptableRenderContext_PassData_byref_CommandBuffer_byref_CameraData_RTHandle_RTHandle_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			cmd = ((intPtr4 == 0) ? null : new CommandBuffer(intPtr4));
		}

		// Token: 0x060018DE RID: 6366 RVA: 0x00068EA0 File Offset: 0x000670A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 627125, XrefRangeEnd = 627136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnCameraCleanup(CommandBuffer cmd)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CopyDepthPass.NativeMethodInfoPtr_OnCameraCleanup_Public_Virtual_Void_CommandBuffer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060018DF RID: 6367 RVA: 0x00068EF0 File Offset: 0x000670F0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 627225, RefRangeEnd = 627227, XrefRangeStart = 627136, XrefRangeEnd = 627225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Render(RenderGraph renderGraph, out TextureHandle destination, [In] ref TextureHandle source, ref RenderingData renderingData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(renderGraph);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &destination;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &source;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(renderingData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CopyDepthPass.NativeMethodInfoPtr_Render_Internal_Void_RenderGraph_byref_TextureHandle_byref_TextureHandle_byref_RenderingData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018E0 RID: 6368 RVA: 0x0000E246 File Offset: 0x0000C446
		public CopyDepthPass(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700091A RID: 2330
		// (get) Token: 0x060018E1 RID: 6369 RVA: 0x00068F64 File Offset: 0x00067164
		// (set) Token: 0x060018E2 RID: 6370 RVA: 0x0000E24F File Offset: 0x0000C44F
		public unsafe RTHandle _source_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CopyDepthPass.NativeFieldInfoPtr__source_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RTHandle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CopyDepthPass.NativeFieldInfoPtr__source_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700091B RID: 2331
		// (get) Token: 0x060018E3 RID: 6371 RVA: 0x00068F94 File Offset: 0x00067194
		// (set) Token: 0x060018E4 RID: 6372 RVA: 0x0000E26E File Offset: 0x0000C46E
		public unsafe RTHandle _destination_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CopyDepthPass.NativeFieldInfoPtr__destination_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RTHandle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CopyDepthPass.NativeFieldInfoPtr__destination_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700091C RID: 2332
		// (get) Token: 0x060018E5 RID: 6373 RVA: 0x00068FC4 File Offset: 0x000671C4
		// (set) Token: 0x060018E6 RID: 6374 RVA: 0x0000E28D File Offset: 0x0000C48D
		public unsafe int _MssaSamples_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CopyDepthPass.NativeFieldInfoPtr__MssaSamples_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CopyDepthPass.NativeFieldInfoPtr__MssaSamples_k__BackingField)) = value;
			}
		}

		// Token: 0x1700091D RID: 2333
		// (get) Token: 0x060018E7 RID: 6375 RVA: 0x00068FEC File Offset: 0x000671EC
		// (set) Token: 0x060018E8 RID: 6376 RVA: 0x0000E2A8 File Offset: 0x0000C4A8
		public unsafe bool _CopyToDepth_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CopyDepthPass.NativeFieldInfoPtr__CopyToDepth_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CopyDepthPass.NativeFieldInfoPtr__CopyToDepth_k__BackingField)) = value;
			}
		}

		// Token: 0x1700091E RID: 2334
		// (get) Token: 0x060018E9 RID: 6377 RVA: 0x00069014 File Offset: 0x00067214
		// (set) Token: 0x060018EA RID: 6378 RVA: 0x0000E2C3 File Offset: 0x0000C4C3
		public unsafe Material m_CopyDepthMaterial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CopyDepthPass.NativeFieldInfoPtr_m_CopyDepthMaterial);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CopyDepthPass.NativeFieldInfoPtr_m_CopyDepthMaterial), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700091F RID: 2335
		// (get) Token: 0x060018EB RID: 6379 RVA: 0x00069044 File Offset: 0x00067244
		// (set) Token: 0x060018EC RID: 6380 RVA: 0x0000E2E2 File Offset: 0x0000C4E2
		public unsafe bool m_CopyResolvedDepth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CopyDepthPass.NativeFieldInfoPtr_m_CopyResolvedDepth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CopyDepthPass.NativeFieldInfoPtr_m_CopyResolvedDepth)) = value;
			}
		}

		// Token: 0x17000920 RID: 2336
		// (get) Token: 0x060018ED RID: 6381 RVA: 0x0006906C File Offset: 0x0006726C
		// (set) Token: 0x060018EE RID: 6382 RVA: 0x0000E2FD File Offset: 0x0000C4FD
		public unsafe bool m_ShouldClear
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CopyDepthPass.NativeFieldInfoPtr_m_ShouldClear);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CopyDepthPass.NativeFieldInfoPtr_m_ShouldClear)) = value;
			}
		}

		// Token: 0x17000921 RID: 2337
		// (get) Token: 0x060018EF RID: 6383 RVA: 0x00069094 File Offset: 0x00067294
		// (set) Token: 0x060018F0 RID: 6384 RVA: 0x0000E318 File Offset: 0x0000C518
		public unsafe CopyDepthPass.PassData m_PassData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CopyDepthPass.NativeFieldInfoPtr_m_PassData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CopyDepthPass.PassData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CopyDepthPass.NativeFieldInfoPtr_m_PassData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040011F9 RID: 4601
		private static readonly IntPtr NativeFieldInfoPtr__source_k__BackingField;

		// Token: 0x040011FA RID: 4602
		private static readonly IntPtr NativeFieldInfoPtr__destination_k__BackingField;

		// Token: 0x040011FB RID: 4603
		private static readonly IntPtr NativeFieldInfoPtr__MssaSamples_k__BackingField;

		// Token: 0x040011FC RID: 4604
		private static readonly IntPtr NativeFieldInfoPtr__CopyToDepth_k__BackingField;

		// Token: 0x040011FD RID: 4605
		private static readonly IntPtr NativeFieldInfoPtr_m_CopyDepthMaterial;

		// Token: 0x040011FE RID: 4606
		private static readonly IntPtr NativeFieldInfoPtr_m_CopyResolvedDepth;

		// Token: 0x040011FF RID: 4607
		private static readonly IntPtr NativeFieldInfoPtr_m_ShouldClear;

		// Token: 0x04001200 RID: 4608
		private static readonly IntPtr NativeFieldInfoPtr_m_PassData;

		// Token: 0x04001201 RID: 4609
		private static readonly IntPtr NativeMethodInfoPtr_get_source_Private_get_RTHandle_0;

		// Token: 0x04001202 RID: 4610
		private static readonly IntPtr NativeMethodInfoPtr_set_source_Private_set_Void_RTHandle_0;

		// Token: 0x04001203 RID: 4611
		private static readonly IntPtr NativeMethodInfoPtr_get_destination_Private_get_RTHandle_0;

		// Token: 0x04001204 RID: 4612
		private static readonly IntPtr NativeMethodInfoPtr_set_destination_Private_set_Void_RTHandle_0;

		// Token: 0x04001205 RID: 4613
		private static readonly IntPtr NativeMethodInfoPtr_get_MssaSamples_Internal_get_Int32_0;

		// Token: 0x04001206 RID: 4614
		private static readonly IntPtr NativeMethodInfoPtr_set_MssaSamples_Internal_set_Void_Int32_0;

		// Token: 0x04001207 RID: 4615
		private static readonly IntPtr NativeMethodInfoPtr_get_CopyToDepth_Internal_get_Boolean_0;

		// Token: 0x04001208 RID: 4616
		private static readonly IntPtr NativeMethodInfoPtr_set_CopyToDepth_Internal_set_Void_Boolean_0;

		// Token: 0x04001209 RID: 4617
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_RenderPassEvent_Material_Boolean_Boolean_Boolean_0;

		// Token: 0x0400120A RID: 4618
		private static readonly IntPtr NativeMethodInfoPtr_Setup_Public_Void_RTHandle_RTHandle_0;

		// Token: 0x0400120B RID: 4619
		private static readonly IntPtr NativeMethodInfoPtr_OnCameraSetup_Public_Virtual_Void_CommandBuffer_byref_RenderingData_0;

		// Token: 0x0400120C RID: 4620
		private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_ScriptableRenderContext_byref_RenderingData_0;

		// Token: 0x0400120D RID: 4621
		private static readonly IntPtr NativeMethodInfoPtr_ExecutePass_Private_Static_Void_ScriptableRenderContext_PassData_byref_CommandBuffer_byref_CameraData_RTHandle_RTHandle_0;

		// Token: 0x0400120E RID: 4622
		private static readonly IntPtr NativeMethodInfoPtr_OnCameraCleanup_Public_Virtual_Void_CommandBuffer_0;

		// Token: 0x0400120F RID: 4623
		private static readonly IntPtr NativeMethodInfoPtr_Render_Internal_Void_RenderGraph_byref_TextureHandle_byref_TextureHandle_byref_RenderingData_0;

		// Token: 0x020001F1 RID: 497
		public class PassData : Object
		{
			// Token: 0x0600229F RID: 8863 RVA: 0x00083C70 File Offset: 0x00081E70
			// Note: this type is marked as 'beforefieldinit'.
			static PassData()
			{
				Il2CppClassPointerStore<CopyDepthPass.PassData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CopyDepthPass>.NativeClassPtr, "PassData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CopyDepthPass.PassData>.NativeClassPtr);
				CopyDepthPass.PassData.NativeFieldInfoPtr_source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CopyDepthPass.PassData>.NativeClassPtr, "source");
				CopyDepthPass.PassData.NativeFieldInfoPtr_destination = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CopyDepthPass.PassData>.NativeClassPtr, "destination");
				CopyDepthPass.PassData.NativeFieldInfoPtr_cmd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CopyDepthPass.PassData>.NativeClassPtr, "cmd");
				CopyDepthPass.PassData.NativeFieldInfoPtr_cameraData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CopyDepthPass.PassData>.NativeClassPtr, "cameraData");
				CopyDepthPass.PassData.NativeFieldInfoPtr_copyDepthMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CopyDepthPass.PassData>.NativeClassPtr, "copyDepthMaterial");
				CopyDepthPass.PassData.NativeFieldInfoPtr_msaaSamples = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CopyDepthPass.PassData>.NativeClassPtr, "msaaSamples");
				CopyDepthPass.PassData.NativeFieldInfoPtr_copyResolvedDepth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CopyDepthPass.PassData>.NativeClassPtr, "copyResolvedDepth");
				CopyDepthPass.PassData.NativeFieldInfoPtr_copyToDepth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CopyDepthPass.PassData>.NativeClassPtr, "copyToDepth");
				CopyDepthPass.PassData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopyDepthPass.PassData>.NativeClassPtr, 100666211);
			}

			// Token: 0x060022A0 RID: 8864 RVA: 0x00083D50 File Offset: 0x00081F50
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe PassData()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CopyDepthPass.PassData>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CopyDepthPass.PassData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060022A1 RID: 8865 RVA: 0x00013C73 File Offset: 0x00011E73
			public PassData(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000C84 RID: 3204
			// (get) Token: 0x060022A2 RID: 8866 RVA: 0x00083D8C File Offset: 0x00081F8C
			// (set) Token: 0x060022A3 RID: 8867 RVA: 0x00013C7C File Offset: 0x00011E7C
			public unsafe TextureHandle source
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CopyDepthPass.PassData.NativeFieldInfoPtr_source);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CopyDepthPass.PassData.NativeFieldInfoPtr_source)) = value;
				}
			}

			// Token: 0x17000C85 RID: 3205
			// (get) Token: 0x060022A4 RID: 8868 RVA: 0x00083DB4 File Offset: 0x00081FB4
			// (set) Token: 0x060022A5 RID: 8869 RVA: 0x00013C97 File Offset: 0x00011E97
			public unsafe TextureHandle destination
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CopyDepthPass.PassData.NativeFieldInfoPtr_destination);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CopyDepthPass.PassData.NativeFieldInfoPtr_destination)) = value;
				}
			}

			// Token: 0x17000C86 RID: 3206
			// (get) Token: 0x060022A6 RID: 8870 RVA: 0x00083DDC File Offset: 0x00081FDC
			// (set) Token: 0x060022A7 RID: 8871 RVA: 0x00013CB2 File Offset: 0x00011EB2
			public unsafe CommandBuffer cmd
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CopyDepthPass.PassData.NativeFieldInfoPtr_cmd);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CommandBuffer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CopyDepthPass.PassData.NativeFieldInfoPtr_cmd), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000C87 RID: 3207
			// (get) Token: 0x060022A8 RID: 8872 RVA: 0x00083E0C File Offset: 0x0008200C
			// (set) Token: 0x060022A9 RID: 8873 RVA: 0x00013CD1 File Offset: 0x00011ED1
			public CameraData cameraData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CopyDepthPass.PassData.NativeFieldInfoPtr_cameraData);
					return new CameraData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CameraData>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CopyDepthPass.PassData.NativeFieldInfoPtr_cameraData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CameraData>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000C88 RID: 3208
			// (get) Token: 0x060022AA RID: 8874 RVA: 0x00083E3C File Offset: 0x0008203C
			// (set) Token: 0x060022AB RID: 8875 RVA: 0x00013CFF File Offset: 0x00011EFF
			public unsafe Material copyDepthMaterial
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CopyDepthPass.PassData.NativeFieldInfoPtr_copyDepthMaterial);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CopyDepthPass.PassData.NativeFieldInfoPtr_copyDepthMaterial), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000C89 RID: 3209
			// (get) Token: 0x060022AC RID: 8876 RVA: 0x00083E6C File Offset: 0x0008206C
			// (set) Token: 0x060022AD RID: 8877 RVA: 0x00013D1E File Offset: 0x00011F1E
			public unsafe int msaaSamples
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CopyDepthPass.PassData.NativeFieldInfoPtr_msaaSamples);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CopyDepthPass.PassData.NativeFieldInfoPtr_msaaSamples)) = value;
				}
			}

			// Token: 0x17000C8A RID: 3210
			// (get) Token: 0x060022AE RID: 8878 RVA: 0x00083E94 File Offset: 0x00082094
			// (set) Token: 0x060022AF RID: 8879 RVA: 0x00013D39 File Offset: 0x00011F39
			public unsafe bool copyResolvedDepth
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CopyDepthPass.PassData.NativeFieldInfoPtr_copyResolvedDepth);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CopyDepthPass.PassData.NativeFieldInfoPtr_copyResolvedDepth)) = value;
				}
			}

			// Token: 0x17000C8B RID: 3211
			// (get) Token: 0x060022B0 RID: 8880 RVA: 0x00083EBC File Offset: 0x000820BC
			// (set) Token: 0x060022B1 RID: 8881 RVA: 0x00013D54 File Offset: 0x00011F54
			public unsafe bool copyToDepth
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CopyDepthPass.PassData.NativeFieldInfoPtr_copyToDepth);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CopyDepthPass.PassData.NativeFieldInfoPtr_copyToDepth)) = value;
				}
			}

			// Token: 0x0400185A RID: 6234
			private static readonly IntPtr NativeFieldInfoPtr_source;

			// Token: 0x0400185B RID: 6235
			private static readonly IntPtr NativeFieldInfoPtr_destination;

			// Token: 0x0400185C RID: 6236
			private static readonly IntPtr NativeFieldInfoPtr_cmd;

			// Token: 0x0400185D RID: 6237
			private static readonly IntPtr NativeFieldInfoPtr_cameraData;

			// Token: 0x0400185E RID: 6238
			private static readonly IntPtr NativeFieldInfoPtr_copyDepthMaterial;

			// Token: 0x0400185F RID: 6239
			private static readonly IntPtr NativeFieldInfoPtr_msaaSamples;

			// Token: 0x04001860 RID: 6240
			private static readonly IntPtr NativeFieldInfoPtr_copyResolvedDepth;

			// Token: 0x04001861 RID: 6241
			private static readonly IntPtr NativeFieldInfoPtr_copyToDepth;

			// Token: 0x04001862 RID: 6242
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020001F2 RID: 498
		[ObfuscatedName("UnityEngine.Rendering.Universal.Internal.CopyDepthPass+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x060022B2 RID: 8882 RVA: 0x00083EE4 File Offset: 0x000820E4
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<CopyDepthPass.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CopyDepthPass>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CopyDepthPass.__c>.NativeClassPtr);
				CopyDepthPass.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CopyDepthPass.__c>.NativeClassPtr, "<>9");
				CopyDepthPass.__c.NativeFieldInfoPtr___9__27_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CopyDepthPass.__c>.NativeClassPtr, "<>9__27_0");
				CopyDepthPass.__c.NativeFieldInfoPtr___9__27_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CopyDepthPass.__c>.NativeClassPtr, "<>9__27_1");
				CopyDepthPass.__c.NativeFieldInfoPtr___9__27_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CopyDepthPass.__c>.NativeClassPtr, "<>9__27_2");
				CopyDepthPass.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopyDepthPass.__c>.NativeClassPtr, 100666213);
				CopyDepthPass.__c.NativeMethodInfoPtr__Render_b__27_0_Internal_Void_PassData_RenderGraphContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopyDepthPass.__c>.NativeClassPtr, 100666214);
				CopyDepthPass.__c.NativeMethodInfoPtr__Render_b__27_1_Internal_Void_PassData_RenderGraphContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopyDepthPass.__c>.NativeClassPtr, 100666215);
				CopyDepthPass.__c.NativeMethodInfoPtr__Render_b__27_2_Internal_Void_PassData_RenderGraphContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopyDepthPass.__c>.NativeClassPtr, 100666216);
			}

			// Token: 0x060022B3 RID: 8883 RVA: 0x00083FB0 File Offset: 0x000821B0
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CopyDepthPass.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CopyDepthPass.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060022B4 RID: 8884 RVA: 0x00083FEC File Offset: 0x000821EC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 626973, XrefRangeEnd = 626980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Render_b__27_0(CopyDepthPass.PassData data, RenderGraphContext context)
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CopyDepthPass.__c.NativeMethodInfoPtr__Render_b__27_0_Internal_Void_PassData_RenderGraphContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060022B5 RID: 8885 RVA: 0x00084040 File Offset: 0x00082240
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 626980, XrefRangeEnd = 626986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Render_b__27_1(CopyDepthPass.PassData data, RenderGraphContext context)
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CopyDepthPass.__c.NativeMethodInfoPtr__Render_b__27_1_Internal_Void_PassData_RenderGraphContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060022B6 RID: 8886 RVA: 0x00084094 File Offset: 0x00082294
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 626986, XrefRangeEnd = 626993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Render_b__27_2(CopyDepthPass.PassData data, RenderGraphContext context)
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CopyDepthPass.__c.NativeMethodInfoPtr__Render_b__27_2_Internal_Void_PassData_RenderGraphContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060022B7 RID: 8887 RVA: 0x00013D6F File Offset: 0x00011F6F
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000C8C RID: 3212
			// (get) Token: 0x060022B8 RID: 8888 RVA: 0x000840E8 File Offset: 0x000822E8
			// (set) Token: 0x060022B9 RID: 8889 RVA: 0x00013D78 File Offset: 0x00011F78
			public unsafe static CopyDepthPass.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CopyDepthPass.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CopyDepthPass.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CopyDepthPass.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000C8D RID: 3213
			// (get) Token: 0x060022BA RID: 8890 RVA: 0x00084110 File Offset: 0x00082310
			// (set) Token: 0x060022BB RID: 8891 RVA: 0x00013D8A File Offset: 0x00011F8A
			public unsafe static RenderFunc<CopyDepthPass.PassData> __9__27_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CopyDepthPass.__c.NativeFieldInfoPtr___9__27_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderFunc<CopyDepthPass.PassData>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CopyDepthPass.__c.NativeFieldInfoPtr___9__27_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000C8E RID: 3214
			// (get) Token: 0x060022BC RID: 8892 RVA: 0x00084138 File Offset: 0x00082338
			// (set) Token: 0x060022BD RID: 8893 RVA: 0x00013D9C File Offset: 0x00011F9C
			public unsafe static RenderFunc<CopyDepthPass.PassData> __9__27_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CopyDepthPass.__c.NativeFieldInfoPtr___9__27_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderFunc<CopyDepthPass.PassData>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CopyDepthPass.__c.NativeFieldInfoPtr___9__27_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000C8F RID: 3215
			// (get) Token: 0x060022BE RID: 8894 RVA: 0x00084160 File Offset: 0x00082360
			// (set) Token: 0x060022BF RID: 8895 RVA: 0x00013DAE File Offset: 0x00011FAE
			public unsafe static RenderFunc<CopyDepthPass.PassData> __9__27_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CopyDepthPass.__c.NativeFieldInfoPtr___9__27_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderFunc<CopyDepthPass.PassData>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CopyDepthPass.__c.NativeFieldInfoPtr___9__27_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001863 RID: 6243
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04001864 RID: 6244
			private static readonly IntPtr NativeFieldInfoPtr___9__27_0;

			// Token: 0x04001865 RID: 6245
			private static readonly IntPtr NativeFieldInfoPtr___9__27_1;

			// Token: 0x04001866 RID: 6246
			private static readonly IntPtr NativeFieldInfoPtr___9__27_2;

			// Token: 0x04001867 RID: 6247
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001868 RID: 6248
			private static readonly IntPtr NativeMethodInfoPtr__Render_b__27_0_Internal_Void_PassData_RenderGraphContext_0;

			// Token: 0x04001869 RID: 6249
			private static readonly IntPtr NativeMethodInfoPtr__Render_b__27_1_Internal_Void_PassData_RenderGraphContext_0;

			// Token: 0x0400186A RID: 6250
			private static readonly IntPtr NativeMethodInfoPtr__Render_b__27_2_Internal_Void_PassData_RenderGraphContext_0;
		}
	}
}
