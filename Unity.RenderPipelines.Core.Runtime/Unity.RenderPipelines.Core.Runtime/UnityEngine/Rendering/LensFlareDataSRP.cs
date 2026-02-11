using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.Rendering
{
	// Token: 0x020000A6 RID: 166
	[Serializable]
	public sealed class LensFlareDataSRP : ScriptableObject
	{
		// Token: 0x06000C5D RID: 3165 RVA: 0x00039D68 File Offset: 0x00037F68
		// Note: this type is marked as 'beforefieldinit'.
		static LensFlareDataSRP()
		{
			Il2CppClassPointerStore<LensFlareDataSRP>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "LensFlareDataSRP");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LensFlareDataSRP>.NativeClassPtr);
			LensFlareDataSRP.NativeFieldInfoPtr_elements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensFlareDataSRP>.NativeClassPtr, "elements");
			LensFlareDataSRP.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LensFlareDataSRP>.NativeClassPtr, 100665111);
		}

		// Token: 0x06000C5E RID: 3166 RVA: 0x00039DC0 File Offset: 0x00037FC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 971633, XrefRangeEnd = 971635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LensFlareDataSRP()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LensFlareDataSRP>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LensFlareDataSRP.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C5F RID: 3167 RVA: 0x00007678 File Offset: 0x00005878
		public LensFlareDataSRP(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003D2 RID: 978
		// (get) Token: 0x06000C60 RID: 3168 RVA: 0x00039DFC File Offset: 0x00037FFC
		// (set) Token: 0x06000C61 RID: 3169 RVA: 0x00007681 File Offset: 0x00005881
		public unsafe Il2CppReferenceArray<LensFlareDataElementSRP> elements
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LensFlareDataSRP.NativeFieldInfoPtr_elements);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<LensFlareDataElementSRP>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LensFlareDataSRP.NativeFieldInfoPtr_elements), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000943 RID: 2371
		private static readonly IntPtr NativeFieldInfoPtr_elements;

		// Token: 0x04000944 RID: 2372
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
