using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x02000350 RID: 848
	public sealed class BinaryAssembly : Object
	{
		// Token: 0x060032CC RID: 13004 RVA: 0x00100500 File Offset: 0x000FE700
		// Note: this type is marked as 'beforefieldinit'.
		static BinaryAssembly()
		{
			Il2CppClassPointerStore<BinaryAssembly>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization.Formatters.Binary", "BinaryAssembly");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BinaryAssembly>.NativeClassPtr);
			BinaryAssembly.NativeFieldInfoPtr_assemId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryAssembly>.NativeClassPtr, "assemId");
			BinaryAssembly.NativeFieldInfoPtr_assemblyString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryAssembly>.NativeClassPtr, "assemblyString");
			BinaryAssembly.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryAssembly>.NativeClassPtr, 100671235);
			BinaryAssembly.NativeMethodInfoPtr_Set_Internal_Void_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryAssembly>.NativeClassPtr, 100671236);
			BinaryAssembly.NativeMethodInfoPtr_Write_Public_Virtual_Final_New_Void___BinaryWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryAssembly>.NativeClassPtr, 100671237);
			BinaryAssembly.NativeMethodInfoPtr_Read_Public_Virtual_Final_New_Void___BinaryParser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryAssembly>.NativeClassPtr, 100671238);
			BinaryAssembly.NativeMethodInfoPtr_Dump_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryAssembly>.NativeClassPtr, 100671239);
		}

		// Token: 0x060032CD RID: 13005 RVA: 0x001005BC File Offset: 0x000FE7BC
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BinaryAssembly()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BinaryAssembly>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryAssembly.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060032CE RID: 13006 RVA: 0x001005F8 File Offset: 0x000FE7F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Set(int assemId, string assemblyString)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref assemId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(assemblyString);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryAssembly.NativeMethodInfoPtr_Set_Internal_Void_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060032CF RID: 13007 RVA: 0x00100648 File Offset: 0x000FE848
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1387208, XrefRangeEnd = 1387209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Write(__BinaryWriter sout)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sout);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryAssembly.NativeMethodInfoPtr_Write_Public_Virtual_Final_New_Void___BinaryWriter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060032D0 RID: 13008 RVA: 0x0010068C File Offset: 0x000FE88C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1387213, RefRangeEnd = 1387215, XrefRangeStart = 1387209, XrefRangeEnd = 1387213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Read(__BinaryParser input)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(input);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryAssembly.NativeMethodInfoPtr_Read_Public_Virtual_Final_New_Void___BinaryParser_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060032D1 RID: 13009 RVA: 0x001006D0 File Offset: 0x000FE8D0
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dump()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryAssembly.NativeMethodInfoPtr_Dump_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060032D2 RID: 13010 RVA: 0x00011A25 File Offset: 0x0000FC25
		public BinaryAssembly(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000B87 RID: 2951
		// (get) Token: 0x060032D3 RID: 13011 RVA: 0x00100704 File Offset: 0x000FE904
		// (set) Token: 0x060032D4 RID: 13012 RVA: 0x00011A2E File Offset: 0x0000FC2E
		public unsafe int assemId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryAssembly.NativeFieldInfoPtr_assemId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryAssembly.NativeFieldInfoPtr_assemId)) = value;
			}
		}

		// Token: 0x17000B88 RID: 2952
		// (get) Token: 0x060032D5 RID: 13013 RVA: 0x0010072C File Offset: 0x000FE92C
		// (set) Token: 0x060032D6 RID: 13014 RVA: 0x00011A49 File Offset: 0x0000FC49
		public unsafe string assemblyString
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryAssembly.NativeFieldInfoPtr_assemblyString);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryAssembly.NativeFieldInfoPtr_assemblyString), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04002A16 RID: 10774
		private static readonly IntPtr NativeFieldInfoPtr_assemId;

		// Token: 0x04002A17 RID: 10775
		private static readonly IntPtr NativeFieldInfoPtr_assemblyString;

		// Token: 0x04002A18 RID: 10776
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x04002A19 RID: 10777
		private static readonly IntPtr NativeMethodInfoPtr_Set_Internal_Void_Int32_String_0;

		// Token: 0x04002A1A RID: 10778
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_Final_New_Void___BinaryWriter_0;

		// Token: 0x04002A1B RID: 10779
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Virtual_Final_New_Void___BinaryParser_0;

		// Token: 0x04002A1C RID: 10780
		private static readonly IntPtr NativeMethodInfoPtr_Dump_Public_Void_0;
	}
}
