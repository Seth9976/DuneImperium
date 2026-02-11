using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.Rendering.Universal
{
	// Token: 0x0200002D RID: 45
	public class PixelPerfectBackgroundPass : ScriptableRenderPass
	{
		// Token: 0x06000350 RID: 848 RVA: 0x000218C8 File Offset: 0x0001FAC8
		// Note: this type is marked as 'beforefieldinit'.
		static PixelPerfectBackgroundPass()
		{
			Il2CppClassPointerStore<PixelPerfectBackgroundPass>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "PixelPerfectBackgroundPass");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PixelPerfectBackgroundPass>.NativeClassPtr);
			PixelPerfectBackgroundPass.NativeFieldInfoPtr_m_ProfilingScope = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PixelPerfectBackgroundPass>.NativeClassPtr, "m_ProfilingScope");
			PixelPerfectBackgroundPass.NativeMethodInfoPtr__ctor_Public_Void_RenderPassEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PixelPerfectBackgroundPass>.NativeClassPtr, 100663728);
			PixelPerfectBackgroundPass.NativeMethodInfoPtr_Execute_Public_Virtual_Void_ScriptableRenderContext_byref_RenderingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PixelPerfectBackgroundPass>.NativeClassPtr, 100663729);
		}

		// Token: 0x06000351 RID: 849 RVA: 0x00021934 File Offset: 0x0001FB34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 600405, XrefRangeEnd = 600409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PixelPerfectBackgroundPass(RenderPassEvent evt)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PixelPerfectBackgroundPass>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref evt;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PixelPerfectBackgroundPass.NativeMethodInfoPtr__ctor_Public_Void_RenderPassEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000352 RID: 850 RVA: 0x0002197C File Offset: 0x0001FB7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 600409, XrefRangeEnd = 600422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PixelPerfectBackgroundPass.NativeMethodInfoPtr_Execute_Public_Virtual_Void_ScriptableRenderContext_byref_RenderingData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000353 RID: 851 RVA: 0x000036A0 File Offset: 0x000018A0
		public PixelPerfectBackgroundPass(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700010C RID: 268
		// (get) Token: 0x06000354 RID: 852 RVA: 0x000219D8 File Offset: 0x0001FBD8
		// (set) Token: 0x06000355 RID: 853 RVA: 0x000036A9 File Offset: 0x000018A9
		public unsafe static ProfilingSampler m_ProfilingScope
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PixelPerfectBackgroundPass.NativeFieldInfoPtr_m_ProfilingScope, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProfilingSampler>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PixelPerfectBackgroundPass.NativeFieldInfoPtr_m_ProfilingScope, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000290 RID: 656
		private static readonly IntPtr NativeFieldInfoPtr_m_ProfilingScope;

		// Token: 0x04000291 RID: 657
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_RenderPassEvent_0;

		// Token: 0x04000292 RID: 658
		private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_ScriptableRenderContext_byref_RenderingData_0;
	}
}
