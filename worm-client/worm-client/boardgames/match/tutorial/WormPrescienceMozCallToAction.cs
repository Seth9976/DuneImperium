using System;
using Canis.attributes;
using dwd.core.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using lotus;

namespace boardgames.match.tutorial
{
	// Token: 0x0200002E RID: 46
	public class WormPrescienceMozCallToAction : ObserverCallToAction
	{
		// Token: 0x060001FE RID: 510 RVA: 0x0001F2DC File Offset: 0x0001D4DC
		// Note: this type is marked as 'beforefieldinit'.
		static WormPrescienceMozCallToAction()
		{
			Il2CppClassPointerStore<WormPrescienceMozCallToAction>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "boardgames.match.tutorial", "WormPrescienceMozCallToAction");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormPrescienceMozCallToAction>.NativeClassPtr);
			WormPrescienceMozCallToAction.NativeFieldInfoPtr_deckView = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPrescienceMozCallToAction>.NativeClassPtr, "deckView");
			WormPrescienceMozCallToAction.NativeFieldInfoPtr_mozComplete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPrescienceMozCallToAction>.NativeClassPtr, "mozComplete");
			WormPrescienceMozCallToAction.NativeMethodInfoPtr_get_Identifier_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPrescienceMozCallToAction>.NativeClassPtr, 100663651);
			WormPrescienceMozCallToAction.NativeMethodInfoPtr_RunAction_Public_Virtual_IEnumerator_MutableAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPrescienceMozCallToAction>.NativeClassPtr, 100663652);
			WormPrescienceMozCallToAction.NativeMethodInfoPtr_DirtyUpdate_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPrescienceMozCallToAction>.NativeClassPtr, 100663653);
			WormPrescienceMozCallToAction.NativeMethodInfoPtr_GetPersistentTutorialEffect_Public_Virtual_Command_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPrescienceMozCallToAction>.NativeClassPtr, 100663654);
			WormPrescienceMozCallToAction.NativeMethodInfoPtr_CompleteMozRequirement_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPrescienceMozCallToAction>.NativeClassPtr, 100663655);
			WormPrescienceMozCallToAction.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPrescienceMozCallToAction>.NativeClassPtr, 100663656);
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x060001FF RID: 511 RVA: 0x0001F3AC File Offset: 0x0001D5AC
		public unsafe override string Identifier
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 689854, XrefRangeEnd = 689859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormPrescienceMozCallToAction.NativeMethodInfoPtr_get_Identifier_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000200 RID: 512 RVA: 0x0001F3F0 File Offset: 0x0001D5F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 689859, XrefRangeEnd = 689864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator RunAction(MutableAttributes attributes)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attributes);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormPrescienceMozCallToAction.NativeMethodInfoPtr_RunAction_Public_Virtual_IEnumerator_MutableAttributes_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x06000201 RID: 513 RVA: 0x0001F44C File Offset: 0x0001D64C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void DirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormPrescienceMozCallToAction.NativeMethodInfoPtr_DirtyUpdate_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000202 RID: 514 RVA: 0x0001F488 File Offset: 0x0001D688
		[CallerCount(74)]
		[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Command GetPersistentTutorialEffect()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormPrescienceMozCallToAction.NativeMethodInfoPtr_GetPersistentTutorialEffect_Public_Virtual_Command_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Command>(intPtr3) : null;
		}

		// Token: 0x06000203 RID: 515 RVA: 0x0001F4D4 File Offset: 0x0001D6D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 689864, XrefRangeEnd = 689877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CompleteMozRequirement(string entityIDString)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(entityIDString);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPrescienceMozCallToAction.NativeMethodInfoPtr_CompleteMozRequirement_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000204 RID: 516 RVA: 0x0001F518 File Offset: 0x0001D718
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 689877, XrefRangeEnd = 689878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormPrescienceMozCallToAction()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormPrescienceMozCallToAction>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPrescienceMozCallToAction.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000205 RID: 517 RVA: 0x00002ED1 File Offset: 0x000010D1
		public WormPrescienceMozCallToAction(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x06000206 RID: 518 RVA: 0x0001F554 File Offset: 0x0001D754
		// (set) Token: 0x06000207 RID: 519 RVA: 0x00002EDA File Offset: 0x000010DA
		public unsafe EntityView deckView
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPrescienceMozCallToAction.NativeFieldInfoPtr_deckView);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityView>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPrescienceMozCallToAction.NativeFieldInfoPtr_deckView), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x06000208 RID: 520 RVA: 0x0001F584 File Offset: 0x0001D784
		// (set) Token: 0x06000209 RID: 521 RVA: 0x00002EF9 File Offset: 0x000010F9
		public unsafe bool mozComplete
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPrescienceMozCallToAction.NativeFieldInfoPtr_mozComplete);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPrescienceMozCallToAction.NativeFieldInfoPtr_mozComplete)) = value;
			}
		}

		// Token: 0x0400013B RID: 315
		private static readonly IntPtr NativeFieldInfoPtr_deckView;

		// Token: 0x0400013C RID: 316
		private static readonly IntPtr NativeFieldInfoPtr_mozComplete;

		// Token: 0x0400013D RID: 317
		private static readonly IntPtr NativeMethodInfoPtr_get_Identifier_Public_Virtual_get_String_0;

		// Token: 0x0400013E RID: 318
		private static readonly IntPtr NativeMethodInfoPtr_RunAction_Public_Virtual_IEnumerator_MutableAttributes_0;

		// Token: 0x0400013F RID: 319
		private static readonly IntPtr NativeMethodInfoPtr_DirtyUpdate_Public_Virtual_Void_0;

		// Token: 0x04000140 RID: 320
		private static readonly IntPtr NativeMethodInfoPtr_GetPersistentTutorialEffect_Public_Virtual_Command_0;

		// Token: 0x04000141 RID: 321
		private static readonly IntPtr NativeMethodInfoPtr_CompleteMozRequirement_Private_Void_String_0;

		// Token: 0x04000142 RID: 322
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020002CF RID: 719
		[ObfuscatedName("boardgames.match.tutorial.WormPrescienceMozCallToAction+<RunAction>d__4")]
		public sealed class _RunAction_d__4 : Object
		{
			// Token: 0x06001D6F RID: 7535 RVA: 0x00072604 File Offset: 0x00070804
			// Note: this type is marked as 'beforefieldinit'.
			static _RunAction_d__4()
			{
				Il2CppClassPointerStore<WormPrescienceMozCallToAction._RunAction_d__4>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormPrescienceMozCallToAction>.NativeClassPtr, "<RunAction>d__4");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormPrescienceMozCallToAction._RunAction_d__4>.NativeClassPtr);
				WormPrescienceMozCallToAction._RunAction_d__4.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPrescienceMozCallToAction._RunAction_d__4>.NativeClassPtr, "<>1__state");
				WormPrescienceMozCallToAction._RunAction_d__4.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPrescienceMozCallToAction._RunAction_d__4>.NativeClassPtr, "<>2__current");
				WormPrescienceMozCallToAction._RunAction_d__4.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPrescienceMozCallToAction._RunAction_d__4>.NativeClassPtr, "<>4__this");
				WormPrescienceMozCallToAction._RunAction_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPrescienceMozCallToAction._RunAction_d__4>.NativeClassPtr, 100663657);
				WormPrescienceMozCallToAction._RunAction_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPrescienceMozCallToAction._RunAction_d__4>.NativeClassPtr, 100663658);
				WormPrescienceMozCallToAction._RunAction_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPrescienceMozCallToAction._RunAction_d__4>.NativeClassPtr, 100663659);
				WormPrescienceMozCallToAction._RunAction_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPrescienceMozCallToAction._RunAction_d__4>.NativeClassPtr, 100663660);
				WormPrescienceMozCallToAction._RunAction_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPrescienceMozCallToAction._RunAction_d__4>.NativeClassPtr, 100663661);
				WormPrescienceMozCallToAction._RunAction_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPrescienceMozCallToAction._RunAction_d__4>.NativeClassPtr, 100663662);
			}

			// Token: 0x06001D70 RID: 7536 RVA: 0x000726E4 File Offset: 0x000708E4
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _RunAction_d__4(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormPrescienceMozCallToAction._RunAction_d__4>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPrescienceMozCallToAction._RunAction_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001D71 RID: 7537 RVA: 0x0007272C File Offset: 0x0007092C
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPrescienceMozCallToAction._RunAction_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001D72 RID: 7538 RVA: 0x00072760 File Offset: 0x00070960
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 689834, XrefRangeEnd = 689849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPrescienceMozCallToAction._RunAction_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000811 RID: 2065
			// (get) Token: 0x06001D73 RID: 7539 RVA: 0x0007279C File Offset: 0x0007099C
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPrescienceMozCallToAction._RunAction_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001D74 RID: 7540 RVA: 0x000727DC File Offset: 0x000709DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 689849, XrefRangeEnd = 689854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPrescienceMozCallToAction._RunAction_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000812 RID: 2066
			// (get) Token: 0x06001D75 RID: 7541 RVA: 0x00072810 File Offset: 0x00070A10
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPrescienceMozCallToAction._RunAction_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001D76 RID: 7542 RVA: 0x00010D2A File Offset: 0x0000EF2A
			public _RunAction_d__4(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700080E RID: 2062
			// (get) Token: 0x06001D77 RID: 7543 RVA: 0x00072850 File Offset: 0x00070A50
			// (set) Token: 0x06001D78 RID: 7544 RVA: 0x00010D33 File Offset: 0x0000EF33
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPrescienceMozCallToAction._RunAction_d__4.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPrescienceMozCallToAction._RunAction_d__4.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700080F RID: 2063
			// (get) Token: 0x06001D79 RID: 7545 RVA: 0x00072878 File Offset: 0x00070A78
			// (set) Token: 0x06001D7A RID: 7546 RVA: 0x00010D4E File Offset: 0x0000EF4E
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPrescienceMozCallToAction._RunAction_d__4.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPrescienceMozCallToAction._RunAction_d__4.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000810 RID: 2064
			// (get) Token: 0x06001D7B RID: 7547 RVA: 0x000728A8 File Offset: 0x00070AA8
			// (set) Token: 0x06001D7C RID: 7548 RVA: 0x00010D6D File Offset: 0x0000EF6D
			public unsafe WormPrescienceMozCallToAction __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPrescienceMozCallToAction._RunAction_d__4.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPrescienceMozCallToAction>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPrescienceMozCallToAction._RunAction_d__4.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001101 RID: 4353
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001102 RID: 4354
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001103 RID: 4355
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001104 RID: 4356
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001105 RID: 4357
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001106 RID: 4358
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001107 RID: 4359
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001108 RID: 4360
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001109 RID: 4361
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
