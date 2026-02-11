using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine
{
	// Token: 0x020000AE RID: 174
	public sealed class Skybox : Behaviour
	{
		// Token: 0x06000E8F RID: 3727 RVA: 0x00048548 File Offset: 0x00046748
		// Note: this type is marked as 'beforefieldinit'.
		static Skybox()
		{
			Il2CppClassPointerStore<Skybox>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "Skybox");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Skybox>.NativeClassPtr);
			Skybox.NativeMethodInfoPtr_get_material_Public_get_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skybox>.NativeClassPtr, 100665150);
			Skybox.set_materialDelegateField = IL2CPP.ResolveICall<Skybox.set_materialDelegate>("UnityEngine.Skybox::set_material");
		}

		// Token: 0x17000319 RID: 793
		// (get) Token: 0x06000E90 RID: 3728 RVA: 0x0004859C File Offset: 0x0004679C
		// (set) Token: 0x06000E92 RID: 3730 RVA: 0x0000715C File Offset: 0x0000535C
		public unsafe Material material
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 653605, RefRangeEnd = 653606, XrefRangeStart = 653603, XrefRangeEnd = 653605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skybox.NativeMethodInfoPtr_get_material_Public_get_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
			}
			set
			{
				Skybox.set_materialDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x06000E91 RID: 3729 RVA: 0x00007153 File Offset: 0x00005353
		public Skybox(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000B95 RID: 2965
		private static readonly IntPtr NativeMethodInfoPtr_get_material_Public_get_Material_0;

		// Token: 0x04000B96 RID: 2966
		private static readonly Skybox.set_materialDelegate set_materialDelegateField;

		// Token: 0x02000618 RID: 1560
		// (Invoke) Token: 0x0600353B RID: 13627
		private delegate void set_materialDelegate(IntPtr @this, IntPtr value);
	}
}
