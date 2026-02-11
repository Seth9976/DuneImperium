using System;
using Canis;
using dwd.core.commands;
using dwd.core.ui.prompt.prompts;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using lotus;

namespace boardgames.menus.commands
{
	// Token: 0x02000212 RID: 530
	public class ContinueTutorialPracticeGameFlow : Command
	{
		// Token: 0x06001856 RID: 6230 RVA: 0x0006C940 File Offset: 0x0006AB40
		// Note: this type is marked as 'beforefieldinit'.
		static ContinueTutorialPracticeGameFlow()
		{
			Il2CppClassPointerStore<ContinueTutorialPracticeGameFlow>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.menus.commands", "ContinueTutorialPracticeGameFlow");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ContinueTutorialPracticeGameFlow>.NativeClassPtr);
			ContinueTutorialPracticeGameFlow.NativeFieldInfoPtr_savegameLocString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContinueTutorialPracticeGameFlow>.NativeClassPtr, "savegameLocString");
			ContinueTutorialPracticeGameFlow.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContinueTutorialPracticeGameFlow>.NativeClassPtr, 100666895);
			ContinueTutorialPracticeGameFlow.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContinueTutorialPracticeGameFlow>.NativeClassPtr, 100666896);
		}

		// Token: 0x06001857 RID: 6231 RVA: 0x0006C9AC File Offset: 0x0006ABAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 526688, XrefRangeEnd = 526692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ContinueTutorialPracticeGameFlow.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001858 RID: 6232 RVA: 0x0006C9F8 File Offset: 0x0006ABF8
		[CallerCount(55)]
		[CachedScanResults(RefRangeStart = 498694, RefRangeEnd = 498749, XrefRangeStart = 498694, XrefRangeEnd = 498749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ContinueTutorialPracticeGameFlow()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ContinueTutorialPracticeGameFlow>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContinueTutorialPracticeGameFlow.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001859 RID: 6233 RVA: 0x0000D7B8 File Offset: 0x0000B9B8
		public ContinueTutorialPracticeGameFlow(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700068C RID: 1676
		// (get) Token: 0x0600185A RID: 6234 RVA: 0x0006CA34 File Offset: 0x0006AC34
		// (set) Token: 0x0600185B RID: 6235 RVA: 0x0000D7C1 File Offset: 0x0000B9C1
		public unsafe static string savegameLocString
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ContinueTutorialPracticeGameFlow.NativeFieldInfoPtr_savegameLocString, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ContinueTutorialPracticeGameFlow.NativeFieldInfoPtr_savegameLocString, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000F3C RID: 3900
		private static readonly IntPtr NativeFieldInfoPtr_savegameLocString;

		// Token: 0x04000F3D RID: 3901
		private static readonly IntPtr NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0;

		// Token: 0x04000F3E RID: 3902
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020003E6 RID: 998
		[ObfuscatedName("boardgames.menus.commands.ContinueTutorialPracticeGameFlow+<execute>d__1")]
		public sealed class _execute_d__1 : Object
		{
			// Token: 0x06002E7E RID: 11902 RVA: 0x000B3538 File Offset: 0x000B1738
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__1()
			{
				Il2CppClassPointerStore<ContinueTutorialPracticeGameFlow._execute_d__1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ContinueTutorialPracticeGameFlow>.NativeClassPtr, "<execute>d__1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ContinueTutorialPracticeGameFlow._execute_d__1>.NativeClassPtr);
				ContinueTutorialPracticeGameFlow._execute_d__1.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContinueTutorialPracticeGameFlow._execute_d__1>.NativeClassPtr, "<>1__state");
				ContinueTutorialPracticeGameFlow._execute_d__1.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContinueTutorialPracticeGameFlow._execute_d__1>.NativeClassPtr, "<>2__current");
				ContinueTutorialPracticeGameFlow._execute_d__1.NativeFieldInfoPtr__continuePracticeGamePrompt_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContinueTutorialPracticeGameFlow._execute_d__1>.NativeClassPtr, "<continuePracticeGamePrompt>5__2");
				ContinueTutorialPracticeGameFlow._execute_d__1.NativeFieldInfoPtr__saveProvider_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContinueTutorialPracticeGameFlow._execute_d__1>.NativeClassPtr, "<saveProvider>5__3");
				ContinueTutorialPracticeGameFlow._execute_d__1.NativeFieldInfoPtr__practiceGameSaveMetaData_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContinueTutorialPracticeGameFlow._execute_d__1>.NativeClassPtr, "<practiceGameSaveMetaData>5__4");
				ContinueTutorialPracticeGameFlow._execute_d__1.NativeFieldInfoPtr__loadPracticeGameCommand_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContinueTutorialPracticeGameFlow._execute_d__1>.NativeClassPtr, "<loadPracticeGameCommand>5__5");
				ContinueTutorialPracticeGameFlow._execute_d__1.NativeFieldInfoPtr__practiceGameSaveData_5__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContinueTutorialPracticeGameFlow._execute_d__1>.NativeClassPtr, "<practiceGameSaveData>5__6");
				ContinueTutorialPracticeGameFlow._execute_d__1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContinueTutorialPracticeGameFlow._execute_d__1>.NativeClassPtr, 100666897);
				ContinueTutorialPracticeGameFlow._execute_d__1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContinueTutorialPracticeGameFlow._execute_d__1>.NativeClassPtr, 100666898);
				ContinueTutorialPracticeGameFlow._execute_d__1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContinueTutorialPracticeGameFlow._execute_d__1>.NativeClassPtr, 100666899);
				ContinueTutorialPracticeGameFlow._execute_d__1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContinueTutorialPracticeGameFlow._execute_d__1>.NativeClassPtr, 100666900);
				ContinueTutorialPracticeGameFlow._execute_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContinueTutorialPracticeGameFlow._execute_d__1>.NativeClassPtr, 100666901);
				ContinueTutorialPracticeGameFlow._execute_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContinueTutorialPracticeGameFlow._execute_d__1>.NativeClassPtr, 100666902);
			}

			// Token: 0x06002E7F RID: 11903 RVA: 0x000B3668 File Offset: 0x000B1868
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__1(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ContinueTutorialPracticeGameFlow._execute_d__1>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContinueTutorialPracticeGameFlow._execute_d__1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002E80 RID: 11904 RVA: 0x000B36B0 File Offset: 0x000B18B0
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContinueTutorialPracticeGameFlow._execute_d__1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002E81 RID: 11905 RVA: 0x000B36E4 File Offset: 0x000B18E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 526672, XrefRangeEnd = 526683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContinueTutorialPracticeGameFlow._execute_d__1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000D48 RID: 3400
			// (get) Token: 0x06002E82 RID: 11906 RVA: 0x000B3720 File Offset: 0x000B1920
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContinueTutorialPracticeGameFlow._execute_d__1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002E83 RID: 11907 RVA: 0x000B3760 File Offset: 0x000B1960
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 526683, XrefRangeEnd = 526688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContinueTutorialPracticeGameFlow._execute_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000D49 RID: 3401
			// (get) Token: 0x06002E84 RID: 11908 RVA: 0x000B3794 File Offset: 0x000B1994
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContinueTutorialPracticeGameFlow._execute_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002E85 RID: 11909 RVA: 0x00018043 File Offset: 0x00016243
			public _execute_d__1(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000D41 RID: 3393
			// (get) Token: 0x06002E86 RID: 11910 RVA: 0x000B37D4 File Offset: 0x000B19D4
			// (set) Token: 0x06002E87 RID: 11911 RVA: 0x0001804C File Offset: 0x0001624C
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContinueTutorialPracticeGameFlow._execute_d__1.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContinueTutorialPracticeGameFlow._execute_d__1.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000D42 RID: 3394
			// (get) Token: 0x06002E88 RID: 11912 RVA: 0x000B37FC File Offset: 0x000B19FC
			// (set) Token: 0x06002E89 RID: 11913 RVA: 0x00018067 File Offset: 0x00016267
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContinueTutorialPracticeGameFlow._execute_d__1.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContinueTutorialPracticeGameFlow._execute_d__1.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D43 RID: 3395
			// (get) Token: 0x06002E8A RID: 11914 RVA: 0x000B382C File Offset: 0x000B1A2C
			// (set) Token: 0x06002E8B RID: 11915 RVA: 0x00018086 File Offset: 0x00016286
			public unsafe ConfirmOrDenyPrompt _continuePracticeGamePrompt_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContinueTutorialPracticeGameFlow._execute_d__1.NativeFieldInfoPtr__continuePracticeGamePrompt_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConfirmOrDenyPrompt>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContinueTutorialPracticeGameFlow._execute_d__1.NativeFieldInfoPtr__continuePracticeGamePrompt_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D44 RID: 3396
			// (get) Token: 0x06002E8C RID: 11916 RVA: 0x000B385C File Offset: 0x000B1A5C
			// (set) Token: 0x06002E8D RID: 11917 RVA: 0x000180A5 File Offset: 0x000162A5
			public unsafe SaveMetaDataProvider _saveProvider_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContinueTutorialPracticeGameFlow._execute_d__1.NativeFieldInfoPtr__saveProvider_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SaveMetaDataProvider>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContinueTutorialPracticeGameFlow._execute_d__1.NativeFieldInfoPtr__saveProvider_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D45 RID: 3397
			// (get) Token: 0x06002E8E RID: 11918 RVA: 0x000B388C File Offset: 0x000B1A8C
			// (set) Token: 0x06002E8F RID: 11919 RVA: 0x000180C4 File Offset: 0x000162C4
			public unsafe SaveMetaData _practiceGameSaveMetaData_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContinueTutorialPracticeGameFlow._execute_d__1.NativeFieldInfoPtr__practiceGameSaveMetaData_5__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SaveMetaData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContinueTutorialPracticeGameFlow._execute_d__1.NativeFieldInfoPtr__practiceGameSaveMetaData_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D46 RID: 3398
			// (get) Token: 0x06002E90 RID: 11920 RVA: 0x000B38BC File Offset: 0x000B1ABC
			// (set) Token: 0x06002E91 RID: 11921 RVA: 0x000180E3 File Offset: 0x000162E3
			public unsafe SaveMetaDataProvider.LoadReference _loadPracticeGameCommand_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContinueTutorialPracticeGameFlow._execute_d__1.NativeFieldInfoPtr__loadPracticeGameCommand_5__5);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SaveMetaDataProvider.LoadReference>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContinueTutorialPracticeGameFlow._execute_d__1.NativeFieldInfoPtr__loadPracticeGameCommand_5__5), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D47 RID: 3399
			// (get) Token: 0x06002E92 RID: 11922 RVA: 0x000B38EC File Offset: 0x000B1AEC
			// (set) Token: 0x06002E93 RID: 11923 RVA: 0x00018102 File Offset: 0x00016302
			public unsafe SaveData _practiceGameSaveData_5__6
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContinueTutorialPracticeGameFlow._execute_d__1.NativeFieldInfoPtr__practiceGameSaveData_5__6);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SaveData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContinueTutorialPracticeGameFlow._execute_d__1.NativeFieldInfoPtr__practiceGameSaveData_5__6), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001CC9 RID: 7369
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001CCA RID: 7370
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001CCB RID: 7371
			private static readonly IntPtr NativeFieldInfoPtr__continuePracticeGamePrompt_5__2;

			// Token: 0x04001CCC RID: 7372
			private static readonly IntPtr NativeFieldInfoPtr__saveProvider_5__3;

			// Token: 0x04001CCD RID: 7373
			private static readonly IntPtr NativeFieldInfoPtr__practiceGameSaveMetaData_5__4;

			// Token: 0x04001CCE RID: 7374
			private static readonly IntPtr NativeFieldInfoPtr__loadPracticeGameCommand_5__5;

			// Token: 0x04001CCF RID: 7375
			private static readonly IntPtr NativeFieldInfoPtr__practiceGameSaveData_5__6;

			// Token: 0x04001CD0 RID: 7376
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001CD1 RID: 7377
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001CD2 RID: 7378
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001CD3 RID: 7379
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001CD4 RID: 7380
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001CD5 RID: 7381
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
