using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.Rendering
{
	// Token: 0x020000F2 RID: 242
	[Serializable]
	public class IntParameter : VolumeParameter<int>
	{
		// Token: 0x06001144 RID: 4420 RVA: 0x0004F26C File Offset: 0x0004D46C
		// Note: this type is marked as 'beforefieldinit'.
		static IntParameter()
		{
			Il2CppClassPointerStore<IntParameter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "IntParameter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IntParameter>.NativeClassPtr);
			IntParameter.NativeMethodInfoPtr__ctor_Public_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntParameter>.NativeClassPtr, 100665854);
			IntParameter.NativeMethodInfoPtr_Interp_Public_Virtual_Final_Void_Int32_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntParameter>.NativeClassPtr, 100665855);
		}

		// Token: 0x06001145 RID: 4421 RVA: 0x0004F2C4 File Offset: 0x0004D4C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 978893, XrefRangeEnd = 978896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IntParameter(int value, bool overrideState = false)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IntParameter>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref overrideState;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntParameter.NativeMethodInfoPtr__ctor_Public_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001146 RID: 4422 RVA: 0x0004F31C File Offset: 0x0004D51C
		[CallerCount(0)]
		public unsafe override void Interp(int from, int to, float t)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntParameter.NativeMethodInfoPtr_Interp_Public_Virtual_Final_Void_Int32_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001147 RID: 4423 RVA: 0x00008FD3 File Offset: 0x000071D3
		public IntParameter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000D18 RID: 3352
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Boolean_0;

		// Token: 0x04000D19 RID: 3353
		private static readonly IntPtr NativeMethodInfoPtr_Interp_Public_Virtual_Final_Void_Int32_Int32_Single_0;
	}
}
