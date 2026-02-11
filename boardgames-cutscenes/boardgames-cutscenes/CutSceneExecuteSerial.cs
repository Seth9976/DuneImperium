using System;
using dwd.core.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace lotus
{
	// Token: 0x0200000A RID: 10
	public class CutSceneExecuteSerial : Command
	{
		// Token: 0x06000050 RID: 80 RVA: 0x00003E38 File Offset: 0x00002038
		// Note: this type is marked as 'beforefieldinit'.
		static CutSceneExecuteSerial()
		{
			Il2CppClassPointerStore<CutSceneExecuteSerial>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames-cutscenes.dll", "lotus", "CutSceneExecuteSerial");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CutSceneExecuteSerial>.NativeClassPtr);
			CutSceneExecuteSerial.NativeFieldInfoPtr_commands = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CutSceneExecuteSerial>.NativeClassPtr, "commands");
			CutSceneExecuteSerial.NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_CutSceneCommand_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CutSceneExecuteSerial>.NativeClassPtr, 100663357);
			CutSceneExecuteSerial.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CutSceneExecuteSerial>.NativeClassPtr, 100663358);
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00003EA4 File Offset: 0x000020A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1258207, XrefRangeEnd = 1258215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CutSceneExecuteSerial(IEnumerable<CutSceneCommand> commands)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CutSceneExecuteSerial>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(commands);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CutSceneExecuteSerial.NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_CutSceneCommand_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00003EF0 File Offset: 0x000020F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1258215, XrefRangeEnd = 1258220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CutSceneExecuteSerial.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00002225 File Offset: 0x00000425
		public CutSceneExecuteSerial(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000054 RID: 84 RVA: 0x00003F3C File Offset: 0x0000213C
		// (set) Token: 0x06000055 RID: 85 RVA: 0x0000222E File Offset: 0x0000042E
		public unsafe List<CutSceneCommand> commands
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CutSceneExecuteSerial.NativeFieldInfoPtr_commands);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<CutSceneCommand>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CutSceneExecuteSerial.NativeFieldInfoPtr_commands), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000032 RID: 50
		private static readonly IntPtr NativeFieldInfoPtr_commands;

		// Token: 0x04000033 RID: 51
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_CutSceneCommand_0;

		// Token: 0x04000034 RID: 52
		private static readonly IntPtr NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0;

		// Token: 0x02000025 RID: 37
		[ObfuscatedName("lotus.CutSceneExecuteSerial+<execute>d__2")]
		public sealed class _execute_d__2 : Object
		{
			// Token: 0x0600014A RID: 330 RVA: 0x000070B0 File Offset: 0x000052B0
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__2()
			{
				Il2CppClassPointerStore<CutSceneExecuteSerial._execute_d__2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CutSceneExecuteSerial>.NativeClassPtr, "<execute>d__2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CutSceneExecuteSerial._execute_d__2>.NativeClassPtr);
				CutSceneExecuteSerial._execute_d__2.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CutSceneExecuteSerial._execute_d__2>.NativeClassPtr, "<>1__state");
				CutSceneExecuteSerial._execute_d__2.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CutSceneExecuteSerial._execute_d__2>.NativeClassPtr, "<>2__current");
				CutSceneExecuteSerial._execute_d__2.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CutSceneExecuteSerial._execute_d__2>.NativeClassPtr, "<>4__this");
				CutSceneExecuteSerial._execute_d__2.NativeFieldInfoPtr__i_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CutSceneExecuteSerial._execute_d__2>.NativeClassPtr, "<i>5__2");
				CutSceneExecuteSerial._execute_d__2.NativeFieldInfoPtr__cutSceneCommand_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CutSceneExecuteSerial._execute_d__2>.NativeClassPtr, "<cutSceneCommand>5__3");
				CutSceneExecuteSerial._execute_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CutSceneExecuteSerial._execute_d__2>.NativeClassPtr, 100663359);
				CutSceneExecuteSerial._execute_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CutSceneExecuteSerial._execute_d__2>.NativeClassPtr, 100663360);
				CutSceneExecuteSerial._execute_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CutSceneExecuteSerial._execute_d__2>.NativeClassPtr, 100663361);
				CutSceneExecuteSerial._execute_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CutSceneExecuteSerial._execute_d__2>.NativeClassPtr, 100663362);
				CutSceneExecuteSerial._execute_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CutSceneExecuteSerial._execute_d__2>.NativeClassPtr, 100663363);
				CutSceneExecuteSerial._execute_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CutSceneExecuteSerial._execute_d__2>.NativeClassPtr, 100663364);
			}

			// Token: 0x0600014B RID: 331 RVA: 0x000071B8 File Offset: 0x000053B8
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__2(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CutSceneExecuteSerial._execute_d__2>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CutSceneExecuteSerial._execute_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600014C RID: 332 RVA: 0x00007200 File Offset: 0x00005400
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CutSceneExecuteSerial._execute_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600014D RID: 333 RVA: 0x00007234 File Offset: 0x00005434
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1258191, XrefRangeEnd = 1258202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CutSceneExecuteSerial._execute_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000051 RID: 81
			// (get) Token: 0x0600014E RID: 334 RVA: 0x00007270 File Offset: 0x00005470
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CutSceneExecuteSerial._execute_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600014F RID: 335 RVA: 0x000072B0 File Offset: 0x000054B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1258202, XrefRangeEnd = 1258207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CutSceneExecuteSerial._execute_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000052 RID: 82
			// (get) Token: 0x06000150 RID: 336 RVA: 0x000072E4 File Offset: 0x000054E4
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CutSceneExecuteSerial._execute_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000151 RID: 337 RVA: 0x000028D5 File Offset: 0x00000AD5
			public _execute_d__2(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700004C RID: 76
			// (get) Token: 0x06000152 RID: 338 RVA: 0x00007324 File Offset: 0x00005524
			// (set) Token: 0x06000153 RID: 339 RVA: 0x000028DE File Offset: 0x00000ADE
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CutSceneExecuteSerial._execute_d__2.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CutSceneExecuteSerial._execute_d__2.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700004D RID: 77
			// (get) Token: 0x06000154 RID: 340 RVA: 0x0000734C File Offset: 0x0000554C
			// (set) Token: 0x06000155 RID: 341 RVA: 0x000028F9 File Offset: 0x00000AF9
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CutSceneExecuteSerial._execute_d__2.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CutSceneExecuteSerial._execute_d__2.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700004E RID: 78
			// (get) Token: 0x06000156 RID: 342 RVA: 0x0000737C File Offset: 0x0000557C
			// (set) Token: 0x06000157 RID: 343 RVA: 0x00002918 File Offset: 0x00000B18
			public unsafe CutSceneExecuteSerial __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CutSceneExecuteSerial._execute_d__2.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CutSceneExecuteSerial>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CutSceneExecuteSerial._execute_d__2.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700004F RID: 79
			// (get) Token: 0x06000158 RID: 344 RVA: 0x000073AC File Offset: 0x000055AC
			// (set) Token: 0x06000159 RID: 345 RVA: 0x00002937 File Offset: 0x00000B37
			public unsafe int _i_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CutSceneExecuteSerial._execute_d__2.NativeFieldInfoPtr__i_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CutSceneExecuteSerial._execute_d__2.NativeFieldInfoPtr__i_5__2)) = value;
				}
			}

			// Token: 0x17000050 RID: 80
			// (get) Token: 0x0600015A RID: 346 RVA: 0x000073D4 File Offset: 0x000055D4
			// (set) Token: 0x0600015B RID: 347 RVA: 0x00002952 File Offset: 0x00000B52
			public unsafe CutSceneCommand _cutSceneCommand_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CutSceneExecuteSerial._execute_d__2.NativeFieldInfoPtr__cutSceneCommand_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CutSceneCommand>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CutSceneExecuteSerial._execute_d__2.NativeFieldInfoPtr__cutSceneCommand_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040000C5 RID: 197
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040000C6 RID: 198
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040000C7 RID: 199
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040000C8 RID: 200
			private static readonly IntPtr NativeFieldInfoPtr__i_5__2;

			// Token: 0x040000C9 RID: 201
			private static readonly IntPtr NativeFieldInfoPtr__cutSceneCommand_5__3;

			// Token: 0x040000CA RID: 202
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040000CB RID: 203
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040000CC RID: 204
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040000CD RID: 205
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040000CE RID: 206
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040000CF RID: 207
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
