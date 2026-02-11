using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine.Rendering;
using UnityEngine.Rendering.RendererUtils;

namespace UnityEngine.Experimental.Rendering.RenderGraphModule
{
	// Token: 0x02000027 RID: 39
	public sealed class RendererListResource : ValueType
	{
		// Token: 0x06000397 RID: 919 RVA: 0x0001B220 File Offset: 0x00019420
		// Note: this type is marked as 'beforefieldinit'.
		static RendererListResource()
		{
			Il2CppClassPointerStore<RendererListResource>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Experimental.Rendering.RenderGraphModule", "RendererListResource");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RendererListResource>.NativeClassPtr);
			RendererListResource.NativeFieldInfoPtr_desc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RendererListResource>.NativeClassPtr, "desc");
			RendererListResource.NativeFieldInfoPtr_rendererList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RendererListResource>.NativeClassPtr, "rendererList");
			RendererListResource.NativeMethodInfoPtr__ctor_Internal_Void_byref_RendererListDesc_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RendererListResource>.NativeClassPtr, 100663775);
		}

		// Token: 0x06000398 RID: 920 RVA: 0x0001B28C File Offset: 0x0001948C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 958427, RefRangeEnd = 958429, XrefRangeStart = 958426, XrefRangeEnd = 958427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RendererListResource([In] ref RendererListDesc desc)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RendererListResource>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(desc);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RendererListResource.NativeMethodInfoPtr__ctor_Internal_Void_byref_RendererListDesc_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000399 RID: 921 RVA: 0x000036BB File Offset: 0x000018BB
		public RendererListResource(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600039A RID: 922 RVA: 0x000036C4 File Offset: 0x000018C4
		public RendererListResource()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RendererListResource>.NativeClassPtr))
		{
		}

		// Token: 0x17000106 RID: 262
		// (get) Token: 0x0600039B RID: 923 RVA: 0x0001B2E0 File Offset: 0x000194E0
		// (set) Token: 0x0600039C RID: 924 RVA: 0x000036D6 File Offset: 0x000018D6
		public RendererListDesc desc
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RendererListResource.NativeFieldInfoPtr_desc);
				return new RendererListDesc(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RendererListDesc>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RendererListResource.NativeFieldInfoPtr_desc), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<RendererListDesc>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000107 RID: 263
		// (get) Token: 0x0600039D RID: 925 RVA: 0x0001B310 File Offset: 0x00019510
		// (set) Token: 0x0600039E RID: 926 RVA: 0x00003704 File Offset: 0x00001904
		public unsafe RendererList rendererList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RendererListResource.NativeFieldInfoPtr_rendererList);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RendererListResource.NativeFieldInfoPtr_rendererList)) = value;
			}
		}

		// Token: 0x04000288 RID: 648
		private static readonly IntPtr NativeFieldInfoPtr_desc;

		// Token: 0x04000289 RID: 649
		private static readonly IntPtr NativeFieldInfoPtr_rendererList;

		// Token: 0x0400028A RID: 650
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_byref_RendererListDesc_0;
	}
}
