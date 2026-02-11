using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Utils
{
	// Token: 0x02000039 RID: 57
	public static class TypeUtil : Object
	{
		// Token: 0x06000266 RID: 614 RVA: 0x0000E8C4 File Offset: 0x0000CAC4
		// Note: this type is marked as 'beforefieldinit'.
		static TypeUtil()
		{
			Il2CppClassPointerStore<TypeUtil>.NativeClassPtr = IL2CPP.GetIl2CppClass("Utils.dll", "Utils", "TypeUtil");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TypeUtil>.NativeClassPtr);
			TypeUtil.NativeMethodInfoPtr_GetFriendlyTypeName_Public_Static_String_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeUtil>.NativeClassPtr, 100663879);
			TypeUtil.NativeMethodInfoPtr_CleanName_Private_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeUtil>.NativeClassPtr, 100663880);
		}

		// Token: 0x06000267 RID: 615 RVA: 0x0000E91C File Offset: 0x0000CB1C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1184429, RefRangeEnd = 1184430, XrefRangeStart = 1184369, XrefRangeEnd = 1184429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetFriendlyTypeName(Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeUtil.NativeMethodInfoPtr_GetFriendlyTypeName_Public_Static_String_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000268 RID: 616 RVA: 0x0000E958 File Offset: 0x0000CB58
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1184444, RefRangeEnd = 1184445, XrefRangeStart = 1184430, XrefRangeEnd = 1184444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string CleanName(string typeName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(typeName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeUtil.NativeMethodInfoPtr_CleanName_Private_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000269 RID: 617 RVA: 0x00002A7D File Offset: 0x00000C7D
		public TypeUtil(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040001A8 RID: 424
		private static readonly IntPtr NativeMethodInfoPtr_GetFriendlyTypeName_Public_Static_String_Type_0;

		// Token: 0x040001A9 RID: 425
		private static readonly IntPtr NativeMethodInfoPtr_CleanName_Private_Static_String_String_0;

		// Token: 0x020000B7 RID: 183
		[ObfuscatedName("Utils.TypeUtil+<>O")]
		public static class __O : Object
		{
			// Token: 0x060005B0 RID: 1456 RVA: 0x00004469 File Offset: 0x00002669
			// Note: this type is marked as 'beforefieldinit'.
			static __O()
			{
				Il2CppClassPointerStore<TypeUtil.__O>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TypeUtil>.NativeClassPtr, "<>O");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TypeUtil.__O>.NativeClassPtr);
				TypeUtil.__O.NativeFieldInfoPtr__0___GetFriendlyTypeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeUtil.__O>.NativeClassPtr, "<0>__GetFriendlyTypeName");
			}

			// Token: 0x060005B1 RID: 1457 RVA: 0x0000449D File Offset: 0x0000269D
			public __O(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700016B RID: 363
			// (get) Token: 0x060005B2 RID: 1458 RVA: 0x00019F60 File Offset: 0x00018160
			// (set) Token: 0x060005B3 RID: 1459 RVA: 0x000044A6 File Offset: 0x000026A6
			public unsafe static Func<Type, string> _0___GetFriendlyTypeName
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TypeUtil.__O.NativeFieldInfoPtr__0___GetFriendlyTypeName, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Type, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TypeUtil.__O.NativeFieldInfoPtr__0___GetFriendlyTypeName, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040003B6 RID: 950
			private static readonly IntPtr NativeFieldInfoPtr__0___GetFriendlyTypeName;
		}
	}
}
