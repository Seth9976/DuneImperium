using System;
using Canis.utils.ids;
using dwd.core.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using zen.src.match.sequences;
using zen.src.match.sequences.zenCommands;

namespace lib.canis.boardgames.src.match.sequences
{
	// Token: 0x0200003C RID: 60
	public class GeneralEventAndSaveSequence : VoodooSequence
	{
		// Token: 0x06000277 RID: 631 RVA: 0x00018F88 File Offset: 0x00017188
		// Note: this type is marked as 'beforefieldinit'.
		static GeneralEventAndSaveSequence()
		{
			Il2CppClassPointerStore<GeneralEventAndSaveSequence>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "lib.canis.boardgames.src.match.sequences", "GeneralEventAndSaveSequence");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GeneralEventAndSaveSequence>.NativeClassPtr);
			GeneralEventAndSaveSequence.NativeMethodInfoPtr__ctor_Public_Void_SequenceID_String_IList_1_Command_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneralEventAndSaveSequence>.NativeClassPtr, 100663746);
			GeneralEventAndSaveSequence.NativeMethodInfoPtr_build_Protected_Virtual_Void_SequenceBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneralEventAndSaveSequence>.NativeClassPtr, 100663747);
			GeneralEventAndSaveSequence.NativeMethodInfoPtr_executeSequence_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneralEventAndSaveSequence>.NativeClassPtr, 100663748);
		}

		// Token: 0x06000278 RID: 632 RVA: 0x00018FF4 File Offset: 0x000171F4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 719323, RefRangeEnd = 719327, XrefRangeStart = 719323, XrefRangeEnd = 719327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GeneralEventAndSaveSequence(SequenceID id, string name, IList<Command> sequence)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GeneralEventAndSaveSequence>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneralEventAndSaveSequence.NativeMethodInfoPtr__ctor_Public_Void_SequenceID_String_IList_1_Command_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000279 RID: 633 RVA: 0x00019064 File Offset: 0x00017264
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void build(SequenceBuilder sequence)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sequence);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GeneralEventAndSaveSequence.NativeMethodInfoPtr_build_Protected_Virtual_Void_SequenceBuilder_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600027A RID: 634 RVA: 0x000190B4 File Offset: 0x000172B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 985005, XrefRangeEnd = 985010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator executeSequence()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GeneralEventAndSaveSequence.NativeMethodInfoPtr_executeSequence_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600027B RID: 635 RVA: 0x000030B9 File Offset: 0x000012B9
		public GeneralEventAndSaveSequence(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400019C RID: 412
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SequenceID_String_IList_1_Command_0;

		// Token: 0x0400019D RID: 413
		private static readonly IntPtr NativeMethodInfoPtr_build_Protected_Virtual_Void_SequenceBuilder_0;

		// Token: 0x0400019E RID: 414
		private static readonly IntPtr NativeMethodInfoPtr_executeSequence_Protected_Virtual_IEnumerator_0;

		// Token: 0x020001B4 RID: 436
		[ObfuscatedName("lib.canis.boardgames.src.match.sequences.GeneralEventAndSaveSequence+<executeSequence>d__2")]
		public new sealed class _executeSequence_d__2 : Object
		{
			// Token: 0x060014FD RID: 5373 RVA: 0x00051B88 File Offset: 0x0004FD88
			// Note: this type is marked as 'beforefieldinit'.
			static _executeSequence_d__2()
			{
				Il2CppClassPointerStore<GeneralEventAndSaveSequence._executeSequence_d__2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GeneralEventAndSaveSequence>.NativeClassPtr, "<executeSequence>d__2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GeneralEventAndSaveSequence._executeSequence_d__2>.NativeClassPtr);
				GeneralEventAndSaveSequence._executeSequence_d__2.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeneralEventAndSaveSequence._executeSequence_d__2>.NativeClassPtr, "<>1__state");
				GeneralEventAndSaveSequence._executeSequence_d__2.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeneralEventAndSaveSequence._executeSequence_d__2>.NativeClassPtr, "<>2__current");
				GeneralEventAndSaveSequence._executeSequence_d__2.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeneralEventAndSaveSequence._executeSequence_d__2>.NativeClassPtr, "<>4__this");
				GeneralEventAndSaveSequence._executeSequence_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneralEventAndSaveSequence._executeSequence_d__2>.NativeClassPtr, 100663749);
				GeneralEventAndSaveSequence._executeSequence_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneralEventAndSaveSequence._executeSequence_d__2>.NativeClassPtr, 100663750);
				GeneralEventAndSaveSequence._executeSequence_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneralEventAndSaveSequence._executeSequence_d__2>.NativeClassPtr, 100663751);
				GeneralEventAndSaveSequence._executeSequence_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneralEventAndSaveSequence._executeSequence_d__2>.NativeClassPtr, 100663752);
				GeneralEventAndSaveSequence._executeSequence_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneralEventAndSaveSequence._executeSequence_d__2>.NativeClassPtr, 100663753);
				GeneralEventAndSaveSequence._executeSequence_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneralEventAndSaveSequence._executeSequence_d__2>.NativeClassPtr, 100663754);
			}

			// Token: 0x060014FE RID: 5374 RVA: 0x00051C68 File Offset: 0x0004FE68
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _executeSequence_d__2(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GeneralEventAndSaveSequence._executeSequence_d__2>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneralEventAndSaveSequence._executeSequence_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060014FF RID: 5375 RVA: 0x00051CB0 File Offset: 0x0004FEB0
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneralEventAndSaveSequence._executeSequence_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001500 RID: 5376 RVA: 0x00051CE4 File Offset: 0x0004FEE4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 984955, XrefRangeEnd = 985000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneralEventAndSaveSequence._executeSequence_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170005FC RID: 1532
			// (get) Token: 0x06001501 RID: 5377 RVA: 0x00051D20 File Offset: 0x0004FF20
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneralEventAndSaveSequence._executeSequence_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001502 RID: 5378 RVA: 0x00051D60 File Offset: 0x0004FF60
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 985000, XrefRangeEnd = 985005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneralEventAndSaveSequence._executeSequence_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170005FD RID: 1533
			// (get) Token: 0x06001503 RID: 5379 RVA: 0x00051D94 File Offset: 0x0004FF94
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneralEventAndSaveSequence._executeSequence_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001504 RID: 5380 RVA: 0x0000BD4E File Offset: 0x00009F4E
			public _executeSequence_d__2(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170005F9 RID: 1529
			// (get) Token: 0x06001505 RID: 5381 RVA: 0x00051DD4 File Offset: 0x0004FFD4
			// (set) Token: 0x06001506 RID: 5382 RVA: 0x0000BD57 File Offset: 0x00009F57
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralEventAndSaveSequence._executeSequence_d__2.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralEventAndSaveSequence._executeSequence_d__2.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170005FA RID: 1530
			// (get) Token: 0x06001507 RID: 5383 RVA: 0x00051DFC File Offset: 0x0004FFFC
			// (set) Token: 0x06001508 RID: 5384 RVA: 0x0000BD72 File Offset: 0x00009F72
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralEventAndSaveSequence._executeSequence_d__2.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralEventAndSaveSequence._executeSequence_d__2.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170005FB RID: 1531
			// (get) Token: 0x06001509 RID: 5385 RVA: 0x00051E2C File Offset: 0x0005002C
			// (set) Token: 0x0600150A RID: 5386 RVA: 0x0000BD91 File Offset: 0x00009F91
			public unsafe GeneralEventAndSaveSequence __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralEventAndSaveSequence._executeSequence_d__2.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GeneralEventAndSaveSequence>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralEventAndSaveSequence._executeSequence_d__2.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000CB6 RID: 3254
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000CB7 RID: 3255
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000CB8 RID: 3256
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000CB9 RID: 3257
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000CBA RID: 3258
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000CBB RID: 3259
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000CBC RID: 3260
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000CBD RID: 3261
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000CBE RID: 3262
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
