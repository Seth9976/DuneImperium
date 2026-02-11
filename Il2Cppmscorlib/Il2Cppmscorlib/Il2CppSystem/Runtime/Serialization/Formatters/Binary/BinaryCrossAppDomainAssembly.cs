using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x02000351 RID: 849
	public sealed class BinaryCrossAppDomainAssembly : Object
	{
		// Token: 0x060032D7 RID: 13015 RVA: 0x00100754 File Offset: 0x000FE954
		// Note: this type is marked as 'beforefieldinit'.
		static BinaryCrossAppDomainAssembly()
		{
			Il2CppClassPointerStore<BinaryCrossAppDomainAssembly>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization.Formatters.Binary", "BinaryCrossAppDomainAssembly");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BinaryCrossAppDomainAssembly>.NativeClassPtr);
			BinaryCrossAppDomainAssembly.NativeFieldInfoPtr_assemId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryCrossAppDomainAssembly>.NativeClassPtr, "assemId");
			BinaryCrossAppDomainAssembly.NativeFieldInfoPtr_assemblyIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryCrossAppDomainAssembly>.NativeClassPtr, "assemblyIndex");
			BinaryCrossAppDomainAssembly.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryCrossAppDomainAssembly>.NativeClassPtr, 100671240);
			BinaryCrossAppDomainAssembly.NativeMethodInfoPtr_Read_Public_Virtual_Final_New_Void___BinaryParser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryCrossAppDomainAssembly>.NativeClassPtr, 100671241);
			BinaryCrossAppDomainAssembly.NativeMethodInfoPtr_Dump_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryCrossAppDomainAssembly>.NativeClassPtr, 100671242);
		}

		// Token: 0x060032D8 RID: 13016 RVA: 0x001007E8 File Offset: 0x000FE9E8
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BinaryCrossAppDomainAssembly()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BinaryCrossAppDomainAssembly>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryCrossAppDomainAssembly.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060032D9 RID: 13017 RVA: 0x00100824 File Offset: 0x000FEA24
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1387217, RefRangeEnd = 1387220, XrefRangeStart = 1387215, XrefRangeEnd = 1387217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Read(__BinaryParser input)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(input);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryCrossAppDomainAssembly.NativeMethodInfoPtr_Read_Public_Virtual_Final_New_Void___BinaryParser_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060032DA RID: 13018 RVA: 0x00100868 File Offset: 0x000FEA68
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dump()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryCrossAppDomainAssembly.NativeMethodInfoPtr_Dump_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060032DB RID: 13019 RVA: 0x00011A68 File Offset: 0x0000FC68
		public BinaryCrossAppDomainAssembly(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000B89 RID: 2953
		// (get) Token: 0x060032DC RID: 13020 RVA: 0x0010089C File Offset: 0x000FEA9C
		// (set) Token: 0x060032DD RID: 13021 RVA: 0x00011A71 File Offset: 0x0000FC71
		public unsafe int assemId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryCrossAppDomainAssembly.NativeFieldInfoPtr_assemId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryCrossAppDomainAssembly.NativeFieldInfoPtr_assemId)) = value;
			}
		}

		// Token: 0x17000B8A RID: 2954
		// (get) Token: 0x060032DE RID: 13022 RVA: 0x001008C4 File Offset: 0x000FEAC4
		// (set) Token: 0x060032DF RID: 13023 RVA: 0x00011A8C File Offset: 0x0000FC8C
		public unsafe int assemblyIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryCrossAppDomainAssembly.NativeFieldInfoPtr_assemblyIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryCrossAppDomainAssembly.NativeFieldInfoPtr_assemblyIndex)) = value;
			}
		}

		// Token: 0x04002A1D RID: 10781
		private static readonly IntPtr NativeFieldInfoPtr_assemId;

		// Token: 0x04002A1E RID: 10782
		private static readonly IntPtr NativeFieldInfoPtr_assemblyIndex;

		// Token: 0x04002A1F RID: 10783
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x04002A20 RID: 10784
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Virtual_Final_New_Void___BinaryParser_0;

		// Token: 0x04002A21 RID: 10785
		private static readonly IntPtr NativeMethodInfoPtr_Dump_Public_Void_0;
	}
}
