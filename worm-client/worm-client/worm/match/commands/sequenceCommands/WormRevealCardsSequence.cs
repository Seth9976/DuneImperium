using System;
using Canis.utils.ids;
using dwd.core.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace worm.match.commands.sequenceCommands
{
	// Token: 0x0200025C RID: 604
	public class WormRevealCardsSequence : WormStingerSequence
	{
		// Token: 0x06001931 RID: 6449 RVA: 0x00064BBC File Offset: 0x00062DBC
		// Note: this type is marked as 'beforefieldinit'.
		static WormRevealCardsSequence()
		{
			Il2CppClassPointerStore<WormRevealCardsSequence>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.commands.sequenceCommands", "WormRevealCardsSequence");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormRevealCardsSequence>.NativeClassPtr);
			WormRevealCardsSequence.NativeMethodInfoPtr__ctor_Public_Void_SequenceID_String_IList_1_Command_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormRevealCardsSequence>.NativeClassPtr, 100666873);
			WormRevealCardsSequence.NativeMethodInfoPtr_PreSequence_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormRevealCardsSequence>.NativeClassPtr, 100666874);
		}

		// Token: 0x06001932 RID: 6450 RVA: 0x00064C14 File Offset: 0x00062E14
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 719323, RefRangeEnd = 719327, XrefRangeStart = 719323, XrefRangeEnd = 719327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormRevealCardsSequence(SequenceID id, string name, IList<Command> sequence)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormRevealCardsSequence>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormRevealCardsSequence.NativeMethodInfoPtr__ctor_Public_Void_SequenceID_String_IList_1_Command_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001933 RID: 6451 RVA: 0x00064C84 File Offset: 0x00062E84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 719751, XrefRangeEnd = 719756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator PreSequence()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormRevealCardsSequence.NativeMethodInfoPtr_PreSequence_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001934 RID: 6452 RVA: 0x0000EEAF File Offset: 0x0000D0AF
		public WormRevealCardsSequence(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000E85 RID: 3717
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SequenceID_String_IList_1_Command_0;

		// Token: 0x04000E86 RID: 3718
		private static readonly IntPtr NativeMethodInfoPtr_PreSequence_Protected_Virtual_IEnumerator_0;

		// Token: 0x0200041A RID: 1050
		[ObfuscatedName("worm.match.commands.sequenceCommands.WormRevealCardsSequence+<PreSequence>d__1")]
		public sealed class _PreSequence_d__1 : Object
		{
			// Token: 0x06002B5E RID: 11102 RVA: 0x0009B734 File Offset: 0x00099934
			// Note: this type is marked as 'beforefieldinit'.
			static _PreSequence_d__1()
			{
				Il2CppClassPointerStore<WormRevealCardsSequence._PreSequence_d__1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormRevealCardsSequence>.NativeClassPtr, "<PreSequence>d__1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormRevealCardsSequence._PreSequence_d__1>.NativeClassPtr);
				WormRevealCardsSequence._PreSequence_d__1.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormRevealCardsSequence._PreSequence_d__1>.NativeClassPtr, "<>1__state");
				WormRevealCardsSequence._PreSequence_d__1.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormRevealCardsSequence._PreSequence_d__1>.NativeClassPtr, "<>2__current");
				WormRevealCardsSequence._PreSequence_d__1.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormRevealCardsSequence._PreSequence_d__1>.NativeClassPtr, "<>4__this");
				WormRevealCardsSequence._PreSequence_d__1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormRevealCardsSequence._PreSequence_d__1>.NativeClassPtr, 100666875);
				WormRevealCardsSequence._PreSequence_d__1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormRevealCardsSequence._PreSequence_d__1>.NativeClassPtr, 100666876);
				WormRevealCardsSequence._PreSequence_d__1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormRevealCardsSequence._PreSequence_d__1>.NativeClassPtr, 100666877);
				WormRevealCardsSequence._PreSequence_d__1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormRevealCardsSequence._PreSequence_d__1>.NativeClassPtr, 100666878);
				WormRevealCardsSequence._PreSequence_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormRevealCardsSequence._PreSequence_d__1>.NativeClassPtr, 100666879);
				WormRevealCardsSequence._PreSequence_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormRevealCardsSequence._PreSequence_d__1>.NativeClassPtr, 100666880);
			}

			// Token: 0x06002B5F RID: 11103 RVA: 0x0009B814 File Offset: 0x00099A14
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _PreSequence_d__1(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormRevealCardsSequence._PreSequence_d__1>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormRevealCardsSequence._PreSequence_d__1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002B60 RID: 11104 RVA: 0x0009B85C File Offset: 0x00099A5C
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormRevealCardsSequence._PreSequence_d__1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002B61 RID: 11105 RVA: 0x0009B890 File Offset: 0x00099A90
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 719709, XrefRangeEnd = 719746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormRevealCardsSequence._PreSequence_d__1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000C61 RID: 3169
			// (get) Token: 0x06002B62 RID: 11106 RVA: 0x0009B8CC File Offset: 0x00099ACC
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormRevealCardsSequence._PreSequence_d__1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002B63 RID: 11107 RVA: 0x0009B90C File Offset: 0x00099B0C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 719746, XrefRangeEnd = 719751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormRevealCardsSequence._PreSequence_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000C62 RID: 3170
			// (get) Token: 0x06002B64 RID: 11108 RVA: 0x0009B940 File Offset: 0x00099B40
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormRevealCardsSequence._PreSequence_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002B65 RID: 11109 RVA: 0x00017A65 File Offset: 0x00015C65
			public _PreSequence_d__1(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000C5E RID: 3166
			// (get) Token: 0x06002B66 RID: 11110 RVA: 0x0009B980 File Offset: 0x00099B80
			// (set) Token: 0x06002B67 RID: 11111 RVA: 0x00017A6E File Offset: 0x00015C6E
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormRevealCardsSequence._PreSequence_d__1.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormRevealCardsSequence._PreSequence_d__1.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000C5F RID: 3167
			// (get) Token: 0x06002B68 RID: 11112 RVA: 0x0009B9A8 File Offset: 0x00099BA8
			// (set) Token: 0x06002B69 RID: 11113 RVA: 0x00017A89 File Offset: 0x00015C89
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormRevealCardsSequence._PreSequence_d__1.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormRevealCardsSequence._PreSequence_d__1.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000C60 RID: 3168
			// (get) Token: 0x06002B6A RID: 11114 RVA: 0x0009B9D8 File Offset: 0x00099BD8
			// (set) Token: 0x06002B6B RID: 11115 RVA: 0x00017AA8 File Offset: 0x00015CA8
			public unsafe WormRevealCardsSequence __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormRevealCardsSequence._PreSequence_d__1.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormRevealCardsSequence>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormRevealCardsSequence._PreSequence_d__1.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001930 RID: 6448
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001931 RID: 6449
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001932 RID: 6450
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001933 RID: 6451
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001934 RID: 6452
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001935 RID: 6453
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001936 RID: 6454
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001937 RID: 6455
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001938 RID: 6456
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
