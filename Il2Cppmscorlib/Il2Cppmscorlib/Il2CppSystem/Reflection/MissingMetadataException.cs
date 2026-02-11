using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Reflection
{
	// Token: 0x02000438 RID: 1080
	public sealed class MissingMetadataException : TypeAccessException
	{
		// Token: 0x06003E20 RID: 15904 RVA: 0x00016B5E File Offset: 0x00014D5E
		// Note: this type is marked as 'beforefieldinit'.
		static MissingMetadataException()
		{
			Il2CppClassPointerStore<MissingMetadataException>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Reflection", "MissingMetadataException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MissingMetadataException>.NativeClassPtr);
			MissingMetadataException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MissingMetadataException>.NativeClassPtr, 100672641);
		}

		// Token: 0x06003E21 RID: 15905 RVA: 0x0012A0A8 File Offset: 0x001282A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1400051, RefRangeEnd = 1400052, XrefRangeStart = 1400050, XrefRangeEnd = 1400051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MissingMetadataException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MissingMetadataException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MissingMetadataException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E22 RID: 15906 RVA: 0x00016B97 File Offset: 0x00014D97
		public MissingMetadataException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040032DA RID: 13018
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
