using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering
{
	// Token: 0x020000E4 RID: 228
	public static class XRUtils : Object
	{
		// Token: 0x06001082 RID: 4226 RVA: 0x00008B6B File Offset: 0x00006D6B
		// Note: this type is marked as 'beforefieldinit'.
		static XRUtils()
		{
			Il2CppClassPointerStore<XRUtils>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "XRUtils");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XRUtils>.NativeClassPtr);
			XRUtils.NativeMethodInfoPtr_DrawOcclusionMesh_Public_Static_Void_CommandBuffer_Camera_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRUtils>.NativeClassPtr, 100665738);
		}

		// Token: 0x06001083 RID: 4227 RVA: 0x0004C0A4 File Offset: 0x0004A2A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 977803, XrefRangeEnd = 977808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DrawOcclusionMesh(CommandBuffer cmd, Camera camera, bool stereoEnabled = true)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(camera);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref stereoEnabled;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XRUtils.NativeMethodInfoPtr_DrawOcclusionMesh_Public_Static_Void_CommandBuffer_Camera_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001084 RID: 4228 RVA: 0x00008BA4 File Offset: 0x00006DA4
		public XRUtils(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000C91 RID: 3217
		private static readonly IntPtr NativeMethodInfoPtr_DrawOcclusionMesh_Public_Static_Void_CommandBuffer_Camera_Boolean_0;
	}
}
