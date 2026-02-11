using System;
using boardgames.match.selection;
using dwd.core.ui.prompt.prompts;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using lotus;
using UnityEngine;
using UnityEngine.EventSystems;

namespace worm.match.components
{
	// Token: 0x0200020A RID: 522
	public class WormPromptConfirmationOnSelection : MonoBehaviour
	{
		// Token: 0x0600171E RID: 5918 RVA: 0x0005E2FC File Offset: 0x0005C4FC
		// Note: this type is marked as 'beforefieldinit'.
		static WormPromptConfirmationOnSelection()
		{
			Il2CppClassPointerStore<WormPromptConfirmationOnSelection>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.components", "WormPromptConfirmationOnSelection");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormPromptConfirmationOnSelection>.NativeClassPtr);
			WormPromptConfirmationOnSelection.NativeFieldInfoPtr_unitView = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPromptConfirmationOnSelection>.NativeClassPtr, "unitView");
			WormPromptConfirmationOnSelection.NativeFieldInfoPtr_modalScope = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPromptConfirmationOnSelection>.NativeClassPtr, "modalScope");
			WormPromptConfirmationOnSelection.NativeFieldInfoPtr_selectionResponder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPromptConfirmationOnSelection>.NativeClassPtr, "selectionResponder");
			WormPromptConfirmationOnSelection.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPromptConfirmationOnSelection>.NativeClassPtr, 100666498);
			WormPromptConfirmationOnSelection.NativeMethodInfoPtr_OnSubmit_Public_Virtual_Final_New_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPromptConfirmationOnSelection>.NativeClassPtr, 100666499);
			WormPromptConfirmationOnSelection.NativeMethodInfoPtr_runSelection_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPromptConfirmationOnSelection>.NativeClassPtr, 100666500);
			WormPromptConfirmationOnSelection.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPromptConfirmationOnSelection>.NativeClassPtr, 100666501);
		}

		// Token: 0x0600171F RID: 5919 RVA: 0x0005E3B8 File Offset: 0x0005C5B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 717127, XrefRangeEnd = 717134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormPromptConfirmationOnSelection.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001720 RID: 5920 RVA: 0x0005E3F4 File Offset: 0x0005C5F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 717134, XrefRangeEnd = 717145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnSubmit(BaseEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPromptConfirmationOnSelection.NativeMethodInfoPtr_OnSubmit_Public_Virtual_Final_New_Void_BaseEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001721 RID: 5921 RVA: 0x0005E438 File Offset: 0x0005C638
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 717145, XrefRangeEnd = 717150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator runSelection()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPromptConfirmationOnSelection.NativeMethodInfoPtr_runSelection_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001722 RID: 5922 RVA: 0x0005E478 File Offset: 0x0005C678
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormPromptConfirmationOnSelection()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormPromptConfirmationOnSelection>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPromptConfirmationOnSelection.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001723 RID: 5923 RVA: 0x0000DDF1 File Offset: 0x0000BFF1
		public WormPromptConfirmationOnSelection(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700068A RID: 1674
		// (get) Token: 0x06001724 RID: 5924 RVA: 0x0005E4B4 File Offset: 0x0005C6B4
		// (set) Token: 0x06001725 RID: 5925 RVA: 0x0000DDFA File Offset: 0x0000BFFA
		public unsafe UnitView unitView
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPromptConfirmationOnSelection.NativeFieldInfoPtr_unitView);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnitView>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPromptConfirmationOnSelection.NativeFieldInfoPtr_unitView), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700068B RID: 1675
		// (get) Token: 0x06001726 RID: 5926 RVA: 0x0005E4E4 File Offset: 0x0005C6E4
		// (set) Token: 0x06001727 RID: 5927 RVA: 0x0000DE19 File Offset: 0x0000C019
		public unsafe ModalScope modalScope
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPromptConfirmationOnSelection.NativeFieldInfoPtr_modalScope);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ModalScope>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPromptConfirmationOnSelection.NativeFieldInfoPtr_modalScope), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700068C RID: 1676
		// (get) Token: 0x06001728 RID: 5928 RVA: 0x0005E514 File Offset: 0x0005C714
		// (set) Token: 0x06001729 RID: 5929 RVA: 0x0000DE38 File Offset: 0x0000C038
		public unsafe DBGSelectionResponder selectionResponder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPromptConfirmationOnSelection.NativeFieldInfoPtr_selectionResponder);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGSelectionResponder>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPromptConfirmationOnSelection.NativeFieldInfoPtr_selectionResponder), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000D69 RID: 3433
		private static readonly IntPtr NativeFieldInfoPtr_unitView;

		// Token: 0x04000D6A RID: 3434
		private static readonly IntPtr NativeFieldInfoPtr_modalScope;

		// Token: 0x04000D6B RID: 3435
		private static readonly IntPtr NativeFieldInfoPtr_selectionResponder;

		// Token: 0x04000D6C RID: 3436
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0;

		// Token: 0x04000D6D RID: 3437
		private static readonly IntPtr NativeMethodInfoPtr_OnSubmit_Public_Virtual_Final_New_Void_BaseEventData_0;

		// Token: 0x04000D6E RID: 3438
		private static readonly IntPtr NativeMethodInfoPtr_runSelection_Private_IEnumerator_0;

		// Token: 0x04000D6F RID: 3439
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020003F9 RID: 1017
		[ObfuscatedName("worm.match.components.WormPromptConfirmationOnSelection+<runSelection>d__5")]
		public sealed class _runSelection_d__5 : global::Il2CppSystem.Object
		{
			// Token: 0x0600297E RID: 10622 RVA: 0x00095C80 File Offset: 0x00093E80
			// Note: this type is marked as 'beforefieldinit'.
			static _runSelection_d__5()
			{
				Il2CppClassPointerStore<WormPromptConfirmationOnSelection._runSelection_d__5>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormPromptConfirmationOnSelection>.NativeClassPtr, "<runSelection>d__5");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormPromptConfirmationOnSelection._runSelection_d__5>.NativeClassPtr);
				WormPromptConfirmationOnSelection._runSelection_d__5.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPromptConfirmationOnSelection._runSelection_d__5>.NativeClassPtr, "<>1__state");
				WormPromptConfirmationOnSelection._runSelection_d__5.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPromptConfirmationOnSelection._runSelection_d__5>.NativeClassPtr, "<>2__current");
				WormPromptConfirmationOnSelection._runSelection_d__5.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPromptConfirmationOnSelection._runSelection_d__5>.NativeClassPtr, "<>4__this");
				WormPromptConfirmationOnSelection._runSelection_d__5.NativeFieldInfoPtr__confirmOrDenyPrompt_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPromptConfirmationOnSelection._runSelection_d__5>.NativeClassPtr, "<confirmOrDenyPrompt>5__2");
				WormPromptConfirmationOnSelection._runSelection_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPromptConfirmationOnSelection._runSelection_d__5>.NativeClassPtr, 100666502);
				WormPromptConfirmationOnSelection._runSelection_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPromptConfirmationOnSelection._runSelection_d__5>.NativeClassPtr, 100666503);
				WormPromptConfirmationOnSelection._runSelection_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPromptConfirmationOnSelection._runSelection_d__5>.NativeClassPtr, 100666504);
				WormPromptConfirmationOnSelection._runSelection_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPromptConfirmationOnSelection._runSelection_d__5>.NativeClassPtr, 100666505);
				WormPromptConfirmationOnSelection._runSelection_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPromptConfirmationOnSelection._runSelection_d__5>.NativeClassPtr, 100666506);
				WormPromptConfirmationOnSelection._runSelection_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPromptConfirmationOnSelection._runSelection_d__5>.NativeClassPtr, 100666507);
			}

			// Token: 0x0600297F RID: 10623 RVA: 0x00095D74 File Offset: 0x00093F74
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _runSelection_d__5(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormPromptConfirmationOnSelection._runSelection_d__5>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPromptConfirmationOnSelection._runSelection_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002980 RID: 10624 RVA: 0x00095DBC File Offset: 0x00093FBC
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPromptConfirmationOnSelection._runSelection_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002981 RID: 10625 RVA: 0x00095DF0 File Offset: 0x00093FF0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 717089, XrefRangeEnd = 717122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPromptConfirmationOnSelection._runSelection_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000BB6 RID: 2998
			// (get) Token: 0x06002982 RID: 10626 RVA: 0x00095E2C File Offset: 0x0009402C
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPromptConfirmationOnSelection._runSelection_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002983 RID: 10627 RVA: 0x00095E6C File Offset: 0x0009406C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 717122, XrefRangeEnd = 717127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPromptConfirmationOnSelection._runSelection_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000BB7 RID: 2999
			// (get) Token: 0x06002984 RID: 10628 RVA: 0x00095EA0 File Offset: 0x000940A0
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPromptConfirmationOnSelection._runSelection_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002985 RID: 10629 RVA: 0x00016B5A File Offset: 0x00014D5A
			public _runSelection_d__5(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000BB2 RID: 2994
			// (get) Token: 0x06002986 RID: 10630 RVA: 0x00095EE0 File Offset: 0x000940E0
			// (set) Token: 0x06002987 RID: 10631 RVA: 0x00016B63 File Offset: 0x00014D63
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPromptConfirmationOnSelection._runSelection_d__5.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPromptConfirmationOnSelection._runSelection_d__5.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000BB3 RID: 2995
			// (get) Token: 0x06002988 RID: 10632 RVA: 0x00095F08 File Offset: 0x00094108
			// (set) Token: 0x06002989 RID: 10633 RVA: 0x00016B7E File Offset: 0x00014D7E
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPromptConfirmationOnSelection._runSelection_d__5.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPromptConfirmationOnSelection._runSelection_d__5.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000BB4 RID: 2996
			// (get) Token: 0x0600298A RID: 10634 RVA: 0x00095F38 File Offset: 0x00094138
			// (set) Token: 0x0600298B RID: 10635 RVA: 0x00016B9D File Offset: 0x00014D9D
			public unsafe WormPromptConfirmationOnSelection __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPromptConfirmationOnSelection._runSelection_d__5.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPromptConfirmationOnSelection>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPromptConfirmationOnSelection._runSelection_d__5.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000BB5 RID: 2997
			// (get) Token: 0x0600298C RID: 10636 RVA: 0x00095F68 File Offset: 0x00094168
			// (set) Token: 0x0600298D RID: 10637 RVA: 0x00016BBC File Offset: 0x00014DBC
			public unsafe ConfirmOrDenyPrompt _confirmOrDenyPrompt_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPromptConfirmationOnSelection._runSelection_d__5.NativeFieldInfoPtr__confirmOrDenyPrompt_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConfirmOrDenyPrompt>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPromptConfirmationOnSelection._runSelection_d__5.NativeFieldInfoPtr__confirmOrDenyPrompt_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040017ED RID: 6125
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040017EE RID: 6126
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040017EF RID: 6127
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040017F0 RID: 6128
			private static readonly IntPtr NativeFieldInfoPtr__confirmOrDenyPrompt_5__2;

			// Token: 0x040017F1 RID: 6129
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040017F2 RID: 6130
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040017F3 RID: 6131
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040017F4 RID: 6132
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040017F5 RID: 6133
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040017F6 RID: 6134
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
