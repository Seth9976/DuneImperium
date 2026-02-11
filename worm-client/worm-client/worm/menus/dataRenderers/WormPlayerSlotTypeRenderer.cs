using System;
using boardgames.data;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using TMPro;

namespace worm.menus.dataRenderers
{
	// Token: 0x02000094 RID: 148
	public class WormPlayerSlotTypeRenderer : VersionedSubscriber<PlayerTypeData>
	{
		// Token: 0x060005C5 RID: 1477 RVA: 0x0002A554 File Offset: 0x00028754
		// Note: this type is marked as 'beforefieldinit'.
		static WormPlayerSlotTypeRenderer()
		{
			Il2CppClassPointerStore<WormPlayerSlotTypeRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.menus.dataRenderers", "WormPlayerSlotTypeRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormPlayerSlotTypeRenderer>.NativeClassPtr);
			WormPlayerSlotTypeRenderer.NativeFieldInfoPtr_playerTypeText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayerSlotTypeRenderer>.NativeClassPtr, "playerTypeText");
			WormPlayerSlotTypeRenderer.NativeFieldInfoPtr_prompt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayerSlotTypeRenderer>.NativeClassPtr, "prompt");
			WormPlayerSlotTypeRenderer.NativeMethodInfoPtr_start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerSlotTypeRenderer>.NativeClassPtr, 100664123);
			WormPlayerSlotTypeRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerSlotTypeRenderer>.NativeClassPtr, 100664124);
			WormPlayerSlotTypeRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerSlotTypeRenderer>.NativeClassPtr, 100664125);
		}

		// Token: 0x060005C6 RID: 1478 RVA: 0x0002A5E8 File Offset: 0x000287E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 695606, XrefRangeEnd = 695610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormPlayerSlotTypeRenderer.NativeMethodInfoPtr_start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005C7 RID: 1479 RVA: 0x0002A624 File Offset: 0x00028824
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 695610, XrefRangeEnd = 695631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormPlayerSlotTypeRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005C8 RID: 1480 RVA: 0x0002A660 File Offset: 0x00028860
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 695631, XrefRangeEnd = 695634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormPlayerSlotTypeRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormPlayerSlotTypeRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayerSlotTypeRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005C9 RID: 1481 RVA: 0x00004DFA File Offset: 0x00002FFA
		public WormPlayerSlotTypeRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000175 RID: 373
		// (get) Token: 0x060005CA RID: 1482 RVA: 0x0002A69C File Offset: 0x0002889C
		// (set) Token: 0x060005CB RID: 1483 RVA: 0x00004E03 File Offset: 0x00003003
		public unsafe TMP_Text playerTypeText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerSlotTypeRenderer.NativeFieldInfoPtr_playerTypeText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerSlotTypeRenderer.NativeFieldInfoPtr_playerTypeText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000176 RID: 374
		// (get) Token: 0x060005CC RID: 1484 RVA: 0x0002A6CC File Offset: 0x000288CC
		// (set) Token: 0x060005CD RID: 1485 RVA: 0x00004E22 File Offset: 0x00003022
		public unsafe WormConfigureGamePromptBehaviour prompt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerSlotTypeRenderer.NativeFieldInfoPtr_prompt);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormConfigureGamePromptBehaviour>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerSlotTypeRenderer.NativeFieldInfoPtr_prompt), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000354 RID: 852
		private static readonly IntPtr NativeFieldInfoPtr_playerTypeText;

		// Token: 0x04000355 RID: 853
		private static readonly IntPtr NativeFieldInfoPtr_prompt;

		// Token: 0x04000356 RID: 854
		private static readonly IntPtr NativeMethodInfoPtr_start_Protected_Virtual_Void_0;

		// Token: 0x04000357 RID: 855
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

		// Token: 0x04000358 RID: 856
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
