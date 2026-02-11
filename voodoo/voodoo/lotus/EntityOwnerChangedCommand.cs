using System;
using Canis.messages;
using Canis.utils.ids;
using dwd.core.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace lotus
{
	// Token: 0x0200005D RID: 93
	public class EntityOwnerChangedCommand : Command
	{
		// Token: 0x06000574 RID: 1396 RVA: 0x0001B734 File Offset: 0x00019934
		// Note: this type is marked as 'beforefieldinit'.
		static EntityOwnerChangedCommand()
		{
			Il2CppClassPointerStore<EntityOwnerChangedCommand>.NativeClassPtr = IL2CPP.GetIl2CppClass("voodoo.dll", "lotus", "EntityOwnerChangedCommand");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EntityOwnerChangedCommand>.NativeClassPtr);
			EntityOwnerChangedCommand.NativeFieldInfoPtr_entityIDs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityOwnerChangedCommand>.NativeClassPtr, "entityIDs");
			EntityOwnerChangedCommand.NativeFieldInfoPtr_newOwnerAccountID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityOwnerChangedCommand>.NativeClassPtr, "newOwnerAccountID");
			EntityOwnerChangedCommand.NativeMethodInfoPtr__ctor_Public_Void_EntityOwnerChanged_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityOwnerChangedCommand>.NativeClassPtr, 100664024);
			EntityOwnerChangedCommand.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityOwnerChangedCommand>.NativeClassPtr, 100664025);
		}

		// Token: 0x06000575 RID: 1397 RVA: 0x0001B7B4 File Offset: 0x000199B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EntityOwnerChangedCommand(EntityOwnerChanged message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EntityOwnerChangedCommand>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityOwnerChangedCommand.NativeMethodInfoPtr__ctor_Public_Void_EntityOwnerChanged_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000576 RID: 1398 RVA: 0x0001B800 File Offset: 0x00019A00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1111790, XrefRangeEnd = 1111795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EntityOwnerChangedCommand.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000577 RID: 1399 RVA: 0x00004A96 File Offset: 0x00002C96
		public EntityOwnerChangedCommand(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001A7 RID: 423
		// (get) Token: 0x06000578 RID: 1400 RVA: 0x0001B84C File Offset: 0x00019A4C
		// (set) Token: 0x06000579 RID: 1401 RVA: 0x00004A9F File Offset: 0x00002C9F
		public unsafe List<EntityID> entityIDs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityOwnerChangedCommand.NativeFieldInfoPtr_entityIDs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<EntityID>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityOwnerChangedCommand.NativeFieldInfoPtr_entityIDs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001A8 RID: 424
		// (get) Token: 0x0600057A RID: 1402 RVA: 0x0001B87C File Offset: 0x00019A7C
		// (set) Token: 0x0600057B RID: 1403 RVA: 0x00004ABE File Offset: 0x00002CBE
		public unsafe AccountID newOwnerAccountID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityOwnerChangedCommand.NativeFieldInfoPtr_newOwnerAccountID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityOwnerChangedCommand.NativeFieldInfoPtr_newOwnerAccountID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400036E RID: 878
		private static readonly IntPtr NativeFieldInfoPtr_entityIDs;

		// Token: 0x0400036F RID: 879
		private static readonly IntPtr NativeFieldInfoPtr_newOwnerAccountID;

		// Token: 0x04000370 RID: 880
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_EntityOwnerChanged_0;

		// Token: 0x04000371 RID: 881
		private static readonly IntPtr NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0;

		// Token: 0x020000E0 RID: 224
		[ObfuscatedName("lotus.EntityOwnerChangedCommand+<execute>d__3")]
		public sealed class _execute_d__3 : Object
		{
			// Token: 0x06000BC5 RID: 3013 RVA: 0x0002FC24 File Offset: 0x0002DE24
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__3()
			{
				Il2CppClassPointerStore<EntityOwnerChangedCommand._execute_d__3>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EntityOwnerChangedCommand>.NativeClassPtr, "<execute>d__3");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EntityOwnerChangedCommand._execute_d__3>.NativeClassPtr);
				EntityOwnerChangedCommand._execute_d__3.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityOwnerChangedCommand._execute_d__3>.NativeClassPtr, "<>1__state");
				EntityOwnerChangedCommand._execute_d__3.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityOwnerChangedCommand._execute_d__3>.NativeClassPtr, "<>2__current");
				EntityOwnerChangedCommand._execute_d__3.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityOwnerChangedCommand._execute_d__3>.NativeClassPtr, "<>4__this");
				EntityOwnerChangedCommand._execute_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityOwnerChangedCommand._execute_d__3>.NativeClassPtr, 100664026);
				EntityOwnerChangedCommand._execute_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityOwnerChangedCommand._execute_d__3>.NativeClassPtr, 100664027);
				EntityOwnerChangedCommand._execute_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityOwnerChangedCommand._execute_d__3>.NativeClassPtr, 100664028);
				EntityOwnerChangedCommand._execute_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityOwnerChangedCommand._execute_d__3>.NativeClassPtr, 100664029);
				EntityOwnerChangedCommand._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityOwnerChangedCommand._execute_d__3>.NativeClassPtr, 100664030);
				EntityOwnerChangedCommand._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityOwnerChangedCommand._execute_d__3>.NativeClassPtr, 100664031);
			}

			// Token: 0x06000BC6 RID: 3014 RVA: 0x0002FD04 File Offset: 0x0002DF04
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__3(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EntityOwnerChangedCommand._execute_d__3>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityOwnerChangedCommand._execute_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000BC7 RID: 3015 RVA: 0x0002FD4C File Offset: 0x0002DF4C
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityOwnerChangedCommand._execute_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000BC8 RID: 3016 RVA: 0x0002FD80 File Offset: 0x0002DF80
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1111769, XrefRangeEnd = 1111785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityOwnerChangedCommand._execute_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000379 RID: 889
			// (get) Token: 0x06000BC9 RID: 3017 RVA: 0x0002FDBC File Offset: 0x0002DFBC
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityOwnerChangedCommand._execute_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000BCA RID: 3018 RVA: 0x0002FDFC File Offset: 0x0002DFFC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1111785, XrefRangeEnd = 1111790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityOwnerChangedCommand._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700037A RID: 890
			// (get) Token: 0x06000BCB RID: 3019 RVA: 0x0002FE30 File Offset: 0x0002E030
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityOwnerChangedCommand._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000BCC RID: 3020 RVA: 0x00007C82 File Offset: 0x00005E82
			public _execute_d__3(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000376 RID: 886
			// (get) Token: 0x06000BCD RID: 3021 RVA: 0x0002FE70 File Offset: 0x0002E070
			// (set) Token: 0x06000BCE RID: 3022 RVA: 0x00007C8B File Offset: 0x00005E8B
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityOwnerChangedCommand._execute_d__3.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityOwnerChangedCommand._execute_d__3.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000377 RID: 887
			// (get) Token: 0x06000BCF RID: 3023 RVA: 0x0002FE98 File Offset: 0x0002E098
			// (set) Token: 0x06000BD0 RID: 3024 RVA: 0x00007CA6 File Offset: 0x00005EA6
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityOwnerChangedCommand._execute_d__3.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityOwnerChangedCommand._execute_d__3.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000378 RID: 888
			// (get) Token: 0x06000BD1 RID: 3025 RVA: 0x0002FEC8 File Offset: 0x0002E0C8
			// (set) Token: 0x06000BD2 RID: 3026 RVA: 0x00007CC5 File Offset: 0x00005EC5
			public unsafe EntityOwnerChangedCommand __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityOwnerChangedCommand._execute_d__3.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityOwnerChangedCommand>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityOwnerChangedCommand._execute_d__3.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400075A RID: 1882
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400075B RID: 1883
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400075C RID: 1884
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400075D RID: 1885
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400075E RID: 1886
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400075F RID: 1887
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000760 RID: 1888
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000761 RID: 1889
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000762 RID: 1890
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
