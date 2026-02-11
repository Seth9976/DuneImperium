using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace TMPro
{
	// Token: 0x02000009 RID: 9
	public sealed class TMP_MaterialReference : ValueType
	{
		// Token: 0x06000052 RID: 82 RVA: 0x0000B43C File Offset: 0x0000963C
		// Note: this type is marked as 'beforefieldinit'.
		static TMP_MaterialReference()
		{
			Il2CppClassPointerStore<TMP_MaterialReference>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "TMP_MaterialReference");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_MaterialReference>.NativeClassPtr);
			TMP_MaterialReference.NativeFieldInfoPtr_material = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_MaterialReference>.NativeClassPtr, "material");
			TMP_MaterialReference.NativeFieldInfoPtr_referenceCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_MaterialReference>.NativeClassPtr, "referenceCount");
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00002244 File Offset: 0x00000444
		public TMP_MaterialReference(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000054 RID: 84 RVA: 0x0000224D File Offset: 0x0000044D
		public TMP_MaterialReference()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_MaterialReference>.NativeClassPtr))
		{
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000055 RID: 85 RVA: 0x0000B494 File Offset: 0x00009694
		// (set) Token: 0x06000056 RID: 86 RVA: 0x0000225F File Offset: 0x0000045F
		public unsafe Material material
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_MaterialReference.NativeFieldInfoPtr_material);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_MaterialReference.NativeFieldInfoPtr_material), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000057 RID: 87 RVA: 0x0000B4C4 File Offset: 0x000096C4
		// (set) Token: 0x06000058 RID: 88 RVA: 0x0000227E File Offset: 0x0000047E
		public unsafe int referenceCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_MaterialReference.NativeFieldInfoPtr_referenceCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_MaterialReference.NativeFieldInfoPtr_referenceCount)) = value;
			}
		}

		// Token: 0x04000037 RID: 55
		private static readonly IntPtr NativeFieldInfoPtr_material;

		// Token: 0x04000038 RID: 56
		private static readonly IntPtr NativeFieldInfoPtr_referenceCount;
	}
}
