using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using lotus;
using UnityEngine;

namespace worm.match.prompts.behaviours
{
	// Token: 0x020000CD RID: 205
	public class WormDiscardCardsPromptBehaviour : MonoBehaviour
	{
		// Token: 0x060008A6 RID: 2214 RVA: 0x00032BCC File Offset: 0x00030DCC
		// Note: this type is marked as 'beforefieldinit'.
		static WormDiscardCardsPromptBehaviour()
		{
			Il2CppClassPointerStore<WormDiscardCardsPromptBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.prompts.behaviours", "WormDiscardCardsPromptBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormDiscardCardsPromptBehaviour>.NativeClassPtr);
			WormDiscardCardsPromptBehaviour.NativeFieldInfoPtr_pileView = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormDiscardCardsPromptBehaviour>.NativeClassPtr, "pileView");
			WormDiscardCardsPromptBehaviour.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormDiscardCardsPromptBehaviour>.NativeClassPtr, 100664482);
			WormDiscardCardsPromptBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormDiscardCardsPromptBehaviour>.NativeClassPtr, 100664483);
		}

		// Token: 0x060008A7 RID: 2215 RVA: 0x00032C38 File Offset: 0x00030E38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 698831, XrefRangeEnd = 698845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormDiscardCardsPromptBehaviour.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008A8 RID: 2216 RVA: 0x00032C6C File Offset: 0x00030E6C
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormDiscardCardsPromptBehaviour()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormDiscardCardsPromptBehaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormDiscardCardsPromptBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008A9 RID: 2217 RVA: 0x000066AF File Offset: 0x000048AF
		public WormDiscardCardsPromptBehaviour(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700025C RID: 604
		// (get) Token: 0x060008AA RID: 2218 RVA: 0x00032CA8 File Offset: 0x00030EA8
		// (set) Token: 0x060008AB RID: 2219 RVA: 0x000066B8 File Offset: 0x000048B8
		public unsafe ContainerView pileView
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDiscardCardsPromptBehaviour.NativeFieldInfoPtr_pileView);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ContainerView>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDiscardCardsPromptBehaviour.NativeFieldInfoPtr_pileView), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040004FC RID: 1276
		private static readonly IntPtr NativeFieldInfoPtr_pileView;

		// Token: 0x040004FD RID: 1277
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040004FE RID: 1278
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
