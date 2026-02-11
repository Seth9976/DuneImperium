using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering.Universal
{
	// Token: 0x0200006F RID: 111
	[StructLayout(2)]
	public struct DecalEntity
	{
		// Token: 0x0600098E RID: 2446 RVA: 0x00036604 File Offset: 0x00034804
		// Note: this type is marked as 'beforefieldinit'.
		static DecalEntity()
		{
			Il2CppClassPointerStore<DecalEntity>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "DecalEntity");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DecalEntity>.NativeClassPtr);
			DecalEntity.NativeFieldInfoPtr_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalEntity>.NativeClassPtr, "index");
			DecalEntity.NativeFieldInfoPtr_version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalEntity>.NativeClassPtr, "version");
		}

		// Token: 0x0600098F RID: 2447 RVA: 0x0000627E File Offset: 0x0000447E
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DecalEntity>.NativeClassPtr, ref this));
		}

		// Token: 0x0400072C RID: 1836
		private static readonly IntPtr NativeFieldInfoPtr_index;

		// Token: 0x0400072D RID: 1837
		private static readonly IntPtr NativeFieldInfoPtr_version;

		// Token: 0x0400072E RID: 1838
		[FieldOffset(0)]
		public int index;

		// Token: 0x0400072F RID: 1839
		[FieldOffset(4)]
		public int version;
	}
}
