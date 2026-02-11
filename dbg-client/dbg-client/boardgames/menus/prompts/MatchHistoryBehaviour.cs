using System;
using boardgames.menus.commands;
using dwd.core.data.composition;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace boardgames.menus.prompts
{
	// Token: 0x020001D5 RID: 469
	public class MatchHistoryBehaviour : MonoBehaviour
	{
		// Token: 0x06001575 RID: 5493 RVA: 0x0006317C File Offset: 0x0006137C
		// Note: this type is marked as 'beforefieldinit'.
		static MatchHistoryBehaviour()
		{
			Il2CppClassPointerStore<MatchHistoryBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.menus.prompts", "MatchHistoryBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MatchHistoryBehaviour>.NativeClassPtr);
			MatchHistoryBehaviour.NativeFieldInfoPtr_entryPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MatchHistoryBehaviour>.NativeClassPtr, "entryPrefab");
			MatchHistoryBehaviour.NativeFieldInfoPtr_entryContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MatchHistoryBehaviour>.NativeClassPtr, "entryContainer");
			MatchHistoryBehaviour.NativeFieldInfoPtr_noDataWarning = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MatchHistoryBehaviour>.NativeClassPtr, "noDataWarning");
			MatchHistoryBehaviour.NativeFieldInfoPtr__entryRenderers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MatchHistoryBehaviour>.NativeClassPtr, "_entryRenderers");
			MatchHistoryBehaviour.NativeMethodInfoPtr_UpdateDisplay_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchHistoryBehaviour>.NativeClassPtr, 100666456);
			MatchHistoryBehaviour.NativeMethodInfoPtr_FetchAndUpdateDisplay_Protected_Virtual_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchHistoryBehaviour>.NativeClassPtr, 100666457);
			MatchHistoryBehaviour.NativeMethodInfoPtr_ShowMatchStatsHistory_Protected_Virtual_New_Void_DataComposition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchHistoryBehaviour>.NativeClassPtr, 100666458);
			MatchHistoryBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchHistoryBehaviour>.NativeClassPtr, 100666459);
		}

		// Token: 0x06001576 RID: 5494 RVA: 0x0006324C File Offset: 0x0006144C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 522487, XrefRangeEnd = 522488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateDisplay()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MatchHistoryBehaviour.NativeMethodInfoPtr_UpdateDisplay_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001577 RID: 5495 RVA: 0x00063280 File Offset: 0x00061480
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 522488, XrefRangeEnd = 522493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator FetchAndUpdateDisplay()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MatchHistoryBehaviour.NativeMethodInfoPtr_FetchAndUpdateDisplay_Protected_Virtual_New_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001578 RID: 5496 RVA: 0x000632CC File Offset: 0x000614CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 522493, XrefRangeEnd = 522538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ShowMatchStatsHistory(DataComposition data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MatchHistoryBehaviour.NativeMethodInfoPtr_ShowMatchStatsHistory_Protected_Virtual_New_Void_DataComposition_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001579 RID: 5497 RVA: 0x0006331C File Offset: 0x0006151C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 522538, XrefRangeEnd = 522546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MatchHistoryBehaviour()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MatchHistoryBehaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MatchHistoryBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600157A RID: 5498 RVA: 0x0000C157 File Offset: 0x0000A357
		public MatchHistoryBehaviour(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005B5 RID: 1461
		// (get) Token: 0x0600157B RID: 5499 RVA: 0x00063358 File Offset: 0x00061558
		// (set) Token: 0x0600157C RID: 5500 RVA: 0x0000C160 File Offset: 0x0000A360
		public unsafe SubscriptionProvider entryPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchHistoryBehaviour.NativeFieldInfoPtr_entryPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SubscriptionProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchHistoryBehaviour.NativeFieldInfoPtr_entryPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005B6 RID: 1462
		// (get) Token: 0x0600157D RID: 5501 RVA: 0x00063388 File Offset: 0x00061588
		// (set) Token: 0x0600157E RID: 5502 RVA: 0x0000C17F File Offset: 0x0000A37F
		public unsafe Transform entryContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchHistoryBehaviour.NativeFieldInfoPtr_entryContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchHistoryBehaviour.NativeFieldInfoPtr_entryContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005B7 RID: 1463
		// (get) Token: 0x0600157F RID: 5503 RVA: 0x000633B8 File Offset: 0x000615B8
		// (set) Token: 0x06001580 RID: 5504 RVA: 0x0000C19E File Offset: 0x0000A39E
		public unsafe GameObject noDataWarning
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchHistoryBehaviour.NativeFieldInfoPtr_noDataWarning);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchHistoryBehaviour.NativeFieldInfoPtr_noDataWarning), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005B8 RID: 1464
		// (get) Token: 0x06001581 RID: 5505 RVA: 0x000633E8 File Offset: 0x000615E8
		// (set) Token: 0x06001582 RID: 5506 RVA: 0x0000C1BD File Offset: 0x0000A3BD
		public unsafe List<SubscriptionProvider> _entryRenderers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchHistoryBehaviour.NativeFieldInfoPtr__entryRenderers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<SubscriptionProvider>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchHistoryBehaviour.NativeFieldInfoPtr__entryRenderers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000D4E RID: 3406
		private static readonly IntPtr NativeFieldInfoPtr_entryPrefab;

		// Token: 0x04000D4F RID: 3407
		private static readonly IntPtr NativeFieldInfoPtr_entryContainer;

		// Token: 0x04000D50 RID: 3408
		private static readonly IntPtr NativeFieldInfoPtr_noDataWarning;

		// Token: 0x04000D51 RID: 3409
		private static readonly IntPtr NativeFieldInfoPtr__entryRenderers;

		// Token: 0x04000D52 RID: 3410
		private static readonly IntPtr NativeMethodInfoPtr_UpdateDisplay_Public_Void_0;

		// Token: 0x04000D53 RID: 3411
		private static readonly IntPtr NativeMethodInfoPtr_FetchAndUpdateDisplay_Protected_Virtual_New_IEnumerator_0;

		// Token: 0x04000D54 RID: 3412
		private static readonly IntPtr NativeMethodInfoPtr_ShowMatchStatsHistory_Protected_Virtual_New_Void_DataComposition_0;

		// Token: 0x04000D55 RID: 3413
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020003C3 RID: 963
		[ObfuscatedName("boardgames.menus.prompts.MatchHistoryBehaviour+<FetchAndUpdateDisplay>d__5")]
		public sealed class _FetchAndUpdateDisplay_d__5 : global::Il2CppSystem.Object
		{
			// Token: 0x06002CE2 RID: 11490 RVA: 0x000AE8B0 File Offset: 0x000ACAB0
			// Note: this type is marked as 'beforefieldinit'.
			static _FetchAndUpdateDisplay_d__5()
			{
				Il2CppClassPointerStore<MatchHistoryBehaviour._FetchAndUpdateDisplay_d__5>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MatchHistoryBehaviour>.NativeClassPtr, "<FetchAndUpdateDisplay>d__5");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MatchHistoryBehaviour._FetchAndUpdateDisplay_d__5>.NativeClassPtr);
				MatchHistoryBehaviour._FetchAndUpdateDisplay_d__5.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MatchHistoryBehaviour._FetchAndUpdateDisplay_d__5>.NativeClassPtr, "<>1__state");
				MatchHistoryBehaviour._FetchAndUpdateDisplay_d__5.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MatchHistoryBehaviour._FetchAndUpdateDisplay_d__5>.NativeClassPtr, "<>2__current");
				MatchHistoryBehaviour._FetchAndUpdateDisplay_d__5.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MatchHistoryBehaviour._FetchAndUpdateDisplay_d__5>.NativeClassPtr, "<>4__this");
				MatchHistoryBehaviour._FetchAndUpdateDisplay_d__5.NativeFieldInfoPtr__loadCommand_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MatchHistoryBehaviour._FetchAndUpdateDisplay_d__5>.NativeClassPtr, "<loadCommand>5__2");
				MatchHistoryBehaviour._FetchAndUpdateDisplay_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchHistoryBehaviour._FetchAndUpdateDisplay_d__5>.NativeClassPtr, 100666460);
				MatchHistoryBehaviour._FetchAndUpdateDisplay_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchHistoryBehaviour._FetchAndUpdateDisplay_d__5>.NativeClassPtr, 100666461);
				MatchHistoryBehaviour._FetchAndUpdateDisplay_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchHistoryBehaviour._FetchAndUpdateDisplay_d__5>.NativeClassPtr, 100666462);
				MatchHistoryBehaviour._FetchAndUpdateDisplay_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchHistoryBehaviour._FetchAndUpdateDisplay_d__5>.NativeClassPtr, 100666463);
				MatchHistoryBehaviour._FetchAndUpdateDisplay_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchHistoryBehaviour._FetchAndUpdateDisplay_d__5>.NativeClassPtr, 100666464);
				MatchHistoryBehaviour._FetchAndUpdateDisplay_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchHistoryBehaviour._FetchAndUpdateDisplay_d__5>.NativeClassPtr, 100666465);
			}

			// Token: 0x06002CE3 RID: 11491 RVA: 0x000AE9A4 File Offset: 0x000ACBA4
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _FetchAndUpdateDisplay_d__5(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MatchHistoryBehaviour._FetchAndUpdateDisplay_d__5>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MatchHistoryBehaviour._FetchAndUpdateDisplay_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002CE4 RID: 11492 RVA: 0x000AE9EC File Offset: 0x000ACBEC
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MatchHistoryBehaviour._FetchAndUpdateDisplay_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002CE5 RID: 11493 RVA: 0x000AEA20 File Offset: 0x000ACC20
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 522464, XrefRangeEnd = 522482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MatchHistoryBehaviour._FetchAndUpdateDisplay_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000CC1 RID: 3265
			// (get) Token: 0x06002CE6 RID: 11494 RVA: 0x000AEA5C File Offset: 0x000ACC5C
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MatchHistoryBehaviour._FetchAndUpdateDisplay_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002CE7 RID: 11495 RVA: 0x000AEA9C File Offset: 0x000ACC9C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 522482, XrefRangeEnd = 522487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MatchHistoryBehaviour._FetchAndUpdateDisplay_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000CC2 RID: 3266
			// (get) Token: 0x06002CE8 RID: 11496 RVA: 0x000AEAD0 File Offset: 0x000ACCD0
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MatchHistoryBehaviour._FetchAndUpdateDisplay_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002CE9 RID: 11497 RVA: 0x000173B9 File Offset: 0x000155B9
			public _FetchAndUpdateDisplay_d__5(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000CBD RID: 3261
			// (get) Token: 0x06002CEA RID: 11498 RVA: 0x000AEB10 File Offset: 0x000ACD10
			// (set) Token: 0x06002CEB RID: 11499 RVA: 0x000173C2 File Offset: 0x000155C2
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchHistoryBehaviour._FetchAndUpdateDisplay_d__5.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchHistoryBehaviour._FetchAndUpdateDisplay_d__5.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000CBE RID: 3262
			// (get) Token: 0x06002CEC RID: 11500 RVA: 0x000AEB38 File Offset: 0x000ACD38
			// (set) Token: 0x06002CED RID: 11501 RVA: 0x000173DD File Offset: 0x000155DD
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchHistoryBehaviour._FetchAndUpdateDisplay_d__5.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchHistoryBehaviour._FetchAndUpdateDisplay_d__5.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000CBF RID: 3263
			// (get) Token: 0x06002CEE RID: 11502 RVA: 0x000AEB68 File Offset: 0x000ACD68
			// (set) Token: 0x06002CEF RID: 11503 RVA: 0x000173FC File Offset: 0x000155FC
			public unsafe MatchHistoryBehaviour __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchHistoryBehaviour._FetchAndUpdateDisplay_d__5.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MatchHistoryBehaviour>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchHistoryBehaviour._FetchAndUpdateDisplay_d__5.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000CC0 RID: 3264
			// (get) Token: 0x06002CF0 RID: 11504 RVA: 0x000AEB98 File Offset: 0x000ACD98
			// (set) Token: 0x06002CF1 RID: 11505 RVA: 0x0001741B File Offset: 0x0001561B
			public unsafe LoadMatchHistory _loadCommand_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchHistoryBehaviour._FetchAndUpdateDisplay_d__5.NativeFieldInfoPtr__loadCommand_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LoadMatchHistory>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchHistoryBehaviour._FetchAndUpdateDisplay_d__5.NativeFieldInfoPtr__loadCommand_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001BDB RID: 7131
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001BDC RID: 7132
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001BDD RID: 7133
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001BDE RID: 7134
			private static readonly IntPtr NativeFieldInfoPtr__loadCommand_5__2;

			// Token: 0x04001BDF RID: 7135
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001BE0 RID: 7136
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001BE1 RID: 7137
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001BE2 RID: 7138
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001BE3 RID: 7139
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001BE4 RID: 7140
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
