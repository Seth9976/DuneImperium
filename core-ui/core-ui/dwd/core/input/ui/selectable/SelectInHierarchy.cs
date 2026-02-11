using System;
using dwd.core.util;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace dwd.core.input.ui.selectable
{
	// Token: 0x0200000E RID: 14
	public sealed class SelectInHierarchy : MonoBehaviour
	{
		// Token: 0x0600008C RID: 140 RVA: 0x00004918 File Offset: 0x00002B18
		// Note: this type is marked as 'beforefieldinit'.
		static SelectInHierarchy()
		{
			Il2CppClassPointerStore<SelectInHierarchy>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-ui.dll", "dwd.core.input.ui.selectable", "SelectInHierarchy");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SelectInHierarchy>.NativeClassPtr);
			SelectInHierarchy.NativeFieldInfoPtr_hierarchyParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectInHierarchy>.NativeClassPtr, "hierarchyParent");
			SelectInHierarchy.NativeFieldInfoPtr_reuseLastSelected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectInHierarchy>.NativeClassPtr, "reuseLastSelected");
			SelectInHierarchy.NativeFieldInfoPtr_onSelectionSucceeded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectInHierarchy>.NativeClassPtr, "onSelectionSucceeded");
			SelectInHierarchy.NativeFieldInfoPtr_onSelectionFailed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectInHierarchy>.NativeClassPtr, "onSelectionFailed");
			SelectInHierarchy.NativeFieldInfoPtr_eventSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectInHierarchy>.NativeClassPtr, "eventSystem");
			SelectInHierarchy.NativeFieldInfoPtr_cachedCandidateSelectables = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectInHierarchy>.NativeClassPtr, "cachedCandidateSelectables");
			SelectInHierarchy.NativeFieldInfoPtr_cachedVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectInHierarchy>.NativeClassPtr, "cachedVersion");
			SelectInHierarchy.NativeFieldInfoPtr_candidateLastSeenSelected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectInHierarchy>.NativeClassPtr, "candidateLastSeenSelected");
			SelectInHierarchy.NativeMethodInfoPtr_get_candidateSelectables_Private_get_IEnumerable_1_Selectable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectInHierarchy>.NativeClassPtr, 100663380);
			SelectInHierarchy.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectInHierarchy>.NativeClassPtr, 100663381);
			SelectInHierarchy.NativeMethodInfoPtr_Event_SelectInHierarchy_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectInHierarchy>.NativeClassPtr, 100663382);
			SelectInHierarchy.NativeMethodInfoPtr_Event_SelectIndexInHierarchy_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectInHierarchy>.NativeClassPtr, 100663383);
			SelectInHierarchy.NativeMethodInfoPtr_Event_ResetLastSelected_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectInHierarchy>.NativeClassPtr, 100663384);
			SelectInHierarchy.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectInHierarchy>.NativeClassPtr, 100663385);
			SelectInHierarchy.NativeMethodInfoPtr_isSelectableCurrentlyValid_Private_Static_Boolean_Selectable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectInHierarchy>.NativeClassPtr, 100663386);
			SelectInHierarchy.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectInHierarchy>.NativeClassPtr, 100663387);
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x0600008D RID: 141 RVA: 0x00004A88 File Offset: 0x00002C88
		public unsafe IEnumerable<Selectable> candidateSelectables
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1254187, RefRangeEnd = 1254190, XrefRangeStart = 1254183, XrefRangeEnd = 1254187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x0600008E RID: 142 RVA: 0x00004AC8 File Offset: 0x00002CC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1254190, XrefRangeEnd = 1254203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectInHierarchy.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600008F RID: 143 RVA: 0x00004AFC File Offset: 0x00002CFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1254203, XrefRangeEnd = 1254233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_SelectInHierarchy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectInHierarchy.NativeMethodInfoPtr_Event_SelectInHierarchy_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000090 RID: 144 RVA: 0x00004B30 File Offset: 0x00002D30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1254233, XrefRangeEnd = 1254273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06000091 RID: 145 RVA: 0x00004B70 File Offset: 0x00002D70
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

		// Token: 0x06000092 RID: 146 RVA: 0x00004BA4 File Offset: 0x00002DA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1254273, XrefRangeEnd = 1254292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectInHierarchy.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000093 RID: 147 RVA: 0x00004BD8 File Offset: 0x00002DD8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1254297, RefRangeEnd = 1254298, XrefRangeStart = 1254292, XrefRangeEnd = 1254297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool isSelectableCurrentlyValid(Selectable selectable)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(selectable);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectInHierarchy.NativeMethodInfoPtr_isSelectableCurrentlyValid_Private_Static_Boolean_Selectable_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000094 RID: 148 RVA: 0x00004C1C File Offset: 0x00002E1C
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

		// Token: 0x06000095 RID: 149 RVA: 0x000023BD File Offset: 0x000005BD
		public SelectInHierarchy(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000096 RID: 150 RVA: 0x00004C58 File Offset: 0x00002E58
		// (set) Token: 0x06000097 RID: 151 RVA: 0x000023C6 File Offset: 0x000005C6
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

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000098 RID: 152 RVA: 0x00004C88 File Offset: 0x00002E88
		// (set) Token: 0x06000099 RID: 153 RVA: 0x000023E5 File Offset: 0x000005E5
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

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x0600009A RID: 154 RVA: 0x00004CB0 File Offset: 0x00002EB0
		// (set) Token: 0x0600009B RID: 155 RVA: 0x00002400 File Offset: 0x00000600
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

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x0600009C RID: 156 RVA: 0x00004CE0 File Offset: 0x00002EE0
		// (set) Token: 0x0600009D RID: 157 RVA: 0x0000241F File Offset: 0x0000061F
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

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x0600009E RID: 158 RVA: 0x00004D10 File Offset: 0x00002F10
		// (set) Token: 0x0600009F RID: 159 RVA: 0x0000243E File Offset: 0x0000063E
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

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x060000A0 RID: 160 RVA: 0x00004D40 File Offset: 0x00002F40
		// (set) Token: 0x060000A1 RID: 161 RVA: 0x0000245D File Offset: 0x0000065D
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

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x060000A2 RID: 162 RVA: 0x00004D70 File Offset: 0x00002F70
		// (set) Token: 0x060000A3 RID: 163 RVA: 0x0000247C File Offset: 0x0000067C
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

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x060000A4 RID: 164 RVA: 0x00004D98 File Offset: 0x00002F98
		// (set) Token: 0x060000A5 RID: 165 RVA: 0x00002497 File Offset: 0x00000697
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

		// Token: 0x0400005C RID: 92
		private static readonly IntPtr NativeFieldInfoPtr_hierarchyParent;

		// Token: 0x0400005D RID: 93
		private static readonly IntPtr NativeFieldInfoPtr_reuseLastSelected;

		// Token: 0x0400005E RID: 94
		private static readonly IntPtr NativeFieldInfoPtr_onSelectionSucceeded;

		// Token: 0x0400005F RID: 95
		private static readonly IntPtr NativeFieldInfoPtr_onSelectionFailed;

		// Token: 0x04000060 RID: 96
		private static readonly IntPtr NativeFieldInfoPtr_eventSystem;

		// Token: 0x04000061 RID: 97
		private static readonly IntPtr NativeFieldInfoPtr_cachedCandidateSelectables;

		// Token: 0x04000062 RID: 98
		private static readonly IntPtr NativeFieldInfoPtr_cachedVersion;

		// Token: 0x04000063 RID: 99
		private static readonly IntPtr NativeFieldInfoPtr_candidateLastSeenSelected;

		// Token: 0x04000064 RID: 100
		private static readonly IntPtr NativeMethodInfoPtr_get_candidateSelectables_Private_get_IEnumerable_1_Selectable_0;

		// Token: 0x04000065 RID: 101
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04000066 RID: 102
		private static readonly IntPtr NativeMethodInfoPtr_Event_SelectInHierarchy_Public_Void_0;

		// Token: 0x04000067 RID: 103
		private static readonly IntPtr NativeMethodInfoPtr_Event_SelectIndexInHierarchy_Public_Void_Int32_0;

		// Token: 0x04000068 RID: 104
		private static readonly IntPtr NativeMethodInfoPtr_Event_ResetLastSelected_Public_Void_0;

		// Token: 0x04000069 RID: 105
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x0400006A RID: 106
		private static readonly IntPtr NativeMethodInfoPtr_isSelectableCurrentlyValid_Private_Static_Boolean_Selectable_0;

		// Token: 0x0400006B RID: 107
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000026 RID: 38
		[ObfuscatedName("dwd.core.input.ui.selectable.SelectInHierarchy+<>c")]
		[Serializable]
		public sealed class __c : global::Il2CppSystem.Object
		{
			// Token: 0x06000173 RID: 371 RVA: 0x000073C4 File Offset: 0x000055C4
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<SelectInHierarchy.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SelectInHierarchy>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SelectInHierarchy.__c>.NativeClassPtr);
				SelectInHierarchy.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectInHierarchy.__c>.NativeClassPtr, "<>9");
				SelectInHierarchy.__c.NativeFieldInfoPtr___9__12_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectInHierarchy.__c>.NativeClassPtr, "<>9__12_0");
				SelectInHierarchy.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectInHierarchy.__c>.NativeClassPtr, 100663389);
				SelectInHierarchy.__c.NativeMethodInfoPtr__Event_SelectIndexInHierarchy_b__12_0_Internal_Boolean_Selectable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectInHierarchy.__c>.NativeClassPtr, 100663390);
			}

			// Token: 0x06000174 RID: 372 RVA: 0x00007440 File Offset: 0x00005640
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SelectInHierarchy.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectInHierarchy.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000175 RID: 373 RVA: 0x0000747C File Offset: 0x0000567C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1254178, XrefRangeEnd = 1254183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Event_SelectIndexInHierarchy_b__12_0(Selectable x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectInHierarchy.__c.NativeMethodInfoPtr__Event_SelectIndexInHierarchy_b__12_0_Internal_Boolean_Selectable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000176 RID: 374 RVA: 0x00002B1A File Offset: 0x00000D1A
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700005B RID: 91
			// (get) Token: 0x06000177 RID: 375 RVA: 0x000074CC File Offset: 0x000056CC
			// (set) Token: 0x06000178 RID: 376 RVA: 0x00002B23 File Offset: 0x00000D23
			public unsafe static SelectInHierarchy.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SelectInHierarchy.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SelectInHierarchy.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SelectInHierarchy.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700005C RID: 92
			// (get) Token: 0x06000179 RID: 377 RVA: 0x000074F4 File Offset: 0x000056F4
			// (set) Token: 0x0600017A RID: 378 RVA: 0x00002B35 File Offset: 0x00000D35
			public unsafe static Func<Selectable, bool> __9__12_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SelectInHierarchy.__c.NativeFieldInfoPtr___9__12_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Selectable, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SelectInHierarchy.__c.NativeFieldInfoPtr___9__12_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040000DF RID: 223
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040000E0 RID: 224
			private static readonly IntPtr NativeFieldInfoPtr___9__12_0;

			// Token: 0x040000E1 RID: 225
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040000E2 RID: 226
			private static readonly IntPtr NativeMethodInfoPtr__Event_SelectIndexInHierarchy_b__12_0_Internal_Boolean_Selectable_0;
		}
	}
}
