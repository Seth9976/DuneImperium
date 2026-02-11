using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.Rendering
{
	// Token: 0x0200010A RID: 266
	[Serializable]
	public class Vector4Parameter : VolumeParameter<Vector4>
	{
		// Token: 0x060011E4 RID: 4580 RVA: 0x0005155C File Offset: 0x0004F75C
		// Note: this type is marked as 'beforefieldinit'.
		static Vector4Parameter()
		{
			Il2CppClassPointerStore<Vector4Parameter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "Vector4Parameter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Vector4Parameter>.NativeClassPtr);
			Vector4Parameter.NativeMethodInfoPtr__ctor_Public_Void_Vector4_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector4Parameter>.NativeClassPtr, 100665914);
			Vector4Parameter.NativeMethodInfoPtr_Interp_Public_Virtual_Void_Vector4_Vector4_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector4Parameter>.NativeClassPtr, 100665915);
		}

		// Token: 0x060011E5 RID: 4581 RVA: 0x000515B4 File Offset: 0x0004F7B4
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 979029, RefRangeEnd = 979035, XrefRangeStart = 979026, XrefRangeEnd = 979029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector4Parameter(Vector4 value, bool overrideState = false)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Vector4Parameter>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref overrideState;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector4Parameter.NativeMethodInfoPtr__ctor_Public_Void_Vector4_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011E6 RID: 4582 RVA: 0x0005160C File Offset: 0x0004F80C
		[CallerCount(0)]
		public unsafe override void Interp(Vector4 from, Vector4 to, float t)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Vector4Parameter.NativeMethodInfoPtr_Interp_Public_Virtual_Void_Vector4_Vector4_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011E7 RID: 4583 RVA: 0x0000944D File Offset: 0x0000764D
		public Vector4Parameter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000D6E RID: 3438
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Vector4_Boolean_0;

		// Token: 0x04000D6F RID: 3439
		private static readonly IntPtr NativeMethodInfoPtr_Interp_Public_Virtual_Void_Vector4_Vector4_Single_0;
	}
}
