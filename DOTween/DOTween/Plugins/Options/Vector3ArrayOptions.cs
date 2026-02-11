using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace DG.Tweening.Plugins.Options
{
	// Token: 0x02000033 RID: 51
	public sealed class Vector3ArrayOptions : ValueType
	{
		// Token: 0x0600035F RID: 863 RVA: 0x00016B40 File Offset: 0x00014D40
		// Note: this type is marked as 'beforefieldinit'.
		static Vector3ArrayOptions()
		{
			Il2CppClassPointerStore<Vector3ArrayOptions>.NativeClassPtr = IL2CPP.GetIl2CppClass("DOTween.dll", "DG.Tweening.Plugins.Options", "Vector3ArrayOptions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Vector3ArrayOptions>.NativeClassPtr);
			Vector3ArrayOptions.NativeFieldInfoPtr_axisConstraint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector3ArrayOptions>.NativeClassPtr, "axisConstraint");
			Vector3ArrayOptions.NativeFieldInfoPtr_snapping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector3ArrayOptions>.NativeClassPtr, "snapping");
			Vector3ArrayOptions.NativeFieldInfoPtr_durations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector3ArrayOptions>.NativeClassPtr, "durations");
			Vector3ArrayOptions.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3ArrayOptions>.NativeClassPtr, 100664087);
		}

		// Token: 0x06000360 RID: 864 RVA: 0x00016BC0 File Offset: 0x00014DC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1132489, XrefRangeEnd = 1132490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3ArrayOptions.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000361 RID: 865 RVA: 0x00002F0C File Offset: 0x0000110C
		public Vector3ArrayOptions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000362 RID: 866 RVA: 0x00002F15 File Offset: 0x00001115
		public Vector3ArrayOptions()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Vector3ArrayOptions>.NativeClassPtr))
		{
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x06000363 RID: 867 RVA: 0x00016BF8 File Offset: 0x00014DF8
		// (set) Token: 0x06000364 RID: 868 RVA: 0x00002F27 File Offset: 0x00001127
		public unsafe AxisConstraint axisConstraint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Vector3ArrayOptions.NativeFieldInfoPtr_axisConstraint);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Vector3ArrayOptions.NativeFieldInfoPtr_axisConstraint)) = value;
			}
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x06000365 RID: 869 RVA: 0x00016C20 File Offset: 0x00014E20
		// (set) Token: 0x06000366 RID: 870 RVA: 0x00002F42 File Offset: 0x00001142
		public unsafe bool snapping
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Vector3ArrayOptions.NativeFieldInfoPtr_snapping);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Vector3ArrayOptions.NativeFieldInfoPtr_snapping)) = value;
			}
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x06000367 RID: 871 RVA: 0x00016C48 File Offset: 0x00014E48
		// (set) Token: 0x06000368 RID: 872 RVA: 0x00002F5D File Offset: 0x0000115D
		public unsafe Il2CppStructArray<float> durations
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Vector3ArrayOptions.NativeFieldInfoPtr_durations);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Vector3ArrayOptions.NativeFieldInfoPtr_durations), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040002F1 RID: 753
		private static readonly IntPtr NativeFieldInfoPtr_axisConstraint;

		// Token: 0x040002F2 RID: 754
		private static readonly IntPtr NativeFieldInfoPtr_snapping;

		// Token: 0x040002F3 RID: 755
		private static readonly IntPtr NativeFieldInfoPtr_durations;

		// Token: 0x040002F4 RID: 756
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0;
	}
}
