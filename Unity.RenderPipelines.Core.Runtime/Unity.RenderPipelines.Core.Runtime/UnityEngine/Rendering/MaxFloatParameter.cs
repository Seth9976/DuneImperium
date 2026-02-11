using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.Rendering
{
	// Token: 0x020000FE RID: 254
	[Serializable]
	public class MaxFloatParameter : FloatParameter
	{
		// Token: 0x0600118E RID: 4494 RVA: 0x000502CC File Offset: 0x0004E4CC
		// Note: this type is marked as 'beforefieldinit'.
		static MaxFloatParameter()
		{
			Il2CppClassPointerStore<MaxFloatParameter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "MaxFloatParameter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MaxFloatParameter>.NativeClassPtr);
			MaxFloatParameter.NativeFieldInfoPtr_max = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaxFloatParameter>.NativeClassPtr, "max");
			MaxFloatParameter.NativeMethodInfoPtr_get_value_Public_Virtual_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaxFloatParameter>.NativeClassPtr, 100665884);
			MaxFloatParameter.NativeMethodInfoPtr_set_value_Public_Virtual_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaxFloatParameter>.NativeClassPtr, 100665885);
			MaxFloatParameter.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaxFloatParameter>.NativeClassPtr, 100665886);
		}

		// Token: 0x1700051E RID: 1310
		// (get) Token: 0x0600118F RID: 4495 RVA: 0x0005034C File Offset: 0x0004E54C
		// (set) Token: 0x06001190 RID: 4496 RVA: 0x00050394 File Offset: 0x0004E594
		public unsafe override float value
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MaxFloatParameter.NativeMethodInfoPtr_get_value_Public_Virtual_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MaxFloatParameter.NativeMethodInfoPtr_set_value_Public_Virtual_set_Void_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001191 RID: 4497 RVA: 0x000503E0 File Offset: 0x0004E5E0
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 978927, RefRangeEnd = 978938, XrefRangeStart = 978927, XrefRangeEnd = 978938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MaxFloatParameter(float value, float max, bool overrideState = false)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MaxFloatParameter>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref max;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref overrideState;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaxFloatParameter.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001192 RID: 4498 RVA: 0x000091BF File Offset: 0x000073BF
		public MaxFloatParameter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700051D RID: 1309
		// (get) Token: 0x06001193 RID: 4499 RVA: 0x00050444 File Offset: 0x0004E644
		// (set) Token: 0x06001194 RID: 4500 RVA: 0x000091C8 File Offset: 0x000073C8
		public unsafe float max
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaxFloatParameter.NativeFieldInfoPtr_max);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaxFloatParameter.NativeFieldInfoPtr_max)) = value;
			}
		}

		// Token: 0x04000D40 RID: 3392
		private static readonly IntPtr NativeFieldInfoPtr_max;

		// Token: 0x04000D41 RID: 3393
		private static readonly IntPtr NativeMethodInfoPtr_get_value_Public_Virtual_get_Single_0;

		// Token: 0x04000D42 RID: 3394
		private static readonly IntPtr NativeMethodInfoPtr_set_value_Public_Virtual_set_Void_Single_0;

		// Token: 0x04000D43 RID: 3395
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Boolean_0;
	}
}
