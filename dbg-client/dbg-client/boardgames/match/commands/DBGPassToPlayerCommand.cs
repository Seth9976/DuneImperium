using System;
using Canis.actions;
using Canis.utils.ids;
using dwd.core.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;

namespace boardgames.match.commands
{
	// Token: 0x02000296 RID: 662
	public class DBGPassToPlayerCommand : Command
	{
		// Token: 0x06001F1C RID: 7964 RVA: 0x0008558C File Offset: 0x0008378C
		// Note: this type is marked as 'beforefieldinit'.
		static DBGPassToPlayerCommand()
		{
			Il2CppClassPointerStore<DBGPassToPlayerCommand>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.match.commands", "DBGPassToPlayerCommand");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DBGPassToPlayerCommand>.NativeClassPtr);
			DBGPassToPlayerCommand.NativeFieldInfoPtr_NewAccountID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGPassToPlayerCommand>.NativeClassPtr, "NewAccountID");
			DBGPassToPlayerCommand.NativeFieldInfoPtr_NewName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGPassToPlayerCommand>.NativeClassPtr, "NewName");
			DBGPassToPlayerCommand.NativeMethodInfoPtr__ctor_Public_Void_PassToPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGPassToPlayerCommand>.NativeClassPtr, 100668493);
			DBGPassToPlayerCommand.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGPassToPlayerCommand>.NativeClassPtr, 100668494);
		}

		// Token: 0x06001F1D RID: 7965 RVA: 0x0008560C File Offset: 0x0008380C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 540808, XrefRangeEnd = 540812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DBGPassToPlayerCommand(PassToPlayer msg)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DBGPassToPlayerCommand>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(msg);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGPassToPlayerCommand.NativeMethodInfoPtr__ctor_Public_Void_PassToPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001F1E RID: 7966 RVA: 0x00085658 File Offset: 0x00083858
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 540812, XrefRangeEnd = 540816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DBGPassToPlayerCommand.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001F1F RID: 7967 RVA: 0x000105B4 File Offset: 0x0000E7B4
		public DBGPassToPlayerCommand(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000840 RID: 2112
		// (get) Token: 0x06001F20 RID: 7968 RVA: 0x000856A4 File Offset: 0x000838A4
		// (set) Token: 0x06001F21 RID: 7969 RVA: 0x000105BD File Offset: 0x0000E7BD
		public unsafe AccountID NewAccountID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGPassToPlayerCommand.NativeFieldInfoPtr_NewAccountID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGPassToPlayerCommand.NativeFieldInfoPtr_NewAccountID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000841 RID: 2113
		// (get) Token: 0x06001F22 RID: 7970 RVA: 0x000856D4 File Offset: 0x000838D4
		// (set) Token: 0x06001F23 RID: 7971 RVA: 0x000105DC File Offset: 0x0000E7DC
		public unsafe string NewName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGPassToPlayerCommand.NativeFieldInfoPtr_NewName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGPassToPlayerCommand.NativeFieldInfoPtr_NewName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040013A7 RID: 5031
		private static readonly IntPtr NativeFieldInfoPtr_NewAccountID;

		// Token: 0x040013A8 RID: 5032
		private static readonly IntPtr NativeFieldInfoPtr_NewName;

		// Token: 0x040013A9 RID: 5033
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_PassToPlayer_0;

		// Token: 0x040013AA RID: 5034
		private static readonly IntPtr NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0;

		// Token: 0x02000493 RID: 1171
		[ObfuscatedName("boardgames.match.commands.DBGPassToPlayerCommand+<execute>d__3")]
		public sealed class _execute_d__3 : Object
		{
			// Token: 0x0600378E RID: 14222 RVA: 0x000CE814 File Offset: 0x000CCA14
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__3()
			{
				Il2CppClassPointerStore<DBGPassToPlayerCommand._execute_d__3>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DBGPassToPlayerCommand>.NativeClassPtr, "<execute>d__3");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DBGPassToPlayerCommand._execute_d__3>.NativeClassPtr);
				DBGPassToPlayerCommand._execute_d__3.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGPassToPlayerCommand._execute_d__3>.NativeClassPtr, "<>1__state");
				DBGPassToPlayerCommand._execute_d__3.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGPassToPlayerCommand._execute_d__3>.NativeClassPtr, "<>2__current");
				DBGPassToPlayerCommand._execute_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGPassToPlayerCommand._execute_d__3>.NativeClassPtr, 100668495);
				DBGPassToPlayerCommand._execute_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGPassToPlayerCommand._execute_d__3>.NativeClassPtr, 100668496);
				DBGPassToPlayerCommand._execute_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGPassToPlayerCommand._execute_d__3>.NativeClassPtr, 100668497);
				DBGPassToPlayerCommand._execute_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGPassToPlayerCommand._execute_d__3>.NativeClassPtr, 100668498);
				DBGPassToPlayerCommand._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGPassToPlayerCommand._execute_d__3>.NativeClassPtr, 100668499);
				DBGPassToPlayerCommand._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGPassToPlayerCommand._execute_d__3>.NativeClassPtr, 100668500);
			}

			// Token: 0x0600378F RID: 14223 RVA: 0x000CE8E0 File Offset: 0x000CCAE0
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__3(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DBGPassToPlayerCommand._execute_d__3>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGPassToPlayerCommand._execute_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003790 RID: 14224 RVA: 0x000CE928 File Offset: 0x000CCB28
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGPassToPlayerCommand._execute_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003791 RID: 14225 RVA: 0x000CE95C File Offset: 0x000CCB5C
			[CallerCount(0)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGPassToPlayerCommand._execute_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001065 RID: 4197
			// (get) Token: 0x06003792 RID: 14226 RVA: 0x000CE998 File Offset: 0x000CCB98
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGPassToPlayerCommand._execute_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06003793 RID: 14227 RVA: 0x000CE9D8 File Offset: 0x000CCBD8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 540803, XrefRangeEnd = 540808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGPassToPlayerCommand._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001066 RID: 4198
			// (get) Token: 0x06003794 RID: 14228 RVA: 0x000CEA0C File Offset: 0x000CCC0C
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGPassToPlayerCommand._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06003795 RID: 14229 RVA: 0x0001C918 File Offset: 0x0001AB18
			public _execute_d__3(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001063 RID: 4195
			// (get) Token: 0x06003796 RID: 14230 RVA: 0x000CEA4C File Offset: 0x000CCC4C
			// (set) Token: 0x06003797 RID: 14231 RVA: 0x0001C921 File Offset: 0x0001AB21
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGPassToPlayerCommand._execute_d__3.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGPassToPlayerCommand._execute_d__3.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001064 RID: 4196
			// (get) Token: 0x06003798 RID: 14232 RVA: 0x000CEA74 File Offset: 0x000CCC74
			// (set) Token: 0x06003799 RID: 14233 RVA: 0x0001C93C File Offset: 0x0001AB3C
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGPassToPlayerCommand._execute_d__3.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGPassToPlayerCommand._execute_d__3.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400222E RID: 8750
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400222F RID: 8751
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04002230 RID: 8752
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04002231 RID: 8753
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002232 RID: 8754
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04002233 RID: 8755
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04002234 RID: 8756
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002235 RID: 8757
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
