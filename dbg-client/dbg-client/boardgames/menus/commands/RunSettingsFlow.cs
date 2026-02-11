using System;
using boardgames.match.data;
using boardgames.prompts;
using Canis;
using dwd.core.commands;
using dwd.core.ui.prompt.prompts;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;

namespace boardgames.menus.commands
{
	// Token: 0x02000235 RID: 565
	public class RunSettingsFlow : Command
	{
		// Token: 0x0600199E RID: 6558 RVA: 0x00070DC4 File Offset: 0x0006EFC4
		// Note: this type is marked as 'beforefieldinit'.
		static RunSettingsFlow()
		{
			Il2CppClassPointerStore<RunSettingsFlow>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.menus.commands", "RunSettingsFlow");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RunSettingsFlow>.NativeClassPtr);
			RunSettingsFlow.NativeFieldInfoPtr_startingTab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunSettingsFlow>.NativeClassPtr, "startingTab");
			RunSettingsFlow.NativeFieldInfoPtr_subPromptsOpen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunSettingsFlow>.NativeClassPtr, "subPromptsOpen");
			RunSettingsFlow.NativeFieldInfoPtr__Prompt_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunSettingsFlow>.NativeClassPtr, "<Prompt>k__BackingField");
			RunSettingsFlow.NativeMethodInfoPtr__ctor_Public_Void_SettingsPromptTab_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunSettingsFlow>.NativeClassPtr, 100667307);
			RunSettingsFlow.NativeMethodInfoPtr_get_Prompt_Public_get_SettingsPrompt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunSettingsFlow>.NativeClassPtr, 100667308);
			RunSettingsFlow.NativeMethodInfoPtr_set_Prompt_Private_set_Void_SettingsPrompt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunSettingsFlow>.NativeClassPtr, 100667309);
			RunSettingsFlow.NativeMethodInfoPtr_OpenedSubPrompt_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunSettingsFlow>.NativeClassPtr, 100667310);
			RunSettingsFlow.NativeMethodInfoPtr_ClosedSubPrompt_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunSettingsFlow>.NativeClassPtr, 100667311);
			RunSettingsFlow.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunSettingsFlow>.NativeClassPtr, 100667312);
			RunSettingsFlow.NativeMethodInfoPtr_RestartFlow_Private_IEnumerator_SettingsPromptTab_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunSettingsFlow>.NativeClassPtr, 100667313);
		}

		// Token: 0x0600199F RID: 6559 RVA: 0x00070EBC File Offset: 0x0006F0BC
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 505412, RefRangeEnd = 505418, XrefRangeStart = 505412, XrefRangeEnd = 505418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RunSettingsFlow(SettingsPromptTab startingTab = SettingsPromptTab.General)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunSettingsFlow>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref startingTab;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunSettingsFlow.NativeMethodInfoPtr__ctor_Public_Void_SettingsPromptTab_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170006D9 RID: 1753
		// (get) Token: 0x060019A0 RID: 6560 RVA: 0x00070F04 File Offset: 0x0006F104
		// (set) Token: 0x060019A1 RID: 6561 RVA: 0x00070F44 File Offset: 0x0006F144
		public unsafe SettingsPrompt Prompt
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunSettingsFlow.NativeMethodInfoPtr_get_Prompt_Public_get_SettingsPrompt_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SettingsPrompt>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunSettingsFlow.NativeMethodInfoPtr_set_Prompt_Private_set_Void_SettingsPrompt_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060019A2 RID: 6562 RVA: 0x00070F88 File Offset: 0x0006F188
		[CallerCount(0)]
		public unsafe void OpenedSubPrompt()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunSettingsFlow.NativeMethodInfoPtr_OpenedSubPrompt_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019A3 RID: 6563 RVA: 0x00070FBC File Offset: 0x0006F1BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 530365, RefRangeEnd = 530366, XrefRangeStart = 530365, XrefRangeEnd = 530365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClosedSubPrompt()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunSettingsFlow.NativeMethodInfoPtr_ClosedSubPrompt_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019A4 RID: 6564 RVA: 0x00070FF0 File Offset: 0x0006F1F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 530366, XrefRangeEnd = 530371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RunSettingsFlow.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060019A5 RID: 6565 RVA: 0x0007103C File Offset: 0x0006F23C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 530376, RefRangeEnd = 530380, XrefRangeStart = 530371, XrefRangeEnd = 530376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator RestartFlow(SettingsPromptTab start = SettingsPromptTab.Gameplay)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref start;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunSettingsFlow.NativeMethodInfoPtr_RestartFlow_Private_IEnumerator_SettingsPromptTab_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x060019A6 RID: 6566 RVA: 0x0000E0F6 File Offset: 0x0000C2F6
		public RunSettingsFlow(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006D6 RID: 1750
		// (get) Token: 0x060019A7 RID: 6567 RVA: 0x00071088 File Offset: 0x0006F288
		// (set) Token: 0x060019A8 RID: 6568 RVA: 0x0000E0FF File Offset: 0x0000C2FF
		public unsafe SettingsPromptTab startingTab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunSettingsFlow.NativeFieldInfoPtr_startingTab);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunSettingsFlow.NativeFieldInfoPtr_startingTab)) = value;
			}
		}

		// Token: 0x170006D7 RID: 1751
		// (get) Token: 0x060019A9 RID: 6569 RVA: 0x000710B0 File Offset: 0x0006F2B0
		// (set) Token: 0x060019AA RID: 6570 RVA: 0x0000E11A File Offset: 0x0000C31A
		public unsafe int subPromptsOpen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunSettingsFlow.NativeFieldInfoPtr_subPromptsOpen);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunSettingsFlow.NativeFieldInfoPtr_subPromptsOpen)) = value;
			}
		}

		// Token: 0x170006D8 RID: 1752
		// (get) Token: 0x060019AB RID: 6571 RVA: 0x000710D8 File Offset: 0x0006F2D8
		// (set) Token: 0x060019AC RID: 6572 RVA: 0x0000E135 File Offset: 0x0000C335
		public unsafe SettingsPrompt _Prompt_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunSettingsFlow.NativeFieldInfoPtr__Prompt_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SettingsPrompt>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunSettingsFlow.NativeFieldInfoPtr__Prompt_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000FFB RID: 4091
		private static readonly IntPtr NativeFieldInfoPtr_startingTab;

		// Token: 0x04000FFC RID: 4092
		private static readonly IntPtr NativeFieldInfoPtr_subPromptsOpen;

		// Token: 0x04000FFD RID: 4093
		private static readonly IntPtr NativeFieldInfoPtr__Prompt_k__BackingField;

		// Token: 0x04000FFE RID: 4094
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SettingsPromptTab_0;

		// Token: 0x04000FFF RID: 4095
		private static readonly IntPtr NativeMethodInfoPtr_get_Prompt_Public_get_SettingsPrompt_0;

		// Token: 0x04001000 RID: 4096
		private static readonly IntPtr NativeMethodInfoPtr_set_Prompt_Private_set_Void_SettingsPrompt_0;

		// Token: 0x04001001 RID: 4097
		private static readonly IntPtr NativeMethodInfoPtr_OpenedSubPrompt_Public_Void_0;

		// Token: 0x04001002 RID: 4098
		private static readonly IntPtr NativeMethodInfoPtr_ClosedSubPrompt_Public_Void_0;

		// Token: 0x04001003 RID: 4099
		private static readonly IntPtr NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0;

		// Token: 0x04001004 RID: 4100
		private static readonly IntPtr NativeMethodInfoPtr_RestartFlow_Private_IEnumerator_SettingsPromptTab_0;

		// Token: 0x0200041D RID: 1053
		[ObfuscatedName("boardgames.menus.commands.RunSettingsFlow+<>c__DisplayClass9_0")]
		public sealed class __c__DisplayClass9_0 : Object
		{
			// Token: 0x060031C8 RID: 12744 RVA: 0x000BD04C File Offset: 0x000BB24C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass9_0()
			{
				Il2CppClassPointerStore<RunSettingsFlow.__c__DisplayClass9_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RunSettingsFlow>.NativeClassPtr, "<>c__DisplayClass9_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RunSettingsFlow.__c__DisplayClass9_0>.NativeClassPtr);
				RunSettingsFlow.__c__DisplayClass9_0.NativeFieldInfoPtr_optionsData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunSettingsFlow.__c__DisplayClass9_0>.NativeClassPtr, "optionsData");
				RunSettingsFlow.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunSettingsFlow.__c__DisplayClass9_0>.NativeClassPtr, 100667314);
				RunSettingsFlow.__c__DisplayClass9_0.NativeMethodInfoPtr__execute_b__0_Internal_Boolean_MatchInitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunSettingsFlow.__c__DisplayClass9_0>.NativeClassPtr, 100667315);
			}

			// Token: 0x060031C9 RID: 12745 RVA: 0x000BD0B4 File Offset: 0x000BB2B4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass9_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunSettingsFlow.__c__DisplayClass9_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunSettingsFlow.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060031CA RID: 12746 RVA: 0x000BD0F0 File Offset: 0x000BB2F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 529961, XrefRangeEnd = 530055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _execute_b__0(MatchInitData m)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunSettingsFlow.__c__DisplayClass9_0.NativeMethodInfoPtr__execute_b__0_Internal_Boolean_MatchInitData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060031CB RID: 12747 RVA: 0x00019BDF File Offset: 0x00017DDF
			public __c__DisplayClass9_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000E76 RID: 3702
			// (get) Token: 0x060031CC RID: 12748 RVA: 0x000BD140 File Offset: 0x000BB340
			// (set) Token: 0x060031CD RID: 12749 RVA: 0x00019BE8 File Offset: 0x00017DE8
			public unsafe GameOptionsData optionsData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunSettingsFlow.__c__DisplayClass9_0.NativeFieldInfoPtr_optionsData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameOptionsData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunSettingsFlow.__c__DisplayClass9_0.NativeFieldInfoPtr_optionsData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001EC0 RID: 7872
			private static readonly IntPtr NativeFieldInfoPtr_optionsData;

			// Token: 0x04001EC1 RID: 7873
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001EC2 RID: 7874
			private static readonly IntPtr NativeMethodInfoPtr__execute_b__0_Internal_Boolean_MatchInitData_0;
		}

		// Token: 0x0200041E RID: 1054
		[ObfuscatedName("boardgames.menus.commands.RunSettingsFlow+<RestartFlow>d__10")]
		public sealed class _RestartFlow_d__10 : Object
		{
			// Token: 0x060031CE RID: 12750 RVA: 0x000BD170 File Offset: 0x000BB370
			// Note: this type is marked as 'beforefieldinit'.
			static _RestartFlow_d__10()
			{
				Il2CppClassPointerStore<RunSettingsFlow._RestartFlow_d__10>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RunSettingsFlow>.NativeClassPtr, "<RestartFlow>d__10");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RunSettingsFlow._RestartFlow_d__10>.NativeClassPtr);
				RunSettingsFlow._RestartFlow_d__10.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunSettingsFlow._RestartFlow_d__10>.NativeClassPtr, "<>1__state");
				RunSettingsFlow._RestartFlow_d__10.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunSettingsFlow._RestartFlow_d__10>.NativeClassPtr, "<>2__current");
				RunSettingsFlow._RestartFlow_d__10.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunSettingsFlow._RestartFlow_d__10>.NativeClassPtr, "<>4__this");
				RunSettingsFlow._RestartFlow_d__10.NativeFieldInfoPtr_start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunSettingsFlow._RestartFlow_d__10>.NativeClassPtr, "start");
				RunSettingsFlow._RestartFlow_d__10.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunSettingsFlow._RestartFlow_d__10>.NativeClassPtr, 100667316);
				RunSettingsFlow._RestartFlow_d__10.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunSettingsFlow._RestartFlow_d__10>.NativeClassPtr, 100667317);
				RunSettingsFlow._RestartFlow_d__10.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunSettingsFlow._RestartFlow_d__10>.NativeClassPtr, 100667318);
				RunSettingsFlow._RestartFlow_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunSettingsFlow._RestartFlow_d__10>.NativeClassPtr, 100667319);
				RunSettingsFlow._RestartFlow_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunSettingsFlow._RestartFlow_d__10>.NativeClassPtr, 100667320);
				RunSettingsFlow._RestartFlow_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunSettingsFlow._RestartFlow_d__10>.NativeClassPtr, 100667321);
			}

			// Token: 0x060031CF RID: 12751 RVA: 0x000BD264 File Offset: 0x000BB464
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _RestartFlow_d__10(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunSettingsFlow._RestartFlow_d__10>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunSettingsFlow._RestartFlow_d__10.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060031D0 RID: 12752 RVA: 0x000BD2AC File Offset: 0x000BB4AC
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunSettingsFlow._RestartFlow_d__10.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060031D1 RID: 12753 RVA: 0x000BD2E0 File Offset: 0x000BB4E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 530055, XrefRangeEnd = 530057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunSettingsFlow._RestartFlow_d__10.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000E7B RID: 3707
			// (get) Token: 0x060031D2 RID: 12754 RVA: 0x000BD31C File Offset: 0x000BB51C
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunSettingsFlow._RestartFlow_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060031D3 RID: 12755 RVA: 0x000BD35C File Offset: 0x000BB55C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 530057, XrefRangeEnd = 530062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunSettingsFlow._RestartFlow_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000E7C RID: 3708
			// (get) Token: 0x060031D4 RID: 12756 RVA: 0x000BD390 File Offset: 0x000BB590
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunSettingsFlow._RestartFlow_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060031D5 RID: 12757 RVA: 0x00019C07 File Offset: 0x00017E07
			public _RestartFlow_d__10(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000E77 RID: 3703
			// (get) Token: 0x060031D6 RID: 12758 RVA: 0x000BD3D0 File Offset: 0x000BB5D0
			// (set) Token: 0x060031D7 RID: 12759 RVA: 0x00019C10 File Offset: 0x00017E10
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunSettingsFlow._RestartFlow_d__10.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunSettingsFlow._RestartFlow_d__10.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000E78 RID: 3704
			// (get) Token: 0x060031D8 RID: 12760 RVA: 0x000BD3F8 File Offset: 0x000BB5F8
			// (set) Token: 0x060031D9 RID: 12761 RVA: 0x00019C2B File Offset: 0x00017E2B
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunSettingsFlow._RestartFlow_d__10.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunSettingsFlow._RestartFlow_d__10.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000E79 RID: 3705
			// (get) Token: 0x060031DA RID: 12762 RVA: 0x000BD428 File Offset: 0x000BB628
			// (set) Token: 0x060031DB RID: 12763 RVA: 0x00019C4A File Offset: 0x00017E4A
			public unsafe RunSettingsFlow __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunSettingsFlow._RestartFlow_d__10.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RunSettingsFlow>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunSettingsFlow._RestartFlow_d__10.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000E7A RID: 3706
			// (get) Token: 0x060031DC RID: 12764 RVA: 0x000BD458 File Offset: 0x000BB658
			// (set) Token: 0x060031DD RID: 12765 RVA: 0x00019C69 File Offset: 0x00017E69
			public unsafe SettingsPromptTab start
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunSettingsFlow._RestartFlow_d__10.NativeFieldInfoPtr_start);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunSettingsFlow._RestartFlow_d__10.NativeFieldInfoPtr_start)) = value;
				}
			}

			// Token: 0x04001EC3 RID: 7875
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001EC4 RID: 7876
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001EC5 RID: 7877
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001EC6 RID: 7878
			private static readonly IntPtr NativeFieldInfoPtr_start;

			// Token: 0x04001EC7 RID: 7879
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001EC8 RID: 7880
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001EC9 RID: 7881
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001ECA RID: 7882
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001ECB RID: 7883
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001ECC RID: 7884
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x0200041F RID: 1055
		[ObfuscatedName("boardgames.menus.commands.RunSettingsFlow+<execute>d__9")]
		public sealed class _execute_d__9 : Object
		{
			// Token: 0x060031DE RID: 12766 RVA: 0x000BD480 File Offset: 0x000BB680
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__9()
			{
				Il2CppClassPointerStore<RunSettingsFlow._execute_d__9>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RunSettingsFlow>.NativeClassPtr, "<execute>d__9");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RunSettingsFlow._execute_d__9>.NativeClassPtr);
				RunSettingsFlow._execute_d__9.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunSettingsFlow._execute_d__9>.NativeClassPtr, "<>1__state");
				RunSettingsFlow._execute_d__9.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunSettingsFlow._execute_d__9>.NativeClassPtr, "<>2__current");
				RunSettingsFlow._execute_d__9.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunSettingsFlow._execute_d__9>.NativeClassPtr, "<>4__this");
				RunSettingsFlow._execute_d__9.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunSettingsFlow._execute_d__9>.NativeClassPtr, "<>8__1");
				RunSettingsFlow._execute_d__9.NativeFieldInfoPtr__confirmOrDeny_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunSettingsFlow._execute_d__9>.NativeClassPtr, "<confirmOrDeny>5__2");
				RunSettingsFlow._execute_d__9.NativeFieldInfoPtr__loginPromptFlow_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunSettingsFlow._execute_d__9>.NativeClassPtr, "<loginPromptFlow>5__3");
				RunSettingsFlow._execute_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunSettingsFlow._execute_d__9>.NativeClassPtr, 100667322);
				RunSettingsFlow._execute_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunSettingsFlow._execute_d__9>.NativeClassPtr, 100667323);
				RunSettingsFlow._execute_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunSettingsFlow._execute_d__9>.NativeClassPtr, 100667324);
				RunSettingsFlow._execute_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunSettingsFlow._execute_d__9>.NativeClassPtr, 100667325);
				RunSettingsFlow._execute_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunSettingsFlow._execute_d__9>.NativeClassPtr, 100667326);
				RunSettingsFlow._execute_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunSettingsFlow._execute_d__9>.NativeClassPtr, 100667327);
			}

			// Token: 0x060031DF RID: 12767 RVA: 0x000BD59C File Offset: 0x000BB79C
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__9(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunSettingsFlow._execute_d__9>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunSettingsFlow._execute_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060031E0 RID: 12768 RVA: 0x000BD5E4 File Offset: 0x000BB7E4
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunSettingsFlow._execute_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060031E1 RID: 12769 RVA: 0x000BD618 File Offset: 0x000BB818
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 530062, XrefRangeEnd = 530360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunSettingsFlow._execute_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000E83 RID: 3715
			// (get) Token: 0x060031E2 RID: 12770 RVA: 0x000BD654 File Offset: 0x000BB854
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunSettingsFlow._execute_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060031E3 RID: 12771 RVA: 0x000BD694 File Offset: 0x000BB894
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 530360, XrefRangeEnd = 530365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunSettingsFlow._execute_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000E84 RID: 3716
			// (get) Token: 0x060031E4 RID: 12772 RVA: 0x000BD6C8 File Offset: 0x000BB8C8
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunSettingsFlow._execute_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060031E5 RID: 12773 RVA: 0x00019C84 File Offset: 0x00017E84
			public _execute_d__9(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000E7D RID: 3709
			// (get) Token: 0x060031E6 RID: 12774 RVA: 0x000BD708 File Offset: 0x000BB908
			// (set) Token: 0x060031E7 RID: 12775 RVA: 0x00019C8D File Offset: 0x00017E8D
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunSettingsFlow._execute_d__9.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunSettingsFlow._execute_d__9.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000E7E RID: 3710
			// (get) Token: 0x060031E8 RID: 12776 RVA: 0x000BD730 File Offset: 0x000BB930
			// (set) Token: 0x060031E9 RID: 12777 RVA: 0x00019CA8 File Offset: 0x00017EA8
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunSettingsFlow._execute_d__9.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunSettingsFlow._execute_d__9.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000E7F RID: 3711
			// (get) Token: 0x060031EA RID: 12778 RVA: 0x000BD760 File Offset: 0x000BB960
			// (set) Token: 0x060031EB RID: 12779 RVA: 0x00019CC7 File Offset: 0x00017EC7
			public unsafe RunSettingsFlow __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunSettingsFlow._execute_d__9.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RunSettingsFlow>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunSettingsFlow._execute_d__9.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000E80 RID: 3712
			// (get) Token: 0x060031EC RID: 12780 RVA: 0x000BD790 File Offset: 0x000BB990
			// (set) Token: 0x060031ED RID: 12781 RVA: 0x00019CE6 File Offset: 0x00017EE6
			public unsafe RunSettingsFlow.__c__DisplayClass9_0 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunSettingsFlow._execute_d__9.NativeFieldInfoPtr___8__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RunSettingsFlow.__c__DisplayClass9_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunSettingsFlow._execute_d__9.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000E81 RID: 3713
			// (get) Token: 0x060031EE RID: 12782 RVA: 0x000BD7C0 File Offset: 0x000BB9C0
			// (set) Token: 0x060031EF RID: 12783 RVA: 0x00019D05 File Offset: 0x00017F05
			public unsafe ConfirmOrDenyPrompt _confirmOrDeny_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunSettingsFlow._execute_d__9.NativeFieldInfoPtr__confirmOrDeny_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConfirmOrDenyPrompt>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunSettingsFlow._execute_d__9.NativeFieldInfoPtr__confirmOrDeny_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000E82 RID: 3714
			// (get) Token: 0x060031F0 RID: 12784 RVA: 0x000BD7F0 File Offset: 0x000BB9F0
			// (set) Token: 0x060031F1 RID: 12785 RVA: 0x00019D24 File Offset: 0x00017F24
			public unsafe RunLoginPromptFlow _loginPromptFlow_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunSettingsFlow._execute_d__9.NativeFieldInfoPtr__loginPromptFlow_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RunLoginPromptFlow>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunSettingsFlow._execute_d__9.NativeFieldInfoPtr__loginPromptFlow_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001ECD RID: 7885
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001ECE RID: 7886
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001ECF RID: 7887
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001ED0 RID: 7888
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x04001ED1 RID: 7889
			private static readonly IntPtr NativeFieldInfoPtr__confirmOrDeny_5__2;

			// Token: 0x04001ED2 RID: 7890
			private static readonly IntPtr NativeFieldInfoPtr__loginPromptFlow_5__3;

			// Token: 0x04001ED3 RID: 7891
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001ED4 RID: 7892
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001ED5 RID: 7893
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001ED6 RID: 7894
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001ED7 RID: 7895
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001ED8 RID: 7896
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
