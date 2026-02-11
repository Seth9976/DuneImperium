using System;
using dwd.core.data.composition;
using dwd.core.direBytes.messages;
using dwd.core.networking.commands;
using dwd.core.session;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Runtime.CompilerServices;
using Il2CppSystem.Threading.Tasks;
using UnityEngine;
using UnityEngine.Networking;

namespace dwd.core.direBytes
{
	// Token: 0x0200000D RID: 13
	public class DireBytesProvider : MonoBehaviour
	{
		// Token: 0x0600005C RID: 92 RVA: 0x0000475C File Offset: 0x0000295C
		// Note: this type is marked as 'beforefieldinit'.
		static DireBytesProvider()
		{
			Il2CppClassPointerStore<DireBytesProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("direbytes.dll", "dwd.core.direBytes", "DireBytesProvider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DireBytesProvider>.NativeClassPtr);
			DireBytesProvider.NativeFieldInfoPtr_requestOnStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DireBytesProvider>.NativeClassPtr, "requestOnStart");
			DireBytesProvider.NativeFieldInfoPtr__Initialized_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DireBytesProvider>.NativeClassPtr, "<Initialized>k__BackingField");
			DireBytesProvider.NativeFieldInfoPtr__DireBytesData_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DireBytesProvider>.NativeClassPtr, "<DireBytesData>k__BackingField");
			DireBytesProvider.NativeFieldInfoPtr__DireBytesAlertData_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DireBytesProvider>.NativeClassPtr, "<DireBytesAlertData>k__BackingField");
			DireBytesProvider.NativeFieldInfoPtr_session = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DireBytesProvider>.NativeClassPtr, "session");
			DireBytesProvider.NativeFieldInfoPtr_cachedImageFolderName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DireBytesProvider>.NativeClassPtr, "cachedImageFolderName");
			DireBytesProvider.NativeFieldInfoPtr_promptDataMaxTileCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DireBytesProvider>.NativeClassPtr, "promptDataMaxTileCount");
			DireBytesProvider.NativeFieldInfoPtr_primaryImageFilePattern = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DireBytesProvider>.NativeClassPtr, "primaryImageFilePattern");
			DireBytesProvider.NativeFieldInfoPtr_alternateImageFilePattern = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DireBytesProvider>.NativeClassPtr, "alternateImageFilePattern");
			DireBytesProvider.NativeFieldInfoPtr_spriteNameHorizontal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DireBytesProvider>.NativeClassPtr, "spriteNameHorizontal");
			DireBytesProvider.NativeFieldInfoPtr_spriteNameVertical = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DireBytesProvider>.NativeClassPtr, "spriteNameVertical");
			DireBytesProvider.NativeFieldInfoPtr_spriteNameRectangle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DireBytesProvider>.NativeClassPtr, "spriteNameRectangle");
			DireBytesProvider.NativeFieldInfoPtr_spriteNameDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DireBytesProvider>.NativeClassPtr, "spriteNameDefault");
			DireBytesProvider.NativeFieldInfoPtr_spriteNameFormat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DireBytesProvider>.NativeClassPtr, "spriteNameFormat");
			DireBytesProvider.NativeFieldInfoPtr_layoutHorizontal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DireBytesProvider>.NativeClassPtr, "layoutHorizontal");
			DireBytesProvider.NativeFieldInfoPtr_layoutVertical = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DireBytesProvider>.NativeClassPtr, "layoutVertical");
			DireBytesProvider.NativeFieldInfoPtr_layoutRectangle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DireBytesProvider>.NativeClassPtr, "layoutRectangle");
			DireBytesProvider.NativeFieldInfoPtr_alertType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DireBytesProvider>.NativeClassPtr, "alertType");
			DireBytesProvider.NativeFieldInfoPtr_shopType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DireBytesProvider>.NativeClassPtr, "shopType");
			DireBytesProvider.NativeFieldInfoPtr_newsType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DireBytesProvider>.NativeClassPtr, "newsType");
			DireBytesProvider.NativeFieldInfoPtr_eventType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DireBytesProvider>.NativeClassPtr, "eventType");
			DireBytesProvider.NativeFieldInfoPtr_imageDirectoryPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DireBytesProvider>.NativeClassPtr, "imageDirectoryPath");
			DireBytesProvider.NativeFieldInfoPtr__HaveUnseenAlert_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DireBytesProvider>.NativeClassPtr, "<HaveUnseenAlert>k__BackingField");
			DireBytesProvider.NativeFieldInfoPtr__HaveUnseenTile_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DireBytesProvider>.NativeClassPtr, "<HaveUnseenTile>k__BackingField");
			DireBytesProvider.NativeMethodInfoPtr_get_Initialized_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DireBytesProvider>.NativeClassPtr, 100663342);
			DireBytesProvider.NativeMethodInfoPtr_set_Initialized_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DireBytesProvider>.NativeClassPtr, 100663343);
			DireBytesProvider.NativeMethodInfoPtr_get_DireBytesData_Public_get_VersionedList_1_DataComposition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DireBytesProvider>.NativeClassPtr, 100663344);
			DireBytesProvider.NativeMethodInfoPtr_set_DireBytesData_Private_set_Void_VersionedList_1_DataComposition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DireBytesProvider>.NativeClassPtr, 100663345);
			DireBytesProvider.NativeMethodInfoPtr_get_DireBytesAlertData_Public_get_VersionedList_1_DataComposition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DireBytesProvider>.NativeClassPtr, 100663346);
			DireBytesProvider.NativeMethodInfoPtr_set_DireBytesAlertData_Private_set_Void_VersionedList_1_DataComposition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DireBytesProvider>.NativeClassPtr, 100663347);
			DireBytesProvider.NativeMethodInfoPtr_get_HaveUnseenAlert_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DireBytesProvider>.NativeClassPtr, 100663348);
			DireBytesProvider.NativeMethodInfoPtr_set_HaveUnseenAlert_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DireBytesProvider>.NativeClassPtr, 100663349);
			DireBytesProvider.NativeMethodInfoPtr_get_HaveUnseenTile_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DireBytesProvider>.NativeClassPtr, 100663350);
			DireBytesProvider.NativeMethodInfoPtr_set_HaveUnseenTile_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DireBytesProvider>.NativeClassPtr, 100663351);
			DireBytesProvider.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DireBytesProvider>.NativeClassPtr, 100663352);
			DireBytesProvider.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DireBytesProvider>.NativeClassPtr, 100663353);
			DireBytesProvider.NativeMethodInfoPtr_Request_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DireBytesProvider>.NativeClassPtr, 100663354);
			DireBytesProvider.NativeMethodInfoPtr_ClearUnseenAlert_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DireBytesProvider>.NativeClassPtr, 100663355);
			DireBytesProvider.NativeMethodInfoPtr_ClearUnseenTile_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DireBytesProvider>.NativeClassPtr, 100663356);
			DireBytesProvider.NativeMethodInfoPtr_handle_Private_Void_DireBytesFound_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DireBytesProvider>.NativeClassPtr, 100663357);
			DireBytesProvider.NativeMethodInfoPtr_setupDireBytes_Private_IEnumerator_DireBytesFound_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DireBytesProvider>.NativeClassPtr, 100663358);
			DireBytesProvider.NativeMethodInfoPtr_EvaluatePredicateForData_Protected_Virtual_New_Boolean_DataComposition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DireBytesProvider>.NativeClassPtr, 100663359);
			DireBytesProvider.NativeMethodInfoPtr_updateDireBytesPromptDataLayouts_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DireBytesProvider>.NativeClassPtr, 100663360);
			DireBytesProvider.NativeMethodInfoPtr_getPromptTileLayout_Private_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DireBytesProvider>.NativeClassPtr, 100663361);
			DireBytesProvider.NativeMethodInfoPtr_setImageDataOnDisk_Private_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DireBytesProvider>.NativeClassPtr, 100663362);
			DireBytesProvider.NativeMethodInfoPtr_getDireByteImageData_Private_HashSet_1_DireByteImageData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DireBytesProvider>.NativeClassPtr, 100663363);
			DireBytesProvider.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DireBytesProvider>.NativeClassPtr, 100663364);
			DireBytesProvider.NativeMethodInfoPtr__setImageDataOnDisk_b__50_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DireBytesProvider>.NativeClassPtr, 100663365);
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x0600005D RID: 93 RVA: 0x00004B4C File Offset: 0x00002D4C
		// (set) Token: 0x0600005E RID: 94 RVA: 0x00004B88 File Offset: 0x00002D88
		public unsafe virtual bool Initialized
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DireBytesProvider.NativeMethodInfoPtr_get_Initialized_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DireBytesProvider.NativeMethodInfoPtr_set_Initialized_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x0600005F RID: 95 RVA: 0x00004BC8 File Offset: 0x00002DC8
		// (set) Token: 0x06000060 RID: 96 RVA: 0x00004C08 File Offset: 0x00002E08
		public unsafe VersionedList<DataComposition> DireBytesData
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DireBytesProvider.NativeMethodInfoPtr_get_DireBytesData_Public_get_VersionedList_1_DataComposition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<VersionedList<DataComposition>>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DireBytesProvider.NativeMethodInfoPtr_set_DireBytesData_Private_set_Void_VersionedList_1_DataComposition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x06000061 RID: 97 RVA: 0x00004C4C File Offset: 0x00002E4C
		// (set) Token: 0x06000062 RID: 98 RVA: 0x00004C8C File Offset: 0x00002E8C
		public unsafe VersionedList<DataComposition> DireBytesAlertData
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DireBytesProvider.NativeMethodInfoPtr_get_DireBytesAlertData_Public_get_VersionedList_1_DataComposition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<VersionedList<DataComposition>>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DireBytesProvider.NativeMethodInfoPtr_set_DireBytesAlertData_Private_set_Void_VersionedList_1_DataComposition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x06000063 RID: 99 RVA: 0x00004CD0 File Offset: 0x00002ED0
		// (set) Token: 0x06000064 RID: 100 RVA: 0x00004D0C File Offset: 0x00002F0C
		public unsafe bool HaveUnseenAlert
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DireBytesProvider.NativeMethodInfoPtr_get_HaveUnseenAlert_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DireBytesProvider.NativeMethodInfoPtr_set_HaveUnseenAlert_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x06000065 RID: 101 RVA: 0x00004D4C File Offset: 0x00002F4C
		// (set) Token: 0x06000066 RID: 102 RVA: 0x00004D88 File Offset: 0x00002F88
		public unsafe bool HaveUnseenTile
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DireBytesProvider.NativeMethodInfoPtr_get_HaveUnseenTile_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DireBytesProvider.NativeMethodInfoPtr_set_HaveUnseenTile_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000067 RID: 103 RVA: 0x00004DC8 File Offset: 0x00002FC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1234345, XrefRangeEnd = 1234389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DireBytesProvider.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000068 RID: 104 RVA: 0x00004DFC File Offset: 0x00002FFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1234389, XrefRangeEnd = 1234402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DireBytesProvider.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000069 RID: 105 RVA: 0x00004E30 File Offset: 0x00003030
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1234486, RefRangeEnd = 1234487, XrefRangeStart = 1234402, XrefRangeEnd = 1234486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Request()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DireBytesProvider.NativeMethodInfoPtr_Request_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00004E64 File Offset: 0x00003064
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 339010, RefRangeEnd = 339011, XrefRangeStart = 339010, XrefRangeEnd = 339011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearUnseenAlert()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DireBytesProvider.NativeMethodInfoPtr_ClearUnseenAlert_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00004E98 File Offset: 0x00003098
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 339010, RefRangeEnd = 339011, XrefRangeStart = 339010, XrefRangeEnd = 339011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearUnseenTile()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DireBytesProvider.NativeMethodInfoPtr_ClearUnseenTile_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600006C RID: 108 RVA: 0x00004ECC File Offset: 0x000030CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1234487, XrefRangeEnd = 1234494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void handle(DireBytesFound message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DireBytesProvider.NativeMethodInfoPtr_handle_Private_Void_DireBytesFound_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600006D RID: 109 RVA: 0x00004F10 File Offset: 0x00003110
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1234494, XrefRangeEnd = 1234500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator setupDireBytes(DireBytesFound message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DireBytesProvider.NativeMethodInfoPtr_setupDireBytes_Private_IEnumerator_DireBytesFound_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x0600006E RID: 110 RVA: 0x00004F60 File Offset: 0x00003160
		[CallerCount(184)]
		[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool EvaluatePredicateForData(DataComposition data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DireBytesProvider.NativeMethodInfoPtr_EvaluatePredicateForData_Protected_Virtual_New_Boolean_DataComposition_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600006F RID: 111 RVA: 0x00004FB8 File Offset: 0x000031B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1234534, RefRangeEnd = 1234535, XrefRangeStart = 1234500, XrefRangeEnd = 1234534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void updateDireBytesPromptDataLayouts()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DireBytesProvider.NativeMethodInfoPtr_updateDireBytesPromptDataLayouts_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000070 RID: 112 RVA: 0x00004FEC File Offset: 0x000031EC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1234542, RefRangeEnd = 1234543, XrefRangeStart = 1234535, XrefRangeEnd = 1234542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string getPromptTileLayout(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DireBytesProvider.NativeMethodInfoPtr_getPromptTileLayout_Private_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000071 RID: 113 RVA: 0x00005030 File Offset: 0x00003230
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1234543, XrefRangeEnd = 1234553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task setImageDataOnDisk()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DireBytesProvider.NativeMethodInfoPtr_setImageDataOnDisk_Private_Task_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x06000072 RID: 114 RVA: 0x00005070 File Offset: 0x00003270
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1234614, RefRangeEnd = 1234615, XrefRangeStart = 1234553, XrefRangeEnd = 1234614, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HashSet<DireBytesProvider.DireByteImageData> getDireByteImageData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DireBytesProvider.NativeMethodInfoPtr_getDireByteImageData_Private_HashSet_1_DireByteImageData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<HashSet<DireBytesProvider.DireByteImageData>>(intPtr3) : null;
		}

		// Token: 0x06000073 RID: 115 RVA: 0x000050B0 File Offset: 0x000032B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1234615, XrefRangeEnd = 1234619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DireBytesProvider()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DireBytesProvider>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DireBytesProvider.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000074 RID: 116 RVA: 0x000050EC File Offset: 0x000032EC
		[CallerCount(0)]
		public unsafe void _setImageDataOnDisk_b__50_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DireBytesProvider.NativeMethodInfoPtr__setImageDataOnDisk_b__50_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000075 RID: 117 RVA: 0x0000232D File Offset: 0x0000052D
		public DireBytesProvider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000076 RID: 118 RVA: 0x00005120 File Offset: 0x00003320
		// (set) Token: 0x06000077 RID: 119 RVA: 0x00002336 File Offset: 0x00000536
		public unsafe bool requestOnStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireBytesProvider.NativeFieldInfoPtr_requestOnStart);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireBytesProvider.NativeFieldInfoPtr_requestOnStart)) = value;
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000078 RID: 120 RVA: 0x00005148 File Offset: 0x00003348
		// (set) Token: 0x06000079 RID: 121 RVA: 0x00002351 File Offset: 0x00000551
		public unsafe bool _Initialized_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireBytesProvider.NativeFieldInfoPtr__Initialized_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireBytesProvider.NativeFieldInfoPtr__Initialized_k__BackingField)) = value;
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x0600007A RID: 122 RVA: 0x00005170 File Offset: 0x00003370
		// (set) Token: 0x0600007B RID: 123 RVA: 0x0000236C File Offset: 0x0000056C
		public unsafe VersionedList<DataComposition> _DireBytesData_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireBytesProvider.NativeFieldInfoPtr__DireBytesData_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VersionedList<DataComposition>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireBytesProvider.NativeFieldInfoPtr__DireBytesData_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x0600007C RID: 124 RVA: 0x000051A0 File Offset: 0x000033A0
		// (set) Token: 0x0600007D RID: 125 RVA: 0x0000238B File Offset: 0x0000058B
		public unsafe VersionedList<DataComposition> _DireBytesAlertData_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireBytesProvider.NativeFieldInfoPtr__DireBytesAlertData_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VersionedList<DataComposition>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireBytesProvider.NativeFieldInfoPtr__DireBytesAlertData_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x0600007E RID: 126 RVA: 0x000051D0 File Offset: 0x000033D0
		// (set) Token: 0x0600007F RID: 127 RVA: 0x000023AA File Offset: 0x000005AA
		public unsafe SessionProvider session
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireBytesProvider.NativeFieldInfoPtr_session);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SessionProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireBytesProvider.NativeFieldInfoPtr_session), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000080 RID: 128 RVA: 0x00005200 File Offset: 0x00003400
		// (set) Token: 0x06000081 RID: 129 RVA: 0x000023C9 File Offset: 0x000005C9
		public unsafe string cachedImageFolderName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireBytesProvider.NativeFieldInfoPtr_cachedImageFolderName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireBytesProvider.NativeFieldInfoPtr_cachedImageFolderName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000082 RID: 130 RVA: 0x00005228 File Offset: 0x00003428
		// (set) Token: 0x06000083 RID: 131 RVA: 0x000023E8 File Offset: 0x000005E8
		public unsafe static int promptDataMaxTileCount
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DireBytesProvider.NativeFieldInfoPtr_promptDataMaxTileCount, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DireBytesProvider.NativeFieldInfoPtr_promptDataMaxTileCount, (void*)(&value));
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000084 RID: 132 RVA: 0x00005244 File Offset: 0x00003444
		// (set) Token: 0x06000085 RID: 133 RVA: 0x000023F6 File Offset: 0x000005F6
		public unsafe static string primaryImageFilePattern
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DireBytesProvider.NativeFieldInfoPtr_primaryImageFilePattern, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DireBytesProvider.NativeFieldInfoPtr_primaryImageFilePattern, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000086 RID: 134 RVA: 0x00005264 File Offset: 0x00003464
		// (set) Token: 0x06000087 RID: 135 RVA: 0x00002408 File Offset: 0x00000608
		public unsafe static string alternateImageFilePattern
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DireBytesProvider.NativeFieldInfoPtr_alternateImageFilePattern, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DireBytesProvider.NativeFieldInfoPtr_alternateImageFilePattern, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000088 RID: 136 RVA: 0x00005284 File Offset: 0x00003484
		// (set) Token: 0x06000089 RID: 137 RVA: 0x0000241A File Offset: 0x0000061A
		public unsafe static string spriteNameHorizontal
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DireBytesProvider.NativeFieldInfoPtr_spriteNameHorizontal, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DireBytesProvider.NativeFieldInfoPtr_spriteNameHorizontal, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x0600008A RID: 138 RVA: 0x000052A4 File Offset: 0x000034A4
		// (set) Token: 0x0600008B RID: 139 RVA: 0x0000242C File Offset: 0x0000062C
		public unsafe static string spriteNameVertical
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DireBytesProvider.NativeFieldInfoPtr_spriteNameVertical, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DireBytesProvider.NativeFieldInfoPtr_spriteNameVertical, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x0600008C RID: 140 RVA: 0x000052C4 File Offset: 0x000034C4
		// (set) Token: 0x0600008D RID: 141 RVA: 0x0000243E File Offset: 0x0000063E
		public unsafe static string spriteNameRectangle
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DireBytesProvider.NativeFieldInfoPtr_spriteNameRectangle, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DireBytesProvider.NativeFieldInfoPtr_spriteNameRectangle, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x0600008E RID: 142 RVA: 0x000052E4 File Offset: 0x000034E4
		// (set) Token: 0x0600008F RID: 143 RVA: 0x00002450 File Offset: 0x00000650
		public unsafe static string spriteNameDefault
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DireBytesProvider.NativeFieldInfoPtr_spriteNameDefault, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DireBytesProvider.NativeFieldInfoPtr_spriteNameDefault, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06000090 RID: 144 RVA: 0x00005304 File Offset: 0x00003504
		// (set) Token: 0x06000091 RID: 145 RVA: 0x00002462 File Offset: 0x00000662
		public unsafe static string spriteNameFormat
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DireBytesProvider.NativeFieldInfoPtr_spriteNameFormat, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DireBytesProvider.NativeFieldInfoPtr_spriteNameFormat, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000092 RID: 146 RVA: 0x00005324 File Offset: 0x00003524
		// (set) Token: 0x06000093 RID: 147 RVA: 0x00002474 File Offset: 0x00000674
		public unsafe static string layoutHorizontal
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DireBytesProvider.NativeFieldInfoPtr_layoutHorizontal, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DireBytesProvider.NativeFieldInfoPtr_layoutHorizontal, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000094 RID: 148 RVA: 0x00005344 File Offset: 0x00003544
		// (set) Token: 0x06000095 RID: 149 RVA: 0x00002486 File Offset: 0x00000686
		public unsafe static string layoutVertical
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DireBytesProvider.NativeFieldInfoPtr_layoutVertical, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DireBytesProvider.NativeFieldInfoPtr_layoutVertical, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x06000096 RID: 150 RVA: 0x00005364 File Offset: 0x00003564
		// (set) Token: 0x06000097 RID: 151 RVA: 0x00002498 File Offset: 0x00000698
		public unsafe static string layoutRectangle
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DireBytesProvider.NativeFieldInfoPtr_layoutRectangle, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DireBytesProvider.NativeFieldInfoPtr_layoutRectangle, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x06000098 RID: 152 RVA: 0x00005384 File Offset: 0x00003584
		// (set) Token: 0x06000099 RID: 153 RVA: 0x000024AA File Offset: 0x000006AA
		public unsafe static string alertType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DireBytesProvider.NativeFieldInfoPtr_alertType, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DireBytesProvider.NativeFieldInfoPtr_alertType, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x0600009A RID: 154 RVA: 0x000053A4 File Offset: 0x000035A4
		// (set) Token: 0x0600009B RID: 155 RVA: 0x000024BC File Offset: 0x000006BC
		public unsafe static string shopType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DireBytesProvider.NativeFieldInfoPtr_shopType, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DireBytesProvider.NativeFieldInfoPtr_shopType, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x0600009C RID: 156 RVA: 0x000053C4 File Offset: 0x000035C4
		// (set) Token: 0x0600009D RID: 157 RVA: 0x000024CE File Offset: 0x000006CE
		public unsafe static string newsType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DireBytesProvider.NativeFieldInfoPtr_newsType, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DireBytesProvider.NativeFieldInfoPtr_newsType, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x0600009E RID: 158 RVA: 0x000053E4 File Offset: 0x000035E4
		// (set) Token: 0x0600009F RID: 159 RVA: 0x000024E0 File Offset: 0x000006E0
		public unsafe static string eventType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DireBytesProvider.NativeFieldInfoPtr_eventType, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DireBytesProvider.NativeFieldInfoPtr_eventType, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x060000A0 RID: 160 RVA: 0x00005404 File Offset: 0x00003604
		// (set) Token: 0x060000A1 RID: 161 RVA: 0x000024F2 File Offset: 0x000006F2
		public unsafe string imageDirectoryPath
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireBytesProvider.NativeFieldInfoPtr_imageDirectoryPath);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireBytesProvider.NativeFieldInfoPtr_imageDirectoryPath), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x060000A2 RID: 162 RVA: 0x0000542C File Offset: 0x0000362C
		// (set) Token: 0x060000A3 RID: 163 RVA: 0x00002511 File Offset: 0x00000711
		public unsafe bool _HaveUnseenAlert_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireBytesProvider.NativeFieldInfoPtr__HaveUnseenAlert_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireBytesProvider.NativeFieldInfoPtr__HaveUnseenAlert_k__BackingField)) = value;
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x060000A4 RID: 164 RVA: 0x00005454 File Offset: 0x00003654
		// (set) Token: 0x060000A5 RID: 165 RVA: 0x0000252C File Offset: 0x0000072C
		public unsafe bool _HaveUnseenTile_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireBytesProvider.NativeFieldInfoPtr__HaveUnseenTile_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireBytesProvider.NativeFieldInfoPtr__HaveUnseenTile_k__BackingField)) = value;
			}
		}

		// Token: 0x04000032 RID: 50
		private static readonly IntPtr NativeFieldInfoPtr_requestOnStart;

		// Token: 0x04000033 RID: 51
		private static readonly IntPtr NativeFieldInfoPtr__Initialized_k__BackingField;

		// Token: 0x04000034 RID: 52
		private static readonly IntPtr NativeFieldInfoPtr__DireBytesData_k__BackingField;

		// Token: 0x04000035 RID: 53
		private static readonly IntPtr NativeFieldInfoPtr__DireBytesAlertData_k__BackingField;

		// Token: 0x04000036 RID: 54
		private static readonly IntPtr NativeFieldInfoPtr_session;

		// Token: 0x04000037 RID: 55
		private static readonly IntPtr NativeFieldInfoPtr_cachedImageFolderName;

		// Token: 0x04000038 RID: 56
		private static readonly IntPtr NativeFieldInfoPtr_promptDataMaxTileCount;

		// Token: 0x04000039 RID: 57
		private static readonly IntPtr NativeFieldInfoPtr_primaryImageFilePattern;

		// Token: 0x0400003A RID: 58
		private static readonly IntPtr NativeFieldInfoPtr_alternateImageFilePattern;

		// Token: 0x0400003B RID: 59
		private static readonly IntPtr NativeFieldInfoPtr_spriteNameHorizontal;

		// Token: 0x0400003C RID: 60
		private static readonly IntPtr NativeFieldInfoPtr_spriteNameVertical;

		// Token: 0x0400003D RID: 61
		private static readonly IntPtr NativeFieldInfoPtr_spriteNameRectangle;

		// Token: 0x0400003E RID: 62
		private static readonly IntPtr NativeFieldInfoPtr_spriteNameDefault;

		// Token: 0x0400003F RID: 63
		private static readonly IntPtr NativeFieldInfoPtr_spriteNameFormat;

		// Token: 0x04000040 RID: 64
		private static readonly IntPtr NativeFieldInfoPtr_layoutHorizontal;

		// Token: 0x04000041 RID: 65
		private static readonly IntPtr NativeFieldInfoPtr_layoutVertical;

		// Token: 0x04000042 RID: 66
		private static readonly IntPtr NativeFieldInfoPtr_layoutRectangle;

		// Token: 0x04000043 RID: 67
		private static readonly IntPtr NativeFieldInfoPtr_alertType;

		// Token: 0x04000044 RID: 68
		private static readonly IntPtr NativeFieldInfoPtr_shopType;

		// Token: 0x04000045 RID: 69
		private static readonly IntPtr NativeFieldInfoPtr_newsType;

		// Token: 0x04000046 RID: 70
		private static readonly IntPtr NativeFieldInfoPtr_eventType;

		// Token: 0x04000047 RID: 71
		private static readonly IntPtr NativeFieldInfoPtr_imageDirectoryPath;

		// Token: 0x04000048 RID: 72
		private static readonly IntPtr NativeFieldInfoPtr__HaveUnseenAlert_k__BackingField;

		// Token: 0x04000049 RID: 73
		private static readonly IntPtr NativeFieldInfoPtr__HaveUnseenTile_k__BackingField;

		// Token: 0x0400004A RID: 74
		private static readonly IntPtr NativeMethodInfoPtr_get_Initialized_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x0400004B RID: 75
		private static readonly IntPtr NativeMethodInfoPtr_set_Initialized_Private_set_Void_Boolean_0;

		// Token: 0x0400004C RID: 76
		private static readonly IntPtr NativeMethodInfoPtr_get_DireBytesData_Public_get_VersionedList_1_DataComposition_0;

		// Token: 0x0400004D RID: 77
		private static readonly IntPtr NativeMethodInfoPtr_set_DireBytesData_Private_set_Void_VersionedList_1_DataComposition_0;

		// Token: 0x0400004E RID: 78
		private static readonly IntPtr NativeMethodInfoPtr_get_DireBytesAlertData_Public_get_VersionedList_1_DataComposition_0;

		// Token: 0x0400004F RID: 79
		private static readonly IntPtr NativeMethodInfoPtr_set_DireBytesAlertData_Private_set_Void_VersionedList_1_DataComposition_0;

		// Token: 0x04000050 RID: 80
		private static readonly IntPtr NativeMethodInfoPtr_get_HaveUnseenAlert_Public_get_Boolean_0;

		// Token: 0x04000051 RID: 81
		private static readonly IntPtr NativeMethodInfoPtr_set_HaveUnseenAlert_Private_set_Void_Boolean_0;

		// Token: 0x04000052 RID: 82
		private static readonly IntPtr NativeMethodInfoPtr_get_HaveUnseenTile_Public_get_Boolean_0;

		// Token: 0x04000053 RID: 83
		private static readonly IntPtr NativeMethodInfoPtr_set_HaveUnseenTile_Private_set_Void_Boolean_0;

		// Token: 0x04000054 RID: 84
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04000055 RID: 85
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04000056 RID: 86
		private static readonly IntPtr NativeMethodInfoPtr_Request_Public_Virtual_Final_New_Void_0;

		// Token: 0x04000057 RID: 87
		private static readonly IntPtr NativeMethodInfoPtr_ClearUnseenAlert_Public_Void_0;

		// Token: 0x04000058 RID: 88
		private static readonly IntPtr NativeMethodInfoPtr_ClearUnseenTile_Public_Void_0;

		// Token: 0x04000059 RID: 89
		private static readonly IntPtr NativeMethodInfoPtr_handle_Private_Void_DireBytesFound_0;

		// Token: 0x0400005A RID: 90
		private static readonly IntPtr NativeMethodInfoPtr_setupDireBytes_Private_IEnumerator_DireBytesFound_0;

		// Token: 0x0400005B RID: 91
		private static readonly IntPtr NativeMethodInfoPtr_EvaluatePredicateForData_Protected_Virtual_New_Boolean_DataComposition_0;

		// Token: 0x0400005C RID: 92
		private static readonly IntPtr NativeMethodInfoPtr_updateDireBytesPromptDataLayouts_Private_Void_0;

		// Token: 0x0400005D RID: 93
		private static readonly IntPtr NativeMethodInfoPtr_getPromptTileLayout_Private_String_Int32_0;

		// Token: 0x0400005E RID: 94
		private static readonly IntPtr NativeMethodInfoPtr_setImageDataOnDisk_Private_Task_0;

		// Token: 0x0400005F RID: 95
		private static readonly IntPtr NativeMethodInfoPtr_getDireByteImageData_Private_HashSet_1_DireByteImageData_0;

		// Token: 0x04000060 RID: 96
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000061 RID: 97
		private static readonly IntPtr NativeMethodInfoPtr__setImageDataOnDisk_b__50_0_Private_Void_0;

		// Token: 0x0200002E RID: 46
		public sealed class DireByteImageData : ValueType
		{
			// Token: 0x06000219 RID: 537 RVA: 0x00009400 File Offset: 0x00007600
			// Note: this type is marked as 'beforefieldinit'.
			static DireByteImageData()
			{
				Il2CppClassPointerStore<DireBytesProvider.DireByteImageData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DireBytesProvider>.NativeClassPtr, "DireByteImageData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DireBytesProvider.DireByteImageData>.NativeClassPtr);
				DireBytesProvider.DireByteImageData.NativeFieldInfoPtr_ImageType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DireBytesProvider.DireByteImageData>.NativeClassPtr, "ImageType");
				DireBytesProvider.DireByteImageData.NativeFieldInfoPtr_ImageData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DireBytesProvider.DireByteImageData>.NativeClassPtr, "ImageData");
				DireBytesProvider.DireByteImageData.NativeMethodInfoPtr__ctor_Public_Void_String_TextBundleImageData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DireBytesProvider.DireByteImageData>.NativeClassPtr, 100663366);
			}

			// Token: 0x0600021A RID: 538 RVA: 0x00009468 File Offset: 0x00007668
			[CallerCount(238)]
			[CachedScanResults(RefRangeStart = 342357, RefRangeEnd = 342595, XrefRangeStart = 342357, XrefRangeEnd = 342595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DireByteImageData(string imageType, TextBundleImageData imageData)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DireBytesProvider.DireByteImageData>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(imageType);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(imageData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DireBytesProvider.DireByteImageData.NativeMethodInfoPtr__ctor_Public_Void_String_TextBundleImageData_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600021B RID: 539 RVA: 0x0000333C File Offset: 0x0000153C
			public DireByteImageData(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600021C RID: 540 RVA: 0x00003345 File Offset: 0x00001545
			public DireByteImageData()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DireBytesProvider.DireByteImageData>.NativeClassPtr))
			{
			}

			// Token: 0x170000AE RID: 174
			// (get) Token: 0x0600021D RID: 541 RVA: 0x000094CC File Offset: 0x000076CC
			// (set) Token: 0x0600021E RID: 542 RVA: 0x00003357 File Offset: 0x00001557
			public unsafe string ImageType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireBytesProvider.DireByteImageData.NativeFieldInfoPtr_ImageType);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireBytesProvider.DireByteImageData.NativeFieldInfoPtr_ImageType), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170000AF RID: 175
			// (get) Token: 0x0600021F RID: 543 RVA: 0x000094F4 File Offset: 0x000076F4
			// (set) Token: 0x06000220 RID: 544 RVA: 0x00003376 File Offset: 0x00001576
			public unsafe TextBundleImageData ImageData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireBytesProvider.DireByteImageData.NativeFieldInfoPtr_ImageData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextBundleImageData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireBytesProvider.DireByteImageData.NativeFieldInfoPtr_ImageData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000129 RID: 297
			private static readonly IntPtr NativeFieldInfoPtr_ImageType;

			// Token: 0x0400012A RID: 298
			private static readonly IntPtr NativeFieldInfoPtr_ImageData;

			// Token: 0x0400012B RID: 299
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_TextBundleImageData_0;
		}

		// Token: 0x0200002F RID: 47
		[ObfuscatedName("dwd.core.direBytes.DireBytesProvider+<>c")]
		[Serializable]
		public sealed class __c : global::Il2CppSystem.Object
		{
			// Token: 0x06000221 RID: 545 RVA: 0x00009524 File Offset: 0x00007724
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<DireBytesProvider.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DireBytesProvider>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DireBytesProvider.__c>.NativeClassPtr);
				DireBytesProvider.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DireBytesProvider.__c>.NativeClassPtr, "<>9");
				DireBytesProvider.__c.NativeFieldInfoPtr___9__42_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DireBytesProvider.__c>.NativeClassPtr, "<>9__42_0");
				DireBytesProvider.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DireBytesProvider.__c>.NativeClassPtr, 100663368);
				DireBytesProvider.__c.NativeMethodInfoPtr__Request_b__42_0_Internal_Void_UnityWebRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DireBytesProvider.__c>.NativeClassPtr, 100663369);
			}

			// Token: 0x06000222 RID: 546 RVA: 0x000095A0 File Offset: 0x000077A0
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DireBytesProvider.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DireBytesProvider.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000223 RID: 547 RVA: 0x000095DC File Offset: 0x000077DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1233778, XrefRangeEnd = 1233786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Request_b__42_0(UnityWebRequest request)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(request);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DireBytesProvider.__c.NativeMethodInfoPtr__Request_b__42_0_Internal_Void_UnityWebRequest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000224 RID: 548 RVA: 0x00003395 File Offset: 0x00001595
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170000B0 RID: 176
			// (get) Token: 0x06000225 RID: 549 RVA: 0x00009620 File Offset: 0x00007820
			// (set) Token: 0x06000226 RID: 550 RVA: 0x0000339E File Offset: 0x0000159E
			public unsafe static DireBytesProvider.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DireBytesProvider.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DireBytesProvider.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DireBytesProvider.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000B1 RID: 177
			// (get) Token: 0x06000227 RID: 551 RVA: 0x00009648 File Offset: 0x00007848
			// (set) Token: 0x06000228 RID: 552 RVA: 0x000033B0 File Offset: 0x000015B0
			public unsafe static Action<UnityWebRequest> __9__42_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DireBytesProvider.__c.NativeFieldInfoPtr___9__42_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<UnityWebRequest>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DireBytesProvider.__c.NativeFieldInfoPtr___9__42_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400012C RID: 300
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400012D RID: 301
			private static readonly IntPtr NativeFieldInfoPtr___9__42_0;

			// Token: 0x0400012E RID: 302
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400012F RID: 303
			private static readonly IntPtr NativeMethodInfoPtr__Request_b__42_0_Internal_Void_UnityWebRequest_0;
		}

		// Token: 0x02000030 RID: 48
		[ObfuscatedName("dwd.core.direBytes.DireBytesProvider+<>c__DisplayClass42_0")]
		public sealed class __c__DisplayClass42_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06000229 RID: 553 RVA: 0x00009670 File Offset: 0x00007870
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass42_0()
			{
				Il2CppClassPointerStore<DireBytesProvider.__c__DisplayClass42_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DireBytesProvider>.NativeClassPtr, "<>c__DisplayClass42_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DireBytesProvider.__c__DisplayClass42_0>.NativeClassPtr);
				DireBytesProvider.__c__DisplayClass42_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DireBytesProvider.__c__DisplayClass42_0>.NativeClassPtr, "<>4__this");
				DireBytesProvider.__c__DisplayClass42_0.NativeFieldInfoPtr_url = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DireBytesProvider.__c__DisplayClass42_0>.NativeClassPtr, "url");
				DireBytesProvider.__c__DisplayClass42_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DireBytesProvider.__c__DisplayClass42_0>.NativeClassPtr, 100663370);
				DireBytesProvider.__c__DisplayClass42_0.NativeMethodInfoPtr__Request_b__1_Internal_Void_DwdWebRequestCommand_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DireBytesProvider.__c__DisplayClass42_0>.NativeClassPtr, 100663371);
				DireBytesProvider.__c__DisplayClass42_0.NativeMethodInfoPtr__Request_b__2_Internal_Void_ErrorInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DireBytesProvider.__c__DisplayClass42_0>.NativeClassPtr, 100663372);
			}

			// Token: 0x0600022A RID: 554 RVA: 0x00009700 File Offset: 0x00007900
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass42_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DireBytesProvider.__c__DisplayClass42_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DireBytesProvider.__c__DisplayClass42_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600022B RID: 555 RVA: 0x0000973C File Offset: 0x0000793C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1233786, XrefRangeEnd = 1233801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Request_b__1(DwdWebRequestCommand request)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(request);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DireBytesProvider.__c__DisplayClass42_0.NativeMethodInfoPtr__Request_b__1_Internal_Void_DwdWebRequestCommand_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600022C RID: 556 RVA: 0x00009780 File Offset: 0x00007980
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1233801, XrefRangeEnd = 1233813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Request_b__2(ErrorInfo status)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(status));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DireBytesProvider.__c__DisplayClass42_0.NativeMethodInfoPtr__Request_b__2_Internal_Void_ErrorInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600022D RID: 557 RVA: 0x000033C2 File Offset: 0x000015C2
			public __c__DisplayClass42_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170000B2 RID: 178
			// (get) Token: 0x0600022E RID: 558 RVA: 0x000097C8 File Offset: 0x000079C8
			// (set) Token: 0x0600022F RID: 559 RVA: 0x000033CB File Offset: 0x000015CB
			public unsafe DireBytesProvider __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireBytesProvider.__c__DisplayClass42_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DireBytesProvider>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireBytesProvider.__c__DisplayClass42_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000B3 RID: 179
			// (get) Token: 0x06000230 RID: 560 RVA: 0x000097F8 File Offset: 0x000079F8
			// (set) Token: 0x06000231 RID: 561 RVA: 0x000033EA File Offset: 0x000015EA
			public unsafe string url
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireBytesProvider.__c__DisplayClass42_0.NativeFieldInfoPtr_url);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireBytesProvider.__c__DisplayClass42_0.NativeFieldInfoPtr_url), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04000130 RID: 304
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000131 RID: 305
			private static readonly IntPtr NativeFieldInfoPtr_url;

			// Token: 0x04000132 RID: 306
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000133 RID: 307
			private static readonly IntPtr NativeMethodInfoPtr__Request_b__1_Internal_Void_DwdWebRequestCommand_0;

			// Token: 0x04000134 RID: 308
			private static readonly IntPtr NativeMethodInfoPtr__Request_b__2_Internal_Void_ErrorInfo_0;
		}

		// Token: 0x02000031 RID: 49
		[ObfuscatedName("dwd.core.direBytes.DireBytesProvider+<setImageDataOnDisk>d__50")]
		public sealed class _setImageDataOnDisk_d__50 : ValueType
		{
			// Token: 0x06000232 RID: 562 RVA: 0x00009820 File Offset: 0x00007A20
			// Note: this type is marked as 'beforefieldinit'.
			static _setImageDataOnDisk_d__50()
			{
				Il2CppClassPointerStore<DireBytesProvider._setImageDataOnDisk_d__50>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DireBytesProvider>.NativeClassPtr, "<setImageDataOnDisk>d__50");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DireBytesProvider._setImageDataOnDisk_d__50>.NativeClassPtr);
				DireBytesProvider._setImageDataOnDisk_d__50.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DireBytesProvider._setImageDataOnDisk_d__50>.NativeClassPtr, "<>1__state");
				DireBytesProvider._setImageDataOnDisk_d__50.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DireBytesProvider._setImageDataOnDisk_d__50>.NativeClassPtr, "<>t__builder");
				DireBytesProvider._setImageDataOnDisk_d__50.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DireBytesProvider._setImageDataOnDisk_d__50>.NativeClassPtr, "<>4__this");
				DireBytesProvider._setImageDataOnDisk_d__50.NativeFieldInfoPtr__currentDownloadedImageNames_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DireBytesProvider._setImageDataOnDisk_d__50>.NativeClassPtr, "<currentDownloadedImageNames>5__2");
				DireBytesProvider._setImageDataOnDisk_d__50.NativeFieldInfoPtr__imagesMarkedForDownload_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DireBytesProvider._setImageDataOnDisk_d__50>.NativeClassPtr, "<imagesMarkedForDownload>5__3");
				DireBytesProvider._setImageDataOnDisk_d__50.NativeFieldInfoPtr__imagesCurrentlyUsedOnDisk_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DireBytesProvider._setImageDataOnDisk_d__50>.NativeClassPtr, "<imagesCurrentlyUsedOnDisk>5__4");
				DireBytesProvider._setImageDataOnDisk_d__50.NativeFieldInfoPtr___7__wrap4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DireBytesProvider._setImageDataOnDisk_d__50>.NativeClassPtr, "<>7__wrap4");
				DireBytesProvider._setImageDataOnDisk_d__50.NativeFieldInfoPtr__direByteImage_5__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DireBytesProvider._setImageDataOnDisk_d__50>.NativeClassPtr, "<direByteImage>5__6");
				DireBytesProvider._setImageDataOnDisk_d__50.NativeFieldInfoPtr__alternateName_5__7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DireBytesProvider._setImageDataOnDisk_d__50>.NativeClassPtr, "<alternateName>5__7");
				DireBytesProvider._setImageDataOnDisk_d__50.NativeFieldInfoPtr__spriteName_5__8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DireBytesProvider._setImageDataOnDisk_d__50>.NativeClassPtr, "<spriteName>5__8");
				DireBytesProvider._setImageDataOnDisk_d__50.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DireBytesProvider._setImageDataOnDisk_d__50>.NativeClassPtr, "<>u__1");
				DireBytesProvider._setImageDataOnDisk_d__50.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DireBytesProvider._setImageDataOnDisk_d__50>.NativeClassPtr, 100663373);
				DireBytesProvider._setImageDataOnDisk_d__50.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DireBytesProvider._setImageDataOnDisk_d__50>.NativeClassPtr, 100663374);
			}

			// Token: 0x06000233 RID: 563 RVA: 0x00009950 File Offset: 0x00007B50
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1233813, XrefRangeEnd = 1234048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DireBytesProvider._setImageDataOnDisk_d__50.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000234 RID: 564 RVA: 0x00009988 File Offset: 0x00007B88
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1234048, XrefRangeEnd = 1234052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DireBytesProvider._setImageDataOnDisk_d__50.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000235 RID: 565 RVA: 0x00003409 File Offset: 0x00001609
			public _setImageDataOnDisk_d__50(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06000236 RID: 566 RVA: 0x00003412 File Offset: 0x00001612
			public _setImageDataOnDisk_d__50()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DireBytesProvider._setImageDataOnDisk_d__50>.NativeClassPtr))
			{
			}

			// Token: 0x170000B4 RID: 180
			// (get) Token: 0x06000237 RID: 567 RVA: 0x000099D0 File Offset: 0x00007BD0
			// (set) Token: 0x06000238 RID: 568 RVA: 0x00003424 File Offset: 0x00001624
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireBytesProvider._setImageDataOnDisk_d__50.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireBytesProvider._setImageDataOnDisk_d__50.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170000B5 RID: 181
			// (get) Token: 0x06000239 RID: 569 RVA: 0x000099F8 File Offset: 0x00007BF8
			// (set) Token: 0x0600023A RID: 570 RVA: 0x0000343F File Offset: 0x0000163F
			public AsyncTaskMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireBytesProvider._setImageDataOnDisk_d__50.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireBytesProvider._setImageDataOnDisk_d__50.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170000B6 RID: 182
			// (get) Token: 0x0600023B RID: 571 RVA: 0x00009A28 File Offset: 0x00007C28
			// (set) Token: 0x0600023C RID: 572 RVA: 0x0000346D File Offset: 0x0000166D
			public unsafe DireBytesProvider __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireBytesProvider._setImageDataOnDisk_d__50.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DireBytesProvider>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireBytesProvider._setImageDataOnDisk_d__50.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000B7 RID: 183
			// (get) Token: 0x0600023D RID: 573 RVA: 0x00009A58 File Offset: 0x00007C58
			// (set) Token: 0x0600023E RID: 574 RVA: 0x0000348C File Offset: 0x0000168C
			public unsafe List<string> _currentDownloadedImageNames_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireBytesProvider._setImageDataOnDisk_d__50.NativeFieldInfoPtr__currentDownloadedImageNames_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireBytesProvider._setImageDataOnDisk_d__50.NativeFieldInfoPtr__currentDownloadedImageNames_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000B8 RID: 184
			// (get) Token: 0x0600023F RID: 575 RVA: 0x00009A88 File Offset: 0x00007C88
			// (set) Token: 0x06000240 RID: 576 RVA: 0x000034AB File Offset: 0x000016AB
			public unsafe HashSet<string> _imagesMarkedForDownload_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireBytesProvider._setImageDataOnDisk_d__50.NativeFieldInfoPtr__imagesMarkedForDownload_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<string>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireBytesProvider._setImageDataOnDisk_d__50.NativeFieldInfoPtr__imagesMarkedForDownload_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000B9 RID: 185
			// (get) Token: 0x06000241 RID: 577 RVA: 0x00009AB8 File Offset: 0x00007CB8
			// (set) Token: 0x06000242 RID: 578 RVA: 0x000034CA File Offset: 0x000016CA
			public unsafe HashSet<string> _imagesCurrentlyUsedOnDisk_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireBytesProvider._setImageDataOnDisk_d__50.NativeFieldInfoPtr__imagesCurrentlyUsedOnDisk_5__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<string>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireBytesProvider._setImageDataOnDisk_d__50.NativeFieldInfoPtr__imagesCurrentlyUsedOnDisk_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000BA RID: 186
			// (get) Token: 0x06000243 RID: 579 RVA: 0x00009AE8 File Offset: 0x00007CE8
			// (set) Token: 0x06000244 RID: 580 RVA: 0x000034E9 File Offset: 0x000016E9
			public HashSet<DireBytesProvider.DireByteImageData>.Enumerator __7__wrap4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireBytesProvider._setImageDataOnDisk_d__50.NativeFieldInfoPtr___7__wrap4);
					return new HashSet<DireBytesProvider.DireByteImageData>.Enumerator(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HashSet<DireBytesProvider.DireByteImageData>.Enumerator>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireBytesProvider._setImageDataOnDisk_d__50.NativeFieldInfoPtr___7__wrap4), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<HashSet<DireBytesProvider.DireByteImageData>.Enumerator>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170000BB RID: 187
			// (get) Token: 0x06000245 RID: 581 RVA: 0x00009B18 File Offset: 0x00007D18
			// (set) Token: 0x06000246 RID: 582 RVA: 0x00003517 File Offset: 0x00001717
			public DireBytesProvider.DireByteImageData _direByteImage_5__6
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireBytesProvider._setImageDataOnDisk_d__50.NativeFieldInfoPtr__direByteImage_5__6);
					return new DireBytesProvider.DireByteImageData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DireBytesProvider.DireByteImageData>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireBytesProvider._setImageDataOnDisk_d__50.NativeFieldInfoPtr__direByteImage_5__6), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DireBytesProvider.DireByteImageData>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170000BC RID: 188
			// (get) Token: 0x06000247 RID: 583 RVA: 0x00009B48 File Offset: 0x00007D48
			// (set) Token: 0x06000248 RID: 584 RVA: 0x00003545 File Offset: 0x00001745
			public unsafe string _alternateName_5__7
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireBytesProvider._setImageDataOnDisk_d__50.NativeFieldInfoPtr__alternateName_5__7);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireBytesProvider._setImageDataOnDisk_d__50.NativeFieldInfoPtr__alternateName_5__7), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170000BD RID: 189
			// (get) Token: 0x06000249 RID: 585 RVA: 0x00009B70 File Offset: 0x00007D70
			// (set) Token: 0x0600024A RID: 586 RVA: 0x00003564 File Offset: 0x00001764
			public unsafe string _spriteName_5__8
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireBytesProvider._setImageDataOnDisk_d__50.NativeFieldInfoPtr__spriteName_5__8);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireBytesProvider._setImageDataOnDisk_d__50.NativeFieldInfoPtr__spriteName_5__8), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170000BE RID: 190
			// (get) Token: 0x0600024B RID: 587 RVA: 0x00009B98 File Offset: 0x00007D98
			// (set) Token: 0x0600024C RID: 588 RVA: 0x00003583 File Offset: 0x00001783
			public TaskAwaiter<Sprite> __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireBytesProvider._setImageDataOnDisk_d__50.NativeFieldInfoPtr___u__1);
					return new TaskAwaiter<Sprite>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TaskAwaiter<Sprite>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireBytesProvider._setImageDataOnDisk_d__50.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TaskAwaiter<Sprite>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04000135 RID: 309
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000136 RID: 310
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04000137 RID: 311
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000138 RID: 312
			private static readonly IntPtr NativeFieldInfoPtr__currentDownloadedImageNames_5__2;

			// Token: 0x04000139 RID: 313
			private static readonly IntPtr NativeFieldInfoPtr__imagesMarkedForDownload_5__3;

			// Token: 0x0400013A RID: 314
			private static readonly IntPtr NativeFieldInfoPtr__imagesCurrentlyUsedOnDisk_5__4;

			// Token: 0x0400013B RID: 315
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap4;

			// Token: 0x0400013C RID: 316
			private static readonly IntPtr NativeFieldInfoPtr__direByteImage_5__6;

			// Token: 0x0400013D RID: 317
			private static readonly IntPtr NativeFieldInfoPtr__alternateName_5__7;

			// Token: 0x0400013E RID: 318
			private static readonly IntPtr NativeFieldInfoPtr__spriteName_5__8;

			// Token: 0x0400013F RID: 319
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04000140 RID: 320
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000141 RID: 321
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x02000032 RID: 50
		[ObfuscatedName("dwd.core.direBytes.DireBytesProvider+<setupDireBytes>d__46")]
		public sealed class _setupDireBytes_d__46 : global::Il2CppSystem.Object
		{
			// Token: 0x0600024D RID: 589 RVA: 0x00009BC8 File Offset: 0x00007DC8
			// Note: this type is marked as 'beforefieldinit'.
			static _setupDireBytes_d__46()
			{
				Il2CppClassPointerStore<DireBytesProvider._setupDireBytes_d__46>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DireBytesProvider>.NativeClassPtr, "<setupDireBytes>d__46");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DireBytesProvider._setupDireBytes_d__46>.NativeClassPtr);
				DireBytesProvider._setupDireBytes_d__46.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DireBytesProvider._setupDireBytes_d__46>.NativeClassPtr, "<>1__state");
				DireBytesProvider._setupDireBytes_d__46.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DireBytesProvider._setupDireBytes_d__46>.NativeClassPtr, "<>2__current");
				DireBytesProvider._setupDireBytes_d__46.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DireBytesProvider._setupDireBytes_d__46>.NativeClassPtr, "<>4__this");
				DireBytesProvider._setupDireBytes_d__46.NativeFieldInfoPtr_message = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DireBytesProvider._setupDireBytes_d__46>.NativeClassPtr, "message");
				DireBytesProvider._setupDireBytes_d__46.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DireBytesProvider._setupDireBytes_d__46>.NativeClassPtr, 100663375);
				DireBytesProvider._setupDireBytes_d__46.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DireBytesProvider._setupDireBytes_d__46>.NativeClassPtr, 100663376);
				DireBytesProvider._setupDireBytes_d__46.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DireBytesProvider._setupDireBytes_d__46>.NativeClassPtr, 100663377);
				DireBytesProvider._setupDireBytes_d__46.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DireBytesProvider._setupDireBytes_d__46>.NativeClassPtr, 100663378);
				DireBytesProvider._setupDireBytes_d__46.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DireBytesProvider._setupDireBytes_d__46>.NativeClassPtr, 100663379);
				DireBytesProvider._setupDireBytes_d__46.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DireBytesProvider._setupDireBytes_d__46>.NativeClassPtr, 100663380);
			}

			// Token: 0x0600024E RID: 590 RVA: 0x00009CBC File Offset: 0x00007EBC
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _setupDireBytes_d__46(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DireBytesProvider._setupDireBytes_d__46>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DireBytesProvider._setupDireBytes_d__46.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600024F RID: 591 RVA: 0x00009D04 File Offset: 0x00007F04
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DireBytesProvider._setupDireBytes_d__46.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000250 RID: 592 RVA: 0x00009D38 File Offset: 0x00007F38
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1234052, XrefRangeEnd = 1234340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DireBytesProvider._setupDireBytes_d__46.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170000C3 RID: 195
			// (get) Token: 0x06000251 RID: 593 RVA: 0x00009D74 File Offset: 0x00007F74
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DireBytesProvider._setupDireBytes_d__46.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000252 RID: 594 RVA: 0x00009DB4 File Offset: 0x00007FB4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1234340, XrefRangeEnd = 1234345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DireBytesProvider._setupDireBytes_d__46.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170000C4 RID: 196
			// (get) Token: 0x06000253 RID: 595 RVA: 0x00009DE8 File Offset: 0x00007FE8
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DireBytesProvider._setupDireBytes_d__46.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000254 RID: 596 RVA: 0x000035B1 File Offset: 0x000017B1
			public _setupDireBytes_d__46(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170000BF RID: 191
			// (get) Token: 0x06000255 RID: 597 RVA: 0x00009E28 File Offset: 0x00008028
			// (set) Token: 0x06000256 RID: 598 RVA: 0x000035BA File Offset: 0x000017BA
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireBytesProvider._setupDireBytes_d__46.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireBytesProvider._setupDireBytes_d__46.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170000C0 RID: 192
			// (get) Token: 0x06000257 RID: 599 RVA: 0x00009E50 File Offset: 0x00008050
			// (set) Token: 0x06000258 RID: 600 RVA: 0x000035D5 File Offset: 0x000017D5
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireBytesProvider._setupDireBytes_d__46.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireBytesProvider._setupDireBytes_d__46.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000C1 RID: 193
			// (get) Token: 0x06000259 RID: 601 RVA: 0x00009E80 File Offset: 0x00008080
			// (set) Token: 0x0600025A RID: 602 RVA: 0x000035F4 File Offset: 0x000017F4
			public unsafe DireBytesProvider __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireBytesProvider._setupDireBytes_d__46.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DireBytesProvider>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireBytesProvider._setupDireBytes_d__46.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000C2 RID: 194
			// (get) Token: 0x0600025B RID: 603 RVA: 0x00009EB0 File Offset: 0x000080B0
			// (set) Token: 0x0600025C RID: 604 RVA: 0x00003613 File Offset: 0x00001813
			public unsafe DireBytesFound message
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireBytesProvider._setupDireBytes_d__46.NativeFieldInfoPtr_message);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DireBytesFound>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireBytesProvider._setupDireBytes_d__46.NativeFieldInfoPtr_message), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000142 RID: 322
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000143 RID: 323
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000144 RID: 324
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000145 RID: 325
			private static readonly IntPtr NativeFieldInfoPtr_message;

			// Token: 0x04000146 RID: 326
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000147 RID: 327
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000148 RID: 328
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000149 RID: 329
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400014A RID: 330
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400014B RID: 331
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
