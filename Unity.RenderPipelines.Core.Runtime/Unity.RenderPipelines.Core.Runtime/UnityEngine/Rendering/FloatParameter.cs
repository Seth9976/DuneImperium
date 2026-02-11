using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.Rendering
{
	// Token: 0x020000FA RID: 250
	[Serializable]
	public class FloatParameter : VolumeParameter<float>
	{
		// Token: 0x06001179 RID: 4473 RVA: 0x0004FE28 File Offset: 0x0004E028
		// Note: this type is marked as 'beforefieldinit'.
		static FloatParameter()
		{
			Il2CppClassPointerStore<FloatParameter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "FloatParameter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FloatParameter>.NativeClassPtr);
			FloatParameter.NativeMethodInfoPtr__ctor_Public_Void_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatParameter>.NativeClassPtr, 100665875);
			FloatParameter.NativeMethodInfoPtr_Interp_Public_Virtual_Final_Void_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatParameter>.NativeClassPtr, 100665876);
		}

		// Token: 0x0600117A RID: 4474 RVA: 0x0004FE80 File Offset: 0x0004E080
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 978920, RefRangeEnd = 978921, XrefRangeStart = 978917, XrefRangeEnd = 978920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FloatParameter(float value, bool overrideState = false)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FloatParameter>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref overrideState;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FloatParameter.NativeMethodInfoPtr__ctor_Public_Void_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600117B RID: 4475 RVA: 0x0004FED8 File Offset: 0x0004E0D8
		[CallerCount(0)]
		public unsafe override void Interp(float from, float to, float t)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FloatParameter.NativeMethodInfoPtr_Interp_Public_Virtual_Final_Void_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600117C RID: 4476 RVA: 0x0000912C File Offset: 0x0000732C
		public FloatParameter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000D35 RID: 3381
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Boolean_0;

		// Token: 0x04000D36 RID: 3382
		private static readonly IntPtr NativeMethodInfoPtr_Interp_Public_Virtual_Final_Void_Single_Single_Single_0;
	}
}
