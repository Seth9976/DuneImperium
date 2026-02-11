using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements.UIR
{
	// Token: 0x02000266 RID: 614
	public sealed class TextureEntry : ValueType
	{
		// Token: 0x06002D9E RID: 11678 RVA: 0x000C32AC File Offset: 0x000C14AC
		// Note: this type is marked as 'beforefieldinit'.
		static TextureEntry()
		{
			Il2CppClassPointerStore<TextureEntry>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements.UIR", "TextureEntry");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextureEntry>.NativeClassPtr);
			TextureEntry.NativeFieldInfoPtr_source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureEntry>.NativeClassPtr, "source");
			TextureEntry.NativeFieldInfoPtr_actual = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureEntry>.NativeClassPtr, "actual");
			TextureEntry.NativeFieldInfoPtr_replaced = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureEntry>.NativeClassPtr, "replaced");
		}

		// Token: 0x06002D9F RID: 11679 RVA: 0x00012B8D File Offset: 0x00010D8D
		public TextureEntry(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06002DA0 RID: 11680 RVA: 0x00012B96 File Offset: 0x00010D96
		public TextureEntry()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextureEntry>.NativeClassPtr))
		{
		}

		// Token: 0x17000E46 RID: 3654
		// (get) Token: 0x06002DA1 RID: 11681 RVA: 0x000C3318 File Offset: 0x000C1518
		// (set) Token: 0x06002DA2 RID: 11682 RVA: 0x00012BA8 File Offset: 0x00010DA8
		public unsafe Texture source
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextureEntry.NativeFieldInfoPtr_source);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextureEntry.NativeFieldInfoPtr_source), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E47 RID: 3655
		// (get) Token: 0x06002DA3 RID: 11683 RVA: 0x000C3348 File Offset: 0x000C1548
		// (set) Token: 0x06002DA4 RID: 11684 RVA: 0x00012BC7 File Offset: 0x00010DC7
		public unsafe TextureId actual
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextureEntry.NativeFieldInfoPtr_actual);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextureEntry.NativeFieldInfoPtr_actual)) = value;
			}
		}

		// Token: 0x17000E48 RID: 3656
		// (get) Token: 0x06002DA5 RID: 11685 RVA: 0x000C3370 File Offset: 0x000C1570
		// (set) Token: 0x06002DA6 RID: 11686 RVA: 0x00012BE2 File Offset: 0x00010DE2
		public unsafe bool replaced
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextureEntry.NativeFieldInfoPtr_replaced);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextureEntry.NativeFieldInfoPtr_replaced)) = value;
			}
		}

		// Token: 0x040020DB RID: 8411
		private static readonly IntPtr NativeFieldInfoPtr_source;

		// Token: 0x040020DC RID: 8412
		private static readonly IntPtr NativeFieldInfoPtr_actual;

		// Token: 0x040020DD RID: 8413
		private static readonly IntPtr NativeFieldInfoPtr_replaced;
	}
}
