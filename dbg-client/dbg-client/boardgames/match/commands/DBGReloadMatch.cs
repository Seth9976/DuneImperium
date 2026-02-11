using System;
using Canis.utils.ids;
using dwd.core.commands;
using dwd.core.ui.prompt.commands;
using dwd.core.ui.prompt.prompts;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;

namespace boardgames.match.commands
{
	// Token: 0x02000298 RID: 664
	public class DBGReloadMatch : FailableCommand
	{
		// Token: 0x06001F2A RID: 7978 RVA: 0x00085830 File Offset: 0x00083A30
		// Note: this type is marked as 'beforefieldinit'.
		static DBGReloadMatch()
		{
			Il2CppClassPointerStore<DBGReloadMatch>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.match.commands", "DBGReloadMatch");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DBGReloadMatch>.NativeClassPtr);
			DBGReloadMatch.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGReloadMatch>.NativeClassPtr, 100668514);
			DBGReloadMatch.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGReloadMatch>.NativeClassPtr, 100668515);
		}

		// Token: 0x06001F2B RID: 7979 RVA: 0x00085888 File Offset: 0x00083A88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 540988, XrefRangeEnd = 540993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DBGReloadMatch.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001F2C RID: 7980 RVA: 0x000858D4 File Offset: 0x00083AD4
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 498677, RefRangeEnd = 498693, XrefRangeStart = 498677, XrefRangeEnd = 498693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DBGReloadMatch()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DBGReloadMatch>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGReloadMatch.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F2D RID: 7981 RVA: 0x00010623 File Offset: 0x0000E823
		public DBGReloadMatch(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040013AE RID: 5038
		private static readonly IntPtr NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0;

		// Token: 0x040013AF RID: 5039
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000497 RID: 1175
		[ObfuscatedName("boardgames.match.commands.DBGReloadMatch+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x060037BC RID: 14268 RVA: 0x000CF0A0 File Offset: 0x000CD2A0
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<DBGReloadMatch.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DBGReloadMatch>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DBGReloadMatch.__c>.NativeClassPtr);
				DBGReloadMatch.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGReloadMatch.__c>.NativeClassPtr, "<>9");
				DBGReloadMatch.__c.NativeFieldInfoPtr___9__0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGReloadMatch.__c>.NativeClassPtr, "<>9__0_0");
				DBGReloadMatch.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGReloadMatch.__c>.NativeClassPtr, 100668517);
				DBGReloadMatch.__c.NativeMethodInfoPtr__execute_b__0_0_Internal_IEnumerator_ChangeScene_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGReloadMatch.__c>.NativeClassPtr, 100668518);
			}

			// Token: 0x060037BD RID: 14269 RVA: 0x000CF11C File Offset: 0x000CD31C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DBGReloadMatch.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGReloadMatch.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060037BE RID: 14270 RVA: 0x000CF158 File Offset: 0x000CD358
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 540867, XrefRangeEnd = 540871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator _execute_b__0_0(ChangeScene _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGReloadMatch.__c.NativeMethodInfoPtr__execute_b__0_0_Internal_IEnumerator_ChangeScene_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
				}
			}

			// Token: 0x060037BF RID: 14271 RVA: 0x0001CA6F File Offset: 0x0001AC6F
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001072 RID: 4210
			// (get) Token: 0x060037C0 RID: 14272 RVA: 0x000CF1A8 File Offset: 0x000CD3A8
			// (set) Token: 0x060037C1 RID: 14273 RVA: 0x0001CA78 File Offset: 0x0001AC78
			public unsafe static DBGReloadMatch.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DBGReloadMatch.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGReloadMatch.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DBGReloadMatch.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001073 RID: 4211
			// (get) Token: 0x060037C2 RID: 14274 RVA: 0x000CF1D0 File Offset: 0x000CD3D0
			// (set) Token: 0x060037C3 RID: 14275 RVA: 0x0001CA8A File Offset: 0x0001AC8A
			public unsafe static Func<ChangeScene, IEnumerator> __9__0_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DBGReloadMatch.__c.NativeFieldInfoPtr___9__0_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ChangeScene, IEnumerator>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DBGReloadMatch.__c.NativeFieldInfoPtr___9__0_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002249 RID: 8777
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400224A RID: 8778
			private static readonly IntPtr NativeFieldInfoPtr___9__0_0;

			// Token: 0x0400224B RID: 8779
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400224C RID: 8780
			private static readonly IntPtr NativeMethodInfoPtr__execute_b__0_0_Internal_IEnumerator_ChangeScene_0;
		}

		// Token: 0x02000498 RID: 1176
		[ObfuscatedName("boardgames.match.commands.DBGReloadMatch+<execute>d__0")]
		public sealed class _execute_d__0 : Object
		{
			// Token: 0x060037C4 RID: 14276 RVA: 0x000CF1F8 File Offset: 0x000CD3F8
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__0()
			{
				Il2CppClassPointerStore<DBGReloadMatch._execute_d__0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DBGReloadMatch>.NativeClassPtr, "<execute>d__0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DBGReloadMatch._execute_d__0>.NativeClassPtr);
				DBGReloadMatch._execute_d__0.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGReloadMatch._execute_d__0>.NativeClassPtr, "<>1__state");
				DBGReloadMatch._execute_d__0.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGReloadMatch._execute_d__0>.NativeClassPtr, "<>2__current");
				DBGReloadMatch._execute_d__0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGReloadMatch._execute_d__0>.NativeClassPtr, "<>4__this");
				DBGReloadMatch._execute_d__0.NativeFieldInfoPtr__gameID_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGReloadMatch._execute_d__0>.NativeClassPtr, "<gameID>5__2");
				DBGReloadMatch._execute_d__0.NativeFieldInfoPtr__spinner_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGReloadMatch._execute_d__0>.NativeClassPtr, "<spinner>5__3");
				DBGReloadMatch._execute_d__0.NativeFieldInfoPtr__showSpinner_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGReloadMatch._execute_d__0>.NativeClassPtr, "<showSpinner>5__4");
				DBGReloadMatch._execute_d__0.NativeFieldInfoPtr__playCommand_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGReloadMatch._execute_d__0>.NativeClassPtr, "<playCommand>5__5");
				DBGReloadMatch._execute_d__0.NativeFieldInfoPtr__errorCode_5__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGReloadMatch._execute_d__0>.NativeClassPtr, "<errorCode>5__6");
				DBGReloadMatch._execute_d__0.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGReloadMatch._execute_d__0>.NativeClassPtr, 100668519);
				DBGReloadMatch._execute_d__0.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGReloadMatch._execute_d__0>.NativeClassPtr, 100668520);
				DBGReloadMatch._execute_d__0.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGReloadMatch._execute_d__0>.NativeClassPtr, 100668521);
				DBGReloadMatch._execute_d__0.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGReloadMatch._execute_d__0>.NativeClassPtr, 100668522);
				DBGReloadMatch._execute_d__0.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGReloadMatch._execute_d__0>.NativeClassPtr, 100668523);
				DBGReloadMatch._execute_d__0.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGReloadMatch._execute_d__0>.NativeClassPtr, 100668524);
			}

			// Token: 0x060037C5 RID: 14277 RVA: 0x000CF33C File Offset: 0x000CD53C
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__0(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DBGReloadMatch._execute_d__0>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGReloadMatch._execute_d__0.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060037C6 RID: 14278 RVA: 0x000CF384 File Offset: 0x000CD584
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGReloadMatch._execute_d__0.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060037C7 RID: 14279 RVA: 0x000CF3B8 File Offset: 0x000CD5B8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 540871, XrefRangeEnd = 540983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGReloadMatch._execute_d__0.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700107C RID: 4220
			// (get) Token: 0x060037C8 RID: 14280 RVA: 0x000CF3F4 File Offset: 0x000CD5F4
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGReloadMatch._execute_d__0.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060037C9 RID: 14281 RVA: 0x000CF434 File Offset: 0x000CD634
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 540983, XrefRangeEnd = 540988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGReloadMatch._execute_d__0.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700107D RID: 4221
			// (get) Token: 0x060037CA RID: 14282 RVA: 0x000CF468 File Offset: 0x000CD668
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGReloadMatch._execute_d__0.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060037CB RID: 14283 RVA: 0x0001CA9C File Offset: 0x0001AC9C
			public _execute_d__0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001074 RID: 4212
			// (get) Token: 0x060037CC RID: 14284 RVA: 0x000CF4A8 File Offset: 0x000CD6A8
			// (set) Token: 0x060037CD RID: 14285 RVA: 0x0001CAA5 File Offset: 0x0001ACA5
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGReloadMatch._execute_d__0.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGReloadMatch._execute_d__0.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001075 RID: 4213
			// (get) Token: 0x060037CE RID: 14286 RVA: 0x000CF4D0 File Offset: 0x000CD6D0
			// (set) Token: 0x060037CF RID: 14287 RVA: 0x0001CAC0 File Offset: 0x0001ACC0
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGReloadMatch._execute_d__0.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGReloadMatch._execute_d__0.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001076 RID: 4214
			// (get) Token: 0x060037D0 RID: 14288 RVA: 0x000CF500 File Offset: 0x000CD700
			// (set) Token: 0x060037D1 RID: 14289 RVA: 0x0001CADF File Offset: 0x0001ACDF
			public unsafe DBGReloadMatch __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGReloadMatch._execute_d__0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGReloadMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGReloadMatch._execute_d__0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001077 RID: 4215
			// (get) Token: 0x060037D2 RID: 14290 RVA: 0x000CF530 File Offset: 0x000CD730
			// (set) Token: 0x060037D3 RID: 14291 RVA: 0x0001CAFE File Offset: 0x0001ACFE
			public unsafe GameID _gameID_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGReloadMatch._execute_d__0.NativeFieldInfoPtr__gameID_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameID>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGReloadMatch._execute_d__0.NativeFieldInfoPtr__gameID_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001078 RID: 4216
			// (get) Token: 0x060037D4 RID: 14292 RVA: 0x000CF560 File Offset: 0x000CD760
			// (set) Token: 0x060037D5 RID: 14293 RVA: 0x0001CB1D File Offset: 0x0001AD1D
			public unsafe FlavoredSpinner _spinner_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGReloadMatch._execute_d__0.NativeFieldInfoPtr__spinner_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FlavoredSpinner>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGReloadMatch._execute_d__0.NativeFieldInfoPtr__spinner_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001079 RID: 4217
			// (get) Token: 0x060037D6 RID: 14294 RVA: 0x000CF590 File Offset: 0x000CD790
			// (set) Token: 0x060037D7 RID: 14295 RVA: 0x0001CB3C File Offset: 0x0001AD3C
			public unsafe DisplayGenericPrompt _showSpinner_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGReloadMatch._execute_d__0.NativeFieldInfoPtr__showSpinner_5__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DisplayGenericPrompt>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGReloadMatch._execute_d__0.NativeFieldInfoPtr__showSpinner_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700107A RID: 4218
			// (get) Token: 0x060037D8 RID: 14296 RVA: 0x000CF5C0 File Offset: 0x000CD7C0
			// (set) Token: 0x060037D9 RID: 14297 RVA: 0x0001CB5B File Offset: 0x0001AD5B
			public unsafe DBGPlayTurnCommand _playCommand_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGReloadMatch._execute_d__0.NativeFieldInfoPtr__playCommand_5__5);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGPlayTurnCommand>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGReloadMatch._execute_d__0.NativeFieldInfoPtr__playCommand_5__5), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700107B RID: 4219
			// (get) Token: 0x060037DA RID: 14298 RVA: 0x000CF5F0 File Offset: 0x000CD7F0
			// (set) Token: 0x060037DB RID: 14299 RVA: 0x0001CB7A File Offset: 0x0001AD7A
			public unsafe int _errorCode_5__6
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGReloadMatch._execute_d__0.NativeFieldInfoPtr__errorCode_5__6);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGReloadMatch._execute_d__0.NativeFieldInfoPtr__errorCode_5__6)) = value;
				}
			}

			// Token: 0x0400224D RID: 8781
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400224E RID: 8782
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400224F RID: 8783
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04002250 RID: 8784
			private static readonly IntPtr NativeFieldInfoPtr__gameID_5__2;

			// Token: 0x04002251 RID: 8785
			private static readonly IntPtr NativeFieldInfoPtr__spinner_5__3;

			// Token: 0x04002252 RID: 8786
			private static readonly IntPtr NativeFieldInfoPtr__showSpinner_5__4;

			// Token: 0x04002253 RID: 8787
			private static readonly IntPtr NativeFieldInfoPtr__playCommand_5__5;

			// Token: 0x04002254 RID: 8788
			private static readonly IntPtr NativeFieldInfoPtr__errorCode_5__6;

			// Token: 0x04002255 RID: 8789
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04002256 RID: 8790
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002257 RID: 8791
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04002258 RID: 8792
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04002259 RID: 8793
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400225A RID: 8794
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
