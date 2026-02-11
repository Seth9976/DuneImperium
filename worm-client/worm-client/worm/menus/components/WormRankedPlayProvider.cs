using System;
using boardgames.ranked.menus;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Collections.Generic;

namespace worm.menus.components
{
	// Token: 0x020000A2 RID: 162
	public class WormRankedPlayProvider : RankedPlayProvider
	{
		// Token: 0x06000655 RID: 1621 RVA: 0x0002BF08 File Offset: 0x0002A108
		// Note: this type is marked as 'beforefieldinit'.
		static WormRankedPlayProvider()
		{
			Il2CppClassPointerStore<WormRankedPlayProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.menus.components", "WormRankedPlayProvider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormRankedPlayProvider>.NativeClassPtr);
			WormRankedPlayProvider.NativeMethodInfoPtr_AddQueueMetadata_Protected_Virtual_Void_Dictionary_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormRankedPlayProvider>.NativeClassPtr, 100664188);
			WormRankedPlayProvider.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormRankedPlayProvider>.NativeClassPtr, 100664189);
		}

		// Token: 0x06000656 RID: 1622 RVA: 0x0002BF60 File Offset: 0x0002A160
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 696231, XrefRangeEnd = 696247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void AddQueueMetadata(Dictionary<string, string> metadata)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(metadata);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormRankedPlayProvider.NativeMethodInfoPtr_AddQueueMetadata_Protected_Virtual_Void_Dictionary_2_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000657 RID: 1623 RVA: 0x0002BFB0 File Offset: 0x0002A1B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 696247, XrefRangeEnd = 696248, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormRankedPlayProvider()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormRankedPlayProvider>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormRankedPlayProvider.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000658 RID: 1624 RVA: 0x000052BB File Offset: 0x000034BB
		public WormRankedPlayProvider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040003A4 RID: 932
		private static readonly IntPtr NativeMethodInfoPtr_AddQueueMetadata_Protected_Virtual_Void_Dictionary_2_String_String_0;

		// Token: 0x040003A5 RID: 933
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
