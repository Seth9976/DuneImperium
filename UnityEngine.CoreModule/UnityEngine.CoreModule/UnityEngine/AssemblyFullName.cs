using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000134 RID: 308
	public sealed class AssemblyFullName : ValueType
	{
		// Token: 0x060017D6 RID: 6102 RVA: 0x00070A64 File Offset: 0x0006EC64
		// Note: this type is marked as 'beforefieldinit'.
		static AssemblyFullName()
		{
			Il2CppClassPointerStore<AssemblyFullName>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "AssemblyFullName");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AssemblyFullName>.NativeClassPtr);
			AssemblyFullName.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssemblyFullName>.NativeClassPtr, "Name");
			AssemblyFullName.NativeFieldInfoPtr_Version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssemblyFullName>.NativeClassPtr, "Version");
			AssemblyFullName.NativeFieldInfoPtr_PublicKeyToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssemblyFullName>.NativeClassPtr, "PublicKeyToken");
			AssemblyFullName.NativeFieldInfoPtr_Culture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssemblyFullName>.NativeClassPtr, "Culture");
			AssemblyFullName.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssemblyFullName>.NativeClassPtr, 100666547);
			AssemblyFullName.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssemblyFullName>.NativeClassPtr, 100666548);
			AssemblyFullName.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssemblyFullName>.NativeClassPtr, 100666549);
		}

		// Token: 0x060017D7 RID: 6103 RVA: 0x00070B20 File Offset: 0x0006ED20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 661869, XrefRangeEnd = 661875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssemblyFullName.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060017D8 RID: 6104 RVA: 0x00070B74 File Offset: 0x0006ED74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 661875, XrefRangeEnd = 661881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssemblyFullName.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060017D9 RID: 6105 RVA: 0x00070BB8 File Offset: 0x0006EDB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 661881, XrefRangeEnd = 661901, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssemblyFullName.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060017DA RID: 6106 RVA: 0x00009744 File Offset: 0x00007944
		public AssemblyFullName(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060017DB RID: 6107 RVA: 0x0000974D File Offset: 0x0000794D
		public AssemblyFullName()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AssemblyFullName>.NativeClassPtr))
		{
		}

		// Token: 0x170004EB RID: 1259
		// (get) Token: 0x060017DC RID: 6108 RVA: 0x00070BF4 File Offset: 0x0006EDF4
		// (set) Token: 0x060017DD RID: 6109 RVA: 0x0000975F File Offset: 0x0000795F
		public unsafe string Name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssemblyFullName.NativeFieldInfoPtr_Name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssemblyFullName.NativeFieldInfoPtr_Name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170004EC RID: 1260
		// (get) Token: 0x060017DE RID: 6110 RVA: 0x00070C1C File Offset: 0x0006EE1C
		// (set) Token: 0x060017DF RID: 6111 RVA: 0x0000977E File Offset: 0x0000797E
		public unsafe AssemblyVersion Version
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssemblyFullName.NativeFieldInfoPtr_Version);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssemblyFullName.NativeFieldInfoPtr_Version)) = value;
			}
		}

		// Token: 0x170004ED RID: 1261
		// (get) Token: 0x060017E0 RID: 6112 RVA: 0x00070C44 File Offset: 0x0006EE44
		// (set) Token: 0x060017E1 RID: 6113 RVA: 0x00009799 File Offset: 0x00007999
		public unsafe string PublicKeyToken
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssemblyFullName.NativeFieldInfoPtr_PublicKeyToken);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssemblyFullName.NativeFieldInfoPtr_PublicKeyToken), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170004EE RID: 1262
		// (get) Token: 0x060017E2 RID: 6114 RVA: 0x00070C6C File Offset: 0x0006EE6C
		// (set) Token: 0x060017E3 RID: 6115 RVA: 0x000097B8 File Offset: 0x000079B8
		public unsafe string Culture
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssemblyFullName.NativeFieldInfoPtr_Culture);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssemblyFullName.NativeFieldInfoPtr_Culture), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400156F RID: 5487
		private static readonly IntPtr NativeFieldInfoPtr_Name;

		// Token: 0x04001570 RID: 5488
		private static readonly IntPtr NativeFieldInfoPtr_Version;

		// Token: 0x04001571 RID: 5489
		private static readonly IntPtr NativeFieldInfoPtr_PublicKeyToken;

		// Token: 0x04001572 RID: 5490
		private static readonly IntPtr NativeFieldInfoPtr_Culture;

		// Token: 0x04001573 RID: 5491
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04001574 RID: 5492
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04001575 RID: 5493
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
