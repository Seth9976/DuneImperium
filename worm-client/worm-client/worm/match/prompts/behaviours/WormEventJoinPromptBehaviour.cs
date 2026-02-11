using System;
using dwd.core.ui.prompt.behaviours;
using dwd.core.ui.prompt.prompts;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace worm.match.prompts.behaviours
{
	// Token: 0x020000D1 RID: 209
	public class WormEventJoinPromptBehaviour : PromptBehaviour<IPromptWithData>
	{
		// Token: 0x060008DE RID: 2270 RVA: 0x0003359C File Offset: 0x0003179C
		// Note: this type is marked as 'beforefieldinit'.
		static WormEventJoinPromptBehaviour()
		{
			Il2CppClassPointerStore<WormEventJoinPromptBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.prompts.behaviours", "WormEventJoinPromptBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormEventJoinPromptBehaviour>.NativeClassPtr);
			WormEventJoinPromptBehaviour.NativeMethodInfoPtr_Event_MoreInfo_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventJoinPromptBehaviour>.NativeClassPtr, 100664510);
			WormEventJoinPromptBehaviour.NativeMethodInfoPtr_Event_Cancel_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventJoinPromptBehaviour>.NativeClassPtr, 100664511);
			WormEventJoinPromptBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventJoinPromptBehaviour>.NativeClassPtr, 100664512);
		}

		// Token: 0x060008DF RID: 2271 RVA: 0x00033608 File Offset: 0x00031808
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 699029, XrefRangeEnd = 699048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_MoreInfo()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEventJoinPromptBehaviour.NativeMethodInfoPtr_Event_MoreInfo_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008E0 RID: 2272 RVA: 0x0003363C File Offset: 0x0003183C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 699048, XrefRangeEnd = 699053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_Cancel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEventJoinPromptBehaviour.NativeMethodInfoPtr_Event_Cancel_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008E1 RID: 2273 RVA: 0x00033670 File Offset: 0x00031870
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 699053, XrefRangeEnd = 699056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormEventJoinPromptBehaviour()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormEventJoinPromptBehaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEventJoinPromptBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008E2 RID: 2274 RVA: 0x000068D2 File Offset: 0x00004AD2
		public WormEventJoinPromptBehaviour(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400051C RID: 1308
		private static readonly IntPtr NativeMethodInfoPtr_Event_MoreInfo_Public_Void_0;

		// Token: 0x0400051D RID: 1309
		private static readonly IntPtr NativeMethodInfoPtr_Event_Cancel_Public_Void_0;

		// Token: 0x0400051E RID: 1310
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
