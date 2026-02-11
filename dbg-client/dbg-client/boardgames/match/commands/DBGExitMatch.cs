using System;
using boardgames.match.data;
using dwd.core.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;

namespace boardgames.match.commands
{
	// Token: 0x0200028A RID: 650
	public class DBGExitMatch : Command
	{
		// Token: 0x06001E97 RID: 7831 RVA: 0x0008368C File Offset: 0x0008188C
		// Note: this type is marked as 'beforefieldinit'.
		static DBGExitMatch()
		{
			Il2CppClassPointerStore<DBGExitMatch>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.match.commands", "DBGExitMatch");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DBGExitMatch>.NativeClassPtr);
			DBGExitMatch.NativeFieldInfoPtr_resign = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGExitMatch>.NativeClassPtr, "resign");
			DBGExitMatch.NativeFieldInfoPtr_ignoreMatchData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGExitMatch>.NativeClassPtr, "ignoreMatchData");
			DBGExitMatch.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGExitMatch>.NativeClassPtr, 100668309);
			DBGExitMatch.NativeMethodInfoPtr__ctor_Public_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGExitMatch>.NativeClassPtr, 100668310);
			DBGExitMatch.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGExitMatch>.NativeClassPtr, 100668311);
		}

		// Token: 0x06001E98 RID: 7832 RVA: 0x00083720 File Offset: 0x00081920
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 539348, RefRangeEnd = 539350, XrefRangeStart = 539347, XrefRangeEnd = 539348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DBGExitMatch(bool resign)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DBGExitMatch>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref resign;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGExitMatch.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001E99 RID: 7833 RVA: 0x00083768 File Offset: 0x00081968
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 539350, XrefRangeEnd = 539351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DBGExitMatch(bool resign, bool ignoreMatchData)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DBGExitMatch>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref resign;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ignoreMatchData;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGExitMatch.NativeMethodInfoPtr__ctor_Public_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E9A RID: 7834 RVA: 0x000837C0 File Offset: 0x000819C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 539351, XrefRangeEnd = 539356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DBGExitMatch.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001E9B RID: 7835 RVA: 0x00010277 File Offset: 0x0000E477
		public DBGExitMatch(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000822 RID: 2082
		// (get) Token: 0x06001E9C RID: 7836 RVA: 0x0008380C File Offset: 0x00081A0C
		// (set) Token: 0x06001E9D RID: 7837 RVA: 0x00010280 File Offset: 0x0000E480
		public unsafe bool resign
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGExitMatch.NativeFieldInfoPtr_resign);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGExitMatch.NativeFieldInfoPtr_resign)) = value;
			}
		}

		// Token: 0x17000823 RID: 2083
		// (get) Token: 0x06001E9E RID: 7838 RVA: 0x00083834 File Offset: 0x00081A34
		// (set) Token: 0x06001E9F RID: 7839 RVA: 0x0001029B File Offset: 0x0000E49B
		public unsafe bool ignoreMatchData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGExitMatch.NativeFieldInfoPtr_ignoreMatchData);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGExitMatch.NativeFieldInfoPtr_ignoreMatchData)) = value;
			}
		}

		// Token: 0x04001351 RID: 4945
		private static readonly IntPtr NativeFieldInfoPtr_resign;

		// Token: 0x04001352 RID: 4946
		private static readonly IntPtr NativeFieldInfoPtr_ignoreMatchData;

		// Token: 0x04001353 RID: 4947
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_0;

		// Token: 0x04001354 RID: 4948
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_Boolean_0;

		// Token: 0x04001355 RID: 4949
		private static readonly IntPtr NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0;

		// Token: 0x0200047C RID: 1148
		[ObfuscatedName("boardgames.match.commands.DBGExitMatch+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06003649 RID: 13897 RVA: 0x000CAA30 File Offset: 0x000C8C30
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<DBGExitMatch.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DBGExitMatch>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DBGExitMatch.__c>.NativeClassPtr);
				DBGExitMatch.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGExitMatch.__c>.NativeClassPtr, "<>9");
				DBGExitMatch.__c.NativeFieldInfoPtr___9__4_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGExitMatch.__c>.NativeClassPtr, "<>9__4_1");
				DBGExitMatch.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGExitMatch.__c>.NativeClassPtr, 100668313);
				DBGExitMatch.__c.NativeMethodInfoPtr__execute_b__4_1_Internal_Boolean_Command_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGExitMatch.__c>.NativeClassPtr, 100668314);
			}

			// Token: 0x0600364A RID: 13898 RVA: 0x000CAAAC File Offset: 0x000C8CAC
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DBGExitMatch.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGExitMatch.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600364B RID: 13899 RVA: 0x000CAAE8 File Offset: 0x000C8CE8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 539248, XrefRangeEnd = 539255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _execute_b__4_1(Command c)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGExitMatch.__c.NativeMethodInfoPtr__execute_b__4_1_Internal_Boolean_Command_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600364C RID: 13900 RVA: 0x0001BF5D File Offset: 0x0001A15D
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000FF0 RID: 4080
			// (get) Token: 0x0600364D RID: 13901 RVA: 0x000CAB38 File Offset: 0x000C8D38
			// (set) Token: 0x0600364E RID: 13902 RVA: 0x0001BF66 File Offset: 0x0001A166
			public unsafe static DBGExitMatch.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DBGExitMatch.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGExitMatch.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DBGExitMatch.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000FF1 RID: 4081
			// (get) Token: 0x0600364F RID: 13903 RVA: 0x000CAB60 File Offset: 0x000C8D60
			// (set) Token: 0x06003650 RID: 13904 RVA: 0x0001BF78 File Offset: 0x0001A178
			public unsafe static Func<Command, bool> __9__4_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DBGExitMatch.__c.NativeFieldInfoPtr___9__4_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Command, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DBGExitMatch.__c.NativeFieldInfoPtr___9__4_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002168 RID: 8552
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04002169 RID: 8553
			private static readonly IntPtr NativeFieldInfoPtr___9__4_1;

			// Token: 0x0400216A RID: 8554
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400216B RID: 8555
			private static readonly IntPtr NativeMethodInfoPtr__execute_b__4_1_Internal_Boolean_Command_0;
		}

		// Token: 0x0200047D RID: 1149
		[ObfuscatedName("boardgames.match.commands.DBGExitMatch+<>c__DisplayClass4_0")]
		public sealed class __c__DisplayClass4_0 : Object
		{
			// Token: 0x06003651 RID: 13905 RVA: 0x000CAB88 File Offset: 0x000C8D88
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass4_0()
			{
				Il2CppClassPointerStore<DBGExitMatch.__c__DisplayClass4_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DBGExitMatch>.NativeClassPtr, "<>c__DisplayClass4_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DBGExitMatch.__c__DisplayClass4_0>.NativeClassPtr);
				DBGExitMatch.__c__DisplayClass4_0.NativeFieldInfoPtr_postMatchCommand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGExitMatch.__c__DisplayClass4_0>.NativeClassPtr, "postMatchCommand");
				DBGExitMatch.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGExitMatch.__c__DisplayClass4_0>.NativeClassPtr, 100668315);
				DBGExitMatch.__c__DisplayClass4_0.NativeMethodInfoPtr__execute_b__0_Internal_IEnumerator_ChangeScene_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGExitMatch.__c__DisplayClass4_0>.NativeClassPtr, 100668316);
			}

			// Token: 0x06003652 RID: 13906 RVA: 0x000CABF0 File Offset: 0x000C8DF0
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass4_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DBGExitMatch.__c__DisplayClass4_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGExitMatch.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003653 RID: 13907 RVA: 0x000CAC2C File Offset: 0x000C8E2C
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator _execute_b__0(ChangeScene _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGExitMatch.__c__DisplayClass4_0.NativeMethodInfoPtr__execute_b__0_Internal_IEnumerator_ChangeScene_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
				}
			}

			// Token: 0x06003654 RID: 13908 RVA: 0x0001BF8A File Offset: 0x0001A18A
			public __c__DisplayClass4_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000FF2 RID: 4082
			// (get) Token: 0x06003655 RID: 13909 RVA: 0x000CAC7C File Offset: 0x000C8E7C
			// (set) Token: 0x06003656 RID: 13910 RVA: 0x0001BF93 File Offset: 0x0001A193
			public unsafe RunPostMatchFlow postMatchCommand
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGExitMatch.__c__DisplayClass4_0.NativeFieldInfoPtr_postMatchCommand);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RunPostMatchFlow>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGExitMatch.__c__DisplayClass4_0.NativeFieldInfoPtr_postMatchCommand), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400216C RID: 8556
			private static readonly IntPtr NativeFieldInfoPtr_postMatchCommand;

			// Token: 0x0400216D RID: 8557
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400216E RID: 8558
			private static readonly IntPtr NativeMethodInfoPtr__execute_b__0_Internal_IEnumerator_ChangeScene_0;
		}

		// Token: 0x0200047E RID: 1150
		[ObfuscatedName("boardgames.match.commands.DBGExitMatch+<execute>d__4")]
		public sealed class _execute_d__4 : Object
		{
			// Token: 0x06003657 RID: 13911 RVA: 0x000CACAC File Offset: 0x000C8EAC
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__4()
			{
				Il2CppClassPointerStore<DBGExitMatch._execute_d__4>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DBGExitMatch>.NativeClassPtr, "<execute>d__4");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DBGExitMatch._execute_d__4>.NativeClassPtr);
				DBGExitMatch._execute_d__4.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGExitMatch._execute_d__4>.NativeClassPtr, "<>1__state");
				DBGExitMatch._execute_d__4.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGExitMatch._execute_d__4>.NativeClassPtr, "<>2__current");
				DBGExitMatch._execute_d__4.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGExitMatch._execute_d__4>.NativeClassPtr, "<>4__this");
				DBGExitMatch._execute_d__4.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGExitMatch._execute_d__4>.NativeClassPtr, "<>8__1");
				DBGExitMatch._execute_d__4.NativeFieldInfoPtr__gameOptionsData_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGExitMatch._execute_d__4>.NativeClassPtr, "<gameOptionsData>5__2");
				DBGExitMatch._execute_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGExitMatch._execute_d__4>.NativeClassPtr, 100668317);
				DBGExitMatch._execute_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGExitMatch._execute_d__4>.NativeClassPtr, 100668318);
				DBGExitMatch._execute_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGExitMatch._execute_d__4>.NativeClassPtr, 100668319);
				DBGExitMatch._execute_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGExitMatch._execute_d__4>.NativeClassPtr, 100668320);
				DBGExitMatch._execute_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGExitMatch._execute_d__4>.NativeClassPtr, 100668321);
				DBGExitMatch._execute_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGExitMatch._execute_d__4>.NativeClassPtr, 100668322);
			}

			// Token: 0x06003658 RID: 13912 RVA: 0x000CADB4 File Offset: 0x000C8FB4
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__4(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DBGExitMatch._execute_d__4>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGExitMatch._execute_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003659 RID: 13913 RVA: 0x000CADFC File Offset: 0x000C8FFC
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGExitMatch._execute_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600365A RID: 13914 RVA: 0x000CAE30 File Offset: 0x000C9030
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 539255, XrefRangeEnd = 539342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGExitMatch._execute_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000FF8 RID: 4088
			// (get) Token: 0x0600365B RID: 13915 RVA: 0x000CAE6C File Offset: 0x000C906C
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGExitMatch._execute_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600365C RID: 13916 RVA: 0x000CAEAC File Offset: 0x000C90AC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 539342, XrefRangeEnd = 539347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGExitMatch._execute_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000FF9 RID: 4089
			// (get) Token: 0x0600365D RID: 13917 RVA: 0x000CAEE0 File Offset: 0x000C90E0
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGExitMatch._execute_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600365E RID: 13918 RVA: 0x0001BFB2 File Offset: 0x0001A1B2
			public _execute_d__4(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000FF3 RID: 4083
			// (get) Token: 0x0600365F RID: 13919 RVA: 0x000CAF20 File Offset: 0x000C9120
			// (set) Token: 0x06003660 RID: 13920 RVA: 0x0001BFBB File Offset: 0x0001A1BB
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGExitMatch._execute_d__4.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGExitMatch._execute_d__4.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000FF4 RID: 4084
			// (get) Token: 0x06003661 RID: 13921 RVA: 0x000CAF48 File Offset: 0x000C9148
			// (set) Token: 0x06003662 RID: 13922 RVA: 0x0001BFD6 File Offset: 0x0001A1D6
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGExitMatch._execute_d__4.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGExitMatch._execute_d__4.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000FF5 RID: 4085
			// (get) Token: 0x06003663 RID: 13923 RVA: 0x000CAF78 File Offset: 0x000C9178
			// (set) Token: 0x06003664 RID: 13924 RVA: 0x0001BFF5 File Offset: 0x0001A1F5
			public unsafe DBGExitMatch __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGExitMatch._execute_d__4.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGExitMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGExitMatch._execute_d__4.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000FF6 RID: 4086
			// (get) Token: 0x06003665 RID: 13925 RVA: 0x000CAFA8 File Offset: 0x000C91A8
			// (set) Token: 0x06003666 RID: 13926 RVA: 0x0001C014 File Offset: 0x0001A214
			public unsafe DBGExitMatch.__c__DisplayClass4_0 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGExitMatch._execute_d__4.NativeFieldInfoPtr___8__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGExitMatch.__c__DisplayClass4_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGExitMatch._execute_d__4.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000FF7 RID: 4087
			// (get) Token: 0x06003667 RID: 13927 RVA: 0x000CAFD8 File Offset: 0x000C91D8
			// (set) Token: 0x06003668 RID: 13928 RVA: 0x0001C033 File Offset: 0x0001A233
			public unsafe GameOptionsData _gameOptionsData_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGExitMatch._execute_d__4.NativeFieldInfoPtr__gameOptionsData_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameOptionsData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGExitMatch._execute_d__4.NativeFieldInfoPtr__gameOptionsData_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400216F RID: 8559
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04002170 RID: 8560
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04002171 RID: 8561
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04002172 RID: 8562
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x04002173 RID: 8563
			private static readonly IntPtr NativeFieldInfoPtr__gameOptionsData_5__2;

			// Token: 0x04002174 RID: 8564
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04002175 RID: 8565
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002176 RID: 8566
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04002177 RID: 8567
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04002178 RID: 8568
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002179 RID: 8569
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
