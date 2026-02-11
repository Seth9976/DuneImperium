using System;
using dwd.core.match;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;

namespace lotus
{
	// Token: 0x0200004D RID: 77
	public class EntitiesIntroducedGroupCommand : VoodooMoveCommand
	{
		// Token: 0x060004A8 RID: 1192 RVA: 0x000186C8 File Offset: 0x000168C8
		// Note: this type is marked as 'beforefieldinit'.
		static EntitiesIntroducedGroupCommand()
		{
			Il2CppClassPointerStore<EntitiesIntroducedGroupCommand>.NativeClassPtr = IL2CPP.GetIl2CppClass("voodoo.dll", "lotus", "EntitiesIntroducedGroupCommand");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EntitiesIntroducedGroupCommand>.NativeClassPtr);
			EntitiesIntroducedGroupCommand.NativeMethodInfoPtr__ctor_Public_Void_MoveContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntitiesIntroducedGroupCommand>.NativeClassPtr, 100663846);
			EntitiesIntroducedGroupCommand.NativeMethodInfoPtr_CreateView_Public_Void_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntitiesIntroducedGroupCommand>.NativeClassPtr, 100663847);
			EntitiesIntroducedGroupCommand.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntitiesIntroducedGroupCommand>.NativeClassPtr, 100663848);
		}

		// Token: 0x060004A9 RID: 1193 RVA: 0x00018734 File Offset: 0x00016934
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1110651, RefRangeEnd = 1110655, XrefRangeStart = 1110650, XrefRangeEnd = 1110651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EntitiesIntroducedGroupCommand(MoveContext c)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EntitiesIntroducedGroupCommand>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntitiesIntroducedGroupCommand.NativeMethodInfoPtr__ctor_Public_Void_MoveContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004AA RID: 1194 RVA: 0x00018780 File Offset: 0x00016980
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1110681, RefRangeEnd = 1110682, XrefRangeStart = 1110655, XrefRangeEnd = 1110681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateView(EntityComponent ec)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ec);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntitiesIntroducedGroupCommand.NativeMethodInfoPtr_CreateView_Public_Void_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004AB RID: 1195 RVA: 0x000187C4 File Offset: 0x000169C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1110682, XrefRangeEnd = 1110687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EntitiesIntroducedGroupCommand.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060004AC RID: 1196 RVA: 0x000045C9 File Offset: 0x000027C9
		public EntitiesIntroducedGroupCommand(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040002E4 RID: 740
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_MoveContext_0;

		// Token: 0x040002E5 RID: 741
		private static readonly IntPtr NativeMethodInfoPtr_CreateView_Public_Void_EntityComponent_0;

		// Token: 0x040002E6 RID: 742
		private static readonly IntPtr NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0;

		// Token: 0x020000D1 RID: 209
		[ObfuscatedName("lotus.EntitiesIntroducedGroupCommand+<execute>d__2")]
		public sealed class _execute_d__2 : Object
		{
			// Token: 0x06000AFA RID: 2810 RVA: 0x0002D554 File Offset: 0x0002B754
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__2()
			{
				Il2CppClassPointerStore<EntitiesIntroducedGroupCommand._execute_d__2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EntitiesIntroducedGroupCommand>.NativeClassPtr, "<execute>d__2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EntitiesIntroducedGroupCommand._execute_d__2>.NativeClassPtr);
				EntitiesIntroducedGroupCommand._execute_d__2.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntitiesIntroducedGroupCommand._execute_d__2>.NativeClassPtr, "<>1__state");
				EntitiesIntroducedGroupCommand._execute_d__2.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntitiesIntroducedGroupCommand._execute_d__2>.NativeClassPtr, "<>2__current");
				EntitiesIntroducedGroupCommand._execute_d__2.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntitiesIntroducedGroupCommand._execute_d__2>.NativeClassPtr, "<>4__this");
				EntitiesIntroducedGroupCommand._execute_d__2.NativeFieldInfoPtr__i_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntitiesIntroducedGroupCommand._execute_d__2>.NativeClassPtr, "<i>5__2");
				EntitiesIntroducedGroupCommand._execute_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntitiesIntroducedGroupCommand._execute_d__2>.NativeClassPtr, 100663849);
				EntitiesIntroducedGroupCommand._execute_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntitiesIntroducedGroupCommand._execute_d__2>.NativeClassPtr, 100663850);
				EntitiesIntroducedGroupCommand._execute_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntitiesIntroducedGroupCommand._execute_d__2>.NativeClassPtr, 100663851);
				EntitiesIntroducedGroupCommand._execute_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntitiesIntroducedGroupCommand._execute_d__2>.NativeClassPtr, 100663852);
				EntitiesIntroducedGroupCommand._execute_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntitiesIntroducedGroupCommand._execute_d__2>.NativeClassPtr, 100663853);
				EntitiesIntroducedGroupCommand._execute_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntitiesIntroducedGroupCommand._execute_d__2>.NativeClassPtr, 100663854);
			}

			// Token: 0x06000AFB RID: 2811 RVA: 0x0002D648 File Offset: 0x0002B848
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__2(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EntitiesIntroducedGroupCommand._execute_d__2>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntitiesIntroducedGroupCommand._execute_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000AFC RID: 2812 RVA: 0x0002D690 File Offset: 0x0002B890
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntitiesIntroducedGroupCommand._execute_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000AFD RID: 2813 RVA: 0x0002D6C4 File Offset: 0x0002B8C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1110628, XrefRangeEnd = 1110645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntitiesIntroducedGroupCommand._execute_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700032F RID: 815
			// (get) Token: 0x06000AFE RID: 2814 RVA: 0x0002D700 File Offset: 0x0002B900
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntitiesIntroducedGroupCommand._execute_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000AFF RID: 2815 RVA: 0x0002D740 File Offset: 0x0002B940
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1110645, XrefRangeEnd = 1110650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntitiesIntroducedGroupCommand._execute_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000330 RID: 816
			// (get) Token: 0x06000B00 RID: 2816 RVA: 0x0002D774 File Offset: 0x0002B974
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntitiesIntroducedGroupCommand._execute_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000B01 RID: 2817 RVA: 0x0000761C File Offset: 0x0000581C
			public _execute_d__2(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700032B RID: 811
			// (get) Token: 0x06000B02 RID: 2818 RVA: 0x0002D7B4 File Offset: 0x0002B9B4
			// (set) Token: 0x06000B03 RID: 2819 RVA: 0x00007625 File Offset: 0x00005825
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntitiesIntroducedGroupCommand._execute_d__2.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntitiesIntroducedGroupCommand._execute_d__2.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700032C RID: 812
			// (get) Token: 0x06000B04 RID: 2820 RVA: 0x0002D7DC File Offset: 0x0002B9DC
			// (set) Token: 0x06000B05 RID: 2821 RVA: 0x00007640 File Offset: 0x00005840
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntitiesIntroducedGroupCommand._execute_d__2.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntitiesIntroducedGroupCommand._execute_d__2.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700032D RID: 813
			// (get) Token: 0x06000B06 RID: 2822 RVA: 0x0002D80C File Offset: 0x0002BA0C
			// (set) Token: 0x06000B07 RID: 2823 RVA: 0x0000765F File Offset: 0x0000585F
			public unsafe EntitiesIntroducedGroupCommand __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntitiesIntroducedGroupCommand._execute_d__2.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntitiesIntroducedGroupCommand>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntitiesIntroducedGroupCommand._execute_d__2.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700032E RID: 814
			// (get) Token: 0x06000B08 RID: 2824 RVA: 0x0002D83C File Offset: 0x0002BA3C
			// (set) Token: 0x06000B09 RID: 2825 RVA: 0x0000767E File Offset: 0x0000587E
			public unsafe int _i_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntitiesIntroducedGroupCommand._execute_d__2.NativeFieldInfoPtr__i_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntitiesIntroducedGroupCommand._execute_d__2.NativeFieldInfoPtr__i_5__2)) = value;
				}
			}

			// Token: 0x040006D8 RID: 1752
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040006D9 RID: 1753
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040006DA RID: 1754
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040006DB RID: 1755
			private static readonly IntPtr NativeFieldInfoPtr__i_5__2;

			// Token: 0x040006DC RID: 1756
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040006DD RID: 1757
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040006DE RID: 1758
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040006DF RID: 1759
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040006E0 RID: 1760
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040006E1 RID: 1761
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
