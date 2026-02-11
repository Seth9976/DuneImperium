using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.Rendering
{
	// Token: 0x020000F4 RID: 244
	[Serializable]
	public class MinIntParameter : IntParameter
	{
		// Token: 0x0600114B RID: 4427 RVA: 0x0004F3D0 File Offset: 0x0004D5D0
		// Note: this type is marked as 'beforefieldinit'.
		static MinIntParameter()
		{
			Il2CppClassPointerStore<MinIntParameter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "MinIntParameter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MinIntParameter>.NativeClassPtr);
			MinIntParameter.NativeFieldInfoPtr_min = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MinIntParameter>.NativeClassPtr, "min");
			MinIntParameter.NativeMethodInfoPtr_get_value_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MinIntParameter>.NativeClassPtr, 100665857);
			MinIntParameter.NativeMethodInfoPtr_set_value_Public_Virtual_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MinIntParameter>.NativeClassPtr, 100665858);
			MinIntParameter.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MinIntParameter>.NativeClassPtr, 100665859);
		}

		// Token: 0x1700050C RID: 1292
		// (get) Token: 0x0600114C RID: 4428 RVA: 0x0004F450 File Offset: 0x0004D650
		// (set) Token: 0x0600114D RID: 4429 RVA: 0x0004F498 File Offset: 0x0004D698
		public unsafe override int value
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MinIntParameter.NativeMethodInfoPtr_get_value_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MinIntParameter.NativeMethodInfoPtr_set_value_Public_Virtual_set_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600114E RID: 4430 RVA: 0x0004F4E4 File Offset: 0x0004D6E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 978899, XrefRangeEnd = 978902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MinIntParameter(int value, int min, bool overrideState = false)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MinIntParameter>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref min;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref overrideState;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MinIntParameter.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600114F RID: 4431 RVA: 0x0000901E File Offset: 0x0000721E
		public MinIntParameter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700050B RID: 1291
		// (get) Token: 0x06001150 RID: 4432 RVA: 0x0004F548 File Offset: 0x0004D748
		// (set) Token: 0x06001151 RID: 4433 RVA: 0x00009027 File Offset: 0x00007227
		public unsafe int min
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MinIntParameter.NativeFieldInfoPtr_min);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MinIntParameter.NativeFieldInfoPtr_min)) = value;
			}
		}

		// Token: 0x04000D1B RID: 3355
		private static readonly IntPtr NativeFieldInfoPtr_min;

		// Token: 0x04000D1C RID: 3356
		private static readonly IntPtr NativeMethodInfoPtr_get_value_Public_Virtual_get_Int32_0;

		// Token: 0x04000D1D RID: 3357
		private static readonly IntPtr NativeMethodInfoPtr_set_value_Public_Virtual_set_Void_Int32_0;

		// Token: 0x04000D1E RID: 3358
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Boolean_0;
	}
}
