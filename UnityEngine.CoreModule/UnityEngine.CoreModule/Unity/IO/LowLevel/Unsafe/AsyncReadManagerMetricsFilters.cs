using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Unity.IO.LowLevel.Unsafe
{
	// Token: 0x0200002E RID: 46
	public class AsyncReadManagerMetricsFilters : Object
	{
		// Token: 0x0600019E RID: 414 RVA: 0x0001A830 File Offset: 0x00018A30
		// Note: this type is marked as 'beforefieldinit'.
		static AsyncReadManagerMetricsFilters()
		{
			Il2CppClassPointerStore<AsyncReadManagerMetricsFilters>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.IO.LowLevel.Unsafe", "AsyncReadManagerMetricsFilters");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AsyncReadManagerMetricsFilters>.NativeClassPtr);
			AsyncReadManagerMetricsFilters.NativeFieldInfoPtr_TypeIDs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncReadManagerMetricsFilters>.NativeClassPtr, "TypeIDs");
			AsyncReadManagerMetricsFilters.NativeFieldInfoPtr_States = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncReadManagerMetricsFilters>.NativeClassPtr, "States");
			AsyncReadManagerMetricsFilters.NativeFieldInfoPtr_ReadTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncReadManagerMetricsFilters>.NativeClassPtr, "ReadTypes");
			AsyncReadManagerMetricsFilters.NativeFieldInfoPtr_PriorityLevels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncReadManagerMetricsFilters>.NativeClassPtr, "PriorityLevels");
			AsyncReadManagerMetricsFilters.NativeFieldInfoPtr_Subsystems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncReadManagerMetricsFilters>.NativeClassPtr, "Subsystems");
		}

		// Token: 0x0600019F RID: 415 RVA: 0x00002D26 File Offset: 0x00000F26
		public AsyncReadManagerMetricsFilters(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x060001A0 RID: 416 RVA: 0x0001A8C4 File Offset: 0x00018AC4
		// (set) Token: 0x060001A1 RID: 417 RVA: 0x00002D2F File Offset: 0x00000F2F
		public unsafe Il2CppStructArray<ulong> TypeIDs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncReadManagerMetricsFilters.NativeFieldInfoPtr_TypeIDs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<ulong>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncReadManagerMetricsFilters.NativeFieldInfoPtr_TypeIDs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x060001A2 RID: 418 RVA: 0x0001A8F4 File Offset: 0x00018AF4
		// (set) Token: 0x060001A3 RID: 419 RVA: 0x00002D4E File Offset: 0x00000F4E
		public unsafe Il2CppStructArray<ProcessingState> States
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncReadManagerMetricsFilters.NativeFieldInfoPtr_States);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<ProcessingState>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncReadManagerMetricsFilters.NativeFieldInfoPtr_States), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x060001A4 RID: 420 RVA: 0x0001A924 File Offset: 0x00018B24
		// (set) Token: 0x060001A5 RID: 421 RVA: 0x00002D6D File Offset: 0x00000F6D
		public unsafe Il2CppStructArray<FileReadType> ReadTypes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncReadManagerMetricsFilters.NativeFieldInfoPtr_ReadTypes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<FileReadType>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncReadManagerMetricsFilters.NativeFieldInfoPtr_ReadTypes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x060001A6 RID: 422 RVA: 0x0001A954 File Offset: 0x00018B54
		// (set) Token: 0x060001A7 RID: 423 RVA: 0x00002D8C File Offset: 0x00000F8C
		public unsafe Il2CppStructArray<Priority> PriorityLevels
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncReadManagerMetricsFilters.NativeFieldInfoPtr_PriorityLevels);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Priority>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncReadManagerMetricsFilters.NativeFieldInfoPtr_PriorityLevels), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x060001A8 RID: 424 RVA: 0x0001A984 File Offset: 0x00018B84
		// (set) Token: 0x060001A9 RID: 425 RVA: 0x00002DAB File Offset: 0x00000FAB
		public unsafe Il2CppStructArray<AssetLoadingSubsystem> Subsystems
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncReadManagerMetricsFilters.NativeFieldInfoPtr_Subsystems);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<AssetLoadingSubsystem>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncReadManagerMetricsFilters.NativeFieldInfoPtr_Subsystems), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x060001AA RID: 426 RVA: 0x00002DCA File Offset: 0x00000FCA
		public void SetTypeIDFilter(Il2CppStructArray<ulong> _typeIDs)
		{
			this.TypeIDs = _typeIDs;
		}

		// Token: 0x060001AB RID: 427 RVA: 0x00002DD4 File Offset: 0x00000FD4
		public void SetStateFilter(Il2CppStructArray<ProcessingState> _states)
		{
			this.States = _states;
		}

		// Token: 0x060001AC RID: 428 RVA: 0x00002DDE File Offset: 0x00000FDE
		public void SetReadTypeFilter(Il2CppStructArray<FileReadType> _readTypes)
		{
			this.ReadTypes = _readTypes;
		}

		// Token: 0x060001AD RID: 429 RVA: 0x00002DE8 File Offset: 0x00000FE8
		public void SetPriorityFilter(Il2CppStructArray<Priority> _priorityLevels)
		{
			this.PriorityLevels = _priorityLevels;
		}

		// Token: 0x060001AE RID: 430 RVA: 0x00002DF2 File Offset: 0x00000FF2
		public void SetSubsystemFilter(Il2CppStructArray<AssetLoadingSubsystem> _subsystems)
		{
			this.Subsystems = _subsystems;
		}

		// Token: 0x060001AF RID: 431 RVA: 0x00002DFC File Offset: 0x00000FFC
		public void SetTypeIDFilter(ulong _typeID)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x00002E09 File Offset: 0x00001009
		public void SetStateFilter(ProcessingState _state)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060001B1 RID: 433 RVA: 0x00002E16 File Offset: 0x00001016
		public void SetReadTypeFilter(FileReadType _readType)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060001B2 RID: 434 RVA: 0x00002E23 File Offset: 0x00001023
		public void SetPriorityFilter(Priority _priorityLevel)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060001B3 RID: 435 RVA: 0x00002E30 File Offset: 0x00001030
		public void SetSubsystemFilter(AssetLoadingSubsystem _subsystem)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060001B4 RID: 436 RVA: 0x00002E3D File Offset: 0x0000103D
		public void RemoveTypeIDFilter()
		{
			this.TypeIDs = null;
		}

		// Token: 0x060001B5 RID: 437 RVA: 0x00002E47 File Offset: 0x00001047
		public void RemoveStateFilter()
		{
			this.States = null;
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x00002E51 File Offset: 0x00001051
		public void RemoveReadTypeFilter()
		{
			this.ReadTypes = null;
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x00002E5B File Offset: 0x0000105B
		public void RemovePriorityFilter()
		{
			this.PriorityLevels = null;
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x00002E65 File Offset: 0x00001065
		public void RemoveSubsystemFilter()
		{
			this.Subsystems = null;
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x00002E6F File Offset: 0x0000106F
		public void ClearFilters()
		{
			this.RemoveTypeIDFilter();
			this.RemoveStateFilter();
			this.RemoveReadTypeFilter();
			this.RemovePriorityFilter();
			this.RemoveSubsystemFilter();
		}

		// Token: 0x0400016D RID: 365
		private static readonly IntPtr NativeFieldInfoPtr_TypeIDs;

		// Token: 0x0400016E RID: 366
		private static readonly IntPtr NativeFieldInfoPtr_States;

		// Token: 0x0400016F RID: 367
		private static readonly IntPtr NativeFieldInfoPtr_ReadTypes;

		// Token: 0x04000170 RID: 368
		private static readonly IntPtr NativeFieldInfoPtr_PriorityLevels;

		// Token: 0x04000171 RID: 369
		private static readonly IntPtr NativeFieldInfoPtr_Subsystems;
	}
}
