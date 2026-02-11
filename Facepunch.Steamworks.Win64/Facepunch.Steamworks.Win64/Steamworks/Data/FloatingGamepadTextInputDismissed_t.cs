using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x0200010A RID: 266
	[StructLayout(2)]
	public struct FloatingGamepadTextInputDismissed_t
	{
		// Token: 0x06000FC0 RID: 4032 RVA: 0x0005E09C File Offset: 0x0005C29C
		// Note: this type is marked as 'beforefieldinit'.
		static FloatingGamepadTextInputDismissed_t()
		{
			Il2CppClassPointerStore<FloatingGamepadTextInputDismissed_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "FloatingGamepadTextInputDismissed_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FloatingGamepadTextInputDismissed_t>.NativeClassPtr);
			FloatingGamepadTextInputDismissed_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FloatingGamepadTextInputDismissed_t>.NativeClassPtr, "_datasize");
			FloatingGamepadTextInputDismissed_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatingGamepadTextInputDismissed_t>.NativeClassPtr, 100666858);
			FloatingGamepadTextInputDismissed_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatingGamepadTextInputDismissed_t>.NativeClassPtr, 100666859);
		}

		// Token: 0x1700029E RID: 670
		// (get) Token: 0x06000FC1 RID: 4033 RVA: 0x0005E108 File Offset: 0x0005C308
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950307, XrefRangeEnd = 950311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FloatingGamepadTextInputDismissed_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700029F RID: 671
		// (get) Token: 0x06000FC2 RID: 4034 RVA: 0x0005E138 File Offset: 0x0005C338
		public unsafe CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FloatingGamepadTextInputDismissed_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FC3 RID: 4035 RVA: 0x00004596 File Offset: 0x00002796
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FloatingGamepadTextInputDismissed_t>.NativeClassPtr, ref this));
		}

		// Token: 0x1700029D RID: 669
		// (get) Token: 0x06000FC4 RID: 4036 RVA: 0x0005E168 File Offset: 0x0005C368
		// (set) Token: 0x06000FC5 RID: 4037 RVA: 0x000045A8 File Offset: 0x000027A8
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(FloatingGamepadTextInputDismissed_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FloatingGamepadTextInputDismissed_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x040015E9 RID: 5609
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x040015EA RID: 5610
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x040015EB RID: 5611
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;
	}
}
