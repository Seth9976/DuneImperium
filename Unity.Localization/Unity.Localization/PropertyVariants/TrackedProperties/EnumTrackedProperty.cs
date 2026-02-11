using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.Localization.PropertyVariants.TrackedProperties
{
	// Token: 0x020000F4 RID: 244
	[Serializable]
	public class EnumTrackedProperty : IntTrackedProperty
	{
		// Token: 0x06000BCF RID: 3023 RVA: 0x00007056 File Offset: 0x00005256
		// Note: this type is marked as 'beforefieldinit'.
		static EnumTrackedProperty()
		{
			Il2CppClassPointerStore<EnumTrackedProperty>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.PropertyVariants.TrackedProperties", "EnumTrackedProperty");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EnumTrackedProperty>.NativeClassPtr);
			EnumTrackedProperty.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumTrackedProperty>.NativeClassPtr, 100665243);
		}

		// Token: 0x06000BD0 RID: 3024 RVA: 0x00035AA4 File Offset: 0x00033CA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EnumTrackedProperty()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EnumTrackedProperty>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumTrackedProperty.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BD1 RID: 3025 RVA: 0x0000708F File Offset: 0x0000528F
		public EnumTrackedProperty(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000841 RID: 2113
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
