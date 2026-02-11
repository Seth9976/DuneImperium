using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x020000E5 RID: 229
	[StructLayout(2)]
	public struct IPCFailure_t
	{
		// Token: 0x06000EC0 RID: 3776 RVA: 0x0005B43C File Offset: 0x0005963C
		// Note: this type is marked as 'beforefieldinit'.
		static IPCFailure_t()
		{
			Il2CppClassPointerStore<IPCFailure_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "IPCFailure_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IPCFailure_t>.NativeClassPtr);
			IPCFailure_t.NativeFieldInfoPtr_FailureType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IPCFailure_t>.NativeClassPtr, "FailureType");
			IPCFailure_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IPCFailure_t>.NativeClassPtr, "_datasize");
			IPCFailure_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPCFailure_t>.NativeClassPtr, 100666741);
			IPCFailure_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPCFailure_t>.NativeClassPtr, 100666742);
		}

		// Token: 0x17000224 RID: 548
		// (get) Token: 0x06000EC1 RID: 3777 RVA: 0x0005B4BC File Offset: 0x000596BC
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950129, XrefRangeEnd = 950133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IPCFailure_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000225 RID: 549
		// (get) Token: 0x06000EC2 RID: 3778 RVA: 0x0005B4EC File Offset: 0x000596EC
		public unsafe CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IPCFailure_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000EC3 RID: 3779 RVA: 0x00003F7B File Offset: 0x0000217B
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<IPCFailure_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000223 RID: 547
		// (get) Token: 0x06000EC4 RID: 3780 RVA: 0x0005B51C File Offset: 0x0005971C
		// (set) Token: 0x06000EC5 RID: 3781 RVA: 0x00003F8D File Offset: 0x0000218D
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(IPCFailure_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(IPCFailure_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x040014E3 RID: 5347
		private static readonly IntPtr NativeFieldInfoPtr_FailureType;

		// Token: 0x040014E4 RID: 5348
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x040014E5 RID: 5349
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x040014E6 RID: 5350
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;

		// Token: 0x040014E7 RID: 5351
		[FieldOffset(0)]
		public byte FailureType;

		// Token: 0x0200029B RID: 667
		public enum EFailureType
		{
			// Token: 0x0400238C RID: 9100
			FlushedCallbackQueue,
			// Token: 0x0400238D RID: 9101
			PipeFail
		}
	}
}
