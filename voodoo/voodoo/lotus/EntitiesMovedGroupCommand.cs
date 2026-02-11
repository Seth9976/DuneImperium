using System;
using dwd.core.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;

namespace lotus
{
	// Token: 0x0200004E RID: 78
	public class EntitiesMovedGroupCommand : VoodooMoveCommand
	{
		// Token: 0x060004AD RID: 1197 RVA: 0x00018810 File Offset: 0x00016A10
		// Note: this type is marked as 'beforefieldinit'.
		static EntitiesMovedGroupCommand()
		{
			Il2CppClassPointerStore<EntitiesMovedGroupCommand>.NativeClassPtr = IL2CPP.GetIl2CppClass("voodoo.dll", "lotus", "EntitiesMovedGroupCommand");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EntitiesMovedGroupCommand>.NativeClassPtr);
			EntitiesMovedGroupCommand.NativeMethodInfoPtr__ctor_Public_Void_MoveContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntitiesMovedGroupCommand>.NativeClassPtr, 100663855);
			EntitiesMovedGroupCommand.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntitiesMovedGroupCommand>.NativeClassPtr, 100663856);
			EntitiesMovedGroupCommand.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntitiesMovedGroupCommand>.NativeClassPtr, 100663857);
		}

		// Token: 0x060004AE RID: 1198 RVA: 0x0001887C File Offset: 0x00016A7C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1110651, RefRangeEnd = 1110655, XrefRangeStart = 1110651, XrefRangeEnd = 1110655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EntitiesMovedGroupCommand(MoveContext c)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EntitiesMovedGroupCommand>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntitiesMovedGroupCommand.NativeMethodInfoPtr__ctor_Public_Void_MoveContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004AF RID: 1199 RVA: 0x000188C8 File Offset: 0x00016AC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1110772, XrefRangeEnd = 1110777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EntitiesMovedGroupCommand.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060004B0 RID: 1200 RVA: 0x00018914 File Offset: 0x00016B14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1110777, XrefRangeEnd = 1110794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EntitiesMovedGroupCommand.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060004B1 RID: 1201 RVA: 0x000045D2 File Offset: 0x000027D2
		public EntitiesMovedGroupCommand(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040002E7 RID: 743
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_MoveContext_0;

		// Token: 0x040002E8 RID: 744
		private static readonly IntPtr NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0;

		// Token: 0x040002E9 RID: 745
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x020000D2 RID: 210
		[ObfuscatedName("lotus.EntitiesMovedGroupCommand+<execute>d__1")]
		public sealed class _execute_d__1 : Object
		{
			// Token: 0x06000B0A RID: 2826 RVA: 0x0002D864 File Offset: 0x0002BA64
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__1()
			{
				Il2CppClassPointerStore<EntitiesMovedGroupCommand._execute_d__1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EntitiesMovedGroupCommand>.NativeClassPtr, "<execute>d__1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EntitiesMovedGroupCommand._execute_d__1>.NativeClassPtr);
				EntitiesMovedGroupCommand._execute_d__1.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntitiesMovedGroupCommand._execute_d__1>.NativeClassPtr, "<>1__state");
				EntitiesMovedGroupCommand._execute_d__1.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntitiesMovedGroupCommand._execute_d__1>.NativeClassPtr, "<>2__current");
				EntitiesMovedGroupCommand._execute_d__1.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntitiesMovedGroupCommand._execute_d__1>.NativeClassPtr, "<>4__this");
				EntitiesMovedGroupCommand._execute_d__1.NativeFieldInfoPtr__prepareToReceiveEntities_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntitiesMovedGroupCommand._execute_d__1>.NativeClassPtr, "<prepareToReceiveEntities>5__2");
				EntitiesMovedGroupCommand._execute_d__1.NativeFieldInfoPtr__prepareToRemoveEntities_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntitiesMovedGroupCommand._execute_d__1>.NativeClassPtr, "<prepareToRemoveEntities>5__3");
				EntitiesMovedGroupCommand._execute_d__1.NativeFieldInfoPtr__i_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntitiesMovedGroupCommand._execute_d__1>.NativeClassPtr, "<i>5__4");
				EntitiesMovedGroupCommand._execute_d__1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntitiesMovedGroupCommand._execute_d__1>.NativeClassPtr, 100663858);
				EntitiesMovedGroupCommand._execute_d__1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntitiesMovedGroupCommand._execute_d__1>.NativeClassPtr, 100663859);
				EntitiesMovedGroupCommand._execute_d__1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntitiesMovedGroupCommand._execute_d__1>.NativeClassPtr, 100663860);
				EntitiesMovedGroupCommand._execute_d__1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntitiesMovedGroupCommand._execute_d__1>.NativeClassPtr, 100663861);
				EntitiesMovedGroupCommand._execute_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntitiesMovedGroupCommand._execute_d__1>.NativeClassPtr, 100663862);
				EntitiesMovedGroupCommand._execute_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntitiesMovedGroupCommand._execute_d__1>.NativeClassPtr, 100663863);
			}

			// Token: 0x06000B0B RID: 2827 RVA: 0x0002D980 File Offset: 0x0002BB80
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__1(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EntitiesMovedGroupCommand._execute_d__1>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntitiesMovedGroupCommand._execute_d__1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000B0C RID: 2828 RVA: 0x0002D9C8 File Offset: 0x0002BBC8
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntitiesMovedGroupCommand._execute_d__1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000B0D RID: 2829 RVA: 0x0002D9FC File Offset: 0x0002BBFC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1110687, XrefRangeEnd = 1110767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntitiesMovedGroupCommand._execute_d__1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000337 RID: 823
			// (get) Token: 0x06000B0E RID: 2830 RVA: 0x0002DA38 File Offset: 0x0002BC38
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntitiesMovedGroupCommand._execute_d__1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000B0F RID: 2831 RVA: 0x0002DA78 File Offset: 0x0002BC78
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1110767, XrefRangeEnd = 1110772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntitiesMovedGroupCommand._execute_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000338 RID: 824
			// (get) Token: 0x06000B10 RID: 2832 RVA: 0x0002DAAC File Offset: 0x0002BCAC
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntitiesMovedGroupCommand._execute_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000B11 RID: 2833 RVA: 0x00007699 File Offset: 0x00005899
			public _execute_d__1(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000331 RID: 817
			// (get) Token: 0x06000B12 RID: 2834 RVA: 0x0002DAEC File Offset: 0x0002BCEC
			// (set) Token: 0x06000B13 RID: 2835 RVA: 0x000076A2 File Offset: 0x000058A2
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntitiesMovedGroupCommand._execute_d__1.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntitiesMovedGroupCommand._execute_d__1.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000332 RID: 818
			// (get) Token: 0x06000B14 RID: 2836 RVA: 0x0002DB14 File Offset: 0x0002BD14
			// (set) Token: 0x06000B15 RID: 2837 RVA: 0x000076BD File Offset: 0x000058BD
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntitiesMovedGroupCommand._execute_d__1.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntitiesMovedGroupCommand._execute_d__1.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000333 RID: 819
			// (get) Token: 0x06000B16 RID: 2838 RVA: 0x0002DB44 File Offset: 0x0002BD44
			// (set) Token: 0x06000B17 RID: 2839 RVA: 0x000076DC File Offset: 0x000058DC
			public unsafe EntitiesMovedGroupCommand __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntitiesMovedGroupCommand._execute_d__1.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntitiesMovedGroupCommand>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntitiesMovedGroupCommand._execute_d__1.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000334 RID: 820
			// (get) Token: 0x06000B18 RID: 2840 RVA: 0x0002DB74 File Offset: 0x0002BD74
			// (set) Token: 0x06000B19 RID: 2841 RVA: 0x000076FB File Offset: 0x000058FB
			public unsafe IFailable _prepareToReceiveEntities_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntitiesMovedGroupCommand._execute_d__1.NativeFieldInfoPtr__prepareToReceiveEntities_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IFailable>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntitiesMovedGroupCommand._execute_d__1.NativeFieldInfoPtr__prepareToReceiveEntities_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000335 RID: 821
			// (get) Token: 0x06000B1A RID: 2842 RVA: 0x0002DBA4 File Offset: 0x0002BDA4
			// (set) Token: 0x06000B1B RID: 2843 RVA: 0x0000771A File Offset: 0x0000591A
			public unsafe IFailable _prepareToRemoveEntities_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntitiesMovedGroupCommand._execute_d__1.NativeFieldInfoPtr__prepareToRemoveEntities_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IFailable>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntitiesMovedGroupCommand._execute_d__1.NativeFieldInfoPtr__prepareToRemoveEntities_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000336 RID: 822
			// (get) Token: 0x06000B1C RID: 2844 RVA: 0x0002DBD4 File Offset: 0x0002BDD4
			// (set) Token: 0x06000B1D RID: 2845 RVA: 0x00007739 File Offset: 0x00005939
			public unsafe int _i_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntitiesMovedGroupCommand._execute_d__1.NativeFieldInfoPtr__i_5__4);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntitiesMovedGroupCommand._execute_d__1.NativeFieldInfoPtr__i_5__4)) = value;
				}
			}

			// Token: 0x040006E2 RID: 1762
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040006E3 RID: 1763
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040006E4 RID: 1764
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040006E5 RID: 1765
			private static readonly IntPtr NativeFieldInfoPtr__prepareToReceiveEntities_5__2;

			// Token: 0x040006E6 RID: 1766
			private static readonly IntPtr NativeFieldInfoPtr__prepareToRemoveEntities_5__3;

			// Token: 0x040006E7 RID: 1767
			private static readonly IntPtr NativeFieldInfoPtr__i_5__4;

			// Token: 0x040006E8 RID: 1768
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040006E9 RID: 1769
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040006EA RID: 1770
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040006EB RID: 1771
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040006EC RID: 1772
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040006ED RID: 1773
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
