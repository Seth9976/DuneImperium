using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.Rendering.Universal
{
	// Token: 0x0200000A RID: 10
	public class CinemachineUniversalPixelPerfect : MonoBehaviour
	{
		// Token: 0x06000091 RID: 145 RVA: 0x00017358 File Offset: 0x00015558
		// Note: this type is marked as 'beforefieldinit'.
		static CinemachineUniversalPixelPerfect()
		{
			Il2CppClassPointerStore<CinemachineUniversalPixelPerfect>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "CinemachineUniversalPixelPerfect");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CinemachineUniversalPixelPerfect>.NativeClassPtr);
			CinemachineUniversalPixelPerfect.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineUniversalPixelPerfect>.NativeClassPtr, 100663382);
			CinemachineUniversalPixelPerfect.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineUniversalPixelPerfect>.NativeClassPtr, 100663383);
		}

		// Token: 0x06000092 RID: 146 RVA: 0x000173B0 File Offset: 0x000155B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 596897, XrefRangeEnd = 596903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CinemachineUniversalPixelPerfect.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000093 RID: 147 RVA: 0x000173E4 File Offset: 0x000155E4
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CinemachineUniversalPixelPerfect()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CinemachineUniversalPixelPerfect>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CinemachineUniversalPixelPerfect.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000094 RID: 148 RVA: 0x00002476 File Offset: 0x00000676
		public CinemachineUniversalPixelPerfect(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000067 RID: 103
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x04000068 RID: 104
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
