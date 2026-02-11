using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x02000358 RID: 856
	public sealed class MemberPrimitiveTyped : Object
	{
		// Token: 0x0600332E RID: 13102 RVA: 0x00101680 File Offset: 0x000FF880
		// Note: this type is marked as 'beforefieldinit'.
		static MemberPrimitiveTyped()
		{
			Il2CppClassPointerStore<MemberPrimitiveTyped>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization.Formatters.Binary", "MemberPrimitiveTyped");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MemberPrimitiveTyped>.NativeClassPtr);
			MemberPrimitiveTyped.NativeFieldInfoPtr_primitiveTypeEnum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemberPrimitiveTyped>.NativeClassPtr, "primitiveTypeEnum");
			MemberPrimitiveTyped.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemberPrimitiveTyped>.NativeClassPtr, "value");
			MemberPrimitiveTyped.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemberPrimitiveTyped>.NativeClassPtr, 100671266);
			MemberPrimitiveTyped.NativeMethodInfoPtr_Set_Internal_Void_InternalPrimitiveTypeE_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemberPrimitiveTyped>.NativeClassPtr, 100671267);
			MemberPrimitiveTyped.NativeMethodInfoPtr_Write_Public_Virtual_Final_New_Void___BinaryWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemberPrimitiveTyped>.NativeClassPtr, 100671268);
			MemberPrimitiveTyped.NativeMethodInfoPtr_Read_Public_Virtual_Final_New_Void___BinaryParser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemberPrimitiveTyped>.NativeClassPtr, 100671269);
			MemberPrimitiveTyped.NativeMethodInfoPtr_Dump_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemberPrimitiveTyped>.NativeClassPtr, 100671270);
		}

		// Token: 0x0600332F RID: 13103 RVA: 0x0010173C File Offset: 0x000FF93C
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MemberPrimitiveTyped()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MemberPrimitiveTyped>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemberPrimitiveTyped.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003330 RID: 13104 RVA: 0x00101778 File Offset: 0x000FF978
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Set(InternalPrimitiveTypeE primitiveTypeEnum, Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref primitiveTypeEnum;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemberPrimitiveTyped.NativeMethodInfoPtr_Set_Internal_Void_InternalPrimitiveTypeE_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003331 RID: 13105 RVA: 0x001017C8 File Offset: 0x000FF9C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1387272, XrefRangeEnd = 1387274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Write(__BinaryWriter sout)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sout);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemberPrimitiveTyped.NativeMethodInfoPtr_Write_Public_Virtual_Final_New_Void___BinaryWriter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003332 RID: 13106 RVA: 0x0010180C File Offset: 0x000FFA0C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1387278, RefRangeEnd = 1387279, XrefRangeStart = 1387274, XrefRangeEnd = 1387278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Read(__BinaryParser input)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(input);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemberPrimitiveTyped.NativeMethodInfoPtr_Read_Public_Virtual_Final_New_Void___BinaryParser_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003333 RID: 13107 RVA: 0x00101850 File Offset: 0x000FFA50
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dump()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemberPrimitiveTyped.NativeMethodInfoPtr_Dump_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003334 RID: 13108 RVA: 0x00011D52 File Offset: 0x0000FF52
		public MemberPrimitiveTyped(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000BA1 RID: 2977
		// (get) Token: 0x06003335 RID: 13109 RVA: 0x00101884 File Offset: 0x000FFA84
		// (set) Token: 0x06003336 RID: 13110 RVA: 0x00011D5B File Offset: 0x0000FF5B
		public unsafe InternalPrimitiveTypeE primitiveTypeEnum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemberPrimitiveTyped.NativeFieldInfoPtr_primitiveTypeEnum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemberPrimitiveTyped.NativeFieldInfoPtr_primitiveTypeEnum)) = value;
			}
		}

		// Token: 0x17000BA2 RID: 2978
		// (get) Token: 0x06003337 RID: 13111 RVA: 0x001018AC File Offset: 0x000FFAAC
		// (set) Token: 0x06003338 RID: 13112 RVA: 0x00011D76 File Offset: 0x0000FF76
		public unsafe Object value
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemberPrimitiveTyped.NativeFieldInfoPtr_value);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemberPrimitiveTyped.NativeFieldInfoPtr_value), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002A4E RID: 10830
		private static readonly IntPtr NativeFieldInfoPtr_primitiveTypeEnum;

		// Token: 0x04002A4F RID: 10831
		private static readonly IntPtr NativeFieldInfoPtr_value;

		// Token: 0x04002A50 RID: 10832
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x04002A51 RID: 10833
		private static readonly IntPtr NativeMethodInfoPtr_Set_Internal_Void_InternalPrimitiveTypeE_Object_0;

		// Token: 0x04002A52 RID: 10834
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_Final_New_Void___BinaryWriter_0;

		// Token: 0x04002A53 RID: 10835
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Virtual_Final_New_Void___BinaryParser_0;

		// Token: 0x04002A54 RID: 10836
		private static readonly IntPtr NativeMethodInfoPtr_Dump_Public_Void_0;
	}
}
