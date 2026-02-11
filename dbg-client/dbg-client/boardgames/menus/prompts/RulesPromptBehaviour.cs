using System;
using dwd.core.ui.prompt.behaviours;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace boardgames.menus.prompts
{
	// Token: 0x020001DB RID: 475
	public class RulesPromptBehaviour : PromptBehaviour
	{
		// Token: 0x060015F3 RID: 5619 RVA: 0x00064724 File Offset: 0x00062924
		// Note: this type is marked as 'beforefieldinit'.
		static RulesPromptBehaviour()
		{
			Il2CppClassPointerStore<RulesPromptBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.menus.prompts", "RulesPromptBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RulesPromptBehaviour>.NativeClassPtr);
			RulesPromptBehaviour.NativeFieldInfoPtr_pages = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RulesPromptBehaviour>.NativeClassPtr, "pages");
			RulesPromptBehaviour.NativeFieldInfoPtr_contentsAnchor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RulesPromptBehaviour>.NativeClassPtr, "contentsAnchor");
			RulesPromptBehaviour.NativeFieldInfoPtr_contentsScrollRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RulesPromptBehaviour>.NativeClassPtr, "contentsScrollRect");
			RulesPromptBehaviour.NativeFieldInfoPtr_pagePrefabs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RulesPromptBehaviour>.NativeClassPtr, "pagePrefabs");
			RulesPromptBehaviour.NativeFieldInfoPtr_currentPageName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RulesPromptBehaviour>.NativeClassPtr, "currentPageName");
			RulesPromptBehaviour.NativeFieldInfoPtr_currentPage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RulesPromptBehaviour>.NativeClassPtr, "currentPage");
			RulesPromptBehaviour.NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RulesPromptBehaviour>.NativeClassPtr, 100666510);
			RulesPromptBehaviour.NativeMethodInfoPtr_Event_SwapPage_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RulesPromptBehaviour>.NativeClassPtr, 100666511);
			RulesPromptBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RulesPromptBehaviour>.NativeClassPtr, 100666512);
		}

		// Token: 0x060015F4 RID: 5620 RVA: 0x00064808 File Offset: 0x00062A08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 523293, XrefRangeEnd = 523320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RulesPromptBehaviour.NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015F5 RID: 5621 RVA: 0x00064844 File Offset: 0x00062A44
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 523343, RefRangeEnd = 523344, XrefRangeStart = 523320, XrefRangeEnd = 523343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_SwapPage(string newPage)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(newPage);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RulesPromptBehaviour.NativeMethodInfoPtr_Event_SwapPage_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060015F6 RID: 5622 RVA: 0x00064888 File Offset: 0x00062A88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 523344, XrefRangeEnd = 523356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RulesPromptBehaviour()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RulesPromptBehaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RulesPromptBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015F7 RID: 5623 RVA: 0x0000C6A8 File Offset: 0x0000A8A8
		public RulesPromptBehaviour(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005E2 RID: 1506
		// (get) Token: 0x060015F8 RID: 5624 RVA: 0x000648C4 File Offset: 0x00062AC4
		// (set) Token: 0x060015F9 RID: 5625 RVA: 0x0000C6B1 File Offset: 0x0000A8B1
		public unsafe Il2CppReferenceArray<RulesPromptBehaviour.NamedSection> pages
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RulesPromptBehaviour.NativeFieldInfoPtr_pages);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RulesPromptBehaviour.NamedSection>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RulesPromptBehaviour.NativeFieldInfoPtr_pages), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005E3 RID: 1507
		// (get) Token: 0x060015FA RID: 5626 RVA: 0x000648F4 File Offset: 0x00062AF4
		// (set) Token: 0x060015FB RID: 5627 RVA: 0x0000C6D0 File Offset: 0x0000A8D0
		public unsafe Transform contentsAnchor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RulesPromptBehaviour.NativeFieldInfoPtr_contentsAnchor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RulesPromptBehaviour.NativeFieldInfoPtr_contentsAnchor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005E4 RID: 1508
		// (get) Token: 0x060015FC RID: 5628 RVA: 0x00064924 File Offset: 0x00062B24
		// (set) Token: 0x060015FD RID: 5629 RVA: 0x0000C6EF File Offset: 0x0000A8EF
		public unsafe ScrollRect contentsScrollRect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RulesPromptBehaviour.NativeFieldInfoPtr_contentsScrollRect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ScrollRect>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RulesPromptBehaviour.NativeFieldInfoPtr_contentsScrollRect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005E5 RID: 1509
		// (get) Token: 0x060015FE RID: 5630 RVA: 0x00064954 File Offset: 0x00062B54
		// (set) Token: 0x060015FF RID: 5631 RVA: 0x0000C70E File Offset: 0x0000A90E
		public unsafe Dictionary<string, RulesPromptBehaviour.NamedSection> pagePrefabs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RulesPromptBehaviour.NativeFieldInfoPtr_pagePrefabs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, RulesPromptBehaviour.NamedSection>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RulesPromptBehaviour.NativeFieldInfoPtr_pagePrefabs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005E6 RID: 1510
		// (get) Token: 0x06001600 RID: 5632 RVA: 0x00064984 File Offset: 0x00062B84
		// (set) Token: 0x06001601 RID: 5633 RVA: 0x0000C72D File Offset: 0x0000A92D
		public unsafe string currentPageName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RulesPromptBehaviour.NativeFieldInfoPtr_currentPageName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RulesPromptBehaviour.NativeFieldInfoPtr_currentPageName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170005E7 RID: 1511
		// (get) Token: 0x06001602 RID: 5634 RVA: 0x000649AC File Offset: 0x00062BAC
		// (set) Token: 0x06001603 RID: 5635 RVA: 0x0000C74C File Offset: 0x0000A94C
		public unsafe GameObject currentPage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RulesPromptBehaviour.NativeFieldInfoPtr_currentPage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RulesPromptBehaviour.NativeFieldInfoPtr_currentPage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000D9A RID: 3482
		private static readonly IntPtr NativeFieldInfoPtr_pages;

		// Token: 0x04000D9B RID: 3483
		private static readonly IntPtr NativeFieldInfoPtr_contentsAnchor;

		// Token: 0x04000D9C RID: 3484
		private static readonly IntPtr NativeFieldInfoPtr_contentsScrollRect;

		// Token: 0x04000D9D RID: 3485
		private static readonly IntPtr NativeFieldInfoPtr_pagePrefabs;

		// Token: 0x04000D9E RID: 3486
		private static readonly IntPtr NativeFieldInfoPtr_currentPageName;

		// Token: 0x04000D9F RID: 3487
		private static readonly IntPtr NativeFieldInfoPtr_currentPage;

		// Token: 0x04000DA0 RID: 3488
		private static readonly IntPtr NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0;

		// Token: 0x04000DA1 RID: 3489
		private static readonly IntPtr NativeMethodInfoPtr_Event_SwapPage_Public_Void_String_0;

		// Token: 0x04000DA2 RID: 3490
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020003C9 RID: 969
		[Serializable]
		public class NamedSection : global::Il2CppSystem.Object
		{
			// Token: 0x06002D2B RID: 11563 RVA: 0x000AF6E0 File Offset: 0x000AD8E0
			// Note: this type is marked as 'beforefieldinit'.
			static NamedSection()
			{
				Il2CppClassPointerStore<RulesPromptBehaviour.NamedSection>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RulesPromptBehaviour>.NativeClassPtr, "NamedSection");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RulesPromptBehaviour.NamedSection>.NativeClassPtr);
				RulesPromptBehaviour.NamedSection.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RulesPromptBehaviour.NamedSection>.NativeClassPtr, "Name");
				RulesPromptBehaviour.NamedSection.NativeFieldInfoPtr_Prefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RulesPromptBehaviour.NamedSection>.NativeClassPtr, "Prefab");
				RulesPromptBehaviour.NamedSection.NativeFieldInfoPtr_Toggle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RulesPromptBehaviour.NamedSection>.NativeClassPtr, "Toggle");
				RulesPromptBehaviour.NamedSection.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RulesPromptBehaviour.NamedSection>.NativeClassPtr, 100666513);
			}

			// Token: 0x06002D2C RID: 11564 RVA: 0x000AF75C File Offset: 0x000AD95C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 523288, XrefRangeEnd = 523293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe NamedSection()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RulesPromptBehaviour.NamedSection>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RulesPromptBehaviour.NamedSection.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002D2D RID: 11565 RVA: 0x000175D4 File Offset: 0x000157D4
			public NamedSection(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000CD3 RID: 3283
			// (get) Token: 0x06002D2E RID: 11566 RVA: 0x000AF798 File Offset: 0x000AD998
			// (set) Token: 0x06002D2F RID: 11567 RVA: 0x000175DD File Offset: 0x000157DD
			public unsafe string Name
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RulesPromptBehaviour.NamedSection.NativeFieldInfoPtr_Name);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RulesPromptBehaviour.NamedSection.NativeFieldInfoPtr_Name), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000CD4 RID: 3284
			// (get) Token: 0x06002D30 RID: 11568 RVA: 0x000AF7C0 File Offset: 0x000AD9C0
			// (set) Token: 0x06002D31 RID: 11569 RVA: 0x000175FC File Offset: 0x000157FC
			public unsafe GameObject Prefab
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RulesPromptBehaviour.NamedSection.NativeFieldInfoPtr_Prefab);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RulesPromptBehaviour.NamedSection.NativeFieldInfoPtr_Prefab), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000CD5 RID: 3285
			// (get) Token: 0x06002D32 RID: 11570 RVA: 0x000AF7F0 File Offset: 0x000AD9F0
			// (set) Token: 0x06002D33 RID: 11571 RVA: 0x0001761B File Offset: 0x0001581B
			public unsafe Toggle Toggle
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RulesPromptBehaviour.NamedSection.NativeFieldInfoPtr_Toggle);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Toggle>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RulesPromptBehaviour.NamedSection.NativeFieldInfoPtr_Toggle), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001C06 RID: 7174
			private static readonly IntPtr NativeFieldInfoPtr_Name;

			// Token: 0x04001C07 RID: 7175
			private static readonly IntPtr NativeFieldInfoPtr_Prefab;

			// Token: 0x04001C08 RID: 7176
			private static readonly IntPtr NativeFieldInfoPtr_Toggle;

			// Token: 0x04001C09 RID: 7177
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
