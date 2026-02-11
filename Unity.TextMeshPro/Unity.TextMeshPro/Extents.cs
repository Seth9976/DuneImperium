using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace TMPro
{
	// Token: 0x0200001A RID: 26
	[StructLayout(2)]
	public struct Extents
	{
		// Token: 0x0600025F RID: 607 RVA: 0x0001234C File Offset: 0x0001054C
		// Note: this type is marked as 'beforefieldinit'.
		static Extents()
		{
			Il2CppClassPointerStore<Extents>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "Extents");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Extents>.NativeClassPtr);
			Extents.NativeFieldInfoPtr_zero = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Extents>.NativeClassPtr, "zero");
			Extents.NativeFieldInfoPtr_uninitialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Extents>.NativeClassPtr, "uninitialized");
			Extents.NativeFieldInfoPtr_min = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Extents>.NativeClassPtr, "min");
			Extents.NativeFieldInfoPtr_max = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Extents>.NativeClassPtr, "max");
			Extents.NativeMethodInfoPtr__ctor_Public_Void_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Extents>.NativeClassPtr, 100663578);
			Extents.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Extents>.NativeClassPtr, 100663579);
		}

		// Token: 0x06000260 RID: 608 RVA: 0x000123F4 File Offset: 0x000105F4
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 636721, RefRangeEnd = 636742, XrefRangeStart = 636721, XrefRangeEnd = 636742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Extents(Vector2 min, Vector2 max)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref min;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref max;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Extents.NativeMethodInfoPtr__ctor_Public_Void_Vector2_Vector2_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000261 RID: 609 RVA: 0x00012434 File Offset: 0x00010634
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1037949, XrefRangeEnd = 1037989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Extents.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000262 RID: 610 RVA: 0x00002EE1 File Offset: 0x000010E1
		public global::Il2CppSystem.Object BoxIl2CppObject()
		{
			return new global::Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Extents>.NativeClassPtr, ref this));
		}

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x06000263 RID: 611 RVA: 0x00012460 File Offset: 0x00010660
		// (set) Token: 0x06000264 RID: 612 RVA: 0x00002EF3 File Offset: 0x000010F3
		public unsafe static Extents zero
		{
			get
			{
				Extents extents;
				IL2CPP.il2cpp_field_static_get_value(Extents.NativeFieldInfoPtr_zero, (void*)(&extents));
				return extents;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Extents.NativeFieldInfoPtr_zero, (void*)(&value));
			}
		}

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x06000265 RID: 613 RVA: 0x0001247C File Offset: 0x0001067C
		// (set) Token: 0x06000266 RID: 614 RVA: 0x00002F01 File Offset: 0x00001101
		public unsafe static Extents uninitialized
		{
			get
			{
				Extents extents;
				IL2CPP.il2cpp_field_static_get_value(Extents.NativeFieldInfoPtr_uninitialized, (void*)(&extents));
				return extents;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Extents.NativeFieldInfoPtr_uninitialized, (void*)(&value));
			}
		}

		// Token: 0x040001CB RID: 459
		private static readonly IntPtr NativeFieldInfoPtr_zero;

		// Token: 0x040001CC RID: 460
		private static readonly IntPtr NativeFieldInfoPtr_uninitialized;

		// Token: 0x040001CD RID: 461
		private static readonly IntPtr NativeFieldInfoPtr_min;

		// Token: 0x040001CE RID: 462
		private static readonly IntPtr NativeFieldInfoPtr_max;

		// Token: 0x040001CF RID: 463
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Vector2_Vector2_0;

		// Token: 0x040001D0 RID: 464
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x040001D1 RID: 465
		[FieldOffset(0)]
		public Vector2 min;

		// Token: 0x040001D2 RID: 466
		[FieldOffset(8)]
		public Vector2 max;
	}
}
