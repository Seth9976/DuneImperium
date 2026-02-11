using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x02000125 RID: 293
	public sealed class RangePositionInfo : ValueType
	{
		// Token: 0x0600198C RID: 6540 RVA: 0x00082CB4 File Offset: 0x00080EB4
		// Note: this type is marked as 'beforefieldinit'.
		static RangePositionInfo()
		{
			Il2CppClassPointerStore<RangePositionInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "RangePositionInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RangePositionInfo>.NativeClassPtr);
			RangePositionInfo.NativeFieldInfoPtr_curpos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RangePositionInfo>.NativeClassPtr, "curpos");
			RangePositionInfo.NativeFieldInfoPtr_rangeCounters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RangePositionInfo>.NativeClassPtr, "rangeCounters");
		}

		// Token: 0x0600198D RID: 6541 RVA: 0x0000ADEF File Offset: 0x00008FEF
		public RangePositionInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600198E RID: 6542 RVA: 0x0000ADF8 File Offset: 0x00008FF8
		public RangePositionInfo()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RangePositionInfo>.NativeClassPtr))
		{
		}

		// Token: 0x1700083B RID: 2107
		// (get) Token: 0x0600198F RID: 6543 RVA: 0x00082D0C File Offset: 0x00080F0C
		// (set) Token: 0x06001990 RID: 6544 RVA: 0x0000AE0A File Offset: 0x0000900A
		public unsafe BitSet curpos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RangePositionInfo.NativeFieldInfoPtr_curpos);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BitSet>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RangePositionInfo.NativeFieldInfoPtr_curpos), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700083C RID: 2108
		// (get) Token: 0x06001991 RID: 6545 RVA: 0x00082D3C File Offset: 0x00080F3C
		// (set) Token: 0x06001992 RID: 6546 RVA: 0x0000AE29 File Offset: 0x00009029
		public unsafe Il2CppStructArray<Decimal> rangeCounters
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RangePositionInfo.NativeFieldInfoPtr_rangeCounters);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Decimal>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RangePositionInfo.NativeFieldInfoPtr_rangeCounters), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040013DE RID: 5086
		private static readonly IntPtr NativeFieldInfoPtr_curpos;

		// Token: 0x040013DF RID: 5087
		private static readonly IntPtr NativeFieldInfoPtr_rangeCounters;
	}
}
