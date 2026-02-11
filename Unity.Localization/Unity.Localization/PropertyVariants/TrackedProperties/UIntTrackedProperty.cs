using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.Localization.PropertyVariants.TrackedProperties
{
	// Token: 0x020000EE RID: 238
	[Serializable]
	public class UIntTrackedProperty : TrackedProperty<uint>
	{
		// Token: 0x06000BBD RID: 3005 RVA: 0x00006ECA File Offset: 0x000050CA
		// Note: this type is marked as 'beforefieldinit'.
		static UIntTrackedProperty()
		{
			Il2CppClassPointerStore<UIntTrackedProperty>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.PropertyVariants.TrackedProperties", "UIntTrackedProperty");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIntTrackedProperty>.NativeClassPtr);
			UIntTrackedProperty.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIntTrackedProperty>.NativeClassPtr, 100665237);
		}

		// Token: 0x06000BBE RID: 3006 RVA: 0x0003593C File Offset: 0x00033B3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1079824, XrefRangeEnd = 1079827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UIntTrackedProperty()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIntTrackedProperty>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIntTrackedProperty.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BBF RID: 3007 RVA: 0x00006F03 File Offset: 0x00005103
		public UIntTrackedProperty(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400083B RID: 2107
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
