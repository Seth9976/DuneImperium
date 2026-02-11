using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x0200014A RID: 330
	[StructLayout(2)]
	public struct RegisterActivationCodeResponse_t
	{
		// Token: 0x060011DF RID: 4575 RVA: 0x00063B5C File Offset: 0x00061D5C
		// Note: this type is marked as 'beforefieldinit'.
		static RegisterActivationCodeResponse_t()
		{
			Il2CppClassPointerStore<RegisterActivationCodeResponse_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "RegisterActivationCodeResponse_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RegisterActivationCodeResponse_t>.NativeClassPtr);
			RegisterActivationCodeResponse_t.NativeFieldInfoPtr_Result = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisterActivationCodeResponse_t>.NativeClassPtr, "Result");
			RegisterActivationCodeResponse_t.NativeFieldInfoPtr_PackageRegistered = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisterActivationCodeResponse_t>.NativeClassPtr, "PackageRegistered");
			RegisterActivationCodeResponse_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisterActivationCodeResponse_t>.NativeClassPtr, "_datasize");
			RegisterActivationCodeResponse_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterActivationCodeResponse_t>.NativeClassPtr, 100667060);
			RegisterActivationCodeResponse_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterActivationCodeResponse_t>.NativeClassPtr, 100667061);
		}

		// Token: 0x170003A3 RID: 931
		// (get) Token: 0x060011E0 RID: 4576 RVA: 0x00063BF0 File Offset: 0x00061DF0
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950607, XrefRangeEnd = 950611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegisterActivationCodeResponse_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170003A4 RID: 932
		// (get) Token: 0x060011E1 RID: 4577 RVA: 0x00063C20 File Offset: 0x00061E20
		public unsafe CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegisterActivationCodeResponse_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060011E2 RID: 4578 RVA: 0x00005588 File Offset: 0x00003788
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RegisterActivationCodeResponse_t>.NativeClassPtr, ref this));
		}

		// Token: 0x170003A2 RID: 930
		// (get) Token: 0x060011E3 RID: 4579 RVA: 0x00063C50 File Offset: 0x00061E50
		// (set) Token: 0x060011E4 RID: 4580 RVA: 0x0000559A File Offset: 0x0000379A
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RegisterActivationCodeResponse_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RegisterActivationCodeResponse_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x04001816 RID: 6166
		private static readonly IntPtr NativeFieldInfoPtr_Result;

		// Token: 0x04001817 RID: 6167
		private static readonly IntPtr NativeFieldInfoPtr_PackageRegistered;

		// Token: 0x04001818 RID: 6168
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x04001819 RID: 6169
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x0400181A RID: 6170
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;

		// Token: 0x0400181B RID: 6171
		[FieldOffset(0)]
		public RegisterActivationCodeResult Result;

		// Token: 0x0400181C RID: 6172
		[FieldOffset(4)]
		public uint PackageRegistered;
	}
}
