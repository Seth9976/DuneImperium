using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace zen.src.preferences
{
	// Token: 0x0200004F RID: 79
	public class MultiConfig : Object
	{
		// Token: 0x0600031A RID: 794 RVA: 0x0001B210 File Offset: 0x00019410
		// Note: this type is marked as 'beforefieldinit'.
		static MultiConfig()
		{
			Il2CppClassPointerStore<MultiConfig>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "zen.src.preferences", "MultiConfig");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MultiConfig>.NativeClassPtr);
			MultiConfig.NativeMethodInfoPtr_GetDirectory_Public_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiConfig>.NativeClassPtr, 100663836);
			MultiConfig.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiConfig>.NativeClassPtr, 100663837);
		}

		// Token: 0x0600031B RID: 795 RVA: 0x0001B268 File Offset: 0x00019468
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetDirectory()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiConfig.NativeMethodInfoPtr_GetDirectory_Public_Static_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600031C RID: 796 RVA: 0x0001B294 File Offset: 0x00019494
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MultiConfig()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MultiConfig>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiConfig.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600031D RID: 797 RVA: 0x00003519 File Offset: 0x00001719
		public MultiConfig(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040001FC RID: 508
		private static readonly IntPtr NativeMethodInfoPtr_GetDirectory_Public_Static_String_0;

		// Token: 0x040001FD RID: 509
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
