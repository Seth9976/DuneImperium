using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x0200014B RID: 331
	[StructLayout(2)]
	public struct NewUrlLaunchParameters_t
	{
		// Token: 0x060011E5 RID: 4581 RVA: 0x00063C6C File Offset: 0x00061E6C
		// Note: this type is marked as 'beforefieldinit'.
		static NewUrlLaunchParameters_t()
		{
			Il2CppClassPointerStore<NewUrlLaunchParameters_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "NewUrlLaunchParameters_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NewUrlLaunchParameters_t>.NativeClassPtr);
			NewUrlLaunchParameters_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewUrlLaunchParameters_t>.NativeClassPtr, "_datasize");
			NewUrlLaunchParameters_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewUrlLaunchParameters_t>.NativeClassPtr, 100667063);
			NewUrlLaunchParameters_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewUrlLaunchParameters_t>.NativeClassPtr, 100667064);
		}

		// Token: 0x170003A6 RID: 934
		// (get) Token: 0x060011E6 RID: 4582 RVA: 0x00063CD8 File Offset: 0x00061ED8
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950611, XrefRangeEnd = 950615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NewUrlLaunchParameters_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170003A7 RID: 935
		// (get) Token: 0x060011E7 RID: 4583 RVA: 0x00063D08 File Offset: 0x00061F08
		public unsafe CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NewUrlLaunchParameters_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060011E8 RID: 4584 RVA: 0x000055A8 File Offset: 0x000037A8
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NewUrlLaunchParameters_t>.NativeClassPtr, ref this));
		}

		// Token: 0x170003A5 RID: 933
		// (get) Token: 0x060011E9 RID: 4585 RVA: 0x00063D38 File Offset: 0x00061F38
		// (set) Token: 0x060011EA RID: 4586 RVA: 0x000055BA File Offset: 0x000037BA
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(NewUrlLaunchParameters_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NewUrlLaunchParameters_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x0400181D RID: 6173
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x0400181E RID: 6174
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x0400181F RID: 6175
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;
	}
}
