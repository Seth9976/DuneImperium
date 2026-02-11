using System;
using boardgames.data;
using boardgames.menus.prompts;
using Canis;
using dwd.core;
using dwd.core.commands;
using dwd.core.ui.prompt.prompts;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace boardgames.menus.commands
{
	// Token: 0x02000222 RID: 546
	public class RunConfigureNewOfflineMatchFlow : Command
	{
		// Token: 0x060018D9 RID: 6361 RVA: 0x0006E3D0 File Offset: 0x0006C5D0
		// Note: this type is marked as 'beforefieldinit'.
		static RunConfigureNewOfflineMatchFlow()
		{
			Il2CppClassPointerStore<RunConfigureNewOfflineMatchFlow>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.menus.commands", "RunConfigureNewOfflineMatchFlow");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RunConfigureNewOfflineMatchFlow>.NativeClassPtr);
			RunConfigureNewOfflineMatchFlow.NativeFieldInfoPtr_matchData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunConfigureNewOfflineMatchFlow>.NativeClassPtr, "matchData");
			RunConfigureNewOfflineMatchFlow.NativeFieldInfoPtr__ConfiguredResult_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunConfigureNewOfflineMatchFlow>.NativeClassPtr, "<ConfiguredResult>k__BackingField");
			RunConfigureNewOfflineMatchFlow.NativeFieldInfoPtr_error = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunConfigureNewOfflineMatchFlow>.NativeClassPtr, "error");
			RunConfigureNewOfflineMatchFlow.NativeFieldInfoPtr_backToPrompt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunConfigureNewOfflineMatchFlow>.NativeClassPtr, "backToPrompt");
			RunConfigureNewOfflineMatchFlow.NativeFieldInfoPtr_promptFlavors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunConfigureNewOfflineMatchFlow>.NativeClassPtr, "promptFlavors");
			RunConfigureNewOfflineMatchFlow.NativeMethodInfoPtr_get_ConfiguredResult_Public_get_MatchInitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunConfigureNewOfflineMatchFlow>.NativeClassPtr, 100667075);
			RunConfigureNewOfflineMatchFlow.NativeMethodInfoPtr_set_ConfiguredResult_Private_set_Void_MatchInitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunConfigureNewOfflineMatchFlow>.NativeClassPtr, 100667076);
			RunConfigureNewOfflineMatchFlow.NativeMethodInfoPtr__ctor_Public_Void_SerializedMatchComponent_IReturnablePrompt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunConfigureNewOfflineMatchFlow>.NativeClassPtr, 100667077);
			RunConfigureNewOfflineMatchFlow.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunConfigureNewOfflineMatchFlow>.NativeClassPtr, 100667078);
			RunConfigureNewOfflineMatchFlow.NativeMethodInfoPtr_WithPromptFlavors_Public_RunConfigureNewOfflineMatchFlow_IEnumerable_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunConfigureNewOfflineMatchFlow>.NativeClassPtr, 100667079);
			RunConfigureNewOfflineMatchFlow.NativeMethodInfoPtr_CancelConfig_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunConfigureNewOfflineMatchFlow>.NativeClassPtr, 100667080);
			RunConfigureNewOfflineMatchFlow.NativeMethodInfoPtr_Status_Public_Virtual_Final_New_ErrorInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunConfigureNewOfflineMatchFlow>.NativeClassPtr, 100667081);
		}

		// Token: 0x170006AB RID: 1707
		// (get) Token: 0x060018DA RID: 6362 RVA: 0x0006E4F0 File Offset: 0x0006C6F0
		// (set) Token: 0x060018DB RID: 6363 RVA: 0x0006E530 File Offset: 0x0006C730
		public unsafe MatchInitData ConfiguredResult
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunConfigureNewOfflineMatchFlow.NativeMethodInfoPtr_get_ConfiguredResult_Public_get_MatchInitData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunConfigureNewOfflineMatchFlow.NativeMethodInfoPtr_set_ConfiguredResult_Private_set_Void_MatchInitData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060018DC RID: 6364 RVA: 0x0006E574 File Offset: 0x0006C774
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 528122, XrefRangeEnd = 528130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RunConfigureNewOfflineMatchFlow(SerializedMatchComponent matchComponent, IReturnablePrompt backToPrompt = null)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunConfigureNewOfflineMatchFlow>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(matchComponent);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(backToPrompt);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunConfigureNewOfflineMatchFlow.NativeMethodInfoPtr__ctor_Public_Void_SerializedMatchComponent_IReturnablePrompt_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018DD RID: 6365 RVA: 0x0006E5D4 File Offset: 0x0006C7D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 528130, XrefRangeEnd = 528135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RunConfigureNewOfflineMatchFlow.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060018DE RID: 6366 RVA: 0x0006E620 File Offset: 0x0006C820
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 136596, RefRangeEnd = 136597, XrefRangeStart = 136596, XrefRangeEnd = 136597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RunConfigureNewOfflineMatchFlow WithPromptFlavors(IEnumerable<string> flavors)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(flavors);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunConfigureNewOfflineMatchFlow.NativeMethodInfoPtr_WithPromptFlavors_Public_RunConfigureNewOfflineMatchFlow_IEnumerable_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RunConfigureNewOfflineMatchFlow>(intPtr3) : null;
			}
		}

		// Token: 0x060018DF RID: 6367 RVA: 0x0006E670 File Offset: 0x0006C870
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 528135, XrefRangeEnd = 528136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CancelConfig()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunConfigureNewOfflineMatchFlow.NativeMethodInfoPtr_CancelConfig_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018E0 RID: 6368 RVA: 0x0006E6A4 File Offset: 0x0006C8A4
		[CallerCount(0)]
		public unsafe virtual ErrorInfo Status()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunConfigureNewOfflineMatchFlow.NativeMethodInfoPtr_Status_Public_Virtual_Final_New_ErrorInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new ErrorInfo(intPtr);
		}

		// Token: 0x060018E1 RID: 6369 RVA: 0x0000DB73 File Offset: 0x0000BD73
		public RunConfigureNewOfflineMatchFlow(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006A6 RID: 1702
		// (get) Token: 0x060018E2 RID: 6370 RVA: 0x0006E6DC File Offset: 0x0006C8DC
		// (set) Token: 0x060018E3 RID: 6371 RVA: 0x0000DB7C File Offset: 0x0000BD7C
		public unsafe SerializedMatchComponent matchData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunConfigureNewOfflineMatchFlow.NativeFieldInfoPtr_matchData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SerializedMatchComponent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunConfigureNewOfflineMatchFlow.NativeFieldInfoPtr_matchData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006A7 RID: 1703
		// (get) Token: 0x060018E4 RID: 6372 RVA: 0x0006E70C File Offset: 0x0006C90C
		// (set) Token: 0x060018E5 RID: 6373 RVA: 0x0000DB9B File Offset: 0x0000BD9B
		public unsafe MatchInitData _ConfiguredResult_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunConfigureNewOfflineMatchFlow.NativeFieldInfoPtr__ConfiguredResult_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MatchInitData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunConfigureNewOfflineMatchFlow.NativeFieldInfoPtr__ConfiguredResult_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006A8 RID: 1704
		// (get) Token: 0x060018E6 RID: 6374 RVA: 0x0006E73C File Offset: 0x0006C93C
		// (set) Token: 0x060018E7 RID: 6375 RVA: 0x0000DBBA File Offset: 0x0000BDBA
		public ErrorInfo error
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunConfigureNewOfflineMatchFlow.NativeFieldInfoPtr_error);
				return new ErrorInfo(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ErrorInfo>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunConfigureNewOfflineMatchFlow.NativeFieldInfoPtr_error), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ErrorInfo>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170006A9 RID: 1705
		// (get) Token: 0x060018E8 RID: 6376 RVA: 0x0006E76C File Offset: 0x0006C96C
		// (set) Token: 0x060018E9 RID: 6377 RVA: 0x0000DBE8 File Offset: 0x0000BDE8
		public unsafe IReturnablePrompt backToPrompt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunConfigureNewOfflineMatchFlow.NativeFieldInfoPtr_backToPrompt);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IReturnablePrompt>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunConfigureNewOfflineMatchFlow.NativeFieldInfoPtr_backToPrompt), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006AA RID: 1706
		// (get) Token: 0x060018EA RID: 6378 RVA: 0x0006E79C File Offset: 0x0006C99C
		// (set) Token: 0x060018EB RID: 6379 RVA: 0x0000DC07 File Offset: 0x0000BE07
		public unsafe IEnumerable<string> promptFlavors
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunConfigureNewOfflineMatchFlow.NativeFieldInfoPtr_promptFlavors);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunConfigureNewOfflineMatchFlow.NativeFieldInfoPtr_promptFlavors), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000F84 RID: 3972
		private static readonly IntPtr NativeFieldInfoPtr_matchData;

		// Token: 0x04000F85 RID: 3973
		private static readonly IntPtr NativeFieldInfoPtr__ConfiguredResult_k__BackingField;

		// Token: 0x04000F86 RID: 3974
		private static readonly IntPtr NativeFieldInfoPtr_error;

		// Token: 0x04000F87 RID: 3975
		private static readonly IntPtr NativeFieldInfoPtr_backToPrompt;

		// Token: 0x04000F88 RID: 3976
		private static readonly IntPtr NativeFieldInfoPtr_promptFlavors;

		// Token: 0x04000F89 RID: 3977
		private static readonly IntPtr NativeMethodInfoPtr_get_ConfiguredResult_Public_get_MatchInitData_0;

		// Token: 0x04000F8A RID: 3978
		private static readonly IntPtr NativeMethodInfoPtr_set_ConfiguredResult_Private_set_Void_MatchInitData_0;

		// Token: 0x04000F8B RID: 3979
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SerializedMatchComponent_IReturnablePrompt_0;

		// Token: 0x04000F8C RID: 3980
		private static readonly IntPtr NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0;

		// Token: 0x04000F8D RID: 3981
		private static readonly IntPtr NativeMethodInfoPtr_WithPromptFlavors_Public_RunConfigureNewOfflineMatchFlow_IEnumerable_1_String_0;

		// Token: 0x04000F8E RID: 3982
		private static readonly IntPtr NativeMethodInfoPtr_CancelConfig_Private_Void_0;

		// Token: 0x04000F8F RID: 3983
		private static readonly IntPtr NativeMethodInfoPtr_Status_Public_Virtual_Final_New_ErrorInfo_0;

		// Token: 0x020003FF RID: 1023
		[ObfuscatedName("boardgames.menus.commands.RunConfigureNewOfflineMatchFlow+<execute>d__9")]
		public sealed class _execute_d__9 : Object
		{
			// Token: 0x06003002 RID: 12290 RVA: 0x000B7D0C File Offset: 0x000B5F0C
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__9()
			{
				Il2CppClassPointerStore<RunConfigureNewOfflineMatchFlow._execute_d__9>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RunConfigureNewOfflineMatchFlow>.NativeClassPtr, "<execute>d__9");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RunConfigureNewOfflineMatchFlow._execute_d__9>.NativeClassPtr);
				RunConfigureNewOfflineMatchFlow._execute_d__9.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunConfigureNewOfflineMatchFlow._execute_d__9>.NativeClassPtr, "<>1__state");
				RunConfigureNewOfflineMatchFlow._execute_d__9.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunConfigureNewOfflineMatchFlow._execute_d__9>.NativeClassPtr, "<>2__current");
				RunConfigureNewOfflineMatchFlow._execute_d__9.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunConfigureNewOfflineMatchFlow._execute_d__9>.NativeClassPtr, "<>4__this");
				RunConfigureNewOfflineMatchFlow._execute_d__9.NativeFieldInfoPtr__configPrompt_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunConfigureNewOfflineMatchFlow._execute_d__9>.NativeClassPtr, "<configPrompt>5__2");
				RunConfigureNewOfflineMatchFlow._execute_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunConfigureNewOfflineMatchFlow._execute_d__9>.NativeClassPtr, 100667082);
				RunConfigureNewOfflineMatchFlow._execute_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunConfigureNewOfflineMatchFlow._execute_d__9>.NativeClassPtr, 100667083);
				RunConfigureNewOfflineMatchFlow._execute_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunConfigureNewOfflineMatchFlow._execute_d__9>.NativeClassPtr, 100667084);
				RunConfigureNewOfflineMatchFlow._execute_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunConfigureNewOfflineMatchFlow._execute_d__9>.NativeClassPtr, 100667085);
				RunConfigureNewOfflineMatchFlow._execute_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunConfigureNewOfflineMatchFlow._execute_d__9>.NativeClassPtr, 100667086);
				RunConfigureNewOfflineMatchFlow._execute_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunConfigureNewOfflineMatchFlow._execute_d__9>.NativeClassPtr, 100667087);
			}

			// Token: 0x06003003 RID: 12291 RVA: 0x000B7E00 File Offset: 0x000B6000
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__9(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunConfigureNewOfflineMatchFlow._execute_d__9>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunConfigureNewOfflineMatchFlow._execute_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003004 RID: 12292 RVA: 0x000B7E48 File Offset: 0x000B6048
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunConfigureNewOfflineMatchFlow._execute_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003005 RID: 12293 RVA: 0x000B7E7C File Offset: 0x000B607C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 528098, XrefRangeEnd = 528117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunConfigureNewOfflineMatchFlow._execute_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000DD4 RID: 3540
			// (get) Token: 0x06003006 RID: 12294 RVA: 0x000B7EB8 File Offset: 0x000B60B8
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunConfigureNewOfflineMatchFlow._execute_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06003007 RID: 12295 RVA: 0x000B7EF8 File Offset: 0x000B60F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 528117, XrefRangeEnd = 528122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunConfigureNewOfflineMatchFlow._execute_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000DD5 RID: 3541
			// (get) Token: 0x06003008 RID: 12296 RVA: 0x000B7F2C File Offset: 0x000B612C
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunConfigureNewOfflineMatchFlow._execute_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06003009 RID: 12297 RVA: 0x00018CF8 File Offset: 0x00016EF8
			public _execute_d__9(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000DD0 RID: 3536
			// (get) Token: 0x0600300A RID: 12298 RVA: 0x000B7F6C File Offset: 0x000B616C
			// (set) Token: 0x0600300B RID: 12299 RVA: 0x00018D01 File Offset: 0x00016F01
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunConfigureNewOfflineMatchFlow._execute_d__9.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunConfigureNewOfflineMatchFlow._execute_d__9.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000DD1 RID: 3537
			// (get) Token: 0x0600300C RID: 12300 RVA: 0x000B7F94 File Offset: 0x000B6194
			// (set) Token: 0x0600300D RID: 12301 RVA: 0x00018D1C File Offset: 0x00016F1C
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunConfigureNewOfflineMatchFlow._execute_d__9.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunConfigureNewOfflineMatchFlow._execute_d__9.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000DD2 RID: 3538
			// (get) Token: 0x0600300E RID: 12302 RVA: 0x000B7FC4 File Offset: 0x000B61C4
			// (set) Token: 0x0600300F RID: 12303 RVA: 0x00018D3B File Offset: 0x00016F3B
			public unsafe RunConfigureNewOfflineMatchFlow __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunConfigureNewOfflineMatchFlow._execute_d__9.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RunConfigureNewOfflineMatchFlow>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunConfigureNewOfflineMatchFlow._execute_d__9.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000DD3 RID: 3539
			// (get) Token: 0x06003010 RID: 12304 RVA: 0x000B7FF4 File Offset: 0x000B61F4
			// (set) Token: 0x06003011 RID: 12305 RVA: 0x00018D5A File Offset: 0x00016F5A
			public unsafe ConfigureOfflineGamePrompt _configPrompt_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunConfigureNewOfflineMatchFlow._execute_d__9.NativeFieldInfoPtr__configPrompt_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConfigureOfflineGamePrompt>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunConfigureNewOfflineMatchFlow._execute_d__9.NativeFieldInfoPtr__configPrompt_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001DB2 RID: 7602
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001DB3 RID: 7603
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001DB4 RID: 7604
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001DB5 RID: 7605
			private static readonly IntPtr NativeFieldInfoPtr__configPrompt_5__2;

			// Token: 0x04001DB6 RID: 7606
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001DB7 RID: 7607
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001DB8 RID: 7608
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001DB9 RID: 7609
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001DBA RID: 7610
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001DBB RID: 7611
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
