using System;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Globalization
{
	// Token: 0x02000491 RID: 1169
	public sealed class InternalEncodingDataItem : ValueType
	{
		// Token: 0x06004841 RID: 18497 RVA: 0x00150DF0 File Offset: 0x0014EFF0
		// Note: this type is marked as 'beforefieldinit'.
		static InternalEncodingDataItem()
		{
			Il2CppClassPointerStore<InternalEncodingDataItem>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Globalization", "InternalEncodingDataItem");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InternalEncodingDataItem>.NativeClassPtr);
			InternalEncodingDataItem.NativeFieldInfoPtr_webName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalEncodingDataItem>.NativeClassPtr, "webName");
			InternalEncodingDataItem.NativeFieldInfoPtr_codePage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalEncodingDataItem>.NativeClassPtr, "codePage");
		}

		// Token: 0x06004842 RID: 18498 RVA: 0x0001A402 File Offset: 0x00018602
		public InternalEncodingDataItem(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06004843 RID: 18499 RVA: 0x0001A40B File Offset: 0x0001860B
		public InternalEncodingDataItem()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InternalEncodingDataItem>.NativeClassPtr))
		{
		}

		// Token: 0x1700124C RID: 4684
		// (get) Token: 0x06004844 RID: 18500 RVA: 0x00150E48 File Offset: 0x0014F048
		// (set) Token: 0x06004845 RID: 18501 RVA: 0x0001A41D File Offset: 0x0001861D
		public unsafe string webName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalEncodingDataItem.NativeFieldInfoPtr_webName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalEncodingDataItem.NativeFieldInfoPtr_webName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700124D RID: 4685
		// (get) Token: 0x06004846 RID: 18502 RVA: 0x00150E70 File Offset: 0x0014F070
		// (set) Token: 0x06004847 RID: 18503 RVA: 0x0001A43C File Offset: 0x0001863C
		public unsafe ushort codePage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalEncodingDataItem.NativeFieldInfoPtr_codePage);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalEncodingDataItem.NativeFieldInfoPtr_codePage)) = value;
			}
		}

		// Token: 0x04003B7C RID: 15228
		private static readonly IntPtr NativeFieldInfoPtr_webName;

		// Token: 0x04003B7D RID: 15229
		private static readonly IntPtr NativeFieldInfoPtr_codePage;
	}
}
