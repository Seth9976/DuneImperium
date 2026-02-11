using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x020001AA RID: 426
	[StructLayout(2)]
	public struct GSGameplayStats_t
	{
		// Token: 0x06001508 RID: 5384 RVA: 0x0006BB00 File Offset: 0x00069D00
		// Note: this type is marked as 'beforefieldinit'.
		static GSGameplayStats_t()
		{
			Il2CppClassPointerStore<GSGameplayStats_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "GSGameplayStats_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GSGameplayStats_t>.NativeClassPtr);
			GSGameplayStats_t.NativeFieldInfoPtr_Result = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GSGameplayStats_t>.NativeClassPtr, "Result");
			GSGameplayStats_t.NativeFieldInfoPtr_Rank = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GSGameplayStats_t>.NativeClassPtr, "Rank");
			GSGameplayStats_t.NativeFieldInfoPtr_TotalConnects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GSGameplayStats_t>.NativeClassPtr, "TotalConnects");
			GSGameplayStats_t.NativeFieldInfoPtr_TotalMinutesPlayed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GSGameplayStats_t>.NativeClassPtr, "TotalMinutesPlayed");
			GSGameplayStats_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GSGameplayStats_t>.NativeClassPtr, "_datasize");
			GSGameplayStats_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GSGameplayStats_t>.NativeClassPtr, 100667356);
			GSGameplayStats_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GSGameplayStats_t>.NativeClassPtr, 100667357);
		}

		// Token: 0x17000526 RID: 1318
		// (get) Token: 0x06001509 RID: 5385 RVA: 0x0006BBBC File Offset: 0x00069DBC
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951028, XrefRangeEnd = 951032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GSGameplayStats_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000527 RID: 1319
		// (get) Token: 0x0600150A RID: 5386 RVA: 0x0006BBEC File Offset: 0x00069DEC
		public unsafe CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GSGameplayStats_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600150B RID: 5387 RVA: 0x00006D9D File Offset: 0x00004F9D
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GSGameplayStats_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000525 RID: 1317
		// (get) Token: 0x0600150C RID: 5388 RVA: 0x0006BC1C File Offset: 0x00069E1C
		// (set) Token: 0x0600150D RID: 5389 RVA: 0x00006DAF File Offset: 0x00004FAF
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(GSGameplayStats_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GSGameplayStats_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x04001AA9 RID: 6825
		private static readonly IntPtr NativeFieldInfoPtr_Result;

		// Token: 0x04001AAA RID: 6826
		private static readonly IntPtr NativeFieldInfoPtr_Rank;

		// Token: 0x04001AAB RID: 6827
		private static readonly IntPtr NativeFieldInfoPtr_TotalConnects;

		// Token: 0x04001AAC RID: 6828
		private static readonly IntPtr NativeFieldInfoPtr_TotalMinutesPlayed;

		// Token: 0x04001AAD RID: 6829
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x04001AAE RID: 6830
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04001AAF RID: 6831
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;

		// Token: 0x04001AB0 RID: 6832
		[FieldOffset(0)]
		public Result Result;

		// Token: 0x04001AB1 RID: 6833
		[FieldOffset(4)]
		public int Rank;

		// Token: 0x04001AB2 RID: 6834
		[FieldOffset(8)]
		public uint TotalConnects;

		// Token: 0x04001AB3 RID: 6835
		[FieldOffset(12)]
		public uint TotalMinutesPlayed;
	}
}
