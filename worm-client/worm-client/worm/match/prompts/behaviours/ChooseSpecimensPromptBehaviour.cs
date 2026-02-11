using System;
using boardgames.match.selection;
using Canis.utils.ids;
using dwd.core.match;
using dwd.core.ui.prompt.behaviours;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using TMPro;

namespace worm.match.prompts.behaviours
{
	// Token: 0x020000C0 RID: 192
	public class ChooseSpecimensPromptBehaviour : PromptBehaviour<DBGSelectEntityPrompt>
	{
		// Token: 0x060007A2 RID: 1954 RVA: 0x0002F98C File Offset: 0x0002DB8C
		// Note: this type is marked as 'beforefieldinit'.
		static ChooseSpecimensPromptBehaviour()
		{
			Il2CppClassPointerStore<ChooseSpecimensPromptBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.prompts.behaviours", "ChooseSpecimensPromptBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChooseSpecimensPromptBehaviour>.NativeClassPtr);
			ChooseSpecimensPromptBehaviour.NativeFieldInfoPtr_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChooseSpecimensPromptBehaviour>.NativeClassPtr, "count");
			ChooseSpecimensPromptBehaviour.NativeFieldInfoPtr_selectionResponder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChooseSpecimensPromptBehaviour>.NativeClassPtr, "selectionResponder");
			ChooseSpecimensPromptBehaviour.NativeFieldInfoPtr_selectedEntities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChooseSpecimensPromptBehaviour>.NativeClassPtr, "selectedEntities");
			ChooseSpecimensPromptBehaviour.NativeFieldInfoPtr__Version_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChooseSpecimensPromptBehaviour>.NativeClassPtr, "<Version>k__BackingField");
			ChooseSpecimensPromptBehaviour.NativeMethodInfoPtr_get_Version_Public_Virtual_Final_New_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChooseSpecimensPromptBehaviour>.NativeClassPtr, 100664302);
			ChooseSpecimensPromptBehaviour.NativeMethodInfoPtr_set_Version_Private_set_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChooseSpecimensPromptBehaviour>.NativeClassPtr, 100664303);
			ChooseSpecimensPromptBehaviour.NativeMethodInfoPtr_get_CanDecrementDisplay_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChooseSpecimensPromptBehaviour>.NativeClassPtr, 100664304);
			ChooseSpecimensPromptBehaviour.NativeMethodInfoPtr_get_CanIncrementDisplay_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChooseSpecimensPromptBehaviour>.NativeClassPtr, 100664305);
			ChooseSpecimensPromptBehaviour.NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChooseSpecimensPromptBehaviour>.NativeClassPtr, 100664306);
			ChooseSpecimensPromptBehaviour.NativeMethodInfoPtr_Event_DecrementDisplay_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChooseSpecimensPromptBehaviour>.NativeClassPtr, 100664307);
			ChooseSpecimensPromptBehaviour.NativeMethodInfoPtr_Event_IncrementDisplay_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChooseSpecimensPromptBehaviour>.NativeClassPtr, 100664308);
			ChooseSpecimensPromptBehaviour.NativeMethodInfoPtr_OnChanged_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChooseSpecimensPromptBehaviour>.NativeClassPtr, 100664309);
			ChooseSpecimensPromptBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChooseSpecimensPromptBehaviour>.NativeClassPtr, 100664310);
			ChooseSpecimensPromptBehaviour.NativeMethodInfoPtr__Event_IncrementDisplay_b__13_1_Private_Boolean_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChooseSpecimensPromptBehaviour>.NativeClassPtr, 100664311);
		}

		// Token: 0x17000213 RID: 531
		// (get) Token: 0x060007A3 RID: 1955 RVA: 0x0002FAD4 File Offset: 0x0002DCD4
		// (set) Token: 0x060007A4 RID: 1956 RVA: 0x0002FB10 File Offset: 0x0002DD10
		public unsafe virtual ulong Version
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 329189, RefRangeEnd = 329190, XrefRangeStart = 329189, XrefRangeEnd = 329190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChooseSpecimensPromptBehaviour.NativeMethodInfoPtr_get_Version_Public_Virtual_Final_New_get_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChooseSpecimensPromptBehaviour.NativeMethodInfoPtr_set_Version_Private_set_Void_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000214 RID: 532
		// (get) Token: 0x060007A5 RID: 1957 RVA: 0x0002FB50 File Offset: 0x0002DD50
		public unsafe virtual bool CanDecrementDisplay
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 696894, XrefRangeEnd = 696898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChooseSpecimensPromptBehaviour.NativeMethodInfoPtr_get_CanDecrementDisplay_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000215 RID: 533
		// (get) Token: 0x060007A6 RID: 1958 RVA: 0x0002FB8C File Offset: 0x0002DD8C
		public unsafe virtual bool CanIncrementDisplay
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 696898, XrefRangeEnd = 696903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChooseSpecimensPromptBehaviour.NativeMethodInfoPtr_get_CanIncrementDisplay_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060007A7 RID: 1959 RVA: 0x0002FBC8 File Offset: 0x0002DDC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 696903, XrefRangeEnd = 696926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ChooseSpecimensPromptBehaviour.NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007A8 RID: 1960 RVA: 0x0002FC04 File Offset: 0x0002DE04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 696926, XrefRangeEnd = 696937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Event_DecrementDisplay()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChooseSpecimensPromptBehaviour.NativeMethodInfoPtr_Event_DecrementDisplay_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007A9 RID: 1961 RVA: 0x0002FC38 File Offset: 0x0002DE38
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 696980, RefRangeEnd = 696981, XrefRangeStart = 696937, XrefRangeEnd = 696980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Event_IncrementDisplay()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChooseSpecimensPromptBehaviour.NativeMethodInfoPtr_Event_IncrementDisplay_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007AA RID: 1962 RVA: 0x0002FC6C File Offset: 0x0002DE6C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 696983, RefRangeEnd = 696985, XrefRangeStart = 696981, XrefRangeEnd = 696983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChooseSpecimensPromptBehaviour.NativeMethodInfoPtr_OnChanged_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007AB RID: 1963 RVA: 0x0002FCA0 File Offset: 0x0002DEA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 696985, XrefRangeEnd = 696995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ChooseSpecimensPromptBehaviour()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChooseSpecimensPromptBehaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChooseSpecimensPromptBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007AC RID: 1964 RVA: 0x0002FCDC File Offset: 0x0002DEDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 696995, XrefRangeEnd = 696998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _Event_IncrementDisplay_b__13_1(EntityID c)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChooseSpecimensPromptBehaviour.NativeMethodInfoPtr__Event_IncrementDisplay_b__13_1_Private_Boolean_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060007AD RID: 1965 RVA: 0x00005DB7 File Offset: 0x00003FB7
		public ChooseSpecimensPromptBehaviour(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700020F RID: 527
		// (get) Token: 0x060007AE RID: 1966 RVA: 0x0002FD2C File Offset: 0x0002DF2C
		// (set) Token: 0x060007AF RID: 1967 RVA: 0x00005DC0 File Offset: 0x00003FC0
		public unsafe TMP_Text count
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChooseSpecimensPromptBehaviour.NativeFieldInfoPtr_count);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChooseSpecimensPromptBehaviour.NativeFieldInfoPtr_count), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000210 RID: 528
		// (get) Token: 0x060007B0 RID: 1968 RVA: 0x0002FD5C File Offset: 0x0002DF5C
		// (set) Token: 0x060007B1 RID: 1969 RVA: 0x00005DDF File Offset: 0x00003FDF
		public unsafe DBGSelectionResponder selectionResponder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChooseSpecimensPromptBehaviour.NativeFieldInfoPtr_selectionResponder);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGSelectionResponder>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChooseSpecimensPromptBehaviour.NativeFieldInfoPtr_selectionResponder), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000211 RID: 529
		// (get) Token: 0x060007B2 RID: 1970 RVA: 0x0002FD8C File Offset: 0x0002DF8C
		// (set) Token: 0x060007B3 RID: 1971 RVA: 0x00005DFE File Offset: 0x00003FFE
		public unsafe HashSet<EntityID> selectedEntities
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChooseSpecimensPromptBehaviour.NativeFieldInfoPtr_selectedEntities);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<EntityID>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChooseSpecimensPromptBehaviour.NativeFieldInfoPtr_selectedEntities), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000212 RID: 530
		// (get) Token: 0x060007B4 RID: 1972 RVA: 0x0002FDBC File Offset: 0x0002DFBC
		// (set) Token: 0x060007B5 RID: 1973 RVA: 0x00005E1D File Offset: 0x0000401D
		public unsafe ulong _Version_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChooseSpecimensPromptBehaviour.NativeFieldInfoPtr__Version_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChooseSpecimensPromptBehaviour.NativeFieldInfoPtr__Version_k__BackingField)) = value;
			}
		}

		// Token: 0x04000459 RID: 1113
		private static readonly IntPtr NativeFieldInfoPtr_count;

		// Token: 0x0400045A RID: 1114
		private static readonly IntPtr NativeFieldInfoPtr_selectionResponder;

		// Token: 0x0400045B RID: 1115
		private static readonly IntPtr NativeFieldInfoPtr_selectedEntities;

		// Token: 0x0400045C RID: 1116
		private static readonly IntPtr NativeFieldInfoPtr__Version_k__BackingField;

		// Token: 0x0400045D RID: 1117
		private static readonly IntPtr NativeMethodInfoPtr_get_Version_Public_Virtual_Final_New_get_UInt64_0;

		// Token: 0x0400045E RID: 1118
		private static readonly IntPtr NativeMethodInfoPtr_set_Version_Private_set_Void_UInt64_0;

		// Token: 0x0400045F RID: 1119
		private static readonly IntPtr NativeMethodInfoPtr_get_CanDecrementDisplay_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000460 RID: 1120
		private static readonly IntPtr NativeMethodInfoPtr_get_CanIncrementDisplay_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000461 RID: 1121
		private static readonly IntPtr NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0;

		// Token: 0x04000462 RID: 1122
		private static readonly IntPtr NativeMethodInfoPtr_Event_DecrementDisplay_Public_Virtual_Final_New_Void_0;

		// Token: 0x04000463 RID: 1123
		private static readonly IntPtr NativeMethodInfoPtr_Event_IncrementDisplay_Public_Virtual_Final_New_Void_0;

		// Token: 0x04000464 RID: 1124
		private static readonly IntPtr NativeMethodInfoPtr_OnChanged_Private_Void_0;

		// Token: 0x04000465 RID: 1125
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000466 RID: 1126
		private static readonly IntPtr NativeMethodInfoPtr__Event_IncrementDisplay_b__13_1_Private_Boolean_EntityID_0;

		// Token: 0x02000315 RID: 789
		[ObfuscatedName("worm.match.prompts.behaviours.ChooseSpecimensPromptBehaviour+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06001FC6 RID: 8134 RVA: 0x000792B8 File Offset: 0x000774B8
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<ChooseSpecimensPromptBehaviour.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ChooseSpecimensPromptBehaviour>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChooseSpecimensPromptBehaviour.__c>.NativeClassPtr);
				ChooseSpecimensPromptBehaviour.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChooseSpecimensPromptBehaviour.__c>.NativeClassPtr, "<>9");
				ChooseSpecimensPromptBehaviour.__c.NativeFieldInfoPtr___9__13_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChooseSpecimensPromptBehaviour.__c>.NativeClassPtr, "<>9__13_0");
				ChooseSpecimensPromptBehaviour.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChooseSpecimensPromptBehaviour.__c>.NativeClassPtr, 100664313);
				ChooseSpecimensPromptBehaviour.__c.NativeMethodInfoPtr__Event_IncrementDisplay_b__13_0_Internal_EntityID_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChooseSpecimensPromptBehaviour.__c>.NativeClassPtr, 100664314);
			}

			// Token: 0x06001FC7 RID: 8135 RVA: 0x00079334 File Offset: 0x00077534
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChooseSpecimensPromptBehaviour.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChooseSpecimensPromptBehaviour.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001FC8 RID: 8136 RVA: 0x00079370 File Offset: 0x00077570
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 696890, XrefRangeEnd = 696894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe EntityID _Event_IncrementDisplay_b__13_0(EntityComponent c)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChooseSpecimensPromptBehaviour.__c.NativeMethodInfoPtr__Event_IncrementDisplay_b__13_0_Internal_EntityID_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr3) : null;
				}
			}

			// Token: 0x06001FC9 RID: 8137 RVA: 0x00011E57 File Offset: 0x00010057
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170008B2 RID: 2226
			// (get) Token: 0x06001FCA RID: 8138 RVA: 0x000793C0 File Offset: 0x000775C0
			// (set) Token: 0x06001FCB RID: 8139 RVA: 0x00011E60 File Offset: 0x00010060
			public unsafe static ChooseSpecimensPromptBehaviour.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ChooseSpecimensPromptBehaviour.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ChooseSpecimensPromptBehaviour.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ChooseSpecimensPromptBehaviour.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008B3 RID: 2227
			// (get) Token: 0x06001FCC RID: 8140 RVA: 0x000793E8 File Offset: 0x000775E8
			// (set) Token: 0x06001FCD RID: 8141 RVA: 0x00011E72 File Offset: 0x00010072
			public unsafe static Func<EntityComponent, EntityID> __9__13_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ChooseSpecimensPromptBehaviour.__c.NativeFieldInfoPtr___9__13_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<EntityComponent, EntityID>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ChooseSpecimensPromptBehaviour.__c.NativeFieldInfoPtr___9__13_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001259 RID: 4697
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400125A RID: 4698
			private static readonly IntPtr NativeFieldInfoPtr___9__13_0;

			// Token: 0x0400125B RID: 4699
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400125C RID: 4700
			private static readonly IntPtr NativeMethodInfoPtr__Event_IncrementDisplay_b__13_0_Internal_EntityID_EntityComponent_0;
		}
	}
}
