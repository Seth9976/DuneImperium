using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements.UIR
{
	// Token: 0x02000276 RID: 630
	[StructLayout(2)]
	public struct BMPAlloc
	{
		// Token: 0x06002E8A RID: 11914 RVA: 0x000C5E64 File Offset: 0x000C4064
		// Note: this type is marked as 'beforefieldinit'.
		static BMPAlloc()
		{
			Il2CppClassPointerStore<BMPAlloc>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements.UIR", "BMPAlloc");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BMPAlloc>.NativeClassPtr);
			BMPAlloc.NativeFieldInfoPtr_Invalid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BMPAlloc>.NativeClassPtr, "Invalid");
			BMPAlloc.NativeFieldInfoPtr_page = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BMPAlloc>.NativeClassPtr, "page");
			BMPAlloc.NativeFieldInfoPtr_pageLine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BMPAlloc>.NativeClassPtr, "pageLine");
			BMPAlloc.NativeFieldInfoPtr_bitIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BMPAlloc>.NativeClassPtr, "bitIndex");
			BMPAlloc.NativeFieldInfoPtr_ownedState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BMPAlloc>.NativeClassPtr, "ownedState");
			BMPAlloc.NativeMethodInfoPtr_Equals_Public_Boolean_BMPAlloc_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BMPAlloc>.NativeClassPtr, 100670053);
			BMPAlloc.NativeMethodInfoPtr_IsValid_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BMPAlloc>.NativeClassPtr, 100670054);
			BMPAlloc.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BMPAlloc>.NativeClassPtr, 100670055);
		}

		// Token: 0x06002E8B RID: 11915 RVA: 0x000C5F34 File Offset: 0x000C4134
		[CallerCount(0)]
		public unsafe bool Equals(BMPAlloc other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BMPAlloc.NativeMethodInfoPtr_Equals_Public_Boolean_BMPAlloc_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002E8C RID: 11916 RVA: 0x000C5F74 File Offset: 0x000C4174
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 352266, RefRangeEnd = 352267, XrefRangeStart = 352266, XrefRangeEnd = 352266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsValid()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BMPAlloc.NativeMethodInfoPtr_IsValid_Public_Boolean_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002E8D RID: 11917 RVA: 0x000C5FA4 File Offset: 0x000C41A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 352267, XrefRangeEnd = 352279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BMPAlloc.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002E8E RID: 11918 RVA: 0x00013383 File Offset: 0x00011583
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BMPAlloc>.NativeClassPtr, ref this));
		}

		// Token: 0x17000E92 RID: 3730
		// (get) Token: 0x06002E8F RID: 11919 RVA: 0x000C5FD0 File Offset: 0x000C41D0
		// (set) Token: 0x06002E90 RID: 11920 RVA: 0x00013395 File Offset: 0x00011595
		public unsafe static BMPAlloc Invalid
		{
			get
			{
				BMPAlloc bmpalloc;
				IL2CPP.il2cpp_field_static_get_value(BMPAlloc.NativeFieldInfoPtr_Invalid, (void*)(&bmpalloc));
				return bmpalloc;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BMPAlloc.NativeFieldInfoPtr_Invalid, (void*)(&value));
			}
		}

		// Token: 0x04002170 RID: 8560
		private static readonly IntPtr NativeFieldInfoPtr_Invalid;

		// Token: 0x04002171 RID: 8561
		private static readonly IntPtr NativeFieldInfoPtr_page;

		// Token: 0x04002172 RID: 8562
		private static readonly IntPtr NativeFieldInfoPtr_pageLine;

		// Token: 0x04002173 RID: 8563
		private static readonly IntPtr NativeFieldInfoPtr_bitIndex;

		// Token: 0x04002174 RID: 8564
		private static readonly IntPtr NativeFieldInfoPtr_ownedState;

		// Token: 0x04002175 RID: 8565
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Boolean_BMPAlloc_0;

		// Token: 0x04002176 RID: 8566
		private static readonly IntPtr NativeMethodInfoPtr_IsValid_Public_Boolean_0;

		// Token: 0x04002177 RID: 8567
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04002178 RID: 8568
		[FieldOffset(0)]
		public int page;

		// Token: 0x04002179 RID: 8569
		[FieldOffset(4)]
		public ushort pageLine;

		// Token: 0x0400217A RID: 8570
		[FieldOffset(6)]
		public byte bitIndex;

		// Token: 0x0400217B RID: 8571
		[FieldOffset(7)]
		public OwnedState ownedState;
	}
}
