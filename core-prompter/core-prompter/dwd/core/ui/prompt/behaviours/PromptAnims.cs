using System;
using dwd.core.animation;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;

namespace dwd.core.ui.prompt.behaviours
{
	// Token: 0x0200003A RID: 58
	public class PromptAnims : PromptBehaviour
	{
		// Token: 0x06000215 RID: 533 RVA: 0x0000A930 File Offset: 0x00008B30
		// Note: this type is marked as 'beforefieldinit'.
		static PromptAnims()
		{
			Il2CppClassPointerStore<PromptAnims>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-prompter.dll", "dwd.core.ui.prompt.behaviours", "PromptAnims");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PromptAnims>.NativeClassPtr);
			PromptAnims.NativeFieldInfoPtr_openAnimation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PromptAnims>.NativeClassPtr, "openAnimation");
			PromptAnims.NativeFieldInfoPtr_closeAnimation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PromptAnims>.NativeClassPtr, "closeAnimation");
			PromptAnims.NativeFieldInfoPtr_blockInputDuringAnimation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PromptAnims>.NativeClassPtr, "blockInputDuringAnimation");
			PromptAnims.NativeFieldInfoPtr_warnIfOpenCloseMatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PromptAnims>.NativeClassPtr, "warnIfOpenCloseMatch");
			PromptAnims.NativeMethodInfoPtr_get_OpenAnimation_Public_get_TriggeredBlockingAnimation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PromptAnims>.NativeClassPtr, 100663534);
			PromptAnims.NativeMethodInfoPtr_set_OpenAnimation_Public_set_Void_TriggeredBlockingAnimation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PromptAnims>.NativeClassPtr, 100663535);
			PromptAnims.NativeMethodInfoPtr_get_CloseAnimation_Public_get_TriggeredBlockingAnimation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PromptAnims>.NativeClassPtr, 100663536);
			PromptAnims.NativeMethodInfoPtr_set_CloseAnimation_Public_set_Void_TriggeredBlockingAnimation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PromptAnims>.NativeClassPtr, 100663537);
			PromptAnims.NativeMethodInfoPtr_get_BlockInputDuringAnimation_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PromptAnims>.NativeClassPtr, 100663538);
			PromptAnims.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PromptAnims>.NativeClassPtr, 100663539);
			PromptAnims.NativeMethodInfoPtr_Event_AnimatorOpen_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PromptAnims>.NativeClassPtr, 100663540);
			PromptAnims.NativeMethodInfoPtr_AnimateOpen_Public_Virtual_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PromptAnims>.NativeClassPtr, 100663541);
			PromptAnims.NativeMethodInfoPtr_Event_AnimatorClose_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PromptAnims>.NativeClassPtr, 100663542);
			PromptAnims.NativeMethodInfoPtr_AnimateClose_Public_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PromptAnims>.NativeClassPtr, 100663543);
			PromptAnims.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PromptAnims>.NativeClassPtr, 100663544);
		}

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x06000216 RID: 534 RVA: 0x0000AA8C File Offset: 0x00008C8C
		// (set) Token: 0x06000217 RID: 535 RVA: 0x0000AACC File Offset: 0x00008CCC
		public unsafe TriggeredBlockingAnimation OpenAnimation
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PromptAnims.NativeMethodInfoPtr_get_OpenAnimation_Public_get_TriggeredBlockingAnimation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TriggeredBlockingAnimation>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PromptAnims.NativeMethodInfoPtr_set_OpenAnimation_Public_set_Void_TriggeredBlockingAnimation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x06000218 RID: 536 RVA: 0x0000AB10 File Offset: 0x00008D10
		// (set) Token: 0x06000219 RID: 537 RVA: 0x0000AB50 File Offset: 0x00008D50
		public unsafe TriggeredBlockingAnimation CloseAnimation
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PromptAnims.NativeMethodInfoPtr_get_CloseAnimation_Public_get_TriggeredBlockingAnimation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TriggeredBlockingAnimation>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PromptAnims.NativeMethodInfoPtr_set_CloseAnimation_Public_set_Void_TriggeredBlockingAnimation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x0600021A RID: 538 RVA: 0x0000AB94 File Offset: 0x00008D94
		public unsafe bool BlockInputDuringAnimation
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PromptAnims.NativeMethodInfoPtr_get_BlockInputDuringAnimation_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600021B RID: 539 RVA: 0x0000ABD0 File Offset: 0x00008DD0
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PromptAnims.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600021C RID: 540 RVA: 0x0000AC04 File Offset: 0x00008E04
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1214435, RefRangeEnd = 1214436, XrefRangeStart = 1214434, XrefRangeEnd = 1214435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_AnimatorOpen()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PromptAnims.NativeMethodInfoPtr_Event_AnimatorOpen_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600021D RID: 541 RVA: 0x0000AC38 File Offset: 0x00008E38
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1214441, RefRangeEnd = 1214442, XrefRangeStart = 1214436, XrefRangeEnd = 1214441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator AnimateOpen()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PromptAnims.NativeMethodInfoPtr_AnimateOpen_Public_Virtual_New_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600021E RID: 542 RVA: 0x0000AC84 File Offset: 0x00008E84
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1214448, RefRangeEnd = 1214449, XrefRangeStart = 1214442, XrefRangeEnd = 1214448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_AnimatorClose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PromptAnims.NativeMethodInfoPtr_Event_AnimatorClose_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600021F RID: 543 RVA: 0x0000ACB8 File Offset: 0x00008EB8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1214454, RefRangeEnd = 1214455, XrefRangeStart = 1214449, XrefRangeEnd = 1214454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator AnimateClose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PromptAnims.NativeMethodInfoPtr_AnimateClose_Public_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000220 RID: 544 RVA: 0x0000ACF8 File Offset: 0x00008EF8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1214456, RefRangeEnd = 1214457, XrefRangeStart = 1214455, XrefRangeEnd = 1214456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PromptAnims()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PromptAnims>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PromptAnims.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000221 RID: 545 RVA: 0x00003154 File Offset: 0x00001354
		public PromptAnims(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x06000222 RID: 546 RVA: 0x0000AD34 File Offset: 0x00008F34
		// (set) Token: 0x06000223 RID: 547 RVA: 0x0000315D File Offset: 0x0000135D
		public unsafe TriggeredBlockingAnimation openAnimation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PromptAnims.NativeFieldInfoPtr_openAnimation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TriggeredBlockingAnimation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PromptAnims.NativeFieldInfoPtr_openAnimation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x06000224 RID: 548 RVA: 0x0000AD64 File Offset: 0x00008F64
		// (set) Token: 0x06000225 RID: 549 RVA: 0x0000317C File Offset: 0x0000137C
		public unsafe TriggeredBlockingAnimation closeAnimation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PromptAnims.NativeFieldInfoPtr_closeAnimation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TriggeredBlockingAnimation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PromptAnims.NativeFieldInfoPtr_closeAnimation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x06000226 RID: 550 RVA: 0x0000AD94 File Offset: 0x00008F94
		// (set) Token: 0x06000227 RID: 551 RVA: 0x0000319B File Offset: 0x0000139B
		public unsafe bool blockInputDuringAnimation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PromptAnims.NativeFieldInfoPtr_blockInputDuringAnimation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PromptAnims.NativeFieldInfoPtr_blockInputDuringAnimation)) = value;
			}
		}

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x06000228 RID: 552 RVA: 0x0000ADBC File Offset: 0x00008FBC
		// (set) Token: 0x06000229 RID: 553 RVA: 0x000031B6 File Offset: 0x000013B6
		public unsafe bool warnIfOpenCloseMatch
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PromptAnims.NativeFieldInfoPtr_warnIfOpenCloseMatch);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PromptAnims.NativeFieldInfoPtr_warnIfOpenCloseMatch)) = value;
			}
		}

		// Token: 0x04000124 RID: 292
		private static readonly IntPtr NativeFieldInfoPtr_openAnimation;

		// Token: 0x04000125 RID: 293
		private static readonly IntPtr NativeFieldInfoPtr_closeAnimation;

		// Token: 0x04000126 RID: 294
		private static readonly IntPtr NativeFieldInfoPtr_blockInputDuringAnimation;

		// Token: 0x04000127 RID: 295
		private static readonly IntPtr NativeFieldInfoPtr_warnIfOpenCloseMatch;

		// Token: 0x04000128 RID: 296
		private static readonly IntPtr NativeMethodInfoPtr_get_OpenAnimation_Public_get_TriggeredBlockingAnimation_0;

		// Token: 0x04000129 RID: 297
		private static readonly IntPtr NativeMethodInfoPtr_set_OpenAnimation_Public_set_Void_TriggeredBlockingAnimation_0;

		// Token: 0x0400012A RID: 298
		private static readonly IntPtr NativeMethodInfoPtr_get_CloseAnimation_Public_get_TriggeredBlockingAnimation_0;

		// Token: 0x0400012B RID: 299
		private static readonly IntPtr NativeMethodInfoPtr_set_CloseAnimation_Public_set_Void_TriggeredBlockingAnimation_0;

		// Token: 0x0400012C RID: 300
		private static readonly IntPtr NativeMethodInfoPtr_get_BlockInputDuringAnimation_Public_get_Boolean_0;

		// Token: 0x0400012D RID: 301
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x0400012E RID: 302
		private static readonly IntPtr NativeMethodInfoPtr_Event_AnimatorOpen_Public_Void_0;

		// Token: 0x0400012F RID: 303
		private static readonly IntPtr NativeMethodInfoPtr_AnimateOpen_Public_Virtual_New_IEnumerator_0;

		// Token: 0x04000130 RID: 304
		private static readonly IntPtr NativeMethodInfoPtr_Event_AnimatorClose_Public_Void_0;

		// Token: 0x04000131 RID: 305
		private static readonly IntPtr NativeMethodInfoPtr_AnimateClose_Public_IEnumerator_0;

		// Token: 0x04000132 RID: 306
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000058 RID: 88
		[ObfuscatedName("dwd.core.ui.prompt.behaviours.PromptAnims+<AnimateClose>d__16")]
		public sealed class _AnimateClose_d__16 : Object
		{
			// Token: 0x06000378 RID: 888 RVA: 0x0000EFC8 File Offset: 0x0000D1C8
			// Note: this type is marked as 'beforefieldinit'.
			static _AnimateClose_d__16()
			{
				Il2CppClassPointerStore<PromptAnims._AnimateClose_d__16>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PromptAnims>.NativeClassPtr, "<AnimateClose>d__16");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PromptAnims._AnimateClose_d__16>.NativeClassPtr);
				PromptAnims._AnimateClose_d__16.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PromptAnims._AnimateClose_d__16>.NativeClassPtr, "<>1__state");
				PromptAnims._AnimateClose_d__16.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PromptAnims._AnimateClose_d__16>.NativeClassPtr, "<>2__current");
				PromptAnims._AnimateClose_d__16.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PromptAnims._AnimateClose_d__16>.NativeClassPtr, "<>4__this");
				PromptAnims._AnimateClose_d__16.NativeFieldInfoPtr__triggerAndBlock_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PromptAnims._AnimateClose_d__16>.NativeClassPtr, "<triggerAndBlock>5__2");
				PromptAnims._AnimateClose_d__16.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PromptAnims._AnimateClose_d__16>.NativeClassPtr, 100663545);
				PromptAnims._AnimateClose_d__16.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PromptAnims._AnimateClose_d__16>.NativeClassPtr, 100663546);
				PromptAnims._AnimateClose_d__16.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PromptAnims._AnimateClose_d__16>.NativeClassPtr, 100663547);
				PromptAnims._AnimateClose_d__16.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PromptAnims._AnimateClose_d__16>.NativeClassPtr, 100663548);
				PromptAnims._AnimateClose_d__16.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PromptAnims._AnimateClose_d__16>.NativeClassPtr, 100663549);
				PromptAnims._AnimateClose_d__16.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PromptAnims._AnimateClose_d__16>.NativeClassPtr, 100663550);
			}

			// Token: 0x06000379 RID: 889 RVA: 0x0000F0BC File Offset: 0x0000D2BC
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _AnimateClose_d__16(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PromptAnims._AnimateClose_d__16>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PromptAnims._AnimateClose_d__16.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600037A RID: 890 RVA: 0x0000F104 File Offset: 0x0000D304
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PromptAnims._AnimateClose_d__16.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600037B RID: 891 RVA: 0x0000F138 File Offset: 0x0000D338
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1214398, XrefRangeEnd = 1214411, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PromptAnims._AnimateClose_d__16.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000125 RID: 293
			// (get) Token: 0x0600037C RID: 892 RVA: 0x0000F174 File Offset: 0x0000D374
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PromptAnims._AnimateClose_d__16.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600037D RID: 893 RVA: 0x0000F1B4 File Offset: 0x0000D3B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1214411, XrefRangeEnd = 1214416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PromptAnims._AnimateClose_d__16.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000126 RID: 294
			// (get) Token: 0x0600037E RID: 894 RVA: 0x0000F1E8 File Offset: 0x0000D3E8
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PromptAnims._AnimateClose_d__16.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600037F RID: 895 RVA: 0x00003C0C File Offset: 0x00001E0C
			public _AnimateClose_d__16(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000121 RID: 289
			// (get) Token: 0x06000380 RID: 896 RVA: 0x0000F228 File Offset: 0x0000D428
			// (set) Token: 0x06000381 RID: 897 RVA: 0x00003C15 File Offset: 0x00001E15
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PromptAnims._AnimateClose_d__16.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PromptAnims._AnimateClose_d__16.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000122 RID: 290
			// (get) Token: 0x06000382 RID: 898 RVA: 0x0000F250 File Offset: 0x0000D450
			// (set) Token: 0x06000383 RID: 899 RVA: 0x00003C30 File Offset: 0x00001E30
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PromptAnims._AnimateClose_d__16.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PromptAnims._AnimateClose_d__16.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000123 RID: 291
			// (get) Token: 0x06000384 RID: 900 RVA: 0x0000F280 File Offset: 0x0000D480
			// (set) Token: 0x06000385 RID: 901 RVA: 0x00003C4F File Offset: 0x00001E4F
			public unsafe PromptAnims __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PromptAnims._AnimateClose_d__16.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PromptAnims>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PromptAnims._AnimateClose_d__16.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000124 RID: 292
			// (get) Token: 0x06000386 RID: 902 RVA: 0x0000F2B0 File Offset: 0x0000D4B0
			// (set) Token: 0x06000387 RID: 903 RVA: 0x00003C6E File Offset: 0x00001E6E
			public unsafe IEnumerator _triggerAndBlock_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PromptAnims._AnimateClose_d__16.NativeFieldInfoPtr__triggerAndBlock_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PromptAnims._AnimateClose_d__16.NativeFieldInfoPtr__triggerAndBlock_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040001F7 RID: 503
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040001F8 RID: 504
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040001F9 RID: 505
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040001FA RID: 506
			private static readonly IntPtr NativeFieldInfoPtr__triggerAndBlock_5__2;

			// Token: 0x040001FB RID: 507
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040001FC RID: 508
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040001FD RID: 509
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040001FE RID: 510
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040001FF RID: 511
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000200 RID: 512
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000059 RID: 89
		[ObfuscatedName("dwd.core.ui.prompt.behaviours.PromptAnims+<AnimateOpen>d__14")]
		public sealed class _AnimateOpen_d__14 : Object
		{
			// Token: 0x06000388 RID: 904 RVA: 0x0000F2E0 File Offset: 0x0000D4E0
			// Note: this type is marked as 'beforefieldinit'.
			static _AnimateOpen_d__14()
			{
				Il2CppClassPointerStore<PromptAnims._AnimateOpen_d__14>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PromptAnims>.NativeClassPtr, "<AnimateOpen>d__14");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PromptAnims._AnimateOpen_d__14>.NativeClassPtr);
				PromptAnims._AnimateOpen_d__14.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PromptAnims._AnimateOpen_d__14>.NativeClassPtr, "<>1__state");
				PromptAnims._AnimateOpen_d__14.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PromptAnims._AnimateOpen_d__14>.NativeClassPtr, "<>2__current");
				PromptAnims._AnimateOpen_d__14.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PromptAnims._AnimateOpen_d__14>.NativeClassPtr, "<>4__this");
				PromptAnims._AnimateOpen_d__14.NativeFieldInfoPtr__triggerAndBlock_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PromptAnims._AnimateOpen_d__14>.NativeClassPtr, "<triggerAndBlock>5__2");
				PromptAnims._AnimateOpen_d__14.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PromptAnims._AnimateOpen_d__14>.NativeClassPtr, 100663551);
				PromptAnims._AnimateOpen_d__14.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PromptAnims._AnimateOpen_d__14>.NativeClassPtr, 100663552);
				PromptAnims._AnimateOpen_d__14.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PromptAnims._AnimateOpen_d__14>.NativeClassPtr, 100663553);
				PromptAnims._AnimateOpen_d__14.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PromptAnims._AnimateOpen_d__14>.NativeClassPtr, 100663554);
				PromptAnims._AnimateOpen_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PromptAnims._AnimateOpen_d__14>.NativeClassPtr, 100663555);
				PromptAnims._AnimateOpen_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PromptAnims._AnimateOpen_d__14>.NativeClassPtr, 100663556);
			}

			// Token: 0x06000389 RID: 905 RVA: 0x0000F3D4 File Offset: 0x0000D5D4
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _AnimateOpen_d__14(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PromptAnims._AnimateOpen_d__14>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PromptAnims._AnimateOpen_d__14.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600038A RID: 906 RVA: 0x0000F41C File Offset: 0x0000D61C
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PromptAnims._AnimateOpen_d__14.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600038B RID: 907 RVA: 0x0000F450 File Offset: 0x0000D650
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1214416, XrefRangeEnd = 1214429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PromptAnims._AnimateOpen_d__14.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700012B RID: 299
			// (get) Token: 0x0600038C RID: 908 RVA: 0x0000F48C File Offset: 0x0000D68C
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PromptAnims._AnimateOpen_d__14.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600038D RID: 909 RVA: 0x0000F4CC File Offset: 0x0000D6CC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1214429, XrefRangeEnd = 1214434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PromptAnims._AnimateOpen_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700012C RID: 300
			// (get) Token: 0x0600038E RID: 910 RVA: 0x0000F500 File Offset: 0x0000D700
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PromptAnims._AnimateOpen_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600038F RID: 911 RVA: 0x00003C8D File Offset: 0x00001E8D
			public _AnimateOpen_d__14(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000127 RID: 295
			// (get) Token: 0x06000390 RID: 912 RVA: 0x0000F540 File Offset: 0x0000D740
			// (set) Token: 0x06000391 RID: 913 RVA: 0x00003C96 File Offset: 0x00001E96
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PromptAnims._AnimateOpen_d__14.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PromptAnims._AnimateOpen_d__14.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000128 RID: 296
			// (get) Token: 0x06000392 RID: 914 RVA: 0x0000F568 File Offset: 0x0000D768
			// (set) Token: 0x06000393 RID: 915 RVA: 0x00003CB1 File Offset: 0x00001EB1
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PromptAnims._AnimateOpen_d__14.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PromptAnims._AnimateOpen_d__14.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000129 RID: 297
			// (get) Token: 0x06000394 RID: 916 RVA: 0x0000F598 File Offset: 0x0000D798
			// (set) Token: 0x06000395 RID: 917 RVA: 0x00003CD0 File Offset: 0x00001ED0
			public unsafe PromptAnims __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PromptAnims._AnimateOpen_d__14.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PromptAnims>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PromptAnims._AnimateOpen_d__14.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700012A RID: 298
			// (get) Token: 0x06000396 RID: 918 RVA: 0x0000F5C8 File Offset: 0x0000D7C8
			// (set) Token: 0x06000397 RID: 919 RVA: 0x00003CEF File Offset: 0x00001EEF
			public unsafe IEnumerator _triggerAndBlock_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PromptAnims._AnimateOpen_d__14.NativeFieldInfoPtr__triggerAndBlock_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PromptAnims._AnimateOpen_d__14.NativeFieldInfoPtr__triggerAndBlock_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000201 RID: 513
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000202 RID: 514
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000203 RID: 515
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000204 RID: 516
			private static readonly IntPtr NativeFieldInfoPtr__triggerAndBlock_5__2;

			// Token: 0x04000205 RID: 517
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000206 RID: 518
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000207 RID: 519
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000208 RID: 520
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000209 RID: 521
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400020A RID: 522
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
