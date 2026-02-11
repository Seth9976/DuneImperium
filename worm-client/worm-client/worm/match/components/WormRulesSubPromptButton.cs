using System;
using boardgames.menus.commands;
using dwd.core.ui.prompt.behaviours;
using dwd.core.ui.prompt.prompts;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace worm.match.components
{
	// Token: 0x0200020E RID: 526
	public class WormRulesSubPromptButton : MonoBehaviour
	{
		// Token: 0x06001749 RID: 5961 RVA: 0x0005EB88 File Offset: 0x0005CD88
		// Note: this type is marked as 'beforefieldinit'.
		static WormRulesSubPromptButton()
		{
			Il2CppClassPointerStore<WormRulesSubPromptButton>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.components", "WormRulesSubPromptButton");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormRulesSubPromptButton>.NativeClassPtr);
			WormRulesSubPromptButton.NativeFieldInfoPtr_settingsPrompt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormRulesSubPromptButton>.NativeClassPtr, "settingsPrompt");
			WormRulesSubPromptButton.NativeFieldInfoPtr_promptFlavor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormRulesSubPromptButton>.NativeClassPtr, "promptFlavor");
			WormRulesSubPromptButton.NativeMethodInfoPtr_Event_OnClick_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormRulesSubPromptButton>.NativeClassPtr, 100666534);
			WormRulesSubPromptButton.NativeMethodInfoPtr_Open_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormRulesSubPromptButton>.NativeClassPtr, 100666535);
			WormRulesSubPromptButton.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormRulesSubPromptButton>.NativeClassPtr, 100666536);
		}

		// Token: 0x0600174A RID: 5962 RVA: 0x0005EC1C File Offset: 0x0005CE1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 717350, XrefRangeEnd = 717356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_OnClick()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormRulesSubPromptButton.NativeMethodInfoPtr_Event_OnClick_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600174B RID: 5963 RVA: 0x0005EC50 File Offset: 0x0005CE50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 717356, XrefRangeEnd = 717361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Open()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormRulesSubPromptButton.NativeMethodInfoPtr_Open_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600174C RID: 5964 RVA: 0x0005EC90 File Offset: 0x0005CE90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 717361, XrefRangeEnd = 717365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormRulesSubPromptButton()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormRulesSubPromptButton>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormRulesSubPromptButton.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600174D RID: 5965 RVA: 0x0000DF1B File Offset: 0x0000C11B
		public WormRulesSubPromptButton(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000694 RID: 1684
		// (get) Token: 0x0600174E RID: 5966 RVA: 0x0005ECCC File Offset: 0x0005CECC
		// (set) Token: 0x0600174F RID: 5967 RVA: 0x0000DF24 File Offset: 0x0000C124
		public unsafe DismissablePromptBehaviour settingsPrompt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormRulesSubPromptButton.NativeFieldInfoPtr_settingsPrompt);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DismissablePromptBehaviour>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormRulesSubPromptButton.NativeFieldInfoPtr_settingsPrompt), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000695 RID: 1685
		// (get) Token: 0x06001750 RID: 5968 RVA: 0x0005ECFC File Offset: 0x0005CEFC
		// (set) Token: 0x06001751 RID: 5969 RVA: 0x0000DF43 File Offset: 0x0000C143
		public unsafe string promptFlavor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormRulesSubPromptButton.NativeFieldInfoPtr_promptFlavor);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormRulesSubPromptButton.NativeFieldInfoPtr_promptFlavor), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000D83 RID: 3459
		private static readonly IntPtr NativeFieldInfoPtr_settingsPrompt;

		// Token: 0x04000D84 RID: 3460
		private static readonly IntPtr NativeFieldInfoPtr_promptFlavor;

		// Token: 0x04000D85 RID: 3461
		private static readonly IntPtr NativeMethodInfoPtr_Event_OnClick_Public_Void_0;

		// Token: 0x04000D86 RID: 3462
		private static readonly IntPtr NativeMethodInfoPtr_Open_Private_IEnumerator_0;

		// Token: 0x04000D87 RID: 3463
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020003FC RID: 1020
		[ObfuscatedName("worm.match.components.WormRulesSubPromptButton+<Open>d__3")]
		public sealed class _Open_d__3 : global::Il2CppSystem.Object
		{
			// Token: 0x060029B0 RID: 10672 RVA: 0x0009660C File Offset: 0x0009480C
			// Note: this type is marked as 'beforefieldinit'.
			static _Open_d__3()
			{
				Il2CppClassPointerStore<WormRulesSubPromptButton._Open_d__3>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormRulesSubPromptButton>.NativeClassPtr, "<Open>d__3");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormRulesSubPromptButton._Open_d__3>.NativeClassPtr);
				WormRulesSubPromptButton._Open_d__3.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormRulesSubPromptButton._Open_d__3>.NativeClassPtr, "<>1__state");
				WormRulesSubPromptButton._Open_d__3.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormRulesSubPromptButton._Open_d__3>.NativeClassPtr, "<>2__current");
				WormRulesSubPromptButton._Open_d__3.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormRulesSubPromptButton._Open_d__3>.NativeClassPtr, "<>4__this");
				WormRulesSubPromptButton._Open_d__3.NativeFieldInfoPtr__runSettingsFlow_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormRulesSubPromptButton._Open_d__3>.NativeClassPtr, "<runSettingsFlow>5__2");
				WormRulesSubPromptButton._Open_d__3.NativeFieldInfoPtr__settingsScope_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormRulesSubPromptButton._Open_d__3>.NativeClassPtr, "<settingsScope>5__3");
				WormRulesSubPromptButton._Open_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormRulesSubPromptButton._Open_d__3>.NativeClassPtr, 100666537);
				WormRulesSubPromptButton._Open_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormRulesSubPromptButton._Open_d__3>.NativeClassPtr, 100666538);
				WormRulesSubPromptButton._Open_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormRulesSubPromptButton._Open_d__3>.NativeClassPtr, 100666539);
				WormRulesSubPromptButton._Open_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormRulesSubPromptButton._Open_d__3>.NativeClassPtr, 100666540);
				WormRulesSubPromptButton._Open_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormRulesSubPromptButton._Open_d__3>.NativeClassPtr, 100666541);
				WormRulesSubPromptButton._Open_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormRulesSubPromptButton._Open_d__3>.NativeClassPtr, 100666542);
			}

			// Token: 0x060029B1 RID: 10673 RVA: 0x00096714 File Offset: 0x00094914
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Open_d__3(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormRulesSubPromptButton._Open_d__3>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormRulesSubPromptButton._Open_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060029B2 RID: 10674 RVA: 0x0009675C File Offset: 0x0009495C
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormRulesSubPromptButton._Open_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060029B3 RID: 10675 RVA: 0x00096790 File Offset: 0x00094990
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 717299, XrefRangeEnd = 717345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormRulesSubPromptButton._Open_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000BCA RID: 3018
			// (get) Token: 0x060029B4 RID: 10676 RVA: 0x000967CC File Offset: 0x000949CC
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormRulesSubPromptButton._Open_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060029B5 RID: 10677 RVA: 0x0009680C File Offset: 0x00094A0C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 717345, XrefRangeEnd = 717350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormRulesSubPromptButton._Open_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000BCB RID: 3019
			// (get) Token: 0x060029B6 RID: 10678 RVA: 0x00096840 File Offset: 0x00094A40
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormRulesSubPromptButton._Open_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060029B7 RID: 10679 RVA: 0x00016CFC File Offset: 0x00014EFC
			public _Open_d__3(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000BC5 RID: 3013
			// (get) Token: 0x060029B8 RID: 10680 RVA: 0x00096880 File Offset: 0x00094A80
			// (set) Token: 0x060029B9 RID: 10681 RVA: 0x00016D05 File Offset: 0x00014F05
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormRulesSubPromptButton._Open_d__3.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormRulesSubPromptButton._Open_d__3.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000BC6 RID: 3014
			// (get) Token: 0x060029BA RID: 10682 RVA: 0x000968A8 File Offset: 0x00094AA8
			// (set) Token: 0x060029BB RID: 10683 RVA: 0x00016D20 File Offset: 0x00014F20
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormRulesSubPromptButton._Open_d__3.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormRulesSubPromptButton._Open_d__3.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000BC7 RID: 3015
			// (get) Token: 0x060029BC RID: 10684 RVA: 0x000968D8 File Offset: 0x00094AD8
			// (set) Token: 0x060029BD RID: 10685 RVA: 0x00016D3F File Offset: 0x00014F3F
			public unsafe WormRulesSubPromptButton __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormRulesSubPromptButton._Open_d__3.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormRulesSubPromptButton>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormRulesSubPromptButton._Open_d__3.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000BC8 RID: 3016
			// (get) Token: 0x060029BE RID: 10686 RVA: 0x00096908 File Offset: 0x00094B08
			// (set) Token: 0x060029BF RID: 10687 RVA: 0x00016D5E File Offset: 0x00014F5E
			public unsafe RunSettingsFlow _runSettingsFlow_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormRulesSubPromptButton._Open_d__3.NativeFieldInfoPtr__runSettingsFlow_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RunSettingsFlow>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormRulesSubPromptButton._Open_d__3.NativeFieldInfoPtr__runSettingsFlow_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000BC9 RID: 3017
			// (get) Token: 0x060029C0 RID: 10688 RVA: 0x00096938 File Offset: 0x00094B38
			// (set) Token: 0x060029C1 RID: 10689 RVA: 0x00016D7D File Offset: 0x00014F7D
			public unsafe ModalScope _settingsScope_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormRulesSubPromptButton._Open_d__3.NativeFieldInfoPtr__settingsScope_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ModalScope>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormRulesSubPromptButton._Open_d__3.NativeFieldInfoPtr__settingsScope_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400180C RID: 6156
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400180D RID: 6157
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400180E RID: 6158
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400180F RID: 6159
			private static readonly IntPtr NativeFieldInfoPtr__runSettingsFlow_5__2;

			// Token: 0x04001810 RID: 6160
			private static readonly IntPtr NativeFieldInfoPtr__settingsScope_5__3;

			// Token: 0x04001811 RID: 6161
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001812 RID: 6162
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001813 RID: 6163
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001814 RID: 6164
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001815 RID: 6165
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001816 RID: 6166
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
