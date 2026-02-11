using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Unity.Mathematics;

namespace UnityEngine.Rendering.Universal.UTess
{
	// Token: 0x02000131 RID: 305
	public sealed class UHull : ValueType
	{
		// Token: 0x06001A6F RID: 6767 RVA: 0x0006F0D0 File Offset: 0x0006D2D0
		// Note: this type is marked as 'beforefieldinit'.
		static UHull()
		{
			Il2CppClassPointerStore<UHull>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal.UTess", "UHull");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UHull>.NativeClassPtr);
			UHull.NativeFieldInfoPtr_a = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UHull>.NativeClassPtr, "a");
			UHull.NativeFieldInfoPtr_b = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UHull>.NativeClassPtr, "b");
			UHull.NativeFieldInfoPtr_idx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UHull>.NativeClassPtr, "idx");
			UHull.NativeFieldInfoPtr_ilarray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UHull>.NativeClassPtr, "ilarray");
			UHull.NativeFieldInfoPtr_ilcount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UHull>.NativeClassPtr, "ilcount");
			UHull.NativeFieldInfoPtr_iuarray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UHull>.NativeClassPtr, "iuarray");
			UHull.NativeFieldInfoPtr_iucount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UHull>.NativeClassPtr, "iucount");
		}

		// Token: 0x06001A70 RID: 6768 RVA: 0x0000EE62 File Offset: 0x0000D062
		public UHull(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06001A71 RID: 6769 RVA: 0x0000EE6B File Offset: 0x0000D06B
		public UHull()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UHull>.NativeClassPtr))
		{
		}

		// Token: 0x17000996 RID: 2454
		// (get) Token: 0x06001A72 RID: 6770 RVA: 0x0006F18C File Offset: 0x0006D38C
		// (set) Token: 0x06001A73 RID: 6771 RVA: 0x0000EE7D File Offset: 0x0000D07D
		public unsafe float2 a
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UHull.NativeFieldInfoPtr_a);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UHull.NativeFieldInfoPtr_a)) = value;
			}
		}

		// Token: 0x17000997 RID: 2455
		// (get) Token: 0x06001A74 RID: 6772 RVA: 0x0006F1B4 File Offset: 0x0006D3B4
		// (set) Token: 0x06001A75 RID: 6773 RVA: 0x0000EE98 File Offset: 0x0000D098
		public unsafe float2 b
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UHull.NativeFieldInfoPtr_b);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UHull.NativeFieldInfoPtr_b)) = value;
			}
		}

		// Token: 0x17000998 RID: 2456
		// (get) Token: 0x06001A76 RID: 6774 RVA: 0x0006F1DC File Offset: 0x0006D3DC
		// (set) Token: 0x06001A77 RID: 6775 RVA: 0x0000EEB3 File Offset: 0x0000D0B3
		public unsafe int idx
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UHull.NativeFieldInfoPtr_idx);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UHull.NativeFieldInfoPtr_idx)) = value;
			}
		}

		// Token: 0x17000999 RID: 2457
		// (get) Token: 0x06001A78 RID: 6776 RVA: 0x0006F204 File Offset: 0x0006D404
		// (set) Token: 0x06001A79 RID: 6777 RVA: 0x0000EECE File Offset: 0x0000D0CE
		public ArraySlice<int> ilarray
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UHull.NativeFieldInfoPtr_ilarray);
				return new ArraySlice<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ArraySlice<int>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UHull.NativeFieldInfoPtr_ilarray), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ArraySlice<int>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700099A RID: 2458
		// (get) Token: 0x06001A7A RID: 6778 RVA: 0x0006F234 File Offset: 0x0006D434
		// (set) Token: 0x06001A7B RID: 6779 RVA: 0x0000EEFC File Offset: 0x0000D0FC
		public unsafe int ilcount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UHull.NativeFieldInfoPtr_ilcount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UHull.NativeFieldInfoPtr_ilcount)) = value;
			}
		}

		// Token: 0x1700099B RID: 2459
		// (get) Token: 0x06001A7C RID: 6780 RVA: 0x0006F25C File Offset: 0x0006D45C
		// (set) Token: 0x06001A7D RID: 6781 RVA: 0x0000EF17 File Offset: 0x0000D117
		public ArraySlice<int> iuarray
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UHull.NativeFieldInfoPtr_iuarray);
				return new ArraySlice<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ArraySlice<int>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UHull.NativeFieldInfoPtr_iuarray), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ArraySlice<int>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700099C RID: 2460
		// (get) Token: 0x06001A7E RID: 6782 RVA: 0x0006F28C File Offset: 0x0006D48C
		// (set) Token: 0x06001A7F RID: 6783 RVA: 0x0000EF45 File Offset: 0x0000D145
		public unsafe int iucount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UHull.NativeFieldInfoPtr_iucount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UHull.NativeFieldInfoPtr_iucount)) = value;
			}
		}

		// Token: 0x0400131C RID: 4892
		private static readonly IntPtr NativeFieldInfoPtr_a;

		// Token: 0x0400131D RID: 4893
		private static readonly IntPtr NativeFieldInfoPtr_b;

		// Token: 0x0400131E RID: 4894
		private static readonly IntPtr NativeFieldInfoPtr_idx;

		// Token: 0x0400131F RID: 4895
		private static readonly IntPtr NativeFieldInfoPtr_ilarray;

		// Token: 0x04001320 RID: 4896
		private static readonly IntPtr NativeFieldInfoPtr_ilcount;

		// Token: 0x04001321 RID: 4897
		private static readonly IntPtr NativeFieldInfoPtr_iuarray;

		// Token: 0x04001322 RID: 4898
		private static readonly IntPtr NativeFieldInfoPtr_iucount;
	}
}
