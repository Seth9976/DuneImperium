using System;
using System.Runtime.InteropServices;
using boardgames.menus.prompts;
using Canis;
using dwd.core.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using lotus;

namespace boardgames.menus.commands
{
	// Token: 0x02000220 RID: 544
	public class RunCheckContinueOfflineMatchFlow : FailableCommand
	{
		// Token: 0x060018C4 RID: 6340 RVA: 0x0006DF38 File Offset: 0x0006C138
		// Note: this type is marked as 'beforefieldinit'.
		static RunCheckContinueOfflineMatchFlow()
		{
			Il2CppClassPointerStore<RunCheckContinueOfflineMatchFlow>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.menus.commands", "RunCheckContinueOfflineMatchFlow");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RunCheckContinueOfflineMatchFlow>.NativeClassPtr);
			RunCheckContinueOfflineMatchFlow.NativeFieldInfoPtr_matches = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunCheckContinueOfflineMatchFlow>.NativeClassPtr, "matches");
			RunCheckContinueOfflineMatchFlow.NativeFieldInfoPtr_promptFlavors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunCheckContinueOfflineMatchFlow>.NativeClassPtr, "promptFlavors");
			RunCheckContinueOfflineMatchFlow.NativeFieldInfoPtr__ContinueResult_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunCheckContinueOfflineMatchFlow>.NativeClassPtr, "<ContinueResult>k__BackingField");
			RunCheckContinueOfflineMatchFlow.NativeMethodInfoPtr_get_ContinueResult_Public_get_MatchInitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunCheckContinueOfflineMatchFlow>.NativeClassPtr, 100667044);
			RunCheckContinueOfflineMatchFlow.NativeMethodInfoPtr_set_ContinueResult_Private_set_Void_MatchInitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunCheckContinueOfflineMatchFlow>.NativeClassPtr, 100667045);
			RunCheckContinueOfflineMatchFlow.NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_MatchInitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunCheckContinueOfflineMatchFlow>.NativeClassPtr, 100667046);
			RunCheckContinueOfflineMatchFlow.NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_MatchInitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunCheckContinueOfflineMatchFlow>.NativeClassPtr, 100667047);
			RunCheckContinueOfflineMatchFlow.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunCheckContinueOfflineMatchFlow>.NativeClassPtr, 100667048);
			RunCheckContinueOfflineMatchFlow.NativeMethodInfoPtr_WithPromptFlavors_Public_RunCheckContinueOfflineMatchFlow_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunCheckContinueOfflineMatchFlow>.NativeClassPtr, 100667049);
		}

		// Token: 0x170006A5 RID: 1701
		// (get) Token: 0x060018C5 RID: 6341 RVA: 0x0006E01C File Offset: 0x0006C21C
		// (set) Token: 0x060018C6 RID: 6342 RVA: 0x0006E05C File Offset: 0x0006C25C
		public unsafe MatchInitData ContinueResult
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 329189, RefRangeEnd = 329190, XrefRangeStart = 329189, XrefRangeEnd = 329190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunCheckContinueOfflineMatchFlow.NativeMethodInfoPtr_get_ContinueResult_Public_get_MatchInitData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MatchInitData>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunCheckContinueOfflineMatchFlow.NativeMethodInfoPtr_set_ContinueResult_Private_set_Void_MatchInitData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060018C7 RID: 6343 RVA: 0x0006E0A0 File Offset: 0x0006C2A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 527945, XrefRangeEnd = 527954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RunCheckContinueOfflineMatchFlow([Optional] Il2CppReferenceArray<MatchInitData> matches)
		{
			if (matches == null)
			{
				matches = new Il2CppReferenceArray<MatchInitData>(0L);
			}
			this..ctor(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunCheckContinueOfflineMatchFlow>.NativeClassPtr));
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(matches);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunCheckContinueOfflineMatchFlow.NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_MatchInitData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060018C8 RID: 6344 RVA: 0x0006E0F8 File Offset: 0x0006C2F8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 527966, RefRangeEnd = 527967, XrefRangeStart = 527954, XrefRangeEnd = 527966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RunCheckContinueOfflineMatchFlow(IEnumerable<MatchInitData> matches)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunCheckContinueOfflineMatchFlow>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(matches);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunCheckContinueOfflineMatchFlow.NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_MatchInitData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060018C9 RID: 6345 RVA: 0x0006E144 File Offset: 0x0006C344
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 527967, XrefRangeEnd = 527972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RunCheckContinueOfflineMatchFlow.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060018CA RID: 6346 RVA: 0x0006E190 File Offset: 0x0006C390
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 527972, XrefRangeEnd = 527975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RunCheckContinueOfflineMatchFlow WithPromptFlavors([Optional] Il2CppStringArray flavors)
		{
			if (flavors == null)
			{
				flavors = new Il2CppStringArray(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(flavors);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunCheckContinueOfflineMatchFlow.NativeMethodInfoPtr_WithPromptFlavors_Public_RunCheckContinueOfflineMatchFlow_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RunCheckContinueOfflineMatchFlow>(intPtr3) : null;
			}
		}

		// Token: 0x060018CB RID: 6347 RVA: 0x0000DAE8 File Offset: 0x0000BCE8
		public RunCheckContinueOfflineMatchFlow(params MatchInitData[] matches)
			: this(new Il2CppReferenceArray<MatchInitData>(matches))
		{
		}

		// Token: 0x060018CC RID: 6348 RVA: 0x0000DAF6 File Offset: 0x0000BCF6
		public RunCheckContinueOfflineMatchFlow WithPromptFlavors(params string[] flavors)
		{
			return this.WithPromptFlavors(new Il2CppStringArray(flavors));
		}

		// Token: 0x060018CD RID: 6349 RVA: 0x0000DB04 File Offset: 0x0000BD04
		public RunCheckContinueOfflineMatchFlow(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006A2 RID: 1698
		// (get) Token: 0x060018CE RID: 6350 RVA: 0x0006E1F0 File Offset: 0x0006C3F0
		// (set) Token: 0x060018CF RID: 6351 RVA: 0x0000DB0D File Offset: 0x0000BD0D
		public unsafe IReadOnlyCollection<MatchInitData> matches
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunCheckContinueOfflineMatchFlow.NativeFieldInfoPtr_matches);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IReadOnlyCollection<MatchInitData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunCheckContinueOfflineMatchFlow.NativeFieldInfoPtr_matches), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006A3 RID: 1699
		// (get) Token: 0x060018D0 RID: 6352 RVA: 0x0006E220 File Offset: 0x0006C420
		// (set) Token: 0x060018D1 RID: 6353 RVA: 0x0000DB2C File Offset: 0x0000BD2C
		public unsafe List<string> promptFlavors
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunCheckContinueOfflineMatchFlow.NativeFieldInfoPtr_promptFlavors);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunCheckContinueOfflineMatchFlow.NativeFieldInfoPtr_promptFlavors), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006A4 RID: 1700
		// (get) Token: 0x060018D2 RID: 6354 RVA: 0x0006E250 File Offset: 0x0006C450
		// (set) Token: 0x060018D3 RID: 6355 RVA: 0x0000DB4B File Offset: 0x0000BD4B
		public unsafe MatchInitData _ContinueResult_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunCheckContinueOfflineMatchFlow.NativeFieldInfoPtr__ContinueResult_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MatchInitData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunCheckContinueOfflineMatchFlow.NativeFieldInfoPtr__ContinueResult_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000F78 RID: 3960
		private static readonly IntPtr NativeFieldInfoPtr_matches;

		// Token: 0x04000F79 RID: 3961
		private static readonly IntPtr NativeFieldInfoPtr_promptFlavors;

		// Token: 0x04000F7A RID: 3962
		private static readonly IntPtr NativeFieldInfoPtr__ContinueResult_k__BackingField;

		// Token: 0x04000F7B RID: 3963
		private static readonly IntPtr NativeMethodInfoPtr_get_ContinueResult_Public_get_MatchInitData_0;

		// Token: 0x04000F7C RID: 3964
		private static readonly IntPtr NativeMethodInfoPtr_set_ContinueResult_Private_set_Void_MatchInitData_0;

		// Token: 0x04000F7D RID: 3965
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_MatchInitData_0;

		// Token: 0x04000F7E RID: 3966
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_MatchInitData_0;

		// Token: 0x04000F7F RID: 3967
		private static readonly IntPtr NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0;

		// Token: 0x04000F80 RID: 3968
		private static readonly IntPtr NativeMethodInfoPtr_WithPromptFlavors_Public_RunCheckContinueOfflineMatchFlow_Il2CppStringArray_0;

		// Token: 0x020003FB RID: 1019
		[ObfuscatedName("boardgames.menus.commands.RunCheckContinueOfflineMatchFlow+<execute>d__8")]
		public sealed class _execute_d__8 : Object
		{
			// Token: 0x06002FB9 RID: 12217 RVA: 0x000B7004 File Offset: 0x000B5204
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__8()
			{
				Il2CppClassPointerStore<RunCheckContinueOfflineMatchFlow._execute_d__8>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RunCheckContinueOfflineMatchFlow>.NativeClassPtr, "<execute>d__8");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RunCheckContinueOfflineMatchFlow._execute_d__8>.NativeClassPtr);
				RunCheckContinueOfflineMatchFlow._execute_d__8.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunCheckContinueOfflineMatchFlow._execute_d__8>.NativeClassPtr, "<>1__state");
				RunCheckContinueOfflineMatchFlow._execute_d__8.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunCheckContinueOfflineMatchFlow._execute_d__8>.NativeClassPtr, "<>2__current");
				RunCheckContinueOfflineMatchFlow._execute_d__8.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunCheckContinueOfflineMatchFlow._execute_d__8>.NativeClassPtr, "<>4__this");
				RunCheckContinueOfflineMatchFlow._execute_d__8.NativeFieldInfoPtr__metaDataProvider_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunCheckContinueOfflineMatchFlow._execute_d__8>.NativeClassPtr, "<metaDataProvider>5__2");
				RunCheckContinueOfflineMatchFlow._execute_d__8.NativeFieldInfoPtr__offlineMatches_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunCheckContinueOfflineMatchFlow._execute_d__8>.NativeClassPtr, "<offlineMatches>5__3");
				RunCheckContinueOfflineMatchFlow._execute_d__8.NativeFieldInfoPtr___7__wrap3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunCheckContinueOfflineMatchFlow._execute_d__8>.NativeClassPtr, "<>7__wrap3");
				RunCheckContinueOfflineMatchFlow._execute_d__8.NativeFieldInfoPtr__metaData_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunCheckContinueOfflineMatchFlow._execute_d__8>.NativeClassPtr, "<metaData>5__5");
				RunCheckContinueOfflineMatchFlow._execute_d__8.NativeFieldInfoPtr__loadGameCommand_5__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunCheckContinueOfflineMatchFlow._execute_d__8>.NativeClassPtr, "<loadGameCommand>5__6");
				RunCheckContinueOfflineMatchFlow._execute_d__8.NativeFieldInfoPtr__saveGameData_5__7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunCheckContinueOfflineMatchFlow._execute_d__8>.NativeClassPtr, "<saveGameData>5__7");
				RunCheckContinueOfflineMatchFlow._execute_d__8.NativeFieldInfoPtr__continuePrompt_5__8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunCheckContinueOfflineMatchFlow._execute_d__8>.NativeClassPtr, "<continuePrompt>5__8");
				RunCheckContinueOfflineMatchFlow._execute_d__8.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunCheckContinueOfflineMatchFlow._execute_d__8>.NativeClassPtr, 100667050);
				RunCheckContinueOfflineMatchFlow._execute_d__8.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunCheckContinueOfflineMatchFlow._execute_d__8>.NativeClassPtr, 100667051);
				RunCheckContinueOfflineMatchFlow._execute_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunCheckContinueOfflineMatchFlow._execute_d__8>.NativeClassPtr, 100667052);
				RunCheckContinueOfflineMatchFlow._execute_d__8.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunCheckContinueOfflineMatchFlow._execute_d__8>.NativeClassPtr, 100667053);
				RunCheckContinueOfflineMatchFlow._execute_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunCheckContinueOfflineMatchFlow._execute_d__8>.NativeClassPtr, 100667054);
				RunCheckContinueOfflineMatchFlow._execute_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunCheckContinueOfflineMatchFlow._execute_d__8>.NativeClassPtr, 100667055);
				RunCheckContinueOfflineMatchFlow._execute_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunCheckContinueOfflineMatchFlow._execute_d__8>.NativeClassPtr, 100667056);
			}

			// Token: 0x06002FBA RID: 12218 RVA: 0x000B7184 File Offset: 0x000B5384
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__8(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunCheckContinueOfflineMatchFlow._execute_d__8>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunCheckContinueOfflineMatchFlow._execute_d__8.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002FBB RID: 12219 RVA: 0x000B71CC File Offset: 0x000B53CC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 527848, XrefRangeEnd = 527853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunCheckContinueOfflineMatchFlow._execute_d__8.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002FBC RID: 12220 RVA: 0x000B7200 File Offset: 0x000B5400
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 527853, XrefRangeEnd = 527936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunCheckContinueOfflineMatchFlow._execute_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06002FBD RID: 12221 RVA: 0x000B723C File Offset: 0x000B543C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 527939, RefRangeEnd = 527940, XrefRangeStart = 527936, XrefRangeEnd = 527939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunCheckContinueOfflineMatchFlow._execute_d__8.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000DBE RID: 3518
			// (get) Token: 0x06002FBE RID: 12222 RVA: 0x000B7270 File Offset: 0x000B5470
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunCheckContinueOfflineMatchFlow._execute_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002FBF RID: 12223 RVA: 0x000B72B0 File Offset: 0x000B54B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 527940, XrefRangeEnd = 527945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunCheckContinueOfflineMatchFlow._execute_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000DBF RID: 3519
			// (get) Token: 0x06002FC0 RID: 12224 RVA: 0x000B72E4 File Offset: 0x000B54E4
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunCheckContinueOfflineMatchFlow._execute_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002FC1 RID: 12225 RVA: 0x00018A50 File Offset: 0x00016C50
			public _execute_d__8(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000DB4 RID: 3508
			// (get) Token: 0x06002FC2 RID: 12226 RVA: 0x000B7324 File Offset: 0x000B5524
			// (set) Token: 0x06002FC3 RID: 12227 RVA: 0x00018A59 File Offset: 0x00016C59
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunCheckContinueOfflineMatchFlow._execute_d__8.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunCheckContinueOfflineMatchFlow._execute_d__8.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000DB5 RID: 3509
			// (get) Token: 0x06002FC4 RID: 12228 RVA: 0x000B734C File Offset: 0x000B554C
			// (set) Token: 0x06002FC5 RID: 12229 RVA: 0x00018A74 File Offset: 0x00016C74
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunCheckContinueOfflineMatchFlow._execute_d__8.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunCheckContinueOfflineMatchFlow._execute_d__8.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000DB6 RID: 3510
			// (get) Token: 0x06002FC6 RID: 12230 RVA: 0x000B737C File Offset: 0x000B557C
			// (set) Token: 0x06002FC7 RID: 12231 RVA: 0x00018A93 File Offset: 0x00016C93
			public unsafe RunCheckContinueOfflineMatchFlow __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunCheckContinueOfflineMatchFlow._execute_d__8.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RunCheckContinueOfflineMatchFlow>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunCheckContinueOfflineMatchFlow._execute_d__8.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000DB7 RID: 3511
			// (get) Token: 0x06002FC8 RID: 12232 RVA: 0x000B73AC File Offset: 0x000B55AC
			// (set) Token: 0x06002FC9 RID: 12233 RVA: 0x00018AB2 File Offset: 0x00016CB2
			public unsafe SaveMetaDataProvider _metaDataProvider_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunCheckContinueOfflineMatchFlow._execute_d__8.NativeFieldInfoPtr__metaDataProvider_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SaveMetaDataProvider>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunCheckContinueOfflineMatchFlow._execute_d__8.NativeFieldInfoPtr__metaDataProvider_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000DB8 RID: 3512
			// (get) Token: 0x06002FCA RID: 12234 RVA: 0x000B73DC File Offset: 0x000B55DC
			// (set) Token: 0x06002FCB RID: 12235 RVA: 0x00018AD1 File Offset: 0x00016CD1
			public unsafe OfflineMatchesManager _offlineMatches_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunCheckContinueOfflineMatchFlow._execute_d__8.NativeFieldInfoPtr__offlineMatches_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<OfflineMatchesManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunCheckContinueOfflineMatchFlow._execute_d__8.NativeFieldInfoPtr__offlineMatches_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000DB9 RID: 3513
			// (get) Token: 0x06002FCC RID: 12236 RVA: 0x000B740C File Offset: 0x000B560C
			// (set) Token: 0x06002FCD RID: 12237 RVA: 0x00018AF0 File Offset: 0x00016CF0
			public unsafe IEnumerator<MatchInitData> __7__wrap3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunCheckContinueOfflineMatchFlow._execute_d__8.NativeFieldInfoPtr___7__wrap3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<MatchInitData>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunCheckContinueOfflineMatchFlow._execute_d__8.NativeFieldInfoPtr___7__wrap3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000DBA RID: 3514
			// (get) Token: 0x06002FCE RID: 12238 RVA: 0x000B743C File Offset: 0x000B563C
			// (set) Token: 0x06002FCF RID: 12239 RVA: 0x00018B0F File Offset: 0x00016D0F
			public unsafe SaveMetaData _metaData_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunCheckContinueOfflineMatchFlow._execute_d__8.NativeFieldInfoPtr__metaData_5__5);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SaveMetaData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunCheckContinueOfflineMatchFlow._execute_d__8.NativeFieldInfoPtr__metaData_5__5), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000DBB RID: 3515
			// (get) Token: 0x06002FD0 RID: 12240 RVA: 0x000B746C File Offset: 0x000B566C
			// (set) Token: 0x06002FD1 RID: 12241 RVA: 0x00018B2E File Offset: 0x00016D2E
			public unsafe SaveMetaDataProvider.LoadReference _loadGameCommand_5__6
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunCheckContinueOfflineMatchFlow._execute_d__8.NativeFieldInfoPtr__loadGameCommand_5__6);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SaveMetaDataProvider.LoadReference>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunCheckContinueOfflineMatchFlow._execute_d__8.NativeFieldInfoPtr__loadGameCommand_5__6), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000DBC RID: 3516
			// (get) Token: 0x06002FD2 RID: 12242 RVA: 0x000B749C File Offset: 0x000B569C
			// (set) Token: 0x06002FD3 RID: 12243 RVA: 0x00018B4D File Offset: 0x00016D4D
			public unsafe SaveData _saveGameData_5__7
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunCheckContinueOfflineMatchFlow._execute_d__8.NativeFieldInfoPtr__saveGameData_5__7);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SaveData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunCheckContinueOfflineMatchFlow._execute_d__8.NativeFieldInfoPtr__saveGameData_5__7), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000DBD RID: 3517
			// (get) Token: 0x06002FD4 RID: 12244 RVA: 0x000B74CC File Offset: 0x000B56CC
			// (set) Token: 0x06002FD5 RID: 12245 RVA: 0x00018B6C File Offset: 0x00016D6C
			public unsafe ContinueOfflineGamePrompt _continuePrompt_5__8
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunCheckContinueOfflineMatchFlow._execute_d__8.NativeFieldInfoPtr__continuePrompt_5__8);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ContinueOfflineGamePrompt>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunCheckContinueOfflineMatchFlow._execute_d__8.NativeFieldInfoPtr__continuePrompt_5__8), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001D87 RID: 7559
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001D88 RID: 7560
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001D89 RID: 7561
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001D8A RID: 7562
			private static readonly IntPtr NativeFieldInfoPtr__metaDataProvider_5__2;

			// Token: 0x04001D8B RID: 7563
			private static readonly IntPtr NativeFieldInfoPtr__offlineMatches_5__3;

			// Token: 0x04001D8C RID: 7564
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap3;

			// Token: 0x04001D8D RID: 7565
			private static readonly IntPtr NativeFieldInfoPtr__metaData_5__5;

			// Token: 0x04001D8E RID: 7566
			private static readonly IntPtr NativeFieldInfoPtr__loadGameCommand_5__6;

			// Token: 0x04001D8F RID: 7567
			private static readonly IntPtr NativeFieldInfoPtr__saveGameData_5__7;

			// Token: 0x04001D90 RID: 7568
			private static readonly IntPtr NativeFieldInfoPtr__continuePrompt_5__8;

			// Token: 0x04001D91 RID: 7569
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001D92 RID: 7570
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001D93 RID: 7571
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001D94 RID: 7572
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04001D95 RID: 7573
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001D96 RID: 7574
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001D97 RID: 7575
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
