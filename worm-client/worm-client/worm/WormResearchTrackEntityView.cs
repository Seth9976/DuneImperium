using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace worm
{
	// Token: 0x02000049 RID: 73
	public class WormResearchTrackEntityView : MonoBehaviour
	{
		// Token: 0x06000323 RID: 803 RVA: 0x00022868 File Offset: 0x00020A68
		// Note: this type is marked as 'beforefieldinit'.
		static WormResearchTrackEntityView()
		{
			Il2CppClassPointerStore<WormResearchTrackEntityView>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm", "WormResearchTrackEntityView");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormResearchTrackEntityView>.NativeClassPtr);
			WormResearchTrackEntityView.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormResearchTrackEntityView>.NativeClassPtr, 100663797);
			WormResearchTrackEntityView.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormResearchTrackEntityView>.NativeClassPtr, 100663798);
			WormResearchTrackEntityView.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormResearchTrackEntityView>.NativeClassPtr, 100663799);
		}

		// Token: 0x06000324 RID: 804 RVA: 0x000228D4 File Offset: 0x00020AD4
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormResearchTrackEntityView.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000325 RID: 805 RVA: 0x00022908 File Offset: 0x00020B08
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormResearchTrackEntityView.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000326 RID: 806 RVA: 0x0002293C File Offset: 0x00020B3C
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormResearchTrackEntityView()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormResearchTrackEntityView>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormResearchTrackEntityView.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000327 RID: 807 RVA: 0x00003767 File Offset: 0x00001967
		public WormResearchTrackEntityView(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040001E2 RID: 482
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040001E3 RID: 483
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040001E4 RID: 484
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
