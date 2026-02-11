using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem
{
	// Token: 0x02000169 RID: 361
	public class TermInfoReader : Object
	{
		// Token: 0x060018AA RID: 6314 RVA: 0x0009A5C4 File Offset: 0x000987C4
		// Note: this type is marked as 'beforefieldinit'.
		static TermInfoReader()
		{
			Il2CppClassPointerStore<TermInfoReader>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "TermInfoReader");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TermInfoReader>.NativeClassPtr);
			TermInfoReader.NativeFieldInfoPtr_boolSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TermInfoReader>.NativeClassPtr, "boolSize");
			TermInfoReader.NativeFieldInfoPtr_numSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TermInfoReader>.NativeClassPtr, "numSize");
			TermInfoReader.NativeFieldInfoPtr_strOffsets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TermInfoReader>.NativeClassPtr, "strOffsets");
			TermInfoReader.NativeFieldInfoPtr_buffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TermInfoReader>.NativeClassPtr, "buffer");
			TermInfoReader.NativeFieldInfoPtr_booleansOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TermInfoReader>.NativeClassPtr, "booleansOffset");
			TermInfoReader.NativeFieldInfoPtr_intOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TermInfoReader>.NativeClassPtr, "intOffset");
			TermInfoReader.NativeMethodInfoPtr__ctor_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TermInfoReader>.NativeClassPtr, 100667568);
			TermInfoReader.NativeMethodInfoPtr__ctor_Public_Void_String_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TermInfoReader>.NativeClassPtr, 100667569);
			TermInfoReader.NativeMethodInfoPtr_DetermineVersion_Private_Void_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TermInfoReader>.NativeClassPtr, 100667570);
			TermInfoReader.NativeMethodInfoPtr_ReadHeader_Private_Void_Il2CppStructArray_1_Byte_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TermInfoReader>.NativeClassPtr, 100667571);
			TermInfoReader.NativeMethodInfoPtr_ReadNames_Private_Void_Il2CppStructArray_1_Byte_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TermInfoReader>.NativeClassPtr, 100667572);
			TermInfoReader.NativeMethodInfoPtr_Get_Public_Int32_TermInfoNumbers_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TermInfoReader>.NativeClassPtr, 100667573);
			TermInfoReader.NativeMethodInfoPtr_Get_Public_String_TermInfoStrings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TermInfoReader>.NativeClassPtr, 100667574);
			TermInfoReader.NativeMethodInfoPtr_GetStringBytes_Public_Il2CppStructArray_1_Byte_TermInfoStrings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TermInfoReader>.NativeClassPtr, 100667575);
			TermInfoReader.NativeMethodInfoPtr_GetInt16_Private_Int16_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TermInfoReader>.NativeClassPtr, 100667576);
			TermInfoReader.NativeMethodInfoPtr_GetString_Private_String_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TermInfoReader>.NativeClassPtr, 100667577);
			TermInfoReader.NativeMethodInfoPtr_GetStringBytes_Private_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TermInfoReader>.NativeClassPtr, 100667578);
		}

		// Token: 0x060018AB RID: 6315 RVA: 0x0009A748 File Offset: 0x00098948
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1349509, RefRangeEnd = 1349510, XrefRangeStart = 1349496, XrefRangeEnd = 1349509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TermInfoReader(string term, string filename)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TermInfoReader>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(term);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(filename);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TermInfoReader.NativeMethodInfoPtr__ctor_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018AC RID: 6316 RVA: 0x0009A7A8 File Offset: 0x000989A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1349510, XrefRangeEnd = 1349519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TermInfoReader(string term, Il2CppStructArray<byte> buffer)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TermInfoReader>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(term);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TermInfoReader.NativeMethodInfoPtr__ctor_Public_Void_String_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018AD RID: 6317 RVA: 0x0009A808 File Offset: 0x00098A08
		[CallerCount(0)]
		public unsafe void DetermineVersion(short magic)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref magic;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TermInfoReader.NativeMethodInfoPtr_DetermineVersion_Private_Void_Int16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060018AE RID: 6318 RVA: 0x0009A848 File Offset: 0x00098A48
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1349523, RefRangeEnd = 1349527, XrefRangeStart = 1349519, XrefRangeEnd = 1349523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReadHeader(Il2CppStructArray<byte> buffer, ref int position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &position;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TermInfoReader.NativeMethodInfoPtr_ReadHeader_Private_Void_Il2CppStructArray_1_Byte_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018AF RID: 6319 RVA: 0x0009A898 File Offset: 0x00098A98
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1349529, RefRangeEnd = 1349533, XrefRangeStart = 1349527, XrefRangeEnd = 1349529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReadNames(Il2CppStructArray<byte> buffer, ref int position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &position;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TermInfoReader.NativeMethodInfoPtr_ReadNames_Private_Void_Il2CppStructArray_1_Byte_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018B0 RID: 6320 RVA: 0x0009A8E8 File Offset: 0x00098AE8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1349533, RefRangeEnd = 1349536, XrefRangeStart = 1349533, XrefRangeEnd = 1349533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int Get(TermInfoNumbers number)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref number;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TermInfoReader.NativeMethodInfoPtr_Get_Public_Int32_TermInfoNumbers_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060018B1 RID: 6321 RVA: 0x0009A934 File Offset: 0x00098B34
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 1349539, RefRangeEnd = 1349553, XrefRangeStart = 1349536, XrefRangeEnd = 1349539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string Get(TermInfoStrings tstr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref tstr;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TermInfoReader.NativeMethodInfoPtr_Get_Public_String_TermInfoStrings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060018B2 RID: 6322 RVA: 0x0009A978 File Offset: 0x00098B78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1349553, XrefRangeEnd = 1349559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<byte> GetStringBytes(TermInfoStrings tstr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref tstr;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TermInfoReader.NativeMethodInfoPtr_GetStringBytes_Public_Il2CppStructArray_1_Byte_TermInfoStrings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x060018B3 RID: 6323 RVA: 0x0009A9C4 File Offset: 0x00098BC4
		[CallerCount(0)]
		public unsafe short GetInt16(Il2CppStructArray<byte> buffer, int offset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TermInfoReader.NativeMethodInfoPtr_GetInt16_Private_Int16_Il2CppStructArray_1_Byte_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060018B4 RID: 6324 RVA: 0x0009AA20 File Offset: 0x00098C20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1349559, XrefRangeEnd = 1349561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetString(Il2CppStructArray<byte> buffer, int offset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TermInfoReader.NativeMethodInfoPtr_GetString_Private_String_Il2CppStructArray_1_Byte_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060018B5 RID: 6325 RVA: 0x0009AA78 File Offset: 0x00098C78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1349561, XrefRangeEnd = 1349566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<byte> GetStringBytes(Il2CppStructArray<byte> buffer, int offset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TermInfoReader.NativeMethodInfoPtr_GetStringBytes_Private_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x060018B6 RID: 6326 RVA: 0x00007E37 File Offset: 0x00006037
		public TermInfoReader(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000464 RID: 1124
		// (get) Token: 0x060018B7 RID: 6327 RVA: 0x0009AAD8 File Offset: 0x00098CD8
		// (set) Token: 0x060018B8 RID: 6328 RVA: 0x00007E40 File Offset: 0x00006040
		public unsafe int boolSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoReader.NativeFieldInfoPtr_boolSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoReader.NativeFieldInfoPtr_boolSize)) = value;
			}
		}

		// Token: 0x17000465 RID: 1125
		// (get) Token: 0x060018B9 RID: 6329 RVA: 0x0009AB00 File Offset: 0x00098D00
		// (set) Token: 0x060018BA RID: 6330 RVA: 0x00007E5B File Offset: 0x0000605B
		public unsafe int numSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoReader.NativeFieldInfoPtr_numSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoReader.NativeFieldInfoPtr_numSize)) = value;
			}
		}

		// Token: 0x17000466 RID: 1126
		// (get) Token: 0x060018BB RID: 6331 RVA: 0x0009AB28 File Offset: 0x00098D28
		// (set) Token: 0x060018BC RID: 6332 RVA: 0x00007E76 File Offset: 0x00006076
		public unsafe int strOffsets
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoReader.NativeFieldInfoPtr_strOffsets);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoReader.NativeFieldInfoPtr_strOffsets)) = value;
			}
		}

		// Token: 0x17000467 RID: 1127
		// (get) Token: 0x060018BD RID: 6333 RVA: 0x0009AB50 File Offset: 0x00098D50
		// (set) Token: 0x060018BE RID: 6334 RVA: 0x00007E91 File Offset: 0x00006091
		public unsafe Il2CppStructArray<byte> buffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoReader.NativeFieldInfoPtr_buffer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoReader.NativeFieldInfoPtr_buffer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000468 RID: 1128
		// (get) Token: 0x060018BF RID: 6335 RVA: 0x0009AB80 File Offset: 0x00098D80
		// (set) Token: 0x060018C0 RID: 6336 RVA: 0x00007EB0 File Offset: 0x000060B0
		public unsafe int booleansOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoReader.NativeFieldInfoPtr_booleansOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoReader.NativeFieldInfoPtr_booleansOffset)) = value;
			}
		}

		// Token: 0x17000469 RID: 1129
		// (get) Token: 0x060018C1 RID: 6337 RVA: 0x0009ABA8 File Offset: 0x00098DA8
		// (set) Token: 0x060018C2 RID: 6338 RVA: 0x00007ECB File Offset: 0x000060CB
		public unsafe int intOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoReader.NativeFieldInfoPtr_intOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoReader.NativeFieldInfoPtr_intOffset)) = value;
			}
		}

		// Token: 0x0400152D RID: 5421
		private static readonly IntPtr NativeFieldInfoPtr_boolSize;

		// Token: 0x0400152E RID: 5422
		private static readonly IntPtr NativeFieldInfoPtr_numSize;

		// Token: 0x0400152F RID: 5423
		private static readonly IntPtr NativeFieldInfoPtr_strOffsets;

		// Token: 0x04001530 RID: 5424
		private static readonly IntPtr NativeFieldInfoPtr_buffer;

		// Token: 0x04001531 RID: 5425
		private static readonly IntPtr NativeFieldInfoPtr_booleansOffset;

		// Token: 0x04001532 RID: 5426
		private static readonly IntPtr NativeFieldInfoPtr_intOffset;

		// Token: 0x04001533 RID: 5427
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_0;

		// Token: 0x04001534 RID: 5428
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Il2CppStructArray_1_Byte_0;

		// Token: 0x04001535 RID: 5429
		private static readonly IntPtr NativeMethodInfoPtr_DetermineVersion_Private_Void_Int16_0;

		// Token: 0x04001536 RID: 5430
		private static readonly IntPtr NativeMethodInfoPtr_ReadHeader_Private_Void_Il2CppStructArray_1_Byte_byref_Int32_0;

		// Token: 0x04001537 RID: 5431
		private static readonly IntPtr NativeMethodInfoPtr_ReadNames_Private_Void_Il2CppStructArray_1_Byte_byref_Int32_0;

		// Token: 0x04001538 RID: 5432
		private static readonly IntPtr NativeMethodInfoPtr_Get_Public_Int32_TermInfoNumbers_0;

		// Token: 0x04001539 RID: 5433
		private static readonly IntPtr NativeMethodInfoPtr_Get_Public_String_TermInfoStrings_0;

		// Token: 0x0400153A RID: 5434
		private static readonly IntPtr NativeMethodInfoPtr_GetStringBytes_Public_Il2CppStructArray_1_Byte_TermInfoStrings_0;

		// Token: 0x0400153B RID: 5435
		private static readonly IntPtr NativeMethodInfoPtr_GetInt16_Private_Int16_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x0400153C RID: 5436
		private static readonly IntPtr NativeMethodInfoPtr_GetString_Private_String_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x0400153D RID: 5437
		private static readonly IntPtr NativeMethodInfoPtr_GetStringBytes_Private_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Int32_0;
	}
}
