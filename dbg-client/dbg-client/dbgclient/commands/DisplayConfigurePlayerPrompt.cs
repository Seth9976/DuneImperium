using System;
using boardgames.menus.prompts;
using dwd.core.commands;
using dwd.core.data.composition;
using dwd.core.ui.prompt.prompts;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace dbgclient.commands
{
	// Token: 0x020000D8 RID: 216
	public class DisplayConfigurePlayerPrompt : Command
	{
		// Token: 0x06000923 RID: 2339 RVA: 0x0003A594 File Offset: 0x00038794
		// Note: this type is marked as 'beforefieldinit'.
		static DisplayConfigurePlayerPrompt()
		{
			Il2CppClassPointerStore<DisplayConfigurePlayerPrompt>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "dbgclient.commands", "DisplayConfigurePlayerPrompt");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DisplayConfigurePlayerPrompt>.NativeClassPtr);
			DisplayConfigurePlayerPrompt.NativeFieldInfoPtr_configurePlayerPrompt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisplayConfigurePlayerPrompt>.NativeClassPtr, "configurePlayerPrompt");
			DisplayConfigurePlayerPrompt.NativeFieldInfoPtr_playerComposition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisplayConfigurePlayerPrompt>.NativeClassPtr, "playerComposition");
			DisplayConfigurePlayerPrompt.NativeFieldInfoPtr_allPlayerCompositions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisplayConfigurePlayerPrompt>.NativeClassPtr, "allPlayerCompositions");
			DisplayConfigurePlayerPrompt.NativeFieldInfoPtr_modalScope = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisplayConfigurePlayerPrompt>.NativeClassPtr, "modalScope");
			DisplayConfigurePlayerPrompt.NativeFieldInfoPtr_allColors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisplayConfigurePlayerPrompt>.NativeClassPtr, "allColors");
			DisplayConfigurePlayerPrompt.NativeFieldInfoPtr_allAvatars = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisplayConfigurePlayerPrompt>.NativeClassPtr, "allAvatars");
			DisplayConfigurePlayerPrompt.NativeMethodInfoPtr__ctor_Public_Void_DataComposition_IEnumerable_1_DataComposition_Il2CppStringArray_Il2CppStringArray_ModalScope_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisplayConfigurePlayerPrompt>.NativeClassPtr, 100664607);
			DisplayConfigurePlayerPrompt.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisplayConfigurePlayerPrompt>.NativeClassPtr, 100664608);
			DisplayConfigurePlayerPrompt.NativeMethodInfoPtr_UpdateValidData_Public_Void_DataComposition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisplayConfigurePlayerPrompt>.NativeClassPtr, 100664609);
			DisplayConfigurePlayerPrompt.NativeMethodInfoPtr_getValidColors_Private_List_1_String_DataComposition_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisplayConfigurePlayerPrompt>.NativeClassPtr, 100664610);
			DisplayConfigurePlayerPrompt.NativeMethodInfoPtr_getValidAvatars_Private_List_1_String_DataComposition_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisplayConfigurePlayerPrompt>.NativeClassPtr, 100664611);
		}

		// Token: 0x06000924 RID: 2340 RVA: 0x0003A6A0 File Offset: 0x000388A0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 505250, RefRangeEnd = 505252, XrefRangeStart = 505244, XrefRangeEnd = 505250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DisplayConfigurePlayerPrompt(DataComposition playerComposition, IEnumerable<DataComposition> allPlayerCompositions, Il2CppStringArray allColors, Il2CppStringArray allAvatars, ModalScope modalScope)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DisplayConfigurePlayerPrompt>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(playerComposition);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(allPlayerCompositions);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(allColors);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(allAvatars);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(modalScope);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DisplayConfigurePlayerPrompt.NativeMethodInfoPtr__ctor_Public_Void_DataComposition_IEnumerable_1_DataComposition_Il2CppStringArray_Il2CppStringArray_ModalScope_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000925 RID: 2341 RVA: 0x0003A738 File Offset: 0x00038938
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 505252, XrefRangeEnd = 505257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DisplayConfigurePlayerPrompt.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000926 RID: 2342 RVA: 0x0003A784 File Offset: 0x00038984
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 505261, RefRangeEnd = 505263, XrefRangeStart = 505257, XrefRangeEnd = 505261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateValidData(DataComposition newPlayerComposition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(newPlayerComposition);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DisplayConfigurePlayerPrompt.NativeMethodInfoPtr_UpdateValidData_Public_Void_DataComposition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000927 RID: 2343 RVA: 0x0003A7C8 File Offset: 0x000389C8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 505320, RefRangeEnd = 505322, XrefRangeStart = 505263, XrefRangeEnd = 505320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<string> getValidColors(DataComposition data, bool ignoreNonHuman)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ignoreNonHuman;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DisplayConfigurePlayerPrompt.NativeMethodInfoPtr_getValidColors_Private_List_1_String_DataComposition_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
		}

		// Token: 0x06000928 RID: 2344 RVA: 0x0003A828 File Offset: 0x00038A28
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 505379, RefRangeEnd = 505381, XrefRangeStart = 505322, XrefRangeEnd = 505379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<string> getValidAvatars(DataComposition data, bool ignoreNonHuman)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ignoreNonHuman;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DisplayConfigurePlayerPrompt.NativeMethodInfoPtr_getValidAvatars_Private_List_1_String_DataComposition_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
		}

		// Token: 0x06000929 RID: 2345 RVA: 0x000064C3 File Offset: 0x000046C3
		public DisplayConfigurePlayerPrompt(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000272 RID: 626
		// (get) Token: 0x0600092A RID: 2346 RVA: 0x0003A888 File Offset: 0x00038A88
		// (set) Token: 0x0600092B RID: 2347 RVA: 0x000064CC File Offset: 0x000046CC
		public unsafe ConfigurePlayerPrompt configurePlayerPrompt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DisplayConfigurePlayerPrompt.NativeFieldInfoPtr_configurePlayerPrompt);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConfigurePlayerPrompt>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DisplayConfigurePlayerPrompt.NativeFieldInfoPtr_configurePlayerPrompt), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000273 RID: 627
		// (get) Token: 0x0600092C RID: 2348 RVA: 0x0003A8B8 File Offset: 0x00038AB8
		// (set) Token: 0x0600092D RID: 2349 RVA: 0x000064EB File Offset: 0x000046EB
		public unsafe DataComposition playerComposition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DisplayConfigurePlayerPrompt.NativeFieldInfoPtr_playerComposition);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataComposition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DisplayConfigurePlayerPrompt.NativeFieldInfoPtr_playerComposition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000274 RID: 628
		// (get) Token: 0x0600092E RID: 2350 RVA: 0x0003A8E8 File Offset: 0x00038AE8
		// (set) Token: 0x0600092F RID: 2351 RVA: 0x0000650A File Offset: 0x0000470A
		public unsafe IEnumerable<DataComposition> allPlayerCompositions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DisplayConfigurePlayerPrompt.NativeFieldInfoPtr_allPlayerCompositions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<DataComposition>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DisplayConfigurePlayerPrompt.NativeFieldInfoPtr_allPlayerCompositions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000275 RID: 629
		// (get) Token: 0x06000930 RID: 2352 RVA: 0x0003A918 File Offset: 0x00038B18
		// (set) Token: 0x06000931 RID: 2353 RVA: 0x00006529 File Offset: 0x00004729
		public unsafe ModalScope modalScope
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DisplayConfigurePlayerPrompt.NativeFieldInfoPtr_modalScope);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ModalScope>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DisplayConfigurePlayerPrompt.NativeFieldInfoPtr_modalScope), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000276 RID: 630
		// (get) Token: 0x06000932 RID: 2354 RVA: 0x0003A948 File Offset: 0x00038B48
		// (set) Token: 0x06000933 RID: 2355 RVA: 0x00006548 File Offset: 0x00004748
		public unsafe Il2CppStringArray allColors
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DisplayConfigurePlayerPrompt.NativeFieldInfoPtr_allColors);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DisplayConfigurePlayerPrompt.NativeFieldInfoPtr_allColors), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000277 RID: 631
		// (get) Token: 0x06000934 RID: 2356 RVA: 0x0003A978 File Offset: 0x00038B78
		// (set) Token: 0x06000935 RID: 2357 RVA: 0x00006567 File Offset: 0x00004767
		public unsafe Il2CppStringArray allAvatars
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DisplayConfigurePlayerPrompt.NativeFieldInfoPtr_allAvatars);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DisplayConfigurePlayerPrompt.NativeFieldInfoPtr_allAvatars), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000590 RID: 1424
		private static readonly IntPtr NativeFieldInfoPtr_configurePlayerPrompt;

		// Token: 0x04000591 RID: 1425
		private static readonly IntPtr NativeFieldInfoPtr_playerComposition;

		// Token: 0x04000592 RID: 1426
		private static readonly IntPtr NativeFieldInfoPtr_allPlayerCompositions;

		// Token: 0x04000593 RID: 1427
		private static readonly IntPtr NativeFieldInfoPtr_modalScope;

		// Token: 0x04000594 RID: 1428
		private static readonly IntPtr NativeFieldInfoPtr_allColors;

		// Token: 0x04000595 RID: 1429
		private static readonly IntPtr NativeFieldInfoPtr_allAvatars;

		// Token: 0x04000596 RID: 1430
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_DataComposition_IEnumerable_1_DataComposition_Il2CppStringArray_Il2CppStringArray_ModalScope_0;

		// Token: 0x04000597 RID: 1431
		private static readonly IntPtr NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0;

		// Token: 0x04000598 RID: 1432
		private static readonly IntPtr NativeMethodInfoPtr_UpdateValidData_Public_Void_DataComposition_0;

		// Token: 0x04000599 RID: 1433
		private static readonly IntPtr NativeMethodInfoPtr_getValidColors_Private_List_1_String_DataComposition_Boolean_0;

		// Token: 0x0400059A RID: 1434
		private static readonly IntPtr NativeMethodInfoPtr_getValidAvatars_Private_List_1_String_DataComposition_Boolean_0;

		// Token: 0x02000325 RID: 805
		[ObfuscatedName("dbgclient.commands.DisplayConfigurePlayerPrompt+<>c__DisplayClass10_0")]
		public sealed class __c__DisplayClass10_0 : Object
		{
			// Token: 0x06002601 RID: 9729 RVA: 0x0009A2C8 File Offset: 0x000984C8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass10_0()
			{
				Il2CppClassPointerStore<DisplayConfigurePlayerPrompt.__c__DisplayClass10_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DisplayConfigurePlayerPrompt>.NativeClassPtr, "<>c__DisplayClass10_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DisplayConfigurePlayerPrompt.__c__DisplayClass10_0>.NativeClassPtr);
				DisplayConfigurePlayerPrompt.__c__DisplayClass10_0.NativeFieldInfoPtr_takenAvatars = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisplayConfigurePlayerPrompt.__c__DisplayClass10_0>.NativeClassPtr, "takenAvatars");
				DisplayConfigurePlayerPrompt.__c__DisplayClass10_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisplayConfigurePlayerPrompt.__c__DisplayClass10_0>.NativeClassPtr, 100664612);
				DisplayConfigurePlayerPrompt.__c__DisplayClass10_0.NativeMethodInfoPtr__getValidAvatars_b__0_Internal_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisplayConfigurePlayerPrompt.__c__DisplayClass10_0>.NativeClassPtr, 100664613);
			}

			// Token: 0x06002602 RID: 9730 RVA: 0x0009A330 File Offset: 0x00098530
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass10_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DisplayConfigurePlayerPrompt.__c__DisplayClass10_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DisplayConfigurePlayerPrompt.__c__DisplayClass10_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002603 RID: 9731 RVA: 0x0009A36C File Offset: 0x0009856C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 505195, XrefRangeEnd = 505198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _getValidAvatars_b__0(string avatar)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(avatar);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DisplayConfigurePlayerPrompt.__c__DisplayClass10_0.NativeMethodInfoPtr__getValidAvatars_b__0_Internal_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002604 RID: 9732 RVA: 0x00013B73 File Offset: 0x00011D73
			public __c__DisplayClass10_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000A7D RID: 2685
			// (get) Token: 0x06002605 RID: 9733 RVA: 0x0009A3BC File Offset: 0x000985BC
			// (set) Token: 0x06002606 RID: 9734 RVA: 0x00013B7C File Offset: 0x00011D7C
			public unsafe List<string> takenAvatars
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DisplayConfigurePlayerPrompt.__c__DisplayClass10_0.NativeFieldInfoPtr_takenAvatars);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DisplayConfigurePlayerPrompt.__c__DisplayClass10_0.NativeFieldInfoPtr_takenAvatars), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040017D5 RID: 6101
			private static readonly IntPtr NativeFieldInfoPtr_takenAvatars;

			// Token: 0x040017D6 RID: 6102
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040017D7 RID: 6103
			private static readonly IntPtr NativeMethodInfoPtr__getValidAvatars_b__0_Internal_Boolean_String_0;
		}

		// Token: 0x02000326 RID: 806
		[ObfuscatedName("dbgclient.commands.DisplayConfigurePlayerPrompt+<>c__DisplayClass9_0")]
		public sealed class __c__DisplayClass9_0 : Object
		{
			// Token: 0x06002607 RID: 9735 RVA: 0x0009A3EC File Offset: 0x000985EC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass9_0()
			{
				Il2CppClassPointerStore<DisplayConfigurePlayerPrompt.__c__DisplayClass9_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DisplayConfigurePlayerPrompt>.NativeClassPtr, "<>c__DisplayClass9_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DisplayConfigurePlayerPrompt.__c__DisplayClass9_0>.NativeClassPtr);
				DisplayConfigurePlayerPrompt.__c__DisplayClass9_0.NativeFieldInfoPtr_takenColors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisplayConfigurePlayerPrompt.__c__DisplayClass9_0>.NativeClassPtr, "takenColors");
				DisplayConfigurePlayerPrompt.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisplayConfigurePlayerPrompt.__c__DisplayClass9_0>.NativeClassPtr, 100664614);
				DisplayConfigurePlayerPrompt.__c__DisplayClass9_0.NativeMethodInfoPtr__getValidColors_b__0_Internal_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisplayConfigurePlayerPrompt.__c__DisplayClass9_0>.NativeClassPtr, 100664615);
			}

			// Token: 0x06002608 RID: 9736 RVA: 0x0009A454 File Offset: 0x00098654
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass9_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DisplayConfigurePlayerPrompt.__c__DisplayClass9_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DisplayConfigurePlayerPrompt.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002609 RID: 9737 RVA: 0x0009A490 File Offset: 0x00098690
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 505198, XrefRangeEnd = 505201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _getValidColors_b__0(string color)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(color);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DisplayConfigurePlayerPrompt.__c__DisplayClass9_0.NativeMethodInfoPtr__getValidColors_b__0_Internal_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600260A RID: 9738 RVA: 0x00013B9B File Offset: 0x00011D9B
			public __c__DisplayClass9_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000A7E RID: 2686
			// (get) Token: 0x0600260B RID: 9739 RVA: 0x0009A4E0 File Offset: 0x000986E0
			// (set) Token: 0x0600260C RID: 9740 RVA: 0x00013BA4 File Offset: 0x00011DA4
			public unsafe List<string> takenColors
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DisplayConfigurePlayerPrompt.__c__DisplayClass9_0.NativeFieldInfoPtr_takenColors);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DisplayConfigurePlayerPrompt.__c__DisplayClass9_0.NativeFieldInfoPtr_takenColors), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040017D8 RID: 6104
			private static readonly IntPtr NativeFieldInfoPtr_takenColors;

			// Token: 0x040017D9 RID: 6105
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040017DA RID: 6106
			private static readonly IntPtr NativeMethodInfoPtr__getValidColors_b__0_Internal_Boolean_String_0;
		}

		// Token: 0x02000327 RID: 807
		[ObfuscatedName("dbgclient.commands.DisplayConfigurePlayerPrompt+<execute>d__7")]
		public sealed class _execute_d__7 : Object
		{
			// Token: 0x0600260D RID: 9741 RVA: 0x0009A510 File Offset: 0x00098710
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__7()
			{
				Il2CppClassPointerStore<DisplayConfigurePlayerPrompt._execute_d__7>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DisplayConfigurePlayerPrompt>.NativeClassPtr, "<execute>d__7");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DisplayConfigurePlayerPrompt._execute_d__7>.NativeClassPtr);
				DisplayConfigurePlayerPrompt._execute_d__7.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisplayConfigurePlayerPrompt._execute_d__7>.NativeClassPtr, "<>1__state");
				DisplayConfigurePlayerPrompt._execute_d__7.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisplayConfigurePlayerPrompt._execute_d__7>.NativeClassPtr, "<>2__current");
				DisplayConfigurePlayerPrompt._execute_d__7.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisplayConfigurePlayerPrompt._execute_d__7>.NativeClassPtr, "<>4__this");
				DisplayConfigurePlayerPrompt._execute_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisplayConfigurePlayerPrompt._execute_d__7>.NativeClassPtr, 100664616);
				DisplayConfigurePlayerPrompt._execute_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisplayConfigurePlayerPrompt._execute_d__7>.NativeClassPtr, 100664617);
				DisplayConfigurePlayerPrompt._execute_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisplayConfigurePlayerPrompt._execute_d__7>.NativeClassPtr, 100664618);
				DisplayConfigurePlayerPrompt._execute_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisplayConfigurePlayerPrompt._execute_d__7>.NativeClassPtr, 100664619);
				DisplayConfigurePlayerPrompt._execute_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisplayConfigurePlayerPrompt._execute_d__7>.NativeClassPtr, 100664620);
				DisplayConfigurePlayerPrompt._execute_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisplayConfigurePlayerPrompt._execute_d__7>.NativeClassPtr, 100664621);
			}

			// Token: 0x0600260E RID: 9742 RVA: 0x0009A5F0 File Offset: 0x000987F0
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__7(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DisplayConfigurePlayerPrompt._execute_d__7>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DisplayConfigurePlayerPrompt._execute_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600260F RID: 9743 RVA: 0x0009A638 File Offset: 0x00098838
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DisplayConfigurePlayerPrompt._execute_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002610 RID: 9744 RVA: 0x0009A66C File Offset: 0x0009886C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 505201, XrefRangeEnd = 505239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DisplayConfigurePlayerPrompt._execute_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000A82 RID: 2690
			// (get) Token: 0x06002611 RID: 9745 RVA: 0x0009A6A8 File Offset: 0x000988A8
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DisplayConfigurePlayerPrompt._execute_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002612 RID: 9746 RVA: 0x0009A6E8 File Offset: 0x000988E8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 505239, XrefRangeEnd = 505244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DisplayConfigurePlayerPrompt._execute_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000A83 RID: 2691
			// (get) Token: 0x06002613 RID: 9747 RVA: 0x0009A71C File Offset: 0x0009891C
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DisplayConfigurePlayerPrompt._execute_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002614 RID: 9748 RVA: 0x00013BC3 File Offset: 0x00011DC3
			public _execute_d__7(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000A7F RID: 2687
			// (get) Token: 0x06002615 RID: 9749 RVA: 0x0009A75C File Offset: 0x0009895C
			// (set) Token: 0x06002616 RID: 9750 RVA: 0x00013BCC File Offset: 0x00011DCC
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DisplayConfigurePlayerPrompt._execute_d__7.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DisplayConfigurePlayerPrompt._execute_d__7.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000A80 RID: 2688
			// (get) Token: 0x06002617 RID: 9751 RVA: 0x0009A784 File Offset: 0x00098984
			// (set) Token: 0x06002618 RID: 9752 RVA: 0x00013BE7 File Offset: 0x00011DE7
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DisplayConfigurePlayerPrompt._execute_d__7.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DisplayConfigurePlayerPrompt._execute_d__7.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A81 RID: 2689
			// (get) Token: 0x06002619 RID: 9753 RVA: 0x0009A7B4 File Offset: 0x000989B4
			// (set) Token: 0x0600261A RID: 9754 RVA: 0x00013C06 File Offset: 0x00011E06
			public unsafe DisplayConfigurePlayerPrompt __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DisplayConfigurePlayerPrompt._execute_d__7.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DisplayConfigurePlayerPrompt>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DisplayConfigurePlayerPrompt._execute_d__7.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040017DB RID: 6107
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040017DC RID: 6108
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040017DD RID: 6109
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040017DE RID: 6110
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040017DF RID: 6111
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040017E0 RID: 6112
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040017E1 RID: 6113
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040017E2 RID: 6114
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040017E3 RID: 6115
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
