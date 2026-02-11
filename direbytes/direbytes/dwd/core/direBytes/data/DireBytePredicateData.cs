using System;
using dwd.core.data.composition;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace dwd.core.direBytes.data
{
	// Token: 0x0200001F RID: 31
	public class DireBytePredicateData : DataComponent
	{
		// Token: 0x06000168 RID: 360 RVA: 0x0000759C File Offset: 0x0000579C
		// Note: this type is marked as 'beforefieldinit'.
		static DireBytePredicateData()
		{
			Il2CppClassPointerStore<DireBytePredicateData>.NativeClassPtr = IL2CPP.GetIl2CppClass("direbytes.dll", "dwd.core.direBytes.data", "DireBytePredicateData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DireBytePredicateData>.NativeClassPtr);
			DireBytePredicateData.NativeFieldInfoPtr__Hint_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DireBytePredicateData>.NativeClassPtr, "<Hint>k__BackingField");
			DireBytePredicateData.NativeFieldInfoPtr__ProductId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DireBytePredicateData>.NativeClassPtr, "<ProductId>k__BackingField");
			DireBytePredicateData.NativeFieldInfoPtr__ProductIds_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DireBytePredicateData>.NativeClassPtr, "<ProductIds>k__BackingField");
			DireBytePredicateData.NativeMethodInfoPtr_get_Hint_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DireBytePredicateData>.NativeClassPtr, 100663437);
			DireBytePredicateData.NativeMethodInfoPtr_get_ProductId_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DireBytePredicateData>.NativeClassPtr, 100663438);
			DireBytePredicateData.NativeMethodInfoPtr_get_ProductIds_Public_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DireBytePredicateData>.NativeClassPtr, 100663439);
			DireBytePredicateData.NativeMethodInfoPtr__ctor_Public_Void_String_String_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DireBytePredicateData>.NativeClassPtr, 100663440);
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x06000169 RID: 361 RVA: 0x00007658 File Offset: 0x00005858
		public unsafe string Hint
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DireBytePredicateData.NativeMethodInfoPtr_get_Hint_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x0600016A RID: 362 RVA: 0x00007690 File Offset: 0x00005890
		public unsafe string ProductId
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DireBytePredicateData.NativeMethodInfoPtr_get_ProductId_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x0600016B RID: 363 RVA: 0x000076C8 File Offset: 0x000058C8
		public unsafe Il2CppStringArray ProductIds
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DireBytePredicateData.NativeMethodInfoPtr_get_ProductIds_Public_get_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x0600016C RID: 364 RVA: 0x00007708 File Offset: 0x00005908
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 711769, RefRangeEnd = 711771, XrefRangeStart = 711769, XrefRangeEnd = 711771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DireBytePredicateData(string hint, string productId, Il2CppStringArray productIds)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DireBytePredicateData>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(hint);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(productId);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(productIds);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DireBytePredicateData.NativeMethodInfoPtr__ctor_Public_Void_String_String_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600016D RID: 365 RVA: 0x00002C8B File Offset: 0x00000E8B
		public DireBytePredicateData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x0600016E RID: 366 RVA: 0x00007778 File Offset: 0x00005978
		// (set) Token: 0x0600016F RID: 367 RVA: 0x00002C94 File Offset: 0x00000E94
		public unsafe string _Hint_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireBytePredicateData.NativeFieldInfoPtr__Hint_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireBytePredicateData.NativeFieldInfoPtr__Hint_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x06000170 RID: 368 RVA: 0x000077A0 File Offset: 0x000059A0
		// (set) Token: 0x06000171 RID: 369 RVA: 0x00002CB3 File Offset: 0x00000EB3
		public unsafe string _ProductId_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireBytePredicateData.NativeFieldInfoPtr__ProductId_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireBytePredicateData.NativeFieldInfoPtr__ProductId_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x06000172 RID: 370 RVA: 0x000077C8 File Offset: 0x000059C8
		// (set) Token: 0x06000173 RID: 371 RVA: 0x00002CD2 File Offset: 0x00000ED2
		public unsafe Il2CppStringArray _ProductIds_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireBytePredicateData.NativeFieldInfoPtr__ProductIds_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireBytePredicateData.NativeFieldInfoPtr__ProductIds_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040000CA RID: 202
		private static readonly IntPtr NativeFieldInfoPtr__Hint_k__BackingField;

		// Token: 0x040000CB RID: 203
		private static readonly IntPtr NativeFieldInfoPtr__ProductId_k__BackingField;

		// Token: 0x040000CC RID: 204
		private static readonly IntPtr NativeFieldInfoPtr__ProductIds_k__BackingField;

		// Token: 0x040000CD RID: 205
		private static readonly IntPtr NativeMethodInfoPtr_get_Hint_Public_get_String_0;

		// Token: 0x040000CE RID: 206
		private static readonly IntPtr NativeMethodInfoPtr_get_ProductId_Public_get_String_0;

		// Token: 0x040000CF RID: 207
		private static readonly IntPtr NativeMethodInfoPtr_get_ProductIds_Public_get_Il2CppStringArray_0;

		// Token: 0x040000D0 RID: 208
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_Il2CppStringArray_0;
	}
}
