using System;
using Canis.attributes;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace worm.match.components.stingers
{
	// Token: 0x02000231 RID: 561
	public class WormStingerUndoAcquireInitializer : WormStingerContainerInitializer
	{
		// Token: 0x0600186D RID: 6253 RVA: 0x000623D4 File Offset: 0x000605D4
		// Note: this type is marked as 'beforefieldinit'.
		static WormStingerUndoAcquireInitializer()
		{
			Il2CppClassPointerStore<WormStingerUndoAcquireInitializer>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.components.stingers", "WormStingerUndoAcquireInitializer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormStingerUndoAcquireInitializer>.NativeClassPtr);
			WormStingerUndoAcquireInitializer.NativeMethodInfoPtr_InitViews_Public_Virtual_Void_IHasAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormStingerUndoAcquireInitializer>.NativeClassPtr, 100666674);
			WormStingerUndoAcquireInitializer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormStingerUndoAcquireInitializer>.NativeClassPtr, 100666675);
		}

		// Token: 0x0600186E RID: 6254 RVA: 0x0006242C File Offset: 0x0006062C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 718383, XrefRangeEnd = 718416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void InitViews(IHasAttributes attributes)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attributes);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormStingerUndoAcquireInitializer.NativeMethodInfoPtr_InitViews_Public_Virtual_Void_IHasAttributes_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600186F RID: 6255 RVA: 0x0006247C File Offset: 0x0006067C
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormStingerUndoAcquireInitializer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormStingerUndoAcquireInitializer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormStingerUndoAcquireInitializer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001870 RID: 6256 RVA: 0x0000E7A7 File Offset: 0x0000C9A7
		public WormStingerUndoAcquireInitializer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000E27 RID: 3623
		private static readonly IntPtr NativeMethodInfoPtr_InitViews_Public_Virtual_Void_IHasAttributes_0;

		// Token: 0x04000E28 RID: 3624
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
