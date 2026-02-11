using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Runtime.Remoting
{
	// Token: 0x020002A7 RID: 679
	public class TypeEntry : Object
	{
		// Token: 0x06002B9C RID: 11164 RVA: 0x000E6260 File Offset: 0x000E4460
		// Note: this type is marked as 'beforefieldinit'.
		static TypeEntry()
		{
			Il2CppClassPointerStore<TypeEntry>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting", "TypeEntry");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TypeEntry>.NativeClassPtr);
			TypeEntry.NativeFieldInfoPtr_assembly_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeEntry>.NativeClassPtr, "assembly_name");
			TypeEntry.NativeFieldInfoPtr_type_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeEntry>.NativeClassPtr, "type_name");
			TypeEntry.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeEntry>.NativeClassPtr, 100670360);
			TypeEntry.NativeMethodInfoPtr_get_AssemblyName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeEntry>.NativeClassPtr, 100670361);
			TypeEntry.NativeMethodInfoPtr_set_AssemblyName_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeEntry>.NativeClassPtr, 100670362);
			TypeEntry.NativeMethodInfoPtr_get_TypeName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeEntry>.NativeClassPtr, 100670363);
			TypeEntry.NativeMethodInfoPtr_set_TypeName_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeEntry>.NativeClassPtr, 100670364);
		}

		// Token: 0x06002B9D RID: 11165 RVA: 0x000E631C File Offset: 0x000E451C
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TypeEntry()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TypeEntry>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeEntry.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000930 RID: 2352
		// (get) Token: 0x06002B9E RID: 11166 RVA: 0x000E6358 File Offset: 0x000E4558
		// (set) Token: 0x06002B9F RID: 11167 RVA: 0x000E6390 File Offset: 0x000E4590
		public unsafe string AssemblyName
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeEntry.NativeMethodInfoPtr_get_AssemblyName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 287292, RefRangeEnd = 287294, XrefRangeStart = 287292, XrefRangeEnd = 287294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeEntry.NativeMethodInfoPtr_set_AssemblyName_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000931 RID: 2353
		// (get) Token: 0x06002BA0 RID: 11168 RVA: 0x000E63D4 File Offset: 0x000E45D4
		// (set) Token: 0x06002BA1 RID: 11169 RVA: 0x000E640C File Offset: 0x000E460C
		public unsafe string TypeName
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeEntry.NativeMethodInfoPtr_get_TypeName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeEntry.NativeMethodInfoPtr_set_TypeName_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06002BA2 RID: 11170 RVA: 0x0000E864 File Offset: 0x0000CA64
		public TypeEntry(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700092E RID: 2350
		// (get) Token: 0x06002BA3 RID: 11171 RVA: 0x000E6450 File Offset: 0x000E4650
		// (set) Token: 0x06002BA4 RID: 11172 RVA: 0x0000E86D File Offset: 0x0000CA6D
		public unsafe string assembly_name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeEntry.NativeFieldInfoPtr_assembly_name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeEntry.NativeFieldInfoPtr_assembly_name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700092F RID: 2351
		// (get) Token: 0x06002BA5 RID: 11173 RVA: 0x000E6478 File Offset: 0x000E4678
		// (set) Token: 0x06002BA6 RID: 11174 RVA: 0x0000E88C File Offset: 0x0000CA8C
		public unsafe string type_name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeEntry.NativeFieldInfoPtr_type_name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeEntry.NativeFieldInfoPtr_type_name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040024E9 RID: 9449
		private static readonly IntPtr NativeFieldInfoPtr_assembly_name;

		// Token: 0x040024EA RID: 9450
		private static readonly IntPtr NativeFieldInfoPtr_type_name;

		// Token: 0x040024EB RID: 9451
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x040024EC RID: 9452
		private static readonly IntPtr NativeMethodInfoPtr_get_AssemblyName_Public_get_String_0;

		// Token: 0x040024ED RID: 9453
		private static readonly IntPtr NativeMethodInfoPtr_set_AssemblyName_Public_set_Void_String_0;

		// Token: 0x040024EE RID: 9454
		private static readonly IntPtr NativeMethodInfoPtr_get_TypeName_Public_get_String_0;

		// Token: 0x040024EF RID: 9455
		private static readonly IntPtr NativeMethodInfoPtr_set_TypeName_Public_set_Void_String_0;
	}
}
