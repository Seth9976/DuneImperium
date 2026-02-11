using System;
using boardgames.menus.ui;
using dwd.core.ui.prompt.behaviours;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using worm.match.prompts.prompts;

namespace worm.match.prompts.behaviours
{
	// Token: 0x020000D4 RID: 212
	public class WormEventQueuePromptBehaviour : PromptBehaviour<WormEventQueuePrompt>
	{
		// Token: 0x060008F9 RID: 2297 RVA: 0x00033A74 File Offset: 0x00031C74
		// Note: this type is marked as 'beforefieldinit'.
		static WormEventQueuePromptBehaviour()
		{
			Il2CppClassPointerStore<WormEventQueuePromptBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.prompts.behaviours", "WormEventQueuePromptBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormEventQueuePromptBehaviour>.NativeClassPtr);
			WormEventQueuePromptBehaviour.NativeFieldInfoPtr_maxEstimatedMinutes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEventQueuePromptBehaviour>.NativeClassPtr, "maxEstimatedMinutes");
			WormEventQueuePromptBehaviour.NativeFieldInfoPtr_estimatedWaitDisplay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEventQueuePromptBehaviour>.NativeClassPtr, "estimatedWaitDisplay");
			WormEventQueuePromptBehaviour.NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventQueuePromptBehaviour>.NativeClassPtr, 100664519);
			WormEventQueuePromptBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventQueuePromptBehaviour>.NativeClassPtr, 100664520);
		}

		// Token: 0x060008FA RID: 2298 RVA: 0x00033AF4 File Offset: 0x00031CF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 699188, XrefRangeEnd = 699222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormEventQueuePromptBehaviour.NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008FB RID: 2299 RVA: 0x00033B30 File Offset: 0x00031D30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 699222, XrefRangeEnd = 699225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormEventQueuePromptBehaviour()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormEventQueuePromptBehaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEventQueuePromptBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008FC RID: 2300 RVA: 0x000069A7 File Offset: 0x00004BA7
		public WormEventQueuePromptBehaviour(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000272 RID: 626
		// (get) Token: 0x060008FD RID: 2301 RVA: 0x00033B6C File Offset: 0x00031D6C
		// (set) Token: 0x060008FE RID: 2302 RVA: 0x000069B0 File Offset: 0x00004BB0
		public unsafe int maxEstimatedMinutes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventQueuePromptBehaviour.NativeFieldInfoPtr_maxEstimatedMinutes);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventQueuePromptBehaviour.NativeFieldInfoPtr_maxEstimatedMinutes)) = value;
			}
		}

		// Token: 0x17000273 RID: 627
		// (get) Token: 0x060008FF RID: 2303 RVA: 0x00033B94 File Offset: 0x00031D94
		// (set) Token: 0x06000900 RID: 2304 RVA: 0x000069CB File Offset: 0x00004BCB
		public unsafe TimerDisplay estimatedWaitDisplay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventQueuePromptBehaviour.NativeFieldInfoPtr_estimatedWaitDisplay);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TimerDisplay>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventQueuePromptBehaviour.NativeFieldInfoPtr_estimatedWaitDisplay), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400052B RID: 1323
		private static readonly IntPtr NativeFieldInfoPtr_maxEstimatedMinutes;

		// Token: 0x0400052C RID: 1324
		private static readonly IntPtr NativeFieldInfoPtr_estimatedWaitDisplay;

		// Token: 0x0400052D RID: 1325
		private static readonly IntPtr NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0;

		// Token: 0x0400052E RID: 1326
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
