using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.Localization
{
	// Token: 0x02000009 RID: 9
	[Serializable]
	public class LocalizedMesh : LocalizedAsset<Mesh>
	{
		// Token: 0x06000075 RID: 117 RVA: 0x00002281 File Offset: 0x00000481
		// Note: this type is marked as 'beforefieldinit'.
		static LocalizedMesh()
		{
			Il2CppClassPointerStore<LocalizedMesh>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization", "LocalizedMesh");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LocalizedMesh>.NativeClassPtr);
			LocalizedMesh.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedMesh>.NativeClassPtr, 100663383);
		}

		// Token: 0x06000076 RID: 118 RVA: 0x0000AD0C File Offset: 0x00008F0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1065405, XrefRangeEnd = 1065408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LocalizedMesh()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocalizedMesh>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedMesh.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000077 RID: 119 RVA: 0x000022BA File Offset: 0x000004BA
		public LocalizedMesh(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400005A RID: 90
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
