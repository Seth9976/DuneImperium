using System;
using dwd.core.data.composition;
using dwd.core.wargServer;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace dwd.core.direBytes.data
{
	// Token: 0x02000024 RID: 36
	public class DireByteTileTimeData : DataComponent
	{
		// Token: 0x060001AB RID: 427 RVA: 0x00008254 File Offset: 0x00006454
		// Note: this type is marked as 'beforefieldinit'.
		static DireByteTileTimeData()
		{
			Il2CppClassPointerStore<DireByteTileTimeData>.NativeClassPtr = IL2CPP.GetIl2CppClass("direbytes.dll", "dwd.core.direBytes.data", "DireByteTileTimeData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DireByteTileTimeData>.NativeClassPtr);
			DireByteTileTimeData.NativeFieldInfoPtr_endTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DireByteTileTimeData>.NativeClassPtr, "endTime");
			DireByteTileTimeData.NativeMethodInfoPtr__ctor_Public_Void_WargTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DireByteTileTimeData>.NativeClassPtr, 100663458);
		}

		// Token: 0x060001AC RID: 428 RVA: 0x000082AC File Offset: 0x000064AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1235177, XrefRangeEnd = 1235178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DireByteTileTimeData(WargTime endTime)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DireByteTileTimeData>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(endTime));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DireByteTileTimeData.NativeMethodInfoPtr__ctor_Public_Void_WargTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001AD RID: 429 RVA: 0x00002EDE File Offset: 0x000010DE
		public DireByteTileTimeData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x060001AE RID: 430 RVA: 0x000082FC File Offset: 0x000064FC
		// (set) Token: 0x060001AF RID: 431 RVA: 0x00002EE7 File Offset: 0x000010E7
		public WargTime endTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireByteTileTimeData.NativeFieldInfoPtr_endTime);
				return new WargTime(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<WargTime>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireByteTileTimeData.NativeFieldInfoPtr_endTime), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<WargTime>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x040000F1 RID: 241
		private static readonly IntPtr NativeFieldInfoPtr_endTime;

		// Token: 0x040000F2 RID: 242
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_WargTime_0;
	}
}
