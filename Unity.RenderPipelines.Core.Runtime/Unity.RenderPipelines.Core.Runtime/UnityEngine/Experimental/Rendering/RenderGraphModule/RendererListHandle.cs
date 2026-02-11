using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine.Rendering;

namespace UnityEngine.Experimental.Rendering.RenderGraphModule
{
	// Token: 0x02000026 RID: 38
	[StructLayout(2)]
	public struct RendererListHandle
	{
		// Token: 0x0600038F RID: 911 RVA: 0x0001B008 File Offset: 0x00019208
		// Note: this type is marked as 'beforefieldinit'.
		static RendererListHandle()
		{
			Il2CppClassPointerStore<RendererListHandle>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Experimental.Rendering.RenderGraphModule", "RendererListHandle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RendererListHandle>.NativeClassPtr);
			RendererListHandle.NativeFieldInfoPtr_m_IsValid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RendererListHandle>.NativeClassPtr, "m_IsValid");
			RendererListHandle.NativeFieldInfoPtr__handle_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RendererListHandle>.NativeClassPtr, "<handle>k__BackingField");
			RendererListHandle.NativeMethodInfoPtr_get_handle_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RendererListHandle>.NativeClassPtr, 100663769);
			RendererListHandle.NativeMethodInfoPtr_set_handle_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RendererListHandle>.NativeClassPtr, 100663770);
			RendererListHandle.NativeMethodInfoPtr__ctor_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RendererListHandle>.NativeClassPtr, 100663771);
			RendererListHandle.NativeMethodInfoPtr_op_Implicit_Public_Static_Int32_RendererListHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RendererListHandle>.NativeClassPtr, 100663772);
			RendererListHandle.NativeMethodInfoPtr_op_Implicit_Public_Static_RendererList_RendererListHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RendererListHandle>.NativeClassPtr, 100663773);
			RendererListHandle.NativeMethodInfoPtr_IsValid_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RendererListHandle>.NativeClassPtr, 100663774);
		}

		// Token: 0x17000105 RID: 261
		// (get) Token: 0x06000390 RID: 912 RVA: 0x0001B0D8 File Offset: 0x000192D8
		// (set) Token: 0x06000391 RID: 913 RVA: 0x0001B108 File Offset: 0x00019308
		public unsafe int handle
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RendererListHandle.NativeMethodInfoPtr_get_handle_Internal_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 320170, RefRangeEnd = 320176, XrefRangeStart = 320170, XrefRangeEnd = 320176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RendererListHandle.NativeMethodInfoPtr_set_handle_Private_set_Void_Int32_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000392 RID: 914 RVA: 0x0001B13C File Offset: 0x0001933C
		[CallerCount(2754)]
		[CachedScanResults(RefRangeStart = 787572, RefRangeEnd = 790326, XrefRangeStart = 787572, XrefRangeEnd = 790326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RendererListHandle(int handle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RendererListHandle.NativeMethodInfoPtr__ctor_Internal_Void_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000393 RID: 915 RVA: 0x0001B170 File Offset: 0x00019370
		[CallerCount(0)]
		public unsafe static implicit operator int(RendererListHandle handle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RendererListHandle.NativeMethodInfoPtr_op_Implicit_Public_Static_Int32_RendererListHandle_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000394 RID: 916 RVA: 0x0001B1B0 File Offset: 0x000193B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 958418, XrefRangeEnd = 958426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator RendererList(RendererListHandle rendererList)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref rendererList;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RendererListHandle.NativeMethodInfoPtr_op_Implicit_Public_Static_RendererList_RendererListHandle_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000395 RID: 917 RVA: 0x0001B1F0 File Offset: 0x000193F0
		[CallerCount(45)]
		[CachedScanResults(RefRangeStart = 441993, RefRangeEnd = 442038, XrefRangeStart = 441993, XrefRangeEnd = 442038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsValid()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RendererListHandle.NativeMethodInfoPtr_IsValid_Public_Boolean_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000396 RID: 918 RVA: 0x000036A9 File Offset: 0x000018A9
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RendererListHandle>.NativeClassPtr, ref this));
		}

		// Token: 0x0400027E RID: 638
		private static readonly IntPtr NativeFieldInfoPtr_m_IsValid;

		// Token: 0x0400027F RID: 639
		private static readonly IntPtr NativeFieldInfoPtr__handle_k__BackingField;

		// Token: 0x04000280 RID: 640
		private static readonly IntPtr NativeMethodInfoPtr_get_handle_Internal_get_Int32_0;

		// Token: 0x04000281 RID: 641
		private static readonly IntPtr NativeMethodInfoPtr_set_handle_Private_set_Void_Int32_0;

		// Token: 0x04000282 RID: 642
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Int32_0;

		// Token: 0x04000283 RID: 643
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Int32_RendererListHandle_0;

		// Token: 0x04000284 RID: 644
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_RendererList_RendererListHandle_0;

		// Token: 0x04000285 RID: 645
		private static readonly IntPtr NativeMethodInfoPtr_IsValid_Public_Boolean_0;

		// Token: 0x04000286 RID: 646
		[FieldOffset(0)]
		[MarshalAs(4)]
		public bool m_IsValid;

		// Token: 0x04000287 RID: 647
		[FieldOffset(4)]
		public int _handle_k__BackingField;
	}
}
