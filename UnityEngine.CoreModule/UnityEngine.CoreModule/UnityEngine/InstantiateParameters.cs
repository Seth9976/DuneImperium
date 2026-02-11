using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.SceneManagement;

namespace UnityEngine
{
	// Token: 0x02000157 RID: 343
	public sealed class InstantiateParameters : ValueType
	{
		// Token: 0x06001954 RID: 6484 RVA: 0x00076C0C File Offset: 0x00074E0C
		// Note: this type is marked as 'beforefieldinit'.
		static InstantiateParameters()
		{
			Il2CppClassPointerStore<InstantiateParameters>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "InstantiateParameters");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InstantiateParameters>.NativeClassPtr);
			InstantiateParameters.NativeFieldInfoPtr_parent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstantiateParameters>.NativeClassPtr, "parent");
			InstantiateParameters.NativeFieldInfoPtr_scene = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstantiateParameters>.NativeClassPtr, "scene");
			InstantiateParameters.NativeFieldInfoPtr_worldSpace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstantiateParameters>.NativeClassPtr, "worldSpace");
		}

		// Token: 0x06001955 RID: 6485 RVA: 0x00009DEE File Offset: 0x00007FEE
		public InstantiateParameters(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06001956 RID: 6486 RVA: 0x00009DF7 File Offset: 0x00007FF7
		public InstantiateParameters()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InstantiateParameters>.NativeClassPtr))
		{
		}

		// Token: 0x1700051F RID: 1311
		// (get) Token: 0x06001957 RID: 6487 RVA: 0x00076C78 File Offset: 0x00074E78
		// (set) Token: 0x06001958 RID: 6488 RVA: 0x00009E09 File Offset: 0x00008009
		public unsafe Transform parent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InstantiateParameters.NativeFieldInfoPtr_parent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InstantiateParameters.NativeFieldInfoPtr_parent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000520 RID: 1312
		// (get) Token: 0x06001959 RID: 6489 RVA: 0x00076CA8 File Offset: 0x00074EA8
		// (set) Token: 0x0600195A RID: 6490 RVA: 0x00009E28 File Offset: 0x00008028
		public unsafe UnityEngine.SceneManagement.Scene scene
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InstantiateParameters.NativeFieldInfoPtr_scene);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InstantiateParameters.NativeFieldInfoPtr_scene)) = value;
			}
		}

		// Token: 0x17000521 RID: 1313
		// (get) Token: 0x0600195B RID: 6491 RVA: 0x00076CD0 File Offset: 0x00074ED0
		// (set) Token: 0x0600195C RID: 6492 RVA: 0x00009E43 File Offset: 0x00008043
		public unsafe bool worldSpace
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InstantiateParameters.NativeFieldInfoPtr_worldSpace);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InstantiateParameters.NativeFieldInfoPtr_worldSpace)) = value;
			}
		}

		// Token: 0x04001699 RID: 5785
		private static readonly IntPtr NativeFieldInfoPtr_parent;

		// Token: 0x0400169A RID: 5786
		private static readonly IntPtr NativeFieldInfoPtr_scene;

		// Token: 0x0400169B RID: 5787
		private static readonly IntPtr NativeFieldInfoPtr_worldSpace;
	}
}
