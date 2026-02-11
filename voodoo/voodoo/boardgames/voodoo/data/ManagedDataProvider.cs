using System;
using dwd.core.data.composition;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace boardgames.voodoo.data
{
	// Token: 0x020000A3 RID: 163
	public class ManagedDataProvider : MonoBehaviour
	{
		// Token: 0x06000960 RID: 2400 RVA: 0x00028A04 File Offset: 0x00026C04
		// Note: this type is marked as 'beforefieldinit'.
		static ManagedDataProvider()
		{
			Il2CppClassPointerStore<ManagedDataProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("voodoo.dll", "boardgames.voodoo.data", "ManagedDataProvider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ManagedDataProvider>.NativeClassPtr);
			ManagedDataProvider.NativeFieldInfoPtr_observers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagedDataProvider>.NativeClassPtr, "observers");
			ManagedDataProvider.NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagedDataProvider>.NativeClassPtr, "data");
			ManagedDataProvider.NativeMethodInfoPtr_get_Data_Public_get_DataComposition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagedDataProvider>.NativeClassPtr, 100664660);
			ManagedDataProvider.NativeMethodInfoPtr_set_Data_Public_set_Void_DataComposition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagedDataProvider>.NativeClassPtr, 100664661);
			ManagedDataProvider.NativeMethodInfoPtr_Republish_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagedDataProvider>.NativeClassPtr, 100664662);
			ManagedDataProvider.NativeMethodInfoPtr_AddObserver_Public_Void_ManagedDataObserver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagedDataProvider>.NativeClassPtr, 100664663);
			ManagedDataProvider.NativeMethodInfoPtr_RemoveObserver_Public_Void_ManagedDataObserver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagedDataProvider>.NativeClassPtr, 100664664);
			ManagedDataProvider.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagedDataProvider>.NativeClassPtr, 100664665);
		}

		// Token: 0x170002B0 RID: 688
		// (get) Token: 0x06000961 RID: 2401 RVA: 0x00028AD4 File Offset: 0x00026CD4
		// (set) Token: 0x06000962 RID: 2402 RVA: 0x00028B14 File Offset: 0x00026D14
		public unsafe DataComposition Data
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagedDataProvider.NativeMethodInfoPtr_get_Data_Public_get_DataComposition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataComposition>(intPtr3) : null;
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 1117344, RefRangeEnd = 1117348, XrefRangeStart = 1117342, XrefRangeEnd = 1117344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagedDataProvider.NativeMethodInfoPtr_set_Data_Public_set_Void_DataComposition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000963 RID: 2403 RVA: 0x00028B58 File Offset: 0x00026D58
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1117362, RefRangeEnd = 1117363, XrefRangeStart = 1117348, XrefRangeEnd = 1117362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Republish()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagedDataProvider.NativeMethodInfoPtr_Republish_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000964 RID: 2404 RVA: 0x00028B8C File Offset: 0x00026D8C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1117367, RefRangeEnd = 1117368, XrefRangeStart = 1117363, XrefRangeEnd = 1117367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddObserver(ManagedDataObserver observer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(observer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagedDataProvider.NativeMethodInfoPtr_AddObserver_Public_Void_ManagedDataObserver_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000965 RID: 2405 RVA: 0x00028BD0 File Offset: 0x00026DD0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1117372, RefRangeEnd = 1117373, XrefRangeStart = 1117368, XrefRangeEnd = 1117372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveObserver(ManagedDataObserver observer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(observer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagedDataProvider.NativeMethodInfoPtr_RemoveObserver_Public_Void_ManagedDataObserver_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000966 RID: 2406 RVA: 0x00028C14 File Offset: 0x00026E14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1117373, XrefRangeEnd = 1117381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ManagedDataProvider()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ManagedDataProvider>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagedDataProvider.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000967 RID: 2407 RVA: 0x000068F6 File Offset: 0x00004AF6
		public ManagedDataProvider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002AE RID: 686
		// (get) Token: 0x06000968 RID: 2408 RVA: 0x00028C50 File Offset: 0x00026E50
		// (set) Token: 0x06000969 RID: 2409 RVA: 0x000068FF File Offset: 0x00004AFF
		public unsafe HashSet<ManagedDataObserver> observers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedDataProvider.NativeFieldInfoPtr_observers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<ManagedDataObserver>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedDataProvider.NativeFieldInfoPtr_observers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002AF RID: 687
		// (get) Token: 0x0600096A RID: 2410 RVA: 0x00028C80 File Offset: 0x00026E80
		// (set) Token: 0x0600096B RID: 2411 RVA: 0x0000691E File Offset: 0x00004B1E
		public unsafe DataComposition data
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedDataProvider.NativeFieldInfoPtr_data);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataComposition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedDataProvider.NativeFieldInfoPtr_data), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040005DA RID: 1498
		private static readonly IntPtr NativeFieldInfoPtr_observers;

		// Token: 0x040005DB RID: 1499
		private static readonly IntPtr NativeFieldInfoPtr_data;

		// Token: 0x040005DC RID: 1500
		private static readonly IntPtr NativeMethodInfoPtr_get_Data_Public_get_DataComposition_0;

		// Token: 0x040005DD RID: 1501
		private static readonly IntPtr NativeMethodInfoPtr_set_Data_Public_set_Void_DataComposition_0;

		// Token: 0x040005DE RID: 1502
		private static readonly IntPtr NativeMethodInfoPtr_Republish_Private_Void_0;

		// Token: 0x040005DF RID: 1503
		private static readonly IntPtr NativeMethodInfoPtr_AddObserver_Public_Void_ManagedDataObserver_0;

		// Token: 0x040005E0 RID: 1504
		private static readonly IntPtr NativeMethodInfoPtr_RemoveObserver_Public_Void_ManagedDataObserver_0;

		// Token: 0x040005E1 RID: 1505
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
