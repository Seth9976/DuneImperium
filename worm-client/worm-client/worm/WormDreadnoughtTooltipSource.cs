using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using lotus;

namespace worm
{
	// Token: 0x0200003D RID: 61
	public class WormDreadnoughtTooltipSource : Observer
	{
		// Token: 0x060002AC RID: 684 RVA: 0x00021128 File Offset: 0x0001F328
		// Note: this type is marked as 'beforefieldinit'.
		static WormDreadnoughtTooltipSource()
		{
			Il2CppClassPointerStore<WormDreadnoughtTooltipSource>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm", "WormDreadnoughtTooltipSource");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormDreadnoughtTooltipSource>.NativeClassPtr);
			WormDreadnoughtTooltipSource.NativeMethodInfoPtr_GetLocalizedTooltip_Public_Virtual_Final_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormDreadnoughtTooltipSource>.NativeClassPtr, 100663735);
			WormDreadnoughtTooltipSource.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormDreadnoughtTooltipSource>.NativeClassPtr, 100663736);
		}

		// Token: 0x060002AD RID: 685 RVA: 0x00021180 File Offset: 0x0001F380
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 690560, XrefRangeEnd = 690595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetLocalizedTooltip()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormDreadnoughtTooltipSource.NativeMethodInfoPtr_GetLocalizedTooltip_Public_Virtual_Final_New_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060002AE RID: 686 RVA: 0x000211B8 File Offset: 0x0001F3B8
		[CallerCount(197)]
		[CachedScanResults(RefRangeStart = 496077, RefRangeEnd = 496274, XrefRangeStart = 496077, XrefRangeEnd = 496274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormDreadnoughtTooltipSource()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormDreadnoughtTooltipSource>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormDreadnoughtTooltipSource.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002AF RID: 687 RVA: 0x000033C7 File Offset: 0x000015C7
		public WormDreadnoughtTooltipSource(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400019E RID: 414
		private static readonly IntPtr NativeMethodInfoPtr_GetLocalizedTooltip_Public_Virtual_Final_New_String_0;

		// Token: 0x0400019F RID: 415
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
