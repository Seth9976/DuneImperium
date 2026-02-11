using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.Remoting.Contexts;

namespace Il2CppSystem.Runtime.Remoting
{
	// Token: 0x0200028F RID: 655
	public class ActivatedClientTypeEntry : TypeEntry
	{
		// Token: 0x06002A19 RID: 10777 RVA: 0x000E055C File Offset: 0x000DE75C
		// Note: this type is marked as 'beforefieldinit'.
		static ActivatedClientTypeEntry()
		{
			Il2CppClassPointerStore<ActivatedClientTypeEntry>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting", "ActivatedClientTypeEntry");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ActivatedClientTypeEntry>.NativeClassPtr);
			ActivatedClientTypeEntry.NativeFieldInfoPtr_applicationUrl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActivatedClientTypeEntry>.NativeClassPtr, "applicationUrl");
			ActivatedClientTypeEntry.NativeFieldInfoPtr_obj_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActivatedClientTypeEntry>.NativeClassPtr, "obj_type");
			ActivatedClientTypeEntry.NativeMethodInfoPtr__ctor_Public_Void_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivatedClientTypeEntry>.NativeClassPtr, 100670163);
			ActivatedClientTypeEntry.NativeMethodInfoPtr_get_ApplicationUrl_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivatedClientTypeEntry>.NativeClassPtr, 100670164);
			ActivatedClientTypeEntry.NativeMethodInfoPtr_get_ContextAttributes_Public_get_Il2CppReferenceArray_1_IContextAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivatedClientTypeEntry>.NativeClassPtr, 100670165);
			ActivatedClientTypeEntry.NativeMethodInfoPtr_get_ObjectType_Public_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivatedClientTypeEntry>.NativeClassPtr, 100670166);
			ActivatedClientTypeEntry.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivatedClientTypeEntry>.NativeClassPtr, 100670167);
		}

		// Token: 0x06002A1A RID: 10778 RVA: 0x000E0618 File Offset: 0x000DE818
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1376795, XrefRangeEnd = 1376805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ActivatedClientTypeEntry(string typeName, string assemblyName, string appUrl)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ActivatedClientTypeEntry>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(typeName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(assemblyName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(appUrl);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivatedClientTypeEntry.NativeMethodInfoPtr__ctor_Public_Void_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170008C3 RID: 2243
		// (get) Token: 0x06002A1B RID: 10779 RVA: 0x000E0688 File Offset: 0x000DE888
		public unsafe string ApplicationUrl
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivatedClientTypeEntry.NativeMethodInfoPtr_get_ApplicationUrl_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170008C4 RID: 2244
		// (get) Token: 0x06002A1C RID: 10780 RVA: 0x000E06C0 File Offset: 0x000DE8C0
		public unsafe Il2CppReferenceArray<IContextAttribute> ContextAttributes
		{
			[CallerCount(74)]
			[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivatedClientTypeEntry.NativeMethodInfoPtr_get_ContextAttributes_Public_get_Il2CppReferenceArray_1_IContextAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<IContextAttribute>>(intPtr3) : null;
			}
		}

		// Token: 0x170008C5 RID: 2245
		// (get) Token: 0x06002A1D RID: 10781 RVA: 0x000E0700 File Offset: 0x000DE900
		public unsafe Type ObjectType
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivatedClientTypeEntry.NativeMethodInfoPtr_get_ObjectType_Public_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x06002A1E RID: 10782 RVA: 0x000E0740 File Offset: 0x000DE940
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1376805, XrefRangeEnd = 1376806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ActivatedClientTypeEntry.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002A1F RID: 10783 RVA: 0x0000DF77 File Offset: 0x0000C177
		public ActivatedClientTypeEntry(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170008C1 RID: 2241
		// (get) Token: 0x06002A20 RID: 10784 RVA: 0x000E0784 File Offset: 0x000DE984
		// (set) Token: 0x06002A21 RID: 10785 RVA: 0x0000DF80 File Offset: 0x0000C180
		public unsafe string applicationUrl
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivatedClientTypeEntry.NativeFieldInfoPtr_applicationUrl);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivatedClientTypeEntry.NativeFieldInfoPtr_applicationUrl), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170008C2 RID: 2242
		// (get) Token: 0x06002A22 RID: 10786 RVA: 0x000E07AC File Offset: 0x000DE9AC
		// (set) Token: 0x06002A23 RID: 10787 RVA: 0x0000DF9F File Offset: 0x0000C19F
		public unsafe Type obj_type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivatedClientTypeEntry.NativeFieldInfoPtr_obj_type);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivatedClientTypeEntry.NativeFieldInfoPtr_obj_type), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040023DC RID: 9180
		private static readonly IntPtr NativeFieldInfoPtr_applicationUrl;

		// Token: 0x040023DD RID: 9181
		private static readonly IntPtr NativeFieldInfoPtr_obj_type;

		// Token: 0x040023DE RID: 9182
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_String_0;

		// Token: 0x040023DF RID: 9183
		private static readonly IntPtr NativeMethodInfoPtr_get_ApplicationUrl_Public_get_String_0;

		// Token: 0x040023E0 RID: 9184
		private static readonly IntPtr NativeMethodInfoPtr_get_ContextAttributes_Public_get_Il2CppReferenceArray_1_IContextAttribute_0;

		// Token: 0x040023E1 RID: 9185
		private static readonly IntPtr NativeMethodInfoPtr_get_ObjectType_Public_get_Type_0;

		// Token: 0x040023E2 RID: 9186
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
