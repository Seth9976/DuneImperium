using System;
using dwd.core.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;

namespace platformCore.scoreboard
{
	// Token: 0x0200000A RID: 10
	public class RecordScoreboardEvent : Command
	{
		// Token: 0x06000054 RID: 84 RVA: 0x000041B8 File Offset: 0x000023B8
		// Note: this type is marked as 'beforefieldinit'.
		static RecordScoreboardEvent()
		{
			Il2CppClassPointerStore<RecordScoreboardEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("platformCore.dll", "platformCore.scoreboard", "RecordScoreboardEvent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RecordScoreboardEvent>.NativeClassPtr);
			RecordScoreboardEvent.NativeFieldInfoPtr_evt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RecordScoreboardEvent>.NativeClassPtr, "evt");
			RecordScoreboardEvent.NativeFieldInfoPtr_delta = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RecordScoreboardEvent>.NativeClassPtr, "delta");
			RecordScoreboardEvent.NativeFieldInfoPtr_flushWhenDone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RecordScoreboardEvent>.NativeClassPtr, "flushWhenDone");
			RecordScoreboardEvent.NativeFieldInfoPtr_Account = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RecordScoreboardEvent>.NativeClassPtr, "Account");
			RecordScoreboardEvent.NativeFieldInfoPtr_URL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RecordScoreboardEvent>.NativeClassPtr, "URL");
			RecordScoreboardEvent.NativeFieldInfoPtr_Client = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RecordScoreboardEvent>.NativeClassPtr, "Client");
			RecordScoreboardEvent.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_String_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RecordScoreboardEvent>.NativeClassPtr, 100663343);
			RecordScoreboardEvent.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RecordScoreboardEvent>.NativeClassPtr, 100663344);
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00004288 File Offset: 0x00002488
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1250111, RefRangeEnd = 1250113, XrefRangeStart = 1250106, XrefRangeEnd = 1250111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RecordScoreboardEvent(string evt, int delta, string account, string url, string client, bool flushWhenDone = true)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RecordScoreboardEvent>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(evt);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref delta;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(account);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(url);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(client);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flushWhenDone;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RecordScoreboardEvent.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_String_String_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00004328 File Offset: 0x00002528
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1250113, XrefRangeEnd = 1250118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RecordScoreboardEvent.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000057 RID: 87 RVA: 0x00002366 File Offset: 0x00000566
		public RecordScoreboardEvent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000058 RID: 88 RVA: 0x00004374 File Offset: 0x00002574
		// (set) Token: 0x06000059 RID: 89 RVA: 0x0000236F File Offset: 0x0000056F
		public unsafe string evt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecordScoreboardEvent.NativeFieldInfoPtr_evt);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecordScoreboardEvent.NativeFieldInfoPtr_evt), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x0600005A RID: 90 RVA: 0x0000439C File Offset: 0x0000259C
		// (set) Token: 0x0600005B RID: 91 RVA: 0x0000238E File Offset: 0x0000058E
		public unsafe int delta
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecordScoreboardEvent.NativeFieldInfoPtr_delta);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecordScoreboardEvent.NativeFieldInfoPtr_delta)) = value;
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x0600005C RID: 92 RVA: 0x000043C4 File Offset: 0x000025C4
		// (set) Token: 0x0600005D RID: 93 RVA: 0x000023A9 File Offset: 0x000005A9
		public unsafe bool flushWhenDone
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecordScoreboardEvent.NativeFieldInfoPtr_flushWhenDone);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecordScoreboardEvent.NativeFieldInfoPtr_flushWhenDone)) = value;
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x0600005E RID: 94 RVA: 0x000043EC File Offset: 0x000025EC
		// (set) Token: 0x0600005F RID: 95 RVA: 0x000023C4 File Offset: 0x000005C4
		public unsafe string Account
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecordScoreboardEvent.NativeFieldInfoPtr_Account);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecordScoreboardEvent.NativeFieldInfoPtr_Account), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000060 RID: 96 RVA: 0x00004414 File Offset: 0x00002614
		// (set) Token: 0x06000061 RID: 97 RVA: 0x000023E3 File Offset: 0x000005E3
		public unsafe string URL
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecordScoreboardEvent.NativeFieldInfoPtr_URL);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecordScoreboardEvent.NativeFieldInfoPtr_URL), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000062 RID: 98 RVA: 0x0000443C File Offset: 0x0000263C
		// (set) Token: 0x06000063 RID: 99 RVA: 0x00002402 File Offset: 0x00000602
		public unsafe string Client
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecordScoreboardEvent.NativeFieldInfoPtr_Client);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecordScoreboardEvent.NativeFieldInfoPtr_Client), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400002F RID: 47
		private static readonly IntPtr NativeFieldInfoPtr_evt;

		// Token: 0x04000030 RID: 48
		private static readonly IntPtr NativeFieldInfoPtr_delta;

		// Token: 0x04000031 RID: 49
		private static readonly IntPtr NativeFieldInfoPtr_flushWhenDone;

		// Token: 0x04000032 RID: 50
		private static readonly IntPtr NativeFieldInfoPtr_Account;

		// Token: 0x04000033 RID: 51
		private static readonly IntPtr NativeFieldInfoPtr_URL;

		// Token: 0x04000034 RID: 52
		private static readonly IntPtr NativeFieldInfoPtr_Client;

		// Token: 0x04000035 RID: 53
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Int32_String_String_String_Boolean_0;

		// Token: 0x04000036 RID: 54
		private static readonly IntPtr NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0;

		// Token: 0x02000019 RID: 25
		[ObfuscatedName("platformCore.scoreboard.RecordScoreboardEvent+<execute>d__7")]
		public sealed class _execute_d__7 : Object
		{
			// Token: 0x06000142 RID: 322 RVA: 0x00006E24 File Offset: 0x00005024
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__7()
			{
				Il2CppClassPointerStore<RecordScoreboardEvent._execute_d__7>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RecordScoreboardEvent>.NativeClassPtr, "<execute>d__7");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RecordScoreboardEvent._execute_d__7>.NativeClassPtr);
				RecordScoreboardEvent._execute_d__7.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RecordScoreboardEvent._execute_d__7>.NativeClassPtr, "<>1__state");
				RecordScoreboardEvent._execute_d__7.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RecordScoreboardEvent._execute_d__7>.NativeClassPtr, "<>2__current");
				RecordScoreboardEvent._execute_d__7.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RecordScoreboardEvent._execute_d__7>.NativeClassPtr, "<>4__this");
				RecordScoreboardEvent._execute_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RecordScoreboardEvent._execute_d__7>.NativeClassPtr, 100663345);
				RecordScoreboardEvent._execute_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RecordScoreboardEvent._execute_d__7>.NativeClassPtr, 100663346);
				RecordScoreboardEvent._execute_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RecordScoreboardEvent._execute_d__7>.NativeClassPtr, 100663347);
				RecordScoreboardEvent._execute_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RecordScoreboardEvent._execute_d__7>.NativeClassPtr, 100663348);
				RecordScoreboardEvent._execute_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RecordScoreboardEvent._execute_d__7>.NativeClassPtr, 100663349);
				RecordScoreboardEvent._execute_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RecordScoreboardEvent._execute_d__7>.NativeClassPtr, 100663350);
			}

			// Token: 0x06000143 RID: 323 RVA: 0x00006F04 File Offset: 0x00005104
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__7(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RecordScoreboardEvent._execute_d__7>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RecordScoreboardEvent._execute_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000144 RID: 324 RVA: 0x00006F4C File Offset: 0x0000514C
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RecordScoreboardEvent._execute_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000145 RID: 325 RVA: 0x00006F80 File Offset: 0x00005180
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1250046, XrefRangeEnd = 1250101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RecordScoreboardEvent._execute_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000067 RID: 103
			// (get) Token: 0x06000146 RID: 326 RVA: 0x00006FBC File Offset: 0x000051BC
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RecordScoreboardEvent._execute_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000147 RID: 327 RVA: 0x00006FFC File Offset: 0x000051FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1250101, XrefRangeEnd = 1250106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RecordScoreboardEvent._execute_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000068 RID: 104
			// (get) Token: 0x06000148 RID: 328 RVA: 0x00007030 File Offset: 0x00005230
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RecordScoreboardEvent._execute_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000149 RID: 329 RVA: 0x00002C2D File Offset: 0x00000E2D
			public _execute_d__7(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000064 RID: 100
			// (get) Token: 0x0600014A RID: 330 RVA: 0x00007070 File Offset: 0x00005270
			// (set) Token: 0x0600014B RID: 331 RVA: 0x00002C36 File Offset: 0x00000E36
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecordScoreboardEvent._execute_d__7.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecordScoreboardEvent._execute_d__7.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000065 RID: 101
			// (get) Token: 0x0600014C RID: 332 RVA: 0x00007098 File Offset: 0x00005298
			// (set) Token: 0x0600014D RID: 333 RVA: 0x00002C51 File Offset: 0x00000E51
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecordScoreboardEvent._execute_d__7.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecordScoreboardEvent._execute_d__7.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000066 RID: 102
			// (get) Token: 0x0600014E RID: 334 RVA: 0x000070C8 File Offset: 0x000052C8
			// (set) Token: 0x0600014F RID: 335 RVA: 0x00002C70 File Offset: 0x00000E70
			public unsafe RecordScoreboardEvent __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecordScoreboardEvent._execute_d__7.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RecordScoreboardEvent>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecordScoreboardEvent._execute_d__7.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040000BC RID: 188
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040000BD RID: 189
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040000BE RID: 190
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040000BF RID: 191
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040000C0 RID: 192
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040000C1 RID: 193
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040000C2 RID: 194
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040000C3 RID: 195
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040000C4 RID: 196
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
