using System;
using dwd.core.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;

namespace boardgames.match.commands
{
	// Token: 0x0200028B RID: 651
	public class DBGLeaveMatchDueToError : Command
	{
		// Token: 0x06001EA0 RID: 7840 RVA: 0x0008385C File Offset: 0x00081A5C
		// Note: this type is marked as 'beforefieldinit'.
		static DBGLeaveMatchDueToError()
		{
			Il2CppClassPointerStore<DBGLeaveMatchDueToError>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.match.commands", "DBGLeaveMatchDueToError");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DBGLeaveMatchDueToError>.NativeClassPtr);
			DBGLeaveMatchDueToError.NativeFieldInfoPtr_errorKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGLeaveMatchDueToError>.NativeClassPtr, "errorKey");
			DBGLeaveMatchDueToError.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGLeaveMatchDueToError>.NativeClassPtr, 100668323);
			DBGLeaveMatchDueToError.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGLeaveMatchDueToError>.NativeClassPtr, 100668324);
		}

		// Token: 0x06001EA1 RID: 7841 RVA: 0x000838C8 File Offset: 0x00081AC8
		[CallerCount(37)]
		[CachedScanResults(RefRangeStart = 495009, RefRangeEnd = 495046, XrefRangeStart = 495009, XrefRangeEnd = 495046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DBGLeaveMatchDueToError(string errorKey)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DBGLeaveMatchDueToError>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(errorKey);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGLeaveMatchDueToError.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001EA2 RID: 7842 RVA: 0x00083914 File Offset: 0x00081B14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 539411, XrefRangeEnd = 539416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DBGLeaveMatchDueToError.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001EA3 RID: 7843 RVA: 0x000102B6 File Offset: 0x0000E4B6
		public DBGLeaveMatchDueToError(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000824 RID: 2084
		// (get) Token: 0x06001EA4 RID: 7844 RVA: 0x00083960 File Offset: 0x00081B60
		// (set) Token: 0x06001EA5 RID: 7845 RVA: 0x000102BF File Offset: 0x0000E4BF
		public unsafe string errorKey
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGLeaveMatchDueToError.NativeFieldInfoPtr_errorKey);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGLeaveMatchDueToError.NativeFieldInfoPtr_errorKey), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04001356 RID: 4950
		private static readonly IntPtr NativeFieldInfoPtr_errorKey;

		// Token: 0x04001357 RID: 4951
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04001358 RID: 4952
		private static readonly IntPtr NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0;

		// Token: 0x0200047F RID: 1151
		[ObfuscatedName("boardgames.match.commands.DBGLeaveMatchDueToError+<execute>d__2")]
		public sealed class _execute_d__2 : Object
		{
			// Token: 0x06003669 RID: 13929 RVA: 0x000CB008 File Offset: 0x000C9208
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__2()
			{
				Il2CppClassPointerStore<DBGLeaveMatchDueToError._execute_d__2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DBGLeaveMatchDueToError>.NativeClassPtr, "<execute>d__2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DBGLeaveMatchDueToError._execute_d__2>.NativeClassPtr);
				DBGLeaveMatchDueToError._execute_d__2.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGLeaveMatchDueToError._execute_d__2>.NativeClassPtr, "<>1__state");
				DBGLeaveMatchDueToError._execute_d__2.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGLeaveMatchDueToError._execute_d__2>.NativeClassPtr, "<>2__current");
				DBGLeaveMatchDueToError._execute_d__2.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGLeaveMatchDueToError._execute_d__2>.NativeClassPtr, "<>4__this");
				DBGLeaveMatchDueToError._execute_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGLeaveMatchDueToError._execute_d__2>.NativeClassPtr, 100668325);
				DBGLeaveMatchDueToError._execute_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGLeaveMatchDueToError._execute_d__2>.NativeClassPtr, 100668326);
				DBGLeaveMatchDueToError._execute_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGLeaveMatchDueToError._execute_d__2>.NativeClassPtr, 100668327);
				DBGLeaveMatchDueToError._execute_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGLeaveMatchDueToError._execute_d__2>.NativeClassPtr, 100668328);
				DBGLeaveMatchDueToError._execute_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGLeaveMatchDueToError._execute_d__2>.NativeClassPtr, 100668329);
				DBGLeaveMatchDueToError._execute_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGLeaveMatchDueToError._execute_d__2>.NativeClassPtr, 100668330);
			}

			// Token: 0x0600366A RID: 13930 RVA: 0x000CB0E8 File Offset: 0x000C92E8
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__2(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DBGLeaveMatchDueToError._execute_d__2>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGLeaveMatchDueToError._execute_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600366B RID: 13931 RVA: 0x000CB130 File Offset: 0x000C9330
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGLeaveMatchDueToError._execute_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600366C RID: 13932 RVA: 0x000CB164 File Offset: 0x000C9364
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 539356, XrefRangeEnd = 539406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGLeaveMatchDueToError._execute_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000FFD RID: 4093
			// (get) Token: 0x0600366D RID: 13933 RVA: 0x000CB1A0 File Offset: 0x000C93A0
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGLeaveMatchDueToError._execute_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600366E RID: 13934 RVA: 0x000CB1E0 File Offset: 0x000C93E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 539406, XrefRangeEnd = 539411, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGLeaveMatchDueToError._execute_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000FFE RID: 4094
			// (get) Token: 0x0600366F RID: 13935 RVA: 0x000CB214 File Offset: 0x000C9414
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGLeaveMatchDueToError._execute_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06003670 RID: 13936 RVA: 0x0001C052 File Offset: 0x0001A252
			public _execute_d__2(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000FFA RID: 4090
			// (get) Token: 0x06003671 RID: 13937 RVA: 0x000CB254 File Offset: 0x000C9454
			// (set) Token: 0x06003672 RID: 13938 RVA: 0x0001C05B File Offset: 0x0001A25B
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGLeaveMatchDueToError._execute_d__2.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGLeaveMatchDueToError._execute_d__2.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000FFB RID: 4091
			// (get) Token: 0x06003673 RID: 13939 RVA: 0x000CB27C File Offset: 0x000C947C
			// (set) Token: 0x06003674 RID: 13940 RVA: 0x0001C076 File Offset: 0x0001A276
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGLeaveMatchDueToError._execute_d__2.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGLeaveMatchDueToError._execute_d__2.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000FFC RID: 4092
			// (get) Token: 0x06003675 RID: 13941 RVA: 0x000CB2AC File Offset: 0x000C94AC
			// (set) Token: 0x06003676 RID: 13942 RVA: 0x0001C095 File Offset: 0x0001A295
			public unsafe DBGLeaveMatchDueToError __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGLeaveMatchDueToError._execute_d__2.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGLeaveMatchDueToError>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGLeaveMatchDueToError._execute_d__2.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400217A RID: 8570
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400217B RID: 8571
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400217C RID: 8572
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400217D RID: 8573
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400217E RID: 8574
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400217F RID: 8575
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04002180 RID: 8576
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04002181 RID: 8577
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002182 RID: 8578
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
