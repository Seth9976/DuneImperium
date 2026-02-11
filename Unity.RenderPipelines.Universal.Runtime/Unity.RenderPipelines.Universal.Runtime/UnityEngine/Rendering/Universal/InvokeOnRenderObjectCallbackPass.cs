using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Experimental.Rendering.RenderGraphModule;

namespace UnityEngine.Rendering.Universal
{
	// Token: 0x020000B0 RID: 176
	public class InvokeOnRenderObjectCallbackPass : ScriptableRenderPass
	{
		// Token: 0x06000DCA RID: 3530 RVA: 0x00045254 File Offset: 0x00043454
		// Note: this type is marked as 'beforefieldinit'.
		static InvokeOnRenderObjectCallbackPass()
		{
			Il2CppClassPointerStore<InvokeOnRenderObjectCallbackPass>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "InvokeOnRenderObjectCallbackPass");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InvokeOnRenderObjectCallbackPass>.NativeClassPtr);
			InvokeOnRenderObjectCallbackPass.NativeMethodInfoPtr__ctor_Public_Void_RenderPassEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvokeOnRenderObjectCallbackPass>.NativeClassPtr, 100665095);
			InvokeOnRenderObjectCallbackPass.NativeMethodInfoPtr_Execute_Public_Virtual_Void_ScriptableRenderContext_byref_RenderingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvokeOnRenderObjectCallbackPass>.NativeClassPtr, 100665096);
			InvokeOnRenderObjectCallbackPass.NativeMethodInfoPtr_Render_Internal_Void_RenderGraph_TextureHandle_TextureHandle_byref_RenderingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvokeOnRenderObjectCallbackPass>.NativeClassPtr, 100665097);
		}

		// Token: 0x06000DCB RID: 3531 RVA: 0x000452C0 File Offset: 0x000434C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 612893, RefRangeEnd = 612894, XrefRangeStart = 612882, XrefRangeEnd = 612893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InvokeOnRenderObjectCallbackPass(RenderPassEvent evt)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InvokeOnRenderObjectCallbackPass>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref evt;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InvokeOnRenderObjectCallbackPass.NativeMethodInfoPtr__ctor_Public_Void_RenderPassEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000DCC RID: 3532 RVA: 0x00045308 File Offset: 0x00043508
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 612894, XrefRangeEnd = 612898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InvokeOnRenderObjectCallbackPass.NativeMethodInfoPtr_Execute_Public_Virtual_Void_ScriptableRenderContext_byref_RenderingData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DCD RID: 3533 RVA: 0x00045364 File Offset: 0x00043564
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 612927, RefRangeEnd = 612928, XrefRangeStart = 612898, XrefRangeEnd = 612927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Render(RenderGraph renderGraph, TextureHandle colorTarget, TextureHandle depthTarget, ref RenderingData renderingData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(renderGraph);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref colorTarget;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depthTarget;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(renderingData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InvokeOnRenderObjectCallbackPass.NativeMethodInfoPtr_Render_Internal_Void_RenderGraph_TextureHandle_TextureHandle_byref_RenderingData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DCE RID: 3534 RVA: 0x00008859 File Offset: 0x00006A59
		public InvokeOnRenderObjectCallbackPass(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000A14 RID: 2580
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_RenderPassEvent_0;

		// Token: 0x04000A15 RID: 2581
		private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_ScriptableRenderContext_byref_RenderingData_0;

		// Token: 0x04000A16 RID: 2582
		private static readonly IntPtr NativeMethodInfoPtr_Render_Internal_Void_RenderGraph_TextureHandle_TextureHandle_byref_RenderingData_0;

		// Token: 0x020001A5 RID: 421
		public class PassData : Object
		{
			// Token: 0x06001E7E RID: 7806 RVA: 0x0007A4A8 File Offset: 0x000786A8
			// Note: this type is marked as 'beforefieldinit'.
			static PassData()
			{
				Il2CppClassPointerStore<InvokeOnRenderObjectCallbackPass.PassData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InvokeOnRenderObjectCallbackPass>.NativeClassPtr, "PassData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InvokeOnRenderObjectCallbackPass.PassData>.NativeClassPtr);
				InvokeOnRenderObjectCallbackPass.PassData.NativeFieldInfoPtr_colorTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InvokeOnRenderObjectCallbackPass.PassData>.NativeClassPtr, "colorTarget");
				InvokeOnRenderObjectCallbackPass.PassData.NativeFieldInfoPtr_depthTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InvokeOnRenderObjectCallbackPass.PassData>.NativeClassPtr, "depthTarget");
				InvokeOnRenderObjectCallbackPass.PassData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvokeOnRenderObjectCallbackPass.PassData>.NativeClassPtr, 100665098);
			}

			// Token: 0x06001E7F RID: 7807 RVA: 0x0007A510 File Offset: 0x00078710
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe PassData()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InvokeOnRenderObjectCallbackPass.PassData>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InvokeOnRenderObjectCallbackPass.PassData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001E80 RID: 7808 RVA: 0x000117AD File Offset: 0x0000F9AD
			public PassData(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000AE6 RID: 2790
			// (get) Token: 0x06001E81 RID: 7809 RVA: 0x0007A54C File Offset: 0x0007874C
			// (set) Token: 0x06001E82 RID: 7810 RVA: 0x000117B6 File Offset: 0x0000F9B6
			public unsafe TextureHandle colorTarget
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InvokeOnRenderObjectCallbackPass.PassData.NativeFieldInfoPtr_colorTarget);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InvokeOnRenderObjectCallbackPass.PassData.NativeFieldInfoPtr_colorTarget)) = value;
				}
			}

			// Token: 0x17000AE7 RID: 2791
			// (get) Token: 0x06001E83 RID: 7811 RVA: 0x0007A574 File Offset: 0x00078774
			// (set) Token: 0x06001E84 RID: 7812 RVA: 0x000117D1 File Offset: 0x0000F9D1
			public unsafe TextureHandle depthTarget
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InvokeOnRenderObjectCallbackPass.PassData.NativeFieldInfoPtr_depthTarget);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InvokeOnRenderObjectCallbackPass.PassData.NativeFieldInfoPtr_depthTarget)) = value;
				}
			}

			// Token: 0x040015E6 RID: 5606
			private static readonly IntPtr NativeFieldInfoPtr_colorTarget;

			// Token: 0x040015E7 RID: 5607
			private static readonly IntPtr NativeFieldInfoPtr_depthTarget;

			// Token: 0x040015E8 RID: 5608
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020001A6 RID: 422
		[ObfuscatedName("UnityEngine.Rendering.Universal.InvokeOnRenderObjectCallbackPass+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06001E85 RID: 7813 RVA: 0x0007A59C File Offset: 0x0007879C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<InvokeOnRenderObjectCallbackPass.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InvokeOnRenderObjectCallbackPass>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InvokeOnRenderObjectCallbackPass.__c>.NativeClassPtr);
				InvokeOnRenderObjectCallbackPass.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InvokeOnRenderObjectCallbackPass.__c>.NativeClassPtr, "<>9");
				InvokeOnRenderObjectCallbackPass.__c.NativeFieldInfoPtr___9__3_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InvokeOnRenderObjectCallbackPass.__c>.NativeClassPtr, "<>9__3_0");
				InvokeOnRenderObjectCallbackPass.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvokeOnRenderObjectCallbackPass.__c>.NativeClassPtr, 100665100);
				InvokeOnRenderObjectCallbackPass.__c.NativeMethodInfoPtr__Render_b__3_0_Internal_Void_PassData_RenderGraphContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvokeOnRenderObjectCallbackPass.__c>.NativeClassPtr, 100665101);
			}

			// Token: 0x06001E86 RID: 7814 RVA: 0x0007A618 File Offset: 0x00078818
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InvokeOnRenderObjectCallbackPass.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InvokeOnRenderObjectCallbackPass.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001E87 RID: 7815 RVA: 0x0007A654 File Offset: 0x00078854
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 612877, XrefRangeEnd = 612882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Render_b__3_0(InvokeOnRenderObjectCallbackPass.PassData data, RenderGraphContext context)
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InvokeOnRenderObjectCallbackPass.__c.NativeMethodInfoPtr__Render_b__3_0_Internal_Void_PassData_RenderGraphContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001E88 RID: 7816 RVA: 0x000117EC File Offset: 0x0000F9EC
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000AE8 RID: 2792
			// (get) Token: 0x06001E89 RID: 7817 RVA: 0x0007A6A8 File Offset: 0x000788A8
			// (set) Token: 0x06001E8A RID: 7818 RVA: 0x000117F5 File Offset: 0x0000F9F5
			public unsafe static InvokeOnRenderObjectCallbackPass.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(InvokeOnRenderObjectCallbackPass.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<InvokeOnRenderObjectCallbackPass.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(InvokeOnRenderObjectCallbackPass.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000AE9 RID: 2793
			// (get) Token: 0x06001E8B RID: 7819 RVA: 0x0007A6D0 File Offset: 0x000788D0
			// (set) Token: 0x06001E8C RID: 7820 RVA: 0x00011807 File Offset: 0x0000FA07
			public unsafe static RenderFunc<InvokeOnRenderObjectCallbackPass.PassData> __9__3_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(InvokeOnRenderObjectCallbackPass.__c.NativeFieldInfoPtr___9__3_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderFunc<InvokeOnRenderObjectCallbackPass.PassData>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(InvokeOnRenderObjectCallbackPass.__c.NativeFieldInfoPtr___9__3_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040015E9 RID: 5609
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040015EA RID: 5610
			private static readonly IntPtr NativeFieldInfoPtr___9__3_0;

			// Token: 0x040015EB RID: 5611
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040015EC RID: 5612
			private static readonly IntPtr NativeMethodInfoPtr__Render_b__3_0_Internal_Void_PassData_RenderGraphContext_0;
		}
	}
}
