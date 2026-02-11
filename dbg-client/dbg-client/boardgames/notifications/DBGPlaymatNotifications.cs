using System;
using Canis.utils.ids;
using dwd.core.notifications.messages.incoming;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace boardgames.notifications
{
	// Token: 0x02000109 RID: 265
	public class DBGPlaymatNotifications : DBGNotifications
	{
		// Token: 0x06000BBE RID: 3006 RVA: 0x00042B20 File Offset: 0x00040D20
		// Note: this type is marked as 'beforefieldinit'.
		static DBGPlaymatNotifications()
		{
			Il2CppClassPointerStore<DBGPlaymatNotifications>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.notifications", "DBGPlaymatNotifications");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DBGPlaymatNotifications>.NativeClassPtr);
			DBGPlaymatNotifications.NativeMethodInfoPtr_ShowNotifications_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGPlaymatNotifications>.NativeClassPtr, 100665042);
			DBGPlaymatNotifications.NativeMethodInfoPtr_TryGetNextNotification_Private_Boolean_byref_Notification_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGPlaymatNotifications>.NativeClassPtr, 100665043);
			DBGPlaymatNotifications.NativeMethodInfoPtr_AlreadyInGame_Private_Static_Boolean_GameID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGPlaymatNotifications>.NativeClassPtr, 100665044);
			DBGPlaymatNotifications.NativeMethodInfoPtr_IsLive_Private_Static_Boolean_IReadOnlyDictionary_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGPlaymatNotifications>.NativeClassPtr, 100665045);
			DBGPlaymatNotifications.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGPlaymatNotifications>.NativeClassPtr, 100665046);
		}

		// Token: 0x06000BBF RID: 3007 RVA: 0x00042BB4 File Offset: 0x00040DB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 509163, XrefRangeEnd = 509168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator ShowNotifications()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DBGPlaymatNotifications.NativeMethodInfoPtr_ShowNotifications_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000BC0 RID: 3008 RVA: 0x00042C00 File Offset: 0x00040E00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 509168, XrefRangeEnd = 509188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryGetNextNotification(out Notification notification)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr = 0;
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(DBGPlaymatNotifications.NativeMethodInfoPtr_TryGetNextNotification_Private_Boolean_byref_Notification_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				notification = ((intPtr4 == 0) ? null : new Notification(intPtr4));
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x06000BC1 RID: 3009 RVA: 0x00042C60 File Offset: 0x00040E60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 509188, XrefRangeEnd = 509191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool AlreadyInGame(GameID gameID)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameID);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGPlaymatNotifications.NativeMethodInfoPtr_AlreadyInGame_Private_Static_Boolean_GameID_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000BC2 RID: 3010 RVA: 0x00042CA4 File Offset: 0x00040EA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 509191, XrefRangeEnd = 509197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsLive(IReadOnlyDictionary<string, string> options)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(options);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGPlaymatNotifications.NativeMethodInfoPtr_IsLive_Private_Static_Boolean_IReadOnlyDictionary_2_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000BC3 RID: 3011 RVA: 0x00042CE8 File Offset: 0x00040EE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DBGPlaymatNotifications()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DBGPlaymatNotifications>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGPlaymatNotifications.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BC4 RID: 3012 RVA: 0x00007A10 File Offset: 0x00005C10
		public DBGPlaymatNotifications(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400073D RID: 1853
		private static readonly IntPtr NativeMethodInfoPtr_ShowNotifications_Protected_Virtual_IEnumerator_0;

		// Token: 0x0400073E RID: 1854
		private static readonly IntPtr NativeMethodInfoPtr_TryGetNextNotification_Private_Boolean_byref_Notification_0;

		// Token: 0x0400073F RID: 1855
		private static readonly IntPtr NativeMethodInfoPtr_AlreadyInGame_Private_Static_Boolean_GameID_0;

		// Token: 0x04000740 RID: 1856
		private static readonly IntPtr NativeMethodInfoPtr_IsLive_Private_Static_Boolean_IReadOnlyDictionary_2_String_String_0;

		// Token: 0x04000741 RID: 1857
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200034E RID: 846
		[ObfuscatedName("boardgames.notifications.DBGPlaymatNotifications+<>c")]
		[Serializable]
		public new sealed class __c : Object
		{
			// Token: 0x06002803 RID: 10243 RVA: 0x000A0438 File Offset: 0x0009E638
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<DBGPlaymatNotifications.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DBGPlaymatNotifications>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DBGPlaymatNotifications.__c>.NativeClassPtr);
				DBGPlaymatNotifications.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGPlaymatNotifications.__c>.NativeClassPtr, "<>9");
				DBGPlaymatNotifications.__c.NativeFieldInfoPtr___9__1_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGPlaymatNotifications.__c>.NativeClassPtr, "<>9__1_0");
				DBGPlaymatNotifications.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGPlaymatNotifications.__c>.NativeClassPtr, 100665048);
				DBGPlaymatNotifications.__c.NativeMethodInfoPtr__TryGetNextNotification_b__1_0_Internal_Boolean_Notification_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGPlaymatNotifications.__c>.NativeClassPtr, 100665049);
			}

			// Token: 0x06002804 RID: 10244 RVA: 0x000A04B4 File Offset: 0x0009E6B4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DBGPlaymatNotifications.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGPlaymatNotifications.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002805 RID: 10245 RVA: 0x000A04F0 File Offset: 0x0009E6F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 509123, XrefRangeEnd = 509127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _TryGetNextNotification_b__1_0(Notification n)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(n);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGPlaymatNotifications.__c.NativeMethodInfoPtr__TryGetNextNotification_b__1_0_Internal_Boolean_Notification_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002806 RID: 10246 RVA: 0x00014B54 File Offset: 0x00012D54
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000B2F RID: 2863
			// (get) Token: 0x06002807 RID: 10247 RVA: 0x000A0540 File Offset: 0x0009E740
			// (set) Token: 0x06002808 RID: 10248 RVA: 0x00014B5D File Offset: 0x00012D5D
			public unsafe static DBGPlaymatNotifications.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DBGPlaymatNotifications.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGPlaymatNotifications.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DBGPlaymatNotifications.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B30 RID: 2864
			// (get) Token: 0x06002809 RID: 10249 RVA: 0x000A0568 File Offset: 0x0009E768
			// (set) Token: 0x0600280A RID: 10250 RVA: 0x00014B6F File Offset: 0x00012D6F
			public unsafe static Func<Notification, bool> __9__1_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DBGPlaymatNotifications.__c.NativeFieldInfoPtr___9__1_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Notification, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DBGPlaymatNotifications.__c.NativeFieldInfoPtr___9__1_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001917 RID: 6423
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04001918 RID: 6424
			private static readonly IntPtr NativeFieldInfoPtr___9__1_0;

			// Token: 0x04001919 RID: 6425
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400191A RID: 6426
			private static readonly IntPtr NativeMethodInfoPtr__TryGetNextNotification_b__1_0_Internal_Boolean_Notification_0;
		}

		// Token: 0x0200034F RID: 847
		[ObfuscatedName("boardgames.notifications.DBGPlaymatNotifications+<ShowNotifications>d__0")]
		public sealed class _ShowNotifications_d__0 : Object
		{
			// Token: 0x0600280B RID: 10251 RVA: 0x000A0590 File Offset: 0x0009E790
			// Note: this type is marked as 'beforefieldinit'.
			static _ShowNotifications_d__0()
			{
				Il2CppClassPointerStore<DBGPlaymatNotifications._ShowNotifications_d__0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DBGPlaymatNotifications>.NativeClassPtr, "<ShowNotifications>d__0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DBGPlaymatNotifications._ShowNotifications_d__0>.NativeClassPtr);
				DBGPlaymatNotifications._ShowNotifications_d__0.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGPlaymatNotifications._ShowNotifications_d__0>.NativeClassPtr, "<>1__state");
				DBGPlaymatNotifications._ShowNotifications_d__0.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGPlaymatNotifications._ShowNotifications_d__0>.NativeClassPtr, "<>2__current");
				DBGPlaymatNotifications._ShowNotifications_d__0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGPlaymatNotifications._ShowNotifications_d__0>.NativeClassPtr, "<>4__this");
				DBGPlaymatNotifications._ShowNotifications_d__0.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGPlaymatNotifications._ShowNotifications_d__0>.NativeClassPtr, 100665050);
				DBGPlaymatNotifications._ShowNotifications_d__0.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGPlaymatNotifications._ShowNotifications_d__0>.NativeClassPtr, 100665051);
				DBGPlaymatNotifications._ShowNotifications_d__0.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGPlaymatNotifications._ShowNotifications_d__0>.NativeClassPtr, 100665052);
				DBGPlaymatNotifications._ShowNotifications_d__0.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGPlaymatNotifications._ShowNotifications_d__0>.NativeClassPtr, 100665053);
				DBGPlaymatNotifications._ShowNotifications_d__0.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGPlaymatNotifications._ShowNotifications_d__0>.NativeClassPtr, 100665054);
				DBGPlaymatNotifications._ShowNotifications_d__0.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGPlaymatNotifications._ShowNotifications_d__0>.NativeClassPtr, 100665055);
			}

			// Token: 0x0600280C RID: 10252 RVA: 0x000A0670 File Offset: 0x0009E870
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _ShowNotifications_d__0(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DBGPlaymatNotifications._ShowNotifications_d__0>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGPlaymatNotifications._ShowNotifications_d__0.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600280D RID: 10253 RVA: 0x000A06B8 File Offset: 0x0009E8B8
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGPlaymatNotifications._ShowNotifications_d__0.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600280E RID: 10254 RVA: 0x000A06EC File Offset: 0x0009E8EC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 509127, XrefRangeEnd = 509158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGPlaymatNotifications._ShowNotifications_d__0.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000B34 RID: 2868
			// (get) Token: 0x0600280F RID: 10255 RVA: 0x000A0728 File Offset: 0x0009E928
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGPlaymatNotifications._ShowNotifications_d__0.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002810 RID: 10256 RVA: 0x000A0768 File Offset: 0x0009E968
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 509158, XrefRangeEnd = 509163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGPlaymatNotifications._ShowNotifications_d__0.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000B35 RID: 2869
			// (get) Token: 0x06002811 RID: 10257 RVA: 0x000A079C File Offset: 0x0009E99C
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGPlaymatNotifications._ShowNotifications_d__0.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002812 RID: 10258 RVA: 0x00014B81 File Offset: 0x00012D81
			public _ShowNotifications_d__0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000B31 RID: 2865
			// (get) Token: 0x06002813 RID: 10259 RVA: 0x000A07DC File Offset: 0x0009E9DC
			// (set) Token: 0x06002814 RID: 10260 RVA: 0x00014B8A File Offset: 0x00012D8A
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGPlaymatNotifications._ShowNotifications_d__0.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGPlaymatNotifications._ShowNotifications_d__0.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000B32 RID: 2866
			// (get) Token: 0x06002815 RID: 10261 RVA: 0x000A0804 File Offset: 0x0009EA04
			// (set) Token: 0x06002816 RID: 10262 RVA: 0x00014BA5 File Offset: 0x00012DA5
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGPlaymatNotifications._ShowNotifications_d__0.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGPlaymatNotifications._ShowNotifications_d__0.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B33 RID: 2867
			// (get) Token: 0x06002817 RID: 10263 RVA: 0x000A0834 File Offset: 0x0009EA34
			// (set) Token: 0x06002818 RID: 10264 RVA: 0x00014BC4 File Offset: 0x00012DC4
			public unsafe DBGPlaymatNotifications __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGPlaymatNotifications._ShowNotifications_d__0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGPlaymatNotifications>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGPlaymatNotifications._ShowNotifications_d__0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400191B RID: 6427
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400191C RID: 6428
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400191D RID: 6429
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400191E RID: 6430
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400191F RID: 6431
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001920 RID: 6432
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001921 RID: 6433
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001922 RID: 6434
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001923 RID: 6435
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
