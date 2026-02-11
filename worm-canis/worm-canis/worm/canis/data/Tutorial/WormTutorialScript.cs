using System;
using System.Runtime.InteropServices;
using Canis.actions;
using Canis.context;
using Canis.events;
using Canis.tutorialScripts;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Networking.clientevents;
using worm.canis.entities;
using worm.canis.selectionfilters;

namespace worm.canis.data.Tutorial
{
	// Token: 0x02000047 RID: 71
	public class WormTutorialScript : GenericTutorialScript<WormTutorialAction>
	{
		// Token: 0x06000A3C RID: 2620 RVA: 0x00087E3C File Offset: 0x0008603C
		// Note: this type is marked as 'beforefieldinit'.
		static WormTutorialScript()
		{
			Il2CppClassPointerStore<WormTutorialScript>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.data.Tutorial", "WormTutorialScript");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormTutorialScript>.NativeClassPtr);
			WormTutorialScript.NativeFieldInfoPtr_wormMatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialScript>.NativeClassPtr, "wormMatch");
			WormTutorialScript.NativeFieldInfoPtr_selectionFiltering = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialScript>.NativeClassPtr, "selectionFiltering");
			WormTutorialScript.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript>.NativeClassPtr, 100664766);
			WormTutorialScript.NativeMethodInfoPtr_OnTurn_Protected_Func_2_Context_Boolean_WormPlayer_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript>.NativeClassPtr, 100664767);
			WormTutorialScript.NativeMethodInfoPtr_AfterTurn_Protected_Func_2_Context_Boolean_WormPlayer_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript>.NativeClassPtr, 100664768);
			WormTutorialScript.NativeMethodInfoPtr_BeforeTurn_Protected_Func_2_Context_Boolean_WormPlayer_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript>.NativeClassPtr, 100664769);
			WormTutorialScript.NativeMethodInfoPtr_Message_Protected_WormTutorialAction_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript>.NativeClassPtr, 100664770);
			WormTutorialScript.NativeMethodInfoPtr_Recurring_Protected_WormTutorialAction_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript>.NativeClassPtr, 100664771);
			WormTutorialScript.NativeMethodInfoPtr_ArrowWithLabel_Protected_WormTutorialAction_Int32_String_String_byref_WormTutorialAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript>.NativeClassPtr, 100664772);
			WormTutorialScript.NativeMethodInfoPtr_PaulSay_Protected_WormTutorialAction_String_Int32_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript>.NativeClassPtr, 100664773);
			WormTutorialScript.NativeMethodInfoPtr_LetoSay_Protected_WormTutorialAction_String_Int32_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript>.NativeClassPtr, 100664774);
			WormTutorialScript.NativeMethodInfoPtr_GurneySay_Protected_WormTutorialAction_String_Int32_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript>.NativeClassPtr, 100664775);
			WormTutorialScript.NativeMethodInfoPtr_RabbanSay_Protected_WormTutorialAction_String_Int32_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript>.NativeClassPtr, 100664776);
			WormTutorialScript.NativeMethodInfoPtr_ThufirSay_Protected_WormTutorialAction_String_Int32_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript>.NativeClassPtr, 100664777);
			WormTutorialScript.NativeMethodInfoPtr_DuncanSay_Protected_WormTutorialAction_String_Int32_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript>.NativeClassPtr, 100664778);
			WormTutorialScript.NativeMethodInfoPtr_ArianaSay_Protected_WormTutorialAction_String_Int32_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript>.NativeClassPtr, 100664779);
			WormTutorialScript.NativeMethodInfoPtr_StilgarSay_Protected_WormTutorialAction_String_Int32_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript>.NativeClassPtr, 100664780);
			WormTutorialScript.NativeMethodInfoPtr_ArmandSay_Protected_WormTutorialAction_String_Int32_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript>.NativeClassPtr, 100664781);
			WormTutorialScript.NativeMethodInfoPtr_IlbanSay_Protected_WormTutorialAction_String_Int32_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript>.NativeClassPtr, 100664782);
			WormTutorialScript.NativeMethodInfoPtr_evtDuring_Protected_Event_String_WormPlayer_Nullable_1_Int32_Nullable_1_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript>.NativeClassPtr, 100664783);
			WormTutorialScript.NativeMethodInfoPtr_evtAfter_Protected_Event_String_WormPlayer_Nullable_1_Int32_Nullable_1_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript>.NativeClassPtr, 100664784);
			WormTutorialScript.NativeMethodInfoPtr_evtBefore_Protected_Event_String_WormPlayer_Nullable_1_Int32_Nullable_1_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript>.NativeClassPtr, 100664785);
			WormTutorialScript.NativeMethodInfoPtr_ShowCard_Protected_WormTutorialAction_Int32_String_String_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript>.NativeClassPtr, 100664786);
			WormTutorialScript.NativeMethodInfoPtr_HideElement_Protected_Action_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript>.NativeClassPtr, 100664787);
			WormTutorialScript.NativeMethodInfoPtr_UnHideElement_Protected_Action_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript>.NativeClassPtr, 100664788);
			WormTutorialScript.NativeMethodInfoPtr_ClearDisplayActions_Protected_Action_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript>.NativeClassPtr, 100664789);
			WormTutorialScript.NativeMethodInfoPtr_ReEnableDisplayActionClearOnSave_Protected_Action_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript>.NativeClassPtr, 100664790);
			WormTutorialScript.NativeMethodInfoPtr_InstallTutorialActionsOnce_Public_Action_Event_ClientEvent_ClientEventResponseID_Il2CppReferenceArray_1_TutorialAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript>.NativeClassPtr, 100664791);
		}

		// Token: 0x06000A3D RID: 2621 RVA: 0x0008809C File Offset: 0x0008629C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 52402, RefRangeEnd = 52407, XrefRangeStart = 52380, XrefRangeEnd = 52402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormTutorialScript(WormMatch m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormTutorialScript>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A3E RID: 2622 RVA: 0x000880E8 File Offset: 0x000862E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52407, XrefRangeEnd = 52419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Func<Context, bool> OnTurn(WormPlayer player, int round, int turn, bool checkPlayer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref round;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref turn;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref checkPlayer;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript.NativeMethodInfoPtr_OnTurn_Protected_Func_2_Context_Boolean_WormPlayer_Int32_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Func<Context, bool>>(intPtr3) : null;
		}

		// Token: 0x06000A3F RID: 2623 RVA: 0x00088164 File Offset: 0x00086364
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52419, XrefRangeEnd = 52431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Func<Context, bool> AfterTurn(WormPlayer player, int round, int turn, bool checkPlayer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref round;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref turn;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref checkPlayer;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript.NativeMethodInfoPtr_AfterTurn_Protected_Func_2_Context_Boolean_WormPlayer_Int32_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Func<Context, bool>>(intPtr3) : null;
		}

		// Token: 0x06000A40 RID: 2624 RVA: 0x000881E0 File Offset: 0x000863E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52431, XrefRangeEnd = 52443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Func<Context, bool> BeforeTurn(WormPlayer player, int round, int turn, bool checkPlayer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref round;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref turn;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref checkPlayer;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript.NativeMethodInfoPtr_BeforeTurn_Protected_Func_2_Context_Boolean_WormPlayer_Int32_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Func<Context, bool>>(intPtr3) : null;
		}

		// Token: 0x06000A41 RID: 2625 RVA: 0x0008825C File Offset: 0x0008645C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 52448, RefRangeEnd = 52454, XrefRangeStart = 52443, XrefRangeEnd = 52448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormTutorialAction Message(string text)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript.NativeMethodInfoPtr_Message_Protected_WormTutorialAction_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WormTutorialAction>(intPtr3) : null;
			}
		}

		// Token: 0x06000A42 RID: 2626 RVA: 0x000882AC File Offset: 0x000864AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52454, XrefRangeEnd = 52459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormTutorialAction Recurring(string text, int id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref id;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript.NativeMethodInfoPtr_Recurring_Protected_WormTutorialAction_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<WormTutorialAction>(intPtr3) : null;
		}

		// Token: 0x06000A43 RID: 2627 RVA: 0x0008830C File Offset: 0x0008650C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 52476, RefRangeEnd = 52480, XrefRangeStart = 52459, XrefRangeEnd = 52476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormTutorialAction ArrowWithLabel(int id, string identifier, string label, out WormTutorialAction hide)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(identifier);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(label);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript.NativeMethodInfoPtr_ArrowWithLabel_Protected_WormTutorialAction_Int32_String_String_byref_WormTutorialAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			hide = ((intPtr4 == 0) ? null : new WormTutorialAction(intPtr4));
			IntPtr intPtr5 = intPtr2;
			return (intPtr5 != 0) ? Il2CppObjectPool.Get<WormTutorialAction>(intPtr5) : null;
		}

		// Token: 0x06000A44 RID: 2628 RVA: 0x000883A0 File Offset: 0x000865A0
		[CallerCount(29)]
		[CachedScanResults(RefRangeStart = 52509, RefRangeEnd = 52538, XrefRangeStart = 52480, XrefRangeEnd = 52509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormTutorialAction PaulSay(string text, int id = 0, bool blocking = true, string dialogType = "ClickToContinue")
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref id;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref blocking;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(dialogType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript.NativeMethodInfoPtr_PaulSay_Protected_WormTutorialAction_String_Int32_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<WormTutorialAction>(intPtr3) : null;
		}

		// Token: 0x06000A45 RID: 2629 RVA: 0x00088420 File Offset: 0x00086620
		[CallerCount(28)]
		[CachedScanResults(RefRangeStart = 52567, RefRangeEnd = 52595, XrefRangeStart = 52538, XrefRangeEnd = 52567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormTutorialAction LetoSay(string text, int id = 0, bool blocking = true, string dialogType = "ClickToContinue")
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref id;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref blocking;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(dialogType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript.NativeMethodInfoPtr_LetoSay_Protected_WormTutorialAction_String_Int32_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<WormTutorialAction>(intPtr3) : null;
		}

		// Token: 0x06000A46 RID: 2630 RVA: 0x000884A0 File Offset: 0x000866A0
		[CallerCount(38)]
		[CachedScanResults(RefRangeStart = 52624, RefRangeEnd = 52662, XrefRangeStart = 52595, XrefRangeEnd = 52624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormTutorialAction GurneySay(string text, int id = 0, bool blocking = true, string dialogType = "ClickToContinue")
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref id;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref blocking;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(dialogType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript.NativeMethodInfoPtr_GurneySay_Protected_WormTutorialAction_String_Int32_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<WormTutorialAction>(intPtr3) : null;
		}

		// Token: 0x06000A47 RID: 2631 RVA: 0x00088520 File Offset: 0x00086720
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 52691, RefRangeEnd = 52699, XrefRangeStart = 52662, XrefRangeEnd = 52691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormTutorialAction RabbanSay(string text, int id = 0, bool blocking = true, string dialogType = "ClickToContinue")
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref id;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref blocking;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(dialogType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript.NativeMethodInfoPtr_RabbanSay_Protected_WormTutorialAction_String_Int32_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<WormTutorialAction>(intPtr3) : null;
		}

		// Token: 0x06000A48 RID: 2632 RVA: 0x000885A0 File Offset: 0x000867A0
		[CallerCount(58)]
		[CachedScanResults(RefRangeStart = 52728, RefRangeEnd = 52786, XrefRangeStart = 52699, XrefRangeEnd = 52728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormTutorialAction ThufirSay(string text, int id = 0, bool blocking = true, string dialogType = "ClickToContinue")
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref id;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref blocking;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(dialogType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript.NativeMethodInfoPtr_ThufirSay_Protected_WormTutorialAction_String_Int32_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<WormTutorialAction>(intPtr3) : null;
		}

		// Token: 0x06000A49 RID: 2633 RVA: 0x00088620 File Offset: 0x00086820
		[CallerCount(43)]
		[CachedScanResults(RefRangeStart = 52815, RefRangeEnd = 52858, XrefRangeStart = 52786, XrefRangeEnd = 52815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormTutorialAction DuncanSay(string text, int id = 0, bool blocking = true, string dialogType = "ClickToContinue")
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref id;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref blocking;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(dialogType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript.NativeMethodInfoPtr_DuncanSay_Protected_WormTutorialAction_String_Int32_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<WormTutorialAction>(intPtr3) : null;
		}

		// Token: 0x06000A4A RID: 2634 RVA: 0x000886A0 File Offset: 0x000868A0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 52887, RefRangeEnd = 52888, XrefRangeStart = 52858, XrefRangeEnd = 52887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormTutorialAction ArianaSay(string text, int id = 0, bool blocking = true, string dialogType = "ClickToContinue")
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref id;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref blocking;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(dialogType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript.NativeMethodInfoPtr_ArianaSay_Protected_WormTutorialAction_String_Int32_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<WormTutorialAction>(intPtr3) : null;
		}

		// Token: 0x06000A4B RID: 2635 RVA: 0x00088720 File Offset: 0x00086920
		[CallerCount(46)]
		[CachedScanResults(RefRangeStart = 52917, RefRangeEnd = 52963, XrefRangeStart = 52888, XrefRangeEnd = 52917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormTutorialAction StilgarSay(string text, int id = 0, bool blocking = true, string dialogType = "ClickToContinue")
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref id;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref blocking;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(dialogType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript.NativeMethodInfoPtr_StilgarSay_Protected_WormTutorialAction_String_Int32_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<WormTutorialAction>(intPtr3) : null;
		}

		// Token: 0x06000A4C RID: 2636 RVA: 0x000887A0 File Offset: 0x000869A0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 52992, RefRangeEnd = 52993, XrefRangeStart = 52963, XrefRangeEnd = 52992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormTutorialAction ArmandSay(string text, int id = 0, bool blocking = true, string dialogType = "ClickToContinue")
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref id;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref blocking;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(dialogType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript.NativeMethodInfoPtr_ArmandSay_Protected_WormTutorialAction_String_Int32_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<WormTutorialAction>(intPtr3) : null;
		}

		// Token: 0x06000A4D RID: 2637 RVA: 0x00088820 File Offset: 0x00086A20
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 53022, RefRangeEnd = 53023, XrefRangeStart = 52993, XrefRangeEnd = 53022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormTutorialAction IlbanSay(string text, int id = 0, bool blocking = true, string dialogType = "ClickToContinue")
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref id;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref blocking;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(dialogType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript.NativeMethodInfoPtr_IlbanSay_Protected_WormTutorialAction_String_Int32_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<WormTutorialAction>(intPtr3) : null;
		}

		// Token: 0x06000A4E RID: 2638 RVA: 0x000888A0 File Offset: 0x00086AA0
		[CallerCount(186)]
		[CachedScanResults(RefRangeStart = 53042, RefRangeEnd = 53228, XrefRangeStart = 53023, XrefRangeEnd = 53042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Event evtDuring(string str, WormPlayer player = null, Nullable<int> round = null, Nullable<int> turn = null, bool checkPlayer = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(player);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(round));
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(turn));
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref checkPlayer;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript.NativeMethodInfoPtr_evtDuring_Protected_Event_String_WormPlayer_Nullable_1_Int32_Nullable_1_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Event>(intPtr3) : null;
		}

		// Token: 0x06000A4F RID: 2639 RVA: 0x00088940 File Offset: 0x00086B40
		[CallerCount(44)]
		[CachedScanResults(RefRangeStart = 53247, RefRangeEnd = 53291, XrefRangeStart = 53228, XrefRangeEnd = 53247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Event evtAfter(string str, WormPlayer player = null, Nullable<int> round = null, Nullable<int> turn = null, bool checkPlayer = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(player);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(round));
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(turn));
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref checkPlayer;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript.NativeMethodInfoPtr_evtAfter_Protected_Event_String_WormPlayer_Nullable_1_Int32_Nullable_1_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Event>(intPtr3) : null;
		}

		// Token: 0x06000A50 RID: 2640 RVA: 0x000889E0 File Offset: 0x00086BE0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 53310, RefRangeEnd = 53311, XrefRangeStart = 53291, XrefRangeEnd = 53310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Event evtBefore(string str, WormPlayer player = null, Nullable<int> round = null, Nullable<int> turn = null, bool checkPlayer = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(player);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(round));
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(turn));
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref checkPlayer;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript.NativeMethodInfoPtr_evtBefore_Protected_Event_String_WormPlayer_Nullable_1_Int32_Nullable_1_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Event>(intPtr3) : null;
		}

		// Token: 0x06000A51 RID: 2641 RVA: 0x00088A80 File Offset: 0x00086C80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53311, XrefRangeEnd = 53321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormTutorialAction ShowCard(int id, string text, string card, bool blocking = true, string dialogType = "ClickToContinue")
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(text);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(card);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref blocking;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(dialogType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript.NativeMethodInfoPtr_ShowCard_Protected_WormTutorialAction_Int32_String_String_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<WormTutorialAction>(intPtr3) : null;
		}

		// Token: 0x06000A52 RID: 2642 RVA: 0x00088B14 File Offset: 0x00086D14
		[CallerCount(44)]
		[CachedScanResults(RefRangeStart = 53343, RefRangeEnd = 53387, XrefRangeStart = 53321, XrefRangeEnd = 53343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Canis.actions.Action HideElement(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript.NativeMethodInfoPtr_HideElement_Protected_Action_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr3) : null;
			}
		}

		// Token: 0x06000A53 RID: 2643 RVA: 0x00088B64 File Offset: 0x00086D64
		[CallerCount(29)]
		[CachedScanResults(RefRangeStart = 53409, RefRangeEnd = 53438, XrefRangeStart = 53387, XrefRangeEnd = 53409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Canis.actions.Action UnHideElement(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript.NativeMethodInfoPtr_UnHideElement_Protected_Action_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr3) : null;
			}
		}

		// Token: 0x06000A54 RID: 2644 RVA: 0x00088BB4 File Offset: 0x00086DB4
		[CallerCount(54)]
		[CachedScanResults(RefRangeStart = 53454, RefRangeEnd = 53508, XrefRangeStart = 53438, XrefRangeEnd = 53454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Canis.actions.Action ClearDisplayActions(WormPlayer player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript.NativeMethodInfoPtr_ClearDisplayActions_Protected_Action_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr3) : null;
			}
		}

		// Token: 0x06000A55 RID: 2645 RVA: 0x00088C04 File Offset: 0x00086E04
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 53527, RefRangeEnd = 53538, XrefRangeStart = 53508, XrefRangeEnd = 53527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Canis.actions.Action ReEnableDisplayActionClearOnSave(bool newValue = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref newValue;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript.NativeMethodInfoPtr_ReEnableDisplayActionClearOnSave_Protected_Action_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr3) : null;
			}
		}

		// Token: 0x06000A56 RID: 2646 RVA: 0x00088C50 File Offset: 0x00086E50
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 53546, RefRangeEnd = 53552, XrefRangeStart = 53538, XrefRangeEnd = 53546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Canis.actions.Action InstallTutorialActionsOnce(Event evt, ClientEvent clientEvent, ClientEventResponseID responseID, [Optional] Il2CppReferenceArray<TutorialAction> actions)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript.NativeMethodInfoPtr_InstallTutorialActionsOnce_Public_Action_Event_ClientEvent_ClientEventResponseID_Il2CppReferenceArray_1_TutorialAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr3) : null;
		}

		// Token: 0x06000A57 RID: 2647 RVA: 0x00006B1B File Offset: 0x00004D1B
		public Canis.actions.Action InstallTutorialActionsOnce(Event evt, ClientEvent clientEvent, ClientEventResponseID responseID, params TutorialAction[] actions)
		{
			return this.InstallTutorialActionsOnce(evt, clientEvent, responseID, new Il2CppReferenceArray<TutorialAction>(actions));
		}

		// Token: 0x06000A58 RID: 2648 RVA: 0x00006B2D File Offset: 0x00004D2D
		public WormTutorialScript(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000414 RID: 1044
		// (get) Token: 0x06000A59 RID: 2649 RVA: 0x00088CE8 File Offset: 0x00086EE8
		// (set) Token: 0x06000A5A RID: 2650 RVA: 0x00006B36 File Offset: 0x00004D36
		public unsafe WormMatch wormMatch
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTutorialScript.NativeFieldInfoPtr_wormMatch);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTutorialScript.NativeFieldInfoPtr_wormMatch), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000415 RID: 1045
		// (get) Token: 0x06000A5B RID: 2651 RVA: 0x00088D18 File Offset: 0x00086F18
		// (set) Token: 0x06000A5C RID: 2652 RVA: 0x00006B55 File Offset: 0x00004D55
		public unsafe WormPlayerSelectionFiltering selectionFiltering
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTutorialScript.NativeFieldInfoPtr_selectionFiltering);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayerSelectionFiltering>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTutorialScript.NativeFieldInfoPtr_selectionFiltering), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000654 RID: 1620
		private static readonly IntPtr NativeFieldInfoPtr_wormMatch;

		// Token: 0x04000655 RID: 1621
		private static readonly IntPtr NativeFieldInfoPtr_selectionFiltering;

		// Token: 0x04000656 RID: 1622
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0;

		// Token: 0x04000657 RID: 1623
		private static readonly IntPtr NativeMethodInfoPtr_OnTurn_Protected_Func_2_Context_Boolean_WormPlayer_Int32_Int32_Boolean_0;

		// Token: 0x04000658 RID: 1624
		private static readonly IntPtr NativeMethodInfoPtr_AfterTurn_Protected_Func_2_Context_Boolean_WormPlayer_Int32_Int32_Boolean_0;

		// Token: 0x04000659 RID: 1625
		private static readonly IntPtr NativeMethodInfoPtr_BeforeTurn_Protected_Func_2_Context_Boolean_WormPlayer_Int32_Int32_Boolean_0;

		// Token: 0x0400065A RID: 1626
		private static readonly IntPtr NativeMethodInfoPtr_Message_Protected_WormTutorialAction_String_0;

		// Token: 0x0400065B RID: 1627
		private static readonly IntPtr NativeMethodInfoPtr_Recurring_Protected_WormTutorialAction_String_Int32_0;

		// Token: 0x0400065C RID: 1628
		private static readonly IntPtr NativeMethodInfoPtr_ArrowWithLabel_Protected_WormTutorialAction_Int32_String_String_byref_WormTutorialAction_0;

		// Token: 0x0400065D RID: 1629
		private static readonly IntPtr NativeMethodInfoPtr_PaulSay_Protected_WormTutorialAction_String_Int32_Boolean_String_0;

		// Token: 0x0400065E RID: 1630
		private static readonly IntPtr NativeMethodInfoPtr_LetoSay_Protected_WormTutorialAction_String_Int32_Boolean_String_0;

		// Token: 0x0400065F RID: 1631
		private static readonly IntPtr NativeMethodInfoPtr_GurneySay_Protected_WormTutorialAction_String_Int32_Boolean_String_0;

		// Token: 0x04000660 RID: 1632
		private static readonly IntPtr NativeMethodInfoPtr_RabbanSay_Protected_WormTutorialAction_String_Int32_Boolean_String_0;

		// Token: 0x04000661 RID: 1633
		private static readonly IntPtr NativeMethodInfoPtr_ThufirSay_Protected_WormTutorialAction_String_Int32_Boolean_String_0;

		// Token: 0x04000662 RID: 1634
		private static readonly IntPtr NativeMethodInfoPtr_DuncanSay_Protected_WormTutorialAction_String_Int32_Boolean_String_0;

		// Token: 0x04000663 RID: 1635
		private static readonly IntPtr NativeMethodInfoPtr_ArianaSay_Protected_WormTutorialAction_String_Int32_Boolean_String_0;

		// Token: 0x04000664 RID: 1636
		private static readonly IntPtr NativeMethodInfoPtr_StilgarSay_Protected_WormTutorialAction_String_Int32_Boolean_String_0;

		// Token: 0x04000665 RID: 1637
		private static readonly IntPtr NativeMethodInfoPtr_ArmandSay_Protected_WormTutorialAction_String_Int32_Boolean_String_0;

		// Token: 0x04000666 RID: 1638
		private static readonly IntPtr NativeMethodInfoPtr_IlbanSay_Protected_WormTutorialAction_String_Int32_Boolean_String_0;

		// Token: 0x04000667 RID: 1639
		private static readonly IntPtr NativeMethodInfoPtr_evtDuring_Protected_Event_String_WormPlayer_Nullable_1_Int32_Nullable_1_Int32_Boolean_0;

		// Token: 0x04000668 RID: 1640
		private static readonly IntPtr NativeMethodInfoPtr_evtAfter_Protected_Event_String_WormPlayer_Nullable_1_Int32_Nullable_1_Int32_Boolean_0;

		// Token: 0x04000669 RID: 1641
		private static readonly IntPtr NativeMethodInfoPtr_evtBefore_Protected_Event_String_WormPlayer_Nullable_1_Int32_Nullable_1_Int32_Boolean_0;

		// Token: 0x0400066A RID: 1642
		private static readonly IntPtr NativeMethodInfoPtr_ShowCard_Protected_WormTutorialAction_Int32_String_String_Boolean_String_0;

		// Token: 0x0400066B RID: 1643
		private static readonly IntPtr NativeMethodInfoPtr_HideElement_Protected_Action_String_0;

		// Token: 0x0400066C RID: 1644
		private static readonly IntPtr NativeMethodInfoPtr_UnHideElement_Protected_Action_String_0;

		// Token: 0x0400066D RID: 1645
		private static readonly IntPtr NativeMethodInfoPtr_ClearDisplayActions_Protected_Action_WormPlayer_0;

		// Token: 0x0400066E RID: 1646
		private static readonly IntPtr NativeMethodInfoPtr_ReEnableDisplayActionClearOnSave_Protected_Action_Boolean_0;

		// Token: 0x0400066F RID: 1647
		private static readonly IntPtr NativeMethodInfoPtr_InstallTutorialActionsOnce_Public_Action_Event_ClientEvent_ClientEventResponseID_Il2CppReferenceArray_1_TutorialAction_0;

		// Token: 0x020005E7 RID: 1511
		[ObfuscatedName("worm.canis.data.Tutorial.WormTutorialScript+<>c__DisplayClass3_0")]
		public sealed class __c__DisplayClass3_0 : Object
		{
			// Token: 0x06004977 RID: 18807 RVA: 0x00191910 File Offset: 0x0018FB10
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass3_0()
			{
				Il2CppClassPointerStore<WormTutorialScript.__c__DisplayClass3_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormTutorialScript>.NativeClassPtr, "<>c__DisplayClass3_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormTutorialScript.__c__DisplayClass3_0>.NativeClassPtr);
				WormTutorialScript.__c__DisplayClass3_0.NativeFieldInfoPtr_checkPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialScript.__c__DisplayClass3_0>.NativeClassPtr, "checkPlayer");
				WormTutorialScript.__c__DisplayClass3_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialScript.__c__DisplayClass3_0>.NativeClassPtr, "<>4__this");
				WormTutorialScript.__c__DisplayClass3_0.NativeFieldInfoPtr_player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialScript.__c__DisplayClass3_0>.NativeClassPtr, "player");
				WormTutorialScript.__c__DisplayClass3_0.NativeFieldInfoPtr_round = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialScript.__c__DisplayClass3_0>.NativeClassPtr, "round");
				WormTutorialScript.__c__DisplayClass3_0.NativeFieldInfoPtr_turn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialScript.__c__DisplayClass3_0>.NativeClassPtr, "turn");
				WormTutorialScript.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript.__c__DisplayClass3_0>.NativeClassPtr, 100664792);
				WormTutorialScript.__c__DisplayClass3_0.NativeMethodInfoPtr__OnTurn_b__0_Internal_Boolean_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript.__c__DisplayClass3_0>.NativeClassPtr, 100664793);
			}

			// Token: 0x06004978 RID: 18808 RVA: 0x001919C8 File Offset: 0x0018FBC8
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass3_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormTutorialScript.__c__DisplayClass3_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004979 RID: 18809 RVA: 0x00191A04 File Offset: 0x0018FC04
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52371, XrefRangeEnd = 52374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _OnTurn_b__0(Context context)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript.__c__DisplayClass3_0.NativeMethodInfoPtr__OnTurn_b__0_Internal_Boolean_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600497A RID: 18810 RVA: 0x00019154 File Offset: 0x00017354
			public __c__DisplayClass3_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170011D8 RID: 4568
			// (get) Token: 0x0600497B RID: 18811 RVA: 0x00191A54 File Offset: 0x0018FC54
			// (set) Token: 0x0600497C RID: 18812 RVA: 0x0001915D File Offset: 0x0001735D
			public unsafe bool checkPlayer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTutorialScript.__c__DisplayClass3_0.NativeFieldInfoPtr_checkPlayer);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTutorialScript.__c__DisplayClass3_0.NativeFieldInfoPtr_checkPlayer)) = value;
				}
			}

			// Token: 0x170011D9 RID: 4569
			// (get) Token: 0x0600497D RID: 18813 RVA: 0x00191A7C File Offset: 0x0018FC7C
			// (set) Token: 0x0600497E RID: 18814 RVA: 0x00019178 File Offset: 0x00017378
			public unsafe WormTutorialScript __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTutorialScript.__c__DisplayClass3_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormTutorialScript>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTutorialScript.__c__DisplayClass3_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170011DA RID: 4570
			// (get) Token: 0x0600497F RID: 18815 RVA: 0x00191AAC File Offset: 0x0018FCAC
			// (set) Token: 0x06004980 RID: 18816 RVA: 0x00019197 File Offset: 0x00017397
			public unsafe WormPlayer player
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTutorialScript.__c__DisplayClass3_0.NativeFieldInfoPtr_player);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTutorialScript.__c__DisplayClass3_0.NativeFieldInfoPtr_player), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170011DB RID: 4571
			// (get) Token: 0x06004981 RID: 18817 RVA: 0x00191ADC File Offset: 0x0018FCDC
			// (set) Token: 0x06004982 RID: 18818 RVA: 0x000191B6 File Offset: 0x000173B6
			public unsafe int round
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTutorialScript.__c__DisplayClass3_0.NativeFieldInfoPtr_round);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTutorialScript.__c__DisplayClass3_0.NativeFieldInfoPtr_round)) = value;
				}
			}

			// Token: 0x170011DC RID: 4572
			// (get) Token: 0x06004983 RID: 18819 RVA: 0x00191B04 File Offset: 0x0018FD04
			// (set) Token: 0x06004984 RID: 18820 RVA: 0x000191D1 File Offset: 0x000173D1
			public unsafe int turn
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTutorialScript.__c__DisplayClass3_0.NativeFieldInfoPtr_turn);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTutorialScript.__c__DisplayClass3_0.NativeFieldInfoPtr_turn)) = value;
				}
			}

			// Token: 0x04003034 RID: 12340
			private static readonly IntPtr NativeFieldInfoPtr_checkPlayer;

			// Token: 0x04003035 RID: 12341
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04003036 RID: 12342
			private static readonly IntPtr NativeFieldInfoPtr_player;

			// Token: 0x04003037 RID: 12343
			private static readonly IntPtr NativeFieldInfoPtr_round;

			// Token: 0x04003038 RID: 12344
			private static readonly IntPtr NativeFieldInfoPtr_turn;

			// Token: 0x04003039 RID: 12345
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400303A RID: 12346
			private static readonly IntPtr NativeMethodInfoPtr__OnTurn_b__0_Internal_Boolean_Context_0;
		}

		// Token: 0x020005E8 RID: 1512
		[ObfuscatedName("worm.canis.data.Tutorial.WormTutorialScript+<>c__DisplayClass4_0")]
		public sealed class __c__DisplayClass4_0 : Object
		{
			// Token: 0x06004985 RID: 18821 RVA: 0x00191B2C File Offset: 0x0018FD2C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass4_0()
			{
				Il2CppClassPointerStore<WormTutorialScript.__c__DisplayClass4_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormTutorialScript>.NativeClassPtr, "<>c__DisplayClass4_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormTutorialScript.__c__DisplayClass4_0>.NativeClassPtr);
				WormTutorialScript.__c__DisplayClass4_0.NativeFieldInfoPtr_checkPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialScript.__c__DisplayClass4_0>.NativeClassPtr, "checkPlayer");
				WormTutorialScript.__c__DisplayClass4_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialScript.__c__DisplayClass4_0>.NativeClassPtr, "<>4__this");
				WormTutorialScript.__c__DisplayClass4_0.NativeFieldInfoPtr_player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialScript.__c__DisplayClass4_0>.NativeClassPtr, "player");
				WormTutorialScript.__c__DisplayClass4_0.NativeFieldInfoPtr_round = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialScript.__c__DisplayClass4_0>.NativeClassPtr, "round");
				WormTutorialScript.__c__DisplayClass4_0.NativeFieldInfoPtr_turn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialScript.__c__DisplayClass4_0>.NativeClassPtr, "turn");
				WormTutorialScript.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript.__c__DisplayClass4_0>.NativeClassPtr, 100664794);
				WormTutorialScript.__c__DisplayClass4_0.NativeMethodInfoPtr__AfterTurn_b__0_Internal_Boolean_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript.__c__DisplayClass4_0>.NativeClassPtr, 100664795);
			}

			// Token: 0x06004986 RID: 18822 RVA: 0x00191BE4 File Offset: 0x0018FDE4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass4_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormTutorialScript.__c__DisplayClass4_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004987 RID: 18823 RVA: 0x00191C20 File Offset: 0x0018FE20
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52374, XrefRangeEnd = 52377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _AfterTurn_b__0(Context context)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript.__c__DisplayClass4_0.NativeMethodInfoPtr__AfterTurn_b__0_Internal_Boolean_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004988 RID: 18824 RVA: 0x000191EC File Offset: 0x000173EC
			public __c__DisplayClass4_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170011DD RID: 4573
			// (get) Token: 0x06004989 RID: 18825 RVA: 0x00191C70 File Offset: 0x0018FE70
			// (set) Token: 0x0600498A RID: 18826 RVA: 0x000191F5 File Offset: 0x000173F5
			public unsafe bool checkPlayer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTutorialScript.__c__DisplayClass4_0.NativeFieldInfoPtr_checkPlayer);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTutorialScript.__c__DisplayClass4_0.NativeFieldInfoPtr_checkPlayer)) = value;
				}
			}

			// Token: 0x170011DE RID: 4574
			// (get) Token: 0x0600498B RID: 18827 RVA: 0x00191C98 File Offset: 0x0018FE98
			// (set) Token: 0x0600498C RID: 18828 RVA: 0x00019210 File Offset: 0x00017410
			public unsafe WormTutorialScript __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTutorialScript.__c__DisplayClass4_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormTutorialScript>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTutorialScript.__c__DisplayClass4_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170011DF RID: 4575
			// (get) Token: 0x0600498D RID: 18829 RVA: 0x00191CC8 File Offset: 0x0018FEC8
			// (set) Token: 0x0600498E RID: 18830 RVA: 0x0001922F File Offset: 0x0001742F
			public unsafe WormPlayer player
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTutorialScript.__c__DisplayClass4_0.NativeFieldInfoPtr_player);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTutorialScript.__c__DisplayClass4_0.NativeFieldInfoPtr_player), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170011E0 RID: 4576
			// (get) Token: 0x0600498F RID: 18831 RVA: 0x00191CF8 File Offset: 0x0018FEF8
			// (set) Token: 0x06004990 RID: 18832 RVA: 0x0001924E File Offset: 0x0001744E
			public unsafe int round
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTutorialScript.__c__DisplayClass4_0.NativeFieldInfoPtr_round);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTutorialScript.__c__DisplayClass4_0.NativeFieldInfoPtr_round)) = value;
				}
			}

			// Token: 0x170011E1 RID: 4577
			// (get) Token: 0x06004991 RID: 18833 RVA: 0x00191D20 File Offset: 0x0018FF20
			// (set) Token: 0x06004992 RID: 18834 RVA: 0x00019269 File Offset: 0x00017469
			public unsafe int turn
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTutorialScript.__c__DisplayClass4_0.NativeFieldInfoPtr_turn);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTutorialScript.__c__DisplayClass4_0.NativeFieldInfoPtr_turn)) = value;
				}
			}

			// Token: 0x0400303B RID: 12347
			private static readonly IntPtr NativeFieldInfoPtr_checkPlayer;

			// Token: 0x0400303C RID: 12348
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400303D RID: 12349
			private static readonly IntPtr NativeFieldInfoPtr_player;

			// Token: 0x0400303E RID: 12350
			private static readonly IntPtr NativeFieldInfoPtr_round;

			// Token: 0x0400303F RID: 12351
			private static readonly IntPtr NativeFieldInfoPtr_turn;

			// Token: 0x04003040 RID: 12352
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04003041 RID: 12353
			private static readonly IntPtr NativeMethodInfoPtr__AfterTurn_b__0_Internal_Boolean_Context_0;
		}

		// Token: 0x020005E9 RID: 1513
		[ObfuscatedName("worm.canis.data.Tutorial.WormTutorialScript+<>c__DisplayClass5_0")]
		public sealed class __c__DisplayClass5_0 : Object
		{
			// Token: 0x06004993 RID: 18835 RVA: 0x00191D48 File Offset: 0x0018FF48
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass5_0()
			{
				Il2CppClassPointerStore<WormTutorialScript.__c__DisplayClass5_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormTutorialScript>.NativeClassPtr, "<>c__DisplayClass5_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormTutorialScript.__c__DisplayClass5_0>.NativeClassPtr);
				WormTutorialScript.__c__DisplayClass5_0.NativeFieldInfoPtr_checkPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialScript.__c__DisplayClass5_0>.NativeClassPtr, "checkPlayer");
				WormTutorialScript.__c__DisplayClass5_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialScript.__c__DisplayClass5_0>.NativeClassPtr, "<>4__this");
				WormTutorialScript.__c__DisplayClass5_0.NativeFieldInfoPtr_player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialScript.__c__DisplayClass5_0>.NativeClassPtr, "player");
				WormTutorialScript.__c__DisplayClass5_0.NativeFieldInfoPtr_round = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialScript.__c__DisplayClass5_0>.NativeClassPtr, "round");
				WormTutorialScript.__c__DisplayClass5_0.NativeFieldInfoPtr_turn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialScript.__c__DisplayClass5_0>.NativeClassPtr, "turn");
				WormTutorialScript.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript.__c__DisplayClass5_0>.NativeClassPtr, 100664796);
				WormTutorialScript.__c__DisplayClass5_0.NativeMethodInfoPtr__BeforeTurn_b__0_Internal_Boolean_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript.__c__DisplayClass5_0>.NativeClassPtr, 100664797);
			}

			// Token: 0x06004994 RID: 18836 RVA: 0x00191E00 File Offset: 0x00190000
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass5_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormTutorialScript.__c__DisplayClass5_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004995 RID: 18837 RVA: 0x00191E3C File Offset: 0x0019003C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52377, XrefRangeEnd = 52380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _BeforeTurn_b__0(Context context)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript.__c__DisplayClass5_0.NativeMethodInfoPtr__BeforeTurn_b__0_Internal_Boolean_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004996 RID: 18838 RVA: 0x00019284 File Offset: 0x00017484
			public __c__DisplayClass5_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170011E2 RID: 4578
			// (get) Token: 0x06004997 RID: 18839 RVA: 0x00191E8C File Offset: 0x0019008C
			// (set) Token: 0x06004998 RID: 18840 RVA: 0x0001928D File Offset: 0x0001748D
			public unsafe bool checkPlayer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTutorialScript.__c__DisplayClass5_0.NativeFieldInfoPtr_checkPlayer);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTutorialScript.__c__DisplayClass5_0.NativeFieldInfoPtr_checkPlayer)) = value;
				}
			}

			// Token: 0x170011E3 RID: 4579
			// (get) Token: 0x06004999 RID: 18841 RVA: 0x00191EB4 File Offset: 0x001900B4
			// (set) Token: 0x0600499A RID: 18842 RVA: 0x000192A8 File Offset: 0x000174A8
			public unsafe WormTutorialScript __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTutorialScript.__c__DisplayClass5_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormTutorialScript>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTutorialScript.__c__DisplayClass5_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170011E4 RID: 4580
			// (get) Token: 0x0600499B RID: 18843 RVA: 0x00191EE4 File Offset: 0x001900E4
			// (set) Token: 0x0600499C RID: 18844 RVA: 0x000192C7 File Offset: 0x000174C7
			public unsafe WormPlayer player
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTutorialScript.__c__DisplayClass5_0.NativeFieldInfoPtr_player);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTutorialScript.__c__DisplayClass5_0.NativeFieldInfoPtr_player), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170011E5 RID: 4581
			// (get) Token: 0x0600499D RID: 18845 RVA: 0x00191F14 File Offset: 0x00190114
			// (set) Token: 0x0600499E RID: 18846 RVA: 0x000192E6 File Offset: 0x000174E6
			public unsafe int round
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTutorialScript.__c__DisplayClass5_0.NativeFieldInfoPtr_round);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTutorialScript.__c__DisplayClass5_0.NativeFieldInfoPtr_round)) = value;
				}
			}

			// Token: 0x170011E6 RID: 4582
			// (get) Token: 0x0600499F RID: 18847 RVA: 0x00191F3C File Offset: 0x0019013C
			// (set) Token: 0x060049A0 RID: 18848 RVA: 0x00019301 File Offset: 0x00017501
			public unsafe int turn
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTutorialScript.__c__DisplayClass5_0.NativeFieldInfoPtr_turn);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTutorialScript.__c__DisplayClass5_0.NativeFieldInfoPtr_turn)) = value;
				}
			}

			// Token: 0x04003042 RID: 12354
			private static readonly IntPtr NativeFieldInfoPtr_checkPlayer;

			// Token: 0x04003043 RID: 12355
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04003044 RID: 12356
			private static readonly IntPtr NativeFieldInfoPtr_player;

			// Token: 0x04003045 RID: 12357
			private static readonly IntPtr NativeFieldInfoPtr_round;

			// Token: 0x04003046 RID: 12358
			private static readonly IntPtr NativeFieldInfoPtr_turn;

			// Token: 0x04003047 RID: 12359
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04003048 RID: 12360
			private static readonly IntPtr NativeMethodInfoPtr__BeforeTurn_b__0_Internal_Boolean_Context_0;
		}
	}
}
