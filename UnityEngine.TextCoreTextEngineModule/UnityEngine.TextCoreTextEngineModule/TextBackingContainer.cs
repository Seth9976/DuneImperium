using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.TextCore.Text
{
	// Token: 0x02000027 RID: 39
	public sealed class TextBackingContainer : ValueType
	{
		// Token: 0x06000440 RID: 1088 RVA: 0x00012F08 File Offset: 0x00011108
		// Note: this type is marked as 'beforefieldinit'.
		static TextBackingContainer()
		{
			Il2CppClassPointerStore<TextBackingContainer>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.TextCoreTextEngineModule.dll", "UnityEngine.TextCore.Text", "TextBackingContainer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextBackingContainer>.NativeClassPtr);
			TextBackingContainer.NativeFieldInfoPtr_m_Array = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextBackingContainer>.NativeClassPtr, "m_Array");
			TextBackingContainer.NativeFieldInfoPtr_m_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextBackingContainer>.NativeClassPtr, "m_Count");
			TextBackingContainer.NativeMethodInfoPtr_get_Capacity_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextBackingContainer>.NativeClassPtr, 100663576);
			TextBackingContainer.NativeMethodInfoPtr_get_Count_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextBackingContainer>.NativeClassPtr, 100663577);
			TextBackingContainer.NativeMethodInfoPtr_set_Count_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextBackingContainer>.NativeClassPtr, 100663578);
			TextBackingContainer.NativeMethodInfoPtr_get_Item_Public_get_UInt32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextBackingContainer>.NativeClassPtr, 100663579);
			TextBackingContainer.NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextBackingContainer>.NativeClassPtr, 100663580);
			TextBackingContainer.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextBackingContainer>.NativeClassPtr, 100663581);
			TextBackingContainer.NativeMethodInfoPtr_Resize_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextBackingContainer>.NativeClassPtr, 100663582);
		}

		// Token: 0x170001AB RID: 427
		// (get) Token: 0x06000441 RID: 1089 RVA: 0x00012FEC File Offset: 0x000111EC
		public unsafe int Capacity
		{
			[CallerCount(22)]
			[CachedScanResults(RefRangeStart = 336051, RefRangeEnd = 336073, XrefRangeStart = 336051, XrefRangeEnd = 336073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextBackingContainer.NativeMethodInfoPtr_get_Capacity_Public_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001AC RID: 428
		// (get) Token: 0x06000442 RID: 1090 RVA: 0x00013030 File Offset: 0x00011230
		// (set) Token: 0x06000443 RID: 1091 RVA: 0x00013074 File Offset: 0x00011274
		public unsafe int Count
		{
			[CallerCount(27)]
			[CachedScanResults(RefRangeStart = 335516, RefRangeEnd = 335543, XrefRangeStart = 335516, XrefRangeEnd = 335543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextBackingContainer.NativeMethodInfoPtr_get_Count_Public_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 310301, RefRangeEnd = 310309, XrefRangeStart = 310301, XrefRangeEnd = 310309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextBackingContainer.NativeMethodInfoPtr_set_Count_Public_set_Void_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001AD RID: 429
		public unsafe uint this[int index]
		{
			[CallerCount(39)]
			[CachedScanResults(RefRangeStart = 1047231, RefRangeEnd = 1047270, XrefRangeStart = 1047231, XrefRangeEnd = 1047270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextBackingContainer.NativeMethodInfoPtr_get_Item_Public_get_UInt32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 1104510, RefRangeEnd = 1104516, XrefRangeStart = 1104506, XrefRangeEnd = 1104510, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextBackingContainer.NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_UInt32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000446 RID: 1094 RVA: 0x0001315C File Offset: 0x0001135C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1104520, RefRangeEnd = 1104521, XrefRangeStart = 1104516, XrefRangeEnd = 1104520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TextBackingContainer(int size)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextBackingContainer>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref size;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextBackingContainer.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000447 RID: 1095 RVA: 0x000131A8 File Offset: 0x000113A8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1104525, RefRangeEnd = 1104528, XrefRangeStart = 1104521, XrefRangeEnd = 1104525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Resize(int size)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref size;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextBackingContainer.NativeMethodInfoPtr_Resize_Public_Void_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000448 RID: 1096 RVA: 0x00004BB0 File Offset: 0x00002DB0
		public TextBackingContainer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000449 RID: 1097 RVA: 0x00004BB9 File Offset: 0x00002DB9
		public TextBackingContainer()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextBackingContainer>.NativeClassPtr))
		{
		}

		// Token: 0x170001A9 RID: 425
		// (get) Token: 0x0600044A RID: 1098 RVA: 0x000131EC File Offset: 0x000113EC
		// (set) Token: 0x0600044B RID: 1099 RVA: 0x00004BCB File Offset: 0x00002DCB
		public unsafe Il2CppStructArray<uint> m_Array
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextBackingContainer.NativeFieldInfoPtr_m_Array);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<uint>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextBackingContainer.NativeFieldInfoPtr_m_Array), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001AA RID: 426
		// (get) Token: 0x0600044C RID: 1100 RVA: 0x0001321C File Offset: 0x0001141C
		// (set) Token: 0x0600044D RID: 1101 RVA: 0x00004BEA File Offset: 0x00002DEA
		public unsafe int m_Count
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextBackingContainer.NativeFieldInfoPtr_m_Count);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextBackingContainer.NativeFieldInfoPtr_m_Count)) = value;
			}
		}

		// Token: 0x170001AE RID: 430
		// (get) Token: 0x0600044E RID: 1102 RVA: 0x00013244 File Offset: 0x00011444
		public Il2CppStructArray<uint> Text
		{
			get
			{
				return this.m_Array;
			}
		}

		// Token: 0x04000349 RID: 841
		private static readonly IntPtr NativeFieldInfoPtr_m_Array;

		// Token: 0x0400034A RID: 842
		private static readonly IntPtr NativeFieldInfoPtr_m_Count;

		// Token: 0x0400034B RID: 843
		private static readonly IntPtr NativeMethodInfoPtr_get_Capacity_Public_get_Int32_0;

		// Token: 0x0400034C RID: 844
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_get_Int32_0;

		// Token: 0x0400034D RID: 845
		private static readonly IntPtr NativeMethodInfoPtr_set_Count_Public_set_Void_Int32_0;

		// Token: 0x0400034E RID: 846
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_UInt32_Int32_0;

		// Token: 0x0400034F RID: 847
		private static readonly IntPtr NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_UInt32_0;

		// Token: 0x04000350 RID: 848
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04000351 RID: 849
		private static readonly IntPtr NativeMethodInfoPtr_Resize_Public_Void_Int32_0;
	}
}
