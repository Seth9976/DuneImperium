using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace TMPro
{
	// Token: 0x02000033 RID: 51
	[Serializable]
	public sealed class TMP_FontWeightPair : ValueType
	{
		// Token: 0x06000586 RID: 1414 RVA: 0x0001BA60 File Offset: 0x00019C60
		// Note: this type is marked as 'beforefieldinit'.
		static TMP_FontWeightPair()
		{
			Il2CppClassPointerStore<TMP_FontWeightPair>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "TMP_FontWeightPair");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_FontWeightPair>.NativeClassPtr);
			TMP_FontWeightPair.NativeFieldInfoPtr_regularTypeface = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontWeightPair>.NativeClassPtr, "regularTypeface");
			TMP_FontWeightPair.NativeFieldInfoPtr_italicTypeface = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontWeightPair>.NativeClassPtr, "italicTypeface");
		}

		// Token: 0x06000587 RID: 1415 RVA: 0x00004C9E File Offset: 0x00002E9E
		public TMP_FontWeightPair(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000588 RID: 1416 RVA: 0x00004CA7 File Offset: 0x00002EA7
		public TMP_FontWeightPair()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_FontWeightPair>.NativeClassPtr))
		{
		}

		// Token: 0x170001EC RID: 492
		// (get) Token: 0x06000589 RID: 1417 RVA: 0x0001BAB8 File Offset: 0x00019CB8
		// (set) Token: 0x0600058A RID: 1418 RVA: 0x00004CB9 File Offset: 0x00002EB9
		public unsafe TMP_FontAsset regularTypeface
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontWeightPair.NativeFieldInfoPtr_regularTypeface);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_FontAsset>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontWeightPair.NativeFieldInfoPtr_regularTypeface), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001ED RID: 493
		// (get) Token: 0x0600058B RID: 1419 RVA: 0x0001BAE8 File Offset: 0x00019CE8
		// (set) Token: 0x0600058C RID: 1420 RVA: 0x00004CD8 File Offset: 0x00002ED8
		public unsafe TMP_FontAsset italicTypeface
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontWeightPair.NativeFieldInfoPtr_italicTypeface);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_FontAsset>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontWeightPair.NativeFieldInfoPtr_italicTypeface), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040003F5 RID: 1013
		private static readonly IntPtr NativeFieldInfoPtr_regularTypeface;

		// Token: 0x040003F6 RID: 1014
		private static readonly IntPtr NativeFieldInfoPtr_italicTypeface;
	}
}
