using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace dwd.core
{
	// Token: 0x02000085 RID: 133
	public class SortingLayerExposed : MonoBehaviour
	{
		// Token: 0x060009D8 RID: 2520 RVA: 0x00005757 File Offset: 0x00003957
		// Note: this type is marked as 'beforefieldinit'.
		static SortingLayerExposed()
		{
			Il2CppClassPointerStore<SortingLayerExposed>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core", "SortingLayerExposed");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SortingLayerExposed>.NativeClassPtr);
			SortingLayerExposed.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortingLayerExposed>.NativeClassPtr, 100664666);
		}

		// Token: 0x060009D9 RID: 2521 RVA: 0x00039270 File Offset: 0x00037470
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SortingLayerExposed()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SortingLayerExposed>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortingLayerExposed.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009DA RID: 2522 RVA: 0x00005790 File Offset: 0x00003990
		public SortingLayerExposed(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000741 RID: 1857
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
