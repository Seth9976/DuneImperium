using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.Rendering
{
	// Token: 0x02000108 RID: 264
	[Serializable]
	public class Vector3Parameter : VolumeParameter<Vector3>
	{
		// Token: 0x060011DD RID: 4573 RVA: 0x000513EC File Offset: 0x0004F5EC
		// Note: this type is marked as 'beforefieldinit'.
		static Vector3Parameter()
		{
			Il2CppClassPointerStore<Vector3Parameter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "Vector3Parameter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Vector3Parameter>.NativeClassPtr);
			Vector3Parameter.NativeMethodInfoPtr__ctor_Public_Void_Vector3_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3Parameter>.NativeClassPtr, 100665911);
			Vector3Parameter.NativeMethodInfoPtr_Interp_Public_Virtual_Void_Vector3_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3Parameter>.NativeClassPtr, 100665912);
		}

		// Token: 0x060011DE RID: 4574 RVA: 0x00051444 File Offset: 0x0004F644
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 979020, XrefRangeEnd = 979023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3Parameter(Vector3 value, bool overrideState = false)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Vector3Parameter>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref overrideState;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3Parameter.NativeMethodInfoPtr__ctor_Public_Void_Vector3_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011DF RID: 4575 RVA: 0x0005149C File Offset: 0x0004F69C
		[CallerCount(0)]
		public unsafe override void Interp(Vector3 from, Vector3 to, float t)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Vector3Parameter.NativeMethodInfoPtr_Interp_Public_Virtual_Void_Vector3_Vector3_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011E0 RID: 4576 RVA: 0x00009402 File Offset: 0x00007602
		public Vector3Parameter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000D6B RID: 3435
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Vector3_Boolean_0;

		// Token: 0x04000D6C RID: 3436
		private static readonly IntPtr NativeMethodInfoPtr_Interp_Public_Virtual_Void_Vector3_Vector3_Single_0;
	}
}
