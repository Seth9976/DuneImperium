using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.Rendering
{
	// Token: 0x020000F8 RID: 248
	[Serializable]
	public class ClampedIntParameter : IntParameter
	{
		// Token: 0x06001167 RID: 4455 RVA: 0x0004FA50 File Offset: 0x0004DC50
		// Note: this type is marked as 'beforefieldinit'.
		static ClampedIntParameter()
		{
			Il2CppClassPointerStore<ClampedIntParameter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "ClampedIntParameter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClampedIntParameter>.NativeClassPtr);
			ClampedIntParameter.NativeFieldInfoPtr_min = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClampedIntParameter>.NativeClassPtr, "min");
			ClampedIntParameter.NativeFieldInfoPtr_max = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClampedIntParameter>.NativeClassPtr, "max");
			ClampedIntParameter.NativeMethodInfoPtr_get_value_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClampedIntParameter>.NativeClassPtr, 100665869);
			ClampedIntParameter.NativeMethodInfoPtr_set_value_Public_Virtual_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClampedIntParameter>.NativeClassPtr, 100665870);
			ClampedIntParameter.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClampedIntParameter>.NativeClassPtr, 100665871);
		}

		// Token: 0x17000515 RID: 1301
		// (get) Token: 0x06001168 RID: 4456 RVA: 0x0004FAE4 File Offset: 0x0004DCE4
		// (set) Token: 0x06001169 RID: 4457 RVA: 0x0004FB2C File Offset: 0x0004DD2C
		public unsafe override int value
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ClampedIntParameter.NativeMethodInfoPtr_get_value_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ClampedIntParameter.NativeMethodInfoPtr_set_value_Public_Virtual_set_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600116A RID: 4458 RVA: 0x0004FB78 File Offset: 0x0004DD78
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 978911, RefRangeEnd = 978914, XrefRangeStart = 978908, XrefRangeEnd = 978911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ClampedIntParameter(int value, int min, int max, bool overrideState = false)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClampedIntParameter>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClampedIntParameter.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600116B RID: 4459 RVA: 0x000090AE File Offset: 0x000072AE
		public ClampedIntParameter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000513 RID: 1299
		// (get) Token: 0x0600116C RID: 4460 RVA: 0x0004FBEC File Offset: 0x0004DDEC
		// (set) Token: 0x0600116D RID: 4461 RVA: 0x000090B7 File Offset: 0x000072B7
		public unsafe int min
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClampedIntParameter.NativeFieldInfoPtr_min);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClampedIntParameter.NativeFieldInfoPtr_min)) = value;
			}
		}

		// Token: 0x17000514 RID: 1300
		// (get) Token: 0x0600116E RID: 4462 RVA: 0x0004FC14 File Offset: 0x0004DE14
		// (set) Token: 0x0600116F RID: 4463 RVA: 0x000090D2 File Offset: 0x000072D2
		public unsafe int max
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClampedIntParameter.NativeFieldInfoPtr_max);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClampedIntParameter.NativeFieldInfoPtr_max)) = value;
			}
		}

		// Token: 0x04000D2B RID: 3371
		private static readonly IntPtr NativeFieldInfoPtr_min;

		// Token: 0x04000D2C RID: 3372
		private static readonly IntPtr NativeFieldInfoPtr_max;

		// Token: 0x04000D2D RID: 3373
		private static readonly IntPtr NativeMethodInfoPtr_get_value_Public_Virtual_get_Int32_0;

		// Token: 0x04000D2E RID: 3374
		private static readonly IntPtr NativeMethodInfoPtr_set_value_Public_Virtual_set_Void_Int32_0;

		// Token: 0x04000D2F RID: 3375
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Boolean_0;
	}
}
