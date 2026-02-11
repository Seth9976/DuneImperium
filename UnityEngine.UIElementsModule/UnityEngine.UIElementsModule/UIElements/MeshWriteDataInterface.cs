using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x0200014E RID: 334
	[StructLayout(2)]
	public struct MeshWriteDataInterface
	{
		// Token: 0x06001874 RID: 6260 RVA: 0x00073A54 File Offset: 0x00071C54
		// Note: this type is marked as 'beforefieldinit'.
		static MeshWriteDataInterface()
		{
			Il2CppClassPointerStore<MeshWriteDataInterface>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "MeshWriteDataInterface");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MeshWriteDataInterface>.NativeClassPtr);
			MeshWriteDataInterface.NativeFieldInfoPtr_vertices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshWriteDataInterface>.NativeClassPtr, "vertices");
			MeshWriteDataInterface.NativeFieldInfoPtr_indices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshWriteDataInterface>.NativeClassPtr, "indices");
			MeshWriteDataInterface.NativeFieldInfoPtr_vertexCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshWriteDataInterface>.NativeClassPtr, "vertexCount");
			MeshWriteDataInterface.NativeFieldInfoPtr_indexCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshWriteDataInterface>.NativeClassPtr, "indexCount");
		}

		// Token: 0x06001875 RID: 6261 RVA: 0x0000B34E File Offset: 0x0000954E
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MeshWriteDataInterface>.NativeClassPtr, ref this));
		}

		// Token: 0x06001876 RID: 6262 RVA: 0x0000B360 File Offset: 0x00009560
		public static MeshWriteDataInterface FromMeshWriteData(MeshWriteData data)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x040010C8 RID: 4296
		private static readonly IntPtr NativeFieldInfoPtr_vertices;

		// Token: 0x040010C9 RID: 4297
		private static readonly IntPtr NativeFieldInfoPtr_indices;

		// Token: 0x040010CA RID: 4298
		private static readonly IntPtr NativeFieldInfoPtr_vertexCount;

		// Token: 0x040010CB RID: 4299
		private static readonly IntPtr NativeFieldInfoPtr_indexCount;

		// Token: 0x040010CC RID: 4300
		[FieldOffset(0)]
		public IntPtr vertices;

		// Token: 0x040010CD RID: 4301
		[FieldOffset(8)]
		public IntPtr indices;

		// Token: 0x040010CE RID: 4302
		[FieldOffset(16)]
		public int vertexCount;

		// Token: 0x040010CF RID: 4303
		[FieldOffset(20)]
		public int indexCount;
	}
}
