using System;
using dwd.core.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;

namespace boardgames.commands
{
	// Token: 0x0200019E RID: 414
	public class WaitForReconnectableLiveGame : Command
	{
		// Token: 0x0600125A RID: 4698 RVA: 0x0005855C File Offset: 0x0005675C
		// Note: this type is marked as 'beforefieldinit'.
		static WaitForReconnectableLiveGame()
		{
			Il2CppClassPointerStore<WaitForReconnectableLiveGame>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.commands", "WaitForReconnectableLiveGame");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WaitForReconnectableLiveGame>.NativeClassPtr);
			WaitForReconnectableLiveGame.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitForReconnectableLiveGame>.NativeClassPtr, 100665954);
			WaitForReconnectableLiveGame.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitForReconnectableLiveGame>.NativeClassPtr, 100665955);
		}

		// Token: 0x0600125B RID: 4699 RVA: 0x000585B4 File Offset: 0x000567B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 516858, XrefRangeEnd = 516862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WaitForReconnectableLiveGame.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600125C RID: 4700 RVA: 0x00058600 File Offset: 0x00056800
		[CallerCount(55)]
		[CachedScanResults(RefRangeStart = 498694, RefRangeEnd = 498749, XrefRangeStart = 498694, XrefRangeEnd = 498749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WaitForReconnectableLiveGame()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WaitForReconnectableLiveGame>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitForReconnectableLiveGame.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600125D RID: 4701 RVA: 0x0000AB6F File Offset: 0x00008D6F
		public WaitForReconnectableLiveGame(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000B41 RID: 2881
		private static readonly IntPtr NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0;

		// Token: 0x04000B42 RID: 2882
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200038E RID: 910
		[ObfuscatedName("boardgames.commands.WaitForReconnectableLiveGame+<execute>d__0")]
		public sealed class _execute_d__0 : Object
		{
			// Token: 0x06002AE3 RID: 10979 RVA: 0x000A8C30 File Offset: 0x000A6E30
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__0()
			{
				Il2CppClassPointerStore<WaitForReconnectableLiveGame._execute_d__0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WaitForReconnectableLiveGame>.NativeClassPtr, "<execute>d__0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WaitForReconnectableLiveGame._execute_d__0>.NativeClassPtr);
				WaitForReconnectableLiveGame._execute_d__0.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaitForReconnectableLiveGame._execute_d__0>.NativeClassPtr, "<>1__state");
				WaitForReconnectableLiveGame._execute_d__0.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaitForReconnectableLiveGame._execute_d__0>.NativeClassPtr, "<>2__current");
				WaitForReconnectableLiveGame._execute_d__0.NativeFieldInfoPtr__timeout_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaitForReconnectableLiveGame._execute_d__0>.NativeClassPtr, "<timeout>5__2");
				WaitForReconnectableLiveGame._execute_d__0.NativeFieldInfoPtr__start_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaitForReconnectableLiveGame._execute_d__0>.NativeClassPtr, "<start>5__3");
				WaitForReconnectableLiveGame._execute_d__0.NativeFieldInfoPtr__reconnect_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaitForReconnectableLiveGame._execute_d__0>.NativeClassPtr, "<reconnect>5__4");
				WaitForReconnectableLiveGame._execute_d__0.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitForReconnectableLiveGame._execute_d__0>.NativeClassPtr, 100665956);
				WaitForReconnectableLiveGame._execute_d__0.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitForReconnectableLiveGame._execute_d__0>.NativeClassPtr, 100665957);
				WaitForReconnectableLiveGame._execute_d__0.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitForReconnectableLiveGame._execute_d__0>.NativeClassPtr, 100665958);
				WaitForReconnectableLiveGame._execute_d__0.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitForReconnectableLiveGame._execute_d__0>.NativeClassPtr, 100665959);
				WaitForReconnectableLiveGame._execute_d__0.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitForReconnectableLiveGame._execute_d__0>.NativeClassPtr, 100665960);
				WaitForReconnectableLiveGame._execute_d__0.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitForReconnectableLiveGame._execute_d__0>.NativeClassPtr, 100665961);
			}

			// Token: 0x06002AE4 RID: 10980 RVA: 0x000A8D38 File Offset: 0x000A6F38
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__0(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WaitForReconnectableLiveGame._execute_d__0>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitForReconnectableLiveGame._execute_d__0.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002AE5 RID: 10981 RVA: 0x000A8D80 File Offset: 0x000A6F80
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitForReconnectableLiveGame._execute_d__0.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002AE6 RID: 10982 RVA: 0x000A8DB4 File Offset: 0x000A6FB4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 516837, XrefRangeEnd = 516853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitForReconnectableLiveGame._execute_d__0.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000C27 RID: 3111
			// (get) Token: 0x06002AE7 RID: 10983 RVA: 0x000A8DF0 File Offset: 0x000A6FF0
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitForReconnectableLiveGame._execute_d__0.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002AE8 RID: 10984 RVA: 0x000A8E30 File Offset: 0x000A7030
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 516853, XrefRangeEnd = 516858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitForReconnectableLiveGame._execute_d__0.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000C28 RID: 3112
			// (get) Token: 0x06002AE9 RID: 10985 RVA: 0x000A8E64 File Offset: 0x000A7064
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitForReconnectableLiveGame._execute_d__0.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002AEA RID: 10986 RVA: 0x000162C9 File Offset: 0x000144C9
			public _execute_d__0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000C22 RID: 3106
			// (get) Token: 0x06002AEB RID: 10987 RVA: 0x000A8EA4 File Offset: 0x000A70A4
			// (set) Token: 0x06002AEC RID: 10988 RVA: 0x000162D2 File Offset: 0x000144D2
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitForReconnectableLiveGame._execute_d__0.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitForReconnectableLiveGame._execute_d__0.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000C23 RID: 3107
			// (get) Token: 0x06002AED RID: 10989 RVA: 0x000A8ECC File Offset: 0x000A70CC
			// (set) Token: 0x06002AEE RID: 10990 RVA: 0x000162ED File Offset: 0x000144ED
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitForReconnectableLiveGame._execute_d__0.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitForReconnectableLiveGame._execute_d__0.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000C24 RID: 3108
			// (get) Token: 0x06002AEF RID: 10991 RVA: 0x000A8EFC File Offset: 0x000A70FC
			// (set) Token: 0x06002AF0 RID: 10992 RVA: 0x0001630C File Offset: 0x0001450C
			public unsafe TimeSpan _timeout_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitForReconnectableLiveGame._execute_d__0.NativeFieldInfoPtr__timeout_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitForReconnectableLiveGame._execute_d__0.NativeFieldInfoPtr__timeout_5__2)) = value;
				}
			}

			// Token: 0x17000C25 RID: 3109
			// (get) Token: 0x06002AF1 RID: 10993 RVA: 0x000A8F24 File Offset: 0x000A7124
			// (set) Token: 0x06002AF2 RID: 10994 RVA: 0x00016327 File Offset: 0x00014527
			public unsafe DateTime _start_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitForReconnectableLiveGame._execute_d__0.NativeFieldInfoPtr__start_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitForReconnectableLiveGame._execute_d__0.NativeFieldInfoPtr__start_5__3)) = value;
				}
			}

			// Token: 0x17000C26 RID: 3110
			// (get) Token: 0x06002AF3 RID: 10995 RVA: 0x000A8F4C File Offset: 0x000A714C
			// (set) Token: 0x06002AF4 RID: 10996 RVA: 0x00016342 File Offset: 0x00014542
			public unsafe DBGCheckForReconnectableLiveGameCommand _reconnect_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitForReconnectableLiveGame._execute_d__0.NativeFieldInfoPtr__reconnect_5__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGCheckForReconnectableLiveGameCommand>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitForReconnectableLiveGame._execute_d__0.NativeFieldInfoPtr__reconnect_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001AC0 RID: 6848
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001AC1 RID: 6849
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001AC2 RID: 6850
			private static readonly IntPtr NativeFieldInfoPtr__timeout_5__2;

			// Token: 0x04001AC3 RID: 6851
			private static readonly IntPtr NativeFieldInfoPtr__start_5__3;

			// Token: 0x04001AC4 RID: 6852
			private static readonly IntPtr NativeFieldInfoPtr__reconnect_5__4;

			// Token: 0x04001AC5 RID: 6853
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001AC6 RID: 6854
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001AC7 RID: 6855
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001AC8 RID: 6856
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001AC9 RID: 6857
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001ACA RID: 6858
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
