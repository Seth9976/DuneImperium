using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.Rendering
{
	// Token: 0x02000100 RID: 256
	[Serializable]
	public class ClampedFloatParameter : FloatParameter
	{
		// Token: 0x0600119C RID: 4508 RVA: 0x0005060C File Offset: 0x0004E80C
		// Note: this type is marked as 'beforefieldinit'.
		static ClampedFloatParameter()
		{
			Il2CppClassPointerStore<ClampedFloatParameter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "ClampedFloatParameter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClampedFloatParameter>.NativeClassPtr);
			ClampedFloatParameter.NativeFieldInfoPtr_min = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClampedFloatParameter>.NativeClassPtr, "min");
			ClampedFloatParameter.NativeFieldInfoPtr_max = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClampedFloatParameter>.NativeClassPtr, "max");
			ClampedFloatParameter.NativeMethodInfoPtr_get_value_Public_Virtual_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClampedFloatParameter>.NativeClassPtr, 100665890);
			ClampedFloatParameter.NativeMethodInfoPtr_set_value_Public_Virtual_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClampedFloatParameter>.NativeClassPtr, 100665891);
			ClampedFloatParameter.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClampedFloatParameter>.NativeClassPtr, 100665892);
		}

		// Token: 0x17000523 RID: 1315
		// (get) Token: 0x0600119D RID: 4509 RVA: 0x000506A0 File Offset: 0x0004E8A0
		// (set) Token: 0x0600119E RID: 4510 RVA: 0x000506E8 File Offset: 0x0004E8E8
		public unsafe override float value
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ClampedFloatParameter.NativeMethodInfoPtr_get_value_Public_Virtual_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ClampedFloatParameter.NativeMethodInfoPtr_set_value_Public_Virtual_set_Void_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600119F RID: 4511 RVA: 0x00050734 File Offset: 0x0004E934
		[CallerCount(39)]
		[CachedScanResults(RefRangeStart = 978947, RefRangeEnd = 978986, XrefRangeStart = 978944, XrefRangeEnd = 978947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ClampedFloatParameter(float value, float min, float max, bool overrideState = false)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClampedFloatParameter>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClampedFloatParameter.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011A0 RID: 4512 RVA: 0x00009207 File Offset: 0x00007407
		public ClampedFloatParameter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000521 RID: 1313
		// (get) Token: 0x060011A1 RID: 4513 RVA: 0x000507A8 File Offset: 0x0004E9A8
		// (set) Token: 0x060011A2 RID: 4514 RVA: 0x00009210 File Offset: 0x00007410
		public unsafe float min
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClampedFloatParameter.NativeFieldInfoPtr_min);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClampedFloatParameter.NativeFieldInfoPtr_min)) = value;
			}
		}

		// Token: 0x17000522 RID: 1314
		// (get) Token: 0x060011A3 RID: 4515 RVA: 0x000507D0 File Offset: 0x0004E9D0
		// (set) Token: 0x060011A4 RID: 4516 RVA: 0x0000922B File Offset: 0x0000742B
		public unsafe float max
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClampedFloatParameter.NativeFieldInfoPtr_max);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClampedFloatParameter.NativeFieldInfoPtr_max)) = value;
			}
		}

		// Token: 0x04000D48 RID: 3400
		private static readonly IntPtr NativeFieldInfoPtr_min;

		// Token: 0x04000D49 RID: 3401
		private static readonly IntPtr NativeFieldInfoPtr_max;

		// Token: 0x04000D4A RID: 3402
		private static readonly IntPtr NativeMethodInfoPtr_get_value_Public_Virtual_get_Single_0;

		// Token: 0x04000D4B RID: 3403
		private static readonly IntPtr NativeMethodInfoPtr_set_value_Public_Virtual_set_Void_Single_0;

		// Token: 0x04000D4C RID: 3404
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Boolean_0;
	}
}
