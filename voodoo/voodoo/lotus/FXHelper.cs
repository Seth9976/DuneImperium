using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using UnityEngine;

namespace lotus
{
	// Token: 0x02000056 RID: 86
	public class FXHelper : MonoBehaviour
	{
		// Token: 0x0600051B RID: 1307 RVA: 0x0001A0C0 File Offset: 0x000182C0
		// Note: this type is marked as 'beforefieldinit'.
		static FXHelper()
		{
			Il2CppClassPointerStore<FXHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("voodoo.dll", "lotus", "FXHelper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FXHelper>.NativeClassPtr);
			FXHelper.NativeFieldInfoPtr_spawns = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FXHelper>.NativeClassPtr, "spawns");
			FXHelper.NativeFieldInfoPtr_fxSpawnDatum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FXHelper>.NativeClassPtr, "fxSpawnDatum");
			FXHelper.NativeFieldInfoPtr_spawnedFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FXHelper>.NativeClassPtr, "spawnedFX");
			FXHelper.NativeFieldInfoPtr_poolable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FXHelper>.NativeClassPtr, "poolable");
			FXHelper.NativeFieldInfoPtr_fallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FXHelper>.NativeClassPtr, "fallback");
			FXHelper.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FXHelper>.NativeClassPtr, 100663919);
			FXHelper.NativeMethodInfoPtr_FXSpawn_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FXHelper>.NativeClassPtr, 100663920);
			FXHelper.NativeMethodInfoPtr_FXSpawnAndPersist_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FXHelper>.NativeClassPtr, 100663921);
			FXHelper.NativeMethodInfoPtr_FXDespawnPersisted_Public_FXUnit_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FXHelper>.NativeClassPtr, 100663922);
			FXHelper.NativeMethodInfoPtr_ContainsKey_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FXHelper>.NativeClassPtr, 100663923);
			FXHelper.NativeMethodInfoPtr_fxSpawnRoutine_Private_IEnumerator_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FXHelper>.NativeClassPtr, 100663924);
			FXHelper.NativeMethodInfoPtr_fxSpawnPersistedRoutine_Private_IEnumerator_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FXHelper>.NativeClassPtr, 100663925);
			FXHelper.NativeMethodInfoPtr_Persist_Public_Void_String_FXUnit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FXHelper>.NativeClassPtr, 100663926);
			FXHelper.NativeMethodInfoPtr_SpawnInternal_Public_FXUnit_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FXHelper>.NativeClassPtr, 100663927);
			FXHelper.NativeMethodInfoPtr_SpawnInternal_Public_T_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FXHelper>.NativeClassPtr, 100663928);
			FXHelper.NativeMethodInfoPtr_Spawn_Public_Void_FXUnit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FXHelper>.NativeClassPtr, 100663929);
			FXHelper.NativeMethodInfoPtr_GetSpawnedFX_Public_FXUnit_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FXHelper>.NativeClassPtr, 100663930);
			FXHelper.NativeMethodInfoPtr_GetFXSpawnDatum_Public_FXUnitData_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FXHelper>.NativeClassPtr, 100663931);
			FXHelper.NativeMethodInfoPtr_GetSpawnedFXKeys_Public_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FXHelper>.NativeClassPtr, 100663932);
			FXHelper.NativeMethodInfoPtr_AddFallback_Public_Virtual_Final_New_Void_FXHelper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FXHelper>.NativeClassPtr, 100663933);
			FXHelper.NativeMethodInfoPtr_RemoveFallback_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FXHelper>.NativeClassPtr, 100663934);
			FXHelper.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FXHelper>.NativeClassPtr, 100663935);
		}

		// Token: 0x0600051C RID: 1308 RVA: 0x0001A2A8 File Offset: 0x000184A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1111304, XrefRangeEnd = 1111312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FXHelper.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600051D RID: 1309 RVA: 0x0001A2DC File Offset: 0x000184DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1111312, XrefRangeEnd = 1111319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FXSpawn(string key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FXHelper.NativeMethodInfoPtr_FXSpawn_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600051E RID: 1310 RVA: 0x0001A320 File Offset: 0x00018520
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1111319, XrefRangeEnd = 1111326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FXSpawnAndPersist(string key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FXHelper.NativeMethodInfoPtr_FXSpawnAndPersist_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600051F RID: 1311 RVA: 0x0001A364 File Offset: 0x00018564
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1111351, RefRangeEnd = 1111353, XrefRangeStart = 1111326, XrefRangeEnd = 1111351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FXUnit FXDespawnPersisted(string key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FXHelper.NativeMethodInfoPtr_FXDespawnPersisted_Public_FXUnit_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<FXUnit>(intPtr3) : null;
			}
		}

		// Token: 0x06000520 RID: 1312 RVA: 0x0001A3B4 File Offset: 0x000185B4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1111356, RefRangeEnd = 1111357, XrefRangeStart = 1111353, XrefRangeEnd = 1111356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ContainsKey(string key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FXHelper.NativeMethodInfoPtr_ContainsKey_Public_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000521 RID: 1313 RVA: 0x0001A404 File Offset: 0x00018604
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1111357, XrefRangeEnd = 1111363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator fxSpawnRoutine(string key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FXHelper.NativeMethodInfoPtr_fxSpawnRoutine_Private_IEnumerator_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x06000522 RID: 1314 RVA: 0x0001A454 File Offset: 0x00018654
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1111363, XrefRangeEnd = 1111369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator fxSpawnPersistedRoutine(string key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FXHelper.NativeMethodInfoPtr_fxSpawnPersistedRoutine_Private_IEnumerator_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x06000523 RID: 1315 RVA: 0x0001A4A4 File Offset: 0x000186A4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1111373, RefRangeEnd = 1111374, XrefRangeStart = 1111369, XrefRangeEnd = 1111373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Persist(string key, FXUnit spawnedUnit)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(spawnedUnit);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FXHelper.NativeMethodInfoPtr_Persist_Public_Void_String_FXUnit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000524 RID: 1316 RVA: 0x0001A4F8 File Offset: 0x000186F8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1111393, RefRangeEnd = 1111396, XrefRangeStart = 1111374, XrefRangeEnd = 1111393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FXUnit SpawnInternal(string key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FXHelper.NativeMethodInfoPtr_SpawnInternal_Public_FXUnit_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<FXUnit>(intPtr3) : null;
			}
		}

		// Token: 0x06000525 RID: 1317 RVA: 0x0001A548 File Offset: 0x00018748
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1111402, RefRangeEnd = 1111403, XrefRangeStart = 1111396, XrefRangeEnd = 1111402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T SpawnInternal<T>(string key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FXHelper.MethodInfoStoreGeneric_SpawnInternal_Public_T_String_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x06000526 RID: 1318 RVA: 0x0001A594 File Offset: 0x00018794
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1111403, XrefRangeEnd = 1111412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Spawn(FXUnit fxPrefab)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(fxPrefab);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FXHelper.NativeMethodInfoPtr_Spawn_Public_Void_FXUnit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000527 RID: 1319 RVA: 0x0001A5D8 File Offset: 0x000187D8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1111415, RefRangeEnd = 1111416, XrefRangeStart = 1111412, XrefRangeEnd = 1111415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FXUnit GetSpawnedFX(string key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FXHelper.NativeMethodInfoPtr_GetSpawnedFX_Public_FXUnit_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<FXUnit>(intPtr3) : null;
			}
		}

		// Token: 0x06000528 RID: 1320 RVA: 0x0001A628 File Offset: 0x00018828
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1111416, XrefRangeEnd = 1111419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FXHelper.FXUnitData GetFXSpawnDatum(string key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FXHelper.NativeMethodInfoPtr_GetFXSpawnDatum_Public_FXUnitData_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<FXHelper.FXUnitData>(intPtr3) : null;
			}
		}

		// Token: 0x06000529 RID: 1321 RVA: 0x0001A678 File Offset: 0x00018878
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1111419, XrefRangeEnd = 1111426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<string> GetSpawnedFXKeys()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FXHelper.NativeMethodInfoPtr_GetSpawnedFXKeys_Public_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
		}

		// Token: 0x0600052A RID: 1322 RVA: 0x0001A6B8 File Offset: 0x000188B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void AddFallback(FXHelper fallback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(fallback);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FXHelper.NativeMethodInfoPtr_AddFallback_Public_Virtual_Final_New_Void_FXHelper_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600052B RID: 1323 RVA: 0x0001A6FC File Offset: 0x000188FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1111426, XrefRangeEnd = 1111427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RemoveFallback()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FXHelper.NativeMethodInfoPtr_RemoveFallback_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600052C RID: 1324 RVA: 0x0001A730 File Offset: 0x00018930
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1111427, XrefRangeEnd = 1111442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FXHelper()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FXHelper>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FXHelper.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600052D RID: 1325 RVA: 0x0000489D File Offset: 0x00002A9D
		public FXHelper(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000199 RID: 409
		// (get) Token: 0x0600052E RID: 1326 RVA: 0x0001A76C File Offset: 0x0001896C
		// (set) Token: 0x0600052F RID: 1327 RVA: 0x000048A6 File Offset: 0x00002AA6
		public unsafe List<FXHelper.FXUnitData> spawns
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FXHelper.NativeFieldInfoPtr_spawns);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<FXHelper.FXUnitData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FXHelper.NativeFieldInfoPtr_spawns), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700019A RID: 410
		// (get) Token: 0x06000530 RID: 1328 RVA: 0x0001A79C File Offset: 0x0001899C
		// (set) Token: 0x06000531 RID: 1329 RVA: 0x000048C5 File Offset: 0x00002AC5
		public unsafe LocalDataManager<string, FXHelper.FXUnitData> fxSpawnDatum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FXHelper.NativeFieldInfoPtr_fxSpawnDatum);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LocalDataManager<string, FXHelper.FXUnitData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FXHelper.NativeFieldInfoPtr_fxSpawnDatum), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700019B RID: 411
		// (get) Token: 0x06000532 RID: 1330 RVA: 0x0001A7CC File Offset: 0x000189CC
		// (set) Token: 0x06000533 RID: 1331 RVA: 0x000048E4 File Offset: 0x00002AE4
		public unsafe Dictionary<string, FXUnit> spawnedFX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FXHelper.NativeFieldInfoPtr_spawnedFX);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, FXUnit>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FXHelper.NativeFieldInfoPtr_spawnedFX), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700019C RID: 412
		// (get) Token: 0x06000534 RID: 1332 RVA: 0x0001A7FC File Offset: 0x000189FC
		// (set) Token: 0x06000535 RID: 1333 RVA: 0x00004903 File Offset: 0x00002B03
		public unsafe PoolableItem poolable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FXHelper.NativeFieldInfoPtr_poolable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PoolableItem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FXHelper.NativeFieldInfoPtr_poolable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700019D RID: 413
		// (get) Token: 0x06000536 RID: 1334 RVA: 0x0001A82C File Offset: 0x00018A2C
		// (set) Token: 0x06000537 RID: 1335 RVA: 0x00004922 File Offset: 0x00002B22
		public unsafe FXHelper fallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FXHelper.NativeFieldInfoPtr_fallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FXHelper>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FXHelper.NativeFieldInfoPtr_fallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000330 RID: 816
		private static readonly IntPtr NativeFieldInfoPtr_spawns;

		// Token: 0x04000331 RID: 817
		private static readonly IntPtr NativeFieldInfoPtr_fxSpawnDatum;

		// Token: 0x04000332 RID: 818
		private static readonly IntPtr NativeFieldInfoPtr_spawnedFX;

		// Token: 0x04000333 RID: 819
		private static readonly IntPtr NativeFieldInfoPtr_poolable;

		// Token: 0x04000334 RID: 820
		private static readonly IntPtr NativeFieldInfoPtr_fallback;

		// Token: 0x04000335 RID: 821
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04000336 RID: 822
		private static readonly IntPtr NativeMethodInfoPtr_FXSpawn_Public_Void_String_0;

		// Token: 0x04000337 RID: 823
		private static readonly IntPtr NativeMethodInfoPtr_FXSpawnAndPersist_Public_Void_String_0;

		// Token: 0x04000338 RID: 824
		private static readonly IntPtr NativeMethodInfoPtr_FXDespawnPersisted_Public_FXUnit_String_0;

		// Token: 0x04000339 RID: 825
		private static readonly IntPtr NativeMethodInfoPtr_ContainsKey_Public_Boolean_String_0;

		// Token: 0x0400033A RID: 826
		private static readonly IntPtr NativeMethodInfoPtr_fxSpawnRoutine_Private_IEnumerator_String_0;

		// Token: 0x0400033B RID: 827
		private static readonly IntPtr NativeMethodInfoPtr_fxSpawnPersistedRoutine_Private_IEnumerator_String_0;

		// Token: 0x0400033C RID: 828
		private static readonly IntPtr NativeMethodInfoPtr_Persist_Public_Void_String_FXUnit_0;

		// Token: 0x0400033D RID: 829
		private static readonly IntPtr NativeMethodInfoPtr_SpawnInternal_Public_FXUnit_String_0;

		// Token: 0x0400033E RID: 830
		private static readonly IntPtr NativeMethodInfoPtr_SpawnInternal_Public_T_String_0;

		// Token: 0x0400033F RID: 831
		private static readonly IntPtr NativeMethodInfoPtr_Spawn_Public_Void_FXUnit_0;

		// Token: 0x04000340 RID: 832
		private static readonly IntPtr NativeMethodInfoPtr_GetSpawnedFX_Public_FXUnit_String_0;

		// Token: 0x04000341 RID: 833
		private static readonly IntPtr NativeMethodInfoPtr_GetFXSpawnDatum_Public_FXUnitData_String_0;

		// Token: 0x04000342 RID: 834
		private static readonly IntPtr NativeMethodInfoPtr_GetSpawnedFXKeys_Public_List_1_String_0;

		// Token: 0x04000343 RID: 835
		private static readonly IntPtr NativeMethodInfoPtr_AddFallback_Public_Virtual_Final_New_Void_FXHelper_0;

		// Token: 0x04000344 RID: 836
		private static readonly IntPtr NativeMethodInfoPtr_RemoveFallback_Public_Virtual_Final_New_Void_0;

		// Token: 0x04000345 RID: 837
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020000D4 RID: 212
		[Serializable]
		public class FXUnitData : global::Il2CppSystem.Object
		{
			// Token: 0x06000B2C RID: 2860 RVA: 0x0002DED0 File Offset: 0x0002C0D0
			// Note: this type is marked as 'beforefieldinit'.
			static FXUnitData()
			{
				Il2CppClassPointerStore<FXHelper.FXUnitData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FXHelper>.NativeClassPtr, "FXUnitData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FXHelper.FXUnitData>.NativeClassPtr);
				FXHelper.FXUnitData.NativeFieldInfoPtr_key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FXHelper.FXUnitData>.NativeClassPtr, "key");
				FXHelper.FXUnitData.NativeFieldInfoPtr_spawnPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FXHelper.FXUnitData>.NativeClassPtr, "spawnPoint");
				FXHelper.FXUnitData.NativeFieldInfoPtr_unit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FXHelper.FXUnitData>.NativeClassPtr, "unit");
				FXHelper.FXUnitData.NativeMethodInfoPtr_GetKey_Public_Virtual_Final_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FXHelper.FXUnitData>.NativeClassPtr, 100663936);
				FXHelper.FXUnitData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FXHelper.FXUnitData>.NativeClassPtr, 100663937);
			}

			// Token: 0x06000B2D RID: 2861 RVA: 0x0002DF60 File Offset: 0x0002C160
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual string GetKey()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FXHelper.FXUnitData.NativeMethodInfoPtr_GetKey_Public_Virtual_Final_New_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x06000B2E RID: 2862 RVA: 0x0002DF98 File Offset: 0x0002C198
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe FXUnitData()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FXHelper.FXUnitData>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FXHelper.FXUnitData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000B2F RID: 2863 RVA: 0x000077B6 File Offset: 0x000059B6
			public FXUnitData(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700033E RID: 830
			// (get) Token: 0x06000B30 RID: 2864 RVA: 0x0002DFD4 File Offset: 0x0002C1D4
			// (set) Token: 0x06000B31 RID: 2865 RVA: 0x000077BF File Offset: 0x000059BF
			public unsafe string key
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FXHelper.FXUnitData.NativeFieldInfoPtr_key);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FXHelper.FXUnitData.NativeFieldInfoPtr_key), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700033F RID: 831
			// (get) Token: 0x06000B32 RID: 2866 RVA: 0x0002DFFC File Offset: 0x0002C1FC
			// (set) Token: 0x06000B33 RID: 2867 RVA: 0x000077DE File Offset: 0x000059DE
			public unsafe Transform spawnPoint
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FXHelper.FXUnitData.NativeFieldInfoPtr_spawnPoint);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FXHelper.FXUnitData.NativeFieldInfoPtr_spawnPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000340 RID: 832
			// (get) Token: 0x06000B34 RID: 2868 RVA: 0x0002E02C File Offset: 0x0002C22C
			// (set) Token: 0x06000B35 RID: 2869 RVA: 0x000077FD File Offset: 0x000059FD
			public unsafe FXUnit unit
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FXHelper.FXUnitData.NativeFieldInfoPtr_unit);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FXUnit>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FXHelper.FXUnitData.NativeFieldInfoPtr_unit), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040006F7 RID: 1783
			private static readonly IntPtr NativeFieldInfoPtr_key;

			// Token: 0x040006F8 RID: 1784
			private static readonly IntPtr NativeFieldInfoPtr_spawnPoint;

			// Token: 0x040006F9 RID: 1785
			private static readonly IntPtr NativeFieldInfoPtr_unit;

			// Token: 0x040006FA RID: 1786
			private static readonly IntPtr NativeMethodInfoPtr_GetKey_Public_Virtual_Final_New_String_0;

			// Token: 0x040006FB RID: 1787
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020000D5 RID: 213
		[ObfuscatedName("lotus.FXHelper+<fxSpawnPersistedRoutine>d__12")]
		public sealed class _fxSpawnPersistedRoutine_d__12 : global::Il2CppSystem.Object
		{
			// Token: 0x06000B36 RID: 2870 RVA: 0x0002E05C File Offset: 0x0002C25C
			// Note: this type is marked as 'beforefieldinit'.
			static _fxSpawnPersistedRoutine_d__12()
			{
				Il2CppClassPointerStore<FXHelper._fxSpawnPersistedRoutine_d__12>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FXHelper>.NativeClassPtr, "<fxSpawnPersistedRoutine>d__12");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FXHelper._fxSpawnPersistedRoutine_d__12>.NativeClassPtr);
				FXHelper._fxSpawnPersistedRoutine_d__12.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FXHelper._fxSpawnPersistedRoutine_d__12>.NativeClassPtr, "<>1__state");
				FXHelper._fxSpawnPersistedRoutine_d__12.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FXHelper._fxSpawnPersistedRoutine_d__12>.NativeClassPtr, "<>2__current");
				FXHelper._fxSpawnPersistedRoutine_d__12.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FXHelper._fxSpawnPersistedRoutine_d__12>.NativeClassPtr, "<>4__this");
				FXHelper._fxSpawnPersistedRoutine_d__12.NativeFieldInfoPtr_key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FXHelper._fxSpawnPersistedRoutine_d__12>.NativeClassPtr, "key");
				FXHelper._fxSpawnPersistedRoutine_d__12.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FXHelper._fxSpawnPersistedRoutine_d__12>.NativeClassPtr, 100663938);
				FXHelper._fxSpawnPersistedRoutine_d__12.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FXHelper._fxSpawnPersistedRoutine_d__12>.NativeClassPtr, 100663939);
				FXHelper._fxSpawnPersistedRoutine_d__12.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FXHelper._fxSpawnPersistedRoutine_d__12>.NativeClassPtr, 100663940);
				FXHelper._fxSpawnPersistedRoutine_d__12.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FXHelper._fxSpawnPersistedRoutine_d__12>.NativeClassPtr, 100663941);
				FXHelper._fxSpawnPersistedRoutine_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FXHelper._fxSpawnPersistedRoutine_d__12>.NativeClassPtr, 100663942);
				FXHelper._fxSpawnPersistedRoutine_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FXHelper._fxSpawnPersistedRoutine_d__12>.NativeClassPtr, 100663943);
			}

			// Token: 0x06000B37 RID: 2871 RVA: 0x0002E150 File Offset: 0x0002C350
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _fxSpawnPersistedRoutine_d__12(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FXHelper._fxSpawnPersistedRoutine_d__12>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FXHelper._fxSpawnPersistedRoutine_d__12.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000B38 RID: 2872 RVA: 0x0002E198 File Offset: 0x0002C398
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FXHelper._fxSpawnPersistedRoutine_d__12.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000B39 RID: 2873 RVA: 0x0002E1CC File Offset: 0x0002C3CC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1111284, XrefRangeEnd = 1111293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FXHelper._fxSpawnPersistedRoutine_d__12.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000345 RID: 837
			// (get) Token: 0x06000B3A RID: 2874 RVA: 0x0002E208 File Offset: 0x0002C408
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FXHelper._fxSpawnPersistedRoutine_d__12.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000B3B RID: 2875 RVA: 0x0002E248 File Offset: 0x0002C448
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1111293, XrefRangeEnd = 1111298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FXHelper._fxSpawnPersistedRoutine_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000346 RID: 838
			// (get) Token: 0x06000B3C RID: 2876 RVA: 0x0002E27C File Offset: 0x0002C47C
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FXHelper._fxSpawnPersistedRoutine_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000B3D RID: 2877 RVA: 0x0000781C File Offset: 0x00005A1C
			public _fxSpawnPersistedRoutine_d__12(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000341 RID: 833
			// (get) Token: 0x06000B3E RID: 2878 RVA: 0x0002E2BC File Offset: 0x0002C4BC
			// (set) Token: 0x06000B3F RID: 2879 RVA: 0x00007825 File Offset: 0x00005A25
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FXHelper._fxSpawnPersistedRoutine_d__12.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FXHelper._fxSpawnPersistedRoutine_d__12.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000342 RID: 834
			// (get) Token: 0x06000B40 RID: 2880 RVA: 0x0002E2E4 File Offset: 0x0002C4E4
			// (set) Token: 0x06000B41 RID: 2881 RVA: 0x00007840 File Offset: 0x00005A40
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FXHelper._fxSpawnPersistedRoutine_d__12.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FXHelper._fxSpawnPersistedRoutine_d__12.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000343 RID: 835
			// (get) Token: 0x06000B42 RID: 2882 RVA: 0x0002E314 File Offset: 0x0002C514
			// (set) Token: 0x06000B43 RID: 2883 RVA: 0x0000785F File Offset: 0x00005A5F
			public unsafe FXHelper __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FXHelper._fxSpawnPersistedRoutine_d__12.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FXHelper>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FXHelper._fxSpawnPersistedRoutine_d__12.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000344 RID: 836
			// (get) Token: 0x06000B44 RID: 2884 RVA: 0x0002E344 File Offset: 0x0002C544
			// (set) Token: 0x06000B45 RID: 2885 RVA: 0x0000787E File Offset: 0x00005A7E
			public unsafe string key
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FXHelper._fxSpawnPersistedRoutine_d__12.NativeFieldInfoPtr_key);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FXHelper._fxSpawnPersistedRoutine_d__12.NativeFieldInfoPtr_key), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x040006FC RID: 1788
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040006FD RID: 1789
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040006FE RID: 1790
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040006FF RID: 1791
			private static readonly IntPtr NativeFieldInfoPtr_key;

			// Token: 0x04000700 RID: 1792
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000701 RID: 1793
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000702 RID: 1794
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000703 RID: 1795
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000704 RID: 1796
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000705 RID: 1797
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x020000D6 RID: 214
		[ObfuscatedName("lotus.FXHelper+<fxSpawnRoutine>d__11")]
		public sealed class _fxSpawnRoutine_d__11 : global::Il2CppSystem.Object
		{
			// Token: 0x06000B46 RID: 2886 RVA: 0x0002E36C File Offset: 0x0002C56C
			// Note: this type is marked as 'beforefieldinit'.
			static _fxSpawnRoutine_d__11()
			{
				Il2CppClassPointerStore<FXHelper._fxSpawnRoutine_d__11>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FXHelper>.NativeClassPtr, "<fxSpawnRoutine>d__11");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FXHelper._fxSpawnRoutine_d__11>.NativeClassPtr);
				FXHelper._fxSpawnRoutine_d__11.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FXHelper._fxSpawnRoutine_d__11>.NativeClassPtr, "<>1__state");
				FXHelper._fxSpawnRoutine_d__11.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FXHelper._fxSpawnRoutine_d__11>.NativeClassPtr, "<>2__current");
				FXHelper._fxSpawnRoutine_d__11.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FXHelper._fxSpawnRoutine_d__11>.NativeClassPtr, "<>4__this");
				FXHelper._fxSpawnRoutine_d__11.NativeFieldInfoPtr_key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FXHelper._fxSpawnRoutine_d__11>.NativeClassPtr, "key");
				FXHelper._fxSpawnRoutine_d__11.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FXHelper._fxSpawnRoutine_d__11>.NativeClassPtr, 100663944);
				FXHelper._fxSpawnRoutine_d__11.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FXHelper._fxSpawnRoutine_d__11>.NativeClassPtr, 100663945);
				FXHelper._fxSpawnRoutine_d__11.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FXHelper._fxSpawnRoutine_d__11>.NativeClassPtr, 100663946);
				FXHelper._fxSpawnRoutine_d__11.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FXHelper._fxSpawnRoutine_d__11>.NativeClassPtr, 100663947);
				FXHelper._fxSpawnRoutine_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FXHelper._fxSpawnRoutine_d__11>.NativeClassPtr, 100663948);
				FXHelper._fxSpawnRoutine_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FXHelper._fxSpawnRoutine_d__11>.NativeClassPtr, 100663949);
			}

			// Token: 0x06000B47 RID: 2887 RVA: 0x0002E460 File Offset: 0x0002C660
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _fxSpawnRoutine_d__11(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FXHelper._fxSpawnRoutine_d__11>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FXHelper._fxSpawnRoutine_d__11.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000B48 RID: 2888 RVA: 0x0002E4A8 File Offset: 0x0002C6A8
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FXHelper._fxSpawnRoutine_d__11.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000B49 RID: 2889 RVA: 0x0002E4DC File Offset: 0x0002C6DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1111298, XrefRangeEnd = 1111299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FXHelper._fxSpawnRoutine_d__11.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700034B RID: 843
			// (get) Token: 0x06000B4A RID: 2890 RVA: 0x0002E518 File Offset: 0x0002C718
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FXHelper._fxSpawnRoutine_d__11.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000B4B RID: 2891 RVA: 0x0002E558 File Offset: 0x0002C758
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1111299, XrefRangeEnd = 1111304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FXHelper._fxSpawnRoutine_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700034C RID: 844
			// (get) Token: 0x06000B4C RID: 2892 RVA: 0x0002E58C File Offset: 0x0002C78C
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FXHelper._fxSpawnRoutine_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000B4D RID: 2893 RVA: 0x0000789D File Offset: 0x00005A9D
			public _fxSpawnRoutine_d__11(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000347 RID: 839
			// (get) Token: 0x06000B4E RID: 2894 RVA: 0x0002E5CC File Offset: 0x0002C7CC
			// (set) Token: 0x06000B4F RID: 2895 RVA: 0x000078A6 File Offset: 0x00005AA6
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FXHelper._fxSpawnRoutine_d__11.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FXHelper._fxSpawnRoutine_d__11.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000348 RID: 840
			// (get) Token: 0x06000B50 RID: 2896 RVA: 0x0002E5F4 File Offset: 0x0002C7F4
			// (set) Token: 0x06000B51 RID: 2897 RVA: 0x000078C1 File Offset: 0x00005AC1
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FXHelper._fxSpawnRoutine_d__11.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FXHelper._fxSpawnRoutine_d__11.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000349 RID: 841
			// (get) Token: 0x06000B52 RID: 2898 RVA: 0x0002E624 File Offset: 0x0002C824
			// (set) Token: 0x06000B53 RID: 2899 RVA: 0x000078E0 File Offset: 0x00005AE0
			public unsafe FXHelper __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FXHelper._fxSpawnRoutine_d__11.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FXHelper>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FXHelper._fxSpawnRoutine_d__11.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700034A RID: 842
			// (get) Token: 0x06000B54 RID: 2900 RVA: 0x0002E654 File Offset: 0x0002C854
			// (set) Token: 0x06000B55 RID: 2901 RVA: 0x000078FF File Offset: 0x00005AFF
			public unsafe string key
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FXHelper._fxSpawnRoutine_d__11.NativeFieldInfoPtr_key);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FXHelper._fxSpawnRoutine_d__11.NativeFieldInfoPtr_key), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04000706 RID: 1798
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000707 RID: 1799
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000708 RID: 1800
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000709 RID: 1801
			private static readonly IntPtr NativeFieldInfoPtr_key;

			// Token: 0x0400070A RID: 1802
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400070B RID: 1803
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400070C RID: 1804
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400070D RID: 1805
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400070E RID: 1806
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400070F RID: 1807
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x020000D7 RID: 215
		private sealed class MethodInfoStoreGeneric_SpawnInternal_Public_T_String_0<T>
		{
			// Token: 0x04000710 RID: 1808
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(FXHelper.NativeMethodInfoPtr_SpawnInternal_Public_T_String_0, Il2CppClassPointerStore<FXHelper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
