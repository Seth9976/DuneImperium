using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using lotus;

namespace worm.client.match.render
{
	// Token: 0x0200029C RID: 668
	public class WormViewManager : ViewManager
	{
		// Token: 0x06001B30 RID: 6960 RVA: 0x0006B8FC File Offset: 0x00069AFC
		// Note: this type is marked as 'beforefieldinit'.
		static WormViewManager()
		{
			Il2CppClassPointerStore<WormViewManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.client.match.render", "WormViewManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormViewManager>.NativeClassPtr);
			WormViewManager.NativeMethodInfoPtr_init_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormViewManager>.NativeClassPtr, 100667255);
			WormViewManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormViewManager>.NativeClassPtr, 100667256);
		}

		// Token: 0x06001B31 RID: 6961 RVA: 0x0006B954 File Offset: 0x00069B54
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormViewManager.NativeMethodInfoPtr_init_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B32 RID: 6962 RVA: 0x0006B990 File Offset: 0x00069B90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 724200, XrefRangeEnd = 724201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormViewManager()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormViewManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormViewManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B33 RID: 6963 RVA: 0x0000FC23 File Offset: 0x0000DE23
		public WormViewManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000FB0 RID: 4016
		private static readonly IntPtr NativeMethodInfoPtr_init_Protected_Virtual_Void_0;

		// Token: 0x04000FB1 RID: 4017
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
