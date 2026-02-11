using System;
using System.Runtime.InteropServices;
using Canis.actions;
using Canis.events;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Networking.clientevents;

namespace Canis.tutorialScripts
{
	// Token: 0x0200003F RID: 63
	public class TutorialScript : Object
	{
		// Token: 0x060003EA RID: 1002 RVA: 0x00028E6C File Offset: 0x0002706C
		// Note: this type is marked as 'beforefieldinit'.
		static TutorialScript()
		{
			Il2CppClassPointerStore<TutorialScript>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.tutorialScripts", "TutorialScript");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TutorialScript>.NativeClassPtr);
			TutorialScript.NativeFieldInfoPtr_match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialScript>.NativeClassPtr, "match");
			TutorialScript.NativeFieldInfoPtr_counter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialScript>.NativeClassPtr, "counter");
			TutorialScript.NativeMethodInfoPtr__ctor_Protected_Void_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialScript>.NativeClassPtr, 100664129);
			TutorialScript.NativeMethodInfoPtr_innerActions_Protected_Virtual_New_List_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialScript>.NativeClassPtr, 100664130);
			TutorialScript.NativeMethodInfoPtr_GetAction_Public_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialScript>.NativeClassPtr, 100664131);
			TutorialScript.NativeMethodInfoPtr_When_Protected_Action_String_TutorialAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialScript>.NativeClassPtr, 100664132);
			TutorialScript.NativeMethodInfoPtr_When_Protected_Action_String_Il2CppReferenceArray_1_TutorialAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialScript>.NativeClassPtr, 100664133);
			TutorialScript.NativeMethodInfoPtr_When_Protected_Action_String_Il2CppReferenceArray_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialScript>.NativeClassPtr, 100664134);
			TutorialScript.NativeMethodInfoPtr_When_Protected_Action_Event_Il2CppReferenceArray_1_TutorialAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialScript>.NativeClassPtr, 100664135);
			TutorialScript.NativeMethodInfoPtr_InstallTutorialActions_Protected_Action_Event_ClientEvent_ClientEventResponseID_Il2CppReferenceArray_1_TutorialAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialScript>.NativeClassPtr, 100664136);
			TutorialScript.NativeMethodInfoPtr_UninstallTutorialActions_Protected_Action_Event_ClientEventResponseID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialScript>.NativeClassPtr, 100664137);
			TutorialScript.NativeMethodInfoPtr_WhenAndReload_Protected_Action_Event_Il2CppReferenceArray_1_TutorialAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialScript>.NativeClassPtr, 100664138);
			TutorialScript.NativeMethodInfoPtr_When_Protected_Action_Event_Il2CppReferenceArray_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialScript>.NativeClassPtr, 100664139);
			TutorialScript.NativeMethodInfoPtr_WhenAndReload_Protected_Action_String_Il2CppReferenceArray_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialScript>.NativeClassPtr, 100664140);
			TutorialScript.NativeMethodInfoPtr_WhenAndReload_Protected_Action_Event_Il2CppReferenceArray_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialScript>.NativeClassPtr, 100664141);
			TutorialScript.NativeMethodInfoPtr_WhenAndReloadAny_Protected_Action_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialScript>.NativeClassPtr, 100664142);
			TutorialScript.NativeMethodInfoPtr_WhenAndReloadAny_Protected_Action_Event_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialScript>.NativeClassPtr, 100664143);
			TutorialScript.NativeMethodInfoPtr_WhenOnce_Protected_Action_String_TutorialAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialScript>.NativeClassPtr, 100664144);
			TutorialScript.NativeMethodInfoPtr_WhenOnce_Protected_Action_String_Il2CppReferenceArray_1_TutorialAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialScript>.NativeClassPtr, 100664145);
			TutorialScript.NativeMethodInfoPtr_WhenOnce_Protected_Action_String_byref_Int32_Il2CppReferenceArray_1_TutorialAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialScript>.NativeClassPtr, 100664146);
			TutorialScript.NativeMethodInfoPtr_WhenOnce_Protected_Action_Event_Il2CppReferenceArray_1_TutorialAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialScript>.NativeClassPtr, 100664147);
			TutorialScript.NativeMethodInfoPtr_WhenOnce_Protected_Action_Event_byref_Int32_Il2CppReferenceArray_1_TutorialAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialScript>.NativeClassPtr, 100664148);
			TutorialScript.NativeMethodInfoPtr_WhenOnceAny_Protected_Action_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialScript>.NativeClassPtr, 100664149);
			TutorialScript.NativeMethodInfoPtr_WhenOnceAny_Protected_Action_Event_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialScript>.NativeClassPtr, 100664150);
			TutorialScript.NativeMethodInfoPtr_WhenOnceAny_Protected_Action_Event_byref_Int32_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialScript>.NativeClassPtr, 100664151);
			TutorialScript.NativeMethodInfoPtr_AnyToActions_Protected_IEnumerable_1_Action_IEnumerable_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialScript>.NativeClassPtr, 100664152);
			TutorialScript.NativeMethodInfoPtr_WhenOnceAction_Protected_Action_String_Il2CppReferenceArray_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialScript>.NativeClassPtr, 100664153);
			TutorialScript.NativeMethodInfoPtr_WhenOnceAction_Protected_Action_String_byref_Int32_Il2CppReferenceArray_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialScript>.NativeClassPtr, 100664154);
			TutorialScript.NativeMethodInfoPtr_WhenOnceAction_Protected_Action_Event_Il2CppReferenceArray_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialScript>.NativeClassPtr, 100664155);
			TutorialScript.NativeMethodInfoPtr_WhenOnceAction_Protected_Action_Event_byref_Int32_Il2CppReferenceArray_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialScript>.NativeClassPtr, 100664156);
			TutorialScript.NativeMethodInfoPtr_WhenOnceAction_Protected_Action_Event_Func_2_Action_IEnumerable_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialScript>.NativeClassPtr, 100664157);
			TutorialScript.NativeMethodInfoPtr__When_b__6_0_Private_Action_TutorialAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialScript>.NativeClassPtr, 100664158);
			TutorialScript.NativeMethodInfoPtr__When_b__8_0_Private_Action_TutorialAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialScript>.NativeClassPtr, 100664159);
			TutorialScript.NativeMethodInfoPtr__WhenAndReload_b__11_0_Private_Action_TutorialAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialScript>.NativeClassPtr, 100664160);
			TutorialScript.NativeMethodInfoPtr__WhenOnce_b__19_0_Private_Action_TutorialAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialScript>.NativeClassPtr, 100664161);
			TutorialScript.NativeMethodInfoPtr__WhenOnce_b__21_0_Private_Action_TutorialAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialScript>.NativeClassPtr, 100664162);
			TutorialScript.NativeMethodInfoPtr__AnyToActions_b__25_0_Private_Action_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialScript>.NativeClassPtr, 100664163);
		}

		// Token: 0x060003EB RID: 1003 RVA: 0x00029180 File Offset: 0x00027380
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 551953, RefRangeEnd = 551954, XrefRangeStart = 551951, XrefRangeEnd = 551953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TutorialScript(Match match)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TutorialScript>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialScript.NativeMethodInfoPtr__ctor_Protected_Void_Match_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060003EC RID: 1004 RVA: 0x000291CC File Offset: 0x000273CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 551954, XrefRangeEnd = 551960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual List<Canis.actions.Action> innerActions()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TutorialScript.NativeMethodInfoPtr_innerActions_Protected_Virtual_New_List_1_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x060003ED RID: 1005 RVA: 0x00029218 File Offset: 0x00027418
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 551964, RefRangeEnd = 551965, XrefRangeStart = 551960, XrefRangeEnd = 551964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Canis.actions.Action GetAction()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialScript.NativeMethodInfoPtr_GetAction_Public_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr3) : null;
		}

		// Token: 0x060003EE RID: 1006 RVA: 0x00029258 File Offset: 0x00027458
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 551965, XrefRangeEnd = 552020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Canis.actions.Action When(string str, TutorialAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialScript.NativeMethodInfoPtr_When_Protected_Action_String_TutorialAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr3) : null;
		}

		// Token: 0x060003EF RID: 1007 RVA: 0x000292BC File Offset: 0x000274BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 552020, XrefRangeEnd = 552079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Canis.actions.Action When(string str, [Optional] Il2CppReferenceArray<TutorialAction> actions)
		{
			if (actions == null)
			{
				actions = new Il2CppReferenceArray<TutorialAction>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(actions);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialScript.NativeMethodInfoPtr_When_Protected_Action_String_Il2CppReferenceArray_1_TutorialAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr3) : null;
		}

		// Token: 0x060003F0 RID: 1008 RVA: 0x0002932C File Offset: 0x0002752C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 552079, XrefRangeEnd = 552129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Canis.actions.Action When(string str, [Optional] Il2CppReferenceArray<Canis.actions.Action> actions)
		{
			if (actions == null)
			{
				actions = new Il2CppReferenceArray<Canis.actions.Action>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(actions);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialScript.NativeMethodInfoPtr_When_Protected_Action_String_Il2CppReferenceArray_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr3) : null;
		}

		// Token: 0x060003F1 RID: 1009 RVA: 0x0002939C File Offset: 0x0002759C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 552129, XrefRangeEnd = 552184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Canis.actions.Action When(Event evt, [Optional] Il2CppReferenceArray<TutorialAction> actions)
		{
			if (actions == null)
			{
				actions = new Il2CppReferenceArray<TutorialAction>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(actions);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialScript.NativeMethodInfoPtr_When_Protected_Action_Event_Il2CppReferenceArray_1_TutorialAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr3) : null;
		}

		// Token: 0x060003F2 RID: 1010 RVA: 0x0002940C File Offset: 0x0002760C
		[CallerCount(57)]
		[CachedScanResults(RefRangeStart = 552195, RefRangeEnd = 552252, XrefRangeStart = 552184, XrefRangeEnd = 552195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Canis.actions.Action InstallTutorialActions(Event evt, ClientEvent clientEvent, ClientEventResponseID responseID, [Optional] Il2CppReferenceArray<TutorialAction> actions)
		{
			if (actions == null)
			{
				actions = new Il2CppReferenceArray<TutorialAction>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(clientEvent);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(responseID);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(actions);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialScript.NativeMethodInfoPtr_InstallTutorialActions_Protected_Action_Event_ClientEvent_ClientEventResponseID_Il2CppReferenceArray_1_TutorialAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr3) : null;
		}

		// Token: 0x060003F3 RID: 1011 RVA: 0x000294A4 File Offset: 0x000276A4
		[CallerCount(61)]
		[CachedScanResults(RefRangeStart = 552260, RefRangeEnd = 552321, XrefRangeStart = 552252, XrefRangeEnd = 552260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Canis.actions.Action UninstallTutorialActions(Event evt, ClientEventResponseID responseID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(responseID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialScript.NativeMethodInfoPtr_UninstallTutorialActions_Protected_Action_Event_ClientEventResponseID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr3) : null;
		}

		// Token: 0x060003F4 RID: 1012 RVA: 0x00029508 File Offset: 0x00027708
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 552341, RefRangeEnd = 552342, XrefRangeStart = 552321, XrefRangeEnd = 552341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Canis.actions.Action WhenAndReload(Event evt, [Optional] Il2CppReferenceArray<TutorialAction> actions)
		{
			if (actions == null)
			{
				actions = new Il2CppReferenceArray<TutorialAction>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(actions);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialScript.NativeMethodInfoPtr_WhenAndReload_Protected_Action_Event_Il2CppReferenceArray_1_TutorialAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr3) : null;
		}

		// Token: 0x060003F5 RID: 1013 RVA: 0x00029578 File Offset: 0x00027778
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 552342, XrefRangeEnd = 552388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Canis.actions.Action When(Event evt, [Optional] Il2CppReferenceArray<Canis.actions.Action> actions)
		{
			if (actions == null)
			{
				actions = new Il2CppReferenceArray<Canis.actions.Action>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(actions);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialScript.NativeMethodInfoPtr_When_Protected_Action_Event_Il2CppReferenceArray_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr3) : null;
		}

		// Token: 0x060003F6 RID: 1014 RVA: 0x000295E8 File Offset: 0x000277E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 552388, XrefRangeEnd = 552400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Canis.actions.Action WhenAndReload(string str, [Optional] Il2CppReferenceArray<Canis.actions.Action> actions)
		{
			if (actions == null)
			{
				actions = new Il2CppReferenceArray<Canis.actions.Action>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(actions);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialScript.NativeMethodInfoPtr_WhenAndReload_Protected_Action_String_Il2CppReferenceArray_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr3) : null;
		}

		// Token: 0x060003F7 RID: 1015 RVA: 0x00029658 File Offset: 0x00027858
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 552408, RefRangeEnd = 552420, XrefRangeStart = 552400, XrefRangeEnd = 552408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Canis.actions.Action WhenAndReload(Event evt, [Optional] Il2CppReferenceArray<Canis.actions.Action> actions)
		{
			if (actions == null)
			{
				actions = new Il2CppReferenceArray<Canis.actions.Action>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(actions);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialScript.NativeMethodInfoPtr_WhenAndReload_Protected_Action_Event_Il2CppReferenceArray_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr3) : null;
		}

		// Token: 0x060003F8 RID: 1016 RVA: 0x000296C8 File Offset: 0x000278C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 552420, XrefRangeEnd = 552436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Canis.actions.Action WhenAndReloadAny(string str, [Optional] Il2CppReferenceArray<Object> actions)
		{
			if (actions == null)
			{
				actions = new Il2CppReferenceArray<Object>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(actions);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialScript.NativeMethodInfoPtr_WhenAndReloadAny_Protected_Action_String_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr3) : null;
		}

		// Token: 0x060003F9 RID: 1017 RVA: 0x00029738 File Offset: 0x00027938
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 552448, RefRangeEnd = 552449, XrefRangeStart = 552436, XrefRangeEnd = 552448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Canis.actions.Action WhenAndReloadAny(Event evt, [Optional] Il2CppReferenceArray<Object> actions)
		{
			if (actions == null)
			{
				actions = new Il2CppReferenceArray<Object>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(actions);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialScript.NativeMethodInfoPtr_WhenAndReloadAny_Protected_Action_Event_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr3) : null;
		}

		// Token: 0x060003FA RID: 1018 RVA: 0x000297A8 File Offset: 0x000279A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 552449, XrefRangeEnd = 552501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Canis.actions.Action WhenOnce(string str, TutorialAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialScript.NativeMethodInfoPtr_WhenOnce_Protected_Action_String_TutorialAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr3) : null;
		}

		// Token: 0x060003FB RID: 1019 RVA: 0x0002980C File Offset: 0x00027A0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 552501, XrefRangeEnd = 552502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Canis.actions.Action WhenOnce(string str, [Optional] Il2CppReferenceArray<TutorialAction> actions)
		{
			if (actions == null)
			{
				actions = new Il2CppReferenceArray<TutorialAction>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(actions);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialScript.NativeMethodInfoPtr_WhenOnce_Protected_Action_String_Il2CppReferenceArray_1_TutorialAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr3) : null;
		}

		// Token: 0x060003FC RID: 1020 RVA: 0x0002987C File Offset: 0x00027A7C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 552558, RefRangeEnd = 552559, XrefRangeStart = 552502, XrefRangeEnd = 552558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Canis.actions.Action WhenOnce(string str, out int id, [Optional] Il2CppReferenceArray<TutorialAction> actions)
		{
			if (actions == null)
			{
				actions = new Il2CppReferenceArray<TutorialAction>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &id;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(actions);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialScript.NativeMethodInfoPtr_WhenOnce_Protected_Action_String_byref_Int32_Il2CppReferenceArray_1_TutorialAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr3) : null;
		}

		// Token: 0x060003FD RID: 1021 RVA: 0x000298FC File Offset: 0x00027AFC
		[CallerCount(22)]
		[CachedScanResults(RefRangeStart = 552560, RefRangeEnd = 552582, XrefRangeStart = 552559, XrefRangeEnd = 552560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Canis.actions.Action WhenOnce(Event evt, [Optional] Il2CppReferenceArray<TutorialAction> actions)
		{
			if (actions == null)
			{
				actions = new Il2CppReferenceArray<TutorialAction>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(actions);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialScript.NativeMethodInfoPtr_WhenOnce_Protected_Action_Event_Il2CppReferenceArray_1_TutorialAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr3) : null;
		}

		// Token: 0x060003FE RID: 1022 RVA: 0x0002996C File Offset: 0x00027B6C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 552634, RefRangeEnd = 552635, XrefRangeStart = 552582, XrefRangeEnd = 552634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Canis.actions.Action WhenOnce(Event evt, out int id, [Optional] Il2CppReferenceArray<TutorialAction> actions)
		{
			if (actions == null)
			{
				actions = new Il2CppReferenceArray<TutorialAction>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &id;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(actions);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialScript.NativeMethodInfoPtr_WhenOnce_Protected_Action_Event_byref_Int32_Il2CppReferenceArray_1_TutorialAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr3) : null;
		}

		// Token: 0x060003FF RID: 1023 RVA: 0x000299EC File Offset: 0x00027BEC
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 552640, RefRangeEnd = 552648, XrefRangeStart = 552635, XrefRangeEnd = 552640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Canis.actions.Action WhenOnceAny(string str, [Optional] Il2CppReferenceArray<Object> actions)
		{
			if (actions == null)
			{
				actions = new Il2CppReferenceArray<Object>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(actions);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialScript.NativeMethodInfoPtr_WhenOnceAny_Protected_Action_String_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr3) : null;
		}

		// Token: 0x06000400 RID: 1024 RVA: 0x00029A5C File Offset: 0x00027C5C
		[CallerCount(79)]
		[CachedScanResults(RefRangeStart = 552649, RefRangeEnd = 552728, XrefRangeStart = 552648, XrefRangeEnd = 552649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Canis.actions.Action WhenOnceAny(Event evt, [Optional] Il2CppReferenceArray<Object> actions)
		{
			if (actions == null)
			{
				actions = new Il2CppReferenceArray<Object>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(actions);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialScript.NativeMethodInfoPtr_WhenOnceAny_Protected_Action_Event_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr3) : null;
		}

		// Token: 0x06000401 RID: 1025 RVA: 0x00029ACC File Offset: 0x00027CCC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 552772, RefRangeEnd = 552774, XrefRangeStart = 552728, XrefRangeEnd = 552772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Canis.actions.Action WhenOnceAny(Event evt, out int id, [Optional] Il2CppReferenceArray<Object> actions)
		{
			if (actions == null)
			{
				actions = new Il2CppReferenceArray<Object>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &id;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(actions);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialScript.NativeMethodInfoPtr_WhenOnceAny_Protected_Action_Event_byref_Int32_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr3) : null;
		}

		// Token: 0x06000402 RID: 1026 RVA: 0x00029B4C File Offset: 0x00027D4C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 552783, RefRangeEnd = 552786, XrefRangeStart = 552774, XrefRangeEnd = 552783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<Canis.actions.Action> AnyToActions(IEnumerable<Object> actions)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(actions);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialScript.NativeMethodInfoPtr_AnyToActions_Protected_IEnumerable_1_Action_IEnumerable_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Canis.actions.Action>>(intPtr3) : null;
			}
		}

		// Token: 0x06000403 RID: 1027 RVA: 0x00029B9C File Offset: 0x00027D9C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 552787, RefRangeEnd = 552788, XrefRangeStart = 552786, XrefRangeEnd = 552787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Canis.actions.Action WhenOnceAction(string str, [Optional] Il2CppReferenceArray<Canis.actions.Action> actions)
		{
			if (actions == null)
			{
				actions = new Il2CppReferenceArray<Canis.actions.Action>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(actions);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialScript.NativeMethodInfoPtr_WhenOnceAction_Protected_Action_String_Il2CppReferenceArray_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr3) : null;
		}

		// Token: 0x06000404 RID: 1028 RVA: 0x00029C0C File Offset: 0x00027E0C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 552835, RefRangeEnd = 552836, XrefRangeStart = 552788, XrefRangeEnd = 552835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Canis.actions.Action WhenOnceAction(string str, out int id, [Optional] Il2CppReferenceArray<Canis.actions.Action> actions)
		{
			if (actions == null)
			{
				actions = new Il2CppReferenceArray<Canis.actions.Action>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &id;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(actions);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialScript.NativeMethodInfoPtr_WhenOnceAction_Protected_Action_String_byref_Int32_Il2CppReferenceArray_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr3) : null;
		}

		// Token: 0x06000405 RID: 1029 RVA: 0x00029C8C File Offset: 0x00027E8C
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 552837, RefRangeEnd = 552848, XrefRangeStart = 552836, XrefRangeEnd = 552837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Canis.actions.Action WhenOnceAction(Event evt, [Optional] Il2CppReferenceArray<Canis.actions.Action> actions)
		{
			if (actions == null)
			{
				actions = new Il2CppReferenceArray<Canis.actions.Action>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(actions);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialScript.NativeMethodInfoPtr_WhenOnceAction_Protected_Action_Event_Il2CppReferenceArray_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr3) : null;
		}

		// Token: 0x06000406 RID: 1030 RVA: 0x00029CFC File Offset: 0x00027EFC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 552888, RefRangeEnd = 552889, XrefRangeStart = 552848, XrefRangeEnd = 552888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Canis.actions.Action WhenOnceAction(Event evt, out int id, [Optional] Il2CppReferenceArray<Canis.actions.Action> actions)
		{
			if (actions == null)
			{
				actions = new Il2CppReferenceArray<Canis.actions.Action>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &id;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(actions);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialScript.NativeMethodInfoPtr_WhenOnceAction_Protected_Action_Event_byref_Int32_Il2CppReferenceArray_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr3) : null;
		}

		// Token: 0x06000407 RID: 1031 RVA: 0x00029D7C File Offset: 0x00027F7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 552889, XrefRangeEnd = 552926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Canis.actions.Action WhenOnceAction(Event evt, Func<Canis.actions.Action, IEnumerable<Canis.actions.Action>> actionGenerator)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(actionGenerator);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialScript.NativeMethodInfoPtr_WhenOnceAction_Protected_Action_Event_Func_2_Action_IEnumerable_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr3) : null;
		}

		// Token: 0x06000408 RID: 1032 RVA: 0x00029DE0 File Offset: 0x00027FE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 552926, XrefRangeEnd = 552930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Canis.actions.Action _When_b__6_0(TutorialAction a)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialScript.NativeMethodInfoPtr__When_b__6_0_Private_Action_TutorialAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr3) : null;
			}
		}

		// Token: 0x06000409 RID: 1033 RVA: 0x00029E30 File Offset: 0x00028030
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 552930, XrefRangeEnd = 552934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Canis.actions.Action _When_b__8_0(TutorialAction a)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialScript.NativeMethodInfoPtr__When_b__8_0_Private_Action_TutorialAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr3) : null;
			}
		}

		// Token: 0x0600040A RID: 1034 RVA: 0x00029E80 File Offset: 0x00028080
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 552934, XrefRangeEnd = 552938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Canis.actions.Action _WhenAndReload_b__11_0(TutorialAction a)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialScript.NativeMethodInfoPtr__WhenAndReload_b__11_0_Private_Action_TutorialAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr3) : null;
			}
		}

		// Token: 0x0600040B RID: 1035 RVA: 0x00029ED0 File Offset: 0x000280D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 552938, XrefRangeEnd = 552942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Canis.actions.Action _WhenOnce_b__19_0(TutorialAction a)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialScript.NativeMethodInfoPtr__WhenOnce_b__19_0_Private_Action_TutorialAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr3) : null;
			}
		}

		// Token: 0x0600040C RID: 1036 RVA: 0x00029F20 File Offset: 0x00028120
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 552942, XrefRangeEnd = 552946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Canis.actions.Action _WhenOnce_b__21_0(TutorialAction a)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialScript.NativeMethodInfoPtr__WhenOnce_b__21_0_Private_Action_TutorialAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr3) : null;
			}
		}

		// Token: 0x0600040D RID: 1037 RVA: 0x00029F70 File Offset: 0x00028170
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 552946, XrefRangeEnd = 552956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Canis.actions.Action _AnyToActions_b__25_0(Object a)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialScript.NativeMethodInfoPtr__AnyToActions_b__25_0_Private_Action_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr3) : null;
			}
		}

		// Token: 0x0600040E RID: 1038 RVA: 0x00003B0A File Offset: 0x00001D0A
		public Canis.actions.Action When(string str, params TutorialAction[] actions)
		{
			return this.When(str, new Il2CppReferenceArray<TutorialAction>(actions));
		}

		// Token: 0x0600040F RID: 1039 RVA: 0x00003B19 File Offset: 0x00001D19
		public Canis.actions.Action When(string str, params Canis.actions.Action[] actions)
		{
			return this.When(str, new Il2CppReferenceArray<Canis.actions.Action>(actions));
		}

		// Token: 0x06000410 RID: 1040 RVA: 0x00003B28 File Offset: 0x00001D28
		public Canis.actions.Action When(Event evt, params TutorialAction[] actions)
		{
			return this.When(evt, new Il2CppReferenceArray<TutorialAction>(actions));
		}

		// Token: 0x06000411 RID: 1041 RVA: 0x00003B37 File Offset: 0x00001D37
		public Canis.actions.Action InstallTutorialActions(Event evt, ClientEvent clientEvent, ClientEventResponseID responseID, params TutorialAction[] actions)
		{
			return this.InstallTutorialActions(evt, clientEvent, responseID, new Il2CppReferenceArray<TutorialAction>(actions));
		}

		// Token: 0x06000412 RID: 1042 RVA: 0x00003B49 File Offset: 0x00001D49
		public Canis.actions.Action WhenAndReload(Event evt, params TutorialAction[] actions)
		{
			return this.WhenAndReload(evt, new Il2CppReferenceArray<TutorialAction>(actions));
		}

		// Token: 0x06000413 RID: 1043 RVA: 0x00003B58 File Offset: 0x00001D58
		public Canis.actions.Action When(Event evt, params Canis.actions.Action[] actions)
		{
			return this.When(evt, new Il2CppReferenceArray<Canis.actions.Action>(actions));
		}

		// Token: 0x06000414 RID: 1044 RVA: 0x00003B67 File Offset: 0x00001D67
		public Canis.actions.Action WhenAndReload(string str, params Canis.actions.Action[] actions)
		{
			return this.WhenAndReload(str, new Il2CppReferenceArray<Canis.actions.Action>(actions));
		}

		// Token: 0x06000415 RID: 1045 RVA: 0x00003B76 File Offset: 0x00001D76
		public Canis.actions.Action WhenAndReload(Event evt, params Canis.actions.Action[] actions)
		{
			return this.WhenAndReload(evt, new Il2CppReferenceArray<Canis.actions.Action>(actions));
		}

		// Token: 0x06000416 RID: 1046 RVA: 0x00003B85 File Offset: 0x00001D85
		public Canis.actions.Action WhenAndReloadAny(string str, params Object[] actions)
		{
			return this.WhenAndReloadAny(str, new Il2CppReferenceArray<Object>(actions));
		}

		// Token: 0x06000417 RID: 1047 RVA: 0x00003B94 File Offset: 0x00001D94
		public Canis.actions.Action WhenAndReloadAny(Event evt, params Object[] actions)
		{
			return this.WhenAndReloadAny(evt, new Il2CppReferenceArray<Object>(actions));
		}

		// Token: 0x06000418 RID: 1048 RVA: 0x00003BA3 File Offset: 0x00001DA3
		public Canis.actions.Action WhenOnce(string str, params TutorialAction[] actions)
		{
			return this.WhenOnce(str, new Il2CppReferenceArray<TutorialAction>(actions));
		}

		// Token: 0x06000419 RID: 1049 RVA: 0x00003BB2 File Offset: 0x00001DB2
		public Canis.actions.Action WhenOnce(string str, out int id, params TutorialAction[] actions)
		{
			return this.WhenOnce(str, out id, new Il2CppReferenceArray<TutorialAction>(actions));
		}

		// Token: 0x0600041A RID: 1050 RVA: 0x00003BC2 File Offset: 0x00001DC2
		public Canis.actions.Action WhenOnce(Event evt, params TutorialAction[] actions)
		{
			return this.WhenOnce(evt, new Il2CppReferenceArray<TutorialAction>(actions));
		}

		// Token: 0x0600041B RID: 1051 RVA: 0x00003BD1 File Offset: 0x00001DD1
		public Canis.actions.Action WhenOnce(Event evt, out int id, params TutorialAction[] actions)
		{
			return this.WhenOnce(evt, out id, new Il2CppReferenceArray<TutorialAction>(actions));
		}

		// Token: 0x0600041C RID: 1052 RVA: 0x00003BE1 File Offset: 0x00001DE1
		public Canis.actions.Action WhenOnceAny(string str, params Object[] actions)
		{
			return this.WhenOnceAny(str, new Il2CppReferenceArray<Object>(actions));
		}

		// Token: 0x0600041D RID: 1053 RVA: 0x00003BF0 File Offset: 0x00001DF0
		public Canis.actions.Action WhenOnceAny(Event evt, params Object[] actions)
		{
			return this.WhenOnceAny(evt, new Il2CppReferenceArray<Object>(actions));
		}

		// Token: 0x0600041E RID: 1054 RVA: 0x00003BFF File Offset: 0x00001DFF
		public Canis.actions.Action WhenOnceAny(Event evt, out int id, params Object[] actions)
		{
			return this.WhenOnceAny(evt, out id, new Il2CppReferenceArray<Object>(actions));
		}

		// Token: 0x0600041F RID: 1055 RVA: 0x00003C0F File Offset: 0x00001E0F
		public Canis.actions.Action WhenOnceAction(string str, params Canis.actions.Action[] actions)
		{
			return this.WhenOnceAction(str, new Il2CppReferenceArray<Canis.actions.Action>(actions));
		}

		// Token: 0x06000420 RID: 1056 RVA: 0x00003C1E File Offset: 0x00001E1E
		public Canis.actions.Action WhenOnceAction(string str, out int id, params Canis.actions.Action[] actions)
		{
			return this.WhenOnceAction(str, out id, new Il2CppReferenceArray<Canis.actions.Action>(actions));
		}

		// Token: 0x06000421 RID: 1057 RVA: 0x00003C2E File Offset: 0x00001E2E
		public Canis.actions.Action WhenOnceAction(Event evt, params Canis.actions.Action[] actions)
		{
			return this.WhenOnceAction(evt, new Il2CppReferenceArray<Canis.actions.Action>(actions));
		}

		// Token: 0x06000422 RID: 1058 RVA: 0x00003C3D File Offset: 0x00001E3D
		public Canis.actions.Action WhenOnceAction(Event evt, out int id, params Canis.actions.Action[] actions)
		{
			return this.WhenOnceAction(evt, out id, new Il2CppReferenceArray<Canis.actions.Action>(actions));
		}

		// Token: 0x06000423 RID: 1059 RVA: 0x00003C4D File Offset: 0x00001E4D
		public TutorialScript(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000115 RID: 277
		// (get) Token: 0x06000424 RID: 1060 RVA: 0x00029FC0 File Offset: 0x000281C0
		// (set) Token: 0x06000425 RID: 1061 RVA: 0x00003C56 File Offset: 0x00001E56
		public unsafe Match match
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialScript.NativeFieldInfoPtr_match);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Match>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialScript.NativeFieldInfoPtr_match), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000116 RID: 278
		// (get) Token: 0x06000426 RID: 1062 RVA: 0x00029FF0 File Offset: 0x000281F0
		// (set) Token: 0x06000427 RID: 1063 RVA: 0x00003C75 File Offset: 0x00001E75
		public unsafe int counter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialScript.NativeFieldInfoPtr_counter);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialScript.NativeFieldInfoPtr_counter)) = value;
			}
		}

		// Token: 0x04000291 RID: 657
		private static readonly IntPtr NativeFieldInfoPtr_match;

		// Token: 0x04000292 RID: 658
		private static readonly IntPtr NativeFieldInfoPtr_counter;

		// Token: 0x04000293 RID: 659
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_Match_0;

		// Token: 0x04000294 RID: 660
		private static readonly IntPtr NativeMethodInfoPtr_innerActions_Protected_Virtual_New_List_1_Action_0;

		// Token: 0x04000295 RID: 661
		private static readonly IntPtr NativeMethodInfoPtr_GetAction_Public_Action_0;

		// Token: 0x04000296 RID: 662
		private static readonly IntPtr NativeMethodInfoPtr_When_Protected_Action_String_TutorialAction_0;

		// Token: 0x04000297 RID: 663
		private static readonly IntPtr NativeMethodInfoPtr_When_Protected_Action_String_Il2CppReferenceArray_1_TutorialAction_0;

		// Token: 0x04000298 RID: 664
		private static readonly IntPtr NativeMethodInfoPtr_When_Protected_Action_String_Il2CppReferenceArray_1_Action_0;

		// Token: 0x04000299 RID: 665
		private static readonly IntPtr NativeMethodInfoPtr_When_Protected_Action_Event_Il2CppReferenceArray_1_TutorialAction_0;

		// Token: 0x0400029A RID: 666
		private static readonly IntPtr NativeMethodInfoPtr_InstallTutorialActions_Protected_Action_Event_ClientEvent_ClientEventResponseID_Il2CppReferenceArray_1_TutorialAction_0;

		// Token: 0x0400029B RID: 667
		private static readonly IntPtr NativeMethodInfoPtr_UninstallTutorialActions_Protected_Action_Event_ClientEventResponseID_0;

		// Token: 0x0400029C RID: 668
		private static readonly IntPtr NativeMethodInfoPtr_WhenAndReload_Protected_Action_Event_Il2CppReferenceArray_1_TutorialAction_0;

		// Token: 0x0400029D RID: 669
		private static readonly IntPtr NativeMethodInfoPtr_When_Protected_Action_Event_Il2CppReferenceArray_1_Action_0;

		// Token: 0x0400029E RID: 670
		private static readonly IntPtr NativeMethodInfoPtr_WhenAndReload_Protected_Action_String_Il2CppReferenceArray_1_Action_0;

		// Token: 0x0400029F RID: 671
		private static readonly IntPtr NativeMethodInfoPtr_WhenAndReload_Protected_Action_Event_Il2CppReferenceArray_1_Action_0;

		// Token: 0x040002A0 RID: 672
		private static readonly IntPtr NativeMethodInfoPtr_WhenAndReloadAny_Protected_Action_String_Il2CppReferenceArray_1_Object_0;

		// Token: 0x040002A1 RID: 673
		private static readonly IntPtr NativeMethodInfoPtr_WhenAndReloadAny_Protected_Action_Event_Il2CppReferenceArray_1_Object_0;

		// Token: 0x040002A2 RID: 674
		private static readonly IntPtr NativeMethodInfoPtr_WhenOnce_Protected_Action_String_TutorialAction_0;

		// Token: 0x040002A3 RID: 675
		private static readonly IntPtr NativeMethodInfoPtr_WhenOnce_Protected_Action_String_Il2CppReferenceArray_1_TutorialAction_0;

		// Token: 0x040002A4 RID: 676
		private static readonly IntPtr NativeMethodInfoPtr_WhenOnce_Protected_Action_String_byref_Int32_Il2CppReferenceArray_1_TutorialAction_0;

		// Token: 0x040002A5 RID: 677
		private static readonly IntPtr NativeMethodInfoPtr_WhenOnce_Protected_Action_Event_Il2CppReferenceArray_1_TutorialAction_0;

		// Token: 0x040002A6 RID: 678
		private static readonly IntPtr NativeMethodInfoPtr_WhenOnce_Protected_Action_Event_byref_Int32_Il2CppReferenceArray_1_TutorialAction_0;

		// Token: 0x040002A7 RID: 679
		private static readonly IntPtr NativeMethodInfoPtr_WhenOnceAny_Protected_Action_String_Il2CppReferenceArray_1_Object_0;

		// Token: 0x040002A8 RID: 680
		private static readonly IntPtr NativeMethodInfoPtr_WhenOnceAny_Protected_Action_Event_Il2CppReferenceArray_1_Object_0;

		// Token: 0x040002A9 RID: 681
		private static readonly IntPtr NativeMethodInfoPtr_WhenOnceAny_Protected_Action_Event_byref_Int32_Il2CppReferenceArray_1_Object_0;

		// Token: 0x040002AA RID: 682
		private static readonly IntPtr NativeMethodInfoPtr_AnyToActions_Protected_IEnumerable_1_Action_IEnumerable_1_Object_0;

		// Token: 0x040002AB RID: 683
		private static readonly IntPtr NativeMethodInfoPtr_WhenOnceAction_Protected_Action_String_Il2CppReferenceArray_1_Action_0;

		// Token: 0x040002AC RID: 684
		private static readonly IntPtr NativeMethodInfoPtr_WhenOnceAction_Protected_Action_String_byref_Int32_Il2CppReferenceArray_1_Action_0;

		// Token: 0x040002AD RID: 685
		private static readonly IntPtr NativeMethodInfoPtr_WhenOnceAction_Protected_Action_Event_Il2CppReferenceArray_1_Action_0;

		// Token: 0x040002AE RID: 686
		private static readonly IntPtr NativeMethodInfoPtr_WhenOnceAction_Protected_Action_Event_byref_Int32_Il2CppReferenceArray_1_Action_0;

		// Token: 0x040002AF RID: 687
		private static readonly IntPtr NativeMethodInfoPtr_WhenOnceAction_Protected_Action_Event_Func_2_Action_IEnumerable_1_Action_0;

		// Token: 0x040002B0 RID: 688
		private static readonly IntPtr NativeMethodInfoPtr__When_b__6_0_Private_Action_TutorialAction_0;

		// Token: 0x040002B1 RID: 689
		private static readonly IntPtr NativeMethodInfoPtr__When_b__8_0_Private_Action_TutorialAction_0;

		// Token: 0x040002B2 RID: 690
		private static readonly IntPtr NativeMethodInfoPtr__WhenAndReload_b__11_0_Private_Action_TutorialAction_0;

		// Token: 0x040002B3 RID: 691
		private static readonly IntPtr NativeMethodInfoPtr__WhenOnce_b__19_0_Private_Action_TutorialAction_0;

		// Token: 0x040002B4 RID: 692
		private static readonly IntPtr NativeMethodInfoPtr__WhenOnce_b__21_0_Private_Action_TutorialAction_0;

		// Token: 0x040002B5 RID: 693
		private static readonly IntPtr NativeMethodInfoPtr__AnyToActions_b__25_0_Private_Action_Object_0;
	}
}
