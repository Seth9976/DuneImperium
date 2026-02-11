using System;
using boardgames.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace boardgames
{
	// Token: 0x020000E4 RID: 228
	public class DBGAttemptReconnect : MonoBehaviour
	{
		// Token: 0x060009EB RID: 2539 RVA: 0x0003CB20 File Offset: 0x0003AD20
		// Note: this type is marked as 'beforefieldinit'.
		static DBGAttemptReconnect()
		{
			Il2CppClassPointerStore<DBGAttemptReconnect>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames", "DBGAttemptReconnect");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DBGAttemptReconnect>.NativeClassPtr);
			DBGAttemptReconnect.NativeFieldInfoPtr_networkReachbable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGAttemptReconnect>.NativeClassPtr, "networkReachbable");
			DBGAttemptReconnect.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGAttemptReconnect>.NativeClassPtr, 100664742);
			DBGAttemptReconnect.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGAttemptReconnect>.NativeClassPtr, 100664743);
			DBGAttemptReconnect.NativeMethodInfoPtr_CheckForReconnectableGames_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGAttemptReconnect>.NativeClassPtr, 100664744);
			DBGAttemptReconnect.NativeMethodInfoPtr_isNetworkReachable_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGAttemptReconnect>.NativeClassPtr, 100664745);
			DBGAttemptReconnect.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGAttemptReconnect>.NativeClassPtr, 100664746);
		}

		// Token: 0x060009EC RID: 2540 RVA: 0x0003CBC8 File Offset: 0x0003ADC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 506422, XrefRangeEnd = 506434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGAttemptReconnect.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009ED RID: 2541 RVA: 0x0003CBFC File Offset: 0x0003ADFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 506434, XrefRangeEnd = 506446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGAttemptReconnect.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009EE RID: 2542 RVA: 0x0003CC30 File Offset: 0x0003AE30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 506446, XrefRangeEnd = 506450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator CheckForReconnectableGames()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGAttemptReconnect.NativeMethodInfoPtr_CheckForReconnectableGames_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060009EF RID: 2543 RVA: 0x0003CC70 File Offset: 0x0003AE70
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 506462, RefRangeEnd = 506464, XrefRangeStart = 506450, XrefRangeEnd = 506462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool isNetworkReachable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGAttemptReconnect.NativeMethodInfoPtr_isNetworkReachable_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060009F0 RID: 2544 RVA: 0x0003CCAC File Offset: 0x0003AEAC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 506167, RefRangeEnd = 506168, XrefRangeStart = 506167, XrefRangeEnd = 506168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DBGAttemptReconnect()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DBGAttemptReconnect>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGAttemptReconnect.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009F1 RID: 2545 RVA: 0x00006BD2 File Offset: 0x00004DD2
		public DBGAttemptReconnect(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002B3 RID: 691
		// (get) Token: 0x060009F2 RID: 2546 RVA: 0x0003CCE8 File Offset: 0x0003AEE8
		// (set) Token: 0x060009F3 RID: 2547 RVA: 0x00006BDB File Offset: 0x00004DDB
		public unsafe bool networkReachbable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGAttemptReconnect.NativeFieldInfoPtr_networkReachbable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGAttemptReconnect.NativeFieldInfoPtr_networkReachbable)) = value;
			}
		}

		// Token: 0x04000607 RID: 1543
		private static readonly IntPtr NativeFieldInfoPtr_networkReachbable;

		// Token: 0x04000608 RID: 1544
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04000609 RID: 1545
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x0400060A RID: 1546
		private static readonly IntPtr NativeMethodInfoPtr_CheckForReconnectableGames_Private_IEnumerator_0;

		// Token: 0x0400060B RID: 1547
		private static readonly IntPtr NativeMethodInfoPtr_isNetworkReachable_Private_Boolean_0;

		// Token: 0x0400060C RID: 1548
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000335 RID: 821
		[ObfuscatedName("boardgames.DBGAttemptReconnect+<CheckForReconnectableGames>d__3")]
		public sealed class _CheckForReconnectableGames_d__3 : global::Il2CppSystem.Object
		{
			// Token: 0x060026C8 RID: 9928 RVA: 0x0009C878 File Offset: 0x0009AA78
			// Note: this type is marked as 'beforefieldinit'.
			static _CheckForReconnectableGames_d__3()
			{
				Il2CppClassPointerStore<DBGAttemptReconnect._CheckForReconnectableGames_d__3>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DBGAttemptReconnect>.NativeClassPtr, "<CheckForReconnectableGames>d__3");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DBGAttemptReconnect._CheckForReconnectableGames_d__3>.NativeClassPtr);
				DBGAttemptReconnect._CheckForReconnectableGames_d__3.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGAttemptReconnect._CheckForReconnectableGames_d__3>.NativeClassPtr, "<>1__state");
				DBGAttemptReconnect._CheckForReconnectableGames_d__3.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGAttemptReconnect._CheckForReconnectableGames_d__3>.NativeClassPtr, "<>2__current");
				DBGAttemptReconnect._CheckForReconnectableGames_d__3.NativeFieldInfoPtr__liveGameCommand_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGAttemptReconnect._CheckForReconnectableGames_d__3>.NativeClassPtr, "<liveGameCommand>5__2");
				DBGAttemptReconnect._CheckForReconnectableGames_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGAttemptReconnect._CheckForReconnectableGames_d__3>.NativeClassPtr, 100664747);
				DBGAttemptReconnect._CheckForReconnectableGames_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGAttemptReconnect._CheckForReconnectableGames_d__3>.NativeClassPtr, 100664748);
				DBGAttemptReconnect._CheckForReconnectableGames_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGAttemptReconnect._CheckForReconnectableGames_d__3>.NativeClassPtr, 100664749);
				DBGAttemptReconnect._CheckForReconnectableGames_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGAttemptReconnect._CheckForReconnectableGames_d__3>.NativeClassPtr, 100664750);
				DBGAttemptReconnect._CheckForReconnectableGames_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGAttemptReconnect._CheckForReconnectableGames_d__3>.NativeClassPtr, 100664751);
				DBGAttemptReconnect._CheckForReconnectableGames_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGAttemptReconnect._CheckForReconnectableGames_d__3>.NativeClassPtr, 100664752);
			}

			// Token: 0x060026C9 RID: 9929 RVA: 0x0009C958 File Offset: 0x0009AB58
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _CheckForReconnectableGames_d__3(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DBGAttemptReconnect._CheckForReconnectableGames_d__3>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGAttemptReconnect._CheckForReconnectableGames_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060026CA RID: 9930 RVA: 0x0009C9A0 File Offset: 0x0009ABA0
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGAttemptReconnect._CheckForReconnectableGames_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060026CB RID: 9931 RVA: 0x0009C9D4 File Offset: 0x0009ABD4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 506408, XrefRangeEnd = 506417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGAttemptReconnect._CheckForReconnectableGames_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000AC5 RID: 2757
			// (get) Token: 0x060026CC RID: 9932 RVA: 0x0009CA10 File Offset: 0x0009AC10
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGAttemptReconnect._CheckForReconnectableGames_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060026CD RID: 9933 RVA: 0x0009CA50 File Offset: 0x0009AC50
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 506417, XrefRangeEnd = 506422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGAttemptReconnect._CheckForReconnectableGames_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000AC6 RID: 2758
			// (get) Token: 0x060026CE RID: 9934 RVA: 0x0009CA84 File Offset: 0x0009AC84
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGAttemptReconnect._CheckForReconnectableGames_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060026CF RID: 9935 RVA: 0x00014178 File Offset: 0x00012378
			public _CheckForReconnectableGames_d__3(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000AC2 RID: 2754
			// (get) Token: 0x060026D0 RID: 9936 RVA: 0x0009CAC4 File Offset: 0x0009ACC4
			// (set) Token: 0x060026D1 RID: 9937 RVA: 0x00014181 File Offset: 0x00012381
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGAttemptReconnect._CheckForReconnectableGames_d__3.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGAttemptReconnect._CheckForReconnectableGames_d__3.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000AC3 RID: 2755
			// (get) Token: 0x060026D2 RID: 9938 RVA: 0x0009CAEC File Offset: 0x0009ACEC
			// (set) Token: 0x060026D3 RID: 9939 RVA: 0x0001419C File Offset: 0x0001239C
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGAttemptReconnect._CheckForReconnectableGames_d__3.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGAttemptReconnect._CheckForReconnectableGames_d__3.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000AC4 RID: 2756
			// (get) Token: 0x060026D4 RID: 9940 RVA: 0x0009CB1C File Offset: 0x0009AD1C
			// (set) Token: 0x060026D5 RID: 9941 RVA: 0x000141BB File Offset: 0x000123BB
			public unsafe DBGCheckForReconnectableLiveGameCommand _liveGameCommand_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGAttemptReconnect._CheckForReconnectableGames_d__3.NativeFieldInfoPtr__liveGameCommand_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGCheckForReconnectableLiveGameCommand>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGAttemptReconnect._CheckForReconnectableGames_d__3.NativeFieldInfoPtr__liveGameCommand_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001852 RID: 6226
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001853 RID: 6227
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001854 RID: 6228
			private static readonly IntPtr NativeFieldInfoPtr__liveGameCommand_5__2;

			// Token: 0x04001855 RID: 6229
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001856 RID: 6230
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001857 RID: 6231
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001858 RID: 6232
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001859 RID: 6233
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400185A RID: 6234
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
