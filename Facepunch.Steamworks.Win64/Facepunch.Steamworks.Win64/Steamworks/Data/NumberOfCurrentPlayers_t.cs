using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x02000143 RID: 323
	[StructLayout(2)]
	public struct NumberOfCurrentPlayers_t
	{
		// Token: 0x060011AB RID: 4523 RVA: 0x000632CC File Offset: 0x000614CC
		// Note: this type is marked as 'beforefieldinit'.
		static NumberOfCurrentPlayers_t()
		{
			Il2CppClassPointerStore<NumberOfCurrentPlayers_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "NumberOfCurrentPlayers_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NumberOfCurrentPlayers_t>.NativeClassPtr);
			NumberOfCurrentPlayers_t.NativeFieldInfoPtr_Success = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberOfCurrentPlayers_t>.NativeClassPtr, "Success");
			NumberOfCurrentPlayers_t.NativeFieldInfoPtr_CPlayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberOfCurrentPlayers_t>.NativeClassPtr, "CPlayers");
			NumberOfCurrentPlayers_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberOfCurrentPlayers_t>.NativeClassPtr, "_datasize");
			NumberOfCurrentPlayers_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberOfCurrentPlayers_t>.NativeClassPtr, 100667038);
			NumberOfCurrentPlayers_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberOfCurrentPlayers_t>.NativeClassPtr, 100667039);
		}

		// Token: 0x1700038A RID: 906
		// (get) Token: 0x060011AC RID: 4524 RVA: 0x00063360 File Offset: 0x00061560
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950574, XrefRangeEnd = 950578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberOfCurrentPlayers_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700038B RID: 907
		// (get) Token: 0x060011AD RID: 4525 RVA: 0x00063390 File Offset: 0x00061590
		public unsafe CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberOfCurrentPlayers_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060011AE RID: 4526 RVA: 0x0000542F File Offset: 0x0000362F
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NumberOfCurrentPlayers_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000389 RID: 905
		// (get) Token: 0x060011AF RID: 4527 RVA: 0x000633C0 File Offset: 0x000615C0
		// (set) Token: 0x060011B0 RID: 4528 RVA: 0x00005441 File Offset: 0x00003641
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(NumberOfCurrentPlayers_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NumberOfCurrentPlayers_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x040017E8 RID: 6120
		private static readonly IntPtr NativeFieldInfoPtr_Success;

		// Token: 0x040017E9 RID: 6121
		private static readonly IntPtr NativeFieldInfoPtr_CPlayers;

		// Token: 0x040017EA RID: 6122
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x040017EB RID: 6123
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x040017EC RID: 6124
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;

		// Token: 0x040017ED RID: 6125
		[FieldOffset(0)]
		public byte Success;

		// Token: 0x040017EE RID: 6126
		[FieldOffset(4)]
		public int CPlayers;
	}
}
