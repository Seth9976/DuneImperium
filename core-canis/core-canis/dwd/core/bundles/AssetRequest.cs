using System;
using dwd.core.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace dwd.core.bundles
{
	// Token: 0x020001FA RID: 506
	public sealed class AssetRequest<T> : Command where T : global::UnityEngine.Object
	{
		// Token: 0x06001C0A RID: 7178 RVA: 0x00082B38 File Offset: 0x00080D38
		// Note: this type is marked as 'beforefieldinit'.
		static AssetRequest()
		{
			Il2CppClassPointerStore<AssetRequest<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.bundles", "AssetRequest`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AssetRequest<T>>.NativeClassPtr);
			AssetRequest<T>.NativeFieldInfoPtr_numberOfRerequests = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetRequest<T>>.NativeClassPtr, "numberOfRerequests");
			AssetRequest<T>.NativeFieldInfoPtr_bundleManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetRequest<T>>.NativeClassPtr, "bundleManager");
			AssetRequest<T>.NativeFieldInfoPtr_defaultAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetRequest<T>>.NativeClassPtr, "defaultAsset");
			AssetRequest<T>.NativeFieldInfoPtr_priority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetRequest<T>>.NativeClassPtr, "priority");
			AssetRequest<T>.NativeFieldInfoPtr_asyncGet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetRequest<T>>.NativeClassPtr, "asyncGet");
			AssetRequest<T>.NativeFieldInfoPtr__AssetName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetRequest<T>>.NativeClassPtr, "<AssetName>k__BackingField");
			AssetRequest<T>.NativeFieldInfoPtr__Version_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetRequest<T>>.NativeClassPtr, "<Version>k__BackingField");
			AssetRequest<T>.NativeFieldInfoPtr__IsVersionCached_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetRequest<T>>.NativeClassPtr, "<IsVersionCached>k__BackingField");
			AssetRequest<T>.NativeFieldInfoPtr__Error_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetRequest<T>>.NativeClassPtr, "<Error>k__BackingField");
			AssetRequest<T>.NativeFieldInfoPtr__Progress_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetRequest<T>>.NativeClassPtr, "<Progress>k__BackingField");
			AssetRequest<T>.NativeFieldInfoPtr__Asset_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetRequest<T>>.NativeClassPtr, "<Asset>k__BackingField");
			AssetRequest<T>.NativeFieldInfoPtr__State_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetRequest<T>>.NativeClassPtr, "<State>k__BackingField");
			AssetRequest<T>.NativeMethodInfoPtr__ctor_Public_Void_String_RequestPriority_AssetBundleManager_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetRequest<T>>.NativeClassPtr, 100667741);
			AssetRequest<T>.NativeMethodInfoPtr_get_AssetName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetRequest<T>>.NativeClassPtr, 100667742);
			AssetRequest<T>.NativeMethodInfoPtr_set_AssetName_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetRequest<T>>.NativeClassPtr, 100667743);
			AssetRequest<T>.NativeMethodInfoPtr_get_Version_Public_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetRequest<T>>.NativeClassPtr, 100667744);
			AssetRequest<T>.NativeMethodInfoPtr_set_Version_Private_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetRequest<T>>.NativeClassPtr, 100667745);
			AssetRequest<T>.NativeMethodInfoPtr_get_IsVersionCached_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetRequest<T>>.NativeClassPtr, 100667746);
			AssetRequest<T>.NativeMethodInfoPtr_set_IsVersionCached_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetRequest<T>>.NativeClassPtr, 100667747);
			AssetRequest<T>.NativeMethodInfoPtr_get_Error_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetRequest<T>>.NativeClassPtr, 100667748);
			AssetRequest<T>.NativeMethodInfoPtr_set_Error_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetRequest<T>>.NativeClassPtr, 100667749);
			AssetRequest<T>.NativeMethodInfoPtr_get_Progress_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetRequest<T>>.NativeClassPtr, 100667750);
			AssetRequest<T>.NativeMethodInfoPtr_set_Progress_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetRequest<T>>.NativeClassPtr, 100667751);
			AssetRequest<T>.NativeMethodInfoPtr_get_Asset_Public_Virtual_Final_New_get_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetRequest<T>>.NativeClassPtr, 100667752);
			AssetRequest<T>.NativeMethodInfoPtr_set_Asset_Private_set_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetRequest<T>>.NativeClassPtr, 100667753);
			AssetRequest<T>.NativeMethodInfoPtr_get_State_Public_Virtual_Final_New_get_AssetRequestStates_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetRequest<T>>.NativeClassPtr, 100667754);
			AssetRequest<T>.NativeMethodInfoPtr_set_State_Private_set_Void_AssetRequestStates_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetRequest<T>>.NativeClassPtr, 100667755);
			AssetRequest<T>.NativeMethodInfoPtr_Cancel_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetRequest<T>>.NativeClassPtr, 100667756);
			AssetRequest<T>.NativeMethodInfoPtr_dwd_core_data_IHasProgress_GetPercent_Private_Virtual_Final_New_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetRequest<T>>.NativeClassPtr, 100667757);
			AssetRequest<T>.NativeMethodInfoPtr_DeRef_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetRequest<T>>.NativeClassPtr, 100667758);
			AssetRequest<T>.NativeMethodInfoPtr_Ref_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetRequest<T>>.NativeClassPtr, 100667759);
			AssetRequest<T>.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetRequest<T>>.NativeClassPtr, 100667760);
			AssetRequest<T>.NativeMethodInfoPtr_loadAsset_Private_IEnumerator_RequestPriority_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetRequest<T>>.NativeClassPtr, 100667761);
			AssetRequest<T>.NativeMethodInfoPtr_AssignAsset_Private_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetRequest<T>>.NativeClassPtr, 100667762);
			AssetRequest<T>.NativeMethodInfoPtr_Unload_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetRequest<T>>.NativeClassPtr, 100667763);
		}

		// Token: 0x06001C0B RID: 7179 RVA: 0x00082E60 File Offset: 0x00081060
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 885350, RefRangeEnd = 885351, XrefRangeStart = 885346, XrefRangeEnd = 885350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AssetRequest(string assetName, RequestPriority priority, AssetBundleManager bundleManager, string defaultAsset, bool asyncGet = true)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AssetRequest<T>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(assetName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref priority;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(bundleManager);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(defaultAsset);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref asyncGet;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetRequest<T>.NativeMethodInfoPtr__ctor_Public_Void_String_RequestPriority_AssetBundleManager_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170007D0 RID: 2000
		// (get) Token: 0x06001C0C RID: 7180 RVA: 0x00082EEC File Offset: 0x000810EC
		// (set) Token: 0x06001C0D RID: 7181 RVA: 0x00082F24 File Offset: 0x00081124
		public unsafe string AssetName
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 139770, RefRangeEnd = 139777, XrefRangeStart = 139770, XrefRangeEnd = 139777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetRequest<T>.NativeMethodInfoPtr_get_AssetName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetRequest<T>.NativeMethodInfoPtr_set_AssetName_Private_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170007D1 RID: 2001
		// (get) Token: 0x06001C0E RID: 7182 RVA: 0x00082F68 File Offset: 0x00081168
		// (set) Token: 0x06001C0F RID: 7183 RVA: 0x00082FA4 File Offset: 0x000811A4
		public unsafe uint Version
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetRequest<T>.NativeMethodInfoPtr_get_Version_Public_get_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetRequest<T>.NativeMethodInfoPtr_set_Version_Private_set_Void_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170007D2 RID: 2002
		// (get) Token: 0x06001C10 RID: 7184 RVA: 0x00082FE4 File Offset: 0x000811E4
		// (set) Token: 0x06001C11 RID: 7185 RVA: 0x00083020 File Offset: 0x00081220
		public unsafe bool IsVersionCached
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetRequest<T>.NativeMethodInfoPtr_get_IsVersionCached_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetRequest<T>.NativeMethodInfoPtr_set_IsVersionCached_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170007D3 RID: 2003
		// (get) Token: 0x06001C12 RID: 7186 RVA: 0x00083060 File Offset: 0x00081260
		// (set) Token: 0x06001C13 RID: 7187 RVA: 0x00083098 File Offset: 0x00081298
		public unsafe string Error
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetRequest<T>.NativeMethodInfoPtr_get_Error_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetRequest<T>.NativeMethodInfoPtr_set_Error_Private_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170007D4 RID: 2004
		// (get) Token: 0x06001C14 RID: 7188 RVA: 0x000830DC File Offset: 0x000812DC
		// (set) Token: 0x06001C15 RID: 7189 RVA: 0x00083118 File Offset: 0x00081318
		public unsafe float Progress
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetRequest<T>.NativeMethodInfoPtr_get_Progress_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 885351, RefRangeEnd = 885352, XrefRangeStart = 885351, XrefRangeEnd = 885351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetRequest<T>.NativeMethodInfoPtr_set_Progress_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170007D5 RID: 2005
		// (get) Token: 0x06001C16 RID: 7190 RVA: 0x00083158 File Offset: 0x00081358
		// (set) Token: 0x06001C17 RID: 7191 RVA: 0x00083194 File Offset: 0x00081394
		public unsafe T Asset
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetRequest<T>.NativeMethodInfoPtr_get_Asset_Public_Virtual_Final_New_get_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr;
					if (!typeof(T).IsValueType)
					{
						T t = value;
						intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
					}
					else
					{
						intPtr = ref value;
					}
					ptr2 = intPtr;
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(AssetRequest<T>.NativeMethodInfoPtr_set_Asset_Private_set_Void_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				}
			}
		}

		// Token: 0x170007D6 RID: 2006
		// (get) Token: 0x06001C18 RID: 7192 RVA: 0x0008320C File Offset: 0x0008140C
		// (set) Token: 0x06001C19 RID: 7193 RVA: 0x00083248 File Offset: 0x00081448
		public unsafe AssetRequestStates State
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetRequest<T>.NativeMethodInfoPtr_get_State_Public_Virtual_Final_New_get_AssetRequestStates_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(16)]
			[CachedScanResults(RefRangeStart = 312518, RefRangeEnd = 312534, XrefRangeStart = 312518, XrefRangeEnd = 312534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetRequest<T>.NativeMethodInfoPtr_set_State_Private_set_Void_AssetRequestStates_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001C1A RID: 7194 RVA: 0x00083288 File Offset: 0x00081488
		[CallerCount(0)]
		public unsafe void Cancel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetRequest<T>.NativeMethodInfoPtr_Cancel_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C1B RID: 7195 RVA: 0x000832BC File Offset: 0x000814BC
		[CallerCount(0)]
		public unsafe float dwd_core_data_IHasProgress_GetPercent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetRequest<T>.NativeMethodInfoPtr_dwd_core_data_IHasProgress_GetPercent_Private_Virtual_Final_New_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C1C RID: 7196 RVA: 0x000832F8 File Offset: 0x000814F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 885352, XrefRangeEnd = 885360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DeRef()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetRequest<T>.NativeMethodInfoPtr_DeRef_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C1D RID: 7197 RVA: 0x0008332C File Offset: 0x0008152C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 885360, XrefRangeEnd = 885368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Ref()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetRequest<T>.NativeMethodInfoPtr_Ref_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C1E RID: 7198 RVA: 0x00083360 File Offset: 0x00081560
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 885368, XrefRangeEnd = 885372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetRequest<T>.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001C1F RID: 7199 RVA: 0x000833A0 File Offset: 0x000815A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 885372, XrefRangeEnd = 885376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator loadAsset(RequestPriority loadPriority, int retryCount = 0)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref loadPriority;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref retryCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetRequest<T>.NativeMethodInfoPtr_loadAsset_Private_IEnumerator_RequestPriority_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001C20 RID: 7200 RVA: 0x000833FC File Offset: 0x000815FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 885376, XrefRangeEnd = 885397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool AssignAsset(global::UnityEngine.Object asset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(asset);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetRequest<T>.NativeMethodInfoPtr_AssignAsset_Private_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001C21 RID: 7201 RVA: 0x0008344C File Offset: 0x0008164C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 885397, XrefRangeEnd = 885402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Unload()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetRequest<T>.NativeMethodInfoPtr_Unload_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C22 RID: 7202 RVA: 0x0000C174 File Offset: 0x0000A374
		public AssetRequest(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170007C4 RID: 1988
		// (get) Token: 0x06001C23 RID: 7203 RVA: 0x00083480 File Offset: 0x00081680
		// (set) Token: 0x06001C24 RID: 7204 RVA: 0x0000C17D File Offset: 0x0000A37D
		public unsafe static int numberOfRerequests
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(AssetRequest<T>.NativeFieldInfoPtr_numberOfRerequests, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AssetRequest<T>.NativeFieldInfoPtr_numberOfRerequests, (void*)(&value));
			}
		}

		// Token: 0x170007C5 RID: 1989
		// (get) Token: 0x06001C25 RID: 7205 RVA: 0x0008349C File Offset: 0x0008169C
		// (set) Token: 0x06001C26 RID: 7206 RVA: 0x0000C18B File Offset: 0x0000A38B
		public unsafe AssetBundleManager bundleManager
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetRequest<T>.NativeFieldInfoPtr_bundleManager);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetBundleManager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetRequest<T>.NativeFieldInfoPtr_bundleManager), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007C6 RID: 1990
		// (get) Token: 0x06001C27 RID: 7207 RVA: 0x000834CC File Offset: 0x000816CC
		// (set) Token: 0x06001C28 RID: 7208 RVA: 0x0000C1AA File Offset: 0x0000A3AA
		public unsafe string defaultAsset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetRequest<T>.NativeFieldInfoPtr_defaultAsset);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetRequest<T>.NativeFieldInfoPtr_defaultAsset), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170007C7 RID: 1991
		// (get) Token: 0x06001C29 RID: 7209 RVA: 0x000834F4 File Offset: 0x000816F4
		// (set) Token: 0x06001C2A RID: 7210 RVA: 0x0000C1C9 File Offset: 0x0000A3C9
		public unsafe RequestPriority priority
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetRequest<T>.NativeFieldInfoPtr_priority);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetRequest<T>.NativeFieldInfoPtr_priority)) = value;
			}
		}

		// Token: 0x170007C8 RID: 1992
		// (get) Token: 0x06001C2B RID: 7211 RVA: 0x0008351C File Offset: 0x0008171C
		// (set) Token: 0x06001C2C RID: 7212 RVA: 0x0000C1E4 File Offset: 0x0000A3E4
		public unsafe bool asyncGet
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetRequest<T>.NativeFieldInfoPtr_asyncGet);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetRequest<T>.NativeFieldInfoPtr_asyncGet)) = value;
			}
		}

		// Token: 0x170007C9 RID: 1993
		// (get) Token: 0x06001C2D RID: 7213 RVA: 0x00083544 File Offset: 0x00081744
		// (set) Token: 0x06001C2E RID: 7214 RVA: 0x0000C1FF File Offset: 0x0000A3FF
		public unsafe string _AssetName_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetRequest<T>.NativeFieldInfoPtr__AssetName_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetRequest<T>.NativeFieldInfoPtr__AssetName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170007CA RID: 1994
		// (get) Token: 0x06001C2F RID: 7215 RVA: 0x0008356C File Offset: 0x0008176C
		// (set) Token: 0x06001C30 RID: 7216 RVA: 0x0000C21E File Offset: 0x0000A41E
		public unsafe uint _Version_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetRequest<T>.NativeFieldInfoPtr__Version_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetRequest<T>.NativeFieldInfoPtr__Version_k__BackingField)) = value;
			}
		}

		// Token: 0x170007CB RID: 1995
		// (get) Token: 0x06001C31 RID: 7217 RVA: 0x00083594 File Offset: 0x00081794
		// (set) Token: 0x06001C32 RID: 7218 RVA: 0x0000C239 File Offset: 0x0000A439
		public unsafe bool _IsVersionCached_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetRequest<T>.NativeFieldInfoPtr__IsVersionCached_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetRequest<T>.NativeFieldInfoPtr__IsVersionCached_k__BackingField)) = value;
			}
		}

		// Token: 0x170007CC RID: 1996
		// (get) Token: 0x06001C33 RID: 7219 RVA: 0x000835BC File Offset: 0x000817BC
		// (set) Token: 0x06001C34 RID: 7220 RVA: 0x0000C254 File Offset: 0x0000A454
		public unsafe string _Error_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetRequest<T>.NativeFieldInfoPtr__Error_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetRequest<T>.NativeFieldInfoPtr__Error_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170007CD RID: 1997
		// (get) Token: 0x06001C35 RID: 7221 RVA: 0x000835E4 File Offset: 0x000817E4
		// (set) Token: 0x06001C36 RID: 7222 RVA: 0x0000C273 File Offset: 0x0000A473
		public unsafe float _Progress_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetRequest<T>.NativeFieldInfoPtr__Progress_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetRequest<T>.NativeFieldInfoPtr__Progress_k__BackingField)) = value;
			}
		}

		// Token: 0x170007CE RID: 1998
		// (get) Token: 0x06001C37 RID: 7223 RVA: 0x0008360C File Offset: 0x0008180C
		// (set) Token: 0x06001C38 RID: 7224 RVA: 0x00083634 File Offset: 0x00081834
		public unsafe T _Asset_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetRequest<T>.NativeFieldInfoPtr__Asset_k__BackingField);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetRequest<T>.NativeFieldInfoPtr__Asset_k__BackingField);
				Type typeFromHandle = typeof(T);
				if (!typeFromHandle.IsValueType)
				{
					if (!string.Equals(typeFromHandle.FullName, "System.String"))
					{
						IntPtr intPtr4;
						IntPtr intPtr3 = (intPtr4 = IL2CPP.Il2CppObjectBaseToPtr(value as Il2CppObjectBase));
						if (intPtr3 != 0)
						{
							intPtr4 = intPtr3;
							if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr3)))
							{
								IntPtr intPtr5 = intPtr3;
								cpblk(intPtr2, IL2CPP.il2cpp_object_unbox(intPtr3), IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(intPtr5), (UIntPtr)0));
								return;
							}
						}
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, intPtr4);
					}
					else
					{
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, IL2CPP.ManagedStringToIl2Cpp(value as string));
					}
				}
				else
				{
					*intPtr2 = value;
				}
			}
		}

		// Token: 0x170007CF RID: 1999
		// (get) Token: 0x06001C39 RID: 7225 RVA: 0x000836DC File Offset: 0x000818DC
		// (set) Token: 0x06001C3A RID: 7226 RVA: 0x0000C28E File Offset: 0x0000A48E
		public unsafe AssetRequestStates _State_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetRequest<T>.NativeFieldInfoPtr__State_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetRequest<T>.NativeFieldInfoPtr__State_k__BackingField)) = value;
			}
		}

		// Token: 0x0400139F RID: 5023
		private static readonly IntPtr NativeFieldInfoPtr_numberOfRerequests;

		// Token: 0x040013A0 RID: 5024
		private static readonly IntPtr NativeFieldInfoPtr_bundleManager;

		// Token: 0x040013A1 RID: 5025
		private static readonly IntPtr NativeFieldInfoPtr_defaultAsset;

		// Token: 0x040013A2 RID: 5026
		private static readonly IntPtr NativeFieldInfoPtr_priority;

		// Token: 0x040013A3 RID: 5027
		private static readonly IntPtr NativeFieldInfoPtr_asyncGet;

		// Token: 0x040013A4 RID: 5028
		private static readonly IntPtr NativeFieldInfoPtr__AssetName_k__BackingField;

		// Token: 0x040013A5 RID: 5029
		private static readonly IntPtr NativeFieldInfoPtr__Version_k__BackingField;

		// Token: 0x040013A6 RID: 5030
		private static readonly IntPtr NativeFieldInfoPtr__IsVersionCached_k__BackingField;

		// Token: 0x040013A7 RID: 5031
		private static readonly IntPtr NativeFieldInfoPtr__Error_k__BackingField;

		// Token: 0x040013A8 RID: 5032
		private static readonly IntPtr NativeFieldInfoPtr__Progress_k__BackingField;

		// Token: 0x040013A9 RID: 5033
		private static readonly IntPtr NativeFieldInfoPtr__Asset_k__BackingField;

		// Token: 0x040013AA RID: 5034
		private static readonly IntPtr NativeFieldInfoPtr__State_k__BackingField;

		// Token: 0x040013AB RID: 5035
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_RequestPriority_AssetBundleManager_String_Boolean_0;

		// Token: 0x040013AC RID: 5036
		private static readonly IntPtr NativeMethodInfoPtr_get_AssetName_Public_get_String_0;

		// Token: 0x040013AD RID: 5037
		private static readonly IntPtr NativeMethodInfoPtr_set_AssetName_Private_set_Void_String_0;

		// Token: 0x040013AE RID: 5038
		private static readonly IntPtr NativeMethodInfoPtr_get_Version_Public_get_UInt32_0;

		// Token: 0x040013AF RID: 5039
		private static readonly IntPtr NativeMethodInfoPtr_set_Version_Private_set_Void_UInt32_0;

		// Token: 0x040013B0 RID: 5040
		private static readonly IntPtr NativeMethodInfoPtr_get_IsVersionCached_Public_get_Boolean_0;

		// Token: 0x040013B1 RID: 5041
		private static readonly IntPtr NativeMethodInfoPtr_set_IsVersionCached_Private_set_Void_Boolean_0;

		// Token: 0x040013B2 RID: 5042
		private static readonly IntPtr NativeMethodInfoPtr_get_Error_Public_get_String_0;

		// Token: 0x040013B3 RID: 5043
		private static readonly IntPtr NativeMethodInfoPtr_set_Error_Private_set_Void_String_0;

		// Token: 0x040013B4 RID: 5044
		private static readonly IntPtr NativeMethodInfoPtr_get_Progress_Public_get_Single_0;

		// Token: 0x040013B5 RID: 5045
		private static readonly IntPtr NativeMethodInfoPtr_set_Progress_Private_set_Void_Single_0;

		// Token: 0x040013B6 RID: 5046
		private static readonly IntPtr NativeMethodInfoPtr_get_Asset_Public_Virtual_Final_New_get_T_0;

		// Token: 0x040013B7 RID: 5047
		private static readonly IntPtr NativeMethodInfoPtr_set_Asset_Private_set_Void_T_0;

		// Token: 0x040013B8 RID: 5048
		private static readonly IntPtr NativeMethodInfoPtr_get_State_Public_Virtual_Final_New_get_AssetRequestStates_0;

		// Token: 0x040013B9 RID: 5049
		private static readonly IntPtr NativeMethodInfoPtr_set_State_Private_set_Void_AssetRequestStates_0;

		// Token: 0x040013BA RID: 5050
		private static readonly IntPtr NativeMethodInfoPtr_Cancel_Public_Void_0;

		// Token: 0x040013BB RID: 5051
		private static readonly IntPtr NativeMethodInfoPtr_dwd_core_data_IHasProgress_GetPercent_Private_Virtual_Final_New_Single_0;

		// Token: 0x040013BC RID: 5052
		private static readonly IntPtr NativeMethodInfoPtr_DeRef_Public_Void_0;

		// Token: 0x040013BD RID: 5053
		private static readonly IntPtr NativeMethodInfoPtr_Ref_Public_Void_0;

		// Token: 0x040013BE RID: 5054
		private static readonly IntPtr NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0;

		// Token: 0x040013BF RID: 5055
		private static readonly IntPtr NativeMethodInfoPtr_loadAsset_Private_IEnumerator_RequestPriority_Int32_0;

		// Token: 0x040013C0 RID: 5056
		private static readonly IntPtr NativeMethodInfoPtr_AssignAsset_Private_Boolean_Object_0;

		// Token: 0x040013C1 RID: 5057
		private static readonly IntPtr NativeMethodInfoPtr_Unload_Public_Void_0;

		// Token: 0x0200038C RID: 908
		[ObfuscatedName("dwd.core.bundles.AssetRequest`1+<execute>d__38")]
		public sealed class _execute_d__38 : global::Il2CppSystem.Object
		{
			// Token: 0x06002887 RID: 10375 RVA: 0x000AAE0C File Offset: 0x000A900C
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__38()
			{
				Il2CppClassPointerStore<AssetRequest<T>._execute_d__38>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AssetRequest<T>>.NativeClassPtr, "<execute>d__38"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AssetRequest<T>._execute_d__38>.NativeClassPtr);
				AssetRequest<T>._execute_d__38.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetRequest<T>._execute_d__38>.NativeClassPtr, "<>1__state");
				AssetRequest<T>._execute_d__38.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetRequest<T>._execute_d__38>.NativeClassPtr, "<>2__current");
				AssetRequest<T>._execute_d__38.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetRequest<T>._execute_d__38>.NativeClassPtr, "<>4__this");
				AssetRequest<T>._execute_d__38.NativeFieldInfoPtr__loadAssetEnumerator_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetRequest<T>._execute_d__38>.NativeClassPtr, "<loadAssetEnumerator>5__2");
				AssetRequest<T>._execute_d__38.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetRequest<T>._execute_d__38>.NativeClassPtr, 100667764);
				AssetRequest<T>._execute_d__38.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetRequest<T>._execute_d__38>.NativeClassPtr, 100667765);
				AssetRequest<T>._execute_d__38.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetRequest<T>._execute_d__38>.NativeClassPtr, 100667766);
				AssetRequest<T>._execute_d__38.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetRequest<T>._execute_d__38>.NativeClassPtr, 100667767);
				AssetRequest<T>._execute_d__38.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetRequest<T>._execute_d__38>.NativeClassPtr, 100667768);
				AssetRequest<T>._execute_d__38.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetRequest<T>._execute_d__38>.NativeClassPtr, 100667769);
			}

			// Token: 0x06002888 RID: 10376 RVA: 0x000AAF3C File Offset: 0x000A913C
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__38(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AssetRequest<T>._execute_d__38>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetRequest<T>._execute_d__38.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002889 RID: 10377 RVA: 0x000AAF84 File Offset: 0x000A9184
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetRequest<T>._execute_d__38.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600288A RID: 10378 RVA: 0x000AAFB8 File Offset: 0x000A91B8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 885311, XrefRangeEnd = 885318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetRequest<T>._execute_d__38.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000B7C RID: 2940
			// (get) Token: 0x0600288B RID: 10379 RVA: 0x000AAFF4 File Offset: 0x000A91F4
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetRequest<T>._execute_d__38.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600288C RID: 10380 RVA: 0x000AB034 File Offset: 0x000A9234
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetRequest<T>._execute_d__38.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000B7D RID: 2941
			// (get) Token: 0x0600288D RID: 10381 RVA: 0x000AB068 File Offset: 0x000A9268
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetRequest<T>._execute_d__38.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600288E RID: 10382 RVA: 0x00012634 File Offset: 0x00010834
			public _execute_d__38(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000B78 RID: 2936
			// (get) Token: 0x0600288F RID: 10383 RVA: 0x000AB0A8 File Offset: 0x000A92A8
			// (set) Token: 0x06002890 RID: 10384 RVA: 0x0001263D File Offset: 0x0001083D
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetRequest<T>._execute_d__38.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetRequest<T>._execute_d__38.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000B79 RID: 2937
			// (get) Token: 0x06002891 RID: 10385 RVA: 0x000AB0D0 File Offset: 0x000A92D0
			// (set) Token: 0x06002892 RID: 10386 RVA: 0x00012658 File Offset: 0x00010858
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetRequest<T>._execute_d__38.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetRequest<T>._execute_d__38.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B7A RID: 2938
			// (get) Token: 0x06002893 RID: 10387 RVA: 0x000AB100 File Offset: 0x000A9300
			// (set) Token: 0x06002894 RID: 10388 RVA: 0x00012677 File Offset: 0x00010877
			public unsafe AssetRequest<T> __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetRequest<T>._execute_d__38.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetRequest<T>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetRequest<T>._execute_d__38.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B7B RID: 2939
			// (get) Token: 0x06002895 RID: 10389 RVA: 0x000AB130 File Offset: 0x000A9330
			// (set) Token: 0x06002896 RID: 10390 RVA: 0x00012696 File Offset: 0x00010896
			public unsafe IEnumerator _loadAssetEnumerator_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetRequest<T>._execute_d__38.NativeFieldInfoPtr__loadAssetEnumerator_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetRequest<T>._execute_d__38.NativeFieldInfoPtr__loadAssetEnumerator_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001B7B RID: 7035
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001B7C RID: 7036
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001B7D RID: 7037
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001B7E RID: 7038
			private static readonly IntPtr NativeFieldInfoPtr__loadAssetEnumerator_5__2;

			// Token: 0x04001B7F RID: 7039
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001B80 RID: 7040
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001B81 RID: 7041
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001B82 RID: 7042
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001B83 RID: 7043
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001B84 RID: 7044
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x0200038D RID: 909
		[ObfuscatedName("dwd.core.bundles.AssetRequest`1+<loadAsset>d__39")]
		public sealed class _loadAsset_d__39 : global::Il2CppSystem.Object
		{
			// Token: 0x06002897 RID: 10391 RVA: 0x000AB160 File Offset: 0x000A9360
			// Note: this type is marked as 'beforefieldinit'.
			static _loadAsset_d__39()
			{
				Il2CppClassPointerStore<AssetRequest<T>._loadAsset_d__39>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AssetRequest<T>>.NativeClassPtr, "<loadAsset>d__39"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AssetRequest<T>._loadAsset_d__39>.NativeClassPtr);
				AssetRequest<T>._loadAsset_d__39.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetRequest<T>._loadAsset_d__39>.NativeClassPtr, "<>1__state");
				AssetRequest<T>._loadAsset_d__39.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetRequest<T>._loadAsset_d__39>.NativeClassPtr, "<>2__current");
				AssetRequest<T>._loadAsset_d__39.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetRequest<T>._loadAsset_d__39>.NativeClassPtr, "<>4__this");
				AssetRequest<T>._loadAsset_d__39.NativeFieldInfoPtr_loadPriority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetRequest<T>._loadAsset_d__39>.NativeClassPtr, "loadPriority");
				AssetRequest<T>._loadAsset_d__39.NativeFieldInfoPtr_retryCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetRequest<T>._loadAsset_d__39>.NativeClassPtr, "retryCount");
				AssetRequest<T>._loadAsset_d__39.NativeFieldInfoPtr__request_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetRequest<T>._loadAsset_d__39>.NativeClassPtr, "<request>5__2");
				AssetRequest<T>._loadAsset_d__39.NativeFieldInfoPtr__subRequest_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetRequest<T>._loadAsset_d__39>.NativeClassPtr, "<subRequest>5__3");
				AssetRequest<T>._loadAsset_d__39.NativeFieldInfoPtr__retry_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetRequest<T>._loadAsset_d__39>.NativeClassPtr, "<retry>5__4");
				AssetRequest<T>._loadAsset_d__39.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetRequest<T>._loadAsset_d__39>.NativeClassPtr, 100667770);
				AssetRequest<T>._loadAsset_d__39.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetRequest<T>._loadAsset_d__39>.NativeClassPtr, 100667771);
				AssetRequest<T>._loadAsset_d__39.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetRequest<T>._loadAsset_d__39>.NativeClassPtr, 100667772);
				AssetRequest<T>._loadAsset_d__39.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetRequest<T>._loadAsset_d__39>.NativeClassPtr, 100667773);
				AssetRequest<T>._loadAsset_d__39.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetRequest<T>._loadAsset_d__39>.NativeClassPtr, 100667774);
				AssetRequest<T>._loadAsset_d__39.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetRequest<T>._loadAsset_d__39>.NativeClassPtr, 100667775);
			}

			// Token: 0x06002898 RID: 10392 RVA: 0x000AB2E0 File Offset: 0x000A94E0
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _loadAsset_d__39(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AssetRequest<T>._loadAsset_d__39>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetRequest<T>._loadAsset_d__39.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002899 RID: 10393 RVA: 0x000AB328 File Offset: 0x000A9528
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetRequest<T>._loadAsset_d__39.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600289A RID: 10394 RVA: 0x000AB35C File Offset: 0x000A955C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 885318, XrefRangeEnd = 885346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetRequest<T>._loadAsset_d__39.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000B86 RID: 2950
			// (get) Token: 0x0600289B RID: 10395 RVA: 0x000AB398 File Offset: 0x000A9598
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetRequest<T>._loadAsset_d__39.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600289C RID: 10396 RVA: 0x000AB3D8 File Offset: 0x000A95D8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetRequest<T>._loadAsset_d__39.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000B87 RID: 2951
			// (get) Token: 0x0600289D RID: 10397 RVA: 0x000AB40C File Offset: 0x000A960C
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetRequest<T>._loadAsset_d__39.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600289E RID: 10398 RVA: 0x000126B5 File Offset: 0x000108B5
			public _loadAsset_d__39(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000B7E RID: 2942
			// (get) Token: 0x0600289F RID: 10399 RVA: 0x000AB44C File Offset: 0x000A964C
			// (set) Token: 0x060028A0 RID: 10400 RVA: 0x000126BE File Offset: 0x000108BE
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetRequest<T>._loadAsset_d__39.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetRequest<T>._loadAsset_d__39.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000B7F RID: 2943
			// (get) Token: 0x060028A1 RID: 10401 RVA: 0x000AB474 File Offset: 0x000A9674
			// (set) Token: 0x060028A2 RID: 10402 RVA: 0x000126D9 File Offset: 0x000108D9
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetRequest<T>._loadAsset_d__39.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetRequest<T>._loadAsset_d__39.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B80 RID: 2944
			// (get) Token: 0x060028A3 RID: 10403 RVA: 0x000AB4A4 File Offset: 0x000A96A4
			// (set) Token: 0x060028A4 RID: 10404 RVA: 0x000126F8 File Offset: 0x000108F8
			public unsafe AssetRequest<T> __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetRequest<T>._loadAsset_d__39.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetRequest<T>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetRequest<T>._loadAsset_d__39.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B81 RID: 2945
			// (get) Token: 0x060028A5 RID: 10405 RVA: 0x000AB4D4 File Offset: 0x000A96D4
			// (set) Token: 0x060028A6 RID: 10406 RVA: 0x00012717 File Offset: 0x00010917
			public unsafe RequestPriority loadPriority
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetRequest<T>._loadAsset_d__39.NativeFieldInfoPtr_loadPriority);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetRequest<T>._loadAsset_d__39.NativeFieldInfoPtr_loadPriority)) = value;
				}
			}

			// Token: 0x17000B82 RID: 2946
			// (get) Token: 0x060028A7 RID: 10407 RVA: 0x000AB4FC File Offset: 0x000A96FC
			// (set) Token: 0x060028A8 RID: 10408 RVA: 0x00012732 File Offset: 0x00010932
			public unsafe int retryCount
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetRequest<T>._loadAsset_d__39.NativeFieldInfoPtr_retryCount);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetRequest<T>._loadAsset_d__39.NativeFieldInfoPtr_retryCount)) = value;
				}
			}

			// Token: 0x17000B83 RID: 2947
			// (get) Token: 0x060028A9 RID: 10409 RVA: 0x000AB524 File Offset: 0x000A9724
			// (set) Token: 0x060028AA RID: 10410 RVA: 0x0001274D File Offset: 0x0001094D
			public unsafe AssetBundleRequest _request_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetRequest<T>._loadAsset_d__39.NativeFieldInfoPtr__request_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetBundleRequest>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetRequest<T>._loadAsset_d__39.NativeFieldInfoPtr__request_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B84 RID: 2948
			// (get) Token: 0x060028AB RID: 10411 RVA: 0x000AB554 File Offset: 0x000A9754
			// (set) Token: 0x060028AC RID: 10412 RVA: 0x0001276C File Offset: 0x0001096C
			public unsafe AssetBundleRequest _subRequest_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetRequest<T>._loadAsset_d__39.NativeFieldInfoPtr__subRequest_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetBundleRequest>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetRequest<T>._loadAsset_d__39.NativeFieldInfoPtr__subRequest_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B85 RID: 2949
			// (get) Token: 0x060028AD RID: 10413 RVA: 0x000AB584 File Offset: 0x000A9784
			// (set) Token: 0x060028AE RID: 10414 RVA: 0x0001278B File Offset: 0x0001098B
			public unsafe IEnumerator _retry_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetRequest<T>._loadAsset_d__39.NativeFieldInfoPtr__retry_5__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetRequest<T>._loadAsset_d__39.NativeFieldInfoPtr__retry_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001B85 RID: 7045
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001B86 RID: 7046
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001B87 RID: 7047
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001B88 RID: 7048
			private static readonly IntPtr NativeFieldInfoPtr_loadPriority;

			// Token: 0x04001B89 RID: 7049
			private static readonly IntPtr NativeFieldInfoPtr_retryCount;

			// Token: 0x04001B8A RID: 7050
			private static readonly IntPtr NativeFieldInfoPtr__request_5__2;

			// Token: 0x04001B8B RID: 7051
			private static readonly IntPtr NativeFieldInfoPtr__subRequest_5__3;

			// Token: 0x04001B8C RID: 7052
			private static readonly IntPtr NativeFieldInfoPtr__retry_5__4;

			// Token: 0x04001B8D RID: 7053
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001B8E RID: 7054
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001B8F RID: 7055
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001B90 RID: 7056
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001B91 RID: 7057
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001B92 RID: 7058
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
