using System;
using Canis.attributes;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace worm.match.components.stingers
{
	// Token: 0x0200022A RID: 554
	public class WormStingerEntityIDInitializer : WormStingerContainerInitializer
	{
		// Token: 0x06001839 RID: 6201 RVA: 0x00061A44 File Offset: 0x0005FC44
		// Note: this type is marked as 'beforefieldinit'.
		static WormStingerEntityIDInitializer()
		{
			Il2CppClassPointerStore<WormStingerEntityIDInitializer>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.components.stingers", "WormStingerEntityIDInitializer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormStingerEntityIDInitializer>.NativeClassPtr);
			WormStingerEntityIDInitializer.NativeMethodInfoPtr_InitViews_Public_Virtual_Void_IHasAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormStingerEntityIDInitializer>.NativeClassPtr, 100666655);
			WormStingerEntityIDInitializer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormStingerEntityIDInitializer>.NativeClassPtr, 100666656);
		}

		// Token: 0x0600183A RID: 6202 RVA: 0x00061A9C File Offset: 0x0005FC9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 718140, XrefRangeEnd = 718174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void InitViews(IHasAttributes attributes)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attributes);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormStingerEntityIDInitializer.NativeMethodInfoPtr_InitViews_Public_Virtual_Void_IHasAttributes_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600183B RID: 6203 RVA: 0x00061AEC File Offset: 0x0005FCEC
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormStingerEntityIDInitializer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormStingerEntityIDInitializer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormStingerEntityIDInitializer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600183C RID: 6204 RVA: 0x0000E613 File Offset: 0x0000C813
		public WormStingerEntityIDInitializer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000E0C RID: 3596
		private static readonly IntPtr NativeMethodInfoPtr_InitViews_Public_Virtual_Void_IHasAttributes_0;

		// Token: 0x04000E0D RID: 3597
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
