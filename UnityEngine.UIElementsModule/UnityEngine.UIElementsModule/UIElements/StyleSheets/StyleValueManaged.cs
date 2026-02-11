using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements.StyleSheets
{
	// Token: 0x02000290 RID: 656
	public sealed class StyleValueManaged : ValueType
	{
		// Token: 0x060030E1 RID: 12513 RVA: 0x000CF7BC File Offset: 0x000CD9BC
		// Note: this type is marked as 'beforefieldinit'.
		static StyleValueManaged()
		{
			Il2CppClassPointerStore<StyleValueManaged>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements.StyleSheets", "StyleValueManaged");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StyleValueManaged>.NativeClassPtr);
			StyleValueManaged.NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleValueManaged>.NativeClassPtr, "id");
			StyleValueManaged.NativeFieldInfoPtr_keyword = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleValueManaged>.NativeClassPtr, "keyword");
			StyleValueManaged.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleValueManaged>.NativeClassPtr, "value");
		}

		// Token: 0x060030E2 RID: 12514 RVA: 0x00013F77 File Offset: 0x00012177
		public StyleValueManaged(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060030E3 RID: 12515 RVA: 0x00013F80 File Offset: 0x00012180
		public StyleValueManaged()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StyleValueManaged>.NativeClassPtr))
		{
		}

		// Token: 0x17000F5F RID: 3935
		// (get) Token: 0x060030E4 RID: 12516 RVA: 0x000CF828 File Offset: 0x000CDA28
		// (set) Token: 0x060030E5 RID: 12517 RVA: 0x00013F92 File Offset: 0x00012192
		public unsafe StylePropertyId id
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleValueManaged.NativeFieldInfoPtr_id);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleValueManaged.NativeFieldInfoPtr_id)) = value;
			}
		}

		// Token: 0x17000F60 RID: 3936
		// (get) Token: 0x060030E6 RID: 12518 RVA: 0x000CF850 File Offset: 0x000CDA50
		// (set) Token: 0x060030E7 RID: 12519 RVA: 0x00013FAD File Offset: 0x000121AD
		public unsafe StyleKeyword keyword
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleValueManaged.NativeFieldInfoPtr_keyword);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleValueManaged.NativeFieldInfoPtr_keyword)) = value;
			}
		}

		// Token: 0x17000F61 RID: 3937
		// (get) Token: 0x060030E8 RID: 12520 RVA: 0x000CF878 File Offset: 0x000CDA78
		// (set) Token: 0x060030E9 RID: 12521 RVA: 0x00013FC8 File Offset: 0x000121C8
		public unsafe Object value
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleValueManaged.NativeFieldInfoPtr_value);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleValueManaged.NativeFieldInfoPtr_value), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040023B9 RID: 9145
		private static readonly IntPtr NativeFieldInfoPtr_id;

		// Token: 0x040023BA RID: 9146
		private static readonly IntPtr NativeFieldInfoPtr_keyword;

		// Token: 0x040023BB RID: 9147
		private static readonly IntPtr NativeFieldInfoPtr_value;
	}
}
