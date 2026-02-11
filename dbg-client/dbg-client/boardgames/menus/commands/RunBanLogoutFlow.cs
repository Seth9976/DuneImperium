using System;
using dwd.core.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;

namespace boardgames.menus.commands
{
	// Token: 0x0200021A RID: 538
	public class RunBanLogoutFlow : Command
	{
		// Token: 0x0600189E RID: 6302 RVA: 0x0006D6A8 File Offset: 0x0006B8A8
		// Note: this type is marked as 'beforefieldinit'.
		static RunBanLogoutFlow()
		{
			Il2CppClassPointerStore<RunBanLogoutFlow>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.menus.commands", "RunBanLogoutFlow");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RunBanLogoutFlow>.NativeClassPtr);
			RunBanLogoutFlow.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunBanLogoutFlow>.NativeClassPtr, 100666976);
			RunBanLogoutFlow.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunBanLogoutFlow>.NativeClassPtr, 100666977);
		}

		// Token: 0x0600189F RID: 6303 RVA: 0x0006D700 File Offset: 0x0006B900
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 527528, XrefRangeEnd = 527532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RunBanLogoutFlow.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060018A0 RID: 6304 RVA: 0x0006D74C File Offset: 0x0006B94C
		[CallerCount(55)]
		[CachedScanResults(RefRangeStart = 498694, RefRangeEnd = 498749, XrefRangeStart = 498694, XrefRangeEnd = 498749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RunBanLogoutFlow()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunBanLogoutFlow>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunBanLogoutFlow.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018A1 RID: 6305 RVA: 0x0000DA2B File Offset: 0x0000BC2B
		public RunBanLogoutFlow(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000F62 RID: 3938
		private static readonly IntPtr NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0;

		// Token: 0x04000F63 RID: 3939
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020003F2 RID: 1010
		[ObfuscatedName("boardgames.menus.commands.RunBanLogoutFlow+<execute>d__0")]
		public sealed class _execute_d__0 : Object
		{
			// Token: 0x06002F37 RID: 12087 RVA: 0x000B56D4 File Offset: 0x000B38D4
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__0()
			{
				Il2CppClassPointerStore<RunBanLogoutFlow._execute_d__0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RunBanLogoutFlow>.NativeClassPtr, "<execute>d__0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RunBanLogoutFlow._execute_d__0>.NativeClassPtr);
				RunBanLogoutFlow._execute_d__0.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunBanLogoutFlow._execute_d__0>.NativeClassPtr, "<>1__state");
				RunBanLogoutFlow._execute_d__0.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunBanLogoutFlow._execute_d__0>.NativeClassPtr, "<>2__current");
				RunBanLogoutFlow._execute_d__0.NativeFieldInfoPtr__kickToLandingMessage_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunBanLogoutFlow._execute_d__0>.NativeClassPtr, "<kickToLandingMessage>5__2");
				RunBanLogoutFlow._execute_d__0.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunBanLogoutFlow._execute_d__0>.NativeClassPtr, 100666978);
				RunBanLogoutFlow._execute_d__0.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunBanLogoutFlow._execute_d__0>.NativeClassPtr, 100666979);
				RunBanLogoutFlow._execute_d__0.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunBanLogoutFlow._execute_d__0>.NativeClassPtr, 100666980);
				RunBanLogoutFlow._execute_d__0.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunBanLogoutFlow._execute_d__0>.NativeClassPtr, 100666981);
				RunBanLogoutFlow._execute_d__0.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunBanLogoutFlow._execute_d__0>.NativeClassPtr, 100666982);
				RunBanLogoutFlow._execute_d__0.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunBanLogoutFlow._execute_d__0>.NativeClassPtr, 100666983);
			}

			// Token: 0x06002F38 RID: 12088 RVA: 0x000B57B4 File Offset: 0x000B39B4
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__0(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunBanLogoutFlow._execute_d__0>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunBanLogoutFlow._execute_d__0.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002F39 RID: 12089 RVA: 0x000B57FC File Offset: 0x000B39FC
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunBanLogoutFlow._execute_d__0.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002F3A RID: 12090 RVA: 0x000B5830 File Offset: 0x000B3A30
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 527498, XrefRangeEnd = 527523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunBanLogoutFlow._execute_d__0.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000D88 RID: 3464
			// (get) Token: 0x06002F3B RID: 12091 RVA: 0x000B586C File Offset: 0x000B3A6C
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunBanLogoutFlow._execute_d__0.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002F3C RID: 12092 RVA: 0x000B58AC File Offset: 0x000B3AAC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 527523, XrefRangeEnd = 527528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunBanLogoutFlow._execute_d__0.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000D89 RID: 3465
			// (get) Token: 0x06002F3D RID: 12093 RVA: 0x000B58E0 File Offset: 0x000B3AE0
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunBanLogoutFlow._execute_d__0.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002F3E RID: 12094 RVA: 0x00018666 File Offset: 0x00016866
			public _execute_d__0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000D85 RID: 3461
			// (get) Token: 0x06002F3F RID: 12095 RVA: 0x000B5920 File Offset: 0x000B3B20
			// (set) Token: 0x06002F40 RID: 12096 RVA: 0x0001866F File Offset: 0x0001686F
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunBanLogoutFlow._execute_d__0.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunBanLogoutFlow._execute_d__0.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000D86 RID: 3462
			// (get) Token: 0x06002F41 RID: 12097 RVA: 0x000B5948 File Offset: 0x000B3B48
			// (set) Token: 0x06002F42 RID: 12098 RVA: 0x0001868A File Offset: 0x0001688A
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunBanLogoutFlow._execute_d__0.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunBanLogoutFlow._execute_d__0.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D87 RID: 3463
			// (get) Token: 0x06002F43 RID: 12099 RVA: 0x000B5978 File Offset: 0x000B3B78
			// (set) Token: 0x06002F44 RID: 12100 RVA: 0x000186A9 File Offset: 0x000168A9
			public unsafe string _kickToLandingMessage_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunBanLogoutFlow._execute_d__0.NativeFieldInfoPtr__kickToLandingMessage_5__2);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunBanLogoutFlow._execute_d__0.NativeFieldInfoPtr__kickToLandingMessage_5__2), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04001D36 RID: 7478
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001D37 RID: 7479
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001D38 RID: 7480
			private static readonly IntPtr NativeFieldInfoPtr__kickToLandingMessage_5__2;

			// Token: 0x04001D39 RID: 7481
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001D3A RID: 7482
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001D3B RID: 7483
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001D3C RID: 7484
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001D3D RID: 7485
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001D3E RID: 7486
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
