using System;
using Canis;
using Canis.utils.ids;
using dwd.core;
using dwd.core.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using lotus;

namespace boardgames.menus.commands
{
	// Token: 0x02000211 RID: 529
	public class StartMatchFailed : Command
	{
		// Token: 0x0600184E RID: 6222 RVA: 0x0006C7B0 File Offset: 0x0006A9B0
		// Note: this type is marked as 'beforefieldinit'.
		static StartMatchFailed()
		{
			Il2CppClassPointerStore<StartMatchFailed>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.menus.commands", "StartMatchFailed");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StartMatchFailed>.NativeClassPtr);
			StartMatchFailed.NativeFieldInfoPtr_gameID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartMatchFailed>.NativeClassPtr, "gameID");
			StartMatchFailed.NativeFieldInfoPtr_errorMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartMatchFailed>.NativeClassPtr, "errorMessage");
			StartMatchFailed.NativeMethodInfoPtr__ctor_Public_Void_GameID_ErrorInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartMatchFailed>.NativeClassPtr, 100666884);
			StartMatchFailed.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartMatchFailed>.NativeClassPtr, 100666885);
		}

		// Token: 0x0600184F RID: 6223 RVA: 0x0006C830 File Offset: 0x0006AA30
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 526666, RefRangeEnd = 526667, XrefRangeStart = 526663, XrefRangeEnd = 526666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StartMatchFailed(GameID failedMatchID, ErrorInfo failureReason)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StartMatchFailed>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(failedMatchID);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(failureReason));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartMatchFailed.NativeMethodInfoPtr__ctor_Public_Void_GameID_ErrorInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001850 RID: 6224 RVA: 0x0006C894 File Offset: 0x0006AA94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 526667, XrefRangeEnd = 526672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StartMatchFailed.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001851 RID: 6225 RVA: 0x0000D762 File Offset: 0x0000B962
		public StartMatchFailed(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700068A RID: 1674
		// (get) Token: 0x06001852 RID: 6226 RVA: 0x0006C8E0 File Offset: 0x0006AAE0
		// (set) Token: 0x06001853 RID: 6227 RVA: 0x0000D76B File Offset: 0x0000B96B
		public unsafe GameID gameID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartMatchFailed.NativeFieldInfoPtr_gameID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartMatchFailed.NativeFieldInfoPtr_gameID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700068B RID: 1675
		// (get) Token: 0x06001854 RID: 6228 RVA: 0x0006C910 File Offset: 0x0006AB10
		// (set) Token: 0x06001855 RID: 6229 RVA: 0x0000D78A File Offset: 0x0000B98A
		public ErrorInfo errorMessage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartMatchFailed.NativeFieldInfoPtr_errorMessage);
				return new ErrorInfo(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ErrorInfo>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartMatchFailed.NativeFieldInfoPtr_errorMessage), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ErrorInfo>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x04000F38 RID: 3896
		private static readonly IntPtr NativeFieldInfoPtr_gameID;

		// Token: 0x04000F39 RID: 3897
		private static readonly IntPtr NativeFieldInfoPtr_errorMessage;

		// Token: 0x04000F3A RID: 3898
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_GameID_ErrorInfo_0;

		// Token: 0x04000F3B RID: 3899
		private static readonly IntPtr NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0;

		// Token: 0x020003E4 RID: 996
		[ObfuscatedName("boardgames.menus.commands.StartMatchFailed+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06002E62 RID: 11874 RVA: 0x000B3040 File Offset: 0x000B1240
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<StartMatchFailed.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StartMatchFailed>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StartMatchFailed.__c>.NativeClassPtr);
				StartMatchFailed.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartMatchFailed.__c>.NativeClassPtr, "<>9");
				StartMatchFailed.__c.NativeFieldInfoPtr___9__3_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartMatchFailed.__c>.NativeClassPtr, "<>9__3_0");
				StartMatchFailed.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartMatchFailed.__c>.NativeClassPtr, 100666887);
				StartMatchFailed.__c.NativeMethodInfoPtr__execute_b__3_0_Internal_IEnumerator_ChangeScene_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartMatchFailed.__c>.NativeClassPtr, 100666888);
			}

			// Token: 0x06002E63 RID: 11875 RVA: 0x000B30BC File Offset: 0x000B12BC
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StartMatchFailed.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartMatchFailed.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002E64 RID: 11876 RVA: 0x000B30F8 File Offset: 0x000B12F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 526641, XrefRangeEnd = 526645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator _execute_b__3_0(ChangeScene _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartMatchFailed.__c.NativeMethodInfoPtr__execute_b__3_0_Internal_IEnumerator_ChangeScene_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
				}
			}

			// Token: 0x06002E65 RID: 11877 RVA: 0x00017F57 File Offset: 0x00016157
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000D37 RID: 3383
			// (get) Token: 0x06002E66 RID: 11878 RVA: 0x000B3148 File Offset: 0x000B1348
			// (set) Token: 0x06002E67 RID: 11879 RVA: 0x00017F60 File Offset: 0x00016160
			public unsafe static StartMatchFailed.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(StartMatchFailed.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<StartMatchFailed.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(StartMatchFailed.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D38 RID: 3384
			// (get) Token: 0x06002E68 RID: 11880 RVA: 0x000B3170 File Offset: 0x000B1370
			// (set) Token: 0x06002E69 RID: 11881 RVA: 0x00017F72 File Offset: 0x00016172
			public unsafe static Func<ChangeScene, IEnumerator> __9__3_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(StartMatchFailed.__c.NativeFieldInfoPtr___9__3_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ChangeScene, IEnumerator>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(StartMatchFailed.__c.NativeFieldInfoPtr___9__3_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001CB9 RID: 7353
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04001CBA RID: 7354
			private static readonly IntPtr NativeFieldInfoPtr___9__3_0;

			// Token: 0x04001CBB RID: 7355
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001CBC RID: 7356
			private static readonly IntPtr NativeMethodInfoPtr__execute_b__3_0_Internal_IEnumerator_ChangeScene_0;
		}

		// Token: 0x020003E5 RID: 997
		[ObfuscatedName("boardgames.menus.commands.StartMatchFailed+<execute>d__3")]
		public sealed class _execute_d__3 : Object
		{
			// Token: 0x06002E6A RID: 11882 RVA: 0x000B3198 File Offset: 0x000B1398
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__3()
			{
				Il2CppClassPointerStore<StartMatchFailed._execute_d__3>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StartMatchFailed>.NativeClassPtr, "<execute>d__3");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StartMatchFailed._execute_d__3>.NativeClassPtr);
				StartMatchFailed._execute_d__3.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartMatchFailed._execute_d__3>.NativeClassPtr, "<>1__state");
				StartMatchFailed._execute_d__3.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartMatchFailed._execute_d__3>.NativeClassPtr, "<>2__current");
				StartMatchFailed._execute_d__3.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartMatchFailed._execute_d__3>.NativeClassPtr, "<>4__this");
				StartMatchFailed._execute_d__3.NativeFieldInfoPtr__saveProvider_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartMatchFailed._execute_d__3>.NativeClassPtr, "<saveProvider>5__2");
				StartMatchFailed._execute_d__3.NativeFieldInfoPtr__metaData_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartMatchFailed._execute_d__3>.NativeClassPtr, "<metaData>5__3");
				StartMatchFailed._execute_d__3.NativeFieldInfoPtr__loadGameCommand_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartMatchFailed._execute_d__3>.NativeClassPtr, "<loadGameCommand>5__4");
				StartMatchFailed._execute_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartMatchFailed._execute_d__3>.NativeClassPtr, 100666889);
				StartMatchFailed._execute_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartMatchFailed._execute_d__3>.NativeClassPtr, 100666890);
				StartMatchFailed._execute_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartMatchFailed._execute_d__3>.NativeClassPtr, 100666891);
				StartMatchFailed._execute_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartMatchFailed._execute_d__3>.NativeClassPtr, 100666892);
				StartMatchFailed._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartMatchFailed._execute_d__3>.NativeClassPtr, 100666893);
				StartMatchFailed._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartMatchFailed._execute_d__3>.NativeClassPtr, 100666894);
			}

			// Token: 0x06002E6B RID: 11883 RVA: 0x000B32B4 File Offset: 0x000B14B4
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__3(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StartMatchFailed._execute_d__3>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartMatchFailed._execute_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002E6C RID: 11884 RVA: 0x000B32FC File Offset: 0x000B14FC
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartMatchFailed._execute_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002E6D RID: 11885 RVA: 0x000B3330 File Offset: 0x000B1530
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 526645, XrefRangeEnd = 526658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartMatchFailed._execute_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000D3F RID: 3391
			// (get) Token: 0x06002E6E RID: 11886 RVA: 0x000B336C File Offset: 0x000B156C
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartMatchFailed._execute_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002E6F RID: 11887 RVA: 0x000B33AC File Offset: 0x000B15AC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 526658, XrefRangeEnd = 526663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartMatchFailed._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000D40 RID: 3392
			// (get) Token: 0x06002E70 RID: 11888 RVA: 0x000B33E0 File Offset: 0x000B15E0
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartMatchFailed._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002E71 RID: 11889 RVA: 0x00017F84 File Offset: 0x00016184
			public _execute_d__3(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000D39 RID: 3385
			// (get) Token: 0x06002E72 RID: 11890 RVA: 0x000B3420 File Offset: 0x000B1620
			// (set) Token: 0x06002E73 RID: 11891 RVA: 0x00017F8D File Offset: 0x0001618D
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartMatchFailed._execute_d__3.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartMatchFailed._execute_d__3.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000D3A RID: 3386
			// (get) Token: 0x06002E74 RID: 11892 RVA: 0x000B3448 File Offset: 0x000B1648
			// (set) Token: 0x06002E75 RID: 11893 RVA: 0x00017FA8 File Offset: 0x000161A8
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartMatchFailed._execute_d__3.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartMatchFailed._execute_d__3.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D3B RID: 3387
			// (get) Token: 0x06002E76 RID: 11894 RVA: 0x000B3478 File Offset: 0x000B1678
			// (set) Token: 0x06002E77 RID: 11895 RVA: 0x00017FC7 File Offset: 0x000161C7
			public unsafe StartMatchFailed __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartMatchFailed._execute_d__3.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<StartMatchFailed>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartMatchFailed._execute_d__3.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D3C RID: 3388
			// (get) Token: 0x06002E78 RID: 11896 RVA: 0x000B34A8 File Offset: 0x000B16A8
			// (set) Token: 0x06002E79 RID: 11897 RVA: 0x00017FE6 File Offset: 0x000161E6
			public unsafe SaveMetaDataProvider _saveProvider_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartMatchFailed._execute_d__3.NativeFieldInfoPtr__saveProvider_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SaveMetaDataProvider>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartMatchFailed._execute_d__3.NativeFieldInfoPtr__saveProvider_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D3D RID: 3389
			// (get) Token: 0x06002E7A RID: 11898 RVA: 0x000B34D8 File Offset: 0x000B16D8
			// (set) Token: 0x06002E7B RID: 11899 RVA: 0x00018005 File Offset: 0x00016205
			public unsafe SaveMetaData _metaData_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartMatchFailed._execute_d__3.NativeFieldInfoPtr__metaData_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SaveMetaData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartMatchFailed._execute_d__3.NativeFieldInfoPtr__metaData_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D3E RID: 3390
			// (get) Token: 0x06002E7C RID: 11900 RVA: 0x000B3508 File Offset: 0x000B1708
			// (set) Token: 0x06002E7D RID: 11901 RVA: 0x00018024 File Offset: 0x00016224
			public unsafe SaveMetaDataProvider.LoadReference _loadGameCommand_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartMatchFailed._execute_d__3.NativeFieldInfoPtr__loadGameCommand_5__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SaveMetaDataProvider.LoadReference>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartMatchFailed._execute_d__3.NativeFieldInfoPtr__loadGameCommand_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001CBD RID: 7357
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001CBE RID: 7358
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001CBF RID: 7359
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001CC0 RID: 7360
			private static readonly IntPtr NativeFieldInfoPtr__saveProvider_5__2;

			// Token: 0x04001CC1 RID: 7361
			private static readonly IntPtr NativeFieldInfoPtr__metaData_5__3;

			// Token: 0x04001CC2 RID: 7362
			private static readonly IntPtr NativeFieldInfoPtr__loadGameCommand_5__4;

			// Token: 0x04001CC3 RID: 7363
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001CC4 RID: 7364
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001CC5 RID: 7365
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001CC6 RID: 7366
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001CC7 RID: 7367
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001CC8 RID: 7368
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
