using System;
using Canis.utils.ids;
using dwd.core.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using lotus;

namespace worm.match.commands.sequenceCommands
{
	// Token: 0x0200025E RID: 606
	public class WormShippingTrackSequence : VoodooGroupedSequence
	{
		// Token: 0x0600193B RID: 6459 RVA: 0x00064E14 File Offset: 0x00063014
		// Note: this type is marked as 'beforefieldinit'.
		static WormShippingTrackSequence()
		{
			Il2CppClassPointerStore<WormShippingTrackSequence>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.commands.sequenceCommands", "WormShippingTrackSequence");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormShippingTrackSequence>.NativeClassPtr);
			WormShippingTrackSequence.NativeFieldInfoPtr_PlayerColorParam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormShippingTrackSequence>.NativeClassPtr, "PlayerColorParam");
			WormShippingTrackSequence.NativeMethodInfoPtr__ctor_Public_Void_SequenceID_String_IList_1_Command_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormShippingTrackSequence>.NativeClassPtr, 100666890);
			WormShippingTrackSequence.NativeMethodInfoPtr_PreSequence_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormShippingTrackSequence>.NativeClassPtr, 100666891);
		}

		// Token: 0x0600193C RID: 6460 RVA: 0x00064E80 File Offset: 0x00063080
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 719323, RefRangeEnd = 719327, XrefRangeStart = 719323, XrefRangeEnd = 719327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormShippingTrackSequence(SequenceID id, string name, IList<Command> sequence)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormShippingTrackSequence>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormShippingTrackSequence.NativeMethodInfoPtr__ctor_Public_Void_SequenceID_String_IList_1_Command_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600193D RID: 6461 RVA: 0x00064EF0 File Offset: 0x000630F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 719982, XrefRangeEnd = 719987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator PreSequence()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormShippingTrackSequence.NativeMethodInfoPtr_PreSequence_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600193E RID: 6462 RVA: 0x0000EECF File Offset: 0x0000D0CF
		public WormShippingTrackSequence(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006EB RID: 1771
		// (get) Token: 0x0600193F RID: 6463 RVA: 0x00064F3C File Offset: 0x0006313C
		// (set) Token: 0x06001940 RID: 6464 RVA: 0x0000EED8 File Offset: 0x0000D0D8
		public unsafe static int PlayerColorParam
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(WormShippingTrackSequence.NativeFieldInfoPtr_PlayerColorParam, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormShippingTrackSequence.NativeFieldInfoPtr_PlayerColorParam, (void*)(&value));
			}
		}

		// Token: 0x04000E8A RID: 3722
		private static readonly IntPtr NativeFieldInfoPtr_PlayerColorParam;

		// Token: 0x04000E8B RID: 3723
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SequenceID_String_IList_1_Command_0;

		// Token: 0x04000E8C RID: 3724
		private static readonly IntPtr NativeMethodInfoPtr_PreSequence_Protected_Virtual_IEnumerator_0;

		// Token: 0x0200041C RID: 1052
		[ObfuscatedName("worm.match.commands.sequenceCommands.WormShippingTrackSequence+<PreSequence>d__2")]
		public sealed class _PreSequence_d__2 : Object
		{
			// Token: 0x06002B7E RID: 11134 RVA: 0x0009BD64 File Offset: 0x00099F64
			// Note: this type is marked as 'beforefieldinit'.
			static _PreSequence_d__2()
			{
				Il2CppClassPointerStore<WormShippingTrackSequence._PreSequence_d__2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormShippingTrackSequence>.NativeClassPtr, "<PreSequence>d__2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormShippingTrackSequence._PreSequence_d__2>.NativeClassPtr);
				WormShippingTrackSequence._PreSequence_d__2.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormShippingTrackSequence._PreSequence_d__2>.NativeClassPtr, "<>1__state");
				WormShippingTrackSequence._PreSequence_d__2.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormShippingTrackSequence._PreSequence_d__2>.NativeClassPtr, "<>2__current");
				WormShippingTrackSequence._PreSequence_d__2.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormShippingTrackSequence._PreSequence_d__2>.NativeClassPtr, "<>4__this");
				WormShippingTrackSequence._PreSequence_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormShippingTrackSequence._PreSequence_d__2>.NativeClassPtr, 100666893);
				WormShippingTrackSequence._PreSequence_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormShippingTrackSequence._PreSequence_d__2>.NativeClassPtr, 100666894);
				WormShippingTrackSequence._PreSequence_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormShippingTrackSequence._PreSequence_d__2>.NativeClassPtr, 100666895);
				WormShippingTrackSequence._PreSequence_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormShippingTrackSequence._PreSequence_d__2>.NativeClassPtr, 100666896);
				WormShippingTrackSequence._PreSequence_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormShippingTrackSequence._PreSequence_d__2>.NativeClassPtr, 100666897);
				WormShippingTrackSequence._PreSequence_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormShippingTrackSequence._PreSequence_d__2>.NativeClassPtr, 100666898);
			}

			// Token: 0x06002B7F RID: 11135 RVA: 0x0009BE44 File Offset: 0x0009A044
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _PreSequence_d__2(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormShippingTrackSequence._PreSequence_d__2>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormShippingTrackSequence._PreSequence_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002B80 RID: 11136 RVA: 0x0009BE8C File Offset: 0x0009A08C
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormShippingTrackSequence._PreSequence_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002B81 RID: 11137 RVA: 0x0009BEC0 File Offset: 0x0009A0C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 719842, XrefRangeEnd = 719977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormShippingTrackSequence._PreSequence_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000C6D RID: 3181
			// (get) Token: 0x06002B82 RID: 11138 RVA: 0x0009BEFC File Offset: 0x0009A0FC
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormShippingTrackSequence._PreSequence_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002B83 RID: 11139 RVA: 0x0009BF3C File Offset: 0x0009A13C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 719977, XrefRangeEnd = 719982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormShippingTrackSequence._PreSequence_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000C6E RID: 3182
			// (get) Token: 0x06002B84 RID: 11140 RVA: 0x0009BF70 File Offset: 0x0009A170
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormShippingTrackSequence._PreSequence_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002B85 RID: 11141 RVA: 0x00017B67 File Offset: 0x00015D67
			public _PreSequence_d__2(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000C6A RID: 3178
			// (get) Token: 0x06002B86 RID: 11142 RVA: 0x0009BFB0 File Offset: 0x0009A1B0
			// (set) Token: 0x06002B87 RID: 11143 RVA: 0x00017B70 File Offset: 0x00015D70
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormShippingTrackSequence._PreSequence_d__2.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormShippingTrackSequence._PreSequence_d__2.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000C6B RID: 3179
			// (get) Token: 0x06002B88 RID: 11144 RVA: 0x0009BFD8 File Offset: 0x0009A1D8
			// (set) Token: 0x06002B89 RID: 11145 RVA: 0x00017B8B File Offset: 0x00015D8B
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormShippingTrackSequence._PreSequence_d__2.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormShippingTrackSequence._PreSequence_d__2.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000C6C RID: 3180
			// (get) Token: 0x06002B8A RID: 11146 RVA: 0x0009C008 File Offset: 0x0009A208
			// (set) Token: 0x06002B8B RID: 11147 RVA: 0x00017BAA File Offset: 0x00015DAA
			public unsafe WormShippingTrackSequence __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormShippingTrackSequence._PreSequence_d__2.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormShippingTrackSequence>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormShippingTrackSequence._PreSequence_d__2.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001944 RID: 6468
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001945 RID: 6469
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001946 RID: 6470
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001947 RID: 6471
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001948 RID: 6472
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001949 RID: 6473
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400194A RID: 6474
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400194B RID: 6475
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400194C RID: 6476
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
