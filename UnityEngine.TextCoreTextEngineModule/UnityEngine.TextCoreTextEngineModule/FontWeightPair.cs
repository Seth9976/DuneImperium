using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.TextCore.Text
{
	// Token: 0x02000005 RID: 5
	[Serializable]
	public sealed class FontWeightPair : ValueType
	{
		// Token: 0x0600000D RID: 13 RVA: 0x00006938 File Offset: 0x00004B38
		// Note: this type is marked as 'beforefieldinit'.
		static FontWeightPair()
		{
			Il2CppClassPointerStore<FontWeightPair>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.TextCoreTextEngineModule.dll", "UnityEngine.TextCore.Text", "FontWeightPair");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FontWeightPair>.NativeClassPtr);
			FontWeightPair.NativeFieldInfoPtr_regularTypeface = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontWeightPair>.NativeClassPtr, "regularTypeface");
			FontWeightPair.NativeFieldInfoPtr_italicTypeface = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontWeightPair>.NativeClassPtr, "italicTypeface");
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00002062 File Offset: 0x00000262
		public FontWeightPair(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600000F RID: 15 RVA: 0x0000206B File Offset: 0x0000026B
		public FontWeightPair()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FontWeightPair>.NativeClassPtr))
		{
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000010 RID: 16 RVA: 0x00006990 File Offset: 0x00004B90
		// (set) Token: 0x06000011 RID: 17 RVA: 0x0000207D File Offset: 0x0000027D
		public unsafe FontAsset regularTypeface
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontWeightPair.NativeFieldInfoPtr_regularTypeface);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FontAsset>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontWeightPair.NativeFieldInfoPtr_regularTypeface), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000012 RID: 18 RVA: 0x000069C0 File Offset: 0x00004BC0
		// (set) Token: 0x06000013 RID: 19 RVA: 0x0000209C File Offset: 0x0000029C
		public unsafe FontAsset italicTypeface
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontWeightPair.NativeFieldInfoPtr_italicTypeface);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FontAsset>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontWeightPair.NativeFieldInfoPtr_italicTypeface), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000010 RID: 16
		private static readonly IntPtr NativeFieldInfoPtr_regularTypeface;

		// Token: 0x04000011 RID: 17
		private static readonly IntPtr NativeFieldInfoPtr_italicTypeface;
	}
}
