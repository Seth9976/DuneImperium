using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x02000100 RID: 256
	[StructLayout(2)]
	public struct SetPersonaNameResponse_t
	{
		// Token: 0x06000F80 RID: 3968 RVA: 0x0005D608 File Offset: 0x0005B808
		// Note: this type is marked as 'beforefieldinit'.
		static SetPersonaNameResponse_t()
		{
			Il2CppClassPointerStore<SetPersonaNameResponse_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "SetPersonaNameResponse_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetPersonaNameResponse_t>.NativeClassPtr);
			SetPersonaNameResponse_t.NativeFieldInfoPtr_Success = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetPersonaNameResponse_t>.NativeClassPtr, "Success");
			SetPersonaNameResponse_t.NativeFieldInfoPtr_LocalSuccess = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetPersonaNameResponse_t>.NativeClassPtr, "LocalSuccess");
			SetPersonaNameResponse_t.NativeFieldInfoPtr_Result = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetPersonaNameResponse_t>.NativeClassPtr, "Result");
			SetPersonaNameResponse_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetPersonaNameResponse_t>.NativeClassPtr, "_datasize");
			SetPersonaNameResponse_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetPersonaNameResponse_t>.NativeClassPtr, 100666827);
			SetPersonaNameResponse_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetPersonaNameResponse_t>.NativeClassPtr, 100666828);
		}

		// Token: 0x1700027F RID: 639
		// (get) Token: 0x06000F81 RID: 3969 RVA: 0x0005D6B0 File Offset: 0x0005B8B0
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950262, XrefRangeEnd = 950266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetPersonaNameResponse_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000280 RID: 640
		// (get) Token: 0x06000F82 RID: 3970 RVA: 0x0005D6E0 File Offset: 0x0005B8E0
		public unsafe CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetPersonaNameResponse_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F83 RID: 3971 RVA: 0x0000442E File Offset: 0x0000262E
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SetPersonaNameResponse_t>.NativeClassPtr, ref this));
		}

		// Token: 0x1700027E RID: 638
		// (get) Token: 0x06000F84 RID: 3972 RVA: 0x0005D710 File Offset: 0x0005B910
		// (set) Token: 0x06000F85 RID: 3973 RVA: 0x00004440 File Offset: 0x00002640
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SetPersonaNameResponse_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SetPersonaNameResponse_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x040015B5 RID: 5557
		private static readonly IntPtr NativeFieldInfoPtr_Success;

		// Token: 0x040015B6 RID: 5558
		private static readonly IntPtr NativeFieldInfoPtr_LocalSuccess;

		// Token: 0x040015B7 RID: 5559
		private static readonly IntPtr NativeFieldInfoPtr_Result;

		// Token: 0x040015B8 RID: 5560
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x040015B9 RID: 5561
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x040015BA RID: 5562
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;

		// Token: 0x040015BB RID: 5563
		[FieldOffset(0)]
		[MarshalAs(4)]
		public bool Success;

		// Token: 0x040015BC RID: 5564
		[FieldOffset(1)]
		[MarshalAs(4)]
		public bool LocalSuccess;

		// Token: 0x040015BD RID: 5565
		[FieldOffset(4)]
		public Result Result;
	}
}
