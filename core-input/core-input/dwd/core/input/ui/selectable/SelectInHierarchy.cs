using System;
using dwd.core.util;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace dwd.core.input.ui.selectable
{
	// Token: 0x0200005F RID: 95
	public sealed class SelectInHierarchy : MonoBehaviour
	{
		// Token: 0x06000389 RID: 905 RVA: 0x00011D34 File Offset: 0x0000FF34
		// Note: this type is marked as 'beforefieldinit'.
		static SelectInHierarchy()
		{
			Il2CppClassPointerStore<SelectInHierarchy>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-input.dll", "dwd.core.input.ui.selectable", "SelectInHierarchy");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SelectInHierarchy>.NativeClassPtr);
			SelectInHierarchy.NativeFieldInfoPtr_hierarchyParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectInHierarchy>.NativeClassPtr, "hierarchyParent");
			SelectInHierarchy.NativeFieldInfoPtr_reuseLastSelected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectInHierarchy>.NativeClassPtr, "reuseLastSelected");
			SelectInHierarchy.NativeFieldInfoPtr_onSelectionSucceeded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectInHierarchy>.NativeClassPtr, "onSelectionSucceeded");
			SelectInHierarchy.NativeFieldInfoPtr_onSelectionFailed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectInHierarchy>.NativeClassPtr, "onSelectionFailed");
			SelectInHierarchy.NativeFieldInfoPtr_eventSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectInHierarchy>.NativeClassPtr, "eventSystem");
			SelectInHierarchy.NativeFieldInfoPtr_cachedCandidateSelectables = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectInHierarchy>.NativeClassPtr, "cachedCandidateSelectables");
			SelectInHierarchy.NativeFieldInfoPtr_cachedVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectInHierarchy>.NativeClassPtr, "cachedVersion");
			SelectInHierarchy.NativeFieldInfoPtr_candidateLastSeenSelected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectInHierarchy>.NativeClassPtr, "candidateLastSeenSelected");
			SelectInHierarchy.NativeMethodInfoPtr_get_candidateSelectables_Private_get_IEnumerable_1_Selectable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectInHierarchy>.NativeClassPtr, 100663696);
			SelectInHierarchy.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectInHierarchy>.NativeClassPtr, 100663697);
			SelectInHierarchy.NativeMethodInfoPtr_Event_SelectInHierarchy_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectInHierarchy>.NativeClassPtr, 100663698);
			SelectInHierarchy.NativeMethodInfoPtr_Event_SelectIndexInHierarchy_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectInHierarchy>.NativeClassPtr, 100663699);
			SelectInHierarchy.NativeMethodInfoPtr_Event_ResetLastSelected_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectInHierarchy>.NativeClassPtr, 100663700);
			SelectInHierarchy.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectInHierarchy>.NativeClassPtr, 100663701);
			SelectInHierarchy.NativeMethodInfoPtr_isSelectableCurrentlyValid_Private_Boolean_Selectable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectInHierarchy>.NativeClassPtr, 100663702);
			SelectInHierarchy.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectInHierarchy>.NativeClassPtr, 100663703);
			SelectInHierarchy.NativeMethodInfoPtr__Event_SelectIndexInHierarchy_b__12_0_Private_Boolean_Selectable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectInHierarchy>.NativeClassPtr, 100663704);
		}

		// Token: 0x17000100 RID: 256
		// (get) Token: 0x0600038A RID: 906 RVA: 0x00011EB8 File Offset: 0x000100B8
		public unsafe IEnumerable<Selectable> candidateSelectables
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1121832, RefRangeEnd = 1121835, XrefRangeStart = 1121828, XrefRangeEnd = 1121832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectInHierarchy.NativeMethodInfoPtr_get_candidateSelectables_Private_get_IEnumerable_1_Selectable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Selectable>>(intPtr3) : null;
			}
		}

		// Token: 0x0600038B RID: 907 RVA: 0x00011EF8 File Offset: 0x000100F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1121835, XrefRangeEnd = 1121848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectInHierarchy.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600038C RID: 908 RVA: 0x00011F2C File Offset: 0x0001012C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1121848, XrefRangeEnd = 1121878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_SelectInHierarchy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectInHierarchy.NativeMethodInfoPtr_Event_SelectInHierarchy_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600038D RID: 909 RVA: 0x00011F60 File Offset: 0x00010160
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1121878, XrefRangeEnd = 1121906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_SelectIndexInHierarchy(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectInHierarchy.NativeMethodInfoPtr_Event_SelectIndexInHierarchy_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600038E RID: 910 RVA: 0x00011FA0 File Offset: 0x000101A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_ResetLastSelected()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectInHierarchy.NativeMethodInfoPtr_Event_ResetLastSelected_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600038F RID: 911 RVA: 0x00011FD4 File Offset: 0x000101D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1121906, XrefRangeEnd = 1121925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectInHierarchy.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000390 RID: 912 RVA: 0x00012008 File Offset: 0x00010208
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1121925, XrefRangeEnd = 1121930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool isSelectableCurrentlyValid(Selectable selectable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(selectable);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectInHierarchy.NativeMethodInfoPtr_isSelectableCurrentlyValid_Private_Boolean_Selectable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000391 RID: 913 RVA: 0x00012058 File Offset: 0x00010258
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SelectInHierarchy()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SelectInHierarchy>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectInHierarchy.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000392 RID: 914 RVA: 0x00012094 File Offset: 0x00010294
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _Event_SelectIndexInHierarchy_b__12_0(Selectable x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectInHierarchy.NativeMethodInfoPtr__Event_SelectIndexInHierarchy_b__12_0_Private_Boolean_Selectable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000393 RID: 915 RVA: 0x000040EC File Offset: 0x000022EC
		public SelectInHierarchy(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x06000394 RID: 916 RVA: 0x000120E4 File Offset: 0x000102E4
		// (set) Token: 0x06000395 RID: 917 RVA: 0x000040F5 File Offset: 0x000022F5
		public unsafe VersionedParentTransform hierarchyParent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectInHierarchy.NativeFieldInfoPtr_hierarchyParent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VersionedParentTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectInHierarchy.NativeFieldInfoPtr_hierarchyParent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x06000396 RID: 918 RVA: 0x00012114 File Offset: 0x00010314
		// (set) Token: 0x06000397 RID: 919 RVA: 0x00004114 File Offset: 0x00002314
		public unsafe bool reuseLastSelected
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectInHierarchy.NativeFieldInfoPtr_reuseLastSelected);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectInHierarchy.NativeFieldInfoPtr_reuseLastSelected)) = value;
			}
		}

		// Token: 0x170000FA RID: 250
		// (get) Token: 0x06000398 RID: 920 RVA: 0x0001213C File Offset: 0x0001033C
		// (set) Token: 0x06000399 RID: 921 RVA: 0x0000412F File Offset: 0x0000232F
		public unsafe UnityEvent onSelectionSucceeded
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectInHierarchy.NativeFieldInfoPtr_onSelectionSucceeded);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectInHierarchy.NativeFieldInfoPtr_onSelectionSucceeded), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000FB RID: 251
		// (get) Token: 0x0600039A RID: 922 RVA: 0x0001216C File Offset: 0x0001036C
		// (set) Token: 0x0600039B RID: 923 RVA: 0x0000414E File Offset: 0x0000234E
		public unsafe UnityEvent onSelectionFailed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectInHierarchy.NativeFieldInfoPtr_onSelectionFailed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectInHierarchy.NativeFieldInfoPtr_onSelectionFailed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000FC RID: 252
		// (get) Token: 0x0600039C RID: 924 RVA: 0x0001219C File Offset: 0x0001039C
		// (set) Token: 0x0600039D RID: 925 RVA: 0x0000416D File Offset: 0x0000236D
		public unsafe EventSystem eventSystem
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectInHierarchy.NativeFieldInfoPtr_eventSystem);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventSystem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectInHierarchy.NativeFieldInfoPtr_eventSystem), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000FD RID: 253
		// (get) Token: 0x0600039E RID: 926 RVA: 0x000121CC File Offset: 0x000103CC
		// (set) Token: 0x0600039F RID: 927 RVA: 0x0000418C File Offset: 0x0000238C
		public unsafe Il2CppReferenceArray<Selectable> cachedCandidateSelectables
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectInHierarchy.NativeFieldInfoPtr_cachedCandidateSelectables);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Selectable>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectInHierarchy.NativeFieldInfoPtr_cachedCandidateSelectables), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000FE RID: 254
		// (get) Token: 0x060003A0 RID: 928 RVA: 0x000121FC File Offset: 0x000103FC
		// (set) Token: 0x060003A1 RID: 929 RVA: 0x000041AB File Offset: 0x000023AB
		public unsafe ulong cachedVersion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectInHierarchy.NativeFieldInfoPtr_cachedVersion);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectInHierarchy.NativeFieldInfoPtr_cachedVersion)) = value;
			}
		}

		// Token: 0x170000FF RID: 255
		// (get) Token: 0x060003A2 RID: 930 RVA: 0x00012224 File Offset: 0x00010424
		// (set) Token: 0x060003A3 RID: 931 RVA: 0x000041C6 File Offset: 0x000023C6
		public unsafe Selectable candidateLastSeenSelected
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectInHierarchy.NativeFieldInfoPtr_candidateLastSeenSelected);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Selectable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectInHierarchy.NativeFieldInfoPtr_candidateLastSeenSelected), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000210 RID: 528
		private static readonly IntPtr NativeFieldInfoPtr_hierarchyParent;

		// Token: 0x04000211 RID: 529
		private static readonly IntPtr NativeFieldInfoPtr_reuseLastSelected;

		// Token: 0x04000212 RID: 530
		private static readonly IntPtr NativeFieldInfoPtr_onSelectionSucceeded;

		// Token: 0x04000213 RID: 531
		private static readonly IntPtr NativeFieldInfoPtr_onSelectionFailed;

		// Token: 0x04000214 RID: 532
		private static readonly IntPtr NativeFieldInfoPtr_eventSystem;

		// Token: 0x04000215 RID: 533
		private static readonly IntPtr NativeFieldInfoPtr_cachedCandidateSelectables;

		// Token: 0x04000216 RID: 534
		private static readonly IntPtr NativeFieldInfoPtr_cachedVersion;

		// Token: 0x04000217 RID: 535
		private static readonly IntPtr NativeFieldInfoPtr_candidateLastSeenSelected;

		// Token: 0x04000218 RID: 536
		private static readonly IntPtr NativeMethodInfoPtr_get_candidateSelectables_Private_get_IEnumerable_1_Selectable_0;

		// Token: 0x04000219 RID: 537
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x0400021A RID: 538
		private static readonly IntPtr NativeMethodInfoPtr_Event_SelectInHierarchy_Public_Void_0;

		// Token: 0x0400021B RID: 539
		private static readonly IntPtr NativeMethodInfoPtr_Event_SelectIndexInHierarchy_Public_Void_Int32_0;

		// Token: 0x0400021C RID: 540
		private static readonly IntPtr NativeMethodInfoPtr_Event_ResetLastSelected_Public_Void_0;

		// Token: 0x0400021D RID: 541
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x0400021E RID: 542
		private static readonly IntPtr NativeMethodInfoPtr_isSelectableCurrentlyValid_Private_Boolean_Selectable_0;

		// Token: 0x0400021F RID: 543
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000220 RID: 544
		private static readonly IntPtr NativeMethodInfoPtr__Event_SelectIndexInHierarchy_b__12_0_Private_Boolean_Selectable_0;
	}
}
