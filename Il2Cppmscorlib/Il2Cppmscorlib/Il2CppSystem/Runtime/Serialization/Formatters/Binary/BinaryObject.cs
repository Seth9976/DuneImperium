using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x02000352 RID: 850
	public sealed class BinaryObject : Object
	{
		// Token: 0x060032E0 RID: 13024 RVA: 0x001008EC File Offset: 0x000FEAEC
		// Note: this type is marked as 'beforefieldinit'.
		static BinaryObject()
		{
			Il2CppClassPointerStore<BinaryObject>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization.Formatters.Binary", "BinaryObject");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BinaryObject>.NativeClassPtr);
			BinaryObject.NativeFieldInfoPtr_objectId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryObject>.NativeClassPtr, "objectId");
			BinaryObject.NativeFieldInfoPtr_mapId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryObject>.NativeClassPtr, "mapId");
			BinaryObject.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryObject>.NativeClassPtr, 100671243);
			BinaryObject.NativeMethodInfoPtr_Set_Internal_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryObject>.NativeClassPtr, 100671244);
			BinaryObject.NativeMethodInfoPtr_Write_Public_Virtual_Final_New_Void___BinaryWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryObject>.NativeClassPtr, 100671245);
			BinaryObject.NativeMethodInfoPtr_Read_Public_Virtual_Final_New_Void___BinaryParser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryObject>.NativeClassPtr, 100671246);
			BinaryObject.NativeMethodInfoPtr_Dump_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryObject>.NativeClassPtr, 100671247);
		}

		// Token: 0x060032E1 RID: 13025 RVA: 0x001009A8 File Offset: 0x000FEBA8
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BinaryObject()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BinaryObject>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryObject.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060032E2 RID: 13026 RVA: 0x001009E4 File Offset: 0x000FEBE4
		[CallerCount(0)]
		public unsafe void Set(int objectId, int mapId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref objectId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mapId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryObject.NativeMethodInfoPtr_Set_Internal_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060032E3 RID: 13027 RVA: 0x00100A30 File Offset: 0x000FEC30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1387220, XrefRangeEnd = 1387221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Write(__BinaryWriter sout)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sout);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryObject.NativeMethodInfoPtr_Write_Public_Virtual_Final_New_Void___BinaryWriter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060032E4 RID: 13028 RVA: 0x00100A74 File Offset: 0x000FEC74
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1387217, RefRangeEnd = 1387220, XrefRangeStart = 1387217, XrefRangeEnd = 1387220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Read(__BinaryParser input)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(input);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryObject.NativeMethodInfoPtr_Read_Public_Virtual_Final_New_Void___BinaryParser_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060032E5 RID: 13029 RVA: 0x00100AB8 File Offset: 0x000FECB8
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dump()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryObject.NativeMethodInfoPtr_Dump_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060032E6 RID: 13030 RVA: 0x00011AA7 File Offset: 0x0000FCA7
		public BinaryObject(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000B8B RID: 2955
		// (get) Token: 0x060032E7 RID: 13031 RVA: 0x00100AEC File Offset: 0x000FECEC
		// (set) Token: 0x060032E8 RID: 13032 RVA: 0x00011AB0 File Offset: 0x0000FCB0
		public unsafe int objectId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryObject.NativeFieldInfoPtr_objectId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryObject.NativeFieldInfoPtr_objectId)) = value;
			}
		}

		// Token: 0x17000B8C RID: 2956
		// (get) Token: 0x060032E9 RID: 13033 RVA: 0x00100B14 File Offset: 0x000FED14
		// (set) Token: 0x060032EA RID: 13034 RVA: 0x00011ACB File Offset: 0x0000FCCB
		public unsafe int mapId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryObject.NativeFieldInfoPtr_mapId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryObject.NativeFieldInfoPtr_mapId)) = value;
			}
		}

		// Token: 0x04002A22 RID: 10786
		private static readonly IntPtr NativeFieldInfoPtr_objectId;

		// Token: 0x04002A23 RID: 10787
		private static readonly IntPtr NativeFieldInfoPtr_mapId;

		// Token: 0x04002A24 RID: 10788
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x04002A25 RID: 10789
		private static readonly IntPtr NativeMethodInfoPtr_Set_Internal_Void_Int32_Int32_0;

		// Token: 0x04002A26 RID: 10790
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_Final_New_Void___BinaryWriter_0;

		// Token: 0x04002A27 RID: 10791
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Virtual_Final_New_Void___BinaryParser_0;

		// Token: 0x04002A28 RID: 10792
		private static readonly IntPtr NativeMethodInfoPtr_Dump_Public_Void_0;
	}
}
