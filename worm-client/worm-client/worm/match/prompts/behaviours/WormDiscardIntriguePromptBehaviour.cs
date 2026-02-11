using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using lotus;
using UnityEngine;

namespace worm.match.prompts.behaviours
{
	// Token: 0x020000CE RID: 206
	public class WormDiscardIntriguePromptBehaviour : MonoBehaviour
	{
		// Token: 0x060008AC RID: 2220 RVA: 0x00032CD8 File Offset: 0x00030ED8
		// Note: this type is marked as 'beforefieldinit'.
		static WormDiscardIntriguePromptBehaviour()
		{
			Il2CppClassPointerStore<WormDiscardIntriguePromptBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.prompts.behaviours", "WormDiscardIntriguePromptBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormDiscardIntriguePromptBehaviour>.NativeClassPtr);
			WormDiscardIntriguePromptBehaviour.NativeFieldInfoPtr_pileView = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormDiscardIntriguePromptBehaviour>.NativeClassPtr, "pileView");
			WormDiscardIntriguePromptBehaviour.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormDiscardIntriguePromptBehaviour>.NativeClassPtr, 100664484);
			WormDiscardIntriguePromptBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormDiscardIntriguePromptBehaviour>.NativeClassPtr, 100664485);
		}

		// Token: 0x060008AD RID: 2221 RVA: 0x00032D44 File Offset: 0x00030F44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 698845, XrefRangeEnd = 698859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormDiscardIntriguePromptBehaviour.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008AE RID: 2222 RVA: 0x00032D78 File Offset: 0x00030F78
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormDiscardIntriguePromptBehaviour()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormDiscardIntriguePromptBehaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormDiscardIntriguePromptBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008AF RID: 2223 RVA: 0x000066D7 File Offset: 0x000048D7
		public WormDiscardIntriguePromptBehaviour(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700025D RID: 605
		// (get) Token: 0x060008B0 RID: 2224 RVA: 0x00032DB4 File Offset: 0x00030FB4
		// (set) Token: 0x060008B1 RID: 2225 RVA: 0x000066E0 File Offset: 0x000048E0
		public unsafe ContainerView pileView
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDiscardIntriguePromptBehaviour.NativeFieldInfoPtr_pileView);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ContainerView>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDiscardIntriguePromptBehaviour.NativeFieldInfoPtr_pileView), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040004FF RID: 1279
		private static readonly IntPtr NativeFieldInfoPtr_pileView;

		// Token: 0x04000500 RID: 1280
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04000501 RID: 1281
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
