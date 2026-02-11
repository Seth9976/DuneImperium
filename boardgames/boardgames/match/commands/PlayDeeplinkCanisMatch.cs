using System;
using dwd.core.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;

namespace boardgames.match.commands
{
	// Token: 0x0200012F RID: 303
	public sealed class PlayDeeplinkCanisMatch : Command
	{
		// Token: 0x06000FE1 RID: 4065 RVA: 0x00041AD0 File Offset: 0x0003FCD0
		// Note: this type is marked as 'beforefieldinit'.
		static PlayDeeplinkCanisMatch()
		{
			Il2CppClassPointerStore<PlayDeeplinkCanisMatch>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "boardgames.match.commands", "PlayDeeplinkCanisMatch");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayDeeplinkCanisMatch>.NativeClassPtr);
			PlayDeeplinkCanisMatch.NativeFieldInfoPtr_playOnlineMatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayDeeplinkCanisMatch>.NativeClassPtr, "playOnlineMatch");
			PlayDeeplinkCanisMatch.NativeFieldInfoPtr_requiredLoadedScene = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayDeeplinkCanisMatch>.NativeClassPtr, "requiredLoadedScene");
			PlayDeeplinkCanisMatch.NativeFieldInfoPtr_isMatchComplete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayDeeplinkCanisMatch>.NativeClassPtr, "isMatchComplete");
			PlayDeeplinkCanisMatch.NativeMethodInfoPtr__ctor_Public_Void_Command_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayDeeplinkCanisMatch>.NativeClassPtr, 100665576);
			PlayDeeplinkCanisMatch.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayDeeplinkCanisMatch>.NativeClassPtr, 100665577);
		}

		// Token: 0x06000FE2 RID: 4066 RVA: 0x00041B64 File Offset: 0x0003FD64
		[CallerCount(17)]
		[CachedScanResults(RefRangeStart = 495165, RefRangeEnd = 495182, XrefRangeStart = 495165, XrefRangeEnd = 495182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayDeeplinkCanisMatch(Command playOnlineMatch, string requiredLoadedScene)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayDeeplinkCanisMatch>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(playOnlineMatch);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(requiredLoadedScene);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayDeeplinkCanisMatch.NativeMethodInfoPtr__ctor_Public_Void_Command_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FE3 RID: 4067 RVA: 0x00041BC4 File Offset: 0x0003FDC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 998355, XrefRangeEnd = 998360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayDeeplinkCanisMatch.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000FE4 RID: 4068 RVA: 0x000095B7 File Offset: 0x000077B7
		public PlayDeeplinkCanisMatch(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000498 RID: 1176
		// (get) Token: 0x06000FE5 RID: 4069 RVA: 0x00041C04 File Offset: 0x0003FE04
		// (set) Token: 0x06000FE6 RID: 4070 RVA: 0x000095C0 File Offset: 0x000077C0
		public unsafe Command playOnlineMatch
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayDeeplinkCanisMatch.NativeFieldInfoPtr_playOnlineMatch);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Command>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayDeeplinkCanisMatch.NativeFieldInfoPtr_playOnlineMatch), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000499 RID: 1177
		// (get) Token: 0x06000FE7 RID: 4071 RVA: 0x00041C34 File Offset: 0x0003FE34
		// (set) Token: 0x06000FE8 RID: 4072 RVA: 0x000095DF File Offset: 0x000077DF
		public unsafe string requiredLoadedScene
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayDeeplinkCanisMatch.NativeFieldInfoPtr_requiredLoadedScene);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayDeeplinkCanisMatch.NativeFieldInfoPtr_requiredLoadedScene), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700049A RID: 1178
		// (get) Token: 0x06000FE9 RID: 4073 RVA: 0x00041C5C File Offset: 0x0003FE5C
		// (set) Token: 0x06000FEA RID: 4074 RVA: 0x000095FE File Offset: 0x000077FE
		public unsafe bool isMatchComplete
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayDeeplinkCanisMatch.NativeFieldInfoPtr_isMatchComplete);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayDeeplinkCanisMatch.NativeFieldInfoPtr_isMatchComplete)) = value;
			}
		}

		// Token: 0x040009B0 RID: 2480
		private static readonly IntPtr NativeFieldInfoPtr_playOnlineMatch;

		// Token: 0x040009B1 RID: 2481
		private static readonly IntPtr NativeFieldInfoPtr_requiredLoadedScene;

		// Token: 0x040009B2 RID: 2482
		private static readonly IntPtr NativeFieldInfoPtr_isMatchComplete;

		// Token: 0x040009B3 RID: 2483
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Command_String_0;

		// Token: 0x040009B4 RID: 2484
		private static readonly IntPtr NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0;

		// Token: 0x02000266 RID: 614
		[ObfuscatedName("boardgames.match.commands.PlayDeeplinkCanisMatch+<execute>d__4")]
		public sealed class _execute_d__4 : Object
		{
			// Token: 0x06001C20 RID: 7200 RVA: 0x00067CA4 File Offset: 0x00065EA4
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__4()
			{
				Il2CppClassPointerStore<PlayDeeplinkCanisMatch._execute_d__4>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayDeeplinkCanisMatch>.NativeClassPtr, "<execute>d__4");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayDeeplinkCanisMatch._execute_d__4>.NativeClassPtr);
				PlayDeeplinkCanisMatch._execute_d__4.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayDeeplinkCanisMatch._execute_d__4>.NativeClassPtr, "<>1__state");
				PlayDeeplinkCanisMatch._execute_d__4.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayDeeplinkCanisMatch._execute_d__4>.NativeClassPtr, "<>2__current");
				PlayDeeplinkCanisMatch._execute_d__4.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayDeeplinkCanisMatch._execute_d__4>.NativeClassPtr, "<>4__this");
				PlayDeeplinkCanisMatch._execute_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayDeeplinkCanisMatch._execute_d__4>.NativeClassPtr, 100665578);
				PlayDeeplinkCanisMatch._execute_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayDeeplinkCanisMatch._execute_d__4>.NativeClassPtr, 100665579);
				PlayDeeplinkCanisMatch._execute_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayDeeplinkCanisMatch._execute_d__4>.NativeClassPtr, 100665580);
				PlayDeeplinkCanisMatch._execute_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayDeeplinkCanisMatch._execute_d__4>.NativeClassPtr, 100665581);
				PlayDeeplinkCanisMatch._execute_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayDeeplinkCanisMatch._execute_d__4>.NativeClassPtr, 100665582);
				PlayDeeplinkCanisMatch._execute_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayDeeplinkCanisMatch._execute_d__4>.NativeClassPtr, 100665583);
			}

			// Token: 0x06001C21 RID: 7201 RVA: 0x00067D84 File Offset: 0x00065F84
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__4(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayDeeplinkCanisMatch._execute_d__4>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayDeeplinkCanisMatch._execute_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001C22 RID: 7202 RVA: 0x00067DCC File Offset: 0x00065FCC
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayDeeplinkCanisMatch._execute_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001C23 RID: 7203 RVA: 0x00067E00 File Offset: 0x00066000
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 998349, XrefRangeEnd = 998350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayDeeplinkCanisMatch._execute_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000852 RID: 2130
			// (get) Token: 0x06001C24 RID: 7204 RVA: 0x00067E3C File Offset: 0x0006603C
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayDeeplinkCanisMatch._execute_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001C25 RID: 7205 RVA: 0x00067E7C File Offset: 0x0006607C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 998350, XrefRangeEnd = 998355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayDeeplinkCanisMatch._execute_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000853 RID: 2131
			// (get) Token: 0x06001C26 RID: 7206 RVA: 0x00067EB0 File Offset: 0x000660B0
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayDeeplinkCanisMatch._execute_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001C27 RID: 7207 RVA: 0x0000F30F File Offset: 0x0000D50F
			public _execute_d__4(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700084F RID: 2127
			// (get) Token: 0x06001C28 RID: 7208 RVA: 0x00067EF0 File Offset: 0x000660F0
			// (set) Token: 0x06001C29 RID: 7209 RVA: 0x0000F318 File Offset: 0x0000D518
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayDeeplinkCanisMatch._execute_d__4.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayDeeplinkCanisMatch._execute_d__4.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000850 RID: 2128
			// (get) Token: 0x06001C2A RID: 7210 RVA: 0x00067F18 File Offset: 0x00066118
			// (set) Token: 0x06001C2B RID: 7211 RVA: 0x0000F333 File Offset: 0x0000D533
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayDeeplinkCanisMatch._execute_d__4.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayDeeplinkCanisMatch._execute_d__4.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000851 RID: 2129
			// (get) Token: 0x06001C2C RID: 7212 RVA: 0x00067F48 File Offset: 0x00066148
			// (set) Token: 0x06001C2D RID: 7213 RVA: 0x0000F352 File Offset: 0x0000D552
			public unsafe PlayDeeplinkCanisMatch __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayDeeplinkCanisMatch._execute_d__4.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayDeeplinkCanisMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayDeeplinkCanisMatch._execute_d__4.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001118 RID: 4376
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001119 RID: 4377
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400111A RID: 4378
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400111B RID: 4379
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400111C RID: 4380
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400111D RID: 4381
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400111E RID: 4382
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400111F RID: 4383
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001120 RID: 4384
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
