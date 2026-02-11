using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements.StyleSheets
{
	// Token: 0x02000286 RID: 646
	public sealed class StylePropertyValue : ValueType
	{
		// Token: 0x06003050 RID: 12368 RVA: 0x000CD250 File Offset: 0x000CB450
		// Note: this type is marked as 'beforefieldinit'.
		static StylePropertyValue()
		{
			Il2CppClassPointerStore<StylePropertyValue>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements.StyleSheets", "StylePropertyValue");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StylePropertyValue>.NativeClassPtr);
			StylePropertyValue.NativeFieldInfoPtr_sheet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StylePropertyValue>.NativeClassPtr, "sheet");
			StylePropertyValue.NativeFieldInfoPtr_handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StylePropertyValue>.NativeClassPtr, "handle");
		}

		// Token: 0x06003051 RID: 12369 RVA: 0x00013C03 File Offset: 0x00011E03
		public StylePropertyValue(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06003052 RID: 12370 RVA: 0x00013C0C File Offset: 0x00011E0C
		public StylePropertyValue()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StylePropertyValue>.NativeClassPtr))
		{
		}

		// Token: 0x17000F42 RID: 3906
		// (get) Token: 0x06003053 RID: 12371 RVA: 0x000CD2A8 File Offset: 0x000CB4A8
		// (set) Token: 0x06003054 RID: 12372 RVA: 0x00013C1E File Offset: 0x00011E1E
		public unsafe StyleSheet sheet
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StylePropertyValue.NativeFieldInfoPtr_sheet);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StyleSheet>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StylePropertyValue.NativeFieldInfoPtr_sheet), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F43 RID: 3907
		// (get) Token: 0x06003055 RID: 12373 RVA: 0x000CD2D8 File Offset: 0x000CB4D8
		// (set) Token: 0x06003056 RID: 12374 RVA: 0x00013C3D File Offset: 0x00011E3D
		public unsafe StyleValueHandle handle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StylePropertyValue.NativeFieldInfoPtr_handle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StylePropertyValue.NativeFieldInfoPtr_handle)) = value;
			}
		}

		// Token: 0x04002345 RID: 9029
		private static readonly IntPtr NativeFieldInfoPtr_sheet;

		// Token: 0x04002346 RID: 9030
		private static readonly IntPtr NativeFieldInfoPtr_handle;
	}
}
