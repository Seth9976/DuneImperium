using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.Localization.PropertyVariants.TrackedProperties
{
	// Token: 0x020000F3 RID: 243
	[Serializable]
	public class ArraySizeTrackedProperty : UIntTrackedProperty
	{
		// Token: 0x06000BCC RID: 3020 RVA: 0x00007014 File Offset: 0x00005214
		// Note: this type is marked as 'beforefieldinit'.
		static ArraySizeTrackedProperty()
		{
			Il2CppClassPointerStore<ArraySizeTrackedProperty>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.PropertyVariants.TrackedProperties", "ArraySizeTrackedProperty");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArraySizeTrackedProperty>.NativeClassPtr);
			ArraySizeTrackedProperty.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArraySizeTrackedProperty>.NativeClassPtr, 100665242);
		}

		// Token: 0x06000BCD RID: 3021 RVA: 0x00035A68 File Offset: 0x00033C68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ArraySizeTrackedProperty()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArraySizeTrackedProperty>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArraySizeTrackedProperty.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BCE RID: 3022 RVA: 0x0000704D File Offset: 0x0000524D
		public ArraySizeTrackedProperty(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000840 RID: 2112
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
