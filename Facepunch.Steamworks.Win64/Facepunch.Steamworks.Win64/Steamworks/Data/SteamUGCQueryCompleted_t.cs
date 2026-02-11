using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x02000169 RID: 361
	public sealed class SteamUGCQueryCompleted_t : ValueType
	{
		// Token: 0x060012AC RID: 4780 RVA: 0x00065CFC File Offset: 0x00063EFC
		// Note: this type is marked as 'beforefieldinit'.
		static SteamUGCQueryCompleted_t()
		{
			Il2CppClassPointerStore<SteamUGCQueryCompleted_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "SteamUGCQueryCompleted_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamUGCQueryCompleted_t>.NativeClassPtr);
			SteamUGCQueryCompleted_t.NativeFieldInfoPtr_Handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUGCQueryCompleted_t>.NativeClassPtr, "Handle");
			SteamUGCQueryCompleted_t.NativeFieldInfoPtr_Result = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUGCQueryCompleted_t>.NativeClassPtr, "Result");
			SteamUGCQueryCompleted_t.NativeFieldInfoPtr_NumResultsReturned = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUGCQueryCompleted_t>.NativeClassPtr, "NumResultsReturned");
			SteamUGCQueryCompleted_t.NativeFieldInfoPtr_TotalMatchingResults = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUGCQueryCompleted_t>.NativeClassPtr, "TotalMatchingResults");
			SteamUGCQueryCompleted_t.NativeFieldInfoPtr_CachedData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUGCQueryCompleted_t>.NativeClassPtr, "CachedData");
			SteamUGCQueryCompleted_t.NativeFieldInfoPtr_NextCursor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUGCQueryCompleted_t>.NativeClassPtr, "NextCursor");
			SteamUGCQueryCompleted_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUGCQueryCompleted_t>.NativeClassPtr, "_datasize");
			SteamUGCQueryCompleted_t.NativeMethodInfoPtr_NextCursorUTF8_Internal_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUGCQueryCompleted_t>.NativeClassPtr, 100667154);
			SteamUGCQueryCompleted_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUGCQueryCompleted_t>.NativeClassPtr, 100667155);
			SteamUGCQueryCompleted_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUGCQueryCompleted_t>.NativeClassPtr, 100667156);
		}

		// Token: 0x060012AD RID: 4781 RVA: 0x00065DF4 File Offset: 0x00063FF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950735, XrefRangeEnd = 950739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string NextCursorUTF8()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUGCQueryCompleted_t.NativeMethodInfoPtr_NextCursorUTF8_Internal_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x1700040E RID: 1038
		// (get) Token: 0x060012AE RID: 4782 RVA: 0x00065E30 File Offset: 0x00064030
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950739, XrefRangeEnd = 950743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUGCQueryCompleted_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700040F RID: 1039
		// (get) Token: 0x060012AF RID: 4783 RVA: 0x00065E74 File Offset: 0x00064074
		public unsafe CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUGCQueryCompleted_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060012B0 RID: 4784 RVA: 0x00005A5A File Offset: 0x00003C5A
		public SteamUGCQueryCompleted_t(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060012B1 RID: 4785 RVA: 0x00005A63 File Offset: 0x00003C63
		public SteamUGCQueryCompleted_t()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SteamUGCQueryCompleted_t>.NativeClassPtr))
		{
		}

		// Token: 0x17000407 RID: 1031
		// (get) Token: 0x060012B2 RID: 4786 RVA: 0x00065EB8 File Offset: 0x000640B8
		// (set) Token: 0x060012B3 RID: 4787 RVA: 0x00005A75 File Offset: 0x00003C75
		public unsafe ulong Handle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGCQueryCompleted_t.NativeFieldInfoPtr_Handle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGCQueryCompleted_t.NativeFieldInfoPtr_Handle)) = value;
			}
		}

		// Token: 0x17000408 RID: 1032
		// (get) Token: 0x060012B4 RID: 4788 RVA: 0x00065EE0 File Offset: 0x000640E0
		// (set) Token: 0x060012B5 RID: 4789 RVA: 0x00005A90 File Offset: 0x00003C90
		public unsafe Result Result
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGCQueryCompleted_t.NativeFieldInfoPtr_Result);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGCQueryCompleted_t.NativeFieldInfoPtr_Result)) = value;
			}
		}

		// Token: 0x17000409 RID: 1033
		// (get) Token: 0x060012B6 RID: 4790 RVA: 0x00065F08 File Offset: 0x00064108
		// (set) Token: 0x060012B7 RID: 4791 RVA: 0x00005AAB File Offset: 0x00003CAB
		public unsafe uint NumResultsReturned
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGCQueryCompleted_t.NativeFieldInfoPtr_NumResultsReturned);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGCQueryCompleted_t.NativeFieldInfoPtr_NumResultsReturned)) = value;
			}
		}

		// Token: 0x1700040A RID: 1034
		// (get) Token: 0x060012B8 RID: 4792 RVA: 0x00065F30 File Offset: 0x00064130
		// (set) Token: 0x060012B9 RID: 4793 RVA: 0x00005AC6 File Offset: 0x00003CC6
		public unsafe uint TotalMatchingResults
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGCQueryCompleted_t.NativeFieldInfoPtr_TotalMatchingResults);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGCQueryCompleted_t.NativeFieldInfoPtr_TotalMatchingResults)) = value;
			}
		}

		// Token: 0x1700040B RID: 1035
		// (get) Token: 0x060012BA RID: 4794 RVA: 0x00065F58 File Offset: 0x00064158
		// (set) Token: 0x060012BB RID: 4795 RVA: 0x00005AE1 File Offset: 0x00003CE1
		public unsafe bool CachedData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGCQueryCompleted_t.NativeFieldInfoPtr_CachedData);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGCQueryCompleted_t.NativeFieldInfoPtr_CachedData)) = value;
			}
		}

		// Token: 0x1700040C RID: 1036
		// (get) Token: 0x060012BC RID: 4796 RVA: 0x00065F80 File Offset: 0x00064180
		// (set) Token: 0x060012BD RID: 4797 RVA: 0x00005AFC File Offset: 0x00003CFC
		public unsafe Il2CppStructArray<byte> NextCursor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGCQueryCompleted_t.NativeFieldInfoPtr_NextCursor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGCQueryCompleted_t.NativeFieldInfoPtr_NextCursor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700040D RID: 1037
		// (get) Token: 0x060012BE RID: 4798 RVA: 0x00065FB0 File Offset: 0x000641B0
		// (set) Token: 0x060012BF RID: 4799 RVA: 0x00005B1B File Offset: 0x00003D1B
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SteamUGCQueryCompleted_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SteamUGCQueryCompleted_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x040018C8 RID: 6344
		private static readonly IntPtr NativeFieldInfoPtr_Handle;

		// Token: 0x040018C9 RID: 6345
		private static readonly IntPtr NativeFieldInfoPtr_Result;

		// Token: 0x040018CA RID: 6346
		private static readonly IntPtr NativeFieldInfoPtr_NumResultsReturned;

		// Token: 0x040018CB RID: 6347
		private static readonly IntPtr NativeFieldInfoPtr_TotalMatchingResults;

		// Token: 0x040018CC RID: 6348
		private static readonly IntPtr NativeFieldInfoPtr_CachedData;

		// Token: 0x040018CD RID: 6349
		private static readonly IntPtr NativeFieldInfoPtr_NextCursor;

		// Token: 0x040018CE RID: 6350
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x040018CF RID: 6351
		private static readonly IntPtr NativeMethodInfoPtr_NextCursorUTF8_Internal_String_0;

		// Token: 0x040018D0 RID: 6352
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x040018D1 RID: 6353
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;
	}
}
