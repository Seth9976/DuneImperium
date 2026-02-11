using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering.LookDev
{
	// Token: 0x0200011B RID: 283
	public sealed class Sky : ValueType
	{
		// Token: 0x0600125E RID: 4702 RVA: 0x000535FC File Offset: 0x000517FC
		// Note: this type is marked as 'beforefieldinit'.
		static Sky()
		{
			Il2CppClassPointerStore<Sky>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering.LookDev", "Sky");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Sky>.NativeClassPtr);
			Sky.NativeFieldInfoPtr_cubemap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sky>.NativeClassPtr, "cubemap");
			Sky.NativeFieldInfoPtr_longitudeOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sky>.NativeClassPtr, "longitudeOffset");
			Sky.NativeFieldInfoPtr_exposure = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sky>.NativeClassPtr, "exposure");
		}

		// Token: 0x0600125F RID: 4703 RVA: 0x00009641 File Offset: 0x00007841
		public Sky(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06001260 RID: 4704 RVA: 0x0000964A File Offset: 0x0000784A
		public Sky()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Sky>.NativeClassPtr))
		{
		}

		// Token: 0x17000542 RID: 1346
		// (get) Token: 0x06001261 RID: 4705 RVA: 0x00053668 File Offset: 0x00051868
		// (set) Token: 0x06001262 RID: 4706 RVA: 0x0000965C File Offset: 0x0000785C
		public unsafe Cubemap cubemap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sky.NativeFieldInfoPtr_cubemap);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Cubemap>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sky.NativeFieldInfoPtr_cubemap), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000543 RID: 1347
		// (get) Token: 0x06001263 RID: 4707 RVA: 0x00053698 File Offset: 0x00051898
		// (set) Token: 0x06001264 RID: 4708 RVA: 0x0000967B File Offset: 0x0000787B
		public unsafe float longitudeOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sky.NativeFieldInfoPtr_longitudeOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sky.NativeFieldInfoPtr_longitudeOffset)) = value;
			}
		}

		// Token: 0x17000544 RID: 1348
		// (get) Token: 0x06001265 RID: 4709 RVA: 0x000536C0 File Offset: 0x000518C0
		// (set) Token: 0x06001266 RID: 4710 RVA: 0x00009696 File Offset: 0x00007896
		public unsafe float exposure
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sky.NativeFieldInfoPtr_exposure);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sky.NativeFieldInfoPtr_exposure)) = value;
			}
		}

		// Token: 0x04000DBD RID: 3517
		private static readonly IntPtr NativeFieldInfoPtr_cubemap;

		// Token: 0x04000DBE RID: 3518
		private static readonly IntPtr NativeFieldInfoPtr_longitudeOffset;

		// Token: 0x04000DBF RID: 3519
		private static readonly IntPtr NativeFieldInfoPtr_exposure;
	}
}
