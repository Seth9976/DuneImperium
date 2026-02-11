using System;
using Canis.entities;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace Canis.actions.responseparsers
{
	// Token: 0x02000216 RID: 534
	public class ListResponseParser : ResponseParser<IEnumerable<Entity>>
	{
		// Token: 0x0600166D RID: 5741 RVA: 0x00073614 File Offset: 0x00071814
		// Note: this type is marked as 'beforefieldinit'.
		static ListResponseParser()
		{
			Il2CppClassPointerStore<ListResponseParser>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.actions.responseparsers", "ListResponseParser");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ListResponseParser>.NativeClassPtr);
			ListResponseParser.NativeFieldInfoPtr_WrappedParser = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListResponseParser>.NativeClassPtr, "WrappedParser");
			ListResponseParser.NativeMethodInfoPtr__ctor_Public_Void_ResponseParser_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListResponseParser>.NativeClassPtr, 100668399);
			ListResponseParser.NativeMethodInfoPtr_ParseResponse_Public_Virtual_IEnumerable_1_IEnumerable_1_Entity_Match_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListResponseParser>.NativeClassPtr, 100668400);
		}

		// Token: 0x0600166E RID: 5742 RVA: 0x00073680 File Offset: 0x00071880
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 593510, XrefRangeEnd = 593514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ListResponseParser(ResponseParser<Entity> parser)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ListResponseParser>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(parser);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListResponseParser.NativeMethodInfoPtr__ctor_Public_Void_ResponseParser_1_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600166F RID: 5743 RVA: 0x000736CC File Offset: 0x000718CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 593514, XrefRangeEnd = 593522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<IEnumerable<Entity>> ParseResponse(Match match, Object responseMessage)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(responseMessage);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ListResponseParser.NativeMethodInfoPtr_ParseResponse_Public_Virtual_IEnumerable_1_IEnumerable_1_Entity_Match_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<IEnumerable<Entity>>>(intPtr3) : null;
		}

		// Token: 0x06001670 RID: 5744 RVA: 0x0000AC66 File Offset: 0x00008E66
		public ListResponseParser(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004D9 RID: 1241
		// (get) Token: 0x06001671 RID: 5745 RVA: 0x0007373C File Offset: 0x0007193C
		// (set) Token: 0x06001672 RID: 5746 RVA: 0x0000AC6F File Offset: 0x00008E6F
		public unsafe ResponseParser<Entity> WrappedParser
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListResponseParser.NativeFieldInfoPtr_WrappedParser);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ResponseParser<Entity>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListResponseParser.NativeFieldInfoPtr_WrappedParser), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000E6C RID: 3692
		private static readonly IntPtr NativeFieldInfoPtr_WrappedParser;

		// Token: 0x04000E6D RID: 3693
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ResponseParser_1_Entity_0;

		// Token: 0x04000E6E RID: 3694
		private static readonly IntPtr NativeMethodInfoPtr_ParseResponse_Public_Virtual_IEnumerable_1_IEnumerable_1_Entity_Match_Object_0;

		// Token: 0x0200045F RID: 1119
		[ObfuscatedName("Canis.actions.responseparsers.ListResponseParser+<ParseResponse>d__2")]
		public sealed class _ParseResponse_d__2 : Object
		{
			// Token: 0x060031F9 RID: 12793 RVA: 0x000CDF5C File Offset: 0x000CC15C
			// Note: this type is marked as 'beforefieldinit'.
			static _ParseResponse_d__2()
			{
				Il2CppClassPointerStore<ListResponseParser._ParseResponse_d__2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ListResponseParser>.NativeClassPtr, "<ParseResponse>d__2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ListResponseParser._ParseResponse_d__2>.NativeClassPtr);
				ListResponseParser._ParseResponse_d__2.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListResponseParser._ParseResponse_d__2>.NativeClassPtr, "<>1__state");
				ListResponseParser._ParseResponse_d__2.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListResponseParser._ParseResponse_d__2>.NativeClassPtr, "<>2__current");
				ListResponseParser._ParseResponse_d__2.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListResponseParser._ParseResponse_d__2>.NativeClassPtr, "<>l__initialThreadId");
				ListResponseParser._ParseResponse_d__2.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListResponseParser._ParseResponse_d__2>.NativeClassPtr, "<>4__this");
				ListResponseParser._ParseResponse_d__2.NativeFieldInfoPtr_match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListResponseParser._ParseResponse_d__2>.NativeClassPtr, "match");
				ListResponseParser._ParseResponse_d__2.NativeFieldInfoPtr___3__match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListResponseParser._ParseResponse_d__2>.NativeClassPtr, "<>3__match");
				ListResponseParser._ParseResponse_d__2.NativeFieldInfoPtr_responseMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListResponseParser._ParseResponse_d__2>.NativeClassPtr, "responseMessage");
				ListResponseParser._ParseResponse_d__2.NativeFieldInfoPtr___3__responseMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListResponseParser._ParseResponse_d__2>.NativeClassPtr, "<>3__responseMessage");
				ListResponseParser._ParseResponse_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListResponseParser._ParseResponse_d__2>.NativeClassPtr, 100668401);
				ListResponseParser._ParseResponse_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListResponseParser._ParseResponse_d__2>.NativeClassPtr, 100668402);
				ListResponseParser._ParseResponse_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListResponseParser._ParseResponse_d__2>.NativeClassPtr, 100668403);
				ListResponseParser._ParseResponse_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Collections_Generic_IEnumerable_Canis_entities_Entity___get_Current_Private_Virtual_Final_New_get_IEnumerable_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListResponseParser._ParseResponse_d__2>.NativeClassPtr, 100668404);
				ListResponseParser._ParseResponse_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListResponseParser._ParseResponse_d__2>.NativeClassPtr, 100668405);
				ListResponseParser._ParseResponse_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListResponseParser._ParseResponse_d__2>.NativeClassPtr, 100668406);
				ListResponseParser._ParseResponse_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_System_Collections_Generic_IEnumerable_Canis_entities_Entity___GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_IEnumerable_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListResponseParser._ParseResponse_d__2>.NativeClassPtr, 100668407);
				ListResponseParser._ParseResponse_d__2.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListResponseParser._ParseResponse_d__2>.NativeClassPtr, 100668408);
			}

			// Token: 0x060031FA RID: 12794 RVA: 0x000CE0C8 File Offset: 0x000CC2C8
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _ParseResponse_d__2(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ListResponseParser._ParseResponse_d__2>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListResponseParser._ParseResponse_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060031FB RID: 12795 RVA: 0x000CE110 File Offset: 0x000CC310
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListResponseParser._ParseResponse_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060031FC RID: 12796 RVA: 0x000CE144 File Offset: 0x000CC344
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 593494, XrefRangeEnd = 593495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListResponseParser._ParseResponse_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000D3B RID: 3387
			// (get) Token: 0x060031FD RID: 12797 RVA: 0x000CE180 File Offset: 0x000CC380
			public unsafe IEnumerable<Entity> System.Collections.Generic.IEnumerator<System.Collections.Generic.IEnumerable<Canis.entities.Entity>>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListResponseParser._ParseResponse_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Collections_Generic_IEnumerable_Canis_entities_Entity___get_Current_Private_Virtual_Final_New_get_IEnumerable_1_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Entity>>(intPtr3) : null;
				}
			}

			// Token: 0x060031FE RID: 12798 RVA: 0x000CE1C0 File Offset: 0x000CC3C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 593495, XrefRangeEnd = 593500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListResponseParser._ParseResponse_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000D3C RID: 3388
			// (get) Token: 0x060031FF RID: 12799 RVA: 0x000CE1F4 File Offset: 0x000CC3F4
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListResponseParser._ParseResponse_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06003200 RID: 12800 RVA: 0x000CE234 File Offset: 0x000CC434
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 593500, XrefRangeEnd = 593510, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<IEnumerable<Entity>> System_Collections_Generic_IEnumerable_System_Collections_Generic_IEnumerable_Canis_entities_Entity___GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListResponseParser._ParseResponse_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_System_Collections_Generic_IEnumerable_Canis_entities_Entity___GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_IEnumerable_1_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<IEnumerable<Entity>>>(intPtr3) : null;
			}

			// Token: 0x06003201 RID: 12801 RVA: 0x000CE274 File Offset: 0x000CC474
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListResponseParser._ParseResponse_d__2.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06003202 RID: 12802 RVA: 0x00017EEC File Offset: 0x000160EC
			public _ParseResponse_d__2(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000D33 RID: 3379
			// (get) Token: 0x06003203 RID: 12803 RVA: 0x000CE2B4 File Offset: 0x000CC4B4
			// (set) Token: 0x06003204 RID: 12804 RVA: 0x00017EF5 File Offset: 0x000160F5
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListResponseParser._ParseResponse_d__2.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListResponseParser._ParseResponse_d__2.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000D34 RID: 3380
			// (get) Token: 0x06003205 RID: 12805 RVA: 0x000CE2DC File Offset: 0x000CC4DC
			// (set) Token: 0x06003206 RID: 12806 RVA: 0x00017F10 File Offset: 0x00016110
			public unsafe IEnumerable<Entity> __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListResponseParser._ParseResponse_d__2.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<Entity>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListResponseParser._ParseResponse_d__2.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D35 RID: 3381
			// (get) Token: 0x06003207 RID: 12807 RVA: 0x000CE30C File Offset: 0x000CC50C
			// (set) Token: 0x06003208 RID: 12808 RVA: 0x00017F2F File Offset: 0x0001612F
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListResponseParser._ParseResponse_d__2.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListResponseParser._ParseResponse_d__2.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17000D36 RID: 3382
			// (get) Token: 0x06003209 RID: 12809 RVA: 0x000CE334 File Offset: 0x000CC534
			// (set) Token: 0x0600320A RID: 12810 RVA: 0x00017F4A File Offset: 0x0001614A
			public unsafe ListResponseParser __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListResponseParser._ParseResponse_d__2.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ListResponseParser>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListResponseParser._ParseResponse_d__2.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D37 RID: 3383
			// (get) Token: 0x0600320B RID: 12811 RVA: 0x000CE364 File Offset: 0x000CC564
			// (set) Token: 0x0600320C RID: 12812 RVA: 0x00017F69 File Offset: 0x00016169
			public unsafe Match match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListResponseParser._ParseResponse_d__2.NativeFieldInfoPtr_match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Match>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListResponseParser._ParseResponse_d__2.NativeFieldInfoPtr_match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D38 RID: 3384
			// (get) Token: 0x0600320D RID: 12813 RVA: 0x000CE394 File Offset: 0x000CC594
			// (set) Token: 0x0600320E RID: 12814 RVA: 0x00017F88 File Offset: 0x00016188
			public unsafe Match __3__match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListResponseParser._ParseResponse_d__2.NativeFieldInfoPtr___3__match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Match>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListResponseParser._ParseResponse_d__2.NativeFieldInfoPtr___3__match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D39 RID: 3385
			// (get) Token: 0x0600320F RID: 12815 RVA: 0x000CE3C4 File Offset: 0x000CC5C4
			// (set) Token: 0x06003210 RID: 12816 RVA: 0x00017FA7 File Offset: 0x000161A7
			public unsafe Object responseMessage
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListResponseParser._ParseResponse_d__2.NativeFieldInfoPtr_responseMessage);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListResponseParser._ParseResponse_d__2.NativeFieldInfoPtr_responseMessage), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D3A RID: 3386
			// (get) Token: 0x06003211 RID: 12817 RVA: 0x000CE3F4 File Offset: 0x000CC5F4
			// (set) Token: 0x06003212 RID: 12818 RVA: 0x00017FC6 File Offset: 0x000161C6
			public unsafe Object __3__responseMessage
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListResponseParser._ParseResponse_d__2.NativeFieldInfoPtr___3__responseMessage);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListResponseParser._ParseResponse_d__2.NativeFieldInfoPtr___3__responseMessage), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001F44 RID: 8004
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001F45 RID: 8005
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001F46 RID: 8006
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04001F47 RID: 8007
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001F48 RID: 8008
			private static readonly IntPtr NativeFieldInfoPtr_match;

			// Token: 0x04001F49 RID: 8009
			private static readonly IntPtr NativeFieldInfoPtr___3__match;

			// Token: 0x04001F4A RID: 8010
			private static readonly IntPtr NativeFieldInfoPtr_responseMessage;

			// Token: 0x04001F4B RID: 8011
			private static readonly IntPtr NativeFieldInfoPtr___3__responseMessage;

			// Token: 0x04001F4C RID: 8012
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001F4D RID: 8013
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001F4E RID: 8014
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001F4F RID: 8015
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Collections_Generic_IEnumerable_Canis_entities_Entity___get_Current_Private_Virtual_Final_New_get_IEnumerable_1_Entity_0;

			// Token: 0x04001F50 RID: 8016
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001F51 RID: 8017
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001F52 RID: 8018
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_System_Collections_Generic_IEnumerable_Canis_entities_Entity___GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_IEnumerable_1_Entity_0;

			// Token: 0x04001F53 RID: 8019
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
