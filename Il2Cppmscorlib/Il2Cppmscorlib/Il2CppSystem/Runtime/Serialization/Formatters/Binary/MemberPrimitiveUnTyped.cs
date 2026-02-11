using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x0200035C RID: 860
	public sealed class MemberPrimitiveUnTyped : Object
	{
		// Token: 0x0600337F RID: 13183 RVA: 0x001025CC File Offset: 0x001007CC
		// Note: this type is marked as 'beforefieldinit'.
		static MemberPrimitiveUnTyped()
		{
			Il2CppClassPointerStore<MemberPrimitiveUnTyped>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization.Formatters.Binary", "MemberPrimitiveUnTyped");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MemberPrimitiveUnTyped>.NativeClassPtr);
			MemberPrimitiveUnTyped.NativeFieldInfoPtr_typeInformation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemberPrimitiveUnTyped>.NativeClassPtr, "typeInformation");
			MemberPrimitiveUnTyped.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemberPrimitiveUnTyped>.NativeClassPtr, "value");
			MemberPrimitiveUnTyped.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemberPrimitiveUnTyped>.NativeClassPtr, 100671287);
			MemberPrimitiveUnTyped.NativeMethodInfoPtr_Set_Internal_Void_InternalPrimitiveTypeE_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemberPrimitiveUnTyped>.NativeClassPtr, 100671288);
			MemberPrimitiveUnTyped.NativeMethodInfoPtr_Set_Internal_Void_InternalPrimitiveTypeE_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemberPrimitiveUnTyped>.NativeClassPtr, 100671289);
			MemberPrimitiveUnTyped.NativeMethodInfoPtr_Write_Public_Virtual_Final_New_Void___BinaryWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemberPrimitiveUnTyped>.NativeClassPtr, 100671290);
			MemberPrimitiveUnTyped.NativeMethodInfoPtr_Read_Public_Virtual_Final_New_Void___BinaryParser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemberPrimitiveUnTyped>.NativeClassPtr, 100671291);
			MemberPrimitiveUnTyped.NativeMethodInfoPtr_Dump_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemberPrimitiveUnTyped>.NativeClassPtr, 100671292);
		}

		// Token: 0x06003380 RID: 13184 RVA: 0x0010269C File Offset: 0x0010089C
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MemberPrimitiveUnTyped()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MemberPrimitiveUnTyped>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemberPrimitiveUnTyped.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003381 RID: 13185 RVA: 0x001026D8 File Offset: 0x001008D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Set(InternalPrimitiveTypeE typeInformation, Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref typeInformation;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemberPrimitiveUnTyped.NativeMethodInfoPtr_Set_Internal_Void_InternalPrimitiveTypeE_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003382 RID: 13186 RVA: 0x00102728 File Offset: 0x00100928
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 307807, RefRangeEnd = 307812, XrefRangeStart = 307807, XrefRangeEnd = 307812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Set(InternalPrimitiveTypeE typeInformation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref typeInformation;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemberPrimitiveUnTyped.NativeMethodInfoPtr_Set_Internal_Void_InternalPrimitiveTypeE_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003383 RID: 13187 RVA: 0x00102768 File Offset: 0x00100968
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1387385, XrefRangeEnd = 1387387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Write(__BinaryWriter sout)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sout);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemberPrimitiveUnTyped.NativeMethodInfoPtr_Write_Public_Virtual_Final_New_Void___BinaryWriter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003384 RID: 13188 RVA: 0x001027AC File Offset: 0x001009AC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1387390, RefRangeEnd = 1387391, XrefRangeStart = 1387387, XrefRangeEnd = 1387390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Read(__BinaryParser input)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(input);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemberPrimitiveUnTyped.NativeMethodInfoPtr_Read_Public_Virtual_Final_New_Void___BinaryParser_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003385 RID: 13189 RVA: 0x001027F0 File Offset: 0x001009F0
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dump()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemberPrimitiveUnTyped.NativeMethodInfoPtr_Dump_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003386 RID: 13190 RVA: 0x00012060 File Offset: 0x00010260
		public MemberPrimitiveUnTyped(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000BBB RID: 3003
		// (get) Token: 0x06003387 RID: 13191 RVA: 0x00102824 File Offset: 0x00100A24
		// (set) Token: 0x06003388 RID: 13192 RVA: 0x00012069 File Offset: 0x00010269
		public unsafe InternalPrimitiveTypeE typeInformation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemberPrimitiveUnTyped.NativeFieldInfoPtr_typeInformation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemberPrimitiveUnTyped.NativeFieldInfoPtr_typeInformation)) = value;
			}
		}

		// Token: 0x17000BBC RID: 3004
		// (get) Token: 0x06003389 RID: 13193 RVA: 0x0010284C File Offset: 0x00100A4C
		// (set) Token: 0x0600338A RID: 13194 RVA: 0x00012084 File Offset: 0x00010284
		public unsafe Object value
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemberPrimitiveUnTyped.NativeFieldInfoPtr_value);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemberPrimitiveUnTyped.NativeFieldInfoPtr_value), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002A7D RID: 10877
		private static readonly IntPtr NativeFieldInfoPtr_typeInformation;

		// Token: 0x04002A7E RID: 10878
		private static readonly IntPtr NativeFieldInfoPtr_value;

		// Token: 0x04002A7F RID: 10879
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x04002A80 RID: 10880
		private static readonly IntPtr NativeMethodInfoPtr_Set_Internal_Void_InternalPrimitiveTypeE_Object_0;

		// Token: 0x04002A81 RID: 10881
		private static readonly IntPtr NativeMethodInfoPtr_Set_Internal_Void_InternalPrimitiveTypeE_0;

		// Token: 0x04002A82 RID: 10882
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_Final_New_Void___BinaryWriter_0;

		// Token: 0x04002A83 RID: 10883
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Virtual_Final_New_Void___BinaryParser_0;

		// Token: 0x04002A84 RID: 10884
		private static readonly IntPtr NativeMethodInfoPtr_Dump_Public_Void_0;
	}
}
