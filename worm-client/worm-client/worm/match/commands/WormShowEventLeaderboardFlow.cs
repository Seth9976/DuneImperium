using System;
using Canis.utils.ids;
using dwd.core.commands;
using dwd.core.data.composition;
using dwd.core.session.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using worm.networking.responses;

namespace worm.match.commands
{
	// Token: 0x02000242 RID: 578
	public class WormShowEventLeaderboardFlow : Command
	{
		// Token: 0x060018D4 RID: 6356 RVA: 0x00063960 File Offset: 0x00061B60
		// Note: this type is marked as 'beforefieldinit'.
		static WormShowEventLeaderboardFlow()
		{
			Il2CppClassPointerStore<WormShowEventLeaderboardFlow>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.commands", "WormShowEventLeaderboardFlow");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormShowEventLeaderboardFlow>.NativeClassPtr);
			WormShowEventLeaderboardFlow.NativeFieldInfoPtr_eventData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormShowEventLeaderboardFlow>.NativeClassPtr, "eventData");
			WormShowEventLeaderboardFlow.NativeMethodInfoPtr__ctor_Public_Void_DataComposition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormShowEventLeaderboardFlow>.NativeClassPtr, 100666800);
			WormShowEventLeaderboardFlow.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormShowEventLeaderboardFlow>.NativeClassPtr, 100666801);
		}

		// Token: 0x060018D5 RID: 6357 RVA: 0x000639CC File Offset: 0x00061BCC
		[CallerCount(37)]
		[CachedScanResults(RefRangeStart = 495009, RefRangeEnd = 495046, XrefRangeStart = 495009, XrefRangeEnd = 495046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormShowEventLeaderboardFlow(DataComposition eventData)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormShowEventLeaderboardFlow>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormShowEventLeaderboardFlow.NativeMethodInfoPtr__ctor_Public_Void_DataComposition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060018D6 RID: 6358 RVA: 0x00063A18 File Offset: 0x00061C18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 719317, XrefRangeEnd = 719322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormShowEventLeaderboardFlow.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060018D7 RID: 6359 RVA: 0x0000EA08 File Offset: 0x0000CC08
		public WormShowEventLeaderboardFlow(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006E2 RID: 1762
		// (get) Token: 0x060018D8 RID: 6360 RVA: 0x00063A64 File Offset: 0x00061C64
		// (set) Token: 0x060018D9 RID: 6361 RVA: 0x0000EA11 File Offset: 0x0000CC11
		public unsafe DataComposition eventData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormShowEventLeaderboardFlow.NativeFieldInfoPtr_eventData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataComposition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormShowEventLeaderboardFlow.NativeFieldInfoPtr_eventData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000E5E RID: 3678
		private static readonly IntPtr NativeFieldInfoPtr_eventData;

		// Token: 0x04000E5F RID: 3679
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_DataComposition_0;

		// Token: 0x04000E60 RID: 3680
		private static readonly IntPtr NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0;

		// Token: 0x02000413 RID: 1043
		[ObfuscatedName("worm.match.commands.WormShowEventLeaderboardFlow+<execute>d__2")]
		public sealed class _execute_d__2 : Object
		{
			// Token: 0x06002B06 RID: 11014 RVA: 0x0009A60C File Offset: 0x0009880C
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__2()
			{
				Il2CppClassPointerStore<WormShowEventLeaderboardFlow._execute_d__2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormShowEventLeaderboardFlow>.NativeClassPtr, "<execute>d__2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormShowEventLeaderboardFlow._execute_d__2>.NativeClassPtr);
				WormShowEventLeaderboardFlow._execute_d__2.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormShowEventLeaderboardFlow._execute_d__2>.NativeClassPtr, "<>1__state");
				WormShowEventLeaderboardFlow._execute_d__2.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormShowEventLeaderboardFlow._execute_d__2>.NativeClassPtr, "<>2__current");
				WormShowEventLeaderboardFlow._execute_d__2.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormShowEventLeaderboardFlow._execute_d__2>.NativeClassPtr, "<>4__this");
				WormShowEventLeaderboardFlow._execute_d__2.NativeFieldInfoPtr__eventID_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormShowEventLeaderboardFlow._execute_d__2>.NativeClassPtr, "<eventID>5__2");
				WormShowEventLeaderboardFlow._execute_d__2.NativeFieldInfoPtr__leaderboard_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormShowEventLeaderboardFlow._execute_d__2>.NativeClassPtr, "<leaderboard>5__3");
				WormShowEventLeaderboardFlow._execute_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormShowEventLeaderboardFlow._execute_d__2>.NativeClassPtr, 100666802);
				WormShowEventLeaderboardFlow._execute_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormShowEventLeaderboardFlow._execute_d__2>.NativeClassPtr, 100666803);
				WormShowEventLeaderboardFlow._execute_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormShowEventLeaderboardFlow._execute_d__2>.NativeClassPtr, 100666804);
				WormShowEventLeaderboardFlow._execute_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormShowEventLeaderboardFlow._execute_d__2>.NativeClassPtr, 100666805);
				WormShowEventLeaderboardFlow._execute_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormShowEventLeaderboardFlow._execute_d__2>.NativeClassPtr, 100666806);
				WormShowEventLeaderboardFlow._execute_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormShowEventLeaderboardFlow._execute_d__2>.NativeClassPtr, 100666807);
			}

			// Token: 0x06002B07 RID: 11015 RVA: 0x0009A714 File Offset: 0x00098914
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__2(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormShowEventLeaderboardFlow._execute_d__2>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormShowEventLeaderboardFlow._execute_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002B08 RID: 11016 RVA: 0x0009A75C File Offset: 0x0009895C
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormShowEventLeaderboardFlow._execute_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002B09 RID: 11017 RVA: 0x0009A790 File Offset: 0x00098990
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 719279, XrefRangeEnd = 719312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormShowEventLeaderboardFlow._execute_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000C45 RID: 3141
			// (get) Token: 0x06002B0A RID: 11018 RVA: 0x0009A7CC File Offset: 0x000989CC
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormShowEventLeaderboardFlow._execute_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002B0B RID: 11019 RVA: 0x0009A80C File Offset: 0x00098A0C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 719312, XrefRangeEnd = 719317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormShowEventLeaderboardFlow._execute_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000C46 RID: 3142
			// (get) Token: 0x06002B0C RID: 11020 RVA: 0x0009A840 File Offset: 0x00098A40
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormShowEventLeaderboardFlow._execute_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002B0D RID: 11021 RVA: 0x000177E8 File Offset: 0x000159E8
			public _execute_d__2(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000C40 RID: 3136
			// (get) Token: 0x06002B0E RID: 11022 RVA: 0x0009A880 File Offset: 0x00098A80
			// (set) Token: 0x06002B0F RID: 11023 RVA: 0x000177F1 File Offset: 0x000159F1
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormShowEventLeaderboardFlow._execute_d__2.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormShowEventLeaderboardFlow._execute_d__2.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000C41 RID: 3137
			// (get) Token: 0x06002B10 RID: 11024 RVA: 0x0009A8A8 File Offset: 0x00098AA8
			// (set) Token: 0x06002B11 RID: 11025 RVA: 0x0001780C File Offset: 0x00015A0C
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormShowEventLeaderboardFlow._execute_d__2.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormShowEventLeaderboardFlow._execute_d__2.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000C42 RID: 3138
			// (get) Token: 0x06002B12 RID: 11026 RVA: 0x0009A8D8 File Offset: 0x00098AD8
			// (set) Token: 0x06002B13 RID: 11027 RVA: 0x0001782B File Offset: 0x00015A2B
			public unsafe WormShowEventLeaderboardFlow __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormShowEventLeaderboardFlow._execute_d__2.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormShowEventLeaderboardFlow>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormShowEventLeaderboardFlow._execute_d__2.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000C43 RID: 3139
			// (get) Token: 0x06002B14 RID: 11028 RVA: 0x0009A908 File Offset: 0x00098B08
			// (set) Token: 0x06002B15 RID: 11029 RVA: 0x0001784A File Offset: 0x00015A4A
			public unsafe EventID _eventID_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormShowEventLeaderboardFlow._execute_d__2.NativeFieldInfoPtr__eventID_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventID>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormShowEventLeaderboardFlow._execute_d__2.NativeFieldInfoPtr__eventID_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000C44 RID: 3140
			// (get) Token: 0x06002B16 RID: 11030 RVA: 0x0009A938 File Offset: 0x00098B38
			// (set) Token: 0x06002B17 RID: 11031 RVA: 0x00017869 File Offset: 0x00015A69
			public unsafe WriteToSessionAndAwaitResponse<EventLeaderboard, EventError> _leaderboard_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormShowEventLeaderboardFlow._execute_d__2.NativeFieldInfoPtr__leaderboard_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WriteToSessionAndAwaitResponse<EventLeaderboard, EventError>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormShowEventLeaderboardFlow._execute_d__2.NativeFieldInfoPtr__leaderboard_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040018FA RID: 6394
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040018FB RID: 6395
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040018FC RID: 6396
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040018FD RID: 6397
			private static readonly IntPtr NativeFieldInfoPtr__eventID_5__2;

			// Token: 0x040018FE RID: 6398
			private static readonly IntPtr NativeFieldInfoPtr__leaderboard_5__3;

			// Token: 0x040018FF RID: 6399
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001900 RID: 6400
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001901 RID: 6401
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001902 RID: 6402
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001903 RID: 6403
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001904 RID: 6404
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
