using System;
using dwd.core.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace zen.src.match.sequences.zenCommands
{
	// Token: 0x02000065 RID: 101
	public class ParseAndRunParallelCommand : ParseAndRunSequenceCommand
	{
		// Token: 0x06000535 RID: 1333 RVA: 0x000205D0 File Offset: 0x0001E7D0
		// Note: this type is marked as 'beforefieldinit'.
		static ParseAndRunParallelCommand()
		{
			Il2CppClassPointerStore<ParseAndRunParallelCommand>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "zen.src.match.sequences.zenCommands", "ParseAndRunParallelCommand");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParseAndRunParallelCommand>.NativeClassPtr);
			ParseAndRunParallelCommand.NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_Command_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParseAndRunParallelCommand>.NativeClassPtr, 100664037);
			ParseAndRunParallelCommand.NativeMethodInfoPtr_executeGroupMoves_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParseAndRunParallelCommand>.NativeClassPtr, 100664038);
		}

		// Token: 0x06000536 RID: 1334 RVA: 0x00020628 File Offset: 0x0001E828
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 986830, XrefRangeEnd = 986831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ParseAndRunParallelCommand(IEnumerable<Command> sequence, string sn)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParseAndRunParallelCommand>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sequence);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(sn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParseAndRunParallelCommand.NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_Command_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000537 RID: 1335 RVA: 0x00020688 File Offset: 0x0001E888
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 986831, XrefRangeEnd = 986836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator executeGroupMoves()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ParseAndRunParallelCommand.NativeMethodInfoPtr_executeGroupMoves_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000538 RID: 1336 RVA: 0x000046C8 File Offset: 0x000028C8
		public ParseAndRunParallelCommand(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000323 RID: 803
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_Command_String_0;

		// Token: 0x04000324 RID: 804
		private static readonly IntPtr NativeMethodInfoPtr_executeGroupMoves_Protected_Virtual_IEnumerator_0;

		// Token: 0x020001D4 RID: 468
		[ObfuscatedName("zen.src.match.sequences.zenCommands.ParseAndRunParallelCommand+<executeGroupMoves>d__1")]
		public sealed class _executeGroupMoves_d__1 : Object
		{
			// Token: 0x06001644 RID: 5700 RVA: 0x00055D08 File Offset: 0x00053F08
			// Note: this type is marked as 'beforefieldinit'.
			static _executeGroupMoves_d__1()
			{
				Il2CppClassPointerStore<ParseAndRunParallelCommand._executeGroupMoves_d__1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ParseAndRunParallelCommand>.NativeClassPtr, "<executeGroupMoves>d__1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParseAndRunParallelCommand._executeGroupMoves_d__1>.NativeClassPtr);
				ParseAndRunParallelCommand._executeGroupMoves_d__1.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParseAndRunParallelCommand._executeGroupMoves_d__1>.NativeClassPtr, "<>1__state");
				ParseAndRunParallelCommand._executeGroupMoves_d__1.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParseAndRunParallelCommand._executeGroupMoves_d__1>.NativeClassPtr, "<>2__current");
				ParseAndRunParallelCommand._executeGroupMoves_d__1.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParseAndRunParallelCommand._executeGroupMoves_d__1>.NativeClassPtr, "<>4__this");
				ParseAndRunParallelCommand._executeGroupMoves_d__1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParseAndRunParallelCommand._executeGroupMoves_d__1>.NativeClassPtr, 100664039);
				ParseAndRunParallelCommand._executeGroupMoves_d__1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParseAndRunParallelCommand._executeGroupMoves_d__1>.NativeClassPtr, 100664040);
				ParseAndRunParallelCommand._executeGroupMoves_d__1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParseAndRunParallelCommand._executeGroupMoves_d__1>.NativeClassPtr, 100664041);
				ParseAndRunParallelCommand._executeGroupMoves_d__1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParseAndRunParallelCommand._executeGroupMoves_d__1>.NativeClassPtr, 100664042);
				ParseAndRunParallelCommand._executeGroupMoves_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParseAndRunParallelCommand._executeGroupMoves_d__1>.NativeClassPtr, 100664043);
				ParseAndRunParallelCommand._executeGroupMoves_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParseAndRunParallelCommand._executeGroupMoves_d__1>.NativeClassPtr, 100664044);
			}

			// Token: 0x06001645 RID: 5701 RVA: 0x00055DE8 File Offset: 0x00053FE8
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _executeGroupMoves_d__1(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParseAndRunParallelCommand._executeGroupMoves_d__1>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParseAndRunParallelCommand._executeGroupMoves_d__1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001646 RID: 5702 RVA: 0x00055E30 File Offset: 0x00054030
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParseAndRunParallelCommand._executeGroupMoves_d__1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001647 RID: 5703 RVA: 0x00055E64 File Offset: 0x00054064
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 986819, XrefRangeEnd = 986825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParseAndRunParallelCommand._executeGroupMoves_d__1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700066B RID: 1643
			// (get) Token: 0x06001648 RID: 5704 RVA: 0x00055EA0 File Offset: 0x000540A0
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParseAndRunParallelCommand._executeGroupMoves_d__1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001649 RID: 5705 RVA: 0x00055EE0 File Offset: 0x000540E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 986825, XrefRangeEnd = 986830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParseAndRunParallelCommand._executeGroupMoves_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700066C RID: 1644
			// (get) Token: 0x0600164A RID: 5706 RVA: 0x00055F14 File Offset: 0x00054114
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParseAndRunParallelCommand._executeGroupMoves_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600164B RID: 5707 RVA: 0x0000C682 File Offset: 0x0000A882
			public _executeGroupMoves_d__1(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000668 RID: 1640
			// (get) Token: 0x0600164C RID: 5708 RVA: 0x00055F54 File Offset: 0x00054154
			// (set) Token: 0x0600164D RID: 5709 RVA: 0x0000C68B File Offset: 0x0000A88B
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseAndRunParallelCommand._executeGroupMoves_d__1.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseAndRunParallelCommand._executeGroupMoves_d__1.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000669 RID: 1641
			// (get) Token: 0x0600164E RID: 5710 RVA: 0x00055F7C File Offset: 0x0005417C
			// (set) Token: 0x0600164F RID: 5711 RVA: 0x0000C6A6 File Offset: 0x0000A8A6
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseAndRunParallelCommand._executeGroupMoves_d__1.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseAndRunParallelCommand._executeGroupMoves_d__1.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700066A RID: 1642
			// (get) Token: 0x06001650 RID: 5712 RVA: 0x00055FAC File Offset: 0x000541AC
			// (set) Token: 0x06001651 RID: 5713 RVA: 0x0000C6C5 File Offset: 0x0000A8C5
			public unsafe ParseAndRunParallelCommand __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseAndRunParallelCommand._executeGroupMoves_d__1.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParseAndRunParallelCommand>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseAndRunParallelCommand._executeGroupMoves_d__1.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000D84 RID: 3460
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000D85 RID: 3461
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000D86 RID: 3462
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000D87 RID: 3463
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000D88 RID: 3464
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000D89 RID: 3465
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000D8A RID: 3466
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000D8B RID: 3467
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000D8C RID: 3468
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
