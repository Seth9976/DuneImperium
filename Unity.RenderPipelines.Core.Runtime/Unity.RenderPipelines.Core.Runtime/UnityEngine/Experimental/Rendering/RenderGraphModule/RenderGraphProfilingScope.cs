using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Rendering;

namespace UnityEngine.Experimental.Rendering.RenderGraphModule
{
	// Token: 0x02000016 RID: 22
	public sealed class RenderGraphProfilingScope : ValueType
	{
		// Token: 0x06000216 RID: 534 RVA: 0x00015074 File Offset: 0x00013274
		// Note: this type is marked as 'beforefieldinit'.
		static RenderGraphProfilingScope()
		{
			Il2CppClassPointerStore<RenderGraphProfilingScope>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Experimental.Rendering.RenderGraphModule", "RenderGraphProfilingScope");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RenderGraphProfilingScope>.NativeClassPtr);
			RenderGraphProfilingScope.NativeFieldInfoPtr_m_Disposed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraphProfilingScope>.NativeClassPtr, "m_Disposed");
			RenderGraphProfilingScope.NativeFieldInfoPtr_m_Sampler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraphProfilingScope>.NativeClassPtr, "m_Sampler");
			RenderGraphProfilingScope.NativeFieldInfoPtr_m_RenderGraph = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraphProfilingScope>.NativeClassPtr, "m_RenderGraph");
			RenderGraphProfilingScope.NativeMethodInfoPtr__ctor_Public_Void_RenderGraph_ProfilingSampler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphProfilingScope>.NativeClassPtr, 100663537);
			RenderGraphProfilingScope.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphProfilingScope>.NativeClassPtr, 100663538);
			RenderGraphProfilingScope.NativeMethodInfoPtr_Dispose_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphProfilingScope>.NativeClassPtr, 100663539);
		}

		// Token: 0x06000217 RID: 535 RVA: 0x0001511C File Offset: 0x0001331C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 956565, XrefRangeEnd = 956569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RenderGraphProfilingScope(RenderGraph renderGraph, ProfilingSampler sampler)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RenderGraphProfilingScope>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(renderGraph);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sampler);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraphProfilingScope.NativeMethodInfoPtr__ctor_Public_Void_RenderGraph_ProfilingSampler_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000218 RID: 536 RVA: 0x00015180 File Offset: 0x00013380
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 956569, XrefRangeEnd = 956570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraphProfilingScope.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000219 RID: 537 RVA: 0x000151B8 File Offset: 0x000133B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 956570, XrefRangeEnd = 956571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraphProfilingScope.NativeMethodInfoPtr_Dispose_Private_Void_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600021A RID: 538 RVA: 0x00002E5C File Offset: 0x0000105C
		public RenderGraphProfilingScope(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600021B RID: 539 RVA: 0x00002E65 File Offset: 0x00001065
		public RenderGraphProfilingScope()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RenderGraphProfilingScope>.NativeClassPtr))
		{
		}

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x0600021C RID: 540 RVA: 0x000151FC File Offset: 0x000133FC
		// (set) Token: 0x0600021D RID: 541 RVA: 0x00002E77 File Offset: 0x00001077
		public unsafe bool m_Disposed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraphProfilingScope.NativeFieldInfoPtr_m_Disposed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraphProfilingScope.NativeFieldInfoPtr_m_Disposed)) = value;
			}
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x0600021E RID: 542 RVA: 0x00015224 File Offset: 0x00013424
		// (set) Token: 0x0600021F RID: 543 RVA: 0x00002E92 File Offset: 0x00001092
		public unsafe ProfilingSampler m_Sampler
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraphProfilingScope.NativeFieldInfoPtr_m_Sampler);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProfilingSampler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraphProfilingScope.NativeFieldInfoPtr_m_Sampler), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x06000220 RID: 544 RVA: 0x00015254 File Offset: 0x00013454
		// (set) Token: 0x06000221 RID: 545 RVA: 0x00002EB1 File Offset: 0x000010B1
		public unsafe RenderGraph m_RenderGraph
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraphProfilingScope.NativeFieldInfoPtr_m_RenderGraph);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderGraph>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraphProfilingScope.NativeFieldInfoPtr_m_RenderGraph), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000166 RID: 358
		private static readonly IntPtr NativeFieldInfoPtr_m_Disposed;

		// Token: 0x04000167 RID: 359
		private static readonly IntPtr NativeFieldInfoPtr_m_Sampler;

		// Token: 0x04000168 RID: 360
		private static readonly IntPtr NativeFieldInfoPtr_m_RenderGraph;

		// Token: 0x04000169 RID: 361
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_RenderGraph_ProfilingSampler_0;

		// Token: 0x0400016A RID: 362
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x0400016B RID: 363
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Private_Void_Boolean_0;
	}
}
