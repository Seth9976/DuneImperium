using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;

namespace dwd.core.commands
{
	// Token: 0x02000021 RID: 33
	public class TimedWarningCommand : Command
	{
		// Token: 0x0600014D RID: 333 RVA: 0x0000A290 File Offset: 0x00008490
		// Note: this type is marked as 'beforefieldinit'.
		static TimedWarningCommand()
		{
			Il2CppClassPointerStore<TimedWarningCommand>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-commands.dll", "dwd.core.commands", "TimedWarningCommand");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TimedWarningCommand>.NativeClassPtr);
			TimedWarningCommand.NativeFieldInfoPtr_command = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimedWarningCommand>.NativeClassPtr, "command");
			TimedWarningCommand.NativeFieldInfoPtr_warnAfter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimedWarningCommand>.NativeClassPtr, "warnAfter");
			TimedWarningCommand.NativeFieldInfoPtr_message = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimedWarningCommand>.NativeClassPtr, "message");
			TimedWarningCommand.NativeFieldInfoPtr_asError = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimedWarningCommand>.NativeClassPtr, "asError");
			TimedWarningCommand.NativeMethodInfoPtr__ctor_Public_Void_Command_Single_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimedWarningCommand>.NativeClassPtr, 100663687);
			TimedWarningCommand.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimedWarningCommand>.NativeClassPtr, 100663688);
		}

		// Token: 0x0600014E RID: 334 RVA: 0x0000A338 File Offset: 0x00008538
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1209179, XrefRangeEnd = 1209186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TimedWarningCommand(Command command, float warnAfter, string message, bool asError)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TimedWarningCommand>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(command);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref warnAfter;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref asError;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimedWarningCommand.NativeMethodInfoPtr__ctor_Public_Void_Command_Single_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600014F RID: 335 RVA: 0x0000A3B4 File Offset: 0x000085B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1209186, XrefRangeEnd = 1209191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TimedWarningCommand.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000150 RID: 336 RVA: 0x000027DC File Offset: 0x000009DC
		public TimedWarningCommand(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x06000151 RID: 337 RVA: 0x0000A400 File Offset: 0x00008600
		// (set) Token: 0x06000152 RID: 338 RVA: 0x000027E5 File Offset: 0x000009E5
		public unsafe Command command
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimedWarningCommand.NativeFieldInfoPtr_command);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Command>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimedWarningCommand.NativeFieldInfoPtr_command), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x06000153 RID: 339 RVA: 0x0000A430 File Offset: 0x00008630
		// (set) Token: 0x06000154 RID: 340 RVA: 0x00002804 File Offset: 0x00000A04
		public unsafe float warnAfter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimedWarningCommand.NativeFieldInfoPtr_warnAfter);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimedWarningCommand.NativeFieldInfoPtr_warnAfter)) = value;
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x06000155 RID: 341 RVA: 0x0000A458 File Offset: 0x00008658
		// (set) Token: 0x06000156 RID: 342 RVA: 0x0000281F File Offset: 0x00000A1F
		public unsafe string message
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimedWarningCommand.NativeFieldInfoPtr_message);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimedWarningCommand.NativeFieldInfoPtr_message), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x06000157 RID: 343 RVA: 0x0000A480 File Offset: 0x00008680
		// (set) Token: 0x06000158 RID: 344 RVA: 0x0000283E File Offset: 0x00000A3E
		public unsafe bool asError
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimedWarningCommand.NativeFieldInfoPtr_asError);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimedWarningCommand.NativeFieldInfoPtr_asError)) = value;
			}
		}

		// Token: 0x040000DD RID: 221
		private static readonly IntPtr NativeFieldInfoPtr_command;

		// Token: 0x040000DE RID: 222
		private static readonly IntPtr NativeFieldInfoPtr_warnAfter;

		// Token: 0x040000DF RID: 223
		private static readonly IntPtr NativeFieldInfoPtr_message;

		// Token: 0x040000E0 RID: 224
		private static readonly IntPtr NativeFieldInfoPtr_asError;

		// Token: 0x040000E1 RID: 225
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Command_Single_String_Boolean_0;

		// Token: 0x040000E2 RID: 226
		private static readonly IntPtr NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0;

		// Token: 0x02000083 RID: 131
		[ObfuscatedName("dwd.core.commands.TimedWarningCommand+<execute>d__5")]
		public sealed class _execute_d__5 : Object
		{
			// Token: 0x0600049E RID: 1182 RVA: 0x00015580 File Offset: 0x00013780
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__5()
			{
				Il2CppClassPointerStore<TimedWarningCommand._execute_d__5>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TimedWarningCommand>.NativeClassPtr, "<execute>d__5");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TimedWarningCommand._execute_d__5>.NativeClassPtr);
				TimedWarningCommand._execute_d__5.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimedWarningCommand._execute_d__5>.NativeClassPtr, "<>1__state");
				TimedWarningCommand._execute_d__5.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimedWarningCommand._execute_d__5>.NativeClassPtr, "<>2__current");
				TimedWarningCommand._execute_d__5.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimedWarningCommand._execute_d__5>.NativeClassPtr, "<>4__this");
				TimedWarningCommand._execute_d__5.NativeFieldInfoPtr__endTime_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimedWarningCommand._execute_d__5>.NativeClassPtr, "<endTime>5__2");
				TimedWarningCommand._execute_d__5.NativeFieldInfoPtr__warned_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimedWarningCommand._execute_d__5>.NativeClassPtr, "<warned>5__3");
				TimedWarningCommand._execute_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimedWarningCommand._execute_d__5>.NativeClassPtr, 100663689);
				TimedWarningCommand._execute_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimedWarningCommand._execute_d__5>.NativeClassPtr, 100663690);
				TimedWarningCommand._execute_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimedWarningCommand._execute_d__5>.NativeClassPtr, 100663691);
				TimedWarningCommand._execute_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimedWarningCommand._execute_d__5>.NativeClassPtr, 100663692);
				TimedWarningCommand._execute_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimedWarningCommand._execute_d__5>.NativeClassPtr, 100663693);
				TimedWarningCommand._execute_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimedWarningCommand._execute_d__5>.NativeClassPtr, 100663694);
			}

			// Token: 0x0600049F RID: 1183 RVA: 0x00015688 File Offset: 0x00013888
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__5(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TimedWarningCommand._execute_d__5>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimedWarningCommand._execute_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060004A0 RID: 1184 RVA: 0x000156D0 File Offset: 0x000138D0
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimedWarningCommand._execute_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060004A1 RID: 1185 RVA: 0x00015704 File Offset: 0x00013904
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1209159, XrefRangeEnd = 1209174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimedWarningCommand._execute_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700012F RID: 303
			// (get) Token: 0x060004A2 RID: 1186 RVA: 0x00015740 File Offset: 0x00013940
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimedWarningCommand._execute_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060004A3 RID: 1187 RVA: 0x00015780 File Offset: 0x00013980
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1209174, XrefRangeEnd = 1209179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimedWarningCommand._execute_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000130 RID: 304
			// (get) Token: 0x060004A4 RID: 1188 RVA: 0x000157B4 File Offset: 0x000139B4
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimedWarningCommand._execute_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060004A5 RID: 1189 RVA: 0x00004000 File Offset: 0x00002200
			public _execute_d__5(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700012A RID: 298
			// (get) Token: 0x060004A6 RID: 1190 RVA: 0x000157F4 File Offset: 0x000139F4
			// (set) Token: 0x060004A7 RID: 1191 RVA: 0x00004009 File Offset: 0x00002209
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimedWarningCommand._execute_d__5.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimedWarningCommand._execute_d__5.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700012B RID: 299
			// (get) Token: 0x060004A8 RID: 1192 RVA: 0x0001581C File Offset: 0x00013A1C
			// (set) Token: 0x060004A9 RID: 1193 RVA: 0x00004024 File Offset: 0x00002224
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimedWarningCommand._execute_d__5.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimedWarningCommand._execute_d__5.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700012C RID: 300
			// (get) Token: 0x060004AA RID: 1194 RVA: 0x0001584C File Offset: 0x00013A4C
			// (set) Token: 0x060004AB RID: 1195 RVA: 0x00004043 File Offset: 0x00002243
			public unsafe TimedWarningCommand __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimedWarningCommand._execute_d__5.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TimedWarningCommand>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimedWarningCommand._execute_d__5.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700012D RID: 301
			// (get) Token: 0x060004AC RID: 1196 RVA: 0x0001587C File Offset: 0x00013A7C
			// (set) Token: 0x060004AD RID: 1197 RVA: 0x00004062 File Offset: 0x00002262
			public unsafe float _endTime_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimedWarningCommand._execute_d__5.NativeFieldInfoPtr__endTime_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimedWarningCommand._execute_d__5.NativeFieldInfoPtr__endTime_5__2)) = value;
				}
			}

			// Token: 0x1700012E RID: 302
			// (get) Token: 0x060004AE RID: 1198 RVA: 0x000158A4 File Offset: 0x00013AA4
			// (set) Token: 0x060004AF RID: 1199 RVA: 0x0000407D File Offset: 0x0000227D
			public unsafe bool _warned_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimedWarningCommand._execute_d__5.NativeFieldInfoPtr__warned_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimedWarningCommand._execute_d__5.NativeFieldInfoPtr__warned_5__3)) = value;
				}
			}

			// Token: 0x040002D0 RID: 720
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040002D1 RID: 721
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040002D2 RID: 722
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040002D3 RID: 723
			private static readonly IntPtr NativeFieldInfoPtr__endTime_5__2;

			// Token: 0x040002D4 RID: 724
			private static readonly IntPtr NativeFieldInfoPtr__warned_5__3;

			// Token: 0x040002D5 RID: 725
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040002D6 RID: 726
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040002D7 RID: 727
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040002D8 RID: 728
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040002D9 RID: 729
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040002DA RID: 730
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
