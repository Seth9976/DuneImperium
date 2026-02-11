using System;
using Canis.utils.ids;
using dwd.core.commands;
using dwd.core.match.sequence.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using zen.src.match.sequences.zenCommands;

namespace zen.src.match.sequences
{
	// Token: 0x02000064 RID: 100
	public class VoodooSequence : SequenceCommand
	{
		// Token: 0x06000530 RID: 1328 RVA: 0x00020458 File Offset: 0x0001E658
		// Note: this type is marked as 'beforefieldinit'.
		static VoodooSequence()
		{
			Il2CppClassPointerStore<VoodooSequence>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "zen.src.match.sequences", "VoodooSequence");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VoodooSequence>.NativeClassPtr);
			VoodooSequence.NativeMethodInfoPtr__ctor_Protected_Void_SequenceID_String_IList_1_Command_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooSequence>.NativeClassPtr, 100664028);
			VoodooSequence.NativeMethodInfoPtr_build_Protected_Abstract_Virtual_New_Void_SequenceBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooSequence>.NativeClassPtr, 100664029);
			VoodooSequence.NativeMethodInfoPtr_executeSequence_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooSequence>.NativeClassPtr, 100664030);
		}

		// Token: 0x06000531 RID: 1329 RVA: 0x000204C4 File Offset: 0x0001E6C4
		[CallerCount(39)]
		[CachedScanResults(RefRangeStart = 719643, RefRangeEnd = 719682, XrefRangeStart = 719643, XrefRangeEnd = 719682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VoodooSequence(SequenceID id, string name, IList<Command> sequence)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VoodooSequence>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooSequence.NativeMethodInfoPtr__ctor_Protected_Void_SequenceID_String_IList_1_Command_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000532 RID: 1330 RVA: 0x00020534 File Offset: 0x0001E734
		[CallerCount(0)]
		public unsafe virtual void build(SequenceBuilder sequence)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sequence);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VoodooSequence.NativeMethodInfoPtr_build_Protected_Abstract_Virtual_New_Void_SequenceBuilder_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000533 RID: 1331 RVA: 0x00020584 File Offset: 0x0001E784
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 986814, XrefRangeEnd = 986819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator executeSequence()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VoodooSequence.NativeMethodInfoPtr_executeSequence_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000534 RID: 1332 RVA: 0x000046BF File Offset: 0x000028BF
		public VoodooSequence(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000320 RID: 800
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SequenceID_String_IList_1_Command_0;

		// Token: 0x04000321 RID: 801
		private static readonly IntPtr NativeMethodInfoPtr_build_Protected_Abstract_Virtual_New_Void_SequenceBuilder_0;

		// Token: 0x04000322 RID: 802
		private static readonly IntPtr NativeMethodInfoPtr_executeSequence_Protected_Virtual_IEnumerator_0;

		// Token: 0x020001D3 RID: 467
		[ObfuscatedName("zen.src.match.sequences.VoodooSequence+<executeSequence>d__2")]
		public sealed class _executeSequence_d__2 : Object
		{
			// Token: 0x06001636 RID: 5686 RVA: 0x00055A34 File Offset: 0x00053C34
			// Note: this type is marked as 'beforefieldinit'.
			static _executeSequence_d__2()
			{
				Il2CppClassPointerStore<VoodooSequence._executeSequence_d__2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VoodooSequence>.NativeClassPtr, "<executeSequence>d__2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VoodooSequence._executeSequence_d__2>.NativeClassPtr);
				VoodooSequence._executeSequence_d__2.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooSequence._executeSequence_d__2>.NativeClassPtr, "<>1__state");
				VoodooSequence._executeSequence_d__2.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooSequence._executeSequence_d__2>.NativeClassPtr, "<>2__current");
				VoodooSequence._executeSequence_d__2.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooSequence._executeSequence_d__2>.NativeClassPtr, "<>4__this");
				VoodooSequence._executeSequence_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooSequence._executeSequence_d__2>.NativeClassPtr, 100664031);
				VoodooSequence._executeSequence_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooSequence._executeSequence_d__2>.NativeClassPtr, 100664032);
				VoodooSequence._executeSequence_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooSequence._executeSequence_d__2>.NativeClassPtr, 100664033);
				VoodooSequence._executeSequence_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooSequence._executeSequence_d__2>.NativeClassPtr, 100664034);
				VoodooSequence._executeSequence_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooSequence._executeSequence_d__2>.NativeClassPtr, 100664035);
				VoodooSequence._executeSequence_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooSequence._executeSequence_d__2>.NativeClassPtr, 100664036);
			}

			// Token: 0x06001637 RID: 5687 RVA: 0x00055B14 File Offset: 0x00053D14
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _executeSequence_d__2(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VoodooSequence._executeSequence_d__2>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooSequence._executeSequence_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001638 RID: 5688 RVA: 0x00055B5C File Offset: 0x00053D5C
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooSequence._executeSequence_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001639 RID: 5689 RVA: 0x00055B90 File Offset: 0x00053D90
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 986779, XrefRangeEnd = 986809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooSequence._executeSequence_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000666 RID: 1638
			// (get) Token: 0x0600163A RID: 5690 RVA: 0x00055BCC File Offset: 0x00053DCC
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooSequence._executeSequence_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600163B RID: 5691 RVA: 0x00055C0C File Offset: 0x00053E0C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 986809, XrefRangeEnd = 986814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooSequence._executeSequence_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000667 RID: 1639
			// (get) Token: 0x0600163C RID: 5692 RVA: 0x00055C40 File Offset: 0x00053E40
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooSequence._executeSequence_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600163D RID: 5693 RVA: 0x0000C620 File Offset: 0x0000A820
			public _executeSequence_d__2(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000663 RID: 1635
			// (get) Token: 0x0600163E RID: 5694 RVA: 0x00055C80 File Offset: 0x00053E80
			// (set) Token: 0x0600163F RID: 5695 RVA: 0x0000C629 File Offset: 0x0000A829
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooSequence._executeSequence_d__2.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooSequence._executeSequence_d__2.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000664 RID: 1636
			// (get) Token: 0x06001640 RID: 5696 RVA: 0x00055CA8 File Offset: 0x00053EA8
			// (set) Token: 0x06001641 RID: 5697 RVA: 0x0000C644 File Offset: 0x0000A844
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooSequence._executeSequence_d__2.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooSequence._executeSequence_d__2.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000665 RID: 1637
			// (get) Token: 0x06001642 RID: 5698 RVA: 0x00055CD8 File Offset: 0x00053ED8
			// (set) Token: 0x06001643 RID: 5699 RVA: 0x0000C663 File Offset: 0x0000A863
			public unsafe VoodooSequence __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooSequence._executeSequence_d__2.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<VoodooSequence>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooSequence._executeSequence_d__2.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000D7B RID: 3451
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000D7C RID: 3452
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000D7D RID: 3453
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000D7E RID: 3454
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000D7F RID: 3455
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000D80 RID: 3456
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000D81 RID: 3457
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000D82 RID: 3458
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000D83 RID: 3459
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
