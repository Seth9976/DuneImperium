using System;
using Canis;
using Canis.actions;
using Canis.entities;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace lib.canis.Canis.actions
{
	// Token: 0x02000021 RID: 33
	public class MoveCameraTo : global::Canis.actions.Action
	{
		// Token: 0x0600012A RID: 298 RVA: 0x0001DB08 File Offset: 0x0001BD08
		// Note: this type is marked as 'beforefieldinit'.
		static MoveCameraTo()
		{
			Il2CppClassPointerStore<MoveCameraTo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "lib.canis.Canis.actions", "MoveCameraTo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MoveCameraTo>.NativeClassPtr);
			MoveCameraTo.NativeFieldInfoPtr_flavor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveCameraTo>.NativeClassPtr, "flavor");
			MoveCameraTo.NativeFieldInfoPtr_recordPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveCameraTo>.NativeClassPtr, "recordPosition");
			MoveCameraTo.NativeFieldInfoPtr_suppressPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveCameraTo>.NativeClassPtr, "suppressPlayer");
			MoveCameraTo.NativeFieldInfoPtr_forPlayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveCameraTo>.NativeClassPtr, "forPlayers");
			MoveCameraTo.NativeMethodInfoPtr__ctor_Public_Void_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveCameraTo>.NativeClassPtr, 100663488);
			MoveCameraTo.NativeMethodInfoPtr_WithFlavor_Public_MoveCameraTo_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveCameraTo>.NativeClassPtr, 100663489);
			MoveCameraTo.NativeMethodInfoPtr_WithRecordPosition_Public_MoveCameraTo_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveCameraTo>.NativeClassPtr, 100663490);
			MoveCameraTo.NativeMethodInfoPtr_WithSuppressPlayer_Public_MoveCameraTo_AccountID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveCameraTo>.NativeClassPtr, 100663491);
			MoveCameraTo.NativeMethodInfoPtr_ForPlayers_Public_MoveCameraTo_IEnumerable_1_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveCameraTo>.NativeClassPtr, 100663492);
			MoveCameraTo.NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveCameraTo>.NativeClassPtr, 100663493);
		}

		// Token: 0x0600012B RID: 299 RVA: 0x0001DC00 File Offset: 0x0001BE00
		[CallerCount(191)]
		[CachedScanResults(RefRangeStart = 51381, RefRangeEnd = 51572, XrefRangeStart = 51381, XrefRangeEnd = 51572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MoveCameraTo(Match m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MoveCameraTo>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveCameraTo.NativeMethodInfoPtr__ctor_Public_Void_Match_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600012C RID: 300 RVA: 0x0001DC4C File Offset: 0x0001BE4C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 544371, RefRangeEnd = 544377, XrefRangeStart = 544370, XrefRangeEnd = 544371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MoveCameraTo WithFlavor(string newFlavor)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(newFlavor);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveCameraTo.NativeMethodInfoPtr_WithFlavor_Public_MoveCameraTo_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MoveCameraTo>(intPtr3) : null;
			}
		}

		// Token: 0x0600012D RID: 301 RVA: 0x0001DC9C File Offset: 0x0001BE9C
		[CallerCount(0)]
		public unsafe MoveCameraTo WithRecordPosition(bool record = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref record;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveCameraTo.NativeMethodInfoPtr_WithRecordPosition_Public_MoveCameraTo_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MoveCameraTo>(intPtr3) : null;
			}
		}

		// Token: 0x0600012E RID: 302 RVA: 0x0001DCE8 File Offset: 0x0001BEE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MoveCameraTo WithSuppressPlayer(AccountID playerAccount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(playerAccount);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveCameraTo.NativeMethodInfoPtr_WithSuppressPlayer_Public_MoveCameraTo_AccountID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MoveCameraTo>(intPtr3) : null;
			}
		}

		// Token: 0x0600012F RID: 303 RVA: 0x0001DD38 File Offset: 0x0001BF38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 544377, XrefRangeEnd = 544381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MoveCameraTo ForPlayers(IEnumerable<PlayerEntity> players)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(players);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveCameraTo.NativeMethodInfoPtr_ForPlayers_Public_MoveCameraTo_IEnumerable_1_PlayerEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MoveCameraTo>(intPtr3) : null;
			}
		}

		// Token: 0x06000130 RID: 304 RVA: 0x0001DD88 File Offset: 0x0001BF88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 544381, XrefRangeEnd = 544387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<global::Canis.actions.Action> execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MoveCameraTo.NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x06000131 RID: 305 RVA: 0x0000290A File Offset: 0x00000B0A
		public MoveCameraTo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x06000132 RID: 306 RVA: 0x0001DDD4 File Offset: 0x0001BFD4
		// (set) Token: 0x06000133 RID: 307 RVA: 0x00002913 File Offset: 0x00000B13
		public unsafe string flavor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveCameraTo.NativeFieldInfoPtr_flavor);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveCameraTo.NativeFieldInfoPtr_flavor), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x06000134 RID: 308 RVA: 0x0001DDFC File Offset: 0x0001BFFC
		// (set) Token: 0x06000135 RID: 309 RVA: 0x00002932 File Offset: 0x00000B32
		public unsafe bool recordPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveCameraTo.NativeFieldInfoPtr_recordPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveCameraTo.NativeFieldInfoPtr_recordPosition)) = value;
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x06000136 RID: 310 RVA: 0x0001DE24 File Offset: 0x0001C024
		// (set) Token: 0x06000137 RID: 311 RVA: 0x0000294D File Offset: 0x00000B4D
		public unsafe AccountID suppressPlayer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveCameraTo.NativeFieldInfoPtr_suppressPlayer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveCameraTo.NativeFieldInfoPtr_suppressPlayer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x06000138 RID: 312 RVA: 0x0001DE54 File Offset: 0x0001C054
		// (set) Token: 0x06000139 RID: 313 RVA: 0x0000296C File Offset: 0x00000B6C
		public unsafe Il2CppReferenceArray<PlayerEntity> forPlayers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveCameraTo.NativeFieldInfoPtr_forPlayers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<PlayerEntity>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveCameraTo.NativeFieldInfoPtr_forPlayers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040000A5 RID: 165
		private static readonly IntPtr NativeFieldInfoPtr_flavor;

		// Token: 0x040000A6 RID: 166
		private static readonly IntPtr NativeFieldInfoPtr_recordPosition;

		// Token: 0x040000A7 RID: 167
		private static readonly IntPtr NativeFieldInfoPtr_suppressPlayer;

		// Token: 0x040000A8 RID: 168
		private static readonly IntPtr NativeFieldInfoPtr_forPlayers;

		// Token: 0x040000A9 RID: 169
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Match_0;

		// Token: 0x040000AA RID: 170
		private static readonly IntPtr NativeMethodInfoPtr_WithFlavor_Public_MoveCameraTo_String_0;

		// Token: 0x040000AB RID: 171
		private static readonly IntPtr NativeMethodInfoPtr_WithRecordPosition_Public_MoveCameraTo_Boolean_0;

		// Token: 0x040000AC RID: 172
		private static readonly IntPtr NativeMethodInfoPtr_WithSuppressPlayer_Public_MoveCameraTo_AccountID_0;

		// Token: 0x040000AD RID: 173
		private static readonly IntPtr NativeMethodInfoPtr_ForPlayers_Public_MoveCameraTo_IEnumerable_1_PlayerEntity_0;

		// Token: 0x040000AE RID: 174
		private static readonly IntPtr NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0;

		// Token: 0x0200024D RID: 589
		[ObfuscatedName("lib.canis.Canis.actions.MoveCameraTo+<execute>d__9")]
		public sealed class _execute_d__9 : Object
		{
			// Token: 0x0600189B RID: 6299 RVA: 0x0007B1C0 File Offset: 0x000793C0
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__9()
			{
				Il2CppClassPointerStore<MoveCameraTo._execute_d__9>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MoveCameraTo>.NativeClassPtr, "<execute>d__9");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MoveCameraTo._execute_d__9>.NativeClassPtr);
				MoveCameraTo._execute_d__9.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveCameraTo._execute_d__9>.NativeClassPtr, "<>1__state");
				MoveCameraTo._execute_d__9.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveCameraTo._execute_d__9>.NativeClassPtr, "<>2__current");
				MoveCameraTo._execute_d__9.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveCameraTo._execute_d__9>.NativeClassPtr, "<>l__initialThreadId");
				MoveCameraTo._execute_d__9.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveCameraTo._execute_d__9>.NativeClassPtr, "<>4__this");
				MoveCameraTo._execute_d__9.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveCameraTo._execute_d__9>.NativeClassPtr, "<>7__wrap1");
				MoveCameraTo._execute_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveCameraTo._execute_d__9>.NativeClassPtr, 100663494);
				MoveCameraTo._execute_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveCameraTo._execute_d__9>.NativeClassPtr, 100663495);
				MoveCameraTo._execute_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveCameraTo._execute_d__9>.NativeClassPtr, 100663496);
				MoveCameraTo._execute_d__9.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveCameraTo._execute_d__9>.NativeClassPtr, 100663497);
				MoveCameraTo._execute_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveCameraTo._execute_d__9>.NativeClassPtr, 100663498);
				MoveCameraTo._execute_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveCameraTo._execute_d__9>.NativeClassPtr, 100663499);
				MoveCameraTo._execute_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveCameraTo._execute_d__9>.NativeClassPtr, 100663500);
				MoveCameraTo._execute_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveCameraTo._execute_d__9>.NativeClassPtr, 100663501);
				MoveCameraTo._execute_d__9.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveCameraTo._execute_d__9>.NativeClassPtr, 100663502);
			}

			// Token: 0x0600189C RID: 6300 RVA: 0x0007B304 File Offset: 0x00079504
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__9(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MoveCameraTo._execute_d__9>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveCameraTo._execute_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600189D RID: 6301 RVA: 0x0007B34C File Offset: 0x0007954C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 544322, XrefRangeEnd = 544327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveCameraTo._execute_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600189E RID: 6302 RVA: 0x0007B380 File Offset: 0x00079580
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 544327, XrefRangeEnd = 544360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveCameraTo._execute_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600189F RID: 6303 RVA: 0x0007B3BC File Offset: 0x000795BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 544360, XrefRangeEnd = 544363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveCameraTo._execute_d__9.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700056A RID: 1386
			// (get) Token: 0x060018A0 RID: 6304 RVA: 0x0007B3F0 File Offset: 0x000795F0
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveCameraTo._execute_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x060018A1 RID: 6305 RVA: 0x0007B430 File Offset: 0x00079630
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 544363, XrefRangeEnd = 544368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveCameraTo._execute_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700056B RID: 1387
			// (get) Token: 0x060018A2 RID: 6306 RVA: 0x0007B464 File Offset: 0x00079664
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveCameraTo._execute_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060018A3 RID: 6307 RVA: 0x0007B4A4 File Offset: 0x000796A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 544368, XrefRangeEnd = 544370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveCameraTo._execute_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x060018A4 RID: 6308 RVA: 0x0007B4E4 File Offset: 0x000796E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveCameraTo._execute_d__9.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x060018A5 RID: 6309 RVA: 0x0000BC1C File Offset: 0x00009E1C
			public _execute_d__9(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000565 RID: 1381
			// (get) Token: 0x060018A6 RID: 6310 RVA: 0x0007B524 File Offset: 0x00079724
			// (set) Token: 0x060018A7 RID: 6311 RVA: 0x0000BC25 File Offset: 0x00009E25
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveCameraTo._execute_d__9.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveCameraTo._execute_d__9.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000566 RID: 1382
			// (get) Token: 0x060018A8 RID: 6312 RVA: 0x0007B54C File Offset: 0x0007974C
			// (set) Token: 0x060018A9 RID: 6313 RVA: 0x0000BC40 File Offset: 0x00009E40
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveCameraTo._execute_d__9.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveCameraTo._execute_d__9.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000567 RID: 1383
			// (get) Token: 0x060018AA RID: 6314 RVA: 0x0007B57C File Offset: 0x0007977C
			// (set) Token: 0x060018AB RID: 6315 RVA: 0x0000BC5F File Offset: 0x00009E5F
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveCameraTo._execute_d__9.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveCameraTo._execute_d__9.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17000568 RID: 1384
			// (get) Token: 0x060018AC RID: 6316 RVA: 0x0007B5A4 File Offset: 0x000797A4
			// (set) Token: 0x060018AD RID: 6317 RVA: 0x0000BC7A File Offset: 0x00009E7A
			public unsafe MoveCameraTo __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveCameraTo._execute_d__9.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MoveCameraTo>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveCameraTo._execute_d__9.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000569 RID: 1385
			// (get) Token: 0x060018AE RID: 6318 RVA: 0x0007B5D4 File Offset: 0x000797D4
			// (set) Token: 0x060018AF RID: 6319 RVA: 0x0000BC99 File Offset: 0x00009E99
			public unsafe IEnumerator<global::Canis.actions.Action> __7__wrap1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveCameraTo._execute_d__9.NativeFieldInfoPtr___7__wrap1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveCameraTo._execute_d__9.NativeFieldInfoPtr___7__wrap1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000FBE RID: 4030
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000FBF RID: 4031
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000FC0 RID: 4032
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04000FC1 RID: 4033
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000FC2 RID: 4034
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

			// Token: 0x04000FC3 RID: 4035
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000FC4 RID: 4036
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000FC5 RID: 4037
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000FC6 RID: 4038
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04000FC7 RID: 4039
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04000FC8 RID: 4040
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000FC9 RID: 4041
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000FCA RID: 4042
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04000FCB RID: 4043
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
