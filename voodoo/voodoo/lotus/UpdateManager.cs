using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace lotus
{
	// Token: 0x02000080 RID: 128
	public class UpdateManager : MonoBehaviour
	{
		// Token: 0x0600078C RID: 1932 RVA: 0x00022658 File Offset: 0x00020858
		// Note: this type is marked as 'beforefieldinit'.
		static UpdateManager()
		{
			Il2CppClassPointerStore<UpdateManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("voodoo.dll", "lotus", "UpdateManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UpdateManager>.NativeClassPtr);
			UpdateManager.NativeFieldInfoPtr_dirtyObjects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateManager>.NativeClassPtr, "dirtyObjects");
			UpdateManager.NativeFieldInfoPtr_objects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateManager>.NativeClassPtr, "objects");
			UpdateManager.NativeFieldInfoPtr_updatedObjects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateManager>.NativeClassPtr, "updatedObjects");
			UpdateManager.NativeFieldInfoPtr_normalizedObservers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateManager>.NativeClassPtr, "normalizedObservers");
			UpdateManager.NativeFieldInfoPtr_dirtyObservers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateManager>.NativeClassPtr, "dirtyObservers");
			UpdateManager.NativeMethodInfoPtr_MarkDirty_Public_Void_IAmDirty_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateManager>.NativeClassPtr, 100664321);
			UpdateManager.NativeMethodInfoPtr_RemoveDirty_Public_Void_IAmDirty_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateManager>.NativeClassPtr, 100664322);
			UpdateManager.NativeMethodInfoPtr_Add_Public_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateManager>.NativeClassPtr, 100664323);
			UpdateManager.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateManager>.NativeClassPtr, 100664324);
			UpdateManager.NativeMethodInfoPtr_LateCoroutineUpdate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateManager>.NativeClassPtr, 100664325);
			UpdateManager.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateManager>.NativeClassPtr, 100664326);
			UpdateManager.NativeMethodInfoPtr_internalUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateManager>.NativeClassPtr, 100664327);
			UpdateManager.NativeMethodInfoPtr_normalizeObserver_Private_Void_List_1_IAmDirty_HashSet_1_IAmDirty_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateManager>.NativeClassPtr, 100664328);
			UpdateManager.NativeMethodInfoPtr_notifyObserver_Private_Void_IAmDirty_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateManager>.NativeClassPtr, 100664329);
			UpdateManager.NativeMethodInfoPtr_UpdateMeWhenThisIsDirty_Public_Void_IAmDirty_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateManager>.NativeClassPtr, 100664330);
			UpdateManager.NativeMethodInfoPtr_DontUpdateMeWhenThisIsDirty_Public_Void_IAmDirty_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateManager>.NativeClassPtr, 100664331);
			UpdateManager.NativeMethodInfoPtr_GetStatistics_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateManager>.NativeClassPtr, 100664332);
			UpdateManager.NativeMethodInfoPtr_OutputDirtyObservers_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateManager>.NativeClassPtr, 100664333);
			UpdateManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateManager>.NativeClassPtr, 100664334);
		}

		// Token: 0x0600078D RID: 1933 RVA: 0x00022804 File Offset: 0x00020A04
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 1114580, RefRangeEnd = 1114593, XrefRangeStart = 1114571, XrefRangeEnd = 1114580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MarkDirty(IAmDirty dirtyObj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dirtyObj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UpdateManager.NativeMethodInfoPtr_MarkDirty_Public_Void_IAmDirty_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600078E RID: 1934 RVA: 0x00022848 File Offset: 0x00020A48
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1114605, RefRangeEnd = 1114607, XrefRangeStart = 1114593, XrefRangeEnd = 1114605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveDirty(IAmDirty dirtyObj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dirtyObj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UpdateManager.NativeMethodInfoPtr_RemoveDirty_Public_Void_IAmDirty_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600078F RID: 1935 RVA: 0x0002288C File Offset: 0x00020A8C
		[CallerCount(23)]
		[CachedScanResults(RefRangeStart = 1114611, RefRangeEnd = 1114634, XrefRangeStart = 1114607, XrefRangeEnd = 1114611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Add(global::Il2CppSystem.Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UpdateManager.NativeMethodInfoPtr_Add_Public_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000790 RID: 1936 RVA: 0x000228D0 File Offset: 0x00020AD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1114634, XrefRangeEnd = 1114635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UpdateManager.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000791 RID: 1937 RVA: 0x00022904 File Offset: 0x00020B04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateCoroutineUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UpdateManager.NativeMethodInfoPtr_LateCoroutineUpdate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000792 RID: 1938 RVA: 0x00022938 File Offset: 0x00020B38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UpdateManager.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000793 RID: 1939 RVA: 0x0002296C File Offset: 0x00020B6C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1114656, RefRangeEnd = 1114659, XrefRangeStart = 1114635, XrefRangeEnd = 1114656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void internalUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UpdateManager.NativeMethodInfoPtr_internalUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000794 RID: 1940 RVA: 0x000229A0 File Offset: 0x00020BA0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1114686, RefRangeEnd = 1114687, XrefRangeStart = 1114659, XrefRangeEnd = 1114686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void normalizeObserver(List<IAmDirty> normalizedObservers, HashSet<IAmDirty> updatedObjects, global::Il2CppSystem.Object dirtyObj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(normalizedObservers);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(updatedObjects);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dirtyObj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UpdateManager.NativeMethodInfoPtr_normalizeObserver_Private_Void_List_1_IAmDirty_HashSet_1_IAmDirty_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000795 RID: 1941 RVA: 0x00022A08 File Offset: 0x00020C08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1114687, XrefRangeEnd = 1114696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void notifyObserver(IAmDirty dirtyObj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dirtyObj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UpdateManager.NativeMethodInfoPtr_notifyObserver_Private_Void_IAmDirty_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000796 RID: 1942 RVA: 0x00022A4C File Offset: 0x00020C4C
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 1114715, RefRangeEnd = 1114729, XrefRangeStart = 1114696, XrefRangeEnd = 1114715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateMeWhenThisIsDirty(IAmDirty observer, global::Il2CppSystem.Object obj, bool chainObserver = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(observer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref chainObserver;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UpdateManager.NativeMethodInfoPtr_UpdateMeWhenThisIsDirty_Public_Void_IAmDirty_Object_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000797 RID: 1943 RVA: 0x00022AB0 File Offset: 0x00020CB0
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 1114740, RefRangeEnd = 1114752, XrefRangeStart = 1114729, XrefRangeEnd = 1114740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DontUpdateMeWhenThisIsDirty(IAmDirty observer, global::Il2CppSystem.Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(observer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UpdateManager.NativeMethodInfoPtr_DontUpdateMeWhenThisIsDirty_Public_Void_IAmDirty_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000798 RID: 1944 RVA: 0x00022B04 File Offset: 0x00020D04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1114752, XrefRangeEnd = 1114776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetStatistics()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UpdateManager.NativeMethodInfoPtr_GetStatistics_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000799 RID: 1945 RVA: 0x00022B3C File Offset: 0x00020D3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1114776, XrefRangeEnd = 1114823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string OutputDirtyObservers()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UpdateManager.NativeMethodInfoPtr_OutputDirtyObservers_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600079A RID: 1946 RVA: 0x00022B74 File Offset: 0x00020D74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1114823, XrefRangeEnd = 1114859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UpdateManager()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UpdateManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UpdateManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600079B RID: 1947 RVA: 0x00005BDA File Offset: 0x00003DDA
		public UpdateManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000233 RID: 563
		// (get) Token: 0x0600079C RID: 1948 RVA: 0x00022BB0 File Offset: 0x00020DB0
		// (set) Token: 0x0600079D RID: 1949 RVA: 0x00005BE3 File Offset: 0x00003DE3
		public unsafe LinkedList<IAmDirty> dirtyObjects
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateManager.NativeFieldInfoPtr_dirtyObjects);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LinkedList<IAmDirty>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateManager.NativeFieldInfoPtr_dirtyObjects), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000234 RID: 564
		// (get) Token: 0x0600079E RID: 1950 RVA: 0x00022BE0 File Offset: 0x00020DE0
		// (set) Token: 0x0600079F RID: 1951 RVA: 0x00005C02 File Offset: 0x00003E02
		public unsafe HashSet<global::Il2CppSystem.Object> objects
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateManager.NativeFieldInfoPtr_objects);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<global::Il2CppSystem.Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateManager.NativeFieldInfoPtr_objects), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000235 RID: 565
		// (get) Token: 0x060007A0 RID: 1952 RVA: 0x00022C10 File Offset: 0x00020E10
		// (set) Token: 0x060007A1 RID: 1953 RVA: 0x00005C21 File Offset: 0x00003E21
		public unsafe HashSet<IAmDirty> updatedObjects
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateManager.NativeFieldInfoPtr_updatedObjects);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<IAmDirty>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateManager.NativeFieldInfoPtr_updatedObjects), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000236 RID: 566
		// (get) Token: 0x060007A2 RID: 1954 RVA: 0x00022C40 File Offset: 0x00020E40
		// (set) Token: 0x060007A3 RID: 1955 RVA: 0x00005C40 File Offset: 0x00003E40
		public unsafe List<IAmDirty> normalizedObservers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateManager.NativeFieldInfoPtr_normalizedObservers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<IAmDirty>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateManager.NativeFieldInfoPtr_normalizedObservers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000237 RID: 567
		// (get) Token: 0x060007A4 RID: 1956 RVA: 0x00022C70 File Offset: 0x00020E70
		// (set) Token: 0x060007A5 RID: 1957 RVA: 0x00005C5F File Offset: 0x00003E5F
		public unsafe Dictionary<global::Il2CppSystem.Object, List<DirtyObserver>> dirtyObservers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateManager.NativeFieldInfoPtr_dirtyObservers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<global::Il2CppSystem.Object, List<DirtyObserver>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateManager.NativeFieldInfoPtr_dirtyObservers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040004BA RID: 1210
		private static readonly IntPtr NativeFieldInfoPtr_dirtyObjects;

		// Token: 0x040004BB RID: 1211
		private static readonly IntPtr NativeFieldInfoPtr_objects;

		// Token: 0x040004BC RID: 1212
		private static readonly IntPtr NativeFieldInfoPtr_updatedObjects;

		// Token: 0x040004BD RID: 1213
		private static readonly IntPtr NativeFieldInfoPtr_normalizedObservers;

		// Token: 0x040004BE RID: 1214
		private static readonly IntPtr NativeFieldInfoPtr_dirtyObservers;

		// Token: 0x040004BF RID: 1215
		private static readonly IntPtr NativeMethodInfoPtr_MarkDirty_Public_Void_IAmDirty_0;

		// Token: 0x040004C0 RID: 1216
		private static readonly IntPtr NativeMethodInfoPtr_RemoveDirty_Public_Void_IAmDirty_0;

		// Token: 0x040004C1 RID: 1217
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Void_Object_0;

		// Token: 0x040004C2 RID: 1218
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040004C3 RID: 1219
		private static readonly IntPtr NativeMethodInfoPtr_LateCoroutineUpdate_Public_Void_0;

		// Token: 0x040004C4 RID: 1220
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x040004C5 RID: 1221
		private static readonly IntPtr NativeMethodInfoPtr_internalUpdate_Private_Void_0;

		// Token: 0x040004C6 RID: 1222
		private static readonly IntPtr NativeMethodInfoPtr_normalizeObserver_Private_Void_List_1_IAmDirty_HashSet_1_IAmDirty_Object_0;

		// Token: 0x040004C7 RID: 1223
		private static readonly IntPtr NativeMethodInfoPtr_notifyObserver_Private_Void_IAmDirty_0;

		// Token: 0x040004C8 RID: 1224
		private static readonly IntPtr NativeMethodInfoPtr_UpdateMeWhenThisIsDirty_Public_Void_IAmDirty_Object_Boolean_0;

		// Token: 0x040004C9 RID: 1225
		private static readonly IntPtr NativeMethodInfoPtr_DontUpdateMeWhenThisIsDirty_Public_Void_IAmDirty_Object_0;

		// Token: 0x040004CA RID: 1226
		private static readonly IntPtr NativeMethodInfoPtr_GetStatistics_Public_String_0;

		// Token: 0x040004CB RID: 1227
		private static readonly IntPtr NativeMethodInfoPtr_OutputDirtyObservers_Public_String_0;

		// Token: 0x040004CC RID: 1228
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
