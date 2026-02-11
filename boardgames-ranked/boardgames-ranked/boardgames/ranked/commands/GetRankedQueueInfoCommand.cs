using System;
using dwd.core.commands;
using dwd.core.networking.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine.Networking;

namespace boardgames.ranked.commands
{
	// Token: 0x02000035 RID: 53
	public class GetRankedQueueInfoCommand : FailableCommand
	{
		// Token: 0x060001D6 RID: 470 RVA: 0x00008A2C File Offset: 0x00006C2C
		// Note: this type is marked as 'beforefieldinit'.
		static GetRankedQueueInfoCommand()
		{
			Il2CppClassPointerStore<GetRankedQueueInfoCommand>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames-ranked.dll", "boardgames.ranked.commands", "GetRankedQueueInfoCommand");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GetRankedQueueInfoCommand>.NativeClassPtr);
			GetRankedQueueInfoCommand.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetRankedQueueInfoCommand>.NativeClassPtr, 100663459);
			GetRankedQueueInfoCommand.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetRankedQueueInfoCommand>.NativeClassPtr, 100663460);
		}

		// Token: 0x060001D7 RID: 471 RVA: 0x00008A84 File Offset: 0x00006C84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1225963, XrefRangeEnd = 1225968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GetRankedQueueInfoCommand.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060001D8 RID: 472 RVA: 0x00008AD0 File Offset: 0x00006CD0
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 498677, RefRangeEnd = 498693, XrefRangeStart = 498677, XrefRangeEnd = 498693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GetRankedQueueInfoCommand()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GetRankedQueueInfoCommand>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetRankedQueueInfoCommand.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001D9 RID: 473 RVA: 0x000030CC File Offset: 0x000012CC
		public GetRankedQueueInfoCommand(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000105 RID: 261
		private static readonly IntPtr NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0;

		// Token: 0x04000106 RID: 262
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000043 RID: 67
		[ObfuscatedName("boardgames.ranked.commands.GetRankedQueueInfoCommand+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06000244 RID: 580 RVA: 0x00009CA0 File Offset: 0x00007EA0
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<GetRankedQueueInfoCommand.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GetRankedQueueInfoCommand>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GetRankedQueueInfoCommand.__c>.NativeClassPtr);
				GetRankedQueueInfoCommand.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetRankedQueueInfoCommand.__c>.NativeClassPtr, "<>9");
				GetRankedQueueInfoCommand.__c.NativeFieldInfoPtr___9__0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetRankedQueueInfoCommand.__c>.NativeClassPtr, "<>9__0_0");
				GetRankedQueueInfoCommand.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetRankedQueueInfoCommand.__c>.NativeClassPtr, 100663462);
				GetRankedQueueInfoCommand.__c.NativeMethodInfoPtr__execute_b__0_0_Internal_Void_UnityWebRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetRankedQueueInfoCommand.__c>.NativeClassPtr, 100663463);
			}

			// Token: 0x06000245 RID: 581 RVA: 0x00009D1C File Offset: 0x00007F1C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GetRankedQueueInfoCommand.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetRankedQueueInfoCommand.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000246 RID: 582 RVA: 0x00009D58 File Offset: 0x00007F58
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1225880, XrefRangeEnd = 1225888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _execute_b__0_0(UnityWebRequest r)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(r);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetRankedQueueInfoCommand.__c.NativeMethodInfoPtr__execute_b__0_0_Internal_Void_UnityWebRequest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000247 RID: 583 RVA: 0x00003421 File Offset: 0x00001621
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170000A0 RID: 160
			// (get) Token: 0x06000248 RID: 584 RVA: 0x00009D9C File Offset: 0x00007F9C
			// (set) Token: 0x06000249 RID: 585 RVA: 0x0000342A File Offset: 0x0000162A
			public unsafe static GetRankedQueueInfoCommand.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GetRankedQueueInfoCommand.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GetRankedQueueInfoCommand.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GetRankedQueueInfoCommand.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000A1 RID: 161
			// (get) Token: 0x0600024A RID: 586 RVA: 0x00009DC4 File Offset: 0x00007FC4
			// (set) Token: 0x0600024B RID: 587 RVA: 0x0000343C File Offset: 0x0000163C
			public unsafe static Action<UnityWebRequest> __9__0_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GetRankedQueueInfoCommand.__c.NativeFieldInfoPtr___9__0_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<UnityWebRequest>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GetRankedQueueInfoCommand.__c.NativeFieldInfoPtr___9__0_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400013C RID: 316
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400013D RID: 317
			private static readonly IntPtr NativeFieldInfoPtr___9__0_0;

			// Token: 0x0400013E RID: 318
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400013F RID: 319
			private static readonly IntPtr NativeMethodInfoPtr__execute_b__0_0_Internal_Void_UnityWebRequest_0;
		}

		// Token: 0x02000044 RID: 68
		[ObfuscatedName("boardgames.ranked.commands.GetRankedQueueInfoCommand+<execute>d__0")]
		public sealed class _execute_d__0 : Object
		{
			// Token: 0x0600024C RID: 588 RVA: 0x00009DEC File Offset: 0x00007FEC
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__0()
			{
				Il2CppClassPointerStore<GetRankedQueueInfoCommand._execute_d__0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GetRankedQueueInfoCommand>.NativeClassPtr, "<execute>d__0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GetRankedQueueInfoCommand._execute_d__0>.NativeClassPtr);
				GetRankedQueueInfoCommand._execute_d__0.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetRankedQueueInfoCommand._execute_d__0>.NativeClassPtr, "<>1__state");
				GetRankedQueueInfoCommand._execute_d__0.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetRankedQueueInfoCommand._execute_d__0>.NativeClassPtr, "<>2__current");
				GetRankedQueueInfoCommand._execute_d__0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetRankedQueueInfoCommand._execute_d__0>.NativeClassPtr, "<>4__this");
				GetRankedQueueInfoCommand._execute_d__0.NativeFieldInfoPtr__request_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetRankedQueueInfoCommand._execute_d__0>.NativeClassPtr, "<request>5__2");
				GetRankedQueueInfoCommand._execute_d__0.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetRankedQueueInfoCommand._execute_d__0>.NativeClassPtr, 100663464);
				GetRankedQueueInfoCommand._execute_d__0.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetRankedQueueInfoCommand._execute_d__0>.NativeClassPtr, 100663465);
				GetRankedQueueInfoCommand._execute_d__0.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetRankedQueueInfoCommand._execute_d__0>.NativeClassPtr, 100663466);
				GetRankedQueueInfoCommand._execute_d__0.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetRankedQueueInfoCommand._execute_d__0>.NativeClassPtr, 100663467);
				GetRankedQueueInfoCommand._execute_d__0.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetRankedQueueInfoCommand._execute_d__0>.NativeClassPtr, 100663468);
				GetRankedQueueInfoCommand._execute_d__0.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetRankedQueueInfoCommand._execute_d__0>.NativeClassPtr, 100663469);
			}

			// Token: 0x0600024D RID: 589 RVA: 0x00009EE0 File Offset: 0x000080E0
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__0(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GetRankedQueueInfoCommand._execute_d__0>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetRankedQueueInfoCommand._execute_d__0.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600024E RID: 590 RVA: 0x00009F28 File Offset: 0x00008128
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetRankedQueueInfoCommand._execute_d__0.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600024F RID: 591 RVA: 0x00009F5C File Offset: 0x0000815C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1225888, XrefRangeEnd = 1225958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetRankedQueueInfoCommand._execute_d__0.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170000A6 RID: 166
			// (get) Token: 0x06000250 RID: 592 RVA: 0x00009F98 File Offset: 0x00008198
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetRankedQueueInfoCommand._execute_d__0.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000251 RID: 593 RVA: 0x00009FD8 File Offset: 0x000081D8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1225958, XrefRangeEnd = 1225963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetRankedQueueInfoCommand._execute_d__0.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170000A7 RID: 167
			// (get) Token: 0x06000252 RID: 594 RVA: 0x0000A00C File Offset: 0x0000820C
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetRankedQueueInfoCommand._execute_d__0.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000253 RID: 595 RVA: 0x0000344E File Offset: 0x0000164E
			public _execute_d__0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170000A2 RID: 162
			// (get) Token: 0x06000254 RID: 596 RVA: 0x0000A04C File Offset: 0x0000824C
			// (set) Token: 0x06000255 RID: 597 RVA: 0x00003457 File Offset: 0x00001657
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetRankedQueueInfoCommand._execute_d__0.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetRankedQueueInfoCommand._execute_d__0.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170000A3 RID: 163
			// (get) Token: 0x06000256 RID: 598 RVA: 0x0000A074 File Offset: 0x00008274
			// (set) Token: 0x06000257 RID: 599 RVA: 0x00003472 File Offset: 0x00001672
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetRankedQueueInfoCommand._execute_d__0.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetRankedQueueInfoCommand._execute_d__0.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000A4 RID: 164
			// (get) Token: 0x06000258 RID: 600 RVA: 0x0000A0A4 File Offset: 0x000082A4
			// (set) Token: 0x06000259 RID: 601 RVA: 0x00003491 File Offset: 0x00001691
			public unsafe GetRankedQueueInfoCommand __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetRankedQueueInfoCommand._execute_d__0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GetRankedQueueInfoCommand>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetRankedQueueInfoCommand._execute_d__0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000A5 RID: 165
			// (get) Token: 0x0600025A RID: 602 RVA: 0x0000A0D4 File Offset: 0x000082D4
			// (set) Token: 0x0600025B RID: 603 RVA: 0x000034B0 File Offset: 0x000016B0
			public unsafe DwdWebRequestCommand _request_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetRankedQueueInfoCommand._execute_d__0.NativeFieldInfoPtr__request_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DwdWebRequestCommand>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetRankedQueueInfoCommand._execute_d__0.NativeFieldInfoPtr__request_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000140 RID: 320
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000141 RID: 321
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000142 RID: 322
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000143 RID: 323
			private static readonly IntPtr NativeFieldInfoPtr__request_5__2;

			// Token: 0x04000144 RID: 324
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000145 RID: 325
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000146 RID: 326
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000147 RID: 327
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000148 RID: 328
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000149 RID: 329
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
