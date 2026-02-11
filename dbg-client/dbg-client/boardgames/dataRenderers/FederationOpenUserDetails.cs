using System;
using boardgames.data;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace boardgames.dataRenderers
{
	// Token: 0x02000148 RID: 328
	public class FederationOpenUserDetails : Subscriber<FederationData>
	{
		// Token: 0x06000EF4 RID: 3828 RVA: 0x0004D428 File Offset: 0x0004B628
		// Note: this type is marked as 'beforefieldinit'.
		static FederationOpenUserDetails()
		{
			Il2CppClassPointerStore<FederationOpenUserDetails>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.dataRenderers", "FederationOpenUserDetails");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FederationOpenUserDetails>.NativeClassPtr);
			FederationOpenUserDetails.NativeMethodInfoPtr_Event_TryOpenUserDetails_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FederationOpenUserDetails>.NativeClassPtr, 100665469);
			FederationOpenUserDetails.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FederationOpenUserDetails>.NativeClassPtr, 100665470);
		}

		// Token: 0x06000EF5 RID: 3829 RVA: 0x0004D480 File Offset: 0x0004B680
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 512775, XrefRangeEnd = 512791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_TryOpenUserDetails()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FederationOpenUserDetails.NativeMethodInfoPtr_Event_TryOpenUserDetails_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EF6 RID: 3830 RVA: 0x0004D4B4 File Offset: 0x0004B6B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 512791, XrefRangeEnd = 512794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FederationOpenUserDetails()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FederationOpenUserDetails>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FederationOpenUserDetails.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EF7 RID: 3831 RVA: 0x00009322 File Offset: 0x00007522
		public FederationOpenUserDetails(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400093A RID: 2362
		private static readonly IntPtr NativeMethodInfoPtr_Event_TryOpenUserDetails_Public_Void_0;

		// Token: 0x0400093B RID: 2363
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
