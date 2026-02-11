using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Diagnostics;
using Il2CppSystem.Runtime.CompilerServices;
using Il2CppSystem.Threading.Tasks;
using Steamworks.Data;

namespace Steamworks.ServerList
{
	// Token: 0x020000D7 RID: 215
	public class Base : Object
	{
		// Token: 0x06000E5C RID: 3676 RVA: 0x00059F04 File Offset: 0x00058104
		// Note: this type is marked as 'beforefieldinit'.
		static Base()
		{
			Il2CppClassPointerStore<Base>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.ServerList", "Base");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Base>.NativeClassPtr);
			Base.NativeFieldInfoPtr__AppId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Base>.NativeClassPtr, "<AppId>k__BackingField");
			Base.NativeFieldInfoPtr_OnChanges = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Base>.NativeClassPtr, "OnChanges");
			Base.NativeFieldInfoPtr_OnResponsiveServer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Base>.NativeClassPtr, "OnResponsiveServer");
			Base.NativeFieldInfoPtr_Responsive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Base>.NativeClassPtr, "Responsive");
			Base.NativeFieldInfoPtr_Unresponsive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Base>.NativeClassPtr, "Unresponsive");
			Base.NativeFieldInfoPtr_request = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Base>.NativeClassPtr, "request");
			Base.NativeFieldInfoPtr_filters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Base>.NativeClassPtr, "filters");
			Base.NativeFieldInfoPtr_watchList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Base>.NativeClassPtr, "watchList");
			Base.NativeFieldInfoPtr_LastCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Base>.NativeClassPtr, "LastCount");
			Base.NativeMethodInfoPtr_get_Internal_Internal_Static_get_ISteamMatchmakingServers_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Base>.NativeClassPtr, 100666686);
			Base.NativeMethodInfoPtr_get_AppId_Public_get_AppId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Base>.NativeClassPtr, 100666687);
			Base.NativeMethodInfoPtr_set_AppId_Public_set_Void_AppId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Base>.NativeClassPtr, 100666688);
			Base.NativeMethodInfoPtr_add_OnChanges_Public_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Base>.NativeClassPtr, 100666689);
			Base.NativeMethodInfoPtr_remove_OnChanges_Public_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Base>.NativeClassPtr, 100666690);
			Base.NativeMethodInfoPtr_add_OnResponsiveServer_Public_add_Void_Action_1_ServerInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Base>.NativeClassPtr, 100666691);
			Base.NativeMethodInfoPtr_remove_OnResponsiveServer_Public_rem_Void_Action_1_ServerInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Base>.NativeClassPtr, 100666692);
			Base.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Base>.NativeClassPtr, 100666693);
			Base.NativeMethodInfoPtr_RunQueryAsync_Public_Virtual_New_Task_1_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Base>.NativeClassPtr, 100666694);
			Base.NativeMethodInfoPtr_Cancel_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Base>.NativeClassPtr, 100666695);
			Base.NativeMethodInfoPtr_LaunchQuery_Internal_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Base>.NativeClassPtr, 100666696);
			Base.NativeMethodInfoPtr_GetFilters_Internal_Virtual_New_Il2CppReferenceArray_1_MatchMakingKeyValuePair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Base>.NativeClassPtr, 100666697);
			Base.NativeMethodInfoPtr_AddFilter_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Base>.NativeClassPtr, 100666698);
			Base.NativeMethodInfoPtr_get_Count_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Base>.NativeClassPtr, 100666699);
			Base.NativeMethodInfoPtr_get_IsRefreshing_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Base>.NativeClassPtr, 100666700);
			Base.NativeMethodInfoPtr_Reset_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Base>.NativeClassPtr, 100666701);
			Base.NativeMethodInfoPtr_ReleaseQuery_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Base>.NativeClassPtr, 100666702);
			Base.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Base>.NativeClassPtr, 100666703);
			Base.NativeMethodInfoPtr_InvokeChanges_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Base>.NativeClassPtr, 100666704);
			Base.NativeMethodInfoPtr_UpdatePending_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Base>.NativeClassPtr, 100666705);
			Base.NativeMethodInfoPtr_UpdateResponsive_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Base>.NativeClassPtr, 100666706);
			Base.NativeMethodInfoPtr_MovePendingToUnresponsive_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Base>.NativeClassPtr, 100666707);
			Base.NativeMethodInfoPtr_OnServer_Private_Void_ServerInfo_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Base>.NativeClassPtr, 100666708);
			Base.NativeMethodInfoPtr__UpdateResponsive_b__33_0_Private_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Base>.NativeClassPtr, 100666709);
			Base.NativeMethodInfoPtr__MovePendingToUnresponsive_b__34_0_Private_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Base>.NativeClassPtr, 100666710);
		}

		// Token: 0x17000211 RID: 529
		// (get) Token: 0x06000E5D RID: 3677 RVA: 0x0005A1DC File Offset: 0x000583DC
		public unsafe static ISteamMatchmakingServers Internal
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 949795, XrefRangeEnd = 949796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Base.NativeMethodInfoPtr_get_Internal_Internal_Static_get_ISteamMatchmakingServers_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ISteamMatchmakingServers>(intPtr3) : null;
			}
		}

		// Token: 0x17000212 RID: 530
		// (get) Token: 0x06000E5E RID: 3678 RVA: 0x0005A210 File Offset: 0x00058410
		// (set) Token: 0x06000E5F RID: 3679 RVA: 0x0005A24C File Offset: 0x0005844C
		public unsafe AppId AppId
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 302497, RefRangeEnd = 302502, XrefRangeStart = 302497, XrefRangeEnd = 302502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Base.NativeMethodInfoPtr_get_AppId_Public_get_AppId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 307807, RefRangeEnd = 307812, XrefRangeStart = 307807, XrefRangeEnd = 307812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Base.NativeMethodInfoPtr_set_AppId_Public_set_Void_AppId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000E60 RID: 3680 RVA: 0x0005A28C File Offset: 0x0005848C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 949796, XrefRangeEnd = 949800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_OnChanges(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Base.NativeMethodInfoPtr_add_OnChanges_Public_add_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E61 RID: 3681 RVA: 0x0005A2D0 File Offset: 0x000584D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 949800, XrefRangeEnd = 949804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_OnChanges(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Base.NativeMethodInfoPtr_remove_OnChanges_Public_rem_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E62 RID: 3682 RVA: 0x0005A314 File Offset: 0x00058514
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 949804, XrefRangeEnd = 949809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_OnResponsiveServer(Action<ServerInfo> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Base.NativeMethodInfoPtr_add_OnResponsiveServer_Public_add_Void_Action_1_ServerInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E63 RID: 3683 RVA: 0x0005A358 File Offset: 0x00058558
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 949809, XrefRangeEnd = 949814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_OnResponsiveServer(Action<ServerInfo> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Base.NativeMethodInfoPtr_remove_OnResponsiveServer_Public_rem_Void_Action_1_ServerInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E64 RID: 3684 RVA: 0x0005A39C File Offset: 0x0005859C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 949848, RefRangeEnd = 949855, XrefRangeStart = 949814, XrefRangeEnd = 949848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Base()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Base>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Base.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E65 RID: 3685 RVA: 0x0005A3D8 File Offset: 0x000585D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 949855, XrefRangeEnd = 949869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Task<bool> RunQueryAsync(float timeoutSeconds = 10f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref timeoutSeconds;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Base.NativeMethodInfoPtr_RunQueryAsync_Public_Virtual_New_Task_1_Boolean_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<bool>>(intPtr3) : null;
			}
		}

		// Token: 0x06000E66 RID: 3686 RVA: 0x0005A430 File Offset: 0x00058630
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 949869, XrefRangeEnd = 949872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Cancel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Base.NativeMethodInfoPtr_Cancel_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E67 RID: 3687 RVA: 0x0005A46C File Offset: 0x0005866C
		[CallerCount(0)]
		public unsafe virtual void LaunchQuery()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Base.NativeMethodInfoPtr_LaunchQuery_Internal_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E68 RID: 3688 RVA: 0x0005A4A8 File Offset: 0x000586A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 949872, XrefRangeEnd = 949876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Il2CppReferenceArray<MatchMakingKeyValuePair> GetFilters()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Base.NativeMethodInfoPtr_GetFilters_Internal_Virtual_New_Il2CppReferenceArray_1_MatchMakingKeyValuePair_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MatchMakingKeyValuePair>>(intPtr3) : null;
		}

		// Token: 0x06000E69 RID: 3689 RVA: 0x0005A4F4 File Offset: 0x000586F4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 949881, RefRangeEnd = 949883, XrefRangeStart = 949876, XrefRangeEnd = 949881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddFilter(string key, string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Base.NativeMethodInfoPtr_AddFilter_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000213 RID: 531
		// (get) Token: 0x06000E6A RID: 3690 RVA: 0x0005A548 File Offset: 0x00058748
		public unsafe int Count
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 949883, XrefRangeEnd = 949886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Base.NativeMethodInfoPtr_get_Count_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000214 RID: 532
		// (get) Token: 0x06000E6B RID: 3691 RVA: 0x0005A584 File Offset: 0x00058784
		public unsafe bool IsRefreshing
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 949886, XrefRangeEnd = 949887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Base.NativeMethodInfoPtr_get_IsRefreshing_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E6C RID: 3692 RVA: 0x0005A5C0 File Offset: 0x000587C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 949887, XrefRangeEnd = 949891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Base.NativeMethodInfoPtr_Reset_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E6D RID: 3693 RVA: 0x0005A5F4 File Offset: 0x000587F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 949891, XrefRangeEnd = 949894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReleaseQuery()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Base.NativeMethodInfoPtr_ReleaseQuery_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E6E RID: 3694 RVA: 0x0005A628 File Offset: 0x00058828
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Base.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E6F RID: 3695 RVA: 0x0005A65C File Offset: 0x0005885C
		[CallerCount(0)]
		public unsafe void InvokeChanges()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Base.NativeMethodInfoPtr_InvokeChanges_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E70 RID: 3696 RVA: 0x0005A690 File Offset: 0x00058890
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 949894, XrefRangeEnd = 949900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdatePending()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Base.NativeMethodInfoPtr_UpdatePending_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E71 RID: 3697 RVA: 0x0005A6C4 File Offset: 0x000588C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 949900, XrefRangeEnd = 949910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateResponsive()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Base.NativeMethodInfoPtr_UpdateResponsive_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E72 RID: 3698 RVA: 0x0005A6F8 File Offset: 0x000588F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 949910, XrefRangeEnd = 949920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MovePendingToUnresponsive()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Base.NativeMethodInfoPtr_MovePendingToUnresponsive_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E73 RID: 3699 RVA: 0x0005A72C File Offset: 0x0005892C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 949923, RefRangeEnd = 949924, XrefRangeStart = 949920, XrefRangeEnd = 949923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnServer(ServerInfo serverInfo, bool responded)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(serverInfo));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref responded;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Base.NativeMethodInfoPtr_OnServer_Private_Void_ServerInfo_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E74 RID: 3700 RVA: 0x0005A784 File Offset: 0x00058984
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 949924, XrefRangeEnd = 949926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _UpdateResponsive_b__33_0(int x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Base.NativeMethodInfoPtr__UpdateResponsive_b__33_0_Private_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E75 RID: 3701 RVA: 0x0005A7D0 File Offset: 0x000589D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 949926, XrefRangeEnd = 949930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _MovePendingToUnresponsive_b__34_0(int x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Base.NativeMethodInfoPtr__MovePendingToUnresponsive_b__34_0_Private_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E76 RID: 3702 RVA: 0x00003D69 File Offset: 0x00001F69
		public Base(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000208 RID: 520
		// (get) Token: 0x06000E77 RID: 3703 RVA: 0x0005A81C File Offset: 0x00058A1C
		// (set) Token: 0x06000E78 RID: 3704 RVA: 0x00003D72 File Offset: 0x00001F72
		public unsafe AppId _AppId_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Base.NativeFieldInfoPtr__AppId_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Base.NativeFieldInfoPtr__AppId_k__BackingField)) = value;
			}
		}

		// Token: 0x17000209 RID: 521
		// (get) Token: 0x06000E79 RID: 3705 RVA: 0x0005A844 File Offset: 0x00058A44
		// (set) Token: 0x06000E7A RID: 3706 RVA: 0x00003D8D File Offset: 0x00001F8D
		public unsafe Action OnChanges
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Base.NativeFieldInfoPtr_OnChanges);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Base.NativeFieldInfoPtr_OnChanges), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700020A RID: 522
		// (get) Token: 0x06000E7B RID: 3707 RVA: 0x0005A874 File Offset: 0x00058A74
		// (set) Token: 0x06000E7C RID: 3708 RVA: 0x00003DAC File Offset: 0x00001FAC
		public unsafe Action<ServerInfo> OnResponsiveServer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Base.NativeFieldInfoPtr_OnResponsiveServer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<ServerInfo>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Base.NativeFieldInfoPtr_OnResponsiveServer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700020B RID: 523
		// (get) Token: 0x06000E7D RID: 3709 RVA: 0x0005A8A4 File Offset: 0x00058AA4
		// (set) Token: 0x06000E7E RID: 3710 RVA: 0x00003DCB File Offset: 0x00001FCB
		public unsafe List<ServerInfo> Responsive
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Base.NativeFieldInfoPtr_Responsive);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ServerInfo>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Base.NativeFieldInfoPtr_Responsive), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700020C RID: 524
		// (get) Token: 0x06000E7F RID: 3711 RVA: 0x0005A8D4 File Offset: 0x00058AD4
		// (set) Token: 0x06000E80 RID: 3712 RVA: 0x00003DEA File Offset: 0x00001FEA
		public unsafe List<ServerInfo> Unresponsive
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Base.NativeFieldInfoPtr_Unresponsive);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ServerInfo>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Base.NativeFieldInfoPtr_Unresponsive), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700020D RID: 525
		// (get) Token: 0x06000E81 RID: 3713 RVA: 0x0005A904 File Offset: 0x00058B04
		// (set) Token: 0x06000E82 RID: 3714 RVA: 0x00003E09 File Offset: 0x00002009
		public unsafe HServerListRequest request
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Base.NativeFieldInfoPtr_request);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Base.NativeFieldInfoPtr_request)) = value;
			}
		}

		// Token: 0x1700020E RID: 526
		// (get) Token: 0x06000E83 RID: 3715 RVA: 0x0005A92C File Offset: 0x00058B2C
		// (set) Token: 0x06000E84 RID: 3716 RVA: 0x00003E24 File Offset: 0x00002024
		public unsafe List<MatchMakingKeyValuePair> filters
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Base.NativeFieldInfoPtr_filters);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<MatchMakingKeyValuePair>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Base.NativeFieldInfoPtr_filters), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700020F RID: 527
		// (get) Token: 0x06000E85 RID: 3717 RVA: 0x0005A95C File Offset: 0x00058B5C
		// (set) Token: 0x06000E86 RID: 3718 RVA: 0x00003E43 File Offset: 0x00002043
		public unsafe List<int> watchList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Base.NativeFieldInfoPtr_watchList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Base.NativeFieldInfoPtr_watchList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000210 RID: 528
		// (get) Token: 0x06000E87 RID: 3719 RVA: 0x0005A98C File Offset: 0x00058B8C
		// (set) Token: 0x06000E88 RID: 3720 RVA: 0x00003E62 File Offset: 0x00002062
		public unsafe int LastCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Base.NativeFieldInfoPtr_LastCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Base.NativeFieldInfoPtr_LastCount)) = value;
			}
		}

		// Token: 0x04001489 RID: 5257
		private static readonly IntPtr NativeFieldInfoPtr__AppId_k__BackingField;

		// Token: 0x0400148A RID: 5258
		private static readonly IntPtr NativeFieldInfoPtr_OnChanges;

		// Token: 0x0400148B RID: 5259
		private static readonly IntPtr NativeFieldInfoPtr_OnResponsiveServer;

		// Token: 0x0400148C RID: 5260
		private static readonly IntPtr NativeFieldInfoPtr_Responsive;

		// Token: 0x0400148D RID: 5261
		private static readonly IntPtr NativeFieldInfoPtr_Unresponsive;

		// Token: 0x0400148E RID: 5262
		private static readonly IntPtr NativeFieldInfoPtr_request;

		// Token: 0x0400148F RID: 5263
		private static readonly IntPtr NativeFieldInfoPtr_filters;

		// Token: 0x04001490 RID: 5264
		private static readonly IntPtr NativeFieldInfoPtr_watchList;

		// Token: 0x04001491 RID: 5265
		private static readonly IntPtr NativeFieldInfoPtr_LastCount;

		// Token: 0x04001492 RID: 5266
		private static readonly IntPtr NativeMethodInfoPtr_get_Internal_Internal_Static_get_ISteamMatchmakingServers_0;

		// Token: 0x04001493 RID: 5267
		private static readonly IntPtr NativeMethodInfoPtr_get_AppId_Public_get_AppId_0;

		// Token: 0x04001494 RID: 5268
		private static readonly IntPtr NativeMethodInfoPtr_set_AppId_Public_set_Void_AppId_0;

		// Token: 0x04001495 RID: 5269
		private static readonly IntPtr NativeMethodInfoPtr_add_OnChanges_Public_add_Void_Action_0;

		// Token: 0x04001496 RID: 5270
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnChanges_Public_rem_Void_Action_0;

		// Token: 0x04001497 RID: 5271
		private static readonly IntPtr NativeMethodInfoPtr_add_OnResponsiveServer_Public_add_Void_Action_1_ServerInfo_0;

		// Token: 0x04001498 RID: 5272
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnResponsiveServer_Public_rem_Void_Action_1_ServerInfo_0;

		// Token: 0x04001499 RID: 5273
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400149A RID: 5274
		private static readonly IntPtr NativeMethodInfoPtr_RunQueryAsync_Public_Virtual_New_Task_1_Boolean_Single_0;

		// Token: 0x0400149B RID: 5275
		private static readonly IntPtr NativeMethodInfoPtr_Cancel_Public_Virtual_New_Void_0;

		// Token: 0x0400149C RID: 5276
		private static readonly IntPtr NativeMethodInfoPtr_LaunchQuery_Internal_Abstract_Virtual_New_Void_0;

		// Token: 0x0400149D RID: 5277
		private static readonly IntPtr NativeMethodInfoPtr_GetFilters_Internal_Virtual_New_Il2CppReferenceArray_1_MatchMakingKeyValuePair_0;

		// Token: 0x0400149E RID: 5278
		private static readonly IntPtr NativeMethodInfoPtr_AddFilter_Public_Void_String_String_0;

		// Token: 0x0400149F RID: 5279
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Internal_get_Int32_0;

		// Token: 0x040014A0 RID: 5280
		private static readonly IntPtr NativeMethodInfoPtr_get_IsRefreshing_Internal_get_Boolean_0;

		// Token: 0x040014A1 RID: 5281
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Private_Void_0;

		// Token: 0x040014A2 RID: 5282
		private static readonly IntPtr NativeMethodInfoPtr_ReleaseQuery_Private_Void_0;

		// Token: 0x040014A3 RID: 5283
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x040014A4 RID: 5284
		private static readonly IntPtr NativeMethodInfoPtr_InvokeChanges_Internal_Void_0;

		// Token: 0x040014A5 RID: 5285
		private static readonly IntPtr NativeMethodInfoPtr_UpdatePending_Private_Void_0;

		// Token: 0x040014A6 RID: 5286
		private static readonly IntPtr NativeMethodInfoPtr_UpdateResponsive_Public_Void_0;

		// Token: 0x040014A7 RID: 5287
		private static readonly IntPtr NativeMethodInfoPtr_MovePendingToUnresponsive_Private_Void_0;

		// Token: 0x040014A8 RID: 5288
		private static readonly IntPtr NativeMethodInfoPtr_OnServer_Private_Void_ServerInfo_Boolean_0;

		// Token: 0x040014A9 RID: 5289
		private static readonly IntPtr NativeMethodInfoPtr__UpdateResponsive_b__33_0_Private_Boolean_Int32_0;

		// Token: 0x040014AA RID: 5290
		private static readonly IntPtr NativeMethodInfoPtr__MovePendingToUnresponsive_b__34_0_Private_Boolean_Int32_0;

		// Token: 0x02000299 RID: 665
		[ObfuscatedName("Steamworks.ServerList.Base+<RunQueryAsync>d__15")]
		public sealed class _RunQueryAsync_d__15 : ValueType
		{
			// Token: 0x060021CD RID: 8653 RVA: 0x000922D8 File Offset: 0x000904D8
			// Note: this type is marked as 'beforefieldinit'.
			static _RunQueryAsync_d__15()
			{
				Il2CppClassPointerStore<Base._RunQueryAsync_d__15>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Base>.NativeClassPtr, "<RunQueryAsync>d__15");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Base._RunQueryAsync_d__15>.NativeClassPtr);
				Base._RunQueryAsync_d__15.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Base._RunQueryAsync_d__15>.NativeClassPtr, "<>1__state");
				Base._RunQueryAsync_d__15.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Base._RunQueryAsync_d__15>.NativeClassPtr, "<>t__builder");
				Base._RunQueryAsync_d__15.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Base._RunQueryAsync_d__15>.NativeClassPtr, "<>4__this");
				Base._RunQueryAsync_d__15.NativeFieldInfoPtr_timeoutSeconds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Base._RunQueryAsync_d__15>.NativeClassPtr, "timeoutSeconds");
				Base._RunQueryAsync_d__15.NativeFieldInfoPtr__stopwatch_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Base._RunQueryAsync_d__15>.NativeClassPtr, "<stopwatch>5__2");
				Base._RunQueryAsync_d__15.NativeFieldInfoPtr__thisRequest_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Base._RunQueryAsync_d__15>.NativeClassPtr, "<thisRequest>5__3");
				Base._RunQueryAsync_d__15.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Base._RunQueryAsync_d__15>.NativeClassPtr, "<>u__1");
				Base._RunQueryAsync_d__15.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Base._RunQueryAsync_d__15>.NativeClassPtr, 100666711);
				Base._RunQueryAsync_d__15.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Base._RunQueryAsync_d__15>.NativeClassPtr, 100666712);
			}

			// Token: 0x060021CE RID: 8654 RVA: 0x000923B8 File Offset: 0x000905B8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 949721, XrefRangeEnd = 949789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Base._RunQueryAsync_d__15.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060021CF RID: 8655 RVA: 0x000923F0 File Offset: 0x000905F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 949789, XrefRangeEnd = 949795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Base._RunQueryAsync_d__15.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060021D0 RID: 8656 RVA: 0x0000D83E File Offset: 0x0000BA3E
			public _RunQueryAsync_d__15(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060021D1 RID: 8657 RVA: 0x0000D847 File Offset: 0x0000BA47
			public _RunQueryAsync_d__15()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Base._RunQueryAsync_d__15>.NativeClassPtr))
			{
			}

			// Token: 0x170008CC RID: 2252
			// (get) Token: 0x060021D2 RID: 8658 RVA: 0x00092438 File Offset: 0x00090638
			// (set) Token: 0x060021D3 RID: 8659 RVA: 0x0000D859 File Offset: 0x0000BA59
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Base._RunQueryAsync_d__15.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Base._RunQueryAsync_d__15.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170008CD RID: 2253
			// (get) Token: 0x060021D4 RID: 8660 RVA: 0x00092460 File Offset: 0x00090660
			// (set) Token: 0x060021D5 RID: 8661 RVA: 0x0000D874 File Offset: 0x0000BA74
			public AsyncTaskMethodBuilder<bool> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Base._RunQueryAsync_d__15.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<bool>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Base._RunQueryAsync_d__15.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<bool>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170008CE RID: 2254
			// (get) Token: 0x060021D6 RID: 8662 RVA: 0x00092490 File Offset: 0x00090690
			// (set) Token: 0x060021D7 RID: 8663 RVA: 0x0000D8A2 File Offset: 0x0000BAA2
			public unsafe Base __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Base._RunQueryAsync_d__15.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Base>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Base._RunQueryAsync_d__15.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008CF RID: 2255
			// (get) Token: 0x060021D8 RID: 8664 RVA: 0x000924C0 File Offset: 0x000906C0
			// (set) Token: 0x060021D9 RID: 8665 RVA: 0x0000D8C1 File Offset: 0x0000BAC1
			public unsafe float timeoutSeconds
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Base._RunQueryAsync_d__15.NativeFieldInfoPtr_timeoutSeconds);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Base._RunQueryAsync_d__15.NativeFieldInfoPtr_timeoutSeconds)) = value;
				}
			}

			// Token: 0x170008D0 RID: 2256
			// (get) Token: 0x060021DA RID: 8666 RVA: 0x000924E8 File Offset: 0x000906E8
			// (set) Token: 0x060021DB RID: 8667 RVA: 0x0000D8DC File Offset: 0x0000BADC
			public unsafe Stopwatch _stopwatch_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Base._RunQueryAsync_d__15.NativeFieldInfoPtr__stopwatch_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stopwatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Base._RunQueryAsync_d__15.NativeFieldInfoPtr__stopwatch_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008D1 RID: 2257
			// (get) Token: 0x060021DC RID: 8668 RVA: 0x00092518 File Offset: 0x00090718
			// (set) Token: 0x060021DD RID: 8669 RVA: 0x0000D8FB File Offset: 0x0000BAFB
			public unsafe HServerListRequest _thisRequest_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Base._RunQueryAsync_d__15.NativeFieldInfoPtr__thisRequest_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Base._RunQueryAsync_d__15.NativeFieldInfoPtr__thisRequest_5__3)) = value;
				}
			}

			// Token: 0x170008D2 RID: 2258
			// (get) Token: 0x060021DE RID: 8670 RVA: 0x00092540 File Offset: 0x00090740
			// (set) Token: 0x060021DF RID: 8671 RVA: 0x0000D916 File Offset: 0x0000BB16
			public TaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Base._RunQueryAsync_d__15.NativeFieldInfoPtr___u__1);
					return new TaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Base._RunQueryAsync_d__15.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04002376 RID: 9078
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04002377 RID: 9079
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04002378 RID: 9080
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04002379 RID: 9081
			private static readonly IntPtr NativeFieldInfoPtr_timeoutSeconds;

			// Token: 0x0400237A RID: 9082
			private static readonly IntPtr NativeFieldInfoPtr__stopwatch_5__2;

			// Token: 0x0400237B RID: 9083
			private static readonly IntPtr NativeFieldInfoPtr__thisRequest_5__3;

			// Token: 0x0400237C RID: 9084
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x0400237D RID: 9085
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400237E RID: 9086
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}
	}
}
