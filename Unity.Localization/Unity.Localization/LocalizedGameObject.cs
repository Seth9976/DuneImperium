using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.Localization
{
	// Token: 0x02000008 RID: 8
	[Serializable]
	public class LocalizedGameObject : LocalizedAsset<GameObject>
	{
		// Token: 0x06000072 RID: 114 RVA: 0x0000223F File Offset: 0x0000043F
		// Note: this type is marked as 'beforefieldinit'.
		static LocalizedGameObject()
		{
			Il2CppClassPointerStore<LocalizedGameObject>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization", "LocalizedGameObject");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LocalizedGameObject>.NativeClassPtr);
			LocalizedGameObject.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedGameObject>.NativeClassPtr, 100663382);
		}

		// Token: 0x06000073 RID: 115 RVA: 0x0000ACD0 File Offset: 0x00008ED0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1065402, XrefRangeEnd = 1065405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LocalizedGameObject()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocalizedGameObject>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedGameObject.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000074 RID: 116 RVA: 0x00002278 File Offset: 0x00000478
		public LocalizedGameObject(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000059 RID: 89
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
