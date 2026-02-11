using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x02000149 RID: 329
	[StructLayout(2)]
	public struct DlcInstalled_t
	{
		// Token: 0x060011D9 RID: 4569 RVA: 0x00063A60 File Offset: 0x00061C60
		// Note: this type is marked as 'beforefieldinit'.
		static DlcInstalled_t()
		{
			Il2CppClassPointerStore<DlcInstalled_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "DlcInstalled_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DlcInstalled_t>.NativeClassPtr);
			DlcInstalled_t.NativeFieldInfoPtr_AppID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DlcInstalled_t>.NativeClassPtr, "AppID");
			DlcInstalled_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DlcInstalled_t>.NativeClassPtr, "_datasize");
			DlcInstalled_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DlcInstalled_t>.NativeClassPtr, 100667057);
			DlcInstalled_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DlcInstalled_t>.NativeClassPtr, 100667058);
		}

		// Token: 0x170003A0 RID: 928
		// (get) Token: 0x060011DA RID: 4570 RVA: 0x00063AE0 File Offset: 0x00061CE0
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950603, XrefRangeEnd = 950607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DlcInstalled_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170003A1 RID: 929
		// (get) Token: 0x060011DB RID: 4571 RVA: 0x00063B10 File Offset: 0x00061D10
		public unsafe CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DlcInstalled_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060011DC RID: 4572 RVA: 0x00005568 File Offset: 0x00003768
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DlcInstalled_t>.NativeClassPtr, ref this));
		}

		// Token: 0x1700039F RID: 927
		// (get) Token: 0x060011DD RID: 4573 RVA: 0x00063B40 File Offset: 0x00061D40
		// (set) Token: 0x060011DE RID: 4574 RVA: 0x0000557A File Offset: 0x0000377A
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DlcInstalled_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DlcInstalled_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x04001811 RID: 6161
		private static readonly IntPtr NativeFieldInfoPtr_AppID;

		// Token: 0x04001812 RID: 6162
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x04001813 RID: 6163
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04001814 RID: 6164
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;

		// Token: 0x04001815 RID: 6165
		[FieldOffset(0)]
		public AppId AppID;
	}
}
