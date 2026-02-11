using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x0200011D RID: 285
	[StructLayout(2)]
	public struct EndGameResultCallback_t
	{
		// Token: 0x06001032 RID: 4146 RVA: 0x0005F724 File Offset: 0x0005D924
		// Note: this type is marked as 'beforefieldinit'.
		static EndGameResultCallback_t()
		{
			Il2CppClassPointerStore<EndGameResultCallback_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "EndGameResultCallback_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EndGameResultCallback_t>.NativeClassPtr);
			EndGameResultCallback_t.NativeFieldInfoPtr_Result = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EndGameResultCallback_t>.NativeClassPtr, "Result");
			EndGameResultCallback_t.NativeFieldInfoPtr_UllUniqueGameID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EndGameResultCallback_t>.NativeClassPtr, "UllUniqueGameID");
			EndGameResultCallback_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EndGameResultCallback_t>.NativeClassPtr, "_datasize");
			EndGameResultCallback_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EndGameResultCallback_t>.NativeClassPtr, 100666915);
			EndGameResultCallback_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EndGameResultCallback_t>.NativeClassPtr, 100666916);
		}

		// Token: 0x170002D7 RID: 727
		// (get) Token: 0x06001033 RID: 4147 RVA: 0x0005F7B8 File Offset: 0x0005D9B8
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950383, XrefRangeEnd = 950387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EndGameResultCallback_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002D8 RID: 728
		// (get) Token: 0x06001034 RID: 4148 RVA: 0x0005F7E8 File Offset: 0x0005D9E8
		public unsafe CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EndGameResultCallback_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001035 RID: 4149 RVA: 0x000047F6 File Offset: 0x000029F6
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EndGameResultCallback_t>.NativeClassPtr, ref this));
		}

		// Token: 0x170002D6 RID: 726
		// (get) Token: 0x06001036 RID: 4150 RVA: 0x0005F818 File Offset: 0x0005DA18
		// (set) Token: 0x06001037 RID: 4151 RVA: 0x00004808 File Offset: 0x00002A08
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(EndGameResultCallback_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EndGameResultCallback_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x040016AA RID: 5802
		private static readonly IntPtr NativeFieldInfoPtr_Result;

		// Token: 0x040016AB RID: 5803
		private static readonly IntPtr NativeFieldInfoPtr_UllUniqueGameID;

		// Token: 0x040016AC RID: 5804
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x040016AD RID: 5805
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x040016AE RID: 5806
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;

		// Token: 0x040016AF RID: 5807
		[FieldOffset(0)]
		public Result Result;

		// Token: 0x040016B0 RID: 5808
		[FieldOffset(8)]
		public ulong UllUniqueGameID;
	}
}
