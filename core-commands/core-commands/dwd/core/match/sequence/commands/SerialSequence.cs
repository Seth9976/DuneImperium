using System;
using Canis.utils.ids;
using dwd.core.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace dwd.core.match.sequence.commands
{
	// Token: 0x0200000E RID: 14
	public class SerialSequence : SequenceCommand
	{
		// Token: 0x0600006B RID: 107 RVA: 0x000060B0 File Offset: 0x000042B0
		// Note: this type is marked as 'beforefieldinit'.
		static SerialSequence()
		{
			Il2CppClassPointerStore<SerialSequence>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-commands.dll", "dwd.core.match.sequence.commands", "SerialSequence");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerialSequence>.NativeClassPtr);
			SerialSequence.NativeMethodInfoPtr__ctor_Public_Void_SequenceID_String_IList_1_Command_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerialSequence>.NativeClassPtr, 100663351);
			SerialSequence.NativeMethodInfoPtr_preExecute_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerialSequence>.NativeClassPtr, 100663352);
			SerialSequence.NativeMethodInfoPtr_executeSequence_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerialSequence>.NativeClassPtr, 100663353);
		}

		// Token: 0x0600006C RID: 108 RVA: 0x0000611C File Offset: 0x0000431C
		[CallerCount(39)]
		[CachedScanResults(RefRangeStart = 719643, RefRangeEnd = 719682, XrefRangeStart = 719643, XrefRangeEnd = 719682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerialSequence(SequenceID id, string name, IList<Command> sequence)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerialSequence>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(id);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sequence);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerialSequence.NativeMethodInfoPtr__ctor_Public_Void_SequenceID_String_IList_1_Command_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600006D RID: 109 RVA: 0x0000618C File Offset: 0x0000438C
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void preExecute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SerialSequence.NativeMethodInfoPtr_preExecute_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600006E RID: 110 RVA: 0x000061C8 File Offset: 0x000043C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1206254, XrefRangeEnd = 1206259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator executeSequence()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SerialSequence.NativeMethodInfoPtr_executeSequence_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600006F RID: 111 RVA: 0x000023B5 File Offset: 0x000005B5
		public SerialSequence(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400003F RID: 63
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SequenceID_String_IList_1_Command_0;

		// Token: 0x04000040 RID: 64
		private static readonly IntPtr NativeMethodInfoPtr_preExecute_Protected_Virtual_New_Void_0;

		// Token: 0x04000041 RID: 65
		private static readonly IntPtr NativeMethodInfoPtr_executeSequence_Protected_Virtual_IEnumerator_0;

		// Token: 0x0200003F RID: 63
		[ObfuscatedName("dwd.core.match.sequence.commands.SerialSequence+<executeSequence>d__2")]
		public sealed class _executeSequence_d__2 : Object
		{
			// Token: 0x06000247 RID: 583 RVA: 0x0000D558 File Offset: 0x0000B758
			// Note: this type is marked as 'beforefieldinit'.
			static _executeSequence_d__2()
			{
				Il2CppClassPointerStore<SerialSequence._executeSequence_d__2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SerialSequence>.NativeClassPtr, "<executeSequence>d__2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerialSequence._executeSequence_d__2>.NativeClassPtr);
				SerialSequence._executeSequence_d__2.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerialSequence._executeSequence_d__2>.NativeClassPtr, "<>1__state");
				SerialSequence._executeSequence_d__2.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerialSequence._executeSequence_d__2>.NativeClassPtr, "<>2__current");
				SerialSequence._executeSequence_d__2.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerialSequence._executeSequence_d__2>.NativeClassPtr, "<>4__this");
				SerialSequence._executeSequence_d__2.NativeFieldInfoPtr__i_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerialSequence._executeSequence_d__2>.NativeClassPtr, "<i>5__2");
				SerialSequence._executeSequence_d__2.NativeFieldInfoPtr__sequenceCommand_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerialSequence._executeSequence_d__2>.NativeClassPtr, "<sequenceCommand>5__3");
				SerialSequence._executeSequence_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerialSequence._executeSequence_d__2>.NativeClassPtr, 100663354);
				SerialSequence._executeSequence_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerialSequence._executeSequence_d__2>.NativeClassPtr, 100663355);
				SerialSequence._executeSequence_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerialSequence._executeSequence_d__2>.NativeClassPtr, 100663356);
				SerialSequence._executeSequence_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerialSequence._executeSequence_d__2>.NativeClassPtr, 100663357);
				SerialSequence._executeSequence_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerialSequence._executeSequence_d__2>.NativeClassPtr, 100663358);
				SerialSequence._executeSequence_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerialSequence._executeSequence_d__2>.NativeClassPtr, 100663359);
			}

			// Token: 0x06000248 RID: 584 RVA: 0x0000D660 File Offset: 0x0000B860
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _executeSequence_d__2(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerialSequence._executeSequence_d__2>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerialSequence._executeSequence_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000249 RID: 585 RVA: 0x0000D6A8 File Offset: 0x0000B8A8
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerialSequence._executeSequence_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600024A RID: 586 RVA: 0x0000D6DC File Offset: 0x0000B8DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1206233, XrefRangeEnd = 1206249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerialSequence._executeSequence_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700007F RID: 127
			// (get) Token: 0x0600024B RID: 587 RVA: 0x0000D718 File Offset: 0x0000B918
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerialSequence._executeSequence_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600024C RID: 588 RVA: 0x0000D758 File Offset: 0x0000B958
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1206249, XrefRangeEnd = 1206254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerialSequence._executeSequence_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000080 RID: 128
			// (get) Token: 0x0600024D RID: 589 RVA: 0x0000D78C File Offset: 0x0000B98C
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerialSequence._executeSequence_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600024E RID: 590 RVA: 0x00002FB1 File Offset: 0x000011B1
			public _executeSequence_d__2(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700007A RID: 122
			// (get) Token: 0x0600024F RID: 591 RVA: 0x0000D7CC File Offset: 0x0000B9CC
			// (set) Token: 0x06000250 RID: 592 RVA: 0x00002FBA File Offset: 0x000011BA
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerialSequence._executeSequence_d__2.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerialSequence._executeSequence_d__2.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700007B RID: 123
			// (get) Token: 0x06000251 RID: 593 RVA: 0x0000D7F4 File Offset: 0x0000B9F4
			// (set) Token: 0x06000252 RID: 594 RVA: 0x00002FD5 File Offset: 0x000011D5
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerialSequence._executeSequence_d__2.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerialSequence._executeSequence_d__2.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700007C RID: 124
			// (get) Token: 0x06000253 RID: 595 RVA: 0x0000D824 File Offset: 0x0000BA24
			// (set) Token: 0x06000254 RID: 596 RVA: 0x00002FF4 File Offset: 0x000011F4
			public unsafe SerialSequence __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerialSequence._executeSequence_d__2.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SerialSequence>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerialSequence._executeSequence_d__2.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700007D RID: 125
			// (get) Token: 0x06000255 RID: 597 RVA: 0x0000D854 File Offset: 0x0000BA54
			// (set) Token: 0x06000256 RID: 598 RVA: 0x00003013 File Offset: 0x00001213
			public unsafe int _i_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerialSequence._executeSequence_d__2.NativeFieldInfoPtr__i_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerialSequence._executeSequence_d__2.NativeFieldInfoPtr__i_5__2)) = value;
				}
			}

			// Token: 0x1700007E RID: 126
			// (get) Token: 0x06000257 RID: 599 RVA: 0x0000D87C File Offset: 0x0000BA7C
			// (set) Token: 0x06000258 RID: 600 RVA: 0x0000302E File Offset: 0x0000122E
			public unsafe Command _sequenceCommand_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerialSequence._executeSequence_d__2.NativeFieldInfoPtr__sequenceCommand_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Command>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerialSequence._executeSequence_d__2.NativeFieldInfoPtr__sequenceCommand_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000165 RID: 357
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000166 RID: 358
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000167 RID: 359
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000168 RID: 360
			private static readonly IntPtr NativeFieldInfoPtr__i_5__2;

			// Token: 0x04000169 RID: 361
			private static readonly IntPtr NativeFieldInfoPtr__sequenceCommand_5__3;

			// Token: 0x0400016A RID: 362
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400016B RID: 363
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400016C RID: 364
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400016D RID: 365
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400016E RID: 366
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400016F RID: 367
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
