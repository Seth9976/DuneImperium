using System;
using Canis.utils.ids;
using dwd.core.commands;
using dwd.core.eventTriggers.clientTriggers;
using dwd.core.match.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Networking.eventtriggers;
using Networking.eventtriggers.clientactions;
using UnityEngine;

namespace dwd.core.eventTriggers
{
	// Token: 0x020001AB RID: 427
	public class ClientEventResponder : MonoBehaviour
	{
		// Token: 0x06001830 RID: 6192 RVA: 0x00074934 File Offset: 0x00072B34
		// Note: this type is marked as 'beforefieldinit'.
		static ClientEventResponder()
		{
			Il2CppClassPointerStore<ClientEventResponder>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.eventTriggers", "ClientEventResponder");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClientEventResponder>.NativeClassPtr);
			ClientEventResponder.NativeFieldInfoPtr_Logging = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientEventResponder>.NativeClassPtr, "Logging");
			ClientEventResponder.NativeFieldInfoPtr_responseMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientEventResponder>.NativeClassPtr, "responseMap");
			ClientEventResponder.NativeFieldInfoPtr_responseList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientEventResponder>.NativeClassPtr, "responseList");
			ClientEventResponder.NativeFieldInfoPtr_clientEventCommands = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientEventResponder>.NativeClassPtr, "clientEventCommands");
			ClientEventResponder.NativeMethodInfoPtr_log_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientEventResponder>.NativeClassPtr, 100667155);
			ClientEventResponder.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientEventResponder>.NativeClassPtr, 100667156);
			ClientEventResponder.NativeMethodInfoPtr_InstallResponse_Public_Virtual_New_Void_ClientEventResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientEventResponder>.NativeClassPtr, 100667157);
			ClientEventResponder.NativeMethodInfoPtr_UninstallResponse_Public_Void_ClientEventResponseID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientEventResponder>.NativeClassPtr, 100667158);
			ClientEventResponder.NativeMethodInfoPtr_RunClientAction_Public_Command_ClientAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientEventResponder>.NativeClassPtr, 100667159);
			ClientEventResponder.NativeMethodInfoPtr_SignalTrigger_Public_IEnumerator_ClientTrigger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientEventResponder>.NativeClassPtr, 100667160);
			ClientEventResponder.NativeMethodInfoPtr_signalTrigger_Private_IEnumerator_ClientTrigger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientEventResponder>.NativeClassPtr, 100667161);
			ClientEventResponder.NativeMethodInfoPtr_getTriggeredActions_Private_List_1_ClientAction_ClientTrigger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientEventResponder>.NativeClassPtr, 100667162);
			ClientEventResponder.NativeMethodInfoPtr_resolveActions_Private_IEnumerator_ClientTrigger_List_1_ClientAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientEventResponder>.NativeClassPtr, 100667163);
			ClientEventResponder.NativeMethodInfoPtr_getClientActionCommand_Protected_Virtual_New_Command_ClientTrigger_ClientAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientEventResponder>.NativeClassPtr, 100667164);
			ClientEventResponder.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientEventResponder>.NativeClassPtr, 100667165);
		}

		// Token: 0x06001831 RID: 6193 RVA: 0x00074A90 File Offset: 0x00072C90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 880314, XrefRangeEnd = 880318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void log(string s)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientEventResponder.NativeMethodInfoPtr_log_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001832 RID: 6194 RVA: 0x00074AD4 File Offset: 0x00072CD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 880318, XrefRangeEnd = 880323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientEventResponder.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001833 RID: 6195 RVA: 0x00074B08 File Offset: 0x00072D08
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 880343, RefRangeEnd = 880344, XrefRangeStart = 880323, XrefRangeEnd = 880343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InstallResponse(ClientEventResponse cer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ClientEventResponder.NativeMethodInfoPtr_InstallResponse_Public_Virtual_New_Void_ClientEventResponse_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001834 RID: 6196 RVA: 0x00074B58 File Offset: 0x00072D58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 880344, XrefRangeEnd = 880353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UninstallResponse(ClientEventResponseID handle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(handle);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientEventResponder.NativeMethodInfoPtr_UninstallResponse_Public_Void_ClientEventResponseID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001835 RID: 6197 RVA: 0x00074B9C File Offset: 0x00072D9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 880353, XrefRangeEnd = 880354, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Command RunClientAction(ClientAction clientAction)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(clientAction);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientEventResponder.NativeMethodInfoPtr_RunClientAction_Public_Command_ClientAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Command>(intPtr3) : null;
			}
		}

		// Token: 0x06001836 RID: 6198 RVA: 0x00074BEC File Offset: 0x00072DEC
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 880360, RefRangeEnd = 880375, XrefRangeStart = 880354, XrefRangeEnd = 880360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator SignalTrigger(ClientTrigger trigger)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(trigger);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientEventResponder.NativeMethodInfoPtr_SignalTrigger_Public_IEnumerator_ClientTrigger_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x06001837 RID: 6199 RVA: 0x00074C3C File Offset: 0x00072E3C
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 880360, RefRangeEnd = 880375, XrefRangeStart = 880360, XrefRangeEnd = 880375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator signalTrigger(ClientTrigger trigger)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(trigger);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientEventResponder.NativeMethodInfoPtr_signalTrigger_Private_IEnumerator_ClientTrigger_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x06001838 RID: 6200 RVA: 0x00074C8C File Offset: 0x00072E8C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 880399, RefRangeEnd = 880400, XrefRangeStart = 880375, XrefRangeEnd = 880399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<ClientAction> getTriggeredActions(ClientTrigger trigger)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(trigger);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientEventResponder.NativeMethodInfoPtr_getTriggeredActions_Private_List_1_ClientAction_ClientTrigger_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<ClientAction>>(intPtr3) : null;
			}
		}

		// Token: 0x06001839 RID: 6201 RVA: 0x00074CDC File Offset: 0x00072EDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 880400, XrefRangeEnd = 880407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator resolveActions(ClientTrigger trigger, List<ClientAction> actions)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(trigger);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(actions);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientEventResponder.NativeMethodInfoPtr_resolveActions_Private_IEnumerator_ClientTrigger_List_1_ClientAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600183A RID: 6202 RVA: 0x00074D40 File Offset: 0x00072F40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 880407, XrefRangeEnd = 880409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Command getClientActionCommand(ClientTrigger trigger, ClientAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(trigger);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ClientEventResponder.NativeMethodInfoPtr_getClientActionCommand_Protected_Virtual_New_Command_ClientTrigger_ClientAction_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Command>(intPtr3) : null;
		}

		// Token: 0x0600183B RID: 6203 RVA: 0x00074DB0 File Offset: 0x00072FB0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 880424, RefRangeEnd = 880425, XrefRangeStart = 880409, XrefRangeEnd = 880424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ClientEventResponder()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClientEventResponder>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientEventResponder.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600183C RID: 6204 RVA: 0x0000A9E6 File Offset: 0x00008BE6
		public ClientEventResponder(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006C0 RID: 1728
		// (get) Token: 0x0600183D RID: 6205 RVA: 0x00074DEC File Offset: 0x00072FEC
		// (set) Token: 0x0600183E RID: 6206 RVA: 0x0000A9EF File Offset: 0x00008BEF
		public unsafe bool Logging
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientEventResponder.NativeFieldInfoPtr_Logging);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientEventResponder.NativeFieldInfoPtr_Logging)) = value;
			}
		}

		// Token: 0x170006C1 RID: 1729
		// (get) Token: 0x0600183F RID: 6207 RVA: 0x00074E14 File Offset: 0x00073014
		// (set) Token: 0x06001840 RID: 6208 RVA: 0x0000AA0A File Offset: 0x00008C0A
		public unsafe Dictionary<ClientEventResponseID, ClientEventResponse> responseMap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientEventResponder.NativeFieldInfoPtr_responseMap);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<ClientEventResponseID, ClientEventResponse>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientEventResponder.NativeFieldInfoPtr_responseMap), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006C2 RID: 1730
		// (get) Token: 0x06001841 RID: 6209 RVA: 0x00074E44 File Offset: 0x00073044
		// (set) Token: 0x06001842 RID: 6210 RVA: 0x0000AA29 File Offset: 0x00008C29
		public unsafe List<ClientEventResponse> responseList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientEventResponder.NativeFieldInfoPtr_responseList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ClientEventResponse>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientEventResponder.NativeFieldInfoPtr_responseList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006C3 RID: 1731
		// (get) Token: 0x06001843 RID: 6211 RVA: 0x00074E74 File Offset: 0x00073074
		// (set) Token: 0x06001844 RID: 6212 RVA: 0x0000AA48 File Offset: 0x00008C48
		public unsafe ClientEventCommands clientEventCommands
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientEventResponder.NativeFieldInfoPtr_clientEventCommands);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ClientEventCommands>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientEventResponder.NativeFieldInfoPtr_clientEventCommands), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400111E RID: 4382
		private static readonly IntPtr NativeFieldInfoPtr_Logging;

		// Token: 0x0400111F RID: 4383
		private static readonly IntPtr NativeFieldInfoPtr_responseMap;

		// Token: 0x04001120 RID: 4384
		private static readonly IntPtr NativeFieldInfoPtr_responseList;

		// Token: 0x04001121 RID: 4385
		private static readonly IntPtr NativeFieldInfoPtr_clientEventCommands;

		// Token: 0x04001122 RID: 4386
		private static readonly IntPtr NativeMethodInfoPtr_log_Private_Void_String_0;

		// Token: 0x04001123 RID: 4387
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04001124 RID: 4388
		private static readonly IntPtr NativeMethodInfoPtr_InstallResponse_Public_Virtual_New_Void_ClientEventResponse_0;

		// Token: 0x04001125 RID: 4389
		private static readonly IntPtr NativeMethodInfoPtr_UninstallResponse_Public_Void_ClientEventResponseID_0;

		// Token: 0x04001126 RID: 4390
		private static readonly IntPtr NativeMethodInfoPtr_RunClientAction_Public_Command_ClientAction_0;

		// Token: 0x04001127 RID: 4391
		private static readonly IntPtr NativeMethodInfoPtr_SignalTrigger_Public_IEnumerator_ClientTrigger_0;

		// Token: 0x04001128 RID: 4392
		private static readonly IntPtr NativeMethodInfoPtr_signalTrigger_Private_IEnumerator_ClientTrigger_0;

		// Token: 0x04001129 RID: 4393
		private static readonly IntPtr NativeMethodInfoPtr_getTriggeredActions_Private_List_1_ClientAction_ClientTrigger_0;

		// Token: 0x0400112A RID: 4394
		private static readonly IntPtr NativeMethodInfoPtr_resolveActions_Private_IEnumerator_ClientTrigger_List_1_ClientAction_0;

		// Token: 0x0400112B RID: 4395
		private static readonly IntPtr NativeMethodInfoPtr_getClientActionCommand_Protected_Virtual_New_Command_ClientTrigger_ClientAction_0;

		// Token: 0x0400112C RID: 4396
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000356 RID: 854
		[ObfuscatedName("dwd.core.eventTriggers.ClientEventResponder+<resolveActions>d__12")]
		public sealed class _resolveActions_d__12 : global::Il2CppSystem.Object
		{
			// Token: 0x06002715 RID: 10005 RVA: 0x000A63E0 File Offset: 0x000A45E0
			// Note: this type is marked as 'beforefieldinit'.
			static _resolveActions_d__12()
			{
				Il2CppClassPointerStore<ClientEventResponder._resolveActions_d__12>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ClientEventResponder>.NativeClassPtr, "<resolveActions>d__12");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClientEventResponder._resolveActions_d__12>.NativeClassPtr);
				ClientEventResponder._resolveActions_d__12.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientEventResponder._resolveActions_d__12>.NativeClassPtr, "<>1__state");
				ClientEventResponder._resolveActions_d__12.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientEventResponder._resolveActions_d__12>.NativeClassPtr, "<>2__current");
				ClientEventResponder._resolveActions_d__12.NativeFieldInfoPtr_actions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientEventResponder._resolveActions_d__12>.NativeClassPtr, "actions");
				ClientEventResponder._resolveActions_d__12.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientEventResponder._resolveActions_d__12>.NativeClassPtr, "<>4__this");
				ClientEventResponder._resolveActions_d__12.NativeFieldInfoPtr_trigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientEventResponder._resolveActions_d__12>.NativeClassPtr, "trigger");
				ClientEventResponder._resolveActions_d__12.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientEventResponder._resolveActions_d__12>.NativeClassPtr, "<>7__wrap1");
				ClientEventResponder._resolveActions_d__12.NativeFieldInfoPtr__context_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientEventResponder._resolveActions_d__12>.NativeClassPtr, "<context>5__3");
				ClientEventResponder._resolveActions_d__12.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientEventResponder._resolveActions_d__12>.NativeClassPtr, 100667166);
				ClientEventResponder._resolveActions_d__12.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientEventResponder._resolveActions_d__12>.NativeClassPtr, 100667167);
				ClientEventResponder._resolveActions_d__12.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientEventResponder._resolveActions_d__12>.NativeClassPtr, 100667168);
				ClientEventResponder._resolveActions_d__12.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientEventResponder._resolveActions_d__12>.NativeClassPtr, 100667169);
				ClientEventResponder._resolveActions_d__12.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientEventResponder._resolveActions_d__12>.NativeClassPtr, 100667170);
				ClientEventResponder._resolveActions_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientEventResponder._resolveActions_d__12>.NativeClassPtr, 100667171);
				ClientEventResponder._resolveActions_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientEventResponder._resolveActions_d__12>.NativeClassPtr, 100667172);
			}

			// Token: 0x06002716 RID: 10006 RVA: 0x000A6524 File Offset: 0x000A4724
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _resolveActions_d__12(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClientEventResponder._resolveActions_d__12>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientEventResponder._resolveActions_d__12.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002717 RID: 10007 RVA: 0x000A656C File Offset: 0x000A476C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 880259, XrefRangeEnd = 880264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientEventResponder._resolveActions_d__12.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002718 RID: 10008 RVA: 0x000A65A0 File Offset: 0x000A47A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 880264, XrefRangeEnd = 880285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientEventResponder._resolveActions_d__12.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06002719 RID: 10009 RVA: 0x000A65DC File Offset: 0x000A47DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 880285, XrefRangeEnd = 880288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientEventResponder._resolveActions_d__12.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000B0F RID: 2831
			// (get) Token: 0x0600271A RID: 10010 RVA: 0x000A6610 File Offset: 0x000A4810
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientEventResponder._resolveActions_d__12.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600271B RID: 10011 RVA: 0x000A6650 File Offset: 0x000A4850
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 880288, XrefRangeEnd = 880293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientEventResponder._resolveActions_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000B10 RID: 2832
			// (get) Token: 0x0600271C RID: 10012 RVA: 0x000A6684 File Offset: 0x000A4884
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientEventResponder._resolveActions_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600271D RID: 10013 RVA: 0x00011BC7 File Offset: 0x0000FDC7
			public _resolveActions_d__12(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000B08 RID: 2824
			// (get) Token: 0x0600271E RID: 10014 RVA: 0x000A66C4 File Offset: 0x000A48C4
			// (set) Token: 0x0600271F RID: 10015 RVA: 0x00011BD0 File Offset: 0x0000FDD0
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientEventResponder._resolveActions_d__12.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientEventResponder._resolveActions_d__12.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000B09 RID: 2825
			// (get) Token: 0x06002720 RID: 10016 RVA: 0x000A66EC File Offset: 0x000A48EC
			// (set) Token: 0x06002721 RID: 10017 RVA: 0x00011BEB File Offset: 0x0000FDEB
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientEventResponder._resolveActions_d__12.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientEventResponder._resolveActions_d__12.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B0A RID: 2826
			// (get) Token: 0x06002722 RID: 10018 RVA: 0x000A671C File Offset: 0x000A491C
			// (set) Token: 0x06002723 RID: 10019 RVA: 0x00011C0A File Offset: 0x0000FE0A
			public unsafe List<ClientAction> actions
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientEventResponder._resolveActions_d__12.NativeFieldInfoPtr_actions);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ClientAction>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientEventResponder._resolveActions_d__12.NativeFieldInfoPtr_actions), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B0B RID: 2827
			// (get) Token: 0x06002724 RID: 10020 RVA: 0x000A674C File Offset: 0x000A494C
			// (set) Token: 0x06002725 RID: 10021 RVA: 0x00011C29 File Offset: 0x0000FE29
			public unsafe ClientEventResponder __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientEventResponder._resolveActions_d__12.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ClientEventResponder>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientEventResponder._resolveActions_d__12.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B0C RID: 2828
			// (get) Token: 0x06002726 RID: 10022 RVA: 0x000A677C File Offset: 0x000A497C
			// (set) Token: 0x06002727 RID: 10023 RVA: 0x00011C48 File Offset: 0x0000FE48
			public unsafe ClientTrigger trigger
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientEventResponder._resolveActions_d__12.NativeFieldInfoPtr_trigger);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ClientTrigger>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientEventResponder._resolveActions_d__12.NativeFieldInfoPtr_trigger), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B0D RID: 2829
			// (get) Token: 0x06002728 RID: 10024 RVA: 0x000A67AC File Offset: 0x000A49AC
			// (set) Token: 0x06002729 RID: 10025 RVA: 0x00011C67 File Offset: 0x0000FE67
			public List<ClientAction>.Enumerator __7__wrap1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientEventResponder._resolveActions_d__12.NativeFieldInfoPtr___7__wrap1);
					return new List<ClientAction>.Enumerator(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<List<ClientAction>.Enumerator>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientEventResponder._resolveActions_d__12.NativeFieldInfoPtr___7__wrap1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<List<ClientAction>.Enumerator>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000B0E RID: 2830
			// (get) Token: 0x0600272A RID: 10026 RVA: 0x000A67DC File Offset: 0x000A49DC
			// (set) Token: 0x0600272B RID: 10027 RVA: 0x00011C95 File Offset: 0x0000FE95
			public unsafe Command _context_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientEventResponder._resolveActions_d__12.NativeFieldInfoPtr__context_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Command>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientEventResponder._resolveActions_d__12.NativeFieldInfoPtr__context_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001A92 RID: 6802
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001A93 RID: 6803
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001A94 RID: 6804
			private static readonly IntPtr NativeFieldInfoPtr_actions;

			// Token: 0x04001A95 RID: 6805
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001A96 RID: 6806
			private static readonly IntPtr NativeFieldInfoPtr_trigger;

			// Token: 0x04001A97 RID: 6807
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

			// Token: 0x04001A98 RID: 6808
			private static readonly IntPtr NativeFieldInfoPtr__context_5__3;

			// Token: 0x04001A99 RID: 6809
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001A9A RID: 6810
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001A9B RID: 6811
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001A9C RID: 6812
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04001A9D RID: 6813
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001A9E RID: 6814
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001A9F RID: 6815
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000357 RID: 855
		[ObfuscatedName("dwd.core.eventTriggers.ClientEventResponder+<signalTrigger>d__10")]
		public sealed class _signalTrigger_d__10 : global::Il2CppSystem.Object
		{
			// Token: 0x0600272C RID: 10028 RVA: 0x000A680C File Offset: 0x000A4A0C
			// Note: this type is marked as 'beforefieldinit'.
			static _signalTrigger_d__10()
			{
				Il2CppClassPointerStore<ClientEventResponder._signalTrigger_d__10>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ClientEventResponder>.NativeClassPtr, "<signalTrigger>d__10");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClientEventResponder._signalTrigger_d__10>.NativeClassPtr);
				ClientEventResponder._signalTrigger_d__10.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientEventResponder._signalTrigger_d__10>.NativeClassPtr, "<>1__state");
				ClientEventResponder._signalTrigger_d__10.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientEventResponder._signalTrigger_d__10>.NativeClassPtr, "<>2__current");
				ClientEventResponder._signalTrigger_d__10.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientEventResponder._signalTrigger_d__10>.NativeClassPtr, "<>4__this");
				ClientEventResponder._signalTrigger_d__10.NativeFieldInfoPtr_trigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientEventResponder._signalTrigger_d__10>.NativeClassPtr, "trigger");
				ClientEventResponder._signalTrigger_d__10.NativeFieldInfoPtr__context_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientEventResponder._signalTrigger_d__10>.NativeClassPtr, "<context>5__2");
				ClientEventResponder._signalTrigger_d__10.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientEventResponder._signalTrigger_d__10>.NativeClassPtr, 100667173);
				ClientEventResponder._signalTrigger_d__10.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientEventResponder._signalTrigger_d__10>.NativeClassPtr, 100667174);
				ClientEventResponder._signalTrigger_d__10.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientEventResponder._signalTrigger_d__10>.NativeClassPtr, 100667175);
				ClientEventResponder._signalTrigger_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientEventResponder._signalTrigger_d__10>.NativeClassPtr, 100667176);
				ClientEventResponder._signalTrigger_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientEventResponder._signalTrigger_d__10>.NativeClassPtr, 100667177);
				ClientEventResponder._signalTrigger_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientEventResponder._signalTrigger_d__10>.NativeClassPtr, 100667178);
			}

			// Token: 0x0600272D RID: 10029 RVA: 0x000A6914 File Offset: 0x000A4B14
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _signalTrigger_d__10(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClientEventResponder._signalTrigger_d__10>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientEventResponder._signalTrigger_d__10.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600272E RID: 10030 RVA: 0x000A695C File Offset: 0x000A4B5C
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientEventResponder._signalTrigger_d__10.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600272F RID: 10031 RVA: 0x000A6990 File Offset: 0x000A4B90
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 880293, XrefRangeEnd = 880309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientEventResponder._signalTrigger_d__10.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000B16 RID: 2838
			// (get) Token: 0x06002730 RID: 10032 RVA: 0x000A69CC File Offset: 0x000A4BCC
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientEventResponder._signalTrigger_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002731 RID: 10033 RVA: 0x000A6A0C File Offset: 0x000A4C0C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 880309, XrefRangeEnd = 880314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientEventResponder._signalTrigger_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000B17 RID: 2839
			// (get) Token: 0x06002732 RID: 10034 RVA: 0x000A6A40 File Offset: 0x000A4C40
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientEventResponder._signalTrigger_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002733 RID: 10035 RVA: 0x00011CB4 File Offset: 0x0000FEB4
			public _signalTrigger_d__10(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000B11 RID: 2833
			// (get) Token: 0x06002734 RID: 10036 RVA: 0x000A6A80 File Offset: 0x000A4C80
			// (set) Token: 0x06002735 RID: 10037 RVA: 0x00011CBD File Offset: 0x0000FEBD
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientEventResponder._signalTrigger_d__10.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientEventResponder._signalTrigger_d__10.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000B12 RID: 2834
			// (get) Token: 0x06002736 RID: 10038 RVA: 0x000A6AA8 File Offset: 0x000A4CA8
			// (set) Token: 0x06002737 RID: 10039 RVA: 0x00011CD8 File Offset: 0x0000FED8
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientEventResponder._signalTrigger_d__10.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientEventResponder._signalTrigger_d__10.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B13 RID: 2835
			// (get) Token: 0x06002738 RID: 10040 RVA: 0x000A6AD8 File Offset: 0x000A4CD8
			// (set) Token: 0x06002739 RID: 10041 RVA: 0x00011CF7 File Offset: 0x0000FEF7
			public unsafe ClientEventResponder __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientEventResponder._signalTrigger_d__10.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ClientEventResponder>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientEventResponder._signalTrigger_d__10.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B14 RID: 2836
			// (get) Token: 0x0600273A RID: 10042 RVA: 0x000A6B08 File Offset: 0x000A4D08
			// (set) Token: 0x0600273B RID: 10043 RVA: 0x00011D16 File Offset: 0x0000FF16
			public unsafe ClientTrigger trigger
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientEventResponder._signalTrigger_d__10.NativeFieldInfoPtr_trigger);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ClientTrigger>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientEventResponder._signalTrigger_d__10.NativeFieldInfoPtr_trigger), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B15 RID: 2837
			// (get) Token: 0x0600273C RID: 10044 RVA: 0x000A6B38 File Offset: 0x000A4D38
			// (set) Token: 0x0600273D RID: 10045 RVA: 0x00011D35 File Offset: 0x0000FF35
			public unsafe IEnumerator _context_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientEventResponder._signalTrigger_d__10.NativeFieldInfoPtr__context_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientEventResponder._signalTrigger_d__10.NativeFieldInfoPtr__context_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001AA0 RID: 6816
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001AA1 RID: 6817
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001AA2 RID: 6818
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001AA3 RID: 6819
			private static readonly IntPtr NativeFieldInfoPtr_trigger;

			// Token: 0x04001AA4 RID: 6820
			private static readonly IntPtr NativeFieldInfoPtr__context_5__2;

			// Token: 0x04001AA5 RID: 6821
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001AA6 RID: 6822
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001AA7 RID: 6823
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001AA8 RID: 6824
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001AA9 RID: 6825
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001AAA RID: 6826
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
