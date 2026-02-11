using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x0200012F RID: 303
	public class ExcludeFromPresetAttribute : Attribute
	{
		// Token: 0x060017B8 RID: 6072 RVA: 0x000096A8 File Offset: 0x000078A8
		// Note: this type is marked as 'beforefieldinit'.
		static ExcludeFromPresetAttribute()
		{
			Il2CppClassPointerStore<ExcludeFromPresetAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "ExcludeFromPresetAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExcludeFromPresetAttribute>.NativeClassPtr);
			ExcludeFromPresetAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExcludeFromPresetAttribute>.NativeClassPtr, 100666532);
		}

		// Token: 0x060017B9 RID: 6073 RVA: 0x00070300 File Offset: 0x0006E500
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ExcludeFromPresetAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExcludeFromPresetAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExcludeFromPresetAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017BA RID: 6074 RVA: 0x000096E1 File Offset: 0x000078E1
		public ExcludeFromPresetAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001559 RID: 5465
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
