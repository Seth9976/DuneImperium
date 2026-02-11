using System;
using dwd.core.commands;
using dwd.core.ui.prompt.behaviours;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;
using UnityEngine.UI;
using worm.canis.actions.phases;
using worm.match.prompts.prompts;

namespace worm.match.prompts.behaviours
{
	// Token: 0x020000C8 RID: 200
	public class WormConflictResultsPromptBehaviour : PromptBehaviour<WormConflictResultsPrompt>
	{
		// Token: 0x0600085A RID: 2138 RVA: 0x00031D04 File Offset: 0x0002FF04
		// Note: this type is marked as 'beforefieldinit'.
		static WormConflictResultsPromptBehaviour()
		{
			Il2CppClassPointerStore<WormConflictResultsPromptBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.prompts.behaviours", "WormConflictResultsPromptBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormConflictResultsPromptBehaviour>.NativeClassPtr);
			WormConflictResultsPromptBehaviour.NativeFieldInfoPtr_winnerDisplays = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormConflictResultsPromptBehaviour>.NativeClassPtr, "winnerDisplays");
			WormConflictResultsPromptBehaviour.NativeFieldInfoPtr_tieDisplays = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormConflictResultsPromptBehaviour>.NativeClassPtr, "tieDisplays");
			WormConflictResultsPromptBehaviour.NativeFieldInfoPtr_continueButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormConflictResultsPromptBehaviour>.NativeClassPtr, "continueButton");
			WormConflictResultsPromptBehaviour.NativeFieldInfoPtr_conflictPromptClientTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormConflictResultsPromptBehaviour>.NativeClassPtr, "conflictPromptClientTrigger");
			WormConflictResultsPromptBehaviour.NativeFieldInfoPtr_WinnerTieParam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormConflictResultsPromptBehaviour>.NativeClassPtr, "WinnerTieParam");
			WormConflictResultsPromptBehaviour.NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConflictResultsPromptBehaviour>.NativeClassPtr, 100664427);
			WormConflictResultsPromptBehaviour.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConflictResultsPromptBehaviour>.NativeClassPtr, 100664428);
			WormConflictResultsPromptBehaviour.NativeMethodInfoPtr_Event_Dismiss_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConflictResultsPromptBehaviour>.NativeClassPtr, 100664429);
			WormConflictResultsPromptBehaviour.NativeMethodInfoPtr_DelayTimeout_Public_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConflictResultsPromptBehaviour>.NativeClassPtr, 100664430);
			WormConflictResultsPromptBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConflictResultsPromptBehaviour>.NativeClassPtr, 100664431);
		}

		// Token: 0x0600085B RID: 2139 RVA: 0x00031DFC File Offset: 0x0002FFFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 698372, XrefRangeEnd = 698429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormConflictResultsPromptBehaviour.NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600085C RID: 2140 RVA: 0x00031E38 File Offset: 0x00030038
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 698429, XrefRangeEnd = 698433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConflictResultsPromptBehaviour.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600085D RID: 2141 RVA: 0x00031E6C File Offset: 0x0003006C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 698433, XrefRangeEnd = 698437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_Dismiss()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConflictResultsPromptBehaviour.NativeMethodInfoPtr_Event_Dismiss_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600085E RID: 2142 RVA: 0x00031EA0 File Offset: 0x000300A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 698437, XrefRangeEnd = 698442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator DelayTimeout()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConflictResultsPromptBehaviour.NativeMethodInfoPtr_DelayTimeout_Public_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600085F RID: 2143 RVA: 0x00031EE0 File Offset: 0x000300E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 698442, XrefRangeEnd = 698452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormConflictResultsPromptBehaviour()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormConflictResultsPromptBehaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConflictResultsPromptBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000860 RID: 2144 RVA: 0x00006437 File Offset: 0x00004637
		public WormConflictResultsPromptBehaviour(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000249 RID: 585
		// (get) Token: 0x06000861 RID: 2145 RVA: 0x00031F1C File Offset: 0x0003011C
		// (set) Token: 0x06000862 RID: 2146 RVA: 0x00006440 File Offset: 0x00004640
		public unsafe Il2CppReferenceArray<GameObject> winnerDisplays
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConflictResultsPromptBehaviour.NativeFieldInfoPtr_winnerDisplays);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConflictResultsPromptBehaviour.NativeFieldInfoPtr_winnerDisplays), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700024A RID: 586
		// (get) Token: 0x06000863 RID: 2147 RVA: 0x00031F4C File Offset: 0x0003014C
		// (set) Token: 0x06000864 RID: 2148 RVA: 0x0000645F File Offset: 0x0000465F
		public unsafe Il2CppReferenceArray<GameObject> tieDisplays
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConflictResultsPromptBehaviour.NativeFieldInfoPtr_tieDisplays);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConflictResultsPromptBehaviour.NativeFieldInfoPtr_tieDisplays), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700024B RID: 587
		// (get) Token: 0x06000865 RID: 2149 RVA: 0x00031F7C File Offset: 0x0003017C
		// (set) Token: 0x06000866 RID: 2150 RVA: 0x0000647E File Offset: 0x0000467E
		public unsafe Button continueButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConflictResultsPromptBehaviour.NativeFieldInfoPtr_continueButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConflictResultsPromptBehaviour.NativeFieldInfoPtr_continueButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700024C RID: 588
		// (get) Token: 0x06000867 RID: 2151 RVA: 0x00031FAC File Offset: 0x000301AC
		// (set) Token: 0x06000868 RID: 2152 RVA: 0x0000649D File Offset: 0x0000469D
		public unsafe Command conflictPromptClientTrigger
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConflictResultsPromptBehaviour.NativeFieldInfoPtr_conflictPromptClientTrigger);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Command>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConflictResultsPromptBehaviour.NativeFieldInfoPtr_conflictPromptClientTrigger), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700024D RID: 589
		// (get) Token: 0x06000869 RID: 2153 RVA: 0x00031FDC File Offset: 0x000301DC
		// (set) Token: 0x0600086A RID: 2154 RVA: 0x000064BC File Offset: 0x000046BC
		public unsafe static int WinnerTieParam
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(WormConflictResultsPromptBehaviour.NativeFieldInfoPtr_WinnerTieParam, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormConflictResultsPromptBehaviour.NativeFieldInfoPtr_WinnerTieParam, (void*)(&value));
			}
		}

		// Token: 0x040004CD RID: 1229
		private static readonly IntPtr NativeFieldInfoPtr_winnerDisplays;

		// Token: 0x040004CE RID: 1230
		private static readonly IntPtr NativeFieldInfoPtr_tieDisplays;

		// Token: 0x040004CF RID: 1231
		private static readonly IntPtr NativeFieldInfoPtr_continueButton;

		// Token: 0x040004D0 RID: 1232
		private static readonly IntPtr NativeFieldInfoPtr_conflictPromptClientTrigger;

		// Token: 0x040004D1 RID: 1233
		private static readonly IntPtr NativeFieldInfoPtr_WinnerTieParam;

		// Token: 0x040004D2 RID: 1234
		private static readonly IntPtr NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0;

		// Token: 0x040004D3 RID: 1235
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040004D4 RID: 1236
		private static readonly IntPtr NativeMethodInfoPtr_Event_Dismiss_Public_Void_0;

		// Token: 0x040004D5 RID: 1237
		private static readonly IntPtr NativeMethodInfoPtr_DelayTimeout_Public_IEnumerator_0;

		// Token: 0x040004D6 RID: 1238
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200032A RID: 810
		[ObfuscatedName("worm.match.prompts.behaviours.WormConflictResultsPromptBehaviour+<>c")]
		[Serializable]
		public sealed class __c : global::Il2CppSystem.Object
		{
			// Token: 0x060020AE RID: 8366 RVA: 0x0007BA54 File Offset: 0x00079C54
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<WormConflictResultsPromptBehaviour.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormConflictResultsPromptBehaviour>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormConflictResultsPromptBehaviour.__c>.NativeClassPtr);
				WormConflictResultsPromptBehaviour.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormConflictResultsPromptBehaviour.__c>.NativeClassPtr, "<>9");
				WormConflictResultsPromptBehaviour.__c.NativeFieldInfoPtr___9__5_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormConflictResultsPromptBehaviour.__c>.NativeClassPtr, "<>9__5_0");
				WormConflictResultsPromptBehaviour.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConflictResultsPromptBehaviour.__c>.NativeClassPtr, 100664434);
				WormConflictResultsPromptBehaviour.__c.NativeMethodInfoPtr__initialize_b__5_0_Internal_Boolean_SerializedPlayerReward_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConflictResultsPromptBehaviour.__c>.NativeClassPtr, 100664435);
			}

			// Token: 0x060020AF RID: 8367 RVA: 0x0007BAD0 File Offset: 0x00079CD0
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormConflictResultsPromptBehaviour.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConflictResultsPromptBehaviour.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060020B0 RID: 8368 RVA: 0x0007BB0C File Offset: 0x00079D0C
			[CallerCount(0)]
			public unsafe bool _initialize_b__5_0(SerializedPlayerReward playerReward)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(playerReward);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConflictResultsPromptBehaviour.__c.NativeMethodInfoPtr__initialize_b__5_0_Internal_Boolean_SerializedPlayerReward_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060020B1 RID: 8369 RVA: 0x000126D6 File Offset: 0x000108D6
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170008F8 RID: 2296
			// (get) Token: 0x060020B2 RID: 8370 RVA: 0x0007BB5C File Offset: 0x00079D5C
			// (set) Token: 0x060020B3 RID: 8371 RVA: 0x000126DF File Offset: 0x000108DF
			public unsafe static WormConflictResultsPromptBehaviour.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormConflictResultsPromptBehaviour.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormConflictResultsPromptBehaviour.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormConflictResultsPromptBehaviour.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008F9 RID: 2297
			// (get) Token: 0x060020B4 RID: 8372 RVA: 0x0007BB84 File Offset: 0x00079D84
			// (set) Token: 0x060020B5 RID: 8373 RVA: 0x000126F1 File Offset: 0x000108F1
			public unsafe static Func<SerializedPlayerReward, bool> __9__5_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormConflictResultsPromptBehaviour.__c.NativeFieldInfoPtr___9__5_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<SerializedPlayerReward, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormConflictResultsPromptBehaviour.__c.NativeFieldInfoPtr___9__5_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040012D3 RID: 4819
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040012D4 RID: 4820
			private static readonly IntPtr NativeFieldInfoPtr___9__5_0;

			// Token: 0x040012D5 RID: 4821
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040012D6 RID: 4822
			private static readonly IntPtr NativeMethodInfoPtr__initialize_b__5_0_Internal_Boolean_SerializedPlayerReward_0;
		}

		// Token: 0x0200032B RID: 811
		[ObfuscatedName("worm.match.prompts.behaviours.WormConflictResultsPromptBehaviour+<DelayTimeout>d__8")]
		public sealed class _DelayTimeout_d__8 : global::Il2CppSystem.Object
		{
			// Token: 0x060020B6 RID: 8374 RVA: 0x0007BBAC File Offset: 0x00079DAC
			// Note: this type is marked as 'beforefieldinit'.
			static _DelayTimeout_d__8()
			{
				Il2CppClassPointerStore<WormConflictResultsPromptBehaviour._DelayTimeout_d__8>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormConflictResultsPromptBehaviour>.NativeClassPtr, "<DelayTimeout>d__8");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormConflictResultsPromptBehaviour._DelayTimeout_d__8>.NativeClassPtr);
				WormConflictResultsPromptBehaviour._DelayTimeout_d__8.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormConflictResultsPromptBehaviour._DelayTimeout_d__8>.NativeClassPtr, "<>1__state");
				WormConflictResultsPromptBehaviour._DelayTimeout_d__8.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormConflictResultsPromptBehaviour._DelayTimeout_d__8>.NativeClassPtr, "<>2__current");
				WormConflictResultsPromptBehaviour._DelayTimeout_d__8.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormConflictResultsPromptBehaviour._DelayTimeout_d__8>.NativeClassPtr, "<>4__this");
				WormConflictResultsPromptBehaviour._DelayTimeout_d__8.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConflictResultsPromptBehaviour._DelayTimeout_d__8>.NativeClassPtr, 100664436);
				WormConflictResultsPromptBehaviour._DelayTimeout_d__8.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConflictResultsPromptBehaviour._DelayTimeout_d__8>.NativeClassPtr, 100664437);
				WormConflictResultsPromptBehaviour._DelayTimeout_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConflictResultsPromptBehaviour._DelayTimeout_d__8>.NativeClassPtr, 100664438);
				WormConflictResultsPromptBehaviour._DelayTimeout_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConflictResultsPromptBehaviour._DelayTimeout_d__8>.NativeClassPtr, 100664439);
				WormConflictResultsPromptBehaviour._DelayTimeout_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConflictResultsPromptBehaviour._DelayTimeout_d__8>.NativeClassPtr, 100664440);
				WormConflictResultsPromptBehaviour._DelayTimeout_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConflictResultsPromptBehaviour._DelayTimeout_d__8>.NativeClassPtr, 100664441);
			}

			// Token: 0x060020B7 RID: 8375 RVA: 0x0007BC8C File Offset: 0x00079E8C
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _DelayTimeout_d__8(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormConflictResultsPromptBehaviour._DelayTimeout_d__8>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConflictResultsPromptBehaviour._DelayTimeout_d__8.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060020B8 RID: 8376 RVA: 0x0007BCD4 File Offset: 0x00079ED4
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConflictResultsPromptBehaviour._DelayTimeout_d__8.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060020B9 RID: 8377 RVA: 0x0007BD08 File Offset: 0x00079F08
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 698362, XrefRangeEnd = 698367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConflictResultsPromptBehaviour._DelayTimeout_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170008FD RID: 2301
			// (get) Token: 0x060020BA RID: 8378 RVA: 0x0007BD44 File Offset: 0x00079F44
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConflictResultsPromptBehaviour._DelayTimeout_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060020BB RID: 8379 RVA: 0x0007BD84 File Offset: 0x00079F84
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 698367, XrefRangeEnd = 698372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConflictResultsPromptBehaviour._DelayTimeout_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170008FE RID: 2302
			// (get) Token: 0x060020BC RID: 8380 RVA: 0x0007BDB8 File Offset: 0x00079FB8
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConflictResultsPromptBehaviour._DelayTimeout_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060020BD RID: 8381 RVA: 0x00012703 File Offset: 0x00010903
			public _DelayTimeout_d__8(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170008FA RID: 2298
			// (get) Token: 0x060020BE RID: 8382 RVA: 0x0007BDF8 File Offset: 0x00079FF8
			// (set) Token: 0x060020BF RID: 8383 RVA: 0x0001270C File Offset: 0x0001090C
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConflictResultsPromptBehaviour._DelayTimeout_d__8.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConflictResultsPromptBehaviour._DelayTimeout_d__8.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170008FB RID: 2299
			// (get) Token: 0x060020C0 RID: 8384 RVA: 0x0007BE20 File Offset: 0x0007A020
			// (set) Token: 0x060020C1 RID: 8385 RVA: 0x00012727 File Offset: 0x00010927
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConflictResultsPromptBehaviour._DelayTimeout_d__8.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConflictResultsPromptBehaviour._DelayTimeout_d__8.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008FC RID: 2300
			// (get) Token: 0x060020C2 RID: 8386 RVA: 0x0007BE50 File Offset: 0x0007A050
			// (set) Token: 0x060020C3 RID: 8387 RVA: 0x00012746 File Offset: 0x00010946
			public unsafe WormConflictResultsPromptBehaviour __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConflictResultsPromptBehaviour._DelayTimeout_d__8.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormConflictResultsPromptBehaviour>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConflictResultsPromptBehaviour._DelayTimeout_d__8.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040012D7 RID: 4823
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040012D8 RID: 4824
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040012D9 RID: 4825
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040012DA RID: 4826
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040012DB RID: 4827
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040012DC RID: 4828
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040012DD RID: 4829
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040012DE RID: 4830
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040012DF RID: 4831
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
