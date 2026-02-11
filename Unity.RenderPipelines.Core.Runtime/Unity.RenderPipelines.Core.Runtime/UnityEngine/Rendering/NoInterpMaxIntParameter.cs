using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.Rendering
{
	// Token: 0x020000F7 RID: 247
	[Serializable]
	public class NoInterpMaxIntParameter : VolumeParameter<int>
	{
		// Token: 0x06001160 RID: 4448 RVA: 0x0004F8B0 File Offset: 0x0004DAB0
		// Note: this type is marked as 'beforefieldinit'.
		static NoInterpMaxIntParameter()
		{
			Il2CppClassPointerStore<NoInterpMaxIntParameter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "NoInterpMaxIntParameter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NoInterpMaxIntParameter>.NativeClassPtr);
			NoInterpMaxIntParameter.NativeFieldInfoPtr_max = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoInterpMaxIntParameter>.NativeClassPtr, "max");
			NoInterpMaxIntParameter.NativeMethodInfoPtr_get_value_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoInterpMaxIntParameter>.NativeClassPtr, 100665866);
			NoInterpMaxIntParameter.NativeMethodInfoPtr_set_value_Public_Virtual_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoInterpMaxIntParameter>.NativeClassPtr, 100665867);
			NoInterpMaxIntParameter.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoInterpMaxIntParameter>.NativeClassPtr, 100665868);
		}

		// Token: 0x17000512 RID: 1298
		// (get) Token: 0x06001161 RID: 4449 RVA: 0x0004F930 File Offset: 0x0004DB30
		// (set) Token: 0x06001162 RID: 4450 RVA: 0x0004F978 File Offset: 0x0004DB78
		public unsafe override int value
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NoInterpMaxIntParameter.NativeMethodInfoPtr_get_value_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NoInterpMaxIntParameter.NativeMethodInfoPtr_set_value_Public_Virtual_set_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001163 RID: 4451 RVA: 0x0004F9C4 File Offset: 0x0004DBC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 978905, XrefRangeEnd = 978908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NoInterpMaxIntParameter(int value, int max, bool overrideState = false)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NoInterpMaxIntParameter>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoInterpMaxIntParameter.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001164 RID: 4452 RVA: 0x0000908A File Offset: 0x0000728A
		public NoInterpMaxIntParameter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000511 RID: 1297
		// (get) Token: 0x06001165 RID: 4453 RVA: 0x0004FA28 File Offset: 0x0004DC28
		// (set) Token: 0x06001166 RID: 4454 RVA: 0x00009093 File Offset: 0x00007293
		public unsafe int max
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoInterpMaxIntParameter.NativeFieldInfoPtr_max);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoInterpMaxIntParameter.NativeFieldInfoPtr_max)) = value;
			}
		}

		// Token: 0x04000D27 RID: 3367
		private static readonly IntPtr NativeFieldInfoPtr_max;

		// Token: 0x04000D28 RID: 3368
		private static readonly IntPtr NativeMethodInfoPtr_get_value_Public_Virtual_get_Int32_0;

		// Token: 0x04000D29 RID: 3369
		private static readonly IntPtr NativeMethodInfoPtr_set_value_Public_Virtual_set_Void_Int32_0;

		// Token: 0x04000D2A RID: 3370
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Boolean_0;
	}
}
