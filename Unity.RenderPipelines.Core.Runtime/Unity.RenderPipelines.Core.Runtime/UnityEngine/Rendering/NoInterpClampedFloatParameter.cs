using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.Rendering
{
	// Token: 0x02000101 RID: 257
	[Serializable]
	public class NoInterpClampedFloatParameter : VolumeParameter<float>
	{
		// Token: 0x060011A5 RID: 4517 RVA: 0x000507F8 File Offset: 0x0004E9F8
		// Note: this type is marked as 'beforefieldinit'.
		static NoInterpClampedFloatParameter()
		{
			Il2CppClassPointerStore<NoInterpClampedFloatParameter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "NoInterpClampedFloatParameter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NoInterpClampedFloatParameter>.NativeClassPtr);
			NoInterpClampedFloatParameter.NativeFieldInfoPtr_min = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoInterpClampedFloatParameter>.NativeClassPtr, "min");
			NoInterpClampedFloatParameter.NativeFieldInfoPtr_max = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoInterpClampedFloatParameter>.NativeClassPtr, "max");
			NoInterpClampedFloatParameter.NativeMethodInfoPtr_get_value_Public_Virtual_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoInterpClampedFloatParameter>.NativeClassPtr, 100665893);
			NoInterpClampedFloatParameter.NativeMethodInfoPtr_set_value_Public_Virtual_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoInterpClampedFloatParameter>.NativeClassPtr, 100665894);
			NoInterpClampedFloatParameter.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoInterpClampedFloatParameter>.NativeClassPtr, 100665895);
		}

		// Token: 0x17000526 RID: 1318
		// (get) Token: 0x060011A6 RID: 4518 RVA: 0x0005088C File Offset: 0x0004EA8C
		// (set) Token: 0x060011A7 RID: 4519 RVA: 0x000508D4 File Offset: 0x0004EAD4
		public unsafe override float value
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NoInterpClampedFloatParameter.NativeMethodInfoPtr_get_value_Public_Virtual_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NoInterpClampedFloatParameter.NativeMethodInfoPtr_set_value_Public_Virtual_set_Void_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060011A8 RID: 4520 RVA: 0x00050920 File Offset: 0x0004EB20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 978986, XrefRangeEnd = 978989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NoInterpClampedFloatParameter(float value, float min, float max, bool overrideState = false)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NoInterpClampedFloatParameter>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoInterpClampedFloatParameter.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011A9 RID: 4521 RVA: 0x00009246 File Offset: 0x00007446
		public NoInterpClampedFloatParameter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000524 RID: 1316
		// (get) Token: 0x060011AA RID: 4522 RVA: 0x00050994 File Offset: 0x0004EB94
		// (set) Token: 0x060011AB RID: 4523 RVA: 0x0000924F File Offset: 0x0000744F
		public unsafe float min
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoInterpClampedFloatParameter.NativeFieldInfoPtr_min);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoInterpClampedFloatParameter.NativeFieldInfoPtr_min)) = value;
			}
		}

		// Token: 0x17000525 RID: 1317
		// (get) Token: 0x060011AC RID: 4524 RVA: 0x000509BC File Offset: 0x0004EBBC
		// (set) Token: 0x060011AD RID: 4525 RVA: 0x0000926A File Offset: 0x0000746A
		public unsafe float max
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoInterpClampedFloatParameter.NativeFieldInfoPtr_max);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoInterpClampedFloatParameter.NativeFieldInfoPtr_max)) = value;
			}
		}

		// Token: 0x04000D4D RID: 3405
		private static readonly IntPtr NativeFieldInfoPtr_min;

		// Token: 0x04000D4E RID: 3406
		private static readonly IntPtr NativeFieldInfoPtr_max;

		// Token: 0x04000D4F RID: 3407
		private static readonly IntPtr NativeMethodInfoPtr_get_value_Public_Virtual_get_Single_0;

		// Token: 0x04000D50 RID: 3408
		private static readonly IntPtr NativeMethodInfoPtr_set_value_Public_Virtual_set_Void_Single_0;

		// Token: 0x04000D51 RID: 3409
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Boolean_0;
	}
}
