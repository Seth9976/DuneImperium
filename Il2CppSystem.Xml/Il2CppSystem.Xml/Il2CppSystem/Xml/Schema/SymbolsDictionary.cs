using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x02000114 RID: 276
	public class SymbolsDictionary : Object
	{
		// Token: 0x060018A7 RID: 6311 RVA: 0x0007F0C4 File Offset: 0x0007D2C4
		// Note: this type is marked as 'beforefieldinit'.
		static SymbolsDictionary()
		{
			Il2CppClassPointerStore<SymbolsDictionary>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "SymbolsDictionary");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SymbolsDictionary>.NativeClassPtr);
			SymbolsDictionary.NativeFieldInfoPtr_last = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SymbolsDictionary>.NativeClassPtr, "last");
			SymbolsDictionary.NativeFieldInfoPtr_names = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SymbolsDictionary>.NativeClassPtr, "names");
			SymbolsDictionary.NativeFieldInfoPtr_wildcards = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SymbolsDictionary>.NativeClassPtr, "wildcards");
			SymbolsDictionary.NativeFieldInfoPtr_particles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SymbolsDictionary>.NativeClassPtr, "particles");
			SymbolsDictionary.NativeFieldInfoPtr_particleLast = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SymbolsDictionary>.NativeClassPtr, "particleLast");
			SymbolsDictionary.NativeFieldInfoPtr_isUpaEnforced = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SymbolsDictionary>.NativeClassPtr, "isUpaEnforced");
			SymbolsDictionary.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SymbolsDictionary>.NativeClassPtr, 100667111);
			SymbolsDictionary.NativeMethodInfoPtr_get_Count_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SymbolsDictionary>.NativeClassPtr, 100667112);
			SymbolsDictionary.NativeMethodInfoPtr_get_IsUpaEnforced_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SymbolsDictionary>.NativeClassPtr, 100667113);
			SymbolsDictionary.NativeMethodInfoPtr_set_IsUpaEnforced_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SymbolsDictionary>.NativeClassPtr, 100667114);
			SymbolsDictionary.NativeMethodInfoPtr_AddName_Public_Int32_XmlQualifiedName_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SymbolsDictionary>.NativeClassPtr, 100667115);
			SymbolsDictionary.NativeMethodInfoPtr_AddNamespaceList_Public_Void_NamespaceList_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SymbolsDictionary>.NativeClassPtr, 100667116);
			SymbolsDictionary.NativeMethodInfoPtr_AddWildcard_Private_Void_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SymbolsDictionary>.NativeClassPtr, 100667117);
			SymbolsDictionary.NativeMethodInfoPtr_GetNamespaceListSymbols_Public_ICollection_NamespaceList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SymbolsDictionary>.NativeClassPtr, 100667118);
			SymbolsDictionary.NativeMethodInfoPtr_get_Item_Public_get_Int32_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SymbolsDictionary>.NativeClassPtr, 100667119);
			SymbolsDictionary.NativeMethodInfoPtr_Exists_Public_Boolean_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SymbolsDictionary>.NativeClassPtr, 100667120);
			SymbolsDictionary.NativeMethodInfoPtr_GetParticle_Public_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SymbolsDictionary>.NativeClassPtr, 100667121);
			SymbolsDictionary.NativeMethodInfoPtr_NameOf_Public_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SymbolsDictionary>.NativeClassPtr, 100667122);
		}

		// Token: 0x060018A8 RID: 6312 RVA: 0x0007F25C File Offset: 0x0007D45C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 392069, XrefRangeEnd = 392080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SymbolsDictionary()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SymbolsDictionary>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SymbolsDictionary.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000802 RID: 2050
		// (get) Token: 0x060018A9 RID: 6313 RVA: 0x0007F298 File Offset: 0x0007D498
		public unsafe int Count
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SymbolsDictionary.NativeMethodInfoPtr_get_Count_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000803 RID: 2051
		// (get) Token: 0x060018AA RID: 6314 RVA: 0x0007F2D4 File Offset: 0x0007D4D4
		// (set) Token: 0x060018AB RID: 6315 RVA: 0x0007F310 File Offset: 0x0007D510
		public unsafe bool IsUpaEnforced
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SymbolsDictionary.NativeMethodInfoPtr_get_IsUpaEnforced_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SymbolsDictionary.NativeMethodInfoPtr_set_IsUpaEnforced_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060018AC RID: 6316 RVA: 0x0007F350 File Offset: 0x0007D550
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 392083, RefRangeEnd = 392085, XrefRangeStart = 392080, XrefRangeEnd = 392083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int AddName(XmlQualifiedName name, Object particle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(particle);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SymbolsDictionary.NativeMethodInfoPtr_AddName_Public_Int32_XmlQualifiedName_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060018AD RID: 6317 RVA: 0x0007F3B0 File Offset: 0x0007D5B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 392110, RefRangeEnd = 392111, XrefRangeStart = 392085, XrefRangeEnd = 392110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddNamespaceList(NamespaceList list, Object particle, bool allowLocal)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(list);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(particle);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref allowLocal;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SymbolsDictionary.NativeMethodInfoPtr_AddNamespaceList_Public_Void_NamespaceList_Object_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018AE RID: 6318 RVA: 0x0007F414 File Offset: 0x0007D614
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 392119, RefRangeEnd = 392122, XrefRangeStart = 392111, XrefRangeEnd = 392119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddWildcard(string wildcard, Object particle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(wildcard);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(particle);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SymbolsDictionary.NativeMethodInfoPtr_AddWildcard_Private_Void_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018AF RID: 6319 RVA: 0x0007F468 File Offset: 0x0007D668
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 392170, RefRangeEnd = 392171, XrefRangeStart = 392122, XrefRangeEnd = 392170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ICollection GetNamespaceListSymbols(NamespaceList list)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(list);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SymbolsDictionary.NativeMethodInfoPtr_GetNamespaceListSymbols_Public_ICollection_NamespaceList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICollection>(intPtr3) : null;
			}
		}

		// Token: 0x17000804 RID: 2052
		public unsafe int this[XmlQualifiedName name]
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 392174, RefRangeEnd = 392176, XrefRangeStart = 392171, XrefRangeEnd = 392174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(name);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SymbolsDictionary.NativeMethodInfoPtr_get_Item_Public_get_Int32_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}
		}

		// Token: 0x060018B1 RID: 6321 RVA: 0x0007F508 File Offset: 0x0007D708
		[CallerCount(0)]
		public unsafe bool Exists(XmlQualifiedName name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SymbolsDictionary.NativeMethodInfoPtr_Exists_Public_Boolean_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060018B2 RID: 6322 RVA: 0x0007F558 File Offset: 0x0007D758
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 392176, RefRangeEnd = 392178, XrefRangeStart = 392176, XrefRangeEnd = 392176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object GetParticle(int symbol)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref symbol;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SymbolsDictionary.NativeMethodInfoPtr_GetParticle_Public_Object_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x060018B3 RID: 6323 RVA: 0x0007F5A4 File Offset: 0x0007D7A4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 392215, RefRangeEnd = 392218, XrefRangeStart = 392178, XrefRangeEnd = 392215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string NameOf(int symbol)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref symbol;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SymbolsDictionary.NativeMethodInfoPtr_NameOf_Public_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060018B4 RID: 6324 RVA: 0x0000A912 File Offset: 0x00008B12
		public SymbolsDictionary(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170007FC RID: 2044
		// (get) Token: 0x060018B5 RID: 6325 RVA: 0x0007F5E8 File Offset: 0x0007D7E8
		// (set) Token: 0x060018B6 RID: 6326 RVA: 0x0000A91B File Offset: 0x00008B1B
		public unsafe int last
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SymbolsDictionary.NativeFieldInfoPtr_last);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SymbolsDictionary.NativeFieldInfoPtr_last)) = value;
			}
		}

		// Token: 0x170007FD RID: 2045
		// (get) Token: 0x060018B7 RID: 6327 RVA: 0x0007F610 File Offset: 0x0007D810
		// (set) Token: 0x060018B8 RID: 6328 RVA: 0x0000A936 File Offset: 0x00008B36
		public unsafe Hashtable names
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SymbolsDictionary.NativeFieldInfoPtr_names);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SymbolsDictionary.NativeFieldInfoPtr_names), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007FE RID: 2046
		// (get) Token: 0x060018B9 RID: 6329 RVA: 0x0007F640 File Offset: 0x0007D840
		// (set) Token: 0x060018BA RID: 6330 RVA: 0x0000A955 File Offset: 0x00008B55
		public unsafe Hashtable wildcards
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SymbolsDictionary.NativeFieldInfoPtr_wildcards);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SymbolsDictionary.NativeFieldInfoPtr_wildcards), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007FF RID: 2047
		// (get) Token: 0x060018BB RID: 6331 RVA: 0x0007F670 File Offset: 0x0007D870
		// (set) Token: 0x060018BC RID: 6332 RVA: 0x0000A974 File Offset: 0x00008B74
		public unsafe ArrayList particles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SymbolsDictionary.NativeFieldInfoPtr_particles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SymbolsDictionary.NativeFieldInfoPtr_particles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000800 RID: 2048
		// (get) Token: 0x060018BD RID: 6333 RVA: 0x0007F6A0 File Offset: 0x0007D8A0
		// (set) Token: 0x060018BE RID: 6334 RVA: 0x0000A993 File Offset: 0x00008B93
		public unsafe Object particleLast
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SymbolsDictionary.NativeFieldInfoPtr_particleLast);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SymbolsDictionary.NativeFieldInfoPtr_particleLast), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000801 RID: 2049
		// (get) Token: 0x060018BF RID: 6335 RVA: 0x0007F6D0 File Offset: 0x0007D8D0
		// (set) Token: 0x060018C0 RID: 6336 RVA: 0x0000A9B2 File Offset: 0x00008BB2
		public unsafe bool isUpaEnforced
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SymbolsDictionary.NativeFieldInfoPtr_isUpaEnforced);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SymbolsDictionary.NativeFieldInfoPtr_isUpaEnforced)) = value;
			}
		}

		// Token: 0x04001342 RID: 4930
		private static readonly IntPtr NativeFieldInfoPtr_last;

		// Token: 0x04001343 RID: 4931
		private static readonly IntPtr NativeFieldInfoPtr_names;

		// Token: 0x04001344 RID: 4932
		private static readonly IntPtr NativeFieldInfoPtr_wildcards;

		// Token: 0x04001345 RID: 4933
		private static readonly IntPtr NativeFieldInfoPtr_particles;

		// Token: 0x04001346 RID: 4934
		private static readonly IntPtr NativeFieldInfoPtr_particleLast;

		// Token: 0x04001347 RID: 4935
		private static readonly IntPtr NativeFieldInfoPtr_isUpaEnforced;

		// Token: 0x04001348 RID: 4936
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001349 RID: 4937
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_get_Int32_0;

		// Token: 0x0400134A RID: 4938
		private static readonly IntPtr NativeMethodInfoPtr_get_IsUpaEnforced_Public_get_Boolean_0;

		// Token: 0x0400134B RID: 4939
		private static readonly IntPtr NativeMethodInfoPtr_set_IsUpaEnforced_Public_set_Void_Boolean_0;

		// Token: 0x0400134C RID: 4940
		private static readonly IntPtr NativeMethodInfoPtr_AddName_Public_Int32_XmlQualifiedName_Object_0;

		// Token: 0x0400134D RID: 4941
		private static readonly IntPtr NativeMethodInfoPtr_AddNamespaceList_Public_Void_NamespaceList_Object_Boolean_0;

		// Token: 0x0400134E RID: 4942
		private static readonly IntPtr NativeMethodInfoPtr_AddWildcard_Private_Void_String_Object_0;

		// Token: 0x0400134F RID: 4943
		private static readonly IntPtr NativeMethodInfoPtr_GetNamespaceListSymbols_Public_ICollection_NamespaceList_0;

		// Token: 0x04001350 RID: 4944
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_Int32_XmlQualifiedName_0;

		// Token: 0x04001351 RID: 4945
		private static readonly IntPtr NativeMethodInfoPtr_Exists_Public_Boolean_XmlQualifiedName_0;

		// Token: 0x04001352 RID: 4946
		private static readonly IntPtr NativeMethodInfoPtr_GetParticle_Public_Object_Int32_0;

		// Token: 0x04001353 RID: 4947
		private static readonly IntPtr NativeMethodInfoPtr_NameOf_Public_String_Int32_0;
	}
}
