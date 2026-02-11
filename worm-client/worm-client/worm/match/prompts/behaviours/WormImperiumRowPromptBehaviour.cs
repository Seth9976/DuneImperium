using System;
using boardgames.match.behaviours;
using dwd.core.ui.prompt.behaviours;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.match.prompts.behaviours
{
	// Token: 0x020000D8 RID: 216
	public class WormImperiumRowPromptBehaviour : PromptBehaviour
	{
		// Token: 0x06000919 RID: 2329 RVA: 0x00034020 File Offset: 0x00032220
		// Note: this type is marked as 'beforefieldinit'.
		static WormImperiumRowPromptBehaviour()
		{
			Il2CppClassPointerStore<WormImperiumRowPromptBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.prompts.behaviours", "WormImperiumRowPromptBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormImperiumRowPromptBehaviour>.NativeClassPtr);
			WormImperiumRowPromptBehaviour.NativeFieldInfoPtr_minimize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormImperiumRowPromptBehaviour>.NativeClassPtr, "minimize");
			WormImperiumRowPromptBehaviour.NativeFieldInfoPtr_shouldHighlightUnminimize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormImperiumRowPromptBehaviour>.NativeClassPtr, "shouldHighlightUnminimize");
			WormImperiumRowPromptBehaviour.NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormImperiumRowPromptBehaviour>.NativeClassPtr, 100664541);
			WormImperiumRowPromptBehaviour.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormImperiumRowPromptBehaviour>.NativeClassPtr, 100664542);
			WormImperiumRowPromptBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormImperiumRowPromptBehaviour>.NativeClassPtr, 100664543);
		}

		// Token: 0x0600091A RID: 2330 RVA: 0x000340B4 File Offset: 0x000322B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 699533, XrefRangeEnd = 699537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormImperiumRowPromptBehaviour.NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600091B RID: 2331 RVA: 0x000340F0 File Offset: 0x000322F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 699537, XrefRangeEnd = 699541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormImperiumRowPromptBehaviour.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600091C RID: 2332 RVA: 0x00034124 File Offset: 0x00032324
		[CallerCount(197)]
		[CachedScanResults(RefRangeStart = 496077, RefRangeEnd = 496274, XrefRangeStart = 496077, XrefRangeEnd = 496274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormImperiumRowPromptBehaviour()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormImperiumRowPromptBehaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormImperiumRowPromptBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600091D RID: 2333 RVA: 0x00006AA0 File Offset: 0x00004CA0
		public WormImperiumRowPromptBehaviour(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000279 RID: 633
		// (get) Token: 0x0600091E RID: 2334 RVA: 0x00034160 File Offset: 0x00032360
		// (set) Token: 0x0600091F RID: 2335 RVA: 0x00006AA9 File Offset: 0x00004CA9
		public unsafe MinimizablePrompt minimize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormImperiumRowPromptBehaviour.NativeFieldInfoPtr_minimize);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MinimizablePrompt>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormImperiumRowPromptBehaviour.NativeFieldInfoPtr_minimize), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700027A RID: 634
		// (get) Token: 0x06000920 RID: 2336 RVA: 0x00034190 File Offset: 0x00032390
		// (set) Token: 0x06000921 RID: 2337 RVA: 0x00006AC8 File Offset: 0x00004CC8
		public unsafe bool shouldHighlightUnminimize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormImperiumRowPromptBehaviour.NativeFieldInfoPtr_shouldHighlightUnminimize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormImperiumRowPromptBehaviour.NativeFieldInfoPtr_shouldHighlightUnminimize)) = value;
			}
		}

		// Token: 0x0400053C RID: 1340
		private static readonly IntPtr NativeFieldInfoPtr_minimize;

		// Token: 0x0400053D RID: 1341
		private static readonly IntPtr NativeFieldInfoPtr_shouldHighlightUnminimize;

		// Token: 0x0400053E RID: 1342
		private static readonly IntPtr NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0;

		// Token: 0x0400053F RID: 1343
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04000540 RID: 1344
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
