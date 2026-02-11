using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.Rendering
{
	// Token: 0x02000102 RID: 258
	[Serializable]
	public class FloatRangeParameter : VolumeParameter<Vector2>
	{
		// Token: 0x060011AE RID: 4526 RVA: 0x000509E4 File Offset: 0x0004EBE4
		// Note: this type is marked as 'beforefieldinit'.
		static FloatRangeParameter()
		{
			Il2CppClassPointerStore<FloatRangeParameter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "FloatRangeParameter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FloatRangeParameter>.NativeClassPtr);
			FloatRangeParameter.NativeFieldInfoPtr_min = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FloatRangeParameter>.NativeClassPtr, "min");
			FloatRangeParameter.NativeFieldInfoPtr_max = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FloatRangeParameter>.NativeClassPtr, "max");
			FloatRangeParameter.NativeMethodInfoPtr_get_value_Public_Virtual_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatRangeParameter>.NativeClassPtr, 100665896);
			FloatRangeParameter.NativeMethodInfoPtr_set_value_Public_Virtual_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatRangeParameter>.NativeClassPtr, 100665897);
			FloatRangeParameter.NativeMethodInfoPtr__ctor_Public_Void_Vector2_Single_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatRangeParameter>.NativeClassPtr, 100665898);
			FloatRangeParameter.NativeMethodInfoPtr_Interp_Public_Virtual_Void_Vector2_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatRangeParameter>.NativeClassPtr, 100665899);
		}

		// Token: 0x17000529 RID: 1321
		// (get) Token: 0x060011AF RID: 4527 RVA: 0x00050A8C File Offset: 0x0004EC8C
		// (set) Token: 0x060011B0 RID: 4528 RVA: 0x00050AD4 File Offset: 0x0004ECD4
		public unsafe override Vector2 value
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FloatRangeParameter.NativeMethodInfoPtr_get_value_Public_Virtual_get_Vector2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FloatRangeParameter.NativeMethodInfoPtr_set_value_Public_Virtual_set_Void_Vector2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060011B1 RID: 4529 RVA: 0x00050B20 File Offset: 0x0004ED20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 978989, XrefRangeEnd = 978992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FloatRangeParameter(Vector2 value, float min, float max, bool overrideState = false)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FloatRangeParameter>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref min;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref max;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref overrideState;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FloatRangeParameter.NativeMethodInfoPtr__ctor_Public_Void_Vector2_Single_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011B2 RID: 4530 RVA: 0x00050B94 File Offset: 0x0004ED94
		[CallerCount(0)]
		public unsafe override void Interp(Vector2 from, Vector2 to, float t)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref from;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref to;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref t;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FloatRangeParameter.NativeMethodInfoPtr_Interp_Public_Virtual_Void_Vector2_Vector2_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011B3 RID: 4531 RVA: 0x00009285 File Offset: 0x00007485
		public FloatRangeParameter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000527 RID: 1319
		// (get) Token: 0x060011B4 RID: 4532 RVA: 0x00050BFC File Offset: 0x0004EDFC
		// (set) Token: 0x060011B5 RID: 4533 RVA: 0x0000928E File Offset: 0x0000748E
		public unsafe float min
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FloatRangeParameter.NativeFieldInfoPtr_min);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FloatRangeParameter.NativeFieldInfoPtr_min)) = value;
			}
		}

		// Token: 0x17000528 RID: 1320
		// (get) Token: 0x060011B6 RID: 4534 RVA: 0x00050C24 File Offset: 0x0004EE24
		// (set) Token: 0x060011B7 RID: 4535 RVA: 0x000092A9 File Offset: 0x000074A9
		public unsafe float max
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FloatRangeParameter.NativeFieldInfoPtr_max);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FloatRangeParameter.NativeFieldInfoPtr_max)) = value;
			}
		}

		// Token: 0x04000D52 RID: 3410
		private static readonly IntPtr NativeFieldInfoPtr_min;

		// Token: 0x04000D53 RID: 3411
		private static readonly IntPtr NativeFieldInfoPtr_max;

		// Token: 0x04000D54 RID: 3412
		private static readonly IntPtr NativeMethodInfoPtr_get_value_Public_Virtual_get_Vector2_0;

		// Token: 0x04000D55 RID: 3413
		private static readonly IntPtr NativeMethodInfoPtr_set_value_Public_Virtual_set_Void_Vector2_0;

		// Token: 0x04000D56 RID: 3414
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Vector2_Single_Single_Boolean_0;

		// Token: 0x04000D57 RID: 3415
		private static readonly IntPtr NativeMethodInfoPtr_Interp_Public_Virtual_Void_Vector2_Vector2_Single_0;
	}
}
