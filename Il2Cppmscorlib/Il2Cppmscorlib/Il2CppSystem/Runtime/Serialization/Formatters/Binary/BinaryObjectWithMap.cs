using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x02000359 RID: 857
	public sealed class BinaryObjectWithMap : Object
	{
		// Token: 0x06003339 RID: 13113 RVA: 0x001018DC File Offset: 0x000FFADC
		// Note: this type is marked as 'beforefieldinit'.
		static BinaryObjectWithMap()
		{
			Il2CppClassPointerStore<BinaryObjectWithMap>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization.Formatters.Binary", "BinaryObjectWithMap");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BinaryObjectWithMap>.NativeClassPtr);
			BinaryObjectWithMap.NativeFieldInfoPtr_binaryHeaderEnum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryObjectWithMap>.NativeClassPtr, "binaryHeaderEnum");
			BinaryObjectWithMap.NativeFieldInfoPtr_objectId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryObjectWithMap>.NativeClassPtr, "objectId");
			BinaryObjectWithMap.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryObjectWithMap>.NativeClassPtr, "name");
			BinaryObjectWithMap.NativeFieldInfoPtr_numMembers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryObjectWithMap>.NativeClassPtr, "numMembers");
			BinaryObjectWithMap.NativeFieldInfoPtr_memberNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryObjectWithMap>.NativeClassPtr, "memberNames");
			BinaryObjectWithMap.NativeFieldInfoPtr_assemId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryObjectWithMap>.NativeClassPtr, "assemId");
			BinaryObjectWithMap.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryObjectWithMap>.NativeClassPtr, 100671271);
			BinaryObjectWithMap.NativeMethodInfoPtr__ctor_Internal_Void_BinaryHeaderEnum_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryObjectWithMap>.NativeClassPtr, 100671272);
			BinaryObjectWithMap.NativeMethodInfoPtr_Set_Internal_Void_Int32_String_Int32_Il2CppStringArray_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryObjectWithMap>.NativeClassPtr, 100671273);
			BinaryObjectWithMap.NativeMethodInfoPtr_Write_Public_Virtual_Final_New_Void___BinaryWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryObjectWithMap>.NativeClassPtr, 100671274);
			BinaryObjectWithMap.NativeMethodInfoPtr_Read_Public_Virtual_Final_New_Void___BinaryParser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryObjectWithMap>.NativeClassPtr, 100671275);
			BinaryObjectWithMap.NativeMethodInfoPtr_Dump_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryObjectWithMap>.NativeClassPtr, 100671276);
		}

		// Token: 0x0600333A RID: 13114 RVA: 0x001019FC File Offset: 0x000FFBFC
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BinaryObjectWithMap()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BinaryObjectWithMap>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryObjectWithMap.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600333B RID: 13115 RVA: 0x00101A38 File Offset: 0x000FFC38
		[CallerCount(73)]
		[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BinaryObjectWithMap(BinaryHeaderEnum binaryHeaderEnum)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BinaryObjectWithMap>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref binaryHeaderEnum;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryObjectWithMap.NativeMethodInfoPtr__ctor_Internal_Void_BinaryHeaderEnum_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600333C RID: 13116 RVA: 0x00101A80 File Offset: 0x000FFC80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1387279, XrefRangeEnd = 1387281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Set(int objectId, string name, int numMembers, Il2CppStringArray memberNames, int assemId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref objectId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref numMembers;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(memberNames);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref assemId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryObjectWithMap.NativeMethodInfoPtr_Set_Internal_Void_Int32_String_Int32_Il2CppStringArray_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600333D RID: 13117 RVA: 0x00101B00 File Offset: 0x000FFD00
		[CallerCount(0)]
		public unsafe void Write(__BinaryWriter sout)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sout);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryObjectWithMap.NativeMethodInfoPtr_Write_Public_Virtual_Final_New_Void___BinaryWriter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600333E RID: 13118 RVA: 0x00101B44 File Offset: 0x000FFD44
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1387292, RefRangeEnd = 1387293, XrefRangeStart = 1387281, XrefRangeEnd = 1387292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Read(__BinaryParser input)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(input);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryObjectWithMap.NativeMethodInfoPtr_Read_Public_Virtual_Final_New_Void___BinaryParser_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600333F RID: 13119 RVA: 0x00101B88 File Offset: 0x000FFD88
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dump()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryObjectWithMap.NativeMethodInfoPtr_Dump_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003340 RID: 13120 RVA: 0x00011D95 File Offset: 0x0000FF95
		public BinaryObjectWithMap(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000BA3 RID: 2979
		// (get) Token: 0x06003341 RID: 13121 RVA: 0x00101BBC File Offset: 0x000FFDBC
		// (set) Token: 0x06003342 RID: 13122 RVA: 0x00011D9E File Offset: 0x0000FF9E
		public unsafe BinaryHeaderEnum binaryHeaderEnum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryObjectWithMap.NativeFieldInfoPtr_binaryHeaderEnum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryObjectWithMap.NativeFieldInfoPtr_binaryHeaderEnum)) = value;
			}
		}

		// Token: 0x17000BA4 RID: 2980
		// (get) Token: 0x06003343 RID: 13123 RVA: 0x00101BE4 File Offset: 0x000FFDE4
		// (set) Token: 0x06003344 RID: 13124 RVA: 0x00011DB9 File Offset: 0x0000FFB9
		public unsafe int objectId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryObjectWithMap.NativeFieldInfoPtr_objectId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryObjectWithMap.NativeFieldInfoPtr_objectId)) = value;
			}
		}

		// Token: 0x17000BA5 RID: 2981
		// (get) Token: 0x06003345 RID: 13125 RVA: 0x00101C0C File Offset: 0x000FFE0C
		// (set) Token: 0x06003346 RID: 13126 RVA: 0x00011DD4 File Offset: 0x0000FFD4
		public unsafe string name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryObjectWithMap.NativeFieldInfoPtr_name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryObjectWithMap.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000BA6 RID: 2982
		// (get) Token: 0x06003347 RID: 13127 RVA: 0x00101C34 File Offset: 0x000FFE34
		// (set) Token: 0x06003348 RID: 13128 RVA: 0x00011DF3 File Offset: 0x0000FFF3
		public unsafe int numMembers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryObjectWithMap.NativeFieldInfoPtr_numMembers);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryObjectWithMap.NativeFieldInfoPtr_numMembers)) = value;
			}
		}

		// Token: 0x17000BA7 RID: 2983
		// (get) Token: 0x06003349 RID: 13129 RVA: 0x00101C5C File Offset: 0x000FFE5C
		// (set) Token: 0x0600334A RID: 13130 RVA: 0x00011E0E File Offset: 0x0001000E
		public unsafe Il2CppStringArray memberNames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryObjectWithMap.NativeFieldInfoPtr_memberNames);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryObjectWithMap.NativeFieldInfoPtr_memberNames), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BA8 RID: 2984
		// (get) Token: 0x0600334B RID: 13131 RVA: 0x00101C8C File Offset: 0x000FFE8C
		// (set) Token: 0x0600334C RID: 13132 RVA: 0x00011E2D File Offset: 0x0001002D
		public unsafe int assemId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryObjectWithMap.NativeFieldInfoPtr_assemId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryObjectWithMap.NativeFieldInfoPtr_assemId)) = value;
			}
		}

		// Token: 0x04002A55 RID: 10837
		private static readonly IntPtr NativeFieldInfoPtr_binaryHeaderEnum;

		// Token: 0x04002A56 RID: 10838
		private static readonly IntPtr NativeFieldInfoPtr_objectId;

		// Token: 0x04002A57 RID: 10839
		private static readonly IntPtr NativeFieldInfoPtr_name;

		// Token: 0x04002A58 RID: 10840
		private static readonly IntPtr NativeFieldInfoPtr_numMembers;

		// Token: 0x04002A59 RID: 10841
		private static readonly IntPtr NativeFieldInfoPtr_memberNames;

		// Token: 0x04002A5A RID: 10842
		private static readonly IntPtr NativeFieldInfoPtr_assemId;

		// Token: 0x04002A5B RID: 10843
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x04002A5C RID: 10844
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_BinaryHeaderEnum_0;

		// Token: 0x04002A5D RID: 10845
		private static readonly IntPtr NativeMethodInfoPtr_Set_Internal_Void_Int32_String_Int32_Il2CppStringArray_Int32_0;

		// Token: 0x04002A5E RID: 10846
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_Final_New_Void___BinaryWriter_0;

		// Token: 0x04002A5F RID: 10847
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Virtual_Final_New_Void___BinaryParser_0;

		// Token: 0x04002A60 RID: 10848
		private static readonly IntPtr NativeMethodInfoPtr_Dump_Public_Void_0;
	}
}
