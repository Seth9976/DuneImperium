using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace boardgames.initialization
{
	// Token: 0x02000134 RID: 308
	public class InitializationCommandAttribute : Attribute
	{
		// Token: 0x0600102B RID: 4139 RVA: 0x00009828 File Offset: 0x00007A28
		// Note: this type is marked as 'beforefieldinit'.
		static InitializationCommandAttribute()
		{
			Il2CppClassPointerStore<InitializationCommandAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "boardgames.initialization", "InitializationCommandAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InitializationCommandAttribute>.NativeClassPtr);
			InitializationCommandAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializationCommandAttribute>.NativeClassPtr, 100665628);
		}

		// Token: 0x0600102C RID: 4140 RVA: 0x00042A38 File Offset: 0x00040C38
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InitializationCommandAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InitializationCommandAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InitializationCommandAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600102D RID: 4141 RVA: 0x00009861 File Offset: 0x00007A61
		public InitializationCommandAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040009DE RID: 2526
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
