using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Networking.game
{
	// Token: 0x020000AC RID: 172
	public class DWDGameProperty : Object
	{
		// Token: 0x060005A1 RID: 1441 RVA: 0x00014E80 File Offset: 0x00013080
		// Note: this type is marked as 'beforefieldinit'.
		static DWDGameProperty()
		{
			Il2CppClassPointerStore<DWDGameProperty>.NativeClassPtr = IL2CPP.GetIl2CppClass("Networking.dll", "Networking.game", "DWDGameProperty");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DWDGameProperty>.NativeClassPtr);
			DWDGameProperty.NativeFieldInfoPtr_Key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DWDGameProperty>.NativeClassPtr, "Key");
			DWDGameProperty.NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DWDGameProperty>.NativeClassPtr, "Value");
			DWDGameProperty.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DWDGameProperty>.NativeClassPtr, 100663649);
		}

		// Token: 0x060005A2 RID: 1442 RVA: 0x00014EEC File Offset: 0x000130EC
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DWDGameProperty()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DWDGameProperty>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DWDGameProperty.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005A3 RID: 1443 RVA: 0x000057A6 File Offset: 0x000039A6
		public DWDGameProperty(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001A2 RID: 418
		// (get) Token: 0x060005A4 RID: 1444 RVA: 0x00014F28 File Offset: 0x00013128
		// (set) Token: 0x060005A5 RID: 1445 RVA: 0x000057AF File Offset: 0x000039AF
		public unsafe string Key
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DWDGameProperty.NativeFieldInfoPtr_Key);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DWDGameProperty.NativeFieldInfoPtr_Key), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170001A3 RID: 419
		// (get) Token: 0x060005A6 RID: 1446 RVA: 0x00014F50 File Offset: 0x00013150
		// (set) Token: 0x060005A7 RID: 1447 RVA: 0x000057CE File Offset: 0x000039CE
		public unsafe string Value
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DWDGameProperty.NativeFieldInfoPtr_Value);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DWDGameProperty.NativeFieldInfoPtr_Value), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040002FA RID: 762
		private static readonly IntPtr NativeFieldInfoPtr_Key;

		// Token: 0x040002FB RID: 763
		private static readonly IntPtr NativeFieldInfoPtr_Value;

		// Token: 0x040002FC RID: 764
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
