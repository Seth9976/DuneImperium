using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering
{
	// Token: 0x020001F4 RID: 500
	public static class CameraEventUtils : Object
	{
		// Token: 0x060021D7 RID: 8663 RVA: 0x0000CE6D File Offset: 0x0000B06D
		// Note: this type is marked as 'beforefieldinit'.
		static CameraEventUtils()
		{
			Il2CppClassPointerStore<CameraEventUtils>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "CameraEventUtils");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CameraEventUtils>.NativeClassPtr);
			CameraEventUtils.NativeMethodInfoPtr_IsValid_Public_Static_Boolean_CameraEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraEventUtils>.NativeClassPtr, 100667843);
		}

		// Token: 0x060021D8 RID: 8664 RVA: 0x00094610 File Offset: 0x00092810
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 681413, RefRangeEnd = 681416, XrefRangeStart = 681413, XrefRangeEnd = 681413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsValid(CameraEvent value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraEventUtils.NativeMethodInfoPtr_IsValid_Public_Static_Boolean_CameraEvent_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060021D9 RID: 8665 RVA: 0x0000CEA6 File Offset: 0x0000B0A6
		public CameraEventUtils(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001D5C RID: 7516
		private static readonly IntPtr NativeMethodInfoPtr_IsValid_Public_Static_Boolean_CameraEvent_0;

		// Token: 0x04001D5D RID: 7517
		public const CameraEvent k_MinimumValue = CameraEvent.BeforeDepthTexture;

		// Token: 0x04001D5E RID: 7518
		public const CameraEvent k_MaximumValue = CameraEvent.AfterHaloAndLensFlares;
	}
}
