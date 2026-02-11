using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering.Universal.UTess
{
	// Token: 0x02000132 RID: 306
	public sealed class UStar : ValueType
	{
		// Token: 0x06001A80 RID: 6784 RVA: 0x0006F2B4 File Offset: 0x0006D4B4
		// Note: this type is marked as 'beforefieldinit'.
		static UStar()
		{
			Il2CppClassPointerStore<UStar>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal.UTess", "UStar");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UStar>.NativeClassPtr);
			UStar.NativeFieldInfoPtr_points = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UStar>.NativeClassPtr, "points");
			UStar.NativeFieldInfoPtr_pointCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UStar>.NativeClassPtr, "pointCount");
		}

		// Token: 0x06001A81 RID: 6785 RVA: 0x0000EF60 File Offset: 0x0000D160
		public UStar(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06001A82 RID: 6786 RVA: 0x0000EF69 File Offset: 0x0000D169
		public UStar()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UStar>.NativeClassPtr))
		{
		}

		// Token: 0x1700099D RID: 2461
		// (get) Token: 0x06001A83 RID: 6787 RVA: 0x0006F30C File Offset: 0x0006D50C
		// (set) Token: 0x06001A84 RID: 6788 RVA: 0x0000EF7B File Offset: 0x0000D17B
		public ArraySlice<int> points
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UStar.NativeFieldInfoPtr_points);
				return new ArraySlice<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ArraySlice<int>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UStar.NativeFieldInfoPtr_points), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ArraySlice<int>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700099E RID: 2462
		// (get) Token: 0x06001A85 RID: 6789 RVA: 0x0006F33C File Offset: 0x0006D53C
		// (set) Token: 0x06001A86 RID: 6790 RVA: 0x0000EFA9 File Offset: 0x0000D1A9
		public unsafe int pointCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UStar.NativeFieldInfoPtr_pointCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UStar.NativeFieldInfoPtr_pointCount)) = value;
			}
		}

		// Token: 0x04001323 RID: 4899
		private static readonly IntPtr NativeFieldInfoPtr_points;

		// Token: 0x04001324 RID: 4900
		private static readonly IntPtr NativeFieldInfoPtr_pointCount;
	}
}
