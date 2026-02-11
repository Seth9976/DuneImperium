using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Reflection;

namespace Il2CppSystem.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x0200034E RID: 846
	public sealed class BinaryAssemblyInfo : Object
	{
		// Token: 0x060032AD RID: 12973 RVA: 0x000FFF14 File Offset: 0x000FE114
		// Note: this type is marked as 'beforefieldinit'.
		static BinaryAssemblyInfo()
		{
			Il2CppClassPointerStore<BinaryAssemblyInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization.Formatters.Binary", "BinaryAssemblyInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BinaryAssemblyInfo>.NativeClassPtr);
			BinaryAssemblyInfo.NativeFieldInfoPtr_assemblyString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryAssemblyInfo>.NativeClassPtr, "assemblyString");
			BinaryAssemblyInfo.NativeFieldInfoPtr_assembly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryAssemblyInfo>.NativeClassPtr, "assembly");
			BinaryAssemblyInfo.NativeMethodInfoPtr__ctor_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryAssemblyInfo>.NativeClassPtr, 100671226);
			BinaryAssemblyInfo.NativeMethodInfoPtr__ctor_Internal_Void_String_Assembly_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryAssemblyInfo>.NativeClassPtr, 100671227);
			BinaryAssemblyInfo.NativeMethodInfoPtr_GetAssembly_Internal_Assembly_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryAssemblyInfo>.NativeClassPtr, 100671228);
		}

		// Token: 0x060032AE RID: 12974 RVA: 0x000FFFA8 File Offset: 0x000FE1A8
		[CallerCount(148)]
		[CachedScanResults(RefRangeStart = 286435, RefRangeEnd = 286583, XrefRangeStart = 286435, XrefRangeEnd = 286583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BinaryAssemblyInfo(string assemblyString)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BinaryAssemblyInfo>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(assemblyString);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryAssemblyInfo.NativeMethodInfoPtr__ctor_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060032AF RID: 12975 RVA: 0x000FFFF4 File Offset: 0x000FE1F4
		[CallerCount(54)]
		[CachedScanResults(RefRangeStart = 296744, RefRangeEnd = 296798, XrefRangeStart = 296744, XrefRangeEnd = 296798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BinaryAssemblyInfo(string assemblyString, Assembly assembly)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BinaryAssemblyInfo>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(assemblyString);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(assembly);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryAssemblyInfo.NativeMethodInfoPtr__ctor_Internal_Void_String_Assembly_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060032B0 RID: 12976 RVA: 0x00100054 File Offset: 0x000FE254
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1387192, XrefRangeEnd = 1387199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Assembly GetAssembly()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryAssemblyInfo.NativeMethodInfoPtr_GetAssembly_Internal_Assembly_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Assembly>(intPtr3) : null;
		}

		// Token: 0x060032B1 RID: 12977 RVA: 0x00011918 File Offset: 0x0000FB18
		public BinaryAssemblyInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000B7E RID: 2942
		// (get) Token: 0x060032B2 RID: 12978 RVA: 0x00100094 File Offset: 0x000FE294
		// (set) Token: 0x060032B3 RID: 12979 RVA: 0x00011921 File Offset: 0x0000FB21
		public unsafe string assemblyString
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryAssemblyInfo.NativeFieldInfoPtr_assemblyString);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryAssemblyInfo.NativeFieldInfoPtr_assemblyString), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000B7F RID: 2943
		// (get) Token: 0x060032B4 RID: 12980 RVA: 0x001000BC File Offset: 0x000FE2BC
		// (set) Token: 0x060032B5 RID: 12981 RVA: 0x00011940 File Offset: 0x0000FB40
		public unsafe Assembly assembly
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryAssemblyInfo.NativeFieldInfoPtr_assembly);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Assembly>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryAssemblyInfo.NativeFieldInfoPtr_assembly), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002A04 RID: 10756
		private static readonly IntPtr NativeFieldInfoPtr_assemblyString;

		// Token: 0x04002A05 RID: 10757
		private static readonly IntPtr NativeFieldInfoPtr_assembly;

		// Token: 0x04002A06 RID: 10758
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_0;

		// Token: 0x04002A07 RID: 10759
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_Assembly_0;

		// Token: 0x04002A08 RID: 10760
		private static readonly IntPtr NativeMethodInfoPtr_GetAssembly_Internal_Assembly_0;
	}
}
