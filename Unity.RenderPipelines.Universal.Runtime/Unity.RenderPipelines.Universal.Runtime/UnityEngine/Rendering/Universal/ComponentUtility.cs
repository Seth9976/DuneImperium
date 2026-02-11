using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering.Universal
{
	// Token: 0x0200003E RID: 62
	public static class ComponentUtility : Object
	{
		// Token: 0x060005BD RID: 1469 RVA: 0x00029824 File Offset: 0x00027A24
		// Note: this type is marked as 'beforefieldinit'.
		static ComponentUtility()
		{
			Il2CppClassPointerStore<ComponentUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "ComponentUtility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ComponentUtility>.NativeClassPtr);
			ComponentUtility.NativeMethodInfoPtr_IsUniversalCamera_Public_Static_Boolean_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentUtility>.NativeClassPtr, 100663964);
			ComponentUtility.NativeMethodInfoPtr_IsUniversalLight_Public_Static_Boolean_Light_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentUtility>.NativeClassPtr, 100663965);
		}

		// Token: 0x060005BE RID: 1470 RVA: 0x0002987C File Offset: 0x00027A7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 603191, XrefRangeEnd = 603199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsUniversalCamera(Camera camera)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComponentUtility.NativeMethodInfoPtr_IsUniversalCamera_Public_Static_Boolean_Camera_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060005BF RID: 1471 RVA: 0x000298C0 File Offset: 0x00027AC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 603199, XrefRangeEnd = 603207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsUniversalLight(Light light)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(light);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComponentUtility.NativeMethodInfoPtr_IsUniversalLight_Public_Static_Boolean_Light_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060005C0 RID: 1472 RVA: 0x00004859 File Offset: 0x00002A59
		public ComponentUtility(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400042F RID: 1071
		private static readonly IntPtr NativeMethodInfoPtr_IsUniversalCamera_Public_Static_Boolean_Camera_0;

		// Token: 0x04000430 RID: 1072
		private static readonly IntPtr NativeMethodInfoPtr_IsUniversalLight_Public_Static_Boolean_Light_0;
	}
}
