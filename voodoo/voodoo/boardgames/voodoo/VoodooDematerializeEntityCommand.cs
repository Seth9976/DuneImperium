using System;
using Canis.messages;
using Canis.utils.ids;
using dwd.core.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using lotus;

namespace boardgames.voodoo
{
	// Token: 0x02000099 RID: 153
	public class VoodooDematerializeEntityCommand : Command
	{
		// Token: 0x06000902 RID: 2306 RVA: 0x0002761C File Offset: 0x0002581C
		// Note: this type is marked as 'beforefieldinit'.
		static VoodooDematerializeEntityCommand()
		{
			Il2CppClassPointerStore<VoodooDematerializeEntityCommand>.NativeClassPtr = IL2CPP.GetIl2CppClass("voodoo.dll", "boardgames.voodoo", "VoodooDematerializeEntityCommand");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VoodooDematerializeEntityCommand>.NativeClassPtr);
			VoodooDematerializeEntityCommand.NativeFieldInfoPtr_EntityID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooDematerializeEntityCommand>.NativeClassPtr, "EntityID");
			VoodooDematerializeEntityCommand.NativeFieldInfoPtr_SourceID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooDematerializeEntityCommand>.NativeClassPtr, "SourceID");
			VoodooDematerializeEntityCommand.NativeFieldInfoPtr_DestinationID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooDematerializeEntityCommand>.NativeClassPtr, "DestinationID");
			VoodooDematerializeEntityCommand.NativeFieldInfoPtr_um = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooDematerializeEntityCommand>.NativeClassPtr, "um");
			VoodooDematerializeEntityCommand.NativeMethodInfoPtr__ctor_Public_Void_DematerializeEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooDematerializeEntityCommand>.NativeClassPtr, 100664604);
			VoodooDematerializeEntityCommand.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooDematerializeEntityCommand>.NativeClassPtr, 100664605);
		}

		// Token: 0x06000903 RID: 2307 RVA: 0x000276C4 File Offset: 0x000258C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1117115, XrefRangeEnd = 1117124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VoodooDematerializeEntityCommand(DematerializeEntity message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VoodooDematerializeEntityCommand>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooDematerializeEntityCommand.NativeMethodInfoPtr__ctor_Public_Void_DematerializeEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000904 RID: 2308 RVA: 0x00027710 File Offset: 0x00025910
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1117124, XrefRangeEnd = 1117129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VoodooDematerializeEntityCommand.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000905 RID: 2309 RVA: 0x00006664 File Offset: 0x00004864
		public VoodooDematerializeEntityCommand(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000297 RID: 663
		// (get) Token: 0x06000906 RID: 2310 RVA: 0x0002775C File Offset: 0x0002595C
		// (set) Token: 0x06000907 RID: 2311 RVA: 0x0000666D File Offset: 0x0000486D
		public unsafe EntityID EntityID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooDematerializeEntityCommand.NativeFieldInfoPtr_EntityID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooDematerializeEntityCommand.NativeFieldInfoPtr_EntityID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000298 RID: 664
		// (get) Token: 0x06000908 RID: 2312 RVA: 0x0002778C File Offset: 0x0002598C
		// (set) Token: 0x06000909 RID: 2313 RVA: 0x0000668C File Offset: 0x0000488C
		public unsafe EntityID SourceID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooDematerializeEntityCommand.NativeFieldInfoPtr_SourceID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooDematerializeEntityCommand.NativeFieldInfoPtr_SourceID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000299 RID: 665
		// (get) Token: 0x0600090A RID: 2314 RVA: 0x000277BC File Offset: 0x000259BC
		// (set) Token: 0x0600090B RID: 2315 RVA: 0x000066AB File Offset: 0x000048AB
		public unsafe EntityID DestinationID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooDematerializeEntityCommand.NativeFieldInfoPtr_DestinationID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooDematerializeEntityCommand.NativeFieldInfoPtr_DestinationID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700029A RID: 666
		// (get) Token: 0x0600090C RID: 2316 RVA: 0x000277EC File Offset: 0x000259EC
		// (set) Token: 0x0600090D RID: 2317 RVA: 0x000066CA File Offset: 0x000048CA
		public unsafe UpdateManager um
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooDematerializeEntityCommand.NativeFieldInfoPtr_um);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UpdateManager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooDematerializeEntityCommand.NativeFieldInfoPtr_um), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040005A5 RID: 1445
		private static readonly IntPtr NativeFieldInfoPtr_EntityID;

		// Token: 0x040005A6 RID: 1446
		private static readonly IntPtr NativeFieldInfoPtr_SourceID;

		// Token: 0x040005A7 RID: 1447
		private static readonly IntPtr NativeFieldInfoPtr_DestinationID;

		// Token: 0x040005A8 RID: 1448
		private static readonly IntPtr NativeFieldInfoPtr_um;

		// Token: 0x040005A9 RID: 1449
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_DematerializeEntity_0;

		// Token: 0x040005AA RID: 1450
		private static readonly IntPtr NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0;

		// Token: 0x02000115 RID: 277
		[ObfuscatedName("boardgames.voodoo.VoodooDematerializeEntityCommand+<execute>d__5")]
		public sealed class _execute_d__5 : Object
		{
			// Token: 0x06000E5A RID: 3674 RVA: 0x000376F0 File Offset: 0x000358F0
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__5()
			{
				Il2CppClassPointerStore<VoodooDematerializeEntityCommand._execute_d__5>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VoodooDematerializeEntityCommand>.NativeClassPtr, "<execute>d__5");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VoodooDematerializeEntityCommand._execute_d__5>.NativeClassPtr);
				VoodooDematerializeEntityCommand._execute_d__5.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooDematerializeEntityCommand._execute_d__5>.NativeClassPtr, "<>1__state");
				VoodooDematerializeEntityCommand._execute_d__5.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooDematerializeEntityCommand._execute_d__5>.NativeClassPtr, "<>2__current");
				VoodooDematerializeEntityCommand._execute_d__5.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooDematerializeEntityCommand._execute_d__5>.NativeClassPtr, "<>4__this");
				VoodooDematerializeEntityCommand._execute_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooDematerializeEntityCommand._execute_d__5>.NativeClassPtr, 100664606);
				VoodooDematerializeEntityCommand._execute_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooDematerializeEntityCommand._execute_d__5>.NativeClassPtr, 100664607);
				VoodooDematerializeEntityCommand._execute_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooDematerializeEntityCommand._execute_d__5>.NativeClassPtr, 100664608);
				VoodooDematerializeEntityCommand._execute_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooDematerializeEntityCommand._execute_d__5>.NativeClassPtr, 100664609);
				VoodooDematerializeEntityCommand._execute_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooDematerializeEntityCommand._execute_d__5>.NativeClassPtr, 100664610);
				VoodooDematerializeEntityCommand._execute_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooDematerializeEntityCommand._execute_d__5>.NativeClassPtr, 100664611);
			}

			// Token: 0x06000E5B RID: 3675 RVA: 0x000377D0 File Offset: 0x000359D0
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__5(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VoodooDematerializeEntityCommand._execute_d__5>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooDematerializeEntityCommand._execute_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000E5C RID: 3676 RVA: 0x00037818 File Offset: 0x00035A18
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooDematerializeEntityCommand._execute_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000E5D RID: 3677 RVA: 0x0003784C File Offset: 0x00035A4C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1117100, XrefRangeEnd = 1117110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooDematerializeEntityCommand._execute_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000458 RID: 1112
			// (get) Token: 0x06000E5E RID: 3678 RVA: 0x00037888 File Offset: 0x00035A88
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooDematerializeEntityCommand._execute_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000E5F RID: 3679 RVA: 0x000378C8 File Offset: 0x00035AC8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1117110, XrefRangeEnd = 1117115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooDematerializeEntityCommand._execute_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000459 RID: 1113
			// (get) Token: 0x06000E60 RID: 3680 RVA: 0x000378FC File Offset: 0x00035AFC
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooDematerializeEntityCommand._execute_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000E61 RID: 3681 RVA: 0x00009220 File Offset: 0x00007420
			public _execute_d__5(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000455 RID: 1109
			// (get) Token: 0x06000E62 RID: 3682 RVA: 0x0003793C File Offset: 0x00035B3C
			// (set) Token: 0x06000E63 RID: 3683 RVA: 0x00009229 File Offset: 0x00007429
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooDematerializeEntityCommand._execute_d__5.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooDematerializeEntityCommand._execute_d__5.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000456 RID: 1110
			// (get) Token: 0x06000E64 RID: 3684 RVA: 0x00037964 File Offset: 0x00035B64
			// (set) Token: 0x06000E65 RID: 3685 RVA: 0x00009244 File Offset: 0x00007444
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooDematerializeEntityCommand._execute_d__5.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooDematerializeEntityCommand._execute_d__5.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000457 RID: 1111
			// (get) Token: 0x06000E66 RID: 3686 RVA: 0x00037994 File Offset: 0x00035B94
			// (set) Token: 0x06000E67 RID: 3687 RVA: 0x00009263 File Offset: 0x00007463
			public unsafe VoodooDematerializeEntityCommand __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooDematerializeEntityCommand._execute_d__5.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<VoodooDematerializeEntityCommand>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooDematerializeEntityCommand._execute_d__5.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040008E7 RID: 2279
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040008E8 RID: 2280
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040008E9 RID: 2281
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040008EA RID: 2282
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040008EB RID: 2283
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040008EC RID: 2284
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040008ED RID: 2285
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040008EE RID: 2286
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040008EF RID: 2287
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
