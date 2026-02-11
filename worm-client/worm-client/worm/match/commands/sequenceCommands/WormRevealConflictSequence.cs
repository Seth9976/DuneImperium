using System;
using Canis.utils.ids;
using dwd.core.commands;
using dwd.core.match;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using lotus;

namespace worm.match.commands.sequenceCommands
{
	// Token: 0x0200025D RID: 605
	public class WormRevealConflictSequence : VoodooGroupedSequence
	{
		// Token: 0x06001935 RID: 6453 RVA: 0x00064CD0 File Offset: 0x00062ED0
		// Note: this type is marked as 'beforefieldinit'.
		static WormRevealConflictSequence()
		{
			Il2CppClassPointerStore<WormRevealConflictSequence>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.commands.sequenceCommands", "WormRevealConflictSequence");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormRevealConflictSequence>.NativeClassPtr);
			WormRevealConflictSequence.NativeFieldInfoPtr_NewConflict = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormRevealConflictSequence>.NativeClassPtr, "NewConflict");
			WormRevealConflictSequence.NativeMethodInfoPtr__ctor_Public_Void_SequenceID_String_IList_1_Command_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormRevealConflictSequence>.NativeClassPtr, 100666881);
			WormRevealConflictSequence.NativeMethodInfoPtr_PostLastGroupCommand_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormRevealConflictSequence>.NativeClassPtr, 100666882);
		}

		// Token: 0x06001936 RID: 6454 RVA: 0x00064D3C File Offset: 0x00062F3C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 719323, RefRangeEnd = 719327, XrefRangeStart = 719323, XrefRangeEnd = 719327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormRevealConflictSequence(SequenceID id, string name, IList<Command> sequence)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormRevealConflictSequence>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormRevealConflictSequence.NativeMethodInfoPtr__ctor_Public_Void_SequenceID_String_IList_1_Command_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001937 RID: 6455 RVA: 0x00064DAC File Offset: 0x00062FAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 719837, XrefRangeEnd = 719842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator PostLastGroupCommand()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormRevealConflictSequence.NativeMethodInfoPtr_PostLastGroupCommand_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001938 RID: 6456 RVA: 0x0000EEB8 File Offset: 0x0000D0B8
		public WormRevealConflictSequence(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006EA RID: 1770
		// (get) Token: 0x06001939 RID: 6457 RVA: 0x00064DF8 File Offset: 0x00062FF8
		// (set) Token: 0x0600193A RID: 6458 RVA: 0x0000EEC1 File Offset: 0x0000D0C1
		public unsafe static int NewConflict
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(WormRevealConflictSequence.NativeFieldInfoPtr_NewConflict, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormRevealConflictSequence.NativeFieldInfoPtr_NewConflict, (void*)(&value));
			}
		}

		// Token: 0x04000E87 RID: 3719
		private static readonly IntPtr NativeFieldInfoPtr_NewConflict;

		// Token: 0x04000E88 RID: 3720
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SequenceID_String_IList_1_Command_0;

		// Token: 0x04000E89 RID: 3721
		private static readonly IntPtr NativeMethodInfoPtr_PostLastGroupCommand_Protected_Virtual_IEnumerator_0;

		// Token: 0x0200041B RID: 1051
		[ObfuscatedName("worm.match.commands.sequenceCommands.WormRevealConflictSequence+<PostLastGroupCommand>d__2")]
		public sealed class _PostLastGroupCommand_d__2 : Object
		{
			// Token: 0x06002B6C RID: 11116 RVA: 0x0009BA08 File Offset: 0x00099C08
			// Note: this type is marked as 'beforefieldinit'.
			static _PostLastGroupCommand_d__2()
			{
				Il2CppClassPointerStore<WormRevealConflictSequence._PostLastGroupCommand_d__2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormRevealConflictSequence>.NativeClassPtr, "<PostLastGroupCommand>d__2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormRevealConflictSequence._PostLastGroupCommand_d__2>.NativeClassPtr);
				WormRevealConflictSequence._PostLastGroupCommand_d__2.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormRevealConflictSequence._PostLastGroupCommand_d__2>.NativeClassPtr, "<>1__state");
				WormRevealConflictSequence._PostLastGroupCommand_d__2.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormRevealConflictSequence._PostLastGroupCommand_d__2>.NativeClassPtr, "<>2__current");
				WormRevealConflictSequence._PostLastGroupCommand_d__2.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormRevealConflictSequence._PostLastGroupCommand_d__2>.NativeClassPtr, "<>4__this");
				WormRevealConflictSequence._PostLastGroupCommand_d__2.NativeFieldInfoPtr__entities_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormRevealConflictSequence._PostLastGroupCommand_d__2>.NativeClassPtr, "<entities>5__2");
				WormRevealConflictSequence._PostLastGroupCommand_d__2.NativeFieldInfoPtr__conflicts_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormRevealConflictSequence._PostLastGroupCommand_d__2>.NativeClassPtr, "<conflicts>5__3");
				WormRevealConflictSequence._PostLastGroupCommand_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormRevealConflictSequence._PostLastGroupCommand_d__2>.NativeClassPtr, 100666884);
				WormRevealConflictSequence._PostLastGroupCommand_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormRevealConflictSequence._PostLastGroupCommand_d__2>.NativeClassPtr, 100666885);
				WormRevealConflictSequence._PostLastGroupCommand_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormRevealConflictSequence._PostLastGroupCommand_d__2>.NativeClassPtr, 100666886);
				WormRevealConflictSequence._PostLastGroupCommand_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormRevealConflictSequence._PostLastGroupCommand_d__2>.NativeClassPtr, 100666887);
				WormRevealConflictSequence._PostLastGroupCommand_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormRevealConflictSequence._PostLastGroupCommand_d__2>.NativeClassPtr, 100666888);
				WormRevealConflictSequence._PostLastGroupCommand_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormRevealConflictSequence._PostLastGroupCommand_d__2>.NativeClassPtr, 100666889);
			}

			// Token: 0x06002B6D RID: 11117 RVA: 0x0009BB10 File Offset: 0x00099D10
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _PostLastGroupCommand_d__2(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormRevealConflictSequence._PostLastGroupCommand_d__2>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormRevealConflictSequence._PostLastGroupCommand_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002B6E RID: 11118 RVA: 0x0009BB58 File Offset: 0x00099D58
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormRevealConflictSequence._PostLastGroupCommand_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002B6F RID: 11119 RVA: 0x0009BB8C File Offset: 0x00099D8C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 719756, XrefRangeEnd = 719832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormRevealConflictSequence._PostLastGroupCommand_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000C68 RID: 3176
			// (get) Token: 0x06002B70 RID: 11120 RVA: 0x0009BBC8 File Offset: 0x00099DC8
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormRevealConflictSequence._PostLastGroupCommand_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002B71 RID: 11121 RVA: 0x0009BC08 File Offset: 0x00099E08
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 719832, XrefRangeEnd = 719837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormRevealConflictSequence._PostLastGroupCommand_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000C69 RID: 3177
			// (get) Token: 0x06002B72 RID: 11122 RVA: 0x0009BC3C File Offset: 0x00099E3C
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormRevealConflictSequence._PostLastGroupCommand_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002B73 RID: 11123 RVA: 0x00017AC7 File Offset: 0x00015CC7
			public _PostLastGroupCommand_d__2(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000C63 RID: 3171
			// (get) Token: 0x06002B74 RID: 11124 RVA: 0x0009BC7C File Offset: 0x00099E7C
			// (set) Token: 0x06002B75 RID: 11125 RVA: 0x00017AD0 File Offset: 0x00015CD0
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormRevealConflictSequence._PostLastGroupCommand_d__2.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormRevealConflictSequence._PostLastGroupCommand_d__2.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000C64 RID: 3172
			// (get) Token: 0x06002B76 RID: 11126 RVA: 0x0009BCA4 File Offset: 0x00099EA4
			// (set) Token: 0x06002B77 RID: 11127 RVA: 0x00017AEB File Offset: 0x00015CEB
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormRevealConflictSequence._PostLastGroupCommand_d__2.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormRevealConflictSequence._PostLastGroupCommand_d__2.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000C65 RID: 3173
			// (get) Token: 0x06002B78 RID: 11128 RVA: 0x0009BCD4 File Offset: 0x00099ED4
			// (set) Token: 0x06002B79 RID: 11129 RVA: 0x00017B0A File Offset: 0x00015D0A
			public unsafe WormRevealConflictSequence __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormRevealConflictSequence._PostLastGroupCommand_d__2.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormRevealConflictSequence>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormRevealConflictSequence._PostLastGroupCommand_d__2.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000C66 RID: 3174
			// (get) Token: 0x06002B7A RID: 11130 RVA: 0x0009BD04 File Offset: 0x00099F04
			// (set) Token: 0x06002B7B RID: 11131 RVA: 0x00017B29 File Offset: 0x00015D29
			public unsafe Entities _entities_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormRevealConflictSequence._PostLastGroupCommand_d__2.NativeFieldInfoPtr__entities_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Entities>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormRevealConflictSequence._PostLastGroupCommand_d__2.NativeFieldInfoPtr__entities_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000C67 RID: 3175
			// (get) Token: 0x06002B7C RID: 11132 RVA: 0x0009BD34 File Offset: 0x00099F34
			// (set) Token: 0x06002B7D RID: 11133 RVA: 0x00017B48 File Offset: 0x00015D48
			public unsafe ReadOnlyVersionedList<EntityComponent> _conflicts_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormRevealConflictSequence._PostLastGroupCommand_d__2.NativeFieldInfoPtr__conflicts_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReadOnlyVersionedList<EntityComponent>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormRevealConflictSequence._PostLastGroupCommand_d__2.NativeFieldInfoPtr__conflicts_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001939 RID: 6457
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400193A RID: 6458
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400193B RID: 6459
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400193C RID: 6460
			private static readonly IntPtr NativeFieldInfoPtr__entities_5__2;

			// Token: 0x0400193D RID: 6461
			private static readonly IntPtr NativeFieldInfoPtr__conflicts_5__3;

			// Token: 0x0400193E RID: 6462
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400193F RID: 6463
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001940 RID: 6464
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001941 RID: 6465
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001942 RID: 6466
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001943 RID: 6467
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
