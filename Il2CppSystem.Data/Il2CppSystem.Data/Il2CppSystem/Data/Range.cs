using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Data
{
	// Token: 0x0200006C RID: 108
	[StructLayout(2)]
	public struct Range
	{
		// Token: 0x06000A15 RID: 2581 RVA: 0x000341F0 File Offset: 0x000323F0
		// Note: this type is marked as 'beforefieldinit'.
		static Range()
		{
			Il2CppClassPointerStore<Range>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Data.dll", "System.Data", "Range");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Range>.NativeClassPtr);
			Range.NativeFieldInfoPtr__min = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Range>.NativeClassPtr, "_min");
			Range.NativeFieldInfoPtr__max = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Range>.NativeClassPtr, "_max");
			Range.NativeFieldInfoPtr__isNotNull = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Range>.NativeClassPtr, "_isNotNull");
			Range.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Range>.NativeClassPtr, 100664949);
			Range.NativeMethodInfoPtr_get_Count_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Range>.NativeClassPtr, 100664950);
			Range.NativeMethodInfoPtr_get_IsNull_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Range>.NativeClassPtr, 100664951);
			Range.NativeMethodInfoPtr_get_Min_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Range>.NativeClassPtr, 100664952);
			Range.NativeMethodInfoPtr_CheckNull_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Range>.NativeClassPtr, 100664953);
		}

		// Token: 0x06000A16 RID: 2582 RVA: 0x000342C0 File Offset: 0x000324C0
		[CallerCount(0)]
		public unsafe Range(int min, int max)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref min;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref max;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Range.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700027F RID: 639
		// (get) Token: 0x06000A17 RID: 2583 RVA: 0x00034300 File Offset: 0x00032500
		public unsafe int Count
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 905648, RefRangeEnd = 905649, XrefRangeStart = 905648, XrefRangeEnd = 905648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Range.NativeMethodInfoPtr_get_Count_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000280 RID: 640
		// (get) Token: 0x06000A18 RID: 2584 RVA: 0x00034330 File Offset: 0x00032530
		public unsafe bool IsNull
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 905649, RefRangeEnd = 905653, XrefRangeStart = 905649, XrefRangeEnd = 905649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Range.NativeMethodInfoPtr_get_IsNull_Public_get_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000281 RID: 641
		// (get) Token: 0x06000A19 RID: 2585 RVA: 0x00034360 File Offset: 0x00032560
		public unsafe int Min
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 905653, RefRangeEnd = 905656, XrefRangeStart = 905653, XrefRangeEnd = 905653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Range.NativeMethodInfoPtr_get_Min_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A1A RID: 2586 RVA: 0x00034390 File Offset: 0x00032590
		[CallerCount(0)]
		public unsafe void CheckNull()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Range.NativeMethodInfoPtr_CheckNull_Internal_Void_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A1B RID: 2587 RVA: 0x000050C7 File Offset: 0x000032C7
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Range>.NativeClassPtr, ref this));
		}

		// Token: 0x0400085A RID: 2138
		private static readonly IntPtr NativeFieldInfoPtr__min;

		// Token: 0x0400085B RID: 2139
		private static readonly IntPtr NativeFieldInfoPtr__max;

		// Token: 0x0400085C RID: 2140
		private static readonly IntPtr NativeFieldInfoPtr__isNotNull;

		// Token: 0x0400085D RID: 2141
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0;

		// Token: 0x0400085E RID: 2142
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_get_Int32_0;

		// Token: 0x0400085F RID: 2143
		private static readonly IntPtr NativeMethodInfoPtr_get_IsNull_Public_get_Boolean_0;

		// Token: 0x04000860 RID: 2144
		private static readonly IntPtr NativeMethodInfoPtr_get_Min_Public_get_Int32_0;

		// Token: 0x04000861 RID: 2145
		private static readonly IntPtr NativeMethodInfoPtr_CheckNull_Internal_Void_0;

		// Token: 0x04000862 RID: 2146
		[FieldOffset(0)]
		public int _min;

		// Token: 0x04000863 RID: 2147
		[FieldOffset(4)]
		public int _max;

		// Token: 0x04000864 RID: 2148
		[FieldOffset(8)]
		[MarshalAs(4)]
		public bool _isNotNull;
	}
}
