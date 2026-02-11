using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Canis.messages
{
	// Token: 0x02000165 RID: 357
	public class PostMulligan : GameMessage
	{
		// Token: 0x06001016 RID: 4118 RVA: 0x00008338 File Offset: 0x00006538
		// Note: this type is marked as 'beforefieldinit'.
		static PostMulligan()
		{
			Il2CppClassPointerStore<PostMulligan>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.messages", "PostMulligan");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PostMulligan>.NativeClassPtr);
			PostMulligan.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostMulligan>.NativeClassPtr, 100666579);
		}

		// Token: 0x06001017 RID: 4119 RVA: 0x0005AB30 File Offset: 0x00058D30
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 542958, RefRangeEnd = 542962, XrefRangeStart = 542958, XrefRangeEnd = 542962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PostMulligan()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PostMulligan>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostMulligan.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001018 RID: 4120 RVA: 0x00008371 File Offset: 0x00006571
		public PostMulligan(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000AA1 RID: 2721
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
