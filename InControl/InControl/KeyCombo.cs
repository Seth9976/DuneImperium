using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.IO;
using Il2CppSystem.Text;

namespace InControl
{
	// Token: 0x02000016 RID: 22
	[StructLayout(2)]
	public struct KeyCombo
	{
		// Token: 0x060000BD RID: 189 RVA: 0x0000A41C File Offset: 0x0000861C
		// Note: this type is marked as 'beforefieldinit'.
		static KeyCombo()
		{
			Il2CppClassPointerStore<KeyCombo>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl", "KeyCombo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KeyCombo>.NativeClassPtr);
			KeyCombo.NativeFieldInfoPtr_Empty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeyCombo>.NativeClassPtr, "Empty");
			KeyCombo.NativeFieldInfoPtr_includeSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeyCombo>.NativeClassPtr, "includeSize");
			KeyCombo.NativeFieldInfoPtr_includeData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeyCombo>.NativeClassPtr, "includeData");
			KeyCombo.NativeFieldInfoPtr_excludeSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeyCombo>.NativeClassPtr, "excludeSize");
			KeyCombo.NativeFieldInfoPtr_excludeData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeyCombo>.NativeClassPtr, "excludeData");
			KeyCombo.NativeFieldInfoPtr_cachedStrings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeyCombo>.NativeClassPtr, "cachedStrings");
			KeyCombo.NativeFieldInfoPtr_cachedStringBuilder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeyCombo>.NativeClassPtr, "cachedStringBuilder");
			KeyCombo.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Key_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyCombo>.NativeClassPtr, 100663410);
			KeyCombo.NativeMethodInfoPtr_AddIncludeInt_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyCombo>.NativeClassPtr, 100663411);
			KeyCombo.NativeMethodInfoPtr_GetIncludeInt_Private_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyCombo>.NativeClassPtr, 100663412);
			KeyCombo.NativeMethodInfoPtr_Add_Public_Void_Key_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyCombo>.NativeClassPtr, 100663413);
			KeyCombo.NativeMethodInfoPtr_Get_Public_Key_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyCombo>.NativeClassPtr, 100663414);
			KeyCombo.NativeMethodInfoPtr_AddInclude_Public_Void_Key_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyCombo>.NativeClassPtr, 100663415);
			KeyCombo.NativeMethodInfoPtr_GetInclude_Public_Key_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyCombo>.NativeClassPtr, 100663416);
			KeyCombo.NativeMethodInfoPtr_AddExcludeInt_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyCombo>.NativeClassPtr, 100663417);
			KeyCombo.NativeMethodInfoPtr_GetExcludeInt_Private_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyCombo>.NativeClassPtr, 100663418);
			KeyCombo.NativeMethodInfoPtr_AddExclude_Public_Void_Key_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyCombo>.NativeClassPtr, 100663419);
			KeyCombo.NativeMethodInfoPtr_GetExclude_Public_Key_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyCombo>.NativeClassPtr, 100663420);
			KeyCombo.NativeMethodInfoPtr_With_Public_Static_KeyCombo_Il2CppStructArray_1_Key_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyCombo>.NativeClassPtr, 100663421);
			KeyCombo.NativeMethodInfoPtr_AndNot_Public_KeyCombo_Il2CppStructArray_1_Key_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyCombo>.NativeClassPtr, 100663422);
			KeyCombo.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyCombo>.NativeClassPtr, 100663423);
			KeyCombo.NativeMethodInfoPtr_get_Count_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyCombo>.NativeClassPtr, 100663424);
			KeyCombo.NativeMethodInfoPtr_get_IncludeCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyCombo>.NativeClassPtr, 100663425);
			KeyCombo.NativeMethodInfoPtr_get_ExcludeCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyCombo>.NativeClassPtr, 100663426);
			KeyCombo.NativeMethodInfoPtr_get_IsPressed_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyCombo>.NativeClassPtr, 100663427);
			KeyCombo.NativeMethodInfoPtr_Detect_Public_Static_KeyCombo_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyCombo>.NativeClassPtr, 100663428);
			KeyCombo.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyCombo>.NativeClassPtr, 100663429);
			KeyCombo.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_KeyCombo_KeyCombo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyCombo>.NativeClassPtr, 100663430);
			KeyCombo.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_KeyCombo_KeyCombo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyCombo>.NativeClassPtr, 100663431);
			KeyCombo.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyCombo>.NativeClassPtr, 100663432);
			KeyCombo.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyCombo>.NativeClassPtr, 100663433);
			KeyCombo.NativeMethodInfoPtr_Load_Internal_Void_BinaryReader_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyCombo>.NativeClassPtr, 100663434);
			KeyCombo.NativeMethodInfoPtr_Save_Internal_Void_BinaryWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyCombo>.NativeClassPtr, 100663435);
		}

		// Token: 0x060000BE RID: 190 RVA: 0x0000A6E0 File Offset: 0x000088E0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 767710, RefRangeEnd = 767713, XrefRangeStart = 767703, XrefRangeEnd = 767710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe KeyCombo([Optional] Il2CppStructArray<Key> keys)
		{
			if (keys == null)
			{
				keys = new Il2CppStructArray<Key>(0L);
			}
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(keys);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyCombo.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Key_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000BF RID: 191 RVA: 0x0000A724 File Offset: 0x00008924
		[CallerCount(0)]
		public unsafe void AddIncludeInt(int key)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref key;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyCombo.NativeMethodInfoPtr_AddIncludeInt_Private_Void_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x0000A758 File Offset: 0x00008958
		[CallerCount(0)]
		public unsafe int GetIncludeInt(int index)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyCombo.NativeMethodInfoPtr_GetIncludeInt_Private_Int32_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x0000A798 File Offset: 0x00008998
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 767713, XrefRangeEnd = 767719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Add(Key key)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref key;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyCombo.NativeMethodInfoPtr_Add_Public_Void_Key_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x0000A7CC File Offset: 0x000089CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 767719, XrefRangeEnd = 767723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Key Get(int index)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyCombo.NativeMethodInfoPtr_Get_Public_Key_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x0000A80C File Offset: 0x00008A0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 767723, XrefRangeEnd = 767726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddInclude(Key key)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref key;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyCombo.NativeMethodInfoPtr_AddInclude_Public_Void_Key_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x0000A840 File Offset: 0x00008A40
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 767729, RefRangeEnd = 767732, XrefRangeStart = 767726, XrefRangeEnd = 767729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Key GetInclude(int index)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyCombo.NativeMethodInfoPtr_GetInclude_Public_Key_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x0000A880 File Offset: 0x00008A80
		[CallerCount(0)]
		public unsafe void AddExcludeInt(int key)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref key;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyCombo.NativeMethodInfoPtr_AddExcludeInt_Private_Void_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x0000A8B4 File Offset: 0x00008AB4
		[CallerCount(0)]
		public unsafe int GetExcludeInt(int index)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyCombo.NativeMethodInfoPtr_GetExcludeInt_Private_Int32_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x0000A8F4 File Offset: 0x00008AF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 767732, XrefRangeEnd = 767735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddExclude(Key key)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref key;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyCombo.NativeMethodInfoPtr_AddExclude_Public_Void_Key_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x0000A928 File Offset: 0x00008B28
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 767738, RefRangeEnd = 767739, XrefRangeStart = 767735, XrefRangeEnd = 767738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Key GetExclude(int index)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyCombo.NativeMethodInfoPtr_GetExclude_Public_Key_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x0000A968 File Offset: 0x00008B68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 767739, XrefRangeEnd = 767740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static KeyCombo With([Optional] Il2CppStructArray<Key> keys)
		{
			if (keys == null)
			{
				keys = new Il2CppStructArray<Key>(0L);
			}
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(keys);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyCombo.NativeMethodInfoPtr_With_Public_Static_KeyCombo_Il2CppStructArray_1_Key_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000CA RID: 202 RVA: 0x0000A9B8 File Offset: 0x00008BB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 767740, XrefRangeEnd = 767747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe KeyCombo AndNot([Optional] Il2CppStructArray<Key> keys)
		{
			if (keys == null)
			{
				keys = new Il2CppStructArray<Key>(0L);
			}
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(keys);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyCombo.NativeMethodInfoPtr_AndNot_Public_KeyCombo_Il2CppStructArray_1_Key_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000CB RID: 203 RVA: 0x0000AA08 File Offset: 0x00008C08
		[CallerCount(0)]
		public unsafe void Clear()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyCombo.NativeMethodInfoPtr_Clear_Public_Void_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x060000CC RID: 204 RVA: 0x0000AA30 File Offset: 0x00008C30
		public unsafe int Count
		{
			[CallerCount(200)]
			[CachedScanResults(RefRangeStart = 306429, RefRangeEnd = 306629, XrefRangeStart = 306429, XrefRangeEnd = 306629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyCombo.NativeMethodInfoPtr_get_Count_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x060000CD RID: 205 RVA: 0x0000AA60 File Offset: 0x00008C60
		public unsafe int IncludeCount
		{
			[CallerCount(200)]
			[CachedScanResults(RefRangeStart = 306429, RefRangeEnd = 306629, XrefRangeStart = 306429, XrefRangeEnd = 306629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyCombo.NativeMethodInfoPtr_get_IncludeCount_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x060000CE RID: 206 RVA: 0x0000AA90 File Offset: 0x00008C90
		public unsafe int ExcludeCount
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 302497, RefRangeEnd = 302502, XrefRangeStart = 302497, XrefRangeEnd = 302502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyCombo.NativeMethodInfoPtr_get_ExcludeCount_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x060000CF RID: 207 RVA: 0x0000AAC0 File Offset: 0x00008CC0
		public unsafe bool IsPressed
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 767769, RefRangeEnd = 767771, XrefRangeStart = 767747, XrefRangeEnd = 767769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyCombo.NativeMethodInfoPtr_get_IsPressed_Public_get_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x0000AAF0 File Offset: 0x00008CF0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 767818, RefRangeEnd = 767819, XrefRangeStart = 767771, XrefRangeEnd = 767818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static KeyCombo Detect(bool modifiersAsKeys)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref modifiersAsKeys;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyCombo.NativeMethodInfoPtr_Detect_Public_Static_KeyCombo_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x0000AB30 File Offset: 0x00008D30
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 767855, RefRangeEnd = 767856, XrefRangeStart = 767819, XrefRangeEnd = 767855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyCombo.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x0000AB5C File Offset: 0x00008D5C
		[CallerCount(0)]
		public unsafe static bool operator ==(KeyCombo a, KeyCombo b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyCombo.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_KeyCombo_KeyCombo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x0000ABA8 File Offset: 0x00008DA8
		[CallerCount(0)]
		public unsafe static bool operator !=(KeyCombo a, KeyCombo b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyCombo.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_KeyCombo_KeyCombo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x0000ABF4 File Offset: 0x00008DF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 767856, XrefRangeEnd = 767859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyCombo.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x0000AC38 File Offset: 0x00008E38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 767859, XrefRangeEnd = 767861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyCombo.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x0000AC68 File Offset: 0x00008E68
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 767861, RefRangeEnd = 767862, XrefRangeStart = 767861, XrefRangeEnd = 767861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Load(BinaryReader reader, ushort dataFormatVersion)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dataFormatVersion;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyCombo.NativeMethodInfoPtr_Load_Internal_Void_BinaryReader_UInt16_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x0000ACAC File Offset: 0x00008EAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 767862, XrefRangeEnd = 767863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Save(BinaryWriter writer)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyCombo.NativeMethodInfoPtr_Save_Internal_Void_BinaryWriter_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x000023B2 File Offset: 0x000005B2
		public KeyCombo(params Key[] keys)
		{
			this = new KeyCombo(new Il2CppStructArray<Key>(keys));
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x000023C0 File Offset: 0x000005C0
		public static KeyCombo With(params Key[] keys)
		{
			return KeyCombo.With(new Il2CppStructArray<Key>(keys));
		}

		// Token: 0x060000DA RID: 218 RVA: 0x000023CD File Offset: 0x000005CD
		public KeyCombo AndNot(params Key[] keys)
		{
			return this.AndNot(new Il2CppStructArray<Key>(keys));
		}

		// Token: 0x060000DB RID: 219 RVA: 0x000023DB File Offset: 0x000005DB
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<KeyCombo>.NativeClassPtr, ref this));
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x060000DC RID: 220 RVA: 0x0000ACE4 File Offset: 0x00008EE4
		// (set) Token: 0x060000DD RID: 221 RVA: 0x000023ED File Offset: 0x000005ED
		public unsafe static KeyCombo Empty
		{
			get
			{
				KeyCombo keyCombo;
				IL2CPP.il2cpp_field_static_get_value(KeyCombo.NativeFieldInfoPtr_Empty, (void*)(&keyCombo));
				return keyCombo;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(KeyCombo.NativeFieldInfoPtr_Empty, (void*)(&value));
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x060000DE RID: 222 RVA: 0x0000AD00 File Offset: 0x00008F00
		// (set) Token: 0x060000DF RID: 223 RVA: 0x000023FB File Offset: 0x000005FB
		public unsafe static Dictionary<ulong, string> cachedStrings
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(KeyCombo.NativeFieldInfoPtr_cachedStrings, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<ulong, string>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(KeyCombo.NativeFieldInfoPtr_cachedStrings, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x060000E0 RID: 224 RVA: 0x0000AD28 File Offset: 0x00008F28
		// (set) Token: 0x060000E1 RID: 225 RVA: 0x0000240D File Offset: 0x0000060D
		public unsafe static StringBuilder cachedStringBuilder
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(KeyCombo.NativeFieldInfoPtr_cachedStringBuilder, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(KeyCombo.NativeFieldInfoPtr_cachedStringBuilder, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400014E RID: 334
		private static readonly IntPtr NativeFieldInfoPtr_Empty;

		// Token: 0x0400014F RID: 335
		private static readonly IntPtr NativeFieldInfoPtr_includeSize;

		// Token: 0x04000150 RID: 336
		private static readonly IntPtr NativeFieldInfoPtr_includeData;

		// Token: 0x04000151 RID: 337
		private static readonly IntPtr NativeFieldInfoPtr_excludeSize;

		// Token: 0x04000152 RID: 338
		private static readonly IntPtr NativeFieldInfoPtr_excludeData;

		// Token: 0x04000153 RID: 339
		private static readonly IntPtr NativeFieldInfoPtr_cachedStrings;

		// Token: 0x04000154 RID: 340
		private static readonly IntPtr NativeFieldInfoPtr_cachedStringBuilder;

		// Token: 0x04000155 RID: 341
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Key_0;

		// Token: 0x04000156 RID: 342
		private static readonly IntPtr NativeMethodInfoPtr_AddIncludeInt_Private_Void_Int32_0;

		// Token: 0x04000157 RID: 343
		private static readonly IntPtr NativeMethodInfoPtr_GetIncludeInt_Private_Int32_Int32_0;

		// Token: 0x04000158 RID: 344
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Void_Key_0;

		// Token: 0x04000159 RID: 345
		private static readonly IntPtr NativeMethodInfoPtr_Get_Public_Key_Int32_0;

		// Token: 0x0400015A RID: 346
		private static readonly IntPtr NativeMethodInfoPtr_AddInclude_Public_Void_Key_0;

		// Token: 0x0400015B RID: 347
		private static readonly IntPtr NativeMethodInfoPtr_GetInclude_Public_Key_Int32_0;

		// Token: 0x0400015C RID: 348
		private static readonly IntPtr NativeMethodInfoPtr_AddExcludeInt_Private_Void_Int32_0;

		// Token: 0x0400015D RID: 349
		private static readonly IntPtr NativeMethodInfoPtr_GetExcludeInt_Private_Int32_Int32_0;

		// Token: 0x0400015E RID: 350
		private static readonly IntPtr NativeMethodInfoPtr_AddExclude_Public_Void_Key_0;

		// Token: 0x0400015F RID: 351
		private static readonly IntPtr NativeMethodInfoPtr_GetExclude_Public_Key_Int32_0;

		// Token: 0x04000160 RID: 352
		private static readonly IntPtr NativeMethodInfoPtr_With_Public_Static_KeyCombo_Il2CppStructArray_1_Key_0;

		// Token: 0x04000161 RID: 353
		private static readonly IntPtr NativeMethodInfoPtr_AndNot_Public_KeyCombo_Il2CppStructArray_1_Key_0;

		// Token: 0x04000162 RID: 354
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

		// Token: 0x04000163 RID: 355
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_get_Int32_0;

		// Token: 0x04000164 RID: 356
		private static readonly IntPtr NativeMethodInfoPtr_get_IncludeCount_Public_get_Int32_0;

		// Token: 0x04000165 RID: 357
		private static readonly IntPtr NativeMethodInfoPtr_get_ExcludeCount_Public_get_Int32_0;

		// Token: 0x04000166 RID: 358
		private static readonly IntPtr NativeMethodInfoPtr_get_IsPressed_Public_get_Boolean_0;

		// Token: 0x04000167 RID: 359
		private static readonly IntPtr NativeMethodInfoPtr_Detect_Public_Static_KeyCombo_Boolean_0;

		// Token: 0x04000168 RID: 360
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000169 RID: 361
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_KeyCombo_KeyCombo_0;

		// Token: 0x0400016A RID: 362
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_KeyCombo_KeyCombo_0;

		// Token: 0x0400016B RID: 363
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x0400016C RID: 364
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x0400016D RID: 365
		private static readonly IntPtr NativeMethodInfoPtr_Load_Internal_Void_BinaryReader_UInt16_0;

		// Token: 0x0400016E RID: 366
		private static readonly IntPtr NativeMethodInfoPtr_Save_Internal_Void_BinaryWriter_0;

		// Token: 0x0400016F RID: 367
		[FieldOffset(0)]
		public int includeSize;

		// Token: 0x04000170 RID: 368
		[FieldOffset(8)]
		public ulong includeData;

		// Token: 0x04000171 RID: 369
		[FieldOffset(16)]
		public int excludeSize;

		// Token: 0x04000172 RID: 370
		[FieldOffset(24)]
		public ulong excludeData;
	}
}
