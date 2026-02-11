using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Experimental.Rendering.RenderGraphModule;

namespace UnityEngine.Rendering.Universal.Internal
{
	// Token: 0x0200011C RID: 284
	public class ColorGradingLutPass : ScriptableRenderPass
	{
		// Token: 0x06001897 RID: 6295 RVA: 0x00067A88 File Offset: 0x00065C88
		// Note: this type is marked as 'beforefieldinit'.
		static ColorGradingLutPass()
		{
			Il2CppClassPointerStore<ColorGradingLutPass>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal.Internal", "ColorGradingLutPass");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ColorGradingLutPass>.NativeClassPtr);
			ColorGradingLutPass.NativeFieldInfoPtr_m_LutBuilderLdr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingLutPass>.NativeClassPtr, "m_LutBuilderLdr");
			ColorGradingLutPass.NativeFieldInfoPtr_m_LutBuilderHdr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingLutPass>.NativeClassPtr, "m_LutBuilderHdr");
			ColorGradingLutPass.NativeFieldInfoPtr_m_HdrLutFormat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingLutPass>.NativeClassPtr, "m_HdrLutFormat");
			ColorGradingLutPass.NativeFieldInfoPtr_m_LdrLutFormat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingLutPass>.NativeClassPtr, "m_LdrLutFormat");
			ColorGradingLutPass.NativeFieldInfoPtr_m_PassData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingLutPass>.NativeClassPtr, "m_PassData");
			ColorGradingLutPass.NativeFieldInfoPtr_m_InternalLut = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingLutPass>.NativeClassPtr, "m_InternalLut");
			ColorGradingLutPass.NativeFieldInfoPtr_m_AllowColorGradingACESHDR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingLutPass>.NativeClassPtr, "m_AllowColorGradingACESHDR");
			ColorGradingLutPass.NativeMethodInfoPtr__ctor_Public_Void_RenderPassEvent_PostProcessData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorGradingLutPass>.NativeClassPtr, 100666163);
			ColorGradingLutPass.NativeMethodInfoPtr_Setup_Public_Void_byref_RTHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorGradingLutPass>.NativeClassPtr, 100666164);
			ColorGradingLutPass.NativeMethodInfoPtr_ConfigureDescriptor_Public_Void_byref_PostProcessingData_byref_RenderTextureDescriptor_byref_FilterMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorGradingLutPass>.NativeClassPtr, 100666165);
			ColorGradingLutPass.NativeMethodInfoPtr_Execute_Public_Virtual_Void_ScriptableRenderContext_byref_RenderingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorGradingLutPass>.NativeClassPtr, 100666166);
			ColorGradingLutPass.NativeMethodInfoPtr_ExecutePass_Private_Static_Void_ScriptableRenderContext_PassData_byref_RenderingData_RTHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorGradingLutPass>.NativeClassPtr, 100666167);
			ColorGradingLutPass.NativeMethodInfoPtr_Render_Internal_Void_RenderGraph_byref_TextureHandle_byref_RenderingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorGradingLutPass>.NativeClassPtr, 100666168);
			ColorGradingLutPass.NativeMethodInfoPtr_Cleanup_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorGradingLutPass>.NativeClassPtr, 100666169);
			ColorGradingLutPass.NativeMethodInfoPtr_Method_Internal_Static_Material_Shader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorGradingLutPass>.NativeClassPtr, 100666170);
		}

		// Token: 0x06001898 RID: 6296 RVA: 0x00067BE4 File Offset: 0x00065DE4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 626545, RefRangeEnd = 626546, XrefRangeStart = 626510, XrefRangeEnd = 626545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ColorGradingLutPass(RenderPassEvent evt, PostProcessData data)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ColorGradingLutPass>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref evt;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorGradingLutPass.NativeMethodInfoPtr__ctor_Public_Void_RenderPassEvent_PostProcessData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001899 RID: 6297 RVA: 0x00067C40 File Offset: 0x00065E40
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 626547, RefRangeEnd = 626549, XrefRangeStart = 626546, XrefRangeEnd = 626547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Setup([In] ref RTHandle internalLut)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(internalLut);
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ColorGradingLutPass.NativeMethodInfoPtr_Setup_Public_Void_byref_RTHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				internalLut = ((intPtr4 == 0) ? null : new RTHandle(intPtr4));
			}
		}

		// Token: 0x0600189A RID: 6298 RVA: 0x00067C98 File Offset: 0x00065E98
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 626551, RefRangeEnd = 626553, XrefRangeStart = 626549, XrefRangeEnd = 626551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConfigureDescriptor([In] ref PostProcessingData postProcessingData, out RenderTextureDescriptor descriptor, out FilterMode filterMode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &postProcessingData;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &descriptor;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &filterMode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorGradingLutPass.NativeMethodInfoPtr_ConfigureDescriptor_Public_Void_byref_PostProcessingData_byref_RenderTextureDescriptor_byref_FilterMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600189B RID: 6299 RVA: 0x00067CF4 File Offset: 0x00065EF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 626553, XrefRangeEnd = 626562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ColorGradingLutPass.NativeMethodInfoPtr_Execute_Public_Virtual_Void_ScriptableRenderContext_byref_RenderingData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600189C RID: 6300 RVA: 0x00067D50 File Offset: 0x00065F50
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 626701, RefRangeEnd = 626703, XrefRangeStart = 626562, XrefRangeEnd = 626701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ExecutePass(ScriptableRenderContext context, ColorGradingLutPass.PassData passData, ref RenderingData renderingData, RTHandle internalLutTarget)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref context;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(passData);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(renderingData);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(internalLutTarget);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorGradingLutPass.NativeMethodInfoPtr_ExecutePass_Private_Static_Void_ScriptableRenderContext_PassData_byref_RenderingData_RTHandle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600189D RID: 6301 RVA: 0x00067DBC File Offset: 0x00065FBC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 626742, RefRangeEnd = 626743, XrefRangeStart = 626703, XrefRangeEnd = 626742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Render(RenderGraph renderGraph, out TextureHandle internalColorLut, ref RenderingData renderingData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(renderGraph);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &internalColorLut;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(renderingData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorGradingLutPass.NativeMethodInfoPtr_Render_Internal_Void_RenderGraph_byref_TextureHandle_byref_RenderingData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600189E RID: 6302 RVA: 0x00067E20 File Offset: 0x00066020
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 626748, RefRangeEnd = 626750, XrefRangeStart = 626743, XrefRangeEnd = 626748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Cleanup()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorGradingLutPass.NativeMethodInfoPtr_Cleanup_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600189F RID: 6303 RVA: 0x00067E54 File Offset: 0x00066054
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 626764, RefRangeEnd = 626766, XrefRangeStart = 626750, XrefRangeEnd = 626764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Material Method_Internal_Static_Material_Shader_0(Shader shader)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(shader);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorGradingLutPass.NativeMethodInfoPtr_Method_Internal_Static_Material_Shader_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
			}
		}

		// Token: 0x060018A0 RID: 6304 RVA: 0x0000E07B File Offset: 0x0000C27B
		public ColorGradingLutPass(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000908 RID: 2312
		// (get) Token: 0x060018A1 RID: 6305 RVA: 0x00067E98 File Offset: 0x00066098
		// (set) Token: 0x060018A2 RID: 6306 RVA: 0x0000E084 File Offset: 0x0000C284
		public unsafe Material m_LutBuilderLdr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGradingLutPass.NativeFieldInfoPtr_m_LutBuilderLdr);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGradingLutPass.NativeFieldInfoPtr_m_LutBuilderLdr), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000909 RID: 2313
		// (get) Token: 0x060018A3 RID: 6307 RVA: 0x00067EC8 File Offset: 0x000660C8
		// (set) Token: 0x060018A4 RID: 6308 RVA: 0x0000E0A3 File Offset: 0x0000C2A3
		public unsafe Material m_LutBuilderHdr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGradingLutPass.NativeFieldInfoPtr_m_LutBuilderHdr);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGradingLutPass.NativeFieldInfoPtr_m_LutBuilderHdr), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700090A RID: 2314
		// (get) Token: 0x060018A5 RID: 6309 RVA: 0x00067EF8 File Offset: 0x000660F8
		// (set) Token: 0x060018A6 RID: 6310 RVA: 0x0000E0C2 File Offset: 0x0000C2C2
		public unsafe GraphicsFormat m_HdrLutFormat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGradingLutPass.NativeFieldInfoPtr_m_HdrLutFormat);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGradingLutPass.NativeFieldInfoPtr_m_HdrLutFormat)) = value;
			}
		}

		// Token: 0x1700090B RID: 2315
		// (get) Token: 0x060018A7 RID: 6311 RVA: 0x00067F20 File Offset: 0x00066120
		// (set) Token: 0x060018A8 RID: 6312 RVA: 0x0000E0DD File Offset: 0x0000C2DD
		public unsafe GraphicsFormat m_LdrLutFormat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGradingLutPass.NativeFieldInfoPtr_m_LdrLutFormat);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGradingLutPass.NativeFieldInfoPtr_m_LdrLutFormat)) = value;
			}
		}

		// Token: 0x1700090C RID: 2316
		// (get) Token: 0x060018A9 RID: 6313 RVA: 0x00067F48 File Offset: 0x00066148
		// (set) Token: 0x060018AA RID: 6314 RVA: 0x0000E0F8 File Offset: 0x0000C2F8
		public unsafe ColorGradingLutPass.PassData m_PassData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGradingLutPass.NativeFieldInfoPtr_m_PassData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ColorGradingLutPass.PassData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGradingLutPass.NativeFieldInfoPtr_m_PassData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700090D RID: 2317
		// (get) Token: 0x060018AB RID: 6315 RVA: 0x00067F78 File Offset: 0x00066178
		// (set) Token: 0x060018AC RID: 6316 RVA: 0x0000E117 File Offset: 0x0000C317
		public unsafe RTHandle m_InternalLut
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGradingLutPass.NativeFieldInfoPtr_m_InternalLut);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RTHandle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGradingLutPass.NativeFieldInfoPtr_m_InternalLut), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700090E RID: 2318
		// (get) Token: 0x060018AD RID: 6317 RVA: 0x00067FA8 File Offset: 0x000661A8
		// (set) Token: 0x060018AE RID: 6318 RVA: 0x0000E136 File Offset: 0x0000C336
		public unsafe bool m_AllowColorGradingACESHDR
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGradingLutPass.NativeFieldInfoPtr_m_AllowColorGradingACESHDR);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGradingLutPass.NativeFieldInfoPtr_m_AllowColorGradingACESHDR)) = value;
			}
		}

		// Token: 0x040011D3 RID: 4563
		private static readonly IntPtr NativeFieldInfoPtr_m_LutBuilderLdr;

		// Token: 0x040011D4 RID: 4564
		private static readonly IntPtr NativeFieldInfoPtr_m_LutBuilderHdr;

		// Token: 0x040011D5 RID: 4565
		private static readonly IntPtr NativeFieldInfoPtr_m_HdrLutFormat;

		// Token: 0x040011D6 RID: 4566
		private static readonly IntPtr NativeFieldInfoPtr_m_LdrLutFormat;

		// Token: 0x040011D7 RID: 4567
		private static readonly IntPtr NativeFieldInfoPtr_m_PassData;

		// Token: 0x040011D8 RID: 4568
		private static readonly IntPtr NativeFieldInfoPtr_m_InternalLut;

		// Token: 0x040011D9 RID: 4569
		private static readonly IntPtr NativeFieldInfoPtr_m_AllowColorGradingACESHDR;

		// Token: 0x040011DA RID: 4570
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_RenderPassEvent_PostProcessData_0;

		// Token: 0x040011DB RID: 4571
		private static readonly IntPtr NativeMethodInfoPtr_Setup_Public_Void_byref_RTHandle_0;

		// Token: 0x040011DC RID: 4572
		private static readonly IntPtr NativeMethodInfoPtr_ConfigureDescriptor_Public_Void_byref_PostProcessingData_byref_RenderTextureDescriptor_byref_FilterMode_0;

		// Token: 0x040011DD RID: 4573
		private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_ScriptableRenderContext_byref_RenderingData_0;

		// Token: 0x040011DE RID: 4574
		private static readonly IntPtr NativeMethodInfoPtr_ExecutePass_Private_Static_Void_ScriptableRenderContext_PassData_byref_RenderingData_RTHandle_0;

		// Token: 0x040011DF RID: 4575
		private static readonly IntPtr NativeMethodInfoPtr_Render_Internal_Void_RenderGraph_byref_TextureHandle_byref_RenderingData_0;

		// Token: 0x040011E0 RID: 4576
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Public_Void_0;

		// Token: 0x040011E1 RID: 4577
		private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Static_Material_Shader_0;

		// Token: 0x020001EC RID: 492
		public class PassData : Object
		{
			// Token: 0x06002234 RID: 8756 RVA: 0x00082F80 File Offset: 0x00081180
			// Note: this type is marked as 'beforefieldinit'.
			static PassData()
			{
				Il2CppClassPointerStore<ColorGradingLutPass.PassData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ColorGradingLutPass>.NativeClassPtr, "PassData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ColorGradingLutPass.PassData>.NativeClassPtr);
				ColorGradingLutPass.PassData.NativeFieldInfoPtr_renderingData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingLutPass.PassData>.NativeClassPtr, "renderingData");
				ColorGradingLutPass.PassData.NativeFieldInfoPtr_lutBuilderLdr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingLutPass.PassData>.NativeClassPtr, "lutBuilderLdr");
				ColorGradingLutPass.PassData.NativeFieldInfoPtr_lutBuilderHdr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingLutPass.PassData>.NativeClassPtr, "lutBuilderHdr");
				ColorGradingLutPass.PassData.NativeFieldInfoPtr_allowColorGradingACESHDR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingLutPass.PassData>.NativeClassPtr, "allowColorGradingACESHDR");
				ColorGradingLutPass.PassData.NativeFieldInfoPtr_internalLut = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingLutPass.PassData>.NativeClassPtr, "internalLut");
				ColorGradingLutPass.PassData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorGradingLutPass.PassData>.NativeClassPtr, 100666171);
			}

			// Token: 0x06002235 RID: 8757 RVA: 0x00083024 File Offset: 0x00081224
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe PassData()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ColorGradingLutPass.PassData>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorGradingLutPass.PassData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002236 RID: 8758 RVA: 0x000138C5 File Offset: 0x00011AC5
			public PassData(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000C57 RID: 3159
			// (get) Token: 0x06002237 RID: 8759 RVA: 0x00083060 File Offset: 0x00081260
			// (set) Token: 0x06002238 RID: 8760 RVA: 0x000138CE File Offset: 0x00011ACE
			public RenderingData renderingData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGradingLutPass.PassData.NativeFieldInfoPtr_renderingData);
					return new RenderingData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RenderingData>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGradingLutPass.PassData.NativeFieldInfoPtr_renderingData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<RenderingData>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000C58 RID: 3160
			// (get) Token: 0x06002239 RID: 8761 RVA: 0x00083090 File Offset: 0x00081290
			// (set) Token: 0x0600223A RID: 8762 RVA: 0x000138FC File Offset: 0x00011AFC
			public unsafe Material lutBuilderLdr
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGradingLutPass.PassData.NativeFieldInfoPtr_lutBuilderLdr);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGradingLutPass.PassData.NativeFieldInfoPtr_lutBuilderLdr), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000C59 RID: 3161
			// (get) Token: 0x0600223B RID: 8763 RVA: 0x000830C0 File Offset: 0x000812C0
			// (set) Token: 0x0600223C RID: 8764 RVA: 0x0001391B File Offset: 0x00011B1B
			public unsafe Material lutBuilderHdr
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGradingLutPass.PassData.NativeFieldInfoPtr_lutBuilderHdr);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGradingLutPass.PassData.NativeFieldInfoPtr_lutBuilderHdr), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000C5A RID: 3162
			// (get) Token: 0x0600223D RID: 8765 RVA: 0x000830F0 File Offset: 0x000812F0
			// (set) Token: 0x0600223E RID: 8766 RVA: 0x0001393A File Offset: 0x00011B3A
			public unsafe bool allowColorGradingACESHDR
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGradingLutPass.PassData.NativeFieldInfoPtr_allowColorGradingACESHDR);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGradingLutPass.PassData.NativeFieldInfoPtr_allowColorGradingACESHDR)) = value;
				}
			}

			// Token: 0x17000C5B RID: 3163
			// (get) Token: 0x0600223F RID: 8767 RVA: 0x00083118 File Offset: 0x00081318
			// (set) Token: 0x06002240 RID: 8768 RVA: 0x00013955 File Offset: 0x00011B55
			public unsafe TextureHandle internalLut
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGradingLutPass.PassData.NativeFieldInfoPtr_internalLut);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGradingLutPass.PassData.NativeFieldInfoPtr_internalLut)) = value;
				}
			}

			// Token: 0x04001826 RID: 6182
			private static readonly IntPtr NativeFieldInfoPtr_renderingData;

			// Token: 0x04001827 RID: 6183
			private static readonly IntPtr NativeFieldInfoPtr_lutBuilderLdr;

			// Token: 0x04001828 RID: 6184
			private static readonly IntPtr NativeFieldInfoPtr_lutBuilderHdr;

			// Token: 0x04001829 RID: 6185
			private static readonly IntPtr NativeFieldInfoPtr_allowColorGradingACESHDR;

			// Token: 0x0400182A RID: 6186
			private static readonly IntPtr NativeFieldInfoPtr_internalLut;

			// Token: 0x0400182B RID: 6187
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020001ED RID: 493
		public static class ShaderConstants : Object
		{
			// Token: 0x06002241 RID: 8769 RVA: 0x00083140 File Offset: 0x00081340
			// Note: this type is marked as 'beforefieldinit'.
			static ShaderConstants()
			{
				Il2CppClassPointerStore<ColorGradingLutPass.ShaderConstants>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ColorGradingLutPass>.NativeClassPtr, "ShaderConstants");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ColorGradingLutPass.ShaderConstants>.NativeClassPtr);
				ColorGradingLutPass.ShaderConstants.NativeFieldInfoPtr__Lut_Params = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingLutPass.ShaderConstants>.NativeClassPtr, "_Lut_Params");
				ColorGradingLutPass.ShaderConstants.NativeFieldInfoPtr__ColorBalance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingLutPass.ShaderConstants>.NativeClassPtr, "_ColorBalance");
				ColorGradingLutPass.ShaderConstants.NativeFieldInfoPtr__ColorFilter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingLutPass.ShaderConstants>.NativeClassPtr, "_ColorFilter");
				ColorGradingLutPass.ShaderConstants.NativeFieldInfoPtr__ChannelMixerRed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingLutPass.ShaderConstants>.NativeClassPtr, "_ChannelMixerRed");
				ColorGradingLutPass.ShaderConstants.NativeFieldInfoPtr__ChannelMixerGreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingLutPass.ShaderConstants>.NativeClassPtr, "_ChannelMixerGreen");
				ColorGradingLutPass.ShaderConstants.NativeFieldInfoPtr__ChannelMixerBlue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingLutPass.ShaderConstants>.NativeClassPtr, "_ChannelMixerBlue");
				ColorGradingLutPass.ShaderConstants.NativeFieldInfoPtr__HueSatCon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingLutPass.ShaderConstants>.NativeClassPtr, "_HueSatCon");
				ColorGradingLutPass.ShaderConstants.NativeFieldInfoPtr__Lift = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingLutPass.ShaderConstants>.NativeClassPtr, "_Lift");
				ColorGradingLutPass.ShaderConstants.NativeFieldInfoPtr__Gamma = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingLutPass.ShaderConstants>.NativeClassPtr, "_Gamma");
				ColorGradingLutPass.ShaderConstants.NativeFieldInfoPtr__Gain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingLutPass.ShaderConstants>.NativeClassPtr, "_Gain");
				ColorGradingLutPass.ShaderConstants.NativeFieldInfoPtr__Shadows = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingLutPass.ShaderConstants>.NativeClassPtr, "_Shadows");
				ColorGradingLutPass.ShaderConstants.NativeFieldInfoPtr__Midtones = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingLutPass.ShaderConstants>.NativeClassPtr, "_Midtones");
				ColorGradingLutPass.ShaderConstants.NativeFieldInfoPtr__Highlights = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingLutPass.ShaderConstants>.NativeClassPtr, "_Highlights");
				ColorGradingLutPass.ShaderConstants.NativeFieldInfoPtr__ShaHiLimits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingLutPass.ShaderConstants>.NativeClassPtr, "_ShaHiLimits");
				ColorGradingLutPass.ShaderConstants.NativeFieldInfoPtr__SplitShadows = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingLutPass.ShaderConstants>.NativeClassPtr, "_SplitShadows");
				ColorGradingLutPass.ShaderConstants.NativeFieldInfoPtr__SplitHighlights = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingLutPass.ShaderConstants>.NativeClassPtr, "_SplitHighlights");
				ColorGradingLutPass.ShaderConstants.NativeFieldInfoPtr__CurveMaster = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingLutPass.ShaderConstants>.NativeClassPtr, "_CurveMaster");
				ColorGradingLutPass.ShaderConstants.NativeFieldInfoPtr__CurveRed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingLutPass.ShaderConstants>.NativeClassPtr, "_CurveRed");
				ColorGradingLutPass.ShaderConstants.NativeFieldInfoPtr__CurveGreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingLutPass.ShaderConstants>.NativeClassPtr, "_CurveGreen");
				ColorGradingLutPass.ShaderConstants.NativeFieldInfoPtr__CurveBlue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingLutPass.ShaderConstants>.NativeClassPtr, "_CurveBlue");
				ColorGradingLutPass.ShaderConstants.NativeFieldInfoPtr__CurveHueVsHue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingLutPass.ShaderConstants>.NativeClassPtr, "_CurveHueVsHue");
				ColorGradingLutPass.ShaderConstants.NativeFieldInfoPtr__CurveHueVsSat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingLutPass.ShaderConstants>.NativeClassPtr, "_CurveHueVsSat");
				ColorGradingLutPass.ShaderConstants.NativeFieldInfoPtr__CurveLumVsSat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingLutPass.ShaderConstants>.NativeClassPtr, "_CurveLumVsSat");
				ColorGradingLutPass.ShaderConstants.NativeFieldInfoPtr__CurveSatVsSat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingLutPass.ShaderConstants>.NativeClassPtr, "_CurveSatVsSat");
			}

			// Token: 0x06002242 RID: 8770 RVA: 0x00013970 File Offset: 0x00011B70
			public ShaderConstants(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000C5C RID: 3164
			// (get) Token: 0x06002243 RID: 8771 RVA: 0x0008334C File Offset: 0x0008154C
			// (set) Token: 0x06002244 RID: 8772 RVA: 0x00013979 File Offset: 0x00011B79
			public unsafe static int _Lut_Params
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(ColorGradingLutPass.ShaderConstants.NativeFieldInfoPtr__Lut_Params, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ColorGradingLutPass.ShaderConstants.NativeFieldInfoPtr__Lut_Params, (void*)(&value));
				}
			}

			// Token: 0x17000C5D RID: 3165
			// (get) Token: 0x06002245 RID: 8773 RVA: 0x00083368 File Offset: 0x00081568
			// (set) Token: 0x06002246 RID: 8774 RVA: 0x00013987 File Offset: 0x00011B87
			public unsafe static int _ColorBalance
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(ColorGradingLutPass.ShaderConstants.NativeFieldInfoPtr__ColorBalance, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ColorGradingLutPass.ShaderConstants.NativeFieldInfoPtr__ColorBalance, (void*)(&value));
				}
			}

			// Token: 0x17000C5E RID: 3166
			// (get) Token: 0x06002247 RID: 8775 RVA: 0x00083384 File Offset: 0x00081584
			// (set) Token: 0x06002248 RID: 8776 RVA: 0x00013995 File Offset: 0x00011B95
			public unsafe static int _ColorFilter
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(ColorGradingLutPass.ShaderConstants.NativeFieldInfoPtr__ColorFilter, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ColorGradingLutPass.ShaderConstants.NativeFieldInfoPtr__ColorFilter, (void*)(&value));
				}
			}

			// Token: 0x17000C5F RID: 3167
			// (get) Token: 0x06002249 RID: 8777 RVA: 0x000833A0 File Offset: 0x000815A0
			// (set) Token: 0x0600224A RID: 8778 RVA: 0x000139A3 File Offset: 0x00011BA3
			public unsafe static int _ChannelMixerRed
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(ColorGradingLutPass.ShaderConstants.NativeFieldInfoPtr__ChannelMixerRed, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ColorGradingLutPass.ShaderConstants.NativeFieldInfoPtr__ChannelMixerRed, (void*)(&value));
				}
			}

			// Token: 0x17000C60 RID: 3168
			// (get) Token: 0x0600224B RID: 8779 RVA: 0x000833BC File Offset: 0x000815BC
			// (set) Token: 0x0600224C RID: 8780 RVA: 0x000139B1 File Offset: 0x00011BB1
			public unsafe static int _ChannelMixerGreen
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(ColorGradingLutPass.ShaderConstants.NativeFieldInfoPtr__ChannelMixerGreen, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ColorGradingLutPass.ShaderConstants.NativeFieldInfoPtr__ChannelMixerGreen, (void*)(&value));
				}
			}

			// Token: 0x17000C61 RID: 3169
			// (get) Token: 0x0600224D RID: 8781 RVA: 0x000833D8 File Offset: 0x000815D8
			// (set) Token: 0x0600224E RID: 8782 RVA: 0x000139BF File Offset: 0x00011BBF
			public unsafe static int _ChannelMixerBlue
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(ColorGradingLutPass.ShaderConstants.NativeFieldInfoPtr__ChannelMixerBlue, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ColorGradingLutPass.ShaderConstants.NativeFieldInfoPtr__ChannelMixerBlue, (void*)(&value));
				}
			}

			// Token: 0x17000C62 RID: 3170
			// (get) Token: 0x0600224F RID: 8783 RVA: 0x000833F4 File Offset: 0x000815F4
			// (set) Token: 0x06002250 RID: 8784 RVA: 0x000139CD File Offset: 0x00011BCD
			public unsafe static int _HueSatCon
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(ColorGradingLutPass.ShaderConstants.NativeFieldInfoPtr__HueSatCon, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ColorGradingLutPass.ShaderConstants.NativeFieldInfoPtr__HueSatCon, (void*)(&value));
				}
			}

			// Token: 0x17000C63 RID: 3171
			// (get) Token: 0x06002251 RID: 8785 RVA: 0x00083410 File Offset: 0x00081610
			// (set) Token: 0x06002252 RID: 8786 RVA: 0x000139DB File Offset: 0x00011BDB
			public unsafe static int _Lift
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(ColorGradingLutPass.ShaderConstants.NativeFieldInfoPtr__Lift, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ColorGradingLutPass.ShaderConstants.NativeFieldInfoPtr__Lift, (void*)(&value));
				}
			}

			// Token: 0x17000C64 RID: 3172
			// (get) Token: 0x06002253 RID: 8787 RVA: 0x0008342C File Offset: 0x0008162C
			// (set) Token: 0x06002254 RID: 8788 RVA: 0x000139E9 File Offset: 0x00011BE9
			public unsafe static int _Gamma
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(ColorGradingLutPass.ShaderConstants.NativeFieldInfoPtr__Gamma, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ColorGradingLutPass.ShaderConstants.NativeFieldInfoPtr__Gamma, (void*)(&value));
				}
			}

			// Token: 0x17000C65 RID: 3173
			// (get) Token: 0x06002255 RID: 8789 RVA: 0x00083448 File Offset: 0x00081648
			// (set) Token: 0x06002256 RID: 8790 RVA: 0x000139F7 File Offset: 0x00011BF7
			public unsafe static int _Gain
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(ColorGradingLutPass.ShaderConstants.NativeFieldInfoPtr__Gain, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ColorGradingLutPass.ShaderConstants.NativeFieldInfoPtr__Gain, (void*)(&value));
				}
			}

			// Token: 0x17000C66 RID: 3174
			// (get) Token: 0x06002257 RID: 8791 RVA: 0x00083464 File Offset: 0x00081664
			// (set) Token: 0x06002258 RID: 8792 RVA: 0x00013A05 File Offset: 0x00011C05
			public unsafe static int _Shadows
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(ColorGradingLutPass.ShaderConstants.NativeFieldInfoPtr__Shadows, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ColorGradingLutPass.ShaderConstants.NativeFieldInfoPtr__Shadows, (void*)(&value));
				}
			}

			// Token: 0x17000C67 RID: 3175
			// (get) Token: 0x06002259 RID: 8793 RVA: 0x00083480 File Offset: 0x00081680
			// (set) Token: 0x0600225A RID: 8794 RVA: 0x00013A13 File Offset: 0x00011C13
			public unsafe static int _Midtones
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(ColorGradingLutPass.ShaderConstants.NativeFieldInfoPtr__Midtones, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ColorGradingLutPass.ShaderConstants.NativeFieldInfoPtr__Midtones, (void*)(&value));
				}
			}

			// Token: 0x17000C68 RID: 3176
			// (get) Token: 0x0600225B RID: 8795 RVA: 0x0008349C File Offset: 0x0008169C
			// (set) Token: 0x0600225C RID: 8796 RVA: 0x00013A21 File Offset: 0x00011C21
			public unsafe static int _Highlights
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(ColorGradingLutPass.ShaderConstants.NativeFieldInfoPtr__Highlights, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ColorGradingLutPass.ShaderConstants.NativeFieldInfoPtr__Highlights, (void*)(&value));
				}
			}

			// Token: 0x17000C69 RID: 3177
			// (get) Token: 0x0600225D RID: 8797 RVA: 0x000834B8 File Offset: 0x000816B8
			// (set) Token: 0x0600225E RID: 8798 RVA: 0x00013A2F File Offset: 0x00011C2F
			public unsafe static int _ShaHiLimits
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(ColorGradingLutPass.ShaderConstants.NativeFieldInfoPtr__ShaHiLimits, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ColorGradingLutPass.ShaderConstants.NativeFieldInfoPtr__ShaHiLimits, (void*)(&value));
				}
			}

			// Token: 0x17000C6A RID: 3178
			// (get) Token: 0x0600225F RID: 8799 RVA: 0x000834D4 File Offset: 0x000816D4
			// (set) Token: 0x06002260 RID: 8800 RVA: 0x00013A3D File Offset: 0x00011C3D
			public unsafe static int _SplitShadows
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(ColorGradingLutPass.ShaderConstants.NativeFieldInfoPtr__SplitShadows, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ColorGradingLutPass.ShaderConstants.NativeFieldInfoPtr__SplitShadows, (void*)(&value));
				}
			}

			// Token: 0x17000C6B RID: 3179
			// (get) Token: 0x06002261 RID: 8801 RVA: 0x000834F0 File Offset: 0x000816F0
			// (set) Token: 0x06002262 RID: 8802 RVA: 0x00013A4B File Offset: 0x00011C4B
			public unsafe static int _SplitHighlights
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(ColorGradingLutPass.ShaderConstants.NativeFieldInfoPtr__SplitHighlights, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ColorGradingLutPass.ShaderConstants.NativeFieldInfoPtr__SplitHighlights, (void*)(&value));
				}
			}

			// Token: 0x17000C6C RID: 3180
			// (get) Token: 0x06002263 RID: 8803 RVA: 0x0008350C File Offset: 0x0008170C
			// (set) Token: 0x06002264 RID: 8804 RVA: 0x00013A59 File Offset: 0x00011C59
			public unsafe static int _CurveMaster
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(ColorGradingLutPass.ShaderConstants.NativeFieldInfoPtr__CurveMaster, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ColorGradingLutPass.ShaderConstants.NativeFieldInfoPtr__CurveMaster, (void*)(&value));
				}
			}

			// Token: 0x17000C6D RID: 3181
			// (get) Token: 0x06002265 RID: 8805 RVA: 0x00083528 File Offset: 0x00081728
			// (set) Token: 0x06002266 RID: 8806 RVA: 0x00013A67 File Offset: 0x00011C67
			public unsafe static int _CurveRed
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(ColorGradingLutPass.ShaderConstants.NativeFieldInfoPtr__CurveRed, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ColorGradingLutPass.ShaderConstants.NativeFieldInfoPtr__CurveRed, (void*)(&value));
				}
			}

			// Token: 0x17000C6E RID: 3182
			// (get) Token: 0x06002267 RID: 8807 RVA: 0x00083544 File Offset: 0x00081744
			// (set) Token: 0x06002268 RID: 8808 RVA: 0x00013A75 File Offset: 0x00011C75
			public unsafe static int _CurveGreen
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(ColorGradingLutPass.ShaderConstants.NativeFieldInfoPtr__CurveGreen, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ColorGradingLutPass.ShaderConstants.NativeFieldInfoPtr__CurveGreen, (void*)(&value));
				}
			}

			// Token: 0x17000C6F RID: 3183
			// (get) Token: 0x06002269 RID: 8809 RVA: 0x00083560 File Offset: 0x00081760
			// (set) Token: 0x0600226A RID: 8810 RVA: 0x00013A83 File Offset: 0x00011C83
			public unsafe static int _CurveBlue
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(ColorGradingLutPass.ShaderConstants.NativeFieldInfoPtr__CurveBlue, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ColorGradingLutPass.ShaderConstants.NativeFieldInfoPtr__CurveBlue, (void*)(&value));
				}
			}

			// Token: 0x17000C70 RID: 3184
			// (get) Token: 0x0600226B RID: 8811 RVA: 0x0008357C File Offset: 0x0008177C
			// (set) Token: 0x0600226C RID: 8812 RVA: 0x00013A91 File Offset: 0x00011C91
			public unsafe static int _CurveHueVsHue
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(ColorGradingLutPass.ShaderConstants.NativeFieldInfoPtr__CurveHueVsHue, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ColorGradingLutPass.ShaderConstants.NativeFieldInfoPtr__CurveHueVsHue, (void*)(&value));
				}
			}

			// Token: 0x17000C71 RID: 3185
			// (get) Token: 0x0600226D RID: 8813 RVA: 0x00083598 File Offset: 0x00081798
			// (set) Token: 0x0600226E RID: 8814 RVA: 0x00013A9F File Offset: 0x00011C9F
			public unsafe static int _CurveHueVsSat
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(ColorGradingLutPass.ShaderConstants.NativeFieldInfoPtr__CurveHueVsSat, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ColorGradingLutPass.ShaderConstants.NativeFieldInfoPtr__CurveHueVsSat, (void*)(&value));
				}
			}

			// Token: 0x17000C72 RID: 3186
			// (get) Token: 0x0600226F RID: 8815 RVA: 0x000835B4 File Offset: 0x000817B4
			// (set) Token: 0x06002270 RID: 8816 RVA: 0x00013AAD File Offset: 0x00011CAD
			public unsafe static int _CurveLumVsSat
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(ColorGradingLutPass.ShaderConstants.NativeFieldInfoPtr__CurveLumVsSat, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ColorGradingLutPass.ShaderConstants.NativeFieldInfoPtr__CurveLumVsSat, (void*)(&value));
				}
			}

			// Token: 0x17000C73 RID: 3187
			// (get) Token: 0x06002271 RID: 8817 RVA: 0x000835D0 File Offset: 0x000817D0
			// (set) Token: 0x06002272 RID: 8818 RVA: 0x00013ABB File Offset: 0x00011CBB
			public unsafe static int _CurveSatVsSat
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(ColorGradingLutPass.ShaderConstants.NativeFieldInfoPtr__CurveSatVsSat, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ColorGradingLutPass.ShaderConstants.NativeFieldInfoPtr__CurveSatVsSat, (void*)(&value));
				}
			}

			// Token: 0x0400182C RID: 6188
			private static readonly IntPtr NativeFieldInfoPtr__Lut_Params;

			// Token: 0x0400182D RID: 6189
			private static readonly IntPtr NativeFieldInfoPtr__ColorBalance;

			// Token: 0x0400182E RID: 6190
			private static readonly IntPtr NativeFieldInfoPtr__ColorFilter;

			// Token: 0x0400182F RID: 6191
			private static readonly IntPtr NativeFieldInfoPtr__ChannelMixerRed;

			// Token: 0x04001830 RID: 6192
			private static readonly IntPtr NativeFieldInfoPtr__ChannelMixerGreen;

			// Token: 0x04001831 RID: 6193
			private static readonly IntPtr NativeFieldInfoPtr__ChannelMixerBlue;

			// Token: 0x04001832 RID: 6194
			private static readonly IntPtr NativeFieldInfoPtr__HueSatCon;

			// Token: 0x04001833 RID: 6195
			private static readonly IntPtr NativeFieldInfoPtr__Lift;

			// Token: 0x04001834 RID: 6196
			private static readonly IntPtr NativeFieldInfoPtr__Gamma;

			// Token: 0x04001835 RID: 6197
			private static readonly IntPtr NativeFieldInfoPtr__Gain;

			// Token: 0x04001836 RID: 6198
			private static readonly IntPtr NativeFieldInfoPtr__Shadows;

			// Token: 0x04001837 RID: 6199
			private static readonly IntPtr NativeFieldInfoPtr__Midtones;

			// Token: 0x04001838 RID: 6200
			private static readonly IntPtr NativeFieldInfoPtr__Highlights;

			// Token: 0x04001839 RID: 6201
			private static readonly IntPtr NativeFieldInfoPtr__ShaHiLimits;

			// Token: 0x0400183A RID: 6202
			private static readonly IntPtr NativeFieldInfoPtr__SplitShadows;

			// Token: 0x0400183B RID: 6203
			private static readonly IntPtr NativeFieldInfoPtr__SplitHighlights;

			// Token: 0x0400183C RID: 6204
			private static readonly IntPtr NativeFieldInfoPtr__CurveMaster;

			// Token: 0x0400183D RID: 6205
			private static readonly IntPtr NativeFieldInfoPtr__CurveRed;

			// Token: 0x0400183E RID: 6206
			private static readonly IntPtr NativeFieldInfoPtr__CurveGreen;

			// Token: 0x0400183F RID: 6207
			private static readonly IntPtr NativeFieldInfoPtr__CurveBlue;

			// Token: 0x04001840 RID: 6208
			private static readonly IntPtr NativeFieldInfoPtr__CurveHueVsHue;

			// Token: 0x04001841 RID: 6209
			private static readonly IntPtr NativeFieldInfoPtr__CurveHueVsSat;

			// Token: 0x04001842 RID: 6210
			private static readonly IntPtr NativeFieldInfoPtr__CurveLumVsSat;

			// Token: 0x04001843 RID: 6211
			private static readonly IntPtr NativeFieldInfoPtr__CurveSatVsSat;
		}

		// Token: 0x020001EE RID: 494
		[ObfuscatedName("UnityEngine.Rendering.Universal.Internal.ColorGradingLutPass+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06002273 RID: 8819 RVA: 0x000835EC File Offset: 0x000817EC
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<ColorGradingLutPass.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ColorGradingLutPass>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ColorGradingLutPass.__c>.NativeClassPtr);
				ColorGradingLutPass.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingLutPass.__c>.NativeClassPtr, "<>9");
				ColorGradingLutPass.__c.NativeFieldInfoPtr___9__13_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingLutPass.__c>.NativeClassPtr, "<>9__13_0");
				ColorGradingLutPass.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorGradingLutPass.__c>.NativeClassPtr, 100666174);
				ColorGradingLutPass.__c.NativeMethodInfoPtr__Render_b__13_0_Internal_Void_PassData_RenderGraphContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorGradingLutPass.__c>.NativeClassPtr, 100666175);
			}

			// Token: 0x06002274 RID: 8820 RVA: 0x00083668 File Offset: 0x00081868
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ColorGradingLutPass.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorGradingLutPass.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002275 RID: 8821 RVA: 0x000836A4 File Offset: 0x000818A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 626505, XrefRangeEnd = 626510, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Render_b__13_0(ColorGradingLutPass.PassData data, RenderGraphContext context)
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorGradingLutPass.__c.NativeMethodInfoPtr__Render_b__13_0_Internal_Void_PassData_RenderGraphContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002276 RID: 8822 RVA: 0x00013AC9 File Offset: 0x00011CC9
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000C74 RID: 3188
			// (get) Token: 0x06002277 RID: 8823 RVA: 0x000836F8 File Offset: 0x000818F8
			// (set) Token: 0x06002278 RID: 8824 RVA: 0x00013AD2 File Offset: 0x00011CD2
			public unsafe static ColorGradingLutPass.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ColorGradingLutPass.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ColorGradingLutPass.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ColorGradingLutPass.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000C75 RID: 3189
			// (get) Token: 0x06002279 RID: 8825 RVA: 0x00083720 File Offset: 0x00081920
			// (set) Token: 0x0600227A RID: 8826 RVA: 0x00013AE4 File Offset: 0x00011CE4
			public unsafe static RenderFunc<ColorGradingLutPass.PassData> __9__13_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ColorGradingLutPass.__c.NativeFieldInfoPtr___9__13_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderFunc<ColorGradingLutPass.PassData>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ColorGradingLutPass.__c.NativeFieldInfoPtr___9__13_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001844 RID: 6212
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04001845 RID: 6213
			private static readonly IntPtr NativeFieldInfoPtr___9__13_0;

			// Token: 0x04001846 RID: 6214
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001847 RID: 6215
			private static readonly IntPtr NativeMethodInfoPtr__Render_b__13_0_Internal_Void_PassData_RenderGraphContext_0;
		}
	}
}
