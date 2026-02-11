using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.Rendering
{
	// Token: 0x020000AB RID: 171
	public class RenderPipelineResources : ScriptableObject
	{
		// Token: 0x06000C6E RID: 3182 RVA: 0x0003A05C File Offset: 0x0003825C
		// Note: this type is marked as 'beforefieldinit'.
		static RenderPipelineResources()
		{
			Il2CppClassPointerStore<RenderPipelineResources>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "RenderPipelineResources");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RenderPipelineResources>.NativeClassPtr);
			RenderPipelineResources.NativeMethodInfoPtr_get_packagePath_Protected_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineResources>.NativeClassPtr, 100665118);
			RenderPipelineResources.NativeMethodInfoPtr_get_packagePath_Internal_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineResources>.NativeClassPtr, 100665119);
			RenderPipelineResources.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineResources>.NativeClassPtr, 100665120);
		}

		// Token: 0x170003D5 RID: 981
		// (get) Token: 0x06000C6F RID: 3183 RVA: 0x0003A0C8 File Offset: 0x000382C8
		public unsafe virtual string packagePath
		{
			[CallerCount(74)]
			[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RenderPipelineResources.NativeMethodInfoPtr_get_packagePath_Protected_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170003D6 RID: 982
		// (get) Token: 0x06000C70 RID: 3184 RVA: 0x0003A10C File Offset: 0x0003830C
		public unsafe string packagePath_Internal
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 660290, RefRangeEnd = 660296, XrefRangeStart = 660290, XrefRangeEnd = 660296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderPipelineResources.NativeMethodInfoPtr_get_packagePath_Internal_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000C71 RID: 3185 RVA: 0x0003A144 File Offset: 0x00038344
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 338035, RefRangeEnd = 338045, XrefRangeStart = 338035, XrefRangeEnd = 338045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RenderPipelineResources()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RenderPipelineResources>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderPipelineResources.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C72 RID: 3186 RVA: 0x00007719 File Offset: 0x00005919
		public RenderPipelineResources(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400094F RID: 2383
		private static readonly IntPtr NativeMethodInfoPtr_get_packagePath_Protected_Virtual_New_get_String_0;

		// Token: 0x04000950 RID: 2384
		private static readonly IntPtr NativeMethodInfoPtr_get_packagePath_Internal_Internal_get_String_0;

		// Token: 0x04000951 RID: 2385
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
