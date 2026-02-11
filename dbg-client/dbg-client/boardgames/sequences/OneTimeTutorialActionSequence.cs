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

namespace boardgames.sequences
{
	// Token: 0x020000F8 RID: 248
	public class OneTimeTutorialActionSequence : VoodooGenericSequence
	{
		// Token: 0x06000AA1 RID: 2721 RVA: 0x0003F35C File Offset: 0x0003D55C
		// Note: this type is marked as 'beforefieldinit'.
		static OneTimeTutorialActionSequence()
		{
			Il2CppClassPointerStore<OneTimeTutorialActionSequence>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.sequences", "OneTimeTutorialActionSequence");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OneTimeTutorialActionSequence>.NativeClassPtr);
			OneTimeTutorialActionSequence.NativeMethodInfoPtr__ctor_Public_Void_SequenceID_String_IList_1_Command_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OneTimeTutorialActionSequence>.NativeClassPtr, 100664855);
			OneTimeTutorialActionSequence.NativeMethodInfoPtr_executeSequence_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OneTimeTutorialActionSequence>.NativeClassPtr, 100664856);
			OneTimeTutorialActionSequence.NativeMethodInfoPtr___n__0_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OneTimeTutorialActionSequence>.NativeClassPtr, 100664857);
		}

		// Token: 0x06000AA2 RID: 2722 RVA: 0x0003F3C8 File Offset: 0x0003D5C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OneTimeTutorialActionSequence(SequenceID id, string name, IList<Command> sequence)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OneTimeTutorialActionSequence>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OneTimeTutorialActionSequence.NativeMethodInfoPtr__ctor_Public_Void_SequenceID_String_IList_1_Command_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AA3 RID: 2723 RVA: 0x0003F438 File Offset: 0x0003D638
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 507206, XrefRangeEnd = 507211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator executeSequence()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OneTimeTutorialActionSequence.NativeMethodInfoPtr_executeSequence_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000AA4 RID: 2724 RVA: 0x0003F484 File Offset: 0x0003D684
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 507211, XrefRangeEnd = 507212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator __n__0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OneTimeTutorialActionSequence.NativeMethodInfoPtr___n__0_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000AA5 RID: 2725 RVA: 0x000070CF File Offset: 0x000052CF
		public OneTimeTutorialActionSequence(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000675 RID: 1653
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SequenceID_String_IList_1_Command_0;

		// Token: 0x04000676 RID: 1654
		private static readonly IntPtr NativeMethodInfoPtr_executeSequence_Protected_Virtual_IEnumerator_0;

		// Token: 0x04000677 RID: 1655
		private static readonly IntPtr NativeMethodInfoPtr___n__0_Private_IEnumerator_0;

		// Token: 0x0200033D RID: 829
		[ObfuscatedName("boardgames.sequences.OneTimeTutorialActionSequence+<executeSequence>d__1")]
		public sealed class _executeSequence_d__1 : Object
		{
			// Token: 0x06002738 RID: 10040 RVA: 0x0009DC60 File Offset: 0x0009BE60
			// Note: this type is marked as 'beforefieldinit'.
			static _executeSequence_d__1()
			{
				Il2CppClassPointerStore<OneTimeTutorialActionSequence._executeSequence_d__1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<OneTimeTutorialActionSequence>.NativeClassPtr, "<executeSequence>d__1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OneTimeTutorialActionSequence._executeSequence_d__1>.NativeClassPtr);
				OneTimeTutorialActionSequence._executeSequence_d__1.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OneTimeTutorialActionSequence._executeSequence_d__1>.NativeClassPtr, "<>1__state");
				OneTimeTutorialActionSequence._executeSequence_d__1.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OneTimeTutorialActionSequence._executeSequence_d__1>.NativeClassPtr, "<>2__current");
				OneTimeTutorialActionSequence._executeSequence_d__1.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OneTimeTutorialActionSequence._executeSequence_d__1>.NativeClassPtr, "<>4__this");
				OneTimeTutorialActionSequence._executeSequence_d__1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OneTimeTutorialActionSequence._executeSequence_d__1>.NativeClassPtr, 100664858);
				OneTimeTutorialActionSequence._executeSequence_d__1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OneTimeTutorialActionSequence._executeSequence_d__1>.NativeClassPtr, 100664859);
				OneTimeTutorialActionSequence._executeSequence_d__1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OneTimeTutorialActionSequence._executeSequence_d__1>.NativeClassPtr, 100664860);
				OneTimeTutorialActionSequence._executeSequence_d__1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OneTimeTutorialActionSequence._executeSequence_d__1>.NativeClassPtr, 100664861);
				OneTimeTutorialActionSequence._executeSequence_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OneTimeTutorialActionSequence._executeSequence_d__1>.NativeClassPtr, 100664862);
				OneTimeTutorialActionSequence._executeSequence_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OneTimeTutorialActionSequence._executeSequence_d__1>.NativeClassPtr, 100664863);
			}

			// Token: 0x06002739 RID: 10041 RVA: 0x0009DD40 File Offset: 0x0009BF40
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _executeSequence_d__1(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OneTimeTutorialActionSequence._executeSequence_d__1>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OneTimeTutorialActionSequence._executeSequence_d__1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600273A RID: 10042 RVA: 0x0009DD88 File Offset: 0x0009BF88
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OneTimeTutorialActionSequence._executeSequence_d__1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600273B RID: 10043 RVA: 0x0009DDBC File Offset: 0x0009BFBC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 507181, XrefRangeEnd = 507201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OneTimeTutorialActionSequence._executeSequence_d__1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000AF1 RID: 2801
			// (get) Token: 0x0600273C RID: 10044 RVA: 0x0009DDF8 File Offset: 0x0009BFF8
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OneTimeTutorialActionSequence._executeSequence_d__1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600273D RID: 10045 RVA: 0x0009DE38 File Offset: 0x0009C038
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 507201, XrefRangeEnd = 507206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OneTimeTutorialActionSequence._executeSequence_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000AF2 RID: 2802
			// (get) Token: 0x0600273E RID: 10046 RVA: 0x0009DE6C File Offset: 0x0009C06C
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OneTimeTutorialActionSequence._executeSequence_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600273F RID: 10047 RVA: 0x000145C7 File Offset: 0x000127C7
			public _executeSequence_d__1(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000AEE RID: 2798
			// (get) Token: 0x06002740 RID: 10048 RVA: 0x0009DEAC File Offset: 0x0009C0AC
			// (set) Token: 0x06002741 RID: 10049 RVA: 0x000145D0 File Offset: 0x000127D0
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OneTimeTutorialActionSequence._executeSequence_d__1.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OneTimeTutorialActionSequence._executeSequence_d__1.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000AEF RID: 2799
			// (get) Token: 0x06002742 RID: 10050 RVA: 0x0009DED4 File Offset: 0x0009C0D4
			// (set) Token: 0x06002743 RID: 10051 RVA: 0x000145EB File Offset: 0x000127EB
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OneTimeTutorialActionSequence._executeSequence_d__1.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OneTimeTutorialActionSequence._executeSequence_d__1.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000AF0 RID: 2800
			// (get) Token: 0x06002744 RID: 10052 RVA: 0x0009DF04 File Offset: 0x0009C104
			// (set) Token: 0x06002745 RID: 10053 RVA: 0x0001460A File Offset: 0x0001280A
			public unsafe OneTimeTutorialActionSequence __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OneTimeTutorialActionSequence._executeSequence_d__1.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<OneTimeTutorialActionSequence>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OneTimeTutorialActionSequence._executeSequence_d__1.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400189B RID: 6299
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400189C RID: 6300
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400189D RID: 6301
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400189E RID: 6302
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400189F RID: 6303
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040018A0 RID: 6304
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040018A1 RID: 6305
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040018A2 RID: 6306
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040018A3 RID: 6307
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
