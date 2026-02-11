using System;
using boardgames.ranked.menus;
using dwd.core.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;

namespace boardgames.ranked.commands
{
	// Token: 0x02000036 RID: 54
	public class InitializeRankedCommand : FailableCommand
	{
		// Token: 0x060001DA RID: 474 RVA: 0x00008B0C File Offset: 0x00006D0C
		// Note: this type is marked as 'beforefieldinit'.
		static InitializeRankedCommand()
		{
			Il2CppClassPointerStore<InitializeRankedCommand>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames-ranked.dll", "boardgames.ranked.commands", "InitializeRankedCommand");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InitializeRankedCommand>.NativeClassPtr);
			InitializeRankedCommand.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializeRankedCommand>.NativeClassPtr, 100663470);
			InitializeRankedCommand.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializeRankedCommand>.NativeClassPtr, 100663471);
		}

		// Token: 0x060001DB RID: 475 RVA: 0x00008B64 File Offset: 0x00006D64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1226000, XrefRangeEnd = 1226005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InitializeRankedCommand.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060001DC RID: 476 RVA: 0x00008BB0 File Offset: 0x00006DB0
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 498677, RefRangeEnd = 498693, XrefRangeStart = 498677, XrefRangeEnd = 498693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InitializeRankedCommand()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InitializeRankedCommand>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InitializeRankedCommand.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001DD RID: 477 RVA: 0x000030D5 File Offset: 0x000012D5
		public InitializeRankedCommand(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000107 RID: 263
		private static readonly IntPtr NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0;

		// Token: 0x04000108 RID: 264
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000045 RID: 69
		[ObfuscatedName("boardgames.ranked.commands.InitializeRankedCommand+<execute>d__0")]
		public sealed class _execute_d__0 : Object
		{
			// Token: 0x0600025C RID: 604 RVA: 0x0000A104 File Offset: 0x00008304
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__0()
			{
				Il2CppClassPointerStore<InitializeRankedCommand._execute_d__0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InitializeRankedCommand>.NativeClassPtr, "<execute>d__0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InitializeRankedCommand._execute_d__0>.NativeClassPtr);
				InitializeRankedCommand._execute_d__0.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitializeRankedCommand._execute_d__0>.NativeClassPtr, "<>1__state");
				InitializeRankedCommand._execute_d__0.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitializeRankedCommand._execute_d__0>.NativeClassPtr, "<>2__current");
				InitializeRankedCommand._execute_d__0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitializeRankedCommand._execute_d__0>.NativeClassPtr, "<>4__this");
				InitializeRankedCommand._execute_d__0.NativeFieldInfoPtr__sessionProvider_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitializeRankedCommand._execute_d__0>.NativeClassPtr, "<sessionProvider>5__2");
				InitializeRankedCommand._execute_d__0.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializeRankedCommand._execute_d__0>.NativeClassPtr, 100663472);
				InitializeRankedCommand._execute_d__0.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializeRankedCommand._execute_d__0>.NativeClassPtr, 100663473);
				InitializeRankedCommand._execute_d__0.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializeRankedCommand._execute_d__0>.NativeClassPtr, 100663474);
				InitializeRankedCommand._execute_d__0.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializeRankedCommand._execute_d__0>.NativeClassPtr, 100663475);
				InitializeRankedCommand._execute_d__0.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializeRankedCommand._execute_d__0>.NativeClassPtr, 100663476);
				InitializeRankedCommand._execute_d__0.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializeRankedCommand._execute_d__0>.NativeClassPtr, 100663477);
			}

			// Token: 0x0600025D RID: 605 RVA: 0x0000A1F8 File Offset: 0x000083F8
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__0(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InitializeRankedCommand._execute_d__0>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InitializeRankedCommand._execute_d__0.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600025E RID: 606 RVA: 0x0000A240 File Offset: 0x00008440
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InitializeRankedCommand._execute_d__0.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600025F RID: 607 RVA: 0x0000A274 File Offset: 0x00008474
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1225968, XrefRangeEnd = 1225995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InitializeRankedCommand._execute_d__0.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170000AC RID: 172
			// (get) Token: 0x06000260 RID: 608 RVA: 0x0000A2B0 File Offset: 0x000084B0
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InitializeRankedCommand._execute_d__0.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000261 RID: 609 RVA: 0x0000A2F0 File Offset: 0x000084F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1225995, XrefRangeEnd = 1226000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InitializeRankedCommand._execute_d__0.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170000AD RID: 173
			// (get) Token: 0x06000262 RID: 610 RVA: 0x0000A324 File Offset: 0x00008524
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InitializeRankedCommand._execute_d__0.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000263 RID: 611 RVA: 0x000034CF File Offset: 0x000016CF
			public _execute_d__0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170000A8 RID: 168
			// (get) Token: 0x06000264 RID: 612 RVA: 0x0000A364 File Offset: 0x00008564
			// (set) Token: 0x06000265 RID: 613 RVA: 0x000034D8 File Offset: 0x000016D8
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InitializeRankedCommand._execute_d__0.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InitializeRankedCommand._execute_d__0.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170000A9 RID: 169
			// (get) Token: 0x06000266 RID: 614 RVA: 0x0000A38C File Offset: 0x0000858C
			// (set) Token: 0x06000267 RID: 615 RVA: 0x000034F3 File Offset: 0x000016F3
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InitializeRankedCommand._execute_d__0.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InitializeRankedCommand._execute_d__0.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000AA RID: 170
			// (get) Token: 0x06000268 RID: 616 RVA: 0x0000A3BC File Offset: 0x000085BC
			// (set) Token: 0x06000269 RID: 617 RVA: 0x00003512 File Offset: 0x00001712
			public unsafe InitializeRankedCommand __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InitializeRankedCommand._execute_d__0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<InitializeRankedCommand>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InitializeRankedCommand._execute_d__0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000AB RID: 171
			// (get) Token: 0x0600026A RID: 618 RVA: 0x0000A3EC File Offset: 0x000085EC
			// (set) Token: 0x0600026B RID: 619 RVA: 0x00003531 File Offset: 0x00001731
			public unsafe RankedSessionProvider _sessionProvider_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InitializeRankedCommand._execute_d__0.NativeFieldInfoPtr__sessionProvider_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RankedSessionProvider>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InitializeRankedCommand._execute_d__0.NativeFieldInfoPtr__sessionProvider_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400014A RID: 330
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400014B RID: 331
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400014C RID: 332
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400014D RID: 333
			private static readonly IntPtr NativeFieldInfoPtr__sessionProvider_5__2;

			// Token: 0x0400014E RID: 334
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400014F RID: 335
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000150 RID: 336
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000151 RID: 337
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000152 RID: 338
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000153 RID: 339
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
