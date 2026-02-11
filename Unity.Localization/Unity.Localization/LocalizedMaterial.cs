using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.Localization
{
	// Token: 0x0200000A RID: 10
	[Serializable]
	public class LocalizedMaterial : LocalizedAsset<Material>
	{
		// Token: 0x06000078 RID: 120 RVA: 0x000022C3 File Offset: 0x000004C3
		// Note: this type is marked as 'beforefieldinit'.
		static LocalizedMaterial()
		{
			Il2CppClassPointerStore<LocalizedMaterial>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization", "LocalizedMaterial");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LocalizedMaterial>.NativeClassPtr);
			LocalizedMaterial.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedMaterial>.NativeClassPtr, 100663384);
		}

		// Token: 0x06000079 RID: 121 RVA: 0x0000AD48 File Offset: 0x00008F48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1065408, XrefRangeEnd = 1065411, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LocalizedMaterial()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocalizedMaterial>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedMaterial.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600007A RID: 122 RVA: 0x000022FC File Offset: 0x000004FC
		public LocalizedMaterial(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400005B RID: 91
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
