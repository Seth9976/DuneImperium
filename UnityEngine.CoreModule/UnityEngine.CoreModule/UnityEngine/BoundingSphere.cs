using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000078 RID: 120
	[StructLayout(2)]
	public struct BoundingSphere
	{
		// Token: 0x06000590 RID: 1424 RVA: 0x00028908 File Offset: 0x00026B08
		// Note: this type is marked as 'beforefieldinit'.
		static BoundingSphere()
		{
			Il2CppClassPointerStore<BoundingSphere>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "BoundingSphere");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BoundingSphere>.NativeClassPtr);
			BoundingSphere.NativeFieldInfoPtr_position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoundingSphere>.NativeClassPtr, "position");
			BoundingSphere.NativeFieldInfoPtr_radius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoundingSphere>.NativeClassPtr, "radius");
			BoundingSphere.NativeMethodInfoPtr__ctor_Public_Void_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoundingSphere>.NativeClassPtr, 100664003);
		}

		// Token: 0x06000591 RID: 1425 RVA: 0x00028974 File Offset: 0x00026B74
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 646311, RefRangeEnd = 646313, XrefRangeStart = 646311, XrefRangeEnd = 646311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BoundingSphere(Vector3 pos, float rad)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rad;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoundingSphere.NativeMethodInfoPtr__ctor_Public_Void_Vector3_Single_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000592 RID: 1426 RVA: 0x000041E3 File Offset: 0x000023E3
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BoundingSphere>.NativeClassPtr, ref this));
		}

		// Token: 0x040004E1 RID: 1249
		private static readonly IntPtr NativeFieldInfoPtr_position;

		// Token: 0x040004E2 RID: 1250
		private static readonly IntPtr NativeFieldInfoPtr_radius;

		// Token: 0x040004E3 RID: 1251
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Vector3_Single_0;

		// Token: 0x040004E4 RID: 1252
		[FieldOffset(0)]
		public Vector3 position;

		// Token: 0x040004E5 RID: 1253
		[FieldOffset(12)]
		public float radius;
	}
}
