using System;
using boardgames.match.selection;
using Canis.utils.localization;
using dwd.core.ui.prompt.prompts;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace worm.match.components
{
	// Token: 0x0200020B RID: 523
	public class WormRetreatConfirmButton : MonoBehaviour
	{
		// Token: 0x0600172A RID: 5930 RVA: 0x0005E544 File Offset: 0x0005C744
		// Note: this type is marked as 'beforefieldinit'.
		static WormRetreatConfirmButton()
		{
			Il2CppClassPointerStore<WormRetreatConfirmButton>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.components", "WormRetreatConfirmButton");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormRetreatConfirmButton>.NativeClassPtr);
			WormRetreatConfirmButton.NativeFieldInfoPtr_advance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormRetreatConfirmButton>.NativeClassPtr, "advance");
			WormRetreatConfirmButton.NativeFieldInfoPtr_selection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormRetreatConfirmButton>.NativeClassPtr, "selection");
			WormRetreatConfirmButton.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormRetreatConfirmButton>.NativeClassPtr, 100666508);
			WormRetreatConfirmButton.NativeMethodInfoPtr_Event_Confirm_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormRetreatConfirmButton>.NativeClassPtr, 100666509);
			WormRetreatConfirmButton.NativeMethodInfoPtr_PromptConfirm_Private_IEnumerator_LocalizableText_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormRetreatConfirmButton>.NativeClassPtr, 100666510);
			WormRetreatConfirmButton.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormRetreatConfirmButton>.NativeClassPtr, 100666511);
		}

		// Token: 0x0600172B RID: 5931 RVA: 0x0005E5EC File Offset: 0x0005C7EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 717170, XrefRangeEnd = 717174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormRetreatConfirmButton.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600172C RID: 5932 RVA: 0x0005E620 File Offset: 0x0005C820
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 717174, XrefRangeEnd = 717211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_Confirm()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormRetreatConfirmButton.NativeMethodInfoPtr_Event_Confirm_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600172D RID: 5933 RVA: 0x0005E654 File Offset: 0x0005C854
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 717211, XrefRangeEnd = 717217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator PromptConfirm(LocalizableText warning)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(warning);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormRetreatConfirmButton.NativeMethodInfoPtr_PromptConfirm_Private_IEnumerator_LocalizableText_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x0600172E RID: 5934 RVA: 0x0005E6A4 File Offset: 0x0005C8A4
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormRetreatConfirmButton()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormRetreatConfirmButton>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormRetreatConfirmButton.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600172F RID: 5935 RVA: 0x0000DE57 File Offset: 0x0000C057
		public WormRetreatConfirmButton(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700068D RID: 1677
		// (get) Token: 0x06001730 RID: 5936 RVA: 0x0005E6E0 File Offset: 0x0005C8E0
		// (set) Token: 0x06001731 RID: 5937 RVA: 0x0000DE60 File Offset: 0x0000C060
		public unsafe WormAdvanceSelectionButton advance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormRetreatConfirmButton.NativeFieldInfoPtr_advance);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormAdvanceSelectionButton>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormRetreatConfirmButton.NativeFieldInfoPtr_advance), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700068E RID: 1678
		// (get) Token: 0x06001732 RID: 5938 RVA: 0x0005E710 File Offset: 0x0005C910
		// (set) Token: 0x06001733 RID: 5939 RVA: 0x0000DE7F File Offset: 0x0000C07F
		public unsafe DBGSelectionResponder selection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormRetreatConfirmButton.NativeFieldInfoPtr_selection);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGSelectionResponder>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormRetreatConfirmButton.NativeFieldInfoPtr_selection), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000D70 RID: 3440
		private static readonly IntPtr NativeFieldInfoPtr_advance;

		// Token: 0x04000D71 RID: 3441
		private static readonly IntPtr NativeFieldInfoPtr_selection;

		// Token: 0x04000D72 RID: 3442
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04000D73 RID: 3443
		private static readonly IntPtr NativeMethodInfoPtr_Event_Confirm_Public_Void_0;

		// Token: 0x04000D74 RID: 3444
		private static readonly IntPtr NativeMethodInfoPtr_PromptConfirm_Private_IEnumerator_LocalizableText_0;

		// Token: 0x04000D75 RID: 3445
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020003FA RID: 1018
		[ObfuscatedName("worm.match.components.WormRetreatConfirmButton+<PromptConfirm>d__4")]
		public sealed class _PromptConfirm_d__4 : global::Il2CppSystem.Object
		{
			// Token: 0x0600298E RID: 10638 RVA: 0x00095F98 File Offset: 0x00094198
			// Note: this type is marked as 'beforefieldinit'.
			static _PromptConfirm_d__4()
			{
				Il2CppClassPointerStore<WormRetreatConfirmButton._PromptConfirm_d__4>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormRetreatConfirmButton>.NativeClassPtr, "<PromptConfirm>d__4");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormRetreatConfirmButton._PromptConfirm_d__4>.NativeClassPtr);
				WormRetreatConfirmButton._PromptConfirm_d__4.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormRetreatConfirmButton._PromptConfirm_d__4>.NativeClassPtr, "<>1__state");
				WormRetreatConfirmButton._PromptConfirm_d__4.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormRetreatConfirmButton._PromptConfirm_d__4>.NativeClassPtr, "<>2__current");
				WormRetreatConfirmButton._PromptConfirm_d__4.NativeFieldInfoPtr_warning = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormRetreatConfirmButton._PromptConfirm_d__4>.NativeClassPtr, "warning");
				WormRetreatConfirmButton._PromptConfirm_d__4.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormRetreatConfirmButton._PromptConfirm_d__4>.NativeClassPtr, "<>4__this");
				WormRetreatConfirmButton._PromptConfirm_d__4.NativeFieldInfoPtr__prompt_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormRetreatConfirmButton._PromptConfirm_d__4>.NativeClassPtr, "<prompt>5__2");
				WormRetreatConfirmButton._PromptConfirm_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormRetreatConfirmButton._PromptConfirm_d__4>.NativeClassPtr, 100666512);
				WormRetreatConfirmButton._PromptConfirm_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormRetreatConfirmButton._PromptConfirm_d__4>.NativeClassPtr, 100666513);
				WormRetreatConfirmButton._PromptConfirm_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormRetreatConfirmButton._PromptConfirm_d__4>.NativeClassPtr, 100666514);
				WormRetreatConfirmButton._PromptConfirm_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormRetreatConfirmButton._PromptConfirm_d__4>.NativeClassPtr, 100666515);
				WormRetreatConfirmButton._PromptConfirm_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormRetreatConfirmButton._PromptConfirm_d__4>.NativeClassPtr, 100666516);
				WormRetreatConfirmButton._PromptConfirm_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormRetreatConfirmButton._PromptConfirm_d__4>.NativeClassPtr, 100666517);
			}

			// Token: 0x0600298F RID: 10639 RVA: 0x000960A0 File Offset: 0x000942A0
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _PromptConfirm_d__4(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormRetreatConfirmButton._PromptConfirm_d__4>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormRetreatConfirmButton._PromptConfirm_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002990 RID: 10640 RVA: 0x000960E8 File Offset: 0x000942E8
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormRetreatConfirmButton._PromptConfirm_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002991 RID: 10641 RVA: 0x0009611C File Offset: 0x0009431C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 717150, XrefRangeEnd = 717165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormRetreatConfirmButton._PromptConfirm_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000BBD RID: 3005
			// (get) Token: 0x06002992 RID: 10642 RVA: 0x00096158 File Offset: 0x00094358
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormRetreatConfirmButton._PromptConfirm_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002993 RID: 10643 RVA: 0x00096198 File Offset: 0x00094398
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 717165, XrefRangeEnd = 717170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormRetreatConfirmButton._PromptConfirm_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000BBE RID: 3006
			// (get) Token: 0x06002994 RID: 10644 RVA: 0x000961CC File Offset: 0x000943CC
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormRetreatConfirmButton._PromptConfirm_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002995 RID: 10645 RVA: 0x00016BDB File Offset: 0x00014DDB
			public _PromptConfirm_d__4(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000BB8 RID: 3000
			// (get) Token: 0x06002996 RID: 10646 RVA: 0x0009620C File Offset: 0x0009440C
			// (set) Token: 0x06002997 RID: 10647 RVA: 0x00016BE4 File Offset: 0x00014DE4
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormRetreatConfirmButton._PromptConfirm_d__4.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormRetreatConfirmButton._PromptConfirm_d__4.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000BB9 RID: 3001
			// (get) Token: 0x06002998 RID: 10648 RVA: 0x00096234 File Offset: 0x00094434
			// (set) Token: 0x06002999 RID: 10649 RVA: 0x00016BFF File Offset: 0x00014DFF
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormRetreatConfirmButton._PromptConfirm_d__4.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormRetreatConfirmButton._PromptConfirm_d__4.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000BBA RID: 3002
			// (get) Token: 0x0600299A RID: 10650 RVA: 0x00096264 File Offset: 0x00094464
			// (set) Token: 0x0600299B RID: 10651 RVA: 0x00016C1E File Offset: 0x00014E1E
			public unsafe LocalizableText warning
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormRetreatConfirmButton._PromptConfirm_d__4.NativeFieldInfoPtr_warning);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LocalizableText>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormRetreatConfirmButton._PromptConfirm_d__4.NativeFieldInfoPtr_warning), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000BBB RID: 3003
			// (get) Token: 0x0600299C RID: 10652 RVA: 0x00096294 File Offset: 0x00094494
			// (set) Token: 0x0600299D RID: 10653 RVA: 0x00016C3D File Offset: 0x00014E3D
			public unsafe WormRetreatConfirmButton __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormRetreatConfirmButton._PromptConfirm_d__4.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormRetreatConfirmButton>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormRetreatConfirmButton._PromptConfirm_d__4.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000BBC RID: 3004
			// (get) Token: 0x0600299E RID: 10654 RVA: 0x000962C4 File Offset: 0x000944C4
			// (set) Token: 0x0600299F RID: 10655 RVA: 0x00016C5C File Offset: 0x00014E5C
			public unsafe ConfirmOrDenyPrompt _prompt_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormRetreatConfirmButton._PromptConfirm_d__4.NativeFieldInfoPtr__prompt_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConfirmOrDenyPrompt>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormRetreatConfirmButton._PromptConfirm_d__4.NativeFieldInfoPtr__prompt_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040017F7 RID: 6135
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040017F8 RID: 6136
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040017F9 RID: 6137
			private static readonly IntPtr NativeFieldInfoPtr_warning;

			// Token: 0x040017FA RID: 6138
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040017FB RID: 6139
			private static readonly IntPtr NativeFieldInfoPtr__prompt_5__2;

			// Token: 0x040017FC RID: 6140
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040017FD RID: 6141
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040017FE RID: 6142
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040017FF RID: 6143
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001800 RID: 6144
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001801 RID: 6145
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
