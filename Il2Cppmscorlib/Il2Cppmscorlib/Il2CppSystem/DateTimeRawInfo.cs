using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem
{
	// Token: 0x0200009D RID: 157
	[StructLayout(2)]
	public struct DateTimeRawInfo
	{
		// Token: 0x06000AE8 RID: 2792 RVA: 0x00058064 File Offset: 0x00056264
		// Note: this type is marked as 'beforefieldinit'.
		static DateTimeRawInfo()
		{
			Il2CppClassPointerStore<DateTimeRawInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "DateTimeRawInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DateTimeRawInfo>.NativeClassPtr);
			DateTimeRawInfo.NativeFieldInfoPtr_num = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeRawInfo>.NativeClassPtr, "num");
			DateTimeRawInfo.NativeFieldInfoPtr_numCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeRawInfo>.NativeClassPtr, "numCount");
			DateTimeRawInfo.NativeFieldInfoPtr_month = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeRawInfo>.NativeClassPtr, "month");
			DateTimeRawInfo.NativeFieldInfoPtr_year = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeRawInfo>.NativeClassPtr, "year");
			DateTimeRawInfo.NativeFieldInfoPtr_dayOfWeek = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeRawInfo>.NativeClassPtr, "dayOfWeek");
			DateTimeRawInfo.NativeFieldInfoPtr_era = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeRawInfo>.NativeClassPtr, "era");
			DateTimeRawInfo.NativeFieldInfoPtr_timeMark = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeRawInfo>.NativeClassPtr, "timeMark");
			DateTimeRawInfo.NativeFieldInfoPtr_fraction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeRawInfo>.NativeClassPtr, "fraction");
			DateTimeRawInfo.NativeFieldInfoPtr_hasSameDateAndTimeSeparators = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeRawInfo>.NativeClassPtr, "hasSameDateAndTimeSeparators");
			DateTimeRawInfo.NativeMethodInfoPtr_Init_Internal_Void_ptr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeRawInfo>.NativeClassPtr, 100665215);
			DateTimeRawInfo.NativeMethodInfoPtr_AddNumber_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeRawInfo>.NativeClassPtr, 100665216);
			DateTimeRawInfo.NativeMethodInfoPtr_GetNumber_Internal_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeRawInfo>.NativeClassPtr, 100665217);
		}

		// Token: 0x06000AE9 RID: 2793 RVA: 0x00058184 File Offset: 0x00056384
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1307333, RefRangeEnd = 1307334, XrefRangeStart = 1307333, XrefRangeEnd = 1307333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Init(int* numberBuffer)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = numberBuffer;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeRawInfo.NativeMethodInfoPtr_Init_Internal_Void_ptr_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000AEA RID: 2794 RVA: 0x000581B8 File Offset: 0x000563B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1307334, RefRangeEnd = 1307335, XrefRangeStart = 1307334, XrefRangeEnd = 1307334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddNumber(int value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeRawInfo.NativeMethodInfoPtr_AddNumber_Internal_Void_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000AEB RID: 2795 RVA: 0x000581EC File Offset: 0x000563EC
		[CallerCount(41)]
		[CachedScanResults(RefRangeStart = 1307335, RefRangeEnd = 1307376, XrefRangeStart = 1307335, XrefRangeEnd = 1307335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetNumber(int index)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeRawInfo.NativeMethodInfoPtr_GetNumber_Internal_Int32_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000AEC RID: 2796 RVA: 0x00004A5C File Offset: 0x00002C5C
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DateTimeRawInfo>.NativeClassPtr, ref this));
		}

		// Token: 0x04000899 RID: 2201
		private static readonly IntPtr NativeFieldInfoPtr_num;

		// Token: 0x0400089A RID: 2202
		private static readonly IntPtr NativeFieldInfoPtr_numCount;

		// Token: 0x0400089B RID: 2203
		private static readonly IntPtr NativeFieldInfoPtr_month;

		// Token: 0x0400089C RID: 2204
		private static readonly IntPtr NativeFieldInfoPtr_year;

		// Token: 0x0400089D RID: 2205
		private static readonly IntPtr NativeFieldInfoPtr_dayOfWeek;

		// Token: 0x0400089E RID: 2206
		private static readonly IntPtr NativeFieldInfoPtr_era;

		// Token: 0x0400089F RID: 2207
		private static readonly IntPtr NativeFieldInfoPtr_timeMark;

		// Token: 0x040008A0 RID: 2208
		private static readonly IntPtr NativeFieldInfoPtr_fraction;

		// Token: 0x040008A1 RID: 2209
		private static readonly IntPtr NativeFieldInfoPtr_hasSameDateAndTimeSeparators;

		// Token: 0x040008A2 RID: 2210
		private static readonly IntPtr NativeMethodInfoPtr_Init_Internal_Void_ptr_Int32_0;

		// Token: 0x040008A3 RID: 2211
		private static readonly IntPtr NativeMethodInfoPtr_AddNumber_Internal_Void_Int32_0;

		// Token: 0x040008A4 RID: 2212
		private static readonly IntPtr NativeMethodInfoPtr_GetNumber_Internal_Int32_Int32_0;

		// Token: 0x040008A5 RID: 2213
		[FieldOffset(0)]
		public IntPtr num;

		// Token: 0x040008A6 RID: 2214
		[FieldOffset(8)]
		public int numCount;

		// Token: 0x040008A7 RID: 2215
		[FieldOffset(12)]
		public int month;

		// Token: 0x040008A8 RID: 2216
		[FieldOffset(16)]
		public int year;

		// Token: 0x040008A9 RID: 2217
		[FieldOffset(20)]
		public int dayOfWeek;

		// Token: 0x040008AA RID: 2218
		[FieldOffset(24)]
		public int era;

		// Token: 0x040008AB RID: 2219
		[FieldOffset(28)]
		public DateTimeParse.TM timeMark;

		// Token: 0x040008AC RID: 2220
		[FieldOffset(32)]
		public double fraction;

		// Token: 0x040008AD RID: 2221
		[FieldOffset(40)]
		[MarshalAs(4)]
		public bool hasSameDateAndTimeSeparators;
	}
}
