using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Rendering;

namespace UnityEngine.Experimental.Rendering.RenderGraphModule
{
	// Token: 0x02000010 RID: 16
	public sealed class RenderGraphParameters : ValueType
	{
		// Token: 0x06000141 RID: 321 RVA: 0x00011F04 File Offset: 0x00010104
		// Note: this type is marked as 'beforefieldinit'.
		static RenderGraphParameters()
		{
			Il2CppClassPointerStore<RenderGraphParameters>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Experimental.Rendering.RenderGraphModule", "RenderGraphParameters");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RenderGraphParameters>.NativeClassPtr);
			RenderGraphParameters.NativeFieldInfoPtr_executionName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraphParameters>.NativeClassPtr, "executionName");
			RenderGraphParameters.NativeFieldInfoPtr_currentFrameIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraphParameters>.NativeClassPtr, "currentFrameIndex");
			RenderGraphParameters.NativeFieldInfoPtr_rendererListCulling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraphParameters>.NativeClassPtr, "rendererListCulling");
			RenderGraphParameters.NativeFieldInfoPtr_scriptableRenderContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraphParameters>.NativeClassPtr, "scriptableRenderContext");
			RenderGraphParameters.NativeFieldInfoPtr_commandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraphParameters>.NativeClassPtr, "commandBuffer");
		}

		// Token: 0x06000142 RID: 322 RVA: 0x000028CD File Offset: 0x00000ACD
		public RenderGraphParameters(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000143 RID: 323 RVA: 0x000028D6 File Offset: 0x00000AD6
		public RenderGraphParameters()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RenderGraphParameters>.NativeClassPtr))
		{
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x06000144 RID: 324 RVA: 0x00011F98 File Offset: 0x00010198
		// (set) Token: 0x06000145 RID: 325 RVA: 0x000028E8 File Offset: 0x00000AE8
		public unsafe string executionName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraphParameters.NativeFieldInfoPtr_executionName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraphParameters.NativeFieldInfoPtr_executionName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x06000146 RID: 326 RVA: 0x00011FC0 File Offset: 0x000101C0
		// (set) Token: 0x06000147 RID: 327 RVA: 0x00002907 File Offset: 0x00000B07
		public unsafe int currentFrameIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraphParameters.NativeFieldInfoPtr_currentFrameIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraphParameters.NativeFieldInfoPtr_currentFrameIndex)) = value;
			}
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x06000148 RID: 328 RVA: 0x00011FE8 File Offset: 0x000101E8
		// (set) Token: 0x06000149 RID: 329 RVA: 0x00002922 File Offset: 0x00000B22
		public unsafe bool rendererListCulling
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraphParameters.NativeFieldInfoPtr_rendererListCulling);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraphParameters.NativeFieldInfoPtr_rendererListCulling)) = value;
			}
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x0600014A RID: 330 RVA: 0x00012010 File Offset: 0x00010210
		// (set) Token: 0x0600014B RID: 331 RVA: 0x0000293D File Offset: 0x00000B3D
		public unsafe ScriptableRenderContext scriptableRenderContext
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraphParameters.NativeFieldInfoPtr_scriptableRenderContext);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraphParameters.NativeFieldInfoPtr_scriptableRenderContext)) = value;
			}
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x0600014C RID: 332 RVA: 0x00012038 File Offset: 0x00010238
		// (set) Token: 0x0600014D RID: 333 RVA: 0x00002958 File Offset: 0x00000B58
		public unsafe CommandBuffer commandBuffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraphParameters.NativeFieldInfoPtr_commandBuffer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CommandBuffer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraphParameters.NativeFieldInfoPtr_commandBuffer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040000D1 RID: 209
		private static readonly IntPtr NativeFieldInfoPtr_executionName;

		// Token: 0x040000D2 RID: 210
		private static readonly IntPtr NativeFieldInfoPtr_currentFrameIndex;

		// Token: 0x040000D3 RID: 211
		private static readonly IntPtr NativeFieldInfoPtr_rendererListCulling;

		// Token: 0x040000D4 RID: 212
		private static readonly IntPtr NativeFieldInfoPtr_scriptableRenderContext;

		// Token: 0x040000D5 RID: 213
		private static readonly IntPtr NativeFieldInfoPtr_commandBuffer;
	}
}
