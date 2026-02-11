using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Google.Apis.Testing
{
	// Token: 0x02000011 RID: 17
	public class VisibleForTestOnly : Attribute
	{
		// Token: 0x06000079 RID: 121 RVA: 0x0000227E File Offset: 0x0000047E
		// Note: this type is marked as 'beforefieldinit'.
		static VisibleForTestOnly()
		{
			Il2CppClassPointerStore<VisibleForTestOnly>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.Core.dll", "Google.Apis.Testing", "VisibleForTestOnly");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VisibleForTestOnly>.NativeClassPtr);
			VisibleForTestOnly.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisibleForTestOnly>.NativeClassPtr, 100663362);
		}

		// Token: 0x0600007A RID: 122 RVA: 0x00005F40 File Offset: 0x00004140
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VisibleForTestOnly()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VisibleForTestOnly>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisibleForTestOnly.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600007B RID: 123 RVA: 0x000022B7 File Offset: 0x000004B7
		public VisibleForTestOnly(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000052 RID: 82
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
