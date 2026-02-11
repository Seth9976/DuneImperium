using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.Rendering
{
	// Token: 0x020000FF RID: 255
	[Serializable]
	public class NoInterpMaxFloatParameter : VolumeParameter<float>
	{
		// Token: 0x06001195 RID: 4501 RVA: 0x0005046C File Offset: 0x0004E66C
		// Note: this type is marked as 'beforefieldinit'.
		static NoInterpMaxFloatParameter()
		{
			Il2CppClassPointerStore<NoInterpMaxFloatParameter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "NoInterpMaxFloatParameter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NoInterpMaxFloatParameter>.NativeClassPtr);
			NoInterpMaxFloatParameter.NativeFieldInfoPtr_max = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoInterpMaxFloatParameter>.NativeClassPtr, "max");
			NoInterpMaxFloatParameter.NativeMethodInfoPtr_get_value_Public_Virtual_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoInterpMaxFloatParameter>.NativeClassPtr, 100665887);
			NoInterpMaxFloatParameter.NativeMethodInfoPtr_set_value_Public_Virtual_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoInterpMaxFloatParameter>.NativeClassPtr, 100665888);
			NoInterpMaxFloatParameter.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoInterpMaxFloatParameter>.NativeClassPtr, 100665889);
		}

		// Token: 0x17000520 RID: 1312
		// (get) Token: 0x06001196 RID: 4502 RVA: 0x000504EC File Offset: 0x0004E6EC
		// (set) Token: 0x06001197 RID: 4503 RVA: 0x00050534 File Offset: 0x0004E734
		public unsafe override float value
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NoInterpMaxFloatParameter.NativeMethodInfoPtr_get_value_Public_Virtual_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NoInterpMaxFloatParameter.NativeMethodInfoPtr_set_value_Public_Virtual_set_Void_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001198 RID: 4504 RVA: 0x00050580 File Offset: 0x0004E780
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 978941, XrefRangeEnd = 978944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NoInterpMaxFloatParameter(float value, float max, bool overrideState = false)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NoInterpMaxFloatParameter>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoInterpMaxFloatParameter.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001199 RID: 4505 RVA: 0x000091E3 File Offset: 0x000073E3
		public NoInterpMaxFloatParameter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700051F RID: 1311
		// (get) Token: 0x0600119A RID: 4506 RVA: 0x000505E4 File Offset: 0x0004E7E4
		// (set) Token: 0x0600119B RID: 4507 RVA: 0x000091EC File Offset: 0x000073EC
		public unsafe float max
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoInterpMaxFloatParameter.NativeFieldInfoPtr_max);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoInterpMaxFloatParameter.NativeFieldInfoPtr_max)) = value;
			}
		}

		// Token: 0x04000D44 RID: 3396
		private static readonly IntPtr NativeFieldInfoPtr_max;

		// Token: 0x04000D45 RID: 3397
		private static readonly IntPtr NativeMethodInfoPtr_get_value_Public_Virtual_get_Single_0;

		// Token: 0x04000D46 RID: 3398
		private static readonly IntPtr NativeMethodInfoPtr_set_value_Public_Virtual_set_Void_Single_0;

		// Token: 0x04000D47 RID: 3399
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Boolean_0;
	}
}
