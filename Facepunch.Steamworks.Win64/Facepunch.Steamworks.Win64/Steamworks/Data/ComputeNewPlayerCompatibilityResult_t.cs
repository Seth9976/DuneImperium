using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x020001AE RID: 430
	[StructLayout(2)]
	public struct ComputeNewPlayerCompatibilityResult_t
	{
		// Token: 0x06001520 RID: 5408 RVA: 0x0006BFE0 File Offset: 0x0006A1E0
		// Note: this type is marked as 'beforefieldinit'.
		static ComputeNewPlayerCompatibilityResult_t()
		{
			Il2CppClassPointerStore<ComputeNewPlayerCompatibilityResult_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "ComputeNewPlayerCompatibilityResult_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ComputeNewPlayerCompatibilityResult_t>.NativeClassPtr);
			ComputeNewPlayerCompatibilityResult_t.NativeFieldInfoPtr_Result = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComputeNewPlayerCompatibilityResult_t>.NativeClassPtr, "Result");
			ComputeNewPlayerCompatibilityResult_t.NativeFieldInfoPtr_CPlayersThatDontLikeCandidate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComputeNewPlayerCompatibilityResult_t>.NativeClassPtr, "CPlayersThatDontLikeCandidate");
			ComputeNewPlayerCompatibilityResult_t.NativeFieldInfoPtr_CPlayersThatCandidateDoesntLike = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComputeNewPlayerCompatibilityResult_t>.NativeClassPtr, "CPlayersThatCandidateDoesntLike");
			ComputeNewPlayerCompatibilityResult_t.NativeFieldInfoPtr_CClanPlayersThatDontLikeCandidate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComputeNewPlayerCompatibilityResult_t>.NativeClassPtr, "CClanPlayersThatDontLikeCandidate");
			ComputeNewPlayerCompatibilityResult_t.NativeFieldInfoPtr_SteamIDCandidate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComputeNewPlayerCompatibilityResult_t>.NativeClassPtr, "SteamIDCandidate");
			ComputeNewPlayerCompatibilityResult_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComputeNewPlayerCompatibilityResult_t>.NativeClassPtr, "_datasize");
			ComputeNewPlayerCompatibilityResult_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeNewPlayerCompatibilityResult_t>.NativeClassPtr, 100667368);
			ComputeNewPlayerCompatibilityResult_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeNewPlayerCompatibilityResult_t>.NativeClassPtr, 100667369);
		}

		// Token: 0x17000532 RID: 1330
		// (get) Token: 0x06001521 RID: 5409 RVA: 0x0006C0B0 File Offset: 0x0006A2B0
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951044, XrefRangeEnd = 951048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputeNewPlayerCompatibilityResult_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000533 RID: 1331
		// (get) Token: 0x06001522 RID: 5410 RVA: 0x0006C0E0 File Offset: 0x0006A2E0
		public unsafe CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputeNewPlayerCompatibilityResult_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001523 RID: 5411 RVA: 0x00006E1D File Offset: 0x0000501D
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ComputeNewPlayerCompatibilityResult_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000531 RID: 1329
		// (get) Token: 0x06001524 RID: 5412 RVA: 0x0006C110 File Offset: 0x0006A310
		// (set) Token: 0x06001525 RID: 5413 RVA: 0x00006E2F File Offset: 0x0000502F
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ComputeNewPlayerCompatibilityResult_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ComputeNewPlayerCompatibilityResult_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x04001AD5 RID: 6869
		private static readonly IntPtr NativeFieldInfoPtr_Result;

		// Token: 0x04001AD6 RID: 6870
		private static readonly IntPtr NativeFieldInfoPtr_CPlayersThatDontLikeCandidate;

		// Token: 0x04001AD7 RID: 6871
		private static readonly IntPtr NativeFieldInfoPtr_CPlayersThatCandidateDoesntLike;

		// Token: 0x04001AD8 RID: 6872
		private static readonly IntPtr NativeFieldInfoPtr_CClanPlayersThatDontLikeCandidate;

		// Token: 0x04001AD9 RID: 6873
		private static readonly IntPtr NativeFieldInfoPtr_SteamIDCandidate;

		// Token: 0x04001ADA RID: 6874
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x04001ADB RID: 6875
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04001ADC RID: 6876
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;

		// Token: 0x04001ADD RID: 6877
		[FieldOffset(0)]
		public Result Result;

		// Token: 0x04001ADE RID: 6878
		[FieldOffset(4)]
		public int CPlayersThatDontLikeCandidate;

		// Token: 0x04001ADF RID: 6879
		[FieldOffset(8)]
		public int CPlayersThatCandidateDoesntLike;

		// Token: 0x04001AE0 RID: 6880
		[FieldOffset(12)]
		public int CClanPlayersThatDontLikeCandidate;

		// Token: 0x04001AE1 RID: 6881
		[FieldOffset(16)]
		public ulong SteamIDCandidate;
	}
}
