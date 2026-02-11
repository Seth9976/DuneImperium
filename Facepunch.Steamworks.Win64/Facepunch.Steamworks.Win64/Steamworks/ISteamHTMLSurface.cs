using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Steamworks.Data;

namespace Steamworks
{
	// Token: 0x02000015 RID: 21
	public class ISteamHTMLSurface : SteamInterface
	{
		// Token: 0x0600026A RID: 618 RVA: 0x0001C7E4 File Offset: 0x0001A9E4
		// Note: this type is marked as 'beforefieldinit'.
		static ISteamHTMLSurface()
		{
			Il2CppClassPointerStore<ISteamHTMLSurface>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks", "ISteamHTMLSurface");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ISteamHTMLSurface>.NativeClassPtr);
			ISteamHTMLSurface.NativeMethodInfoPtr__ctor_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamHTMLSurface>.NativeClassPtr, 100663875);
			ISteamHTMLSurface.NativeMethodInfoPtr_SteamAPI_SteamHTMLSurface_v005_Internal_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamHTMLSurface>.NativeClassPtr, 100663876);
			ISteamHTMLSurface.NativeMethodInfoPtr_GetUserInterfacePointer_Public_Virtual_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamHTMLSurface>.NativeClassPtr, 100663877);
			ISteamHTMLSurface.NativeMethodInfoPtr__Init_Private_Static_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamHTMLSurface>.NativeClassPtr, 100663878);
			ISteamHTMLSurface.NativeMethodInfoPtr_Init_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamHTMLSurface>.NativeClassPtr, 100663879);
			ISteamHTMLSurface.NativeMethodInfoPtr__Shutdown_Private_Static_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamHTMLSurface>.NativeClassPtr, 100663880);
			ISteamHTMLSurface.NativeMethodInfoPtr_Shutdown_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamHTMLSurface>.NativeClassPtr, 100663881);
			ISteamHTMLSurface.NativeMethodInfoPtr__CreateBrowser_Private_Static_SteamAPICall_t_IntPtr_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamHTMLSurface>.NativeClassPtr, 100663882);
			ISteamHTMLSurface.NativeMethodInfoPtr_CreateBrowser_Internal_CallResult_1_HTML_BrowserReady_t_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamHTMLSurface>.NativeClassPtr, 100663883);
			ISteamHTMLSurface.NativeMethodInfoPtr__RemoveBrowser_Private_Static_Void_IntPtr_HHTMLBrowser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamHTMLSurface>.NativeClassPtr, 100663884);
			ISteamHTMLSurface.NativeMethodInfoPtr_RemoveBrowser_Internal_Void_HHTMLBrowser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamHTMLSurface>.NativeClassPtr, 100663885);
			ISteamHTMLSurface.NativeMethodInfoPtr__LoadURL_Private_Static_Void_IntPtr_HHTMLBrowser_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamHTMLSurface>.NativeClassPtr, 100663886);
			ISteamHTMLSurface.NativeMethodInfoPtr_LoadURL_Internal_Void_HHTMLBrowser_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamHTMLSurface>.NativeClassPtr, 100663887);
			ISteamHTMLSurface.NativeMethodInfoPtr__SetSize_Private_Static_Void_IntPtr_HHTMLBrowser_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamHTMLSurface>.NativeClassPtr, 100663888);
			ISteamHTMLSurface.NativeMethodInfoPtr_SetSize_Internal_Void_HHTMLBrowser_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamHTMLSurface>.NativeClassPtr, 100663889);
			ISteamHTMLSurface.NativeMethodInfoPtr__StopLoad_Private_Static_Void_IntPtr_HHTMLBrowser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamHTMLSurface>.NativeClassPtr, 100663890);
			ISteamHTMLSurface.NativeMethodInfoPtr_StopLoad_Internal_Void_HHTMLBrowser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamHTMLSurface>.NativeClassPtr, 100663891);
			ISteamHTMLSurface.NativeMethodInfoPtr__Reload_Private_Static_Void_IntPtr_HHTMLBrowser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamHTMLSurface>.NativeClassPtr, 100663892);
			ISteamHTMLSurface.NativeMethodInfoPtr_Reload_Internal_Void_HHTMLBrowser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamHTMLSurface>.NativeClassPtr, 100663893);
			ISteamHTMLSurface.NativeMethodInfoPtr__GoBack_Private_Static_Void_IntPtr_HHTMLBrowser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamHTMLSurface>.NativeClassPtr, 100663894);
			ISteamHTMLSurface.NativeMethodInfoPtr_GoBack_Internal_Void_HHTMLBrowser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamHTMLSurface>.NativeClassPtr, 100663895);
			ISteamHTMLSurface.NativeMethodInfoPtr__GoForward_Private_Static_Void_IntPtr_HHTMLBrowser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamHTMLSurface>.NativeClassPtr, 100663896);
			ISteamHTMLSurface.NativeMethodInfoPtr_GoForward_Internal_Void_HHTMLBrowser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamHTMLSurface>.NativeClassPtr, 100663897);
			ISteamHTMLSurface.NativeMethodInfoPtr__AddHeader_Private_Static_Void_IntPtr_HHTMLBrowser_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamHTMLSurface>.NativeClassPtr, 100663898);
			ISteamHTMLSurface.NativeMethodInfoPtr_AddHeader_Internal_Void_HHTMLBrowser_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamHTMLSurface>.NativeClassPtr, 100663899);
			ISteamHTMLSurface.NativeMethodInfoPtr__ExecuteJavascript_Private_Static_Void_IntPtr_HHTMLBrowser_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamHTMLSurface>.NativeClassPtr, 100663900);
			ISteamHTMLSurface.NativeMethodInfoPtr_ExecuteJavascript_Internal_Void_HHTMLBrowser_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamHTMLSurface>.NativeClassPtr, 100663901);
			ISteamHTMLSurface.NativeMethodInfoPtr__MouseUp_Private_Static_Void_IntPtr_HHTMLBrowser_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamHTMLSurface>.NativeClassPtr, 100663902);
			ISteamHTMLSurface.NativeMethodInfoPtr_MouseUp_Internal_Void_HHTMLBrowser_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamHTMLSurface>.NativeClassPtr, 100663903);
			ISteamHTMLSurface.NativeMethodInfoPtr__MouseDown_Private_Static_Void_IntPtr_HHTMLBrowser_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamHTMLSurface>.NativeClassPtr, 100663904);
			ISteamHTMLSurface.NativeMethodInfoPtr_MouseDown_Internal_Void_HHTMLBrowser_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamHTMLSurface>.NativeClassPtr, 100663905);
			ISteamHTMLSurface.NativeMethodInfoPtr__MouseDoubleClick_Private_Static_Void_IntPtr_HHTMLBrowser_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamHTMLSurface>.NativeClassPtr, 100663906);
			ISteamHTMLSurface.NativeMethodInfoPtr_MouseDoubleClick_Internal_Void_HHTMLBrowser_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamHTMLSurface>.NativeClassPtr, 100663907);
			ISteamHTMLSurface.NativeMethodInfoPtr__MouseMove_Private_Static_Void_IntPtr_HHTMLBrowser_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamHTMLSurface>.NativeClassPtr, 100663908);
			ISteamHTMLSurface.NativeMethodInfoPtr_MouseMove_Internal_Void_HHTMLBrowser_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamHTMLSurface>.NativeClassPtr, 100663909);
			ISteamHTMLSurface.NativeMethodInfoPtr__MouseWheel_Private_Static_Void_IntPtr_HHTMLBrowser_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamHTMLSurface>.NativeClassPtr, 100663910);
			ISteamHTMLSurface.NativeMethodInfoPtr_MouseWheel_Internal_Void_HHTMLBrowser_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamHTMLSurface>.NativeClassPtr, 100663911);
			ISteamHTMLSurface.NativeMethodInfoPtr__KeyDown_Private_Static_Void_IntPtr_HHTMLBrowser_UInt32_IntPtr_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamHTMLSurface>.NativeClassPtr, 100663912);
			ISteamHTMLSurface.NativeMethodInfoPtr_KeyDown_Internal_Void_HHTMLBrowser_UInt32_IntPtr_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamHTMLSurface>.NativeClassPtr, 100663913);
			ISteamHTMLSurface.NativeMethodInfoPtr__KeyUp_Private_Static_Void_IntPtr_HHTMLBrowser_UInt32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamHTMLSurface>.NativeClassPtr, 100663914);
			ISteamHTMLSurface.NativeMethodInfoPtr_KeyUp_Internal_Void_HHTMLBrowser_UInt32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamHTMLSurface>.NativeClassPtr, 100663915);
			ISteamHTMLSurface.NativeMethodInfoPtr__KeyChar_Private_Static_Void_IntPtr_HHTMLBrowser_UInt32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamHTMLSurface>.NativeClassPtr, 100663916);
			ISteamHTMLSurface.NativeMethodInfoPtr_KeyChar_Internal_Void_HHTMLBrowser_UInt32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamHTMLSurface>.NativeClassPtr, 100663917);
			ISteamHTMLSurface.NativeMethodInfoPtr__SetHorizontalScroll_Private_Static_Void_IntPtr_HHTMLBrowser_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamHTMLSurface>.NativeClassPtr, 100663918);
			ISteamHTMLSurface.NativeMethodInfoPtr_SetHorizontalScroll_Internal_Void_HHTMLBrowser_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamHTMLSurface>.NativeClassPtr, 100663919);
			ISteamHTMLSurface.NativeMethodInfoPtr__SetVerticalScroll_Private_Static_Void_IntPtr_HHTMLBrowser_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamHTMLSurface>.NativeClassPtr, 100663920);
			ISteamHTMLSurface.NativeMethodInfoPtr_SetVerticalScroll_Internal_Void_HHTMLBrowser_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamHTMLSurface>.NativeClassPtr, 100663921);
			ISteamHTMLSurface.NativeMethodInfoPtr__SetKeyFocus_Private_Static_Void_IntPtr_HHTMLBrowser_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamHTMLSurface>.NativeClassPtr, 100663922);
			ISteamHTMLSurface.NativeMethodInfoPtr_SetKeyFocus_Internal_Void_HHTMLBrowser_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamHTMLSurface>.NativeClassPtr, 100663923);
			ISteamHTMLSurface.NativeMethodInfoPtr__ViewSource_Private_Static_Void_IntPtr_HHTMLBrowser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamHTMLSurface>.NativeClassPtr, 100663924);
			ISteamHTMLSurface.NativeMethodInfoPtr_ViewSource_Internal_Void_HHTMLBrowser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamHTMLSurface>.NativeClassPtr, 100663925);
			ISteamHTMLSurface.NativeMethodInfoPtr__CopyToClipboard_Private_Static_Void_IntPtr_HHTMLBrowser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamHTMLSurface>.NativeClassPtr, 100663926);
			ISteamHTMLSurface.NativeMethodInfoPtr_CopyToClipboard_Internal_Void_HHTMLBrowser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamHTMLSurface>.NativeClassPtr, 100663927);
			ISteamHTMLSurface.NativeMethodInfoPtr__PasteFromClipboard_Private_Static_Void_IntPtr_HHTMLBrowser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamHTMLSurface>.NativeClassPtr, 100663928);
			ISteamHTMLSurface.NativeMethodInfoPtr_PasteFromClipboard_Internal_Void_HHTMLBrowser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamHTMLSurface>.NativeClassPtr, 100663929);
			ISteamHTMLSurface.NativeMethodInfoPtr__Find_Private_Static_Void_IntPtr_HHTMLBrowser_String_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamHTMLSurface>.NativeClassPtr, 100663930);
			ISteamHTMLSurface.NativeMethodInfoPtr_Find_Internal_Void_HHTMLBrowser_String_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamHTMLSurface>.NativeClassPtr, 100663931);
			ISteamHTMLSurface.NativeMethodInfoPtr__StopFind_Private_Static_Void_IntPtr_HHTMLBrowser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamHTMLSurface>.NativeClassPtr, 100663932);
			ISteamHTMLSurface.NativeMethodInfoPtr_StopFind_Internal_Void_HHTMLBrowser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamHTMLSurface>.NativeClassPtr, 100663933);
			ISteamHTMLSurface.NativeMethodInfoPtr__GetLinkAtPosition_Private_Static_Void_IntPtr_HHTMLBrowser_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamHTMLSurface>.NativeClassPtr, 100663934);
			ISteamHTMLSurface.NativeMethodInfoPtr_GetLinkAtPosition_Internal_Void_HHTMLBrowser_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamHTMLSurface>.NativeClassPtr, 100663935);
			ISteamHTMLSurface.NativeMethodInfoPtr__SetCookie_Private_Static_Void_IntPtr_String_String_String_String_RTime32_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamHTMLSurface>.NativeClassPtr, 100663936);
			ISteamHTMLSurface.NativeMethodInfoPtr_SetCookie_Internal_Void_String_String_String_String_RTime32_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamHTMLSurface>.NativeClassPtr, 100663937);
			ISteamHTMLSurface.NativeMethodInfoPtr__SetPageScaleFactor_Private_Static_Void_IntPtr_HHTMLBrowser_Single_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamHTMLSurface>.NativeClassPtr, 100663938);
			ISteamHTMLSurface.NativeMethodInfoPtr_SetPageScaleFactor_Internal_Void_HHTMLBrowser_Single_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamHTMLSurface>.NativeClassPtr, 100663939);
			ISteamHTMLSurface.NativeMethodInfoPtr__SetBackgroundMode_Private_Static_Void_IntPtr_HHTMLBrowser_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamHTMLSurface>.NativeClassPtr, 100663940);
			ISteamHTMLSurface.NativeMethodInfoPtr_SetBackgroundMode_Internal_Void_HHTMLBrowser_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamHTMLSurface>.NativeClassPtr, 100663941);
			ISteamHTMLSurface.NativeMethodInfoPtr__SetDPIScalingFactor_Private_Static_Void_IntPtr_HHTMLBrowser_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamHTMLSurface>.NativeClassPtr, 100663942);
			ISteamHTMLSurface.NativeMethodInfoPtr_SetDPIScalingFactor_Internal_Void_HHTMLBrowser_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamHTMLSurface>.NativeClassPtr, 100663943);
			ISteamHTMLSurface.NativeMethodInfoPtr__OpenDeveloperTools_Private_Static_Void_IntPtr_HHTMLBrowser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamHTMLSurface>.NativeClassPtr, 100663944);
			ISteamHTMLSurface.NativeMethodInfoPtr_OpenDeveloperTools_Internal_Void_HHTMLBrowser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamHTMLSurface>.NativeClassPtr, 100663945);
			ISteamHTMLSurface.NativeMethodInfoPtr__AllowStartRequest_Private_Static_Void_IntPtr_HHTMLBrowser_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamHTMLSurface>.NativeClassPtr, 100663946);
			ISteamHTMLSurface.NativeMethodInfoPtr_AllowStartRequest_Internal_Void_HHTMLBrowser_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamHTMLSurface>.NativeClassPtr, 100663947);
			ISteamHTMLSurface.NativeMethodInfoPtr__JSDialogResponse_Private_Static_Void_IntPtr_HHTMLBrowser_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamHTMLSurface>.NativeClassPtr, 100663948);
			ISteamHTMLSurface.NativeMethodInfoPtr_JSDialogResponse_Internal_Void_HHTMLBrowser_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamHTMLSurface>.NativeClassPtr, 100663949);
			ISteamHTMLSurface.NativeMethodInfoPtr__FileLoadDialogResponse_Private_Static_Void_IntPtr_HHTMLBrowser_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamHTMLSurface>.NativeClassPtr, 100663950);
			ISteamHTMLSurface.NativeMethodInfoPtr_FileLoadDialogResponse_Internal_Void_HHTMLBrowser_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamHTMLSurface>.NativeClassPtr, 100663951);
		}

		// Token: 0x0600026B RID: 619 RVA: 0x0001CE18 File Offset: 0x0001B018
		[CallerCount(22)]
		[CachedScanResults(RefRangeStart = 930944, RefRangeEnd = 930966, XrefRangeStart = 930944, XrefRangeEnd = 930966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ISteamHTMLSurface(bool IsGameServer)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ISteamHTMLSurface>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref IsGameServer;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamHTMLSurface.NativeMethodInfoPtr__ctor_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600026C RID: 620 RVA: 0x0001CE60 File Offset: 0x0001B060
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932434, XrefRangeEnd = 932436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr SteamAPI_SteamHTMLSurface_v005()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamHTMLSurface.NativeMethodInfoPtr_SteamAPI_SteamHTMLSurface_v005_Internal_Static_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600026D RID: 621 RVA: 0x0001CE90 File Offset: 0x0001B090
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IntPtr GetUserInterfacePointer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISteamHTMLSurface.NativeMethodInfoPtr_GetUserInterfacePointer_Public_Virtual_IntPtr_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600026E RID: 622 RVA: 0x0001CED8 File Offset: 0x0001B0D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932436, XrefRangeEnd = 932438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _Init(IntPtr self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamHTMLSurface.NativeMethodInfoPtr__Init_Private_Static_Boolean_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600026F RID: 623 RVA: 0x0001CF18 File Offset: 0x0001B118
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932438, XrefRangeEnd = 932440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamHTMLSurface.NativeMethodInfoPtr_Init_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000270 RID: 624 RVA: 0x0001CF54 File Offset: 0x0001B154
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932440, XrefRangeEnd = 932442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _Shutdown(IntPtr self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamHTMLSurface.NativeMethodInfoPtr__Shutdown_Private_Static_Boolean_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000271 RID: 625 RVA: 0x0001CF94 File Offset: 0x0001B194
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932442, XrefRangeEnd = 932444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Shutdown()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamHTMLSurface.NativeMethodInfoPtr_Shutdown_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000272 RID: 626 RVA: 0x0001CFD0 File Offset: 0x0001B1D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932444, XrefRangeEnd = 932449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SteamAPICall_t _CreateBrowser(IntPtr self, string pchUserAgent, string pchUserCSS)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchUserAgent);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchUserCSS);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamHTMLSurface.NativeMethodInfoPtr__CreateBrowser_Private_Static_SteamAPICall_t_IntPtr_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000273 RID: 627 RVA: 0x0001D034 File Offset: 0x0001B234
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932449, XrefRangeEnd = 932457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CallResult<HTML_BrowserReady_t> CreateBrowser(string pchUserAgent, string pchUserCSS)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pchUserAgent);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchUserCSS);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamHTMLSurface.NativeMethodInfoPtr_CreateBrowser_Internal_CallResult_1_HTML_BrowserReady_t_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new CallResult<HTML_BrowserReady_t>(intPtr);
		}

		// Token: 0x06000274 RID: 628 RVA: 0x0001D090 File Offset: 0x0001B290
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932457, XrefRangeEnd = 932459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _RemoveBrowser(IntPtr self, HHTMLBrowser unBrowserHandle)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unBrowserHandle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamHTMLSurface.NativeMethodInfoPtr__RemoveBrowser_Private_Static_Void_IntPtr_HHTMLBrowser_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000275 RID: 629 RVA: 0x0001D0D0 File Offset: 0x0001B2D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932459, XrefRangeEnd = 932461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveBrowser(HHTMLBrowser unBrowserHandle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unBrowserHandle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamHTMLSurface.NativeMethodInfoPtr_RemoveBrowser_Internal_Void_HHTMLBrowser_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000276 RID: 630 RVA: 0x0001D110 File Offset: 0x0001B310
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932461, XrefRangeEnd = 932466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _LoadURL(IntPtr self, HHTMLBrowser unBrowserHandle, string pchURL, string pchPostData)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unBrowserHandle;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchURL);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchPostData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamHTMLSurface.NativeMethodInfoPtr__LoadURL_Private_Static_Void_IntPtr_HHTMLBrowser_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000277 RID: 631 RVA: 0x0001D174 File Offset: 0x0001B374
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932466, XrefRangeEnd = 932471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadURL(HHTMLBrowser unBrowserHandle, string pchURL, string pchPostData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unBrowserHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchURL);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchPostData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamHTMLSurface.NativeMethodInfoPtr_LoadURL_Internal_Void_HHTMLBrowser_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000278 RID: 632 RVA: 0x0001D1D8 File Offset: 0x0001B3D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932471, XrefRangeEnd = 932473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _SetSize(IntPtr self, HHTMLBrowser unBrowserHandle, uint unWidth, uint unHeight)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unBrowserHandle;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unWidth;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unHeight;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamHTMLSurface.NativeMethodInfoPtr__SetSize_Private_Static_Void_IntPtr_HHTMLBrowser_UInt32_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000279 RID: 633 RVA: 0x0001D234 File Offset: 0x0001B434
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932473, XrefRangeEnd = 932475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSize(HHTMLBrowser unBrowserHandle, uint unWidth, uint unHeight)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unBrowserHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unWidth;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unHeight;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamHTMLSurface.NativeMethodInfoPtr_SetSize_Internal_Void_HHTMLBrowser_UInt32_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600027A RID: 634 RVA: 0x0001D290 File Offset: 0x0001B490
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932475, XrefRangeEnd = 932477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _StopLoad(IntPtr self, HHTMLBrowser unBrowserHandle)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unBrowserHandle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamHTMLSurface.NativeMethodInfoPtr__StopLoad_Private_Static_Void_IntPtr_HHTMLBrowser_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600027B RID: 635 RVA: 0x0001D2D0 File Offset: 0x0001B4D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932477, XrefRangeEnd = 932479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopLoad(HHTMLBrowser unBrowserHandle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unBrowserHandle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamHTMLSurface.NativeMethodInfoPtr_StopLoad_Internal_Void_HHTMLBrowser_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600027C RID: 636 RVA: 0x0001D310 File Offset: 0x0001B510
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932479, XrefRangeEnd = 932481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _Reload(IntPtr self, HHTMLBrowser unBrowserHandle)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unBrowserHandle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamHTMLSurface.NativeMethodInfoPtr__Reload_Private_Static_Void_IntPtr_HHTMLBrowser_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600027D RID: 637 RVA: 0x0001D350 File Offset: 0x0001B550
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932481, XrefRangeEnd = 932483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Reload(HHTMLBrowser unBrowserHandle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unBrowserHandle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamHTMLSurface.NativeMethodInfoPtr_Reload_Internal_Void_HHTMLBrowser_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600027E RID: 638 RVA: 0x0001D390 File Offset: 0x0001B590
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932483, XrefRangeEnd = 932485, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _GoBack(IntPtr self, HHTMLBrowser unBrowserHandle)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unBrowserHandle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamHTMLSurface.NativeMethodInfoPtr__GoBack_Private_Static_Void_IntPtr_HHTMLBrowser_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600027F RID: 639 RVA: 0x0001D3D0 File Offset: 0x0001B5D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932485, XrefRangeEnd = 932487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GoBack(HHTMLBrowser unBrowserHandle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unBrowserHandle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamHTMLSurface.NativeMethodInfoPtr_GoBack_Internal_Void_HHTMLBrowser_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000280 RID: 640 RVA: 0x0001D410 File Offset: 0x0001B610
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932487, XrefRangeEnd = 932489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _GoForward(IntPtr self, HHTMLBrowser unBrowserHandle)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unBrowserHandle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamHTMLSurface.NativeMethodInfoPtr__GoForward_Private_Static_Void_IntPtr_HHTMLBrowser_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000281 RID: 641 RVA: 0x0001D450 File Offset: 0x0001B650
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932489, XrefRangeEnd = 932491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GoForward(HHTMLBrowser unBrowserHandle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unBrowserHandle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamHTMLSurface.NativeMethodInfoPtr_GoForward_Internal_Void_HHTMLBrowser_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000282 RID: 642 RVA: 0x0001D490 File Offset: 0x0001B690
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932491, XrefRangeEnd = 932496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _AddHeader(IntPtr self, HHTMLBrowser unBrowserHandle, string pchKey, string pchValue)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unBrowserHandle;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchKey);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchValue);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamHTMLSurface.NativeMethodInfoPtr__AddHeader_Private_Static_Void_IntPtr_HHTMLBrowser_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000283 RID: 643 RVA: 0x0001D4F4 File Offset: 0x0001B6F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932496, XrefRangeEnd = 932501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddHeader(HHTMLBrowser unBrowserHandle, string pchKey, string pchValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unBrowserHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchKey);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchValue);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamHTMLSurface.NativeMethodInfoPtr_AddHeader_Internal_Void_HHTMLBrowser_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000284 RID: 644 RVA: 0x0001D558 File Offset: 0x0001B758
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932501, XrefRangeEnd = 932504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _ExecuteJavascript(IntPtr self, HHTMLBrowser unBrowserHandle, string pchScript)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unBrowserHandle;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchScript);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamHTMLSurface.NativeMethodInfoPtr__ExecuteJavascript_Private_Static_Void_IntPtr_HHTMLBrowser_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000285 RID: 645 RVA: 0x0001D5AC File Offset: 0x0001B7AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932504, XrefRangeEnd = 932507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ExecuteJavascript(HHTMLBrowser unBrowserHandle, string pchScript)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unBrowserHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchScript);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamHTMLSurface.NativeMethodInfoPtr_ExecuteJavascript_Internal_Void_HHTMLBrowser_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000286 RID: 646 RVA: 0x0001D5FC File Offset: 0x0001B7FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932507, XrefRangeEnd = 932509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _MouseUp(IntPtr self, HHTMLBrowser unBrowserHandle, IntPtr eMouseButton)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unBrowserHandle;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eMouseButton;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamHTMLSurface.NativeMethodInfoPtr__MouseUp_Private_Static_Void_IntPtr_HHTMLBrowser_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000287 RID: 647 RVA: 0x0001D64C File Offset: 0x0001B84C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932509, XrefRangeEnd = 932511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MouseUp(HHTMLBrowser unBrowserHandle, IntPtr eMouseButton)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unBrowserHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eMouseButton;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamHTMLSurface.NativeMethodInfoPtr_MouseUp_Internal_Void_HHTMLBrowser_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000288 RID: 648 RVA: 0x0001D698 File Offset: 0x0001B898
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932511, XrefRangeEnd = 932513, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _MouseDown(IntPtr self, HHTMLBrowser unBrowserHandle, IntPtr eMouseButton)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unBrowserHandle;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eMouseButton;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamHTMLSurface.NativeMethodInfoPtr__MouseDown_Private_Static_Void_IntPtr_HHTMLBrowser_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000289 RID: 649 RVA: 0x0001D6E8 File Offset: 0x0001B8E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932513, XrefRangeEnd = 932515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MouseDown(HHTMLBrowser unBrowserHandle, IntPtr eMouseButton)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unBrowserHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eMouseButton;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamHTMLSurface.NativeMethodInfoPtr_MouseDown_Internal_Void_HHTMLBrowser_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600028A RID: 650 RVA: 0x0001D734 File Offset: 0x0001B934
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932515, XrefRangeEnd = 932517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _MouseDoubleClick(IntPtr self, HHTMLBrowser unBrowserHandle, IntPtr eMouseButton)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unBrowserHandle;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eMouseButton;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamHTMLSurface.NativeMethodInfoPtr__MouseDoubleClick_Private_Static_Void_IntPtr_HHTMLBrowser_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600028B RID: 651 RVA: 0x0001D784 File Offset: 0x0001B984
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932517, XrefRangeEnd = 932519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MouseDoubleClick(HHTMLBrowser unBrowserHandle, IntPtr eMouseButton)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unBrowserHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eMouseButton;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamHTMLSurface.NativeMethodInfoPtr_MouseDoubleClick_Internal_Void_HHTMLBrowser_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600028C RID: 652 RVA: 0x0001D7D0 File Offset: 0x0001B9D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932519, XrefRangeEnd = 932521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _MouseMove(IntPtr self, HHTMLBrowser unBrowserHandle, int x, int y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unBrowserHandle;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref x;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamHTMLSurface.NativeMethodInfoPtr__MouseMove_Private_Static_Void_IntPtr_HHTMLBrowser_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600028D RID: 653 RVA: 0x0001D82C File Offset: 0x0001BA2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932521, XrefRangeEnd = 932523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MouseMove(HHTMLBrowser unBrowserHandle, int x, int y)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unBrowserHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref x;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamHTMLSurface.NativeMethodInfoPtr_MouseMove_Internal_Void_HHTMLBrowser_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600028E RID: 654 RVA: 0x0001D888 File Offset: 0x0001BA88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932523, XrefRangeEnd = 932525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _MouseWheel(IntPtr self, HHTMLBrowser unBrowserHandle, int nDelta)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unBrowserHandle;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nDelta;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamHTMLSurface.NativeMethodInfoPtr__MouseWheel_Private_Static_Void_IntPtr_HHTMLBrowser_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600028F RID: 655 RVA: 0x0001D8D8 File Offset: 0x0001BAD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932525, XrefRangeEnd = 932527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MouseWheel(HHTMLBrowser unBrowserHandle, int nDelta)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unBrowserHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nDelta;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamHTMLSurface.NativeMethodInfoPtr_MouseWheel_Internal_Void_HHTMLBrowser_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000290 RID: 656 RVA: 0x0001D924 File Offset: 0x0001BB24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932527, XrefRangeEnd = 932529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _KeyDown(IntPtr self, HHTMLBrowser unBrowserHandle, uint nNativeKeyCode, IntPtr eHTMLKeyModifiers, bool bIsSystemKey)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unBrowserHandle;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nNativeKeyCode;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eHTMLKeyModifiers;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bIsSystemKey;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamHTMLSurface.NativeMethodInfoPtr__KeyDown_Private_Static_Void_IntPtr_HHTMLBrowser_UInt32_IntPtr_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000291 RID: 657 RVA: 0x0001D990 File Offset: 0x0001BB90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932529, XrefRangeEnd = 932531, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void KeyDown(HHTMLBrowser unBrowserHandle, uint nNativeKeyCode, IntPtr eHTMLKeyModifiers, bool bIsSystemKey)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unBrowserHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nNativeKeyCode;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eHTMLKeyModifiers;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bIsSystemKey;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamHTMLSurface.NativeMethodInfoPtr_KeyDown_Internal_Void_HHTMLBrowser_UInt32_IntPtr_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000292 RID: 658 RVA: 0x0001D9F8 File Offset: 0x0001BBF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932531, XrefRangeEnd = 932533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _KeyUp(IntPtr self, HHTMLBrowser unBrowserHandle, uint nNativeKeyCode, IntPtr eHTMLKeyModifiers)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unBrowserHandle;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nNativeKeyCode;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eHTMLKeyModifiers;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamHTMLSurface.NativeMethodInfoPtr__KeyUp_Private_Static_Void_IntPtr_HHTMLBrowser_UInt32_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000293 RID: 659 RVA: 0x0001DA54 File Offset: 0x0001BC54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932533, XrefRangeEnd = 932535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void KeyUp(HHTMLBrowser unBrowserHandle, uint nNativeKeyCode, IntPtr eHTMLKeyModifiers)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unBrowserHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nNativeKeyCode;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eHTMLKeyModifiers;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamHTMLSurface.NativeMethodInfoPtr_KeyUp_Internal_Void_HHTMLBrowser_UInt32_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000294 RID: 660 RVA: 0x0001DAB0 File Offset: 0x0001BCB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932535, XrefRangeEnd = 932537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _KeyChar(IntPtr self, HHTMLBrowser unBrowserHandle, uint cUnicodeChar, IntPtr eHTMLKeyModifiers)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unBrowserHandle;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cUnicodeChar;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eHTMLKeyModifiers;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamHTMLSurface.NativeMethodInfoPtr__KeyChar_Private_Static_Void_IntPtr_HHTMLBrowser_UInt32_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000295 RID: 661 RVA: 0x0001DB0C File Offset: 0x0001BD0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932537, XrefRangeEnd = 932539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void KeyChar(HHTMLBrowser unBrowserHandle, uint cUnicodeChar, IntPtr eHTMLKeyModifiers)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unBrowserHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cUnicodeChar;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eHTMLKeyModifiers;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamHTMLSurface.NativeMethodInfoPtr_KeyChar_Internal_Void_HHTMLBrowser_UInt32_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000296 RID: 662 RVA: 0x0001DB68 File Offset: 0x0001BD68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932539, XrefRangeEnd = 932541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _SetHorizontalScroll(IntPtr self, HHTMLBrowser unBrowserHandle, uint nAbsolutePixelScroll)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unBrowserHandle;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nAbsolutePixelScroll;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamHTMLSurface.NativeMethodInfoPtr__SetHorizontalScroll_Private_Static_Void_IntPtr_HHTMLBrowser_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000297 RID: 663 RVA: 0x0001DBB8 File Offset: 0x0001BDB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932541, XrefRangeEnd = 932543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetHorizontalScroll(HHTMLBrowser unBrowserHandle, uint nAbsolutePixelScroll)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unBrowserHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nAbsolutePixelScroll;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamHTMLSurface.NativeMethodInfoPtr_SetHorizontalScroll_Internal_Void_HHTMLBrowser_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000298 RID: 664 RVA: 0x0001DC04 File Offset: 0x0001BE04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932543, XrefRangeEnd = 932545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _SetVerticalScroll(IntPtr self, HHTMLBrowser unBrowserHandle, uint nAbsolutePixelScroll)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unBrowserHandle;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nAbsolutePixelScroll;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamHTMLSurface.NativeMethodInfoPtr__SetVerticalScroll_Private_Static_Void_IntPtr_HHTMLBrowser_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000299 RID: 665 RVA: 0x0001DC54 File Offset: 0x0001BE54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932545, XrefRangeEnd = 932547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVerticalScroll(HHTMLBrowser unBrowserHandle, uint nAbsolutePixelScroll)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unBrowserHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nAbsolutePixelScroll;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamHTMLSurface.NativeMethodInfoPtr_SetVerticalScroll_Internal_Void_HHTMLBrowser_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600029A RID: 666 RVA: 0x0001DCA0 File Offset: 0x0001BEA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932547, XrefRangeEnd = 932549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _SetKeyFocus(IntPtr self, HHTMLBrowser unBrowserHandle, bool bHasKeyFocus)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unBrowserHandle;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bHasKeyFocus;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamHTMLSurface.NativeMethodInfoPtr__SetKeyFocus_Private_Static_Void_IntPtr_HHTMLBrowser_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600029B RID: 667 RVA: 0x0001DCF0 File Offset: 0x0001BEF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932549, XrefRangeEnd = 932551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetKeyFocus(HHTMLBrowser unBrowserHandle, bool bHasKeyFocus)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unBrowserHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bHasKeyFocus;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamHTMLSurface.NativeMethodInfoPtr_SetKeyFocus_Internal_Void_HHTMLBrowser_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600029C RID: 668 RVA: 0x0001DD3C File Offset: 0x0001BF3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932551, XrefRangeEnd = 932553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _ViewSource(IntPtr self, HHTMLBrowser unBrowserHandle)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unBrowserHandle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamHTMLSurface.NativeMethodInfoPtr__ViewSource_Private_Static_Void_IntPtr_HHTMLBrowser_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600029D RID: 669 RVA: 0x0001DD7C File Offset: 0x0001BF7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932553, XrefRangeEnd = 932555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ViewSource(HHTMLBrowser unBrowserHandle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unBrowserHandle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamHTMLSurface.NativeMethodInfoPtr_ViewSource_Internal_Void_HHTMLBrowser_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600029E RID: 670 RVA: 0x0001DDBC File Offset: 0x0001BFBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932555, XrefRangeEnd = 932557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _CopyToClipboard(IntPtr self, HHTMLBrowser unBrowserHandle)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unBrowserHandle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamHTMLSurface.NativeMethodInfoPtr__CopyToClipboard_Private_Static_Void_IntPtr_HHTMLBrowser_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600029F RID: 671 RVA: 0x0001DDFC File Offset: 0x0001BFFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932557, XrefRangeEnd = 932559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CopyToClipboard(HHTMLBrowser unBrowserHandle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unBrowserHandle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamHTMLSurface.NativeMethodInfoPtr_CopyToClipboard_Internal_Void_HHTMLBrowser_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002A0 RID: 672 RVA: 0x0001DE3C File Offset: 0x0001C03C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932559, XrefRangeEnd = 932561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _PasteFromClipboard(IntPtr self, HHTMLBrowser unBrowserHandle)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unBrowserHandle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamHTMLSurface.NativeMethodInfoPtr__PasteFromClipboard_Private_Static_Void_IntPtr_HHTMLBrowser_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002A1 RID: 673 RVA: 0x0001DE7C File Offset: 0x0001C07C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932561, XrefRangeEnd = 932563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PasteFromClipboard(HHTMLBrowser unBrowserHandle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unBrowserHandle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamHTMLSurface.NativeMethodInfoPtr_PasteFromClipboard_Internal_Void_HHTMLBrowser_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002A2 RID: 674 RVA: 0x0001DEBC File Offset: 0x0001C0BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932563, XrefRangeEnd = 932566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _Find(IntPtr self, HHTMLBrowser unBrowserHandle, string pchSearchStr, bool bCurrentlyInFind, bool bReverse)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unBrowserHandle;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchSearchStr);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bCurrentlyInFind;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bReverse;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamHTMLSurface.NativeMethodInfoPtr__Find_Private_Static_Void_IntPtr_HHTMLBrowser_String_Boolean_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002A3 RID: 675 RVA: 0x0001DF2C File Offset: 0x0001C12C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932566, XrefRangeEnd = 932569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Find(HHTMLBrowser unBrowserHandle, string pchSearchStr, bool bCurrentlyInFind, bool bReverse)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unBrowserHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchSearchStr);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bCurrentlyInFind;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bReverse;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamHTMLSurface.NativeMethodInfoPtr_Find_Internal_Void_HHTMLBrowser_String_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002A4 RID: 676 RVA: 0x0001DF98 File Offset: 0x0001C198
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932569, XrefRangeEnd = 932571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _StopFind(IntPtr self, HHTMLBrowser unBrowserHandle)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unBrowserHandle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamHTMLSurface.NativeMethodInfoPtr__StopFind_Private_Static_Void_IntPtr_HHTMLBrowser_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002A5 RID: 677 RVA: 0x0001DFD8 File Offset: 0x0001C1D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932571, XrefRangeEnd = 932573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopFind(HHTMLBrowser unBrowserHandle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unBrowserHandle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamHTMLSurface.NativeMethodInfoPtr_StopFind_Internal_Void_HHTMLBrowser_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002A6 RID: 678 RVA: 0x0001E018 File Offset: 0x0001C218
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932573, XrefRangeEnd = 932575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _GetLinkAtPosition(IntPtr self, HHTMLBrowser unBrowserHandle, int x, int y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unBrowserHandle;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref x;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamHTMLSurface.NativeMethodInfoPtr__GetLinkAtPosition_Private_Static_Void_IntPtr_HHTMLBrowser_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002A7 RID: 679 RVA: 0x0001E074 File Offset: 0x0001C274
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932575, XrefRangeEnd = 932577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetLinkAtPosition(HHTMLBrowser unBrowserHandle, int x, int y)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unBrowserHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref x;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamHTMLSurface.NativeMethodInfoPtr_GetLinkAtPosition_Internal_Void_HHTMLBrowser_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002A8 RID: 680 RVA: 0x0001E0D0 File Offset: 0x0001C2D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932577, XrefRangeEnd = 932586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _SetCookie(IntPtr self, string pchHostname, string pchKey, string pchValue, string pchPath, RTime32 nExpires, bool bSecure, bool bHTTPOnly)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchHostname);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchKey);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchValue);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchPath);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nExpires;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bSecure;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bHTTPOnly;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamHTMLSurface.NativeMethodInfoPtr__SetCookie_Private_Static_Void_IntPtr_String_String_String_String_RTime32_Boolean_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002A9 RID: 681 RVA: 0x0001E178 File Offset: 0x0001C378
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932586, XrefRangeEnd = 932595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCookie(string pchHostname, string pchKey, string pchValue, string pchPath, RTime32 nExpires, bool bSecure, bool bHTTPOnly)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pchHostname);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchKey);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchValue);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchPath);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nExpires;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bSecure;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bHTTPOnly;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamHTMLSurface.NativeMethodInfoPtr_SetCookie_Internal_Void_String_String_String_String_RTime32_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002AA RID: 682 RVA: 0x0001E21C File Offset: 0x0001C41C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932595, XrefRangeEnd = 932597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _SetPageScaleFactor(IntPtr self, HHTMLBrowser unBrowserHandle, float flZoom, int nPointX, int nPointY)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unBrowserHandle;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flZoom;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nPointX;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nPointY;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamHTMLSurface.NativeMethodInfoPtr__SetPageScaleFactor_Private_Static_Void_IntPtr_HHTMLBrowser_Single_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002AB RID: 683 RVA: 0x0001E288 File Offset: 0x0001C488
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932597, XrefRangeEnd = 932599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPageScaleFactor(HHTMLBrowser unBrowserHandle, float flZoom, int nPointX, int nPointY)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unBrowserHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flZoom;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nPointX;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nPointY;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamHTMLSurface.NativeMethodInfoPtr_SetPageScaleFactor_Internal_Void_HHTMLBrowser_Single_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002AC RID: 684 RVA: 0x0001E2F0 File Offset: 0x0001C4F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932599, XrefRangeEnd = 932601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _SetBackgroundMode(IntPtr self, HHTMLBrowser unBrowserHandle, bool bBackgroundMode)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unBrowserHandle;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bBackgroundMode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamHTMLSurface.NativeMethodInfoPtr__SetBackgroundMode_Private_Static_Void_IntPtr_HHTMLBrowser_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002AD RID: 685 RVA: 0x0001E340 File Offset: 0x0001C540
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932601, XrefRangeEnd = 932603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetBackgroundMode(HHTMLBrowser unBrowserHandle, bool bBackgroundMode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unBrowserHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bBackgroundMode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamHTMLSurface.NativeMethodInfoPtr_SetBackgroundMode_Internal_Void_HHTMLBrowser_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002AE RID: 686 RVA: 0x0001E38C File Offset: 0x0001C58C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932603, XrefRangeEnd = 932605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _SetDPIScalingFactor(IntPtr self, HHTMLBrowser unBrowserHandle, float flDPIScaling)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unBrowserHandle;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flDPIScaling;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamHTMLSurface.NativeMethodInfoPtr__SetDPIScalingFactor_Private_Static_Void_IntPtr_HHTMLBrowser_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002AF RID: 687 RVA: 0x0001E3DC File Offset: 0x0001C5DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932605, XrefRangeEnd = 932607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDPIScalingFactor(HHTMLBrowser unBrowserHandle, float flDPIScaling)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unBrowserHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flDPIScaling;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamHTMLSurface.NativeMethodInfoPtr_SetDPIScalingFactor_Internal_Void_HHTMLBrowser_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002B0 RID: 688 RVA: 0x0001E428 File Offset: 0x0001C628
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932607, XrefRangeEnd = 932609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _OpenDeveloperTools(IntPtr self, HHTMLBrowser unBrowserHandle)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unBrowserHandle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamHTMLSurface.NativeMethodInfoPtr__OpenDeveloperTools_Private_Static_Void_IntPtr_HHTMLBrowser_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002B1 RID: 689 RVA: 0x0001E468 File Offset: 0x0001C668
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932609, XrefRangeEnd = 932611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OpenDeveloperTools(HHTMLBrowser unBrowserHandle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unBrowserHandle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamHTMLSurface.NativeMethodInfoPtr_OpenDeveloperTools_Internal_Void_HHTMLBrowser_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002B2 RID: 690 RVA: 0x0001E4A8 File Offset: 0x0001C6A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932611, XrefRangeEnd = 932613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _AllowStartRequest(IntPtr self, HHTMLBrowser unBrowserHandle, bool bAllowed)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unBrowserHandle;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bAllowed;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamHTMLSurface.NativeMethodInfoPtr__AllowStartRequest_Private_Static_Void_IntPtr_HHTMLBrowser_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002B3 RID: 691 RVA: 0x0001E4F8 File Offset: 0x0001C6F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932613, XrefRangeEnd = 932615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AllowStartRequest(HHTMLBrowser unBrowserHandle, bool bAllowed)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unBrowserHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bAllowed;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamHTMLSurface.NativeMethodInfoPtr_AllowStartRequest_Internal_Void_HHTMLBrowser_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002B4 RID: 692 RVA: 0x0001E544 File Offset: 0x0001C744
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932615, XrefRangeEnd = 932617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _JSDialogResponse(IntPtr self, HHTMLBrowser unBrowserHandle, bool bResult)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unBrowserHandle;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bResult;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamHTMLSurface.NativeMethodInfoPtr__JSDialogResponse_Private_Static_Void_IntPtr_HHTMLBrowser_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002B5 RID: 693 RVA: 0x0001E594 File Offset: 0x0001C794
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932617, XrefRangeEnd = 932619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void JSDialogResponse(HHTMLBrowser unBrowserHandle, bool bResult)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unBrowserHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bResult;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamHTMLSurface.NativeMethodInfoPtr_JSDialogResponse_Internal_Void_HHTMLBrowser_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002B6 RID: 694 RVA: 0x0001E5E0 File Offset: 0x0001C7E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932619, XrefRangeEnd = 932622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _FileLoadDialogResponse(IntPtr self, HHTMLBrowser unBrowserHandle, string pchSelectedFiles)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unBrowserHandle;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchSelectedFiles);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamHTMLSurface.NativeMethodInfoPtr__FileLoadDialogResponse_Private_Static_Void_IntPtr_HHTMLBrowser_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002B7 RID: 695 RVA: 0x0001E634 File Offset: 0x0001C834
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932622, XrefRangeEnd = 932625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FileLoadDialogResponse(HHTMLBrowser unBrowserHandle, string pchSelectedFiles)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unBrowserHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchSelectedFiles);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamHTMLSurface.NativeMethodInfoPtr_FileLoadDialogResponse_Internal_Void_HHTMLBrowser_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002B8 RID: 696 RVA: 0x0000231B File Offset: 0x0000051B
		public ISteamHTMLSurface(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000309 RID: 777
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Boolean_0;

		// Token: 0x0400030A RID: 778
		private static readonly IntPtr NativeMethodInfoPtr_SteamAPI_SteamHTMLSurface_v005_Internal_Static_IntPtr_0;

		// Token: 0x0400030B RID: 779
		private static readonly IntPtr NativeMethodInfoPtr_GetUserInterfacePointer_Public_Virtual_IntPtr_0;

		// Token: 0x0400030C RID: 780
		private static readonly IntPtr NativeMethodInfoPtr__Init_Private_Static_Boolean_IntPtr_0;

		// Token: 0x0400030D RID: 781
		private static readonly IntPtr NativeMethodInfoPtr_Init_Internal_Boolean_0;

		// Token: 0x0400030E RID: 782
		private static readonly IntPtr NativeMethodInfoPtr__Shutdown_Private_Static_Boolean_IntPtr_0;

		// Token: 0x0400030F RID: 783
		private static readonly IntPtr NativeMethodInfoPtr_Shutdown_Internal_Boolean_0;

		// Token: 0x04000310 RID: 784
		private static readonly IntPtr NativeMethodInfoPtr__CreateBrowser_Private_Static_SteamAPICall_t_IntPtr_String_String_0;

		// Token: 0x04000311 RID: 785
		private static readonly IntPtr NativeMethodInfoPtr_CreateBrowser_Internal_CallResult_1_HTML_BrowserReady_t_String_String_0;

		// Token: 0x04000312 RID: 786
		private static readonly IntPtr NativeMethodInfoPtr__RemoveBrowser_Private_Static_Void_IntPtr_HHTMLBrowser_0;

		// Token: 0x04000313 RID: 787
		private static readonly IntPtr NativeMethodInfoPtr_RemoveBrowser_Internal_Void_HHTMLBrowser_0;

		// Token: 0x04000314 RID: 788
		private static readonly IntPtr NativeMethodInfoPtr__LoadURL_Private_Static_Void_IntPtr_HHTMLBrowser_String_String_0;

		// Token: 0x04000315 RID: 789
		private static readonly IntPtr NativeMethodInfoPtr_LoadURL_Internal_Void_HHTMLBrowser_String_String_0;

		// Token: 0x04000316 RID: 790
		private static readonly IntPtr NativeMethodInfoPtr__SetSize_Private_Static_Void_IntPtr_HHTMLBrowser_UInt32_UInt32_0;

		// Token: 0x04000317 RID: 791
		private static readonly IntPtr NativeMethodInfoPtr_SetSize_Internal_Void_HHTMLBrowser_UInt32_UInt32_0;

		// Token: 0x04000318 RID: 792
		private static readonly IntPtr NativeMethodInfoPtr__StopLoad_Private_Static_Void_IntPtr_HHTMLBrowser_0;

		// Token: 0x04000319 RID: 793
		private static readonly IntPtr NativeMethodInfoPtr_StopLoad_Internal_Void_HHTMLBrowser_0;

		// Token: 0x0400031A RID: 794
		private static readonly IntPtr NativeMethodInfoPtr__Reload_Private_Static_Void_IntPtr_HHTMLBrowser_0;

		// Token: 0x0400031B RID: 795
		private static readonly IntPtr NativeMethodInfoPtr_Reload_Internal_Void_HHTMLBrowser_0;

		// Token: 0x0400031C RID: 796
		private static readonly IntPtr NativeMethodInfoPtr__GoBack_Private_Static_Void_IntPtr_HHTMLBrowser_0;

		// Token: 0x0400031D RID: 797
		private static readonly IntPtr NativeMethodInfoPtr_GoBack_Internal_Void_HHTMLBrowser_0;

		// Token: 0x0400031E RID: 798
		private static readonly IntPtr NativeMethodInfoPtr__GoForward_Private_Static_Void_IntPtr_HHTMLBrowser_0;

		// Token: 0x0400031F RID: 799
		private static readonly IntPtr NativeMethodInfoPtr_GoForward_Internal_Void_HHTMLBrowser_0;

		// Token: 0x04000320 RID: 800
		private static readonly IntPtr NativeMethodInfoPtr__AddHeader_Private_Static_Void_IntPtr_HHTMLBrowser_String_String_0;

		// Token: 0x04000321 RID: 801
		private static readonly IntPtr NativeMethodInfoPtr_AddHeader_Internal_Void_HHTMLBrowser_String_String_0;

		// Token: 0x04000322 RID: 802
		private static readonly IntPtr NativeMethodInfoPtr__ExecuteJavascript_Private_Static_Void_IntPtr_HHTMLBrowser_String_0;

		// Token: 0x04000323 RID: 803
		private static readonly IntPtr NativeMethodInfoPtr_ExecuteJavascript_Internal_Void_HHTMLBrowser_String_0;

		// Token: 0x04000324 RID: 804
		private static readonly IntPtr NativeMethodInfoPtr__MouseUp_Private_Static_Void_IntPtr_HHTMLBrowser_IntPtr_0;

		// Token: 0x04000325 RID: 805
		private static readonly IntPtr NativeMethodInfoPtr_MouseUp_Internal_Void_HHTMLBrowser_IntPtr_0;

		// Token: 0x04000326 RID: 806
		private static readonly IntPtr NativeMethodInfoPtr__MouseDown_Private_Static_Void_IntPtr_HHTMLBrowser_IntPtr_0;

		// Token: 0x04000327 RID: 807
		private static readonly IntPtr NativeMethodInfoPtr_MouseDown_Internal_Void_HHTMLBrowser_IntPtr_0;

		// Token: 0x04000328 RID: 808
		private static readonly IntPtr NativeMethodInfoPtr__MouseDoubleClick_Private_Static_Void_IntPtr_HHTMLBrowser_IntPtr_0;

		// Token: 0x04000329 RID: 809
		private static readonly IntPtr NativeMethodInfoPtr_MouseDoubleClick_Internal_Void_HHTMLBrowser_IntPtr_0;

		// Token: 0x0400032A RID: 810
		private static readonly IntPtr NativeMethodInfoPtr__MouseMove_Private_Static_Void_IntPtr_HHTMLBrowser_Int32_Int32_0;

		// Token: 0x0400032B RID: 811
		private static readonly IntPtr NativeMethodInfoPtr_MouseMove_Internal_Void_HHTMLBrowser_Int32_Int32_0;

		// Token: 0x0400032C RID: 812
		private static readonly IntPtr NativeMethodInfoPtr__MouseWheel_Private_Static_Void_IntPtr_HHTMLBrowser_Int32_0;

		// Token: 0x0400032D RID: 813
		private static readonly IntPtr NativeMethodInfoPtr_MouseWheel_Internal_Void_HHTMLBrowser_Int32_0;

		// Token: 0x0400032E RID: 814
		private static readonly IntPtr NativeMethodInfoPtr__KeyDown_Private_Static_Void_IntPtr_HHTMLBrowser_UInt32_IntPtr_Boolean_0;

		// Token: 0x0400032F RID: 815
		private static readonly IntPtr NativeMethodInfoPtr_KeyDown_Internal_Void_HHTMLBrowser_UInt32_IntPtr_Boolean_0;

		// Token: 0x04000330 RID: 816
		private static readonly IntPtr NativeMethodInfoPtr__KeyUp_Private_Static_Void_IntPtr_HHTMLBrowser_UInt32_IntPtr_0;

		// Token: 0x04000331 RID: 817
		private static readonly IntPtr NativeMethodInfoPtr_KeyUp_Internal_Void_HHTMLBrowser_UInt32_IntPtr_0;

		// Token: 0x04000332 RID: 818
		private static readonly IntPtr NativeMethodInfoPtr__KeyChar_Private_Static_Void_IntPtr_HHTMLBrowser_UInt32_IntPtr_0;

		// Token: 0x04000333 RID: 819
		private static readonly IntPtr NativeMethodInfoPtr_KeyChar_Internal_Void_HHTMLBrowser_UInt32_IntPtr_0;

		// Token: 0x04000334 RID: 820
		private static readonly IntPtr NativeMethodInfoPtr__SetHorizontalScroll_Private_Static_Void_IntPtr_HHTMLBrowser_UInt32_0;

		// Token: 0x04000335 RID: 821
		private static readonly IntPtr NativeMethodInfoPtr_SetHorizontalScroll_Internal_Void_HHTMLBrowser_UInt32_0;

		// Token: 0x04000336 RID: 822
		private static readonly IntPtr NativeMethodInfoPtr__SetVerticalScroll_Private_Static_Void_IntPtr_HHTMLBrowser_UInt32_0;

		// Token: 0x04000337 RID: 823
		private static readonly IntPtr NativeMethodInfoPtr_SetVerticalScroll_Internal_Void_HHTMLBrowser_UInt32_0;

		// Token: 0x04000338 RID: 824
		private static readonly IntPtr NativeMethodInfoPtr__SetKeyFocus_Private_Static_Void_IntPtr_HHTMLBrowser_Boolean_0;

		// Token: 0x04000339 RID: 825
		private static readonly IntPtr NativeMethodInfoPtr_SetKeyFocus_Internal_Void_HHTMLBrowser_Boolean_0;

		// Token: 0x0400033A RID: 826
		private static readonly IntPtr NativeMethodInfoPtr__ViewSource_Private_Static_Void_IntPtr_HHTMLBrowser_0;

		// Token: 0x0400033B RID: 827
		private static readonly IntPtr NativeMethodInfoPtr_ViewSource_Internal_Void_HHTMLBrowser_0;

		// Token: 0x0400033C RID: 828
		private static readonly IntPtr NativeMethodInfoPtr__CopyToClipboard_Private_Static_Void_IntPtr_HHTMLBrowser_0;

		// Token: 0x0400033D RID: 829
		private static readonly IntPtr NativeMethodInfoPtr_CopyToClipboard_Internal_Void_HHTMLBrowser_0;

		// Token: 0x0400033E RID: 830
		private static readonly IntPtr NativeMethodInfoPtr__PasteFromClipboard_Private_Static_Void_IntPtr_HHTMLBrowser_0;

		// Token: 0x0400033F RID: 831
		private static readonly IntPtr NativeMethodInfoPtr_PasteFromClipboard_Internal_Void_HHTMLBrowser_0;

		// Token: 0x04000340 RID: 832
		private static readonly IntPtr NativeMethodInfoPtr__Find_Private_Static_Void_IntPtr_HHTMLBrowser_String_Boolean_Boolean_0;

		// Token: 0x04000341 RID: 833
		private static readonly IntPtr NativeMethodInfoPtr_Find_Internal_Void_HHTMLBrowser_String_Boolean_Boolean_0;

		// Token: 0x04000342 RID: 834
		private static readonly IntPtr NativeMethodInfoPtr__StopFind_Private_Static_Void_IntPtr_HHTMLBrowser_0;

		// Token: 0x04000343 RID: 835
		private static readonly IntPtr NativeMethodInfoPtr_StopFind_Internal_Void_HHTMLBrowser_0;

		// Token: 0x04000344 RID: 836
		private static readonly IntPtr NativeMethodInfoPtr__GetLinkAtPosition_Private_Static_Void_IntPtr_HHTMLBrowser_Int32_Int32_0;

		// Token: 0x04000345 RID: 837
		private static readonly IntPtr NativeMethodInfoPtr_GetLinkAtPosition_Internal_Void_HHTMLBrowser_Int32_Int32_0;

		// Token: 0x04000346 RID: 838
		private static readonly IntPtr NativeMethodInfoPtr__SetCookie_Private_Static_Void_IntPtr_String_String_String_String_RTime32_Boolean_Boolean_0;

		// Token: 0x04000347 RID: 839
		private static readonly IntPtr NativeMethodInfoPtr_SetCookie_Internal_Void_String_String_String_String_RTime32_Boolean_Boolean_0;

		// Token: 0x04000348 RID: 840
		private static readonly IntPtr NativeMethodInfoPtr__SetPageScaleFactor_Private_Static_Void_IntPtr_HHTMLBrowser_Single_Int32_Int32_0;

		// Token: 0x04000349 RID: 841
		private static readonly IntPtr NativeMethodInfoPtr_SetPageScaleFactor_Internal_Void_HHTMLBrowser_Single_Int32_Int32_0;

		// Token: 0x0400034A RID: 842
		private static readonly IntPtr NativeMethodInfoPtr__SetBackgroundMode_Private_Static_Void_IntPtr_HHTMLBrowser_Boolean_0;

		// Token: 0x0400034B RID: 843
		private static readonly IntPtr NativeMethodInfoPtr_SetBackgroundMode_Internal_Void_HHTMLBrowser_Boolean_0;

		// Token: 0x0400034C RID: 844
		private static readonly IntPtr NativeMethodInfoPtr__SetDPIScalingFactor_Private_Static_Void_IntPtr_HHTMLBrowser_Single_0;

		// Token: 0x0400034D RID: 845
		private static readonly IntPtr NativeMethodInfoPtr_SetDPIScalingFactor_Internal_Void_HHTMLBrowser_Single_0;

		// Token: 0x0400034E RID: 846
		private static readonly IntPtr NativeMethodInfoPtr__OpenDeveloperTools_Private_Static_Void_IntPtr_HHTMLBrowser_0;

		// Token: 0x0400034F RID: 847
		private static readonly IntPtr NativeMethodInfoPtr_OpenDeveloperTools_Internal_Void_HHTMLBrowser_0;

		// Token: 0x04000350 RID: 848
		private static readonly IntPtr NativeMethodInfoPtr__AllowStartRequest_Private_Static_Void_IntPtr_HHTMLBrowser_Boolean_0;

		// Token: 0x04000351 RID: 849
		private static readonly IntPtr NativeMethodInfoPtr_AllowStartRequest_Internal_Void_HHTMLBrowser_Boolean_0;

		// Token: 0x04000352 RID: 850
		private static readonly IntPtr NativeMethodInfoPtr__JSDialogResponse_Private_Static_Void_IntPtr_HHTMLBrowser_Boolean_0;

		// Token: 0x04000353 RID: 851
		private static readonly IntPtr NativeMethodInfoPtr_JSDialogResponse_Internal_Void_HHTMLBrowser_Boolean_0;

		// Token: 0x04000354 RID: 852
		private static readonly IntPtr NativeMethodInfoPtr__FileLoadDialogResponse_Private_Static_Void_IntPtr_HHTMLBrowser_String_0;

		// Token: 0x04000355 RID: 853
		private static readonly IntPtr NativeMethodInfoPtr_FileLoadDialogResponse_Internal_Void_HHTMLBrowser_String_0;
	}
}
