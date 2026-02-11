using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Net.Mime
{
	// Token: 0x0200024A RID: 586
	public class EncodedStreamFactory : Object
	{
		// Token: 0x06002754 RID: 10068 RVA: 0x00010F49 File Offset: 0x0000F149
		// Note: this type is marked as 'beforefieldinit'.
		static EncodedStreamFactory()
		{
			Il2CppClassPointerStore<EncodedStreamFactory>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net.Mime", "EncodedStreamFactory");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EncodedStreamFactory>.NativeClassPtr);
			EncodedStreamFactory.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncodedStreamFactory>.NativeClassPtr, 100669145);
		}

		// Token: 0x06002755 RID: 10069 RVA: 0x000B3C40 File Offset: 0x000B1E40
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EncodedStreamFactory()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EncodedStreamFactory>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EncodedStreamFactory.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002756 RID: 10070 RVA: 0x00010F82 File Offset: 0x0000F182
		public EncodedStreamFactory(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001F4B RID: 8011
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
