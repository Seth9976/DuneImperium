using System;
using boardgames.match.selection;
using dwd.core.ui.prompt.behaviours;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using TMPro;
using UnityEngine;

namespace worm.match.prompts.behaviours
{
	// Token: 0x020000E3 RID: 227
	public class WormSellMelangePromptBehaviour : PromptBehaviour<ArchetypeCustomChoiceInfoPrompt>
	{
		// Token: 0x06000A04 RID: 2564 RVA: 0x00036A38 File Offset: 0x00034C38
		// Note: this type is marked as 'beforefieldinit'.
		static WormSellMelangePromptBehaviour()
		{
			Il2CppClassPointerStore<WormSellMelangePromptBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.prompts.behaviours", "WormSellMelangePromptBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormSellMelangePromptBehaviour>.NativeClassPtr);
			WormSellMelangePromptBehaviour.NativeFieldInfoPtr_incrementArrow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSellMelangePromptBehaviour>.NativeClassPtr, "incrementArrow");
			WormSellMelangePromptBehaviour.NativeFieldInfoPtr_decrementArrow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSellMelangePromptBehaviour>.NativeClassPtr, "decrementArrow");
			WormSellMelangePromptBehaviour.NativeFieldInfoPtr_sellText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSellMelangePromptBehaviour>.NativeClassPtr, "sellText");
			WormSellMelangePromptBehaviour.NativeFieldInfoPtr_buyText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSellMelangePromptBehaviour>.NativeClassPtr, "buyText");
			WormSellMelangePromptBehaviour.NativeFieldInfoPtr_minSellAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSellMelangePromptBehaviour>.NativeClassPtr, "minSellAmount");
			WormSellMelangePromptBehaviour.NativeFieldInfoPtr_maxSellAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSellMelangePromptBehaviour>.NativeClassPtr, "maxSellAmount");
			WormSellMelangePromptBehaviour.NativeFieldInfoPtr_sellAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSellMelangePromptBehaviour>.NativeClassPtr, "sellAmount");
			WormSellMelangePromptBehaviour.NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSellMelangePromptBehaviour>.NativeClassPtr, 100664675);
			WormSellMelangePromptBehaviour.NativeMethodInfoPtr_Event_ChangeAmount_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSellMelangePromptBehaviour>.NativeClassPtr, 100664676);
			WormSellMelangePromptBehaviour.NativeMethodInfoPtr_Event_Resolve_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSellMelangePromptBehaviour>.NativeClassPtr, 100664677);
			WormSellMelangePromptBehaviour.NativeMethodInfoPtr_UpdateElements_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSellMelangePromptBehaviour>.NativeClassPtr, 100664678);
			WormSellMelangePromptBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSellMelangePromptBehaviour>.NativeClassPtr, 100664679);
		}

		// Token: 0x06000A05 RID: 2565 RVA: 0x00036B58 File Offset: 0x00034D58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 701017, XrefRangeEnd = 701035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormSellMelangePromptBehaviour.NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A06 RID: 2566 RVA: 0x00036B94 File Offset: 0x00034D94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 701035, XrefRangeEnd = 701036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_ChangeAmount(int amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref amount;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSellMelangePromptBehaviour.NativeMethodInfoPtr_Event_ChangeAmount_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A07 RID: 2567 RVA: 0x00036BD4 File Offset: 0x00034DD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 701036, XrefRangeEnd = 701052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_Resolve()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSellMelangePromptBehaviour.NativeMethodInfoPtr_Event_Resolve_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A08 RID: 2568 RVA: 0x00036C08 File Offset: 0x00034E08
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 701056, RefRangeEnd = 701058, XrefRangeStart = 701052, XrefRangeEnd = 701056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateElements()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSellMelangePromptBehaviour.NativeMethodInfoPtr_UpdateElements_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A09 RID: 2569 RVA: 0x00036C3C File Offset: 0x00034E3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 701058, XrefRangeEnd = 701061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormSellMelangePromptBehaviour()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormSellMelangePromptBehaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSellMelangePromptBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A0A RID: 2570 RVA: 0x00007379 File Offset: 0x00005579
		public WormSellMelangePromptBehaviour(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002C3 RID: 707
		// (get) Token: 0x06000A0B RID: 2571 RVA: 0x00036C78 File Offset: 0x00034E78
		// (set) Token: 0x06000A0C RID: 2572 RVA: 0x00007382 File Offset: 0x00005582
		public unsafe GameObject incrementArrow
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSellMelangePromptBehaviour.NativeFieldInfoPtr_incrementArrow);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSellMelangePromptBehaviour.NativeFieldInfoPtr_incrementArrow), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002C4 RID: 708
		// (get) Token: 0x06000A0D RID: 2573 RVA: 0x00036CA8 File Offset: 0x00034EA8
		// (set) Token: 0x06000A0E RID: 2574 RVA: 0x000073A1 File Offset: 0x000055A1
		public unsafe GameObject decrementArrow
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSellMelangePromptBehaviour.NativeFieldInfoPtr_decrementArrow);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSellMelangePromptBehaviour.NativeFieldInfoPtr_decrementArrow), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002C5 RID: 709
		// (get) Token: 0x06000A0F RID: 2575 RVA: 0x00036CD8 File Offset: 0x00034ED8
		// (set) Token: 0x06000A10 RID: 2576 RVA: 0x000073C0 File Offset: 0x000055C0
		public unsafe TMP_Text sellText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSellMelangePromptBehaviour.NativeFieldInfoPtr_sellText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSellMelangePromptBehaviour.NativeFieldInfoPtr_sellText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002C6 RID: 710
		// (get) Token: 0x06000A11 RID: 2577 RVA: 0x00036D08 File Offset: 0x00034F08
		// (set) Token: 0x06000A12 RID: 2578 RVA: 0x000073DF File Offset: 0x000055DF
		public unsafe TMP_Text buyText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSellMelangePromptBehaviour.NativeFieldInfoPtr_buyText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSellMelangePromptBehaviour.NativeFieldInfoPtr_buyText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002C7 RID: 711
		// (get) Token: 0x06000A13 RID: 2579 RVA: 0x00036D38 File Offset: 0x00034F38
		// (set) Token: 0x06000A14 RID: 2580 RVA: 0x000073FE File Offset: 0x000055FE
		public unsafe int minSellAmount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSellMelangePromptBehaviour.NativeFieldInfoPtr_minSellAmount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSellMelangePromptBehaviour.NativeFieldInfoPtr_minSellAmount)) = value;
			}
		}

		// Token: 0x170002C8 RID: 712
		// (get) Token: 0x06000A15 RID: 2581 RVA: 0x00036D60 File Offset: 0x00034F60
		// (set) Token: 0x06000A16 RID: 2582 RVA: 0x00007419 File Offset: 0x00005619
		public unsafe int maxSellAmount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSellMelangePromptBehaviour.NativeFieldInfoPtr_maxSellAmount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSellMelangePromptBehaviour.NativeFieldInfoPtr_maxSellAmount)) = value;
			}
		}

		// Token: 0x170002C9 RID: 713
		// (get) Token: 0x06000A17 RID: 2583 RVA: 0x00036D88 File Offset: 0x00034F88
		// (set) Token: 0x06000A18 RID: 2584 RVA: 0x00007434 File Offset: 0x00005634
		public unsafe int sellAmount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSellMelangePromptBehaviour.NativeFieldInfoPtr_sellAmount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSellMelangePromptBehaviour.NativeFieldInfoPtr_sellAmount)) = value;
			}
		}

		// Token: 0x040005C9 RID: 1481
		private static readonly IntPtr NativeFieldInfoPtr_incrementArrow;

		// Token: 0x040005CA RID: 1482
		private static readonly IntPtr NativeFieldInfoPtr_decrementArrow;

		// Token: 0x040005CB RID: 1483
		private static readonly IntPtr NativeFieldInfoPtr_sellText;

		// Token: 0x040005CC RID: 1484
		private static readonly IntPtr NativeFieldInfoPtr_buyText;

		// Token: 0x040005CD RID: 1485
		private static readonly IntPtr NativeFieldInfoPtr_minSellAmount;

		// Token: 0x040005CE RID: 1486
		private static readonly IntPtr NativeFieldInfoPtr_maxSellAmount;

		// Token: 0x040005CF RID: 1487
		private static readonly IntPtr NativeFieldInfoPtr_sellAmount;

		// Token: 0x040005D0 RID: 1488
		private static readonly IntPtr NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0;

		// Token: 0x040005D1 RID: 1489
		private static readonly IntPtr NativeMethodInfoPtr_Event_ChangeAmount_Public_Void_Int32_0;

		// Token: 0x040005D2 RID: 1490
		private static readonly IntPtr NativeMethodInfoPtr_Event_Resolve_Public_Void_0;

		// Token: 0x040005D3 RID: 1491
		private static readonly IntPtr NativeMethodInfoPtr_UpdateElements_Private_Void_0;

		// Token: 0x040005D4 RID: 1492
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
