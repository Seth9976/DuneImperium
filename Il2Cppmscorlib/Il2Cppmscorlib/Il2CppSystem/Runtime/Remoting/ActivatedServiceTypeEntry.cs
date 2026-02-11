using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.Remoting
{
	// Token: 0x02000290 RID: 656
	public class ActivatedServiceTypeEntry : TypeEntry
	{
		// Token: 0x06002A24 RID: 10788 RVA: 0x000E07DC File Offset: 0x000DE9DC
		// Note: this type is marked as 'beforefieldinit'.
		static ActivatedServiceTypeEntry()
		{
			Il2CppClassPointerStore<ActivatedServiceTypeEntry>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting", "ActivatedServiceTypeEntry");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ActivatedServiceTypeEntry>.NativeClassPtr);
			ActivatedServiceTypeEntry.NativeFieldInfoPtr_obj_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActivatedServiceTypeEntry>.NativeClassPtr, "obj_type");
			ActivatedServiceTypeEntry.NativeMethodInfoPtr__ctor_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivatedServiceTypeEntry>.NativeClassPtr, 100670168);
			ActivatedServiceTypeEntry.NativeMethodInfoPtr_get_ObjectType_Public_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivatedServiceTypeEntry>.NativeClassPtr, 100670169);
			ActivatedServiceTypeEntry.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivatedServiceTypeEntry>.NativeClassPtr, 100670170);
		}

		// Token: 0x06002A25 RID: 10789 RVA: 0x000E085C File Offset: 0x000DEA5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1376806, XrefRangeEnd = 1376815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ActivatedServiceTypeEntry(string typeName, string assemblyName)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ActivatedServiceTypeEntry>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(typeName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(assemblyName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivatedServiceTypeEntry.NativeMethodInfoPtr__ctor_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170008C7 RID: 2247
		// (get) Token: 0x06002A26 RID: 10790 RVA: 0x000E08BC File Offset: 0x000DEABC
		public unsafe Type ObjectType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivatedServiceTypeEntry.NativeMethodInfoPtr_get_ObjectType_Public_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x06002A27 RID: 10791 RVA: 0x000E08FC File Offset: 0x000DEAFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ActivatedServiceTypeEntry.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002A28 RID: 10792 RVA: 0x0000DFBE File Offset: 0x0000C1BE
		public ActivatedServiceTypeEntry(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170008C6 RID: 2246
		// (get) Token: 0x06002A29 RID: 10793 RVA: 0x000E0940 File Offset: 0x000DEB40
		// (set) Token: 0x06002A2A RID: 10794 RVA: 0x0000DFC7 File Offset: 0x0000C1C7
		public unsafe Type obj_type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivatedServiceTypeEntry.NativeFieldInfoPtr_obj_type);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivatedServiceTypeEntry.NativeFieldInfoPtr_obj_type), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040023E3 RID: 9187
		private static readonly IntPtr NativeFieldInfoPtr_obj_type;

		// Token: 0x040023E4 RID: 9188
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_0;

		// Token: 0x040023E5 RID: 9189
		private static readonly IntPtr NativeMethodInfoPtr_get_ObjectType_Public_get_Type_0;

		// Token: 0x040023E6 RID: 9190
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
