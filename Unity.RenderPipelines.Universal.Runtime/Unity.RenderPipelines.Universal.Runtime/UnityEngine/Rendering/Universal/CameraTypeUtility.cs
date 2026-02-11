using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering.Universal
{
	// Token: 0x020000E9 RID: 233
	public static class CameraTypeUtility : Object
	{
		// Token: 0x06001178 RID: 4472 RVA: 0x000521E0 File Offset: 0x000503E0
		// Note: this type is marked as 'beforefieldinit'.
		static CameraTypeUtility()
		{
			Il2CppClassPointerStore<CameraTypeUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "CameraTypeUtility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CameraTypeUtility>.NativeClassPtr);
			CameraTypeUtility.NativeFieldInfoPtr_s_CameraTypeNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraTypeUtility>.NativeClassPtr, "s_CameraTypeNames");
			CameraTypeUtility.NativeMethodInfoPtr_GetName_Public_Static_String_CameraRenderType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraTypeUtility>.NativeClassPtr, 100665513);
		}

		// Token: 0x06001179 RID: 4473 RVA: 0x00052238 File Offset: 0x00050438
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 618862, XrefRangeEnd = 618868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetName(this CameraRenderType type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref type;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraTypeUtility.NativeMethodInfoPtr_GetName_Public_Static_String_CameraRenderType_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600117A RID: 4474 RVA: 0x0000A6BD File Offset: 0x000088BD
		public CameraTypeUtility(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000624 RID: 1572
		// (get) Token: 0x0600117B RID: 4475 RVA: 0x00052270 File Offset: 0x00050470
		// (set) Token: 0x0600117C RID: 4476 RVA: 0x0000A6C6 File Offset: 0x000088C6
		public unsafe static Il2CppStringArray s_CameraTypeNames
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CameraTypeUtility.NativeFieldInfoPtr_s_CameraTypeNames, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CameraTypeUtility.NativeFieldInfoPtr_s_CameraTypeNames, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000CD5 RID: 3285
		private static readonly IntPtr NativeFieldInfoPtr_s_CameraTypeNames;

		// Token: 0x04000CD6 RID: 3286
		private static readonly IntPtr NativeMethodInfoPtr_GetName_Public_Static_String_CameraRenderType_0;
	}
}
