using System;
using Canis.attributes;
using Canis.messages;
using Canis.utils.ids;
using dwd.core.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;

namespace boardgames.voodoo
{
	// Token: 0x0200009A RID: 154
	public class VoodooEntityIntroducedCommand : Command
	{
		// Token: 0x0600090E RID: 2318 RVA: 0x0002781C File Offset: 0x00025A1C
		// Note: this type is marked as 'beforefieldinit'.
		static VoodooEntityIntroducedCommand()
		{
			Il2CppClassPointerStore<VoodooEntityIntroducedCommand>.NativeClassPtr = IL2CPP.GetIl2CppClass("voodoo.dll", "boardgames.voodoo", "VoodooEntityIntroducedCommand");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VoodooEntityIntroducedCommand>.NativeClassPtr);
			VoodooEntityIntroducedCommand.NativeFieldInfoPtr_EntityID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooEntityIntroducedCommand>.NativeClassPtr, "EntityID");
			VoodooEntityIntroducedCommand.NativeFieldInfoPtr_entityName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooEntityIntroducedCommand>.NativeClassPtr, "entityName");
			VoodooEntityIntroducedCommand.NativeFieldInfoPtr_Attributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooEntityIntroducedCommand>.NativeClassPtr, "Attributes");
			VoodooEntityIntroducedCommand.NativeMethodInfoPtr__ctor_Public_Void_EntityIntroduced_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooEntityIntroducedCommand>.NativeClassPtr, 100664612);
			VoodooEntityIntroducedCommand.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooEntityIntroducedCommand>.NativeClassPtr, 100664613);
		}

		// Token: 0x0600090F RID: 2319 RVA: 0x000278B0 File Offset: 0x00025AB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1117148, XrefRangeEnd = 1117153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VoodooEntityIntroducedCommand(EntityIntroduced message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VoodooEntityIntroducedCommand>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooEntityIntroducedCommand.NativeMethodInfoPtr__ctor_Public_Void_EntityIntroduced_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000910 RID: 2320 RVA: 0x000278FC File Offset: 0x00025AFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1117153, XrefRangeEnd = 1117158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VoodooEntityIntroducedCommand.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000911 RID: 2321 RVA: 0x000066E9 File Offset: 0x000048E9
		public VoodooEntityIntroducedCommand(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700029B RID: 667
		// (get) Token: 0x06000912 RID: 2322 RVA: 0x00027948 File Offset: 0x00025B48
		// (set) Token: 0x06000913 RID: 2323 RVA: 0x000066F2 File Offset: 0x000048F2
		public unsafe EntityID EntityID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooEntityIntroducedCommand.NativeFieldInfoPtr_EntityID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooEntityIntroducedCommand.NativeFieldInfoPtr_EntityID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700029C RID: 668
		// (get) Token: 0x06000914 RID: 2324 RVA: 0x00027978 File Offset: 0x00025B78
		// (set) Token: 0x06000915 RID: 2325 RVA: 0x00006711 File Offset: 0x00004911
		public unsafe string entityName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooEntityIntroducedCommand.NativeFieldInfoPtr_entityName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooEntityIntroducedCommand.NativeFieldInfoPtr_entityName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700029D RID: 669
		// (get) Token: 0x06000916 RID: 2326 RVA: 0x000279A0 File Offset: 0x00025BA0
		// (set) Token: 0x06000917 RID: 2327 RVA: 0x00006730 File Offset: 0x00004930
		public unsafe ReadOnlyAttributes Attributes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooEntityIntroducedCommand.NativeFieldInfoPtr_Attributes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReadOnlyAttributes>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooEntityIntroducedCommand.NativeFieldInfoPtr_Attributes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040005AB RID: 1451
		private static readonly IntPtr NativeFieldInfoPtr_EntityID;

		// Token: 0x040005AC RID: 1452
		private static readonly IntPtr NativeFieldInfoPtr_entityName;

		// Token: 0x040005AD RID: 1453
		private static readonly IntPtr NativeFieldInfoPtr_Attributes;

		// Token: 0x040005AE RID: 1454
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_EntityIntroduced_0;

		// Token: 0x040005AF RID: 1455
		private static readonly IntPtr NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0;

		// Token: 0x02000116 RID: 278
		[ObfuscatedName("boardgames.voodoo.VoodooEntityIntroducedCommand+<execute>d__4")]
		public sealed class _execute_d__4 : Object
		{
			// Token: 0x06000E68 RID: 3688 RVA: 0x000379C4 File Offset: 0x00035BC4
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__4()
			{
				Il2CppClassPointerStore<VoodooEntityIntroducedCommand._execute_d__4>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VoodooEntityIntroducedCommand>.NativeClassPtr, "<execute>d__4");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VoodooEntityIntroducedCommand._execute_d__4>.NativeClassPtr);
				VoodooEntityIntroducedCommand._execute_d__4.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooEntityIntroducedCommand._execute_d__4>.NativeClassPtr, "<>1__state");
				VoodooEntityIntroducedCommand._execute_d__4.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooEntityIntroducedCommand._execute_d__4>.NativeClassPtr, "<>2__current");
				VoodooEntityIntroducedCommand._execute_d__4.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooEntityIntroducedCommand._execute_d__4>.NativeClassPtr, "<>4__this");
				VoodooEntityIntroducedCommand._execute_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooEntityIntroducedCommand._execute_d__4>.NativeClassPtr, 100664614);
				VoodooEntityIntroducedCommand._execute_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooEntityIntroducedCommand._execute_d__4>.NativeClassPtr, 100664615);
				VoodooEntityIntroducedCommand._execute_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooEntityIntroducedCommand._execute_d__4>.NativeClassPtr, 100664616);
				VoodooEntityIntroducedCommand._execute_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooEntityIntroducedCommand._execute_d__4>.NativeClassPtr, 100664617);
				VoodooEntityIntroducedCommand._execute_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooEntityIntroducedCommand._execute_d__4>.NativeClassPtr, 100664618);
				VoodooEntityIntroducedCommand._execute_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooEntityIntroducedCommand._execute_d__4>.NativeClassPtr, 100664619);
			}

			// Token: 0x06000E69 RID: 3689 RVA: 0x00037AA4 File Offset: 0x00035CA4
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__4(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VoodooEntityIntroducedCommand._execute_d__4>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooEntityIntroducedCommand._execute_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000E6A RID: 3690 RVA: 0x00037AEC File Offset: 0x00035CEC
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooEntityIntroducedCommand._execute_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000E6B RID: 3691 RVA: 0x00037B20 File Offset: 0x00035D20
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1117129, XrefRangeEnd = 1117143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooEntityIntroducedCommand._execute_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700045D RID: 1117
			// (get) Token: 0x06000E6C RID: 3692 RVA: 0x00037B5C File Offset: 0x00035D5C
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooEntityIntroducedCommand._execute_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000E6D RID: 3693 RVA: 0x00037B9C File Offset: 0x00035D9C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1117143, XrefRangeEnd = 1117148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooEntityIntroducedCommand._execute_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700045E RID: 1118
			// (get) Token: 0x06000E6E RID: 3694 RVA: 0x00037BD0 File Offset: 0x00035DD0
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooEntityIntroducedCommand._execute_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000E6F RID: 3695 RVA: 0x00009282 File Offset: 0x00007482
			public _execute_d__4(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700045A RID: 1114
			// (get) Token: 0x06000E70 RID: 3696 RVA: 0x00037C10 File Offset: 0x00035E10
			// (set) Token: 0x06000E71 RID: 3697 RVA: 0x0000928B File Offset: 0x0000748B
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooEntityIntroducedCommand._execute_d__4.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooEntityIntroducedCommand._execute_d__4.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700045B RID: 1115
			// (get) Token: 0x06000E72 RID: 3698 RVA: 0x00037C38 File Offset: 0x00035E38
			// (set) Token: 0x06000E73 RID: 3699 RVA: 0x000092A6 File Offset: 0x000074A6
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooEntityIntroducedCommand._execute_d__4.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooEntityIntroducedCommand._execute_d__4.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700045C RID: 1116
			// (get) Token: 0x06000E74 RID: 3700 RVA: 0x00037C68 File Offset: 0x00035E68
			// (set) Token: 0x06000E75 RID: 3701 RVA: 0x000092C5 File Offset: 0x000074C5
			public unsafe VoodooEntityIntroducedCommand __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooEntityIntroducedCommand._execute_d__4.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<VoodooEntityIntroducedCommand>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooEntityIntroducedCommand._execute_d__4.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040008F0 RID: 2288
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040008F1 RID: 2289
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040008F2 RID: 2290
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040008F3 RID: 2291
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040008F4 RID: 2292
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040008F5 RID: 2293
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040008F6 RID: 2294
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040008F7 RID: 2295
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040008F8 RID: 2296
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
