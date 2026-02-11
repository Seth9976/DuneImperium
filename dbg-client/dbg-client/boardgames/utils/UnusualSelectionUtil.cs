using System;
using System.Runtime.InteropServices;
using boardgames.match;
using boardgames.match.selection;
using Canis.utils.ids;
using Canis.utils.localization;
using dwd.core.match.selection;
using dwd.core.ui.prompt.commands;
using dwd.core.ui.prompt.prompts;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using lib.canis.Canis.data;

namespace boardgames.utils
{
	// Token: 0x020000F7 RID: 247
	public static class UnusualSelectionUtil : Object
	{
		// Token: 0x06000A9A RID: 2714 RVA: 0x0003F1CC File Offset: 0x0003D3CC
		// Note: this type is marked as 'beforefieldinit'.
		static UnusualSelectionUtil()
		{
			Il2CppClassPointerStore<UnusualSelectionUtil>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.utils", "UnusualSelectionUtil");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnusualSelectionUtil>.NativeClassPtr);
			UnusualSelectionUtil.NativeMethodInfoPtr_ConfirmUnusualSelection_Public_Static_IEnumerator_1_Nullable_1_Boolean_EntityID_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnusualSelectionUtil>.NativeClassPtr, 100664831);
			UnusualSelectionUtil.NativeMethodInfoPtr_ConfirmUnusualSelections_Public_Static_IEnumerator_1_Nullable_1_Boolean_List_1_EntityID_EntityID_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnusualSelectionUtil>.NativeClassPtr, 100664832);
			UnusualSelectionUtil.NativeMethodInfoPtr_ConfirmUnusualSkip_Public_Static_IEnumerator_1_Nullable_1_Boolean_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnusualSelectionUtil>.NativeClassPtr, 100664833);
		}

		// Token: 0x06000A9B RID: 2715 RVA: 0x0003F238 File Offset: 0x0003D438
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 507161, RefRangeEnd = 507166, XrefRangeStart = 507155, XrefRangeEnd = 507161, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerator<Nullable<bool>> ConfirmUnusualSelection(EntityID attemptedSelection, EntityID secondaryEntity = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attemptedSelection);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(secondaryEntity);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnusualSelectionUtil.NativeMethodInfoPtr_ConfirmUnusualSelection_Public_Static_IEnumerator_1_Nullable_1_Boolean_EntityID_EntityID_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<Nullable<bool>>>(intPtr3) : null;
		}

		// Token: 0x06000A9C RID: 2716 RVA: 0x0003F290 File Offset: 0x0003D490
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 507173, RefRangeEnd = 507176, XrefRangeStart = 507166, XrefRangeEnd = 507173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerator<Nullable<bool>> ConfirmUnusualSelections(List<EntityID> attemptedSelections, EntityID secondaryEntity = null, [Optional] Il2CppStringArray promptFlavors)
		{
			if (promptFlavors == null)
			{
				promptFlavors = new Il2CppStringArray(0L);
			}
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attemptedSelections);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(secondaryEntity);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(promptFlavors);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnusualSelectionUtil.NativeMethodInfoPtr_ConfirmUnusualSelections_Public_Static_IEnumerator_1_Nullable_1_Boolean_List_1_EntityID_EntityID_Il2CppStringArray_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<Nullable<bool>>>(intPtr3) : null;
		}

		// Token: 0x06000A9D RID: 2717 RVA: 0x0003F308 File Offset: 0x0003D508
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 507176, XrefRangeEnd = 507181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerator<Nullable<bool>> ConfirmUnusualSkip([Optional] Il2CppStringArray promptFlavors)
		{
			if (promptFlavors == null)
			{
				promptFlavors = new Il2CppStringArray(0L);
			}
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(promptFlavors);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnusualSelectionUtil.NativeMethodInfoPtr_ConfirmUnusualSkip_Public_Static_IEnumerator_1_Nullable_1_Boolean_Il2CppStringArray_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<Nullable<bool>>>(intPtr3) : null;
			}
		}

		// Token: 0x06000A9E RID: 2718 RVA: 0x000070AA File Offset: 0x000052AA
		public static IEnumerator<Nullable<bool>> ConfirmUnusualSelections(List<EntityID> attemptedSelections, [Optional] EntityID secondaryEntity, params string[] promptFlavors)
		{
			return UnusualSelectionUtil.ConfirmUnusualSelections(attemptedSelections, secondaryEntity, new Il2CppStringArray(promptFlavors));
		}

		// Token: 0x06000A9F RID: 2719 RVA: 0x000070B9 File Offset: 0x000052B9
		public static IEnumerator<Nullable<bool>> ConfirmUnusualSkip(params string[] promptFlavors)
		{
			return UnusualSelectionUtil.ConfirmUnusualSkip(new Il2CppStringArray(promptFlavors));
		}

		// Token: 0x06000AA0 RID: 2720 RVA: 0x000070C6 File Offset: 0x000052C6
		public UnusualSelectionUtil(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000672 RID: 1650
		private static readonly IntPtr NativeMethodInfoPtr_ConfirmUnusualSelection_Public_Static_IEnumerator_1_Nullable_1_Boolean_EntityID_EntityID_0;

		// Token: 0x04000673 RID: 1651
		private static readonly IntPtr NativeMethodInfoPtr_ConfirmUnusualSelections_Public_Static_IEnumerator_1_Nullable_1_Boolean_List_1_EntityID_EntityID_Il2CppStringArray_0;

		// Token: 0x04000674 RID: 1652
		private static readonly IntPtr NativeMethodInfoPtr_ConfirmUnusualSkip_Public_Static_IEnumerator_1_Nullable_1_Boolean_Il2CppStringArray_0;

		// Token: 0x02000339 RID: 825
		[ObfuscatedName("boardgames.utils.UnusualSelectionUtil+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x060026E6 RID: 9958 RVA: 0x0009CE64 File Offset: 0x0009B064
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<UnusualSelectionUtil.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnusualSelectionUtil>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnusualSelectionUtil.__c>.NativeClassPtr);
				UnusualSelectionUtil.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnusualSelectionUtil.__c>.NativeClassPtr, "<>9");
				UnusualSelectionUtil.__c.NativeFieldInfoPtr___9__1_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnusualSelectionUtil.__c>.NativeClassPtr, "<>9__1_0");
				UnusualSelectionUtil.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnusualSelectionUtil.__c>.NativeClassPtr, 100664835);
				UnusualSelectionUtil.__c.NativeMethodInfoPtr__ConfirmUnusualSelections_b__1_0_Internal_UnusualSelection_KeyValuePair_2_LocalizableTextVariables_List_1_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnusualSelectionUtil.__c>.NativeClassPtr, 100664836);
			}

			// Token: 0x060026E7 RID: 9959 RVA: 0x0009CEE0 File Offset: 0x0009B0E0
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnusualSelectionUtil.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnusualSelectionUtil.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060026E8 RID: 9960 RVA: 0x0009CF1C File Offset: 0x0009B11C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 506827, XrefRangeEnd = 506835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UnusualSelection _ConfirmUnusualSelections_b__1_0(KeyValuePair<LocalizableTextVariables, List<EntityID>> u)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(u));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnusualSelectionUtil.__c.NativeMethodInfoPtr__ConfirmUnusualSelections_b__1_0_Internal_UnusualSelection_KeyValuePair_2_LocalizableTextVariables_List_1_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<UnusualSelection>(intPtr3) : null;
				}
			}

			// Token: 0x060026E9 RID: 9961 RVA: 0x0001425B File Offset: 0x0001245B
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000ACD RID: 2765
			// (get) Token: 0x060026EA RID: 9962 RVA: 0x0009CF74 File Offset: 0x0009B174
			// (set) Token: 0x060026EB RID: 9963 RVA: 0x00014264 File Offset: 0x00012464
			public unsafe static UnusualSelectionUtil.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(UnusualSelectionUtil.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnusualSelectionUtil.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(UnusualSelectionUtil.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000ACE RID: 2766
			// (get) Token: 0x060026EC RID: 9964 RVA: 0x0009CF9C File Offset: 0x0009B19C
			// (set) Token: 0x060026ED RID: 9965 RVA: 0x00014276 File Offset: 0x00012476
			public unsafe static Func<KeyValuePair<LocalizableTextVariables, List<EntityID>>, UnusualSelection> __9__1_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(UnusualSelectionUtil.__c.NativeFieldInfoPtr___9__1_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<LocalizableTextVariables, List<EntityID>>, UnusualSelection>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(UnusualSelectionUtil.__c.NativeFieldInfoPtr___9__1_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400186C RID: 6252
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400186D RID: 6253
			private static readonly IntPtr NativeFieldInfoPtr___9__1_0;

			// Token: 0x0400186E RID: 6254
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400186F RID: 6255
			private static readonly IntPtr NativeMethodInfoPtr__ConfirmUnusualSelections_b__1_0_Internal_UnusualSelection_KeyValuePair_2_LocalizableTextVariables_List_1_EntityID_0;
		}

		// Token: 0x0200033A RID: 826
		[ObfuscatedName("boardgames.utils.UnusualSelectionUtil+<ConfirmUnusualSelection>d__0")]
		public sealed class _ConfirmUnusualSelection_d__0 : Object
		{
			// Token: 0x060026EE RID: 9966 RVA: 0x0009CFC4 File Offset: 0x0009B1C4
			// Note: this type is marked as 'beforefieldinit'.
			static _ConfirmUnusualSelection_d__0()
			{
				Il2CppClassPointerStore<UnusualSelectionUtil._ConfirmUnusualSelection_d__0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnusualSelectionUtil>.NativeClassPtr, "<ConfirmUnusualSelection>d__0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnusualSelectionUtil._ConfirmUnusualSelection_d__0>.NativeClassPtr);
				UnusualSelectionUtil._ConfirmUnusualSelection_d__0.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnusualSelectionUtil._ConfirmUnusualSelection_d__0>.NativeClassPtr, "<>1__state");
				UnusualSelectionUtil._ConfirmUnusualSelection_d__0.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnusualSelectionUtil._ConfirmUnusualSelection_d__0>.NativeClassPtr, "<>2__current");
				UnusualSelectionUtil._ConfirmUnusualSelection_d__0.NativeFieldInfoPtr_attemptedSelection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnusualSelectionUtil._ConfirmUnusualSelection_d__0>.NativeClassPtr, "attemptedSelection");
				UnusualSelectionUtil._ConfirmUnusualSelection_d__0.NativeFieldInfoPtr_secondaryEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnusualSelectionUtil._ConfirmUnusualSelection_d__0>.NativeClassPtr, "secondaryEntity");
				UnusualSelectionUtil._ConfirmUnusualSelection_d__0.NativeFieldInfoPtr__result_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnusualSelectionUtil._ConfirmUnusualSelection_d__0>.NativeClassPtr, "<result>5__2");
				UnusualSelectionUtil._ConfirmUnusualSelection_d__0.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnusualSelectionUtil._ConfirmUnusualSelection_d__0>.NativeClassPtr, 100664837);
				UnusualSelectionUtil._ConfirmUnusualSelection_d__0.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnusualSelectionUtil._ConfirmUnusualSelection_d__0>.NativeClassPtr, 100664838);
				UnusualSelectionUtil._ConfirmUnusualSelection_d__0.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnusualSelectionUtil._ConfirmUnusualSelection_d__0>.NativeClassPtr, 100664839);
				UnusualSelectionUtil._ConfirmUnusualSelection_d__0.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_Nullable_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnusualSelectionUtil._ConfirmUnusualSelection_d__0>.NativeClassPtr, 100664840);
				UnusualSelectionUtil._ConfirmUnusualSelection_d__0.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnusualSelectionUtil._ConfirmUnusualSelection_d__0>.NativeClassPtr, 100664841);
				UnusualSelectionUtil._ConfirmUnusualSelection_d__0.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnusualSelectionUtil._ConfirmUnusualSelection_d__0>.NativeClassPtr, 100664842);
			}

			// Token: 0x060026EF RID: 9967 RVA: 0x0009D0CC File Offset: 0x0009B2CC
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _ConfirmUnusualSelection_d__0(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnusualSelectionUtil._ConfirmUnusualSelection_d__0>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnusualSelectionUtil._ConfirmUnusualSelection_d__0.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060026F0 RID: 9968 RVA: 0x0009D114 File Offset: 0x0009B314
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnusualSelectionUtil._ConfirmUnusualSelection_d__0.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060026F1 RID: 9969 RVA: 0x0009D148 File Offset: 0x0009B348
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 506835, XrefRangeEnd = 506869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnusualSelectionUtil._ConfirmUnusualSelection_d__0.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000AD4 RID: 2772
			// (get) Token: 0x060026F2 RID: 9970 RVA: 0x0009D184 File Offset: 0x0009B384
			public unsafe Nullable<bool> prop_Nullable_1_Boolean_0
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnusualSelectionUtil._ConfirmUnusualSelection_d__0.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_Nullable_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new Nullable<bool>(intPtr);
				}
			}

			// Token: 0x060026F3 RID: 9971 RVA: 0x0009D1BC File Offset: 0x0009B3BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 506869, XrefRangeEnd = 506874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnusualSelectionUtil._ConfirmUnusualSelection_d__0.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000AD5 RID: 2773
			// (get) Token: 0x060026F4 RID: 9972 RVA: 0x0009D1F0 File Offset: 0x0009B3F0
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 506874, XrefRangeEnd = 506877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnusualSelectionUtil._ConfirmUnusualSelection_d__0.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060026F5 RID: 9973 RVA: 0x00014288 File Offset: 0x00012488
			public _ConfirmUnusualSelection_d__0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000ACF RID: 2767
			// (get) Token: 0x060026F6 RID: 9974 RVA: 0x0009D230 File Offset: 0x0009B430
			// (set) Token: 0x060026F7 RID: 9975 RVA: 0x00014291 File Offset: 0x00012491
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnusualSelectionUtil._ConfirmUnusualSelection_d__0.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnusualSelectionUtil._ConfirmUnusualSelection_d__0.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000AD0 RID: 2768
			// (get) Token: 0x060026F8 RID: 9976 RVA: 0x0009D258 File Offset: 0x0009B458
			// (set) Token: 0x060026F9 RID: 9977 RVA: 0x000142AC File Offset: 0x000124AC
			public Nullable<bool> __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnusualSelectionUtil._ConfirmUnusualSelection_d__0.NativeFieldInfoPtr___2__current);
					return new Nullable<bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnusualSelectionUtil._ConfirmUnusualSelection_d__0.NativeFieldInfoPtr___2__current), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000AD1 RID: 2769
			// (get) Token: 0x060026FA RID: 9978 RVA: 0x0009D288 File Offset: 0x0009B488
			// (set) Token: 0x060026FB RID: 9979 RVA: 0x000142DA File Offset: 0x000124DA
			public unsafe EntityID attemptedSelection
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnusualSelectionUtil._ConfirmUnusualSelection_d__0.NativeFieldInfoPtr_attemptedSelection);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnusualSelectionUtil._ConfirmUnusualSelection_d__0.NativeFieldInfoPtr_attemptedSelection), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000AD2 RID: 2770
			// (get) Token: 0x060026FC RID: 9980 RVA: 0x0009D2B8 File Offset: 0x0009B4B8
			// (set) Token: 0x060026FD RID: 9981 RVA: 0x000142F9 File Offset: 0x000124F9
			public unsafe EntityID secondaryEntity
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnusualSelectionUtil._ConfirmUnusualSelection_d__0.NativeFieldInfoPtr_secondaryEntity);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnusualSelectionUtil._ConfirmUnusualSelection_d__0.NativeFieldInfoPtr_secondaryEntity), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000AD3 RID: 2771
			// (get) Token: 0x060026FE RID: 9982 RVA: 0x0009D2E8 File Offset: 0x0009B4E8
			// (set) Token: 0x060026FF RID: 9983 RVA: 0x00014318 File Offset: 0x00012518
			public unsafe IEnumerator<Nullable<bool>> _result_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnusualSelectionUtil._ConfirmUnusualSelection_d__0.NativeFieldInfoPtr__result_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<Nullable<bool>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnusualSelectionUtil._ConfirmUnusualSelection_d__0.NativeFieldInfoPtr__result_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001870 RID: 6256
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001871 RID: 6257
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001872 RID: 6258
			private static readonly IntPtr NativeFieldInfoPtr_attemptedSelection;

			// Token: 0x04001873 RID: 6259
			private static readonly IntPtr NativeFieldInfoPtr_secondaryEntity;

			// Token: 0x04001874 RID: 6260
			private static readonly IntPtr NativeFieldInfoPtr__result_5__2;

			// Token: 0x04001875 RID: 6261
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001876 RID: 6262
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001877 RID: 6263
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001878 RID: 6264
			private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_Nullable_1_Boolean_0;

			// Token: 0x04001879 RID: 6265
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400187A RID: 6266
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x0200033B RID: 827
		[ObfuscatedName("boardgames.utils.UnusualSelectionUtil+<ConfirmUnusualSelections>d__1")]
		public sealed class _ConfirmUnusualSelections_d__1 : Object
		{
			// Token: 0x06002700 RID: 9984 RVA: 0x0009D318 File Offset: 0x0009B518
			// Note: this type is marked as 'beforefieldinit'.
			static _ConfirmUnusualSelections_d__1()
			{
				Il2CppClassPointerStore<UnusualSelectionUtil._ConfirmUnusualSelections_d__1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnusualSelectionUtil>.NativeClassPtr, "<ConfirmUnusualSelections>d__1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnusualSelectionUtil._ConfirmUnusualSelections_d__1>.NativeClassPtr);
				UnusualSelectionUtil._ConfirmUnusualSelections_d__1.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnusualSelectionUtil._ConfirmUnusualSelections_d__1>.NativeClassPtr, "<>1__state");
				UnusualSelectionUtil._ConfirmUnusualSelections_d__1.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnusualSelectionUtil._ConfirmUnusualSelections_d__1>.NativeClassPtr, "<>2__current");
				UnusualSelectionUtil._ConfirmUnusualSelections_d__1.NativeFieldInfoPtr_attemptedSelections = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnusualSelectionUtil._ConfirmUnusualSelections_d__1>.NativeClassPtr, "attemptedSelections");
				UnusualSelectionUtil._ConfirmUnusualSelections_d__1.NativeFieldInfoPtr_secondaryEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnusualSelectionUtil._ConfirmUnusualSelections_d__1>.NativeClassPtr, "secondaryEntity");
				UnusualSelectionUtil._ConfirmUnusualSelections_d__1.NativeFieldInfoPtr_promptFlavors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnusualSelectionUtil._ConfirmUnusualSelections_d__1>.NativeClassPtr, "promptFlavors");
				UnusualSelectionUtil._ConfirmUnusualSelections_d__1.NativeFieldInfoPtr__selectionResponder_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnusualSelectionUtil._ConfirmUnusualSelections_d__1>.NativeClassPtr, "<selectionResponder>5__2");
				UnusualSelectionUtil._ConfirmUnusualSelections_d__1.NativeFieldInfoPtr__node_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnusualSelectionUtil._ConfirmUnusualSelections_d__1>.NativeClassPtr, "<node>5__3");
				UnusualSelectionUtil._ConfirmUnusualSelections_d__1.NativeFieldInfoPtr__entities_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnusualSelectionUtil._ConfirmUnusualSelections_d__1>.NativeClassPtr, "<entities>5__4");
				UnusualSelectionUtil._ConfirmUnusualSelections_d__1.NativeFieldInfoPtr__realEntities_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnusualSelectionUtil._ConfirmUnusualSelections_d__1>.NativeClassPtr, "<realEntities>5__5");
				UnusualSelectionUtil._ConfirmUnusualSelections_d__1.NativeFieldInfoPtr___7__wrap5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnusualSelectionUtil._ConfirmUnusualSelections_d__1>.NativeClassPtr, "<>7__wrap5");
				UnusualSelectionUtil._ConfirmUnusualSelections_d__1.NativeFieldInfoPtr___7__wrap6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnusualSelectionUtil._ConfirmUnusualSelections_d__1>.NativeClassPtr, "<>7__wrap6");
				UnusualSelectionUtil._ConfirmUnusualSelections_d__1.NativeFieldInfoPtr__confirmOrDeny_5__8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnusualSelectionUtil._ConfirmUnusualSelections_d__1>.NativeClassPtr, "<confirmOrDeny>5__8");
				UnusualSelectionUtil._ConfirmUnusualSelections_d__1.NativeFieldInfoPtr__promptCommand_5__9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnusualSelectionUtil._ConfirmUnusualSelections_d__1>.NativeClassPtr, "<promptCommand>5__9");
				UnusualSelectionUtil._ConfirmUnusualSelections_d__1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnusualSelectionUtil._ConfirmUnusualSelections_d__1>.NativeClassPtr, 100664843);
				UnusualSelectionUtil._ConfirmUnusualSelections_d__1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnusualSelectionUtil._ConfirmUnusualSelections_d__1>.NativeClassPtr, 100664844);
				UnusualSelectionUtil._ConfirmUnusualSelections_d__1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnusualSelectionUtil._ConfirmUnusualSelections_d__1>.NativeClassPtr, 100664845);
				UnusualSelectionUtil._ConfirmUnusualSelections_d__1.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_Nullable_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnusualSelectionUtil._ConfirmUnusualSelections_d__1>.NativeClassPtr, 100664846);
				UnusualSelectionUtil._ConfirmUnusualSelections_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnusualSelectionUtil._ConfirmUnusualSelections_d__1>.NativeClassPtr, 100664847);
				UnusualSelectionUtil._ConfirmUnusualSelections_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnusualSelectionUtil._ConfirmUnusualSelections_d__1>.NativeClassPtr, 100664848);
			}

			// Token: 0x06002701 RID: 9985 RVA: 0x0009D4C0 File Offset: 0x0009B6C0
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _ConfirmUnusualSelections_d__1(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnusualSelectionUtil._ConfirmUnusualSelections_d__1>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnusualSelectionUtil._ConfirmUnusualSelections_d__1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002702 RID: 9986 RVA: 0x0009D508 File Offset: 0x0009B708
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnusualSelectionUtil._ConfirmUnusualSelections_d__1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002703 RID: 9987 RVA: 0x0009D53C File Offset: 0x0009B73C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 506877, XrefRangeEnd = 507078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnusualSelectionUtil._ConfirmUnusualSelections_d__1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000AE3 RID: 2787
			// (get) Token: 0x06002704 RID: 9988 RVA: 0x0009D578 File Offset: 0x0009B778
			public unsafe Nullable<bool> prop_Nullable_1_Boolean_0
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnusualSelectionUtil._ConfirmUnusualSelections_d__1.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_Nullable_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new Nullable<bool>(intPtr);
				}
			}

			// Token: 0x06002705 RID: 9989 RVA: 0x0009D5B0 File Offset: 0x0009B7B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 507078, XrefRangeEnd = 507083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnusualSelectionUtil._ConfirmUnusualSelections_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000AE4 RID: 2788
			// (get) Token: 0x06002706 RID: 9990 RVA: 0x0009D5E4 File Offset: 0x0009B7E4
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 507083, XrefRangeEnd = 507086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnusualSelectionUtil._ConfirmUnusualSelections_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002707 RID: 9991 RVA: 0x00014337 File Offset: 0x00012537
			public _ConfirmUnusualSelections_d__1(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000AD6 RID: 2774
			// (get) Token: 0x06002708 RID: 9992 RVA: 0x0009D624 File Offset: 0x0009B824
			// (set) Token: 0x06002709 RID: 9993 RVA: 0x00014340 File Offset: 0x00012540
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnusualSelectionUtil._ConfirmUnusualSelections_d__1.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnusualSelectionUtil._ConfirmUnusualSelections_d__1.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000AD7 RID: 2775
			// (get) Token: 0x0600270A RID: 9994 RVA: 0x0009D64C File Offset: 0x0009B84C
			// (set) Token: 0x0600270B RID: 9995 RVA: 0x0001435B File Offset: 0x0001255B
			public Nullable<bool> __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnusualSelectionUtil._ConfirmUnusualSelections_d__1.NativeFieldInfoPtr___2__current);
					return new Nullable<bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnusualSelectionUtil._ConfirmUnusualSelections_d__1.NativeFieldInfoPtr___2__current), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000AD8 RID: 2776
			// (get) Token: 0x0600270C RID: 9996 RVA: 0x0009D67C File Offset: 0x0009B87C
			// (set) Token: 0x0600270D RID: 9997 RVA: 0x00014389 File Offset: 0x00012589
			public unsafe List<EntityID> attemptedSelections
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnusualSelectionUtil._ConfirmUnusualSelections_d__1.NativeFieldInfoPtr_attemptedSelections);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<EntityID>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnusualSelectionUtil._ConfirmUnusualSelections_d__1.NativeFieldInfoPtr_attemptedSelections), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000AD9 RID: 2777
			// (get) Token: 0x0600270E RID: 9998 RVA: 0x0009D6AC File Offset: 0x0009B8AC
			// (set) Token: 0x0600270F RID: 9999 RVA: 0x000143A8 File Offset: 0x000125A8
			public unsafe EntityID secondaryEntity
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnusualSelectionUtil._ConfirmUnusualSelections_d__1.NativeFieldInfoPtr_secondaryEntity);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnusualSelectionUtil._ConfirmUnusualSelections_d__1.NativeFieldInfoPtr_secondaryEntity), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000ADA RID: 2778
			// (get) Token: 0x06002710 RID: 10000 RVA: 0x0009D6DC File Offset: 0x0009B8DC
			// (set) Token: 0x06002711 RID: 10001 RVA: 0x000143C7 File Offset: 0x000125C7
			public unsafe Il2CppStringArray promptFlavors
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnusualSelectionUtil._ConfirmUnusualSelections_d__1.NativeFieldInfoPtr_promptFlavors);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnusualSelectionUtil._ConfirmUnusualSelections_d__1.NativeFieldInfoPtr_promptFlavors), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000ADB RID: 2779
			// (get) Token: 0x06002712 RID: 10002 RVA: 0x0009D70C File Offset: 0x0009B90C
			// (set) Token: 0x06002713 RID: 10003 RVA: 0x000143E6 File Offset: 0x000125E6
			public unsafe DBGSelectionResponder _selectionResponder_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnusualSelectionUtil._ConfirmUnusualSelections_d__1.NativeFieldInfoPtr__selectionResponder_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGSelectionResponder>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnusualSelectionUtil._ConfirmUnusualSelections_d__1.NativeFieldInfoPtr__selectionResponder_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000ADC RID: 2780
			// (get) Token: 0x06002714 RID: 10004 RVA: 0x0009D73C File Offset: 0x0009B93C
			// (set) Token: 0x06002715 RID: 10005 RVA: 0x00014405 File Offset: 0x00012605
			public unsafe ISelectionNode _node_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnusualSelectionUtil._ConfirmUnusualSelections_d__1.NativeFieldInfoPtr__node_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ISelectionNode>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnusualSelectionUtil._ConfirmUnusualSelections_d__1.NativeFieldInfoPtr__node_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000ADD RID: 2781
			// (get) Token: 0x06002716 RID: 10006 RVA: 0x0009D76C File Offset: 0x0009B96C
			// (set) Token: 0x06002717 RID: 10007 RVA: 0x00014424 File Offset: 0x00012624
			public unsafe DBGEntities _entities_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnusualSelectionUtil._ConfirmUnusualSelections_d__1.NativeFieldInfoPtr__entities_5__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGEntities>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnusualSelectionUtil._ConfirmUnusualSelections_d__1.NativeFieldInfoPtr__entities_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000ADE RID: 2782
			// (get) Token: 0x06002718 RID: 10008 RVA: 0x0009D79C File Offset: 0x0009B99C
			// (set) Token: 0x06002719 RID: 10009 RVA: 0x00014443 File Offset: 0x00012643
			public unsafe Il2CppReferenceArray<EntityID> _realEntities_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnusualSelectionUtil._ConfirmUnusualSelections_d__1.NativeFieldInfoPtr__realEntities_5__5);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<EntityID>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnusualSelectionUtil._ConfirmUnusualSelections_d__1.NativeFieldInfoPtr__realEntities_5__5), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000ADF RID: 2783
			// (get) Token: 0x0600271A RID: 10010 RVA: 0x0009D7CC File Offset: 0x0009B9CC
			// (set) Token: 0x0600271B RID: 10011 RVA: 0x00014462 File Offset: 0x00012662
			public unsafe Il2CppReferenceArray<UnusualSelection> __7__wrap5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnusualSelectionUtil._ConfirmUnusualSelections_d__1.NativeFieldInfoPtr___7__wrap5);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<UnusualSelection>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnusualSelectionUtil._ConfirmUnusualSelections_d__1.NativeFieldInfoPtr___7__wrap5), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000AE0 RID: 2784
			// (get) Token: 0x0600271C RID: 10012 RVA: 0x0009D7FC File Offset: 0x0009B9FC
			// (set) Token: 0x0600271D RID: 10013 RVA: 0x00014481 File Offset: 0x00012681
			public unsafe int __7__wrap6
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnusualSelectionUtil._ConfirmUnusualSelections_d__1.NativeFieldInfoPtr___7__wrap6);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnusualSelectionUtil._ConfirmUnusualSelections_d__1.NativeFieldInfoPtr___7__wrap6)) = value;
				}
			}

			// Token: 0x17000AE1 RID: 2785
			// (get) Token: 0x0600271E RID: 10014 RVA: 0x0009D824 File Offset: 0x0009BA24
			// (set) Token: 0x0600271F RID: 10015 RVA: 0x0001449C File Offset: 0x0001269C
			public unsafe ConfirmOrDenyPrompt _confirmOrDeny_5__8
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnusualSelectionUtil._ConfirmUnusualSelections_d__1.NativeFieldInfoPtr__confirmOrDeny_5__8);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConfirmOrDenyPrompt>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnusualSelectionUtil._ConfirmUnusualSelections_d__1.NativeFieldInfoPtr__confirmOrDeny_5__8), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000AE2 RID: 2786
			// (get) Token: 0x06002720 RID: 10016 RVA: 0x0009D854 File Offset: 0x0009BA54
			// (set) Token: 0x06002721 RID: 10017 RVA: 0x000144BB File Offset: 0x000126BB
			public unsafe DisplayGenericPrompt _promptCommand_5__9
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnusualSelectionUtil._ConfirmUnusualSelections_d__1.NativeFieldInfoPtr__promptCommand_5__9);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DisplayGenericPrompt>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnusualSelectionUtil._ConfirmUnusualSelections_d__1.NativeFieldInfoPtr__promptCommand_5__9), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400187B RID: 6267
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400187C RID: 6268
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400187D RID: 6269
			private static readonly IntPtr NativeFieldInfoPtr_attemptedSelections;

			// Token: 0x0400187E RID: 6270
			private static readonly IntPtr NativeFieldInfoPtr_secondaryEntity;

			// Token: 0x0400187F RID: 6271
			private static readonly IntPtr NativeFieldInfoPtr_promptFlavors;

			// Token: 0x04001880 RID: 6272
			private static readonly IntPtr NativeFieldInfoPtr__selectionResponder_5__2;

			// Token: 0x04001881 RID: 6273
			private static readonly IntPtr NativeFieldInfoPtr__node_5__3;

			// Token: 0x04001882 RID: 6274
			private static readonly IntPtr NativeFieldInfoPtr__entities_5__4;

			// Token: 0x04001883 RID: 6275
			private static readonly IntPtr NativeFieldInfoPtr__realEntities_5__5;

			// Token: 0x04001884 RID: 6276
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap5;

			// Token: 0x04001885 RID: 6277
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap6;

			// Token: 0x04001886 RID: 6278
			private static readonly IntPtr NativeFieldInfoPtr__confirmOrDeny_5__8;

			// Token: 0x04001887 RID: 6279
			private static readonly IntPtr NativeFieldInfoPtr__promptCommand_5__9;

			// Token: 0x04001888 RID: 6280
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001889 RID: 6281
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400188A RID: 6282
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400188B RID: 6283
			private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_Nullable_1_Boolean_0;

			// Token: 0x0400188C RID: 6284
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400188D RID: 6285
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x0200033C RID: 828
		[ObfuscatedName("boardgames.utils.UnusualSelectionUtil+<ConfirmUnusualSkip>d__2")]
		public sealed class _ConfirmUnusualSkip_d__2 : Object
		{
			// Token: 0x06002722 RID: 10018 RVA: 0x0009D884 File Offset: 0x0009BA84
			// Note: this type is marked as 'beforefieldinit'.
			static _ConfirmUnusualSkip_d__2()
			{
				Il2CppClassPointerStore<UnusualSelectionUtil._ConfirmUnusualSkip_d__2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnusualSelectionUtil>.NativeClassPtr, "<ConfirmUnusualSkip>d__2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnusualSelectionUtil._ConfirmUnusualSkip_d__2>.NativeClassPtr);
				UnusualSelectionUtil._ConfirmUnusualSkip_d__2.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnusualSelectionUtil._ConfirmUnusualSkip_d__2>.NativeClassPtr, "<>1__state");
				UnusualSelectionUtil._ConfirmUnusualSkip_d__2.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnusualSelectionUtil._ConfirmUnusualSkip_d__2>.NativeClassPtr, "<>2__current");
				UnusualSelectionUtil._ConfirmUnusualSkip_d__2.NativeFieldInfoPtr_promptFlavors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnusualSelectionUtil._ConfirmUnusualSkip_d__2>.NativeClassPtr, "promptFlavors");
				UnusualSelectionUtil._ConfirmUnusualSkip_d__2.NativeFieldInfoPtr__selectionResponder_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnusualSelectionUtil._ConfirmUnusualSkip_d__2>.NativeClassPtr, "<selectionResponder>5__2");
				UnusualSelectionUtil._ConfirmUnusualSkip_d__2.NativeFieldInfoPtr__node_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnusualSelectionUtil._ConfirmUnusualSkip_d__2>.NativeClassPtr, "<node>5__3");
				UnusualSelectionUtil._ConfirmUnusualSkip_d__2.NativeFieldInfoPtr__confirmOrDeny_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnusualSelectionUtil._ConfirmUnusualSkip_d__2>.NativeClassPtr, "<confirmOrDeny>5__4");
				UnusualSelectionUtil._ConfirmUnusualSkip_d__2.NativeFieldInfoPtr__promptCommand_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnusualSelectionUtil._ConfirmUnusualSkip_d__2>.NativeClassPtr, "<promptCommand>5__5");
				UnusualSelectionUtil._ConfirmUnusualSkip_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnusualSelectionUtil._ConfirmUnusualSkip_d__2>.NativeClassPtr, 100664849);
				UnusualSelectionUtil._ConfirmUnusualSkip_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnusualSelectionUtil._ConfirmUnusualSkip_d__2>.NativeClassPtr, 100664850);
				UnusualSelectionUtil._ConfirmUnusualSkip_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnusualSelectionUtil._ConfirmUnusualSkip_d__2>.NativeClassPtr, 100664851);
				UnusualSelectionUtil._ConfirmUnusualSkip_d__2.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_Nullable_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnusualSelectionUtil._ConfirmUnusualSkip_d__2>.NativeClassPtr, 100664852);
				UnusualSelectionUtil._ConfirmUnusualSkip_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnusualSelectionUtil._ConfirmUnusualSkip_d__2>.NativeClassPtr, 100664853);
				UnusualSelectionUtil._ConfirmUnusualSkip_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnusualSelectionUtil._ConfirmUnusualSkip_d__2>.NativeClassPtr, 100664854);
			}

			// Token: 0x06002723 RID: 10019 RVA: 0x0009D9B4 File Offset: 0x0009BBB4
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _ConfirmUnusualSkip_d__2(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnusualSelectionUtil._ConfirmUnusualSkip_d__2>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnusualSelectionUtil._ConfirmUnusualSkip_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002724 RID: 10020 RVA: 0x0009D9FC File Offset: 0x0009BBFC
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnusualSelectionUtil._ConfirmUnusualSkip_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002725 RID: 10021 RVA: 0x0009DA30 File Offset: 0x0009BC30
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 507086, XrefRangeEnd = 507147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnusualSelectionUtil._ConfirmUnusualSkip_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000AEC RID: 2796
			// (get) Token: 0x06002726 RID: 10022 RVA: 0x0009DA6C File Offset: 0x0009BC6C
			public unsafe Nullable<bool> prop_Nullable_1_Boolean_0
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnusualSelectionUtil._ConfirmUnusualSkip_d__2.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_Nullable_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new Nullable<bool>(intPtr);
				}
			}

			// Token: 0x06002727 RID: 10023 RVA: 0x0009DAA4 File Offset: 0x0009BCA4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 507147, XrefRangeEnd = 507152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnusualSelectionUtil._ConfirmUnusualSkip_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000AED RID: 2797
			// (get) Token: 0x06002728 RID: 10024 RVA: 0x0009DAD8 File Offset: 0x0009BCD8
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 507152, XrefRangeEnd = 507155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnusualSelectionUtil._ConfirmUnusualSkip_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002729 RID: 10025 RVA: 0x000144DA File Offset: 0x000126DA
			public _ConfirmUnusualSkip_d__2(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000AE5 RID: 2789
			// (get) Token: 0x0600272A RID: 10026 RVA: 0x0009DB18 File Offset: 0x0009BD18
			// (set) Token: 0x0600272B RID: 10027 RVA: 0x000144E3 File Offset: 0x000126E3
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnusualSelectionUtil._ConfirmUnusualSkip_d__2.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnusualSelectionUtil._ConfirmUnusualSkip_d__2.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000AE6 RID: 2790
			// (get) Token: 0x0600272C RID: 10028 RVA: 0x0009DB40 File Offset: 0x0009BD40
			// (set) Token: 0x0600272D RID: 10029 RVA: 0x000144FE File Offset: 0x000126FE
			public Nullable<bool> __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnusualSelectionUtil._ConfirmUnusualSkip_d__2.NativeFieldInfoPtr___2__current);
					return new Nullable<bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnusualSelectionUtil._ConfirmUnusualSkip_d__2.NativeFieldInfoPtr___2__current), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000AE7 RID: 2791
			// (get) Token: 0x0600272E RID: 10030 RVA: 0x0009DB70 File Offset: 0x0009BD70
			// (set) Token: 0x0600272F RID: 10031 RVA: 0x0001452C File Offset: 0x0001272C
			public unsafe Il2CppStringArray promptFlavors
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnusualSelectionUtil._ConfirmUnusualSkip_d__2.NativeFieldInfoPtr_promptFlavors);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnusualSelectionUtil._ConfirmUnusualSkip_d__2.NativeFieldInfoPtr_promptFlavors), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000AE8 RID: 2792
			// (get) Token: 0x06002730 RID: 10032 RVA: 0x0009DBA0 File Offset: 0x0009BDA0
			// (set) Token: 0x06002731 RID: 10033 RVA: 0x0001454B File Offset: 0x0001274B
			public unsafe DBGSelectionResponder _selectionResponder_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnusualSelectionUtil._ConfirmUnusualSkip_d__2.NativeFieldInfoPtr__selectionResponder_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGSelectionResponder>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnusualSelectionUtil._ConfirmUnusualSkip_d__2.NativeFieldInfoPtr__selectionResponder_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000AE9 RID: 2793
			// (get) Token: 0x06002732 RID: 10034 RVA: 0x0009DBD0 File Offset: 0x0009BDD0
			// (set) Token: 0x06002733 RID: 10035 RVA: 0x0001456A File Offset: 0x0001276A
			public unsafe ISelectionNode _node_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnusualSelectionUtil._ConfirmUnusualSkip_d__2.NativeFieldInfoPtr__node_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ISelectionNode>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnusualSelectionUtil._ConfirmUnusualSkip_d__2.NativeFieldInfoPtr__node_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000AEA RID: 2794
			// (get) Token: 0x06002734 RID: 10036 RVA: 0x0009DC00 File Offset: 0x0009BE00
			// (set) Token: 0x06002735 RID: 10037 RVA: 0x00014589 File Offset: 0x00012789
			public unsafe ConfirmOrDenyPrompt _confirmOrDeny_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnusualSelectionUtil._ConfirmUnusualSkip_d__2.NativeFieldInfoPtr__confirmOrDeny_5__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConfirmOrDenyPrompt>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnusualSelectionUtil._ConfirmUnusualSkip_d__2.NativeFieldInfoPtr__confirmOrDeny_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000AEB RID: 2795
			// (get) Token: 0x06002736 RID: 10038 RVA: 0x0009DC30 File Offset: 0x0009BE30
			// (set) Token: 0x06002737 RID: 10039 RVA: 0x000145A8 File Offset: 0x000127A8
			public unsafe DisplayGenericPrompt _promptCommand_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnusualSelectionUtil._ConfirmUnusualSkip_d__2.NativeFieldInfoPtr__promptCommand_5__5);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DisplayGenericPrompt>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnusualSelectionUtil._ConfirmUnusualSkip_d__2.NativeFieldInfoPtr__promptCommand_5__5), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400188E RID: 6286
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400188F RID: 6287
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001890 RID: 6288
			private static readonly IntPtr NativeFieldInfoPtr_promptFlavors;

			// Token: 0x04001891 RID: 6289
			private static readonly IntPtr NativeFieldInfoPtr__selectionResponder_5__2;

			// Token: 0x04001892 RID: 6290
			private static readonly IntPtr NativeFieldInfoPtr__node_5__3;

			// Token: 0x04001893 RID: 6291
			private static readonly IntPtr NativeFieldInfoPtr__confirmOrDeny_5__4;

			// Token: 0x04001894 RID: 6292
			private static readonly IntPtr NativeFieldInfoPtr__promptCommand_5__5;

			// Token: 0x04001895 RID: 6293
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001896 RID: 6294
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001897 RID: 6295
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001898 RID: 6296
			private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_Nullable_1_Boolean_0;

			// Token: 0x04001899 RID: 6297
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400189A RID: 6298
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
