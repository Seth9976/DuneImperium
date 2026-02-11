using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.Rendering.Universal
{
	// Token: 0x020000AC RID: 172
	public class CapturePass : ScriptableRenderPass
	{
		// Token: 0x06000D91 RID: 3473 RVA: 0x00044410 File Offset: 0x00042610
		// Note: this type is marked as 'beforefieldinit'.
		static CapturePass()
		{
			Il2CppClassPointerStore<CapturePass>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "CapturePass");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CapturePass>.NativeClassPtr);
			CapturePass.NativeFieldInfoPtr_m_CameraColorHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CapturePass>.NativeClassPtr, "m_CameraColorHandle");
			CapturePass.NativeFieldInfoPtr_m_ProfilerTag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CapturePass>.NativeClassPtr, "m_ProfilerTag");
			CapturePass.NativeFieldInfoPtr_m_ProfilingSampler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CapturePass>.NativeClassPtr, "m_ProfilingSampler");
			CapturePass.NativeMethodInfoPtr__ctor_Public_Void_RenderPassEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CapturePass>.NativeClassPtr, 100665057);
			CapturePass.NativeMethodInfoPtr_Execute_Public_Virtual_Void_ScriptableRenderContext_byref_RenderingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CapturePass>.NativeClassPtr, 100665058);
		}

		// Token: 0x06000D92 RID: 3474 RVA: 0x000444A4 File Offset: 0x000426A4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 612404, RefRangeEnd = 612405, XrefRangeStart = 612393, XrefRangeEnd = 612404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CapturePass(RenderPassEvent evt)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CapturePass>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref evt;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CapturePass.NativeMethodInfoPtr__ctor_Public_Void_RenderPassEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000D93 RID: 3475 RVA: 0x000444EC File Offset: 0x000426EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 612405, XrefRangeEnd = 612426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CapturePass.NativeMethodInfoPtr_Execute_Public_Virtual_Void_ScriptableRenderContext_byref_RenderingData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D94 RID: 3476 RVA: 0x000086E3 File Offset: 0x000068E3
		public CapturePass(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004FC RID: 1276
		// (get) Token: 0x06000D95 RID: 3477 RVA: 0x00044548 File Offset: 0x00042748
		// (set) Token: 0x06000D96 RID: 3478 RVA: 0x000086EC File Offset: 0x000068EC
		public unsafe RTHandle m_CameraColorHandle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CapturePass.NativeFieldInfoPtr_m_CameraColorHandle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RTHandle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CapturePass.NativeFieldInfoPtr_m_CameraColorHandle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004FD RID: 1277
		// (get) Token: 0x06000D97 RID: 3479 RVA: 0x00044578 File Offset: 0x00042778
		// (set) Token: 0x06000D98 RID: 3480 RVA: 0x0000870B File Offset: 0x0000690B
		public unsafe static string m_ProfilerTag
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CapturePass.NativeFieldInfoPtr_m_ProfilerTag, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CapturePass.NativeFieldInfoPtr_m_ProfilerTag, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170004FE RID: 1278
		// (get) Token: 0x06000D99 RID: 3481 RVA: 0x00044598 File Offset: 0x00042798
		// (set) Token: 0x06000D9A RID: 3482 RVA: 0x0000871D File Offset: 0x0000691D
		public unsafe static ProfilingSampler m_ProfilingSampler
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CapturePass.NativeFieldInfoPtr_m_ProfilingSampler, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProfilingSampler>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CapturePass.NativeFieldInfoPtr_m_ProfilingSampler, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040009EF RID: 2543
		private static readonly IntPtr NativeFieldInfoPtr_m_CameraColorHandle;

		// Token: 0x040009F0 RID: 2544
		private static readonly IntPtr NativeFieldInfoPtr_m_ProfilerTag;

		// Token: 0x040009F1 RID: 2545
		private static readonly IntPtr NativeFieldInfoPtr_m_ProfilingSampler;

		// Token: 0x040009F2 RID: 2546
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_RenderPassEvent_0;

		// Token: 0x040009F3 RID: 2547
		private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_ScriptableRenderContext_byref_RenderingData_0;
	}
}
