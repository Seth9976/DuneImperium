using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering.Universal
{
	// Token: 0x020000DB RID: 219
	[StructLayout(2)]
	public struct InclusiveRange
	{
		// Token: 0x060010D9 RID: 4313 RVA: 0x0005020C File Offset: 0x0004E40C
		// Note: this type is marked as 'beforefieldinit'.
		static InclusiveRange()
		{
			Il2CppClassPointerStore<InclusiveRange>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "InclusiveRange");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InclusiveRange>.NativeClassPtr);
			InclusiveRange.NativeFieldInfoPtr_start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InclusiveRange>.NativeClassPtr, "start");
			InclusiveRange.NativeFieldInfoPtr_end = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InclusiveRange>.NativeClassPtr, "end");
			InclusiveRange.NativeMethodInfoPtr__ctor_Public_Void_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InclusiveRange>.NativeClassPtr, 100665464);
			InclusiveRange.NativeMethodInfoPtr__ctor_Public_Void_Int16_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InclusiveRange>.NativeClassPtr, 100665465);
			InclusiveRange.NativeMethodInfoPtr_Expand_Public_Void_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InclusiveRange>.NativeClassPtr, 100665466);
			InclusiveRange.NativeMethodInfoPtr_Clamp_Public_Void_Int16_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InclusiveRange>.NativeClassPtr, 100665467);
			InclusiveRange.NativeMethodInfoPtr_get_isEmpty_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InclusiveRange>.NativeClassPtr, 100665468);
			InclusiveRange.NativeMethodInfoPtr_Contains_Public_Boolean_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InclusiveRange>.NativeClassPtr, 100665469);
			InclusiveRange.NativeMethodInfoPtr_Merge_Public_Static_InclusiveRange_InclusiveRange_InclusiveRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InclusiveRange>.NativeClassPtr, 100665470);
			InclusiveRange.NativeMethodInfoPtr_get_empty_Public_Static_get_InclusiveRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InclusiveRange>.NativeClassPtr, 100665471);
			InclusiveRange.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InclusiveRange>.NativeClassPtr, 100665472);
		}

		// Token: 0x060010DA RID: 4314 RVA: 0x00050318 File Offset: 0x0004E518
		[CallerCount(0)]
		public unsafe InclusiveRange(short startEnd)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref startEnd;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InclusiveRange.NativeMethodInfoPtr__ctor_Public_Void_Int16_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060010DB RID: 4315 RVA: 0x0005034C File Offset: 0x0004E54C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 438691, RefRangeEnd = 438696, XrefRangeStart = 438691, XrefRangeEnd = 438696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InclusiveRange(short start, short end)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref start;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InclusiveRange.NativeMethodInfoPtr__ctor_Public_Void_Int16_Int16_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010DC RID: 4316 RVA: 0x0005038C File Offset: 0x0004E58C
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 617877, RefRangeEnd = 617891, XrefRangeStart = 617872, XrefRangeEnd = 617877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Expand(short index)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InclusiveRange.NativeMethodInfoPtr_Expand_Public_Void_Int16_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060010DD RID: 4317 RVA: 0x000503C0 File Offset: 0x0004E5C0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 617896, RefRangeEnd = 617900, XrefRangeStart = 617891, XrefRangeEnd = 617896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clamp(short min, short max)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref min;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref max;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InclusiveRange.NativeMethodInfoPtr_Clamp_Public_Void_Int16_Int16_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170005F5 RID: 1525
		// (get) Token: 0x060010DE RID: 4318 RVA: 0x00050400 File Offset: 0x0004E600
		public unsafe bool isEmpty
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 617900, RefRangeEnd = 617901, XrefRangeStart = 617900, XrefRangeEnd = 617900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InclusiveRange.NativeMethodInfoPtr_get_isEmpty_Public_get_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060010DF RID: 4319 RVA: 0x00050430 File Offset: 0x0004E630
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 617901, RefRangeEnd = 617902, XrefRangeStart = 617901, XrefRangeEnd = 617901, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Contains(short index)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InclusiveRange.NativeMethodInfoPtr_Contains_Public_Boolean_Int16_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060010E0 RID: 4320 RVA: 0x00050470 File Offset: 0x0004E670
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 617907, RefRangeEnd = 617915, XrefRangeStart = 617902, XrefRangeEnd = 617907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static InclusiveRange Merge(InclusiveRange a, InclusiveRange b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InclusiveRange.NativeMethodInfoPtr_Merge_Public_Static_InclusiveRange_InclusiveRange_InclusiveRange_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170005F6 RID: 1526
		// (get) Token: 0x060010E1 RID: 4321 RVA: 0x000504BC File Offset: 0x0004E6BC
		public unsafe static InclusiveRange empty
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 617915, RefRangeEnd = 617919, XrefRangeStart = 617915, XrefRangeEnd = 617915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InclusiveRange.NativeMethodInfoPtr_get_empty_Public_Static_get_InclusiveRange_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060010E2 RID: 4322 RVA: 0x000504EC File Offset: 0x0004E6EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 617919, XrefRangeEnd = 617927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InclusiveRange.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060010E3 RID: 4323 RVA: 0x0000A003 File Offset: 0x00008203
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<InclusiveRange>.NativeClassPtr, ref this));
		}

		// Token: 0x04000C5C RID: 3164
		private static readonly IntPtr NativeFieldInfoPtr_start;

		// Token: 0x04000C5D RID: 3165
		private static readonly IntPtr NativeFieldInfoPtr_end;

		// Token: 0x04000C5E RID: 3166
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int16_0;

		// Token: 0x04000C5F RID: 3167
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int16_Int16_0;

		// Token: 0x04000C60 RID: 3168
		private static readonly IntPtr NativeMethodInfoPtr_Expand_Public_Void_Int16_0;

		// Token: 0x04000C61 RID: 3169
		private static readonly IntPtr NativeMethodInfoPtr_Clamp_Public_Void_Int16_Int16_0;

		// Token: 0x04000C62 RID: 3170
		private static readonly IntPtr NativeMethodInfoPtr_get_isEmpty_Public_get_Boolean_0;

		// Token: 0x04000C63 RID: 3171
		private static readonly IntPtr NativeMethodInfoPtr_Contains_Public_Boolean_Int16_0;

		// Token: 0x04000C64 RID: 3172
		private static readonly IntPtr NativeMethodInfoPtr_Merge_Public_Static_InclusiveRange_InclusiveRange_InclusiveRange_0;

		// Token: 0x04000C65 RID: 3173
		private static readonly IntPtr NativeMethodInfoPtr_get_empty_Public_Static_get_InclusiveRange_0;

		// Token: 0x04000C66 RID: 3174
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000C67 RID: 3175
		[FieldOffset(0)]
		public short start;

		// Token: 0x04000C68 RID: 3176
		[FieldOffset(2)]
		public short end;
	}
}
