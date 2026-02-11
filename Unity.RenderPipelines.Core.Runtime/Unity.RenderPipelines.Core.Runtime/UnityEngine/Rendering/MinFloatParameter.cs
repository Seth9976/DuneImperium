using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.Rendering
{
	// Token: 0x020000FC RID: 252
	[Serializable]
	public class MinFloatParameter : FloatParameter
	{
		// Token: 0x06001180 RID: 4480 RVA: 0x0004FF8C File Offset: 0x0004E18C
		// Note: this type is marked as 'beforefieldinit'.
		static MinFloatParameter()
		{
			Il2CppClassPointerStore<MinFloatParameter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "MinFloatParameter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MinFloatParameter>.NativeClassPtr);
			MinFloatParameter.NativeFieldInfoPtr_min = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MinFloatParameter>.NativeClassPtr, "min");
			MinFloatParameter.NativeMethodInfoPtr_get_value_Public_Virtual_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MinFloatParameter>.NativeClassPtr, 100665878);
			MinFloatParameter.NativeMethodInfoPtr_set_value_Public_Virtual_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MinFloatParameter>.NativeClassPtr, 100665879);
			MinFloatParameter.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MinFloatParameter>.NativeClassPtr, 100665880);
		}

		// Token: 0x1700051A RID: 1306
		// (get) Token: 0x06001181 RID: 4481 RVA: 0x0005000C File Offset: 0x0004E20C
		// (set) Token: 0x06001182 RID: 4482 RVA: 0x00050054 File Offset: 0x0004E254
		public unsafe override float value
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MinFloatParameter.NativeMethodInfoPtr_get_value_Public_Virtual_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MinFloatParameter.NativeMethodInfoPtr_set_value_Public_Virtual_set_Void_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001183 RID: 4483 RVA: 0x000500A0 File Offset: 0x0004E2A0
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 978927, RefRangeEnd = 978938, XrefRangeStart = 978924, XrefRangeEnd = 978927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MinFloatParameter(float value, float min, bool overrideState = false)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MinFloatParameter>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MinFloatParameter.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001184 RID: 4484 RVA: 0x00009177 File Offset: 0x00007377
		public MinFloatParameter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000519 RID: 1305
		// (get) Token: 0x06001185 RID: 4485 RVA: 0x00050104 File Offset: 0x0004E304
		// (set) Token: 0x06001186 RID: 4486 RVA: 0x00009180 File Offset: 0x00007380
		public unsafe float min
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MinFloatParameter.NativeFieldInfoPtr_min);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MinFloatParameter.NativeFieldInfoPtr_min)) = value;
			}
		}

		// Token: 0x04000D38 RID: 3384
		private static readonly IntPtr NativeFieldInfoPtr_min;

		// Token: 0x04000D39 RID: 3385
		private static readonly IntPtr NativeMethodInfoPtr_get_value_Public_Virtual_get_Single_0;

		// Token: 0x04000D3A RID: 3386
		private static readonly IntPtr NativeMethodInfoPtr_set_value_Public_Virtual_set_Void_Single_0;

		// Token: 0x04000D3B RID: 3387
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Boolean_0;
	}
}
