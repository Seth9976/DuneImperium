using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x020001AD RID: 429
	[StructLayout(2)]
	public struct AssociateWithClanResult_t
	{
		// Token: 0x0600151A RID: 5402 RVA: 0x0006BEE4 File Offset: 0x0006A0E4
		// Note: this type is marked as 'beforefieldinit'.
		static AssociateWithClanResult_t()
		{
			Il2CppClassPointerStore<AssociateWithClanResult_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "AssociateWithClanResult_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AssociateWithClanResult_t>.NativeClassPtr);
			AssociateWithClanResult_t.NativeFieldInfoPtr_Result = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssociateWithClanResult_t>.NativeClassPtr, "Result");
			AssociateWithClanResult_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssociateWithClanResult_t>.NativeClassPtr, "_datasize");
			AssociateWithClanResult_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssociateWithClanResult_t>.NativeClassPtr, 100667365);
			AssociateWithClanResult_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssociateWithClanResult_t>.NativeClassPtr, 100667366);
		}

		// Token: 0x1700052F RID: 1327
		// (get) Token: 0x0600151B RID: 5403 RVA: 0x0006BF64 File Offset: 0x0006A164
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951040, XrefRangeEnd = 951044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssociateWithClanResult_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000530 RID: 1328
		// (get) Token: 0x0600151C RID: 5404 RVA: 0x0006BF94 File Offset: 0x0006A194
		public unsafe CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssociateWithClanResult_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600151D RID: 5405 RVA: 0x00006DFD File Offset: 0x00004FFD
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AssociateWithClanResult_t>.NativeClassPtr, ref this));
		}

		// Token: 0x1700052E RID: 1326
		// (get) Token: 0x0600151E RID: 5406 RVA: 0x0006BFC4 File Offset: 0x0006A1C4
		// (set) Token: 0x0600151F RID: 5407 RVA: 0x00006E0F File Offset: 0x0000500F
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(AssociateWithClanResult_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AssociateWithClanResult_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x04001AD0 RID: 6864
		private static readonly IntPtr NativeFieldInfoPtr_Result;

		// Token: 0x04001AD1 RID: 6865
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x04001AD2 RID: 6866
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04001AD3 RID: 6867
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;

		// Token: 0x04001AD4 RID: 6868
		[FieldOffset(0)]
		public Result Result;
	}
}
