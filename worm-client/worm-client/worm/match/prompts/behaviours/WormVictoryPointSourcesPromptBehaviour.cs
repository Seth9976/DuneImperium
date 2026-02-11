using System;
using dwd.core.ui.match.prompt.prompts;
using dwd.core.ui.prompt.behaviours;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using lotus;

namespace worm.match.prompts.behaviours
{
	// Token: 0x020000EA RID: 234
	public class WormVictoryPointSourcesPromptBehaviour : PromptBehaviour<FlavoredDismissablePrompt>
	{
		// Token: 0x06000A74 RID: 2676 RVA: 0x00037E34 File Offset: 0x00036034
		// Note: this type is marked as 'beforefieldinit'.
		static WormVictoryPointSourcesPromptBehaviour()
		{
			Il2CppClassPointerStore<WormVictoryPointSourcesPromptBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.prompts.behaviours", "WormVictoryPointSourcesPromptBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormVictoryPointSourcesPromptBehaviour>.NativeClassPtr);
			WormVictoryPointSourcesPromptBehaviour.NativeFieldInfoPtr_playerView = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormVictoryPointSourcesPromptBehaviour>.NativeClassPtr, "playerView");
			WormVictoryPointSourcesPromptBehaviour.NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormVictoryPointSourcesPromptBehaviour>.NativeClassPtr, 100664732);
			WormVictoryPointSourcesPromptBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormVictoryPointSourcesPromptBehaviour>.NativeClassPtr, 100664733);
		}

		// Token: 0x06000A75 RID: 2677 RVA: 0x00037EA0 File Offset: 0x000360A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 701603, XrefRangeEnd = 701615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormVictoryPointSourcesPromptBehaviour.NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A76 RID: 2678 RVA: 0x00037EDC File Offset: 0x000360DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 701615, XrefRangeEnd = 701618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormVictoryPointSourcesPromptBehaviour()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormVictoryPointSourcesPromptBehaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormVictoryPointSourcesPromptBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A77 RID: 2679 RVA: 0x0000779A File Offset: 0x0000599A
		public WormVictoryPointSourcesPromptBehaviour(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002E7 RID: 743
		// (get) Token: 0x06000A78 RID: 2680 RVA: 0x00037F18 File Offset: 0x00036118
		// (set) Token: 0x06000A79 RID: 2681 RVA: 0x000077A3 File Offset: 0x000059A3
		public unsafe EntityView playerView
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormVictoryPointSourcesPromptBehaviour.NativeFieldInfoPtr_playerView);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityView>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormVictoryPointSourcesPromptBehaviour.NativeFieldInfoPtr_playerView), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400060A RID: 1546
		private static readonly IntPtr NativeFieldInfoPtr_playerView;

		// Token: 0x0400060B RID: 1547
		private static readonly IntPtr NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0;

		// Token: 0x0400060C RID: 1548
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
