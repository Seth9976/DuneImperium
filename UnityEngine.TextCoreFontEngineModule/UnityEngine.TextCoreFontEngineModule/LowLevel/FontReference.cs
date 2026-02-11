using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.TextCore.LowLevel
{
	// Token: 0x0200000B RID: 11
	public sealed class FontReference : ValueType
	{
		// Token: 0x0600009C RID: 156 RVA: 0x00004F6C File Offset: 0x0000316C
		// Note: this type is marked as 'beforefieldinit'.
		static FontReference()
		{
			Il2CppClassPointerStore<FontReference>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.TextCoreFontEngineModule.dll", "UnityEngine.TextCore.LowLevel", "FontReference");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FontReference>.NativeClassPtr);
			FontReference.NativeFieldInfoPtr_familyName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontReference>.NativeClassPtr, "familyName");
			FontReference.NativeFieldInfoPtr_styleName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontReference>.NativeClassPtr, "styleName");
			FontReference.NativeFieldInfoPtr_faceIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontReference>.NativeClassPtr, "faceIndex");
			FontReference.NativeFieldInfoPtr_filePath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontReference>.NativeClassPtr, "filePath");
		}

		// Token: 0x0600009D RID: 157 RVA: 0x000023FF File Offset: 0x000005FF
		public FontReference(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600009E RID: 158 RVA: 0x00002408 File Offset: 0x00000608
		public FontReference()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FontReference>.NativeClassPtr))
		{
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x0600009F RID: 159 RVA: 0x00004FEC File Offset: 0x000031EC
		// (set) Token: 0x060000A0 RID: 160 RVA: 0x0000241A File Offset: 0x0000061A
		public unsafe string familyName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontReference.NativeFieldInfoPtr_familyName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontReference.NativeFieldInfoPtr_familyName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x060000A1 RID: 161 RVA: 0x00005014 File Offset: 0x00003214
		// (set) Token: 0x060000A2 RID: 162 RVA: 0x00002439 File Offset: 0x00000639
		public unsafe string styleName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontReference.NativeFieldInfoPtr_styleName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontReference.NativeFieldInfoPtr_styleName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x060000A3 RID: 163 RVA: 0x0000503C File Offset: 0x0000323C
		// (set) Token: 0x060000A4 RID: 164 RVA: 0x00002458 File Offset: 0x00000658
		public unsafe int faceIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontReference.NativeFieldInfoPtr_faceIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontReference.NativeFieldInfoPtr_faceIndex)) = value;
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x060000A5 RID: 165 RVA: 0x00005064 File Offset: 0x00003264
		// (set) Token: 0x060000A6 RID: 166 RVA: 0x00002473 File Offset: 0x00000673
		public unsafe string filePath
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontReference.NativeFieldInfoPtr_filePath);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontReference.NativeFieldInfoPtr_filePath), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040000A9 RID: 169
		private static readonly IntPtr NativeFieldInfoPtr_familyName;

		// Token: 0x040000AA RID: 170
		private static readonly IntPtr NativeFieldInfoPtr_styleName;

		// Token: 0x040000AB RID: 171
		private static readonly IntPtr NativeFieldInfoPtr_faceIndex;

		// Token: 0x040000AC RID: 172
		private static readonly IntPtr NativeFieldInfoPtr_filePath;
	}
}
