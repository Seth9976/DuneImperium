using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.Rendering.Universal
{
	// Token: 0x0200002F RID: 47
	public class UpscalePass : ScriptableRenderPass
	{
		// Token: 0x06000388 RID: 904 RVA: 0x0002234C File Offset: 0x0002054C
		// Note: this type is marked as 'beforefieldinit'.
		static UpscalePass()
		{
			Il2CppClassPointerStore<UpscalePass>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "UpscalePass");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UpscalePass>.NativeClassPtr);
			UpscalePass.NativeFieldInfoPtr_m_ProfilingScope = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpscalePass>.NativeClassPtr, "m_ProfilingScope");
			UpscalePass.NativeFieldInfoPtr_m_Source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpscalePass>.NativeClassPtr, "m_Source");
			UpscalePass.NativeFieldInfoPtr_m_UpscaleHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpscalePass>.NativeClassPtr, "m_UpscaleHandle");
			UpscalePass.NativeFieldInfoPtr_m_BlitMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpscalePass>.NativeClassPtr, "m_BlitMaterial");
			UpscalePass.NativeMethodInfoPtr__ctor_Public_Void_RenderPassEvent_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpscalePass>.NativeClassPtr, 100663745);
			UpscalePass.NativeMethodInfoPtr_Setup_Public_Void_RTHandle_Int32_Int32_FilterMode_byref_RenderingData_byref_RTHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpscalePass>.NativeClassPtr, 100663746);
			UpscalePass.NativeMethodInfoPtr_Dispose_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpscalePass>.NativeClassPtr, 100663747);
			UpscalePass.NativeMethodInfoPtr_Execute_Public_Virtual_Void_ScriptableRenderContext_byref_RenderingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpscalePass>.NativeClassPtr, 100663748);
		}

		// Token: 0x06000389 RID: 905 RVA: 0x0002241C File Offset: 0x0002061C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 600819, XrefRangeEnd = 600829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UpscalePass(RenderPassEvent evt, Material blitMaterial)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UpscalePass>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref evt;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(blitMaterial);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UpscalePass.NativeMethodInfoPtr__ctor_Public_Void_RenderPassEvent_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600038A RID: 906 RVA: 0x00022478 File Offset: 0x00020678
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 600829, XrefRangeEnd = 600838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Setup(RTHandle colorTargetHandle, int width, int height, FilterMode mode, ref RenderingData renderingData, out RTHandle upscaleHandle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(colorTargetHandle);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref width;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mode;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(renderingData);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(UpscalePass.NativeMethodInfoPtr_Setup_Public_Void_RTHandle_Int32_Int32_FilterMode_byref_RenderingData_byref_RTHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			upscaleHandle = ((intPtr4 == 0) ? null : new RTHandle(intPtr4));
		}

		// Token: 0x0600038B RID: 907 RVA: 0x0002251C File Offset: 0x0002071C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 600839, RefRangeEnd = 600840, XrefRangeStart = 600838, XrefRangeEnd = 600839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UpscalePass.NativeMethodInfoPtr_Dispose_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600038C RID: 908 RVA: 0x00022550 File Offset: 0x00020750
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 600840, XrefRangeEnd = 600856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UpscalePass.NativeMethodInfoPtr_Execute_Public_Virtual_Void_ScriptableRenderContext_byref_RenderingData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600038D RID: 909 RVA: 0x00003837 File Offset: 0x00001A37
		public UpscalePass(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000121 RID: 289
		// (get) Token: 0x0600038E RID: 910 RVA: 0x000225AC File Offset: 0x000207AC
		// (set) Token: 0x0600038F RID: 911 RVA: 0x00003840 File Offset: 0x00001A40
		public unsafe static ProfilingSampler m_ProfilingScope
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(UpscalePass.NativeFieldInfoPtr_m_ProfilingScope, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProfilingSampler>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UpscalePass.NativeFieldInfoPtr_m_ProfilingScope, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000122 RID: 290
		// (get) Token: 0x06000390 RID: 912 RVA: 0x000225D4 File Offset: 0x000207D4
		// (set) Token: 0x06000391 RID: 913 RVA: 0x00003852 File Offset: 0x00001A52
		public unsafe RTHandle m_Source
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpscalePass.NativeFieldInfoPtr_m_Source);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RTHandle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpscalePass.NativeFieldInfoPtr_m_Source), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000123 RID: 291
		// (get) Token: 0x06000392 RID: 914 RVA: 0x00022604 File Offset: 0x00020804
		// (set) Token: 0x06000393 RID: 915 RVA: 0x00003871 File Offset: 0x00001A71
		public unsafe RTHandle m_UpscaleHandle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpscalePass.NativeFieldInfoPtr_m_UpscaleHandle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RTHandle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpscalePass.NativeFieldInfoPtr_m_UpscaleHandle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000124 RID: 292
		// (get) Token: 0x06000394 RID: 916 RVA: 0x00022634 File Offset: 0x00020834
		// (set) Token: 0x06000395 RID: 917 RVA: 0x00003890 File Offset: 0x00001A90
		public unsafe static Material m_BlitMaterial
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(UpscalePass.NativeFieldInfoPtr_m_BlitMaterial, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UpscalePass.NativeFieldInfoPtr_m_BlitMaterial, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040002B0 RID: 688
		private static readonly IntPtr NativeFieldInfoPtr_m_ProfilingScope;

		// Token: 0x040002B1 RID: 689
		private static readonly IntPtr NativeFieldInfoPtr_m_Source;

		// Token: 0x040002B2 RID: 690
		private static readonly IntPtr NativeFieldInfoPtr_m_UpscaleHandle;

		// Token: 0x040002B3 RID: 691
		private static readonly IntPtr NativeFieldInfoPtr_m_BlitMaterial;

		// Token: 0x040002B4 RID: 692
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_RenderPassEvent_Material_0;

		// Token: 0x040002B5 RID: 693
		private static readonly IntPtr NativeMethodInfoPtr_Setup_Public_Void_RTHandle_Int32_Int32_FilterMode_byref_RenderingData_byref_RTHandle_0;

		// Token: 0x040002B6 RID: 694
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Void_0;

		// Token: 0x040002B7 RID: 695
		private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_ScriptableRenderContext_byref_RenderingData_0;
	}
}
