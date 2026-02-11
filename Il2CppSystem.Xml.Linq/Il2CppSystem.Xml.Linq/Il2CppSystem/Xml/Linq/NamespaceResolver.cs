using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Linq
{
	// Token: 0x02000011 RID: 17
	public sealed class NamespaceResolver : ValueType
	{
		// Token: 0x060000CC RID: 204 RVA: 0x000062BC File Offset: 0x000044BC
		// Note: this type is marked as 'beforefieldinit'.
		static NamespaceResolver()
		{
			Il2CppClassPointerStore<NamespaceResolver>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.Linq.dll", "System.Xml.Linq", "NamespaceResolver");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NamespaceResolver>.NativeClassPtr);
			NamespaceResolver.NativeFieldInfoPtr__scope = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NamespaceResolver>.NativeClassPtr, "_scope");
			NamespaceResolver.NativeFieldInfoPtr__declaration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NamespaceResolver>.NativeClassPtr, "_declaration");
			NamespaceResolver.NativeFieldInfoPtr__rover = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NamespaceResolver>.NativeClassPtr, "_rover");
			NamespaceResolver.NativeMethodInfoPtr_PushScope_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NamespaceResolver>.NativeClassPtr, 100663458);
			NamespaceResolver.NativeMethodInfoPtr_PopScope_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NamespaceResolver>.NativeClassPtr, 100663459);
			NamespaceResolver.NativeMethodInfoPtr_Add_Public_Void_String_XNamespace_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NamespaceResolver>.NativeClassPtr, 100663460);
			NamespaceResolver.NativeMethodInfoPtr_AddFirst_Public_Void_String_XNamespace_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NamespaceResolver>.NativeClassPtr, 100663461);
			NamespaceResolver.NativeMethodInfoPtr_GetPrefixOfNamespace_Public_String_XNamespace_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NamespaceResolver>.NativeClassPtr, 100663462);
		}

		// Token: 0x060000CD RID: 205 RVA: 0x0000638C File Offset: 0x0000458C
		[CallerCount(0)]
		public unsafe void PushScope()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NamespaceResolver.NativeMethodInfoPtr_PushScope_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000CE RID: 206 RVA: 0x000063C4 File Offset: 0x000045C4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1238090, RefRangeEnd = 1238094, XrefRangeStart = 1238087, XrefRangeEnd = 1238090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PopScope()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NamespaceResolver.NativeMethodInfoPtr_PopScope_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000CF RID: 207 RVA: 0x000063FC File Offset: 0x000045FC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1238105, RefRangeEnd = 1238106, XrefRangeStart = 1238094, XrefRangeEnd = 1238105, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Add(string prefix, XNamespace ns)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(prefix);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ns);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NamespaceResolver.NativeMethodInfoPtr_Add_Public_Void_String_XNamespace_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x00006458 File Offset: 0x00004658
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1238118, RefRangeEnd = 1238119, XrefRangeStart = 1238106, XrefRangeEnd = 1238118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddFirst(string prefix, XNamespace ns)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(prefix);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ns);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NamespaceResolver.NativeMethodInfoPtr_AddFirst_Public_Void_String_XNamespace_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x000064B4 File Offset: 0x000046B4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1238122, RefRangeEnd = 1238123, XrefRangeStart = 1238119, XrefRangeEnd = 1238122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetPrefixOfNamespace(XNamespace ns, bool allowDefaultNamespace)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ns);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref allowDefaultNamespace;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NamespaceResolver.NativeMethodInfoPtr_GetPrefixOfNamespace_Public_String_XNamespace_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x00002404 File Offset: 0x00000604
		public NamespaceResolver(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x0000240D File Offset: 0x0000060D
		public NamespaceResolver()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NamespaceResolver>.NativeClassPtr))
		{
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x060000D4 RID: 212 RVA: 0x00006510 File Offset: 0x00004710
		// (set) Token: 0x060000D5 RID: 213 RVA: 0x0000241F File Offset: 0x0000061F
		public unsafe int _scope
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NamespaceResolver.NativeFieldInfoPtr__scope);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NamespaceResolver.NativeFieldInfoPtr__scope)) = value;
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060000D6 RID: 214 RVA: 0x00006538 File Offset: 0x00004738
		// (set) Token: 0x060000D7 RID: 215 RVA: 0x0000243A File Offset: 0x0000063A
		public unsafe NamespaceResolver.NamespaceDeclaration _declaration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NamespaceResolver.NativeFieldInfoPtr__declaration);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NamespaceResolver.NamespaceDeclaration>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NamespaceResolver.NativeFieldInfoPtr__declaration), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060000D8 RID: 216 RVA: 0x00006568 File Offset: 0x00004768
		// (set) Token: 0x060000D9 RID: 217 RVA: 0x00002459 File Offset: 0x00000659
		public unsafe NamespaceResolver.NamespaceDeclaration _rover
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NamespaceResolver.NativeFieldInfoPtr__rover);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NamespaceResolver.NamespaceDeclaration>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NamespaceResolver.NativeFieldInfoPtr__rover), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000095 RID: 149
		private static readonly IntPtr NativeFieldInfoPtr__scope;

		// Token: 0x04000096 RID: 150
		private static readonly IntPtr NativeFieldInfoPtr__declaration;

		// Token: 0x04000097 RID: 151
		private static readonly IntPtr NativeFieldInfoPtr__rover;

		// Token: 0x04000098 RID: 152
		private static readonly IntPtr NativeMethodInfoPtr_PushScope_Public_Void_0;

		// Token: 0x04000099 RID: 153
		private static readonly IntPtr NativeMethodInfoPtr_PopScope_Public_Void_0;

		// Token: 0x0400009A RID: 154
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Void_String_XNamespace_0;

		// Token: 0x0400009B RID: 155
		private static readonly IntPtr NativeMethodInfoPtr_AddFirst_Public_Void_String_XNamespace_0;

		// Token: 0x0400009C RID: 156
		private static readonly IntPtr NativeMethodInfoPtr_GetPrefixOfNamespace_Public_String_XNamespace_Boolean_0;

		// Token: 0x02000027 RID: 39
		public class NamespaceDeclaration : Object
		{
			// Token: 0x060001DE RID: 478 RVA: 0x0000A038 File Offset: 0x00008238
			// Note: this type is marked as 'beforefieldinit'.
			static NamespaceDeclaration()
			{
				Il2CppClassPointerStore<NamespaceResolver.NamespaceDeclaration>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NamespaceResolver>.NativeClassPtr, "NamespaceDeclaration");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NamespaceResolver.NamespaceDeclaration>.NativeClassPtr);
				NamespaceResolver.NamespaceDeclaration.NativeFieldInfoPtr_prefix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NamespaceResolver.NamespaceDeclaration>.NativeClassPtr, "prefix");
				NamespaceResolver.NamespaceDeclaration.NativeFieldInfoPtr_ns = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NamespaceResolver.NamespaceDeclaration>.NativeClassPtr, "ns");
				NamespaceResolver.NamespaceDeclaration.NativeFieldInfoPtr_scope = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NamespaceResolver.NamespaceDeclaration>.NativeClassPtr, "scope");
				NamespaceResolver.NamespaceDeclaration.NativeFieldInfoPtr_prev = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NamespaceResolver.NamespaceDeclaration>.NativeClassPtr, "prev");
				NamespaceResolver.NamespaceDeclaration.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NamespaceResolver.NamespaceDeclaration>.NativeClassPtr, 100663463);
			}

			// Token: 0x060001DF RID: 479 RVA: 0x0000A0C8 File Offset: 0x000082C8
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe NamespaceDeclaration()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NamespaceResolver.NamespaceDeclaration>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NamespaceResolver.NamespaceDeclaration.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060001E0 RID: 480 RVA: 0x00002B72 File Offset: 0x00000D72
			public NamespaceDeclaration(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000081 RID: 129
			// (get) Token: 0x060001E1 RID: 481 RVA: 0x0000A104 File Offset: 0x00008304
			// (set) Token: 0x060001E2 RID: 482 RVA: 0x00002B7B File Offset: 0x00000D7B
			public unsafe string prefix
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NamespaceResolver.NamespaceDeclaration.NativeFieldInfoPtr_prefix);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NamespaceResolver.NamespaceDeclaration.NativeFieldInfoPtr_prefix), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000082 RID: 130
			// (get) Token: 0x060001E3 RID: 483 RVA: 0x0000A12C File Offset: 0x0000832C
			// (set) Token: 0x060001E4 RID: 484 RVA: 0x00002B9A File Offset: 0x00000D9A
			public unsafe XNamespace ns
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NamespaceResolver.NamespaceDeclaration.NativeFieldInfoPtr_ns);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<XNamespace>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NamespaceResolver.NamespaceDeclaration.NativeFieldInfoPtr_ns), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000083 RID: 131
			// (get) Token: 0x060001E5 RID: 485 RVA: 0x0000A15C File Offset: 0x0000835C
			// (set) Token: 0x060001E6 RID: 486 RVA: 0x00002BB9 File Offset: 0x00000DB9
			public unsafe int scope
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NamespaceResolver.NamespaceDeclaration.NativeFieldInfoPtr_scope);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NamespaceResolver.NamespaceDeclaration.NativeFieldInfoPtr_scope)) = value;
				}
			}

			// Token: 0x17000084 RID: 132
			// (get) Token: 0x060001E7 RID: 487 RVA: 0x0000A184 File Offset: 0x00008384
			// (set) Token: 0x060001E8 RID: 488 RVA: 0x00002BD4 File Offset: 0x00000DD4
			public unsafe NamespaceResolver.NamespaceDeclaration prev
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NamespaceResolver.NamespaceDeclaration.NativeFieldInfoPtr_prev);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NamespaceResolver.NamespaceDeclaration>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NamespaceResolver.NamespaceDeclaration.NativeFieldInfoPtr_prev), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000154 RID: 340
			private static readonly IntPtr NativeFieldInfoPtr_prefix;

			// Token: 0x04000155 RID: 341
			private static readonly IntPtr NativeFieldInfoPtr_ns;

			// Token: 0x04000156 RID: 342
			private static readonly IntPtr NativeFieldInfoPtr_scope;

			// Token: 0x04000157 RID: 343
			private static readonly IntPtr NativeFieldInfoPtr_prev;

			// Token: 0x04000158 RID: 344
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
