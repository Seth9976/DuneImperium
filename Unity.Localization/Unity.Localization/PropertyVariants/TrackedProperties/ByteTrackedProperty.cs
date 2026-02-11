using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.Localization.PropertyVariants.TrackedProperties
{
	// Token: 0x020000E8 RID: 232
	[Serializable]
	public class ByteTrackedProperty : TrackedProperty<byte>
	{
		// Token: 0x06000BAB RID: 2987 RVA: 0x00006D3E File Offset: 0x00004F3E
		// Note: this type is marked as 'beforefieldinit'.
		static ByteTrackedProperty()
		{
			Il2CppClassPointerStore<ByteTrackedProperty>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.PropertyVariants.TrackedProperties", "ByteTrackedProperty");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ByteTrackedProperty>.NativeClassPtr);
			ByteTrackedProperty.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ByteTrackedProperty>.NativeClassPtr, 100665231);
		}

		// Token: 0x06000BAC RID: 2988 RVA: 0x000357D4 File Offset: 0x000339D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1079806, XrefRangeEnd = 1079809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ByteTrackedProperty()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ByteTrackedProperty>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ByteTrackedProperty.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BAD RID: 2989 RVA: 0x00006D77 File Offset: 0x00004F77
		public ByteTrackedProperty(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000835 RID: 2101
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
