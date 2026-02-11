using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.Localization
{
	// Token: 0x0200000B RID: 11
	[Serializable]
	public class LocalizedObject : LocalizedAsset<Object>
	{
		// Token: 0x0600007B RID: 123 RVA: 0x00002305 File Offset: 0x00000505
		// Note: this type is marked as 'beforefieldinit'.
		static LocalizedObject()
		{
			Il2CppClassPointerStore<LocalizedObject>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization", "LocalizedObject");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LocalizedObject>.NativeClassPtr);
			LocalizedObject.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedObject>.NativeClassPtr, 100663385);
		}

		// Token: 0x0600007C RID: 124 RVA: 0x0000AD84 File Offset: 0x00008F84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1065411, XrefRangeEnd = 1065414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LocalizedObject()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocalizedObject>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedObject.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600007D RID: 125 RVA: 0x0000233E File Offset: 0x0000053E
		public LocalizedObject(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400005C RID: 92
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
