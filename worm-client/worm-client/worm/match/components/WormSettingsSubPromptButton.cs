using System;
using dwd.core.ui.prompt.behaviours;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace worm.match.components
{
	// Token: 0x02000210 RID: 528
	public class WormSettingsSubPromptButton : MonoBehaviour
	{
		// Token: 0x0600175A RID: 5978 RVA: 0x0005EE90 File Offset: 0x0005D090
		// Note: this type is marked as 'beforefieldinit'.
		static WormSettingsSubPromptButton()
		{
			Il2CppClassPointerStore<WormSettingsSubPromptButton>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.components", "WormSettingsSubPromptButton");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormSettingsSubPromptButton>.NativeClassPtr);
			WormSettingsSubPromptButton.NativeFieldInfoPtr_settingsPrompt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSettingsSubPromptButton>.NativeClassPtr, "settingsPrompt");
			WormSettingsSubPromptButton.NativeFieldInfoPtr_promptFlavor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSettingsSubPromptButton>.NativeClassPtr, "promptFlavor");
			WormSettingsSubPromptButton.NativeMethodInfoPtr_Event_OnClick_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSettingsSubPromptButton>.NativeClassPtr, 100666545);
			WormSettingsSubPromptButton.NativeMethodInfoPtr_ShowPrompt_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSettingsSubPromptButton>.NativeClassPtr, 100666546);
			WormSettingsSubPromptButton.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSettingsSubPromptButton>.NativeClassPtr, 100666547);
		}

		// Token: 0x0600175B RID: 5979 RVA: 0x0005EF24 File Offset: 0x0005D124
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 717391, XrefRangeEnd = 717397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_OnClick()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSettingsSubPromptButton.NativeMethodInfoPtr_Event_OnClick_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600175C RID: 5980 RVA: 0x0005EF58 File Offset: 0x0005D158
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 717397, XrefRangeEnd = 717402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator ShowPrompt()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSettingsSubPromptButton.NativeMethodInfoPtr_ShowPrompt_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600175D RID: 5981 RVA: 0x0005EF98 File Offset: 0x0005D198
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 717402, XrefRangeEnd = 717406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormSettingsSubPromptButton()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormSettingsSubPromptButton>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSettingsSubPromptButton.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600175E RID: 5982 RVA: 0x0000DFA9 File Offset: 0x0000C1A9
		public WormSettingsSubPromptButton(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000698 RID: 1688
		// (get) Token: 0x0600175F RID: 5983 RVA: 0x0005EFD4 File Offset: 0x0005D1D4
		// (set) Token: 0x06001760 RID: 5984 RVA: 0x0000DFB2 File Offset: 0x0000C1B2
		public unsafe DismissablePromptBehaviour settingsPrompt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSettingsSubPromptButton.NativeFieldInfoPtr_settingsPrompt);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DismissablePromptBehaviour>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSettingsSubPromptButton.NativeFieldInfoPtr_settingsPrompt), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000699 RID: 1689
		// (get) Token: 0x06001761 RID: 5985 RVA: 0x0005F004 File Offset: 0x0005D204
		// (set) Token: 0x06001762 RID: 5986 RVA: 0x0000DFD1 File Offset: 0x0000C1D1
		public unsafe string promptFlavor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSettingsSubPromptButton.NativeFieldInfoPtr_promptFlavor);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSettingsSubPromptButton.NativeFieldInfoPtr_promptFlavor), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000D8C RID: 3468
		private static readonly IntPtr NativeFieldInfoPtr_settingsPrompt;

		// Token: 0x04000D8D RID: 3469
		private static readonly IntPtr NativeFieldInfoPtr_promptFlavor;

		// Token: 0x04000D8E RID: 3470
		private static readonly IntPtr NativeMethodInfoPtr_Event_OnClick_Public_Void_0;

		// Token: 0x04000D8F RID: 3471
		private static readonly IntPtr NativeMethodInfoPtr_ShowPrompt_Private_IEnumerator_0;

		// Token: 0x04000D90 RID: 3472
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020003FD RID: 1021
		[ObfuscatedName("worm.match.components.WormSettingsSubPromptButton+<ShowPrompt>d__3")]
		public sealed class _ShowPrompt_d__3 : global::Il2CppSystem.Object
		{
			// Token: 0x060029C2 RID: 10690 RVA: 0x00096968 File Offset: 0x00094B68
			// Note: this type is marked as 'beforefieldinit'.
			static _ShowPrompt_d__3()
			{
				Il2CppClassPointerStore<WormSettingsSubPromptButton._ShowPrompt_d__3>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormSettingsSubPromptButton>.NativeClassPtr, "<ShowPrompt>d__3");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormSettingsSubPromptButton._ShowPrompt_d__3>.NativeClassPtr);
				WormSettingsSubPromptButton._ShowPrompt_d__3.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSettingsSubPromptButton._ShowPrompt_d__3>.NativeClassPtr, "<>1__state");
				WormSettingsSubPromptButton._ShowPrompt_d__3.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSettingsSubPromptButton._ShowPrompt_d__3>.NativeClassPtr, "<>2__current");
				WormSettingsSubPromptButton._ShowPrompt_d__3.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSettingsSubPromptButton._ShowPrompt_d__3>.NativeClassPtr, "<>4__this");
				WormSettingsSubPromptButton._ShowPrompt_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSettingsSubPromptButton._ShowPrompt_d__3>.NativeClassPtr, 100666548);
				WormSettingsSubPromptButton._ShowPrompt_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSettingsSubPromptButton._ShowPrompt_d__3>.NativeClassPtr, 100666549);
				WormSettingsSubPromptButton._ShowPrompt_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSettingsSubPromptButton._ShowPrompt_d__3>.NativeClassPtr, 100666550);
				WormSettingsSubPromptButton._ShowPrompt_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSettingsSubPromptButton._ShowPrompt_d__3>.NativeClassPtr, 100666551);
				WormSettingsSubPromptButton._ShowPrompt_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSettingsSubPromptButton._ShowPrompt_d__3>.NativeClassPtr, 100666552);
				WormSettingsSubPromptButton._ShowPrompt_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSettingsSubPromptButton._ShowPrompt_d__3>.NativeClassPtr, 100666553);
			}

			// Token: 0x060029C3 RID: 10691 RVA: 0x00096A48 File Offset: 0x00094C48
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _ShowPrompt_d__3(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormSettingsSubPromptButton._ShowPrompt_d__3>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSettingsSubPromptButton._ShowPrompt_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060029C4 RID: 10692 RVA: 0x00096A90 File Offset: 0x00094C90
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSettingsSubPromptButton._ShowPrompt_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060029C5 RID: 10693 RVA: 0x00096AC4 File Offset: 0x00094CC4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 717372, XrefRangeEnd = 717386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSettingsSubPromptButton._ShowPrompt_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000BCF RID: 3023
			// (get) Token: 0x060029C6 RID: 10694 RVA: 0x00096B00 File Offset: 0x00094D00
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSettingsSubPromptButton._ShowPrompt_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060029C7 RID: 10695 RVA: 0x00096B40 File Offset: 0x00094D40
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 717386, XrefRangeEnd = 717391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSettingsSubPromptButton._ShowPrompt_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000BD0 RID: 3024
			// (get) Token: 0x060029C8 RID: 10696 RVA: 0x00096B74 File Offset: 0x00094D74
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSettingsSubPromptButton._ShowPrompt_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060029C9 RID: 10697 RVA: 0x00016D9C File Offset: 0x00014F9C
			public _ShowPrompt_d__3(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000BCC RID: 3020
			// (get) Token: 0x060029CA RID: 10698 RVA: 0x00096BB4 File Offset: 0x00094DB4
			// (set) Token: 0x060029CB RID: 10699 RVA: 0x00016DA5 File Offset: 0x00014FA5
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSettingsSubPromptButton._ShowPrompt_d__3.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSettingsSubPromptButton._ShowPrompt_d__3.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000BCD RID: 3021
			// (get) Token: 0x060029CC RID: 10700 RVA: 0x00096BDC File Offset: 0x00094DDC
			// (set) Token: 0x060029CD RID: 10701 RVA: 0x00016DC0 File Offset: 0x00014FC0
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSettingsSubPromptButton._ShowPrompt_d__3.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSettingsSubPromptButton._ShowPrompt_d__3.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000BCE RID: 3022
			// (get) Token: 0x060029CE RID: 10702 RVA: 0x00096C0C File Offset: 0x00094E0C
			// (set) Token: 0x060029CF RID: 10703 RVA: 0x00016DDF File Offset: 0x00014FDF
			public unsafe WormSettingsSubPromptButton __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSettingsSubPromptButton._ShowPrompt_d__3.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormSettingsSubPromptButton>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSettingsSubPromptButton._ShowPrompt_d__3.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001817 RID: 6167
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001818 RID: 6168
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001819 RID: 6169
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400181A RID: 6170
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400181B RID: 6171
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400181C RID: 6172
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400181D RID: 6173
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400181E RID: 6174
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400181F RID: 6175
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
