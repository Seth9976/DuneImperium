using System;
using System.Runtime.InteropServices;
using boardgames.data;
using Canis;
using dwd.core;
using dwd.core.commands;
using dwd.core.ui.prompt.prompts;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace boardgames.menus.commands
{
	// Token: 0x02000223 RID: 547
	public class RunConfigureOfflineMatchFlow : Command
	{
		// Token: 0x060018EC RID: 6380 RVA: 0x0006E7CC File Offset: 0x0006C9CC
		// Note: this type is marked as 'beforefieldinit'.
		static RunConfigureOfflineMatchFlow()
		{
			Il2CppClassPointerStore<RunConfigureOfflineMatchFlow>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.menus.commands", "RunConfigureOfflineMatchFlow");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RunConfigureOfflineMatchFlow>.NativeClassPtr);
			RunConfigureOfflineMatchFlow.NativeFieldInfoPtr_matchData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunConfigureOfflineMatchFlow>.NativeClassPtr, "matchData");
			RunConfigureOfflineMatchFlow.NativeFieldInfoPtr_ConfiguredResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunConfigureOfflineMatchFlow>.NativeClassPtr, "ConfiguredResult");
			RunConfigureOfflineMatchFlow.NativeFieldInfoPtr_error = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunConfigureOfflineMatchFlow>.NativeClassPtr, "error");
			RunConfigureOfflineMatchFlow.NativeFieldInfoPtr_backToPrompt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunConfigureOfflineMatchFlow>.NativeClassPtr, "backToPrompt");
			RunConfigureOfflineMatchFlow.NativeFieldInfoPtr_promptFlavors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunConfigureOfflineMatchFlow>.NativeClassPtr, "promptFlavors");
			RunConfigureOfflineMatchFlow.NativeFieldInfoPtr__IsResume_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunConfigureOfflineMatchFlow>.NativeClassPtr, "<IsResume>k__BackingField");
			RunConfigureOfflineMatchFlow.NativeMethodInfoPtr_get_IsResume_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunConfigureOfflineMatchFlow>.NativeClassPtr, 100667088);
			RunConfigureOfflineMatchFlow.NativeMethodInfoPtr_set_IsResume_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunConfigureOfflineMatchFlow>.NativeClassPtr, 100667089);
			RunConfigureOfflineMatchFlow.NativeMethodInfoPtr__ctor_Public_Void_SerializedMatchComponent_IReturnablePrompt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunConfigureOfflineMatchFlow>.NativeClassPtr, 100667090);
			RunConfigureOfflineMatchFlow.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunConfigureOfflineMatchFlow>.NativeClassPtr, 100667091);
			RunConfigureOfflineMatchFlow.NativeMethodInfoPtr_ConfigureMatch_Private_IEnumerator_RunCheckContinueOfflineMatchFlow_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunConfigureOfflineMatchFlow>.NativeClassPtr, 100667092);
			RunConfigureOfflineMatchFlow.NativeMethodInfoPtr_CancelConfig_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunConfigureOfflineMatchFlow>.NativeClassPtr, 100667093);
			RunConfigureOfflineMatchFlow.NativeMethodInfoPtr_Status_Public_Virtual_Final_New_ErrorInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunConfigureOfflineMatchFlow>.NativeClassPtr, 100667094);
			RunConfigureOfflineMatchFlow.NativeMethodInfoPtr_WithPromptFlavors_Public_RunConfigureOfflineMatchFlow_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunConfigureOfflineMatchFlow>.NativeClassPtr, 100667095);
			RunConfigureOfflineMatchFlow.NativeMethodInfoPtr__ConfigureMatch_b__11_0_Private_Void_RunConfigureNewOfflineMatchFlow_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunConfigureOfflineMatchFlow>.NativeClassPtr, 100667096);
		}

		// Token: 0x170006B2 RID: 1714
		// (get) Token: 0x060018ED RID: 6381 RVA: 0x0006E928 File Offset: 0x0006CB28
		// (set) Token: 0x060018EE RID: 6382 RVA: 0x0006E964 File Offset: 0x0006CB64
		public unsafe bool IsResume
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunConfigureOfflineMatchFlow.NativeMethodInfoPtr_get_IsResume_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunConfigureOfflineMatchFlow.NativeMethodInfoPtr_set_IsResume_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060018EF RID: 6383 RVA: 0x0006E9A4 File Offset: 0x0006CBA4
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 528191, RefRangeEnd = 528197, XrefRangeStart = 528176, XrefRangeEnd = 528191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RunConfigureOfflineMatchFlow(SerializedMatchComponent matchComponent, IReturnablePrompt backToPrompt = null)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunConfigureOfflineMatchFlow>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(matchComponent);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(backToPrompt);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunConfigureOfflineMatchFlow.NativeMethodInfoPtr__ctor_Public_Void_SerializedMatchComponent_IReturnablePrompt_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018F0 RID: 6384 RVA: 0x0006EA04 File Offset: 0x0006CC04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 528197, XrefRangeEnd = 528240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RunConfigureOfflineMatchFlow.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060018F1 RID: 6385 RVA: 0x0006EA50 File Offset: 0x0006CC50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 528240, XrefRangeEnd = 528246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator ConfigureMatch(RunCheckContinueOfflineMatchFlow continueFlow)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(continueFlow);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunConfigureOfflineMatchFlow.NativeMethodInfoPtr_ConfigureMatch_Private_IEnumerator_RunCheckContinueOfflineMatchFlow_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x060018F2 RID: 6386 RVA: 0x0006EAA0 File Offset: 0x0006CCA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CancelConfig()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunConfigureOfflineMatchFlow.NativeMethodInfoPtr_CancelConfig_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018F3 RID: 6387 RVA: 0x0006EAD4 File Offset: 0x0006CCD4
		[CallerCount(0)]
		public unsafe virtual ErrorInfo Status()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunConfigureOfflineMatchFlow.NativeMethodInfoPtr_Status_Public_Virtual_Final_New_ErrorInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new ErrorInfo(intPtr);
		}

		// Token: 0x060018F4 RID: 6388 RVA: 0x0006EB0C File Offset: 0x0006CD0C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 528249, RefRangeEnd = 528250, XrefRangeStart = 528246, XrefRangeEnd = 528249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RunConfigureOfflineMatchFlow WithPromptFlavors([Optional] Il2CppStringArray flavors)
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunConfigureOfflineMatchFlow.NativeMethodInfoPtr_WithPromptFlavors_Public_RunConfigureOfflineMatchFlow_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RunConfigureOfflineMatchFlow>(intPtr3) : null;
			}
		}

		// Token: 0x060018F5 RID: 6389 RVA: 0x0006EB6C File Offset: 0x0006CD6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 528250, XrefRangeEnd = 528252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _ConfigureMatch_b__11_0(RunConfigureNewOfflineMatchFlow f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(f);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunConfigureOfflineMatchFlow.NativeMethodInfoPtr__ConfigureMatch_b__11_0_Private_Void_RunConfigureNewOfflineMatchFlow_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060018F6 RID: 6390 RVA: 0x0000DC26 File Offset: 0x0000BE26
		public RunConfigureOfflineMatchFlow WithPromptFlavors(params string[] flavors)
		{
			return this.WithPromptFlavors(new Il2CppStringArray(flavors));
		}

		// Token: 0x060018F7 RID: 6391 RVA: 0x0000DC34 File Offset: 0x0000BE34
		public RunConfigureOfflineMatchFlow(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006AC RID: 1708
		// (get) Token: 0x060018F8 RID: 6392 RVA: 0x0006EBB0 File Offset: 0x0006CDB0
		// (set) Token: 0x060018F9 RID: 6393 RVA: 0x0000DC3D File Offset: 0x0000BE3D
		public unsafe SerializedMatchComponent matchData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunConfigureOfflineMatchFlow.NativeFieldInfoPtr_matchData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SerializedMatchComponent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunConfigureOfflineMatchFlow.NativeFieldInfoPtr_matchData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006AD RID: 1709
		// (get) Token: 0x060018FA RID: 6394 RVA: 0x0006EBE0 File Offset: 0x0006CDE0
		// (set) Token: 0x060018FB RID: 6395 RVA: 0x0000DC5C File Offset: 0x0000BE5C
		public unsafe MatchInitData ConfiguredResult
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunConfigureOfflineMatchFlow.NativeFieldInfoPtr_ConfiguredResult);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MatchInitData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunConfigureOfflineMatchFlow.NativeFieldInfoPtr_ConfiguredResult), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006AE RID: 1710
		// (get) Token: 0x060018FC RID: 6396 RVA: 0x0006EC10 File Offset: 0x0006CE10
		// (set) Token: 0x060018FD RID: 6397 RVA: 0x0000DC7B File Offset: 0x0000BE7B
		public ErrorInfo error
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunConfigureOfflineMatchFlow.NativeFieldInfoPtr_error);
				return new ErrorInfo(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ErrorInfo>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunConfigureOfflineMatchFlow.NativeFieldInfoPtr_error), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ErrorInfo>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170006AF RID: 1711
		// (get) Token: 0x060018FE RID: 6398 RVA: 0x0006EC40 File Offset: 0x0006CE40
		// (set) Token: 0x060018FF RID: 6399 RVA: 0x0000DCA9 File Offset: 0x0000BEA9
		public unsafe IReturnablePrompt backToPrompt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunConfigureOfflineMatchFlow.NativeFieldInfoPtr_backToPrompt);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IReturnablePrompt>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunConfigureOfflineMatchFlow.NativeFieldInfoPtr_backToPrompt), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006B0 RID: 1712
		// (get) Token: 0x06001900 RID: 6400 RVA: 0x0006EC70 File Offset: 0x0006CE70
		// (set) Token: 0x06001901 RID: 6401 RVA: 0x0000DCC8 File Offset: 0x0000BEC8
		public unsafe List<string> promptFlavors
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunConfigureOfflineMatchFlow.NativeFieldInfoPtr_promptFlavors);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunConfigureOfflineMatchFlow.NativeFieldInfoPtr_promptFlavors), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006B1 RID: 1713
		// (get) Token: 0x06001902 RID: 6402 RVA: 0x0006ECA0 File Offset: 0x0006CEA0
		// (set) Token: 0x06001903 RID: 6403 RVA: 0x0000DCE7 File Offset: 0x0000BEE7
		public unsafe bool _IsResume_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunConfigureOfflineMatchFlow.NativeFieldInfoPtr__IsResume_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunConfigureOfflineMatchFlow.NativeFieldInfoPtr__IsResume_k__BackingField)) = value;
			}
		}

		// Token: 0x04000F90 RID: 3984
		private static readonly IntPtr NativeFieldInfoPtr_matchData;

		// Token: 0x04000F91 RID: 3985
		private static readonly IntPtr NativeFieldInfoPtr_ConfiguredResult;

		// Token: 0x04000F92 RID: 3986
		private static readonly IntPtr NativeFieldInfoPtr_error;

		// Token: 0x04000F93 RID: 3987
		private static readonly IntPtr NativeFieldInfoPtr_backToPrompt;

		// Token: 0x04000F94 RID: 3988
		private static readonly IntPtr NativeFieldInfoPtr_promptFlavors;

		// Token: 0x04000F95 RID: 3989
		private static readonly IntPtr NativeFieldInfoPtr__IsResume_k__BackingField;

		// Token: 0x04000F96 RID: 3990
		private static readonly IntPtr NativeMethodInfoPtr_get_IsResume_Public_get_Boolean_0;

		// Token: 0x04000F97 RID: 3991
		private static readonly IntPtr NativeMethodInfoPtr_set_IsResume_Private_set_Void_Boolean_0;

		// Token: 0x04000F98 RID: 3992
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SerializedMatchComponent_IReturnablePrompt_0;

		// Token: 0x04000F99 RID: 3993
		private static readonly IntPtr NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0;

		// Token: 0x04000F9A RID: 3994
		private static readonly IntPtr NativeMethodInfoPtr_ConfigureMatch_Private_IEnumerator_RunCheckContinueOfflineMatchFlow_0;

		// Token: 0x04000F9B RID: 3995
		private static readonly IntPtr NativeMethodInfoPtr_CancelConfig_Protected_Void_0;

		// Token: 0x04000F9C RID: 3996
		private static readonly IntPtr NativeMethodInfoPtr_Status_Public_Virtual_Final_New_ErrorInfo_0;

		// Token: 0x04000F9D RID: 3997
		private static readonly IntPtr NativeMethodInfoPtr_WithPromptFlavors_Public_RunConfigureOfflineMatchFlow_Il2CppStringArray_0;

		// Token: 0x04000F9E RID: 3998
		private static readonly IntPtr NativeMethodInfoPtr__ConfigureMatch_b__11_0_Private_Void_RunConfigureNewOfflineMatchFlow_0;

		// Token: 0x02000400 RID: 1024
		[ObfuscatedName("boardgames.menus.commands.RunConfigureOfflineMatchFlow+<ConfigureMatch>d__11")]
		public sealed class _ConfigureMatch_d__11 : Object
		{
			// Token: 0x06003012 RID: 12306 RVA: 0x000B8024 File Offset: 0x000B6224
			// Note: this type is marked as 'beforefieldinit'.
			static _ConfigureMatch_d__11()
			{
				Il2CppClassPointerStore<RunConfigureOfflineMatchFlow._ConfigureMatch_d__11>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RunConfigureOfflineMatchFlow>.NativeClassPtr, "<ConfigureMatch>d__11");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RunConfigureOfflineMatchFlow._ConfigureMatch_d__11>.NativeClassPtr);
				RunConfigureOfflineMatchFlow._ConfigureMatch_d__11.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunConfigureOfflineMatchFlow._ConfigureMatch_d__11>.NativeClassPtr, "<>1__state");
				RunConfigureOfflineMatchFlow._ConfigureMatch_d__11.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunConfigureOfflineMatchFlow._ConfigureMatch_d__11>.NativeClassPtr, "<>2__current");
				RunConfigureOfflineMatchFlow._ConfigureMatch_d__11.NativeFieldInfoPtr_continueFlow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunConfigureOfflineMatchFlow._ConfigureMatch_d__11>.NativeClassPtr, "continueFlow");
				RunConfigureOfflineMatchFlow._ConfigureMatch_d__11.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunConfigureOfflineMatchFlow._ConfigureMatch_d__11>.NativeClassPtr, "<>4__this");
				RunConfigureOfflineMatchFlow._ConfigureMatch_d__11.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunConfigureOfflineMatchFlow._ConfigureMatch_d__11>.NativeClassPtr, 100667097);
				RunConfigureOfflineMatchFlow._ConfigureMatch_d__11.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunConfigureOfflineMatchFlow._ConfigureMatch_d__11>.NativeClassPtr, 100667098);
				RunConfigureOfflineMatchFlow._ConfigureMatch_d__11.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunConfigureOfflineMatchFlow._ConfigureMatch_d__11>.NativeClassPtr, 100667099);
				RunConfigureOfflineMatchFlow._ConfigureMatch_d__11.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunConfigureOfflineMatchFlow._ConfigureMatch_d__11>.NativeClassPtr, 100667100);
				RunConfigureOfflineMatchFlow._ConfigureMatch_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunConfigureOfflineMatchFlow._ConfigureMatch_d__11>.NativeClassPtr, 100667101);
				RunConfigureOfflineMatchFlow._ConfigureMatch_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunConfigureOfflineMatchFlow._ConfigureMatch_d__11>.NativeClassPtr, 100667102);
			}

			// Token: 0x06003013 RID: 12307 RVA: 0x000B8118 File Offset: 0x000B6318
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _ConfigureMatch_d__11(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunConfigureOfflineMatchFlow._ConfigureMatch_d__11>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunConfigureOfflineMatchFlow._ConfigureMatch_d__11.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003014 RID: 12308 RVA: 0x000B8160 File Offset: 0x000B6360
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunConfigureOfflineMatchFlow._ConfigureMatch_d__11.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003015 RID: 12309 RVA: 0x000B8194 File Offset: 0x000B6394
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 528136, XrefRangeEnd = 528171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunConfigureOfflineMatchFlow._ConfigureMatch_d__11.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000DDA RID: 3546
			// (get) Token: 0x06003016 RID: 12310 RVA: 0x000B81D0 File Offset: 0x000B63D0
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunConfigureOfflineMatchFlow._ConfigureMatch_d__11.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06003017 RID: 12311 RVA: 0x000B8210 File Offset: 0x000B6410
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 528171, XrefRangeEnd = 528176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunConfigureOfflineMatchFlow._ConfigureMatch_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000DDB RID: 3547
			// (get) Token: 0x06003018 RID: 12312 RVA: 0x000B8244 File Offset: 0x000B6444
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunConfigureOfflineMatchFlow._ConfigureMatch_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06003019 RID: 12313 RVA: 0x00018D79 File Offset: 0x00016F79
			public _ConfigureMatch_d__11(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000DD6 RID: 3542
			// (get) Token: 0x0600301A RID: 12314 RVA: 0x000B8284 File Offset: 0x000B6484
			// (set) Token: 0x0600301B RID: 12315 RVA: 0x00018D82 File Offset: 0x00016F82
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunConfigureOfflineMatchFlow._ConfigureMatch_d__11.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunConfigureOfflineMatchFlow._ConfigureMatch_d__11.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000DD7 RID: 3543
			// (get) Token: 0x0600301C RID: 12316 RVA: 0x000B82AC File Offset: 0x000B64AC
			// (set) Token: 0x0600301D RID: 12317 RVA: 0x00018D9D File Offset: 0x00016F9D
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunConfigureOfflineMatchFlow._ConfigureMatch_d__11.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunConfigureOfflineMatchFlow._ConfigureMatch_d__11.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000DD8 RID: 3544
			// (get) Token: 0x0600301E RID: 12318 RVA: 0x000B82DC File Offset: 0x000B64DC
			// (set) Token: 0x0600301F RID: 12319 RVA: 0x00018DBC File Offset: 0x00016FBC
			public unsafe RunCheckContinueOfflineMatchFlow continueFlow
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunConfigureOfflineMatchFlow._ConfigureMatch_d__11.NativeFieldInfoPtr_continueFlow);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RunCheckContinueOfflineMatchFlow>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunConfigureOfflineMatchFlow._ConfigureMatch_d__11.NativeFieldInfoPtr_continueFlow), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000DD9 RID: 3545
			// (get) Token: 0x06003020 RID: 12320 RVA: 0x000B830C File Offset: 0x000B650C
			// (set) Token: 0x06003021 RID: 12321 RVA: 0x00018DDB File Offset: 0x00016FDB
			public unsafe RunConfigureOfflineMatchFlow __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunConfigureOfflineMatchFlow._ConfigureMatch_d__11.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RunConfigureOfflineMatchFlow>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunConfigureOfflineMatchFlow._ConfigureMatch_d__11.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001DBC RID: 7612
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001DBD RID: 7613
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001DBE RID: 7614
			private static readonly IntPtr NativeFieldInfoPtr_continueFlow;

			// Token: 0x04001DBF RID: 7615
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001DC0 RID: 7616
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001DC1 RID: 7617
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001DC2 RID: 7618
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001DC3 RID: 7619
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001DC4 RID: 7620
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001DC5 RID: 7621
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
