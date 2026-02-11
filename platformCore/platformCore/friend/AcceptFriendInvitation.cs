using System;
using dwd.core;
using dwd.core.commands;
using dwd.core.platform.providers;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;

namespace platformCore.friend
{
	// Token: 0x0200000E RID: 14
	public class AcceptFriendInvitation : Command
	{
		// Token: 0x060000A0 RID: 160 RVA: 0x000050F4 File Offset: 0x000032F4
		// Note: this type is marked as 'beforefieldinit'.
		static AcceptFriendInvitation()
		{
			Il2CppClassPointerStore<AcceptFriendInvitation>.NativeClassPtr = IL2CPP.GetIl2CppClass("platformCore.dll", "platformCore.friend", "AcceptFriendInvitation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AcceptFriendInvitation>.NativeClassPtr);
			AcceptFriendInvitation.NativeFieldInfoPtr_accountID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AcceptFriendInvitation>.NativeClassPtr, "accountID");
			AcceptFriendInvitation.NativeFieldInfoPtr_error = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AcceptFriendInvitation>.NativeClassPtr, "error");
			AcceptFriendInvitation.NativeFieldInfoPtr_finished = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AcceptFriendInvitation>.NativeClassPtr, "finished");
			AcceptFriendInvitation.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AcceptFriendInvitation>.NativeClassPtr, 100663391);
			AcceptFriendInvitation.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AcceptFriendInvitation>.NativeClassPtr, 100663392);
			AcceptFriendInvitation.NativeMethodInfoPtr_Status_Public_Virtual_Final_New_ErrorInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AcceptFriendInvitation>.NativeClassPtr, 100663393);
			AcceptFriendInvitation.NativeMethodInfoPtr_Interrupted_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AcceptFriendInvitation>.NativeClassPtr, 100663394);
			AcceptFriendInvitation.NativeMethodInfoPtr_gotResponse_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AcceptFriendInvitation>.NativeClassPtr, 100663395);
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x000051C4 File Offset: 0x000033C4
		[CallerCount(37)]
		[CachedScanResults(RefRangeStart = 495009, RefRangeEnd = 495046, XrefRangeStart = 495009, XrefRangeEnd = 495046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AcceptFriendInvitation(string accountID)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AcceptFriendInvitation>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(accountID);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AcceptFriendInvitation.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x00005210 File Offset: 0x00003410
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1250476, XrefRangeEnd = 1250481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AcceptFriendInvitation.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x0000525C File Offset: 0x0000345C
		[CallerCount(0)]
		public unsafe virtual ErrorInfo Status()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AcceptFriendInvitation.NativeMethodInfoPtr_Status_Public_Virtual_Final_New_ErrorInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new ErrorInfo(intPtr);
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x00005294 File Offset: 0x00003494
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1250481, XrefRangeEnd = 1250497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Interrupted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AcceptFriendInvitation.NativeMethodInfoPtr_Interrupted_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x000052C8 File Offset: 0x000034C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1250497, XrefRangeEnd = 1250502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void gotResponse()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AcceptFriendInvitation.NativeMethodInfoPtr_gotResponse_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x0000260C File Offset: 0x0000080C
		public AcceptFriendInvitation(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060000A7 RID: 167 RVA: 0x000052FC File Offset: 0x000034FC
		// (set) Token: 0x060000A8 RID: 168 RVA: 0x00002615 File Offset: 0x00000815
		public unsafe string accountID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AcceptFriendInvitation.NativeFieldInfoPtr_accountID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AcceptFriendInvitation.NativeFieldInfoPtr_accountID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060000A9 RID: 169 RVA: 0x00005324 File Offset: 0x00003524
		// (set) Token: 0x060000AA RID: 170 RVA: 0x00002634 File Offset: 0x00000834
		public ErrorInfo error
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AcceptFriendInvitation.NativeFieldInfoPtr_error);
				return new ErrorInfo(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ErrorInfo>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AcceptFriendInvitation.NativeFieldInfoPtr_error), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ErrorInfo>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060000AB RID: 171 RVA: 0x00005354 File Offset: 0x00003554
		// (set) Token: 0x060000AC RID: 172 RVA: 0x00002662 File Offset: 0x00000862
		public unsafe bool finished
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AcceptFriendInvitation.NativeFieldInfoPtr_finished);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AcceptFriendInvitation.NativeFieldInfoPtr_finished)) = value;
			}
		}

		// Token: 0x0400005E RID: 94
		private static readonly IntPtr NativeFieldInfoPtr_accountID;

		// Token: 0x0400005F RID: 95
		private static readonly IntPtr NativeFieldInfoPtr_error;

		// Token: 0x04000060 RID: 96
		private static readonly IntPtr NativeFieldInfoPtr_finished;

		// Token: 0x04000061 RID: 97
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04000062 RID: 98
		private static readonly IntPtr NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0;

		// Token: 0x04000063 RID: 99
		private static readonly IntPtr NativeMethodInfoPtr_Status_Public_Virtual_Final_New_ErrorInfo_0;

		// Token: 0x04000064 RID: 100
		private static readonly IntPtr NativeMethodInfoPtr_Interrupted_Public_Virtual_Final_New_Void_0;

		// Token: 0x04000065 RID: 101
		private static readonly IntPtr NativeMethodInfoPtr_gotResponse_Private_Void_0;

		// Token: 0x0200001E RID: 30
		[ObfuscatedName("platformCore.friend.AcceptFriendInvitation+<execute>d__4")]
		public sealed class _execute_d__4 : Object
		{
			// Token: 0x06000183 RID: 387 RVA: 0x000079FC File Offset: 0x00005BFC
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__4()
			{
				Il2CppClassPointerStore<AcceptFriendInvitation._execute_d__4>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AcceptFriendInvitation>.NativeClassPtr, "<execute>d__4");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AcceptFriendInvitation._execute_d__4>.NativeClassPtr);
				AcceptFriendInvitation._execute_d__4.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AcceptFriendInvitation._execute_d__4>.NativeClassPtr, "<>1__state");
				AcceptFriendInvitation._execute_d__4.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AcceptFriendInvitation._execute_d__4>.NativeClassPtr, "<>2__current");
				AcceptFriendInvitation._execute_d__4.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AcceptFriendInvitation._execute_d__4>.NativeClassPtr, "<>4__this");
				AcceptFriendInvitation._execute_d__4.NativeFieldInfoPtr__provider_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AcceptFriendInvitation._execute_d__4>.NativeClassPtr, "<provider>5__2");
				AcceptFriendInvitation._execute_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AcceptFriendInvitation._execute_d__4>.NativeClassPtr, 100663396);
				AcceptFriendInvitation._execute_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AcceptFriendInvitation._execute_d__4>.NativeClassPtr, 100663397);
				AcceptFriendInvitation._execute_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AcceptFriendInvitation._execute_d__4>.NativeClassPtr, 100663398);
				AcceptFriendInvitation._execute_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AcceptFriendInvitation._execute_d__4>.NativeClassPtr, 100663399);
				AcceptFriendInvitation._execute_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AcceptFriendInvitation._execute_d__4>.NativeClassPtr, 100663400);
				AcceptFriendInvitation._execute_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AcceptFriendInvitation._execute_d__4>.NativeClassPtr, 100663401);
			}

			// Token: 0x06000184 RID: 388 RVA: 0x00007AF0 File Offset: 0x00005CF0
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__4(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AcceptFriendInvitation._execute_d__4>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AcceptFriendInvitation._execute_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000185 RID: 389 RVA: 0x00007B38 File Offset: 0x00005D38
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AcceptFriendInvitation._execute_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000186 RID: 390 RVA: 0x00007B6C File Offset: 0x00005D6C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1250451, XrefRangeEnd = 1250471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AcceptFriendInvitation._execute_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700007D RID: 125
			// (get) Token: 0x06000187 RID: 391 RVA: 0x00007BA8 File Offset: 0x00005DA8
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AcceptFriendInvitation._execute_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000188 RID: 392 RVA: 0x00007BE8 File Offset: 0x00005DE8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1250471, XrefRangeEnd = 1250476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AcceptFriendInvitation._execute_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700007E RID: 126
			// (get) Token: 0x06000189 RID: 393 RVA: 0x00007C1C File Offset: 0x00005E1C
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AcceptFriendInvitation._execute_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600018A RID: 394 RVA: 0x00002DEC File Offset: 0x00000FEC
			public _execute_d__4(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000079 RID: 121
			// (get) Token: 0x0600018B RID: 395 RVA: 0x00007C5C File Offset: 0x00005E5C
			// (set) Token: 0x0600018C RID: 396 RVA: 0x00002DF5 File Offset: 0x00000FF5
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AcceptFriendInvitation._execute_d__4.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AcceptFriendInvitation._execute_d__4.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700007A RID: 122
			// (get) Token: 0x0600018D RID: 397 RVA: 0x00007C84 File Offset: 0x00005E84
			// (set) Token: 0x0600018E RID: 398 RVA: 0x00002E10 File Offset: 0x00001010
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AcceptFriendInvitation._execute_d__4.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AcceptFriendInvitation._execute_d__4.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700007B RID: 123
			// (get) Token: 0x0600018F RID: 399 RVA: 0x00007CB4 File Offset: 0x00005EB4
			// (set) Token: 0x06000190 RID: 400 RVA: 0x00002E2F File Offset: 0x0000102F
			public unsafe AcceptFriendInvitation __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AcceptFriendInvitation._execute_d__4.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AcceptFriendInvitation>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AcceptFriendInvitation._execute_d__4.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700007C RID: 124
			// (get) Token: 0x06000191 RID: 401 RVA: 0x00007CE4 File Offset: 0x00005EE4
			// (set) Token: 0x06000192 RID: 402 RVA: 0x00002E4E File Offset: 0x0000104E
			public unsafe PlatformProvider _provider_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AcceptFriendInvitation._execute_d__4.NativeFieldInfoPtr__provider_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlatformProvider>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AcceptFriendInvitation._execute_d__4.NativeFieldInfoPtr__provider_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040000E2 RID: 226
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040000E3 RID: 227
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040000E4 RID: 228
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040000E5 RID: 229
			private static readonly IntPtr NativeFieldInfoPtr__provider_5__2;

			// Token: 0x040000E6 RID: 230
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040000E7 RID: 231
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040000E8 RID: 232
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040000E9 RID: 233
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040000EA RID: 234
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040000EB RID: 235
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
