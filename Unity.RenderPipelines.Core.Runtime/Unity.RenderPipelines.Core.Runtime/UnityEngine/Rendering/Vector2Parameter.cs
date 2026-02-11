using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.Rendering
{
	// Token: 0x02000106 RID: 262
	[Serializable]
	public class Vector2Parameter : VolumeParameter<Vector2>
	{
		// Token: 0x060011D6 RID: 4566 RVA: 0x0005127C File Offset: 0x0004F47C
		// Note: this type is marked as 'beforefieldinit'.
		static Vector2Parameter()
		{
			Il2CppClassPointerStore<Vector2Parameter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "Vector2Parameter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Vector2Parameter>.NativeClassPtr);
			Vector2Parameter.NativeMethodInfoPtr__ctor_Public_Void_Vector2_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2Parameter>.NativeClassPtr, 100665908);
			Vector2Parameter.NativeMethodInfoPtr_Interp_Public_Virtual_Void_Vector2_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2Parameter>.NativeClassPtr, 100665909);
		}

		// Token: 0x060011D7 RID: 4567 RVA: 0x000512D4 File Offset: 0x0004F4D4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 979015, RefRangeEnd = 979017, XrefRangeStart = 979012, XrefRangeEnd = 979015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector2Parameter(Vector2 value, bool overrideState = false)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Vector2Parameter>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref overrideState;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2Parameter.NativeMethodInfoPtr__ctor_Public_Void_Vector2_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011D8 RID: 4568 RVA: 0x0005132C File Offset: 0x0004F52C
		[CallerCount(0)]
		public unsafe override void Interp(Vector2 from, Vector2 to, float t)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Vector2Parameter.NativeMethodInfoPtr_Interp_Public_Virtual_Void_Vector2_Vector2_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011D9 RID: 4569 RVA: 0x000093B7 File Offset: 0x000075B7
		public Vector2Parameter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000D68 RID: 3432
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Vector2_Boolean_0;

		// Token: 0x04000D69 RID: 3433
		private static readonly IntPtr NativeMethodInfoPtr_Interp_Public_Virtual_Void_Vector2_Vector2_Single_0;
	}
}
